using System;
using System.Data;
using Dapper;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del dominio Órdenes de Compra (OC). Conexión TransporteAdiggm.
    /// Por ahora cubre la solicitud web de orden de compra (DsOCWeb retirado);
    /// crecerá al migrar DsOC.
    /// </summary>
    public class RepositorioOC : RepositorioBase
    {
        public RepositorioOC() : base(Conexion.TRANSPORTE) { }

        /// <summary>Inserta la solicitud web de una orden de compra (SP OCWeb_OrdenCompraInsert).
        /// Devuelve el escalar del SP: 1 = solicitud enviada; otro = ya hay una en proceso.</summary>
        public int InsertarOrdenCompraWeb(int idOC, string correlativo, string tipoOrden, string proveedor,
            DateTime fecha, string accion, string motivo, string usuario)
        {
            return Escalar<int>("dbo.OCWeb_OrdenCompraInsert", new
            {
                IdOC = idOC,
                Correlativo = correlativo,
                TipoOrden = tipoOrden,
                Proveedor = proveedor,
                Fecha = fecha,
                Accion = accion,
                Motivo = motivo,
                Usuario = usuario
            }, CommandType.StoredProcedure);
        }

        // ===== Tipos de documento CxP (OC\Mantenimiento\ManTipoDocumento) =====

        public DataTable ListarTiposDocumento()
        {
            return ConsultarTabla("SELECT IdCxpDocumento, Codigo, TipoDocumento, Activo FROM dbo.CP_TipoDocumentos");
        }

        public int GuardarTiposDocumento(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.CP_TipoDocumentos (Codigo, TipoDocumento, Activo) VALUES (@Codigo, @TipoDocumento, @Activo)",
                "UPDATE dbo.CP_TipoDocumentos SET Codigo=@Codigo, TipoDocumento=@TipoDocumento, Activo=@Activo WHERE IdCxpDocumento=@IdCxpDocumento",
                "DELETE FROM dbo.CP_TipoDocumentos WHERE IdCxpDocumento=@IdCxpDocumento",
                "dbo.CP_TipoDocumentos", "IdCxpDocumento");
        }

        /// <summary>Tipos de documento CxP activos, para el combo de OC\Transacciones\TranAbonar.</summary>
        public DataTable ListarTiposDocumentoActivos()
        {
            return ConsultarTabla("SELECT IdCxpDocumento, Codigo, TipoDocumento, Activo FROM dbo.CP_TipoDocumentos WHERE Activo = 1");
        }

        // ===== Tipos de orden de compra (OC\Mantenimiento\ManTipoOC) =====

        public DataTable ListarTiposOC()
        {
            return ConsultarTabla("SELECT IdTipoOC, Codigo, TipoOC, Activo, Combustible, Materiales, Servicios, Usuario, NombreEquipo FROM dbo.OC_TipoOC");
        }

        public int GuardarTiposOC(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_TipoOC (Codigo, TipoOC, Activo, Combustible, Materiales, Servicios, Usuario, NombreEquipo) VALUES (@Codigo, @TipoOC, @Activo, @Combustible, @Materiales, @Servicios, @Usuario, @NombreEquipo)",
                "UPDATE dbo.OC_TipoOC SET Codigo=@Codigo, TipoOC=@TipoOC, Activo=@Activo, Combustible=@Combustible, Materiales=@Materiales, Servicios=@Servicios, Usuario=@Usuario, NombreEquipo=@NombreEquipo WHERE IdTipoOC=@IdTipoOC",
                "DELETE FROM dbo.OC_TipoOC WHERE IdTipoOC=@IdTipoOC",
                "dbo.OC_TipoOC", "IdTipoOC");
        }

        // ===== Departamentos (OC\Mantenimiento\ManDepartamentos) =====

        public DataTable ListarDepartamentos()
        {
            return ConsultarTabla("SELECT IdDepartamento, CodDepartamento, Departamento, Activo, Usuario, NombreEquipo FROM dbo.OC_Departamentos");
        }

        public int GuardarDepartamentos(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_Departamentos (CodDepartamento, Departamento, Activo, Usuario, NombreEquipo) VALUES (@CodDepartamento, @Departamento, @Activo, @Usuario, @NombreEquipo)",
                "UPDATE dbo.OC_Departamentos SET CodDepartamento=@CodDepartamento, Departamento=@Departamento, Activo=@Activo, Usuario=@Usuario, NombreEquipo=@NombreEquipo WHERE IdDepartamento=@IdDepartamento",
                "DELETE FROM dbo.OC_Departamentos WHERE IdDepartamento=@IdDepartamento",
                "dbo.OC_Departamentos", "IdDepartamento");
        }

        // ===== Categorías de productos OC (OC\Mantenimiento\ManCatProductos) =====

        public DataTable ListarCategoriasProductosOC()
        {
            return ConsultarTabla("SELECT IdCatProducto, Codigo, Categoria, Activo, Usuario, NombreEquipo FROM dbo.OC_ProductosCategorias");
        }

        public int GuardarCategoriasProductosOC(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_ProductosCategorias (Codigo, Categoria, Activo, Usuario, NombreEquipo) VALUES (@Codigo, @Categoria, @Activo, @Usuario, @NombreEquipo)",
                "UPDATE dbo.OC_ProductosCategorias SET Codigo=@Codigo, Categoria=@Categoria, Activo=@Activo, Usuario=@Usuario, NombreEquipo=@NombreEquipo WHERE IdCatProducto=@IdCatProducto",
                "DELETE FROM dbo.OC_ProductosCategorias WHERE IdCatProducto=@IdCatProducto",
                "dbo.OC_ProductosCategorias", "IdCatProducto");
        }

        // ===== Parametrización OC / ISV (OC\Mantenimiento\ManParametrizacion) =====

        public DataTable ListarParametrizacion()
        {
            return ConsultarTabla("SELECT IdParametrizacion, ISV FROM dbo.OC_Parametrizacion");
        }

        public int GuardarParametrizacion(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_Parametrizacion (ISV) VALUES (@ISV)",
                "UPDATE dbo.OC_Parametrizacion SET ISV=@ISV WHERE IdParametrizacion=@IdParametrizacion",
                "DELETE FROM dbo.OC_Parametrizacion WHERE IdParametrizacion=@IdParametrizacion",
                "dbo.OC_Parametrizacion", "IdParametrizacion");
        }

        // ===== Responsables / firmas (OC\Mantenimiento\ManResponsables) =====

        public DataTable ListarResponsables()
        {
            return ConsultarTabla("SELECT IdResponsable, Nombre, UsuarioFirma, Firma, Activo, Usuario, NombreEquipo FROM dbo.OC_Responsables");
        }

        public int GuardarResponsables(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_Responsables (Nombre, UsuarioFirma, Firma, Activo, Usuario, NombreEquipo) VALUES (@Nombre, @UsuarioFirma, @Firma, @Activo, @Usuario, @NombreEquipo)",
                "UPDATE dbo.OC_Responsables SET Nombre=@Nombre, UsuarioFirma=@UsuarioFirma, Firma=@Firma, Activo=@Activo, Usuario=@Usuario, NombreEquipo=@NombreEquipo WHERE IdResponsable=@IdResponsable",
                "DELETE FROM dbo.OC_Responsables WHERE IdResponsable=@IdResponsable",
                "dbo.OC_Responsables", "IdResponsable");
        }

        // ===== Productos (OC\Mantenimiento\ManProductos) =====

        /// <summary>Categorías activas para el combo filtro (FillByActivos del DataSet).</summary>
        public DataTable ListarCategoriasProductosOCActivas()
        {
            return ConsultarTabla("SELECT IdCatProducto, Codigo, Categoria, Activo, Usuario, NombreEquipo FROM dbo.OC_ProductosCategorias WHERE Activo = 1");
        }

        /// <summary>Productos de una categoría filtrados por texto (LIKE). Alimenta el grid editable.</summary>
        public DataTable ListarProductos(int idCategoria, string filtro)
        {
            return ConsultarTabla(
                "SELECT IdProducto, IdCatProducto, CodProducto, Producto, Activo, Usuario, NombreEquipo FROM dbo.OC_Productos WHERE IdCatProducto = @IdCategoria AND Producto LIKE '%' + @Filtro + '%'",
                new { IdCategoria = idCategoria, Filtro = filtro });
        }

        public int GuardarProductos(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_Productos (IdCatProducto, CodProducto, Producto, Activo, Usuario, NombreEquipo) VALUES (@IdCatProducto, @CodProducto, @Producto, @Activo, @Usuario, @NombreEquipo)",
                "UPDATE dbo.OC_Productos SET IdCatProducto=@IdCatProducto, CodProducto=@CodProducto, Producto=@Producto, Activo=@Activo, Usuario=@Usuario, NombreEquipo=@NombreEquipo WHERE IdProducto=@IdProducto",
                "DELETE FROM dbo.OC_Productos WHERE IdProducto=@IdProducto",
                "dbo.OC_Productos", "IdProducto");
        }

        // ===== Proveedores (OC\Mantenimiento\ManProveedores) =====

        /// <summary>Proveedores activos, para combos (p.ej. OC\Transacciones\TranAbonar).</summary>
        public DataTable ListarProveedoresActivos()
        {
            return ConsultarTabla(
                "SELECT IdProveedor, RTN, NombreProveedor, Direccion, Tel, Movil, Representante, Activo, Usuario, NombreEquipo " +
                "FROM dbo.OC_Proveedores WHERE Activo = 1");
        }

        /// <summary>Carga los campos de un proveedor (SP OC_ProveedorObtener con parámetros OUTPUT).</summary>
        public void ObtenerProveedor(int idProveedor, out string rtn, out string nombre, out string direccion,
            out string tel, out string movil, out string representante, out bool activo, out int maxItems,
            out string cuentaCxC, out bool cxc)
        {
            var p = new DynamicParameters();
            p.Add("@IdProveedor", idProveedor);
            p.Add("@RTN", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@Nombre", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@Direccion", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@Tel", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@Movil", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@Representante", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@Activo", dbType: DbType.Boolean, direction: ParameterDirection.InputOutput);
            p.Add("@MaxItems", dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
            p.Add("@CuentaCxC", dbType: DbType.String, direction: ParameterDirection.InputOutput, size: 4000);
            p.Add("@CxC", dbType: DbType.Boolean, direction: ParameterDirection.InputOutput);
            Ejecutar("dbo.OC_ProveedorObtener", p, CommandType.StoredProcedure);
            rtn = p.Get<string>("@RTN");
            nombre = p.Get<string>("@Nombre");
            direccion = p.Get<string>("@Direccion");
            tel = p.Get<string>("@Tel");
            movil = p.Get<string>("@Movil");
            representante = p.Get<string>("@Representante");
            activo = p.Get<bool?>("@Activo") ?? false;
            maxItems = p.Get<int?>("@MaxItems") ?? 0;
            cuentaCxC = p.Get<string>("@CuentaCxC");
            cxc = p.Get<bool?>("@CxC") ?? false;
        }

        /// <summary>Inserta o actualiza un proveedor (SP OC_ProveedorInsertUpdate). IdProveedor=0 inserta.</summary>
        public void GuardarProveedor(int idProveedor, string rtn, string nombre, string direccion, string tel,
            string movil, string representante, bool activo, string usuario, string nombreEquipo, int cantItems,
            string cuentaCxC, bool cxc)
        {
            Ejecutar("dbo.OC_ProveedorInsertUpdate", new
            {
                IdProveedor = idProveedor, RTN = rtn, Nombre = nombre, Direccion = direccion, Tel = tel,
                Movil = movil, Representante = representante, Activo = activo, Usuario = usuario,
                NombreEquipo = nombreEquipo, CantItems = cantItems, CuentaCxC = cuentaCxC, CxC = cxc
            }, CommandType.StoredProcedure);
        }

        /// <summary>CAIs asignados a un proveedor (grid editable del editor de proveedor).</summary>
        public DataTable ListarProveedorCAI(int idProveedor)
        {
            return ConsultarTabla("SELECT IdAsigCAIProv, IdProveedor, CAI, FechaLimite, Activo FROM dbo.OC_Proveedores_CAI WHERE IdProveedor = @IdProveedor",
                new { IdProveedor = idProveedor });
        }

        public int GuardarProveedorCAI(DataTable tabla)
        {
            return GuardarCambios(tabla,
                "INSERT INTO dbo.OC_Proveedores_CAI (IdProveedor, CAI, FechaLimite, Activo) VALUES (@IdProveedor, @CAI, @FechaLimite, @Activo)",
                "UPDATE dbo.OC_Proveedores_CAI SET IdProveedor=@IdProveedor, CAI=@CAI, FechaLimite=@FechaLimite, Activo=@Activo WHERE IdAsigCAIProv=@IdAsigCAIProv",
                "DELETE FROM dbo.OC_Proveedores_CAI WHERE IdAsigCAIProv=@IdAsigCAIProv",
                "dbo.OC_Proveedores_CAI", "IdAsigCAIProv");
        }

        // ===== Asignación de cuentas de gasto a vehículos por categoría (OC\Mantenimiento\ManAsigCuentas) =====
        // Cruza TR_Vehiculos/TR_Contratistas/TR_Motoristas (datos del vehículo) con OC_AsigCuentas (la
        // asignación en sí, dominio OC); ambas tablas viven en TransporteAdiggm, no hay cruce de conexión.

        /// <summary>Vehículos activos YA asignados a la categoría, con su cuenta de gasto; filtro por código.</summary>
        public DataTable ListarVehiculosAsignados(int idCategoria, string filtro)
        {
            DataTable tabla = ConsultarTabla(@"
SELECT TR_Vehiculos.IdVehiculo, TR_Contratistas.Contratista, TR_Vehiculos.Placa, TR_Motoristas.Motorista,
       OC_AsigCuentas.CuentaGasto AS Cuenta, TR_Vehiculos.CodVehiculo
FROM dbo.TR_Vehiculos
INNER JOIN dbo.TR_Contratistas ON TR_Vehiculos.IdContratista = TR_Contratistas.IdContratista
INNER JOIN dbo.TR_Motoristas ON TR_Vehiculos.IdMotorista = TR_Motoristas.IdMotorista
INNER JOIN dbo.OC_AsigCuentas ON TR_Vehiculos.IdVehiculo = OC_AsigCuentas.IdVehiculo
WHERE TR_Vehiculos.Activo = 1 AND OC_AsigCuentas.IdCatProducto = @IdCategoria AND TR_Vehiculos.CodVehiculo LIKE '%' + @Filtro + '%'
ORDER BY TR_Contratistas.Contratista",
                new { IdCategoria = idCategoria, Filtro = filtro });
            tabla.Columns["Cuenta"].ReadOnly = false; // gotcha §11: DataTable.Load marca ReadOnly columnas de GROUP BY
            tabla.Columns["Cuenta"].MaxLength = -1;   // gotcha §11b: hereda el MaxLength real de CuentaGasto; la BD ya valida el largo al guardar
            return tabla;
        }

        /// <summary>Vehículos activos NO asignados aún a la categoría; el filtro busca en Contratista, Placa o Código.</summary>
        public DataTable ListarVehiculosNoAsignados(string filtro, int idCategoria)
        {
            DataTable tabla = ConsultarTabla(@"
SELECT TR_Vehiculos.IdVehiculo, TR_Contratistas.Contratista, TR_Vehiculos.Placa, TR_Motoristas.Motorista,
       '' AS Cuenta, TR_Vehiculos.CodVehiculo
FROM dbo.TR_Vehiculos
INNER JOIN dbo.TR_Contratistas ON TR_Vehiculos.IdContratista = TR_Contratistas.IdContratista
INNER JOIN dbo.TR_Motoristas ON TR_Vehiculos.IdMotorista = TR_Motoristas.IdMotorista
WHERE TR_Vehiculos.Activo = 1
  AND TR_Vehiculos.IdVehiculo NOT IN (SELECT IdVehiculo FROM dbo.OC_AsigCuentas WHERE IdCatProducto = @IdCategoria)
  AND (TR_Contratistas.Contratista LIKE '%' + @Filtro + '%' OR TR_Vehiculos.Placa LIKE '%' + @Filtro + '%' OR TR_Vehiculos.CodVehiculo LIKE '%' + @Filtro + '%')
ORDER BY TR_Contratistas.Contratista",
                new { Filtro = filtro, IdCategoria = idCategoria });
            tabla.Columns["Cuenta"].ReadOnly = false; // gotcha §11: '' AS Cuenta es columna literal/calculada
            // gotcha §11b (hallado 2026-07-10, usuario validando): DataTable.Load infiere el MaxLength
            // del literal '' (longitud 0) -> ArgumentException al escribir CUALQUIER texto en la celda
            // ("El valor infringe el límite de MaxLength"). Se libera igual que el ReadOnly de arriba.
            tabla.Columns["Cuenta"].MaxLength = -1;
            return tabla;
        }

        /// <summary>Inserta (1), actualiza (2) o elimina (3) la cuenta de gasto de un vehículo en una categoría
        /// (SP OC_AsigCuentasOpciones; reemplaza VarGlobales.consultasOC — gotcha §8). Devuelve el escalar del SP sin usar.</summary>
        public int GuardarAsigCuentaOpcion(int idCategoria, int idVehiculo, string cuenta, string usuario, string nombreEquipo, int opcion)
        {
            return Ejecutar("dbo.OC_AsigCuentasOpciones",
                new { IdCatProducto = idCategoria, IdVehiculo = idVehiculo, Cuenta = cuenta, Usuario = usuario, NombreEquipo = nombreEquipo, Opcion = opcion },
                CommandType.StoredProcedure);
        }

        // ===== Abonos a proveedores (OC\Transacciones\TranAbonar) =====

        /// <summary>Facturas pendientes de un proveedor que el monto alcanza a cubrir, con lo ya abonado y la
        /// deuda restante (SP CP_FacturasEncontradas).</summary>
        public DataTable ListarFacturasPorAbonar(int idProveedor, decimal monto)
        {
            return ConsultarTabla("dbo.CP_FacturasEncontradas",
                new { IdProveedor = idProveedor, Monto = monto },
                CommandType.StoredProcedure);
        }

        /// <summary>Genera un abono contra las facturas de un proveedor (SP CP_AbonosInsert; reemplaza
        /// VarGlobales.consultasOC — gotcha §8). Devuelve el escalar del SP sin usar.</summary>
        public int GuardarAbono(int idTipoDocumento, int idProveedor, string numDocumento, DateTime fecha,
            decimal monto, string observacion, string usuario, string nombreEquipo)
        {
            return Ejecutar("dbo.CP_AbonosInsert",
                new { IdTipoDocumento = idTipoDocumento, IdProveedor = idProveedor, NumDocumento = numDocumento,
                      Fecha = fecha, Monto = monto, Observacion = observacion, Usuario = usuario, NombreEquipo = nombreEquipo },
                CommandType.StoredProcedure);
        }

        // ===== Confirmación de órdenes de compra (OC\Transacciones\TranConfirmarOrden) =====

        /// <summary>CAIs ACTIVOS del proveedor de la orden (combo CAI + fecha límite del form).</summary>
        public DataTable ListarCaiProveedorPorOrden(int idOC)
        {
            return ConsultarTabla(
                "SELECT A.Activo, A.CAI, A.FechaLimite, A.IdAsigCAIProv, A.IdProveedor " +
                "FROM dbo.OC_Proveedores_CAI A INNER JOIN dbo.OC_OrdenCompra B ON A.IdProveedor = B.IdProveedor " +
                "WHERE B.IdOC = @IdOC AND A.Activo = 1",
                new { IdOC = idOC });
        }

        /// <summary>Unidades de longitud/recorrido para el odómetro (OC_UnidadCombustible con EsRecorrido).</summary>
        public DataTable ListarUnidadesRecorrido()
        {
            return ConsultarTabla("SELECT IdUnidad, Unidad, Nomenclatura, EsRecorrido FROM dbo.OC_UnidadCombustible WHERE EsRecorrido = 1");
        }

        /// <summary>Vehículos presentes en el detalle de la orden (combo del form y columnas combo de los grids).</summary>
        public DataTable ListarVehiculosDeOrden(int idOC)
        {
            return ConsultarTabla(
                "SELECT IdVehiculo, RTRIM(CodVehiculo + ' - ' + Placa) AS Vehiculo FROM dbo.TR_Vehiculos " +
                "WHERE IdVehiculo IN (SELECT IdVehiculo FROM dbo.OC_OrdenCompraDet WHERE IdOC = @IdOC)",
                new { IdOC = idOC });
        }

        /// <summary>Detalle de la orden (SP OC_OrdenDetObtener; alimenta los DOS grids del form, cada uno
        /// con su propia tabla). El SP devuelve columnas CALCULADAS (CONVERT/CASE: Precio, Aplica, ISV,
        /// Total) que DataTable.Load marca ReadOnly y el form las edita — se liberan todas (gotcha §11).</summary>
        public DataTable ObtenerDetalleOrden(int idOC)
        {
            DataTable tabla = ConsultarTabla("dbo.OC_OrdenDetObtener", new { IdOC = idOC }, CommandType.StoredProcedure);
            foreach (DataColumn col in tabla.Columns) col.ReadOnly = false;
            return tabla;
        }

        /// <summary>Encabezado de la orden (SP OC_OrdenHeaderObtener, 8 parámetros OUTPUT varchar).</summary>
        public void ObtenerEncabezadoOrden(int idOC, out string fecha, out string tipoOC, out string proveedor,
            out string observaciones, out string solicitante, out string odometro, out string proxCambio,
            out string aplicaCambioAceite)
        {
            var p = new DynamicParameters();
            p.Add("@IdOC", idOC);
            p.Add("@Fecha", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 10);
            p.Add("@TipoOC", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 30);
            p.Add("@Proveedor", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 50);
            p.Add("@Observaciones", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 100);
            p.Add("@Solicitante", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 50);
            p.Add("@Odometro", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 50);
            p.Add("@ProxCambio", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 50);
            p.Add("@AplicaCambioAceite", dbType: DbType.AnsiString, direction: ParameterDirection.InputOutput, size: 1);
            Ejecutar("dbo.OC_OrdenHeaderObtener", p, CommandType.StoredProcedure);
            fecha = p.Get<string>("@Fecha");
            tipoOC = p.Get<string>("@TipoOC");
            proveedor = p.Get<string>("@Proveedor");
            observaciones = p.Get<string>("@Observaciones");
            solicitante = p.Get<string>("@Solicitante");
            odometro = p.Get<string>("@Odometro");
            proxCambio = p.Get<string>("@ProxCambio");
            aplicaCambioAceite = p.Get<string>("@AplicaCambioAceite");
        }

        /// <summary>Tipo de la orden (SP OC_TipoOrdenObtener2): 1 = combustible.</summary>
        public int ObtenerTipoOrden(int idOC)
        {
            return Convert.ToInt32(Escalar<object>("dbo.OC_TipoOrdenObtener2", new { IdOC = idOC }, CommandType.StoredProcedure));
        }

        /// <summary>1 si la cantidad confirmada EXCEDE la solicitada; 0 si está bien (SP OC_ValidarCantidad).</summary>
        public int ValidarCantidadConfirmada(int idOC, int idVehiculo, int idProducto, decimal cantidadConf)
        {
            return Convert.ToInt32(Escalar<object>("dbo.OC_ValidarCantidad",
                new { IdOC = idOC, IdVehiculo = idVehiculo, IdProducto = idProducto, CantidadConf = cantidadConf },
                CommandType.StoredProcedure));
        }

        /// <summary>Confirma UNA línea de la orden (SP OC_OrdenCompraUpdate; reemplaza consultasOC — §8).
        /// @IdProducto = producto ORIGINAL de la línea (el WHERE del SP); @IdProductoConf = producto
        /// confirmado (el grid permite sustituirlo).</summary>
        public int ConfirmarLineaOrden(int idOC, string numFactura, string cai, int idVehiculo, int idProductoOriginal,
            decimal cantidad, decimal precio, decimal isv, decimal total, string usuario, string nombreEquipo,
            int idProductoConf, DateTime fechaConfirmacion, decimal odometro, int idUnidad, bool aplicaDesc, decimal descuento)
        {
            return Ejecutar("dbo.OC_OrdenCompraUpdate", new
            {
                IdOC = idOC,
                NumFactura = numFactura,
                CAI = cai,
                IdVehiculo = idVehiculo,
                IdProducto = idProductoOriginal,
                Cantidad = cantidad,
                Precio = precio,
                ISV = isv,
                Total = total,
                Usuario = usuario,
                NombreEquipo = nombreEquipo,
                IdProductoConf = idProductoConf,
                FechaConfirmacion = fechaConfirmacion,
                Odometro = odometro,
                IdUnidad = idUnidad,
                AplicaDesc = aplicaDesc,
                Descuento = descuento
            }, CommandType.StoredProcedure);
        }

        /// <summary>Id del registro de cambio de aceite del vehículo (SP OC_CambioAceiteObtener; 0 = no hay).</summary>
        public int ObtenerCambioAceite(int idVehiculo)
        {
            return Convert.ToInt32(Escalar<object>("dbo.OC_CambioAceiteObtener", new { IdVehiculo = idVehiculo }, CommandType.StoredProcedure));
        }

        /// <summary>Registra fecha/odómetro contra el cambio de aceite programado (SP OC_CambioAceiteDetInsert;
        /// devuelve &gt;0 si hay que programar un cambio nuevo — semántica del SP).</summary>
        public int InsertarCambioAceiteDet(int idCambioAceite, int idOC, DateTime fecha, decimal odometro)
        {
            return Convert.ToInt32(Escalar<object>("dbo.OC_CambioAceiteDetInsert",
                new { IdCambioAceite = idCambioAceite, IdOC = idOC, Fecha = fecha, Odometro = odometro },
                CommandType.StoredProcedure));
        }

        /// <summary>Crea/actualiza el registro de cambio de aceite del vehículo (SP OC_CambioAceiteInsert;
        /// 0 = ya existía uno [reintentar con completar=true], 2 = actualizó el de esta orden).</summary>
        public int InsertarCambioAceite(int idVehiculo, int idOC, DateTime fechaInicio, decimal odometroInicial,
            decimal odometroProxCambio, int idUnidad, string usuario, bool completar, bool verificar)
        {
            return Convert.ToInt32(Escalar<object>("dbo.OC_CambioAceiteInsert", new
            {
                IdVehiculo = idVehiculo,
                IdOC = idOC,
                FechaInicio = fechaInicio,
                OdometroInicial = odometroInicial,
                OdometroProxCambio = odometroProxCambio,
                IdUnidad = idUnidad,
                Usuario = usuario,
                Completar = completar,
                Verificar = verificar
            }, CommandType.StoredProcedure));
        }
    }
}
