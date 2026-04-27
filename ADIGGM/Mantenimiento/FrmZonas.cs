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
    public partial class FrmZonas : FrmMantenimiento
    {
        int selectedIndex;

        public FrmZonas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvZonas);
        }

        private void FrmZonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Zonas' Puede moverla o quitarla según sea necesario.
            this.tR_ZonasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Zonas);

        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvZonas.AllowUserToAddRows = true;
            dgvZonas.ReadOnly = false;
            dgvZonas.FirstDisplayedScrollingRowIndex = dgvZonas.RowCount - 1;
            var cantidadRow = dgvZonas.RowCount - 1;
            dgvZonas.CurrentCell = dgvZonas.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvZonas.Rows.Count > 0 && dgvZonas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvZonas.CurrentRow.Index;
                    dgvZonas.EndEdit();
                    this.tR_ZonasTableAdapter.Update(this.dsTransporteAdiggm.TR_Zonas);
                    dgvZonas.CurrentCell = dgvZonas.Rows[selectedIndex].Cells[1];
                    dgvZonas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvZonas.ReadOnly = true;
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

            if (dgvZonas.Rows.Count > 0 && dgvZonas.FirstDisplayedCell != null)
            {
                saveRow = dgvZonas.FirstDisplayedCell.RowIndex;
                dgvZonas.ReadOnly = false;
                dgvZonas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvZonas.Rows.Count)
                dgvZonas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvZonas.Rows.Count > 0 && dgvZonas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvZonas.CurrentRow.Index;

                this.tR_ZonasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Zonas);
                dgvZonas.CurrentCell = dgvZonas.Rows[selectedIndex].Cells[1];
                dgvZonas.AllowUserToAddRows = false;

                dgvZonas.ReadOnly = true;
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

        private void dgvZonas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvZonas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR ZONAS - N° DE REGISTROS: " + dgvZonas.RowCount;
        }
    }
}
