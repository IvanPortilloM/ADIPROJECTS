using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using System.Diagnostics;
using System.Globalization;

namespace ADIGGM.SAC
{
    public partial class frmMenu : FrmPrincipal
    {
        private readonly RepositorioCA _repo = new RepositorioCA();

        string Tab = "";
        bool SubirFoto = false;

        public frmMenu()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas de los 3 grids (Desayuno/Almuerzo/Bocadillos, estructura idéntica) EN CÓDIGO
        /// para que el diseñador de VS no las borre — gotcha §11. Clave/Día/Tiempo son ReadOnly; Descripción/
        /// Fecha/Activo editables (el form no usa toggle dgv.ReadOnly, gatea por botón). El orden importa:
        /// Guardar lee celdas por índice (0=clave, 3=descripción, 4=fecha, 5=activo).</summary>
        private void ConfigurarColumnas()
        {
            ConfigurarGridMenu(dgvDesayuno, "");
            ConfigurarGridMenu(dgvAlmuerzo, "1");
            ConfigurarGridMenu(dgvBocadillos, "2");
        }

        private void ConfigurarGridMenu(DataGridView dgv, string sufijo)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(GridColumnas.Texto("nconsemenu" + sufijo, "nconsemenu", "Clave", width: 66, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader));
            var colDia = GridColumnas.Combo("nnumdiasem" + sufijo, "nnumdiasem", "Día", "cnomdiasem", "nnumdiasem", width: 50, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells);
            colDia.DataSource = cFDiasSemBindingSource;
            dgv.Columns.Add(colDia);
            var colTiempo = GridColumnas.Combo("nnumtiempo" + sufijo, "nnumtiempo", "Tiempo", "ctiempocom", "nnumtiempo", width: 71, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells);
            colTiempo.DataSource = cFTiempoComBindingSource;
            dgv.Columns.Add(colTiempo);
            dgv.Columns.Add(GridColumnas.Texto("cnomcomida" + sufijo, "cnomcomida", "Descripción del tiempo de comida", autoSize: DataGridViewAutoSizeColumnMode.Fill, readOnly: false));
            dgv.Columns.Add(GridColumnas.Texto("dfechacrea" + sufijo, "dfechacrea", "Fecha", width: 66, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells, readOnly: false));
            dgv.Columns.Add(GridColumnas.Check("bestaactiv" + sufijo, "bestaactiv", "Activo", width: 48, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader, readOnly: false));
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            string tiempo = tbMenu.SelectedTab.Text;

            // Catálogos de las columnas combo ANTES de enlazar los grids
            cFTiempoComBindingSource.DataMember = "";
            cFTiempoComBindingSource.DataSource = _repo.ListarTiemposComida();
            cFDiasSemBindingSource.DataMember = "";
            cFDiasSemBindingSource.DataSource = _repo.ListarDiasSemana();

            CargarGridsMenu(tiempo);
            CargarImagenTiempo(tiempo);
            CargarReporte(tiempo);

            rvMenu.RefreshReport();
            rvMenu.SetDisplayMode(DisplayMode.PrintLayout);
            rvMenu.ZoomMode = ZoomMode.Percent;
            rvMenu.ZoomPercent = 75;
        }

        /// <summary>Llena los 3 grids con el menú del tiempo indicado (tablas independientes, como los 3 Fill originales).</summary>
        private void CargarGridsMenu(string tiempo)
        {
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            cFMenuBindingSource.DataMember = "";
            cFMenuBindingSource.DataSource = _repo.CargarMenuComedor(tiempo);
            dgvDesayuno.DataSource = cFMenuBindingSource;
            cFMenu1BindingSource.DataMember = "";
            cFMenu1BindingSource.DataSource = _repo.CargarMenuComedor(tiempo);
            dgvAlmuerzo.DataSource = cFMenu1BindingSource;
            cFMenu2BindingSource.DataMember = "";
            cFMenu2BindingSource.DataSource = _repo.CargarMenuComedor(tiempo);
            dgvBocadillos.DataSource = cFMenu2BindingSource;
        }

        /// <summary>Muestra la imagen del tiempo de comida (sin imagen => picturebox vacío; antes tronaba con NULL).</summary>
        private void CargarImagenTiempo(string tiempo)
        {
            byte[] imgData = _repo.ObtenerImagenTiempoComida(tiempo);

            if (imgData == null || imgData.Length == 0)
            {
                ptbTiempoCom.Image = null;
                return;
            }

            // El stream debe seguir vivo mientras exista la imagen (GDI+); no usar using aquí
            MemoryStream ms = new MemoryStream(imgData);
            ptbTiempoCom.Image = Image.FromStream(ms, true);
        }

        private void CargarReporte(string tiempo)
        {
            cFSelectMenuBindingSource.DataMember = "";
            cFSelectMenuBindingSource.DataSource = _repo.CargarMenuReporte(tiempo);
            cFImgenMenuBindingSource.DataMember = "";
            cFImgenMenuBindingSource.DataSource = _repo.ListarImagenesMenu();
        }

        public byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SubirFoto == true)
                {
                    byte[] byteArrayImagen = ImageToByteArray(ptbTiempoCom.Image);
                    _repo.ActualizarImagenTiempoComida(tbMenu.SelectedTab.Text, byteArrayImagen);
                }

                string CtrlDgv = "";
                if (Tab == "Desayuno")
                {
                    CtrlDgv = "dgvDesayuno";
                }
                else if (Tab == "Almuerzo")
                {
                    CtrlDgv = "dgvAlmuerzo";
                }
                else if (Tab == "Bocadillos")
                {
                    CtrlDgv = "dgvBocadillos";
                }

                Control[] Dgv = Controls.Find(CtrlDgv, true);
                if (Dgv.Length > 0 && Dgv[0] is DataGridView dgv)
                {
                    dgv.EndEdit(); // confirma la celda en edición (antes el último cambio podía perderse)

                    var filas = new List<(int Consecutivo, string Comida, DateTime Fecha, bool Activo)>();
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow)
                            continue;
                        filas.Add((int.Parse(row.Cells[0].Value.ToString()),
                                   row.Cells[3].Value.ToString(),
                                   Convert.ToDateTime(row.Cells[4].Value.ToString()),
                                   bool.Parse(row.Cells[5].Value.ToString())));
                    }
                    _repo.ActualizarMenuComedor(filas); // en UNA transacción
                }

                CargarReporte(tbMenu.SelectedTab.Text);
                rvMenu.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los cambios del menú: " + ex.Message,
                    VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnFotoArch.Enabled = false;
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
                CargarGridsMenu(tbMenu.SelectedTab.Text);
                CargarImagenTiempo(tbMenu.SelectedTab.Text);
            }
            else if (Tab == "Desayuno")
            {
                tbMenu.SelectedTab = tpDesayuno;
            }
            else if (Tab == "Almuerzo")
            {
                tbMenu.SelectedTab = tpAlmuerzo;
            }
            else if (Tab == "Bocadillos")
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

            CargarGridsMenu(tbMenu.SelectedTab.Text);
            CargarImagenTiempo(tbMenu.SelectedTab.Text);
            ptbTiempoCom.SizeMode = PictureBoxSizeMode.Zoom;

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

                    // El formato corresponde al filtro elegido (antes PNG exportaba JPG y BMP exportaba PNG)
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            formato = "PNG";
                            break;

                        case 2:
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
