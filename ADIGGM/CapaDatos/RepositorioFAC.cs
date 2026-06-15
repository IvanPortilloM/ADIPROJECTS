using System;
using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de Facturación (tablas FAC_*). Reemplaza al DataSet tipado
    /// DsFAC de forma incremental (un formulario a la vez).
    /// </summary>
    public class RepositorioFAC : RepositorioBase
    {
        public RepositorioFAC() : base(Conexion.TRANSPORTE) { }

        // ===== FAC_CAI (mantenimiento de CAI / rangos de facturación SAR) =====

        public DataTable ListarCAI()
        {
            const string sql = "SELECT IdCai, Cai, FragmentoSAR, FechaDesde, FechaHasta, NumeroDesde, NumeroHasta, Activo, Anulado, Usuario, NombreEquipo, IdSucursal FROM dbo.FAC_CAI";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdCai es identity).</summary>
        public int GuardarCAI(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_CAI (Cai, FragmentoSAR, FechaDesde, FechaHasta, NumeroDesde, NumeroHasta, Activo, Anulado, Usuario, NombreEquipo, IdSucursal) " +
                                  "VALUES (@Cai, @FragmentoSAR, @FechaDesde, @FechaHasta, @NumeroDesde, @NumeroHasta, @Activo, @Anulado, @Usuario, @NombreEquipo, @IdSucursal)";
            const string update = "UPDATE dbo.FAC_CAI SET Cai = @Cai, FragmentoSAR = @FragmentoSAR, FechaDesde = @FechaDesde, FechaHasta = @FechaHasta, " +
                                  "NumeroDesde = @NumeroDesde, NumeroHasta = @NumeroHasta, Activo = @Activo, Anulado = @Anulado, Usuario = @Usuario, " +
                                  "NombreEquipo = @NombreEquipo, IdSucursal = @IdSucursal WHERE IdCai = @IdCai";
            const string delete = "DELETE FROM dbo.FAC_CAI WHERE IdCai = @IdCai";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== FAC_Productos (mantenimiento de productos de facturación) =====

        public DataTable ListarProductos()
        {
            const string sql = "SELECT IdProducto, CodProducto, NombreProducto, Activo, Descripcion, EsCamion, EsRetro, EsBus, PagaISV, IdTipoEx, AplicaImporte, IdTipoFactura FROM dbo.FAC_Productos";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdProducto es identity).</summary>
        public int GuardarProductos(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_Productos (CodProducto, NombreProducto, Activo, Descripcion, EsCamion, EsRetro, EsBus, PagaISV, IdTipoEx, AplicaImporte, IdTipoFactura) " +
                                  "VALUES (@CodProducto, @NombreProducto, @Activo, @Descripcion, @EsCamion, @EsRetro, @EsBus, @PagaISV, @IdTipoEx, @AplicaImporte, @IdTipoFactura)";
            const string update = "UPDATE dbo.FAC_Productos SET CodProducto = @CodProducto, NombreProducto = @NombreProducto, Activo = @Activo, Descripcion = @Descripcion, " +
                                  "EsCamion = @EsCamion, EsRetro = @EsRetro, EsBus = @EsBus, PagaISV = @PagaISV, IdTipoEx = @IdTipoEx, AplicaImporte = @AplicaImporte, IdTipoFactura = @IdTipoFactura WHERE IdProducto = @IdProducto";
            const string delete = "DELETE FROM dbo.FAC_Productos WHERE IdProducto = @IdProducto";
            return GuardarCambios(tabla, insert, update, delete);
        }

        /// <summary>Combo de tipos de exoneración (FAC_TipoEx) para la columna IdTipoEx del grid de productos.</summary>
        public DataTable ListarTipoEx()
        {
            const string sql = "SELECT IdTipoEx, Tipo, EsExenta FROM dbo.FAC_TipoEx";
            return ConsultarTabla(sql);
        }

        /// <summary>Combo de tipos de factura activos (TR_TipoFacturas) para la columna IdTipoFactura del grid de productos.</summary>
        public DataTable ListarTipoFacturasCombo()
        {
            const string sql = "SELECT IdTipoFactura, TipoFactura FROM dbo.TR_TipoFacturas WHERE ISNULL(Activo, 0) = 1";
            return ConsultarTabla(sql);
        }

        // ===== FAC_TipoFacturas (mantenimiento de tipos de factura) =====

        public DataTable ListarTiposFactura()
        {
            const string sql = "SELECT IdTipoFactura, CodTipoFactura, TipoFactura, Activo, EsTransporte FROM dbo.FAC_TipoFacturas";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdTipoFactura es identity).</summary>
        public int GuardarTiposFactura(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_TipoFacturas (CodTipoFactura, TipoFactura, Activo, EsTransporte) VALUES (@CodTipoFactura, @TipoFactura, @Activo, @EsTransporte)";
            const string update = "UPDATE dbo.FAC_TipoFacturas SET CodTipoFactura = @CodTipoFactura, TipoFactura = @TipoFactura, Activo = @Activo, EsTransporte = @EsTransporte WHERE IdTipoFactura = @IdTipoFactura";
            const string delete = "DELETE FROM dbo.FAC_TipoFacturas WHERE IdTipoFactura = @IdTipoFactura";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== FAC_VisorFacturas (visor maestro-detalle de facturas) =====

        /// <summary>Tipos de factura con fila "Todos" (IdTipoFactura=0) al inicio (combo del visor).</summary>
        public DataTable ListarTipoFacturasConTodos()
        {
            const string sql = "SELECT 0 AS IdTipoFactura, '' AS CodTipoFactura, 'Todos' AS TipoFactura, 0 AS Activo, 0 AS EsTransporte " +
                               "UNION ALL SELECT IdTipoFactura, CodTipoFactura, TipoFactura, Activo, EsTransporte FROM dbo.FAC_TipoFacturas";
            return ConsultarTabla(sql);
        }

        /// <summary>Clientes activos con fila "Todos" (IdCliente=0) al inicio (combo del visor).</summary>
        public DataTable ListarClientesConTodos()
        {
            const string sql = "SELECT 0 AS IdCliente, 'Todos' AS Cliente " +
                               "UNION ALL SELECT IdCliente, Cliente FROM dbo.TR_Clientes WHERE ISNULL(Activo,0)=1";
            return ConsultarTabla(sql);
        }

        /// <summary>Facturas del rango/filtros (SP FAC_FacturasVisor) para el grid maestro.</summary>
        public DataTable ListarFacturasVisor(DateTime desde, DateTime hasta, int idTipoFactura, int idCliente, string filtro)
        {
            return ConsultarTabla("dbo.FAC_FacturasVisor",
                new { Desde = desde, Hasta = hasta, IdTipoFactura = idTipoFactura, IdCliente = idCliente, Filtro = filtro },
                CommandType.StoredProcedure);
        }

        /// <summary>Detalle de una factura (SP FAC_FacturaDetVisor) para el grid de detalle.</summary>
        public DataTable ListarFacturaDetVisor(int idFactura)
        {
            return ConsultarTabla("dbo.FAC_FacturaDetVisor", new { IdFac = idFactura }, CommandType.StoredProcedure);
        }

        /// <summary>Anula una factura (SP FAC_FacturaAnular).</summary>
        public int AnularFactura(int idFactura, string usuario)
        {
            return Ejecutar("dbo.FAC_FacturaAnular", new { IdFactura = idFactura, Usuario = usuario }, CommandType.StoredProcedure);
        }

        // ===== FAC_BusquedaViajes (combos + visor de boletas para facturar) =====

        /// <summary>Tipos de factura de TRANSPORTE activos (combo cboTipoFac).</summary>
        public DataTable ListarTipoFacTransporte()
        {
            const string sql = "SELECT IdTipoFactura, TipoFactura FROM dbo.TR_TipoFacturas WHERE ISNULL(Activo,0)=1 AND ISNULL(EsTransporte,0)=1";
            return ConsultarTabla(sql);
        }

        /// <summary>Productos de transporte de un tipo de factura (combo cboProducto).</summary>
        public DataTable ListarProductosPorTipoFac(int idTipoFactura)
        {
            const string sql = "SELECT IdProducto, CodProducto, NombreProducto, A.Activo, Descripcion, EsCamion, EsRetro, EsBus, PagaISV, IdTipoEx, AplicaImporte, A.IdTipoFactura " +
                               "FROM dbo.FAC_Productos A INNER JOIN dbo.TR_TipoFacturas B ON A.IdTipoFactura=B.IdTipoFactura " +
                               "WHERE ISNULL(B.EsTransporte,0)=1 AND A.IdTipoFactura=@IdTipoFactura";
            return ConsultarTabla(sql, new { IdTipoFactura = idTipoFactura });
        }

        /// <summary>Cierres/calendarización (SP FAC_Cierres) para el combo cboCalendarizacion.</summary>
        public DataTable ListarCierres()
        {
            return ConsultarTabla("dbo.FAC_Cierres", null, CommandType.StoredProcedure);
        }

        /// <summary>Clientes activos filtrados por transporte (combo cboCliente). El flag mapea a TR_Clientes.Trasporte.</summary>
        public DataTable ListarClientesTransporte(bool esTransporte)
        {
            const string sql = "SELECT IdCliente, Cliente FROM dbo.TR_Clientes WHERE ISNULL(Activo,0)=1 AND ISNULL(Trasporte,0)=@EsTransporte";
            return ConsultarTabla(sql, new { EsTransporte = esTransporte });
        }

        /// <summary>Proformas de un cierre y cliente (SP FAC_Proformas) para el combo cboProforma.</summary>
        public DataTable ListarProformas(int idCierre, int idCliente)
        {
            return ConsultarTabla("dbo.FAC_Proformas", new { IdCierre = idCierre, IdCliente = idCliente }, CommandType.StoredProcedure);
        }

        /// <summary>Boletas de viaje a facturar (SP FAC_VisorBoletas) para el grid dgvBoletas.</summary>
        public DataTable ListarVisorBoletas(int idCierre, int idCliente, int idTipoFactura)
        {
            return ConsultarTabla("dbo.FAC_VisorBoletas",
                new { IdCierre = idCierre, IdCliente = idCliente, IdTipoFactura = idTipoFactura }, CommandType.StoredProcedure);
        }

        // ===== FAC_RTN (mantenimiento de clientes/RTN — SAC\frmClientesRTN) =====

        public DataTable ListarRTN()
        {
            const string sql = "SELECT RTN, Empresa, Direccion, Contacto, Telefono FROM dbo.FAC_RTN";
            return ConsultarTabla(sql);
        }

        /// <summary>Filtra clientes por RTN o Empresa (LIKE).</summary>
        public DataTable BuscarRTN(string busqueda)
        {
            const string sql = "SELECT RTN, Empresa, Direccion, Contacto, Telefono FROM dbo.FAC_RTN " +
                               "WHERE (RTN LIKE '%' + @Busqueda + '%') OR (Empresa LIKE '%' + @Busqueda + '%')";
            return ConsultarTabla(sql, new { Busqueda = busqueda });
        }

        /// <summary>Persiste altas/cambios de la grilla. El PK es RTN (string, no identity); por eso
        /// va en el INSERT. Nota: renombrar el RTN de una fila existente no se persiste (el WHERE del
        /// UPDATE usa el valor actual); para "renombrar" hay que borrar y crear.</summary>
        public int GuardarRTN(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_RTN (RTN, Empresa, Direccion, Contacto, Telefono) VALUES (@RTN, @Empresa, @Direccion, @Contacto, @Telefono)";
            const string update = "UPDATE dbo.FAC_RTN SET Empresa = @Empresa, Direccion = @Direccion, Contacto = @Contacto, Telefono = @Telefono WHERE RTN = @RTN";
            const string delete = "DELETE FROM dbo.FAC_RTN WHERE RTN = @RTN";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== FAC_ReporteCierres (combo de fincas/clientes del reporte de cierres) =====

        /// <summary>Fincas/clientes (SP FAC_FincasGGM) para el combo del reporte de cierres.</summary>
        public DataTable ListarFincasGGM()
        {
            return ConsultarTabla("dbo.FAC_FincasGGM", null, CommandType.StoredProcedure);
        }

        // ===== FAC_TipoFacUsuarios (asignación de tipos de factura a usuarios) =====

        /// <summary>Usuarios NO asignados al tipo de factura (SP, filtra por texto de búsqueda).</summary>
        public DataTable ListarUsuariosNoAsignados(string usuario, int idTipoFac)
        {
            return ConsultarTabla("dbo.FAC_TipoFacUsuario_NoAsig",
                new { Usuario = usuario, IdTipoFac = idTipoFac }, CommandType.StoredProcedure);
        }

        /// <summary>Usuarios YA asignados al tipo de factura (SP, filtra por texto de búsqueda).</summary>
        public DataTable ListarUsuariosAsignados(string usuario, int idTipoFac)
        {
            return ConsultarTabla("dbo.FAC_TipoFacUsuario_Asig",
                new { Usuario = usuario, IdTipoFac = idTipoFac }, CommandType.StoredProcedure);
        }

        /// <summary>Asigna (Opcion=1) o quita (Opcion=2) un usuario de un tipo de factura.</summary>
        public int GuardarAsignacionUsuario(int idUsuario, int idTipoFac, int opcion)
        {
            return Ejecutar("dbo.FAC_Asignaciones_INS_UPD",
                new { IdUsuario = idUsuario, IdTipoFac = idTipoFac, Opcion = opcion }, CommandType.StoredProcedure);
        }

        // ===== FAC_TipoMoneda (mantenimiento de tipos de moneda) =====

        public DataTable ListarTiposMoneda()
        {
            const string sql = "SELECT IdTipoMoneda, TipoMoneda, Simbolo, ValorLempiras FROM dbo.FAC_TipoMoneda";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdTipoMoneda es identity).</summary>
        public int GuardarTiposMoneda(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_TipoMoneda (TipoMoneda, Simbolo, ValorLempiras) VALUES (@TipoMoneda, @Simbolo, @ValorLempiras)";
            const string update = "UPDATE dbo.FAC_TipoMoneda SET TipoMoneda = @TipoMoneda, Simbolo = @Simbolo, ValorLempiras = @ValorLempiras WHERE IdTipoMoneda = @IdTipoMoneda";
            const string delete = "DELETE FROM dbo.FAC_TipoMoneda WHERE IdTipoMoneda = @IdTipoMoneda";
            return GuardarCambios(tabla, insert, update, delete);
        }
    }
}
