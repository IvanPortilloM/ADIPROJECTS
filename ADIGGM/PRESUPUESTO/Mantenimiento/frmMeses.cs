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
    public partial class frmMeses : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();

        public frmMeses()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvMeses);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Meses' Puede moverla o quitarla según sea necesario.
            this.pR_MesesTableAdapter.Fill(this.dsPresupuesto.PR_Meses);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvMeses.AllowUserToAddRows = true;
            dgvMeses.ReadOnly = false;
            dgvMeses.FirstDisplayedScrollingRowIndex = dgvMeses.RowCount - 1;
            var cantidadRow = dgvMeses.RowCount - 1;
            dgvMeses.CurrentCell = dgvMeses.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMeses.Rows.Count > 0 && dgvMeses.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvMeses.CurrentRow.Index;
                    dgvMeses.EndEdit();
                    this.pR_MesesTableAdapter.Update(this.dsPresupuesto.PR_Meses);
                    dgvMeses.CurrentCell = dgvMeses.Rows[selectedIndex].Cells[1];
                    dgvMeses.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvMeses.ReadOnly = true;
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

            if (dgvMeses.Rows.Count > 0 && dgvMeses.FirstDisplayedCell != null)
            {
                saveRow = dgvMeses.FirstDisplayedCell.RowIndex;
                dgvMeses.ReadOnly = false;
                dgvMeses.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvMeses.Rows.Count)
                dgvMeses.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMeses.Rows.Count > 0 && dgvMeses.FirstDisplayedCell != null)
            {
                selectedIndex = dgvMeses.CurrentRow.Index;

                this.pR_MesesTableAdapter.Fill(this.dsPresupuesto.PR_Meses);
                dgvMeses.CurrentCell = dgvMeses.Rows[selectedIndex].Cells[1];
                dgvMeses.AllowUserToAddRows = false;

                dgvMeses.ReadOnly = true;
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

        private void dgvMeses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
