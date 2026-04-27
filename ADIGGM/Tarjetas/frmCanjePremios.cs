using ADIGGM.Clases;
using ADIGGM.Tarjetas.Api;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public partial class frmCanjePremios : FrmPrincipal
    {
        private ApiService _apiService;
        private string _usuarioActual = VarGlobales.Usuario;
        private int _puntosDisponibles = 0;

        public frmCanjePremios()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void txtCodigoQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                await ConsultarCliente();
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await ConsultarCliente();
        }

        private async Task ConsultarCliente()
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(qr)) return;

            if (!qr.StartsWith("MEM-"))
            {
                MessageBox.Show("Por favor escanee una Membresía válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblMensaje.Text = "Consultando datos del cliente...";
            lblMensaje.ForeColor = Color.Blue;
            btnConsultar.Enabled = false;
            _puntosDisponibles = 0;

            var respuesta = await _apiService.ConsultarMembresiaAsync(qr);

            if (respuesta.error)
            {
                lblMensaje.Text = respuesta.mensaje;
                lblMensaje.ForeColor = Color.Red;
            }
            else
            {
                _puntosDisponibles = (int)respuesta.datos.puntos_actuales;
                string cliente = respuesta.datos.nombre_cliente.ToString();

                lblMensaje.Text = $"CLIENTE: {cliente}\nPUNTOS DISPONIBLES: {_puntosDisponibles}";
                lblMensaje.ForeColor = Color.Green;

                txtPuntosCanjear.Focus();
            }

            btnConsultar.Enabled = true;
        }

        private async void btnCanjear_Click(object sender, EventArgs e)
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();
            string referencia = txtReferencia.Text.Trim();

            if (string.IsNullOrEmpty(qr) || _puntosDisponibles == 0)
            {
                MessageBox.Show("Primero debe consultar una membresía con puntos disponibles.");
                return;
            }

            if (!int.TryParse(txtPuntosCanjear.Text, out int puntosACanjear) || puntosACanjear <= 0)
            {
                MessageBox.Show("Ingrese una cantidad de puntos válida a descontar.");
                txtPuntosCanjear.Focus();
                return;
            }

            if (string.IsNullOrEmpty(referencia))
            {
                MessageBox.Show("Debe ingresar la referencia del premio (Ej. 'Licuadora' o código de artículo).");
                txtReferencia.Focus();
                return;
            }

            if (puntosACanjear > _puntosDisponibles)
            {
                MessageBox.Show($"El cliente solo tiene {_puntosDisponibles} puntos. No le ajusta para este canje.", "Puntos Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show($"¿Confirmar el canje de {puntosACanjear} puntos por: {referencia}?", "Confirmar Canje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            lblMensaje.Text = "Procesando canje en la nube...";
            lblMensaje.ForeColor = Color.Orange;
            btnCanjear.Enabled = false;

            var res = await _apiService.CanjearPuntosAsync(qr, puntosACanjear, referencia, _usuarioActual);

            if (res.error)
            {
                lblMensaje.Text = res.mensaje;
                lblMensaje.ForeColor = Color.Red;
                MessageBox.Show(res.mensaje, "Error de Canje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblMensaje.Text = "¡Canje Exitoso!";
                lblMensaje.ForeColor = Color.Green;
                MessageBox.Show($"Se han descontado {res.puntos_descontados} puntos.\nNuevo saldo: {res.nuevo_saldo_puntos}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- IMPRESIÓN DEL VOUCHER DE CANJE ---
                TicketHelper impresora = new TicketHelper();
                string textoDescuento = $"Puntos Canjeados: -{res.puntos_descontados}";
                string textoNuevoSaldo = $"{res.nuevo_saldo_puntos} Pts";
                impresora.ImprimirTicket("CANJE DE PREMIOS", qr, referencia, textoDescuento, textoNuevoSaldo, _usuarioActual);

                // Limpiamos todo
                txtCodigoQR.Clear();
                txtPuntosCanjear.Clear();
                txtReferencia.Clear();
                _puntosDisponibles = 0;
                txtCodigoQR.Focus();
            }

            btnCanjear.Enabled = true;
        }        
    }
}