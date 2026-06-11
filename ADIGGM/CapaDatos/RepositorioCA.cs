using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;

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

        /// <summary>Movimientos aplicados de un crédito (frmDetCredito).</summary>
        public DataTable CargarMovimientosCredito(string cnumoperac)
        {
            return ConsultarTabla("dbo.CA_CreditosDetMovAplic", new { cnumoperac }, CommandType.StoredProcedure);
        }

        /// <summary>Plan de pagos del crédito filtrado por estado: "T"=tránsito, "P"=pendiente, "A"=aplicado.</summary>
        public DataTable CargarPlanCredito(string cnumoperac, string statusPlan, string usaDevengado = "N")
        {
            return ConsultarTabla("dbo.USP_Sel_Cobros_ConsUsuPlanCred_Filter",
                new { prmCnumoperac = cnumoperac, prmCstatuspla = statusPlan, prmCusaDeveng = usaDevengado },
                CommandType.StoredProcedure);
        }

        // Parámetros OUTPUT (nombre, tamaño) del SP USP_Sel_Cobros_ConsUsuCredAsoc_Filter, en el orden del SP.
        private static readonly KeyValuePair<string, int>[] _salidasDetalleCredito =
        {
            new KeyValuePair<string, int>("cnumoperac", 20), new KeyValuePair<string, int>("dfechaform", 24),
            new KeyValuePair<string, int>("nmontoapro", 12), new KeyValuePair<string, int>("nsaldocred", 12),
            new KeyValuePair<string, int>("nprincapro", 12), new KeyValuePair<string, int>("ncuotapres", 12),
            new KeyValuePair<string, int>("ntasainter", 5), new KeyValuePair<string, int>("ninteremor", 12),
            new KeyValuePair<string, int>("npagosefec", 6), new KeyValuePair<string, int>("dfeproxabo", 10),
            new KeyValuePair<string, int>("nfrecupago", 5), new KeyValuePair<string, int>("cformapago", 5),
            new KeyValuePair<string, int>("dfeculabon", 10), new KeyValuePair<string, int>("dfecalcint", 10),
            new KeyValuePair<string, int>("ctipotrans", 5), new KeyValuePair<string, int>("cnumdocume", 20),
            new KeyValuePair<string, int>("ccodigocat", 20), new KeyValuePair<string, int>("ccodigousu", 15),
            new KeyValuePair<string, int>("ccodigousu2", 15), new KeyValuePair<string, int>("ctipasient", 5),
            new KeyValuePair<string, int>("cnumasient", 15), new KeyValuePair<string, int>("cibloquear", 5),
            new KeyValuePair<string, int>("cnumsolici", 15), new KeyValuePair<string, int>("cdetalleli", 50),
            new KeyValuePair<string, int>("nporcdescu", 12), new KeyValuePair<string, int>("npergracia", 12),
            new KeyValuePair<string, int>("cdetastatu", 15), new KeyValuePair<string, int>("dfepagreal", 10),
            new KeyValuePair<string, int>("nnumcuotas", 6), new KeyValuePair<string, int>("naplcancre", 12),
            new KeyValuePair<string, int>("cbascancre", 5), new KeyValuePair<string, int>("pendientes", 12),
            new KeyValuePair<string, int>("transito", 12), new KeyValuePair<string, int>("ccuotacrec", 6),
            new KeyValuePair<string, int>("ccomentari", 100), new KeyValuePair<string, int>("cdetactivi", 20),
            new KeyValuePair<string, int>("dfecultinc", 24), new KeyValuePair<string, int>("cnumsesion", 20),
            new KeyValuePair<string, int>("dfeprimabo", 10)
        };

        /// <summary>
        /// Encabezado/detalle de un crédito del asociado. El SP devuelve 39 parámetros OUTPUT
        /// (todos nvarchar); se exponen como diccionario nombreParametro -> valor ("" si NULL).
        /// </summary>
        public Dictionary<string, string> ConsultarDetalleCredito(string cnumoperac, string cidasociad)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("prmCnumoperac", cnumoperac);
            p.Add("prmCidasociad", cidasociad);
            foreach (KeyValuePair<string, int> salida in _salidasDetalleCredito)
                p.Add(salida.Key, "", DbType.String, ParameterDirection.InputOutput, salida.Value);

            using (DbConnection con = CrearConexion())
            {
                con.Open();
                con.Execute("dbo.USP_Sel_Cobros_ConsUsuCredAsoc_Filter", p, commandType: CommandType.StoredProcedure);
            }

            Dictionary<string, string> resultado = new Dictionary<string, string>();
            foreach (KeyValuePair<string, int> salida in _salidasDetalleCredito)
                resultado[salida.Key] = p.Get<string>(salida.Key) ?? "";
            return resultado;
        }
    }
}
