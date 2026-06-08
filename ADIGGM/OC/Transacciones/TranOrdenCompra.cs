using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;

namespace ADIGGM.OC.Transacciones
{
    public partial class TranOrdenCompra : FrmPrincipal
    {
        int TipoOC = 0, Actualizar = 0, IdTipoOC = 0, IdProveedor = 0, MaxItems = 0;
        bool permitir = true;
        decimal ISVP = 0;
        string connectionString = ADIGGM.CapaDatos.Conexion.Cadena(ADIGGM.CapaDatos.Conexion.TRANSPORTE);

        public TranOrdenCompra(int Actualizar)
        {
            InitializeComponent();
            this.Actualizar = Actualizar;
        }
        private void TranOrdenCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_UnidadCombustible1' Puede moverla o quitarla según sea necesario.
            this.oC_UnidadCombustible1TableAdapter.Fill(this.dsOC.OC_UnidadCombustible1);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_UnidadCombustible' Puede moverla o quitarla según sea necesario.
            this.oC_UnidadCombustibleTableAdapter.Fill(this.dsOC.OC_UnidadCombustible);
            ISVP = decimal.Parse(VarGlobales.consultasOC.OC_ISVObtener().ToString());
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Responsables' Puede moverla o quitarla según sea necesario.
            this.oC_ResponsablesTableAdapter.FillByActivos(this.dsOC.OC_Responsables);
            // TODO: esta línea de código carga datos en la tabla 'dsOC1.OC_Productos1' Puede moverla o quitarla según sea necesario.
            this.oC_Productos1TableAdapter.Fill(this.dsOC1.OC_Productos1);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Departamentos' Puede moverla o quitarla según sea necesario.
            this.oC_DepartamentosTableAdapter.FillByActivos(this.dsOC.OC_Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.TR_ClaseTrabajos' Puede moverla o quitarla según sea necesario.
            this.tR_ClaseTrabajosTableAdapter.Fill(this.dsOC.TR_ClaseTrabajos);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_ProductosCategorias' Puede moverla o quitarla según sea necesario.
            this.oC_ProductosCategoriasTableAdapter.FillByActivos(this.dsOC.OC_ProductosCategorias);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.TR_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_VehiculosTableAdapter.Fill(this.dsOC.TR_Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillByActivos(this.dsOC.OC_Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_TipoOC' Puede moverla o quitarla según sea necesario.
            this.oC_TipoOCTableAdapter.FillBy(this.dsOC.OC_TipoOC);

            this.oC_ProductosTableAdapter.FillByActivos(this.dsOC.OC_Productos, int.Parse(cboCategoria.SelectedValue.ToString()));
            
            obtenerTipoOC();
            lblTotal.Text = "Sub-Total: " + 0.ToString("N4") + " ISV: " + (0).ToString("N4") + " Total: " + (0).ToString("N4");

            if (cboTipoOC.SelectedIndex != -1 && Actualizar == 0)
            {
                lblCorrelativo.Text = "Orden #: " + VarGlobales.consultasOC.OC_CorrelativoMostrar(int.Parse(cboTipoOC.SelectedValue.ToString()), DateTime.Now.Year.ToString()).ToString();
            }

            if (Actualizar > 0)
            {
                cargarDatos();
                cboTipoOC.Enabled = false;
                lblCorrelativo.Visible = false;
                ckbVehiculosEdit.Visible = true;
            }
            IdTipoOC = (int)cboTipoOC.SelectedValue;

            if (cboVehiculo.SelectedIndex != -1)
            {
                string infoVeh = VarGlobales.consultasOC.OC_InfoVehObtener(int.Parse(cboVehiculo.SelectedValue.ToString())).ToString();
                lblInformacionVeh.Text = infoVeh;
            }

            if (cboProveedor.SelectedIndex != -1)
            {
                string maxItems = VarGlobales.consultasOC.OC_ObtenerMaxItems(int.Parse(cboProveedor.SelectedValue.ToString())).ToString();
                lblMaxItems.Text = "Cantidad Maxima de Productos: " + maxItems;
                MaxItems = int.Parse(maxItems);
            }            
        }
        private void cboTipoOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdTipoOC == 0 && cboTipoOC.SelectedIndex != -1)
            {
                IdTipoOC = (int)cboTipoOC.SelectedValue;
            }

            if (cboTipoOC.SelectedIndex != -1)
            {
                if (IdTipoOC > 0 && IdTipoOC != int.Parse(cboTipoOC.SelectedValue.ToString()) && dgvDetOrden.Rows.Count > 0)
                {
                    if (MessageBox.Show("Si cambia el Tipo de Orden se eliminará el detalle, Desea continuar?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvDetOrden.DataSource = null;
                        dgvDetOrden.Rows.Clear();
                        IdTipoOC = (int)cboTipoOC.SelectedValue;
                        obtenerTipoOC();
                        CalcularTotal();
                        txtSolicitado.Text = string.Empty;
                    }
                    else
                    {
                        cboTipoOC.SelectedValue = IdTipoOC;
                    }
                }
                else
                {
                    obtenerTipoOC();
                }
                lblCorrelativo.Text = "Orden #: "+ VarGlobales.consultasOC.OC_CorrelativoMostrar(int.Parse(cboTipoOC.SelectedValue.ToString()), DateTime.Now.Year.ToString()).ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = 0;
                foreach (DataGridViewRow row in dgvDetOrden.Rows)
                {
                    if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0)
                    {
                        contador += 1;
                    }
                }

                if ((TipoOC == 1 || TipoOC == 4) && contador > 0)
                {
                    MessageBox.Show("El Tipo de Orden solo puede tener un vehículo", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboTipoOC.SelectedValue is null || int.Parse(cboTipoOC.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Tipo de Orden", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboVehiculo.SelectedValue is null || int.Parse(cboVehiculo.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un vehiculo", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboProducto.SelectedValue is null || int.Parse(cboProducto.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un producto", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (decimal.Parse(txtCantidad.Text) <= 0 || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Ingrese una cantidad", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (TipoOC == 2 && decimal.Parse(txtPrecio.Text) <= 0 || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese un precio", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (TipoOC == 1 && (cboUnidad.SelectedValue is null || int.Parse(cboUnidad.SelectedValue.ToString()) < 0))
                {
                    MessageBox.Show("Seleccione una Unidad de Combustible", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvDetOrden.Rows.Count >= MaxItems)
                {
                    MessageBox.Show("Ha llegado a la cantidad máxima de productos permitidos al proveedor: " + cboProveedor.Text, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvDetOrden.Rows)
                    {
                        if (int.Parse(row.Cells["IdVehiculo"].Value.ToString()) == int.Parse(cboVehiculo.SelectedValue.ToString()) && int.Parse(row.Cells["IdProducto"].Value.ToString()) == int.Parse(cboProducto.SelectedValue.ToString()) && int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0)
                        {
                            MessageBox.Show("El vehículo y el producto seleccionado ya existe", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    decimal precio = TipoOC == 1 || TipoOC == 4 ? 0 : decimal.Parse(txtPrecio.Text);
                    int unidad = TipoOC == 1 ? int.Parse(cboUnidad.SelectedValue.ToString()) : 0;
                    if (TipoOC == 1)
                    {
                        string solicitado = VarGlobales.consultasOC.OC_MotoristaObtener(int.Parse(cboVehiculo.SelectedValue.ToString())).ToString();
                        txtSolicitado.Text = solicitado;
                    }
                    dgvDetOrden.Rows.Add(int.Parse(cboVehiculo.SelectedValue.ToString()), int.Parse(cboProducto.SelectedValue.ToString()), decimal.Parse(txtCantidad.Text), precio, TipoOC == 4 ? 0 : decimal.Parse(txtISV.Text), TipoOC == 4 ? 0 : decimal.Parse(txtISV.Text) + (decimal.Parse(txtCantidad.Text) * precio), txtObservacionServicio.Text, 0, unidad);
                    limpiarDetalle();
                    cboVehiculo.Focus();
                    CalcularTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiarDetalle()
        {
            cboProducto.SelectedIndex = -1;
            txtCantidad.Text = "1";
            txtPrecio.Text = "0.0000";
            txtISV.Text = "0.0000";
        }

        void obtenerTipoOC()
        {
            if (int.Parse(cboTipoOC.SelectedIndex.ToString()) != -1)
            {
                int resul = int.Parse(VarGlobales.consultasOC.OC_TipoOrdenObtener(int.Parse(cboTipoOC.SelectedValue.ToString())).ToString());
                TipoOC = resul;

                txtObservacionServicio.Visible = TipoOC == 3 ? true : false;
                lblObsServicio.Visible = TipoOC == 3 ? true : false;
                txtObservacionServicio.Text = TipoOC == 3 ? txtObservacionServicio.Text : string.Empty;
                dgvDetOrden.Columns["Observacion"].Visible = TipoOC == 3 ? true : false;
                lblFEstimada.Visible = TipoOC == 4 ? true : false;
                dtpFechaEstimada.Visible = TipoOC == 4 ? true : false;

                if (resul == 1)
                {
                    lblISV.Visible = false;
                    lblPrecio.Visible = false;
                    txtPrecio.Visible = false;
                    txtISV.Visible = false;
                    dgvDetOrden.Columns["Precio"].Visible = false;
                    dgvDetOrden.Columns["ISV"].Visible = false;
                    dgvDetOrden.Columns["Unidad"].Visible = true;
                    txtSolicitado.Enabled = false;
                    lblClaTra.Visible = true;
                    lblDepartamento.Visible = true;
                    cboClaTra.Visible = true;
                    cboDepartamento.Visible = true;
                    chkAplicaISV.Checked = false;
                    chkAplicaISV.Visible = false;
                    txtPrecio.Text = "0";
                    txtISV.Text = "0";
                    lblUnidad.Visible = true;
                    cboUnidad.Visible = true;
                    ckbVehiculos.Checked = false;
                    ckbVehiculos.Visible = false;
                    txtObservaciones.Text = "";
                }
                else
                {
                    lblISV.Visible = true;
                    lblPrecio.Visible = true;
                    txtPrecio.Visible = true;
                    txtISV.Visible = true;
                    dgvDetOrden.Columns["Precio"].Visible = true;
                    dgvDetOrden.Columns["ISV"].Visible = true;
                    dgvDetOrden.Columns["Unidad"].Visible = false;
                    txtSolicitado.Enabled = true;
                    lblClaTra.Visible = false;
                    lblDepartamento.Visible = false;
                    cboClaTra.Visible = false;
                    cboDepartamento.Visible = false;
                    cboClaTra.SelectedIndex = -1;
                    cboDepartamento.SelectedIndex = -1;
                    chkAplicaISV.Checked = true;
                    chkAplicaISV.Visible = true;
                    lblUnidad.Visible = false;
                    cboUnidad.Visible = false;

                    if (resul == 4)
                    {
                        txtObservacionServicio.Visible = true;
                        lblObsServicio.Visible = true;
                        txtObservacionServicio.Text = string.Empty;
                        dgvDetOrden.Columns["Precio"].Visible = false;
                        dgvDetOrden.Columns["ISV"].Visible = false;
                        dgvDetOrden.Columns["Observacion"].Visible = true;
                        chkAplicaISV.Checked = false;
                        chkAplicaISV.Visible = false;
                        lblISV.Visible = false;
                        txtISV.Visible = false;
                        lblPrecio.Visible = false;
                        txtPrecio.Visible = false;
                        txtPrecio.Text = "0";
                        txtISV.Text = "0";
                    }

                    if (resul == 2)
                    {
                        ckbVehiculos.Visible = true;
                    }
                    else
                    {
                        ckbVehiculos.Checked = false;
                        ckbVehiculos.Visible = false;
                        txtObservaciones.Text = "";
                    }
                }
            }
        }

        private void dgvDetOrden_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoOC.SelectedValue is null || int.Parse(cboTipoOC.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Tipo de Orden", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboProveedor.SelectedValue is null || int.Parse(cboProveedor.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Proveedor", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((cboClaTra.SelectedValue is null || int.Parse(cboClaTra.SelectedValue.ToString()) < 0) && TipoOC == 1)
                {
                    MessageBox.Show("Debe seleccionar una Clase de Trabajo", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((cboDepartamento.SelectedValue is null || int.Parse(cboDepartamento.SelectedValue.ToString()) < 0) && TipoOC == 1)
                {
                    MessageBox.Show("Debe seleccionar un Departamento", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvDetOrden.Rows.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un item al detalle", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtSolicitado.Text))
                {
                    MessageBox.Show("Debe ingresar el Solicitante", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((dtpFecha.Value.Date > DateTime.Now.Date) && chkOmitirFecha.Checked == false)
                {
                    MessageBox.Show("La fecha ingresada no puede ser mayor a la fecha actual", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (cboResponsable.SelectedValue is null || int.Parse(cboResponsable.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Debe ingresar el Responsable", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    decimal cantTotal = 0, cantTotalFormat = 0;
                    if (Actualizar == 0)
                    {
                        decimal isv = TipoOC == 1 ? 0 : decimal.Parse(txtISV.Text);
                        if (MessageBox.Show("Seguro desea agregar esta Orden?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int IdOC = int.Parse(VarGlobales.consultasOC.OC_OrdenTrabajoInsert_v2(0, dtpFecha.Value.Date,
                                                                                                         int.Parse(cboTipoOC.SelectedValue.ToString()),
                                                                                                         int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                                                         txtObservaciones.Text,
                                                                                                         VarGlobales.Usuario,
                                                                                                         Environment.MachineName,
                                                                                                         cboDepartamento.SelectedIndex == -1 ? 0 : int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                                                         cboClaTra.SelectedIndex == -1 ? 0 : int.Parse(cboClaTra.SelectedValue.ToString()),
                                                                                                         txtSolicitado.Text,
                                                                                                         int.Parse(cboResponsable.SelectedValue.ToString()),
                                                                                                         Convert.ToBoolean(ckbGuardarCor.Checked),
                                                                                                         dtpFechaEstimada.Value.Date).ToString());


                            foreach (DataGridViewRow row in dgvDetOrden.Rows)
                            {
                                VarGlobales.consultasOC.OC_OrdenTrabajoDetInsert(IdOC, int.Parse(row.Cells["IdVehiculo"].Value.ToString()),
                                                                                              int.Parse(row.Cells["IdProducto"].Value.ToString()),
                                                                                              decimal.Parse(row.Cells["Cantidad"].Value.ToString()),
                                                                                              decimal.Parse(row.Cells["Precio"].Value.ToString()),
                                                                                              decimal.Parse(row.Cells["ISV"].Value.ToString()),
                                                                                              (decimal.Parse(row.Cells["Cantidad"].Value.ToString()) * decimal.Parse(row.Cells["Precio"].Value.ToString())) + decimal.Parse(row.Cells["ISV"].Value.ToString()),
                                                                                              row.Cells["Observacion"].Value.ToString(),
                                                                                              int.Parse(row.Cells["Unidad"].Value.ToString()));
                            }

                            MessageBox.Show("Orden agregada exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);



                            if (ckbGuardarCor.Checked == false && ckbGuardarCor.Enabled == true)
                            {
                                if (int.Parse(cboTipoOC.SelectedValue.ToString()) != 4)
                                {
                                    Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(IdOC,
                                                                                                                "",
                                                                                                                "",
                                                                                                                0,
                                                                                                                0,
                                                                                                                "",
                                                                                                                "",
                                                                                                                "",
                                                                                                                0,
                                                                                                                0,
                                                                                                                "",
                                                                                                                true);
                                    reporte.ShowDialog();
                                }
                                else
                                {
                                    if (dgvDetOrden.Rows.Count > 0)
                                    {
                                        DataGridViewRow row = dgvDetOrden.Rows[0];
                                        var codveh = row.Cells["IdVehiculo"].FormattedValue.ToString();
                                        var obs = row.Cells["Observacion"].FormattedValue.ToString();
                                        enviarcorreo(codveh, dtpFecha.Value.Date, dtpFechaEstimada.Value.Date, lblCorrelativo.Text, obs);
                                    }
                                }
                            }

                            limpiarDatos();
                            CalcularTotal();
                            IdTipoOC = 0;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro desea actualizar esta Orden?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            decimal isv = TipoOC == 1 ? 0 : decimal.Parse(txtISV.Text);
                            foreach (DataGridViewRow row in dgvDetOrden.Rows)
                            {
                                if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 1)
                                {
                                    VarGlobales.consultasOC.OC_OrdenTrabajoDetDelete(Actualizar, int.Parse(row.Cells["IdVehiculo"].Value.ToString()), int.Parse(row.Cells["IdProducto"].Value.ToString()));
                                }
                            }

                            int IdOC = int.Parse(VarGlobales.consultasOC.OC_OrdenTrabajoInsert_v2(Actualizar, dtpFecha.Value.Date,
                                                                                                                  int.Parse(cboTipoOC.SelectedValue.ToString()),
                                                                                                                  int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                                                                  txtObservaciones.Text,
                                                                                                                  VarGlobales.Usuario,
                                                                                                                  Environment.MachineName,
                                                                                                                  cboDepartamento.SelectedIndex == -1 ? 0 : int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                                                                  cboClaTra.SelectedIndex == -1 ? 0 : int.Parse(cboClaTra.SelectedValue.ToString()),
                                                                                                                  txtSolicitado.Text,
                                                                                                                  int.Parse(cboResponsable.SelectedValue.ToString()),
                                                                                                                  Convert.ToBoolean(ckbGuardarCor.Checked),
                                                                                                                  dtpFechaEstimada.Value.Date).ToString());

                            foreach (DataGridViewRow row in dgvDetOrden.Rows)
                            {

                                if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0)
                                {
                                    VarGlobales.consultasOC.OC_OrdenTrabajoDetInsert(IdOC, int.Parse(row.Cells["IdVehiculo"].Value.ToString()),
                                                                                                  int.Parse(row.Cells["IdProducto"].Value.ToString()),
                                                                                                  decimal.Parse(row.Cells["Cantidad"].Value.ToString()),
                                                                                                  decimal.Parse(row.Cells["Precio"].Value.ToString()),
                                                                                                  decimal.Parse(row.Cells["ISV"].Value.ToString()),
                                                                                                  (decimal.Parse(row.Cells["Cantidad"].Value.ToString()) * decimal.Parse(row.Cells["Precio"].Value.ToString())) + decimal.Parse(row.Cells["ISV"].Value.ToString()),
                                                                                                  row.Cells["Observacion"].Value.ToString(),
                                                                                                  int.Parse(row.Cells["Unidad"].Value.ToString()));
                                }
                            }
                            MessageBox.Show("Orden actualizada exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (ckbGuardarCor.Visible == true && ckbGuardarCor.Checked == false && ckbGuardarCor.Enabled == true)
                            {
                                if (int.Parse(cboTipoOC.SelectedValue.ToString()) != 4)
                                {
                                    Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(IdOC,
                                                                                "",
                                                                                "",
                                                                                0,
                                                                                0,
                                                                                "",
                                                                                "",
                                                                                "",
                                                                                0,
                                                                                0,
                                                                                "",
                                                                                true);
                                    reporte.ShowDialog();
                                }
                                else
                                {
                                    if (dgvDetOrden.Rows.Count > 0)
                                    {
                                        DataGridViewRow row = dgvDetOrden.Rows[0];
                                        var codveh = row.Cells["IdVehiculo"].FormattedValue.ToString();
                                        var obs = row.Cells["Observacion"].FormattedValue.ToString();
                                        enviarcorreo(codveh, dtpFecha.Value.Date, dtpFechaEstimada.Value.Date, lblCorrelativo.Text, obs);
                                    }
                                }
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enviarcorreo(string codveh, DateTime fecha, DateTime fechaEstimada, string correlativo, string obs)
        {
            // Creación del correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("serviciosadiggm@adiggm.hn", "Servidor A.D.I.-GGM");

            // Añadir destinatarios
            mail.To.Add("dperdomo@adiggm.hn");
            mail.To.Add("jflores@adiggm.hn");
            mail.To.Add("nflores@adiggm.hn");
            mail.To.Add("fmercado@adiggm.hn");
            mail.To.Add("glrivera@granjasmarinas.com");
            mail.To.Add("jportillo@adiggm.hn");
            // Puedes agregar tantos destinatarios como desees.

            // Configuración del correo
            mail.Subject = "Nueva requisición para la unidad: " + codveh;
            mail.IsBodyHtml = true;  // Esto permite el formato HTML

            mail.Body = $"<html><body><div style='text-align: center;'>" +
                        $"<h1>Detalles de la requisición</h1>" +
                        $"<table border='1' style='margin: 0 auto;'>" +
                        $"<tr><th>Consecutivo</th><th>Unidad</th><th>Fecha Ingreso</th><th>Fecha Estimada</th><th>Dias Estimados</th><th>Descripción</th></tr>" +
                        $"<tr><td>{correlativo}</td><td>{codveh}</td><td>{fecha:d}</td><td>{fechaEstimada:d}</td><td>{(fechaEstimada - fecha).Days}</td><td>{obs}</td></tr>" +
                        $"</table></div></body></html>";

            // Creación del cliente SMTP
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("serviciosadiggm@adiggm.hn", "serviciosadi@2020");
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;

            // Enviar el correo
            client.Send(mail);
        }
    
        private void dgvDetOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetOrden.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == dgvDetOrden.Columns["Quitar"].Index)
                {
                    if (MessageBox.Show("Seguro deseas quitar este vehículo?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Actualizar == 0)
                        {
                            dgvDetOrden.Rows.Remove(dgvDetOrden.CurrentRow);
                            CalcularTotal();
                            if (TipoOC == 1)
                            {
                                txtSolicitado.Text = string.Empty;
                            }
                        }
                        else
                        {
                            dgvDetOrden.CurrentRow.Cells["Eliminar"].Value = 1;
                            if (this.dgvDetOrden.CurrentRow != null) //Averiguar si se seleccionó un campo en el Datagridview
                            {
                                dgvDetOrden.Rows[dgvDetOrden.CurrentRow.Index].Visible = false;
                            }

                            CalcularTotal();
                            if (TipoOC == 1)
                            {
                                txtSolicitado.Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }

        void limpiarDatos()
        {
            dtpFecha.Value = DateTime.Now.Date;
            cboTipoOC.SelectedIndex = -1;
            cboProveedor.SelectedIndex = -1;
            txtObservaciones.Text = string.Empty;
            txtSolicitado.Text = string.Empty;
            cboClaTra.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;
            dgvDetOrden.DataSource = null;
            dgvDetOrden.Rows.Clear();
            txtObservacionServicio.Text = string.Empty;
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex != -1)
            {
                decimal precio = decimal.Parse(VarGlobales.consultasOC.OC_UltimoPrecio(int.Parse(cboProducto.SelectedValue.ToString())).ToString());
                txtPrecio.Text = TipoOC == 4 ? "0.0" : precio.ToString("N4");

                chkAplicaISV.Checked = TipoOC == 4 ? false : true;

                decimal isv = (txtCantidad.Text == string.Empty ? 0 : decimal.Parse(txtCantidad.Text)) * (txtPrecio.Text == string.Empty ? 0 : decimal.Parse(txtPrecio.Text)) * decimal.Parse(VarGlobales.consultasOC.OC_ISVObtener().ToString());
                txtISV.Text = TipoOC == 1 || TipoOC == 4 ? "0.0" : isv.ToString("N4");

                if (Actualizar < 1 && ckbVehiculos.Checked == true)
                {
                    cargarFlota();
                    CalcularTotal();
                }
            }
        }
        private void cboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVehiculo.SelectedIndex != -1)
            {
                string infoVeh = VarGlobales.consultasOC.OC_InfoVehObtener(int.Parse(cboVehiculo.SelectedValue.ToString())).ToString();
                lblInformacionVeh.Text = infoVeh;
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (chkAplicaISV.Checked == true)
            {
                decimal isv = (txtCantidad.Text == string.Empty ? 0 : decimal.Parse(txtCantidad.Text)) * (txtPrecio.Text == string.Empty ? 0 : decimal.Parse(txtPrecio.Text)) * decimal.Parse(VarGlobales.consultasOC.OC_ISVObtener().ToString());
                txtISV.Text = TipoOC == 1 ? "0.0" : isv.ToString("N4");
            }
            else
            {
                txtISV.Text = 0.ToString("N4");
            }
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (chkAplicaISV.Checked == true)
            {
                decimal isv = (txtCantidad.Text == string.Empty ? 0 : decimal.Parse(txtCantidad.Text)) * (txtPrecio.Text == string.Empty ? 0 : decimal.Parse(txtPrecio.Text)) * decimal.Parse(VarGlobales.consultasOC.OC_ISVObtener().ToString());
                txtISV.Text = TipoOC == 1 ? "0.0" : isv.ToString("N4");
            }
            else
            {
                txtISV.Text = 0.ToString("N4");
            }
        }
        private void chkAplicaISV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAplicaISV.Checked == true)
            {
                decimal isv = (txtCantidad.Text == string.Empty ? 0 : decimal.Parse(txtCantidad.Text)) * (txtPrecio.Text == string.Empty ? 0 : decimal.Parse(txtPrecio.Text)) * decimal.Parse(VarGlobales.consultasOC.OC_ISVObtener().ToString());
                txtISV.Text = TipoOC == 1 ? "0.0" : isv.ToString("N4");
            }
            else
            {
                txtISV.Text = 0.ToString("N4");
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtCantidad); //llamada a la función que evalúa que tecla es aceptada
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtPrecio); //llamada a la función que evalúa que tecla es aceptada
        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboCategoria.SelectedIndex.ToString()) != -1)
            {
                this.oC_ProductosTableAdapter.FillByActivos(this.dsOC.OC_Productos, int.Parse(cboCategoria.SelectedValue.ToString()));
                if (cboProducto.SelectedIndex != -1)
                {
                    decimal precio = decimal.Parse(VarGlobales.consultasOC.OC_UltimoPrecio(int.Parse(cboProducto.SelectedValue.ToString())).ToString());
                    txtPrecio.Text = precio.ToString("N4");
                }
                if (Actualizar < 1 && ckbVehiculos.Checked == true)
                {
                    cargarFlota();
                    CalcularTotal();
                }
            }
        }
        private void cargarFlota()
        {
            if (ckbVehiculos.Checked == true)
            {
                dgvDetOrden.DataSource = null;
                dgvDetOrden.Rows.Clear();
                dgvDetOrden.EditMode = DataGridViewEditMode.EditOnEnter;

                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("Select IdVehiculo, " + cboProducto.SelectedValue.ToString() + " IdProducto, 0.0000 Cantidad, " + Convert.ToDecimal(txtPrecio.Text) + " Precio, 0.0000 ISV, 0.0000 Total, '' Observacion, 0 Eliminar, 0 Unidad FROM TR_Vehiculos WHERE Activo = 1 AND IdContratista = 12 AND IdTipoVehiculo <> 10", conn); ;

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvDetOrden.AutoGenerateColumns = false;
                            dgvDetOrden.DataSource = dt;
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dgvDetOrden.DataSource = null;
                dgvDetOrden.Rows.Clear();
            }
        }
        private void ckbVehiculos_CheckedChanged(object sender, EventArgs e)
        {
            cargarFlota();
            CalcularTotal();
        }

        private void chkOmitirFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        void CalcularTotal()
        {
            decimal total = 0, isv = 0;

            if ((ckbVehiculos.Checked == true || ckbVehiculosEdit.Checked == true) && Convert.ToDecimal(txtPrecio.Text) > 0)
            {
                decimal Total;
                int numItems = 0;

                foreach (DataGridViewRow row in dgvDetOrden.Rows)
                {
                    
                    if (int.Parse(row.Cells["Eliminar"].Value.ToString()) != 1)
                    {
                        numItems++;
                    }
                }                

                decimal cantTotal = 0;
                StringBuilder sb = new StringBuilder();

                if (chkAplicaISV.Checked == true)
                {
                    Total = (Convert.ToDecimal(txtPrecio.Text) / numItems) * Convert.ToDecimal(ISVP + 1);
                }
                else
                {
                    Total = Convert.ToDecimal(txtPrecio.Text) / numItems;
                }

                foreach (DataGridViewRow row in dgvDetOrden.Rows)
                {
                    dgvDetOrden.Rows[row.Index].Cells["Total"].Value = Total;

                    sb.Append(string.Format("{0}, ", row.Cells["IdVehiculo"].FormattedValue));

                    if (chkAplicaISV.Checked == true)
                    {
                        dgvDetOrden.Rows[row.Index].Cells["ISV"].Value = (Total / Convert.ToDecimal(ISVP + 1)) * ISVP;
                        dgvDetOrden.Rows[row.Index].Cells["Cantidad"].Value = (Total / Convert.ToDecimal(txtPrecio.Text)) / Convert.ToDecimal(ISVP + 1);
                    }
                    else
                    {
                        dgvDetOrden.Rows[row.Index].Cells["ISV"].Value = 0;
                        dgvDetOrden.Rows[row.Index].Cells["Cantidad"].Value = Convert.ToDecimal(dgvDetOrden.Rows[row.Index].Cells["Total"].Value) / Convert.ToDecimal(txtPrecio.Text);
                    }
                }
                txtObservaciones.Text = "CARGO A: " + sb.ToString();
            }

            foreach (DataGridViewRow row in dgvDetOrden.Rows)
            {
                if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0)
                {
                    total += decimal.Parse(row.Cells["Cantidad"].Value.ToString()) * decimal.Parse(row.Cells["Precio"].Value.ToString());
                    isv += decimal.Parse(row.Cells["ISV"].Value.ToString());
                }
            }
            lblTotal.Text = "Sub-Total: " + total.ToString("N4") + " ISV: " + isv.ToString("N4") + " Total: " + (total + isv).ToString("N4");
        }
        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdProveedor == 0 && cboProveedor.SelectedIndex != -1)
            {
                IdProveedor = (int)cboProveedor.SelectedValue;
            }

            if (cboProveedor.SelectedIndex != -1)
            {
                if (IdProveedor > 0 && IdProveedor != int.Parse(cboProveedor.SelectedValue.ToString()) && dgvDetOrden.Rows.Count > 0)
                {
                    if (MessageBox.Show("Si cambia el Proveedor se eliminara el detalle, ¿Desea continuar?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvDetOrden.Rows.Clear();
                        IdProveedor = (int)cboProveedor.SelectedValue;
                        obtenerTipoOC();
                        CalcularTotal();
                        string maxItems = VarGlobales.consultasOC.OC_ObtenerMaxItems(int.Parse(cboProveedor.SelectedValue.ToString())).ToString();
                        lblMaxItems.Text = "Cantidad Maxima de Productos: " + maxItems;
                        MaxItems = int.Parse(maxItems);
                    }
                    else
                    {
                        cboProveedor.SelectedValue = IdProveedor;
                    }
                }
                else
                {
                    string maxItems = VarGlobales.consultasOC.OC_ObtenerMaxItems(int.Parse(cboProveedor.SelectedValue.ToString())).ToString();
                    lblMaxItems.Text = "Cantidad Maxima de Productos: " + maxItems;
                    MaxItems = int.Parse(maxItems);
                }
            }
        }
        void cargarDatos()
        {
            DataSets.DsOCTableAdapters.OC_OrdenCompraTableAdapter ta = new DataSets.DsOCTableAdapters.OC_OrdenCompraTableAdapter();
            DataSets.DsOC.OC_OrdenCompraDataTable dt = new DataSets.DsOC.OC_OrdenCompraDataTable();
            ta.Fill(dt, Actualizar);

            DataSets.DsOCTableAdapters.OC_OrdenCompraDetTableAdapter ta2 = new DataSets.DsOCTableAdapters.OC_OrdenCompraDetTableAdapter();
            DataSets.DsOC.OC_OrdenCompraDetDataTable dt2 = new DataSets.DsOC.OC_OrdenCompraDetDataTable();
            ta2.Fill(dt2, Actualizar);

            if (dt.Rows.Count > 0)
            {
                foreach (DataSets.DsOC.OC_OrdenCompraRow row in dt.Rows)
                {
                    dtpFecha.Value = row.Fecha.Date;
                    cboTipoOC.SelectedValue = row.IdTipoOC;
                    cboProveedor.SelectedValue = row.IdProveedor;
                    txtObservaciones.Text = row.Observaciones;
                    txtSolicitado.Text = row.Solicitado;
                    cboDepartamento.SelectedValue = row.IdDepartamento;
                    cboClaTra.SelectedValue = row.IdClaTra;
                    cboResponsable.SelectedValue = row.IdResponsableFirma;
                    ckbGuardarCor.Checked = row.Apartado;
                    if (row.FechaEstimada != null)
                    {
                        dtpFechaEstimada.Value = row.FechaEstimada.Date;
                    }
                    else
                    {
                        // Código para manejar el caso cuando FechaEstimada es nulo, 
                        // por ejemplo asignar un valor predeterminado.
                        dtpFechaEstimada.Value = DateTime.Now; // Valor predeterminado, en este caso la fecha actual.
                    }

                }
                if (ckbGuardarCor.Checked == false)
                {
                    ckbGuardarCor.Visible = false;
                }
            }

            if (dt2.Rows.Count > 0)
            {
                foreach (DataSets.DsOC.OC_OrdenCompraDetRow row in dt2.Rows)
                {
                    dgvDetOrden.Rows.Add(int.Parse(row.IdVehiculo.ToString()), int.Parse(row.IdProducto.ToString()), decimal.Parse(row.Cantidad.ToString()), decimal.Parse(row.Precio.ToString()), decimal.Parse(row.ISV.ToString()), decimal.Parse(row.Total.ToString()), row.DescripcionServicio.ToString(), 0, int.Parse(row.IdUnidad.ToString()));
                }
            }
            CalcularTotal();
        }
        public bool solonumeros(int code, TextBox txt)
        {
            bool resultado;

            if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((code >= 48 && code <= 57) || (code == 8) || code == 46) //se evaluan las teclas válidas
            {
                resultado = false;
            }
            else if (!permitir)
            {
                resultado = permitir;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }
    }
}