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
    public partial class frmCuentaCategoria : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmCuentaCategoria()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCtaCategoria);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void frmCuentaCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_ctaCategoria' Puede moverla o quitarla según sea necesario.
            this.pR_ctaCategoriaTableAdapter.Fill(this.dsPresupuesto.PR_ctaCategoria);

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCtaCategoria.AllowUserToAddRows = true;
            dgvCtaCategoria.ReadOnly = false;
            dgvCtaCategoria.FirstDisplayedScrollingRowIndex = dgvCtaCategoria.RowCount - 1;
            var cantidadRow = dgvCtaCategoria.RowCount - 1;
            dgvCtaCategoria.CurrentCell = dgvCtaCategoria.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCtaCategoria.Rows.Count > 0 && dgvCtaCategoria.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvCtaCategoria.CurrentRow.Index;
                    dgvCtaCategoria.EndEdit();
                    this.pR_ctaCategoriaTableAdapter.Update(this.dsPresupuesto.PR_ctaCategoria);
                    dgvCtaCategoria.CurrentCell = dgvCtaCategoria.Rows[selectedIndex].Cells[1];
                    dgvCtaCategoria.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvCtaCategoria.ReadOnly = true;
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

            if (dgvCtaCategoria.Rows.Count > 0 && dgvCtaCategoria.FirstDisplayedCell != null)
            {
                saveRow = dgvCtaCategoria.FirstDisplayedCell.RowIndex;
                dgvCtaCategoria.ReadOnly = false;
                dgvCtaCategoria.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCtaCategoria.Rows.Count)
                dgvCtaCategoria.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCtaCategoria.Rows.Count > 0 && dgvCtaCategoria.FirstDisplayedCell != null)
            {
                selectedIndex = dgvCtaCategoria.CurrentRow.Index;

                this.pR_ctaCategoriaTableAdapter.Fill(this.dsPresupuesto.PR_ctaCategoria);
                dgvCtaCategoria.CurrentCell = dgvCtaCategoria.Rows[selectedIndex].Cells[1];
                dgvCtaCategoria.AllowUserToAddRows = false;

                dgvCtaCategoria.ReadOnly = true;
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

        private void dgvCtaCategoria_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
