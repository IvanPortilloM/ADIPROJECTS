using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using ADIGGM.CapaDatos;
using System.Drawing;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmCopiarAsistencia : FrmPrincipal
    {
        public List<int> IdsMotoristasSeleccionados { get; private set; } = new List<int>();
        public List<DateTime> FechasSeleccionadas { get; private set; } = new List<DateTime>();

        private int _idMotoristaOrigen;
        private DateTime _fechaActual;     // Fecha que estamos editando
        private DateTime _fechaMinima;     // Inicio del periodo global
        private DateTime _fechaMaxima;     // Fin del periodo global

        private readonly RepositorioMotoristas _repoMotoristas = new RepositorioMotoristas();

        // Constructor actualizado
        public frmCopiarAsistencia(int idMotoristaOrigen, DateTime fechaActual, DateTime fechaMin, DateTime fechaMax)
        {
            InitializeComponent();
            _idMotoristaOrigen = idMotoristaOrigen;
            _fechaActual = fechaActual;
            _fechaMinima = fechaMin;
            _fechaMaxima = fechaMax;
        }

        private void frmCopiarAsistencia_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            ConfigurarCalendario();
            CargarMotoristas();

            // 1. Agregar AUTOMÁTICAMENTE la fecha actual a la lista
            lstFechas.Items.Add(_fechaActual.ToShortDateString());
        }

        private void ConfigurarCalendario()
        {
            calFechas.MaxSelectionCount = 31;

            // 2. Restricciones de fechas (Límites del periodo)
            calFechas.MinDate = _fechaMinima;
            calFechas.MaxDate = _fechaMaxima;

            // Seleccionar visualmente la fecha origen
            calFechas.SelectionStart = _fechaActual;
            calFechas.SelectionEnd = _fechaActual;
        }

        private void ConfigurarGrid()
        {
            dgvMotoristas.AutoGenerateColumns = false;
            dgvMotoristas.AllowUserToAddRows = false;

            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.HeaderText = "Sel";
            colCheck.Name = "colCheck";
            colCheck.Width = 40;
            dgvMotoristas.Columns.Add(colCheck);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Motorista";
            colNombre.DataPropertyName = "Motorista";
            colNombre.Name = "colMotorista";
            colNombre.Width = 200;
            colNombre.ReadOnly = true;
            dgvMotoristas.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "IdMotorista";
            colId.Name = "colId";
            colId.Visible = false;
            dgvMotoristas.Columns.Add(colId);
            dgvMotoristas.Columns["colMotorista"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CargarMotoristas()
        {
            try
            {
                // 3. Traemos TODOS los activos (incluyendo al origen)
                dgvMotoristas.DataSource = _repoMotoristas.ListarEmpleadosActivos();

                // 4. Marcar y "Bloquear" al Motorista Origen
                foreach (DataGridViewRow row in dgvMotoristas.Rows)
                {
                    int id = Convert.ToInt32(row.Cells["colId"].Value);
                    if (id == _idMotoristaOrigen)
                    {
                        row.Cells["colCheck"].Value = true; // Marcado por defecto
                        row.DefaultCellStyle.BackColor = Color.LightGray; // Visualmente deshabilitado
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        row.ReadOnly = true; // Bloquea edición normal
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Evento para evitar que desmarquen al motorista origen manualmente
        private void dgvMotoristas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMotoristas.Columns[e.ColumnIndex].Name == "colCheck")
            {
                int id = Convert.ToInt32(dgvMotoristas.Rows[e.RowIndex].Cells["colId"].Value);
                if (id == _idMotoristaOrigen)
                {
                    // Si intentan cambiar el check del origen, forzamos que siga siendo TRUE
                    dgvMotoristas.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    dgvMotoristas.Rows[e.RowIndex].Cells["colCheck"].Value = true;
                }
            }
        }

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            DateTime inicio = calFechas.SelectionStart;
            DateTime fin = calFechas.SelectionEnd;

            for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
            {
                string fechaStr = dia.ToShortDateString();
                if (!lstFechas.Items.Contains(fechaStr))
                {
                    lstFechas.Items.Add(fechaStr);
                }
            }
        }

        private void btnLimpiarFechas_Click(object sender, EventArgs e)
        {
            lstFechas.Items.Clear();
            // Siempre volvemos a agregar la fecha actual obligatoria
            lstFechas.Items.Add(_fechaActual.ToShortDateString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IdsMotoristasSeleccionados.Clear();
            foreach (DataGridViewRow row in dgvMotoristas.Rows)
            {
                // Si el valor es nulo o false, se ignora. Si es true, se agrega.
                bool isChecked = row.Cells["colCheck"].Value != null && (bool)row.Cells["colCheck"].Value;
                if (isChecked)
                {
                    IdsMotoristasSeleccionados.Add(Convert.ToInt32(row.Cells["colId"].Value));
                }
            }

            FechasSeleccionadas.Clear();
            foreach (var item in lstFechas.Items)
            {
                FechasSeleccionadas.Add(Convert.ToDateTime(item));
            }

            if (IdsMotoristasSeleccionados.Count == 0) { MessageBox.Show("Seleccione motoristas."); return; }
            if (FechasSeleccionadas.Count == 0) { MessageBox.Show("Seleccione fechas."); return; }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}