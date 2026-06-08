namespace ADIGGM.Transaccionales
{
    using ADIGGM.CapaDatos;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    public partial class FrmViajes : FrmPrincipal
    {
        //variables globales
        double ISV = 0;
        DateTime FechaMin = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMinCierre()),
        FechaMax = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMaxCierre());
        
        //campos usados para editar viajes
        int IdViaje = 0, IdCliente = 0, IdClaseTrabajo = 0, IdTipoVehiculo = 0, IdRuta = 0, IdVehiculo = 0, Editar = 0;
        decimal Tarifa = 0, Cantidad = 0, TISV = 0, SubTotal = 0, Total = 0;
        bool PermitirCant = true;
        string Prefijo = "", CodBoleta = "", Observaciones = "", Usuario = Clases.VarGlobales.Usuario;
        DateTime Fecha = DateTime.Now;

        public FrmViajes(int IdViaje, string Prefijo, string CodBoleta, DateTime Fecha, int IdCliente, int IdClaseTrabajo,
                            int IdTipoVehiculo, int IdRuta, int IdVehiculo, decimal Tarifa, decimal Cantidad,
                            decimal TISV, decimal SubTotal, decimal Total, string Observaciones, int Editar)
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
            dtpFecMaxCierre.Value = FechaMax;

            if (Editar == 0)
            {
                mskFecha.Text = Fecha.ToString("dd/MM/yyyy");
                CargarClientes();
                CboClientes.SelectedIndex = -1;
                CboClaseTrabajos.SelectedIndex = -1;
                CboTipoVehiculos.SelectedIndex = -1;
                CboVehiculo.SelectedIndex = -1;
                txtCantidad.Text = $"{1:n}";
                txtISV.Text = $"{0:0%}";
                this.cboPrefijos.Focus();
            }
            else if (Editar == 1)
            {
                this.tR_ViajesTableAdapter.FillByIdViaje(this.dsTransporteAdiggm1.TR_Viajes, IdViaje);
                CargarClientes();
                cboPrefijos.SelectedValue = Prefijo;
                mskNumBoleta.Text = CodBoleta;
                mskFecha.Text = Fecha.ToString("dd/MM/yyyy");
                CboClientes.SelectedValue = IdCliente;
                CboClaseTrabajos.SelectedValue = IdClaseTrabajo;
                CboTipoVehiculos.SelectedValue = IdTipoVehiculo;
                CboRutas.SelectedValue = IdRuta;
                CboVehiculo.SelectedValue = IdVehiculo;
                txtTarifa.Text = $"{Tarifa:n4}";
                txtCantidad.Text = $"{Cantidad:n}";
                txtISV.Text = $"{(TISV / SubTotal):0%}";
                txtTISV.Text = $"{TISV:n4}";
                txtSubtotal.Text = $"{SubTotal:n4}";
                txtTotal.Text = $"{Total:n4}";
                txtObservaciones.Text = Observaciones;
                ptbInfoCliente.Visible = true;
                ptbIndCliente.Visible = true;
                ttInfo.SetToolTip(ptbInfoCliente, CboClientes.Text);
                ptbInfoClaseTrab.Visible = true;
                ptbIndClaTra.Visible = true;
                ttInfo.SetToolTip(ptbInfoClaseTrab, CboClaseTrabajos.Text);
                ptbInfoTipoVeh.Visible = true;
                ptbIndTipoVeh.Visible = true;
                ttInfo.SetToolTip(ptbInfoTipoVeh, CboTipoVehiculos.Text);
                ptbInfoVehiculo.Visible = true;
                ptbIndVeh.Visible = true;
                ttInfo.SetToolTip(ptbInfoVehiculo, CboVehiculo.Text);
                ptbInfoRuta.Visible = true;
                ptbIndRuta.Visible = true;
                ttInfo.SetToolTip(ptbInfoRuta, CboRutas.Text);
            }
        }
        private void CargarClientes()
        {
            this.tR_ClientesTableAdapter.FillByActivo(this.dsTransporteAdiggm1.TR_Clientes);
        }
        private void CargarClaTra()
        {
            this.tR_ClaseTrabajosTableAdapter.FillByCliente(this.dsTransporteAdiggm1.TR_ClaseTrabajos,Convert.ToInt32(CboClientes.SelectedValue));
        }
        private void CargarTipoVeh()
        {
            int IdCliente, IdClaTrab;

            IdCliente = Convert.ToInt32(CboClientes.SelectedValue);
            IdClaTrab = Convert.ToInt32(CboClaseTrabajos.SelectedValue);
            
            this.tR_TipoVehiculosTableAdapter.FillByClaTra(this.dsTransporteAdiggm1.TR_TipoVehiculos, IdCliente, IdClaTrab);
        }
        private void CargarVehiculo()
        {
            this.tR_VehiculosTableAdapter.FillByActivoTipoVeh(this.dsTransporteAdiggm.TR_Vehiculos, Convert.ToInt32(CboTipoVehiculos.SelectedValue));
        }
        private void CargarRutas(int IdCliente, int IdClaseTrabajo, int IdTipoVeh)
        {
            this.tR_RutasFiltradasTableAdapter.Fill(this.dsTransporteAdiggm1.TR_RutasFiltradas, IdCliente, IdClaseTrabajo, IdTipoVeh);
        }
        public void Calcular()
        {
            try
            {
                if (txtCantidad.Text != "" && txtTarifa.Text != "")
                {
                    decimal cantidad = decimal.Parse(txtCantidad.Text, NumberStyles.Number, CultureInfo.CurrentCulture);
                    decimal tarifa = decimal.Parse(txtTarifa.Text, NumberStyles.Number, CultureInfo.CurrentCulture);

                    decimal subtotal = cantidad * tarifa;
                    decimal totalISV = subtotal * (Convert.ToDecimal(ISV) / 100);
                    decimal total = subtotal + totalISV;

                    txtTISV.Text = $"{totalISV:n4}";
                    txtSubtotal.Text = $"{subtotal:n4}";
                    txtTotal.Text = $"{total:n4}";
                }
                else
                {
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
        private void Limpiar()
        {
            mskNumBoleta.Text = "";
            CboClientes.SelectedIndex = -1;
            CboClaseTrabajos.SelectedIndex = -1;
            CboTipoVehiculos.SelectedIndex = -1;
            CboVehiculo.SelectedIndex = -1;
            txtCantidad.Text = $"{1:n}";
            txtObservaciones.Text = "";
            cboPrefijos.Focus();
            CboRutas.SelectedIndex = -1;
            IdViaje = 0;
            Editar = 0;
        }
        private void CompararDatos(string ctrl)
        {
            Control[] ctrls = Controls.Find(ctrl, true);
            if (Editar == 1)
            {
                if (ctrl == "CboClientes" && CboClientes.SelectedIndex > 0)
                {
                    ptbIndCliente.BackColor = IdCliente != Convert.ToInt32(CboClientes.SelectedValue.ToString()) ? Color.Red : Color.Green;
                }
                else
                if (ctrl == "CboClaseTrabajos")
                {
                    ptbIndClaTra.BackColor = IdClaseTrabajo != Convert.ToInt32(CboClaseTrabajos.SelectedValue.ToString()) ? Color.Red : Color.Green;
                }
                else
                if (ctrl == "CboTipoVehiculos")
                {
                    ptbIndTipoVeh.BackColor = IdTipoVehiculo != Convert.ToInt32(CboTipoVehiculos.SelectedValue.ToString()) ? Color.Red : Color.Green;
                }
                else
                if (ctrl == "CboVehiculo")
                {
                    ptbIndVeh.BackColor = IdVehiculo != Convert.ToInt32(CboVehiculo.SelectedValue.ToString()) ? Color.Red : Color.Green;
                }
                else
                if (ctrl == "CboRutas" && CboRutas.SelectedIndex >= 0)
                {
                    ptbIndRuta.BackColor = IdRuta != Convert.ToInt32(CboRutas.SelectedValue.ToString()) ? Color.Red : Color.Green;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int validar = ValidarCampos();

            if (validar == 1)
            {
                DateTime Fecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string Prefijo = cboPrefijos.Text.ToString(),
                       NumBoleta = mskNumBoleta.Text.Trim(),
                       Observaciones = txtObservaciones.Text;
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue),
                    IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue),
                    IdTipoVeh = Convert.ToInt32(CboTipoVehiculos.SelectedValue),
                    IdVehiculo = Convert.ToInt32(CboVehiculo.SelectedValue),
                    IdMotorista = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SeleccionarIdMotorista(IdVehiculo)),
                    IdRuta = Convert.ToInt32(CboRutas.SelectedValue),
                    IdCierre = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresExisteId(Fecha));
                ISV = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_ISV(IdTipoVeh, IdCliente));

                decimal Cantidad = decimal.Parse(txtCantidad.Text, System.Globalization.NumberStyles.Number, CultureInfo.CurrentCulture),
                        Tarifa = decimal.Parse(txtTarifa.Text, System.Globalization.NumberStyles.Number, CultureInfo.CurrentCulture),
                        Subtotal = Cantidad * Tarifa,
                        TotalISV = Subtotal * (Convert.ToDecimal(ISV) / 100),
                        Total = Subtotal + TotalISV;

                try
                {
                    using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexion.TransporteADI))
                    {
                        conn.Open();
                        string spName = Editar == 0 ? "PR_ViajesInsert" : "PR_ViajesUpdate";

                        using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(spName, conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            // Parámetros comunes a Insert y Update
                            cmd.Parameters.Add("@Fecha", System.Data.SqlDbType.Date).Value = Fecha;
                            cmd.Parameters.Add("@Prefijo", System.Data.SqlDbType.VarChar, 10).Value = Prefijo;
                            cmd.Parameters.Add("@NumBoleta", System.Data.SqlDbType.VarChar, 10).Value = NumBoleta;
                            cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = IdCliente;
                            cmd.Parameters.Add("@IdClaseTrabajo", System.Data.SqlDbType.Int).Value = IdClaseTrabajo;
                            cmd.Parameters.Add("@IdTipoVeh", System.Data.SqlDbType.Int).Value = IdTipoVeh;
                            cmd.Parameters.Add("@IdVehiculo", System.Data.SqlDbType.Int).Value = IdVehiculo;
                            cmd.Parameters.Add("@IdMotorista", System.Data.SqlDbType.Int).Value = IdMotorista;
                            cmd.Parameters.Add("@IdRuta", System.Data.SqlDbType.Int).Value = IdRuta;
                            cmd.Parameters.Add("@Observaciones", System.Data.SqlDbType.VarChar, 200).Value = Observaciones;
                            cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar, 50).Value = Usuario;
                            cmd.Parameters.Add("@IdCierre", System.Data.SqlDbType.Int).Value = IdCierre;

                            // @Cantidad es NUMERIC(8,2) en el SP
                            var pCantidad = new System.Data.SqlClient.SqlParameter();
                            pCantidad.ParameterName = "@Cantidad";
                            pCantidad.SqlDbType = System.Data.SqlDbType.Decimal;
                            pCantidad.Precision = 8;
                            pCantidad.Scale = 2;
                            pCantidad.Value = Cantidad;
                            cmd.Parameters.Add(pCantidad);

                            // Parámetros NUMERIC(10,4)
                            foreach (var (nombre, valor) in new (string, decimal)[]
                            {
                        ("@Tarifa",   Tarifa),
                        ("@ISV",      TotalISV),   // ✅ @ISV, no @TISV
                        ("@Subtotal", Subtotal),   // ✅ @Subtotal, no @SubTotal
                        ("@Total",    Total)
                            })
                            {
                                var p = new System.Data.SqlClient.SqlParameter();
                                p.ParameterName = nombre;
                                p.SqlDbType = System.Data.SqlDbType.Decimal;
                                p.Precision = 10;
                                p.Scale = 4;
                                p.Value = valor;
                                cmd.Parameters.Add(p);
                            }

                            // @IdViaje solo en Update
                            if (Editar == 1)
                                cmd.Parameters.Add("@IdViaje", System.Data.SqlDbType.Int).Value = IdViaje;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    if (Editar == 0)
                    {
                        Limpiar();
                        lblFooter.Text = "Datos Guardados Exitosamente";
                        mskNumBoleta.Focus();
                        Timer timer1 = new Timer();
                        timer1.Interval = 10000;
                        timer1.Tick += (s, a) => { ((Timer)s).Stop(); lblFooter.Text = ""; };
                        timer1.Start();
                    }
                    else
                    {
                        Limpiar();
                        MessageBox.Show("Datos Actualizados Exitosamente", Clases.VarGlobales.nombreSistema,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (validar == 2)
                MessageBox.Show("Ingrese un código de boleta", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 3)
                MessageBox.Show("Ingrese una fecha", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 4)
                MessageBox.Show("La fecha de ingreso no puede ser mayor a la fecha actual", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 5)
                MessageBox.Show("La fecha de ingreso no está dentro del rango de cierre", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 6)
                MessageBox.Show("Ingrese un cliente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 7)
                MessageBox.Show("Ingrese una clase de trabajo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 8)
                MessageBox.Show("Ingrese un tipo de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 9)
                MessageBox.Show("Ingrese una ruta", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 10)
                MessageBox.Show("Ingrese un código de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 11)
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 12)
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
            else if (validar == 13)
                MessageBox.Show("El campo debe contener un valor numérico de 6 dígitos", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 14)
                MessageBox.Show("La boleta ya está ingresada", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 15)
                MessageBox.Show("No existe un periodo de cierre ingresado que sea válido", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 16)
                MessageBox.Show("Ya se produjo el cierre para este cliente y tipo de vehículo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cboPrefijos_SelectedValueChanged(object sender, EventArgs e)
        {
            mskNumBoleta.Clear();
        }
        private void CboRutas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CboVehiculo.SelectedValue) > 0)
            {
                int IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue),
                    IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue),
                    IdRuta = Convert.ToInt32(CboRutas.SelectedValue),
                    IdCliente = Convert.ToInt32(CboClientes.SelectedValue);

                decimal tarifa = Convert.ToDecimal(Clases.VarGlobales.consultasTrans.PR_SelectTarifa(IdClaseTrabajo, IdTipoVehiculo, IdRuta, IdCliente));
                txtTarifa.Text = $"{tarifa:n4}";
            }
            else
            {
                txtTarifa.Text = $"{0:n}";
            }
            ComboBox ctrl = sender as ComboBox;
            CompararDatos(Convert.ToString(ctrl.Name));
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
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCantidad(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }
        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Text = $"{0:n}";
                txtCantidad.Focus();
            }
        }
        public bool ValidarCantidad(int code)
        {
            bool resultado;

            if (code == 46 && txtCantidad.Text.Contains("."))//se evalúa si es punto y revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
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
        public int ValidarCampos()
        {
            int existe, resultado,IdCierre, cerrado;
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
            else if (CboClientes.SelectedIndex == -1)
            {
                resultado = 6; //Ingresar Cliente
            }
            else if (CboClaseTrabajos.SelectedIndex == -1)
            {
                resultado = 7; //Ingresar Clase de Trabajo
            }
            else if (CboTipoVehiculos.SelectedIndex == -1)
            {
                resultado = 8; //Ingresar Tipo de Vehiculo
            }
            else if (CboRutas.SelectedIndex == -1)
            {
                resultado = 9; //Ingresar una ruta
            }
            else if (CboVehiculo.SelectedIndex == -1)
            {
                resultado = 10; //Ingresar Vehiculo
            }
            else if (txtCantidad.Text == string.Empty)
            {
                resultado = 11; //Ingresar Cantidad
            }
            else if (txtCantidad.Text == Convert.ToInt32(0).ToString())
            {
                resultado = 12; //Ingresar valor mayor a cero
            }
            else if (mskNumBoleta.Text.Trim().Length < 6)
            {
                resultado = 13; //Ingresar sólo 6 digitos
            }
            else
            {
                DateTime Fecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue),
                    IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue);

                existe = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_ValidarNumBoleta(cboPrefijos.Text, Convert.ToInt32(mskNumBoleta.Text), IdViaje, Editar));               
                IdCierre = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresExisteId(Fecha));
                cerrado = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierreClientesExiste(IdCierre, IdCliente, IdTipoVehiculo));

                if (existe > 0)
                {
                    resultado = 14; //la boleta ya existe
                }
                else if (IdCierre <= 0)
                {
                    resultado = 15; //No existe un periodo de cierre ingresado
                }                
                else if (cerrado > 1)
                {
                    resultado = 16;//ya se produjo el cierre para este cliente y tipo de vehículo
                }
                else
                    resultado = 1;
            }
            return resultado;
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
        private void mskFecha_Enter(object sender, EventArgs e)
        {
            mskFecha.Focus();
            mskFecha.Select(0, 0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void mskNumBoleta_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mskNumBoleta.SelectAll();
            });
        }
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCantidad.SelectAll();
            });
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length < 1 || txtCantidad.Text == ".")
            {
                txtCantidad.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtCantidad.Text = string.Format("{0:#,##0.00}", double.Parse(txtCantidad.Text));
            }
        }
        private void CboClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboClientes.SelectedIndex > -1)
            {
                if (CboClaseTrabajos.SelectedIndex == -1)
                {
                    CargarClaTra();
                    CboClaseTrabajos.SelectedIndex = -1;
                }
                else
                 if (CboClaseTrabajos.SelectedIndex > -1)
                {
                    CargarClaTra();
                }
                ComboBox ctrl = sender as ComboBox;
                CompararDatos(Convert.ToString(ctrl.Name));
            }
        }
        private void CboClaseTrabajos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboClientes.SelectedIndex > -1 &&
                CboClaseTrabajos.SelectedIndex > -1)
            {
                if (CboTipoVehiculos.SelectedIndex == -1)
                {
                    CargarTipoVeh();
                    CboTipoVehiculos.SelectedIndex = -1;
                }
                else
                if (CboTipoVehiculos.SelectedIndex > -1)
                {
                    CargarTipoVeh();
                }
                ComboBox ctrl = sender as ComboBox;
                CompararDatos(Convert.ToString(ctrl.Name));
            }
        }
        private void CboTipoVehiculos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboClientes.SelectedIndex > -1 &&
                 CboClaseTrabajos.SelectedIndex > -1)
            {
                if (CboTipoVehiculos.SelectedIndex > -1)
                {
                    int IdCliente = Convert.ToInt32(CboClientes.SelectedValue);
                    int IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue);
                    int IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue);

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
                    if (CboVehiculo.SelectedIndex == -1)
                    {
                        CargarVehiculo();
                        CboVehiculo.SelectedIndex = -1;
                        CargarRutas(IdCliente, IdClaseTrabajo, IdTipoVehiculo);
                        CboRutas.SelectedIndex = -1;
                    }
                    else
                    if (CboVehiculo.SelectedIndex > -1)
                    {
                        CargarVehiculo();
                        CargarRutas(IdCliente, IdClaseTrabajo, IdTipoVehiculo);
                    }
                    ComboBox ctrl = sender as ComboBox;
                    CompararDatos(Convert.ToString(ctrl.Name));
                }
                else
                {
                    ISV = 0;
                    txtISV.Text = $"{0 / 100:0%}";
                }
            }
        }
        private void CboVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CboVehiculo.SelectedIndex >= 0)
            {
                int IdCliente = Convert.ToInt32(CboClientes.SelectedValue),
                    IdClaseTrabajo = Convert.ToInt32(CboClaseTrabajos.SelectedValue),
                    IdTipoVehiculo = Convert.ToInt32(CboTipoVehiculos.SelectedValue),
                    IdVehiculo = Convert.ToInt32(CboVehiculo.SelectedValue);
                string motorista;

                motorista = Clases.VarGlobales.consultasTrans.TR_SeleccionarMotorista(int.Parse(CboVehiculo.SelectedValue.ToString())).ToString();
                txtMotorista.Text = motorista;
                ComboBox ctrl = sender as ComboBox;
                CompararDatos(Convert.ToString(ctrl.Name));
            }
            else
            {
                txtMotorista.Text = "";
            }
        }
        private void CboClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (CboClientes.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void CboClaseTrabajos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (CboClaseTrabajos.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void CboTipoVehiculos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (CboTipoVehiculos.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void CboVehiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (CboVehiculo.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void CboRutas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (CboRutas.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void cboPrefijos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (cboPrefijos.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtCantidad.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void dtpFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}