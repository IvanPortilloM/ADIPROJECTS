using System;
using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del reporte de horas extras. Devuelve los datos crudos como DataTable
    /// porque el formulario los procesa con LINQ-to-DataTable (cálculo de extras).
    /// El acceso se centraliza vía la fuente única y Dapper (ConsultarTabla).
    /// </summary>
    public class RepositorioReporteHoras : RepositorioBase
    {
        public RepositorioReporteHoras() : base(Conexion.TRANSPORTE) { }

        public DataTable ObtenerDatos(DateTime inicio, DateTime fin, int idMotorista)
        {
            const string sql = @"
        SELECT
            m.Motorista,
            m.IdMotorista,
            m.Identidad,

            ISNULL((
                SELECT TOP 1 hs.SalarioQuincenal
                FROM dbo.TR_HistorialSalarios hs
                WHERE hs.IdMotorista = ra.IdMotorista
                  AND hs.FechaVigencia <= ra.Fecha
                ORDER BY hs.FechaVigencia DESC
            ), m.SalarioQuincenal) AS SalarioQuincenal,

            ISNULL(p.PagaExtrasDiarias, 1) as PagaExtrasDiarias,
            ISNULL(p.PagaDomingos, 1) as PagaDomingos,
            ISNULL(p.PagaFeriados, 1) as PagaFeriados,
            ISNULL(p.AplicaJornadaMixta, 0) as AplicaJornadaMixta,
            ra.Fecha,
            rt.HoraInicio,
            rt.HoraFin,
            CASE WHEN df.Fecha IS NOT NULL THEN 1 ELSE 0 END AS EsFeriado
        FROM dbo.HE_RegistrosAsistencia ra
        INNER JOIN dbo.TR_Motoristas m ON ra.IdMotorista = m.IdMotorista
        LEFT JOIN dbo.HE_PoliticasPago p ON m.PoliticaID = p.PoliticaID
        INNER JOIN dbo.HE_RegistrosTiempos rt ON ra.RegistroAsistenciaID = rt.RegistroAsistenciaID
        LEFT JOIN dbo.HE_DiasFeriados df ON ra.Fecha = df.Fecha
        WHERE ra.Fecha >= @FechaInicio AND ra.Fecha <= @FechaFin
          AND (@IdMotorista = 0 OR ra.IdMotorista = @IdMotorista)
        ORDER BY m.Motorista, ra.Fecha, rt.HoraInicio";

            return ConsultarTabla(sql, new { FechaInicio = inicio, FechaFin = fin, IdMotorista = idMotorista });
        }
    }
}
