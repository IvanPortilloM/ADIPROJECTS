using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_CAI : FrmMantenimiento
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        private DataTable _dt;

        public FAC_CAI()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre — gotcha §11.</summary>
        private void ConfigurarColumnas()
        {
            dgvCAI.AutoGenerateColumns = false;
            dgvCAI.Columns.Clear();
            dgvCAI.Columns.Add(GridColumnas.Texto("idCaiDataGridViewTextBoxColumn", "IdCai", "IdCai", visible: false));
            dgvCAI.Columns.Add(GridColumnas.Texto("caiDataGridViewTextBoxColumn", "Cai", "Cai"));
            dgvCAI.Columns.Add(GridColumnas.Texto("fragmentoSARDataGridViewTextBoxColumn", "FragmentoSAR", "FragmentoSAR"));
            dgvCAI.Columns.Add(GridColumnas.Texto("fechaDesdeDataGridViewTextBoxColumn", "FechaDesde", "FechaDesde"));
            dgvCAI.Columns.Add(GridColumnas.Texto("fechaHastaDataGridViewTextBoxColumn", "FechaHasta", "FechaHasta"));
            dgvCAI.Columns.Add(GridColumnas.Texto("numeroDesdeDataGridViewTextBoxColumn", "NumeroDesde", "NumeroDesde"));
            dgvCAI.Columns.Add(GridColumnas.Texto("numeroHastaDataGridViewTextBoxColumn", "NumeroHasta", "NumeroHasta"));
            dgvCAI.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvCAI.Columns.Add(GridColumnas.Check("anuladoDataGridViewCheckBoxColumn", "Anulado", "Anulado", visible: false));
            dgvCAI.Columns.Add(GridColumnas.Texto("usuarioDataGridViewTextBoxColumn", "Usuario", "Usuario", visible: false));
            dgvCAI.Columns.Add(GridColumnas.Texto("nombreEquipoDataGridViewTextBoxColumn", "NombreEquipo", "NombreEquipo", visible: false));
            dgvCAI.Columns.Add(GridColumnas.Texto("idSucursalDataGridViewTextBoxColumn", "IdSucursal", "IdSucursal", visible: false));
        }

        private void FAC_CAI_Load(object sender, EventArgs e)
        {
            CargarCAI();
            lblFooter.Text = "CAI - #Registros: " + (dgvCAI.RowCount);
        }

        private void CargarCAI()
        {
            _dt = _repo.ListarCAI();
            fACCAIBindingSource.DataMember = "";
            fACCAIBindingSource.DataSource = _dt;
            dgvCAI.DataSource = fACCAIBindingSource;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCAI.AllowUserToAddRows = true;
            Clases.GridColumnas.Edicion(dgvCAI, true);
            dgvCAI.FirstDisplayedScrollingRowIndex = dgvCAI.RowCount - 1;
            var cantidadRow = dgvCAI.RowCount - 1;
            dgvCAI.CurrentCell = dgvCAI.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatagrid(dgvCAI) == true)
            {
                MessageBox.Show("Ingrese los campos para guardar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (dgvCAI.Rows.Count > 0 && dgvCAI.FirstDisplayedCell != null)
                    {
                        dgvCAI.EndEdit();
                        fACCAIBindingSource.EndEdit();
                        _repo.GuardarCAI(_dt);
                        CargarCAI();
                        dgvCAI.AllowUserToAddRows = false;

                        btnGuardar.Enabled = false;
                        btnNuevo.Enabled = true;
                        btnEditar.Enabled = true;
                        btnCancelar.Enabled = false;
                        dgvCAI.ReadOnly = true;
                        lblFooter.Text = "CAI - #Registros: " + (dgvCAI.RowCount);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvCAI.Rows.Count > 0 && dgvCAI.FirstDisplayedCell != null)
            {
                saveRow = dgvCAI.FirstDisplayedCell.RowIndex;
                Clases.GridColumnas.Edicion(dgvCAI, true);
                dgvCAI.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCAI.Rows.Count)
                dgvCAI.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvCAI.AllowUserToAddRows = false;
            if (dgvCAI.Rows.Count > 0 && dgvCAI.FirstDisplayedCell != null)
            {
                CargarCAI();
                dgvCAI.CurrentCell = dgvCAI.Rows[dgvCAI.CurrentRow.Index].Cells[1];

                dgvCAI.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "CAI - #Registros: " + (dgvCAI.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool validarDatagrid(DataGridView dgvListas)
        {
            bool IsEmptyCell = false;
            for (int i = 0; i < dgvListas.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvListas.ColumnCount; j++)
                {
                    if (dgvListas.Rows[i].Cells[j].Value == null)
                    {
                        IsEmptyCell = true;
                    }
                }
            }
            return IsEmptyCell;
        }
    }
}
