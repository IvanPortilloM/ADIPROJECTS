using ADIGGM.CapaDatos;
using System;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmHistorialSalarios : FrmPrincipal
    {
        private readonly RepositorioMotoristas _repoMotoristas = new RepositorioMotoristas();
        private readonly RepositorioHistorialSalarios _repo = new RepositorioHistorialSalarios();

        public frmHistorialSalarios()
        {
            InitializeComponent();
        }

        private void frmHistorialSalarios_Load(object sender, EventArgs e)
        {
            CargarMotoristas();
            dtpVigencia.Value = DateTime.Today;
        }

        private void CargarMotoristas()
        {
            try
            {
                cboMotoristas.DisplayMember = "Motorista";
                cboMotoristas.ValueMember = "IdMotorista";
                cboMotoristas.DataSource = _repoMotoristas.ListarEmpleadosActivos();
                cboMotoristas.SelectedIndex = -1; // Iniciar vacío
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar motoristas: " + ex.Message);
            }
        }

        private void cboMotoristas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMotoristas.SelectedValue != null && cboMotoristas.SelectedIndex != -1)
            {
                int idMotorista = (int)cboMotoristas.SelectedValue;
                CargarGridHistorial(idMotorista);
            }
        }

        private void CargarGridHistorial(int idMotorista)
        {
            try
            {
                dgvHistorial.DataSource = new BindingSource { DataSource = _repo.ListarPorMotorista(idMotorista) };

                // Preservar los encabezados que antes venían de los alias SQL
                if (dgvHistorial.Columns.Contains("SalarioQuincenal"))
                    dgvHistorial.Columns["SalarioQuincenal"].HeaderText = "Salario Quincenal";
                if (dgvHistorial.Columns.Contains("FechaVigencia"))
                    dgvHistorial.Columns["FechaVigencia"].HeaderText = "Fecha Vigencia";
                if (dgvHistorial.Columns.Contains("HistorialID"))
                    dgvHistorial.Columns["HistorialID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboMotoristas.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un motorista.");
                return;
            }

            decimal nuevoSalario = numSalario.Value;
            DateTime fecha = dtpVigencia.Value.Date;
            int idMotorista = (int)cboMotoristas.SelectedValue;

            try
            {
                // Insertar el nuevo registro de salario
                _repo.Insertar(idMotorista, nuevoSalario, fecha);

                MessageBox.Show("Cambio de salario registrado exitosamente.");
                CargarGridHistorial(idMotorista);
                numSalario.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
