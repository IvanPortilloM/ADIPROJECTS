using System;
using System.Data;

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
    }
}
