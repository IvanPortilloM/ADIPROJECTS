using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManDepartamentos : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManDepartamentos()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvDepartamentos);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) — gotcha §11. Mantenimiento editable
        /// (toggle con GridColumnas.Edicion §14.10). "Usuario"/"NombreEquipo" se setean por código.</summary>
        private void ConfigurarColumnas()
        {
            dgvDepartamentos.AutoGenerateColumns = false;
            dgvDepartamentos.Columns.Clear();
            dgvDepartamentos.Columns.Add(GridColumnas.Texto("idDepartamentoDataGridViewTextBoxColumn", "IdDepartamento", "IdDepartamento", visible: false));
            dgvDepartamentos.Columns.Add(GridColumnas.Texto("CodDepartamento", "CodDepartamento", "Codigo"));
            dgvDepartamentos.Columns.Add(GridColumnas.Texto("departamentoDataGridViewTextBoxColumn", "Departamento", "Departamento"));
            dgvDepartamentos.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvDepartamentos.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", visible: false));
            dgvDepartamentos.Columns.Add(GridColumnas.Texto("NombreEquipo", "NombreEquipo", "NombreEquipo", visible: false));
            dgvDepartamentos.DataSource = oCDepartamentosBindingSource;
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
            _dt = _repoOC.ListarDepartamentos();
            oCDepartamentosBindingSource.DataSource = _dt;
            lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
        }

        private void ManDepartamentos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvDepartamentos.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvDepartamentos, true);
            dgvDepartamentos.FirstDisplayedScrollingRowIndex = dgvDepartamentos.RowCount - 1;
            var cantidadRow = dgvDepartamentos.RowCount - 1;
            dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
                {
                    int fila = dgvDepartamentos.CurrentRow.Index;
                    dgvDepartamentos.EndEdit();
                    _repoOC.GuardarDepartamentos(_dt);
                    Cargar();
                    if (fila < dgvDepartamentos.RowCount)
                        dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[fila].Cells[1];
                    dgvDepartamentos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvDepartamentos, false);
                    lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
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

            if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
            {
                saveRow = dgvDepartamentos.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvDepartamentos, true);
                dgvDepartamentos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvDepartamentos.Rows.Count)
                dgvDepartamentos.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.Rows.Count > 0 && dgvDepartamentos.FirstDisplayedCell != null)
            {
                int fila = dgvDepartamentos.CurrentRow.Index;
                Cargar();
                if (fila < dgvDepartamentos.RowCount)
                    dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[fila].Cells[1];
                dgvDepartamentos.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvDepartamentos, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDepartamentos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Departamentos - #Registros: " + (dgvDepartamentos.RowCount);
        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDepartamentos.RowCount > 0)
                {
                    dgvDepartamentos.CurrentRow.Cells["Usuario"].Value = Clases.VarGlobales.Usuario;
                    dgvDepartamentos.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
