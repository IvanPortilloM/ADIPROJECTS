using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.IA.Visores
{
    public partial class frmFotoExpan : FrmPrincipal
    {
        string cidasociad;
        public frmFotoExpan(string cidasociad)
        {
            InitializeComponent();
            this.cidasociad = cidasociad;
        }

        private void frmFotoExpan_Load(object sender, EventArgs e)
        {
            cargarImg();
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
                ptbFotoExpand.Image = img;
                ptbFotoExpand.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception exx)
            {
                try
                {
                    using (var bmpTemp = new Bitmap(VarGlobales.dirFotosCarnets + cidasociad + ".JPG"))
                    {
                        img = new Bitmap(bmpTemp);
                    }
                    ptbFotoExpand.Image = img;
                    ptbFotoExpand.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    try
                    {
                        using (var bmpTemp = new Bitmap(VarGlobales.dirFotos + cidasociad + ".JPG"))
                        {
                            img = new Bitmap(bmpTemp);
                        }
                        ptbFotoExpand.Image = img;
                        ptbFotoExpand.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception)
                    {
                        using (var bmpTemp = new Bitmap(VarGlobales.dirFotosCarnets + "no_image.JPG"))
                        {
                            img = new Bitmap(bmpTemp);
                        }
                        ptbFotoExpand.Image = img;
                        ptbFotoExpand.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }
    }
}
