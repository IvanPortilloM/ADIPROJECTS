using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManTipoDocumento : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManTipoDocumento()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. Mantenimiento editable (toggle con GridColumnas.Edicion §14.10).</summary>
        private void ConfigurarColumnas()
        {
            dgvTipoDocumentos.AutoGenerateColumns = false;
            dgvTipoDocumentos.Columns.Clear();
            dgvTipoDocumentos.Columns.Add(GridColumnas.Texto("idCxpDocumentoDataGridViewTextBoxColumn", "IdCxpDocumento", "IdCxpDocumento", visible: false));
            dgvTipoDocumentos.Columns.Add(GridColumnas.Texto("codigoDataGridViewTextBoxColumn", "Codigo", "Codigo"));
            dgvTipoDocumentos.Columns.Add(GridColumnas.Texto("tipoDocumentoDataGridViewTextBoxColumn", "TipoDocumento", "TipoDocumento"));
            dgvTipoDocumentos.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvTipoDocumentos.DataSource = cPTipoDocumentosBindingSource;
        }

        private void Cargar()
        {
            _dt = _repoOC.ListarTiposDocumento();
            cPTipoDocumentosBindingSource.DataSource = _dt;
        }

        private void ManTipoDocumento_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTipoDocumentos.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvTipoDocumentos, true);
            dgvTipoDocumentos.FirstDisplayedScrollingRowIndex = dgvTipoDocumentos.RowCount - 1;
            var cantidadRow = dgvTipoDocumentos.RowCount - 1;
            dgvTipoDocumentos.CurrentCell = dgvTipoDocumentos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTipoDocumentos.Rows.Count > 0 && dgvTipoDocumentos.FirstDisplayedCell != null)
                {
                    int fila = dgvTipoDocumentos.CurrentRow.Index;
                    dgvTipoDocumentos.EndEdit();
                    _repoOC.GuardarTiposDocumento(_dt);
                    Cargar();
                    if (fila < dgvTipoDocumentos.RowCount)
                        dgvTipoDocumentos.CurrentCell = dgvTipoDocumentos.Rows[fila].Cells[1];
                    dgvTipoDocumentos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvTipoDocumentos, false);
                    lblFooter.Text = "Tipos Documentos - #Registros: " + (dgvTipoDocumentos.RowCount);
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

            if (dgvTipoDocumentos.Rows.Count > 0 && dgvTipoDocumentos.FirstDisplayedCell != null)
            {
                saveRow = dgvTipoDocumentos.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvTipoDocumentos, true);
                dgvTipoDocumentos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvTipoDocumentos.Rows.Count)
                dgvTipoDocumentos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvTipoDocumentos.Rows.Count > 0 && dgvTipoDocumentos.FirstDisplayedCell != null)
            {
                int fila = dgvTipoDocumentos.CurrentRow.Index;
                Cargar();
                if (fila < dgvTipoDocumentos.RowCount)
                    dgvTipoDocumentos.CurrentCell = dgvTipoDocumentos.Rows[fila].Cells[1];
                dgvTipoDocumentos.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvTipoDocumentos, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Tipos Documentos - #Registros: " + (dgvTipoDocumentos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTipoDocumentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Tipo Documentos - #Registros: " + (dgvTipoDocumentos.RowCount);
        }
    }
}
