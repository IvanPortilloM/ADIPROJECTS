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
    }
}
