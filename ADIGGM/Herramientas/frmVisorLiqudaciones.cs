using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ADIGGM.Herramientas
{
    public partial class frmVisorLiqudaciones : FrmPrincipal
    {
        // Cadena de conexión a la base de datos
        string cadenaConexion = ADIGGM.CapaDatos.Conexion.Cadena("Covibase");
        public frmVisorLiqudaciones()
        {
            InitializeComponent();
        }
        private void LlenarDataGridView(DateTime dfechainic, DateTime dfechafin, string creversada, string cstaliquid, string ctipodocum, string ccodigousu)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Consulta SQL
                    string consultaSQL = "SELECT RTRIM(a.cidasociad) AS Codigo, RTRIM(b.cnombrecom) AS Nombre,CONVERT(VARCHAR(10), a.dfechacrea, 103) AS F_Renuncia, " +
                        "CONVERT(VARCHAR(10), a.dfechareve, 103) AS F_Reversa, Estado = CASE a.creversada WHEN 'S' THEN 'Reversada' ELSE 'Vigente' END, " +
                        "RTRIM(a.cobservaci) Observaciones, RTRIM(a.ccodigousu) AS usuario, a.ccodusrmod AS Modifica, 'Liquidaciones' AS Tipo, " +
                        "CASE WHEN a.ctipodocum IN ('ORD', 'CKS', 'NDB') AND a.cctabancar <> '' THEN RTRIM(a.ctipodocum) + '-' + 'Cta.: ' + " +
                        "RTRIM(a.cctabancar) + ' Núm Doc.:' + LTRIM(STR(a.nnumdocume)) " +
                        "WHEN a.cctabancar = '' AND a.ctipodocum <> '' THEN LTRIM(a.ctipodocum) + '-Asiento #:' + LTRIM(STR(a.nnumdocume)) " +
                        "WHEN a.cctabancar <> '' AND a.ctipodocum = '-PR' THEN RTRIM(a.ctipodocum) + '-' + RTRIM(a.cctabancar) " +
                        "ELSE ' ' END AS Descrformp " +
                        "FROM ascopaliqu a INNER JOIN asmaestras b ON a.cidasociad = b.cidasociad " +
                        "AND MONTH(a.dfecharenu) = MONTH(b.dfecharenu) AND YEAR(a.dfecharenu) = YEAR(b.dfecharenu) " +
                        "INNER JOIN geadminusu c ON a.ccodigousu = c.ccodigousu " +
                        "INNER JOIN AsDivision ON b.cidivision = asdivision.cidivision " +
                        "INNER JOIN ascondlabo d ON b.ccondlabor = d.ccondlabor " +
                        "WHERE (a.dfechacrea BETWEEN @dfechainic AND @dfechafin) " +
                        "AND (a.creversada = 'N' OR a.creversada = @creversada) AND a.cstaliquid = @cstaliquid " +
                        "AND a.ctipodocum = @ctipodocum AND a.ccodigousu = CASE WHEN @ccodigousu = '(TODOS)' THEN a.ccodigousu ELSE @ccodigousu END " +
                        "ORDER BY Tipo, f_renuncia DESC, nnumdocume DESC";

                    // Crear el comando SQL
                    SqlCommand comando = new SqlCommand(consultaSQL, conexion);
                    comando.Parameters.AddWithValue("@dfechainic", dfechainic);
                    comando.Parameters.AddWithValue("@dfechafin", dfechafin);
                    comando.Parameters.AddWithValue("@creversada", creversada);
                    comando.Parameters.AddWithValue("@cstaliquid", cstaliquid);
                    comando.Parameters.AddWithValue("@ctipodocum", ctipodocum);
                    comando.Parameters.AddWithValue("@ccodigousu", ccodigousu);

                    // Crear un adaptador de datos
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    // Crear un DataTable para almacenar los resultados
                    DataTable tabla = new DataTable();

                    // Llenar el DataTable con los resultados de la consulta
                    adaptador.Fill(tabla);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dgvLiqRe.DataSource = tabla;

                    // Ajustar el tamaño de las columnas al contenido
                    dgvLiqRe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
            }
        }

        private void frmVisorLiqudaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Usuarios' Puede moverla o quitarla según sea necesario.
            this.tR_UsuariosTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_Usuarios);

            int index = cboUsuarios.FindString(Clases.VarGlobales.Usuario);
            cboUsuarios.SelectedIndex = index;
            
            cboTipoDoc.SelectedIndex = 0;

            string ctipodocum;
            string cstaliquid;
            string creversada;

            if (rdbLiq.Checked == true)
            {
                cstaliquid = "LF";
                ctipodocum = cboTipoDoc.Text;
            }
            else
            {
                cstaliquid = "RE";
                ctipodocum = "";
            }

            if (chkIncRev.Checked == true)
            {
                creversada = "S";
            }
            else
            {
                creversada = "N";
            }

            LlenarDataGridView(dtpFecIni.Value.Date, dtpFecFin.Value.Date, creversada, cstaliquid, ctipodocum, cboUsuarios.SelectedValue.ToString());
            lblFooter.Text = "N° DE REGISTROS: " + dgvLiqRe.RowCount;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string ctipodocum;
            string cstaliquid;
            string creversada;

            if (rdbLiq.Checked == true)
            {
                cstaliquid = "LF";
                ctipodocum = cboTipoDoc.Text;
            }
            else
            {
                cstaliquid = "RE";
                ctipodocum = "";
            }
            
            if (chkIncRev.Checked == true)
            {
                creversada = "S";
            }
            else
            {
                creversada = "N";
            }

            LlenarDataGridView(dtpFecIni.Value.Date, dtpFecFin.Value.Date, creversada, cstaliquid, ctipodocum, cboUsuarios.SelectedValue.ToString());
            lblFooter.Text = "N° DE REGISTROS: " + dgvLiqRe.RowCount;
        }

        private void rdbRenun_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRenun.Checked == true)
            {
                chkIncRev.Visible = true;
                lblTipoDoc.Visible = false;
                cboTipoDoc.Visible=false;
            }
            else
            {
                chkIncRev.Visible = false;
                lblTipoDoc.Visible = true;
                cboTipoDoc.Visible = true;
            }
        }
        private void ExportarAExcel(DataGridView dataGridView)
        {
            try
            {
                // Crear una aplicación de Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Crear un nuevo libro de trabajo de Excel
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;

                // Copiar los datos desde el DataGridView al libro de trabajo de Excel
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;

                // Definir los nombres de las columnas en Excel
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                // Aplicar formato a las celdas
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView.Columns[j].Name == "Codigo")
                        {
                            // Aplicar formato de texto a la columna Codigo
                            worksheet.Cells[i + 2, j + 1].NumberFormat = "@";
                        }

                        // Copiar el valor de la celda
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Guardar el libro de trabajo de Excel
                //workbook.SaveAs("Liquidaciones.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Llamar al método ExportarAExcel y pasar el DataGridView como argumento
            ExportarAExcel(dgvLiqRe);
        }
    }
}
