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
    public partial class FrmFincas : FrmMantenimiento
    {
        int selectedIndex;

        public FrmFincas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvFincas);
        }

        private void FrmFincas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Fincas' Puede moverla o quitarla según sea necesario.
            this.tR_FincasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Fincas);
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
            try
            {
                dgvFincas.AllowUserToAddRows = true;
                dgvFincas.ReadOnly = false;
                if (dgvFincas.Rows.Count > 0 && dgvFincas.FirstDisplayedCell != null)
                {
                        dgvFincas.FirstDisplayedScrollingRowIndex = dgvFincas.RowCount - 1;
                        var cantidadRow = dgvFincas.RowCount - 1;
                        dgvFincas.CurrentCell = dgvFincas.Rows[cantidadRow].Cells[1];
                }
                else
                {
                    dgvFincas.FirstDisplayedScrollingRowIndex = 0;
                    var cantidadRow = 0;
                    dgvFincas.CurrentCell = dgvFincas.Rows[cantidadRow].Cells[1];
                }
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFincas.Rows.Count > 0 && dgvFincas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvFincas.CurrentRow.Index;
                    dgvFincas.EndEdit();
                    this.tR_FincasTableAdapter.Update(this.dsTransporteAdiggm.TR_Fincas);
                    dgvFincas.CurrentCell = dgvFincas.Rows[selectedIndex].Cells[1];
                    dgvFincas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvFincas.ReadOnly = true;
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

            if (dgvFincas.Rows.Count > 0 && dgvFincas.FirstDisplayedCell != null)
            {
                saveRow = dgvFincas.FirstDisplayedCell.RowIndex;
                dgvFincas.ReadOnly = false;
                dgvFincas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvFincas.Rows.Count)
                dgvFincas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvFincas.Rows.Count > 0 && dgvFincas.FirstDisplayedCell != null && dgvFincas.CurrentRow.IsNewRow == false)
            {
                selectedIndex = dgvFincas.CurrentRow.Index;
                this.tR_FincasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Fincas);
                dgvFincas.CurrentCell = dgvFincas.Rows[selectedIndex].Cells[1];
            }
            else
            {
                this.tR_FincasTableAdapter.Fill(this.dsTransporteAdiggm.TR_Fincas);
            }

            dgvFincas.AllowUserToAddRows = false;
            dgvFincas.ReadOnly = true;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFincas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvFincas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR FINCAS - N° DE REGISTROS: " + dgvFincas.RowCount;
        }
    }
}
