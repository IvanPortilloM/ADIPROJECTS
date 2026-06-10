using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de Inventario (tablas IN_*). Reemplaza al DataSet tipado
    /// DsInventarioAdiggm de forma incremental (un formulario a la vez).
    /// </summary>
    public class RepositorioInventario : RepositorioBase
    {
        public RepositorioInventario() : base(Conexion.TRANSPORTE) { }

        // ===== IN_TipoOperaciones (mantenimiento de tipos de operación) =====

        public DataTable ListarTiposOperacion()
        {
            const string sql = "SELECT IdTipoOperacion, NombreOperacion FROM dbo.IN_TipoOperaciones";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdTipoOperacion es identity).</summary>
        public int GuardarTiposOperacion(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.IN_TipoOperaciones (NombreOperacion) VALUES (@NombreOperacion)";
            const string update = "UPDATE dbo.IN_TipoOperaciones SET NombreOperacion = @NombreOperacion WHERE IdTipoOperacion = @IdTipoOperacion";
            const string delete = "DELETE FROM dbo.IN_TipoOperaciones WHERE IdTipoOperacion = @IdTipoOperacion";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== IN_Bodegas (mantenimiento de bodegas) =====

        public DataTable ListarBodegas()
        {
            const string sql = "SELECT IdBodega, NombreBodega, Activo FROM dbo.IN_Bodegas";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdBodega es identity).</summary>
        public int GuardarBodegas(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.IN_Bodegas (NombreBodega, Activo) VALUES (@NombreBodega, @Activo)";
            const string update = "UPDATE dbo.IN_Bodegas SET NombreBodega = @NombreBodega, Activo = @Activo WHERE IdBodega = @IdBodega";
            const string delete = "DELETE FROM dbo.IN_Bodegas WHERE IdBodega = @IdBodega";
            return GuardarCambios(tabla, insert, update, delete);
        }
    }
}
