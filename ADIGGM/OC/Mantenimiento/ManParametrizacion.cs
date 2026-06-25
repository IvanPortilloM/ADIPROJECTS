using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManParametrizacion : FrmMantenimiento
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dt;
        public ManParametrizacion()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) — gotcha §11. Mantenimiento de 1
        /// parámetro (ISV); edición con GridColumnas.Edicion (§14.10).</summary>
        private void ConfigurarColumnas()
        {
            dgvParametrizacion.AutoGenerateColumns = false;
            dgvParametrizacion.Columns.Clear();
            dgvParametrizacion.Columns.Add(GridColumnas.Texto("idParametrizacionDataGridViewTextBoxColumn", "IdParametrizacion", "IdParametrizacion", visible: false));
            dgvParametrizacion.Columns.Add(GridColumnas.Texto("iSVDataGridViewTextBoxColumn", "ISV", "ISV"));
            dgvParametrizacion.DataSource = oCParametrizacionBindingSource;
        }

        private void Cargar()
        {
            _dt = _repoOC.ListarParametrizacion();
            oCParametrizacionBindingSource.DataSource = _dt;
        }

        private void ManParametrizacion_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvParametrizacion.Rows.Count > 0 && dgvParametrizacion.FirstDisplayedCell != null)
                {
                    int fila = dgvParametrizacion.CurrentRow.Index;
                    dgvParametrizacion.EndEdit();
                    _repoOC.GuardarParametrizacion(_dt);
                    Cargar();
                    if (fila < dgvParametrizacion.RowCount)
                        dgvParametrizacion.CurrentCell = dgvParametrizacion.Rows[fila].Cells[1];
                    dgvParametrizacion.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvParametrizacion, false);
                    //lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvParametrizacion.RowCount);
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

            if (dgvParametrizacion.Rows.Count > 0 && dgvParametrizacion.FirstDisplayedCell != null)
            {
                saveRow = dgvParametrizacion.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvParametrizacion, true);
                dgvParametrizacion.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvParametrizacion.Rows.Count)
                dgvParametrizacion.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvParametrizacion.Rows.Count > 0 && dgvParametrizacion.FirstDisplayedCell != null)
            {
                int fila = dgvParametrizacion.CurrentRow.Index;
                Cargar();
                if (fila < dgvParametrizacion.RowCount)
                    dgvParametrizacion.CurrentCell = dgvParametrizacion.Rows[fila].Cells[1];
                dgvParametrizacion.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvParametrizacion, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                //lblFooter.Text = "Tipos Ordenes de Compra - #Registros: " + (dgvParametrizacion.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
