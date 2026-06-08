using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using System;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmPoliticas : FrmPrincipal
    {
        private readonly RepositorioPoliticas _repo = new RepositorioPoliticas();
        private int _idEnEdicion = 0;

        public frmPoliticas()
        {
            InitializeComponent();
        }

        private void frmPoliticas_Load(object sender, EventArgs e)
        {
            CargarPoliticas();
            dgvPoliticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvPoliticas.Columns["NombrePolitica"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CargarPoliticas()
        {
            try
            {
                // BindingSource: genera las columnas a partir del tipo aunque la tabla esté vacía.
                dgvPoliticas.DataSource = new BindingSource { DataSource = _repo.Listar() };
                if (dgvPoliticas.Columns["PoliticaID"] != null)
                    dgvPoliticas.Columns["PoliticaID"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para la política.");
                return;
            }

            try
            {
                PoliticaPago politica = new PoliticaPago
                {
                    NombrePolitica = txtNombre.Text.Trim(),
                    PagaExtrasDiarias = chkPagaExtrasDiarias.Checked,
                    PagaDomingos = chkPagaDomingos.Checked,
                    PagaFeriados = chkPagaFeriados.Checked,
                    AplicaJornadaMixta = chkAplicaMixta.Checked
                };

                if (_idEnEdicion == 0)
                {
                    _repo.Insertar(politica);
                }
                else
                {
                    politica.PoliticaID = _idEnEdicion;
                    _repo.Actualizar(politica);
                }

                MessageBox.Show("Guardado correctamente.");
                LimpiarFormulario();
                CargarPoliticas();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            chkPagaExtrasDiarias.Checked = false;
            chkPagaDomingos.Checked = false;
            chkPagaFeriados.Checked = false;
            chkAplicaMixta.Checked = false;
            _idEnEdicion = 0;
            btnGuardar.Text = "Guardar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPoliticas.SelectedRows.Count == 0) return;

            if (MessageBox.Show("¿Eliminar esta política? \n\nCUIDADO: Asegúrese de que ningún motorista la esté usando antes de borrarla.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPoliticas.SelectedRows[0].Cells["PoliticaID"].Value);
                try
                {
                    _repo.Eliminar(id);
                    CargarPoliticas();
                }
                catch (Exception) { MessageBox.Show("No se puede eliminar porque hay motoristas asignados a esta política.", "Error de Integridad"); }
            }
        }

        private void dgvPoliticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _idEnEdicion = Convert.ToInt32(dgvPoliticas.Rows[e.RowIndex].Cells["PoliticaID"].Value);

                txtNombre.Text = dgvPoliticas.Rows[e.RowIndex].Cells["NombrePolitica"].Value.ToString();

                // Checkboxes
                chkPagaExtrasDiarias.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["PagaExtrasDiarias"].Value);
                chkPagaDomingos.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["PagaDomingos"].Value);
                chkPagaFeriados.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["PagaFeriados"].Value);
                chkAplicaMixta.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["AplicaJornadaMixta"].Value);

                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
