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
    public partial class frmTipoContratos : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();

        public frmTipoContratos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoContrato);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmTipoContratos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoContratos' Puede moverla o quitarla según sea necesario.
            this.pR_tipoContratosTableAdapter.Fill(this.dsPresupuesto.PR_tipoContratos);

        }

        private void dgvTipoContrato_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoContrato.AllowUserToAddRows = true;
            dgvTipoContrato.ReadOnly = false;
            dgvTipoContrato.FirstDisplayedScrollingRowIndex = dgvTipoContrato.RowCount - 1;
            var cantidadRow = dgvTipoContrato.RowCount - 1;
            dgvTipoContrato.CurrentCell = dgvTipoContrato.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoContrato.Rows.Count > 0 && dgvTipoContrato.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvTipoContrato.CurrentRow.Index;
                    dgvTipoContrato.EndEdit();
                    this.pR_tipoContratosTableAdapter.Update(this.dsPresupuesto.PR_tipoContratos);
                    dgvTipoContrato.CurrentCell = dgvTipoContrato.Rows[selectedIndex].Cells[1];
                    dgvTipoContrato.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoContrato.ReadOnly = true;
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

            if (dgvTipoContrato.Rows.Count > 0 && dgvTipoContrato.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoContrato.FirstDisplayedCell.RowIndex;
                dgvTipoContrato.ReadOnly = false;
                dgvTipoContrato.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoContrato.Rows.Count)
                dgvTipoContrato.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoContrato.Rows.Count > 0 && dgvTipoContrato.FirstDisplayedCell != null)
            {
                selectedIndex = dgvTipoContrato.CurrentRow.Index;

                this.pR_tipoContratosTableAdapter.Fill(this.dsPresupuesto.PR_tipoContratos);
                dgvTipoContrato.CurrentCell = dgvTipoContrato.Rows[selectedIndex].Cells[1];
                dgvTipoContrato.AllowUserToAddRows = false;

                dgvTipoContrato.ReadOnly = true;
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
