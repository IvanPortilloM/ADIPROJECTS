using System;
using System.Windows.Forms;
using Formularios_Base;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManParametrizacion : FrmMantenimiento
    {
        public ManParametrizacion()
        {
            InitializeComponent();
        }

        private void ManParametrizacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Parametrizacion' Puede moverla o quitarla según sea necesario.
            this.oC_ParametrizacionTableAdapter.Fill(this.dsOC.OC_Parametrizacion);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvParametrizacion.Rows.Count > 0 && dgvParametrizacion.FirstDisplayedCell != null)
                {
                    dgvParametrizacion.EndEdit();
                    this.oC_ParametrizacionTableAdapter.Update(this.dsOC.OC_Parametrizacion);
                    dgvParametrizacion.CurrentCell = dgvParametrizacion.Rows[dgvParametrizacion.CurrentRow.Index].Cells[1];
                    dgvParametrizacion.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvParametrizacion.ReadOnly = true;
                    //lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvParametrizacion.RowCount);
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

            if (dgvParametrizacion.Rows.Count > 0 && dgvParametrizacion.FirstDisplayedCell != null)
            {
                saveRow = dgvParametrizacion.FirstDisplayedCell.RowIndex;
                dgvParametrizacion.ReadOnly = false;
                dgvParametrizacion.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvParametrizacion.Rows.Count)
                dgvParametrizacion.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvParametrizacion.Rows.Count > 0 && dgvParametrizacion.FirstDisplayedCell != null)
            {
                this.oC_ParametrizacionTableAdapter.Fill(this.dsOC.OC_Parametrizacion);
                dgvParametrizacion.CurrentCell = dgvParametrizacion.Rows[dgvParametrizacion.CurrentRow.Index].Cells[1];
                dgvParametrizacion.AllowUserToAddRows = false;

                dgvParametrizacion.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                //lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvParametrizacion.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
