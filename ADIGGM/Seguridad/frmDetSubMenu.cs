using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios_Base;

namespace ADIGGM.Seguridad
{
    public partial class frmDetSubMenu : FrmMantenimiento
    {
        int selectedIndex;
        public frmDetSubMenu()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvdetSubMenu);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmDetSubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPermisos.DetSubMenu' Puede moverla o quitarla según sea necesario.
            this.detSubMenuTableAdapter.Fill(this.dsPermisos.DetSubMenu);
            // TODO: esta línea de código carga datos en la tabla 'dsPermisos.SubMenu' Puede moverla o quitarla según sea necesario.
            this.subMenuTableAdapter.Fill(this.dsPermisos.SubMenu);
            // TODO: esta línea de código carga datos en la tabla 'dsPermisos.Menu' Puede moverla o quitarla según sea necesario.
            this.menuTableAdapter.Fill(this.dsPermisos.Menu);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvdetSubMenu.AllowUserToAddRows = true;
            dgvdetSubMenu.ReadOnly = false;
            dgvdetSubMenu.FirstDisplayedScrollingRowIndex = dgvdetSubMenu.RowCount - 1;
            var cantidadRow = dgvdetSubMenu.RowCount - 1;
            dgvdetSubMenu.CurrentCell = dgvdetSubMenu.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvdetSubMenu.CurrentRow.Index;
                    dgvdetSubMenu.EndEdit();
                    this.detSubMenuTableAdapter.Update(this.dsPermisos.DetSubMenu);
                    dgvdetSubMenu.CurrentCell = dgvdetSubMenu.Rows[selectedIndex].Cells[2];
                    dgvdetSubMenu.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvdetSubMenu.ReadOnly = true;
                    lblFooter.Text = "MENUS HIJOS - CANTIDAD DE REGISTROS: " + dgvdetSubMenu.RowCount;
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

            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.FirstDisplayedCell != null)
            {
                saveRow = dgvdetSubMenu.FirstDisplayedCell.RowIndex;
                dgvdetSubMenu.ReadOnly = false;
                dgvdetSubMenu.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvdetSubMenu.Rows.Count)
                dgvdetSubMenu.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.FirstDisplayedCell != null)
            {
                selectedIndex = dgvdetSubMenu.CurrentRow.Index;

                this.detSubMenuTableAdapter.Fill(this.dsPermisos.DetSubMenu);
                dgvdetSubMenu.CurrentCell = dgvdetSubMenu.Rows[selectedIndex].Cells[2];
                dgvdetSubMenu.AllowUserToAddRows = false;

                dgvdetSubMenu.ReadOnly = true;
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

        private void cboMenuPadre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.SelectedRows.Count >= 1)
                selectedIndex = dgvdetSubMenu.SelectedRows[0].Index;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.SelectedRows.Count >= 1)
                selectedIndex = dgvdetSubMenu.SelectedRows[0].Index;
        }

        private void dgvdetSubMenu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR ITEMS - N° DE REGISTROS: " + dgvdetSubMenu.RowCount;
        }

        private void dgvdetSubMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
