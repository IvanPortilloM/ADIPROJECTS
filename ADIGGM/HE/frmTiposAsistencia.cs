using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using System;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmTiposAsistencia : FrmPrincipal
    {
        private readonly RepositorioTiposAsistencia _repo = new RepositorioTiposAsistencia();
        private int _idEnEdicion = 0;

        public frmTiposAsistencia()
        {
            InitializeComponent();
        }

        private void frmTiposAsistencia_Load(object sender, EventArgs e)
        {
            CargarTipos();
            dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvTipos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CargarTipos()
        {
            try
            {
                // BindingSource: genera las columnas a partir del tipo aunque la tabla esté vacía.
                dgvTipos.DataSource = new BindingSource { DataSource = _repo.Listar() };
                if (dgvTipos.Columns["TipoAsistenciaID"] != null)
                    dgvTipos.Columns["TipoAsistenciaID"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Código y Descripción.");
                return;
            }

            try
            {
                TipoAsistencia tipo = new TipoAsistencia
                {
                    Codigo = txtCodigo.Text.Trim().ToUpper(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    RequiereTiempos = chkRequiereTiempos.Checked
                };

                if (_idEnEdicion == 0)
                {
                    // MODO INSERTAR (Nuevo): validar duplicado primero
                    if (_repo.ExisteCodigo(txtCodigo.Text.Trim()))
                    {
                        MessageBox.Show("El código ya existe.");
                        return;
                    }
                    _repo.Insertar(tipo);
                    MessageBox.Show("Agregado correctamente.");
                }
                else
                {
                    // MODO ACTUALIZAR (Editar)
                    tipo.TipoAsistenciaID = _idEnEdicion;
                    _repo.Actualizar(tipo);
                    MessageBox.Show("Actualizado correctamente.");
                }

                LimpiarFormulario();
                CargarTipos();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            chkRequiereTiempos.Checked = false;
            _idEnEdicion = 0;
            btnGuardar.Text = "Guardar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipos.SelectedRows.Count == 0) return;

            if (MessageBox.Show("¿Eliminar este tipo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvTipos.SelectedRows[0].Cells["TipoAsistenciaID"].Value);
                try
                {
                    _repo.Eliminar(id);
                    CargarTipos();
                }
                catch (Exception ex) { MessageBox.Show("Error al eliminar (puede estar en uso): " + ex.Message); }
            }
        }

        private void dgvTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. Recuperamos el ID oculto
                _idEnEdicion = Convert.ToInt32(dgvTipos.Rows[e.RowIndex].Cells["TipoAsistenciaID"].Value);

                // 2. Pasamos los datos a los controles para que el usuario los modifique
                txtCodigo.Text = dgvTipos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = dgvTipos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                chkRequiereTiempos.Checked = Convert.ToBoolean(dgvTipos.Rows[e.RowIndex].Cells["RequiereTiempos"].Value);

                // 3. Feedback visual
                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
