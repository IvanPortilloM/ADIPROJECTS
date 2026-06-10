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

        // ===== Transacciones de inventario (kardex) =====

        /// <summary>Categorías visibles en el módulo de inventario (filtro fijo heredado del DataSet).</summary>
        public DataTable ListarCategoriasProductosInv()
        {
            const string sql = @"SELECT IdCatProducto, Codigo, Categoria, Activo, Usuario, NombreEquipo
FROM OC_ProductosCategorias
WHERE IdCatProducto IN (12, 21, 7, 18, 10, 20)
ORDER BY Categoria";
            return ConsultarTabla(sql);
        }

        public DataTable ListarProductosActivosPorCategoria(int idCategoria)
        {
            const string sql = @"SELECT Activo, CodProducto, IdCatProducto, IdProducto, NombreEquipo, Producto, Usuario
FROM OC_Productos
WHERE IdCatProducto = @IdCategoria AND Activo = 1";
            return ConsultarTabla(sql, new { IdCategoria = idCategoria });
        }

        /// <summary>Existencia actual del producto en la bodega (SP escalar; null si no hay kardex).</summary>
        public object ObtenerExistenciaKardex(int idBodega, int idProducto)
        {
            return Escalar<object>("dbo.IN_KardexObtener",
                new { IdBodega = idBodega, IdProducto = idProducto }, CommandType.StoredProcedure);
        }

        public object ObtenerAplicaIsvKardex(int idBodega, int idProducto)
        {
            return Escalar<object>("dbo.IN_KardexISVObtener",
                new { IdBodega = idBodega, IdProducto = idProducto }, CommandType.StoredProcedure);
        }

        /// <summary>Inserta el encabezado del kardex y devuelve su Id.</summary>
        public int InsertarKardexHeader(DateTime fecha, string observacion, string usuario)
        {
            return Convert.ToInt32(Escalar<object>("dbo.IN_KardexHeaderInsert",
                new { Fecha = fecha, Observacion = observacion, Usuario = usuario }, CommandType.StoredProcedure));
        }

        public void ActualizarKardex(int idBodega, int idProducto, decimal cantidad, int idVehiculo,
            int idKardexHeader, int idTipoOperacion, DateTime fecha, decimal precioEntrada, bool aplicaIsv)
        {
            Ejecutar("dbo.IN_KardexUpdate", new
            {
                IdBodega = idBodega,
                IdProducto = idProducto,
                Cantidad = cantidad,
                IdVehiculo = idVehiculo,
                IdKardexHeader = idKardexHeader,
                IdTipoOperacion = idTipoOperacion,
                Fecha = fecha,
                PrecioEntrada = precioEntrada,
                AplicaISV = aplicaIsv
            }, CommandType.StoredProcedure);
        }

        // SPs OC_* que usa el módulo de inventario (se reubicarán al migrar el módulo OC)

        public decimal ObtenerIsvPorcentaje()
        {
            return Convert.ToDecimal(Escalar<object>("dbo.OC_ISVObtener", null, CommandType.StoredProcedure));
        }

        public decimal ObtenerUltimoPrecioCompra(int idProducto)
        {
            return Convert.ToDecimal(Escalar<object>("dbo.OC_UltimoPrecio",
                new { IdProducto = idProducto }, CommandType.StoredProcedure));
        }
    }
}
