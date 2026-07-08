using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADIGGM.OC.Reportes;
using ADIGGM.CapaDatos;

namespace ADIGGM.INV.Transacciones
{
    public partial class frmInventario : FrmPrincipal
    {
        private readonly RepositorioInventario _repo = new RepositorioInventario();
        bool permitir = true;
        decimal ISVP = 0;
        // Señal visual anti-error ENTRADA/SALIDA (banner creado en código; no toca el Designer)
        private readonly Label _lblTipoBanner = new Label();
        private Color _colorPanelOriginal;
        private int _idxTipoAnterior = -1;

        public frmInventario()
        {
            InitializeComponent();
            _colorPanelOriginal = panel1.BackColor;
            _lblTipoBanner.Name = "lblTipoBanner";
            _lblTipoBanner.Location = new Point(12, 97);
            _lblTipoBanner.Size = new Size(99, 88);
            _lblTipoBanner.TextAlign = ContentAlignment.MiddleCenter;
            _lblTipoBanner.Font = new Font(this.Font.FontFamily, 10F, FontStyle.Bold);
            _lblTipoBanner.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(_lblTipoBanner);
            ActualizarSenalTipoOperacion();
        }

        /// <summary>true SOLO si la operación seleccionada resta del inventario (la lógica de signo
        /// del form depende del texto exacto "SALIDA" — ver ActualizarKardex/btnAgregar).</summary>
        private bool EsSalida()
        {
            return cboTipoOperacion.Text == "SALIDA";
        }

        /// <summary>Colorea el panel de captura y el banner según el tipo de operación elegido,
        /// para que una ENTRADA no se confunda con una SALIDA (mejora anti-error 2026-07-07).</summary>
        private void ActualizarSenalTipoOperacion()
        {
            if (cboTipoOperacion.SelectedIndex == -1)
            {
                panel1.BackColor = _colorPanelOriginal;
                _lblTipoBanner.BackColor = SystemColors.ControlLight;
                _lblTipoBanner.ForeColor = Color.Black;
                _lblTipoBanner.Text = "ELIJA EL\nTIPO DE\nOPERACIÓN";
            }
            else if (EsSalida())
            {
                panel1.BackColor = Color.FromArgb(248, 215, 218);   // rojo suave
                _lblTipoBanner.BackColor = Color.Firebrick;
                _lblTipoBanner.ForeColor = Color.White;
                _lblTipoBanner.Text = cboTipoOperacion.Text + "\n(resta del\ninventario)";
            }
            else
            {
                panel1.BackColor = Color.FromArgb(215, 236, 218);   // verde suave
                _lblTipoBanner.BackColor = Color.DarkGreen;
                _lblTipoBanner.ForeColor = Color.White;
                _lblTipoBanner.Text = cboTipoOperacion.Text + "\n(suma al\ninventario)";
            }
        }
        private void frmInventario_Load(object sender, EventArgs e)
        {
            // Mismo orden de llenado que los antiguos Fill: la cascada de SelectedValueChanged depende de él
            oCProductosCategoriasBindingSource.DataMember = "";
            oCProductosCategoriasBindingSource.DataSource = _repo.ListarCategoriasProductosInv();
            tRVehiculosBindingSource.DataMember = "";
            tRVehiculosBindingSource.DataSource = _repo.ListarVehiculosActivos();
            iNBodegasBindingSource.DataMember = "";
            iNBodegasBindingSource.DataSource = _repo.ListarBodegas();
            ISVP = _repo.ObtenerIsvPorcentaje();
            iNTipoOperacionesBindingSource.DataMember = "";
            // Solo ENTRADA/SALIDA: IN_KardexUpdate no tiene rama para otros tipos (TRASLADO guardaba
            // un encabezado sin líneas y decía "éxito" — §14.12.d)
            iNTipoOperacionesBindingSource.DataSource = _repo.ListarTiposOperacionKardex();
            oCProductosBindingSource.DataMember = "";
            oCProductosBindingSource.DataSource = _repo.ListarProductosActivosPorCategoria(int.Parse(cboCategoria.SelectedValue.ToString()));

            // Anti-error ENTRADA/SALIDA: el combo NO queda pre-seleccionado (antes el binding
            // dejaba elegida la primera operación y el usuario podía guardar sin darse cuenta).
            cboTipoOperacion.SelectedIndex = -1;
            ActualizarSenalTipoOperacion();

            if (chkVehiculo.Checked == true)
                cboVehiculo.Enabled = true;
            else
                cboVehiculo.Enabled = false;
        }
        public bool solonumeros(int code, TextBox txt)
        {
            bool resultado;

            if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se revisa si ya existe en el textbox
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipoOperacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el TIPO DE OPERACIÓN (entrada o salida) antes de agregar productos", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idvehiculo = 0;
            string vehiculo = "";
            decimal cant;

            if (chkVehiculo.Checked == true)
            {
                idvehiculo = int.Parse(cboVehiculo.SelectedValue.ToString());
                vehiculo = cboVehiculo.Text;
            }
            if (cboTipoOperacion.Text == "SALIDA")
            {
                cant = -decimal.Parse(txtCantidad.Text);
            }
            else
            {
                cant = decimal.Parse(txtCantidad.Text);
            }

            decimal acumCant = 0;

            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (int.Parse(row.Cells["idProducto"].Value.ToString()) == int.Parse(cboProducto.SelectedValue.ToString()))
                    acumCant += decimal.Parse(row.Cells["cantidad"].Value.ToString());
            }

