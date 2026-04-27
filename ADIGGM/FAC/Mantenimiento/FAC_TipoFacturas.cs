using Formularios_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_TipoFacturas : FrmMantenimiento
    {
        public FAC_TipoFacturas()
        {
            InitializeComponent();
        }

        private void FAC_TipoFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_TipoFacturas' Puede moverla o quitarla según sea necesario.
            this.fAC_TipoFacturasTableAdapter.Fill(this.dsFAC.FAC_TipoFacturas);
            lblFooter.Text = "Tipo Facturas - #Registros: " + (dgvTipoFactura.RowCount);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoFactura.AllowUserToAddRows = true;
            dgvTipoFactura.ReadOnly = false;
            dgvTipoFactura.FirstDisplayedScrollingRowIndex = dgvTipoFactura.RowCount - 1;
            var cantidadRow = dgvTipoFactura.RowCount - 1;
            dgvTipoFactura.CurrentCell = dgvTipoFactura.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoFactura.Rows.Count > 0 && dgvTipoFactura.FirstDisplayedCell != null)
                {
                    dgvTipoFactura.EndEdit();
                    this.fAC_TipoFacturasTableAdapter.Update(this.dsFAC.FAC_TipoFacturas);
                    dgvTipoFactura.CurrentCell = dgvTipoFactura.Rows[dgvTipoFactura.CurrentRow.Index].Cells[1];
                    dgvTipoFactura.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoFactura.ReadOnly = true;
                    lblFooter.Text = "Tipo Facturas - #Registros: " + (dgvTipoFactura.RowCount);
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

            if (dgvTipoFactura.Rows.Count > 0 && dgvTipoFactura.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoFactura.FirstDisplayedCell.RowIndex;
                dgvTipoFactura.ReadOnly = false;
                dgvTipoFactura.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoFactura.Rows.Count)
                dgvTipoFactura.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvTipoFactura.AllowUserToAddRows = false;
            if (dgvTipoFactura.Rows.Count > 0 && dgvTipoFactura.FirstDisplayedCell != null)
            {
                this.fAC_TipoFacturasTableAdapter.Fill(this.dsFAC.FAC_TipoFacturas);
                dgvTipoFactura.CurrentCell = dgvTipoFactura.Rows[dgvTipoFactura.CurrentRow.Index].Cells[1];

                dgvTipoFactura.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipo Facturas - #Registros: " + (dgvTipoFactura.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
