using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using Formularios_Base;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_Productos : FrmMantenimiento
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        private DataTable _dt;

        public FAC_Productos()
        {
            InitializeComponent();
        }

        private void FAC_Productos_Load(object sender, EventArgs e)
        {
            // Combos de las columnas (tipos de exoneración y tipos de factura). Acceso por nombre con
            // null-check: si el diseñador de VS borrara la columna (gotcha §11), el form degrada en
            // vez de tronar con NullReferenceException al cargar.
            fACTipoExBindingSource.DataMember = "";
            fACTipoExBindingSource.DataSource = _repo.ListarTipoEx();
            if (dgvProductos.Columns["IdTipoEx"] is System.Windows.Forms.DataGridViewComboBoxColumn colTipoEx)
                colTipoEx.DataSource = fACTipoExBindingSource;
            tRTipoFacturasBindingSource.DataMember = "";
            tRTipoFacturasBindingSource.DataSource = _repo.ListarTipoFacturasCombo();
            if (dgvProductos.Columns["IdTipoFactura"] is System.Windows.Forms.DataGridViewComboBoxColumn colTipoFac)
                colTipoFac.DataSource = tRTipoFacturasBindingSource;

            CargarProductos();
            lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
        }

        private void CargarProductos()
        {
            _dt = _repo.ListarProductos();
            fACProductosBindingSource.DataMember = "";
            fACProductosBindingSource.DataSource = _dt;
            dgvProductos.DataSource = fACProductosBindingSource;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = true;
            dgvProductos.ReadOnly = false;
            dgvProductos.FirstDisplayedScrollingRowIndex = dgvProductos.RowCount - 1;
            var cantidadRow = dgvProductos.RowCount - 1;
            dgvProductos.CurrentCell = dgvProductos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
                {
                    dgvProductos.EndEdit();
                    fACProductosBindingSource.EndEdit();
                    _repo.GuardarProductos(_dt);
                    CargarProductos();
                    dgvProductos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvProductos.ReadOnly = true;
                    lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
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

            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                saveRow = dgvProductos.FirstDisplayedCell.RowIndex;
                dgvProductos.ReadOnly = false;
                dgvProductos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvProductos.Rows.Count)
                dgvProductos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = false;
            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                CargarProductos();
                dgvProductos.CurrentCell = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1];

                dgvProductos.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
