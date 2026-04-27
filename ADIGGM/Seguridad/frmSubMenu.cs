using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class frmSubMenu : FrmMantenimiento
    {
        int selectedIndex;
        public frmSubMenu()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvSubMenu);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void frmSubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPermisos.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.dsPermisos.Menu);
            // TODO: esta línea de código carga datos en la tabla 'dsPermisos.SubMenu' Puede moverla o quitarla según sea necesario.
            this.subMenuTableAdapter.Fill(this.dsPermisos.SubMenu);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvSubMenu.AllowUserToAddRows = true;
            dgvSubMenu.ReadOnly = false;
            dgvSubMenu.FirstDisplayedScrollingRowIndex = dgvSubMenu.RowCount - 1;
            var cantidadRow = dgvSubMenu.RowCount - 1;
            dgvSubMenu.CurrentCell = dgvSubMenu.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvSubMenu.CurrentRow.Index;
                    dgvSubMenu.EndEdit();
                    this.subMenuTableAdapter.Update(this.dsPermisos.SubMenu);
                    dgvSubMenu.CurrentCell = dgvSubMenu.Rows[selectedIndex].Cells[2];
                    dgvSubMenu.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvSubMenu.ReadOnly = true;
                    lblFooter.Text = "MENUS HIJOS - CANTIDAD DE REGISTROS: " + dgvSubMenu.RowCount;
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

            if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.FirstDisplayedCell != null)
            {
                saveRow = dgvSubMenu.FirstDisplayedCell.RowIndex;
                dgvSubMenu.ReadOnly = false;
                dgvSubMenu.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvSubMenu.Rows.Count)
                dgvSubMenu.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.FirstDisplayedCell != null)
            {
                selectedIndex = dgvSubMenu.CurrentRow.Index;

                this.subMenuTableAdapter.Fill(this.dsPermisos.SubMenu);
                dgvSubMenu.CurrentCell = dgvSubMenu.Rows[selectedIndex].Cells[2];
                dgvSubMenu.AllowUserToAddRows = false;

                dgvSubMenu.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void dgvSubMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvSubMenu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR ITEMS - N° DE REGISTROS: " + dgvSubMenu.RowCount;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMenuPadre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.SelectedRows.Count >= 1)
                selectedIndex = dgvSubMenu.SelectedRows[0].Index;
        }

        private void dgvSubMenu_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
