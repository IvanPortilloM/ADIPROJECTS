using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmConfig : ADIGGM.FrmPrincipal
    {
        bool PermitirISV = true, PermitirISR = true, PermitirTarifa = true;
        int ISV = 0, ISR = 0, IdRuta, IdTipoVeh;
        double Tarifa;
        string CtaISV, CtaISR;
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            this.tR_RutasFiltradasTableAdapter.FillByN(this.dsTransporteAdiggm1.TR_RutasFiltradas);
            this.tR_TipoVehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_TipoVehiculos);
            this.tR_ConfiguracionTableAdapter.Fill(this.dsTransporteAdiggm.TR_Configuracion);
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            ISV = Convert.ToInt32(txtISV.Text);
            ISR = Convert.ToInt32(txtISR.Text);
            IdRuta = Convert.ToInt32(cboRuta.SelectedValue);
            IdTipoVeh = Convert.ToInt32(cboTipoVeh.SelectedValue);
            Tarifa = Convert.ToDouble(txtTarifa.Text);
            CtaISV = mskCtaISV.Text;
            CtaISR = mskCtaISR.Text;
            txtTarifa.Text = string.Format("{0:#,##0.00}", txtTarifa.Text);
        }
        public bool ValidarTarifa(int code)
        {
            bool resultado;

            if (code == 46 && txtTarifa.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirTarifa)
            {
                resultado = PermitirTarifa;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        public int ValidarCampos()
        {
            int resultado;

            string ISV = mskCtaISV.Text;
            ISV = ISV.Replace("-", "");

            string ISR = mskCtaISR.Text;
            ISR = ISR.Replace("-", "");

            if (txtISV.Text == string.Empty)
            {
                resultado = 2; //Ingresar ISV
            }
            else if (txtTarifa.Text == string.Empty)
            {
                resultado = 3; //Ingresar Tarifa
            }
            else if (ISV.Length < 13 || ISV.Length == 0)
            {
                resultado = 4; //Ingresar Cuenta Contable ISV
            }
            else if (txtISR.Text == string.Empty)
            {
                resultado = 5; //Ingresar ISR
            }
            else if (ISR.Length < 13 || ISR.Length == 0)
            {
                resultado = 6; //Ingresar Cuenta Contable ISR
            }
            else
            {
                resultado = 1;
            }

            return resultado;
        }

        private void TxtISV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarISV(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }

        private void TxtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarTarifa(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }

        private void txtISR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarISR(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtISV.Text = Convert.ToString(ISV);
            txtISR.Text = Convert.ToString(ISR);
            cboRuta.SelectedValue = IdRuta;
            cboTipoVeh.SelectedValue = IdTipoVeh;
            txtTarifa.Text = Convert.ToString(Tarifa);
            mskCtaISV.Text = CtaISV;
            mskCtaISR.Text = CtaISR;
            txtISV.Enabled = false;
            txtISR.Enabled = false;
            txtTarifa.Enabled = false;
            mskCtaISV.Enabled = false;
            mskCtaISR.Enabled = false;
            cboTipoVeh.Enabled = false;
            cboRuta.Enabled = false;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void TxtTarifa_Leave(object sender, EventArgs e)
        {
            if (txtTarifa.Text == "")
            {
                txtTarifa.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtTarifa.Text = string.Format("{0:#,##0.00}", double.Parse(txtTarifa.Text));
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txtISV.Enabled = true;
            txtISR.Enabled = true;
            txtTarifa.Enabled = true;
            mskCtaISV.Enabled = true;
            mskCtaISR.Enabled = true;
            cboTipoVeh.Enabled = true;
            cboRuta.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int validar = ValidarCampos();

            if(validar == 1)
            {
                try
                {
                    int ISV = 0, ISR = 0, IdRuta, IdTipoVeh;
                    decimal Tarifa;
                    string CtaISV, CtaISR;

                    ISV = Convert.ToInt32(txtISV.Text);
                    ISR = Convert.ToInt32(txtISR.Text);
                    IdRuta = Convert.ToInt32(cboRuta.SelectedValue);
                    IdTipoVeh = Convert.ToInt32(cboTipoVeh.SelectedValue);
                    Tarifa = Convert.ToDecimal(txtTarifa.Text);
                    CtaISV = mskCtaISV.Text;
                    CtaISR = mskCtaISR.Text;

                    Clases.VarGlobales.consultasTrans.PR_ConfigUpdate(ISV, CtaISV, IdTipoVeh, IdRuta, Tarifa, ISR, CtaISR);

                    txtISV.Enabled = false;
                    txtISR.Enabled = false;
                    txtTarifa.Enabled = false;
                    mskCtaISV.Enabled = false;
                    mskCtaISR.Enabled = false;
                    cboTipoVeh.Enabled = false;
                    cboRuta.Enabled = false;
                    btnEditar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;

                    lblFooter.Text = "Datos Guardados Exitosamente";

                    Timer timer1 = new Timer();
                    timer1.Interval = 10000;

                    timer1.Tick += (s, a) => {
                        ((Timer)s).Stop();
                        lblFooter.Text = "";

                    };
                    timer1.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (validar == 2)
            {
                MessageBox.Show("Ingrese un valor en el campo ISV", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISV.Focus();
            }
            else if (validar == 3)
            {
                MessageBox.Show("Ingrese un valor en el campo de Tarifa", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar == 4)
            {
                MessageBox.Show("Ingrese una cuenta contable de ISV válida", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar == 5)
            {
                MessageBox.Show("Ingrese un valor en el campo ISR", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar == 6)
            {
                MessageBox.Show("Ingrese una cuenta contable de ISR válida", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarISV(int code)
        {
            bool resultado;

            if (code == 46 && txtISV.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirISV)
            {
                resultado = PermitirISV;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        public bool ValidarISR(int code)
        {
            bool resultado;

            if (code == 46 && txtISR.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirISR)
            {
                resultado = PermitirISR;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }
    }
}