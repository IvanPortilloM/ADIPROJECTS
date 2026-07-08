using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using ADIGGM.CapaModelo;
using Dapper;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de las tablas del dominio TRANSPORTE (base TransporteAdiggm, tablas TR_*).
    /// Reemplaza incrementalmente a los DataSets tipados (DsTransporteAdiggm y las tablas TR_*
    /// que vivían dentro de DsCodeasAdiggm). Se organiza por el dato que maneja, no por el
    /// DataSet de origen.
    /// </summary>
    public class RepositorioTransporte : RepositorioBase
    {
        public RepositorioTransporte() : base(Conexion.TRANSPORTE) { }

        // ===== TR_TipoFacturas (mantenimiento de tipos de factura — Mant\FrmTipoFac) =====

        public DataTable ListarTipoFacturas()
        {
            const string sql = "SELECT IdTipoFactura, TipoFactura, Activo FROM dbo.TR_TipoFacturas";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios de la grilla (IdTipoFactura es identity).</summary>
        public int GuardarTipoFacturas(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.TR_TipoFacturas (TipoFactura, Activo) VALUES (@TipoFactura, @Activo)";
            const string update = "UPDATE dbo.TR_TipoFacturas SET TipoFactura = @TipoFactura, Activo = @Activo WHERE IdTipoFactura = @IdTipoFactura";
            const string delete = "DELETE FROM dbo.TR_TipoFacturas WHERE IdTipoFactura = @IdTipoFactura";
            return GuardarCambios(tabla, insert, update, delete, "dbo.TR_TipoFacturas", "IdTipoFactura");
        }

        // ===== TR_TipoVehiculos =====

        /// <summary>Tipos de vehículo ACTIVOS (combo-columna del grid de asignaciones).</summary>
        public DataTable ListarTipoVehiculosActivos()
        {
            const string sql = "SELECT IdTipoVehiculo, TipoVehiculo FROM dbo.TR_TipoVehiculos WHERE Activo = 1 ORDER BY TipoVehiculo";
            return ConsultarTabla(sql);
        }

        // ===== TR_Clientes =====

        /// <summary>Id/Nombre de clientes (combo-columna del grid de cierres).</summary>
        public DataTable ListarClientes()
        {
            const string sql = "SELECT IdCliente, Cliente FROM dbo.TR_Clientes";
            return ConsultarTabla(sql);
        }

        /// <summary>Clientes ACTIVOS (combo selector).</summary>
        public DataTable ListarClientesActivos()
        {
            const string sql = "SELECT IdCliente, Cliente FROM dbo.TR_Clientes WHERE Activo = 1 ORDER BY Cliente";
            return ConsultarTabla(sql);
        }

        // ===== TR_Cierres =====

        /// <summary>Id/Semana de los cierres (combo-columna del grid de búsqueda de cierres).</summary>
        public DataTable ListarCierres()
        {
            const string sql = "SELECT IdCierre, Semana FROM dbo.TR_Cierres ORDER BY FechaInicio DESC";
            return ConsultarTabla(sql);
        }

        // ===== TR_CierreClientes (cierre de clientes — Mant\FrmCierreCliente, Mant\FrmCierresBuscar) =====

        /// <summary>Cierres CERRADOS no anulados ni sincronizados de un cliente/tipo de factura,
        /// agregados por cierre (SP-equivalente FillByClienteTipoFac — Mant\FrmCierresBuscar).</summary>
        public DataTable ListarCierreClientesPorClienteTipoFac(int idCliente, int idTipoFactura)
        {
            const string sql =
                "SELECT TR_CierreClientes.IdCierre, TR_CierreClientes.IdCliente, TR_Cierres.FechaInicio, TR_Cierres.FechaFin, " +
                "SUM(TR_CierreClientes.SubTotalCierre) AS SubTotalCierre, SUM(TR_CierreClientes.ISVCierre) AS ISVCierre, " +
                "SUM(TR_CierreClientes.TotalCierre) AS TotalCierre, TR_CierreClientes.Cerrado, TR_CierreClientes.Anulado, TR_CierreClientes.SynCodeas " +
                "FROM dbo.TR_CierreClientes INNER JOIN dbo.TR_Cierres ON TR_CierreClientes.IdCierre = TR_Cierres.IdCierre " +
                "WHERE TR_CierreClientes.IdCliente = @IdCliente AND TR_CierreClientes.IdTipoVehiculo IN " +
                "(SELECT IdTipoVehiculo FROM dbo.TR_AsigFacTipoVeh WHERE IdTipoFactura = @IdTipoFactura) " +
                "AND TR_CierreClientes.Cerrado = 1 AND TR_CierreClientes.Anulado = 0 AND TR_CierreClientes.SynCodeas = 0 " +
                "GROUP BY TR_CierreClientes.IdCierre, TR_CierreClientes.IdCliente, TR_Cierres.FechaInicio, TR_Cierres.FechaFin, " +
                "TR_CierreClientes.Cerrado, TR_CierreClientes.Anulado, TR_CierreClientes.SynCodeas " +
                "ORDER BY TR_Cierres.FechaInicio DESC";
            return ConsultarTabla(sql, new { IdCliente = idCliente, IdTipoFactura = idTipoFactura });
        }

        // ===== TR_CierreClientes (cierre de clientes — Mant\FrmCierreCliente) =====

        /// <summary>Filas de cierre de un cierre y tipo de factura (JOIN con TR_AsigFacTipoVeh).</summary>
        public DataTable ListarCierreClientesPorTipoFac(int idCierre, int idTipoFactura)
        {
            const string sql =
                "SELECT TR_CierreClientes.IdCierreCliente, TR_CierreClientes.IdCierre, TR_CierreClientes.IdCliente, " +
                "TR_CierreClientes.IdTipoVehiculo, TR_AsigFacTipoVeh.IdTipoFactura, TR_CierreClientes.SubTotalCierre, " +
                "TR_CierreClientes.ISVCierre, TR_CierreClientes.TotalCierre, TR_CierreClientes.Cerrado, TR_CierreClientes.Anulado, TR_CierreClientes.SynCodeas " +
                "FROM dbo.TR_CierreClientes INNER JOIN dbo.TR_AsigFacTipoVeh ON TR_AsigFacTipoVeh.IdTipoVehiculo = TR_CierreClientes.IdTipoVehiculo " +
                "WHERE TR_CierreClientes.IdCierre = @IdCierre AND TR_AsigFacTipoVeh.IdTipoFactura = @IdTipoFactura " +
                "ORDER BY TR_CierreClientes.IdCliente";
            return ConsultarTabla(sql, new { IdCierre = idCierre, IdTipoFactura = idTipoFactura });
        }

        /// <summary>Cierra todos los viajes del cliente en el cierre (SP PR_CierresClientesCerrar).</summary>
        public int CerrarCierreCliente(int idCierre, int idCliente, int idTipoVeh, string usuario)
        {
            return Ejecutar("dbo.PR_CierresClientesCerrar",
                new { IdCierre = idCierre, IdCliente = idCliente, IdTipoVeh = idTipoVeh, Usuario = usuario }, CommandType.StoredProcedure);
        }

        /// <summary>Reversa el estado de cerrado del cliente (SP PR_CierreClientesReversar).</summary>
        public int ReversarCierreCliente(int idCierre, int idCliente, int idTipoVeh, string usuario)
        {
            return Ejecutar("dbo.PR_CierreClientesReversar",
                new { IdCierre = idCierre, IdCliente = idCliente, IdTipoVeh = idTipoVeh, Usuario = usuario }, CommandType.StoredProcedure);
        }

        /// <summary>Aplica (esISV=true) o borra (false) el ISV de los viajes del rango (SP PR_CierresCAplicaISV).</summary>
        public int AplicarISVCierre(int idCierre, int idCliente, int idTipoVeh, string usuario, bool esISV)
        {
            return Ejecutar("dbo.PR_CierresCAplicaISV",
                new { IdCierre = idCierre, IdCliente = idCliente, IdTipoVeh = idTipoVeh, Usuario = usuario, EsISV = esISV }, CommandType.StoredProcedure);
        }

        // ===== TR_AsigFacTipoVeh (asignación tipo factura <-> tipo vehículo — Mant\FrmAsigTpFacTpVeh) =====

        /// <summary>Asignaciones tipo-factura/tipo-vehículo (tabla hija del grid filtrado por relación).</summary>
        public DataTable ListarAsigFacTipoVeh()
        {
            const string sql = "SELECT IdAsigFacTipoVeh, IdTipoFactura, IdTipoVehiculo FROM dbo.TR_AsigFacTipoVeh";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios de la grilla (IdAsigFacTipoVeh es identity; IdTipoFactura lo hereda la relación).</summary>
        public int GuardarAsigFacTipoVeh(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.TR_AsigFacTipoVeh (IdTipoFactura, IdTipoVehiculo) VALUES (@IdTipoFactura, @IdTipoVehiculo)";
            const string update = "UPDATE dbo.TR_AsigFacTipoVeh SET IdTipoFactura = @IdTipoFactura, IdTipoVehiculo = @IdTipoVehiculo WHERE IdAsigFacTipoVeh = @IdAsigFacTipoVeh";
            const string delete = "DELETE FROM dbo.TR_AsigFacTipoVeh WHERE IdAsigFacTipoVeh = @IdAsigFacTipoVeh";
            return GuardarCambios(tabla, insert, update, delete, "dbo.TR_AsigFacTipoVeh", "IdAsigFacTipoVeh");
        }

        // ===== TR_ClaseTrabajos =====

        /// <summary>Clases de trabajo ACTIVAS (combo selector).</summary>
        public DataTable ListarClaseTrabajosActivos()
        {
            const string sql = "SELECT IdClaseTrabajo, ClaseTrabajo FROM dbo.TR_ClaseTrabajos WHERE Activo = 1 ORDER BY ClaseTrabajo";
            return ConsultarTabla(sql);
        }

        /// <summary>Clases de trabajo activas con la fila sintética "(TODAS)" (Id = 0) al inicio, para
        /// los combos de FrmActualizarTarifas que permiten el cambio de tarifa en lote por clase.</summary>
        public DataTable ListarClaseTrabajosActivosConTodas()
        {
            const string sql = @"SELECT IdClaseTrabajo, ClaseTrabajo FROM (
SELECT 0 AS IdClaseTrabajo, '(TODAS)' AS ClaseTrabajo, 0 AS Orden
UNION ALL
SELECT IdClaseTrabajo, ClaseTrabajo, 1 FROM dbo.TR_ClaseTrabajos WHERE Activo = 1
) t ORDER BY Orden, ClaseTrabajo";
            return ConsultarTabla(sql);
        }

        // ===== Actualización masiva de tarifas por porcentaje (Mant\FrmActualizarTarifas) =====
        // Tres procesos INDEPENDIENTES: tarifas base (TR_AsigRutaTipoVeh), tarifas asignadas
        // (TR_TarifaRutas) y precio en boletas ya digitadas (TR_Viajes). Cada "Aplicar" persiste
        // en UNA transacción (todo-o-nada) y deja registro en TR_AuditoriaTarifas.

        /// <summary>Vista previa de tarifas BASE (TR_AsigRutaTipoVeh): solo filtra por tipo de vehículo
        /// (esta tabla no maneja cliente ni clase de trabajo). La ruta se compone Origen + Destino.</summary>
        public List<FilaTarifa> PreviewTarifasBase(int idTipoVehiculo)
        {
            const string sql =
                "SELECT a.IdAsigRutaTipoVeh AS Id, tv.TipoVehiculo, (r.Origen + ' - ' + r.Destino) AS Ruta, a.Tarifa AS TarifaActual " +
                "FROM dbo.TR_AsigRutaTipoVeh a " +
                "INNER JOIN dbo.TR_TipoVehiculos tv ON tv.IdTipoVehiculo = a.IdTipoVehiculo " +
                "INNER JOIN dbo.TR_Rutas r ON r.IdRuta = a.IdRuta " +
                "WHERE a.IdTipoVehiculo = @IdTipoVehiculo " +
                "ORDER BY r.Origen, r.Destino";
            return Consultar<FilaTarifa>(sql, new { IdTipoVehiculo = idTipoVehiculo });
        }

        /// <summary>Vista previa de tarifas ASIGNADAS (TR_TarifaRutas) filtradas por cliente, clase de
        /// trabajo y tipo de vehículo. idClaseTrabajo = 0 significa "(TODAS)" las clases (cambio en
        /// lote); la previa sale agrupada por clase para que el lote sea revisable. La ruta se
        /// compone Origen + Destino.</summary>
        public List<FilaTarifa> PreviewTarifasAsignadas(int idCliente, int idClaseTrabajo, int idTipoVehiculo)
        {
            const string sql =
                "SELECT t.IdTarifaRuta AS Id, c.Cliente, ct.ClaseTrabajo, tv.TipoVehiculo, (r.Origen + ' - ' + r.Destino) AS Ruta, t.Tarifa AS TarifaActual " +
                "FROM dbo.TR_TarifaRutas t " +
                "INNER JOIN dbo.TR_Clientes c ON c.IdCliente = t.IdCliente " +
                "INNER JOIN dbo.TR_ClaseTrabajos ct ON ct.IdClaseTrabajo = t.IdClaseTrabajo " +
                "INNER JOIN dbo.TR_TipoVehiculos tv ON tv.IdTipoVehiculo = t.IdTipoVehiculo " +
                "INNER JOIN dbo.TR_Rutas r ON r.IdRuta = t.IdRuta " +
                "WHERE t.IdCliente = @IdCliente AND (@IdClaseTrabajo = 0 OR t.IdClaseTrabajo = @IdClaseTrabajo) AND t.IdTipoVehiculo = @IdTipoVehiculo " +
                "ORDER BY ct.ClaseTrabajo, r.Origen, r.Destino";
            return Consultar<FilaTarifa>(sql, new { IdCliente = idCliente, IdClaseTrabajo = idClaseTrabajo, IdTipoVehiculo = idTipoVehiculo });
        }

        /// <summary>Vista previa de boletas (TR_Viajes) en el rango de fechas que coinciden con los filtros,
        /// EXCLUYENDO las anuladas y las que pertenecen a un cierre ya cerrado (TR_CierreClientes.Cerrado).
        /// idClaseTrabajo = 0 significa "(TODAS)" las clases (cambio en lote), agrupado por clase.</summary>
        public List<FilaViaje> PreviewViajes(int idCliente, int idClaseTrabajo, int idTipoVehiculo, System.DateTime fechaInicio, System.DateTime fechaFin)
        {
            const string sql =
                "SELECT v.IdViaje, v.Fecha, v.NumBoleta, c.Cliente, ct.ClaseTrabajo, tv.TipoVehiculo, (r.Origen + ' - ' + r.Destino) AS Ruta, v.Cantidad, " +
                "v.Tarifa AS TarifaActual, v.Subtotal AS SubtotalActual, v.ISV AS IsvActual, v.Total AS TotalActual " +
                "FROM dbo.TR_Viajes v " +
                "INNER JOIN dbo.TR_Clientes c ON c.IdCliente = v.IdCliente " +
                "INNER JOIN dbo.TR_ClaseTrabajos ct ON ct.IdClaseTrabajo = v.IdClaseTrabajo " +
                "INNER JOIN dbo.TR_TipoVehiculos tv ON tv.IdTipoVehiculo = v.IdTipoVeh " +
                "INNER JOIN dbo.TR_Rutas r ON r.IdRuta = v.IdRuta " +
                "WHERE v.IdCliente = @IdCliente AND (@IdClaseTrabajo = 0 OR v.IdClaseTrabajo = @IdClaseTrabajo) AND v.IdTipoVeh = @IdTipoVehiculo " +
                "AND v.Fecha >= @FechaInicio AND v.Fecha <= @FechaFin AND v.Anulado = 0 " +
                "AND NOT EXISTS (SELECT 1 FROM dbo.TR_CierreClientes cc " +
                "                WHERE cc.IdCierre = v.IdCierre AND cc.IdCliente = v.IdCliente " +
                "                AND cc.IdTipoVehiculo = v.IdTipoVeh AND cc.Cerrado = 1 AND cc.Anulado = 0) " +
                "ORDER BY ct.ClaseTrabajo, v.Fecha, v.NumBoleta";
            return Consultar<FilaViaje>(sql, new { IdCliente = idCliente, IdClaseTrabajo = idClaseTrabajo, IdTipoVehiculo = idTipoVehiculo, FechaInicio = fechaInicio, FechaFin = fechaFin });
        }

        // INSERT genérico a la bitácora de auditoría del sistema (ADI_Auditoria, reutilizable en todo el
        // proyecto). Cada cambio = una fila: Accion describe qué pasó, Tabla/IdRegistro identifican el
        // registro, ValorAnterior/ValorNuevo guardan el antes/después y Detalle el contexto (%, filtros…).
        private const string SqlAuditoria =
            "INSERT INTO dbo.ADI_Auditoria (Usuario, Modulo, Accion, Tabla, IdRegistro, ValorAnterior, ValorNuevo, Detalle) " +
            "VALUES (@Usuario, @Modulo, @Accion, @Tabla, @IdRegistro, @ValorAnterior, @ValorNuevo, @Detalle)";

        private static object ParamsAuditoria(string usuario, string proceso, string tabla, int id, decimal valorAnterior, decimal valorNuevo, string detalle)
        {
            System.Globalization.CultureInfo inv = System.Globalization.CultureInfo.InvariantCulture;
            return new
            {
                Usuario = usuario,
                Modulo = "Transporte",
                Accion = "Actualizar tarifa (" + proceso + ")",
                Tabla = tabla,
                IdRegistro = id.ToString(inv),
                ValorAnterior = valorAnterior.ToString(inv),
                ValorNuevo = valorNuevo.ToString(inv),
                Detalle = detalle
            };
        }

        /// <summary>Aplica las tarifas nuevas a TR_AsigRutaTipoVeh (base) en UNA transacción + auditoría.
        /// Solo persiste las filas cuya tarifa realmente cambió. Devuelve cuántas se actualizaron.</summary>
        public int AplicarTarifasBase(IList<FilaTarifa> filas, string usuario, string detalle)
        {
            const string update = "UPDATE dbo.TR_AsigRutaTipoVeh SET Tarifa = @Tarifa WHERE IdAsigRutaTipoVeh = @Id";
            return AplicarTarifasInterno(filas, update, "BASE", "TR_AsigRutaTipoVeh", usuario, detalle);
        }

        /// <summary>Aplica las tarifas nuevas a TR_TarifaRutas (asignadas) en UNA transacción + auditoría.</summary>
        public int AplicarTarifasAsignadas(IList<FilaTarifa> filas, string usuario, string detalle)
        {
            const string update = "UPDATE dbo.TR_TarifaRutas SET Tarifa = @Tarifa WHERE IdTarifaRuta = @Id";
            return AplicarTarifasInterno(filas, update, "ASIGNADA", "TR_TarifaRutas", usuario, detalle);
        }

        private int AplicarTarifasInterno(IList<FilaTarifa> filas, string updateSql, string proceso, string tabla, string usuario, string detalle)
        {
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int n = 0;
                        foreach (FilaTarifa f in filas)
                        {
                            if (f.TarifaNueva == f.TarifaActual) continue; // sin cambio: no tocar ni auditar
                            n += con.Execute(updateSql, new { Tarifa = f.TarifaNueva, Id = f.Id }, trans);
                            con.Execute(SqlAuditoria, ParamsAuditoria(usuario, proceso, tabla, f.Id, f.TarifaActual, f.TarifaNueva, detalle), trans);
                        }
                        trans.Commit();
                        return n;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>Aplica el precio nuevo a las boletas (TR_Viajes), recalculando Subtotal/ISV/Total,
        /// en UNA transacción + auditoría. Solo persiste las filas cuya tarifa cambió.</summary>
        public int AplicarViajes(IList<FilaViaje> filas, string usuario, string detalle)
        {
            const string update = "UPDATE dbo.TR_Viajes SET Tarifa = @Tarifa, Subtotal = @Subtotal, ISV = @ISV, Total = @Total WHERE IdViaje = @Id";
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int n = 0;
                        foreach (FilaViaje f in filas)
                        {
                            if (f.TarifaNueva == f.TarifaActual) continue;
                            n += con.Execute(update, new
                            {
                                Tarifa = f.TarifaNueva,
                                Subtotal = f.SubtotalNuevo,
                                ISV = f.IsvNuevo,
                                Total = f.TotalNuevo,
                                Id = f.IdViaje
                            }, trans);
                            con.Execute(SqlAuditoria, ParamsAuditoria(usuario, "VIAJE", "TR_Viajes", f.IdViaje, f.TarifaActual, f.TarifaNueva, detalle), trans);
                        }
                        trans.Commit();
                        return n;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
