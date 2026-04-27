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
    public partial class FrmTipoVehiculos : FrmMantenimiento
    {
        int selectedIndex;
        public FrmTipoVehiculos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoVehiculos);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmTipoVehiculos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.FAC_TipoEx' Puede moverla o quitarla según sea necesario.
            this.fAC_TipoExTableAdapter.Fill(this.dsTransporteAdiggm.FAC_TipoEx);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_TipoVehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_TipoVehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_TipoVehiculos);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoVehiculos.AllowUserToAddRows = true;
            dgvTipoVehiculos.ReadOnly = false;
            dgvTipoVehiculos.FirstDisplayedScrollingRowIndex = dgvTipoVehiculos.RowCount - 1;
            var cantidadRow = dgvTipoVehiculos.RowCount - 1;
            dgvTipoVehiculos.CurrentCell = dgvTipoVehiculos.Rows[cantidadRow].Cells[0];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoVehiculos.Rows.Count > 0 && dgvTipoVehiculos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvTipoVehiculos.CurrentRow.Index;
                    dgvTipoVehiculos.EndEdit();
                    this.tR_TipoVehiculosTableAdapter.Update(this.dsTransporteAdiggm.TR_TipoVehiculos);
                    dgvTipoVehiculos.CurrentCell = dgvTipoVehiculos.Rows[selectedIndex].Cells[1];
                    dgvTipoVehiculos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoVehiculos.ReadOnly = true;
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

            if (dgvTipoVehiculos.Rows.Count > 0 && dgvTipoVehiculos.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoVehiculos.FirstDisplayedCell.RowIndex;
                dgvTipoVehiculos.ReadOnly = false;
                dgvTipoVehiculos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoVehiculos.Rows.Count)
                dgvTipoVehiculos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoVehiculos.Rows.Count > 0 && dgvTipoVehiculos.FirstDisplayedCell != null)
            {
                selectedIndex = dgvTipoVehiculos.CurrentRow.Index;

                this.tR_TipoVehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_TipoVehiculos);
                dgvTipoVehiculos.CurrentCell = dgvTipoVehiculos.Rows[selectedIndex].Cells[1];
                dgvTipoVehiculos.AllowUserToAddRows = false;

                dgvTipoVehiculos.ReadOnly = true;
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

        private void dgvTipoVehiculos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvTipoVehiculos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR TIPO DE VEHÍCULOS - N° DE REGISTROS: " + dgvTipoVehiculos.RowCount;
        }
    }
}
