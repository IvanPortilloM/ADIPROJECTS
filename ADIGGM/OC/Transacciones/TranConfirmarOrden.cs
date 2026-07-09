using System;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;

namespace ADIGGM.OC.Transacciones
{
    public partial class TranConfirmarOrden : FrmPrincipal
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        // ListarProductosConTodos/ObtenerIsvPorcentaje viven en RepositorioInventario (SPs OC_* que ese
        // módulo también usa); se reubicarán a RepositorioOC al cerrar DsOC (nota en el propio repo).
        private readonly RepositorioInventario _repoInv = new RepositorioInventario();

        int IdOC = 0, TipoOC = 0;
        public decimal ISVP = 0;
        bool PermitirCant = true;
        public TranConfirmarOrden(int IdOC)
        {
            InitializeComponent();
            this.IdOC = IdOC;
            ConfigurarColumnas();
        }

        /// <summary>Columnas de los DOS grids EN CÓDIGO (gotcha §11), con los Names EXACTOS que el resto
        /// del .cs referencia por Cells["..."]. dgvOCDet1 = detalle solicitado (grid ReadOnly de diseño);
        /// dgvOCDet2 = detalle a confirmar (editable; ISV/Total se bloquean en Load y los libera chkISV;
        /// idProducto es combo EDITABLE — permite sustituir el producto al confirmar). Los DataSource de
        /// las 4 columnas combo se asignan en el Load tras poblar sus BindingSource.</summary>
        private void ConfigurarColumnas()
        {
            dgvOCDet1.AutoGenerateColumns = false;
            dgvOCDet1.Columns.Clear();
            dgvOCDet1.Columns.Add(GridColumnas.Combo("idVehiculoDataGridViewTextBoxColumn1", "IdVehiculo", "Vehiculo", "Vehiculo", "IdVehiculo", width: 78, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvOCDet1.Columns.Add(GridColumnas.Combo("idProductoDataGridViewTextBoxColumn1", "IdProducto", "Producto", "Producto", "IdProducto"));
            dgvOCDet1.Columns.Add(GridColumnas.Texto("cantidadDGV", "Cantidad", "Cantidad", format: "N2"));
            dgvOCDet1.Columns.Add(GridColumnas.Texto("precioDGV", "Precio", "Precio", format: "N4"));
            dgvOCDet1.Columns.Add(GridColumnas.Texto("iSVDGV", "ISV", "ISV", format: "N4"));
            dgvOCDet1.Columns.Add(GridColumnas.Texto("totalDGV", "Total", "Total", format: "N4"));

            dgvOCDet2.AutoGenerateColumns = false;
            dgvOCDet2.Columns.Clear();
            dgvOCDet2.Columns.Add(GridColumnas.Combo("idVehiculo", "IdVehiculo", "Vehiculo", "Vehiculo", "IdVehiculo", width: 59, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader));
            dgvOCDet2.Columns.Add(GridColumnas.Combo("idProducto", "IdProducto", "Producto", "Producto", "IdProducto", readOnly: false));
            ((DataGridViewComboBoxColumn)dgvOCDet2.Columns["idProducto"]).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            dgvOCDet2.Columns.Add(GridColumnas.Texto("Cantidad", "Cantidad", "Cantidad", format: "N2", width: 67, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader, readOnly: false));
            dgvOCDet2.Columns.Add(GridColumnas.Texto("Precio", "Precio", "Precio", format: "N2", readOnly: false));
            dgvOCDet2.Columns.Add(GridColumnas.Check("Aplica", "Aplica", "ISV", width: 29, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader, readOnly: false));
            dgvOCDet2.Columns.Add(GridColumnas.Texto("ISV", "ISV", "ISV", format: "N2", readOnly: false));
            dgvOCDet2.Columns.Add(GridColumnas.Texto("Total", "Total", "Total", format: "N4", readOnly: false));
            dgvOCDet2.Columns.Add(GridColumnas.Texto("IdProductoOriginal", "IdProductoOriginal", "IdProductoOriginal", visible: false));
            dgvOCDet2.Columns.Add(GridColumnas.Check("Conf", "", "Conf", width: 39, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader, readOnly: false));
            dgvOCDet2.Columns.Add(GridColumnas.Texto("Descuento", "", "Descuento", format: "N2", readOnly: false));
        }

        private void TranConfirmarOrden_Load(object sender, EventArgs e)
        {
            // Tipo de orden e ISV PRIMERO: los cálculos que disparan los bindings de abajo los usan.
            // (El flujo original los cargaba al final, por lo que los primeros recálculos corrían con
            // TipoOC=0; ahora todos los recálculos usan los valores correctos desde el inicio.)
            TipoOC = _repoOC.ObtenerTipoOrden(IdOC);
            ISVP = _repoInv.ObtenerIsvPorcentaje();

            oCProveedoresCAIBindingSource.DataMember = "";
            oCProveedoresCAIBindingSource.DataSource = _repoOC.ListarCaiProveedorPorOrden(IdOC);
            // Binding de lblFLimite recreado en código (el de diseño quedaría huérfano — gotcha §11)
            lblFLimite.DataBindings.Clear();
            lblFLimite.DataBindings.Add(new Binding("Text", oCProveedoresCAIBindingSource, "FechaLimite", true, DataSourceUpdateMode.OnValidation, null, "d"));

            oCUnidadKilometrajeBindingSource.DataMember = "";
            oCUnidadKilometrajeBindingSource.DataSource = _repoOC.ListarUnidadesRecorrido();
            cboUnidad.SelectedIndex = -1;
            tRVehiculosBindingSource.DataMember = "";
            tRVehiculosBindingSource.DataSource = _repoOC.ListarVehiculosDeOrden(IdOC);
            cboVeh.SelectedIndex = 0;
            oCProductosBindingSource.DataMember = "";
            oCProductosBindingSource.DataSource = _repoInv.ListarProductosConTodos();

            // Los DataSource de las columnas combo van ANTES de enlazar los grids (si no, los valores
            // no encontrados en la lista disparan DataError).
            ((DataGridViewComboBoxColumn)dgvOCDet1.Columns["idVehiculoDataGridViewTextBoxColumn1"]).DataSource = tRVehiculosBindingSource;
            ((DataGridViewComboBoxColumn)dgvOCDet1.Columns["idProductoDataGridViewTextBoxColumn1"]).DataSource = oCProductosBindingSource;
            ((DataGridViewComboBoxColumn)dgvOCDet2.Columns["idVehiculo"]).DataSource = tRVehiculosBindingSource;
            ((DataGridViewComboBoxColumn)dgvOCDet2.Columns["idProducto"]).DataSource = oCProductosBindingSource;

            oCOrdenDetObtenerBindingSource.DataMember = "";
            oCOrdenDetObtenerBindingSource.DataSource = _repoOC.ObtenerDetalleOrden(IdOC);
            dgvOCDet1.DataSource = oCOrdenDetObtenerBindingSource;
            oCOrdenDetObtener1BindingSource.DataMember = "";
            oCOrdenDetObtener1BindingSource.DataSource = _repoOC.ObtenerDetalleOrden(IdOC);
            dgvOCDet2.DataSource = oCOrdenDetObtener1BindingSource;
            CalcularTotal();

            string fecha, tipooc, proveedor, observaciones, solicitante, odometro, proximoCambio, aplicaCambio;
            _repoOC.ObtenerEncabezadoOrden(IdOC, out fecha, out tipooc, out proveedor, out observaciones, out solicitante, out odometro, out proximoCambio, out aplicaCambio);

            lblFecha.Text = fecha;
            lblTipoOC.Text = tipooc;
            lblProveedor.Text = proveedor;
            lblObservaciones.Text = observaciones;
            lblSolicitante.Text = solicitante;
            txtOdometro.Text = odometro;
            txtProxCambio.Text = proximoCambio;
            ckbCambioAceite.Checked = Convert.ToBoolean(Convert.ToInt32(aplicaCambio));
            dgvOCDet2.Columns["Descuento"].Visible = false;
            dgvOCDet2.Columns["ISV"].ReadOnly = true;
            dgvOCDet2.Columns["Total"].ReadOnly = true;

            foreach (DataGridViewRow row in dgvOCDet2.Rows)
            {
                row.Cells["Conf"].Value = true;
                dgvOCDet2.Rows[row.Index].Cells["Descuento"].Value = 0;
            }

            if (chkDesc.Checked == false)
            {
                txtDescuento.Text = "0.00";
            }
            obtenerTipoOC();
        }

        void CalcularTotal()
        {
            // (El original consultaba aquí el SP OC_ISVObtener en una variable que nunca se usaba:
            // un viaje a la BD por cada recálculo, eliminado. ISVP se carga UNA vez en el Load.)
            decimal total1 = 0, isv1 = 0, subtotal1 = 0, total2 = 0, isv2 = 0, subtotal2 = 0, descuento;

            foreach (DataGridViewRow row in dgvOCDet1.Rows)
            {
                subtotal1 += TipoOC == 1 ? decimal.Parse(row.Cells["cantidadDGV"].Value.ToString()) : decimal.Parse(row.Cells["cantidadDGV"].Value.ToString()) * decimal.Parse(row.Cells["precioDGV"].Value.ToString());
                isv1 += row.Cells["iSVDGV"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["iSVDGV"].Value.ToString());
                total1 += decimal.Parse(row.Cells["totalDGV"].Value.ToString());
            }
            foreach (DataGridViewRow row in dgvOCDet2.Rows)
            {
                subtotal2 += TipoOC == 1 ? decimal.Parse(row.Cells["Cantidad"].Value.ToString()) : (row.Cells["Cantidad"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["Cantidad"].Value.ToString())) * (row.Cells["Precio"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["Precio"].Value.ToString()));
                isv2 += (row.Cells["ISV"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["ISV"].Value.ToString()));
                total2 += row.Cells["Total"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["Total"].Value.ToString());
            }
            if (chkDesc.Checked == false)
            {
                txtDescuento.Text = "0.00";
            }
            else { 
            descuento = Convert.ToDecimal(txtDescuento.Text);
            subtotal2 -= descuento;
            total2 = subtotal2 + isv2; 
            }
            lblTotal1.Text = "Sub-Total: " + subtotal1.ToString("N2") + " ISV: " + isv1.ToString("N2") + " Total: " + total1.ToString("N2");
            lblTotal2.Text = "Sub-Total: " + subtotal2.ToString("N2") + " ISV: " + isv2.ToString("N2") + " Total: " + total2.ToString("N2");
        }
        private void dgvOCDet2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (TipoOC != 1)
            {
                if ((dgvOCDet2.Columns[e.ColumnIndex].Name == "Cantidad" || dgvOCDet2.Columns[e.ColumnIndex].Name == "Precio" || dgvOCDet2.Columns[e.ColumnIndex].Name == "Aplica" || dgvOCDet2.Columns[e.ColumnIndex].Name == "Descuento") && chkISV.Checked == false)
                {
                    decimal isv;
                    if (bool.Parse(dgvOCDet2.Rows[e.RowIndex].Cells["Aplica"].Value.ToString()) == true)
                    {
                        isv = TipoOC == 1 ? 0 : ISVP;   // ISVP cacheado en el Load (antes: SP por celda editada)
                    }
                    else
                    {
                        isv = 0;
                    }
                    decimal cantidad = dgvOCDet2.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString() == string.Empty ? 0 : decimal.Parse(dgvOCDet2.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    decimal precio = dgvOCDet2.Rows[e.RowIndex].Cells["Precio"].Value.ToString() == string.Empty ? 0 : decimal.Parse(dgvOCDet2.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
                    decimal descuento = dgvOCDet2.Rows[e.RowIndex].Cells["Descuento"].Value.ToString() == string.Empty ? 0 : decimal.Parse(dgvOCDet2.Rows[e.RowIndex].Cells["Descuento"].Value.ToString());
                    
                    decimal resultado = ((cantidad * precio) - descuento) + ((cantidad * precio) - descuento) * isv;
                    decimal isv1 = ((cantidad * precio) - descuento) * isv;
                    dgvOCDet2.Rows[e.RowIndex].Cells["Total"].Value = Math.Round(resultado, 2);
                    dgvOCDet2.Rows[e.RowIndex].Cells["ISV"].Value = Math.Round(isv1, 2);
                    CalcularTotal();
                }
                else
                    if (dgvOCDet2.Columns[e.ColumnIndex].Name == "Cantidad" || dgvOCDet2.Columns[e.ColumnIndex].Name == "ISV" || dgvOCDet2.Columns[e.ColumnIndex].Name == "Total")
                {
                        CalcularTotal();
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = 0, contador2 = 0, contador3 = 0, contador4 = 0;
                foreach (DataGridViewRow row in dgvOCDet2.Rows)
                {
                    if (string.IsNullOrEmpty(row.Cells["Cantidad"].Value.ToString()) || string.IsNullOrEmpty(row.Cells["Precio"].Value.ToString()) || string.IsNullOrEmpty(row.Cells["Total"].Value.ToString()))
                    {
                        contador += 1;
                    }
                }
                foreach (DataGridViewRow row in dgvOCDet2.Rows)
                {
                    if (bool.Parse(row.Cells["Conf"].Value.ToString()) == true)
                    {
                        contador2 += _repoOC.ValidarCantidadConfirmada(IdOC, int.Parse(row.Cells["idVehiculo"].Value.ToString()),
                                                                              int.Parse(row.Cells["idProducto"].Value.ToString()),
                                                                              decimal.Parse(row.Cells["Cantidad"].Value.ToString()));
                    }
                }
                foreach (DataGridViewRow row in dgvOCDet2.Rows)
                {
                    if (bool.Parse(row.Cells["Conf"].Value.ToString()) == true)
                    {
                        contador3 += 1;
                    }
                }
                foreach (DataGridViewRow row in dgvOCDet2.Rows)
                {
                    if (bool.Parse(row.Cells["Conf"].Value.ToString()) == true && (decimal.Parse(row.Cells["Cantidad"].Value.ToString()) <= 0 || (TipoOC == 1 ? 1 : decimal.Parse(row.Cells["Precio"].Value.ToString())) <= 0 || decimal.Parse(row.Cells["Total"].Value.ToString()) <= 0))
                    {
                        contador4 += 1;
                    }
                }
                if (contador > 0)
                {
                    MessageBox.Show("Debe completar todos los campos del detalle de confirmación", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtFactura.Text))
                {
                    MessageBox.Show("Ingrese el número de Factura", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dtpConfirmacion.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha de confirmación ingresada no puede ser mayor a la fecha actual", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (TipoOC == 1 && (cboUnidad.SelectedValue is null || cboUnidad.SelectedIndex == -1))
                {
                    MessageBox.Show("Debe seleccionar una unidad de longitud, favor verificar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((string.IsNullOrEmpty(txtOdometro.Text) || decimal.Parse(txtOdometro.Text) < 0) && (TipoOC == 1 || ckbCambioAceite.Checked == true))
                {
                    MessageBox.Show("Ingrese el Odómetro", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((string.IsNullOrEmpty(txtProxCambio.Text) || decimal.Parse(txtProxCambio.Text) <= 0) && ckbCambioAceite.Checked == true)
                {
                    MessageBox.Show("Ingrese el Odómetro del próximo cambio", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (contador2 > 0)
                {
                    MessageBox.Show("Las cantidades confirmadas deben ser menor o igual a las solicitadas, favor verificar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (contador3 == 0)
                {
                    MessageBox.Show("Debe confirmar al menos un ítem del detalle, favor verificar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (contador4 > 0)
                {
                    MessageBox.Show("Los valores no pueden ser menores o igual a cero, favor verificar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dtpConfirmacion.Value.Date < DateTime.Parse(lblFecha.Text))
                {
                    MessageBox.Show("La fecha de confirmación no puede ser menor a la fecha de Orden, favor verificar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (DateTime.Parse(lblFLimite.Text) < dtpConfirmacion.Value.Date) 
                {
                    MessageBox.Show("La fecha limite no puede ser menor a la fecha de la factura, favor verificar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro desea confirmar esta Orden?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvOCDet2.Rows)
                        {
                            if (bool.Parse(row.Cells["Conf"].Value.ToString()) == true)
                            {
                                _repoOC.ConfirmarLineaOrden(IdOC, txtFactura.Text, cboCAI.Text == "" ? "" : cboCAI.Text,
                                                            int.Parse(row.Cells["idVehiculo"].Value.ToString()),
                                                            int.Parse(row.Cells["IdProductoOriginal"].Value.ToString()),
                                                            decimal.Parse(row.Cells["Cantidad"].Value.ToString()),
                                                            decimal.Parse(row.Cells["Precio"].Value.ToString()),
                                                            decimal.Parse(row.Cells["ISV"].Value.ToString()),
                                                            decimal.Parse(row.Cells["Total"].Value.ToString()),
                                                            Clases.VarGlobales.Usuario,
                                                            Environment.MachineName,
                                                            int.Parse(row.Cells["idProducto"].Value.ToString()),
                                                            dtpConfirmacion.Value.Date,
                                                            decimal.Parse(txtOdometro.Text.ToString()),
                                                            TipoOC == 1 ? int.Parse(cboUnidad.SelectedValue.ToString()) : 0,
                                                            chkDesc.Checked,
                                                            decimal.Parse(txtDescuento.Text.ToString()));
                            }
                        }

                        int idCambioAceite = _repoOC.ObtenerCambioAceite(Convert.ToInt32(cboVeh.SelectedValue));

                        if (TipoOC == 1 && idCambioAceite > 0)
                        {
                            int cambioAceite = _repoOC.InsertarCambioAceiteDet(idCambioAceite, IdOC, dtpConfirmacion.Value.Date, decimal.Parse(txtOdometro.Text));
                            if (cambioAceite > 0)
                            {
                                MessageBox.Show("¡Es necesario programar un nuevo cambio de aceite para esta unidad!", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        if (ckbCambioAceite.Checked == true && TipoOC != 1)
                        {
                            int resp = _repoOC.InsertarCambioAceite(Convert.ToInt32(cboVeh.SelectedValue), IdOC, dtpConfirmacion.Value.Date, Convert.ToDecimal(txtOdometro.Text), Convert.ToDecimal(txtProxCambio.Text), Convert.ToInt32(cboUnidad.SelectedValue), Clases.VarGlobales.Usuario, false, true);
                            if (resp == 0)
                            {
                                MessageBox.Show("Ya existe un registro de cambio de aceite para este vehículo, se completará para ingresar uno nuevo", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _repoOC.InsertarCambioAceite(Convert.ToInt32(cboVeh.SelectedValue), IdOC, dtpConfirmacion.Value.Date, Convert.ToDecimal(txtOdometro.Text), Convert.ToDecimal(txtProxCambio.Text), Convert.ToInt32(cboUnidad.SelectedValue), Clases.VarGlobales.Usuario, true, false);
                            }
                            if (resp == 2)
                            {
                                MessageBox.Show("Ya existe un registro de cambio de aceite de esta orden, se actualizaron los cambios realizados", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        MessageBox.Show("Orden confirmada exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgvOCDet2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            string columna = dgvOCDet2.CurrentCell.OwningColumn.Name;   // por Name, no por índice (§13.b)
            if (columna == "Cantidad" || columna == "Precio" || columna == "Total")
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void chkISV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkISV.Checked == true)
            {
                dgvOCDet2.Columns["ISV"].ReadOnly = false;
                dgvOCDet2.Columns["Total"].ReadOnly = false; 
            }
            else
            {
                dgvOCDet2.Columns["ISV"].ReadOnly = true;
                dgvOCDet2.Columns["Total"].ReadOnly = true;
            }
        }
        private void chkDesc_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDesc.Checked == true)
            {
                txtDescuento.Enabled = true;
                txtDescuento.Text = "0.00";
                dgvOCDet2.Columns["Descuento"].Visible = true;
                AplicarDesc();
            }
            else
            {
                txtDescuento.Text = "0.00";
                AplicarDesc();
                txtDescuento.Enabled = false;
                dgvOCDet2.Columns["Descuento"].Visible = false;
            }
        }
        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            AplicarDesc();
        }
        void AplicarDesc()
        {
            if (dgvOCDet2.RowCount > 0)
            {
                if (string.IsNullOrEmpty(txtDescuento.Text))
                {
                    txtDescuento.Text = $"{0:n2}";
                    txtDescuento.Focus();
                }
                decimal descuento = Convert.ToDecimal(txtDescuento.Text);
                int contador = 0;
                if (chkDesc.Checked == true)
                {
                    foreach (DataGridViewRow rows in dgvOCDet2.Rows)
                    {
                        contador += 1;
                    }
                    descuento /= contador;
                }
                if (chkDesc.Checked == true)
                {
                    foreach (DataGridViewRow rows in dgvOCDet2.Rows)
                    {
                        if (chkISV.Checked == false)
                        {
                            decimal isv;
                            if (bool.Parse(dgvOCDet2.Rows[rows.Index].Cells["Aplica"].Value.ToString()) == true)
                            {
                                isv = TipoOC == 1 ? 0 : ISVP;   // ISVP cacheado en el Load (antes: SP por fila)
                            }
                            else
                            {
                                isv = 0;
                            }
                            decimal cantidad = dgvOCDet2.Rows[rows.Index].Cells["Cantidad"].Value.ToString() == string.Empty ? 0 : decimal.Parse(dgvOCDet2.Rows[rows.Index].Cells["Cantidad"].Value.ToString());
                            decimal precio = dgvOCDet2.Rows[rows.Index].Cells["Precio"].Value.ToString() == string.Empty ? 0 : decimal.Parse(dgvOCDet2.Rows[rows.Index].Cells["Precio"].Value.ToString());

                            dgvOCDet2.Rows[rows.Index].Cells["Descuento"].Value = descuento;

                            decimal resultado = (cantidad * precio) - descuento + ((cantidad * precio) - descuento) * isv;
                            decimal isv1 = ((cantidad * precio) - descuento) * isv;
                            dgvOCDet2.Rows[rows.Index].Cells["Total"].Value = resultado;
                            dgvOCDet2.Rows[rows.Index].Cells["ISV"].Value = isv1;                            
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewRow rows in dgvOCDet2.Rows)
                    {
                        dgvOCDet2.Rows[rows.Index].Cells["Descuento"].Value = descuento;
                    }
                }
            }
        }
        public bool ValidarCantidad(int code)
        {
            bool resultado;

            if (code == 46 && txtDescuento.Text.Contains(".")) //se evalúa si es punto y revisa si ya existe en el textbox
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
        private void txtDescuento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescuento.Text))
            {
                txtDescuento.Text = $"{0:n2}";
                txtDescuento.Focus();
            }
        }
        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCantidad(Convert.ToInt32(e.KeyChar)); //llamada a la funcion que evalua que tecla es aceptada
        }
        private void txtDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtDescuento.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtDescuento.SelectAll();
            });
        }
        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (txtDescuento.Text.Length < 1 || txtDescuento.Text == ".")
            {
                txtDescuento.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtDescuento.Text = string.Format("{0:#,##0.00}", double.Parse(txtDescuento.Text));
            }
        }
        private void ckbCambioAceite_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbCambioAceite.Checked == true && TipoOC != 1)
            {
                txtProxCambio.Visible = true;
                lblProxCambio.Visible = true;
                cboVeh.Visible = true;
                lblVeh.Visible = true;
                cboVeh.SelectedIndex = 0;
                //txtProxCambio.Text = "0";

                txtOdometro.Visible = true;
                lblOdometro.Visible = true;
                cboUnidad.Visible = true;
                lblKilometraje.Visible = true;
                cboUnidad.SelectedIndex = 0;
                //txtOdometro.Text = "0";

            }
            else
            if (ckbCambioAceite.Checked == false && TipoOC != 1)
            {
                txtProxCambio.Visible = false;
                lblProxCambio.Visible = false;
                cboVeh.Visible = false;
                lblVeh.Visible = false;

                txtOdometro.Visible = false;
                lblOdometro.Visible = false;
                cboUnidad.Visible = false;
                lblKilometraje.Visible = false;
            }
        }
        private void dgvOCDet2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void obtenerTipoOC()
        {
            if (TipoOC == 1)
            {
                dgvOCDet2.Columns["Precio"].Visible = false;
                dgvOCDet2.Columns["Aplica"].Visible = false;
                dgvOCDet2.Columns["ISV"].Visible = false;
                dgvOCDet1.Columns["precioDGV"].Visible = false;
                dgvOCDet1.Columns["iSVDGV"].Visible = false;
                dgvOCDet1.Columns["totalDGV"].Visible = false;
                dgvOCDet2.Columns["Total"].ReadOnly = false;
                txtOdometro.Visible = true;
                lblOdometro.Visible = true;
                cboUnidad.Visible = true;
                lblKilometraje.Visible = true;
                ckbCambioAceite.Visible = false;
                lblVeh.Visible = true;
                cboVeh.Visible = true;
            }
            else
            {
                dgvOCDet2.Columns["Precio"].Visible = true;
                dgvOCDet2.Columns["Aplica"].Visible = true;
                dgvOCDet2.Columns["ISV"].Visible = true;
                dgvOCDet1.Columns["precioDGV"].Visible = true;
                dgvOCDet1.Columns["iSVDGV"].Visible = true;
                dgvOCDet1.Columns["totalDGV"].Visible = true;
                dgvOCDet2.Columns["Total"].ReadOnly = true;

                if (ckbCambioAceite.Checked == true)
                {
                    txtOdometro.Visible = true;
                    lblOdometro.Visible = true;
                    cboUnidad.Visible = true;
                    lblKilometraje.Visible = true;
                }
                else
                {
                    txtOdometro.Visible = false;
                    lblOdometro.Visible = false;
                    cboUnidad.Visible = false;
                    lblKilometraje.Visible = false;
                    lblVeh.Visible = false;
                    cboVeh.Visible = false;
                }
            }
        }
    }
}
