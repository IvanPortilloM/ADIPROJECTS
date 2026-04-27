using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Formularios_Base;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmAsigTpFacTpVeh : FrmMantenimiento
    {
        int selectedIndex;
        public FrmAsigTpFacTpVeh()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvAsigTipoFac);
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
            dgvAsigTipoFac.AllowUserToAddRows = true;
            dgvAsigTipoFac.ReadOnly = false;
            dgvAsigTipoFac.FirstDisplayedScrollingRowIndex = dgvAsigTipoFac.RowCount - 1;
            var cantidadRow = dgvAsigTipoFac.RowCount - 1;
            dgvAsigTipoFac.CurrentCell = dgvAsigTipoFac.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAsigTipoFac.Rows.Count > 0 && dgvAsigTipoFac.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvAsigTipoFac.CurrentRow.Index;
                    dgvAsigTipoFac.EndEdit();
                    this.tR_AsigFacTipoVehTableAdapter.Update(this.dsCodeasAdiggm.TR_AsigFacTipoVeh);
                    dgvAsigTipoFac.CurrentCell = dgvAsigTipoFac.Rows[selectedIndex].Cells[2];
                    dgvAsigTipoFac.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvAsigTipoFac.ReadOnly = true;
                    lblFooter.Text = "VEHÍCULOS - CANTIDAD DE REGISTROS: " + dgvAsigTipoFac.RowCount;
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

            if (dgvAsigTipoFac.Rows.Count > 0 && dgvAsigTipoFac.FirstDisplayedCell != null)
            {
                saveRow = dgvAsigTipoFac.FirstDisplayedCell.RowIndex;
                dgvAsigTipoFac.ReadOnly = false;
                dgvAsigTipoFac.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvAsigTipoFac.Rows.Count)
                dgvAsigTipoFac.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAsigTipoFac.Rows.Count > 0 && dgvAsigTipoFac.FirstDisplayedCell != null)
            {
                selectedIndex = dgvAsigTipoFac.CurrentRow.Index;

                this.tR_AsigFacTipoVehTableAdapter.Fill(this.dsCodeasAdiggm.TR_AsigFacTipoVeh);
                dgvAsigTipoFac.CurrentCell = dgvAsigTipoFac.Rows[selectedIndex].Cells[2];
                dgvAsigTipoFac.AllowUserToAddRows = false;

                dgvAsigTipoFac.ReadOnly = true;
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

        private void dgvAsigTipoFac_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvAsigTipoFac_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "TIPO DE VEH ASIG. A ESTE TIPO DE FACTURA: " + dgvAsigTipoFac.RowCount;
        }

        private void FrmAsigTpFacTpVeh_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_TipoVehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_TipoVehiculosTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_TipoVehiculos);
            // TODO: esta línea de código carga datos en la tabla 'dsCodeasAdiggm.TR_AsigFacTipoVeh' Puede moverla o quitarla según sea necesario.
            this.tR_AsigFacTipoVehTableAdapter.Fill(this.dsCodeasAdiggm.TR_AsigFacTipoVeh);
            // TODO: esta línea de código carga datos en la tabla 'dsCodeasAdiggm.TR_TipoFacturas' Puede moverla o quitarla según sea necesario.
            this.tR_TipoFacturasTableAdapter.Fill(this.dsCodeasAdiggm.TR_TipoFacturas);
            lblFooter.Text = "TIPOS DE VEH ASIGNADOS AL TIPO DE FACTURA - CANTIDAD DE REGISTROS: " + dgvAsigTipoFac.RowCount;
        }
    }
}
