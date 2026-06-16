using System;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmCierresBuscar : ADIGGM.FrmPrincipal
    {
        private readonly RepositorioTransporte _repo = new RepositorioTransporte();
        public IContract contrato { get; set; }
        public FrmCierresBuscar()
        {
            InitializeComponent();
            ConfigurarColumnas();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCierres);
        }

        /// <summary>
        /// Define las columnas del grid EN CÓDIGO (no en el Designer). Así el diseñador de VS no puede
        /// borrarlas al abrir el form sin DataSet tipado (gotcha §11): no hay columnas en InitializeComponent
        /// que VS pueda "limpiar". El grid queda inmune al borrado del diseñador.
        /// </summary>
        private void ConfigurarColumnas()
        {
            dgvCierres.AutoGenerateColumns = false;
            dgvCierres.Columns.Clear();

            var moneda = new DataGridViewCellStyle { Format = "C2" };

            dgvCierres.Columns.Add(new DataGridViewComboBoxColumn
            {
                Name = "idCierre",
                DataPropertyName = "IdCierre",
                HeaderText = "Cierre",
                DisplayMember = "Semana",
                ValueMember = "IdCierre",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });
            dgvCierres.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaInicio", DataPropertyName = "FechaInicio", HeaderText = "F. Inicio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, Width = 72, ReadOnly = true
            });
            dgvCierres.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaFin", DataPropertyName = "FechaFin", HeaderText = "F. Fin",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, Width = 58, ReadOnly = true
            });
            dgvCierres.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idCliente", DataPropertyName = "IdCliente", HeaderText = "IdCliente",
                Visible = false, ReadOnly = true
            });
            dgvCierres.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "subTotalCierre", DataPropertyName = "SubTotalCierre", HeaderText = "SubTotal",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, Width = 80, ReadOnly = true,
                DefaultCellStyle = moneda
            });
            dgvCierres.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "iSVCierre", DataPropertyName = "ISVCierre", HeaderText = "ISV",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, Width = 49, ReadOnly = true,
                DefaultCellStyle = moneda
            });
            dgvCierres.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "totalCierre", DataPropertyName = "TotalCierre", HeaderText = "Total",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells, Width = 59, ReadOnly = true,
                DefaultCellStyle = moneda
            });
            dgvCierres.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "cerrado", DataPropertyName = "Cerrado", HeaderText = "Cerrado", Visible = false, ReadOnly = true
            });
            dgvCierres.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "anulado", DataPropertyName = "Anulado", HeaderText = "Anulado", Visible = false, ReadOnly = true
            });
        }

        private void FrmCierresBuscar_Load(object sender, EventArgs e)
        {
            // Combo-columna idCierre (Semana) del grid: el DataSource se asigna aquí, no en el Designer.
            // Se accede por nombre con null-check: si el diseñador de VS borrara la columna (gotcha §11),
            // el form degrada en vez de tronar con NullReferenceException al cargar.
            tRCierresBindingSource.DataMember = "";
            tRCierresBindingSource.DataSource = _repo.ListarCierres();
            if (dgvCierres.Columns["idCierre"] is System.Windows.Forms.DataGridViewComboBoxColumn colCierre)
                colCierre.DataSource = tRCierresBindingSource;
            // Combos selectores (disparan SelectedValueChanged -> LlenarDgv)
            tRTipoFacturasBindingSource.DataMember = "";
            tRTipoFacturasBindingSource.DataSource = _repo.ListarTipoFacturas();
            tRClientesBindingSource.DataMember = "";
            tRClientesBindingSource.DataSource = _repo.ListarClientesActivos();
        }
        public void LlenarDgv()
        {
            if(cboClientes.SelectedIndex != -1 && cboTipoFac.SelectedIndex != -1)
            {
                int IdCliente = Convert.ToInt32(cboClientes.SelectedValue),
                    IdTipoFac = Convert.ToInt32(cboTipoFac.SelectedValue);

                tRCierreClientesBindingSource.DataMember = "";
                tRCierreClientesBindingSource.DataSource = _repo.ListarCierreClientesPorClienteTipoFac(IdCliente, IdTipoFac);
                dgvCierres.DataSource = tRCierreClientesBindingSource;
            }
            if (dgvCierres.RowCount > 0)
            {
                btnSeleccionar.Enabled = true;
            }
            else
            {
                btnSeleccionar.Enabled = false;
            }
        }
        private void cboClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void cboTipoFac_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            contrato.Ejecutar(Convert.ToInt32(dgvCierres.CurrentRow.Cells["idCierre"].Value),
                                Convert.ToInt32(cboClientes.SelectedValue), 
                                Convert.ToInt32(cboTipoFac.SelectedValue),
                                Convert.ToDateTime(dgvCierres.CurrentRow.Cells["FechaInicio"].Value),
                                Convert.ToDateTime(dgvCierres.CurrentRow.Cells["FechaFin"].Value),
                                "");
            this.DialogResult = DialogResult.OK;
        }
    }
}