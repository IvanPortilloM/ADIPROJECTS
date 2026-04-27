using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios_Base;

namespace ADIGGM.INV.Mantenimiento
{
    public partial class frmBodegas : FrmMantenimiento
    {
        int selectedIndex;
        public frmBodegas()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvBodegas);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void frmBodegas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsInventarioAdiggm.IN_Bodegas' Puede moverla o quitarla según sea necesario.
            this.iN_BodegasTableAdapter.Fill(this.dsInventarioAdiggm.IN_Bodegas);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBodegas.AllowUserToAddRows = true;
                dgvBodegas.ReadOnly = false;
                if (dgvBodegas.Rows.Count > 0 && dgvBodegas.FirstDisplayedCell != null)
                {
                    dgvBodegas.FirstDisplayedScrollingRowIndex = dgvBodegas.RowCount - 1;
                    var cantidadRow = dgvBodegas.RowCount - 1;
                    dgvBodegas.CurrentCell = dgvBodegas.Rows[cantidadRow].Cells[1];
                }
                else
                {
                    dgvBodegas.FirstDisplayedScrollingRowIndex = 0;
                    var cantidadRow = 0;
                    dgvBodegas.CurrentCell = dgvBodegas.Rows[cantidadRow].Cells[1];
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
                if (dgvBodegas.Rows.Count > 0 && dgvBodegas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvBodegas.CurrentRow.Index;
                    dgvBodegas.EndEdit();
                    this.iN_BodegasTableAdapter.Update(this.dsInventarioAdiggm.IN_Bodegas);
                    dgvBodegas.CurrentCell = dgvBodegas.Rows[selectedIndex].Cells[1];
                    dgvBodegas.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvBodegas.ReadOnly = true;
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

            if (dgvBodegas.Rows.Count > 0 && dgvBodegas.FirstDisplayedCell != null)
            {
                saveRow = dgvBodegas.FirstDisplayedCell.RowIndex;
                dgvBodegas.ReadOnly = false;
                dgvBodegas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvBodegas.Rows.Count)
                dgvBodegas.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvBodegas.Rows.Count > 0 && dgvBodegas.FirstDisplayedCell != null && dgvBodegas.CurrentRow.IsNewRow == false)
            {
                selectedIndex = dgvBodegas.CurrentRow.Index;
                this.iN_BodegasTableAdapter.Fill(this.dsInventarioAdiggm.IN_Bodegas);
                dgvBodegas.CurrentCell = dgvBodegas.Rows[selectedIndex].Cells[1];
            }
            else
            {
                this.iN_BodegasTableAdapter.Fill(this.dsInventarioAdiggm.IN_Bodegas);
            }

            dgvBodegas.AllowUserToAddRows = false;
            dgvBodegas.ReadOnly = true;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
