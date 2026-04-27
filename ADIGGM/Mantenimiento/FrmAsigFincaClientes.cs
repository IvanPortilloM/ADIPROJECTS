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
    public partial class FrmAsigFincaClientes : FrmMantenimiento
    {
        int selectedIndex;
        public FrmAsigFincaClientes()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvAsigFincaClientes);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void FrmAsigFincaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Fincas' Puede moverla o quitarla según sea necesario.
            this.tR_FincasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Fincas);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_AsigFincaCliente' Puede moverla o quitarla según sea necesario.
            this.tR_AsigFincaClienteTableAdapter.Fill(this.dsTransporteAdiggm.TR_AsigFincaCliente);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Clientes' Puede moverla o quitarla según sea necesario.
            this.tR_ClientesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Clientes);
            lblFooter.Text = "FINCAS ASIGNADAS - CANTIDAD DE REGISTROS: " + dgvAsigFincaClientes.RowCount;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvAsigFincaClientes.AllowUserToAddRows = true;
            dgvAsigFincaClientes.ReadOnly = false;
            dgvAsigFincaClientes.FirstDisplayedScrollingRowIndex = dgvAsigFincaClientes.RowCount - 1;
            var cantidadRow = dgvAsigFincaClientes.RowCount - 1;
            dgvAsigFincaClientes.CurrentCell = dgvAsigFincaClientes.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAsigFincaClientes.Rows.Count > 0 && dgvAsigFincaClientes.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvAsigFincaClientes.CurrentRow.Index;
                    dgvAsigFincaClientes.EndEdit();
                    this.tR_AsigFincaClienteTableAdapter.Update(this.dsTransporteAdiggm.TR_AsigFincaCliente);
                    dgvAsigFincaClientes.CurrentCell = dgvAsigFincaClientes.Rows[selectedIndex].Cells[1];
                    dgvAsigFincaClientes.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvAsigFincaClientes.ReadOnly = true;
                    lblFooter.Text = "FINCAS - CANTIDAD DE REGISTROS: " + dgvAsigFincaClientes.RowCount;
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

            if (dgvAsigFincaClientes.Rows.Count > 0 && dgvAsigFincaClientes.FirstDisplayedCell != null)
            {
                saveRow = dgvAsigFincaClientes.FirstDisplayedCell.RowIndex;
                dgvAsigFincaClientes.ReadOnly = false;
                dgvAsigFincaClientes.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvAsigFincaClientes.Rows.Count)
                dgvAsigFincaClientes.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAsigFincaClientes.Rows.Count > 0)
            {
                if (dgvAsigFincaClientes.FirstDisplayedCell != null && dgvAsigFincaClientes.FirstDisplayedCell.Value != null)
                {
                    selectedIndex = dgvAsigFincaClientes.CurrentRow.Index;

                    this.tR_AsigFincaClienteTableAdapter.Fill(this.dsTransporteAdiggm.TR_AsigFincaCliente);
                    dgvAsigFincaClientes.CurrentCell = dgvAsigFincaClientes.Rows[selectedIndex].Cells[1];
                    dgvAsigFincaClientes.AllowUserToAddRows = false;

                    dgvAsigFincaClientes.ReadOnly = true;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}