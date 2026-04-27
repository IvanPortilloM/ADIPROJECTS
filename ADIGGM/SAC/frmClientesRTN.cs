using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.SAC
{
    public partial class frmClientesRTN : FrmMantenimiento
    {
        int selectedIndex;
        public frmClientesRTN()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRTN);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmClientesRTN_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_RTN' Puede moverla o quitarla según sea necesario.
            this.fAC_RTNTableAdapter.Fill(this.dsFAC.FAC_RTN);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvRTN.AllowUserToAddRows = true;
            dgvRTN.ReadOnly = false;
            dgvRTN.FirstDisplayedScrollingRowIndex = dgvRTN.RowCount - 1;
            var cantidadRow = dgvRTN.RowCount - 1;
            dgvRTN.CurrentCell = dgvRTN.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRTN.Rows.Count > 0 && dgvRTN.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvRTN.CurrentRow.Index;
                    dgvRTN.EndEdit();
                    this.fAC_RTNTableAdapter.Update(this.dsFAC.FAC_RTN);
                    dgvRTN.CurrentCell = dgvRTN.Rows[selectedIndex].Cells[1];
                    dgvRTN.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvRTN.ReadOnly = true;
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

            if (dgvRTN.Rows.Count > 0 && dgvRTN.FirstDisplayedCell != null)
            {
                saveRow = dgvRTN.FirstDisplayedCell.RowIndex;
                dgvRTN.ReadOnly = false;
                dgvRTN.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvRTN.Rows.Count)
                dgvRTN.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvRTN.Rows.Count > 0 && dgvRTN.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRTN.CurrentRow.Index;

                this.fAC_RTNTableAdapter.Fill(this.dsFAC.FAC_RTN);
                dgvRTN.CurrentCell = dgvRTN.Rows[selectedIndex].Cells[1];
                dgvRTN.AllowUserToAddRows = false;

                dgvRTN.ReadOnly = true;
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

        private void dgvRTN_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR CLIENTES - N° DE REGISTROS: " + dgvRTN.RowCount;
        }

        private void dgvRTN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRTN.Rows.Count > 0 && dgvRTN.SelectedRows.Count >= 1)
                selectedIndex = dgvRTN.SelectedRows[0].Index;
        }

        private void txtBuscarRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.fAC_RTNTableAdapter.FillByBusqueda(this.dsFAC.FAC_RTN, txtBuscarRTN.Text);
                e.Handled = true;
            }
        }

        private void tbRTN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbRTN.SelectedTab.Text == "Ingresar RTN")
            {
                this.fAC_RTNTableAdapter.Fill(this.dsFAC.FAC_RTN);
                HabilitarBtn();
            }
            else
            {
                this.fAC_RTNTableAdapter.FillByBusqueda(this.dsFAC.FAC_RTN, txtBuscarRTN.Text);
                btnCancelar.PerformClick();
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.fAC_RTNTableAdapter.FillByBusqueda(this.dsFAC.FAC_RTN, txtBuscarRTN.Text);
        }
    }
}
