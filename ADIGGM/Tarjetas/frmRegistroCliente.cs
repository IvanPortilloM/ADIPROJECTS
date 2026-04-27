using ADIGGM.Clases;
using ADIGGM.Tarjetas.Api;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Tarjetas
{
    public partial class frmRegistroCliente : FrmPrincipal
    {
        private ApiService _apiService;

        public frmRegistroCliente()
        {
            InitializeComponent();
            _apiService = new ApiService();

            // Validar que el teléfono solo acepte números
            txtTelefono.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string qr = txtCodigoQR.Text.Trim().ToUpper();

            // --- VALIDACIONES DE DATOS ---
            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3)
            {
                MessageBox.Show("Ingrese el nombre completo del cliente.");
                txtNombre.Focus();
                return;
            }

            if (!qr.StartsWith("MEM-"))
            {
                MessageBox.Show("El código escaneado debe ser de una Membresía (Prefijo MEM-).");
                txtCodigoQR.Focus();
                return;
            }

            btnRegistrar.Enabled = false;
            lblEstado.Text = "Registrando en la nube...";

            var res = await _apiService.RegistrarClienteAsync(nombre, telefono, qr);

            if (res.error)
            {
                lblEstado.Text = res.mensaje;
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show(res.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lblEstado.Text = "¡Cliente registrado con éxito!";
                lblEstado.ForeColor = Color.Green;
                MessageBox.Show("Membresía activada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar para el siguiente registro
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCodigoQR.Clear();
                txtNombre.Focus();
            }

            btnRegistrar.Enabled = true;
        }
    }
}