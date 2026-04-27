using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Formularios_Base;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmClientes : FrmMantenimiento
    {
        int selectedIndex;
        public FrmClientes()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvClientes);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Clientes' Puede moverla o quitarla según sea necesario.
            this.tR_ClientesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Clientes);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvClientes.AllowUserToAddRows = true;
            dgvClientes.ReadOnly = false;
            dgvClientes.FirstDisplayedScrollingRowIndex = dgvClientes.RowCount - 1;
            var cantidadRow = dgvClientes.RowCount - 1;
            dgvClientes.CurrentCell = dgvClientes.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.Rows.Count > 0 && dgvClientes.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvClientes.CurrentRow.Index;
                    dgvClientes.EndEdit();
                    this.tR_ClientesTableAdapter.Update(this.dsTransporteAdiggm.TR_Clientes);
                    dgvClientes.CurrentCell = dgvClientes.Rows[selectedIndex].Cells[1];
                    dgvClientes.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvClientes.ReadOnly = true;
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

            if (dgvClientes.Rows.Count > 0 && dgvClientes.FirstDisplayedCell != null)
            {
                saveRow = dgvClientes.FirstDisplayedCell.RowIndex;
                dgvClientes.ReadOnly = false;
                dgvClientes.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvClientes.Rows.Count)
                dgvClientes.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0 && dgvClientes.FirstDisplayedCell != null)
            {
                selectedIndex = dgvClientes.CurrentRow.Index;

                this.tR_ClientesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Clientes);
                dgvClientes.CurrentCell = dgvClientes.Rows[selectedIndex].Cells[1];
                dgvClientes.AllowUserToAddRows = false;

                dgvClientes.ReadOnly = true;
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

        private void dgvClientes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvClientes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR CLIENTES - N° DE REGISTROS: " + dgvClientes.RowCount;
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0 && dgvClientes.SelectedRows.Count >= 1)
                selectedIndex = dgvClientes.SelectedRows[0].Index;
        }
    }
}
