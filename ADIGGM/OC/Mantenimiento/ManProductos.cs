using System;
using System.Windows.Forms;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.OC
{
    public partial class ManProductos : FrmMantenimiento
    {
        public ManProductos()
        {
            InitializeComponent();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvProductos);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void ManProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_ProductosCategorias' Puede moverla o quitarla según sea necesario.
            this.oC_ProductosCategoriasTableAdapter.FillByActivos(this.dsOC.OC_ProductosCategorias);

            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Productos' Puede moverla o quitarla según sea necesario.
            this.oC_ProductosTableAdapter.Fill(this.dsOC.OC_Productos, int.Parse(cboCategoria.SelectedValue.ToString()), txtProducto.Text);

            lblFooter.Text = "Productos - #Registros: " + dgvProductos.RowCount;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
                {
                    dgvProductos.CurrentRow.Cells["IdCatProducto"].Value = cboCategoria.SelectedValue;
                    dgvProductos.EndEdit();
                    this.oC_ProductosTableAdapter.Update(this.dsOC.OC_Productos);
                    dgvProductos.CurrentCell = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2];
                    dgvProductos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvProductos.ReadOnly = true;
                    lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = true;
            dgvProductos.ReadOnly = false;
            dgvProductos.FirstDisplayedScrollingRowIndex = dgvProductos.RowCount - 1;
            var cantidadRow = dgvProductos.RowCount - 1;
            dgvProductos.CurrentCell = dgvProductos.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            dgvProductos.CurrentRow.Cells["IdCatProducto"].Value = cboCategoria.SelectedValue;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                saveRow = dgvProductos.FirstDisplayedCell.RowIndex;
                dgvProductos.ReadOnly = false;
                dgvProductos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvProductos.Rows.Count)
                dgvProductos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                this.oC_ProductosTableAdapter.Fill(this.dsOC.OC_Productos, int.Parse(cboCategoria.SelectedValue.ToString()), txtProducto.Text);
                dgvProductos.CurrentCell = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[2];
                dgvProductos.AllowUserToAddRows = false;

                dgvProductos.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
        }

        private void dgvProductos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0)
                {
                    dgvProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvProductos.CurrentRow.Cells["NombreEquipo"].Value = Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboCategoria.SelectedIndex.ToString()) != -1)
            {
                this.oC_ProductosTableAdapter.Fill(this.dsOC.OC_Productos, int.Parse(cboCategoria.SelectedValue.ToString()), txtProducto.Text);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0)
                {
                    dgvProductos.CurrentRow.Cells["IdCatProducto"].Value = cboCategoria.SelectedValue;
                    dgvProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvProductos.CurrentRow.Cells["NombreEquipo"].Value = Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.oC_ProductosTableAdapter.Fill(this.dsOC.OC_Productos, int.Parse(cboCategoria.SelectedValue.ToString()), txtProducto.Text);
            }
        }
    }
}
