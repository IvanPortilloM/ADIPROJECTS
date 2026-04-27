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
    public partial class frmTipoMateriales : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmTipoMateriales()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoMateriales);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTipoMateriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoMateriales' Puede moverla o quitarla según sea necesario.
            this.pR_tipoMaterialesTableAdapter.Fill(this.dsPresupuesto.PR_tipoMateriales);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoMateriales.AllowUserToAddRows = true;
            dgvTipoMateriales.ReadOnly = false;
            dgvTipoMateriales.FirstDisplayedScrollingRowIndex = dgvTipoMateriales.RowCount - 1;
            var cantidadRow = dgvTipoMateriales.RowCount - 1;
            dgvTipoMateriales.CurrentCell = dgvTipoMateriales.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoMateriales.Rows.Count > 0 && dgvTipoMateriales.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvTipoMateriales.CurrentRow.Index;
                    dgvTipoMateriales.EndEdit();
                    this.pR_tipoMaterialesTableAdapter.Update(this.dsPresupuesto.PR_tipoMateriales);
                    dgvTipoMateriales.CurrentCell = dgvTipoMateriales.Rows[selectedIndex].Cells[1];
                    dgvTipoMateriales.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoMateriales.ReadOnly = true;
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

            if (dgvTipoMateriales.Rows.Count > 0 && dgvTipoMateriales.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoMateriales.FirstDisplayedCell.RowIndex;
                dgvTipoMateriales.ReadOnly = false;
                dgvTipoMateriales.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoMateriales.Rows.Count)
                dgvTipoMateriales.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoMateriales.Rows.Count > 0 && dgvTipoMateriales.FirstDisplayedCell != null)
            {
                selectedIndex = dgvTipoMateriales.CurrentRow.Index;

                this.pR_tipoMaterialesTableAdapter.Fill(this.dsPresupuesto.PR_tipoMateriales);
                dgvTipoMateriales.CurrentCell = dgvTipoMateriales.Rows[selectedIndex].Cells[1];
                dgvTipoMateriales.AllowUserToAddRows = false;

                dgvTipoMateriales.ReadOnly = true;
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

        private void dgvTipoMateriales_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
