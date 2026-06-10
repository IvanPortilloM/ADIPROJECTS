using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.INV.Visores
{
    public partial class frmVisorExistencias : FrmPrincipal
    {
        private readonly RepositorioInventario _repo = new RepositorioInventario();

        public frmVisorExistencias()
        {
            InitializeComponent();
        }

        private void frmVisorExistencias_Load(object sender, EventArgs e)
        {
            tRVehiculosBindingSource.DataMember = "";
            tRVehiculosBindingSource.DataSource = _repo.ListarVehiculosActivos();

            // Maestro-detalle categorías -> productos (sustituye la relación del DataSet tipado)
            var dsFiltros = new DataSet();
            DataTable categorias = _repo.ListarCategoriasProductos();
            categorias.TableName = "OC_ProductosCategorias";
            DataTable productos = _repo.ListarProductosConTodos();
            productos.TableName = "OC_Productos";
            dsFiltros.Tables.Add(categorias);
            dsFiltros.Tables.Add(productos);
            dsFiltros.Relations.Add("OC_ProductosCategorias_OC_Productos",
                categorias.Columns["IdCatProducto"], productos.Columns["IdCatProducto"], false);

            oCProductosCategoriasBindingSource.DataMember = "OC_ProductosCategorias";
            oCProductosCategoriasBindingSource.DataSource = dsFiltros;
            oCProductosCategoriasOCProductosBindingSource.DataSource = oCProductosCategoriasBindingSource;
            oCProductosCategoriasOCProductosBindingSource.DataMember = "OC_ProductosCategorias_OC_Productos";

            this.Dock = DockStyle.Fill;
            cboTipoReporte.SelectedIndex = 0;
            CargarReporte();
        }

        /// <summary>Habilita/deshabilita combos según los checks y devuelve los filtros (0 = sin filtro).</summary>
        private void AplicarFiltros(out int idCatProducto, out int idProducto, out int idVehiculo)
        {
            idCatProducto = 0;
            idProducto = 0;
            idVehiculo = 0;

            cboCategorias.Enabled = chkCat.Checked || chkFiltroProd.Checked;
            if (chkCat.Checked && cboCategorias.SelectedValue != null)
                idCatProducto = int.Parse(cboCategorias.SelectedValue.ToString());

            cboProductos.Enabled = chkFiltroProd.Checked;
            if (chkFiltroProd.Checked && cboCategorias.SelectedIndex != -1 && cboProductos.SelectedValue != null)
                idProducto = int.Parse(cboProductos.SelectedValue.ToString());

            cboVehiculos.Enabled = chkFiltroVeh.Checked;
            if (chkFiltroVeh.Checked && cboVehiculos.SelectedValue != null)
                idVehiculo = int.Parse(cboVehiculos.SelectedValue.ToString());
        }

        private void CargarReporte()
        {
            AplicarFiltros(out int idCatProducto, out int idProducto, out int idVehiculo);

            if (cboTipoReporte.Text == "Reporte General")
            {
                iNRExistenciasBindingSource.DataMember = "";
                iNRExistenciasBindingSource.DataSource = _repo.ReporteExistencias(
                    idCatProducto, idProducto, idVehiculo, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvInv.SetDisplayMode(DisplayMode.PrintLayout);
                rvInv.ZoomMode = ZoomMode.PageWidth;
                rvInv.Dock = DockStyle.Fill;
                rvInv.Visible = true;
                rvExistencias.Visible = false;
                rvInv.RefreshReport();
            }
            else if (cboTipoReporte.Text == "Reporte de Existencias")
            {
                IN_R_ProductosExistenciaBindingSource.DataMember = "";
                IN_R_ProductosExistenciaBindingSource.DataSource = _repo.ReporteProductosExistencia(
                    idCatProducto, idProducto, chkSoloExistencias.Checked, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvExistencias.SetDisplayMode(DisplayMode.PrintLayout);
                rvExistencias.ZoomMode = ZoomMode.PageWidth;
                rvExistencias.Dock = DockStyle.Fill;
                rvInv.Visible = false;
                rvExistencias.Visible = true;
                rvExistencias.RefreshReport();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void chkFiltroProd_CheckedChanged(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void chkFiltroVeh_CheckedChanged(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void chkCat_CheckedChanged(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoReporte.Text == "Reporte de Existencias")
            {
                chkSoloExistencias.Enabled = true;
                chkSoloExistencias.Checked = false;
                chkFiltroVeh.Checked = false;
                chkFiltroVeh.Enabled = false;
                cboVehiculos.Enabled = false;
            }
            else
            {
                chkSoloExistencias.Enabled = false;
                chkSoloExistencias.Checked = false;
            }
        }
    }
}
