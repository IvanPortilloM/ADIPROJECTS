using ADIGGM.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ADIGGM.Herramientas
{
    public partial class frmDevoluciones : FrmPrincipal
    {
        string cadenaConexion = ADIGGM.CapaDatos.Conexion.Cadena("Covibase");
        string cadenaConexionCA = ADIGGM.CapaDatos.Conexion.Cadena("CA");
        private readonly ADIGGM.CapaDatos.RepositorioCA _repoCA = new ADIGGM.CapaDatos.RepositorioCA();
        private readonly ADIGGM.CapaDatos.RepositorioCodeas _repoCodeas = new ADIGGM.CapaDatos.RepositorioCodeas();
        public frmDevoluciones()
        {
            InitializeComponent();
        }
        
        private void LlenarDataGridView(string cnumasient)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Abrir la conexión manualmente
                    conexion.Open();

                    // Consulta SQL inicial (primera consulta)
                    string consultaSQL = @"
                SELECT                     
                    RTRIM(codesgnoapli.ccuentacon) AS ccuentacon, 
                    RTRIM(cocatalogo.cdescripci) AS cdescripci,
                    nmontomovi,
                    cdocurefer, 
                    RTRIM(cdetalleli) AS cdetalleli,
                    --ctipasient, 
                    --ctipomovim, 
                    cnumasient
                FROM codesgnoapli
                INNER JOIN cocatalogo ON codesgnoapli.ccuentacon = cocatalogo.ccuentacon
                WHERE ctipasient = 'FAC' AND (cnumasient = @cnumasient OR cdocurefer = RIGHT('000000000000000' + CAST(@cnumasient AS NVARCHAR(15)), 15))
                ORDER BY ctipomovim DESC, codesgnoapli.ccuentacon";

                    // Crear el comando SQL
                    SqlCommand comando = new SqlCommand(consultaSQL, conexion);
                    comando.Parameters.AddWithValue("@cnumasient", cnumasient);

                    // Crear un adaptador de datos
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    // Crear un DataTable para almacenar los resultados de la primera consulta
                    DataTable tabla = new DataTable();

                    // Llenar el DataTable con los resultados de la primera consulta
                    adaptador.Fill(tabla);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dgvDatosOriginales.DataSource = tabla;

                    // Ajustar el tamaño de las columnas al contenido
                    dgvDatosOriginales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Cerrar la conexión después de todas las consultas
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el DataGridView: " + ex.Message);
            }
        }

        private void CorregirCuentasContables()
        {
            try
            {
                DataTable tablaCorregida = new DataTable();
                tablaCorregida.Columns.Add("CuentaOriginal", typeof(string));
                tablaCorregida.Columns.Add("CuentaContable", typeof(string)); // Cuenta corregida
                tablaCorregida.Columns.Add("Descripcion", typeof(string));
                tablaCorregida.Columns.Add("Categoria", typeof(string));
                tablaCorregida.Columns.Add("NombrePunto", typeof(string));
                tablaCorregida.Columns.Add("cdocurefer", typeof(string));
                tablaCorregida.Columns.Add("cnumasient", typeof(string));

                using (SqlConnection conexionCA = new SqlConnection(cadenaConexionCA))
                {
                    conexionCA.Open();

                    foreach (DataGridViewRow fila in dgvDatosOriginales.Rows)
                    {
                        if (fila.IsNewRow || fila.Cells["ccuentacon"].Value == null)
                            continue;

                        string cuentaOriginal = fila.Cells["ccuentacon"].Value.ToString().Trim();

                        if (fila.IsNewRow || fila.Cells["cdocurefer"].Value == null)
                            continue;

                        string cdocurefer = fila.Cells["cdocurefer"].Value.ToString().Trim();

                        if (fila.IsNewRow || fila.Cells["cnumasient"].Value == null)
                            continue;

                        string cnumasient = fila.Cells["cnumasient"].Value.ToString().Trim();

                        // 1. Obtener IdCategoria desde CC_CuentasContables
                        string consultaIdCategoria = @"
                SELECT IdCategoria 
                FROM CC_CuentasContables 
                WHERE CuentaContable = @CuentaOriginal";

                        SqlCommand cmdIdCategoria = new SqlCommand(consultaIdCategoria, conexionCA);
                        cmdIdCategoria.Parameters.AddWithValue("@CuentaOriginal", cuentaOriginal);

                        int idCategoria = -1;
                        using (SqlDataReader reader = cmdIdCategoria.ExecuteReader())
                        {
                            if (reader.Read())
                                idCategoria = Convert.ToInt32(reader["IdCategoria"]);
                        }

                        if (idCategoria == -1)
                        {
                            // Cuenta no encontrada en CC_CuentasContables
                            DataRow filaError = tablaCorregida.NewRow();
                            filaError["CuentaOriginal"] = cuentaOriginal;
                            filaError["CuentaContable"] = "NO ENCONTRADA";
                            tablaCorregida.Rows.Add(filaError);
                            continue;
                        }

                        // 2. Obtener datos corregidos usando IdCategoria e IdPunto
                        string consultaCorreccion = @"
                SELECT 
                    CC.CuentaContable,
                    CC.Descripcion,
                    CAT.Categoria,
                    P.NombrePunto
                FROM CC_CuentasContables CC
                INNER JOIN CC_Categorias CAT 
                    ON CC.IdCategoria = CAT.IdCategoria
                INNER JOIN CC_Puntos P 
                    ON CC.IdPunto = P.IdPunto
                WHERE 
                    CC.IdCategoria = @IdCategoria
                    AND CC.IdPunto = @IdPunto"; // Filtro por ambos IDs

                        SqlCommand cmdCorreccion = new SqlCommand(consultaCorreccion, conexionCA);
                        cmdCorreccion.Parameters.AddWithValue("@IdCategoria", idCategoria);
                        cmdCorreccion.Parameters.AddWithValue("@IdPunto", Convert.ToInt32(cboPuntos.SelectedValue.ToString()));

                        using (SqlDataReader reader = cmdCorreccion.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Cuenta corregida y válida para el IdPunto
                                DataRow filaCorregida = tablaCorregida.NewRow();
                                filaCorregida["CuentaOriginal"] = cuentaOriginal;
                                filaCorregida["CuentaContable"] = reader["CuentaContable"].ToString();
                                filaCorregida["Descripcion"] = reader["Descripcion"].ToString();
                                filaCorregida["Categoria"] = reader["Categoria"].ToString();
                                filaCorregida["NombrePunto"] = reader["NombrePunto"].ToString();
                                filaCorregida["cdocurefer"] = cdocurefer;
                                filaCorregida["cnumasient"] = cnumasient;
                                tablaCorregida.Rows.Add(filaCorregida);
                            }
                            else
                            {
                                // IdCategoria existe, pero no coincide con el IdPunto
                                DataRow filaError = tablaCorregida.NewRow();
                                filaError["CuentaOriginal"] = cuentaOriginal;
                                filaError["CuentaContable"] = "PUNTO INCORRECTO";
                                tablaCorregida.Rows.Add(filaError);
                            }
                        }
                    }
                }

                dgvDatosCorregidos.DataSource = tablaCorregida;

                // Ajustar el tamaño de las columnas al contenido
                dgvDatosCorregidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            LlenarDataGridView(txtDocumento.Text.PadLeft(10,'0'));
            // Corregir datos usando la segunda base de datos
            CorregirCuentasContables();
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            cCPuntosBindingSource.DataMember = "";
            cCPuntosBindingSource.DataSource = _repoCA.ListarPuntos();
            cboPuntos.SelectedIndex = 0;
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            int VerificarCta = 0;

            foreach (DataGridViewRow row in dgvDatosCorregidos.Rows)
            {
                if (_repoCodeas.VerificarCuentaContable(Convert.ToString(row.Cells["CuentaContable"].Value.ToString().Trim())) == 0)
                {
                    VerificarCta += 1;
                }
            }

            if (VerificarCta > 0)
            {
                // Antes el botón no hacía nada y el usuario no sabía por qué
                MessageBox.Show("Hay " + VerificarCta + " cuenta(s) no válidas en el catálogo (NO ENCONTRADA / PUNTO INCORRECTO). Corrija antes de actualizar.",
                    VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (VerificarCta == 0)
            {
                // Mensaje de confirmación inicial
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea actualizar los registros seleccionados?",
                    "Confirmar actualización",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }

                try
                {
                    using (SqlConnection connection = new SqlConnection(cadenaConexion))
                    {
                        connection.Open();
                        int updatedRows = 0;

                        // Correcciones contables en UNA transacción: o se aplican todas o ninguna
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                foreach (DataGridViewRow row in dgvDatosCorregidos.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        string cuentaOriginal = row.Cells["CuentaOriginal"].Value?.ToString();
                                        string cuentaContable = row.Cells["CuentaContable"].Value?.ToString();
                                        string cdocurefer = row.Cells["cdocurefer"].Value?.ToString();
                                        string cnumasient = row.Cells["cnumasient"].Value?.ToString();

                                        if (!string.IsNullOrEmpty(cuentaOriginal) &&
                                            !string.IsNullOrEmpty(cuentaContable) &&
                                            cuentaOriginal != cuentaContable)
                                        {
                                            using (SqlCommand cmd = new SqlCommand(
                                                @"UPDATE codesgnoapli
                                SET ccuentacon = @CuentaContable
                                WHERE ccuentacon = @CuentaOriginal
                                AND cdocurefer = @cdocurefer
                                AND cnumasient = @cnumasient", connection, transaction))
                                            {
                                                cmd.Parameters.AddWithValue("@CuentaContable", cuentaContable);
                                                cmd.Parameters.AddWithValue("@CuentaOriginal", cuentaOriginal);
                                                cmd.Parameters.AddWithValue("@cdocurefer", cdocurefer);
                                                cmd.Parameters.AddWithValue("@cnumasient", cnumasient);

                                                updatedRows += cmd.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                }

                                transaction.Commit();
                            }
                            catch
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }

                        // Mensaje de éxito final
                        MessageBox.Show(
                            $"Proceso completado exitosamente!\nRegistros actualizados: {updatedRows}",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error durante la actualización (no se aplicó ningún cambio): {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void dgvDatosCorregidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int col1 = 0; // Índice de la primera columna
            int col2 = 1; // Índice de la segunda columna

            if (e.ColumnIndex == col1 || e.ColumnIndex == col2) // Solo afecta a las columnas deseadas
            {
                string CuentaOriginal = dgvDatosCorregidos.Rows[e.RowIndex].Cells["CuentaOriginal"].Value?.ToString();
                string CuentaContable = dgvDatosCorregidos.Rows[e.RowIndex].Cells["CuentaContable"].Value?.ToString();

                if (!string.IsNullOrEmpty(CuentaOriginal) && !string.IsNullOrEmpty(CuentaContable))
                {
                    if (CuentaOriginal == CuentaContable)
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (e.ColumnIndex == col1) // Solo la primera columna será roja si los valores son distintos
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                }
            }
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                LlenarDataGridView(txtDocumento.Text.PadLeft(10, '0'));
                // Corregir datos usando la segunda base de datos
                CorregirCuentasContables();
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void dgvDatosOriginales_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvDatosCorregidos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cboPuntos_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = cboPuntos.SelectedValue;

            if (selectedValue != null)
            {
                LlenarDataGridView(txtDocumento.Text.PadLeft(10, '0'));
                // Corregir datos usando la segunda base de datos
                CorregirCuentasContables();
            }          
        }
    }
}