using System;
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

        // ===== Visor de existencias (combos de filtro + reportes RDLC) =====

        public DataTable ListarVehiculosActivos()
        {
            const string sql = @"SELECT TR_Vehiculos.IdVehiculo, RTRIM(TR_Vehiculos.CodVehiculo + ' - ' + TR_Vehiculos.Placa) AS Vehiculo
FROM TR_Vehiculos INNER JOIN TR_Contratistas ON TR_Vehiculos.IdContratista = TR_Contratistas.IdContratista
WHERE TR_Vehiculos.Activo = 1
ORDER BY TR_Vehiculos.CodVehiculo";
            return ConsultarTabla(sql);
        }

        public DataTable ListarCategoriasProductos()
        {
            const string sql = "SELECT IdCatProducto, Codigo, Categoria, Activo, Usuario, NombreEquipo FROM OC_ProductosCategorias";
            return ConsultarTabla(sql);
        }

        /// <summary>Productos activos con una fila sintética "(TODOS)" (IdProducto = 0) al inicio.</summary>
        public DataTable ListarProductosConTodos()
        {
            const string sql = @"SELECT 1 AS Activo, '000' AS CodProducto, 0 AS IdCatProducto, 0 AS IdProducto, '' AS NombreEquipo, '(TODOS)' AS Producto, '' AS Usuario
UNION ALL
SELECT Activo, CodProducto, IdCatProducto, IdProducto, NombreEquipo, Producto, Usuario
FROM OC_Productos
WHERE Activo = 1
ORDER BY Producto";
            return ConsultarTabla(sql);
        }

        public DataTable ReporteExistencias(int idCatProducto, int idProducto, int idVehiculo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return ConsultarTabla("dbo.IN_R_Existencias",
                new { IdCatProducto = idCatProducto, IdProducto = idProducto, IdVehiculo = idVehiculo, FechaDesde = fechaDesde, FechaHasta = fechaHasta },
                CommandType.StoredProcedure);
        }

        public DataTable ReporteProductosExistencia(int idCatProducto, int idProducto, bool mostrarTodo, DateTime fechaDesde, DateTime fechaHasta)
        {
            return ConsultarTabla("dbo.IN_R_ProductosExistencia",
                new { IdCatProducto = idCatProducto, IdProducto = idProducto, MostrarTodo = mostrarTodo, FechaDesde = fechaDesde, FechaHasta = fechaHasta },
                CommandType.StoredProcedure);
        }
    }
}
