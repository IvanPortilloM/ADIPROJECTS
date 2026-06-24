using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.OC.Visores
{
    public partial class VisOCCodeas : FrmPrincipal
    {
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        public VisOCCodeas()
        {
            InitializeComponent();
        }
        bool PermitirMonto = true;
        private void VisOCCodeas_Load(object sender, EventArgs e)
        {
            this.oC_TipoDocumentosTableAdapter.Fill(this.dsOC.OC_TipoDocumentos);
            this.cOD_SlcInstBancariaTableAdapter.Fill(this.dsOC.COD_SlcInstBancaria, VarGlobales.Usuario);
            this.oC_ProveedoresTableAdapter.FillByTodos(this.dsOC.OC_Proveedores);
            this.oC_TipoOCTableAdapter.FillByTodos(this.dsOC.OC_TipoOC);
            cboTipoMov.SelectedIndex = 0;
            CargarConsecutivo();
            txtMonto.Text = $"{1:n}";
            txtMontoCxC.Text = $"{0:n}";
            txtMontoDesc.Text = $"{0:n}";
            dgvOC.Columns["Aprobar"].ReadOnly = false;
        }
        private void Visualizar()
        {
            try
            {
                this.oC_DetalleOrdenCodeasTableAdapter.Fill(this.dsOC.OC_DetalleOrdenCodeas, 
                                                            dtpDesde.Value.Date,
                                                            dtpHasta.Value.Date,
                                                            int.Parse(cboTipoOC.SelectedValue.ToString()),
                                                            int.Parse(cboProveedor.SelectedValue.ToString()),
                                                            cboInstBancaria.SelectedValue.ToString(),
                                                            cboNumCta.SelectedValue.ToString(),
                                                            txtTipoDoc.Text,
                                                            Convert.ToInt32(txtConsecutivo.Text),
                                                            Convert.ToDecimal(txtMonto.Text),
                                                            Convert.ToDecimal(txtMontoCxC.Text),
                                                            Convert.ToDecimal(txtMontoDesc.Text),
                                                            txtDescripDetalle.Text,
                                                            true,
                                                            Convert.ToBoolean(chkAplicarCxC.Checked),
                                                            Convert.ToBoolean(chkAplicarDesc.Checked));
                if (dgvOC.RowCount > 0)
                {
                    int contador = 0;
                    foreach (DataGridViewRow row in dgvOC.Rows)
                    {
                        if (bool.Parse(row.Cells["seleccionar"].Value.ToString()) == false)
                        {
                            DataGridViewLinkCell cellBtn = (DataGridViewLinkCell)this.dgvOC.Rows[row.Index].Cells["DetalleBtn"];
                            cellBtn.UseColumnTextForLinkValue = false;
                            cellBtn.Value = string.Empty;
                        }
                        if (int.Parse(row.Cells["idOC"].Value.ToString()) == 0)
                        {
                            dgvOC.Rows[row.Index].Cells["Aprobar"].Value = 1;
                        }
                        else
                        {
                            dgvOC.Rows[row.Index].Cells["Aprobar"].Value = 0;
                        }
                        contador += 1;
                    }
                    //foreach (DataGridViewColumn c in dgvOC.Columns)
                    //{
                    //    if (c.Name != "debe") c.ReadOnly = true;
                    //    if (c.Name != "haber") c.ReadOnly = true;
                    //}
                    //dgvOC.Columns["Aprobar"].ReadOnly = false;
                    lblContador.Text = "Total de Registros: " + contador;
                    CalcularTotal();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            CargarConsecutivo();
            Visualizar();
        }
        private void dgvOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOC.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == dgvOC.Columns["DetalleBtn"].Index)
                {
                    VisOCCodeasDet visor = new VisOCCodeasDet((dgvOC.CurrentRow.Cells["Correlativo"].Value.ToString()),
                                                                 (dgvOC.CurrentRow.Cells["CodVehiculo"].Value.ToString()),
                                                                 int.Parse(dgvOC.CurrentRow.Cells["idVehiculo"].Value.ToString()),
                                                                 decimal.Parse(dgvOC.CurrentRow.Cells["debe"].Value.ToString()),
                                                                 int.Parse(dgvOC.CurrentRow.Cells["idOC"].Value.ToString()),
                                                                 dgvOC.CurrentRow.Cells["descripcion"].Value.ToString());
                    visor.ShowDialog(this);
                }
            }

            if (dgvOC.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                if (e.ColumnIndex == dgvOC.Columns["Aprobar"].Index)
                {
                    if (dgvOC.RowCount > 0)
                    {
                        int idOC = int.Parse(dgvOC.CurrentRow.Cells["idOC"].Value.ToString());
                        int Aprobar = int.Parse(dgvOC.CurrentRow.Cells["Aprobar"].Value.ToString());

                        if (idOC > 0)
                        {
                            foreach (DataGridViewRow row in dgvOC.Rows)
                            {
                                if (int.Parse(row.Cells["idOC"].Value.ToString()) == idOC)
                                {
                                    dgvOC.Rows[row.Index].Cells["Aprobar"].Value = Aprobar;
                                }
                            }
                            CalcularTotal();
                        }
                        else
                        {
                            dgvOC.Rows[e.RowIndex].Cells["Aprobar"].Value = Aprobar;
                            CalcularTotal();
                        }
                    }
                }
            }
        }
        private void CargarCcBancaria()
        {
            if (cboInstBancaria.SelectedIndex > -1)
            {
                this.cOD_SlcCcBancariaTableAdapter.Fill(this.dsOC.COD_SlcCcBancaria, VarGlobales.Usuario, cboInstBancaria.SelectedValue.ToString());
            }
        }
        private void CargarConsecutivo()
        {
            if (cboInstBancaria.SelectedIndex > -1 && cboNumCta.SelectedIndex > -1)
            {
                txtConsecutivo.Text = Convert.ToString(VarGlobales.consultasOC.COD_SlcTipoDocConsecutivo(cboTipoDoc.SelectedValue.ToString(), cboInstBancaria.SelectedValue.ToString(), cboNumCta.SelectedValue.ToString()));
            }
        }
        private void cboInstBancaria_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarCcBancaria();
            CargarConsecutivo();
        }
        private void cboNumCta_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarConsecutivo();
        }
        private void cboTipoDoc_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarConsecutivo();
        }
        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (txtMonto.Text.Length < 1 || txtMonto.Text == ".")
            {
                txtMonto.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtMonto.Text = string.Format("{0:#,##0.00}", double.Parse(txtMonto.Text));
            }
        }
        private void txtMontoCxC_Leave(object sender, EventArgs e)
        {
            if (txtMontoCxC.Text.Length < 1 || txtMontoCxC.Text == ".")
            {
                txtMontoCxC.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtMontoCxC.Text = string.Format("{0:#,##0.00}", double.Parse(txtMontoCxC.Text));
            }
        }
        private void txtMonto_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtMonto.SelectAll();
            });
        }
        private void txtMontoCxC_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtMontoCxC.SelectAll();
            });
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(0, dtpDesde.Value.Date.ToString(),
                                                                                dtpHasta.Value.Date.ToString(),
                                                                                int.Parse(cboTipoOC.SelectedValue.ToString()),
                                                                                int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                                cboInstBancaria.SelectedValue.ToString(),
                                                                                cboNumCta.SelectedValue.ToString(),
                                                                                cboTipoDoc.SelectedValue.ToString(),
                                                                                int.Parse(txtConsecutivo.Text.ToString()),
                                                                                decimal.Parse(txtMonto.Text.ToString()),
                                                                                txtDescripDetalle.Text.ToString(),
                                                                                true);
            reporte.ShowDialog();
        }
        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtDiferencia.Text) == 0)
            {
                int creditos = 0;
                int debitos = 0;
                int ctaContable = 0;
                int VerificarCta = 0;

                foreach (DataGridViewRow row in dgvOC.Rows)
                {
                    if (Convert.ToString(row.Cells["Aprobar"].Value) == "1" && Convert.ToString(row.Cells["TipoMov"].Value) == "CR")
                    {
                        creditos += 1;
                    }
                    if (Convert.ToString(row.Cells["Aprobar"].Value) == "1" && Convert.ToString(row.Cells["TipoMov"].Value) == "DB")
                    {
                        debitos += 1;
                    }
                    if (Convert.ToString(row.Cells["ctaContable"].Value.ToString().Trim()) == "")
                    {
                        ctaContable += 1;
                    }
                    if (_repoCodeas.VerificarCuentaContable(row.Cells["ctaContable"].Value.ToString().Trim()) == 0)
                    {
                        VerificarCta += 1;
                    }
                }

                if (creditos > 0 && debitos > 0 && ctaContable == 0 && VerificarCta == 0)
                {
                    int resultado;

                    string NumAsiento = VarGlobales.consultasOC.OC_NumAsientoObtener(cboInstBancaria.SelectedValue.ToString(), cboNumCta.SelectedValue.ToString()).ToString();
                    string TipoAsiento = VarGlobales.consultasOC.OC_TipoAsientoObtener(cboInstBancaria.SelectedValue.ToString(), cboNumCta.SelectedValue.ToString()).ToString();

                    resultado = Convert.ToInt32(VarGlobales.consultasOC.OC_DetalleOrdenCodeasSync(txtProveedor.Text,
                                                                                                         cboInstBancaria.SelectedValue.ToString(),
                                                                                                            cboNumCta.SelectedValue.ToString(),
                                                                                                            txtTipoDoc.Text,
                                                                                                            Convert.ToDecimal(txtMonto.Text),
                                                                                                            NumAsiento,
                                                                                                            Convert.ToInt32(txtConsecutivo.Text),
                                                                                                            TipoAsiento,
                                                                                                            txtDescripHeader.Text,
                                                                                                            VarGlobales.Usuario));
                    if (resultado == 1)
                    {
                        if (dgvOC.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dgvOC.Rows)
                            {
                                if (Convert.ToString(row.Cells["TipoMov"].Value) == "CR" && Convert.ToString(row.Cells["Aprobar"].Value) == "1")
                                {
                                    VarGlobales.consultasOC.OC_OrdenCompraSyncUpdate(Convert.ToInt32(row.Cells["idOC"].Value),
                                    txtTipoDoc.Text, Convert.ToInt32(txtConsecutivo.Text));

                                    VarGlobales.consultasOC.OC_AsientosInsert(NumAsiento,
                                                                                    Convert.ToString(row.Cells["ctaContable"].Value),
                                                                                    Convert.ToString(row.Cells["TipoMov"].Value),
                                                                                    Convert.ToDecimal(row.Cells["Haber"].Value),
                                                                                    Convert.ToInt32(txtConsecutivo.Text),
                                                                                    Convert.ToString(row.Cells["detalle"].Value),
                                                                                    TipoAsiento,
                                                                                    Convert.ToString(row.Cells["nDoc"].Value));

                                    VarGlobales.consultasOC.OC_MovBancariosInsert(NumAsiento,
                                                                                        Convert.ToString(row.Cells["ctaContable"].Value),
                                                                                        cboNumCta.SelectedValue.ToString(),
                                                                                        Convert.ToString(row.Cells["TipoMov"].Value),
                                                                                        Convert.ToDecimal(row.Cells["Haber"].Value),
                                                                                        txtTipoDoc.Text,
                                                                                        Convert.ToInt32(txtConsecutivo.Text),
                                                                                        Convert.ToString(row.Cells["detalle"].Value),
                                                                                        Convert.ToString(row.Cells["nDoc"].Value));
                                }
                                else
                                if (Convert.ToString(row.Cells["TipoMov"].Value) == "DB" && Convert.ToString(row.Cells["Aprobar"].Value) == "1")
                                {
                                    VarGlobales.consultasOC.OC_OrdenCompraSyncUpdate(Convert.ToInt32(row.Cells["idOC"].Value),
                                    txtTipoDoc.Text, Convert.ToInt32(txtConsecutivo.Text));

                                    VarGlobales.consultasOC.OC_AsientosInsert(NumAsiento,
                                                                                    Convert.ToString(row.Cells["ctaContable"].Value),
                                                                                    Convert.ToString(row.Cells["TipoMov"].Value),
                                                                                    Convert.ToDecimal(row.Cells["Debe"].Value),
                                                                                    Convert.ToInt32(txtConsecutivo.Text),
                                                                                    Convert.ToString(row.Cells["detalle"].Value),
                                                                                    TipoAsiento,
                                                                                    Convert.ToString(row.Cells["nDoc"].Value));

                                    VarGlobales.consultasOC.OC_MovBancariosInsert(NumAsiento,
                                                                                        Convert.ToString(row.Cells["ctaContable"].Value),
                                                                                        cboNumCta.SelectedValue.ToString(),
                                                                                        Convert.ToString(row.Cells["TipoMov"].Value),
                                                                                        Convert.ToDecimal(row.Cells["Debe"].Value),
                                                                                        txtTipoDoc.Text,
                                                                                        Convert.ToInt32(txtConsecutivo.Text),
                                                                                        Convert.ToString(row.Cells["detalle"].Value),
                                                                                        Convert.ToString(row.Cells["nDoc"].Value));
                                }
                            }
                            MessageBox.Show("Documento #" + txtConsecutivo.Text + " con asiento #" + NumAsiento + " fueron guardados exitosamente.", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDescripHeader.Text = string.Empty;
                            txtDescripDetalle.Text = string.Empty;
                            txtMonto.Text = $"{1:n}";
                            txtMontoCxC.Text = $"{0:n}";
                            txtMontoDesc.Text = $"{0:n}";
                            cboTipoMov.SelectedIndex = 0;
                            CargarConsecutivo();
                            Visualizar();
                        }
                    }
                    else
                        if (resultado == 0)
                    {
                        MessageBox.Show("El número de documento cambió desde la última vez, favor verifique!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique los valores del debe y haber, asi como tambien que las cuentas contables esten correctas.", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Verifique los valores del debe y haber hasta que no haya diferencias para poder continuar.", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtMontoDesc_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtMontoCxC.SelectAll();
            });
        }
        private void txtMontoDesc_Leave(object sender, EventArgs e)
        {
            if (txtMontoDesc.Text.Length < 1 || txtMontoDesc.Text == ".")
            {
                txtMontoDesc.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtMontoDesc.Text = string.Format("{0:#,##0.00}", double.Parse(txtMontoDesc.Text));
            }
        }
        private void lnkEditarDet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkEditarDet.Text == "Editar Detalle")
            {
                if (dgvOC.Columns["detalle"].ReadOnly == true)
                {
                    //Pone todas las columnas en ReadOnly = true
                    foreach (var col in dgvOC.Columns.Cast<DataGridViewColumn>()) col.ReadOnly = true;
                    //Pone la columna "X" en ReadOnly = false, para poder editarla          
                    dgvOC.Columns["detalle"].ReadOnly = false;
                    dgvOC.Columns["ctaContable"].ReadOnly = false;
                    dgvOC.Columns["descripcion"].ReadOnly = false;
                    dgvOC.Columns["debe"].ReadOnly = false;
                    dgvOC.Columns["haber"].ReadOnly = false;
                    dgvOC.Columns["Aprobar"].ReadOnly = false;
                }
                lnkEditarDet.Text = "Guardar Cambios";
            }
            else if (lnkEditarDet.Text == "Guardar Cambios")
            {
                if (dgvOC.Columns["detalle"].ReadOnly == false)
                {
                    //Pone todas las columnas en ReadOnly = true
                    foreach (var col in dgvOC.Columns.Cast<DataGridViewColumn>()) col.ReadOnly = true;
                    //Pone la columna "X" en ReadOnly = false, para poder editarla          
                    dgvOC.Columns["detalle"].ReadOnly = true;
                    dgvOC.Columns["ctaContable"].ReadOnly = true;
                    dgvOC.Columns["descripcion"].ReadOnly = true;
                    dgvOC.Columns["debe"].ReadOnly = true;
                    dgvOC.Columns["haber"].ReadOnly = true;
                    dgvOC.Columns["Aprobar"].ReadOnly = false;
                }
                lnkEditarDet.Text = "Editar Detalle";
            }
        }
        public bool ValidarMonto(int code, string NombreControl)
        {
            bool resultado = true;
            Control[] ctrls = Controls.Find(NombreControl, true);

            if (ctrls.Length > 0)
            {
                TextBox ControlTexbox = ctrls[0] as TextBox;

                if (code == 46 && ControlTexbox.Text == "") //se evalúa si es punto y revisa si el texto está vacío.
                {
                    resultado = true;
                }
                if (code == 46 && ControlTexbox.Text.Contains(".")) //se evalúa si es punto y revisa si ya existe en el textbox
                {
                    resultado = true;
                }
                else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
                {
                    resultado = false;
                }
                else if (!PermitirMonto)
                {
                    resultado = PermitirMonto;
                }
                else
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtMonto.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtMontoCxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtMontoCxC.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtMontoDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtMontoDesc.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void txtMontoCxC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void txtMontoDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Text = $"{0:n}";
                txtMonto.Focus();
            }
        }
        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            DataTable dt = dsOC.OC_DetalleOrdenCodeas;
            DataRow row = dt.NewRow();
            row["idOC"] = 0;
            row["idVehiculo"] = 0;
            row["ctaContable"] = "";
            row["descripcion"] = "";
            row["debe"] = 0.00;
            row["haber"] = 0.00;
            row["ndoc"] = "";
            row["detalle"] = "";
            row["Correlativo"] = 0;
            row["CodVehiculo"] = "";
            row["TipoMov"] = cboTipoMov.SelectedItem.ToString();
            row["seleccionar"] = 0;
            //row["Aprobar"] = 0;

            dt.Rows.Add(row);
            dgvOC.DataSource = dt;

            if (dgvOC.RowCount > 0)
            {
                foreach (DataGridViewRow rows in dgvOC.Rows)
                {
                    if (bool.Parse(rows.Cells["seleccionar"].Value.ToString()) == false)
                    {
                        DataGridViewLinkCell cellBtn = (DataGridViewLinkCell)this.dgvOC.Rows[rows.Index].Cells["DetalleBtn"];
                        cellBtn.UseColumnTextForLinkValue = false;
                        cellBtn.Value = string.Empty;
                    }

                    if (int.Parse(rows.Cells["idOC"].Value.ToString()) == 0)
                    {
                        dgvOC.Rows[rows.Index].Cells["Aprobar"].Value = 1;
                    }
                    else
                    {
                        dgvOC.Rows[rows.Index].Cells["Aprobar"].Value = 0;
                    }
                }
                CalcularTotal();
            }
        }
        private void dgvOC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvOC.IsCurrentCellDirty)
            {
                dgvOC.CommitEdit(DataGridViewDataErrorContexts.Commit);
                CalcularTotal();
            }
        }
        private void txtTipoDoc_TextChanged(object sender, EventArgs e)
        {
            if (dgvOC.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvOC.Rows)
                {
                    dgvOC.Rows[row.Index].Cells["nDoc"].Value = txtTipoDoc.Text + "-" + txtConsecutivo.Text + " CTA: " + cboNumCta.SelectedValue.ToString();
                }
            }
        }
        private void CalcularTotal()
        {
            double Debe = 0, Haber = 0;
            if (dgvOC.RowCount > 0)
            {
                foreach (DataGridViewRow rows in dgvOC.Rows)
                {
                    if (int.Parse(rows.Cells["Aprobar"].Value.ToString()) == 1)
                    {
                        Debe += Convert.ToDouble(rows.Cells["debe"].Value);
                        Haber += Convert.ToDouble(rows.Cells["haber"].Value);
                    }
                }
                txtDebe.Text = $"{Debe:n}";
                txtHaber.Text = $"{Haber:n}";
                txtDiferencia.Text = $"{Convert.ToDouble(txtHaber.Text) - Convert.ToDouble(txtDebe.Text):n}";
                if ((Convert.ToDecimal(txtHaber.Text) - Convert.ToDecimal(txtDebe.Text)) != 0)
                {
                    txtDiferencia.BackColor = Color.Red;
                }
                else
                {
                    txtDiferencia.BackColor = Color.LightSteelBlue;
                }
            }
        }

        private void chkAprobarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvOC.RowCount > 0)
            {
                if(chkAprobarTodo.Checked == true)
                {
                    foreach (DataGridViewRow rows in dgvOC.Rows)
                    {
                        if (int.Parse(rows.Cells["idOC"].Value.ToString()) == 0)
                        {
                            dgvOC.Rows[rows.Index].Cells["Aprobar"].Value = 1;
                        }
                        else
                        {
                            dgvOC.Rows[rows.Index].Cells["Aprobar"].Value = 1;
                        }
                    }
                    CalcularTotal();
                }
                else
                {
                    foreach (DataGridViewRow rows in dgvOC.Rows)
                    {
                        if (int.Parse(rows.Cells["idOC"].Value.ToString()) == 0)
                        {
                            dgvOC.Rows[rows.Index].Cells["Aprobar"].Value = 1;
                        }
                        else
                        {
                            dgvOC.Rows[rows.Index].Cells["Aprobar"].Value = 0;
                        }
                    }
                    CalcularTotal();
                }                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOC.Rows)
            {
                if (Convert.ToString(row.Cells["TipoMov"].Value) == "CR")
                {
                    VarGlobales.consultasOC.OC_OrdenCompraSyncUpdate(Convert.ToInt32(row.Cells["idOC"].Value),
                                txtTipoDoc.Text, Convert.ToInt32("34019"));

                    VarGlobales.consultasOC.OC_AsientosInsert("78509",
                                                                    Convert.ToString(row.Cells["ctaContable"].Value),
                                                                    Convert.ToString(row.Cells["TipoMov"].Value),
                                                                    Convert.ToDecimal(row.Cells["Haber"].Value),
                                                                    34019,
                                                                    Convert.ToString(row.Cells["detalle"].Value),
                                                                    "BCO",
                                                                    "NDB-34019 CTA: 7100038376");

                    VarGlobales.consultasOC.OC_MovBancariosInsert("78509",
                                                                        Convert.ToString(row.Cells["ctaContable"].Value),
                                                                        cboNumCta.SelectedValue.ToString(),
                                                                        Convert.ToString(row.Cells["TipoMov"].Value),
                                                                        Convert.ToDecimal(row.Cells["Haber"].Value),
                                                                        "NDB",
                                                                        34019,
                                                                        Convert.ToString(row.Cells["detalle"].Value),
                                                                        "NDB-34019 CTA: 7100038376");
                }
                else
                if (Convert.ToString(row.Cells["TipoMov"].Value) == "DB")
                {
                    VarGlobales.consultasOC.OC_OrdenCompraSyncUpdate(Convert.ToInt32(row.Cells["idOC"].Value),
                                txtTipoDoc.Text, Convert.ToInt32("34019"));

                    VarGlobales.consultasOC.OC_AsientosInsert("78509",
                                                                    Convert.ToString(row.Cells["ctaContable"].Value),
                                                                    Convert.ToString(row.Cells["TipoMov"].Value),
                                                                    Convert.ToDecimal(row.Cells["Debe"].Value),
                                                                    34019,
                                                                    Convert.ToString(row.Cells["detalle"].Value),
                                                                    "BCO",
                                                                    "NDB-34019 CTA: 7100038376");

                    VarGlobales.consultasOC.OC_MovBancariosInsert("78509",
                                                                        Convert.ToString(row.Cells["ctaContable"].Value),
                                                                        cboNumCta.SelectedValue.ToString(),
                                                                        Convert.ToString(row.Cells["TipoMov"].Value),
                                                                        Convert.ToDecimal(row.Cells["Debe"].Value),
                                                                        "NDB",
                                                                        34019,
                                                                        Convert.ToString(row.Cells["detalle"].Value),
                                                                        "NDB-34019 CTA: 7100038376");
                }
            }
        }
    }
}