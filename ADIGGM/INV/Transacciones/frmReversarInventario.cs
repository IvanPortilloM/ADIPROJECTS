using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.INV.Transacciones
{
    /// <summary>Reversar una transacción del kardex capturada con el tipo de operación equivocado
    /// (entrada por salida o viceversa). Genera una transacción compensatoria; no modifica ni borra
    /// la original (queda como comprobante). Ver §13.d de CONTEXTO-REFACTOR.md.</summary>
    public partial class frmReversarInventario : FrmPrincipal
    {
        private readonly RepositorioInventario _repo = new RepositorioInventario();
        private DataTable _dtDetalle;
        private int _idKardexHeaderSeleccionado = -1;

        public frmReversarInventario()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas de ambos grids EN CÓDIGO (gotcha §11), aunque este form no viene de un
        /// DataSet tipado: si se abre en el diseñador de VS con el BindingSource sin esquema, el
        /// diseñador borraría columnas puestas en el Designer. Ambos grids son solo lectura.</summary>
        private void ConfigurarColumnas()
        {
            dgvTransacciones.AutoGenerateColumns = false;
            dgvTransacciones.Columns.Clear();
            dgvTransacciones.Columns.Add(GridColumnas.Texto("IdKardexHeader", "IdKardexHeader", "#", width: 60));
            dgvTransacciones.Columns.Add(GridColumnas.Texto("Fecha", "Fecha", "Fecha", format: "dd/MM/yyyy HH:mm", width: 130));
            dgvTransacciones.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", width: 100));
            dgvTransacciones.Columns.Add(GridColumnas.Texto("Observacion", "Observacion", "Observación", width: 280));
            dgvTransacciones.Columns.Add(GridColumnas.Texto("Lineas", "Lineas", "# Líneas", width: 70));
            dgvTransacciones.Columns.Add(GridColumnas.Texto("Estado", "Estado", "Estado", width: 160));
            dgvTransacciones.Columns.Add(GridColumnas.Texto("PuedeReversar", "PuedeReversar", "PuedeReversar", visible: false));

            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.Columns.Clear();
            dgvDetalle.Columns.Add(GridColumnas.Texto("IdBodega", "IdBodega", "IdBodega", visible: false));
            dgvDetalle.Columns.Add(GridColumnas.Texto("IdProducto", "IdProducto", "IdProducto", visible: false));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Producto", "Producto", "Producto", width: 220));
            dgvDetalle.Columns.Add(GridColumnas.Texto("NombreBodega", "NombreBodega", "Bodega", width: 130));
            dgvDetalle.Columns.Add(GridColumnas.Texto("NombreOperacion", "NombreOperacion", "Tipo", width: 90));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Cantidad", "Cantidad", "Cantidad", format: "N4", width: 90));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Precio", "Precio", "Precio", format: "N4", width: 90));
            dgvDetalle.Columns.Add(GridColumnas.Texto("ISV", "ISV", "ISV", format: "N2", width: 80));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Total", "Total", "Total", format: "N2", width: 90));
            dgvDetalle.Columns.Add(GridColumnas.Texto("CodVehiculo", "CodVehiculo", "Vehículo", width: 90));
        }

        private void frmReversarInventario_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.Date.AddDays(-7);
            dtpHasta.Value = DateTime.Now.Date;
            CargarTransacciones();
        }

        private void CargarTransacciones()
        {
            var bs = new BindingSource { DataSource = _repo.BuscarTransaccionesKardex(dtpDesde.Value, dtpHasta.Value) };
            dgvTransacciones.DataSource = bs;   // si hay filas, dispara SelectionChanged y deja el detalle listo

            if (dgvTransacciones.Rows.Count == 0)
            {
                dgvDetalle.DataSource = null;
                _dtDetalle = null;
                _idKardexHeaderSeleccionado = -1;
                lblEstadoSeleccion.Text = "Sin transacciones en el rango seleccionado";
                lblEstadoSeleccion.ForeColor = System.Drawing.Color.MidnightBlue;
                btnReversar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha Desde no puede ser posterior a Hasta", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CargarTransacciones();
        }

        private void dgvTransacciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTransacciones.CurrentRow == null)
            {
                btnReversar.Enabled = false;
                return;
            }

            _idKardexHeaderSeleccionado = int.Parse(dgvTransacciones.CurrentRow.Cells["IdKardexHeader"].Value.ToString());
            bool puedeReversar = Convert.ToInt32(dgvTransacciones.CurrentRow.Cells["PuedeReversar"].Value) == 1;
            string estado = dgvTransacciones.CurrentRow.Cells["Estado"].Value.ToString();

            _dtDetalle = _repo.ObtenerDetalleKardex(_idKardexHeaderSeleccionado);
            dgvDetalle.DataSource = _dtDetalle;

            if (puedeReversar)
            {
                lblEstadoSeleccion.Text = "Transacción #" + _idKardexHeaderSeleccionado + " — se puede reversar";
                lblEstadoSeleccion.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblEstadoSeleccion.Text = "Transacción #" + _idKardexHeaderSeleccionado + " — " + estado + " (no se puede reversar)";
                lblEstadoSeleccion.ForeColor = System.Drawing.Color.Firebrick;
            }
            btnReversar.Enabled = puedeReversar;
        }

        private void btnReversar_Click(object sender, EventArgs e)
        {
            if (_idKardexHeaderSeleccionado == -1 || _dtDetalle == null || _dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione una transacción con detalle para reversar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Ingrese el motivo de la reversión", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotivo.Focus();
                return;
            }

            // Chequeo previo de existencia (no bloqueante a nivel de BD, mismo rigor que frmInventario):
            // reversar una ENTRADA equivale a una SALIDA — si ese producto ya se consumió después de
            // la entrada original, reversarla dejaría la existencia en negativo.
            foreach (DataRow fila in _dtDetalle.Rows)
            {
                decimal cantidadOriginal = Convert.ToDecimal(fila["Cantidad"]);
                if (cantidadOriginal <= 0) continue; // esta línea resta al reversar-> solo suma, no hay riesgo

                int idBodega = Convert.ToInt32(fila["IdBodega"]);
                int idProducto = Convert.ToInt32(fila["IdProducto"]);
                decimal existenciaActual = _repo.ObtenerExistenciaActual(idBodega, idProducto);

                if (existenciaActual < cantidadOriginal)
                {
                    MessageBox.Show(
                        "No se puede reversar: el producto \"" + fila["Producto"] + "\" en la bodega \"" + fila["NombreBodega"] +
                        "\" tiene una existencia actual de " + existenciaActual.ToString("N4") +
                        ", menor a la cantidad de esta transacción (" + cantidadOriginal.ToString("N4") +
                        "). Probablemente ya se consumió parte de esa entrada; corrija manualmente.",
                        VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string resumen = "Va a reversar la transacción #" + _idKardexHeaderSeleccionado + " (" + _dtDetalle.Rows.Count + " línea(s)).\n\n" +
                "Se generará una transacción NUEVA con el efecto contrario; la original NO se modifica ni se borra.\n\n" +
                "Motivo: " + txtMotivo.Text.Trim() + "\n\n" +
                "¿Confirma la reversión?";
            if (MessageBox.Show(resumen, VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                int idKardexHeaderReversa = _repo.ReversarTransaccion(_idKardexHeaderSeleccionado, txtMotivo.Text.Trim(), VarGlobales.Usuario);
                MessageBox.Show("Reversión generada exitosamente (transacción #" + idKardexHeaderReversa + ")", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMotivo.Text = string.Empty;
                CargarTransacciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
