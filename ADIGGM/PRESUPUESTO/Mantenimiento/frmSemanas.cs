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
    public partial class frmSemanas : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();

        public frmSemanas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvSemanas);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmSemanas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Semanas' Puede moverla o quitarla según sea necesario.
            this.pR_SemanasTableAdapter.Fill(this.dsPresupuesto.PR_Semanas);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Meses' Puede moverla o quitarla según sea necesario.
            this.pR_MesesTableAdapter.Fill(this.dsPresupuesto.PR_Meses);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvSemanas.AllowUserToAddRows = true;
            dgvSemanas.ReadOnly = false;
            dgvSemanas.FirstDisplayedScrollingRowIndex = dgvSemanas.RowCount - 1;
            var cantidadRow = dgvSemanas.RowCount - 1;
            dgvSemanas.CurrentCell = dgvSemanas.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSemanas.Rows.Count > 0 && dgvSemanas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvSemanas.CurrentRow.Index;
                    dgvSemanas.EndEdit();
                    this.pR_SemanasTableAdapter.Update(this.dsPresupuesto.PR_Semanas);
                    dgvSemanas.CurrentCell = dgvSemanas.Rows[selectedIndex].Cells[1];
                    dgvSemanas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvSemanas.ReadOnly = true;
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

            if (dgvSemanas.Rows.Count > 0 && dgvSemanas.FirstDisplayedCell != null)
            {
                saveRow = dgvSemanas.FirstDisplayedCell.RowIndex;
                dgvSemanas.ReadOnly = false;
                dgvSemanas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvSemanas.Rows.Count)
                dgvSemanas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvSemanas.Rows.Count > 0 && dgvSemanas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvSemanas.CurrentRow.Index;

                this.pR_MesesTableAdapter.Fill(this.dsPresupuesto.PR_Meses);
                dgvSemanas.CurrentCell = dgvSemanas.Rows[selectedIndex].Cells[1];
                dgvSemanas.AllowUserToAddRows = false;

                dgvSemanas.ReadOnly = true;
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

        private void dgvSemanas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
