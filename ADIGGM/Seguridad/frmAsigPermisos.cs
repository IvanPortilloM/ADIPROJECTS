using ADIGGM.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class frmAsigPermisos : FrmPrincipal
    {
        bool selectAllOff = true;
        public frmAsigPermisos()
        {
            InitializeComponent();
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            marcar();
        }
        private void marcar()
        {
            int rowcount = dgvPermisosAsig.Rows.Count;

            if (selectAllOff == true && rowcount > 0)
            {
                foreach (DataGridViewRow row in dgvPermisosAsig.Rows)
                {
                    row.Cells["habilitado"].Value = true;
                }
                btnImp.Image = Properties.Resources.select_all_on;
                selectAllOff = false;
            }
            else
            if (selectAllOff == false && rowcount > 0)
            {
                foreach (DataGridViewRow row in dgvPermisosAsig.Rows)
                {
                    row.Cells["habilitado"].Value = false;
                }
                btnImp.Image = Properties.Resources.select_all_off;
                selectAllOff = true;
            }
        }

        private void cargarDgv()
        {
            this.usp_CargarPermisosTableAdapter.Fill(this.dsPermisos.usp_CargarPermisos, Convert.ToInt32(cboUsuarios.SelectedValue));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(Conexion.cn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Permiso WHERE IdUsuario = @IdUsuario", cn);
                    cmd.Parameters.Add("@IdUsuario", SqlDbType.Int);
                    cmd.Parameters["@IdUsuario"].Value = Convert.ToInt32(cboUsuarios.SelectedValue);
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dgvPermisosAsig.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["habilitado"].Value) == true)
                        {
                            try
                            {
                                SqlCommand command = new SqlCommand("usp_ActualizarPermisos", cn);
                                command.Parameters.AddWithValue("IdUsuario", Convert.ToInt32(cboUsuarios.SelectedValue));
                                command.Parameters.AddWithValue("IdSubMenu", Convert.ToInt32(row.Cells["idSubMenu"].Value));
                                command.Parameters.AddWithValue("IdDetSubMenu", Convert.ToInt32(row.Cells["idDetSubMenu"].Value));
                                command.CommandType = CommandType.StoredProcedure;
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    cn.Close();
                    MessageBox.Show("Permisos actualizados exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            cargarDgv();
        }

        private void frmAsigPermisos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Usuarios' Puede moverla o quitarla según sea necesario.
            this.tR_UsuariosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Usuarios);
            cargarDgv();
            dgvPermisosAsig.Columns["habilitado"].ReadOnly = false;
            this.Dock = DockStyle.Fill;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void cboUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDgv();
        }
    }
}
