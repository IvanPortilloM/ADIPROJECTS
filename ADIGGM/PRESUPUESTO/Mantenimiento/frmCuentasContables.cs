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
    public partial class frmCuentasContables : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmCuentasContables()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCuentasContables);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmCuentasContables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_ctaCategoria' Puede moverla o quitarla según sea necesario.
            this.pR_ctaCategoriaTableAdapter.Fill(this.dsPresupuesto.PR_ctaCategoria);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cuentas' Puede moverla o quitarla según sea necesario.
            this.pR_CuentasTableAdapter.Fill(this.dsPresupuesto.PR_Cuentas);
        }

        private void dgvCuentasContables_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCuentasContables.AllowUserToAddRows = true;
            dgvCuentasContables.ReadOnly = false;
            dgvCuentasContables.FirstDisplayedScrollingRowIndex = dgvCuentasContables.RowCount - 1;
            var cantidadRow = dgvCuentasContables.RowCount - 1;
            dgvCuentasContables.CurrentCell = dgvCuentasContables.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCuentasContables.Rows.Count > 0 && dgvCuentasContables.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvCuentasContables.CurrentRow.Index;
                    dgvCuentasContables.EndEdit();
                    this.pR_CuentasTableAdapter.Update(this.dsPresupuesto.PR_Cuentas);
                    dgvCuentasContables.CurrentCell = dgvCuentasContables.Rows[selectedIndex].Cells[1];
                    dgvCuentasContables.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvCuentasContables.ReadOnly = true;
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

            if (dgvCuentasContables.Rows.Count > 0 && dgvCuentasContables.FirstDisplayedCell != null)
            {
                saveRow = dgvCuentasContables.FirstDisplayedCell.RowIndex;
                dgvCuentasContables.ReadOnly = false;
                dgvCuentasContables.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCuentasContables.Rows.Count)
                dgvCuentasContables.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCuentasContables.Rows.Count > 0 && dgvCuentasContables.FirstDisplayedCell != null)
            {
                selectedIndex = dgvCuentasContables.CurrentRow.Index;

                this.pR_CuentasTableAdapter.Fill(this.dsPresupuesto.PR_Cuentas);
                dgvCuentasContables.CurrentCell = dgvCuentasContables.Rows[selectedIndex].Cells[1];
                dgvCuentasContables.AllowUserToAddRows = false;

                dgvCuentasContables.ReadOnly = true;
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
