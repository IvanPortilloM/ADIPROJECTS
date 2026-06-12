using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.IA.Visores;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ADIGGM.IA.Mantenimiento
{
    public partial class frmTarjetas : FrmPrincipal
    {
        string cidasociad, cnombreaso, cnombinsti, cnombdivis, ccodigopin;
        DateTime ffechexped, ffechvalid;
        bool renovar, reportar, activar, desactivar, modificaImg;

        private bool hayDispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;
        public frmTarjetas(string cidasociad, string cnombreaso, string cnombinsti, string cnombdivis, DateTime ffechexped, DateTime ffechvalid, string ccodigopin, bool renovar, bool reportar, bool activar, bool desactivar)
        {
            InitializeComponent();

            this.cidasociad = cidasociad;
            this.cnombreaso = cnombreaso;
            this.cnombinsti = cnombinsti;
            this.cnombdivis = cnombdivis;
            this.ffechexped = ffechexped;
            this.ffechvalid = ffechvalid;
            this.ccodigopin = ccodigopin;
            this.renovar = renovar;
            this.reportar = reportar;
            this.activar = activar;
            this.desactivar = desactivar;
        }
        private void frmTarjetas_Load(object sender, EventArgs e)
        {
            txtId.Text = cidasociad;
            if (renovar == true && reportar == false && activar == false && desactivar == false)
            {
                mktPIN.Text = ccodigopin;
                txtNombre.Text = cnombreaso;
                txtInst.Text = cnombinsti;
                txtAreaTrab.Text = cnombdivis;
                btnGuardar.Text = "Renovar";

                dtpFecCrea.Value = ffechexped;
                dtpFecExp.Value = ffechvalid;

                btnGenPIN.Visible = false;

                mktPIN.Enabled = false;
                dtpFecCrea.Enabled = false;

            }
            else
            if (renovar == false && reportar == true && activar == false && desactivar == false)
            {
                mktPIN.Text = ccodigopin;

                txtNombre.Text = cnombreaso;
                txtInst.Text = cnombinsti;
                txtAreaTrab.Text = cnombdivis;

                txtNombre.ReadOnly = true;
                txtInst.ReadOnly = true;
                txtAreaTrab.ReadOnly = true;

                lblFecCrea.Visible = false;
                lblFecExp.Visible = false;
                dtpFecCrea.Visible = false;
                dtpFecExp.Visible = false;
                btnFotoCapt.Visible = false;
                btnFotoArch.Visible = false;
                btnGenPIN.Visible = false;
                cboCamara.Visible = false;

                btnGuardar.Text = "Reportar";
            }
            else
            if (renovar == false && reportar == false && activar == true && desactivar == false)
            {
                mktPIN.Text = ccodigopin;

                txtNombre.Text = cnombreaso;
                txtInst.Text = cnombinsti;
                txtAreaTrab.Text = cnombdivis;

                txtNombre.ReadOnly = true;
                txtInst.ReadOnly = true;
                txtAreaTrab.ReadOnly = true;

                dtpFecExp.Value = ffechvalid;

                lblFecCrea.Visible = false;
                lblFecExp.Visible = false;
                dtpFecCrea.Visible = false;
                dtpFecExp.Visible = false;
                btnFotoCapt.Visible = false;
                btnFotoArch.Visible = false;
                btnGenPIN.Visible = false;
                cboCamara.Visible = false;

                btnGuardar.Text = "Activar";
            }
            else
            if (renovar == false && reportar == false && activar == false && desactivar == true)
            {
                mktPIN.Text = ccodigopin;

                txtNombre.Text = cnombreaso;
                txtInst.Text = cnombinsti;
                txtAreaTrab.Text = cnombdivis;

                txtNombre.ReadOnly = true;
                txtInst.ReadOnly = true;
                txtAreaTrab.ReadOnly = true;

                dtpFecExp.Value = ffechvalid;

                lblFecCrea.Visible = false;
                lblFecExp.Visible = false;
                dtpFecCrea.Visible = false;
                dtpFecExp.Visible = false;
                btnFotoCapt.Visible = false;
                btnFotoArch.Visible = false;
                btnGenPIN.Visible = false;
                cboCamara.Visible = false;

                btnGuardar.Text = "Desactivar";
            }
            else
            {
                txtNombre.Text = cnombreaso;
                txtInst.Text = cnombinsti;
                txtAreaTrab.Text = cnombdivis;
                dtpFecCrea.Enabled = false;
                btnGuardar.Enabled = false;
            }

            cargarImg();
            cargarDispositivos();
        }
        private void cargarImg()
        {
            Image img;
            try
            {
                using (var bmpTemp = new Bitmap(VarGlobales.tempVar.Replace(@"\\", @"\")))
                {
                    img = new Bitmap(bmpTemp);
                }
                ptbFoto.Image = img;
                ptbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception exx)
            {
                try
                {
                    using (var bmpTemp = new Bitmap(VarGlobales.dirFotosCarnets + cidasociad + ".JPG"))
                    {
                        img = new Bitmap(bmpTemp);
                    }
                    ptbFoto.Image = img;
                    ptbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    try
                    {
                        using (var bmpTemp = new Bitmap(VarGlobales.dirFotos + cidasociad + ".JPG"))
                        {
                            img = new Bitmap(bmpTemp);
                        }
                        ptbFoto.Image = img;
                        ptbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception)
                    {
                        using (var bmpTemp = new Bitmap(VarGlobales.dirFotosCarnets + "no_image.JPG"))
                        {
                            img = new Bitmap(bmpTemp);
                        }
                        ptbFoto.Image = img;
                        ptbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }
        public void cargarDispositivos()
        {
            try
            {
                misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (misDispositivos.Count > 0)
                {
                    hayDispositivos = true;
                    for (int i = 0; i < misDispositivos.Count; i++)
                        cboCamara.Items.Add(misDispositivos[i].Name.ToString());

                    cboCamara.SelectedIndex = 0;
                }
                else
                    hayDispositivos = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dispositivo de video no encontrado");
            }
        }
        public void cerrarWebCam()
        {
            if(miWebCam!=null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }
        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            ptbFoto.Image = imagen;
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (renovar == true && (txtNombre.Text != cnombreaso || modificaImg == true || txtInst.Text != cnombinsti || txtAreaTrab.Text != cnombdivis))
            {
                chkReimprimir.Visible = true;
                chkReimprimir.Checked = true;
            }
            else
            {
                chkReimprimir.Visible = false;
                chkReimprimir.Checked = false;
            }
        }
        private void txtInst_TextChanged(object sender, EventArgs e)
        {
            if (renovar == true && (txtInst.Text != cnombinsti || modificaImg == true || txtNombre.Text != cnombreaso || txtAreaTrab.Text != cnombdivis))
            {
                chkReimprimir.Visible = true;
                chkReimprimir.Checked = true;
            }
            else
            {
                chkReimprimir.Visible = false;
                chkReimprimir.Checked = false;
            }
        }
        private void txtAreaTrab_TextChanged(object sender, EventArgs e)
        {
            if (renovar == true && (txtAreaTrab.Text != cnombdivis || modificaImg == true || txtNombre.Text != cnombreaso || txtInst.Text != cnombinsti))
            {
                chkReimprimir.Visible = true;
                chkReimprimir.Checked = true;
            }
            else
            {
                chkReimprimir.Visible = false;
                chkReimprimir.Checked = false;
            }
        }
        private void btnExpandir_Click(object sender, EventArgs e)
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                int i = cboCamara.SelectedIndex;
                miWebCam.SignalToStop();
                miWebCam = null;
                ptbFoto.Image.Dispose();
                ptbFoto.Image = null;

                Timer timer1 = new Timer();
                timer1.Interval = 1000;
                timer1.Tick += (s, a) => {
                    ((Timer)s).Stop();
                    frmCamara camara = new frmCamara(cidasociad, i);
                    var result = camara.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        cargarImg();
                        btnFotoCapt.Text = "Abrir Cámara";
                        cboCamara.Enabled = true;
                        btnFotoArch.Enabled = true;
                        btnCancelar.Visible = false;
                        btnGuardar.Visible = true;
                    }
                    else
                    {
                        cargarImg();
                        btnFotoCapt.Text = "Abrir Cámara";
                        cboCamara.Enabled = true;
                        btnFotoArch.Enabled = true;
                        btnCancelar.Visible = false;
                        btnGuardar.Visible = true;
                    }
                };
                timer1.Start();
            }
            else
            {
                frmFotoExpan fotoExpan = new frmFotoExpan(cidasociad);
                ptbFoto.Image.Dispose();
                ptbFoto.Image = null;
                fotoExpan.ShowDialog();
                cargarImg();
            }            
        }

        private void dtpFecExp_ValueChanged(object sender, EventArgs e)
        {
            //if ((renovar == true && dtpFecExp.Value.Date == ffechvalid) || (renovar == false && dtpFecExp.Value.Date <= dtpFecCrea.Value.Date))
            //    btnGuardar.Enabled = false;
            //else 
            //if ((renovar == true && dtpFecExp.Value.Date != ffechvalid ) || (renovar == false && dtpFecExp.Value.Date > dtpFecCrea.Value.Date))
            //    btnGuardar.Enabled = true;
        }

        private void ptbFoto_DoubleClick(object sender, EventArgs e)
        {
            frmFotoExpan fotoExpan = new frmFotoExpan(cidasociad);
            ptbFoto.Image.Dispose();
            ptbFoto.Image = null;
            fotoExpan.ShowDialog();
            cargarImg();
        }

        private void btnFotoCapt_Click(object sender, EventArgs e)
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                string result = Path.GetTempPath();
                string imgTemp = String.Format("_{0:yyyyMMdd_HHmmfff}", DateTime.Now);
                ptbFoto.Image.Save(result + cidasociad + imgTemp + ".JPG", ImageFormat.Jpeg);
                VarGlobales.tempVar = result + cidasociad + imgTemp + ".JPG";
                miWebCam.SignalToStop();
                miWebCam = null;
                btnFotoCapt.Text = "Abrir Cámara";
                cboCamara.Enabled = true;
                btnFotoArch.Enabled = true;
                btnCancelar.Visible = false;
                btnGuardar.Visible = true;
                modificaImg = true;
                if (renovar == true)
                {
                    chkReimprimir.Visible = true;
                    chkReimprimir.Checked = true;
                }
            }
            else
            {
                ptbFoto.Image.Dispose();
                ptbFoto.Image = null;
                cerrarWebCam();
                int i = cboCamara.SelectedIndex;
                string nombreVideo = misDispositivos[i].MonikerString;
                miWebCam = new VideoCaptureDevice(nombreVideo);
                miWebCam.NewFrame += new NewFrameEventHandler(capturando);
                miWebCam.Start();
                btnFotoCapt.Text = "Tomar Foto";
                cboCamara.Enabled = false;
                btnFotoArch.Enabled = false;
                btnCancelar.Visible = true;
                btnGuardar.Visible = false;
            }
        }
        private void btnFotoArch_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Todos los archivos (*.*)|*.*";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Seleccione una imagen";
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            BuscarImagen.InitialDirectory = @"C:\\Users\\" + userName + "\\";
            BuscarImagen.FileName = this.lblRutaImg.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                ptbFoto.Image.Dispose();
                ptbFoto.Image = null;
                // Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                lblRutaImg.Text = BuscarImagen.FileName;
                //String Direccion = BuscarImagen.FileName;
                this.ptbFoto.Image = Image.FromFile(lblRutaImg.Text);

                modificaImg = true;
                if (renovar == true)
                {
                    chkReimprimir.Visible = true;
                    chkReimprimir.Checked = true;
                }
            }
        }
        private void frmTarjetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarWebCam();
            VarGlobales.tempVar = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            try
            {
                if ((txtNombre.Text == "" || txtInst.Text == "" || txtAreaTrab.Text == "" || dtpFecExp.Value.Date <= dtpFecCrea.Value.Date) && (reportar == false && activar == false && desactivar == false))
                {
                    if (dtpFecExp.Value.Date <= dtpFecCrea.Value.Date)
                        MessageBox.Show("¡La fecha de expiración no puede ser igual o menor que la fecha de creación!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("¡Ingrese todos los campos requeridos!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (File.Exists(VarGlobales.dirFotosCarnets + cidasociad + ".JPG"))
                    {
                        if (modificaImg == true)
                        {
                            File.Delete(VarGlobales.dirFotosCarnets + cidasociad + ".JPG");
                            ptbFoto.Image.Save(VarGlobales.dirFotosCarnets + cidasociad + ".JPG", ImageFormat.Jpeg);
                        }
                    }
                    else
                        ptbFoto.Image.Save(VarGlobales.dirFotosCarnets + cidasociad + ".JPG", ImageFormat.Jpeg);
                    int validar = 0;
                    var repoCA = new ADIGGM.CapaDatos.RepositorioCA();
                    if (renovar == false && reportar == false && activar == false && desactivar == false)
                        validar = repoCA.InsertarCarnetAsociado(txtId.Text, mktPIN.Text, txtNombre.Text, txtInst.Text, txtAreaTrab.Text, dtpFecCrea.Value.Date, dtpFecExp.Value.Date, cidasociad + ".JPG");
                    else if (renovar == true && reportar == false && activar == false && desactivar == false)
                        repoCA.ActualizarCarnetAsociado(cidasociad, ccodigopin, mktPIN.Text, txtNombre.Text, txtInst.Text, txtAreaTrab.Text, dtpFecExp.Value.Date, false, chkReimprimir.Checked, false);
                    else if (renovar == false && reportar == true && activar == false && desactivar == false)
                        repoCA.ActualizarCarnetAsociado(cidasociad, ccodigopin, mktPIN.Text, txtNombre.Text, txtInst.Text, txtAreaTrab.Text, dtpFecExp.Value.Date, true, false, false);
                    else if (renovar == false && reportar == false && activar == false && desactivar == true)
                        repoCA.ActualizarCarnetAsociado(cidasociad, ccodigopin, mktPIN.Text, txtNombre.Text, txtInst.Text, txtAreaTrab.Text, dtpFecExp.Value.Date, false, false, true);
                    else if (renovar == false && reportar == false && activar == true && desactivar == false)
                        repoCA.ActualizarCarnetAsociado(cidasociad, ccodigopin, mktPIN.Text, txtNombre.Text, txtInst.Text, txtAreaTrab.Text, dtpFecExp.Value.Date, false, false, false);

                    if (validar == 0)
                    {
                        MessageBox.Show("¡Los datos fueron guardados exitosamente!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("¡El PIN ya existe, intente generar uno nuevo!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Error al guardar la información!, posibles causas: " + ex,VarGlobales.nombreSistema,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            cargarImg();
            btnFotoCapt.Text = "Abrir Cámara";
            cboCamara.Enabled = true;
            btnFotoArch.Enabled = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = false;
        }
        private void btnGenPIN_Click(object sender, EventArgs e)
        {
            Random myObject = new Random();
            int ranNum = myObject.Next(0, 9999);
            mktPIN.Text = ranNum.ToString("D4");
            btnGuardar.Enabled = true;
        }              
    }
}