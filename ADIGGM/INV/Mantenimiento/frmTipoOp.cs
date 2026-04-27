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
using ADIGGM.Clases;

namespace ADIGGM.INV.Mantenimiento
{
    public partial class frmTipoOp : FrmMantenimiento
    {
        int selectedIndex;
        public frmTipoOp()
        {
            InitializeComponent();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoOp);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmTipoOp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsInventarioAdiggm.IN_TipoOperaciones' Puede moverla o quitarla según sea necesario.
            this.iN_TipoOperacionesTableAdapter.Fill(this.dsInventarioAdiggm.IN_TipoOperaciones);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTipoOp.AllowUserToAddRows = true;
                dgvTipoOp.ReadOnly = false;
                if (dgvTipoOp.Rows.Count > 0 && dgvTipoOp.FirstDisplayedCell != null)
                {
                    dgvTipoOp.FirstDisplayedScrollingRowIndex = dgvTipoOp.RowCount - 1;
                    var cantidadRow = dgvTipoOp.RowCount - 1;
                    dgvTipoOp.CurrentCell = dgvTipoOp.Rows[cantidadRow].Cells[1];
                }
                else
                {
                    dgvTipoOp.FirstDisplayedScrollingRowIndex = 0;
                    var cantidadRow = 0;
                    dgvTipoOp.CurrentCell = dgvTipoOp.Rows[cantidadRow].Cells[1];
                }
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoOp.Rows.Count > 0 && dgvTipoOp.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvTipoOp.CurrentRow.Index;
                    dgvTipoOp.EndEdit();
                    this.iN_TipoOperacionesTableAdapter.Update(this.dsInventarioAdiggm.IN_TipoOperaciones);
                    dgvTipoOp.CurrentCell = dgvTipoOp.Rows[selectedIndex].Cells[1];
                    dgvTipoOp.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoOp.ReadOnly = true;
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

            if (dgvTipoOp.Rows.Count > 0 && dgvTipoOp.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoOp.FirstDisplayedCell.RowIndex;
                dgvTipoOp.ReadOnly = false;
                dgvTipoOp.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoOp.Rows.Count)
                dgvTipoOp.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoOp.Rows.Count > 0 && dgvTipoOp.FirstDisplayedCell != null && dgvTipoOp.CurrentRow.IsNewRow == false)
            {
                selectedIndex = dgvTipoOp.CurrentRow.Index;
                this.iN_TipoOperacionesTableAdapter.Fill(this.dsInventarioAdiggm.IN_TipoOperaciones);
                dgvTipoOp.CurrentCell = dgvTipoOp.Rows[selectedIndex].Cells[1];
            }
            else
            {
                this.iN_TipoOperacionesTableAdapter.Fill(this.dsInventarioAdiggm.IN_TipoOperaciones);
            }

            dgvTipoOp.AllowUserToAddRows = false;
            dgvTipoOp.ReadOnly = true;
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
