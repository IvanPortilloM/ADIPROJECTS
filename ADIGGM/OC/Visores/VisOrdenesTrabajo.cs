using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.DataSetsWeb.DsOCWebTableAdapters;
using MySqlX.XDevAPI.Relational;

namespace ADIGGM.OC.Visores
{
    public partial class VisOrdenesTrabajo : FrmPrincipal
    {
        int selectedIndex;
        private DateTimePicker dtp = new DateTimePicker();
        DateTime selectedDate = DateTime.Now.Date;
        public VisOrdenesTrabajo()
        {
            InitializeComponent();

            ToolStripControlHost host = new ToolStripControlHost(dtp);
            contextMenuStrip1.Items.Add(host);

            // Configurar el formato del DateTimePicker a una fecha corta
            dtp.Format = DateTimePickerFormat.Short;

            // Agregar evento ValueChanged al DateTimePicker
            dtp.ValueChanged += Dtp_ValueChanged;
        }
        // Mostrar el DateTimePicker cuando se hace clic con el botón derecho en una celda
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // Asegurarse de que se ha hecho clic en una celda (no en el encabezado)
            if (dgvOC.CurrentCell != null)
            {
                // Mostrar el DateTimePicker
                dtp.Visible = true;
            }
            else
            {
                // Cancelar la apertura del ContextMenuStrip si no se hizo clic en una celda
                e.Cancel = true;
            }
        }
        private static readonly HttpClient client = new HttpClient();

