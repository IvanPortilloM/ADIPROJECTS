using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Transacciones
{
    public partial class TranAbonar : ADIGGM.FrmPrincipal
    {
        Boolean permitir = false;
        public TranAbonar()
        {
            InitializeComponent();
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
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillByActivos(this.dsOC.OC_Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.CP_TipoDocumentos' Puede moverla o quitarla según sea necesario.
            this.cP_TipoDocumentosTableAdapter.FillByActivos(this.dsOC.CP_TipoDocumentos);

            lblTotal.Text = "Total: " + 0.00 + " Abonar: " + 0.00 + " Deuda: " + 0.00;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoDocumento.SelectedValue is null || int.Parse(cboTipoDocumento.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Tipo Documento", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboProveedor.SelectedValue is null || int.Parse(cboProveedor.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Proveedor", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtDocumento.Text))
                {
                    MessageBox.Show("Ingrese un numero de documento", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese un Monto", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (decimal.Parse(txtMonto.Text) > decimal.Parse(lblTotal.Text))
                {
                    MessageBox.Show("No puede abonar mas del total actual que es: " + lblTotal.Text, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Seguro deseas generar este abono?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Clases.VarGlobales.consultasOC.CP_AbonosInsert(int.Parse(cboTipoDocumento.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()), txtDocumento.Text, dtpFecha.Value.Date, decimal.Parse(txtMonto.Text), txtObservacion.Text, Clases.VarGlobales.Usuario, Environment.MachineName);
                        MessageBox.Show("Abono generado exitosamente!", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.cP_FacturasEncontradasTableAdapter.Fill(dsOC.CP_FacturasEncontradas, 0, 0);
            lblTotal.Text = "0.00";
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProveedor.SelectedValue is null || int.Parse(cboProveedor.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Proveedor", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese un Monto", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.cP_FacturasEncontradasTableAdapter.Fill(dsOC.CP_FacturasEncontradas, int.Parse(cboProveedor.SelectedValue.ToString()), decimal.Parse(txtMonto.Text));
                    mostrarTotales();

                    if (dgvFacturas.Rows.Count <= 0)
                    {
                        MessageBox.Show("Si no muestra información pueden pasar 2 cosas: \n 1. El monto ingresado no puede pagar ninguna factura \n 2. No existen facturas por pagar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void mostrarTotales()
        {
            decimal total = 0, deuda = 0, abonar = 0;
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                total += decimal.Parse(row.Cells[3].Value.ToString());
                abonar += decimal.Parse(row.Cells[4].Value.ToString());
                deuda += decimal.Parse(row.Cells[5].Value.ToString());
            }

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
