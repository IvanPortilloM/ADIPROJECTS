using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de Cuentas de Ahorro / IA (BD CA).
    /// Reemplaza al DataSet tipado DsCA de forma incremental (un formulario a la vez).
    /// </summary>
    public class RepositorioCA : RepositorioBase
    {
        public RepositorioCA() : base(Conexion.CA) { }

        // ===== Visores IA =====

        /// <summary>Movimientos de un producto/deducción del asociado (frmDetProducto).</summary>
        public DataTable CargarMovimientosProducto(string cidasociad, string ccoddeducc, string cnumdeducc)
        {
            return ConsultarTabla("dbo.USP_Sel_Cobros_CargarMovimientosProductos_Filter",
                new { CIDASOCIAD = cidasociad, CCODDEDUCC = ccoddeducc, CNUMDEDUCC = cnumdeducc },
                CommandType.StoredProcedure);
        }
    }
}
