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
    public partial class FrmLagunas : FrmMantenimiento
    {
        int selectedIndex;
        public FrmLagunas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvLaguanas);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmLagunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Bloques' Puede moverla o quitarla según sea necesario.
            this.tR_BloquesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Bloques);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Zonas' Puede moverla o quitarla según sea necesario.
            this.tR_ZonasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Zonas);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Lagunas' Puede moverla o quitarla según sea necesario.
            this.tR_LagunasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Lagunas);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Fincas' Puede moverla o quitarla según sea necesario.
            this.tR_FincasTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_Fincas);

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            dgvLaguanas.AllowUserToAddRows = true;
            dgvLaguanas.ReadOnly = false;
            dgvLaguanas.FirstDisplayedScrollingRowIndex = dgvLaguanas.RowCount - 1;
            var cantidadRow = dgvLaguanas.RowCount - 1;
            dgvLaguanas.CurrentCell = dgvLaguanas.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvLaguanas.Rows.Count > 0 && dgvLaguanas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvLaguanas.CurrentRow.Index;
                    dgvLaguanas.EndEdit();
                    this.tR_LagunasTableAdapter.Update(this.dsTransporteAdiggm.TR_Lagunas);
                    dgvLaguanas.CurrentCell = dgvLaguanas.Rows[selectedIndex].Cells[1];
                    dgvLaguanas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvLaguanas.ReadOnly = true;
                    lblFooter.Text = "LAGUNAS - CANTIDAD DE REGISTROS: " + dgvLaguanas.RowCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvLaguanas.Rows.Count > 0 && dgvLaguanas.FirstDisplayedCell != null)
            {
                saveRow = dgvLaguanas.FirstDisplayedCell.RowIndex;
                dgvLaguanas.ReadOnly = false;
                dgvLaguanas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvLaguanas.Rows.Count)
                dgvLaguanas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvLaguanas.Rows.Count > 0 && dgvLaguanas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvLaguanas.CurrentRow.Index;

                this.tR_LagunasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Lagunas);
                dgvLaguanas.CurrentCell = dgvLaguanas.Rows[selectedIndex].Cells[1];
                dgvLaguanas.AllowUserToAddRows = false;

                dgvLaguanas.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvLaguanas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void CboFincas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.tR_LagunasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Lagunas);
            lblFooter.Text = "LAGUNAS - CANTIDAD DE REGISTROS: " + dgvLaguanas.RowCount;
        }

        private void DgvLaguanas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR LAGUNAS - N° DE REGISTROS: " + dgvLaguanas.RowCount;
        }
    }
}
