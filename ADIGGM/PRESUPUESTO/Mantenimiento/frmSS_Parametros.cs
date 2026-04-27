using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    public partial class frmSS_Parametros : Form
    {
        int idPresupuesto = 0;
        public frmSS_Parametros(int idPresupuesto)
        {
            InitializeComponent();
            HabilitarBtn();
            HabilitarTxt();
            this.idPresupuesto = idPresupuesto;
        }
        public void HabilitarBtn()
        {
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        public void HabilitarTxt()
        {
            txtSeguroVida.Enabled = true;
            txtTechoBonoEdc.Enabled = true;
            txtValorBonoEdc.Enabled = true;
            txtInfop.Enabled = true;
            txtRapFosovi.Enabled = true;
            txtTechoRap.Enabled = true;
            txtFondoRetiro.Enabled = true;
            txtTechoIHSS.Enabled = true;
            txtPorcentajeIHSS.Enabled = true;
            txtIncremento.Enabled = true;
            txtFondoAux.Enabled = true;
            txtIncrementoEmpl.Enabled = true;
        }
        public void EditarTxt()
        {
            txtSeguroVida.ReadOnly = false;
            txtTechoBonoEdc.ReadOnly = false;
            txtValorBonoEdc.ReadOnly = false;
            txtInfop.ReadOnly = false;
            txtRapFosovi.ReadOnly = false;
            txtTechoRap.ReadOnly = false;
            txtFondoRetiro.ReadOnly = false;
            txtTechoIHSS.ReadOnly = false;
            txtPorcentajeIHSS.ReadOnly = false;
            txtIncremento.ReadOnly = false;
            txtFondoAux.ReadOnly = false;
            txtIncrementoEmpl.ReadOnly = false;
        }
        public void NoEditarTxt()
        {
            txtSeguroVida.ReadOnly = true;
            txtTechoBonoEdc.ReadOnly = true;
            txtValorBonoEdc.ReadOnly = true;
            txtInfop.ReadOnly = true;
            txtRapFosovi.ReadOnly = true;
            txtTechoRap.ReadOnly = true;
            txtFondoRetiro.ReadOnly = true;
            txtTechoIHSS.ReadOnly = true;
            txtPorcentajeIHSS.ReadOnly = true;
            txtIncremento.ReadOnly = true;
            txtFondoAux.ReadOnly = true;
            txtIncrementoEmpl.ReadOnly = true;
            btnSalir.Focus();
        }

        private void frmSS_Parametros_Load(object sender, EventArgs e)
        {
            string SeguroVida = "", TechoBonoEduc = "", ValorBonoEduc = "", Infop = "", RapFosovi = "", TechoRap = "", FondoRetiro = "", TechoIhss = "", PorcentajeIhss = "", Incremento = "", FondoAuxilio = "", IncrementoEmpl = "";

            Clases.VarGlobales.consultasPR.PR_SSObtenerParametros(idPresupuesto, ref SeguroVida, ref TechoBonoEduc, ref ValorBonoEduc, ref Infop, ref RapFosovi, ref TechoRap, ref FondoRetiro, ref TechoIhss, ref PorcentajeIhss, ref Incremento, ref FondoAuxilio, ref IncrementoEmpl);

            txtSeguroVida.Text = string.Format("{0:#,##0.00}", double.Parse(SeguroVida));
            txtTechoBonoEdc.Text = string.Format("{0:#,##0.00}", double.Parse(TechoBonoEduc));
            txtValorBonoEdc.Text = string.Format("{0:#,##0.00}", double.Parse(ValorBonoEduc));
            txtInfop.Text = string.Format("{0:#,##0.00}", double.Parse(Infop));
            txtRapFosovi.Text = string.Format("{0:#,##0.00}", double.Parse(RapFosovi));
            txtTechoRap.Text = string.Format("{0:#,##0.00}", double.Parse(TechoRap));
            txtFondoRetiro.Text = string.Format("{0:#,##0.00}", double.Parse(FondoRetiro));
            txtTechoIHSS.Text = string.Format("{0:#,##0.00}", double.Parse(TechoIhss));
            txtPorcentajeIHSS.Text = string.Format("{0:#,##0.00}", double.Parse(PorcentajeIhss));
            txtIncremento.Text = string.Format("{0:#,##0.00}", double.Parse(Incremento));
            txtFondoAux.Text = string.Format("{0:#,##0.00}", double.Parse(FondoAuxilio));
            txtIncrementoEmpl.Text = string.Format("{0:#,##0.00}", double.Parse(IncrementoEmpl));
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                Clases.VarGlobales.consultasPR.PR_SSUpdateObtenerParametros(idPresupuesto, Convert.ToDecimal(txtSeguroVida.Text),
                                                                        Convert.ToDecimal(txtTechoBonoEdc.Text), Convert.ToDecimal(txtValorBonoEdc.Text),
                                                                        Convert.ToDecimal(txtInfop.Text), Convert.ToDecimal(txtRapFosovi.Text),
                                                                        Convert.ToDecimal(txtTechoRap.Text), Convert.ToDecimal(txtFondoRetiro.Text),
                                                                        Convert.ToDecimal(txtTechoIHSS.Text), Convert.ToDecimal(txtPorcentajeIHSS.Text),
                                                                        Convert.ToDecimal(txtIncremento.Text), Convert.ToDecimal(txtFondoAux.Text),
                                                                        Convert.ToDecimal(txtIncrementoEmpl.Text));
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                NoEditarTxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarTxt();
            EditarTxt();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NoEditarTxt();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
