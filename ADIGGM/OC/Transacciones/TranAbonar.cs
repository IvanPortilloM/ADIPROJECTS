using System;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.OC.Transacciones
{
    public partial class TranAbonar : ADIGGM.FrmPrincipal
    {
        private readonly RepositorioOC _repo = new RepositorioOC();
        private decimal _totalFacturas = 0m;
        Boolean permitir = false;

        public TranAbonar()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid de facturas EN CÓDIGO (gotcha §11); visor de solo lectura. Se quitó el
        /// binding de diseño Tag→"TotalGral" (nada en el .cs lo leía; habría quedado huérfano al migrar).</summary>
        private void ConfigurarColumnas()
        {
            dgvFacturas.AutoGenerateColumns = false;
            dgvFacturas.Columns.Clear();
            dgvFacturas.Columns.Add(GridColumnas.Texto("Correlativo", "Correlativo", "Correlativo"));
            dgvFacturas.Columns.Add(GridColumnas.Texto("NumFactura", "NumFactura", "# Factura"));
            dgvFacturas.Columns.Add(GridColumnas.Texto("Proveedor", "Proveedor", "Proveedor"));
            dgvFacturas.Columns.Add(GridColumnas.Texto("Total", "Total", "Total", format: "N2"));
            dgvFacturas.Columns.Add(GridColumnas.Texto("Abonar", "Abonar", "Abonar", format: "N2"));
            dgvFacturas.Columns.Add(GridColumnas.Texto("Deuda", "Deuda", "Deuda", format: "N2"));
            dgvFacturas.DataSource = cPFacturasEncontradasBindingSource;
        }

        public bool solonumeros(int code, TextBox txt)
        {
            bool resultado;

            if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas válidas
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

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtMonto);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TranAbonar_Load(object sender, EventArgs e)
        {
            oCProveedoresBindingSource.DataSource = _repo.ListarProveedoresActivos();
            cPTipoDocumentosBindingSource.DataSource = _repo.ListarTiposDocumentoActivos();

            _totalFacturas = 0m;
            lblTotal.Text = "Total: " + 0.00 + " Abonar: " + 0.00 + " Deuda: " + 0.00;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoDocumento.SelectedValue is null || int.Parse(cboTipoDocumento.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Tipo Documento", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboProveedor.SelectedValue is null || int.Parse(cboProveedor.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Proveedor", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtDocumento.Text))
                {
                    MessageBox.Show("Ingrese un numero de documento", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese un Monto", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (decimal.Parse(txtMonto.Text) > _totalFacturas)
                {
                    MessageBox.Show("No puede abonar mas del total actual que es: " + _totalFacturas.ToString("N2"), VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro deseas generar este abono?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _repo.GuardarAbono(int.Parse(cboTipoDocumento.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()), txtDocumento.Text, dtpFecha.Value.Date, decimal.Parse(txtMonto.Text), txtObservacion.Text, VarGlobales.Usuario, Environment.MachineName);
                        MessageBox.Show("Abono generado exitosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarDatos()
        {
            txtDocumento.Text = string.Empty;
            txtMonto.Text = string.Empty;
            cboProveedor.SelectedIndex = -1;
            cboTipoDocumento.SelectedIndex = -1;
            txtObservacion.Text = string.Empty;
            dtpFecha.Value = DateTime.Now.Date;
            cPFacturasEncontradasBindingSource.DataSource = null;
            _totalFacturas = 0m;
            lblTotal.Text = "0.00";
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProveedor.SelectedValue is null || int.Parse(cboProveedor.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Proveedor", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese un Monto", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cPFacturasEncontradasBindingSource.DataSource = _repo.ListarFacturasPorAbonar(int.Parse(cboProveedor.SelectedValue.ToString()), decimal.Parse(txtMonto.Text));
                    mostrarTotales();

                    if (dgvFacturas.Rows.Count <= 0)
                    {
                        MessageBox.Show("Si no muestra información pueden pasar 2 cosas: \n 1. El monto ingresado no puede pagar ninguna factura \n 2. No existen facturas por pagar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void mostrarTotales()
        {
            decimal total = 0, deuda = 0, abonar = 0;
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                total += decimal.Parse(row.Cells["Total"].Value.ToString());
                abonar += decimal.Parse(row.Cells["Abonar"].Value.ToString());
                deuda += decimal.Parse(row.Cells["Deuda"].Value.ToString());
            }
            _totalFacturas = total;

            if (total > 0)
            {
                lblTotal.Text = "Total: " + total.ToString("N2") + "    Abonar: " + abonar.ToString("N2") + "   Deuda: " + deuda.ToString("N2");
            }
            else
            {
                lblTotal.Text = "Total: " + 0.00 + " Abonar: " + 0.00 + " Deuda: " + 0.00;
            }
        }
    }
}
