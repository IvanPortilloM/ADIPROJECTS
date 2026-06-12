using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using Formularios_Base;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_TipoFacturas : FrmMantenimiento
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        private DataTable _dt;

        public FAC_TipoFacturas()
        {
            InitializeComponent();
        }

        private void FAC_TipoFacturas_Load(object sender, EventArgs e)
        {
            CargarTiposFactura();
            lblFooter.Text = "Tipo Facturas - #Registros: " + (dgvTipoFactura.RowCount);
        }

        private void CargarTiposFactura()
        {
            _dt = _repo.ListarTiposFactura();
            fACTipoFacturasBindingSource.DataMember = "";
            fACTipoFacturasBindingSource.DataSource = _dt;
            dgvTipoFactura.DataSource = fACTipoFacturasBindingSource;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoFactura.AllowUserToAddRows = true;
            dgvTipoFactura.ReadOnly = false;
            dgvTipoFactura.FirstDisplayedScrollingRowIndex = dgvTipoFactura.RowCount - 1;
            var cantidadRow = dgvTipoFactura.RowCount - 1;
            dgvTipoFactura.CurrentCell = dgvTipoFactura.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoFactura.Rows.Count > 0 && dgvTipoFactura.FirstDisplayedCell != null)
                {
                    dgvTipoFactura.EndEdit();
                    fACTipoFacturasBindingSource.EndEdit();
                    _repo.GuardarTiposFactura(_dt);
                    CargarTiposFactura();
                    dgvTipoFactura.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoFactura.ReadOnly = true;
                    lblFooter.Text = "Tipo Facturas - #Registros: " + (dgvTipoFactura.RowCount);
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

            if (dgvTipoFactura.Rows.Count > 0 && dgvTipoFactura.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoFactura.FirstDisplayedCell.RowIndex;
                dgvTipoFactura.ReadOnly = false;
                dgvTipoFactura.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoFactura.Rows.Count)
                dgvTipoFactura.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvTipoFactura.AllowUserToAddRows = false;
            if (dgvTipoFactura.Rows.Count > 0 && dgvTipoFactura.FirstDisplayedCell != null)
            {
                CargarTiposFactura();
                dgvTipoFactura.CurrentCell = dgvTipoFactura.Rows[dgvTipoFactura.CurrentRow.Index].Cells[1];

                dgvTipoFactura.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipo Facturas - #Registros: " + (dgvTipoFactura.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
