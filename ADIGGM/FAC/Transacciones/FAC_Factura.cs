namespace ADIGGM.FAC.Transacciones
{
    using ADIGGM.Clases;
    using ADIGGM.CapaDatos;
    using System;
    using System.Windows.Forms;
    public partial class FAC_Factura : FrmPrincipal
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        public bool EsTransporte = false;
        public static int IdCierre = 0;
        public static int IdProforma = 0;
        public static int IdProducto = 0;
        public static string TiposVeh = "";
        public static decimal Cant = 0;
        public static string TipoFact = "";
        public static decimal Imp = 0;
        public static decimal Tot = 0;
        decimal ISVP = 0;
        public string CAI = "";
        public string Correlativo = "";
        Boolean permitir = true;

        public FAC_Factura()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid de detalle EN CÓDIGO (no en el Designer) para que el diseñador de VS no
        /// las borre — gotcha §11. Grid UNBOUND (filas por Rows.Add): columnas sin DataPropertyName; el orden
        /// (0=Producto,1=Cantidad,2=Precio,3=ISV,4=Total) lo usan btnGuardar/btnAgregar. La columna combo
        /// recibe su DataSource en el Load. "Quitar" es columna link.</summary>
        private void ConfigurarColumnas()
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.Columns.Clear();
            dgvDetalle.Columns.Add(GridColumnas.Combo("Producto", null, "Servicio", "NombreProducto", "IdProducto"));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Cantidad", null, "Cantidad", format: "N2"));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Precio", null, "Precio", format: "N2"));
            dgvDetalle.Columns.Add(GridColumnas.Texto("ISV", null, "ISV", format: "N2"));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Total", null, "Sub-Total", format: "N2"));
            dgvDetalle.Columns.Add(new DataGridViewLinkColumn
            {
                Name = "Quitar",
                HeaderText = "Quitar",
                Text = "Quitar",
                LinkColor = System.Drawing.Color.Red,
                UseColumnTextForLinkValue = true,
                ReadOnly = true
            });
        }

        private void cboTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarTipoFactura();
            TipoFact = "N/A";
        }

        void CargarClientes()
        {
            // El DataSource se asigna aquí y NO en el Designer (gotcha del diseñador de VS)
            tRClientesBindingSource.DataMember = "";
            tRClientesBindingSource.DataSource = _repo.ListarClientesTransporte(EsTransporte);
            cboCliente.DataSource = tRClientesBindingSource;
        }

        void validarTipoFactura()
        {
            if (cboTipoFactura.SelectedIndex != -1)
            {
                bool resul = _repo.TipoFacturaEsTransporte(int.Parse(cboTipoFactura.SelectedValue.ToString()));

                if (resul)
                {
                    btnBuscarBoletas.Visible = true;
                    gbDetalle.Enabled = false;
                    dgvDetalle.Rows.Clear();
                    EsTransporte = true;
                    CargarClientes();
                }
                else
                {
                    btnBuscarBoletas.Visible = false;
                    gbDetalle.Enabled = true;
                    dgvDetalle.Rows.Clear();
                    EsTransporte = false;
                    CargarClientes();
                }
            }
        }

        private void FAC_Factura_Load(object sender, EventArgs e)
        {
            // Tipo de moneda
            fACTipoMonedaBindingSource.DataMember = "";
            fACTipoMonedaBindingSource.DataSource = _repo.ListarTiposMoneda();
            cboTipoMoneda.DataSource = fACTipoMonedaBindingSource;
            // Productos no-transporte (detalle manual)
            fACProductosBindingSource.DataMember = "";
            fACProductosBindingSource.DataSource = _repo.ListarProductosNoTransporte();
            cboProducto.DataSource = fACProductosBindingSource;
            // Fuente de la columna combo del grid de detalle (Id->NombreProducto). Acceso por nombre con
            // null-check: si el diseñador de VS borrara la columna (gotcha §11), el form degrada en vez
            // de tronar con NullReferenceException al cargar.
            fACProductosDetBindingSource.DataMember = "";
            fACProductosDetBindingSource.DataSource = _repo.ListarProductosDet();
            if (dgvDetalle.Columns["Producto"] is System.Windows.Forms.DataGridViewComboBoxColumn colProd)
                colProd.DataSource = fACProductosDetBindingSource;
            // Tipos de factura del usuario (dispara cboTipoFactura_SelectedIndexChanged -> validarTipoFactura)
            fACTipoFacturasBindingSource.DataMember = "";
            fACTipoFacturasBindingSource.DataSource = _repo.ListarTipoFacturasPorUsuario(VarGlobales.Usuario);
            cboTipoFactura.DataSource = fACTipoFacturasBindingSource;
            CargarClientes();

            ISVP = _repo.ObtenerISV();
            txtISV.Text = ISVP.ToString();
            obtenerCAI();
            validarTipoFactura();
            //EsExenta(0);
        }

        void obtenerCAI()
        {
            var cai = _repo.ObtenerCAI();
            CAI = cai.Cai;
            Correlativo = cai.Correlativo;
            txtCAI.Text = CAI;
            txtCorrelativo.Text = Correlativo;
        }

        private void btnBuscarBoletas_Click(object sender, EventArgs e)
        {
            if (int.Parse(cboCliente.SelectedIndex.ToString()) != -1)
            {
                FAC_BusquedaViajes buscar = new FAC_BusquedaViajes(int.Parse(cboCliente.SelectedValue.ToString()));
                buscar.ShowDialog();

                if(IdProforma>=0 && IdCierre>0)
                {
                    dgvDetalle.Rows.Clear();
                    //var IdProducto = VarGlobales.consultasFAC.FAC_ObtenerConceptoServicio(TiposVeh);
                    txtOrdenExenta.Text = string.Empty;
                    double precio;
                    var ISV = chkAplica.Checked && Imp <= 0 ? Tot * (decimal.Parse(txtISV.Text) / 100) : Imp;
                    ISV = !chkAplica.Checked && Imp > 0 ? 0 : ISV;

                    if(TipoFact == "Facturación de Retroexcavadoras")
                    {
                        precio = Convert.ToDouble(VarGlobales.consultasTrans.TR_SelectTarifaRetro());
                    }
                    else
                    {
                        precio = 0;
                    }

                    dgvDetalle.Rows.Add(int.Parse(IdProducto.ToString()), Cant, precio, ISV, Tot);
                    //EsExenta(int.Parse(IdProducto.ToString()));
                    CalcularTotal();
                }                
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTipoFactura.SelectedValue is null || int.Parse(cboTipoFactura.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Tipo Factura", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cboCliente.SelectedValue is null || int.Parse(cboCliente.SelectedValue.ToString()) < 0)
                {
                    MessageBox.Show("Seleccione un Cliente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((cboTipoMoneda.SelectedValue is null || int.Parse(cboTipoMoneda.SelectedValue.ToString()) < 0))
                {
                    MessageBox.Show("Seleccione un Tipo de Moneda", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvDetalle.Rows.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un servicio al detalle", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //if (Actualizar == 0)
                    //{
                    //MessageBox.Show(IdCierre.ToString() + '-' + IdProforma.ToString() + '-' + TiposVeh);
                    if (MessageBox.Show("Seguro desea guardar esta factura?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var resultado = _repo.InsertarFactura(dtpFecha.Value.Date,
                                                              int.Parse(cboTipoFactura.SelectedValue.ToString()),
                                                              int.Parse(cboCliente.SelectedValue.ToString()),
                                                              txtCAI.Text,
                                                              int.Parse(cboTipoMoneda.SelectedValue.ToString()),
                                                              txtObservaciones.Text,
                                                              int.Parse(IdCierre.ToString()),
                                                              int.Parse(IdProforma.ToString()),
                                                              TiposVeh,
                                                              VarGlobales.Usuario,
                                                              txtOrdenExenta.Text,
                                                              txtSAG.Text,
                                                              chkAplica.Checked);
                        int IdFAC = resultado.IdFactura;
                        var mensaje = resultado.Mensaje;

                        if (mensaje == "SI")
                        {
                            foreach (DataGridViewRow row in dgvDetalle.Rows)
                            {
                                _repo.InsertarFacturaDetalle(IdFAC, int.Parse(row.Cells[0].Value.ToString()),
                                                                    decimal.Parse(row.Cells[1].Value.ToString()),
                                                                    decimal.Parse(row.Cells[2].Value.ToString()),
                                                                    decimal.Parse(row.Cells[3].Value.ToString()),
                                                                    decimal.Parse(row.Cells[4].Value.ToString()));
                            }
                            MessageBox.Show("Factura agregada exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarDatos();
                            CalcularTotal();
                            obtenerCAI();
                            IdProforma = 0;
                            IdCierre = 0;
                            IdProducto = 0;
                            TiposVeh = "";
                            mensaje = "";

                            if (MessageBox.Show("Deseas ver la Factura?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Visores.FAC_VerReporte tran = new Visores.FAC_VerReporte(IdFAC, 4, DateTime.Now, DateTime.Now, TipoFact);
                                tran.ShowDialog();                                
                            }
                            TipoFact = "";
                        }
                        else
                        {
                            MessageBox.Show("La factura no se ha guardado verifique que tenga números en existencia el CAI", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //}
                    //else
                    //{
                    //    if (MessageBox.Show("Seguro desea actualizar esta Orden?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //    {

                    //        decimal isv = TipoOC == 1 ? 0 : decimal.Parse(txtISV.Text);
                    //        foreach (DataGridViewRow row in dgvDetOrden.Rows)
                    //        {
                    //            if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 1)
                    //            {
                    //                VarGlobales.consultasOC.OC_OrdenTrabajoDetDelete(Actualizar, int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[1].Value.ToString()));
                    //            }
                    //        }

                    //        int IdOC = int.Parse(VarGlobales.consultasOC.OC_OrdenTrabajoInsert(Actualizar, dtpFecha.Value.Date,
                    //                                                                                              int.Parse(cboTipoOC.SelectedValue.ToString()),
                    //                                                                                              int.Parse(cboProveedor.SelectedValue.ToString()),
                    //                                                                                              txtObservaciones.Text,
                    //                                                                                              VarGlobales.Usuario,
                    //                                                                                              Environment.MachineName,
                    //                                                                                              cboDepartamento.SelectedIndex == -1 ? 0 : int.Parse(cboDepartamento.SelectedValue.ToString()),
                    //                                                                                              cboClaTra.SelectedIndex == -1 ? 0 : int.Parse(cboClaTra.SelectedValue.ToString()),
                    //                                                                                              txtSolicitado.Text).ToString());

                    //        foreach (DataGridViewRow row in dgvDetalle.Rows)
                    //        {
                    //            if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0)
                    //            {
                    //                VarGlobales.consultasOC.OC_OrdenTrabajoDetInsert(IdOC, int.Parse(row.Cells[0].Value.ToString()),
                    //                                                                              int.Parse(row.Cells[1].Value.ToString()),
                    //                                                                              decimal.Parse(row.Cells[2].Value.ToString()),
                    //                                                                              decimal.Parse(row.Cells[3].Value.ToString()),
                    //                                                                              decimal.Parse(row.Cells[4].Value.ToString()),
                    //                                                                              (decimal.Parse(row.Cells[2].Value.ToString()) * decimal.Parse(row.Cells[3].Value.ToString())) + decimal.Parse(row.Cells[4].Value.ToString()));
                    //            }
                    //        }
                    //        MessageBox.Show("Orden actualizada exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        this.Close();
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiarDatos()
        {
            dtpFecha.Value = DateTime.Now.Date;
            cboTipoFactura.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            txtObservaciones.Text = string.Empty;
            cboTipoMoneda.SelectedIndex = -1;
            dgvDetalle.Rows.Clear();
            txtOrdenExenta.Text = string.Empty;
            txtSAG.Text = string.Empty;
        }

        void CalcularTotal()
        {
            decimal total = 0, isv = 0, cantidad=0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                //if (int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0)
                //{
                total += decimal.Parse(row.Cells[4].Value.ToString());
                isv += decimal.Parse(row.Cells[3].Value.ToString());
                cantidad += decimal.Parse(row.Cells[1].Value.ToString());
                //}
            }

            lblTotal.Text = "Cantidad: " + cantidad.ToString("N2") + " ISV: " + isv.ToString("N2") + " Sub-Total: " + (total).ToString("N2") + " Total: " + (total+isv).ToString("N2");

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == dgvDetalle.Columns["Quitar"].Index)
                {
                    if (MessageBox.Show("Seguro deseas quitar este servicio?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
                        CalcularTotal();
                        //if (dgvDetalle.Rows.Count == 0)
                        //{
                        //    EsExenta(0);
                        //}
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProducto.SelectedValue is null || int.Parse(cboProducto.SelectedValue.ToString()) <= 0)
                {
                    MessageBox.Show("Seleccione un Servicio", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (decimal.Parse(txtCantidad.Text) <= 0 || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Ingrese una cantidad", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (decimal.Parse(txtPrecio.Text) <= 0 || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Ingrese un precio", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        if (int.Parse(row.Cells[0].Value.ToString()) == int.Parse(cboProducto.SelectedValue.ToString())  /*&& int.Parse(row.Cells["Eliminar"].Value.ToString()) == 0*/)
                        {
                            MessageBox.Show("El producto seleccionado ya existe", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    decimal cantidad, isv, precio, total;
                    cantidad = decimal.Parse(txtCantidad.Text);
                    precio = decimal.Parse(txtPrecio.Text);
                    isv = chkAplica.Checked ? decimal.Parse(txtISV.Text) / 100 : 0;
                    total = (cantidad * precio);// + ((cantidad * precio) * isv);

                    dgvDetalle.Rows.Add(int.Parse(cboProducto.SelectedValue.ToString()), cantidad, precio, (cantidad * precio)*isv, total);
                    //EsExenta(int.Parse(cboProducto.SelectedValue.ToString()));
                    limpiarDetalle();
                    cboProducto.Focus();
                    CalcularTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limpiarDetalle()
        {
            cboProducto.SelectedIndex = -1;
            txtCantidad.Text = "1";
            txtPrecio.Text = "0.0";            
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtPrecio);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtCantidad);
        }

        private void dgvDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gbDetalle_Enter(object sender, EventArgs e)
        {

        }

        void EsExenta(int IdProducto)
        {
            bool esExenta = _repo.EsExenta(IdProducto);
            if (esExenta)
            {
                lblExenta.Visible = true;
                txtOrdenExenta.Visible = true;
            }
            else
            {
                lblExenta.Visible = false;
                txtOrdenExenta.Visible = false;
                txtOrdenExenta.Text = string.Empty;
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                chkAplica.Checked = _repo.ClientePagaISV(int.Parse(cboCliente.SelectedValue.ToString()));
            }
        }

        private void chkAplica_CheckedChanged(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
        }
    }
}
