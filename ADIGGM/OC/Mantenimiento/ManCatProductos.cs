using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using Formularios_Base;

namespace ADIGGM.OC
{
    public partial class ManCatProductos : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManCatProductos()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCatProductos);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) — gotcha §11. Mantenimiento editable
        /// (toggle con GridColumnas.Edicion §14.10). "Usuario"/"NombreEquipo" se setean por código.</summary>
        private void ConfigurarColumnas()
        {
            dgvCatProductos.AutoGenerateColumns = false;
            dgvCatProductos.Columns.Clear();
            dgvCatProductos.Columns.Add(GridColumnas.Texto("idCatProductoDataGridViewTextBoxColumn", "IdCatProducto", "IdCatProducto", visible: false));
            dgvCatProductos.Columns.Add(GridColumnas.Texto("codigoDataGridViewTextBoxColumn", "Codigo", "Codigo"));
            dgvCatProductos.Columns.Add(GridColumnas.Texto("categoriaDataGridViewTextBoxColumn", "Categoria", "Categoria"));
            dgvCatProductos.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvCatProductos.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", visible: false));
            dgvCatProductos.Columns.Add(GridColumnas.Texto("NombreEquipo", "NombreEquipo", "NombreEquipo", visible: false));
            dgvCatProductos.DataSource = oCProductosCategoriasBindingSource;
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void Cargar()
        {
            _dt = _repoOC.ListarCategoriasProductosOC();
            oCProductosCategoriasBindingSource.DataSource = _dt;
            lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
        }

        private void ManCatProductos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCatProductos.Rows.Count > 0 && dgvCatProductos.FirstDisplayedCell != null)
                {
                    int fila = dgvCatProductos.CurrentRow.Index;
                    dgvCatProductos.EndEdit();
                    _repoOC.GuardarCategoriasProductosOC(_dt);
                    Cargar();
                    if (fila < dgvCatProductos.RowCount)
                        dgvCatProductos.CurrentCell = dgvCatProductos.Rows[fila].Cells[1];
                    dgvCatProductos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvCatProductos, false);
                    lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCatProductos.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvCatProductos, true);
            dgvCatProductos.FirstDisplayedScrollingRowIndex = dgvCatProductos.RowCount - 1;
            var cantidadRow = dgvCatProductos.RowCount - 1;
            dgvCatProductos.CurrentCell = dgvCatProductos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvCatProductos.Rows.Count > 0 && dgvCatProductos.FirstDisplayedCell != null)
            {
                saveRow = dgvCatProductos.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvCatProductos, true);
                dgvCatProductos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCatProductos.Rows.Count)
                dgvCatProductos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCatProductos.Rows.Count > 0 && dgvCatProductos.FirstDisplayedCell != null)
            {
                int fila = dgvCatProductos.CurrentRow.Index;
                Cargar();
                if (fila < dgvCatProductos.RowCount)
                    dgvCatProductos.CurrentCell = dgvCatProductos.Rows[fila].Cells[1];
                dgvCatProductos.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvCatProductos, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCatProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Categorias Productos - #Registros: " + dgvCatProductos.RowCount;
        }

        private void dgvCatProductos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (dgvCatProductos.RowCount > 0)
                {
                    dgvCatProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvCatProductos.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCatProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCatProductos.RowCount > 0)
                {
                    dgvCatProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvCatProductos.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
