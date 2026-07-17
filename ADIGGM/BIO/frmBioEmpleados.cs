using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.BIO
{
    /// <summary>Catálogo de empleados del reloj biométrico (BIO_Empleados). El IdBiometrico es el
    /// NÚMERO DE USUARIO con el que se enrola a la persona en el reloj — se digita en el alta
    /// (no es identity) y debe coincidir con el enrolamiento.</summary>
    public partial class frmBioEmpleados : FrmMantenimiento
    {
        private readonly RepositorioBiometrico _repo = new RepositorioBiometrico();
        private DataTable _dt;

        public frmBioEmpleados()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas EN CÓDIGO (gotcha §11). IdBiometrico es editable (se digita en el alta;
        /// como en FAC_RTN, renombrarlo en una fila existente no persiste).</summary>
        private void ConfigurarColumnas()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Columns.Clear();
            dgvEmpleados.Columns.Add(GridColumnas.Texto("IdBiometrico", "IdBiometrico", "No. en reloj", width: 90, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader));
            dgvEmpleados.Columns.Add(GridColumnas.Texto("Nombre", "Nombre", "Nombre"));
            dgvEmpleados.Columns.Add(GridColumnas.Check("Activo", "Activo", "Activo", width: 55, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader));
            dgvEmpleados.DataSource = bioEmpleadosBindingSource;
        }

        private void Cargar()
        {
            _dt = _repo.ListarEmpleados();
            bioEmpleadosBindingSource.DataSource = _dt;
        }

        private void frmBioEmpleados_Load(object sender, EventArgs e)
        {
            Cargar();
            lblFooter.Text = "Empleados Biométrico - #Registros: " + dgvEmpleados.RowCount;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvEmpleados.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvEmpleados, true);
            dgvEmpleados.FirstDisplayedScrollingRowIndex = dgvEmpleados.RowCount - 1;
            var cantidadRow = dgvEmpleados.RowCount - 1;
            dgvEmpleados.CurrentCell = dgvEmpleados.Rows[cantidadRow].Cells[0];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
                {
                    int fila = dgvEmpleados.CurrentRow.Index;
                    dgvEmpleados.EndEdit();
                    _repo.GuardarEmpleados(_dt);
                    Cargar();
                    if (fila < dgvEmpleados.RowCount)
                        dgvEmpleados.CurrentCell = dgvEmpleados.Rows[fila].Cells[1];
                    dgvEmpleados.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvEmpleados, false);
                    lblFooter.Text = "Empleados Biométrico - #Registros: " + (dgvEmpleados.RowCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
            {
                saveRow = dgvEmpleados.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvEmpleados, true);
                dgvEmpleados.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvEmpleados.Rows.Count)
                dgvEmpleados.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
            {
                int fila = dgvEmpleados.CurrentRow.Index;
                Cargar();
                if (fila < dgvEmpleados.RowCount)
                    dgvEmpleados.CurrentCell = dgvEmpleados.Rows[fila].Cells[1];
                dgvEmpleados.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvEmpleados, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Empleados Biométrico - #Registros: " + (dgvEmpleados.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpleados_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "Empleados Biométrico - #Registros: " + (dgvEmpleados.RowCount);
        }
    }
}
