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
    public partial class frmCargos : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmCargos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCargos);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cargos' Puede moverla o quitarla según sea necesario.
            this.pR_CargosTableAdapter.Fill(this.dsPresupuesto.PR_Cargos);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCargos.AllowUserToAddRows = true;
            dgvCargos.ReadOnly = false;
            dgvCargos.FirstDisplayedScrollingRowIndex = dgvCargos.RowCount - 1;
            var cantidadRow = dgvCargos.RowCount - 1;
            dgvCargos.CurrentCell = dgvCargos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCargos.Rows.Count > 0 && dgvCargos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvCargos.CurrentRow.Index;
                    dgvCargos.EndEdit();
                    this.pR_CargosTableAdapter.Update(this.dsPresupuesto.PR_Cargos);
                    dgvCargos.CurrentCell = dgvCargos.Rows[selectedIndex].Cells[1];
                    dgvCargos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvCargos.ReadOnly = true;
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

            if (dgvCargos.Rows.Count > 0 && dgvCargos.FirstDisplayedCell != null)
            {
                saveRow = dgvCargos.FirstDisplayedCell.RowIndex;
                dgvCargos.ReadOnly = false;
                dgvCargos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCargos.Rows.Count)
                dgvCargos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.Rows.Count > 0 && dgvCargos.FirstDisplayedCell != null)
            {
                selectedIndex = dgvCargos.CurrentRow.Index;

                this.pR_CargosTableAdapter.Fill(this.dsPresupuesto.PR_Cargos);
                dgvCargos.CurrentCell = dgvCargos.Rows[selectedIndex].Cells[1];
                dgvCargos.AllowUserToAddRows = false;

                dgvCargos.ReadOnly = true;
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

        private void dgvCargos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
