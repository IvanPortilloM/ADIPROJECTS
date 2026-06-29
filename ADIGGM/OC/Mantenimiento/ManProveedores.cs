using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManProveedores : FrmPrincipal
    {
        private readonly RepositorioOC _repoOC = new RepositorioOC();
        private DataTable _dtCAI;
        int IdProveedor = 0;
        Boolean permitir = true;
        public ManProveedores(int IdProveedor)
        {
            InitializeComponent();
            ConfigurarColumnas();
            this.IdProveedor = IdProveedor;
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCAI);
        }

        /// <summary>Columnas del grid de CAIs EN CÓDIGO (no en el Designer) — gotcha §11. IdProveedor es
        /// columna oculta; las filas nuevas heredan el IdProveedor actual vía DataColumn.DefaultValue
        /// (en CargarCAI). Edición con GridColumnas.Edicion (§14.10).</summary>
        private void ConfigurarColumnas()
        {
            dgvCAI.AutoGenerateColumns = false;
            dgvCAI.Columns.Clear();
            dgvCAI.Columns.Add(GridColumnas.Texto("idProveedorDataGridViewTextBoxColumn", "IdProveedor", "IdProveedor", visible: false));
            dgvCAI.Columns.Add(GridColumnas.Texto("CAI", "CAI", "CAI", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvCAI.Columns.Add(GridColumnas.Texto("fechaLimite", "FechaLimite", "Fecha Limite", format: "d"));
            dgvCAI.Columns.Add(GridColumnas.Check("activoDataGridViewCheckBoxColumn", "Activo", "Activo", width: 48, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader));
        }

        /// <summary>Carga los CAIs del proveedor en el grid; las filas nuevas heredan el IdProveedor.</summary>
        private void CargarCAI()
        {
            _dtCAI = _repoOC.ListarProveedorCAI(IdProveedor);
            _dtCAI.Columns["IdProveedor"].DefaultValue = IdProveedor;
            dgvCAI.DataSource = _dtCAI;
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            //btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRTN.Text.Trim().Length < 14)
                {
                    MessageBox.Show("Ingrese un RTN", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese un nombre", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtTel.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Ingrese un telefono", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtMovil.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Ingrese un movil", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtRepresentante.Text))
                {
                    MessageBox.Show("Ingrese un representante", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("Ingrese una direccion", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(txtMaxItems.Text) || int.Parse(txtMaxItems.Text) < 0)
                {
                    MessageBox.Show("Ingrese una cantidad maxima de items", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (IdProveedor > 0)
                    {
                        if (MessageBox.Show("Seguro deseas actualizar este proveedor: " + txtNombre.Text + "?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _repoOC.GuardarProveedor(IdProveedor, txtRTN.Text, txtNombre.Text, txtDireccion.Text, txtTel.Text, txtMovil.Text, txtRepresentante.Text, chkActivo.Checked, Clases.VarGlobales.Usuario, Environment.MachineName, int.Parse(txtMaxItems.Text), txtCuentaCxC.Text, chkCxC.Checked);

                            if (dgvCAI.Rows.Count > 0 && dgvCAI.FirstDisplayedCell != null)
                            {
                                dgvCAI.EndEdit();
                                _repoOC.GuardarProveedorCAI(_dtCAI);
                            }

                            MessageBox.Show("Datos de Proveedor Actualizados exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Seguro deseas agregar este proveedor: " + txtNombre.Text + "?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _repoOC.GuardarProveedor(IdProveedor, txtRTN.Text, txtNombre.Text, txtDireccion.Text, txtTel.Text, txtMovil.Text, txtRepresentante.Text, chkActivo.Checked, Clases.VarGlobales.Usuario, Environment.MachineName, int.Parse(txtMaxItems.Text), txtCuentaCxC.Text, chkCxC.Checked);
                            MessageBox.Show("Proveedor Agregado exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarDatos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiarDatos()
        {
            txtRTN.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtMovil.Text = string.Empty;
            txtRepresentante.Text = string.Empty;
            chkActivo.Checked = false;
            txtCuentaCxC.Text = string.Empty;
            txtMaxItems.Text = string.Empty;
            chkCxC.Checked = false;
        }
        private void ManProveedores_Load(object sender, EventArgs e)
        {
            if (IdProveedor > 0)
            {
                CargarCAI();
                CargarDatos();
            }
            else
            {
                Size = new System.Drawing.Size(313, 400);
                StartPosition = FormStartPosition.CenterScreen;
                btnNuevo.Visible = false;
                btnEditar.Visible = false; 
                btnCancelar.Visible = false;
                dgvCAI.Visible = false;
                txtDireccion.Width = 190;
            }
        }
        void CargarDatos()
        {
            _repoOC.ObtenerProveedor(IdProveedor, out string rtn, out string nombre, out string direccion,
                out string tel, out string movil, out string representante, out bool activo, out int cant,
                out string cuentaCxC, out bool cxc);

            txtRTN.Text = rtn;
            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            txtTel.Text = tel;
            txtMovil.Text = movil;
            txtRepresentante.Text = representante;
            chkActivo.Checked = activo;
            txtMaxItems.Text = cant.ToString();
            txtCuentaCxC.Text = cuentaCxC;
            chkCxC.Checked = cxc;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtMaxItems); //llamada a la funcion que evalua que tecla es aceptada
        }

        public bool solonumeros(int code, TextBox txt)
        {
            bool resultado;

            if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se rebiza si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvCAI.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvCAI, true);
            dgvCAI.FirstDisplayedScrollingRowIndex = dgvCAI.RowCount - 1;
            var cantidadRow = dgvCAI.RowCount - 1;
            dgvCAI.CurrentCell = dgvCAI.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            //btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvCAI.Rows.Count > 0 && dgvCAI.FirstDisplayedCell != null)
            {
                saveRow = dgvCAI.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvCAI, true);
                dgvCAI.AllowUserToAddRows = false;

                //btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvCAI.Rows.Count)
                dgvCAI.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCAI.Rows.Count > 0 && dgvCAI.FirstDisplayedCell != null)
            {
                int fila = dgvCAI.CurrentRow.Index;
                CargarCAI();
                if (fila < dgvCAI.RowCount)
                    dgvCAI.CurrentCell = dgvCAI.Rows[fila].Cells[1];
                dgvCAI.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvCAI, false);
                //btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
    }
}
