using ADIGGM.CapaModelo;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de registros de asistencia (dbo.HE_RegistrosAsistencia, HE_RegistrosTiempos, etc.).
    /// </summary>
    public class RepositorioAsistencias : RepositorioBase
    {
        public RepositorioAsistencias() : base(Conexion.TRANSPORTE) { }

        // ===== Lecturas (frmAsistencias) =====

        /// <summary>
        /// Matriz cruda motorista×día para el grid de asistencia. Se devuelve como DataTable
        /// porque el formulario arma el pivote y los contadores sobre el DataTable.
        /// </summary>
        public DataTable ObtenerAsistencia(DateTime inicio, DateTime fin, bool mostrarInactivos, bool mostrarSubcontratistas, int politicaId)
        {
            const string sql = @"
                SELECT
                    m.IdMotorista,
                    m.Motorista,
                    ra.Fecha,
                    ta.Codigo,
                    ta.RequiereTiempos,
                    (SELECT SUM(DATEDIFF(MINUTE, rt.HoraInicio, rt.HoraFin))/60.0
                     FROM dbo.HE_RegistrosTiempos rt
                     WHERE rt.RegistroAsistenciaID = ra.RegistroAsistenciaID) as HorasCalculadas
                FROM dbo.TR_Motoristas m
                LEFT JOIN dbo.HE_RegistrosAsistencia ra
                    ON m.IdMotorista = ra.IdMotorista
                    AND ra.Fecha BETWEEN @Inicio AND @Fin
                LEFT JOIN dbo.HE_TiposAsistencia ta
                    ON ra.TipoAsistenciaID = ta.TipoAsistenciaID
                WHERE
                    (@MostrarInactivos = 1 OR m.Activo = 1)
                    AND (@MostrarSubs = 1 OR m.EsEmpleado = 1)
                    AND (@PoliticaID = 0 OR m.PoliticaID = @PoliticaID)
                ORDER BY
                    m.Activo DESC, m.EsEmpleado DESC, m.Motorista ASC, ra.Fecha ASC";

            return ConsultarTabla(sql, new
            {
                Inicio = inicio,
                Fin = fin,
                MostrarInactivos = mostrarInactivos,
                MostrarSubs = mostrarSubcontratistas,
                PoliticaID = politicaId
            });
        }

        public List<ObservacionDia> ListarObservaciones(DateTime inicio, DateTime fin)
        {
            const string sql = @"SELECT IdMotorista, Fecha, Observaciones
                                 FROM dbo.HE_RegistrosAsistencia
                                 WHERE Fecha BETWEEN @Inicio AND @Fin
                                   AND Observaciones IS NOT NULL AND LEN(Observaciones) > 0";
            return Consultar<ObservacionDia>(sql, new { Inicio = inicio, Fin = fin });
        }

        // ===== Lecturas (frmEditarAsistencia) =====

        public List<TipoAsistenciaCombo> ListarTiposCombo()
        {
            const string sql = "SELECT TipoAsistenciaID, Codigo + ' - ' + Descripcion AS Texto, RequiereTiempos FROM dbo.HE_TiposAsistencia";
            return Consultar<TipoAsistenciaCombo>(sql);
        }

        public RegistroAsistenciaCab ObtenerRegistro(int idMotorista, DateTime fecha)
        {
            const string sql = "SELECT RegistroAsistenciaID, TipoAsistenciaID, EstaCerrado, Observaciones FROM dbo.HE_RegistrosAsistencia WHERE IdMotorista = @IdMotorista AND Fecha = @Fecha";
            return PrimeroODefault<RegistroAsistenciaCab>(sql, new { IdMotorista = idMotorista, Fecha = fecha });
        }

        public List<TiempoTrabajado> ListarTiempos(int registroAsistenciaID)
        {
            const string sql = "SELECT HoraInicio, HoraFin FROM dbo.HE_RegistrosTiempos WHERE RegistroAsistenciaID = @RegistroID";
            return Consultar<TiempoTrabajado>(sql, new { RegistroID = registroAsistenciaID });
        }

        // ===== Escrituras =====

        /// <summary>Cierra (bloquea) los registros de asistencia del rango. Devuelve filas afectadas.</summary>
        public int CerrarPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            const string sql = @"UPDATE dbo.HE_RegistrosAsistencia
                                 SET EstaCerrado = 1
                                 WHERE Fecha BETWEEN @FechaInicio AND @FechaFin
                                   AND EstaCerrado = 0";
            return Ejecutar(sql, new { FechaInicio = fechaInicio, FechaFin = fechaFin });
        }

        /// <summary>
        /// Guarda (inserta/actualiza) la asistencia para cada combinación de motorista y fecha,
        /// todo dentro de UNA sola transacción (atómico). Devuelve la cantidad de días procesados.
        /// </summary>
        public int GuardarDias(IEnumerable<int> idsMotoristas, IEnumerable<DateTime> fechas, int tipoAsistenciaID,
                               bool requiereTiempos, string observaciones, IList<(TimeSpan Inicio, TimeSpan Fin)> tiempos)
        {
            int contador = 0;
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        foreach (int idMotorista in idsMotoristas)
                        {
                            foreach (DateTime dia in fechas)
                            {
                                GuardarDiaUnico(con, trans, idMotorista, dia, tipoAsistenciaID, requiereTiempos, observaciones, tiempos);
                                contador++;
                            }
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
            return contador;
        }

        private void GuardarDiaUnico(IDbConnection con, IDbTransaction trans, int idMotorista, DateTime dia,
                                     int tipoAsistenciaID, bool requiereTiempos, string observaciones,
                                     IList<(TimeSpan Inicio, TimeSpan Fin)> tiempos)
        {
            // A. ¿Ya existe el día?
            int registroID = con.ExecuteScalar<int?>(
                "SELECT RegistroAsistenciaID FROM dbo.HE_RegistrosAsistencia WHERE IdMotorista = @IdMotorista AND Fecha = @Fecha",
                new { IdMotorista = idMotorista, Fecha = dia.Date }, trans) ?? 0;

            object obs = string.IsNullOrWhiteSpace(observaciones) ? null : observaciones.Trim();

            // B. Insertar o actualizar la cabecera
            if (registroID == 0)
            {
                registroID = Convert.ToInt32(con.ExecuteScalar<decimal>(
                    @"INSERT INTO dbo.HE_RegistrosAsistencia (IdMotorista, Fecha, TipoAsistenciaID, Observaciones)
                      VALUES (@IdMotorista, @Fecha, @TipoAsistenciaID, @Observaciones);
                      SELECT SCOPE_IDENTITY();",
                    new { IdMotorista = idMotorista, Fecha = dia.Date, TipoAsistenciaID = tipoAsistenciaID, Observaciones = obs }, trans));
            }
            else
            {
                con.Execute(
                    @"UPDATE dbo.HE_RegistrosAsistencia
                      SET TipoAsistenciaID = @TipoAsistenciaID, Observaciones = @Observaciones
                      WHERE RegistroAsistenciaID = @RegistroID;",
                    new { TipoAsistenciaID = tipoAsistenciaID, Observaciones = obs, RegistroID = registroID }, trans);
            }

            // C. Limpiar siempre los tiempos antiguos
            con.Execute("DELETE FROM dbo.HE_RegistrosTiempos WHERE RegistroAsistenciaID = @RegistroID",
                new { RegistroID = registroID }, trans);

            // D. Insertar nuevos tiempos (sólo si se requiere)
            if (requiereTiempos && tiempos != null)
            {
                foreach (var t in tiempos)
                {
                    DateTime horaInicio = dia.Date + t.Inicio;
                    DateTime horaFin = dia.Date + t.Fin;
                    if (horaFin <= horaInicio) horaFin = horaFin.AddDays(1);

                    con.Execute(
                        "INSERT INTO dbo.HE_RegistrosTiempos (RegistroAsistenciaID, HoraInicio, HoraFin) VALUES (@RegistroID, @Inicio, @Fin)",
                        new { RegistroID = registroID, Inicio = horaInicio, Fin = horaFin }, trans);
                }
            }
        }
    }
}
