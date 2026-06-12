using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de las consultas que vivían en el DataSet tipado DsCodeasAdiggm
    /// (conexión TransporteAdiggm; varias consultas cruzan a covibase con nombre calificado).
    /// Se completa de forma incremental al migrar cada formulario.
    /// </summary>
    public class RepositorioCodeas : RepositorioBase
    {
        public RepositorioCodeas() : base(Conexion.TRANSPORTE) { }

        // ===== Estado de cuenta del asociado (reporte rptASMaestra) =====

        public DataTable CargarASMaestras(string identidad)
        {
            return ConsultarTabla("dbo.COD_SlcASMaestras", new { Identidad = identidad }, CommandType.StoredProcedure);
        }

        public DataTable CargarEstadoCuenta(string identidad)
        {
            return ConsultarTabla("dbo.COD_SlcEstadoCuenta", new { Identidad = identidad }, CommandType.StoredProcedure);
        }

        public DataTable CargarEstadoCuentaDet(string cidasociad)
        {
            return ConsultarTabla("dbo.COD_SlcEstadoCuentaDet", new { cidasociad }, CommandType.StoredProcedure);
        }

        /// <summary>1 si la cuenta contable existe como auxiliar en el catálogo de covibase; 0 si no.</summary>
        public int VerificarCuentaContable(string cuentaContable)
        {
            const string sql = @"SELECT COUNT(ccuentacon) AS Existe
FROM covibase.dbo.cocatalogo
WHERE ccuentacon = @ccuentacon AND cauxiliarc = 'S'";
            return Escalar<int>(sql, new { ccuentacon = cuentaContable });
        }
    }
}
