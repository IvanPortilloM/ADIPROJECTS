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
    public partial class frmTiposAsistencia : FrmPrincipal
    {
        private int _idEnEdicion = 0;
        public frmTiposAsistencia()
        {
            InitializeComponent();
        }
        private void frmTiposAsistencia_Load(object sender, EventArgs e)
        {
            CargarTipos();
            dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvTipos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CargarTipos()
        {
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TipoAsistenciaID, Codigo, Descripcion, RequiereTiempos FROM dbo.HE_TiposAsistencia ORDER BY Codigo";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTipos.DataSource = dt;
                    if (dgvTipos.Columns["TipoAsistenciaID"] != null)
                        dgvTipos.Columns["TipoAsistenciaID"].Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Código y Descripción.");
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

                    // --- LÓGICA DE DECISIÓN ---
                    if (_idEnEdicion == 0)
                    {
                        // MODO INSERTAR (Nuevo)
                        // Primero validamos duplicados solo si es nuevo
                        string check = "SELECT COUNT(*) FROM dbo.HE_TiposAsistencia WHERE Codigo = @Cod";
                        SqlCommand checkCmd = new SqlCommand(check, conn);
                        checkCmd.Parameters.AddWithValue("@Cod", txtCodigo.Text.Trim());
                        if ((int)checkCmd.ExecuteScalar() > 0) { MessageBox.Show("El código ya existe."); return; }

                        query = @"INSERT INTO dbo.HE_TiposAsistencia (Codigo, Descripcion, RequiereTiempos) 
                          VALUES (@Cod, @Desc, @Req)";
                    }
                    else
                    {
                        // MODO ACTUALIZAR (Editar)
                        query = @"UPDATE dbo.HE_TiposAsistencia 
                          SET Codigo = @Cod, 
                              Descripcion = @Desc, 
                              RequiereTiempos = @Req 
                          WHERE TipoAsistenciaID = @ID";
                        cmd.Parameters.AddWithValue("@ID", _idEnEdicion);
                    }

                    // Parámetros comunes
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Cod", txtCodigo.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@Desc", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Req", chkRequiereTiempos.Checked);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(_idEnEdicion == 0 ? "Agregado correctamente." : "Actualizado correctamente.");

                    LimpiarFormulario(); // Usamos un método para limpiar
                    CargarTipos();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }
        // Agrega este método auxiliar para no repetir código
        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            chkRequiereTiempos.Checked = false;
            _idEnEdicion = 0; 
            btnGuardar.Text = "Guardar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTipos.SelectedRows.Count == 0) return;

            if (MessageBox.Show("¿Eliminar este tipo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvTipos.SelectedRows[0].Cells["TipoAsistenciaID"].Value);
                using (SqlConnection conn = DbManager.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM dbo.HE_TiposAsistencia WHERE TipoAsistenciaID = @ID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                        CargarTipos();
                    }
                    catch (Exception ex) { MessageBox.Show("Error al eliminar (puede estar en uso): " + ex.Message); }
                }
            }
        }

        private void dgvTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // 1. Recuperamos el ID oculto
                _idEnEdicion = Convert.ToInt32(dgvTipos.Rows[e.RowIndex].Cells["TipoAsistenciaID"].Value);

                // 2. Pasamos los datos a los controles para que el usuario los modifique
                txtCodigo.Text = dgvTipos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = dgvTipos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                chkRequiereTiempos.Checked = Convert.ToBoolean(dgvTipos.Rows[e.RowIndex].Cells["RequiereTiempos"].Value);

                // 3. (Opcional) Cambiar el texto del botón para dar feedback visual
                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
