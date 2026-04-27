using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmMotoristas : FrmMantenimiento
    {
        int selectedIndex;

        public FrmMotoristas()
        {
            InitializeComponent();

            HabilitarBtn();
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        
        VarGlobales variables = new VarGlobales();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMotorista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.HE_PoliticasPago' Puede moverla o quitarla según sea necesario.
            this.hE_PoliticasPagoTableAdapter.Fill(this.dsTransporteAdiggm.HE_PoliticasPago);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Motoristas' Puede moverla o quitarla según sea necesario.
            this.tR_MotoristasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Motoristas);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Motoristas' Puede moverla o quitarla según sea necesario.
            this.tR_MotoristasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Motoristas);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvMotoristas.AllowUserToAddRows = true;
            dgvMotoristas.ReadOnly = false;
            dgvMotoristas.FirstDisplayedScrollingRowIndex = dgvMotoristas.RowCount - 1;
            var cantidadRow = dgvMotoristas.RowCount - 1;
            dgvMotoristas.CurrentCell = dgvMotoristas.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMotoristas.Rows.Count > 0 && dgvMotoristas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvMotoristas.CurrentRow.Index;
                    dgvMotoristas.EndEdit();
                    this.tR_MotoristasTableAdapter.Update(this.dsTransporteAdiggm.TR_Motoristas);
                    dgvMotoristas.CurrentCell = dgvMotoristas.Rows[selectedIndex].Cells[1];
                    dgvMotoristas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvMotoristas.ReadOnly = true;
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

            if (dgvMotoristas.Rows.Count > 0 && dgvMotoristas.FirstDisplayedCell != null)
            {
                saveRow = dgvMotoristas.FirstDisplayedCell.RowIndex;
                dgvMotoristas.ReadOnly = false;
                dgvMotoristas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvMotoristas.Rows.Count)
                dgvMotoristas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvMotoristas.Rows.Count > 0 && dgvMotoristas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvMotoristas.CurrentRow.Index;

                this.tR_MotoristasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Motoristas);
                dgvMotoristas.CurrentCell = dgvMotoristas.Rows[selectedIndex].Cells[1];
                dgvMotoristas.AllowUserToAddRows = false;

                dgvMotoristas.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void dgvMotoristas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvMotoristas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR MOTORISTAS - N° DE REGISTROS: " + dgvMotoristas.RowCount;
        }
    }
}
