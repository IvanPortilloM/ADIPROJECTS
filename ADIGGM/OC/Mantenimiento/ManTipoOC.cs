using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManTipoOC : FrmMantenimiento
    {
        public ManTipoOC()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTiposOC);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void ManTipoOC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_TipoOC' Puede moverla o quitarla según sea necesario.
            this.oC_TipoOCTableAdapter.Fill(this.dsOC.OC_TipoOC);
            lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTiposOC.AllowUserToAddRows = true;
            dgvTiposOC.ReadOnly = false;
            dgvTiposOC.FirstDisplayedScrollingRowIndex = dgvTiposOC.RowCount - 1;
            var cantidadRow = dgvTiposOC.RowCount - 1;
            dgvTiposOC.CurrentCell = dgvTiposOC.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTiposOC.Rows.Count > 0 && dgvTiposOC.FirstDisplayedCell != null)
                {
                    dgvTiposOC.EndEdit();
                    this.oC_TipoOCTableAdapter.Update(this.dsOC.OC_TipoOC);
                    dgvTiposOC.CurrentCell = dgvTiposOC.Rows[dgvTiposOC.CurrentRow.Index].Cells[1];
                    dgvTiposOC.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTiposOC.ReadOnly = true;
                    lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvTiposOC.Rows.Count > 0 && dgvTiposOC.FirstDisplayedCell != null)
            {
                saveRow = dgvTiposOC.FirstDisplayedCell.RowIndex;
                dgvTiposOC.ReadOnly = false;
                dgvTiposOC.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTiposOC.Rows.Count)
                dgvTiposOC.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTiposOC.Rows.Count > 0 && dgvTiposOC.FirstDisplayedCell != null)
            {
                this.oC_TipoOCTableAdapter.Fill(this.dsOC.OC_TipoOC);
                dgvTiposOC.CurrentCell = dgvTiposOC.Rows[dgvTiposOC.CurrentRow.Index].Cells[1];
                dgvTiposOC.AllowUserToAddRows = false;

                dgvTiposOC.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTiposOC_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
        }

        private void dgvTiposOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTiposOC.RowCount > 0)
                {
                    dgvTiposOC.CurrentRow.Cells["Usuario"].Value = Clases.VarGlobales.Usuario;
                    dgvTiposOC.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTiposOC_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (dgvTiposOC.RowCount > 0)
                {
                    dgvTiposOC.CurrentRow.Cells["Usuario"].Value = Clases.VarGlobales.Usuario;
                    dgvTiposOC.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
