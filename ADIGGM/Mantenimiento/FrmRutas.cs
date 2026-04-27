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
    public partial class FrmRutas : FrmMantenimiento
    {
        int selectedIndex;
        public FrmRutas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRutas);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmRutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Rutas' Puede moverla o quitarla según sea necesario.
            this.tR_RutasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Rutas);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvRutas.AllowUserToAddRows = true;
            dgvRutas.ReadOnly = false;
            dgvRutas.FirstDisplayedScrollingRowIndex = dgvRutas.RowCount - 1;
            var cantidadRow = dgvRutas.RowCount - 1;
            dgvRutas.CurrentCell = dgvRutas.Rows[cantidadRow].Cells[0];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRutas.Rows.Count > 0 && dgvRutas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvRutas.CurrentRow.Index;
                    dgvRutas.EndEdit();
                    this.tR_RutasTableAdapter.Update(this.dsTransporteAdiggm.TR_Rutas);
                    dgvRutas.CurrentCell = dgvRutas.Rows[selectedIndex].Cells[1];
                    dgvRutas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvRutas.ReadOnly = true;
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

            if (dgvRutas.Rows.Count > 0 && dgvRutas.FirstDisplayedCell != null)
            {
                saveRow = dgvRutas.FirstDisplayedCell.RowIndex;
                dgvRutas.ReadOnly = false;
                dgvRutas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvRutas.Rows.Count)
                dgvRutas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvRutas.Rows.Count > 0 && dgvRutas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRutas.CurrentRow.Index;

                this.tR_RutasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Rutas);
                dgvRutas.CurrentCell = dgvRutas.Rows[selectedIndex].Cells[1];
                dgvRutas.AllowUserToAddRows = false;

                dgvRutas.ReadOnly = true;
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

        private void dgvRutas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvRutas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR RUTAS - N° DE REGISTROS: " + dgvRutas.RowCount;
        }
    }
}