            if ((Convert.ToDecimal(lblExistencia.Text) >= (Convert.ToDecimal(txtCantidad.Text) + Math.Abs(acumCant)) && cboTipoOperacion.Text == "SALIDA") || cboTipoOperacion.Text == "ENTRADA")
            {
                dgvInventario.Rows.Add(int.Parse(cboProducto.SelectedValue.ToString()), idvehiculo, cboProducto.Text, vehiculo, decimal.Parse(txtPrecio.Text), cant,
                    (decimal.Parse(txtPrecio.Text) * cant) * ISVP, ((decimal.Parse(txtPrecio.Text) * cant) * ISVP) + (decimal.Parse(txtPrecio.Text) * cant), chkAplicaISV.Checked);
                txtCantidad.Text = 1.ToString("N4");
            }
            else
            {
                MessageBox.Show("La existencia del producto es menor a la cantidad que se dará salida", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboTipoOperacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el TIPO DE OPERACIÓN (entrada o salida)", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvInventario.Rows.Count == 0)
            {
                // Antes se guardaba un encabezado de kardex VACÍO si la grilla no tenía productos
                MessageBox.Show("Agregue al menos un producto al detalle antes de guardar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación anti-error ENTRADA/SALIDA: resumen de lo que se va a guardar,
            // con "No" como botón por defecto para exigir un clic consciente.
            decimal totalTransaccion = 0;
            foreach (DataGridViewRow row in dgvInventario.Rows)
                totalTransaccion += decimal.Parse(row.Cells["total"].Value.ToString());

            string efecto = EsSalida() ? "RESTA del inventario" : "SUMA al inventario";
            string resumen = "Está a punto de guardar una operación de tipo:\n\n" +
                "        " + cboTipoOperacion.Text + "  (" + efecto + ")\n\n" +
                "Bodega: " + cboBodega.Text + "\n" +
                "Productos: " + dgvInventario.Rows.Count + "\n" +
                "Total: L " + Math.Abs(totalTransaccion).ToString("N2") + "\n\n" +
                "¿Confirma que el TIPO DE OPERACIÓN es el correcto?";
            if (MessageBox.Show(resumen, VarGlobales.nombreSistema, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            {
                return;
            }

            if (dtpFecha.Value.Date <= DateTime.Now)
            {
                int IdKardexHeader;
                DateTime fechaPicker = dtpFecha.Value;
                DateTime ahora = DateTime.Now;

                DateTime fechaConHoraActual = new DateTime(
                    fechaPicker.Year,
                    fechaPicker.Month,
                    fechaPicker.Day,
                    ahora.Hour,
                    ahora.Minute,
                    ahora.Second
                );

                IdKardexHeader = _repo.InsertarKardexHeader(
                    fechaConHoraActual,
                    txtObservacion.Text,
                    VarGlobales.Usuario
                );

                foreach (DataGridViewRow row in dgvInventario.Rows)
                {
                    _repo.ActualizarKardex(
                        int.Parse(cboBodega.SelectedValue.ToString()),
                        int.Parse(row.Cells["idProducto"].Value.ToString()),
                        decimal.Parse(row.Cells["cantidad"].Value.ToString()),
                        int.Parse(row.Cells["idVehiculo"].Value.ToString()),
                        IdKardexHeader,
                        int.Parse(cboTipoOperacion.SelectedValue.ToString()),
                        fechaConHoraActual,
                        decimal.Parse(row.Cells["precio"].Value.ToString()),
                        Convert.ToBoolean(row.Cells["aplicaISV"].Value)
                    );
                }

                VisualizarReporte reporte = new VisualizarReporte(-3, "", "", 0,0, "", "", "", IdKardexHeader, 0, "", true);
                reporte.ShowDialog();
                dgvInventario.Rows.Clear();
                dgvInventario.Refresh();
                // La siguiente transacción vuelve a exigir elegir el tipo de operación
                cboTipoOperacion.SelectedIndex = -1;
                ActualizarSenalTipoOperacion();

                MessageBox.Show("Los registros fueron salvados exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pueden guardar los registros con una fecha posterior a la actual", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void chkVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVehiculo.Checked == true)
                cboVehiculo.Enabled = true;
            else
                cboVehiculo.Enabled = false;
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtCantidad); //llamada a la función que evalúa que tecla es aceptada
        }
        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Text = 1.ToString("N4");
                txtCantidad.Focus();
            }
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length < 1 || txtCantidad.Text == "." || double.Parse(txtCantidad.Text) == 0)
            {
                txtCantidad.Text = string.Format("{0:#,##0.0000}", 1);
            }
            else
            {
                txtCantidad.Text = string.Format("{0:#,##0.0000}", double.Parse(txtCantidad.Text));
            }
        }
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInventario.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == dgvInventario.Columns["quitar"].Index)
                {
                    if (MessageBox.Show("Seguro deseas quitar este registro?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvInventario.Rows.Remove(dgvInventario.CurrentRow);
                    }
                }
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtPrecio); //llamada a la función que evalúa que tecla es aceptada
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Length < 1 || txtPrecio.Text == "." || double.Parse(txtPrecio.Text) == 0)
            {
                txtPrecio.Text = string.Format("{0:#,##0.0000}", 1);
            }
            else
            {
                txtPrecio.Text = string.Format("{0:#,##0.0000}", double.Parse(txtPrecio.Text));
            }
        }
        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecio.Text = 1.ToString("N4");
                txtPrecio.Focus();
            }
        }
        private void cboProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboBodega.SelectedIndex > -1 && cboProducto.SelectedIndex > -1)
            {
                lblExistencia.Text = Convert.ToString(_repo.ObtenerExistenciaKardex(int.Parse(cboBodega.SelectedValue.ToString()), int.Parse(cboProducto.SelectedValue.ToString())));

                bool AplicaISV = Convert.ToBoolean(_repo.ObtenerAplicaIsvKardex(Convert.ToInt32(cboBodega.SelectedValue.ToString()), Convert.ToInt32(cboProducto.SelectedValue.ToString())));

                chkAplicaISV.Checked = AplicaISV;

                if (cboTipoOperacion.Text == "ENTRADA")
                {
                    txtPrecio.Enabled = true;

                    decimal precio = _repo.ObtenerUltimoPrecioCompra(int.Parse(cboProducto.SelectedValue.ToString()));

                    if (precio == 0)
                    {
                        precio = 1;
                    }

                    txtPrecio.Text = string.Format("{0:#,##0.0000}", precio);
                }
                else
                {
                    txtPrecio.Enabled = false;
                    txtPrecio.Text = string.Format("{0:#,##0.0000}", 1);
                }
            }
        }
        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex > -1)
                oCProductosBindingSource.DataSource = _repo.ListarProductosActivosPorCategoria(int.Parse(cboCategoria.SelectedValue.ToString()));
            if (cboProducto.SelectedIndex > -1 && cboBodega.SelectedIndex > -1)
            {
                bool AplicaISV = Convert.ToBoolean(_repo.ObtenerAplicaIsvKardex(Convert.ToInt32(cboBodega.SelectedValue.ToString()), Convert.ToInt32(cboProducto.SelectedValue.ToString())));

                chkAplicaISV.Checked = AplicaISV;
            }
        }
        private void cboTipoOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            // Cambiar el tipo con detalle ya capturado: confirmar. ANTES, si el usuario respondía
            // "No", el combo QUEDABA en el tipo nuevo con las líneas firmadas por el tipo viejo
            // (mezcla entrada/salida al guardar). Ahora "No" REVIERTE el combo al tipo anterior.
            if (cboTipoOperacion.SelectedIndex != _idxTipoAnterior && dgvInventario.Rows.Count > 0)
            {
                if (MessageBox.Show("Si cambia el Tipo de Operación se eliminará el detalle, Desea continuar?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvInventario.DataSource = null;
                    dgvInventario.Rows.Clear();
                    txtCantidad.Text = string.Format("{0:#,##0.0000}", 1);
                }
                else
                {
                    cboTipoOperacion.SelectedIndex = _idxTipoAnterior;  // re-dispara este handler, ya sin cambio
                    return;
                }
            }
            _idxTipoAnterior = cboTipoOperacion.SelectedIndex;

            ActualizarSenalTipoOperacion();

            decimal precio = 1;
            if (cboProducto.SelectedIndex > -1 && cboBodega.SelectedIndex > -1)
            {
                bool AplicaISV = Convert.ToBoolean(_repo.ObtenerAplicaIsvKardex(Convert.ToInt32(cboBodega.SelectedValue.ToString()), Convert.ToInt32(cboProducto.SelectedValue.ToString())));

                chkAplicaISV.Checked = AplicaISV;
                precio = _repo.ObtenerUltimoPrecioCompra(int.Parse(cboProducto.SelectedValue.ToString()));
            }

            if (cboTipoOperacion.Text == "ENTRADA")
            {
                txtPrecio.Enabled = true;                

                if (precio == 0)
                {
                    precio = 1;
                }
                chkAplicaISV.Enabled = true;

                txtPrecio.Text = string.Format("{0:#,##0.0000}", precio);
            }
            else
            {
                txtPrecio.Enabled = false;
                txtPrecio.Text = string.Format("{0:#,##0.0000}", precio);
                chkAplicaISV.Enabled = false;
            }
        }
        private void cboBodega_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex > -1 && cboBodega.SelectedIndex > -1)
            {
                bool AplicaISV = Convert.ToBoolean(_repo.ObtenerAplicaIsvKardex(Convert.ToInt32(cboBodega.SelectedValue.ToString()), Convert.ToInt32(cboProducto.SelectedValue.ToString())));

                chkAplicaISV.Checked = AplicaISV;
            }
        }
    }
}