using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using System;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmFeriados : FrmPrincipal
    {
        private readonly RepositorioFeriados _repo = new RepositorioFeriados();

        public frmFeriados()
        {
            InitializeComponent();
        }

        private void frmFeriados_Load(object sender, EventArgs e)
        {
            CargarFeriados();
            dgvFeriados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvFeriados.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CargarFeriados()
        {
            try
            {
                // BindingSource: genera las columnas a partir del tipo aunque la tabla esté vacía.
                dgvFeriados.DataSource = new BindingSource { DataSource = _repo.Listar() };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar feriados: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor ingrese una descripción.");
                return;
            }

            DateTime fecha = dtpFecha.Value.Date;
            string descripcion = txtDescripcion.Text.Trim();

            try
            {
                // 1. Verificar si ya existe
                if (_repo.ExisteFecha(fecha))
                {
                    MessageBox.Show("Ya existe un feriado registrado para esta fecha.");
                    return;
                }

                // 2. Insertar
                _repo.Insertar(new DiaFeriado { Fecha = fecha, Descripcion = descripcion });
                MessageBox.Show("Feriado agregado correctamente.");

                // Limpiar y recargar
                txtDescripcion.Clear();
                CargarFeriados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            // Obtenemos la fecha de la fila seleccionada
            DateTime fechaEliminar = Convert.ToDateTime(dgvFeriados.SelectedRows[0].Cells["Fecha"].Value);
            string descripcion = dgvFeriados.SelectedRows[0].Cells["Descripcion"].Value.ToString();

            if (MessageBox.Show($"¿Seguro que desea eliminar el feriado: {descripcion} ({fechaEliminar.ToShortDateString()})?",
                                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _repo.Eliminar(fechaEliminar);
                    CargarFeriados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
