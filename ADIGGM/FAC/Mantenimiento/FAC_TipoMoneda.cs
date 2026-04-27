using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Formularios_Base;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_TipoMoneda : FrmMantenimiento
    {
        public FAC_TipoMoneda()
        {
            InitializeComponent();
        }

        private void FAC_TipoMoneda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_TipoMoneda' Puede moverla o quitarla según sea necesario.
            this.fAC_TipoMonedaTableAdapter.Fill(this.dsFAC.FAC_TipoMoneda);
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
                {
                    dgvTipoMoneda.EndEdit();
                    this.fAC_TipoMonedaTableAdapter.Update(this.dsFAC.FAC_TipoMoneda);
                    dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[dgvTipoMoneda.CurrentRow.Index].Cells[1];
                    dgvTipoMoneda.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoMoneda.ReadOnly = true;
                    lblFooter.Text = "Tipo Moneda - #Registros: " + (dgvTipoMoneda.RowCount);
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
            dgvTipoMoneda.AllowUserToAddRows = false;
            if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
            {
                this.fAC_TipoMonedaTableAdapter.Fill(this.dsFAC.FAC_TipoMoneda);
                dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[dgvTipoMoneda.CurrentRow.Index].Cells[1];

                dgvTipoMoneda.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipo Moneda - #Registros: " + (dgvTipoMoneda.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
