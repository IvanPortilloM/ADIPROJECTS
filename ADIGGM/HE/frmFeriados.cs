using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADIGGM.HE
{
    public partial class frmFeriados : FrmPrincipal
    {
        public frmFeriados()
        {
            InitializeComponent();
        }

        private void frmFeriados_Load(object sender, EventArgs e)
        {
            CargarFeriados();
            dgvFeriados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvFeriados.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CargarFeriados()
        {
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Ordenamos por fecha descendente para ver los más recientes arriba
                    string query = "SELECT Fecha, Descripcion FROM dbo.HE_DiasFeriados ORDER BY Fecha DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvFeriados.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar feriados: " + ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor ingrese una descripción.");
                return;
            }

            DateTime fecha = dtpFecha.Value.Date;
            string descripcion = txtDescripcion.Text.Trim();

            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 1. Verificar si ya existe
                    string checkQuery = "SELECT COUNT(*) FROM dbo.HE_DiasFeriados WHERE Fecha = @Fecha";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Fecha", fecha);

                    int existe = (int)checkCmd.ExecuteScalar();
                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un feriado registrado para esta fecha.");
                        return;
                    }

                    // 2. Insertar
                    string insertQuery = "INSERT INTO dbo.HE_DiasFeriados (Fecha, Descripcion) VALUES (@Fecha, @Desc)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Desc", descripcion);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Feriado agregado correctamente.");

                    // Limpiar y recargar
                    txtDescripcion.Clear();
                    CargarFeriados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
                return;
            }

            // Obtenemos la fecha de la fila seleccionada
            DateTime fechaEliminar = Convert.ToDateTime(dgvFeriados.SelectedRows[0].Cells["Fecha"].Value);
            string descripcion = dgvFeriados.SelectedRows[0].Cells["Descripcion"].Value.ToString();

            if (MessageBox.Show($"¿Seguro que desea eliminar el feriado: {descripcion} ({fechaEliminar.ToShortDateString()})?",
                                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = DbManager.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM dbo.HE_DiasFeriados WHERE Fecha = @Fecha";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Fecha", fechaEliminar);
                        cmd.ExecuteNonQuery();

                        CargarFeriados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
        }
    }
}
