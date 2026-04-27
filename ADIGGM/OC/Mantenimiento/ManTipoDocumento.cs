using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManTipoDocumento : FrmMantenimiento
    {
        public ManTipoDocumento()
        {
            InitializeComponent();
        }

        private void ManTipoDocumento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.CP_TipoDocumentos' Puede moverla o quitarla según sea necesario.
            this.cP_TipoDocumentosTableAdapter.Fill(this.dsOC.CP_TipoDocumentos);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoDocumentos.AllowUserToAddRows = true;
            dgvTipoDocumentos.ReadOnly = false;
            dgvTipoDocumentos.FirstDisplayedScrollingRowIndex = dgvTipoDocumentos.RowCount - 1;
            var cantidadRow = dgvTipoDocumentos.RowCount - 1;
            dgvTipoDocumentos.CurrentCell = dgvTipoDocumentos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoDocumentos.Rows.Count > 0 && dgvTipoDocumentos.FirstDisplayedCell != null)
                {
                    dgvTipoDocumentos.EndEdit();
                    this.cP_TipoDocumentosTableAdapter.Update(this.dsOC.CP_TipoDocumentos);
                    dgvTipoDocumentos.CurrentCell = dgvTipoDocumentos.Rows[dgvTipoDocumentos.CurrentRow.Index].Cells[1];
                    dgvTipoDocumentos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoDocumentos.ReadOnly = true;
                    lblFooter.Text = "Tipos Documentos - #Registros: " + (dgvTipoDocumentos.RowCount);
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

            if (dgvTipoDocumentos.Rows.Count > 0 && dgvTipoDocumentos.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoDocumentos.FirstDisplayedCell.RowIndex;
                dgvTipoDocumentos.ReadOnly = false;
                dgvTipoDocumentos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoDocumentos.Rows.Count)
                dgvTipoDocumentos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoDocumentos.Rows.Count > 0 && dgvTipoDocumentos.FirstDisplayedCell != null)
            {
                this.cP_TipoDocumentosTableAdapter.Fill(this.dsOC.CP_TipoDocumentos);
                dgvTipoDocumentos.CurrentCell = dgvTipoDocumentos.Rows[dgvTipoDocumentos.CurrentRow.Index].Cells[1];
                dgvTipoDocumentos.AllowUserToAddRows = false;

                dgvTipoDocumentos.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipos Documentos - #Registros: " + (dgvTipoDocumentos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTipoDocumentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Tipo Documentos - #Registros: " + (dgvTipoDocumentos.RowCount);
        }
    }
}
