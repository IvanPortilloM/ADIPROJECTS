using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using ADIGGM.Clases;
using ADIGGM.IA.Visores;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ADIGGM.IA.Visores
{
    public partial class frmCamara : FrmPrincipal
    {
        string cidasociad;
        int index;

        private bool hayDispositivos = false;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;
        public frmCamara(string cidasociad, int index)
        {
            InitializeComponent();
            this.cidasociad = cidasociad;
            this.index = index;
        }

        private void frmCamara_Load(object sender, EventArgs e)
        {
            cargarDispositivos();
            cboCamara.SelectedIndex = index;
            ptbFoto.Image.Dispose();
            ptbFoto.Image = null;
            string nombreVideo = misDispositivos[index].MonikerString;
            cerrarWebCam();
            miWebCam = new VideoCaptureDevice(nombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(capturando);
            miWebCam.Start();
            btnFotoCapt.Text = "Tomar Foto";
            cboCamara.Enabled = false;
            btnCancelar.Visible = true;
            btnGuardar.Visible = false;
        }
        private void cargarImg()
        {
            Image img;

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
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            cargarImg();
            cboCamara.Enabled = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = false;
            btnFotoCapt.Text = "Abrir Cámara";
            DialogResult = DialogResult.Cancel;
        }
        private void capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            ptbFoto.Image = imagen;
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
                btnCancelar.Visible = false;
                btnGuardar.Visible = true;
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
                btnCancelar.Visible = true;
                btnGuardar.Visible = false;
            }
        }
        private void frmCamara_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarWebCam();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;            
        }
    }
}
