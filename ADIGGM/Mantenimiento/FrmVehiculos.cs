using Formularios_Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmVehiculos : FrmMantenimiento
    {
        int selectedIndex;
        public FrmVehiculos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvVehiculos);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Contratistas' Puede moverla o quitarla según sea necesario.
            this.tR_ContratistasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Contratistas);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Motoristas' Puede moverla o quitarla según sea necesario.
            this.tR_MotoristasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Motoristas);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_VehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_TipoVehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_TipoVehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_TipoVehiculos);
            lblFooter.Text = "VEHÍCULOS - CANTIDAD DE REGISTROS: " + dgvVehiculos.RowCount;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvVehiculos.AllowUserToAddRows = true;
            dgvVehiculos.ReadOnly = false;
            dgvVehiculos.FirstDisplayedScrollingRowIndex = dgvVehiculos.RowCount - 1;
            var cantidadRow = dgvVehiculos.RowCount - 1;
            dgvVehiculos.CurrentCell = dgvVehiculos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVehiculos.Rows.Count > 0 && dgvVehiculos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvVehiculos.CurrentRow.Index;
                    dgvVehiculos.EndEdit();
                    this.tR_VehiculosTableAdapter.Update(this.dsTransporteAdiggm.TR_Vehiculos);
                    dgvVehiculos.CurrentCell = dgvVehiculos.Rows[selectedIndex].Cells[1];
                    dgvVehiculos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvVehiculos.ReadOnly = true;
                    lblFooter.Text = "VEHÍCULOS - CANTIDAD DE REGISTROS: " + dgvVehiculos.RowCount;
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

            if (dgvVehiculos.Rows.Count > 0 && dgvVehiculos.FirstDisplayedCell != null)
            {
                saveRow = dgvVehiculos.FirstDisplayedCell.RowIndex;
                dgvVehiculos.ReadOnly = false;
                dgvVehiculos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvVehiculos.Rows.Count)
                dgvVehiculos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvVehiculos.Rows.Count > 0 && dgvVehiculos.FirstDisplayedCell != null)
            {
                selectedIndex = dgvVehiculos.CurrentRow.Index;

                this.tR_VehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Vehiculos);
                dgvVehiculos.CurrentCell = dgvVehiculos.Rows[selectedIndex].Cells[1];
                dgvVehiculos.AllowUserToAddRows = false;

                dgvVehiculos.ReadOnly = true;
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

        private void dgvVehiculos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cboTipoVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.tR_VehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Vehiculos);
            lblFooter.Text = "VEHÍCULOS - CANTIDAD DE REGISTROS: " + dgvVehiculos.RowCount;
        }

        private void dgvVehiculos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR VEHÍCULOS - N° DE REGISTROS: " + dgvVehiculos.RowCount;
        }
    }
}
