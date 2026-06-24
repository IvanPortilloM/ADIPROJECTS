using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Win32;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.INV.Visores
{
    public partial class frmVisorInventarioSync : FrmPrincipal
    {
        bool PermitirMonto = true;
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();

        string connectionString = ADIGGM.CapaDatos.Conexion.Cadena("Covipruebas");
        string connectionString2 = ADIGGM.CapaDatos.Conexion.Cadena("TransporteAdiggm");

        private Dictionary<string, cotipasien> registros = new Dictionary<string, cotipasien>();
        public frmVisorInventarioSync()
        {
            InitializeComponent();
            LlenarComboBox(cbocdesasien, registros);
            cbocdesasien.SelectedIndexChanged += new EventHandler(cbocdesasien_SelectedIndexChanged);
            cbocdesasien.SelectedIndex = 2;
            cboCategoria.SelectedIndex = 0;
            txtMonto.Text = $"{0:n}";
        }
        public class cotipasien
        {
            public string cdesasien { get; set; }
            public string ctipasient { get; set; }
            public string nconsecuti { get; set; }
        }
        public void LlenarComboBox(ComboBox comboBox, Dictionary<string, cotipasien> registros)
        {
            string query = "Select cdesasien, ctipasient, nconsecuti From cotipasien  Where cutilconta = 'N' ORDER BY cdesasien";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            comboBox.Items.Clear();
                            registros.Clear();

                            while (reader.Read())
                            {
                                var registro = new cotipasien
                                {
                                    cdesasien = reader["cdesasien"].ToString(),
                                    ctipasient = reader["ctipasient"].ToString(),
                                    nconsecuti = reader["nconsecuti"].ToString()
                                };

                                comboBox.Items.Add(registro.cdesasien);
                                registros[registro.cdesasien] = registro;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void cbocdesasien_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                string selectedcdesasien = comboBox.SelectedItem.ToString();
                if (registros.ContainsKey(selectedcdesasien))
                {
                    cotipasien registro = registros[selectedcdesasien];
                    txtctipasient.Text = registro.ctipasient;
                    txtnconsecuti.Text = registro.nconsecuti.PadLeft(10,'0');
                }
            }
        }
        public void LlenarDataGridView(DataGridView dataGridView, string cuentaGasto, string categoria, DateTime fechaIni, DateTime fechaFin, string detalle, decimal debe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el comando para ejecutar el procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("IN_VisorInventarioSync", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros del procedimiento almacenado
                        command.Parameters.Add(new SqlParameter("@CuentaGasto", cuentaGasto));
                        command.Parameters.Add(new SqlParameter("@Categoria", categoria));
                        command.Parameters.Add(new SqlParameter("@FechaIni", fechaIni));
                        command.Parameters.Add(new SqlParameter("@FechaFin", fechaFin));
                        command.Parameters.Add(new SqlParameter("@Detalle", detalle));
                        command.Parameters.Add(new SqlParameter("@Debe", debe));

                        // Ejecutar el comando y llenar un DataTable con los resultados
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Asignar el DataTable como fuente de datos del DataGridView
                            dataGridView.DataSource = dataTable;
                        }
                        // Ajustar el tamaño de las columnas al contenido
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        // Ocultar columnas específicas
                        dataGridView.Columns["IdKardex"].Visible = false;
                        dataGridView.Columns["CodVehiculo"].Visible = false;
                        dataGridView.Columns["Categoria"].Visible = false;
                        dataGridView.Columns["Fecha"].Visible = false;
                        dataGridView.Columns["Producto"].Visible = false;
                        // Aplicar formato numérico a la columna específica
                        dataGridView.Columns["Debe"].DefaultCellStyle.Format = "N2";
                        dataGridView.Columns["Haber"].DefaultCellStyle.Format = "N2";
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void CalcularDiferencia(DataGridView dataGridView, string nombreColumna1, string nombreColumna2, TextBox textResultado)
        {
            decimal debe = 0;
            decimal haber = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[nombreColumna1].Value != null && row.Cells[nombreColumna2].Value != null)
                {
                    debe += Convert.ToDecimal(row.Cells[nombreColumna1].Value);
                    haber += Convert.ToDecimal(row.Cells[nombreColumna2].Value);
                }
            }

            txtDebe.Text = debe.ToString("N2");
            txtHaber.Text = haber.ToString("N2");
            decimal diferencia = debe - haber;
            textResultado.Text = diferencia.ToString("N2");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            LlenarDataGridView(dgvDetalle, txtCC.Text, cboCategoria.SelectedItem.ToString(), dtpFechaIni.Value.Date, dtpFechaFin.Value.Date, txtDetalle.Text, Convert.ToDecimal(txtMonto.Text));
            CalcularDiferencia(dgvDetalle, "Debe", "Haber", txtDif);
            btnSincronizar.Enabled = false;
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (txtMonto.Text.Length < 1 || txtMonto.Text == ".")
            {
                txtMonto.Text = string.Format("{0:#,##0.00}", 0);
            }
            else
            {
                txtMonto.Text = string.Format("{0:#,##0.00}", double.Parse(txtMonto.Text));
            }
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtMonto.SelectAll();
            });
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtMonto.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Text = $"{0:n}";
                txtMonto.Focus();
            }
        }
        public bool ValidarMonto(int code, string NombreControl)
        {
            bool resultado = true;
            Control[] ctrls = Controls.Find(NombreControl, true);

            if (ctrls.Length > 0)
            {
                TextBox ControlTexbox = ctrls[0] as TextBox;

                if (code == 46 && ControlTexbox.Text == "") //se evalúa si es punto y revisa si el texto está vacío.
                {
                    resultado = true;
                }
                if (code == 46 && ControlTexbox.Text.Contains(".")) //se evalúa si es punto y revisa si ya existe en el textbox
                {
                    resultado = true;
                }
                else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
                {
                    resultado = false;
                }
                else if (!PermitirMonto)
                {
                    resultado = PermitirMonto;
                }
                else
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.RowCount > 0)
            {
                int NoExiste = 0;
                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if (_repoCodeas.VerificarCuentaContable(row.Cells["cuentaContable"].Value.ToString()) == 0)
                    {
                        MessageBox.Show("La siguiente Cuenta Contable no existe en el sistema de CODEAS: " + row.Cells["cuentaContable"].Value.ToString(), VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSincronizar.Enabled = false;
                        NoExiste = 1;
                        break;
                    }
                }
                if (NoExiste < 1)
                {
                    lblFooter.Text = "Verificación de Cuentas Contables Finalizada Exitosamente";

                    Timer timer1 = new Timer();
                    timer1.Interval = 10000;

                    timer1.Tick += (s, a) =>
                    {
                        ((Timer)s).Stop();
                        lblFooter.Text = "";
                    };

                    timer1.Start();
                    btnSincronizar.Enabled = true;
                }
            }
        }
    }
}
