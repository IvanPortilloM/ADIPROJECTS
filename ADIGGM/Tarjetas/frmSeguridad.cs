using ADIGGM.Clases;
using ADIGGM.Tarjetas.Api;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public partial class frmSeguridad : FrmPrincipal
    {
        private ApiService _apiService;
        private string _usuarioActual = VarGlobales.Usuario;
        public frmSeguridad()
        {
            InitializeComponent();
            _apiService = new ApiService();
            // Bloqueamos el grupo de acciones hasta que se consulte un código
            pnlAcciones.Enabled = false;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string qr = txtCodigoQR.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(qr)) return;

            lblInfo.Text = "Buscando...";
            var res = qr.StartsWith("TR-") ? await _apiService.ConsultarTarjetaAsync(qr) : await _apiService.ConsultarMembresiaAsync(qr);

            if (res.error)
            {
                lblInfo.Text = res.mensaje;
                lblInfo.ForeColor = Color.Red;
                pnlAcciones.Enabled = false;
            }
            else
            {
                string detalle = qr.StartsWith("TR-") ? $"Saldo: L {res.datos.saldo_actual}" : $"Cliente: {res.datos.nombre_cliente} ({res.datos.puntos_actuales} Pts)";
                lblInfo.Text = $"{detalle}\nEstado Actual: {res.datos.estado}";
                lblInfo.ForeColor = Color.Green;
                pnlAcciones.Enabled = true;
            }
        }

        private async void btnBloquear_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Está seguro de BLOQUEAR este código? El cliente no podrá usarlo más.", "Seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            var res = await _apiService.GestionarSeguridadAsync(txtCodigoQR.Text, "BLOQUEAR", _usuarioActual);
            ManejarResultado(res);
        }

        private async void btnReponer_Click(object sender, EventArgs e)
        {
            string nuevo = txtNuevoQR.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(nuevo))
            {
                MessageBox.Show("Escanee el NUEVO código QR para la reposición.");
                return;
            }

            var res = await _apiService.GestionarSeguridadAsync(txtCodigoQR.Text, "REPONER", _usuarioActual, nuevo);
            ManejarResultado(res);
        }

        private void ManejarResultado(RespuestaApi res)
        {
            if (res.error) MessageBox.Show(res.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(res.mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtCodigoQR.Clear(); txtNuevoQR.Clear();
            lblInfo.Text = "..."; pnlAcciones.Enabled = false;
        }
    }
}