        // Manejar el evento ValueChanged del DateTimePicker
        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            // Almacenar la fecha seleccionada en una variable de clase
            selectedDate = dtp.Value.Date;
        }
        private void VisOrdenesTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_VehiculosTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_Vehiculos);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillByTodos(this.dsOC.OC_Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_TipoOC' Puede moverla o quitarla según sea necesario.
            this.oC_TipoOCTableAdapter.FillByTodos(this.dsOC.OC_TipoOC);

            this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));

            rdbTodo.Visible = false;
            rdbProxVencer.Visible = false; 

            if (dgvOC.Rows.Count > 0)
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (cboTipoOC.Text == "REQUISICIÓN")
            {   
                // Hacer una columna invisible
                dgvOC.Columns["fechaEstimada"].Visible = true;

                if (rdbTodo.Checked == true)
                {
                    // Llenar el DataGridView
                    this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
                    
                    dgvOC.Sort(dgvOC.Columns["Correlativo"], ListSortDirection.Ascending);

                    // Filtrar los datos
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvOC.DataSource;
                    bs.Filter = "confirmado = False OR confirmado = True";
                    dgvOC.DataSource = bs;
                }
                else
                if (rdbProxVencer.Checked == true)
                {
                    // Llenar el DataGridView
                    this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, DateTime.MinValue.Date, DateTime.Now.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));

                    // Ordenar los datos por fecha (de más reciente a más antiguo)
                    dgvOC.Sort(dgvOC.Columns["fechaEstimada"], ListSortDirection.Descending);

                    // Filtrar los datos para mostrar solo las filas donde el checkbox está desmarcado
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvOC.DataSource;
                    bs.Filter = "confirmado = False";
                    dgvOC.DataSource = bs;
                }
            }
            else
            {
                this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
                // Hacer una columna invisible
                dgvOC.Columns["fechaEstimada"].Visible = false;
            }

            if (dgvOC.Rows.Count > 0)
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
        }

        private void dgvOC_SelectionChanged(object sender, EventArgs e)
        {
            decimal isv = 0, total = 0;
            if (dgvOC.Rows.Count > 0)
            {
                
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
                foreach (DataGridViewRow row in dgvOCDet.Rows)
                {
                    isv += (row.Cells["iSV"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["iSV"].Value.ToString()));
                    total += row.Cells["total"].Value.ToString() == string.Empty ? 0 : decimal.Parse(row.Cells["total"].Value.ToString());
                }
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
            lblTotalDetalle.Text = "Subtotal: " + (total-isv).ToString("N2") + " ISV: " + isv.ToString("N2") + " Total: " + total.ToString("N2");
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                selectedIndex = dgvOC.CurrentRow.Index;
                if (MessageBox.Show("Seguro desea anular esta Orden?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    VarGlobales.consultasOC.OC_OrdenTrabajoAnular(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()), VarGlobales.Usuario, Environment.MachineName);
                    this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));

                    dgvOC.CurrentCell = dgvOC.Rows[selectedIndex].Cells[1];
                    this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
                }
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
        }
        private void dgvOC_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Items[0].Visible = false;
                    contextMenuStrip1.Items[1].Visible = false;
                    contextMenuStrip1.Items[2].Visible = false;
                    contextMenuStrip1.Items[3].Visible = false;
                    contextMenuStrip1.Items[4].Visible = false;
                    contextMenuStrip1.Items[5].Visible = false;
                    contextMenuStrip1.Items[7].Visible = true;
                    contextMenuStrip1.Items[8].Visible = true;
                    dtp.Visible = false;

                    int Autorizado = int.Parse(VarGlobales.consultasOC.OC_ObtenerAutorizado(VarGlobales.Usuario.ToString()).ToString());
                    
                    if (bool.Parse(this.dgvOC.CurrentRow.Cells["anulado"].Value.ToString()) == true)
                    {
                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = false;
                        contextMenuStrip1.Items[3].Visible = false;
                        contextMenuStrip1.Items[4].Visible = false;
                        contextMenuStrip1.Items[5].Visible = false;
                        dtp.Visible = false;
                    }
                    else if (bool.Parse(this.dgvOC.CurrentRow.Cells["anulado"].Value.ToString()) == false && bool.Parse(this.dgvOC.CurrentRow.Cells["confirmado"].Value.ToString()) == false && bool.Parse(this.dgvOC.CurrentRow.Cells["Autorizado"].Value.ToString()) == false && Autorizado > 0)
                    {
                        if (this.dgvOC.CurrentRow.Cells["tipoOC"].Value.ToString() != "REQUISICIÓN")
                        {
                            contextMenuStrip1.Items[0].Visible = true;
                            contextMenuStrip1.Items[2].Visible = true;
                            contextMenuStrip1.Items[5].Visible = true;
                        }
                        else
                        {
                            contextMenuStrip1.Items[3].Visible = true;
                            contextMenuStrip1.Items[7].Visible = false;
                            contextMenuStrip1.Items[8].Visible = false;
                            //dtp.Visible = true;
                        }

                        contextMenuStrip1.Items[1].Visible = true;
                        contextMenuStrip1.Items[4].Visible = false;
                    }
                    else if (bool.Parse(this.dgvOC.CurrentRow.Cells["anulado"].Value.ToString()) == false && bool.Parse(this.dgvOC.CurrentRow.Cells["confirmado"].Value.ToString()) == false && bool.Parse(this.dgvOC.CurrentRow.Cells["Autorizado"].Value.ToString()) == true)
                    {
                        if (this.dgvOC.CurrentRow.Cells["tipoOC"].Value.ToString() != "REQUISICIÓN")
                        {
                            contextMenuStrip1.Items[0].Visible = true;
                            contextMenuStrip1.Items[2].Visible = true;
                            contextMenuStrip1.Items[5].Visible = true;
                        }
                        else
                        {
                            contextMenuStrip1.Items[3].Visible = true;
                            contextMenuStrip1.Items[7].Visible = false;
                            contextMenuStrip1.Items[8].Visible = false;
                            //dtp.Visible = true;
                        }

                        contextMenuStrip1.Items[1].Visible = true;
                        contextMenuStrip1.Items[4].Visible = false;
                    }
                    else if (bool.Parse(this.dgvOC.CurrentRow.Cells["anulado"].Value.ToString()) == false && bool.Parse(this.dgvOC.CurrentRow.Cells["confirmado"].Value.ToString()) == false && bool.Parse(this.dgvOC.CurrentRow.Cells["Autorizado"].Value.ToString()) == false)
                    {
                        if (this.dgvOC.CurrentRow.Cells["tipoOC"].Value.ToString() != "REQUISICIÓN")
                        {
                            contextMenuStrip1.Items[0].Visible = true;
                            contextMenuStrip1.Items[2].Visible = true;
                        }
                        else
                        {
                            contextMenuStrip1.Items[3].Visible = true;
                            contextMenuStrip1.Items[7].Visible = false;
                            contextMenuStrip1.Items[8].Visible = false;
                            //dtp.Visible = true;
                        }

                        contextMenuStrip1.Items[1].Visible = true;
                        contextMenuStrip1.Items[4].Visible = false;
                        contextMenuStrip1.Items[5].Visible = false;
                    }
                    else if (bool.Parse(this.dgvOC.CurrentRow.Cells["confirmado"].Value.ToString()) == true && bool.Parse(this.dgvOC.CurrentRow.Cells["Autorizado"].Value.ToString()) == true)
                    {
                        if (this.dgvOC.CurrentRow.Cells["tipoOC"].Value.ToString() != "REQUISICIÓN")
                        {
                            contextMenuStrip1.Items[4].Visible = true;
                        }
                        else
                        {
                            contextMenuStrip1.Items[3].Visible = true;
                            dtp.Visible = true;
                        }

                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = false;
                        contextMenuStrip1.Items[5].Visible = false;
                    }
                    else if (bool.Parse(this.dgvOC.CurrentRow.Cells["confirmado"].Value.ToString()) == true && bool.Parse(this.dgvOC.CurrentRow.Cells["Autorizado"].Value.ToString()) == false && Autorizado > 0)
                    {
                        if (this.dgvOC.CurrentRow.Cells["tipoOC"].Value.ToString() != "REQUISICIÓN")
                        {
                            contextMenuStrip1.Items[5].Visible = true;
                        }

                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = false;
                        contextMenuStrip1.Items[4].Visible = false;

                    }
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                selectedIndex = dgvOC.CurrentRow.Index;
                Transacciones.TranOrdenCompra tranOrdenesTrabajo = new OC.Transacciones.TranOrdenCompra(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
                tranOrdenesTrabajo.ShowDialog(this);
                this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
                
                dgvOC.CurrentCell = dgvOC.Rows[selectedIndex].Cells[1];
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
        }

        private void confirmarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                selectedIndex = dgvOC.CurrentRow.Index;
                Transacciones.TranConfirmarOrden tranConfirmarOrden = new Transacciones.TranConfirmarOrden(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
                tranConfirmarOrden.ShowDialog(this);
                this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
                        
                dgvOC.CurrentCell = dgvOC.Rows[selectedIndex].Cells[1];
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Transacciones.TranOrdenCompra tranOrdenesTrabajo = new Transacciones.TranOrdenCompra(0);
            tranOrdenesTrabajo.ShowDialog(this);
            this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
            if (dgvOC.Rows.Count > 0)
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()),
                                                                                           dtpDesde.Value.Date.ToString(),
                                                                                           dtpHasta.Value.Date.ToString(),
                                                                                           0,
                                                                                           int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                                           "",
                                                                                           "",
                                                                                           "",
                                                                                           0,
                                                                                           0,
                                                                                           "",
                                                                                           true);
            reporte.ShowDialog();
        }

        private void autorizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                selectedIndex = dgvOC.CurrentRow.Index;
                if (MessageBox.Show("Seguro desea autorizar esta Orden?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    VarGlobales.consultasOC.OC_AutorizarOrden(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()), VarGlobales.Usuario, Environment.MachineName);

                    this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
               
                    dgvOC.CurrentCell = dgvOC.Rows[selectedIndex].Cells[1];
                    this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
                }
            }
            else
            {
                this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
            }
        }
        private bool CheckConnection(String URL)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        private void Solicitud(string Solicitud,string Motivo)
        {
            
                string IdOC = dgvOC.CurrentRow.Cells["IdOC"].Value.ToString();
                string Correlativo = dgvOC.CurrentRow.Cells["Correlativo"].Value.ToString();
                string TipoOrden = dgvOC.CurrentRow.Cells["tipoOC"].Value.ToString();
                string Proveedor = dgvOC.CurrentRow.Cells["nombreProveedor"].Value.ToString();
                DateTime Fecha = Convert.ToDateTime(dgvOC.CurrentRow.Cells["fecha"].Value.ToString());
                string Accion = Solicitud;
                string Usuario = VarGlobales.Usuario;

            if(CheckConnection("https://www.adiggm.hn/WebServiceXamarin/api/oc/get_purchaseorder.php") == true)
            {
                string url = "https://www.adiggm.hn/WebServiceXamarin/api/oc/insert_purchaseorder.php?"
                + "IdOC=" + IdOC
                + "&Correlativo=" + Correlativo
                + "&TipoOrden=" + TipoOrden
                + "&Proveedor=" + Proveedor
                + "&Fecha=" + Fecha.ToString("yyyy-MM-dd")
                + "&Accion=" + Accion
                + "&Motivo=" + Motivo
                + "&Usuario=" + Usuario;

                var json = new WebClient().DownloadString(url);

                if (json == "1")
                {
                    MessageBox.Show("La solicitud fue enviada satisfactoriamente, favor espere la confirmación", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Existe ya una solicitud en proceso para esta orden de compra, favor espera la confirmación de la solicitud anterior", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var sp =  Convert.ToString(VarGlobales.consultasOCWeb.OCWeb_OrdenCompraInsert(Convert.ToInt32(IdOC),Correlativo,TipoOrden,Proveedor,Fecha,Accion,Motivo,Usuario));

                if (sp == "1")
                {
                    MessageBox.Show("La solicitud fue enviada satisfactoriamente, favor espere la confirmación", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Existe ya una solicitud en proceso para esta orden de compra, favor espera la confirmación de la solicitud anterior", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }   
        private void solicitarReimpresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOCMotivo motivo = new FrmOCMotivo();
            AddOwnedForm(motivo);
            motivo.ShowDialog();
            if(motivo.btnEnviar.BackColor == Color.Green) 
            {
                Solicitud("REIMPRESIÓN", motivo.txtMotivo.Text);
            }
        }
        private void solicitarDesconfirmaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOCMotivo motivo = new FrmOCMotivo();
            AddOwnedForm(motivo);
            motivo.ShowDialog();            
            if (motivo.btnEnviar.BackColor == Color.Green)
            {
                Solicitud("DESCONFIRMAR", motivo.txtMotivo.Text);
            }
        }

        private void dgvOC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvOCDet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void confirmarReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea confirmar la reparación de esta unidad?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VarGlobales.consultasOC.OC_OrdenCompraUpdate(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()), "","",
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        0,
                                        VarGlobales.Usuario,
                                        Environment.MachineName,
                                        0,
                                        selectedDate.Date,
                                        0,
                                        0,
                                        false,
                                        0);
                if (dgvOCDet.Rows.Count > 0 && dgvOC.Rows.Count > 0)
                {
                    selectedIndex = dgvOC.CurrentRow.Index;
                    DataGridViewRow dgvOC1 = dgvOC.Rows[selectedIndex];
                    DataGridViewRow dgvOCDet1 = dgvOCDet.Rows[0];

                    var codveh = dgvOCDet1.Cells["vehiculo"].FormattedValue.ToString();
                    var fecha = Convert.ToDateTime(dgvOC1.Cells["fecha"].FormattedValue.ToString());
                    var fechaEst = Convert.ToDateTime(dgvOC1.Cells["fechaEstimada"].FormattedValue.ToString());
                    var correlativo = dgvOC1.Cells["Correlativo"].FormattedValue.ToString();
                    var obs = dgvOCDet1.Cells["DescripcionServicio"].FormattedValue.ToString();

                    enviarcorreo(codveh, fecha, fechaEst, selectedDate.Date, correlativo, obs);
                }
            }
        }
        private void enviarcorreo(string codveh, DateTime fecha, DateTime fechaEstimada, DateTime fechaConfirm, string correlativo, string obs)
        {
            // Creación del correo
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("serviciosadiggm@adiggm.hn", "Servidor A.D.I.-GGM");

            // Añadir destinatarios            
            mail.To.Add("dperdomo@adiggm.hn");
            mail.To.Add("jflores@adiggm.hn");
            mail.To.Add("nflores@adiggm.hn");
            mail.To.Add("fmercado@adiggm.hn");
            mail.To.Add("glrivera@granjasmarinas.com");
            mail.To.Add("jportillo@adiggm.hn");
            // Puedes agregar tantos destinatarios como desees.

            // Configuración del correo
            mail.Subject = "Reparación completada de la unidad: " + codveh;
            mail.IsBodyHtml = true;  // Esto permite el formato HTML

            mail.Body = $"<html><body><div style='text-align: center;'>" +
                        $"<h1>Detalles de la requisición</h1>" +
                        $"<table border='1' style='margin: 0 auto;'>" +
                        $"<tr><th>Consecutivo</th><th>Unidad</th><th>Fecha Ingreso</th><th>Fecha Estimada</th><th>Fecha Reparación</th><th>Dias Estimados</th><th>Dias Reparación</th><th>Diferencia</th><th>Descripción</th></tr>" +
                        $"<tr><td>{correlativo}</td><td>{codveh}</td><td>{fecha:d}</td><td>{fechaEstimada:d}</td><td>{fechaConfirm:d}</td><td>{(fechaEstimada - fecha).Days}</td><td>{(fechaConfirm - fecha).Days}</td><td>{(fechaEstimada - fechaConfirm).Days}</td><td>{obs}</td></tr>" +
                        $"</table></div></body></html>";

            // Creación del cliente SMTP
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("serviciosadiggm@adiggm.hn", "serviciosadi@2020");
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;

            // Enviar el correo
            client.Send(mail);
        }

        private void cboTipoOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbTodo.Visible = false;
            rdbProxVencer.Visible = false;

            if (cboTipoOC.Text == "REQUISICIÓN")
            {
                rdbTodo.Visible = true;
                rdbProxVencer.Visible = true;
            }
        }

        private void rdbProxVencer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProxVencer.Checked == true)
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }
            else
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
        }
    }
}
