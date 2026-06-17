using System;
using System.Data;
using Formularios_Base;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmAsigTpFacTpVeh : FrmMantenimiento
    {
        private readonly RepositorioTransporte _repo = new RepositorioTransporte();
        private DataSet _ds;
        int selectedIndex;
        public FrmAsigTpFacTpVeh()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvAsigTipoFac);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Grid editable de mantenimiento: las columnas arrancan ReadOnly y la edición se
        /// habilita por cascada al poner dgv.ReadOnly=false (btnNuevo/btnEditar). La columna combo recibe
        /// su DataSource en el Load tras poblar el BindingSource.</summary>
        private void ConfigurarColumnas()
        {
            dgvAsigTipoFac.AutoGenerateColumns = false;
            dgvAsigTipoFac.Columns.Clear();
            dgvAsigTipoFac.Columns.Add(GridColumnas.Texto("idAsigFacTipoVehDataGridViewTextBoxColumn", "IdAsigFacTipoVeh", "IdAsigFacTipoVeh", visible: false));
            dgvAsigTipoFac.Columns.Add(GridColumnas.Texto("idTipoFacturaDataGridViewTextBoxColumn", "IdTipoFactura", "IdTipoFactura", visible: false));
            dgvAsigTipoFac.Columns.Add(GridColumnas.Combo("idTipoVehiculo", "IdTipoVehiculo", "Tipo de Vehiculo", "TipoVehiculo", "IdTipoVehiculo", autoSize: DataGridViewAutoSizeColumnMode.Fill));
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        /// <summary>Carga TipoFactura(padre)+AsigFacTipoVeh(hijo) con la relación FK (sustituye al DataSet
        /// tipado): el combo selecciona el padre y el grid muestra sus asignaciones; el combo-columna de
        /// tipo de vehículo se llena aparte.</summary>
        private void CargarDatos()
        {
            object idTipoFacSeleccionado = cboTipoFac.SelectedValue;

            // Combo-columna de tipo de vehículo (mismo BD TransporteAdiggm)
            // Combo-columna por nombre con null-check: si el diseñador de VS borrara la columna
            // (gotcha §11), el form degrada en vez de tronar con NullReferenceException al cargar.
            tRTipoVehiculosBindingSource.DataMember = "";
            tRTipoVehiculosBindingSource.DataSource = _repo.ListarTipoVehiculosActivos();
            if (dgvAsigTipoFac.Columns["idTipoVehiculo"] is System.Windows.Forms.DataGridViewComboBoxColumn colVeh)
                colVeh.DataSource = tRTipoVehiculosBindingSource;

            _ds = new DataSet();
            DataTable tipoFacturas = _repo.ListarTipoFacturas();
            tipoFacturas.TableName = "TR_TipoFacturas";
            DataTable asig = _repo.ListarAsigFacTipoVeh();
            asig.TableName = "TR_AsigFacTipoVeh";
            _ds.Tables.Add(tipoFacturas);
            _ds.Tables.Add(asig);
            _ds.Relations.Add("FK_TR_AsigFacTipoVeh_TR_TipoFacturas",
                tipoFacturas.Columns["IdTipoFactura"], asig.Columns["IdTipoFactura"], false);

            tRTipoFacturasBindingSource.DataMember = "TR_TipoFacturas";
            tRTipoFacturasBindingSource.DataSource = _ds;
            fKTRAsigFacTipoVehTRTipoFacturasBindingSource.DataSource = tRTipoFacturasBindingSource;
            fKTRAsigFacTipoVehTRTipoFacturasBindingSource.DataMember = "FK_TR_AsigFacTipoVeh_TR_TipoFacturas";
            // El DataSource se asigna aquí y NO en el Designer (el diseñador de VS borra las columnas).
            dgvAsigTipoFac.DataSource = fKTRAsigFacTipoVehTRTipoFacturasBindingSource;

            if (idTipoFacSeleccionado != null)
                cboTipoFac.SelectedValue = idTipoFacSeleccionado;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvAsigTipoFac.AllowUserToAddRows = true;
            Clases.GridColumnas.Edicion(dgvAsigTipoFac, true);
            dgvAsigTipoFac.FirstDisplayedScrollingRowIndex = dgvAsigTipoFac.RowCount - 1;
            var cantidadRow = dgvAsigTipoFac.RowCount - 1;
            dgvAsigTipoFac.CurrentCell = dgvAsigTipoFac.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAsigTipoFac.Rows.Count > 0 && dgvAsigTipoFac.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvAsigTipoFac.CurrentRow.Index;
                    dgvAsigTipoFac.EndEdit();
                    fKTRAsigFacTipoVehTRTipoFacturasBindingSource.EndEdit();
                    _repo.GuardarAsigFacTipoVeh(_ds.Tables["TR_AsigFacTipoVeh"]);
                    CargarDatos();
                    if (selectedIndex >= 0 && selectedIndex < dgvAsigTipoFac.Rows.Count)
                        dgvAsigTipoFac.CurrentCell = dgvAsigTipoFac.Rows[selectedIndex].Cells[2];
                    dgvAsigTipoFac.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvAsigTipoFac.ReadOnly = true;
                    lblFooter.Text = "VEHÍCULOS - CANTIDAD DE REGISTROS: " + dgvAsigTipoFac.RowCount;
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

            if (dgvAsigTipoFac.Rows.Count > 0 && dgvAsigTipoFac.FirstDisplayedCell != null)
            {
                saveRow = dgvAsigTipoFac.FirstDisplayedCell.RowIndex;
                Clases.GridColumnas.Edicion(dgvAsigTipoFac, true);
                dgvAsigTipoFac.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvAsigTipoFac.Rows.Count)
                dgvAsigTipoFac.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvAsigTipoFac.Rows.Count > 0 && dgvAsigTipoFac.FirstDisplayedCell != null)
            {
                selectedIndex = dgvAsigTipoFac.CurrentRow.Index;

                CargarDatos();
                if (selectedIndex >= 0 && selectedIndex < dgvAsigTipoFac.Rows.Count)
                    dgvAsigTipoFac.CurrentCell = dgvAsigTipoFac.Rows[selectedIndex].Cells[2];
                dgvAsigTipoFac.AllowUserToAddRows = false;

                dgvAsigTipoFac.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAsigTipoFac_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvAsigTipoFac_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "TIPO DE VEH ASIG. A ESTE TIPO DE FACTURA: " + dgvAsigTipoFac.RowCount;
        }

        private void FrmAsigTpFacTpVeh_Load(object sender, EventArgs e)
        {
            CargarDatos();
            lblFooter.Text = "TIPOS DE VEH ASIGNADOS AL TIPO DE FACTURA - CANTIDAD DE REGISTROS: " + dgvAsigTipoFac.RowCount;
        }
    }
}
