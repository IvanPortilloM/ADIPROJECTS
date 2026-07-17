using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ADIGGM.CapaModelo;
using Dapper;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de asistencia biométrica administrativa (tablas BIO_*, BD TransporteAdiggm).
    /// Módulo independiente del HE (los marcados son empleados administrativos, no motoristas).
    /// Las marcas se descargan del reloj ZKTeco con <see cref="Clases.ZKTecoLector"/> y se
    /// almacenan en BIO_Marcas (staging con deduplicación: el reloj conserva su log completo).
    /// </summary>
    public class RepositorioBiometrico : RepositorioBase
    {
        public RepositorioBiometrico() : base(Conexion.TRANSPORTE) { }

        // ===== BIO_Empleados (catálogo; PK = número de usuario en el reloj, NO identity) =====

        public DataTable ListarEmpleados()
        {
            return ConsultarTabla("SELECT IdBiometrico, Nombre, Activo FROM dbo.BIO_Empleados ORDER BY IdBiometrico");
        }

        /// <summary>Opción A. IdBiometrico NO es identity (es el número del reloj): SÍ va en el INSERT.
        /// Renombrar el Id de una fila existente no persiste (el WHERE del UPDATE usa el valor actual),
        /// igual que FAC_RTN — para "renombrar" se elimina y se crea.</summary>
        public int GuardarEmpleados(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.BIO_Empleados (IdBiometrico, Nombre, Activo) VALUES (@IdBiometrico, @Nombre, @Activo)",
                "UPDATE dbo.BIO_Empleados SET Nombre=@Nombre, Activo=@Activo WHERE IdBiometrico=@IdBiometrico",
                "DELETE FROM dbo.BIO_Empleados WHERE IdBiometrico=@IdBiometrico",
                "dbo.BIO_Empleados", "IdBiometrico");
        }

        /// <summary>Empleados activos con fila "(TODOS)" (Id=0) para el combo del reporte.</summary>
        public DataTable ListarEmpleadosConTodos()
        {
            const string sql = @"SELECT IdBiometrico, Nombre FROM (
SELECT 0 AS IdBiometrico, '(TODOS)' AS Nombre, 0 AS Orden
UNION ALL
SELECT IdBiometrico, Nombre, 1 FROM dbo.BIO_Empleados WHERE Activo = 1
) t ORDER BY Orden, Nombre";
            return ConsultarTabla(sql);
        }

        // ===== BIO_Marcas (staging de checadas) =====

        /// <summary>Inserta las marcas descargadas del reloj en UNA transacción, deduplicando por
        /// (IdBiometrico, FechaHora) — re-descargar el log completo nunca duplica (el UNIQUE de la
        /// tabla es la red de seguridad; este WHERE NOT EXISTS evita siquiera intentar el choque).
        /// Devuelve cuántas eran nuevas y cuántas ya existían.</summary>
        public (int Nuevas, int Existentes) InsertarMarcas(IList<MarcaBiometrico> marcas, DateTime fechaDescarga)
        {
            const string sql = @"
INSERT INTO dbo.BIO_Marcas (IdBiometrico, FechaHora, ModoVerificacion, FechaDescarga)
SELECT @IdBiometrico, @FechaHora, @ModoVerificacion, @FechaDescarga
WHERE NOT EXISTS (SELECT 1 FROM dbo.BIO_Marcas WHERE IdBiometrico = @IdBiometrico AND FechaHora = @FechaHora)";
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int nuevas = 0;
                        foreach (MarcaBiometrico m in marcas)
                        {
                            nuevas += con.Execute(sql,
                                new { m.IdBiometrico, m.FechaHora, m.ModoVerificacion, FechaDescarga = fechaDescarga },
                                trans);
                        }
                        trans.Commit();
                        return (nuevas, marcas.Count - nuevas);
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>Fecha/hora de la última descarga registrada (null si nunca se ha descargado).</summary>
        public DateTime? UltimaDescarga()
        {
            return Escalar<DateTime?>("SELECT MAX(FechaDescarga) FROM dbo.BIO_Marcas");
        }

        /// <summary>Cuántos números de usuario del reloj tienen marcas pero NO están en BIO_Empleados
        /// (para avisar tras la descarga que falta darlos de alta).</summary>
        public int ContarNoRegistrados()
        {
            return Escalar<int>(
                "SELECT COUNT(DISTINCT m.IdBiometrico) FROM dbo.BIO_Marcas m " +
                "WHERE NOT EXISTS (SELECT 1 FROM dbo.BIO_Empleados e WHERE e.IdBiometrico = m.IdBiometrico)");
        }

        // ===== Reporte =====

        /// <summary>Resumen por empleado/día: primera marca = Entrada, última = Salida, horas entre
        /// ambas y conteo de marcas (el form resalta los días con marcas impares o una sola).
        /// idBiometrico = 0 significa todos. SQL compatible con SQL Server 2008 R2.</summary>
        public DataTable ReporteResumen(DateTime desde, DateTime hasta, int idBiometrico)
        {
            const string sql = @"
SELECT m.IdBiometrico,
       ISNULL(e.Nombre, '(no registrado)') AS Empleado,
       CONVERT(DATE, m.FechaHora) AS Fecha,
       MIN(m.FechaHora) AS Entrada,
       MAX(m.FechaHora) AS Salida,
       CAST(DATEDIFF(MINUTE, MIN(m.FechaHora), MAX(m.FechaHora)) / 60.0 AS DECIMAL(9,2)) AS Horas,
       COUNT(*) AS Marcas
FROM dbo.BIO_Marcas m
LEFT JOIN dbo.BIO_Empleados e ON e.IdBiometrico = m.IdBiometrico
WHERE m.FechaHora >= @Desde AND m.FechaHora < @Hasta
  AND (@IdBiometrico = 0 OR m.IdBiometrico = @IdBiometrico)
GROUP BY m.IdBiometrico, e.Nombre, CONVERT(DATE, m.FechaHora)
ORDER BY Empleado, Fecha";
            return ConsultarTabla(sql,
                new { Desde = desde.Date, Hasta = hasta.Date.AddDays(1), IdBiometrico = idBiometrico });
        }

        /// <summary>Todas las marcas de un empleado en un día (detalle del renglón del resumen).</summary>
        public DataTable DetalleMarcas(int idBiometrico, DateTime fecha)
        {
            const string sql = @"
SELECT m.FechaHora,
       CASE m.ModoVerificacion WHEN 1 THEN 'Huella' WHEN 15 THEN 'Rostro' WHEN 2 THEN 'Tarjeta'
            WHEN 0 THEN 'Contraseña' ELSE 'Otro (' + CAST(m.ModoVerificacion AS VARCHAR(5)) + ')' END AS Verificacion
FROM dbo.BIO_Marcas m
WHERE m.IdBiometrico = @Id AND m.FechaHora >= @Fecha AND m.FechaHora < @FechaFin
ORDER BY m.FechaHora";
            return ConsultarTabla(sql, new { Id = idBiometrico, Fecha = fecha.Date, FechaFin = fecha.Date.AddDays(1) });
        }
    }
}
