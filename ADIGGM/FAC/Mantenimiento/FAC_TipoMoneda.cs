using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_TipoMoneda : FrmMantenimiento
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        private DataTable _dt;

        public FAC_TipoMoneda()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre — gotcha §11.</summary>
        private void ConfigurarColumnas()
        {
            dgvTipoMoneda.AutoGenerateColumns = false;
            dgvTipoMoneda.Columns.Clear();
            dgvTipoMoneda.Columns.Add(GridColumnas.Texto("idTipoMonedaDataGridViewTextBoxColumn", "IdTipoMoneda", "IdTipoMoneda", visible: false));
            dgvTipoMoneda.Columns.Add(GridColumnas.Texto("tipoMonedaDataGridViewTextBoxColumn", "TipoMoneda", "TipoMoneda"));
            dgvTipoMoneda.Columns.Add(GridColumnas.Texto("simboloDataGridViewTextBoxColumn", "Simbolo", "Simbolo"));
            dgvTipoMoneda.Columns.Add(GridColumnas.Texto("valorLempirasDataGridViewTextBoxColumn", "ValorLempiras", "ValorLempiras", format: "N2"));
        }

        private void FAC_TipoMoneda_Load(object sender, EventArgs e)
        {
            CargarTiposMoneda();
        }

        private void CargarTiposMoneda()
        {
            _dt = _repo.ListarTiposMoneda();
            fACTipoMonedaBindingSource.DataMember = "";
            fACTipoMonedaBindingSource.DataSource = _dt;
            dgvTipoMoneda.DataSource = fACTipoMonedaBindingSource;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoMoneda.AllowUserToAddRows = true;
            Clases.GridColumnas.Edicion(dgvTipoMoneda, true);
            dgvTipoMoneda.FirstDisplayedScrollingRowIndex = dgvTipoMoneda.RowCount - 1;
            var cantidadRow = dgvTipoMoneda.RowCount - 1;
            dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
                {
                    dgvTipoMoneda.EndEdit();
                    fACTipoMonedaBindingSource.EndEdit();
                    _repo.GuardarTiposMoneda(_dt);
                    CargarTiposMoneda();
                    dgvTipoMoneda.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvTipoMoneda.ReadOnly = true;
                    lblFooter.Text = "Tipo Moneda - #Registros: " + (dgvTipoMoneda.RowCount);
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

            if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoMoneda.FirstDisplayedCell.RowIndex;
                Clases.GridColumnas.Edicion(dgvTipoMoneda, true);
                dgvTipoMoneda.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoMoneda.Rows.Count)
                dgvTipoMoneda.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvTipoMoneda.AllowUserToAddRows = false;
            if (dgvTipoMoneda.Rows.Count > 0 && dgvTipoMoneda.FirstDisplayedCell != null)
            {
                CargarTiposMoneda();
                dgvTipoMoneda.CurrentCell = dgvTipoMoneda.Rows[dgvTipoMoneda.CurrentRow.Index].Cells[1];

                dgvTipoMoneda.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipo Moneda - #Registros: " + (dgvTipoMoneda.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
