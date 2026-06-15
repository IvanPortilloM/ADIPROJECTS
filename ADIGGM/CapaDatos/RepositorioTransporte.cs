using System.Data;

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
            return GuardarCambios(tabla, insert, update, delete);
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
            return GuardarCambios(tabla, insert, update, delete);
        }
    }
}
