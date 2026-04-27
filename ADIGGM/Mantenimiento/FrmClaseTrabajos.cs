using ADIGGM.Clases;
using Formularios_Base;
using System;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmClaseTrabajos : FrmMantenimiento
    {
        int selectedIndex;

        public FrmClaseTrabajos()
        {
            InitializeComponent();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvClaseTrabajos);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void FrmClaseTrabajos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_ClaseTrabajos' Puede moverla o quitarla según sea necesario.
            this.tR_ClaseTrabajosTableAdapter.Fill(this.dsTransporteAdiggm.TR_ClaseTrabajos);

        }
        private void dgvClaseTrabajos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvClaseTrabajos.AllowUserToAddRows = true;
            dgvClaseTrabajos.ReadOnly = false;
            dgvClaseTrabajos.FirstDisplayedScrollingRowIndex = dgvClaseTrabajos.RowCount - 1;
            var cantidadRow = dgvClaseTrabajos.RowCount - 1;
            dgvClaseTrabajos.CurrentCell = dgvClaseTrabajos.Rows[cantidadRow].Cells[0];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClaseTrabajos.Rows.Count > 0 && dgvClaseTrabajos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvClaseTrabajos.CurrentRow.Index;
                    dgvClaseTrabajos.EndEdit();
                    this.tR_ClaseTrabajosTableAdapter.Update(this.dsTransporteAdiggm.TR_ClaseTrabajos);
                    dgvClaseTrabajos.CurrentCell = dgvClaseTrabajos.Rows[selectedIndex].Cells[1];
                    dgvClaseTrabajos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvClaseTrabajos.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvClaseTrabajos.Rows.Count > 0 && dgvClaseTrabajos.FirstDisplayedCell != null)
            {
                saveRow = dgvClaseTrabajos.FirstDisplayedCell.RowIndex;
                dgvClaseTrabajos.ReadOnly = false;
                dgvClaseTrabajos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvClaseTrabajos.Rows.Count > 0 && dgvClaseTrabajos.FirstDisplayedCell != null)
            {
                selectedIndex = dgvClaseTrabajos.CurrentRow.Index;

                this.tR_ClaseTrabajosTableAdapter.Fill(this.dsTransporteAdiggm.TR_ClaseTrabajos);
                dgvClaseTrabajos.CurrentCell = dgvClaseTrabajos.Rows[selectedIndex].Cells[1];
                dgvClaseTrabajos.AllowUserToAddRows = false;

                dgvClaseTrabajos.ReadOnly = true;
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
        private void dgvClaseTrabajos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "CLASE DE TRABAJOS - N° DE REGISTROS: " + dgvClaseTrabajos.RowCount;
        }
    }
}