using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using Formularios_Base;

namespace ADIGGM.OC
{
    public partial class ManProductos : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManProductos()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvProductos);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) — gotcha §11. IdCatProducto es columna
        /// oculta estampada desde el combo de categorías; Usuario/NombreEquipo se setean por código.
        /// Edición con GridColumnas.Edicion (§14.10).</summary>
        private void ConfigurarColumnas()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Clear();
            dgvProductos.Columns.Add(GridColumnas.Texto("IdProducto", "IdProducto", "IdProducto", visible: false));
            dgvProductos.Columns.Add(GridColumnas.Texto("IdCatProducto", "IdCatProducto", "IdCatProducto", visible: false));
            dgvProductos.Columns.Add(GridColumnas.Texto("CodProducto", "CodProducto", "Codigo"));
            dgvProductos.Columns.Add(GridColumnas.Texto("Producto", "Producto", "Producto"));
            dgvProductos.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvProductos.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", visible: false));
            dgvProductos.Columns.Add(GridColumnas.Texto("NombreEquipo", "NombreEquipo", "NombreEquipo", visible: false));
            dgvProductos.DataSource = oCProductosBindingSource;
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        /// <summary>Llena el combo de categorías (solo activas). Al fijar el DataSource se dispara
        /// cboCategoria_SelectedIndexChanged → CargarGrid().</summary>
        private void CargarCategorias()
        {
            oCProductosCategoriasBindingSource.DataSource = _repoOC.ListarCategoriasProductosOCActivas();
        }

        /// <summary>Llena el grid con los productos de la categoría seleccionada filtrados por texto.</summary>
        private void CargarGrid()
        {
            if (cboCategoria.SelectedValue == null) return;
            _dt = _repoOC.ListarProductos(int.Parse(cboCategoria.SelectedValue.ToString()), txtProducto.Text);
            oCProductosBindingSource.DataSource = _dt;
        }

        private void ManProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarGrid();
            lblFooter.Text = "Productos - #Registros: " + dgvProductos.RowCount;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
                {
                    dgvProductos.CurrentRow.Cells["IdCatProducto"].Value = cboCategoria.SelectedValue;
                    int fila = dgvProductos.CurrentRow.Index;
                    dgvProductos.EndEdit();
                    _repoOC.GuardarProductos(_dt);
                    CargarGrid();
                    if (fila < dgvProductos.RowCount)
                        dgvProductos.CurrentCell = dgvProductos.Rows[fila].Cells[2];
                    dgvProductos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvProductos, false);
                    lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvProductos.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvProductos, true);
            dgvProductos.FirstDisplayedScrollingRowIndex = dgvProductos.RowCount - 1;
            var cantidadRow = dgvProductos.RowCount - 1;
            dgvProductos.CurrentCell = dgvProductos.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            dgvProductos.CurrentRow.Cells["IdCatProducto"].Value = cboCategoria.SelectedValue;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                saveRow = dgvProductos.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvProductos, true);
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
            if (dgvProductos.Rows.Count > 0 && dgvProductos.FirstDisplayedCell != null)
            {
                int fila = dgvProductos.CurrentRow.Index;
                CargarGrid();
                if (fila < dgvProductos.RowCount)
                    dgvProductos.CurrentCell = dgvProductos.Rows[fila].Cells[2];
                dgvProductos.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvProductos, false);
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

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Productos - #Registros: " + (dgvProductos.RowCount);
        }

        private void dgvProductos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0)
                {
                    dgvProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvProductos.CurrentRow.Cells["NombreEquipo"].Value = Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboCategoria.SelectedIndex.ToString()) != -1)
            {
                CargarGrid();
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0)
                {
                    dgvProductos.CurrentRow.Cells["IdCatProducto"].Value = cboCategoria.SelectedValue;
                    dgvProductos.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                    dgvProductos.CurrentRow.Cells["NombreEquipo"].Value = Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarGrid();
            }
        }
    }
}
