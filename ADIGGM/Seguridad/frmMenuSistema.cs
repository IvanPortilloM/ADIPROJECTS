using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class frmMenuSistema : FrmMantenimiento
    {
        int selectedIndex;
        public frmMenuSistema()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvMenuSistema);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvMenuSistema.AllowUserToAddRows = true;
            dgvMenuSistema.ReadOnly = false;
            dgvMenuSistema.FirstDisplayedScrollingRowIndex = dgvMenuSistema.RowCount - 1;
            var cantidadRow = dgvMenuSistema.RowCount - 1;
            dgvMenuSistema.CurrentCell = dgvMenuSistema.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenuSistema.Rows.Count > 0 && dgvMenuSistema.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvMenuSistema.CurrentRow.Index;
                    dgvMenuSistema.EndEdit();
                    this.menuTableAdapter.Update(this.dsPermisos.Menu);
                    dgvMenuSistema.CurrentCell = dgvMenuSistema.Rows[selectedIndex].Cells[1];
                    dgvMenuSistema.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvMenuSistema.ReadOnly = true;
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

            if (dgvMenuSistema.Rows.Count > 0 && dgvMenuSistema.FirstDisplayedCell != null)
            {
                saveRow = dgvMenuSistema.FirstDisplayedCell.RowIndex;
                dgvMenuSistema.ReadOnly = false;
                dgvMenuSistema.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvMenuSistema.Rows.Count)
                dgvMenuSistema.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMenuSistema.Rows.Count > 0 && dgvMenuSistema.FirstDisplayedCell != null)
            {
                selectedIndex = dgvMenuSistema.CurrentRow.Index;

                this.menuTableAdapter.Fill(this.dsPermisos.Menu);
                dgvMenuSistema.CurrentCell = dgvMenuSistema.Rows[selectedIndex].Cells[1];
                dgvMenuSistema.AllowUserToAddRows = false;

                dgvMenuSistema.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMenuSistema_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR ITEMS - N° DE REGISTROS: " + dgvMenuSistema.RowCount;
        }

        private void dgvMenuSistema_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenuSistema.Rows.Count > 0 && dgvMenuSistema.SelectedRows.Count >= 1)
                selectedIndex = dgvMenuSistema.SelectedRows[0].Index;
        }

        private void dgvMenuSistema_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frmMenuSistema_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPermisos.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.dsPermisos.Menu);

        }
    }
}
