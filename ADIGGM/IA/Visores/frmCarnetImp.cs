using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Office;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.IA.Visores
{
    public partial class frmCarnetImp : FrmPrincipal
    {
        private readonly RepositorioCA _repo = new RepositorioCA();
        string dirFotosCarnets = @"\" + Clases.VarGlobales.dirFotosCarnets.Replace(@"\\",@"\");
        bool selectAllOff = true;
        public frmCarnetImp()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Visor; la columna "select" es un checkbox NO enlazado y editable (marcar/desmarcar).
        /// Se conservan los Name exactos: el Export a Excel usa Columns[i].Name como cabecera y filtra por nombre.</summary>
        private void ConfigurarColumnas()
        {
            dgvCarnetsImp.AutoGenerateColumns = false;
            dgvCarnetsImp.Columns.Clear();
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("name", "name", "Nombre", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("code", "code", "PIN", width: 51, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("number", "number", "Identidad", width: 88, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("barcode", "barcode", "Código.Barra", visible: false, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("company", "company", "Dependencia", width: 109, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("dept", "dept", "Departamento", width: 114, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("provided", "provided", "Fecha.Creación", width: 120, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("image", "image", "Ruta.Imagen", visible: false, autoSize: DataGridViewAutoSizeColumnMode.Fill));
            var colSelect = Clases.GridColumnas.Check("select", "", "Selecc.", width: 53, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader, readOnly: false);
            colSelect.DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter, NullValue = "False" };
            dgvCarnetsImp.Columns.Add(colSelect);
            dgvCarnetsImp.Columns.Add(Clases.GridColumnas.Texto("nconsecarn", "nconsecarn", "nconsecarn", visible: false));
        }
        public void ExportarExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Hoja1";

            // Cabeceras
            for (int i = 0; i < dgvCarnetsImp.Columns.Count; i++)
            {
                if (i >= 0 && i < dgvCarnetsImp.Columns.Count && dgvCarnetsImp.Columns[i].Name != "select" && dgvCarnetsImp.Columns[i].Name != "nconsecarn")
                {
                    worksheet.Cells[1, i + 1] = dgvCarnetsImp.Columns[i].Name;
                }
            }
            // Valores
            for (int i = 0; i < dgvCarnetsImp.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvCarnetsImp.Rows[i].Cells["select"].Value) == true) {
                    for (int j = 0; j < dgvCarnetsImp.Columns.Count; j++)
                    {
                        if (dgvCarnetsImp.Columns[j].Name != "select" && dgvCarnetsImp.Columns[j].Name != "nconsecarn")
                        {
                            if (dgvCarnetsImp.Columns[j].Name == "code" || dgvCarnetsImp.Columns[j].Name == "barcode" || dgvCarnetsImp.Columns[j].Name == "number" || dgvCarnetsImp.Columns[j].Name == "provided")
                                worksheet.Cells[i + 2, j + 1] = "'" + dgvCarnetsImp.Rows[i].Cells[j].Value.ToString();
                            else
                                worksheet.Cells[i + 2, j + 1] = dgvCarnetsImp.Rows[i].Cells[j].Value.ToString();
                        }
                    } 
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = String.Format("Exported_{0:yyyyMMdd_HHmmfff}", DateTime.Now);
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            else
            {
                workbook.Close(false); // al cancelar, no dejar el libro abierto
            }
            // Quit SIEMPRE: antes, cancelar el diálogo dejaba un Excel.exe huérfano en memoria
            app.Quit();
        }
        private void frmCarnetImp_Load(object sender, EventArgs e)
        {
            cargarDgv();

            foreach (DataGridViewRow row in dgvCarnetsImp.Rows)
            {
                row.Cells["select"].Value = false;
            }
        }
        private void dgvCarnetsImp_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportarExcel();
            btnImpCarnets.Enabled = true;
            dgvCarnetsImp.Enabled = false;
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            marcar();
        }
        private void marcar()
        {
            int rowcount = dgvCarnetsImp.Rows.Count;

            if (selectAllOff == true && rowcount > 0)
            {
                foreach (DataGridViewRow row in dgvCarnetsImp.Rows)
                {
                    row.Cells["select"].Value = true;
                }
                btnImp.Image = Properties.Resources.select_all_on;
                selectAllOff = false;
            }
            else
            if (selectAllOff == false && rowcount > 0)
            {
                foreach (DataGridViewRow row in dgvCarnetsImp.Rows)
                {
                    row.Cells["select"].Value = false;
                }
                btnImp.Image = Properties.Resources.select_all_off;
                selectAllOff = true;
            }
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarDgv();
        }
        private void cargarDgv()
        {
            cACarnetsAsocImpBindingSource.DataMember = "";
            cACarnetsAsocImpBindingSource.DataSource = _repo.CargarCarnetsImprimir(dirFotosCarnets);
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvCarnetsImp.DataSource = cACarnetsAsocImpBindingSource;
            btnImpCarnets.Enabled = false;
            selectAllOff = false;
            marcar();
        }
        private void btnImpCarnets_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvCarnetsImp.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["select"].Value) == true)
                    {
                        _repo.MarcarCarnetExportado(Convert.ToInt32(row.Cells["nconsecarn"].Value));
                    }
                }
            }
            catch (Exception ex)
            {
                // Antes un fallo a media lista tumbaba el form; la recarga muestra lo que sí se marcó
                MessageBox.Show("No se pudieron marcar todos los carnets: " + ex.Message,
                    Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarDgv();
            dgvCarnetsImp.Enabled = true;
        }
    }
}