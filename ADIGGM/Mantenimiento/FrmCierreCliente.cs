using System;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmCierreCliente : FrmPrincipal
    {
        private readonly RepositorioTransporte _repo = new RepositorioTransporte();
        int IdCierre = 0;
        string Usuario = Clases.VarGlobales.Usuario;
        public FrmCierreCliente(int IdCierre)
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCierreCliente);

            this.IdCierre = IdCierre;
        }

        private void FrmCierreCliente_Load(object sender, EventArgs e)
        {
            // Combos-columna del grid (el DataSource se asigna aquí, no en el Designer)
            // Combo-columnas por nombre con null-check: si el diseñador de VS borrara la columna
            // (gotcha §11), el form degrada en vez de tronar con NullReferenceException al cargar.
            tRClientesBindingSource.DataMember = "";
            tRClientesBindingSource.DataSource = _repo.ListarClientes();
            if (dgvCierreCliente.Columns["idCliente"] is System.Windows.Forms.DataGridViewComboBoxColumn colCli)
                colCli.DataSource = tRClientesBindingSource;
            tRTipoVehiculosBindingSource.DataMember = "";
            tRTipoVehiculosBindingSource.DataSource = _repo.ListarTipoVehiculosActivos();
            if (dgvCierreCliente.Columns["idTipoVehiculo"] is System.Windows.Forms.DataGridViewComboBoxColumn colVeh)
                colVeh.DataSource = tRTipoVehiculosBindingSource;
            // Combo filtro por Tipo de Factura (dispara cboTipoVeh_SelectedValueChanged -> LlenarDgv)
            tRTipoFacturasBindingSource.DataMember = "";
            tRTipoFacturasBindingSource.DataSource = _repo.ListarTipoFacturas();

            LlenarDgv();
            LlenarTotales(-1);
        }

        public void LlenarDgv()
        {
            tRCierreClientesBindingSource.DataMember = "";
            tRCierreClientesBindingSource.DataSource = _repo.ListarCierreClientesPorTipoFac(IdCierre, Convert.ToInt32(cboTipoVeh.SelectedValue));
            dgvCierreCliente.DataSource = tRCierreClientesBindingSource;
        }

        private void LimpiarContextMenuStrip()
        {
            cmsOpciones.Items[0].Visible = false;
            cmsOpciones.Items[1].Visible = false;
            cmsOpciones.Items[2].Visible = false;
            cmsOpciones.Items[3].Visible = false;
        }

        private void cboTipoVeh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoVeh.SelectedIndex != -1)
            {
                LlenarDgv();
                LlenarTotales(-1);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se Cerraran todos los Viajes de este Cliente ¿Desea Continuar?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdCierre = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCierrePK"].Value.ToString());
                int IdCliente = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                int IdTipoVeh = int.Parse(dgvCierreCliente.CurrentRow.Cells["idTipoVehiculo"].Value.ToString()); 

                _repo.CerrarCierreCliente(IdCierre, IdCliente, IdTipoVeh, Usuario);
                MessageBox.Show("Cierre Realizado Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }

        private void reversarCerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se Reversará el estado de Cerrado para este Cliente ¿Desea Continuar?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdCierre = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCierrePK"].Value.ToString());
                int IdCliente = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                int IdTipoVeh = int.Parse(dgvCierreCliente.CurrentRow.Cells["idTipoVehiculo"].Value.ToString());

                _repo.ReversarCierreCliente(IdCierre, IdCliente, IdTipoVeh, Usuario);
                MessageBox.Show("Reversión Realizada Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }
        public void LlenarTotales(int IndiceDgv)
        {
            double Subtotal = 0, ISV = 0, Total = 0;

            if (dgvCierreCliente.RowCount > 0)
            {
                if (IndiceDgv >= 0)
                {
                
                    int IdCliente = Convert.ToInt32(dgvCierreCliente.Rows[IndiceDgv].Cells["idCliente"].Value);
                    int IdTpFact = Convert.ToInt32(cboTipoVeh.SelectedValue);

                    foreach (DataGridViewRow row in dgvCierreCliente.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["idCliente"].Value) == IdCliente && Convert.ToInt32(row.Cells["IdTipoFactura"].Value) == IdTpFact)
                        {
                            Subtotal += Convert.ToDouble($"{row.Cells["SubTotalCierre"].Value:n}");
                            ISV += Convert.ToDouble($"{row.Cells["ISVCierre"].Value:n}");
                            Total += Convert.ToDouble($"{row.Cells["TotalCierre"].Value:n}");
                        }
                    }
                    txtSubtotal2.Text = $"{Subtotal:n}";
                    txtISV2.Text = $"{ISV:n}";
                    txtTotal2.Text = $"{Total:n}";
                }
                else
                {
                    foreach (DataGridViewRow row in dgvCierreCliente.Rows)
                    {
                        Subtotal += Convert.ToDouble($"{row.Cells["SubTotalCierre"].Value:n}");
                        ISV += Convert.ToDouble($"{row.Cells["ISVCierre"].Value:n}");
                        Total += Convert.ToDouble($"{row.Cells["TotalCierre"].Value:n}");
                    }
                    txtSubtotal2.Text = $"{Subtotal:n}";
                    txtISV2.Text = $"{ISV:n}";
                    txtTotal2.Text = $"{Total:n}";
                }
            }
            else
            {
                txtSubtotal2.Text = $"{0:n}";
                txtISV2.Text = $"{0:n}";
                txtTotal2.Text = $"{0:n}";
            }
        }

        private void dgvCierreCliente_MouseDown(object sender, MouseEventArgs e)
        {
            LimpiarContextMenuStrip();
            if (dgvCierreCliente.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (bool.Parse(this.dgvCierreCliente.CurrentRow.Cells["cerrado"].Value.ToString()) == false)
                    {
                        cmsOpciones.Items[0].Visible = true;//Cerrar
                        cmsOpciones.Items[1].Visible = false;//Reversar Cerrado
                        //cmsOpciones.Items[2].Visible = true;//Anular
                        //cmsOpciones.Items[3].Visible = false;//Reversar Anulado
                    }
                    else
                    if (bool.Parse(this.dgvCierreCliente.CurrentRow.Cells["cerrado"].Value.ToString()) == true)
                    {
                        cmsOpciones.Items[0].Visible = false;//Cerrar
                        cmsOpciones.Items[1].Visible = true;//Reversar Cerrado
                        //cmsOpciones.Items[2].Visible = false;//Anular
                        //cmsOpciones.Items[3].Visible = false;//Reversar Anulado
                        if (decimal.Parse(this.dgvCierreCliente.CurrentRow.Cells["ISVCierre"].Value.ToString()) > 0)
                        {
                            cmsOpciones.Items[2].Visible = false;//Aplicar ISV
                            cmsOpciones.Items[3].Visible = true;//Borrar ISV
                        }
                        else
                        {
                            cmsOpciones.Items[2].Visible = true;//Aplicar ISV
                            cmsOpciones.Items[3].Visible = false;//Borrar ISV
                        }
                    }
                }
            }
        }

        private void dgvCierreCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCierreCliente.RowCount > 0)
            {
                LlenarTotales(dgvCierreCliente.CurrentRow.Index);
            }
        }

        private void dgvCierreCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCierreCliente.RowCount > 0)
            {
                LlenarTotales(dgvCierreCliente.CurrentRow.Index);
            }
        }

        private void aplicarISVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se aplicará impuesto a todos los viajes dentro del rango del cierre ¿Desea Continuar?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdCierre = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCierrePK"].Value.ToString());
                int IdCliente = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                int IdTipoVeh = int.Parse(dgvCierreCliente.CurrentRow.Cells["idTipoVehiculo"].Value.ToString());

                _repo.AplicarISVCierre(IdCierre, IdCliente, IdTipoVeh, Usuario, true);
                MessageBox.Show("La aplicación del impuesto fue realizada exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }

        private void borrarISVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se borrará el impuesto a todos los viajes dentro del rango del cierre ¿Desea Continuar?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdCierre = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCierrePK"].Value.ToString());
                int IdCliente = int.Parse(dgvCierreCliente.CurrentRow.Cells["idCliente"].Value.ToString());
                int IdTipoVeh = int.Parse(dgvCierreCliente.CurrentRow.Cells["idTipoVehiculo"].Value.ToString());

                _repo.AplicarISVCierre(IdCierre, IdCliente, IdTipoVeh, Usuario, false);
                MessageBox.Show("La aplicación del impuesto fue realizada exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }
    }
}
