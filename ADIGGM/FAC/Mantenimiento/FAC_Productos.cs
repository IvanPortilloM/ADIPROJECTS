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
    public partial class FAC_Productos : FrmMantenimiento
    {
        public FAC_Productos()
        {
            InitializeComponent();
        }

        private void FAC_Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.TR_TipoFacturas' Puede moverla o quitarla según sea necesario.
            this.tR_TipoFacturasTableAdapter.Fill(this.dsFAC.TR_TipoFacturas);
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_TipoEx' Puede moverla o quitarla según sea necesario.
            this.fAC_TipoExTableAdapter.Fill(this.dsFAC.FAC_TipoEx);
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_Productos' Puede moverla o quitarla según sea necesario.
            this.fAC_ProductosTableAdapter.Fill(this.dsFAC.FAC_Productos);
            lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = true;
            dgvProductos.ReadOnly = false;
            dgvProductos.FirstDisplayedScrollingRowIndex = dgvProductos.RowCount - 1;
            var cantidadRow = dgvProductos.RowCount - 1;
            dgvProductos.CurrentCell = dgvProductos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
                {
                    dgvProductos.EndEdit();
                    this.fAC_ProductosTableAdapter.Update(this.dsFAC.FAC_Productos);
                    dgvProductos.CurrentCell = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1];
                    dgvProductos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvProductos.ReadOnly = true;
                    lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
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

            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                saveRow = dgvProductos.FirstDisplayedCell.RowIndex;
                dgvProductos.ReadOnly = false;
                dgvProductos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvProductos.Rows.Count)
                dgvProductos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = false;
            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                this.fAC_ProductosTableAdapter.Fill(this.dsFAC.FAC_Productos);
                dgvProductos.CurrentCell = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1];

                dgvProductos.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
