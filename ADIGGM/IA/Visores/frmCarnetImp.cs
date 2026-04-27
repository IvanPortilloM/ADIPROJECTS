using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Office;
using System.Windows.Forms;

namespace ADIGGM.IA.Visores
{
    public partial class frmCarnetImp : FrmPrincipal
    {
        string dirFotosCarnets = @"\" + Clases.VarGlobales.dirFotosCarnets.Replace(@"\\",@"\");
        bool selectAllOff = true;
        public frmCarnetImp()
        {
            InitializeComponent();
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
                app.Quit();
            }
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
            this.cA_CarnetsAsocImpTableAdapter.Fill(this.dsCA.CA_CarnetsAsocImp, dirFotosCarnets);
            btnImpCarnets.Enabled = false;
            selectAllOff = false;
            marcar();
        }
        private void btnImpCarnets_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCarnetsImp.Rows)
            {
                if (Convert.ToBoolean(row.Cells["select"].Value) == true)
                {
                    Clases.VarGlobales.consultasCA.CA_CarnetsAsocImpExpor(Convert.ToInt32(row.Cells["nconsecarn"].Value));
                }
            }
            cargarDgv();
            dgvCarnetsImp.Enabled = true;
        }
    }
}