using System;
using System.Data;
using System.Windows.Forms;
using Formularios_Base;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.INV.Mantenimiento
{
    public partial class frmTipoOp : FrmMantenimiento
    {
        private readonly RepositorioInventario _repo = new RepositorioInventario();
        private DataTable _dtTipoOp;
        int selectedIndex;

        public frmTipoOp()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTipoOp);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Grid editable de mantenimiento (edición por cascada de dgv.ReadOnly).</summary>
        private void ConfigurarColumnas()
        {
            dgvTipoOp.AutoGenerateColumns = false;
            dgvTipoOp.Columns.Clear();
            dgvTipoOp.Columns.Add(GridColumnas.Texto("idTipoOperacion", "IdTipoOperacion", "IdTipoOperacion", visible: false));
            dgvTipoOp.Columns.Add(GridColumnas.Texto("nombreOperacion", "NombreOperacion", "Operación", autoSize: DataGridViewAutoSizeColumnMode.Fill));
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        /// <summary>Carga la tabla vía Dapper (DataTable) y la enlaza al BindingSource del grid.</summary>
        private void CargarTipoOp()
        {
            _dtTipoOp = _repo.ListarTiposOperacion();
            iNTipoOperacionesBindingSource.DataMember = "";
            iNTipoOperacionesBindingSource.DataSource = _dtTipoOp;
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvTipoOp.DataSource = iNTipoOperacionesBindingSource;
        }

        private void frmTipoOp_Load(object sender, EventArgs e)
        {
            CargarTipoOp();
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
                    iNTipoOperacionesBindingSource.EndEdit();

                    // Persiste altas/cambios del DataTable con Dapper (reemplaza TableAdapter.Update)
                    _repo.GuardarTiposOperacion(_dtTipoOp);

                    // Recargar para reflejar los IDs identity recién generados
                    CargarTipoOp();
                    if (selectedIndex >= 0 && selectedIndex < dgvTipoOp.Rows.Count)
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
                CargarTipoOp();
                if (selectedIndex >= 0 && selectedIndex < dgvTipoOp.Rows.Count)
                    dgvTipoOp.CurrentCell = dgvTipoOp.Rows[selectedIndex].Cells[1];
            }
            else
            {
                CargarTipoOp();
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
