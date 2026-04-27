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
    public partial class frmMateriales : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmMateriales()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvMateriales);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvMateriales.AllowUserToAddRows = true;
            dgvMateriales.ReadOnly = false;
            dgvMateriales.FirstDisplayedScrollingRowIndex = dgvMateriales.RowCount - 1;
            var cantidadRow = dgvMateriales.RowCount - 1;
            dgvMateriales.CurrentCell = dgvMateriales.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void frmMateriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoMateriales' Puede moverla o quitarla según sea necesario.
            this.pR_tipoMaterialesTableAdapter.Fill(this.dsPresupuesto.PR_tipoMateriales);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_undMedidas' Puede moverla o quitarla según sea necesario.
            this.pR_undMedidasTableAdapter.Fill(this.dsPresupuesto.PR_undMedidas);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Materiales' Puede moverla o quitarla según sea necesario.
            this.pR_MaterialesTableAdapter.Fill(this.dsPresupuesto.PR_Materiales);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMateriales.Rows.Count > 0 && dgvMateriales.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvMateriales.CurrentRow.Index;
                    dgvMateriales.EndEdit();
                    this.pR_MaterialesTableAdapter.Update(this.dsPresupuesto.PR_Materiales);
                    dgvMateriales.CurrentCell = dgvMateriales.Rows[selectedIndex].Cells[1];
                    dgvMateriales.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvMateriales.ReadOnly = true;
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

            if (dgvMateriales.Rows.Count > 0 && dgvMateriales.FirstDisplayedCell != null)
            {
                saveRow = dgvMateriales.FirstDisplayedCell.RowIndex;
                dgvMateriales.ReadOnly = false;
                dgvMateriales.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvMateriales.Rows.Count)
                dgvMateriales.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.Rows.Count > 0 && dgvMateriales.FirstDisplayedCell != null)
            {
                selectedIndex = dgvMateriales.CurrentRow.Index;

                this.pR_MaterialesTableAdapter.Fill(this.dsPresupuesto.PR_Materiales);
                dgvMateriales.CurrentCell = dgvMateriales.Rows[selectedIndex].Cells[1];
                dgvMateriales.AllowUserToAddRows = false;

                dgvMateriales.ReadOnly = true;
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

        private void dgvMateriales_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvMateriales_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =
        dgvMateriales.Columns[e.ColumnIndex].HeaderText;

            if (!headerText.Equals("Precio Base") || !headerText.Equals("Precio Real")) return;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvMateriales.Rows[e.RowIndex].ErrorText =
                    "Este campo no puede quedar vacío";
                e.Cancel = true;
            }
        }
        private void dgvMateriales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvMateriales.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dgvMateriales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvMateriales.CurrentCell.ColumnIndex == 4 || dgvMateriales.CurrentCell.ColumnIndex == 5 || dgvMateriales.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
             && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void dgvMateriales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvMateriales.Columns[e.ColumnIndex].Name == "precioBase" || dgvMateriales.Columns[e.ColumnIndex].Name == "porcentaje"))
            {
                decimal porcen;
                if (dgvMateriales.Rows[e.RowIndex].Cells["porcentaje"].Value == "")
                {
                    porcen = 0;
                }
                else
                {
                    porcen = Convert.ToDecimal(dgvMateriales.Rows[e.RowIndex].Cells["porcentaje"].Value);
                }

                dgvMateriales.Rows[e.RowIndex].Cells["precioReal"].Value = Convert.ToDecimal(dgvMateriales.Rows[e.RowIndex].Cells["precioBase"].Value) * ((porcen / 100) + 1); 
            }
        }
    }
}