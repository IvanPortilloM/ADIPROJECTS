using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using Dapper;

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
            return GuardarCambios(tabla, insert, update, delete, "dbo.IN_TipoOperaciones", "IdTipoOperacion");
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
            return GuardarCambios(tabla, insert, update, delete, "dbo.IN_Bodegas", "IdBodega");
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

        // ===== Reversar transacciones de inventario (INV\Transacciones\frmReversarInventario) =====
        // Requiere la columna IdKardexHeaderOriginal en IN_KardexHeader (script SQL entregado al
        // usuario, patrón ADI_Auditoria §13.c). NULL = transacción normal; con valor = es la reversa
        // de ese IdKardexHeader. Sin FK (igual que el resto del esquema IN_*/OC_*).

        private class HeaderKardex
        {
            public int IdKardexHeader { get; set; }
            public int? IdKardexHeaderOriginal { get; set; }
        }

        private class LineaKardex
        {
            public int IdBodega { get; set; }
            public int IdProducto { get; set; }
            public int? IdVehiculo { get; set; }
            public int IdTipoOperacion { get; set; }
            public decimal Cantidad { get; set; }
            public decimal? PrecioEntrada { get; set; }
            public decimal? PrecioSalida { get; set; }
            public decimal? ISV { get; set; }
        }

        /// <summary>Transacciones del kardex en el rango de fechas, con su Estado (Normal / Reversada /
        /// Reversión de #N) y PuedeReversar (0 si ya es una reversión o si ya fue reversada).</summary>
        public DataTable BuscarTransaccionesKardex(DateTime desde, DateTime hasta)
        {
            const string sql = @"
SELECT h.IdKardexHeader, h.Fecha, h.Usuario, h.Observacion,
       (SELECT COUNT(*) FROM dbo.IN_Kardex k WHERE k.IdKardexHeader = h.IdKardexHeader) AS Lineas,
       CASE WHEN h.IdKardexHeaderOriginal IS NOT NULL THEN 'Reversión de #' + CAST(h.IdKardexHeaderOriginal AS VARCHAR(10))
            WHEN r.IdKardexHeader IS NOT NULL THEN 'Reversada (#' + CAST(r.IdKardexHeader AS VARCHAR(10)) + ')'
            ELSE 'Normal' END AS Estado,
       CASE WHEN h.IdKardexHeaderOriginal IS NOT NULL OR r.IdKardexHeader IS NOT NULL THEN 0 ELSE 1 END AS PuedeReversar
FROM dbo.IN_KardexHeader h
LEFT JOIN dbo.IN_KardexHeader r ON r.IdKardexHeaderOriginal = h.IdKardexHeader
WHERE h.Fecha >= @Desde AND h.Fecha < @Hasta
ORDER BY h.Fecha DESC, h.IdKardexHeader DESC";
            return ConsultarTabla(sql, new { Desde = desde.Date, Hasta = hasta.Date.AddDays(1) });
        }

        /// <summary>Líneas de una transacción, con nombres (producto/bodega/tipo/vehículo) para mostrar
        /// en el visor antes de reversar.</summary>
        public DataTable ObtenerDetalleKardex(int idKardexHeader)
        {
            const string sql = @"
SELECT k.IdKardex, k.IdBodega, k.IdProducto, p.Producto, b.NombreBodega, t.NombreOperacion,
       k.Cantidad, ISNULL(k.PrecioEntrada, k.PrecioSalida) AS Precio, k.ISV, k.Total,
       v.CodVehiculo
FROM dbo.IN_Kardex k
INNER JOIN dbo.OC_Productos p ON p.IdProducto = k.IdProducto
INNER JOIN dbo.IN_Bodegas b ON b.IdBodega = k.IdBodega
INNER JOIN dbo.IN_TipoOperaciones t ON t.IdTipoOperacion = k.IdTipoOperacion
LEFT JOIN dbo.TR_Vehiculos v ON v.IdVehiculo = k.IdVehiculo
WHERE k.IdKardexHeader = @Id
ORDER BY k.IdKardex";
            return ConsultarTabla(sql, new { Id = idKardexHeader });
        }

        /// <summary>Existencia actual (bodega, producto); envuelve el SP escalar existente para el
        /// aviso "quedaría negativa" del visor de reversa (chequeo previo, no bloqueante a nivel de
        /// BD — mismo nivel de rigor que la validación de SALIDA en frmInventario).</summary>
        public decimal ObtenerExistenciaActual(int idBodega, int idProducto)
        {
            object v = ObtenerExistenciaKardex(idBodega, idProducto);
            return v == null || v == DBNull.Value ? 0m : Convert.ToDecimal(v);
        }

        /// <summary>Reversa una transacción del kardex: por cada línea original inserta una compensatoria
        /// de cantidad invertida y tipo opuesto (ENTRADA↔SALIDA, resuelto por NOMBRE — ver gotcha §14.12.a
        /// si el catálogo se renombra), todo en UNA transacción (a diferencia del guardado normal de
        /// frmInventario, que no lo es — §14.12.b). Reutiliza los SPs existentes IN_KardexHeaderInsert e
        /// IN_KardexUpdate (regla del usuario: sin SPs nuevos) y audita cada línea en ADI_Auditoria.
        /// Bloquea reversar una reversión y reversar dos veces la misma transacción. Devuelve el
        /// IdKardexHeader de la reversa generada.</summary>
        public int ReversarTransaccion(int idKardexHeaderOriginal, string motivo, string usuario)
        {
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        HeaderKardex header = con.QueryFirstOrDefault<HeaderKardex>(
                            "SELECT IdKardexHeader, IdKardexHeaderOriginal FROM dbo.IN_KardexHeader WHERE IdKardexHeader = @Id",
                            new { Id = idKardexHeaderOriginal }, trans);
                        if (header == null)
                            throw new InvalidOperationException("La transacción #" + idKardexHeaderOriginal + " ya no existe.");
                        if (header.IdKardexHeaderOriginal != null)
                            throw new InvalidOperationException("La transacción #" + idKardexHeaderOriginal + " ya es una reversión; no se puede reversar una reversión.");

                        int yaReversada = con.ExecuteScalar<int>(
                            "SELECT COUNT(*) FROM dbo.IN_KardexHeader WHERE IdKardexHeaderOriginal = @Id",
                            new { Id = idKardexHeaderOriginal }, trans);
                        if (yaReversada > 0)
                            throw new InvalidOperationException("La transacción #" + idKardexHeaderOriginal + " ya fue reversada anteriormente.");

                        List<LineaKardex> detalle = con.Query<LineaKardex>(
                            "SELECT IdBodega, IdProducto, IdVehiculo, IdTipoOperacion, Cantidad, PrecioEntrada, PrecioSalida, ISV " +
                            "FROM dbo.IN_Kardex WHERE IdKardexHeader = @Id",
                            new { Id = idKardexHeaderOriginal }, trans).AsList();
                        if (detalle.Count == 0)
                            throw new InvalidOperationException("La transacción #" + idKardexHeaderOriginal + " no tiene líneas de detalle.");

                        // Todas las líneas de una transacción comparten el mismo tipo (frmInventario
                        // usa UN combo Tipo de Operación para toda la grilla); basta resolver una vez.
                        int? idTipoOpuesto = con.ExecuteScalar<int?>(
                            "SELECT IdTipoOperacion FROM dbo.IN_TipoOperaciones WHERE NombreOperacion = " +
                            "(CASE (SELECT NombreOperacion FROM dbo.IN_TipoOperaciones WHERE IdTipoOperacion = @Id) " +
                            " WHEN 'SALIDA' THEN 'ENTRADA' ELSE 'SALIDA' END)",
                            new { Id = detalle[0].IdTipoOperacion }, trans);
                        if (idTipoOpuesto == null)
                            throw new InvalidOperationException("No se encontró en IN_TipoOperaciones el tipo opuesto (ENTRADA/SALIDA); revise el catálogo antes de reversar.");

                        DateTime ahora = DateTime.Now;
                        int idKardexHeaderReversa = Convert.ToInt32(con.ExecuteScalar<object>(
                            "dbo.IN_KardexHeaderInsert",
                            new { Fecha = ahora, Observacion = "REVERSA de #" + idKardexHeaderOriginal + " — " + motivo, Usuario = usuario },
                            trans, commandType: CommandType.StoredProcedure));
                        con.Execute("UPDATE dbo.IN_KardexHeader SET IdKardexHeaderOriginal = @Original WHERE IdKardexHeader = @Reversa",
                            new { Original = idKardexHeaderOriginal, Reversa = idKardexHeaderReversa }, trans);

                        foreach (LineaKardex linea in detalle)
                        {
                            con.Execute("dbo.IN_KardexUpdate", new
                            {
                                IdBodega = linea.IdBodega,
                                IdProducto = linea.IdProducto,
                                Cantidad = -linea.Cantidad,
                                IdVehiculo = linea.IdVehiculo.GetValueOrDefault(),
                                IdKardexHeader = idKardexHeaderReversa,
                                IdTipoOperacion = idTipoOpuesto.Value,
                                Fecha = ahora,
                                PrecioEntrada = linea.PrecioEntrada ?? linea.PrecioSalida ?? 0m,
                                // AplicaISV no se guarda como tal en IN_Kardex (solo el monto ISV ya
                                // calculado); se infiere de si la línea original tenía ISV > 0.
                                AplicaISV = linea.ISV.GetValueOrDefault() != 0m
                            }, trans, commandType: CommandType.StoredProcedure);

                            con.Execute(
                                "INSERT INTO dbo.ADI_Auditoria (Usuario, Modulo, Accion, Tabla, IdRegistro, ValorAnterior, ValorNuevo, Detalle) " +
                                "VALUES (@Usuario, 'Inventario', 'Reversar transacción', 'IN_Kardex', @IdRegistro, @ValorAnterior, @ValorNuevo, @Detalle)",
                                new
                                {
                                    Usuario = usuario,
                                    IdRegistro = linea.IdProducto.ToString(CultureInfo.InvariantCulture),
                                    ValorAnterior = linea.Cantidad.ToString(CultureInfo.InvariantCulture),
                                    ValorNuevo = (-linea.Cantidad).ToString(CultureInfo.InvariantCulture),
                                    Detalle = "Reversa de kardex #" + idKardexHeaderOriginal + " -> #" + idKardexHeaderReversa +
                                              " (bodega " + linea.IdBodega + "). Motivo: " + motivo
                                }, trans);
                        }

                        trans.Commit();
                        return idKardexHeaderReversa;
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
