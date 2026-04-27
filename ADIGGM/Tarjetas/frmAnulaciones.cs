using ADIGGM.Clases;
using ADIGGM.Tarjetas.Api;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public partial class frmAnulaciones : FrmPrincipal
    {
        private ApiService _apiService;
        private string _usuarioActual = VarGlobales.Usuario;

        public frmAnulaciones()
        {
            InitializeComponent();
            _apiService = new ApiService();

            // Bloquear letras en el ticket
            txtTicket.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };

            // Permitir 'Enter' en el código QR
            txtCodigoQR.KeyPress += (s, e) => {
                if (e.KeyChar == (char)13) { e.Handled = true; txtTicket.Focus(); }
            };
        }

        private async void btnAnular_Click(object sender, EventArgs e)
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();
            string ticket = txtTicket.Text.Trim();

            if (string.IsNullOrEmpty(qr) || (!qr.StartsWith("TR-") && !qr.StartsWith("MEM-")))
            {
                MessageBox.Show("Escanee un código válido de Tarjeta o Membresía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoQR.Focus();
                return;
            }

            if (string.IsNullOrEmpty(ticket))
            {
                MessageBox.Show("Ingrese el número de factura original que desea anular.");
                txtTicket.Focus();
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal montoAnular) || montoAnular <= 0)
            {
                MessageBox.Show("Ingrese un monto o cantidad de puntos válido mayor a cero.");
                txtMonto.Focus();
                return;
            }

            // Mensaje dinámico según lo que están anulando
            string tipoAccion = qr.StartsWith("TR-") ? "DEVOLVERÁ DINERO a la tarjeta" : "RESTARÁ PUNTOS de la membresía";
            var confirm = MessageBox.Show($"¡Atención! Esta acción {tipoAccion}.\n\nMonto/Puntos: {montoAnular}\nTicket Origen: {ticket}\n\n¿Está seguro de proceder?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            btnAnular.Enabled = false;
            lblMensaje.Text = "Procesando anulación...";
            lblMensaje.ForeColor = Color.Orange;

            var res = await _apiService.AnularTransaccionAsync(qr, montoAnular, ticket, _usuarioActual);

            if (res.error)
            {
                lblMensaje.Text = res.mensaje;
                lblMensaje.ForeColor = Color.Red;
                MessageBox.Show(res.mensaje, "Error al Anular", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblMensaje.Text = "¡Anulación Completada!";
                lblMensaje.ForeColor = Color.Green;
                MessageBox.Show($"La transacción fue revertida exitosamente.\nSaldo/Puntos actualizados a: {res.nuevo_saldo}", "Reversión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Imprimir un comprobante de anulación
                TicketHelper impresora = new TicketHelper();
                impresora.ImprimirTicket("COMPROBANTE DE ANULACIÓN", qr, "REV-" + ticket, $"Monto Revertido: {montoAnular}", $"Nuevo Saldo: {res.nuevo_saldo}", _usuarioActual);

                // Limpiar
                txtCodigoQR.Clear();
                txtTicket.Clear();
                txtMonto.Clear();
                txtCodigoQR.Focus();
            }

            btnAnular.Enabled = true;
        }
    }
}