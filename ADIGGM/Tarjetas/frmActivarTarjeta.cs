using ADIGGM.Clases;
using ADIGGM.Tarjetas.Api;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public partial class frmActivarTarjeta : FrmPrincipal
    {
        private ApiService _apiService;
        private string _usuarioActual = VarGlobales.Usuario;

        public frmActivarTarjeta()
        {
            InitializeComponent();
            _apiService = new ApiService();

            // Evitamos que tecleen letras en el ticket
            txtTicket.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }
        private async void btnActivar_Click(object sender, EventArgs e)
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();
            string ticket = txtTicket.Text.Trim();

            // --- VALIDACIONES CLAVE ---
            if (!qr.StartsWith("TR-"))
            {
                MessageBox.Show("Debe escanear una Tarjeta de Regalo válida (Prefijo TR-).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoQR.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ticket))
            {
                MessageBox.Show("Ingrese el número de la factura donde el cliente pagó esta tarjeta.");
                txtTicket.Focus();
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal montoInicial) || montoInicial <= 0)
            {
                MessageBox.Show("Ingrese un monto inicial válido mayor a cero.");
                txtMonto.Focus();
                return;
            }

            var confirm = MessageBox.Show($"¿Confirmar la venta y activación de la tarjeta por L {montoInicial}?", "Activar Tarjeta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Bloqueamos la pantalla mientras la nube trabaja
            btnActivar.Enabled = false;
            lblMensaje.Text = "Activando tarjeta en la nube...";
            lblMensaje.ForeColor = Color.Blue;

            // Llamamos a la API
            var res = await _apiService.ActivarTarjetaAsync(qr, montoInicial, ticket, _usuarioActual);

            if (res.error)
            {
                lblMensaje.Text = res.mensaje;
                lblMensaje.ForeColor = Color.Red;
                MessageBox.Show(res.mensaje, "Error de Activación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblMensaje.Text = "¡Tarjeta Activada!";
                lblMensaje.ForeColor = Color.Green;
                MessageBox.Show($"La tarjeta ahora tiene L {res.nuevo_saldo} y está lista para usarse.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- IMPRIMIR VOUCHER DE ACTIVACIÓN ---
                TicketHelper impresora = new TicketHelper();
                string textoMonto = $"Saldo Cargado: L {montoInicial}";
                string textoSaldo = $"L {res.nuevo_saldo}";

                impresora.ImprimirTicket("ACTIVACIÓN T. REGALO", qr, ticket, textoMonto, textoSaldo, _usuarioActual);

                // Limpiar pantalla
                txtCodigoQR.Clear();
                txtMonto.Clear();
                txtTicket.Clear();
                txtCodigoQR.Focus();
            }

            btnActivar.Enabled = true;
        }
    }
}