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
    public partial class frmTipoMoneda : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmTipoMoneda()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoMoneda);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmTipoMoneda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoMoneda' Puede moverla o quitarla según sea necesario.
            this.pR_tipoMonedaTableAdapter.Fill(this.dsPresupuesto.PR_tipoMoneda);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Anios' Puede moverla o quitarla según sea necesario.
            this.pR_AniosTableAdapter.Fill(this.dsPresupuesto.PR_Anios);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoMoneda' Puede moverla o quitarla según sea necesario.
            this.pR_tipoMonedaTableAdapter.Fill(this.dsPresupuesto.PR_tipoMoneda);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoMoneda.AllowUserToAddRows = true;
            dgvTipoMoneda.ReadOnly = false;
            dgvTipoMoneda.FirstDisplayedScrollingRowIndex = dgvTipoMoneda.RowCount - 1;
            var cantidadRow = dgvTipoMoneda.RowCount - 1;
            dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvTipoMoneda.CurrentRow.Index;
                    dgvTipoMoneda.EndEdit();
                    this.pR_tipoMonedaTableAdapter.Update(this.dsPresupuesto.PR_tipoMoneda);
                    dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[selectedIndex].Cells[1];
                    dgvTipoMoneda.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoMoneda.ReadOnly = true;
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

            if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoMoneda.FirstDisplayedCell.RowIndex;
                dgvTipoMoneda.ReadOnly = false;
                dgvTipoMoneda.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoMoneda.Rows.Count)
                dgvTipoMoneda.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
            {
                selectedIndex = dgvTipoMoneda.CurrentRow.Index;

                this.pR_tipoMonedaTableAdapter.Fill(this.dsPresupuesto.PR_tipoMoneda);
                dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[selectedIndex].Cells[1];
                dgvTipoMoneda.AllowUserToAddRows = false;

                dgvTipoMoneda.ReadOnly = true;
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

        private void dgvTipoMoneda_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
