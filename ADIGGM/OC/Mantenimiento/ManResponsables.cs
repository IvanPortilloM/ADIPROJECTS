using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using Formularios_Base;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManResponsables : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManResponsables()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvResponsables);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) — gotcha §11. "Firma" es columna de
        /// imagen (la edita el doble-clic). ORDEN preservado: el .cs usa Cells[2]=UsuarioFirma y
        /// Cells[3]=Firma. "Usuario"/"NombreEquipo" se setean por código. Edición con GridColumnas.Edicion.</summary>
        private void ConfigurarColumnas()
        {
            dgvResponsables.AutoGenerateColumns = false;
            dgvResponsables.Columns.Clear();
            dgvResponsables.Columns.Add(GridColumnas.Texto("idResponsableDataGridViewTextBoxColumn", "IdResponsable", "IdResponsable", visible: false));
            dgvResponsables.Columns.Add(GridColumnas.Texto("nombreDataGridViewTextBoxColumn", "Nombre", "Nombre"));
            dgvResponsables.Columns.Add(GridColumnas.Texto("usuarioFirmaDataGridViewTextBoxColumn", "UsuarioFirma", "Usuario"));
            dgvResponsables.Columns.Add(GridColumnas.Imagen("Firma", "Firma", "Firma", DataGridViewImageCellLayout.Stretch));
            dgvResponsables.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo"));
            dgvResponsables.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", visible: false));
            dgvResponsables.Columns.Add(GridColumnas.Texto("NombreEquipo", "NombreEquipo", "NombreEquipo", visible: false));
            dgvResponsables.DataSource = oCResponsablesBindingSource;
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
            _dt = _repoOC.ListarResponsables();
            oCResponsablesBindingSource.DataSource = _dt;
            lblFooter.Text = "Responsables - #Registros: " + dgvResponsables.RowCount;
        }

        private void ManResponsables_Load(object sender, EventArgs e)
        {
            Cargar();
            dgvResponsables.RowTemplate.Height = 40;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResponsables.RowCount > 0)
            {
                dgvResponsables.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                dgvResponsables.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvResponsables.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvResponsables, true);
            dgvResponsables.FirstDisplayedScrollingRowIndex = dgvResponsables.RowCount - 1;
            var cantidadRow = dgvResponsables.RowCount - 1;
            dgvResponsables.CurrentCell = dgvResponsables.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResponsables.Rows.Count > 0 && dgvResponsables.FirstDisplayedCell != null)
                {
                    int fila = dgvResponsables.CurrentRow.Index;
                    dgvResponsables.EndEdit();
                    _repoOC.GuardarResponsables(_dt);
                    Cargar();
                    if (fila < dgvResponsables.RowCount)
                        dgvResponsables.CurrentCell = dgvResponsables.Rows[fila].Cells[2];
                    dgvResponsables.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvResponsables, false);
                    lblFooter.Text = "Responsables - #Registros: " + (dgvResponsables.RowCount);
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

            if (dgvResponsables.Rows.Count > 0 && dgvResponsables.FirstDisplayedCell != null)
            {
                saveRow = dgvResponsables.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvResponsables, true);
                dgvResponsables.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvResponsables.Rows.Count)
                dgvResponsables.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvResponsables.Rows.Count > 0 && dgvResponsables.FirstDisplayedCell != null)
            {
                int fila = dgvResponsables.CurrentRow.Index;
                Cargar();
                if (fila < dgvResponsables.RowCount)
                    dgvResponsables.CurrentCell = dgvResponsables.Rows[fila].Cells[2];
                dgvResponsables.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvResponsables, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Responsables - #Registros: " + (dgvResponsables.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResponsables_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResponsables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResponsables.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                if (e.ColumnIndex == dgvResponsables.Columns["Firma"].Index && dgvResponsables.ReadOnly == false)
                {
                    Stream myStream = null;
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Image File(*.jpe; *.jpeg; *.png) | *.jpg;*.jpeg;*.png";
                    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            if ((myStream = openFileDialog.OpenFile()) != null)
                            {
                                string FileName = openFileDialog.FileName;
                                if (myStream.Length > 512000)
                                {
                                    MessageBox.Show("El tamaño de la imagen es demasiado grande");
                                }
                                else
                                {
                                    dgvResponsables.CurrentRow.Cells[3].Value = Image.FromFile(openFileDialog.FileName);
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}
