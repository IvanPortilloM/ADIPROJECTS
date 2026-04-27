using System;
using System.Windows.Forms;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.OC
{
    public partial class ManCatProductos : FrmMantenimiento
    {
        public ManCatProductos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCatProductos);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void ManCatProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_ProductosCategorias' Puede moverla o quitarla según sea necesario.
            this.oC_ProductosCategoriasTableAdapter.Fill(this.dsOC.OC_ProductosCategorias);
            lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCatProductos.Rows.Count > 0 && dgvCatProductos.FirstDisplayedCell != null)
                {
                    dgvCatProductos.EndEdit();
                    this.oC_ProductosCategoriasTableAdapter.Update(this.dsOC.OC_ProductosCategorias);
                    dgvCatProductos.CurrentCell = dgvCatProductos.Rows[dgvCatProductos.CurrentRow.Index].Cells[1];
                    dgvCatProductos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvCatProductos.ReadOnly = true;
                    lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCatProductos.AllowUserToAddRows = true;
            dgvCatProductos.ReadOnly = false;
            dgvCatProductos.FirstDisplayedScrollingRowIndex = dgvCatProductos.RowCount - 1;
            var cantidadRow = dgvCatProductos.RowCount - 1;
            dgvCatProductos.CurrentCell = dgvCatProductos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvCatProductos.Rows.Count > 0 && dgvCatProductos.FirstDisplayedCell != null)
            {
                saveRow = dgvCatProductos.FirstDisplayedCell.RowIndex;
                dgvCatProductos.ReadOnly = false;
                dgvCatProductos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCatProductos.Rows.Count)
                dgvCatProductos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCatProductos.Rows.Count > 0 && dgvCatProductos.FirstDisplayedCell != null)
            {
                this.oC_ProductosCategoriasTableAdapter.Fill(this.dsOC.OC_ProductosCategorias);
                dgvCatProductos.CurrentCell = dgvCatProductos.Rows[dgvCatProductos.CurrentRow.Index].Cells[1];
                dgvCatProductos.AllowUserToAddRows = false;

                dgvCatProductos.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCatProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
        }

        private void dgvCatProductos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (dgvCatProductos.RowCount > 0)
                {
                    dgvCatProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvCatProductos.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCatProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCatProductos.RowCount > 0)
                {
                    dgvCatProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvCatProductos.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
