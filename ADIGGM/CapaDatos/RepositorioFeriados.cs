using ADIGGM.CapaModelo;
using System;
using System.Collections.Generic;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de Días Feriados (dbo.HE_DiasFeriados). La clave es la Fecha.
    /// </summary>
    public class RepositorioFeriados : RepositorioBase
    {
        public RepositorioFeriados() : base(Conexion.TRANSPORTE) { }

        public List<DiaFeriado> Listar()
        {
            const string sql = "SELECT Fecha, Descripcion FROM dbo.HE_DiasFeriados ORDER BY Fecha DESC";
            return Consultar<DiaFeriado>(sql);
        }

        /// <summary>Fechas de feriados dentro de un rango (para marcar el grid de asistencia).</summary>
        public List<DateTime> ListarFechasEntre(DateTime inicio, DateTime fin)
        {
            const string sql = "SELECT Fecha FROM dbo.HE_DiasFeriados WHERE Fecha BETWEEN @Inicio AND @Fin";
            return Consultar<DateTime>(sql, new { Inicio = inicio, Fin = fin });
        }

        public bool ExisteFecha(DateTime fecha)
        {
            const string sql = "SELECT COUNT(*) FROM dbo.HE_DiasFeriados WHERE Fecha = @Fecha";
            return Escalar<int>(sql, new { Fecha = fecha }) > 0;
        }

        public int Insertar(DiaFeriado feriado)
        {
            const string sql = "INSERT INTO dbo.HE_DiasFeriados (Fecha, Descripcion) VALUES (@Fecha, @Descripcion)";
            return Ejecutar(sql, feriado);
        }

        public int Eliminar(DateTime fecha)
        {
            const string sql = "DELETE FROM dbo.HE_DiasFeriados WHERE Fecha = @Fecha";
            return Ejecutar(sql, new { Fecha = fecha });
        }
    }
}
