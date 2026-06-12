namespace ADIGGM.IA.Transaccionales
{
    using ADIGGM.CapaDatos;
    using ADIGGM.Clases;
    using ADIGGM.IA.Busquedas;
    using ADIGGM.IA.Mantenimiento;
    using ADIGGM.IA.Visores;
    using ADIGGM.Mantenimiento;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    public partial class frmInformacionAsoc : FrmPrincipal
    {
        private readonly RepositorioCA _repoCA = new RepositorioCA();
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        public string cidasociad, ccodigopin;
        decimal TotalAport, TotalCred;
        int selectedIndex, validar, validarPAConsul, validarPAInsert;
        bool insert = false, update = false;
        public frmInformacionAsoc(string cidasociad)
        {
            InitializeComponent();
            this.cidasociad = cidasociad;            
        }
        private void cargarDgv()
        {
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            cAAportesBindingSource.DataMember = "";
            cAAportesBindingSource.DataSource = _repoCA.CargarAportes(cidasociad, rdbConSaldoProd.Checked);
            dgvProd.DataSource = cAAportesBindingSource;

            cACreditosBindingSource.DataMember = "";
            cACreditosBindingSource.DataSource = _repoCA.CargarCreditos(cidasociad, rdbConSaldoCred.Checked);
            dgvCred.DataSource = cACreditosBindingSource;

            // Tránsito/pendiente por crédito vía repositorio parametrizado
            // (antes se armaba un EXEC por concatenación de texto con la cadena legacy de Settings)
            foreach (DataGridViewRow row in dgvCred.Rows)
            {
                decimal ncuotaT = 0, ncuotaP = 0;
                string cnumoperac = row.Cells["cnumoperac"].Value.ToString();

                foreach (DataRow pRow in _repoCA.CargarPlanCredito(cnumoperac, "T").Rows)
                {
                    ncuotaT += Convert.ToDecimal(pRow["ncuota"]);
                }

                foreach (DataRow tRow in _repoCA.CargarPlanCredito(cnumoperac, "P").Rows)
                {
                    ncuotaP += Convert.ToDecimal(tRow["ncuota"]);
                }

                row.Cells["Transito"].Value = ncuotaT;
                row.Cells["Pendientes"].Value = ncuotaP;
            }

        }
        private void cargarDgvAutorizados()
        {
            try
            {
                cAAutorizadosCreditoAsocSelBindingSource.DataMember = "";
                cAAutorizadosCreditoAsocSelBindingSource.DataSource = _repoCA.CargarAutorizadosCredito(cidasociad);
                dgvAutorizados.DataSource = cAAutorizadosCreditoAsocSelBindingSource;
            }
            catch (Exception)
            {

            }
        }
        public void calcularProdCred()
        {
            decimal nmtocuotar = 0, nmtoprinci = 0, nmtointere = 0, total = 0,
                    ncuotapres = 0, nsaldocred = 0, TotalAhorroNav = 0, enTransito = 0, pendientes = 0;

            foreach (DataGridViewRow row in dgvProd.Rows)
            {
                nmtocuotar += decimal.Parse(row.Cells["nmtocuotar"].Value.ToString());
                nmtoprinci += decimal.Parse(row.Cells["nmtoprinci"].Value.ToString());
                nmtointere += decimal.Parse(row.Cells["nmtointere"].Value.ToString());
                total += decimal.Parse(row.Cells["total"].Value.ToString());
                if (Convert.ToString(row.Cells["codigo"].Value) == "0003-001")
                    TotalAhorroNav += Convert.ToDecimal(string.Format("{0:n}", row.Cells["total"].Value));
            }
            lblTotalProd.Text = "Cuota: " + nmtocuotar.ToString("N2") + " | Saldo: "+ nmtoprinci.ToString("N2") + " | Interés: " + nmtointere.ToString("N2") + " | Total Ahorro: " + total.ToString("N2");
            
            foreach (DataGridViewRow row in dgvCred.Rows)
            {
                ncuotapres += decimal.Parse(row.Cells["ncuotapres"].Value.ToString());
                nsaldocred += decimal.Parse(row.Cells["nsaldocred"].Value.ToString());
                enTransito += Convert.ToDecimal($"{row.Cells["Transito"].Value:n}");
                pendientes += Convert.ToDecimal($"{row.Cells["Pendientes"].Value:n}");
            }
            TotalAport = total; 
            TotalCred = nsaldocred;
            lblPosFin.Text = "Total Créditos: " + nsaldocred.ToString("N2") + " | Tránsito: " + enTransito.ToString("N2") + " | Pendiente: " + pendientes.ToString("N2") + " | Total: " + (enTransito + pendientes).ToString("N2") + " | Posición Fin: " + ((TotalAport - TotalAhorroNav) - TotalCred).ToString("N2");
        }
        public void cargarImg()
        {
            Image img;

            try
            {
                using (var bmpTemp = new Bitmap(VarGlobales.dirFotosCarnets + cidasociad + ".JPG"))
                {
                    img = new Bitmap(bmpTemp);
                }
                ptbAsociado.Image = img;
            }
            catch (Exception ex)
            {
                try
                {
                    using (var bmpTemp = new Bitmap(VarGlobales.dirFotos + cidasociad + ".JPG"))
                    {
                        img = new Bitmap(bmpTemp);
                    }
                    ptbAsociado.Image = img;
                }
                catch (Exception)
                {
                    try
                    {
                        using (var bmpTemp = new Bitmap(VarGlobales.dirFotosCarnets + "no_image.JPG"))
                        {
                            img = new Bitmap(bmpTemp);
                        }
                        ptbAsociado.Image = img;
                    }
                    catch (Exception)
                    {
                        // Sin foto y sin no_image.JPG accesible: dejar el picturebox vacío en vez de tronar
                        ptbAsociado.Image = null;
                    }
                }
            }
        }
        public void frmInformacionAsoc_Load(object sender, EventArgs e)
        {
            cargarImg();
            System.Collections.Generic.Dictionary<string, string> header = _repoCA.ConsultarHeaderAsociado(cidasociad);

            validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

            if (validarPAConsul == 0)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnBloqDesbloq.Enabled = false;
            }
            else
                if (validarPAConsul == 1)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            if (validarPAConsul == 2)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }

            lblNombre.Text = header["cnombreaso"];
            lblDNI.Text = header["ccedulasoc"];
            lblInstitucion.Text = header["cnombinsti"];
            lblAreaTrab.Text = header["cnombdivis"];
            lblIdentificacion.Text = header["cidasociadOut"];
            lblIngresoInst.Text = header["dfechainga"];
            lblTiempoAfiliado.Text = header["anio"] + " años, " + header["mes"] + " meses, " + header["dia"] + " días";
            lblCondLab.Text = header["cnombconda"];
            lblNombBanco.Text = header["cnombinstb"];
            lblCtaBanc.Text = header["cctabancas"];

            cbocparentezc.SelectedIndex = 0;

            cargarDgv();
            cargarDgvAutorizados();
            calcularProdCred();
            cargarPanel(mktPIN.Text);
            mktPIN.Focus();
        }
        public void cargarPanel(string PIN)
        {
            validar = _repoCA.ValidarCarnetAsociado(cidasociad, PIN);

            if (validar == 0 || validar == 6)
            {
                gboPIN.Visible = false;
                gboOpciones.Visible = true;
                btnCrearPIN.Visible = true;
                btnCrearPIN.Dock = DockStyle.Fill;
                btnRenovarPIN.Visible = false;
                gboDetalles.Visible = false;
            }
            else
            if (validar == 1 && PIN != "")
            {
                gboPIN.Visible = true;
                gboOpciones.Visible = false;
                btnReportar.Visible = true;
                gboDetalles.Visible = true;
                btnActDesact.Visible = true;
                btnActDesact.Image = Properties.Resources.deactivate;
                btnActDesact.Text = "Desactivar";
                lblEstado.Text = "OK";
                lblEstado.ForeColor = Color.Green;
            }
            else
            if (validar == 2 && PIN != "")
            {
                gboPIN.Visible = true;
                gboOpciones.Visible = true;
                btnReportar.Visible = false;
                btnCrearPIN.Visible = false;
                btnRenovarPIN.Visible = true;
                btnRenovarPIN.Dock = DockStyle.Fill;
                gboDetalles.Visible = true;
                btnActDesact.Visible = true;
                btnActDesact.Image = Properties.Resources.deactivate;
                btnActDesact.Text = "Desactivar";
                MessageBox.Show("¡El PIN ha vencido!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblEstado.Text = "VENCIDO";
                lblEstado.ForeColor = Color.DarkRed;
            }
            else
            if (validar == 3 && PIN != "")
            {
                gboPIN.Visible = true;
                gboOpciones.Visible = false;
                btnReportar.Visible = false;
                btnCrearPIN.Visible = false;
                btnRenovarPIN.Visible = false;
                gboDetalles.Visible = true;                
                lblEstado.Text = "INACTIVO";
                lblEstado.ForeColor = Color.Red; 
                btnActDesact.Visible = false;
                validar = _repoCA.ValidarCarnetAsociado(cidasociad, "");
                
                if (validar == 8)
                {
                    btnActDesact.Visible = true;
                    btnActDesact.Image = Properties.Resources.activate;
                    btnActDesact.Text = "Activar";
                }
                MessageBox.Show("¡Este PIN está inactivo!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if ((validar == 4 || validar == 7) && PIN != "")
            {
                gboPIN.Visible = true;
                gboOpciones.Visible = false;
                gboDetalles.Visible = false;
                btnReportar.Visible = false;
                btnActDesact.Visible = false;
                if (validar == 4)
                {
                    MessageBox.Show("¡PIN inválido!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblEstado.Text = "INVALIDO";
                    lblEstado.ForeColor = Color.OrangeRed;
                }
                else
                {
                    MessageBox.Show("¡Este PIN ha sido Reportado como perdido!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblEstado.Text = "REPORTADO";
                    lblEstado.ForeColor = Color.Red;
                }
            }
            else
            if (validar == 5)
            {
                gboPIN.Visible = true;
                btnReportar.Visible = true;
                gboOpciones.Visible = false;
                gboDetalles.Visible = false;
                lblEstado.Text = "";
                btnActDesact.Visible = true;
                btnActDesact.Image = Properties.Resources.deactivate;
                btnActDesact.Text = "Desactivar";
            }
            else
            if (validar == 8)
            {
                gboPIN.Visible = true;
                btnReportar.Visible = false;
                gboOpciones.Visible = false;
                gboDetalles.Visible = false;
                lblEstado.Text = "";
                btnActDesact.Visible = true;
                btnActDesact.Image = Properties.Resources.activate;
                btnActDesact.Text = "Activar";
            }

            if (validar != 0 && validar != 5)
            {
                System.Collections.Generic.Dictionary<string, string> carnet = _repoCA.ConsultarCarnetAsociado(cidasociad, mktPIN.Text, true);

                dtpFecCrea.Value = ParseFechaODefault(carnet["ffechexped"]);
                dtpFecExp.Value = ParseFechaODefault(carnet["ffechvalid"]);
            }
        }

        /// <summary>Fecha del SP o la fecha actual si viene vacía/inválida (antes DateTime.Parse tronaba).</summary>
        private static DateTime ParseFechaODefault(string valor)
        {
            return DateTime.TryParse(valor, out DateTime fecha) ? fecha : DateTime.Now;
        }
        public void ImpSolicitud()
        {
            LocalReport rdlcEstadoCta = new LocalReport();
            rdlcEstadoCta.DataSources.Clear();
            rdlcEstadoCta.ReportEmbeddedResource = "ADIGGM.Informes.rptASMaestra.rdlc";

            rdlcEstadoCta.DataSources.Add(new ReportDataSource("DsASMaestras", _repoCodeas.CargarASMaestras(cidasociad)));
            rdlcEstadoCta.DataSources.Add(new ReportDataSource("DsEstadoCuenta", _repoCodeas.CargarEstadoCuenta(cidasociad)));
            rdlcEstadoCta.DataSources.Add(new ReportDataSource("DsEstadoCuentaDet", _repoCodeas.CargarEstadoCuentaDet(cidasociad)));

            ReportParameter[] ParametroEstado = new ReportParameter[1];
            ParametroEstado[0] = new ReportParameter("Usuario", VarGlobales.Usuario, false);
            rdlcEstadoCta.SetParameters(ParametroEstado);
            try
            {
                        string deviceInfo =
                        "<DeviceInfo>" +
                        " <OutputFormat>PDF</OutputFormat>" +
                        " <PageWidth>8.5in</PageWidth>" +
                        " <PageHeight>11in</PageHeight>" +
                        " <MarginTop>0.19685in</MarginTop>" +
                        " <MarginLeft>0in</MarginLeft>" +
                        " <MarginRight>0in</MarginRight>" +
                        " <MarginBottom>0.19685in</MarginBottom>" +
                        " <EmbedFonts>EmbedAll</EmbedFonts>" +
                        "</DeviceInfo>";

                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        byte[] bytes = rdlcEstadoCta.Render(
                           "PDF", deviceInfo, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Estado de Cuenta #" + cidasociad + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Estado de Cuenta #" + cidasociad + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rdbConSaldoProd_CheckedChanged(object sender, EventArgs e)
        {
            cargarDgv();
            calcularProdCred();
        }
        private void rdbTodosProd_CheckedChanged(object sender, EventArgs e)
        {
            cargarDgv();
            calcularProdCred();
        }
        private void rdbConSaldoCred_CheckedChanged(object sender, EventArgs e)
        {
            cargarDgv();
            calcularProdCred();
        }
        private void rdbTodosCred_CheckedChanged(object sender, EventArgs e)
        {
            cargarDgv();
            calcularProdCred();
        }
        // Método para establecer el estado de habilitación/deshabilitación de los controles en la ventana principal
        private void SetControlsEnabledState(bool isEnabled)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = isEnabled;
            }
        }
        private void btnDetProd_Click(object sender, EventArgs e)
        {
            if (dgvProd.CurrentRow == null)
                return;

            // Deshabilitar controles en la ventana principal
            SetControlsEnabledState(false);

            frmDetProducto detProducto = new frmDetProducto(Convert.ToString(dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["cdesdeducc"].Value.ToString()),
                                                            cidasociad,
                                                            Convert.ToString(dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["ccoddeducc"].Value.ToString()),
                                                            Convert.ToString(dgvProd.Rows[dgvProd.CurrentRow.Index].Cells["cnumdeducc"].Value.ToString()));
            // Suscribirse al evento Load de la ventana secundaria
            detProducto.Load += DetProducto_Load;

            detProducto.ShowDialog();
        }
        private void DetProducto_Load(object sender, EventArgs e)
        {
            // Habilitar controles en la ventana principal cuando la ventana secundaria se ha cargado completamente
            SetControlsEnabledState(true);
        }
        private void btnDetCred_Click(object sender, EventArgs e)
        {
            if (dgvCred.CurrentRow == null)
                return;

            // Deshabilitar controles en la ventana principal
            SetControlsEnabledState(false);

            frmDetCredito detCredito = new frmDetCredito(Convert.ToString(dgvCred.Rows[dgvCred.CurrentRow.Index].Cells["cnumoperac"].Value.ToString()), cidasociad);
            
            // Suscribirse al evento Load de la ventana secundaria
            detCredito.Load += DetCredito_Load;

            // Mostrar la ventana secundaria como un cuadro de diálogo
            detCredito.ShowDialog();
        }
        private void DetCredito_Load(object sender, EventArgs e)
        {
            // Habilitar controles en la ventana principal cuando la ventana secundaria se ha cargado completamente
            SetControlsEnabledState(true);
        }
        private void dgvProd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvProd.RowCount; i++)
            {
                if (dgvProd.Rows[i].Cells["cCODIGOGES"].Value.ToString() == "0000" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Green;// color del text
                }
                else
                if (dgvProd.Rows[i].Cells["cCODIGOGES"].Value.ToString() == "0001" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Blue;// color del text
                }
                else
                if (dgvProd.Rows[i].Cells["cCODIGOGES"].Value.ToString() == "0002" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Gray;// color del text
                }
                else
                if (dgvProd.Rows[i].Cells["cCODIGOGES"].Value.ToString() == "0003" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Orange;// color del text
                }
                else
                if (dgvProd.Rows[i].Cells["cCODIGOGES"].Value.ToString() == "0004" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Red;// color del text
                }
            }
        }
        private void dgvCred_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvCred.RowCount; i++)
            {
                if (dgvCred.Rows[i].Cells["ccodigogest"].Value.ToString() == "0000" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Green;// color del text
                }
                else
                if (dgvCred.Rows[i].Cells["ccodigogest"].Value.ToString() == "0001" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Blue;// color del text
                }
                else
                if (dgvCred.Rows[i].Cells["ccodigogest"].Value.ToString() == "0002" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Gray;// color del text
                }
                else
                if (dgvCred.Rows[i].Cells["ccodigogest"].Value.ToString() == "0003" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Orange;// color del text
                }
                else
                if (dgvCred.Rows[i].Cells["ccodigogest"].Value.ToString() == "0004" && e.RowIndex == i)
                {
                    e.CellStyle.ForeColor = Color.Red;// color del text
                }
            }
        }
        private void btnEstadoCta_Click(object sender, EventArgs e)
        {
            btnEstadoCta.Enabled = false;
            ImpSolicitud();
            btnEstadoCta.Enabled = true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frmBuscarAsociados"] != null)
            {
                Application.OpenForms["frmBuscarAsociados"].Activate();
            }
            else
            {
                frmBuscarAsociados buscarAsociados = new frmBuscarAsociados
                {
                    MdiParent = this
                };
                buscarAsociados.Show();
            }

            this.Close();
        }
        private void ptbAsociado_DoubleClick(object sender, EventArgs e)
        {
            frmFotoExpan fotoExpan = new frmFotoExpan(cidasociad);
            ptbAsociado.Image?.Dispose();
            ptbAsociado.Image = null;
            fotoExpan.ShowDialog();
            cargarPanel(mktPIN.Text);
            cargarImg();
        }
        private void btnCrearPIN_Click(object sender, EventArgs e)
        {
            frmTarjetas tarjetas = new frmTarjetas(cidasociad, lblNombre.Text, lblInstitucion.Text, lblAreaTrab.Text, DateTime.Now, DateTime.Now, "", false, false, false, false);
            ptbAsociado.Image?.Dispose();
            ptbAsociado.Image = null;
            tarjetas.ShowDialog();
            cargarImg();
            cargarPanel("");
        }
        private void frmInformacionAsoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            ptbAsociado.Image?.Dispose();
            ptbAsociado.Image = null;
        }
        private void btnRenovarPIN_Click(object sender, EventArgs e)
        {
            string cnombreaso = "", cnombinsti = "", cnombdivis = "", ffechexped = DateTime.Now.ToString("d"), ffechvalid = DateTime.Now.ToString("d");

            if (validar != 0 && validar != 5)
            {
                System.Collections.Generic.Dictionary<string, string> carnet = _repoCA.ConsultarCarnetAsociado(cidasociad, mktPIN.Text, true);
                cnombreaso = carnet["cnombreaso"]; cnombinsti = carnet["cnombinsti"]; cnombdivis = carnet["cnombdivis"];
                ffechexped = carnet["ffechexped"]; ffechvalid = carnet["ffechvalid"];
            }

            frmTarjetas tarjetas = new frmTarjetas(cidasociad, cnombreaso, cnombinsti,cnombdivis, ParseFechaODefault(ffechexped), ParseFechaODefault(ffechvalid), mktPIN.Text, true, false, false, false);
            ptbAsociado.Image?.Dispose();
            ptbAsociado.Image = null;
            tarjetas.ShowDialog();
            cargarPanel(mktPIN.Text);
            cargarImg();
        }
        private void btnReportar_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.Dictionary<string, string> carnet = _repoCA.ConsultarCarnetAsociado(cidasociad, "", true);

            frmTarjetas tarjetas = new frmTarjetas(cidasociad, carnet["cnombreaso"], carnet["cnombinsti"], carnet["cnombdivis"], ParseFechaODefault(carnet["ffechexped"]), ParseFechaODefault(carnet["ffechvalid"]), carnet["ccodigopinOUT"], false, true, false, false);
            ptbAsociado.Image?.Dispose();
            ptbAsociado.Image = null;
            tarjetas.ShowDialog();
            cargarPanel(mktPIN.Text);
            cargarImg();
        }
        private void mktPIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (mktPIN.Text != "")
                        {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            insert = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;

            btnNuevo.Enabled = false;
            btnBloqDesbloq.Enabled = false;
            dgvAutorizados.Enabled = false;
            btnEditar.Enabled = false;

            mktcidautoriz.Enabled = true;
            txtcnombreaut.Enabled = true;
            txtcdomicilio.Enabled = true;
            mktcnumtelefo.Enabled = true;
            cbocparentezc.Enabled = true;

            mktcidautoriz.Text = "";
            txtcnombreaut.Text = "";
            txtcdomicilio.Text = "";
            mktcnumtelefo.Text = "";
            cbocparentezc.SelectedIndex = -1;

            mktcidautoriz.Focus();

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAutorizados.CurrentRow == null)
                return;

            selectedIndex = dgvAutorizados.CurrentRow.Index;

            update = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;

            btnNuevo.Enabled = false;
            btnBloqDesbloq.Enabled = false;
            dgvAutorizados.Enabled = false;
            btnEditar.Enabled = false;

            txtcnombreaut.Enabled = true;
            txtcdomicilio.Enabled = true;
            mktcnumtelefo.Enabled = true;
            cbocparentezc.Enabled = true;
        }
        private void dgvAutorizados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        private void dgvProd_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        private void dgvCred_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        private void btnBloqDesbloq_Click(object sender, EventArgs e)
        {
            if (dgvAutorizados.CurrentRow == null)
                return;

            if (Convert.ToBoolean(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["bestaactiv"].Value) == true && validarPAConsul == 1)
            {
                _repoCA.ActualizarAutorizadoCredito(cidasociad, Convert.ToString(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["cidautoriz"].Value), "", false, "", "", "", "", true);
                btnBloqDesbloq.Image = Properties.Resources.security_unlock;
                //btnBloqDesbloq.Enabled = false;
            }
            else
            if (Convert.ToBoolean(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["bestaactiv"].Value) == false && validarPAConsul == 2)
            {
                _repoCA.ActualizarAutorizadoCredito(cidasociad, Convert.ToString(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["cidautoriz"].Value), "", true, "", "", "", "", true);
                btnBloqDesbloq.Image = Properties.Resources.security_lock;
                //btnBloqDesbloq.Enabled = true;
            }

            validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

            if (validarPAConsul == 0 || validarPAConsul == 2)
            {
                btnNuevo.Enabled = true;
            }
            else
                if (validarPAConsul == 1)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            cargarDgvAutorizados();
        }
        private void bloqDesbloq(int index)
        {
            var curRow = dgvAutorizados.CurrentRow;

            if (index == -1)
                index = curRow.Index;

            if (curRow != null)
            {
                mktcidautoriz.Text = Convert.ToString(dgvAutorizados.Rows[index].Cells["cidautoriz"].Value);
                txtcnombreaut.Text = Convert.ToString(dgvAutorizados.Rows[index].Cells["cnombreaut"].Value);
                txtcdomicilio.Text = Convert.ToString(dgvAutorizados.Rows[index].Cells["cdomicilio"].Value);
                mktcnumtelefo.Text = Convert.ToString(dgvAutorizados.Rows[index].Cells["cnumtelefo"].Value);
                cbocparentezc.SelectedItem = Convert.ToString(dgvAutorizados.Rows[index].Cells["cparentezc"].Value);

                if (validarPAConsul == 0)
                {
                    btnNuevo.Enabled = true;

                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBloqDesbloq.Enabled = false;
                }
                else
                if (validarPAConsul == 1)
                {
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;

                    if (Convert.ToBoolean(dgvAutorizados.Rows[index].Cells["bestaactiv"].Value) == true)
                    {
                        btnBloqDesbloq.Image = Properties.Resources.security_lock;
                        btnBloqDesbloq.Enabled = true;
                    }
                    else
                    if (Convert.ToBoolean(dgvAutorizados.Rows[index].Cells["bestaactiv"].Value) == false)
                    {
                        btnBloqDesbloq.Image = Properties.Resources.security_unlock;
                        btnBloqDesbloq.Enabled = false;
                    }
                }
                else
                if (validarPAConsul == 2 && Convert.ToBoolean(dgvAutorizados.Rows[index].Cells["bestaactiv"].Value) == false)
                {
                    btnNuevo.Enabled = true;
                    btnBloqDesbloq.Enabled = true;
                }
            }            
        }
        private void mktPIN_Leave(object sender, EventArgs e)
        {
                cargarPanel(mktPIN.Text);
        }

        private void btnVisorCarnets_Click(object sender, EventArgs e)
        {
            frmCarnetImp carnetImp = new frmCarnetImp();
            carnetImp.ShowDialog();
        }

        private void mktcidautoriz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (mktcidautoriz.Text != "")
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtcnombreaut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtcnombreaut.Text != "")
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtcdomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtcdomicilio.Text != "")
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void mktcnumtelefo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (mktcnumtelefo.Text != "")
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
            }
        }
        private void btnActDesact_Click(object sender, EventArgs e)
        {
            if(btnActDesact.Text == "Activar")
            {
                System.Collections.Generic.Dictionary<string, string> carnet = _repoCA.ConsultarCarnetAsociado(cidasociad, "", false);

                frmTarjetas tarjetas = new frmTarjetas(cidasociad, carnet["cnombreaso"], carnet["cnombinsti"], carnet["cnombdivis"], ParseFechaODefault(carnet["ffechexped"]), ParseFechaODefault(carnet["ffechvalid"]), carnet["ccodigopinOUT"], false, false, true, false);
                ptbAsociado.Image?.Dispose();
                ptbAsociado.Image = null;
                tarjetas.ShowDialog();
            }
            else
            if (btnActDesact.Text == "Desactivar")
            {
                System.Collections.Generic.Dictionary<string, string> carnet = _repoCA.ConsultarCarnetAsociado(cidasociad, "", true);

                frmTarjetas tarjetas = new frmTarjetas(cidasociad, carnet["cnombreaso"], carnet["cnombinsti"], carnet["cnombdivis"], ParseFechaODefault(carnet["ffechexped"]), ParseFechaODefault(carnet["ffechvalid"]), carnet["ccodigopinOUT"], false, false, false, true);
                ptbAsociado.Image?.Dispose();
                ptbAsociado.Image = null;
                tarjetas.ShowDialog();
            }
            cargarPanel(mktPIN.Text);
            cargarImg();
        }
        private void dgvAutorizados_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var curRow = dgvAutorizados.CurrentRow;
                if (curRow != null)
                {
                    bloqDesbloq(curRow.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            insert = false; update = false;

            if (validarPAConsul == 0 )
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
                if (validarPAConsul == 1)
            {
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
            if (validarPAConsul == 2)
            {
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }

            dgvAutorizados.Enabled = true;
            
            var curRow = dgvAutorizados.CurrentRow;

            if (curRow != null)
            {
                bloqDesbloq(curRow.Index);
            }

            mktcidautoriz.Enabled = false;
            txtcnombreaut.Enabled = false;
            txtcdomicilio.Enabled = false;
            mktcnumtelefo.Enabled = false;
            cbocparentezc.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mktcidautoriz.Text != "" &&  txtcnombreaut.Text != "" && txtcdomicilio.Text != "" && cbocparentezc.SelectedIndex >= 0)
            {
                validarPAInsert = _repoCA.ValidarAutorizadoCredito(cidasociad, mktcidautoriz.Text, true);

                var curRow = dgvAutorizados.CurrentRow;

                if (curRow != null)
                {
                    selectedIndex = dgvAutorizados.CurrentRow.Index;
                }

                if (validarPAInsert == 0)
                {
                    if (insert == true)
                    {
                        _repoCA.InsertarAutorizadoCredito(cidasociad, mktcidautoriz.Text, cbocparentezc.Text, txtcnombreaut.Text, txtcdomicilio.Text, mktcnumtelefo.Text, "");
                        MessageBox.Show("¡Registro guardado existosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        insert = false;

                        validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

                        cargarDgvAutorizados();

                        mktcidautoriz.Enabled = false;
                        txtcnombreaut.Enabled = false;
                        txtcdomicilio.Enabled = false;
                        mktcnumtelefo.Enabled = false;
                        cbocparentezc.Enabled = false;

                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnCancelar.Enabled = false;
                        dgvAutorizados.Enabled = true;

                        bloqDesbloq(0);
                    }
                }
                else
                    if (validarPAInsert == 1)
                {
                    if (insert == true)
                        MessageBox.Show("¡Existen registros activos, favor verificar!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (update == true)
                    {
                        _repoCA.ActualizarAutorizadoCredito(cidasociad, Convert.ToString(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["cidautoriz"].Value), cbocparentezc.Text, false, txtcnombreaut.Text, txtcdomicilio.Text, mktcnumtelefo.Text, "", false);

                        update = false;

                        validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

                        cargarDgvAutorizados();

                        dgvAutorizados.CurrentCell = dgvAutorizados.Rows[selectedIndex].Cells[1];

                        txtcnombreaut.Enabled = false;
                        txtcdomicilio.Enabled = false;
                        mktcnumtelefo.Enabled = false;
                        cbocparentezc.Enabled = false;

                        mktcidautoriz.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cidautoriz"].Value);
                        txtcnombreaut.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cnombreaut"].Value);
                        txtcdomicilio.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cdomicilio"].Value);
                        mktcnumtelefo.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cnumtelefo"].Value);
                        cbocparentezc.SelectedItem = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cparentezc"].Value);

                        MessageBox.Show("¡Registro actualizado existosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    dgvAutorizados.Enabled = true;

                    if (curRow != null)
                    {
                        bloqDesbloq(selectedIndex);
                    }
                }
                else
                    if (validarPAInsert == 2)
                {
                    if (insert == true)
                        MessageBox.Show("¡Esta persona ya se encuentra registrada, verifique e intentelo de nuevo!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (update == true)
                    {
                        _repoCA.ActualizarAutorizadoCredito(cidasociad, Convert.ToString(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["cidautoriz"].Value),
                            cbocparentezc.Text, false, txtcnombreaut.Text, txtcdomicilio.Text, mktcnumtelefo.Text, "", false);

                        MessageBox.Show("¡Registro actualizado existosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

                        cargarDgvAutorizados();

                        dgvAutorizados.CurrentCell = dgvAutorizados.Rows[selectedIndex].Cells[1];

                        mktcidautoriz.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cidautoriz"].Value);
                        txtcnombreaut.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cnombreaut"].Value);
                        txtcdomicilio.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cdomicilio"].Value);
                        mktcnumtelefo.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cnumtelefo"].Value);
                        cbocparentezc.SelectedItem = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cparentezc"].Value);
                    }

                    mktcidautoriz.Enabled = false;
                    txtcnombreaut.Enabled = false;
                    txtcdomicilio.Enabled = false;
                    mktcnumtelefo.Enabled = false;
                    cbocparentezc.Enabled = false;

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvAutorizados.Enabled = true;

                    if (curRow != null)
                    {
                        bloqDesbloq(curRow.Index);
                    }
                }
                else
                    if (validarPAInsert == 3)
                {
                    if (insert == true)
                    {
                        _repoCA.InsertarAutorizadoCredito(cidasociad, mktcidautoriz.Text, cbocparentezc.Text, txtcnombreaut.Text, txtcdomicilio.Text, mktcnumtelefo.Text, "");

                        insert = false;

                        mktcidautoriz.Enabled = false;

                        validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

                        cargarDgvAutorizados();

                    }
                    if (update == true)
                    {
                        _repoCA.ActualizarAutorizadoCredito(cidasociad, Convert.ToString(dgvAutorizados.Rows[dgvAutorizados.CurrentRow.Index].Cells["cidautoriz"].Value), cbocparentezc.Text, false, txtcnombreaut.Text, txtcdomicilio.Text, mktcnumtelefo.Text, "", false);

                        update = false;

                        validarPAConsul = _repoCA.ValidarAutorizadoCredito(cidasociad, "", false);

                        cargarDgvAutorizados();

                        dgvAutorizados.CurrentCell = dgvAutorizados.Rows[0].Cells[1];

                        mktcidautoriz.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cidautoriz"].Value);
                        txtcnombreaut.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cnombreaut"].Value);
                        txtcdomicilio.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cdomicilio"].Value);
                        mktcnumtelefo.Text = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cnumtelefo"].Value);
                        cbocparentezc.SelectedItem = Convert.ToString(dgvAutorizados.Rows[selectedIndex].Cells["cparentezc"].Value);
                    }

                    MessageBox.Show("¡Registro guardado existosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mktcidautoriz.Enabled = false;
                    txtcnombreaut.Enabled = false;
                    txtcdomicilio.Enabled = false;
                    mktcnumtelefo.Enabled = false;
                    cbocparentezc.Enabled = false;

                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvAutorizados.Enabled = true;
                } 
            }else
                MessageBox.Show("¡Ingrese toda la información!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void mktPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void btnPosFin_Click(object sender, EventArgs e)
        {
            // Deshabilitar controles en la ventana principal
            SetControlsEnabledState(false);

            frmPosFin posFin = new frmPosFin(lblNombre.Text, TotalAport, TotalCred);

            // Suscribirse al evento Load de la ventana secundaria
            posFin.Load += PosFin_Load;

            posFin.ShowDialog();
        }
        private void PosFin_Load(object sender, EventArgs e)
        {
            // Habilitar controles en la ventana principal cuando la ventana secundaria se ha cargado completamente
            SetControlsEnabledState(true);
        }
    }
}