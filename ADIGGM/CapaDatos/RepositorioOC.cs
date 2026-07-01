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
                "DELETE FROM dbo.CP_TipoDocumentos WHERE IdCxpDocumento=@IdCxpDocumento");
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
                "DELETE FROM dbo.OC_TipoOC WHERE IdTipoOC=@IdTipoOC");
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
                "DELETE FROM dbo.OC_Departamentos WHERE IdDepartamento=@IdDepartamento");
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
                "DELETE FROM dbo.OC_ProductosCategorias WHERE IdCatProducto=@IdCatProducto");
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
                "DELETE FROM dbo.OC_Parametrizacion WHERE IdParametrizacion=@IdParametrizacion");
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
                "DELETE FROM dbo.OC_Responsables WHERE IdResponsable=@IdResponsable");
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
                "DELETE FROM dbo.OC_Productos WHERE IdProducto=@IdProducto");
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
                "DELETE FROM dbo.OC_Proveedores_CAI WHERE IdAsigCAIProv=@IdAsigCAIProv");
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
    }
}
