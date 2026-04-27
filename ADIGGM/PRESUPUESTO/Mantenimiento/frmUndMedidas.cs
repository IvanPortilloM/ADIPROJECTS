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
    public partial class frmUndMedidas : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmUndMedidas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvUndMedidas);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void dgvUndMedidas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frmUndMedidas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_undMedidas' Puede moverla o quitarla según sea necesario.
            this.pR_undMedidasTableAdapter.Fill(this.dsPresupuesto.PR_undMedidas);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvUndMedidas.AllowUserToAddRows = true;
            dgvUndMedidas.ReadOnly = false;
            dgvUndMedidas.FirstDisplayedScrollingRowIndex = dgvUndMedidas.RowCount - 1;
            var cantidadRow = dgvUndMedidas.RowCount - 1;
            dgvUndMedidas.CurrentCell = dgvUndMedidas.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUndMedidas.Rows.Count > 0 && dgvUndMedidas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvUndMedidas.CurrentRow.Index;
                    dgvUndMedidas.EndEdit();
                    this.pR_undMedidasTableAdapter.Update(this.dsPresupuesto.PR_undMedidas);
                    dgvUndMedidas.CurrentCell = dgvUndMedidas.Rows[selectedIndex].Cells[1];
                    dgvUndMedidas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvUndMedidas.ReadOnly = true;
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

            if (dgvUndMedidas.Rows.Count > 0 && dgvUndMedidas.FirstDisplayedCell != null)
            {
                saveRow = dgvUndMedidas.FirstDisplayedCell.RowIndex;
                dgvUndMedidas.ReadOnly = false;
                dgvUndMedidas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvUndMedidas.Rows.Count)
                dgvUndMedidas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvUndMedidas.Rows.Count > 0 && dgvUndMedidas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvUndMedidas.CurrentRow.Index;

                this.pR_undMedidasTableAdapter.Fill(this.dsPresupuesto.PR_undMedidas);
                dgvUndMedidas.CurrentCell = dgvUndMedidas.Rows[selectedIndex].Cells[1];
                dgvUndMedidas.AllowUserToAddRows = false;

                dgvUndMedidas.ReadOnly = true;
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
