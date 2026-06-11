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
            this.prmcnumoperac = cnumoperac;
            this.prmcidasociad = cidasociad;
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
