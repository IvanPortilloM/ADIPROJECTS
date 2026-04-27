using ADIGGM.Clases;
using ADIGGM.Tarjetas.Api;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public partial class frmTarjetas : FrmPrincipal
    {
        private ApiService _apiService;
        private string _usuarioActual = VarGlobales.Usuario;

        public frmTarjetas()
        {
            InitializeComponent();
            _apiService = new ApiService();
            txtCodigoQR.KeyPress += new KeyPressEventHandler(txtCodigoQR_KeyPress);

            btnCobrar.Enabled = false;
            btnCobrar.Text = "Procesar";
        }

        private async void txtCodigoQR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                await RealizarConsulta();
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await RealizarConsulta();
        }

        private async Task RealizarConsulta()
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();

            // 1. Limpieza total de seguridad antes de consultar
            txtMonto.Clear();
            txtTicket.Clear();
            btnCobrar.Enabled = false;

            if (string.IsNullOrEmpty(qr)) return;

            // 2. Validación de longitud (Ejemplo: mínimo 8 caracteres, ajusta según tu QR real)
            if (qr.Length < 8)
            {
                ManejarErrorConsulta("Error de lectura: El código QR está incompleto o dañado.");
                return;
            }

            lblMensaje.Text = "Consultando en la nube...";
            lblMensaje.ForeColor = Color.Blue;
            btnConsultar.Enabled = false;

            try
            {
                if (qr.StartsWith("TR-"))
                {
                    var res = await _apiService.ConsultarTarjetaAsync(qr);
                    if (res.error) ManejarErrorConsulta(res.mensaje);
                    else
                    {
                        lblMensaje.Text = $"TARJETA DE REGALO\nSaldo: L {res.datos.saldo_actual}\nEstado: {res.datos.estado}";
                        lblMensaje.ForeColor = Color.Green;

                        btnCobrar.Text = "Cobrar de Tarjeta";
                        btnCobrar.Tag = "COBRAR";
                        btnCobrar.Enabled = true;

                        txtMonto.Focus();
                    }
                }
                else if (qr.StartsWith("MEM-"))
                {
                    var res = await _apiService.ConsultarMembresiaAsync(qr);
                    if (res.error) ManejarErrorConsulta(res.mensaje);
                    else
                    {
                        string cliente = res.datos.nombre_cliente.ToString();
                        lblMensaje.Text = $"CLIENTE: {cliente}\nPuntos: {res.datos.puntos_actuales}";
                        lblMensaje.ForeColor = Color.Green;

                        btnCobrar.Text = "Sumar Puntos";
                        btnCobrar.Tag = "SUMAR";
                        btnCobrar.Enabled = true;

                        txtMonto.Focus();
                    }
                }
                else
                {
                    ManejarErrorConsulta("Código no reconocido. Use prefijos TR- o MEM-.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de red: " + ex.Message, "Falla de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConsultar.Enabled = true;
            }
        }

        private void ManejarErrorConsulta(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = Color.Red;
            btnCobrar.Enabled = false;
        }

        private async void btnCobrar_Click(object sender, EventArgs e)
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();
            string ticket = txtTicket.Text.Trim();
            string accion = btnCobrar.Tag?.ToString();

            if (string.IsNullOrEmpty(qr) || string.IsNullOrEmpty(accion)) return;

            if (string.IsNullOrEmpty(ticket))
            {
                MessageBox.Show("Debe ingresar el número de ticket de facturación.");
                txtTicket.Focus();
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Ingrese un monto válido para la operación.");
                txtMonto.Focus();
                return;
            }

            btnCobrar.Enabled = false;
            lblMensaje.Text = "Procesando...";

            if (accion == "COBRAR")
            {
                var confirm = MessageBox.Show($"¿Desea descontar L {valor} de la tarjeta?", "Confirmar Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var res = await _apiService.CobrarTarjetaAsync(qr, valor, ticket, _usuarioActual);
                    // Pasamos toda la información necesaria a FinalizarAccion
                    FinalizarAccion(res, "Cobro Exitoso", $"Saldo restante: L {res.nuevo_saldo}", qr, ticket, valor, accion);
                }
            }
            else if (accion == "SUMAR")
            {
                var res = await _apiService.SumarPuntosAsync(qr, valor, ticket, _usuarioActual);
                FinalizarAccion(res, "Puntos Acumulados", $"Puntos ganados: {res.puntos_sumados}\nTotal actual: {res.nuevo_saldo_puntos}", qr, ticket, valor, accion);
            }

            btnCobrar.Enabled = true;
        }

        // Modificamos la firma para recibir los datos a imprimir
        private void FinalizarAccion(RespuestaApi res, string titulo, string detalleOk, string codigo, string ticketPos, decimal valorIngresado, string accion)
        {
            if (res.error)
            {
                lblMensaje.Text = res.mensaje;
                lblMensaje.ForeColor = Color.Red;
                MessageBox.Show(res.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblMensaje.Text = titulo;
                lblMensaje.ForeColor = Color.Green;
                MessageBox.Show(detalleOk, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // --- IMPRESIÓN DEL VOUCHER ---
                TicketHelper impresora = new TicketHelper();

                string textoMontoOPuntos = accion == "COBRAR" ? $"Monto Cobrado: L {valorIngresado}" : $"Puntos Sumados: {res.puntos_sumados}";
                string textoNuevoSaldo = accion == "COBRAR" ? $"L {res.nuevo_saldo}" : $"{res.nuevo_saldo_puntos} Pts";

                impresora.ImprimirTicket(titulo.ToUpper(), codigo, ticketPos, textoMontoOPuntos, textoNuevoSaldo, _usuarioActual);

                LimpiarFormulario();
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigoQR.Clear();
            txtMonto.Clear();
            txtTicket.Clear();
            btnCobrar.Tag = null;
            btnCobrar.Enabled = false;
            btnCobrar.Text = "Procesar";
            lblMensaje.Text = "...";
            txtCodigoQR.Focus();
        }

        private void btnIrACanje_Click(object sender, EventArgs e)
        {
            frmCanjePremios pantallaCanje = new frmCanjePremios();
            pantallaCanje.ShowDialog();
        }

        private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y teclas de control (como borrar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAbrirRegistro_Click(object sender, EventArgs e)
        {
            frmRegistroCliente pantallaRegistro = new frmRegistroCliente();
            // Usamos .Show() normal (no ShowDialog) si quieres que el encargado 
            // pueda tener esta ventana abierta a un lado mientras hace otras cosas.
            pantallaRegistro.Show();
        }
    }
}