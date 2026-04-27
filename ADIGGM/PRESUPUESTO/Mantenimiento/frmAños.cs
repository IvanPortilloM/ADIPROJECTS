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
    public partial class frmAños : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmAños()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvAños);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmAños_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Anios' Puede moverla o quitarla según sea necesario.
            this.pR_AniosTableAdapter.Fill(this.dsPresupuesto.PR_Anios);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvAños.AllowUserToAddRows = true;
            dgvAños.ReadOnly = false;
            dgvAños.FirstDisplayedScrollingRowIndex = dgvAños.RowCount - 1;
            var cantidadRow = dgvAños.RowCount - 1;
            dgvAños.CurrentCell = dgvAños.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAños.Rows.Count > 0 && dgvAños.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvAños.CurrentRow.Index;
                    dgvAños.EndEdit();
                    this.pR_AniosTableAdapter.Update(this.dsPresupuesto.PR_Anios);
                    dgvAños.CurrentCell = dgvAños.Rows[selectedIndex].Cells[1];
                    dgvAños.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvAños.ReadOnly = true;
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

            if (dgvAños.Rows.Count > 0 && dgvAños.FirstDisplayedCell != null)
            {
                saveRow = dgvAños.FirstDisplayedCell.RowIndex;
                dgvAños.ReadOnly = false;
                dgvAños.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvAños.Rows.Count)
                dgvAños.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAños.Rows.Count > 0 && dgvAños.FirstDisplayedCell != null)
            {
                selectedIndex = dgvAños.CurrentRow.Index;

                this.pR_AniosTableAdapter.Fill(this.dsPresupuesto.PR_Anios);
                dgvAños.CurrentCell = dgvAños.Rows[selectedIndex].Cells[1];
                dgvAños.AllowUserToAddRows = false;

                dgvAños.ReadOnly = true;
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

        private void dgvAños_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
