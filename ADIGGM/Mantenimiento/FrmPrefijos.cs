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
    public partial class FrmPrefijos : FrmMantenimiento
    {
        int selectedIndex;

        public FrmPrefijos()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvPrefijos);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmPrefijos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Prefijos' Puede moverla o quitarla según sea necesario.
            this.tR_PrefijosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Prefijos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvPrefijos.AllowUserToAddRows = true;
            dgvPrefijos.ReadOnly = false;
            dgvPrefijos.FirstDisplayedScrollingRowIndex = dgvPrefijos.RowCount - 1;
            var cantidadRow = dgvPrefijos.RowCount - 1;
            dgvPrefijos.CurrentCell = dgvPrefijos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrefijos.Rows.Count > 0 && dgvPrefijos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvPrefijos.CurrentRow.Index;
                    dgvPrefijos.EndEdit();
                    this.tR_PrefijosTableAdapter.Update(this.dsTransporteAdiggm.TR_Prefijos);
                    dgvPrefijos.CurrentCell = dgvPrefijos.Rows[selectedIndex].Cells[1];
                    dgvPrefijos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvPrefijos.ReadOnly = true;
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

            if (dgvPrefijos.Rows.Count > 0 && dgvPrefijos.FirstDisplayedCell != null)
            {
                saveRow = dgvPrefijos.FirstDisplayedCell.RowIndex;
                dgvPrefijos.ReadOnly = false;
                dgvPrefijos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvPrefijos.Rows.Count)
                dgvPrefijos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvPrefijos.Rows.Count > 0 && dgvPrefijos.FirstDisplayedCell != null)
            {
                selectedIndex = dgvPrefijos.CurrentRow.Index;

                this.tR_PrefijosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Prefijos);
                dgvPrefijos.CurrentCell = dgvPrefijos.Rows[selectedIndex].Cells[1];
                dgvPrefijos.AllowUserToAddRows = false;

                dgvPrefijos.ReadOnly = true;
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

        private void dgvPrefijos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvPrefijos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR PREFIJOS - N° DE REGISTROS: " + dgvPrefijos.RowCount;
        }
    }
}
