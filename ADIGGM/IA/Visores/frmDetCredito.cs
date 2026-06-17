using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.IA.Visores
{
    public partial class frmDetCredito : FrmPrincipal
    {
        private readonly RepositorioCA _repo = new RepositorioCA();
        string prmcnumoperac, prmcidasociad;

        public frmDetCredito(string cnumoperac, string cidasociad)
        {
            InitializeComponent();
            ConfigurarColumnas();
            this.prmcnumoperac = cnumoperac;
            this.prmcidasociad = cidasociad;
        }

        /// <summary>Columnas de los 4 grids EN CÓDIGO (no en el Designer) para que el diseñador de VS no las
        /// borre — gotcha §11. Visores de solo lectura; el .cs no referencia columnas por Name (solo asigna
        /// DataSource), así que se usan nombres simples = DataPropertyName. Los 3 grids de proyección
        /// (Tránsito/Pendientes/Aplicados) comparten estructura salvo el formato de fechas.</summary>
        private void ConfigurarColumnas()
        {
            ConfigurarGridMovAplic();
            ConfigurarGridProy(dgvProyTransito, "d", "d");
            ConfigurarGridProy(dgvProyPend, null, null);
            ConfigurarGridProy(dgvProyAplic, null, "d");
        }

        private void ConfigurarGridMovAplic()
        {
            dgvMovAplic.AutoGenerateColumns = false;
            dgvMovAplic.Columns.Clear();
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("dfetransac", "dfetransac", "Fecha", format: "d", width: 66));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cnumrecibo", "cnumrecibo", "Recibo", width: 70));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cdetatipab", "cdetatipab", "Tipo.Abono", width: 93));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cdetaOriMov", "cdetaOriMov", "Origen.Mov."));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("nmontotran", "nmontotran", "Total.Pagado", format: "N2", width: 106));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("namorprinc", "namorprinc", "Amortización", format: "N2", width: 101));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("ninterescor", "ninterescor", "Interés", format: "N2", width: 67));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("ninteresmo", "ninteresmo", "Mora", format: "N2", width: 61));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("nmontotros", "nmontotros", "Cargos", format: "N2", width: 70));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("nsaldoactu", "nsaldoactu", "Saldo", format: "N2", width: 63));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("ctipasient", "ctipasient", "Tipo.Asiento", width: 95));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cnumasient", "cnumasient", "Num.Asiento", width: 98));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("ccodigousu", "ccodigousu", "Usuario", width: 71));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cnumoprefu", "cnumoprefu", "Refinanc.", width: 83));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cnumdocume", "cnumdocume", "Factura", width: 74));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("dfepagreal", "dfepagreal", "Fecha.Pago.Real", format: "d", width: 125));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("nmonpoliza", "nmonpoliza", "nmonpoliza", visible: false, width: 96));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cnombreaso", "cnombreaso", "cnombreaso", visible: false, width: 101));
            dgvMovAplic.Columns.Add(Clases.GridColumnas.Texto("cobserva01", "cobserva01", "cobserva01", visible: false, width: 97));
        }

        private void ConfigurarGridProy(DataGridView dgv, string inicioFmt, string corteFmt)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(Clases.GridColumnas.Texto("dfecinicor", "dfecinicor", "Inicio", format: inicioFmt, width: 60));
            dgv.Columns.Add(Clases.GridColumnas.Texto("dfechacort", "dfechacort", "Corte", format: corteFmt, width: 62));
            dgv.Columns.Add(Clases.GridColumnas.Texto("cestatus", "cestatus", "Estatus", width: 69));
            dgv.Columns.Add(Clases.GridColumnas.Texto("ncuota", "ncuota", "Cuota", format: "N2", width: 67));
            dgv.Columns.Add(Clases.GridColumnas.Texto("nmtointere", "nmtointere", "Interés", format: "N2", width: 67));
            dgv.Columns.Add(Clases.GridColumnas.Texto("nmtoamorti", "nmtoamorti", "Amortización", format: "N2", width: 101));
            dgv.Columns.Add(Clases.GridColumnas.Texto("nmtocargos", "nmtocargos", "Cargos", format: "N2", width: 70));
            dgv.Columns.Add(Clases.GridColumnas.Texto("nmtomorato", "nmtomorato", "Mora", format: "N2", width: 61));
            dgv.Columns.Add(Clases.GridColumnas.Texto("ncuotareal", "ncuotareal", "Real", format: "N2", width: 56));
            dgv.Columns.Add(Clases.GridColumnas.Texto("ncuotapaga", "ncuotapaga", "Pagado", format: "N2", width: 77));
            dgv.Columns.Add(Clases.GridColumnas.Texto("nsaldoactu", "nsaldoactu", "Saldo", format: "N2", width: 63));
            dgv.Columns.Add(Clases.GridColumnas.Texto("cidasociad", "cidasociad", "cidasociad", visible: false, width: 94));
        }

        private void frmDetCredito_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> det = _repo.ConsultarDetalleCredito(prmcnumoperac, prmcidasociad);

            txtcnumoperac.Text = det["cnumoperac"];
            txtdfechaform.Text = FormatearFecha(det["dfechaform"]);
            txtnmontoapro.Text = FormatearMonto(det["nmontoapro"]);
            txtnsaldocred.Text = FormatearMonto(det["nsaldocred"]);
            txtnprincapro.Text = FormatearMonto(det["nprincapro"]);
            txtncuotapres.Text = FormatearMonto(det["ncuotapres"]);
            txtntasainter.Text = det["ntasainter"];
            txtninteremor.Text = det["ninteremor"];
            txtnpagosefec.Text = det["npagosefec"];
            txtdfeproxabo.Text = FormatearFecha(det["dfeproxabo"]);
            txtnfrecupago.Text = det["nfrecupago"];
            txtcformapago.Text = det["cformapago"];
            txtdfeculabon.Text = FormatearFecha(det["dfeculabon"]);
            txtdfecalcint.Text = FormatearFecha(det["dfecalcint"]);
            txtctipotrans.Text = det["ctipotrans"];
            txtcnumdocume.Text = det["cnumdocume"];
            txtccodigocat.Text = det["ccodigocat"];
            txtccodigousu.Text = det["ccodigousu"];
            txtctipasient.Text = det["ctipasient"];
            txtcnumasient.Text = det["cnumasient"];
            txtcibloquear.Text = det["cibloquear"];
            txtcnumsolici.Text = det["cnumsolici"];
            txtcdetalleli.Text = det["cdetalleli"];
            txtnpergracia.Text = det["npergracia"];
            txtdfepagreal.Text = FormatearFecha(det["dfepagreal"]);
            txtnnumcuotas.Text = det["nnumcuotas"];
            txtccomentari.Text = det["ccomentari"];
            txtcdetactivi.Text = det["cdetactivi"];
            txtcnumsesion.Text = det["cnumsesion"];

            cargarDgvMovAplic();
            cargarDgvProyTransito();

            int ntransito = dgvProyTransito.RowCount;
            int npagosefec = ParseInt(det["npagosefec"]);
            int nnumcuotas = ParseInt(det["nnumcuotas"]);
            decimal nmontoapro = ParseDecimal(det["nmontoapro"]);
            decimal nsaldocred = ParseDecimal(det["nsaldocred"]);

            txtnpagosrest.Text = npagosefec <= nnumcuotas ? (nnumcuotas - (npagosefec + ntransito)).ToString() : nnumcuotas.ToString();
            // Guard contra división por cero (montos/cuotas en 0 tronaban el visor)
            txtsaldoporc.Text = nmontoapro == 0 ? "0.00" : ((nsaldocred / nmontoapro) * 100).ToString("N2");
            txtplazoporc.Text = nnumcuotas == 0 ? "0.00" : (((decimal)npagosefec / nnumcuotas) * 100).ToString("N2");
            txtdfecproxcr.Text = DateTime.Now.ToString("d");
        }

        private static string FormatearFecha(string valor)
        {
            return DateTime.TryParse(valor, out DateTime fecha) ? fecha.ToString("d") : "";
        }

        private static string FormatearMonto(string valor)
        {
            return ParseDecimal(valor).ToString("N2");
        }

        private static decimal ParseDecimal(string valor)
        {
            return decimal.TryParse(valor, out decimal numero) ? numero : 0m;
        }

        private static int ParseInt(string valor)
        {
            return int.TryParse(valor, out int numero) ? numero : 0;
        }

        private void tbcDgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcDgv.SelectedTab.Name == "tbpMovAplic")
            {
                cargarDgvMovAplic();
            }
            if (tbcDgv.SelectedTab.Name == "tbpProyTransito")
            {
                cargarDgvProyTransito();
            }
            if (tbcDgv.SelectedTab.Name == "tbpProyPend")
            {
                cargarDgvProyPend();
            }
            if (tbcDgv.SelectedTab.Name == "tbpProyAplic")
            {
                cargarDgvProyAplic();
            }
        }

        // Cada tab se carga una sola vez (mismo caché por RowCount que el original).
        // El DataSource del grid se asigna aquí y NO en el Designer (gotcha del diseñador de VS).

        private void cargarDgvMovAplic()
        {
            if (dgvMovAplic.RowCount <= 0)
            {
                try
                {
                    cACreditosDetMovAplicBindingSource.DataMember = "";
                    cACreditosDetMovAplicBindingSource.DataSource = _repo.CargarMovimientosCredito(prmcnumoperac);
                    dgvMovAplic.DataSource = cACreditosDetMovAplicBindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void cargarDgvProyTransito()
        {
            if (dgvProyTransito.RowCount <= 0)
            {
                try
                {
                    uSPSelCobrosConsUsuPlanCredFilterBindingSource.DataMember = "";
                    uSPSelCobrosConsUsuPlanCredFilterBindingSource.DataSource = _repo.CargarPlanCredito(prmcnumoperac, "T");
                    dgvProyTransito.DataSource = uSPSelCobrosConsUsuPlanCredFilterBindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void cargarDgvProyPend()
        {
            if (dgvProyPend.RowCount <= 0)
            {
                try
                {
                    uSPSelCobrosConsUsuPlanCredFilter1BindingSource.DataMember = "";
                    uSPSelCobrosConsUsuPlanCredFilter1BindingSource.DataSource = _repo.CargarPlanCredito(prmcnumoperac, "P");
                    dgvProyPend.DataSource = uSPSelCobrosConsUsuPlanCredFilter1BindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDgvProyAplic()
        {
            if (dgvProyAplic.RowCount <= 0)
            {
                try
                {
                    uSPSelCobrosConsUsuPlanCredFilter2BindingSource.DataMember = "";
                    uSPSelCobrosConsUsuPlanCredFilter2BindingSource.DataSource = _repo.CargarPlanCredito(prmcnumoperac, "A");
                    dgvProyAplic.DataSource = uSPSelCobrosConsUsuPlanCredFilter2BindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }
    }
}
