using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using CheckComboBoxTest;
using System;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.FAC.Transacciones
{
    public partial class FAC_BusquedaViajes : FrmPrincipal
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        public int IdCliente = 0;
        public decimal Cant = 0;
        public decimal Impuesto = 0;
        public decimal Tot = 0;
        Boolean permitir = true;

        public FAC_BusquedaViajes(int IdCliente)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
        }

        private void FAC_BusquedaViajes_Load(object sender, EventArgs e)
        {
            CargarTipoFac();   // dispara cboTipoFac_SelectedIndexChanged -> carga productos
            if (cboTipoFac.SelectedIndex != -1)
            {
                CargarProductos(int.Parse(cboTipoFac.SelectedValue.ToString()));
            }

            CargarCierres();   // dispara cboCalendarizacion_SelectedIndexChanged -> carga proformas
            CargarClientes();

            if (cboCalendarizacion.SelectedIndex != -1)
            {
                CargarProformas(int.Parse(cboCalendarizacion.SelectedValue.ToString()), IdCliente);
            }

            cboCliente.SelectedValue = IdCliente;
            txtCantidad.Text = "0";
            lblTotal.Text = $"Cantidad: {0} ISV: {0} Total: {0}";
        }

        private void CargarTipoFac()
        {
            tRTipoFacturasBindingSource.DataMember = "";
            tRTipoFacturasBindingSource.DataSource = _repo.ListarTipoFacTransporte();
            cboTipoFac.DataSource = tRTipoFacturasBindingSource;
        }

        private void CargarProductos(int idTipoFac)
        {
            fACProductosBindingSource.DataMember = "";
            fACProductosBindingSource.DataSource = _repo.ListarProductosPorTipoFac(idTipoFac);
            cboProducto.DataSource = fACProductosBindingSource;
        }

        private void CargarCierres()
        {
            fACCierresBindingSource.DataMember = "";
            fACCierresBindingSource.DataSource = _repo.ListarCierres();
            cboCalendarizacion.DataSource = fACCierresBindingSource;
        }

        private void CargarClientes()
        {
            tRClientesBindingSource.DataMember = "";
            tRClientesBindingSource.DataSource = _repo.ListarClientesTransporte(true);
            cboCliente.DataSource = tRClientesBindingSource;
        }

        private void CargarProformas(int idCierre, int idCliente)
        {
            fACProformasBindingSource.DataMember = "";
            fACProformasBindingSource.DataSource = _repo.ListarProformas(idCierre, idCliente);
            cboProforma.DataSource = fACProformasBindingSource;
        }

        private void cboCalendarizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCalendarizacion.SelectedIndex != -1)
            {
                CargarProformas(int.Parse(cboCalendarizacion.SelectedValue.ToString()), IdCliente);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (int.Parse(cboTipoFac.SelectedIndex.ToString())==-1) {
                MessageBox.Show("Seleccione Tipo Factura", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fACVisorBoletasBindingSource.DataMember = "";
                fACVisorBoletasBindingSource.DataSource = _repo.ListarVisorBoletas(
                    int.Parse(cboCalendarizacion.SelectedValue.ToString()),
                    int.Parse(cboCliente.SelectedValue.ToString()),
                    int.Parse(cboTipoFac.SelectedValue.ToString()));
                dgvBoletas.DataSource = fACVisorBoletasBindingSource;

                Cant = 0;
                Impuesto = 0;
                Tot = 0;
                
                foreach (DataGridViewRow row in dgvBoletas.Rows)
                {
                    Cant += decimal.Parse(row.Cells[6].Value.ToString());
                    Impuesto += decimal.Parse(row.Cells[8].Value.ToString());
                    Tot += decimal.Parse(row.Cells[9].Value.ToString());
                }
                decimal Tot2 = Impuesto+Tot;
                txtCantidad.Text = Cant.ToString();
                lblTotal.Text = $"Cantidad: {Convert.ToString(Cant.ToString("N2"))}    ISV: {Convert.ToString(Impuesto.ToString("N2"))}    Sub-Total: {Convert.ToString(Tot.ToString("N2"))}     Total: {Convert.ToString(Tot2.ToString("N2"))}";
            }            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cboTipoFac.SelectedIndex.ToString()) == -1)
            {
                MessageBox.Show("Seleccione un Tipo Factura", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(cboProducto.SelectedIndex.ToString()) == -1)
            {
                MessageBox.Show("Seleccione una producto", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(int.Parse(cboProforma.SelectedIndex.ToString())== -1){
                MessageBox.Show("Seleccione una proforma", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (decimal.Parse(dgvBoletas.Rows.Count.ToString()) == 0)
            {
                MessageBox.Show("No hay información en el grid, seleccione los parametros y haga clic en visualizar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FAC_Factura.IdCierre = int.Parse(cboCalendarizacion.SelectedValue.ToString());
                FAC_Factura.IdProforma = int.Parse(cboProforma.SelectedValue.ToString());
                FAC_Factura.IdProducto = int.Parse(cboProducto.SelectedValue.ToString());
                FAC_Factura.Cant = decimal.Parse(txtCantidad.Text);
                FAC_Factura.Imp = Impuesto;
                FAC_Factura.Tot = Tot;
                FAC_Factura.TipoFact = cboTipoFac.Text;
                Cant = 0;
                Impuesto = 0;
                Tot = 0;

                this.Close();
            }
        }

        private void cboTipoFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboTipoFac.SelectedIndex.ToString()) != -1)
            {
                CargarProductos(int.Parse(cboTipoFac.SelectedValue.ToString()));
            }
        }

        public bool solonumeros(int code, TextBox txt)
        {
            bool resultado;

            if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
            {
                resultado = false;
            }
            else if (!permitir)
            {
                resultado = permitir;
            }
            else
            {
                resultado = true;
            }

            return resultado;

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtCantidad);
        }
    }
}
