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
            const DataGridViewAutoSizeColumnMode dc = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCierres.AutoGenerateColumns = false;
            dgvCierres.Columns.Clear();
            dgvCierres.Columns.Add(GridColumnas.Combo("idCierre", "IdCierre", "Cierre", "Semana", "IdCierre", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvCierres.Columns.Add(GridColumnas.Texto("FechaInicio", "FechaInicio", "F. Inicio", width: 72, autoSize: dc));
            dgvCierres.Columns.Add(GridColumnas.Texto("FechaFin", "FechaFin", "F. Fin", width: 58, autoSize: dc));
            dgvCierres.Columns.Add(GridColumnas.Texto("idCliente", "IdCliente", "IdCliente", visible: false));
            dgvCierres.Columns.Add(GridColumnas.Texto("subTotalCierre", "SubTotalCierre", "SubTotal", format: "C2", width: 80, autoSize: dc));
            dgvCierres.Columns.Add(GridColumnas.Texto("iSVCierre", "ISVCierre", "ISV", format: "C2", width: 49, autoSize: dc));
            dgvCierres.Columns.Add(GridColumnas.Texto("totalCierre", "TotalCierre", "Total", format: "C2", width: 59, autoSize: dc));
            dgvCierres.Columns.Add(GridColumnas.Check("cerrado", "Cerrado", "Cerrado", visible: false));
            dgvCierres.Columns.Add(GridColumnas.Check("anulado", "Anulado", "Anulado", visible: false));
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