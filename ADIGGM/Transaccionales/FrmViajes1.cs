using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace TransporteAdiggm.Transaccionales
{
    public partial class FrmViajes : FrmPrincipal
    {
        //variables globales
        double ISV = 0;

        //campos usados para editar viajes
        int IdViaje = 0;
        int Prefijo = 0;
        string CodBoleta = "";
        DateTime Fecha = DateTime.Now;
        int IdCliente = 0;
        int IdClaseTrabajo = 0;
        int IdTipoVehiculo = 0;
        int IdRuta = 0;
        int IdVehiculo = 0;
        double Tarifa = 0;
        double Cantidad = 0;
        double TISV = 0;
        double SubTotal = 0;
        double Total = 0;
        string Observaciones = "";
        int Editar = 0;
        string Usuario = Clases.VarGlobales.Usuario;
        Boolean PermitirCant = true;
        Boolean PermitirNumBol = true;

        public FrmViajes(int IdViaje, int Prefijo, string CodBoleta, DateTime Fecha, int IdCliente, int IdClaseTrabajo,
                            int IdTipoVehiculo, int IdRuta, int IdVehiculo, double Tarifa, double Cantidad,
                            double TISV, double SubTotal, double Total, string Observaciones, int Editar)
        {
            InitializeComponent();

            this.IdViaje = IdViaje;
            this.Prefijo = Prefijo;
            this.CodBoleta = CodBoleta;
            this.Fecha = Fecha;
            this.IdCliente = IdCliente;
            this.IdClaseTrabajo = IdClaseTrabajo;
            this.IdTipoVehiculo = IdTipoVehiculo;
            this.IdRuta = IdRuta;
            this.IdVehiculo = IdVehiculo;
            this.Tarifa = Tarifa;
            this.Cantidad = Cantidad;
            this.TISV = TISV;
            this.SubTotal = SubTotal;
            this.Total = Total;
            this.Observaciones = Observaciones;
            this.Editar = Editar;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmViajes_Load(object sender, EventArgs e)
        {
            this.tR_PrefijosTableAdapter.Fill(this.dsTransporteAdiggm1.TR_Prefijos);

            if (Editar == 0)
            {
                CargarClientes();
                CboClientes.SelectedIndex = -1;
                txtCantidad.Text = $"{1:n}";
                txtISV.Text = $"{0:P2}";
                this.cboPrefijos.Focus();
            }
            else if (Editar == 1)
            {
                this.tR_ViajesTableAdapter.FillByIdViaje(this.dsTransporteAdiggm1.TR_Viajes, IdViaje);
                CargarClientes();
                cboPrefijos.SelectedValue = Prefijo;
                txtNumBoleta.Text = CodBoleta;
                dtpFecha.Value = Fecha;
                CboClientes.SelectedValue = IdCliente;
                CboClaseTrabajos.SelectedValue = IdClaseTrabajo;
                CboTipoVehiculos.SelectedValue = IdTipoVehiculo;
                CboRutas.SelectedValue = IdRuta;
                CboVehiculo.SelectedValue = IdVehiculo;
                txtTarifa.Text = $"{Tarifa:n}";
                txtCantidad.Text = $"{Cantidad:n}";
                txtISV.Text = $"{(TISV / SubTotal):P2}";
                txtTISV.Text = $"{TISV:n}";
                txtSubtotal.Text = $"{SubTotal:n}";
                txtTotal.Text = $"{Total:n}";
                txtObservaciones.Text = Observaciones;
            }
        }

        private void CargarClientes()
        {
            this.tR_ClientesTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_Clientes);
        }
        private void CargarClaTra(int IdCliente)
        {
            this.tR_ClaseTrabajosTableAdapter.FillByCliente(this.dsTransporteAdiggm.TR_ClaseTrabajos, IdCliente);
        }

        private void CargarTipoVeh(int IdClaseTrab)
        {
            this.tR_TipoVehiculosTableAdapter.FillByClaTra(this.dsTransporteAdiggm.TR_TipoVehiculos, IdClaseTrab);
        }

        private void CargarVehiculo(int IdTipoVehiculo)
        {
            this.tR_VehiculosTableAdapter.FillByActivoTipoVeh(this.dsTransporteAdiggm.TR_Vehiculos, IdTipoVehiculo);
        }

        private void CargarRutas(int IdCliente, int IdClaseTrabajo, int IdTipoVeh)
        {
            this.tR_RutasFiltradasTableAdapter.Fill(this.dsTransporteAdiggm1.TR_RutasFiltradas, IdCliente, IdClaseTrabajo, IdTipoVeh);
        }

        public void Calcular()
        {
            try
            {
                double TotalISV, Subtotal, Total;

                if (txtCantidad.Text != "" && txtTarifa.Text != "")
                {
                    Subtotal = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtTarifa.Text);
                    TotalISV = Subtotal * (ISV / 100);
                    Total = Subtotal + TotalISV;

                    txtTISV.Text = $"{TotalISV:n}";
                    txtSubtotal.Text = $"{Subtotal:n}";
                    txtTotal.Text = $"{Total:n}";
                }
                else if (txtCantidad.Text == "" || txtTarifa.Text == "")
                {
                    txtTISV.Text = $"{0:n}";
                    txtSubtotal.Text = $"{0:n}";
                    txtTotal.Text = $"{0:n}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNumBoleta.Text = "";
            CboClientes.SelectedIndex = -1;
            CboClaseTrabajos.SelectedIndex = -1;
            txtCantidad.Text = "1";
            txtObservaciones.Text = "";
            cboPrefijos.Focus();
            IdViaje = 0;
            Editar = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           int validar = ValidarCampos();

            if (validar == 1)
            {
                DateTime Fecha = Convert.ToDateTime(dtpFecha.Value);
                string Prefijo = Convert.ToString(cboPrefijos.Text).ToString();
                string NumBoleta = Convert.ToString(txtNumBoleta.Text.Trim());
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue.ToString());
                int IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue.ToString());
                int IdTipoVeh = Convert.ToInt32(CboTipoVehiculos.SelectedValue.ToString());
                int IdVehiculo = Convert.ToInt32(CboVehiculo.SelectedValue.ToString());
                int IdMotorista = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SeleccionarIdMotorista(IdVehiculo));
                int IdRuta = Convert.ToInt32(CboRutas.SelectedValue.ToString());
                decimal Cantidad = Convert.ToDecimal(txtCantidad.Text);
                decimal Tarifa = Convert.ToDecimal(txtTarifa.Text);
                decimal TISV = Convert.ToDecimal(txtTISV.Text);
                decimal SubTotal = Convert.ToDecimal(txtSubtotal.Text);
                decimal Total = Convert.ToDecimal(txtTotal.Text);
                string Observaciones = Convert.ToString(txtObservaciones.Text);

                if (Editar == 0)
                {
                    try
                    {
                        Clases.VarGlobales.consultasTrans.PR_ViajesInsert(Fecha, Prefijo, NumBoleta, IdCliente, IdClaseTrabajo, IdTipoVeh, IdVehiculo, IdMotorista, IdRuta, Cantidad, Tarifa, TISV, SubTotal, Total, Observaciones, Usuario);

                        Limpiar();

                        MessageBox.Show("Datos Guardados Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Clases.VarGlobales.consultasTrans.PR_ViajesUpdate(Fecha, Prefijo, NumBoleta, IdCliente, IdClaseTrabajo, IdTipoVeh, IdVehiculo, IdMotorista, IdRuta, Cantidad, Tarifa, TISV, SubTotal, Total, Observaciones, Usuario, IdViaje);

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
                txtNumBoleta.Focus();
            }
            else if (validar == 3)
                MessageBox.Show("Ingrese un cliente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 4)
                MessageBox.Show("Ingrese una clase de trabajo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 5)
                MessageBox.Show("Ingrese un tipo de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 6)
                MessageBox.Show("Ingrese una ruta", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 7)
                MessageBox.Show("Ingrese un código de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 8)
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
            else if (validar == 9)
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
        }

        private void cboPrefijos_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNumBoleta.Clear();
        }

        private void CboClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboClientes.SelectedIndex != -1)
            {
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue);

                CargarClaTra(IdCliente);
                CboClaseTrabajos.SelectedIndex = -1;
                CboClaseTrabajos.Enabled = true;
            }
            else
            {
                CboClaseTrabajos.Enabled = false;
            }
        }

        private void CboClaseTrabajos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboClaseTrabajos.SelectedIndex != -1)
            {
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue);
                int IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue);
                int IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue);

                CargarTipoVeh(IdClaseTrabajo);
                CboTipoVehiculos.SelectedIndex = -1;
                CboTipoVehiculos.Enabled = true;

                if (CboClaseTrabajos.SelectedIndex != -1 && CboTipoVehiculos.SelectedIndex != -1)
                {
                    CargarRutas(IdCliente, IdClaseTrabajo, IdTipoVehiculo);
                    CboRutas.SelectedIndex = -1;
                    CboRutas.Enabled = true;
                }
                else
                {
                    CboRutas.Enabled = false;
                    CboRutas.SelectedIndex = -1;
                }
            }
            else
            {
                CboTipoVehiculos.Enabled = false;
                CboTipoVehiculos.SelectedIndex = -1;
                CboRutas.Enabled = false;
                CboRutas.SelectedIndex = -1;
            }
        }

        private void CboTipoVehiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboTipoVehiculos.SelectedIndex != -1)
            {
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue);
                int IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue);
                int IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue);

                CargarVehiculo(IdTipoVehiculo);
                CboVehiculo.SelectedIndex = -1;
                CboVehiculo.Enabled = true;

                bool AplicaISV;
                AplicaISV = Convert.ToBoolean(Clases.VarGlobales.consultasTrans.TR_PagaISV(IdTipoVehiculo));

                if (AplicaISV == true)
                {
                    ISV = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_ISV(IdTipoVehiculo));
                    txtISV.Text = $"{ISV / 100:P2}";
                }
                else
                {
                    ISV = 0;
                    txtISV.Text = $"{0 / 100:P2}";
                }

                if (CboClaseTrabajos.SelectedIndex != -1 && CboTipoVehiculos.SelectedIndex != -1)
                {
                    CargarRutas(IdCliente, IdClaseTrabajo, IdTipoVehiculo);
                    CboRutas.SelectedIndex = -1;
                    CboRutas.Enabled = true;
                }
                else
                {
                    CboRutas.Enabled = false;
                    CboRutas.SelectedIndex = -1;
                }
            }
            else
            {
                CboVehiculo.Enabled = false;
                CboVehiculo.SelectedIndex = -1;
                txtISV.Text = $"{0 / 100:P2}";
            }
        }

        private void CboRutas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboClaseTrabajos.SelectedIndex != -1 && CboTipoVehiculos.SelectedIndex != -1 && CboRutas.SelectedIndex != -1)
            {
                double Tarifa;
                int IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue);
                int IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue);
                int IdRuta = Convert.ToInt32(CboRutas.SelectedValue);

                Tarifa = Convert.ToDouble(Clases.VarGlobales.consultasTrans.PR_SelectTarifa(IdClaseTrabajo, IdTipoVehiculo, IdRuta));
                txtTarifa.Text = $"{Tarifa:n}";
            }
            else
            {
                txtTarifa.Text = $"{0:n}";
            }
        }

        private void CboVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboVehiculo.SelectedIndex != -1)
            {
                int IdVehiculo = Convert.ToInt32(CboVehiculo.SelectedValue);
                string motorista;
                motorista = Clases.VarGlobales.consultasTrans.TR_SeleccionarMotorista(int.Parse(CboVehiculo.SelectedValue.ToString())).ToString();
                txtMotorista.Text = motorista;
            }
            else
            {
                txtMotorista.Text = "";
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNumBoleta_Validating(object sender, CancelEventArgs e)
        {
            int existe;

            if (string.IsNullOrEmpty(txtNumBoleta.Text))
            {
                //vacío
                //e.Cancel = true;
                MessageBox.Show("Ingrese un valor", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtNumBoleta.Focus();
            }
            else
                if (txtNumBoleta.Text.Trim().Length < 6 || txtNumBoleta.Text.Trim().Length > 6)
            {
                //inferior a seis caracteres
                e.Cancel = true;
                if (e.Cancel)
                    MessageBox.Show("El campo debe contener un valor numérico de 6 dígitos", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                existe = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_ValidarNumBoleta(cboPrefijos.Text, Convert.ToInt32(txtNumBoleta.Text), IdViaje, Editar));

                if (existe > 0)
                {
                    e.Cancel = true;
                    if (e.Cancel)
                        MessageBox.Show("La boleta ya está ingresada", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCantidad(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                //vacío
                //e.Cancel = true;
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Text = $"{0:n}";
                txtCantidad.Focus();
            }
        }

        public bool ValidarCantidad(int code)
        {
            bool resultado;

            if (code == 46 && txtCantidad.Text.Contains("."))//se evalua si es punto y  revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirCant)
            {
                resultado = PermitirCant;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }

        public bool ValidarBoleta(int code)
        {
            bool resultado;

            if ((((code >= 48) && (code <= 57)) || (code == 8))) //se evaluan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirNumBol)
            {
                resultado = PermitirNumBol;
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

            if (txtNumBoleta.Text == string.Empty)
            {
                resultado = 2; //Ingresar Codigo de Boleta
            }
            else if (CboClientes.SelectedIndex == -1)
            {
                resultado = 3; //Ingresar Cliente
            }
            else if (CboClaseTrabajos.SelectedIndex == -1)
            {
                resultado = 4; //Ingresar Clase de Trabajo
            }
            else if (CboTipoVehiculos.SelectedIndex == -1)
            {
                resultado = 5; //Ingresar Tipo de Vehiculo
            }
            else if (CboRutas.SelectedIndex == -1)
            {
                resultado = 6; //Ingresar una ruta
            }
            else if (CboVehiculo.SelectedIndex == -1)
            {
                resultado = 7; //Ingresar Vehiculo
            }
            else if (txtCantidad.Text == string.Empty)
            {
                resultado = 8; //Ingresar Cantidad
            }
            else if (txtCantidad.Text == Convert.ToInt32(0).ToString())
            {
                resultado = 9; //Ingresar valor mayor a cero
            }
            else 
            {
                resultado = 1;
            }

            return resultado;
        }

        private void txtNumBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarBoleta(Convert.ToInt32(e.KeyChar)); //llamada a la función que evalua que tecla es aceptada
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Select(0, txtCantidad.Text.Length);
        }

        private void txtNumBoleta_Enter(object sender, EventArgs e)
        {
            txtNumBoleta.Select(0, txtNumBoleta.Text.Length);
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            txtCantidad.Text = $"{txtCantidad.Text:n}";
        }
    }
}
