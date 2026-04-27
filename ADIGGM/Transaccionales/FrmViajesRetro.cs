using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

namespace ADIGGM.Transaccionales
{
    public partial class FrmViajesRetro : ADIGGM.FrmPrincipal
    {
        //variables globales
        double ISV = 0;
        DateTime FechaMin = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMinCierre()),
        FechaMax = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMaxCierre());

        //campos usados para editar viajes
        int IdViaje = 0, IdViajeR = 0, IdCliente = 0, IdRetrero = 0, IdFinca = 0, IdLaguna = 0, IdClaseTrabajo = 0, IdTipoVehiculo = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SelectIdRetro()), 
            IdVehiculo = 0, Editar = 0;
        double Tarifa = 0, TISV = 0, SubTotal = 0, Total = 0, HrInicial = 0, HrFinal = 0, HrTrabajadas = 0, HrGPS = 0;
        bool PermitirHrI = true, PermitirHrF = true, PermitirHrGPS = true;
        string Prefijo = "", CodBoleta = "", Observaciones = "", Usuario = Clases.VarGlobales.Usuario;
        DateTime Fecha = DateTime.Now;

        public FrmViajesRetro(int IdViaje, int IdViajeR, string Prefijo, string CodBoleta, DateTime Fecha, int IdCliente, int IdClaseTrabajo,
                            int IdVehiculo, double Tarifa, double TISV, double SubTotal, double Total, string Observaciones, int Editar,
                            int IdRetrero, int IdFinca, int IdLaguna, double HrInicial, double HrFinal, double HrTrabajadas, double HrGPS)
        {
            InitializeComponent();

            this.IdViaje = IdViaje;
            this.IdViajeR = IdViajeR;
            this.Prefijo = Prefijo;
            this.CodBoleta = CodBoleta;
            this.Fecha = Fecha;
            this.IdCliente = IdCliente;
            this.IdClaseTrabajo = IdClaseTrabajo;
            this.IdVehiculo = IdVehiculo;
            this.Tarifa = Tarifa;
            this.TISV = TISV;
            this.SubTotal = SubTotal;
            this.Total = Total;
            this.Observaciones = Observaciones;
            this.Editar = Editar;
            this.IdRetrero = IdRetrero;
            this.IdFinca = IdFinca;
            this.IdLaguna = IdLaguna;
            this.HrInicial = HrInicial;
            this.HrFinal = HrFinal;
            this.HrTrabajadas = HrTrabajadas;
            this.HrGPS = HrGPS;
        }

        private void FrmViajesRetro_Load(object sender, EventArgs e)
        {
            this.tR_PrefijosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Prefijos);
            CargarClientes();
            dtpFecMaxCierre.Value = FechaMax;

            if(Editar == 0)
            {
                cboPrefijos.SelectedValue = 4;
                mskFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                cboClientes.SelectedIndex = -1;
                CargarVeh();
                cboCodMaq.SelectedIndex = -1;
                Tarifa = Convert.ToDouble(Clases.VarGlobales.consultasTrans.TR_SelectTarifaRetro());
                txtHrInicial.Text = $"{0:n}";
                txtHrFinal.Text = $"{0:n}";
                txtHrTrabajadas.Text = $"{0:n}";
                txtHrGPS.Text = $"{0:n}";
                txtHrGPS.Enabled = false;
                txtISV.Text = $"{0:0%}";
                txtTarifa.Text = $"{Tarifa:n}";
                this.cboPrefijos.Focus();
            }
            else if (Editar == 1)
            {
                int index = cboPrefijos.FindString(Prefijo);
                cboPrefijos.SelectedIndex = index;
                mskNumBoleta.Text = CodBoleta;
                mskFecha.Text = Fecha.ToString("dd/MM/yyyy");
                cboClientes.SelectedValue = IdCliente;
                cboClaseTrabajos.SelectedValue = IdClaseTrabajo;
                CargarVeh();
                CargarMotoristas();
                cboCodMaq.SelectedValue = IdVehiculo;
                cboRetrero.SelectedValue = IdRetrero;
                cboFincas.SelectedValue = IdFinca;
                cboLagunas.SelectedValue = IdLaguna;
                txtTarifa.Text = $"{Tarifa:n}";
                txtHrInicial.Text = $"{HrInicial:n}";
                txtHrFinal.Text = $"{HrFinal:n}";
                txtHrTrabajadas.Text = $"{HrTrabajadas:n}";
                txtHrGPS.Text = $"{HrGPS:n}";
                txtHrGPS.Enabled = true;
                txtISV.Text = $"{(TISV / SubTotal):0%}";
                txtTISV.Text = $"{TISV:n}";
                txtSubtotal.Text = $"{SubTotal:n}";
                txtTotal.Text = $"{Total:n}";
                txtObservaciones.Text = Observaciones;
            }
        }

        public void Calcular()
        {
            try
            {
                double HrTrabajadas, TotalISV, SubTotal, Total;

                if (txtHrInicial.Text != "" && txtHrFinal.Text != "" && txtTarifa.Text != "")
                {
                    HrTrabajadas = Convert.ToDouble(txtHrFinal.Text) - Convert.ToDouble(txtHrInicial.Text);
                    SubTotal = HrTrabajadas * Convert.ToDouble(txtTarifa.Text);
                    TotalISV = SubTotal * (ISV / 100);
                    Total = SubTotal + TotalISV;

                    txtHrTrabajadas.Text = $"{HrTrabajadas:n}";
                    txtHrGPS.Text = $"{HrTrabajadas:n}";
                    txtTISV.Text = $"{TotalISV:n}";
                    txtSubtotal.Text = $"{SubTotal:n}";
                    txtTotal.Text = $"{Total:n}";
                }
                else if (txtHrInicial.Text != "" || txtHrFinal.Text != "" || txtTarifa.Text == "")
                {
                    txtHrTrabajadas.Text = $"{0:n}";
                    txtHrGPS.Text = $"{0:n}";
                    txtTISV.Text = $"{0:n}";
                    txtSubtotal.Text = $"{0:n}";
                    txtTotal.Text = $"{0:n}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CalcularGPS()
        {
            try
            {
                double HrGPS, HrTrabajadas, TotalISV, SubTotal, Total;

                if (txtHrInicial.Text != "" && txtHrFinal.Text != "" && txtTarifa.Text != "")
                {
                    HrTrabajadas = Convert.ToDouble(txtHrFinal.Text) - Convert.ToDouble(txtHrInicial.Text);
                    HrGPS = Convert.ToDouble(txtHrGPS.Text);
                    SubTotal = HrGPS * Convert.ToDouble(txtTarifa.Text);
                    TotalISV = SubTotal * (ISV / 100);
                    Total = SubTotal + TotalISV;

                    txtHrTrabajadas.Text = $"{HrTrabajadas:n}";
                    txtTISV.Text = $"{TotalISV:n}";
                    txtSubtotal.Text = $"{SubTotal:n}";
                    txtTotal.Text = $"{Total:n}";
                }
                else if (txtHrInicial.Text != "" || txtHrFinal.Text != "" || txtTarifa.Text == "")
                {
                    txtHrTrabajadas.Text = $"{0:n}";
                    txtHrGPS.Text = $"{0:n}";
                    txtTISV.Text = $"{0:n}";
                    txtSubtotal.Text = $"{0:n}";
                    txtTotal.Text = $"{0:n}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mskNumBoleta_Validating(object sender, CancelEventArgs e)
        {
            int existe;

            if (string.IsNullOrEmpty(mskNumBoleta.Text))
            {
                MessageBox.Show("Ingrese un valor", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (mskNumBoleta.Text.Trim().Length < 6)
            {
                MessageBox.Show("El campo debe contener un valor numérico de 6 dígitos", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    existe = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_ValidarNumBoleta(cboPrefijos.Text, Convert.ToInt32(mskNumBoleta.Text), IdViaje, Editar));

                    if (existe > 0)
                    {
                        MessageBox.Show("La boleta ya está ingresada", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void txtHrInicial_Leave(object sender, EventArgs e)
        {
            if(txtHrInicial.Text == "")
            {
                txtHrInicial.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtHrInicial.Text = string.Format("{0:#,##0.00}", double.Parse(txtHrInicial.Text));
            }
        }

        private void txtHrFinal_Leave(object sender, EventArgs e)
        {
            if(txtHrFinal.Text == "")
            {
                txtHrFinal.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtHrFinal.Text = string.Format("{0:#,##0.00}", double.Parse(txtHrFinal.Text));
            }
        }
        
        private void txtHrGPS_Leave(object sender, EventArgs e)
        {
            if(txtHrGPS.Text == "")
            {
                txtHrGPS.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtHrGPS.Text = string.Format("{0:#,##0.00}", double.Parse(txtHrGPS.Text));
            }
        }

        private void txtHrInicial_TextChanged(object sender, EventArgs e)
        {
            if (Editar == 0)
            {
                Calcular();
            }
            else
                CalcularGPS();
        }

        private void txtHrFinal_TextChanged(object sender, EventArgs e)
        {
            if (Editar == 0)
            {
                Calcular();
            }
            else
                CalcularGPS();
        }

        private void TxtHrGPS_TextChanged(object sender, EventArgs e)
        {
            if (Editar == 1)
            {
                CalcularGPS();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void CargarClientes()
        {
            try {
                this.tR_ClientesTableAdapter.FillByIdFinca(this.dsTransporteAdiggm.TR_Clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarFincas()
        {
            int IdCliente;
            IdCliente = Convert.ToInt32(cboClientes.SelectedValue);
            this.tR_FincasTableAdapter.FillByCliente(this.dsTransporteAdiggm.TR_Fincas, IdCliente);
        }

        private void CargarClaTra()
        {
            int IdCliente;
            IdCliente = Convert.ToInt32(cboClientes.SelectedValue);
            this.tR_ClaseTrabajosTableAdapter.FillByRetro(this.dsTransporteAdiggm.TR_ClaseTrabajos, IdCliente);
        }

        private void CargarVeh()
        {
            this.tR_VehiculosTableAdapter.FillByActivoTipoVeh(this.dsTransporteAdiggm.TR_Vehiculos, IdTipoVehiculo);
        }

        private void CargarLagunas()
        {
            int IdFinca;
            IdFinca = Convert.ToInt32(cboFincas.SelectedValue);
            this.tR_LagunasTableAdapter.FillByFinca(this.dsTransporteAdiggm.TR_Lagunas,IdFinca);
        }

        private void CargarMotoristas()
        {
            //int IdRetro;
            //IdRetro = Convert.ToInt32(cboCodMaq.SelectedValue);
            //this.tR_MotoristasTableAdapter.FillByRetro(this.dsTransporteAdiggm.TR_Motoristas,IdRetro);
            this.tR_MotoristasTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_Motoristas);
        }

        public int ValidarCampos()
        {
            int existe, resultado, IdCierre, cerrado;
            DateTime MskFecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string t = mskFecha.Text;
            t = t.Replace("/", "");

            if (mskNumBoleta.Text == string.Empty)
            {
                resultado = 2; //Ingresar Código de Boleta
            }
            else if (t.Length < 8 || t.Length == 0)
            {
                resultado = 3; //Ingresar fecha
            }
            else if (MskFecha > DateTime.Now.Date)
            {
                resultado = 4; //Ingresar fecha correcta
            }
            else if (MskFecha < FechaMin || MskFecha > dtpFecMaxCierre.Value.Date)
            {
                resultado = 5; //Fecha Ingreso es mayor a la fecha de cierre
            }
            else if (cboClientes.SelectedIndex == -1)
            {
                resultado = 6; //Ingresar Cliente
            }
            else if (cboFincas.SelectedIndex == -1)
            {
                resultado = 7; //Ingresar Finca
            }
            else if (cboLagunas.SelectedIndex == -1)
            {
                resultado = 8; //Ingresar Laguna
            }
            else if (cboClaseTrabajos.SelectedIndex == -1)
            {
                resultado = 9; //Ingresar clase trabajo
            }
            else if (cboCodMaq.SelectedIndex == -1)
            {
                resultado = 10; //Ingresar Vehiculo
            }
            else if (cboRetrero.SelectedIndex == -1)
            {
                resultado = 11; //Ingresar Motorista
            }
            else if (txtHrInicial.Text == Convert.ToInt32(0).ToString())
            {
                resultado = 12; //Ingresar valor mayor a cero
            }
            else if (txtHrFinal.Text == Convert.ToInt32(0).ToString())
            {
                resultado = 13; //Ingresar valor mayor a cero
            }
            else if (mskNumBoleta.Text.Trim().Length < 6)
            {
                resultado = 14; //Ingresar sólo 6 digitos
            }
            else
            {
                DateTime Fecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int IdCliente = Convert.ToInt32(cboClientes.SelectedValue),
                    IdTipoVehiculo = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SelectIdRetro());//Convert.ToInt32(CboTipoVehiculos.SelectedValue);

                existe = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_ValidarNumBoleta(cboPrefijos.Text, Convert.ToInt32(mskNumBoleta.Text), IdViaje, Editar));
                IdCierre = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresExisteId(Fecha));
                cerrado = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierreClientesExiste(IdCierre, IdCliente, IdTipoVehiculo));

                if (existe > 0)
                {
                    resultado = 15; //la boleta ya existe
                }
                else if (IdCierre == 0)
                {
                    resultado = 16; //No existe un periodo de cierre ingresado
                }
                else if (cerrado > 1)
                {
                    resultado = 17;//ya se produjo el cierre para este cliente y tipo de vehículo
                }
                else
                    resultado = 1;
            }

            return resultado;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int validar = ValidarCampos();

            if (validar == 1)
            {

                DateTime Fecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string Prefijo = Convert.ToString(cboPrefijos.Text).ToString(),
                    NumBoleta = Convert.ToString(mskNumBoleta.Text.Trim()),
                    Observaciones = Convert.ToString(txtObservaciones.Text);
                int IdCliente = Convert.ToInt32(cboClientes.SelectedValue.ToString()),
                    IdClaseTrabajo = Convert.ToInt32(cboClaseTrabajos.SelectedValue.ToString()),
                    IdTipoVeh = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SelectIdRetro()),
                    IdVehiculo = Convert.ToInt32(cboCodMaq.SelectedValue.ToString()),
                    IdMotorista = Convert.ToInt32(cboRetrero.SelectedValue.ToString()),
                    IdCierre = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresExisteId(Fecha)),
                    IdLaguna = Convert.ToInt32(cboLagunas.SelectedValue.ToString());
                decimal ISV = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_ISV(IdTipoVeh, IdCliente)),
                    Tarifa = Convert.ToDecimal(txtTarifa.Text),
                    SubTotal = Convert.ToDecimal(txtHrGPS.Text) * Convert.ToDecimal(txtTarifa.Text),
                    TISV = SubTotal * (Convert.ToDecimal(ISV) / 100),
                    Total = SubTotal + TISV,
                    HrInicial = Convert.ToDecimal(txtHrInicial.Text),
                    HrFinal = Convert.ToDecimal(txtHrFinal.Text),
                    HrTrabajadas = Convert.ToDecimal(txtHrTrabajadas.Text),
                    HrGPS = Convert.ToDecimal(txtHrGPS.Text);

                if (Editar == 0)
                {
                    try
                    {
                        Clases.VarGlobales.consultasTrans.PR_ViajesRInsert(Fecha, Prefijo, NumBoleta, IdCliente, IdClaseTrabajo, IdTipoVeh, IdVehiculo,
                                                                            IdMotorista, Tarifa, TISV, SubTotal, Total, Observaciones, Usuario, IdCierre,
                                                                            IdLaguna, HrInicial, HrFinal, HrTrabajadas, HrGPS);

                        Limpiar();

                        lblFooter.Text = "Datos Guardados Exitosamente";
                        mskNumBoleta.Focus();

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
                else if (Editar == 1)
                {
                    try
                    {
                        Clases.VarGlobales.consultasTrans.PR_ViajesRUpdate(Fecha, Prefijo, NumBoleta, IdCliente, IdClaseTrabajo, IdTipoVeh, IdVehiculo,
                                                                            IdMotorista, Tarifa, TISV, SubTotal, Total, Observaciones, Usuario, IdCierre,
                                                                            IdLaguna, HrInicial, HrFinal, HrTrabajadas, HrGPS, IdViaje, IdViajeR);

                        Limpiar();

                        MessageBox.Show("Datos Actualizados Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (validar == 2)
            {
                MessageBox.Show("Ingrese un código de boleta", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskNumBoleta.Focus();
            }
            else if (validar == 3)
                MessageBox.Show("Ingrese una fecha", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 4)
                MessageBox.Show("La fecha de ingreso no puede ser mayor a la fecha actual", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 5)
                MessageBox.Show("La fecha de ingreso no está dentro del rango de cierre", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 6)
                MessageBox.Show("Ingrese un cliente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 7)
                MessageBox.Show("Ingrese una finca", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 8)
                MessageBox.Show("Ingrese una laguna", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 9)
                MessageBox.Show("Ingrese una clase de trabajo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 10)
                MessageBox.Show("Ingrese un código de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 11)
                MessageBox.Show("Ingrese un motorista", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 12)
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHrInicial.Focus();
            }
            else if (validar == 13)
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHrFinal.Focus();
            }
            else if (validar == 14)
            {
                MessageBox.Show("El campo debe contener un valor numérico de 6 dígitos", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar == 15)
            {
                MessageBox.Show("La boleta ya está ingresada", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar == 16)
            {
                MessageBox.Show("No existe un periodo de cierre ingresado", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validar == 17)
            {
                MessageBox.Show("Ya se produjo el cierre para este cliente y tipo de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarHoraInicio(int code)
        {
            bool resultado;

            if (code == 46 && txtHrInicial.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirHrI)
            {
                resultado = PermitirHrI;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        public bool ValidarHoraFinal(int code)
        {
            bool resultado;

            if (code == 46 && txtHrFinal.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirHrF)
            {
                resultado = PermitirHrF;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        public bool ValidarHoraGPS(int code)
        {
            bool resultado;

            if (code == 46 && txtHrGPS.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirHrGPS)
            {
                resultado = PermitirHrGPS;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        private void TxtHrInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarHoraInicio(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }

        private void TxtHrFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarHoraFinal(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }

        private void Limpiar()
        {
            mskNumBoleta.Text = "";
            cboClientes.SelectedIndex = -1;
            cboClaseTrabajos.SelectedIndex = -1;
            cboFincas.SelectedIndex = -1;
            cboLagunas.SelectedIndex = -1;
            cboRetrero.SelectedIndex = -1;
            cboCodMaq.SelectedIndex = -1;
            txtHrInicial.Text = $"{0:n}";
            txtHrFinal.Text = $"{0:n}";
            txtObservaciones.Text = "";
            cboPrefijos.Focus();
            IdViaje = 0;
            IdViajeR = 0;
            Editar = 0;
        }

        private void CboPrefijos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboPrefijos.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void mskNumBoleta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (mskNumBoleta.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void cboClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboClientes.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void cboFincas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboFincas.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void CboLagunas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboLagunas.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void mskFecha_Enter(object sender, EventArgs e)
        {
            mskFecha.Focus();
            mskFecha.Select(0, 0);
        }

        private void mskFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string t = mskFecha.Text;
                t = t.Replace("/", "");

                if (t != "" && t.Length == 8)
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void cboClaseTrabajos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboClaseTrabajos.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void CboCodMaq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboCodMaq.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void CboRetrero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboRetrero.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void TxtHrInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtHrInicial.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void TxtHrFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtHrFinal.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void TxtHrGPS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtHrGPS.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void cboPrefijos_SelectedValueChanged(object sender, EventArgs e)
        {
            mskNumBoleta.Clear();
        }

        private void cboClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex > -1)
            {
                CargarFincas();
                cboFincas.SelectedIndex = -1;
                CargarClaTra();
                cboClaseTrabajos.SelectedIndex = -1;
                int IdCliente = Convert.ToInt32(cboClientes.SelectedValue);
                int IdClaseTrabajo = Convert.ToInt32(cboClaseTrabajos.SelectedValue);
                int IdTipoVehiculo = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SelectIdRetro());

                bool AplicaISV;
                AplicaISV = Convert.ToBoolean(Clases.VarGlobales.consultasTrans.TR_PagaISV(IdTipoVehiculo, IdCliente));

                if (AplicaISV == true)
                {
                    ISV = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_ISV(IdTipoVehiculo, IdCliente));
                    txtISV.Text = $"{ISV / 100:0%}";
                }
                else
                {
                    ISV = 0;
                    txtISV.Text = $"{0 / 100:0%}";
                }
                if (Editar == 0)
                {
                    Calcular();
                }
                else
                {
                    CalcularGPS();
                }
            }
            else
            {
                cboFincas.SelectedIndex = -1;
                cboClaseTrabajos.SelectedIndex = -1;
                ISV = 0;
                txtISV.Text = $"{0 / 100:0%}";
            }
        }

        private void cboFincas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex > -1)
            {
                if (cboFincas.SelectedIndex > -1)
                {
                    CargarLagunas();
                    cboLagunas.SelectedIndex = -1;
                }
                else
                    cboLagunas.SelectedIndex = -1;
            }
        }

        private void CboCodMaq_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLagunas.SelectedIndex > -1)
            {
                if (cboCodMaq.SelectedIndex > -1)
                {
                    CargarMotoristas();
                    cboRetrero.SelectedIndex = -1;
                }
                else
                    cboRetrero.SelectedIndex = -1;
            }
        }
    }
}
