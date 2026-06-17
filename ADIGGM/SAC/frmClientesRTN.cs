using ADIGGM.CapaDatos;
using Formularios_Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.SAC
{
    public partial class frmClientesRTN : FrmMantenimiento
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        private DataTable _dt;
        int selectedIndex;

        public frmClientesRTN()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRTN);
        }

        /// <summary>Columnas de ambos grids EN CÓDIGO (no en el Designer) para que el diseñador de VS no las
        /// borre — gotcha §11. dgvRTN es editable (edición vía GridColumnas.Edicion); dataGridView1 es visor.</summary>
        private void ConfigurarColumnas()
        {
            dgvRTN.AutoGenerateColumns = false;
            dgvRTN.Columns.Clear();
            dgvRTN.Columns.Add(Clases.GridColumnas.Texto("empresaDataGridViewTextBoxColumn", "Empresa", "Empresa", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvRTN.Columns.Add(Clases.GridColumnas.Texto("rTNDataGridViewTextBoxColumn", "RTN", "RTN", width: 53, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvRTN.Columns.Add(Clases.GridColumnas.Texto("direccionDataGridViewTextBoxColumn", "Direccion", "Direccion"));
            dgvRTN.Columns.Add(Clases.GridColumnas.Texto("contactoDataGridViewTextBoxColumn", "Contacto", "Contacto"));
            dgvRTN.Columns.Add(Clases.GridColumnas.Texto("telefonoDataGridViewTextBoxColumn", "Telefono", "Telefono"));

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(Clases.GridColumnas.Texto("dataGridViewTextBoxColumn1", "Empresa", "Empresa", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dataGridView1.Columns.Add(Clases.GridColumnas.Texto("dataGridViewTextBoxColumn2", "RTN", "RTN", width: 53, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dataGridView1.Columns.Add(Clases.GridColumnas.Texto("dataGridViewTextBoxColumn3", "Direccion", "Direccion"));
            dataGridView1.Columns.Add(Clases.GridColumnas.Texto("dataGridViewTextBoxColumn4", "Contacto", "Contacto"));
            dataGridView1.Columns.Add(Clases.GridColumnas.Texto("dataGridViewTextBoxColumn5", "Telefono", "Telefono"));
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        /// <summary>Enlaza la tabla a los dos grids (comparten BindingSource); el DataSource se
        /// asigna aquí y NO en el Designer (gotcha del diseñador de VS).</summary>
        private void Cargar(DataTable dt)
        {
            _dt = dt;
            fACRTNBindingSource.DataMember = "";
            fACRTNBindingSource.DataSource = _dt;
            dgvRTN.DataSource = fACRTNBindingSource;
            dataGridView1.DataSource = fACRTNBindingSource;
        }

        private void frmClientesRTN_Load(object sender, EventArgs e)
        {
            Cargar(_repo.ListarRTN());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvRTN.AllowUserToAddRows = true;
            Clases.GridColumnas.Edicion(dgvRTN, true);
            dgvRTN.FirstDisplayedScrollingRowIndex = dgvRTN.RowCount - 1;
            var cantidadRow = dgvRTN.RowCount - 1;
            dgvRTN.CurrentCell = dgvRTN.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRTN.Rows.Count > 0 && dgvRTN.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvRTN.CurrentRow.Index;
                    dgvRTN.EndEdit();
                    fACRTNBindingSource.EndEdit();
                    _repo.GuardarRTN(_dt);
                    dgvRTN.CurrentCell = dgvRTN.Rows[selectedIndex].Cells[1];
                    dgvRTN.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvRTN.ReadOnly = true;
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

            if (dgvRTN.Rows.Count > 0 && dgvRTN.FirstDisplayedCell != null)
            {
                saveRow = dgvRTN.FirstDisplayedCell.RowIndex;
                Clases.GridColumnas.Edicion(dgvRTN, true);
                dgvRTN.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvRTN.Rows.Count)
                dgvRTN.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvRTN.Rows.Count > 0 && dgvRTN.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRTN.CurrentRow.Index;

                Cargar(_repo.ListarRTN());
                dgvRTN.CurrentCell = dgvRTN.Rows[selectedIndex].Cells[1];
                dgvRTN.AllowUserToAddRows = false;

                dgvRTN.ReadOnly = true;
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

        private void dgvRTN_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR CLIENTES - N° DE REGISTROS: " + dgvRTN.RowCount;
        }

        private void dgvRTN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRTN.Rows.Count > 0 && dgvRTN.SelectedRows.Count >= 1)
                selectedIndex = dgvRTN.SelectedRows[0].Index;
        }

        private void txtBuscarRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Cargar(_repo.BuscarRTN(txtBuscarRTN.Text));
                e.Handled = true;
            }
        }

        private void tbRTN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbRTN.SelectedTab.Text == "Ingresar RTN")
            {
                Cargar(_repo.ListarRTN());
                HabilitarBtn();
            }
            else
            {
                Cargar(_repo.BuscarRTN(txtBuscarRTN.Text));
                btnCancelar.PerformClick();
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar(_repo.BuscarRTN(txtBuscarRTN.Text));
        }
    }
}
