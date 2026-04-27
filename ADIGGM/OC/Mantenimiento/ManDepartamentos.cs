using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManDepartamentos : FrmMantenimiento
    {
        public ManDepartamentos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvDepartamentos);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void ManDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Departamentos' Puede moverla o quitarla según sea necesario.
            this.oC_DepartamentosTableAdapter.Fill(this.dsOC.OC_Departamentos);
            lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvDepartamentos.AllowUserToAddRows = true;
            dgvDepartamentos.ReadOnly = false;
            dgvDepartamentos.FirstDisplayedScrollingRowIndex = dgvDepartamentos.RowCount - 1;
            var cantidadRow = dgvDepartamentos.RowCount - 1;
            dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
                {
                    dgvDepartamentos.EndEdit();
                    this.oC_DepartamentosTableAdapter.Update(this.dsOC.OC_Departamentos);
                    dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[dgvDepartamentos.CurrentRow.Index].Cells[1];
                    dgvDepartamentos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvDepartamentos.ReadOnly = true;
                    lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
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

            if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
            {
                saveRow = dgvDepartamentos.FirstDisplayedCell.RowIndex;
                dgvDepartamentos.ReadOnly = false;
                dgvDepartamentos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvDepartamentos.Rows.Count)
                dgvDepartamentos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
            {
                this.oC_DepartamentosTableAdapter.Fill(this.dsOC.OC_Departamentos);
                dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[dgvDepartamentos.CurrentRow.Index].Cells[1];
                dgvDepartamentos.AllowUserToAddRows = false;

                dgvDepartamentos.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDepartamentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDepartamentos.RowCount > 0)
                {
                    dgvDepartamentos.CurrentRow.Cells["Usuario"].Value = Clases.VarGlobales.Usuario;
                    dgvDepartamentos.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
