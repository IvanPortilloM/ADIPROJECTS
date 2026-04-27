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
    public partial class FrmBloques : FrmMantenimiento
    {
        int selectedIndex;

        public FrmBloques()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvBloques);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmBloques_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Bloques' Puede moverla o quitarla según sea necesario.
            this.tR_BloquesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Bloques);

        }

        private void dgvBloques_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvBloques.AllowUserToAddRows = true;
            dgvBloques.ReadOnly = false;
            dgvBloques.FirstDisplayedScrollingRowIndex = dgvBloques.RowCount - 1;
            var cantidadRow = dgvBloques.RowCount - 1;
            dgvBloques.CurrentCell = dgvBloques.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBloques.Rows.Count > 0 && dgvBloques.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvBloques.CurrentRow.Index;
                    dgvBloques.EndEdit();
                    this.tR_BloquesTableAdapter.Update(this.dsTransporteAdiggm.TR_Bloques);
                    dgvBloques.CurrentCell = dgvBloques.Rows[selectedIndex].Cells[1];
                    dgvBloques.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvBloques.ReadOnly = true;
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

            if (dgvBloques.Rows.Count > 0 && dgvBloques.FirstDisplayedCell != null)
            {
                saveRow = dgvBloques.FirstDisplayedCell.RowIndex;
                dgvBloques.ReadOnly = false;
                dgvBloques.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvBloques.Rows.Count)
                dgvBloques.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvBloques.Rows.Count > 0 && dgvBloques.FirstDisplayedCell != null)
            {
                selectedIndex = dgvBloques.CurrentRow.Index;

                this.tR_BloquesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Bloques);
                dgvBloques.CurrentCell = dgvBloques.Rows[selectedIndex].Cells[1];
                dgvBloques.AllowUserToAddRows = false;

                dgvBloques.ReadOnly = true;
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

        private void dgvBloques_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR BLOQUES - N° DE REGISTROS: " + dgvBloques.RowCount;
        }
    }
}