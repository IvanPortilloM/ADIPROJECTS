using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManTipoOC : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManTipoOC()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvTiposOC);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. Mantenimiento editable (toggle con GridColumnas.Edicion §14.10).
        /// "Usuario"/"NombreEquipo" se setean por código (Cells[...]) → Names exactos.</summary>
        private void ConfigurarColumnas()
        {
            dgvTiposOC.AutoGenerateColumns = false;
            dgvTiposOC.Columns.Clear();
            dgvTiposOC.Columns.Add(GridColumnas.Texto("idTipoOCDataGridViewTextBoxColumn", "IdTipoOC", "IdTipoOC", visible: false));
            dgvTiposOC.Columns.Add(GridColumnas.Texto("codigoDataGridViewTextBoxColumn", "Codigo", "Codigo"));
            dgvTiposOC.Columns.Add(GridColumnas.Texto("tipoOCDataGridViewTextBoxColumn", "TipoOC", "Tipo"));
            dgvTiposOC.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvTiposOC.Columns.Add(GridColumnas.Check("combustibleDataGridViewCheckBoxColumn", "Combustible", "Combustible"));
            dgvTiposOC.Columns.Add(GridColumnas.Check("materialesDataGridViewCheckBoxColumn", "Materiales", "Materiales"));
            dgvTiposOC.Columns.Add(GridColumnas.Check("serviciosDataGridViewCheckBoxColumn", "Servicios", "Servicios"));
            dgvTiposOC.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", visible: false));
            dgvTiposOC.Columns.Add(GridColumnas.Texto("NombreEquipo", "NombreEquipo", "NombreEquipo", visible: false));
            dgvTiposOC.DataSource = oCTipoOCBindingSource;
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
            _dt = _repoOC.ListarTiposOC();
            oCTipoOCBindingSource.DataSource = _dt;
            lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
        }

        private void ManTipoOC_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTiposOC.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvTiposOC, true);
            dgvTiposOC.FirstDisplayedScrollingRowIndex = dgvTiposOC.RowCount - 1;
            var cantidadRow = dgvTiposOC.RowCount - 1;
            dgvTiposOC.CurrentCell = dgvTiposOC.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTiposOC.Rows.Count > 0 && dgvTiposOC.FirstDisplayedCell != null)
                {
                    int fila = dgvTiposOC.CurrentRow.Index;
                    dgvTiposOC.EndEdit();
                    _repoOC.GuardarTiposOC(_dt);
                    Cargar();
                    if (fila < dgvTiposOC.RowCount)
                        dgvTiposOC.CurrentCell = dgvTiposOC.Rows[fila].Cells[1];
                    dgvTiposOC.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvTiposOC, false);
                    lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
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

            if (dgvTiposOC.Rows.Count > 0 && dgvTiposOC.FirstDisplayedCell != null)
            {
                saveRow = dgvTiposOC.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvTiposOC, true);
                dgvTiposOC.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTiposOC.Rows.Count)
                dgvTiposOC.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTiposOC.Rows.Count > 0 && dgvTiposOC.FirstDisplayedCell != null)
            {
                int fila = dgvTiposOC.CurrentRow.Index;
                Cargar();
                if (fila < dgvTiposOC.RowCount)
                    dgvTiposOC.CurrentCell = dgvTiposOC.Rows[fila].Cells[1];
                dgvTiposOC.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvTiposOC, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTiposOC_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvTiposOC.RowCount);
        }

        private void dgvTiposOC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTiposOC.RowCount > 0)
                {
                    dgvTiposOC.CurrentRow.Cells["Usuario"].Value = Clases.VarGlobales.Usuario;
                    dgvTiposOC.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTiposOC_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                if (dgvTiposOC.RowCount > 0)
                {
                    dgvTiposOC.CurrentRow.Cells["Usuario"].Value = Clases.VarGlobales.Usuario;
                    dgvTiposOC.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
