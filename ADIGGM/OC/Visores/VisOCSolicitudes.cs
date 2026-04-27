namespace ADIGGM.OC.Visores
{
    using Newtonsoft.Json;
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using ADIGGM.Clases;
    using System.Net;
    using System.IO;
    using System.Threading.Tasks;
    using ADIGGM.OC.ViewModels;
    using System.Net.Cache;
    using Microsoft.Office.Interop.Excel;

    public partial class VisOCSolicitudes : FrmPrincipal
    {
        public VisOCSolicitudes()
        {
            InitializeComponent();
            rdbAutorizado.CheckedChanged += RadioButton_CheckedChanged;
            rdbEnProceso.CheckedChanged += RadioButton_CheckedChanged;
            rdbCompletado.CheckedChanged += RadioButton_CheckedChanged;

            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvOC);
        }
        private void VisOCSolicitudes_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            string seleccion;
            if (rdbAutorizado.Checked == true)
            {
                seleccion = "AUTORIZADO";
                btnCompletar.Enabled = true;
            }
            else
            if (rdbEnProceso.Checked == true)
            {
                seleccion = "EN PROCESO";
                btnCompletar.Enabled = false;
            }
            else
            {
                seleccion = "COMPLETADO";
                btnCompletar.Enabled = false;
            }

            _ = ConfigurarColumnasAsync(seleccion);
        }
        private async Task ConfigurarColumnasAsync(string seleccion)
        {
            string respuesta = await GetHttp(seleccion);
            List<OCWebViewModel> lst = JsonConvert.DeserializeObject<List<OCWebViewModel>>(respuesta);
            dgvOC.DataSource = null;
            dgvOC.DataSource = lst;

            dgvOC.Columns["IdOC_pk"].Visible = false;
            dgvOC.Columns["IdOC"].Visible = false;
            dgvOC.Columns["Usuario"].Visible = false;

            dgvOC.Columns["Correlativo"].HeaderText = "Orden";
            dgvOC.Columns["TipoOrden"].HeaderText = "Tipo de OC";
            dgvOC.Columns["FechaCreacion"].HeaderText = "Creado";
            dgvOC.Columns["FechaModificacion"].HeaderText = "Modificado";

            dgvOC.Columns["Correlativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.Columns["TipoOrden"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.Columns["Proveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOC.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.Columns["FechaCreacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.Columns["FechaModificacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.Columns["Accion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.Columns["Estado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOC.CurrentCell = dgvOC.Rows[0].Cells["Correlativo"];
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private void rdbEnProceso_CheckedChanged(object sender, EventArgs e)
        {
            cargar();
        }
        private void rdbAutorizado_CheckedChanged(object sender, EventArgs e)
        {
            cargar();
        }
        private void rdbCompletado_CheckedChanged(object sender, EventArgs e)
        {
            cargar();
        }
        public async Task<string> GetHttp(string seleccion)
        {
            try
            {
                string url = "https://www.adiggm.hn/WebServiceXamarin/api/oc/get_purchaseorder.php?Estado=" + seleccion;
                // Set a default policy level for the "http:" and "https" schemes.
                HttpRequestCachePolicy policy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
                HttpWebRequest.DefaultCachePolicy = policy;
                //---------------------------------------------

                WebRequest oRequest = WebRequest.Create(url);

                // Define a cache policy for this request only.
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                oRequest.CachePolicy = noCachePolicy;
                //---------------------------------------------

                WebResponse oResponse = oRequest.GetResponse();
                StreamReader sr = new StreamReader(oResponse.GetResponseStream());
                return await sr.ReadToEndAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private async void btnCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                var IdOC_pk = Convert.ToInt32(this.dgvOC.CurrentRow.Cells["IdOC_pk"].Value.ToString());

                if (IdOC_pk != 0)
                {
                    var Accion = this.dgvOC.CurrentRow.Cells["Accion"].Value.ToString();
                    var IdOC = Convert.ToInt32(this.dgvOC.CurrentRow.Cells["IdOC"].Value.ToString());
                    VarGlobales.consultasOC.OCW_OCCompletarAccion(IdOC, Accion);

                    string url = "https://www.adiggm.hn/WebServiceXamarin/api/oc/update_purchaseorder.php?Estado=COMPLETADO&IdOC_pk=" + IdOC_pk;

                    using (var client = new HttpClient(new HttpClientHandler()))
                    {
                        client.BaseAddress = new Uri(url);
                        client.DefaultRequestHeaders.IfModifiedSince = DateTime.UtcNow;
                        client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
                        {
                            NoCache = true
                        };
                        HttpResponseMessage response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                        await response.Content.ReadAsStringAsync();
                        MessageBox.Show("¡El proceso fue completado exitosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cargar();
                }
                else
                    MessageBox.Show("¡No hay ordenes para completar!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvOC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
