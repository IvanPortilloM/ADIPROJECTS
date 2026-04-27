using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    public partial class frmDepartamentos : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();

        public frmDepartamentos()
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
        private void dgvDepartamentos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.Fill(this.dsPresupuesto.PR_Departamentos);

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
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvDepartamentos.CurrentRow.Index;
                    dgvDepartamentos.EndEdit();
                    this.pR_DepartamentosTableAdapter.Update(this.dsPresupuesto.PR_Departamentos);
                    dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[selectedIndex].Cells[1];
                    dgvDepartamentos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvDepartamentos.ReadOnly = true;
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
                selectedIndex = dgvDepartamentos.CurrentRow.Index;

                this.pR_DepartamentosTableAdapter.Fill(this.dsPresupuesto.PR_Departamentos);
                dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[selectedIndex].Cells[1];
                dgvDepartamentos.AllowUserToAddRows = false;

                dgvDepartamentos.ReadOnly = true;
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
    }
}
