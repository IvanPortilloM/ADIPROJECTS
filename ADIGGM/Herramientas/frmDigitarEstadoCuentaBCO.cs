using ADIGGM.Clases;
using ExcelDataReader;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ADIGGM.Herramientas
{
    public partial class frmDigitarEstadoCuentaBCO : FrmPrincipal
    {
        private bool todasLasFilasValidas = true, filaValida = true;
        private readonly string nombreHoja = "Hoja1";
        private string cadenaConexionExcel = "";
        private readonly string cadenaConexionSQL = @"Initial Catalog=covibase;Data Source=ADIGGM.granjasmarinas.hn;Persist Security Info=True;User ID=sa;Password=ADIGGM*2016+";
        private readonly string consultaInsertar =
            "INSERT INTO baestabanc  (cctabancar,ctipodocum,nnumdocume,nmontomovi,dfechacrea,nigualadoc,ccontadorr,cstatusmov,cdescripci,nmesconcil,nanoconcil,dFechaIncl) " +
                                 "VALUES (@valor1, @valor2, @valor3, @valor4, @valor5, @valor6, @valor7, @valor8, @valor9, @valor10, @valor11, @valor12)";

        public frmDigitarEstadoCuentaBCO()
        {
            InitializeComponent();
        }
        private void CargarDatosDesdeExcel()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de Excel|*.xlsx;*.xls|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccione el archivo Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    cadenaConexionExcel = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={openFileDialog.FileName};Extended Properties='Excel 12.0 Xml;HDR=YES';";

                    using (OleDbConnection conexionExcel = new OleDbConnection(cadenaConexionExcel))
                    {
                        OleDbCommand comandoExcel = new OleDbCommand($"SELECT * FROM [{nombreHoja}$]", conexionExcel);
                        OleDbDataAdapter adaptadorExcel = new OleDbDataAdapter(comandoExcel);
                        DataTable tablaExcel = new DataTable();
                        adaptadorExcel.Fill(tablaExcel);

                        // Filtrar las filas vacías
                        var filasNoVacias = tablaExcel.AsEnumerable().Where(fila => fila.ItemArray.Any(c => c.ToString() != string.Empty));

                        // Crear un nuevo DataTable con las filas no vacías
                        DataTable tablaFiltrada = filasNoVacias.Any() ? filasNoVacias.CopyToDataTable() : tablaExcel.Clone();

                        dataGridView1.DataSource = tablaFiltrada;
                        OcultarColumnasVacias(dataGridView1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable tablaDataGridView = (DataTable)dataGridView1.DataSource;

            if (!todasLasFilasValidas)
            {
                MessageBox.Show("No se han guardado todos los datos debido a errores de validación.");
            }
            else
            {
                btnGuardar.Enabled = false;
                foreach (DataRow filaDataGridView in tablaDataGridView.Rows)
                {
                    using (SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL))
                    {
                        conexionSQL.Open();
                        SqlCommand comandoSQL = new SqlCommand(consultaInsertar, conexionSQL);

                        comandoSQL.Parameters.AddWithValue("@valor1", lblCuentaBCO.Text);
                        comandoSQL.Parameters.AddWithValue("@valor2", filaDataGridView["TipoDoc"]);
                        comandoSQL.Parameters.AddWithValue("@valor3", Convert.ToInt32(filaDataGridView["Documento"]));
                        comandoSQL.Parameters.AddWithValue("@valor4", Convert.ToDecimal(filaDataGridView["Monto"]));
                        comandoSQL.Parameters.AddWithValue("@valor5", Convert.ToDateTime(filaDataGridView["Fecha"]));
                        comandoSQL.Parameters.AddWithValue("@valor6", 0);
                        comandoSQL.Parameters.AddWithValue("@valor7", "");
                        comandoSQL.Parameters.AddWithValue("@valor8", "N");
                        comandoSQL.Parameters.AddWithValue("@valor9", filaDataGridView["Descripción"].ToString().TrimEnd());
                        comandoSQL.Parameters.AddWithValue("@valor10", Convert.ToInt32(lblNumMes.Text));
                        comandoSQL.Parameters.AddWithValue("@valor11", Convert.ToInt32(lblAnio.Text));
                        comandoSQL.Parameters.AddWithValue("@valor12", DateTime.Now);

                        comandoSQL.ExecuteNonQuery();
                    }
                }
                btnValidar.Enabled = false;
                MessageBox.Show("Todos los datos se han guardado correctamente en la base de datos.");

                // Borrar los datos del DataGridView
                dataGridView1.DataSource = null;
                tablaDataGridView.Clear();
                dataGridView1.DataSource = tablaDataGridView;

                // Actualizar la etiqueta de suma
                lblSuma.Text = "Total: 0.00";
            }
        }
        private void OcultarColumnasVacias(DataGridView dataGridView)
        {
            for (int columnIndex = 0; columnIndex < dataGridView.Columns.Count; columnIndex++)
            {
                bool columnIsEmpty = true;

                for (int rowIndex = 0; rowIndex < dataGridView.Rows.Count; rowIndex++)
                {
                    if (dataGridView.Rows[rowIndex].Cells[columnIndex].Value != null &&
                        !string.IsNullOrWhiteSpace(dataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString()))
                    {
                        columnIsEmpty = false;
                        break;
                    }
                }

                if (columnIsEmpty)
                {
                    dataGridView.Columns[columnIndex].Visible = false;
                }
            }
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosDesdeExcel();

            dataGridView1.Columns["Monto"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            decimal suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["Monto"].Value != DBNull.Value)
                {
                    suma += Convert.ToDecimal(fila.Cells["Monto"].Value);
                }
            }
            // Muestra la suma inicial en una etiqueta llamada "lblSuma"
            lblSuma.Text = "Total: " + suma.ToString("N2");
            btnGuardar.Enabled = false;
            btnValidar.Enabled = true;
        }
        private void eliminarFila(int rowIndex)
        {
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el usuario hizo clic en la columna "Eliminar"
            if (e.ColumnIndex == dataGridView1.Columns["eliminarColumna"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila del DataGridView
                eliminarFila(e.RowIndex);
            }
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Recalcula la suma de los valores de la columna "ColumnaNumerica"
            decimal suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += Convert.ToDecimal(fila.Cells["Monto"].Value);
            }

            // Actualiza la etiqueta que muestra la suma
            lblSuma.Text = "Total: " + suma.ToString("N2");
        }
        private void frmDigitarEstadoCuentaBCO_Load(object sender, EventArgs e)
        {
            this.cOD_SlcInstBancariaTableAdapter.Fill(this.dsOC.COD_SlcInstBancaria, VarGlobales.Usuario);
            this.cOD_SlcCcBancariaTableAdapter.Fill(this.dsOC.COD_SlcCcBancaria, VarGlobales.Usuario, lblCodBanco.Text);

            // Establecer la conexión a la base de datos
            SqlConnection connection = new SqlConnection(cadenaConexionSQL);

            // Definir la consulta SQL
            string query = "SELECT nmesconcil, nanoconcil FROM bactasbanc Where ccodibanca= @ccodibanca and cctabancar=@cctabancar";

            // Crear un comando SQL con la consulta y el parámetro
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ccodibanca", lblCodBanco.Text);
                command.Parameters.AddWithValue("@cctabancar", lblCuentaBCO.Text);

                // Abrir la conexión y ejecutar la consulta
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Verificar que hay datos en el SqlDataReader
                if (reader.Read())
                {
                    // Asignar cada valor de la columna correspondiente al TextBox correspondiente
                    lblNumMes.Text = reader["nmesconcil"].ToString();
                    lblNombreMes.Text = new CultureInfo("es-ES").DateTimeFormat.GetMonthName(Convert.ToInt32(lblNumMes.Text));
                    lblAnio.Text = reader["nanoconcil"].ToString();
                }

                // Cerrar el SqlDataReader y la conexión a la base de datos
                reader.Close();
            }
            connection.Close();
        }
        private bool DocumentoYaExisteEnDataGridView(string documento, int filaActual)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == filaActual) continue;

                if (dataGridView1.Rows[i].Cells["Documento"].Value.ToString() == documento)
                {
                    return true;
                }
            }
            return false;
        }

        private void cboInst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboInst.SelectedIndex > -1)
            {
                this.cOD_SlcCcBancariaTableAdapter.Fill(this.dsOC.COD_SlcCcBancaria, VarGlobales.Usuario, cboInst.SelectedValue.ToString());
            }
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow filaDataGridView in dataGridView1.Rows)
            {
                // Validar los datos de la fila actual
                filaValida = true;

                // Validar el campo Columna1
                string fechaString = filaDataGridView.Cells["Fecha"].Value.ToString();
                DateTime fecha;
                if (!DateTime.TryParse(fechaString, out fecha))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de fecha no es válido.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Fecha"];
                    break; // Detener el ciclo
                }
                else if (string.IsNullOrEmpty(fechaString))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de fecha es obligatorio.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Fecha"];
                    break; // Detener el ciclo
                }
                else if (string.IsNullOrEmpty(fechaString))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de fecha es obligatorio.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Fecha"];
                    break; // Detener el ciclo
                }
                else
                {
                    // Validar que la fecha esté dentro del mes y año específico
                    int mesEspecifico = int.Parse(lblNumMes.Text);
                    int anioEspecifico = int.Parse(lblAnio.Text);

                    if (fecha.Month != mesEspecifico || fecha.Year != anioEspecifico)
                    {
                        filaValida = false;
                        MessageBox.Show("La fecha no está dentro del mes y año específico.");
                        dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Fecha"];
                        break; // Detener el ciclo
                    }
                }
                // Validar el campo Columna2
                string documento = filaDataGridView.Cells["Documento"].Value.ToString();
                if (string.IsNullOrEmpty(documento))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de documento es obligatorio.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Documento"];
                    break; // Detener el ciclo
                }
                else if (DocumentoYaExisteEnDataGridView(documento, filaDataGridView.Index))
                {
                    filaValida = false;
                    MessageBox.Show($"El número de documento {documento} ya existe en el DataGridView.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Documento"];
                    break; // Detener el ciclo
                }
                // Validar el campo Columna3
                string monto = filaDataGridView.Cells["Monto"].Value.ToString();
                if (string.IsNullOrEmpty(monto))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de monto es obligatorio.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Monto"];
                    break; // Detener el ciclo
                }
                // Validar el campo Columna4
                string descripcion = filaDataGridView.Cells["Descripción"].Value.ToString();
                if (string.IsNullOrEmpty(descripcion))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de descripción es obligatorio.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Descripción"];
                    break; // Detener el ciclo
                }
                // Validar el campo Columna5
                string tipoDoc = filaDataGridView.Cells["TipoDoc"].Value.ToString();
                if (string.IsNullOrEmpty(tipoDoc))
                {
                    filaValida = false;
                    MessageBox.Show("El campo de tipo de documento es obligatorio.");
                    dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["TipoDoc"];
                    break; // Detener el ciclo
                }
                // Verificar si el valor del campo Columna1 ya existe en la base de datos
                using (SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL))
                {
                    SqlCommand comandoSQL = new SqlCommand($"SELECT COUNT(nnumdocume) FROM baestabanc WHERE (cctabancar='{lblCuentaBCO.Text}' and ctipodocum='{tipoDoc}' and nnumdocume='{documento}')", conexionSQL);
                    conexionSQL.Open();
                    int cantidadRegistros = (int)comandoSQL.ExecuteScalar();
                    if (cantidadRegistros > 0)
                    {
                        todasLasFilasValidas = false;
                        MessageBox.Show($"El número de documento {documento} ya existe en la base de datos.");
                        dataGridView1.CurrentCell = dataGridView1.Rows[filaDataGridView.Index].Cells["Documento"];
                        break; // Detener el ciclo
                    }
                    else
                    {
                        todasLasFilasValidas = true;
                        btnGuardar.Enabled = true;
                    }
                }
            }
        }
    }
}