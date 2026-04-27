using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.IA.Visores
{
    public partial class frmDetCredito : FrmPrincipal
    {
        string prmcnumoperac, prmcidasociad;
        public frmDetCredito(string cnumoperac, string cidasociad)
        {
            InitializeComponent();
            this.prmcnumoperac = cnumoperac;
            this.prmcidasociad = cidasociad;
        }

        private void frmDetCredito_Load(object sender, EventArgs e)
        {
            string cnumoperac = "", dfechaform = "", nmontoapro = "", nsaldocred = "", nprincapro = "", 
                   ncuotapres = "", ntasainter = "", ninteremor = "", npagosefec = "", dfeproxabo = "", nfrecupago = "",
                   cformapago = "", dfeculabon = "", dfecalcint = "", ctipotrans = "", cnumdocume = "", ccodigocat = "",
                   ccodigousu = "", ccodigous2 = "", ctipasient = "", cnumasient = "", cibloquear = "", cnumsolici = "",
                   cdetalleli = "", nporcdescu = "", npergracia = "", cdetastatu = "", dfepagreal = "", nnumcuotas = "", 
                   naplcancre = "", cbascancre = "", pendientes = "", transito   = "", ccuotacrec = "", ccomentari = "",
                   cdetactivi = "", dfecultinc = "", cnumsesion = "", dfeprimabo = "";

            Clases.VarGlobales.consultasCA.USP_Sel_Cobros_ConsUsuCredAsoc_Filter(prmcnumoperac, prmcidasociad,
            ref cnumoperac, ref dfechaform, ref nmontoapro, ref nsaldocred, ref nprincapro, ref ncuotapres, ref ntasainter,
            ref ninteremor, ref npagosefec, ref dfeproxabo, ref nfrecupago, ref cformapago, ref dfeculabon, ref dfecalcint,
            ref ctipotrans, ref cnumdocume, ref ccodigocat, ref ccodigousu, ref ccodigous2, ref ctipasient, ref cnumasient,
            ref cibloquear, ref cnumsolici, ref cdetalleli, ref nporcdescu, ref npergracia, ref cdetastatu, ref dfepagreal,
            ref nnumcuotas, ref naplcancre, ref cbascancre, ref pendientes, ref transito,   ref ccuotacrec, ref ccomentari,
            ref cdetactivi, ref dfecultinc, ref cnumsesion, ref dfeprimabo);

            txtcnumoperac.Text = cnumoperac; txtdfechaform.Text = Convert.ToDateTime(dfechaform).ToString("d"); txtnmontoapro.Text = Convert.ToDecimal(nmontoapro).ToString("N2"); 
            txtnsaldocred.Text = Convert.ToDecimal(nsaldocred).ToString("N2"); txtnprincapro.Text = Convert.ToDecimal(nprincapro).ToString("N2"); 
            txtncuotapres.Text = Convert.ToDecimal(ncuotapres).ToString("N2"); txtntasainter.Text = ntasainter; txtninteremor.Text = ninteremor;
            txtnpagosefec.Text = npagosefec; txtdfeproxabo.Text = Convert.ToDateTime(dfeproxabo).ToString("d"); txtnfrecupago.Text = nfrecupago; txtcformapago.Text = cformapago;
            txtdfeculabon.Text = Convert.ToDateTime(dfeculabon).ToString("d"); txtdfecalcint.Text = Convert.ToDateTime(dfecalcint).ToString("d"); txtctipotrans.Text = ctipotrans; txtcnumdocume.Text = cnumdocume;
            txtccodigocat.Text = ccodigocat; txtccodigousu.Text = ccodigousu; txtctipasient.Text = ctipasient; txtcnumasient.Text = cnumasient; 
            txtcibloquear.Text = cibloquear; txtcnumsolici.Text = cnumsolici; txtcdetalleli.Text = cdetalleli; txtnpergracia.Text = npergracia; 
            txtdfepagreal.Text = Convert.ToDateTime(dfepagreal).ToString("d"); txtnnumcuotas.Text = nnumcuotas; txtccomentari.Text = ccomentari; txtcdetactivi.Text = cdetactivi;
            txtcnumsesion.Text = cnumsesion;

            cargarDgvMovAplic();
            cargarDgvProyTransito();

            int ntransito = dgvProyTransito.RowCount;

            txtnpagosrest.Text = Convert.ToInt32(npagosefec) <= Convert.ToInt32(nnumcuotas) ?  Convert.ToInt32((Convert.ToInt32(nnumcuotas) - (Convert.ToInt32(npagosefec)+ntransito))).ToString() : Convert.ToInt32(nnumcuotas).ToString();
            txtsaldoporc.Text = Convert.ToDecimal((Convert.ToDecimal(nsaldocred) / Convert.ToDecimal(nmontoapro)) * 100).ToString("N2");
            txtplazoporc.Text = Convert.ToDecimal((Convert.ToDecimal(npagosefec) / Convert.ToDecimal(nnumcuotas)) * 100).ToString("N2");
            txtdfecproxcr.Text = DateTime.Now.ToString("d");

        }

        private void tbcDgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbcDgv.SelectedTab.Name == "tbpMovAplic")
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

        private void cargarDgvMovAplic()
        {
            if (dgvMovAplic.RowCount <= 0)
            {
                try
                {
                    this.cA_CreditosDetMovAplicTableAdapter.Fill(this.dsCA.CA_CreditosDetMovAplic, prmcnumoperac);
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
                    this.uSP_Sel_Cobros_ConsUsuPlanCred_FilterTableAdapter.Fill(this.dsCA1.USP_Sel_Cobros_ConsUsuPlanCred_Filter, prmcnumoperac, "T", "N");
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
                    this.uSP_Sel_Cobros_ConsUsuPlanCred_Filter1TableAdapter.Fill(this.dsCA1.USP_Sel_Cobros_ConsUsuPlanCred_Filter1, prmcnumoperac, "P", "N");
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
                    this.uSP_Sel_Cobros_ConsUsuPlanCred_Filter2TableAdapter.Fill(this.dsCA1.USP_Sel_Cobros_ConsUsuPlanCred_Filter2, prmcnumoperac, "A", "N");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
        }
    }
}