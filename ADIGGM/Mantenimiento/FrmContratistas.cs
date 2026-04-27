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
    public partial class FrmContratistas : FrmMantenimiento
    {
        int selectedIndex;

        public FrmContratistas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvContratistas);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void dgvContratistas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FrmContratistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Contratistas' Puede moverla o quitarla según sea necesario.
            this.tR_ContratistasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Contratistas);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvContratistas.AllowUserToAddRows = true;
            dgvContratistas.ReadOnly = false;
            dgvContratistas.FirstDisplayedScrollingRowIndex = dgvContratistas.RowCount - 1;
            var cantidadRow = dgvContratistas.RowCount - 1;
            dgvContratistas.CurrentCell = dgvContratistas.Rows[cantidadRow].Cells[0];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContratistas.Rows.Count > 0 && dgvContratistas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvContratistas.CurrentRow.Index;
                    dgvContratistas.EndEdit();
                    this.tR_ContratistasTableAdapter.Update(this.dsTransporteAdiggm.TR_Contratistas);
                    dgvContratistas.CurrentCell = dgvContratistas.Rows[selectedIndex].Cells[1];
                    dgvContratistas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvContratistas.ReadOnly = true;
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

            if (dgvContratistas.Rows.Count > 0 && dgvContratistas.FirstDisplayedCell != null)
            {
                saveRow = dgvContratistas.FirstDisplayedCell.RowIndex;
                dgvContratistas.ReadOnly = false;
                dgvContratistas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvContratistas.Rows.Count)
                dgvContratistas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvContratistas.Rows.Count > 0 && dgvContratistas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvContratistas.CurrentRow.Index;

                this.tR_ContratistasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Contratistas);
                dgvContratistas.CurrentCell = dgvContratistas.Rows[selectedIndex].Cells[1];
                dgvContratistas.AllowUserToAddRows = false;

                dgvContratistas.ReadOnly = true;
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

        private void dgvContratistas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR CONTRATISTAS - N° DE REGISTROS: " + dgvContratistas.RowCount;
        }
    }
}
