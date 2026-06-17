using System;
using System.Data;
using System.Windows.Forms;
using Formularios_Base;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.INV.Mantenimiento
{
    public partial class frmBodegas : FrmMantenimiento
    {
        private readonly RepositorioInventario _repo = new RepositorioInventario();
        private DataTable _dtBodegas;
        int selectedIndex;

        public frmBodegas()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvBodegas);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Grid editable de mantenimiento (edición por cascada de dgv.ReadOnly).</summary>
        private void ConfigurarColumnas()
        {
            dgvBodegas.AutoGenerateColumns = false;
            dgvBodegas.Columns.Clear();
            dgvBodegas.Columns.Add(GridColumnas.Texto("idBodega", "IdBodega", "IdBodega", visible: false));
            dgvBodegas.Columns.Add(GridColumnas.Texto("nombreBodega", "NombreBodega", "Bodega", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvBodegas.Columns.Add(GridColumnas.Check("activo", "Activo", "Activo"));
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        /// <summary>Carga la tabla vía Dapper (DataTable) y la enlaza al BindingSource del grid.</summary>
        private void CargarBodegas()
        {
            _dtBodegas = _repo.ListarBodegas();
            iNBodegasBindingSource.DataMember = "";
            iNBodegasBindingSource.DataSource = _dtBodegas;
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvBodegas.DataSource = iNBodegasBindingSource;
        }

        private void frmBodegas_Load(object sender, EventArgs e)
        {
            CargarBodegas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvBodegas.AllowUserToAddRows = true;
                Clases.GridColumnas.Edicion(dgvBodegas, true);
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
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    iNBodegasBindingSource.EndEdit();

                    // Persiste altas/cambios del DataTable con Dapper (reemplaza TableAdapter.Update)
                    _repo.GuardarBodegas(_dtBodegas);

                    // Recargar para reflejar los IDs identity recién generados
                    CargarBodegas();
                    if (selectedIndex >= 0 && selectedIndex < dgvBodegas.Rows.Count)
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
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvBodegas.Rows.Count > 0 && dgvBodegas.FirstDisplayedCell != null)
            {
                saveRow = dgvBodegas.FirstDisplayedCell.RowIndex;
                Clases.GridColumnas.Edicion(dgvBodegas, true);
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
                CargarBodegas();
                if (selectedIndex >= 0 && selectedIndex < dgvBodegas.Rows.Count)
                    dgvBodegas.CurrentCell = dgvBodegas.Rows[selectedIndex].Cells[1];
            }
            else
            {
                CargarBodegas();
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
