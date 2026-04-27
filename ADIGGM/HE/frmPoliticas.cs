using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmPoliticas : FrmPrincipal
    {
        private int _idEnEdicion = 0;
        public frmPoliticas()
        {
            InitializeComponent();
        }

        private void frmPoliticas_Load(object sender, EventArgs e)
        {
            CargarPoliticas();
            dgvPoliticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvPoliticas.Columns["NombrePolitica"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void CargarPoliticas()
        {
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PoliticaID, NombrePolitica, PagaExtrasDiarias, PagaDomingos, PagaFeriados, AplicaJornadaMixta FROM dbo.HE_PoliticasPago ORDER BY NombrePolitica";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPoliticas.DataSource = dt;
                    if (dgvPoliticas.Columns["PoliticaID"] != null)
                        dgvPoliticas.Columns["PoliticaID"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para la política.");
                return;
            }

            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (_idEnEdicion == 0)
                    {
                        // INSERT
                        query = @"INSERT INTO dbo.HE_PoliticasPago (NombrePolitica, PagaExtrasDiarias, PagaDomingos, PagaFeriados, AplicaJornadaMixta) 
                          VALUES (@Nom, @Ext, @Dom, @Fer, @Mix)";
                    }
                    else
                    {
                        // UPDATE
                        query = @"UPDATE dbo.HE_PoliticasPago 
                          SET NombrePolitica = @Nom, 
                              PagaExtrasDiarias = @Ext, 
                              PagaDomingos = @Dom, 
                              PagaFeriados = @Fer,
                              AplicaJornadaMixta = @Mix
                          WHERE PoliticaID = @ID";
                        cmd.Parameters.AddWithValue("@ID", _idEnEdicion);
                    }

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Nom", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ext", chkPagaExtrasDiarias.Checked);
                    cmd.Parameters.AddWithValue("@Dom", chkPagaDomingos.Checked);
                    cmd.Parameters.AddWithValue("@Fer", chkPagaFeriados.Checked);
                    cmd.Parameters.AddWithValue("@Mix", chkAplicaMixta.Checked);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Guardado correctamente.");
                    LimpiarFormulario();
                    CargarPoliticas();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            chkPagaExtrasDiarias.Checked = false;
            chkPagaDomingos.Checked = false;
            chkPagaFeriados.Checked = false;
            chkAplicaMixta.Checked = false;
            _idEnEdicion = 0;
            btnGuardar.Text = "Guardar";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPoliticas.SelectedRows.Count == 0) return;

            if (MessageBox.Show("¿Eliminar esta política? \n\nCUIDADO: Asegúrese de que ningún motorista la esté usando antes de borrarla.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPoliticas.SelectedRows[0].Cells["PoliticaID"].Value);
                using (SqlConnection conn = DbManager.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM dbo.HE_PoliticasPago WHERE PoliticaID = @ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        CargarPoliticas();
                    }
                    catch (Exception ex) { MessageBox.Show("No se puede eliminar porque hay motoristas asignados a esta política.", "Error de Integridad"); }
                }
            }
        }

        private void dgvPoliticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _idEnEdicion = Convert.ToInt32(dgvPoliticas.Rows[e.RowIndex].Cells["PoliticaID"].Value);

                txtNombre.Text = dgvPoliticas.Rows[e.RowIndex].Cells["NombrePolitica"].Value.ToString();

                // Checkboxes
                chkPagaExtrasDiarias.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["PagaExtrasDiarias"].Value);
                chkPagaDomingos.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["PagaDomingos"].Value);
                chkPagaFeriados.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["PagaFeriados"].Value);
                chkAplicaMixta.Checked = Convert.ToBoolean(dgvPoliticas.Rows[e.RowIndex].Cells["AplicaJornadaMixta"].Value);

                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
