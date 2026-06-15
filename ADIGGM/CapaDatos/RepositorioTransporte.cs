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
