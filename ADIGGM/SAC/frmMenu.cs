using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using ADIGGM.Clases;
using System.Diagnostics;
using System.Globalization;

namespace ADIGGM.SAC
{
    public partial class frmMenu : FrmPrincipal
    {
        SqlConnection con;

        string Tab="";
        bool SubirFoto = false;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cF_MenuTableAdapter.FillByTiempo(dsCA.CF_Menu, tbMenu.SelectedTab.Text);
            cF_Menu1TableAdapter.FillByTiempo(dsCA.CF_Menu1, tbMenu.SelectedTab.Text);
            cF_Menu2TableAdapter.FillByTiempo(dsCA.CF_Menu2, tbMenu.SelectedTab.Text);
            cF_TiempoComTableAdapter.Fill(dsCA.CF_TiempoCom);
            cF_DiasSemTableAdapter.Fill(dsCA.CF_DiasSem);
            cF_ImgenMenuTableAdapter.Fill(dsCA.CF_ImgenMenu);

            Image newImage = null;

            byte[] imgData = (byte[])VarGlobales.consultasCA.CF_ImgTiempoCom(tbMenu.SelectedTab.Text);

            // Trata la información de la imagen para poder trasladarla al picturebox
            using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
            {
                ms.Write(imgData, 0, imgData.Length);
                newImage = Image.FromStream(ms, true);
            }

             ptbTiempoCom.Image = newImage;
            newImage = null;

            cF_SelectMenuTableAdapter.Fill(dsCA.CF_SelectMenu, tbMenu.SelectedTab.Text);
            rvMenu.RefreshReport();
            rvMenu.SetDisplayMode(DisplayMode.PrintLayout);
            rvMenu.ZoomMode = ZoomMode.Percent;
            rvMenu.ZoomPercent = 75;
        }
        public byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (SubirFoto == true)
            {
                byte[] byteArrayImagen = ImageToByteArray(ptbTiempoCom.Image);

                VarGlobales.consultasCA.CF_TiempoCom_UPD(tbMenu.SelectedTab.Text, byteArrayImagen);
            }

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnFotoArch.Enabled = false;

            string CtrlDgv = "";
            if (Tab == "Desayuno")
            {
                CtrlDgv = "dgvDesayuno";
            }else
                if (Tab == "Almuerzo")
            {
                CtrlDgv = "dgvAlmuerzo";
            }
            else
                if (Tab == "Bocadillos")
            {
                CtrlDgv = "dgvBocadillos";
            }

            Control[] Dgv = Controls.Find(CtrlDgv, true);

            DataGridView dgv = Dgv[0] as DataGridView;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                VarGlobales.consultasCA.CF_Menu_UPD(int.Parse(row.Cells[0].Value.ToString()),
                                                            row.Cells[3].Value.ToString(),
                                                            Convert.ToDateTime(row.Cells[4].Value.ToString()),
                                                            bool.Parse(row.Cells[5].Value.ToString()));
            }
            this.cF_SelectMenuTableAdapter.Fill(this.dsCA.CF_SelectMenu, tbMenu.SelectedTab.Text);
            this.cF_ImgenMenuTableAdapter.Fill(this.dsCA.CF_ImgenMenu);
            this.rvMenu.RefreshReport();
            Tab = "";
        }

        private void btnFotoArch_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*png)|*.jpg;*.jpeg;*.png";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                ptbTiempoCom.ImageLocation = getImage.FileName;
                ptbTiempoCom.SizeMode = PictureBoxSizeMode.Zoom;
                SubirFoto = true;
            }
            else
            {
                SubirFoto = false;
            }
        }
        private void tbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tab == "")
            {
                this.cF_MenuTableAdapter.FillByTiempo(this.dsCA.CF_Menu, tbMenu.SelectedTab.Text);
                this.cF_Menu1TableAdapter.FillByTiempo(this.dsCA.CF_Menu1, tbMenu.SelectedTab.Text);
                this.cF_Menu2TableAdapter.FillByTiempo(this.dsCA.CF_Menu2, tbMenu.SelectedTab.Text);

                Image newImage = null;

                byte[] imgData = (byte[])VarGlobales.consultasCA.CF_ImgTiempoCom(tbMenu.SelectedTab.Text);

                // Trata la información de la imagen para poder trasladarla al picturebox
                using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                {
                    ms.Write(imgData, 0, imgData.Length);
                    newImage = Image.FromStream(ms, true);
                }

                ptbTiempoCom.Image = newImage;
                newImage = null;
            } else
                if (Tab == "Desayuno") 
            {
                tbMenu.SelectedTab = tpDesayuno; 
            }
            else
                if (Tab == "Almuerzo")
            {
                tbMenu.SelectedTab = tpAlmuerzo;
            }
            else
                if (Tab == "Bocadillos")
            {
                tbMenu.SelectedTab = tpBocadillos;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnFotoArch.Enabled = true;

            Tab = tbMenu.SelectedTab.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnFotoArch.Enabled = false;

            this.cF_MenuTableAdapter.FillByTiempo(this.dsCA.CF_Menu, tbMenu.SelectedTab.Text);
            this.cF_Menu1TableAdapter.FillByTiempo(this.dsCA.CF_Menu1, tbMenu.SelectedTab.Text);
            this.cF_Menu2TableAdapter.FillByTiempo(this.dsCA.CF_Menu2, tbMenu.SelectedTab.Text);

            Image newImage = null;

            byte[] imgData = (byte[])VarGlobales.consultasCA.CF_ImgTiempoCom(tbMenu.SelectedTab.Text);

            // Trata la información de la imagen para poder trasladarla al picturebox
            using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
            {
                ms.Write(imgData, 0, imgData.Length);
                newImage = Image.FromStream(ms, true);
            }

            ptbTiempoCom.Image = newImage;
            ptbTiempoCom.SizeMode = PictureBoxSizeMode.Zoom;
            newImage = null;

            Tab = "";
        }

        private void dgvAlmuerzo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvBocadillos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvDesayuno_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp";
                saveFileDialog1.Title = "Guardar archivo de imagen";
                saveFileDialog1.ShowDialog();
                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    string formato = "";

                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            formato = "JPG";
                            break;

                        case 2:
                            formato = "PNG";
                            break;

                        case 3:
                            formato = "BMP";
                            break;
                    }
                    Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                    var byts = rvMenu.LocalReport.Render("Image", "<DeviceInfo><OutputFormat>" + formato + "</OutputFormat><EmbedFonts>EmbedAll</EmbedFonts></DeviceInfo>",
                         out mimeType, out encoding, out extension, out streamids, out warnings);
                    File.WriteAllBytes(saveFileDialog1.FileName.ToString(), byts);
                }
            }
            
        }
    }
}