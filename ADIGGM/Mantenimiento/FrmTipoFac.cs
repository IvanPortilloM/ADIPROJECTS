using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using Formularios_Base;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmTipoFac : FrmMantenimiento
    {
        private readonly RepositorioTransporte _repo = new RepositorioTransporte();
        private DataTable _dt;
        int selectedIndex;

        public FrmTipoFac()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoFac);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        Clases.VarGlobales variables = new Clases.VarGlobales();

        private void CargarTipoFac()
        {
            _dt = _repo.ListarTipoFacturas();
            tRTipoFacturasBindingSource.DataMember = "";
            tRTipoFacturasBindingSource.DataSource = _dt;
            dgvTipoFac.DataSource = tRTipoFacturasBindingSource;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoFac.AllowUserToAddRows = true;
            dgvTipoFac.ReadOnly = false;
            dgvTipoFac.FirstDisplayedScrollingRowIndex = dgvTipoFac.RowCount - 1;
            var cantidadRow = dgvTipoFac.RowCount - 1;
            dgvTipoFac.CurrentCell = dgvTipoFac.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoFac.Rows.Count > 0 && dgvTipoFac.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvTipoFac.CurrentRow.Index;
                    dgvTipoFac.EndEdit();
                    tRTipoFacturasBindingSource.EndEdit();
                    _repo.GuardarTipoFacturas(_dt);
                    CargarTipoFac();
                    dgvTipoFac.CurrentCell = dgvTipoFac.Rows[selectedIndex].Cells[1];
                    dgvTipoFac.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoFac.ReadOnly = true;
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

            if (dgvTipoFac.Rows.Count > 0 && dgvTipoFac.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoFac.FirstDisplayedCell.RowIndex;
                dgvTipoFac.ReadOnly = false;
                dgvTipoFac.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoFac.Rows.Count)
                dgvTipoFac.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoFac.Rows.Count > 0 && dgvTipoFac.FirstDisplayedCell != null)
            {
                selectedIndex = dgvTipoFac.CurrentRow.Index;

                CargarTipoFac();
                dgvTipoFac.CurrentCell = dgvTipoFac.Rows[selectedIndex].Cells[1];
                dgvTipoFac.AllowUserToAddRows = false;

                dgvTipoFac.ReadOnly = true;
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

        private void dgvBloques_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR BLOQUES - N° DE REGISTROS: " + dgvTipoFac.RowCount;
        }

        private void dgvTipoFac_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void FrmTipoFac_Load(object sender, EventArgs e)
        {
            CargarTipoFac();
        }
    }
}