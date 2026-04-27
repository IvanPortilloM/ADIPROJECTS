using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class FrmMantUsuarios : FrmPrincipal
    {
        public FrmMantUsuarios()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvUsuarios);
        }
        
        private void FrmMantUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm1.TR_Perfiles' Puede moverla o quitarla según sea necesario.
            this.tR_PerfilesTableAdapter.Fill(this.dsTransporteAdiggm1.TR_Perfiles);
            LlenarDgv();
        }

        public void LlenarDgv()
        {
            this.tR_UsuariosTableAdapter.FillByN(dsTransporteAdiggm.TR_Usuarios, this.txtUser.Text);

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnRestablecer.Enabled = true;
                cmsOpciones.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnRestablecer.Enabled = false;
                cmsOpciones.Enabled = false;
            }
        }

        public void EditUser()
        {
            int IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value);
            string Usuario = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
            string Nombres = dgvUsuarios.CurrentRow.Cells["nombreApellido"].Value.ToString();
            string Email = dgvUsuarios.CurrentRow.Cells["email"].Value.ToString();
            int Admin = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells["IdPerfil"].Value);
            string Division = dgvUsuarios.CurrentRow.Cells["Division"].Value.ToString();
            FrmEditUsers editUsers = new FrmEditUsers(IdUsuario, Usuario, Nombres, Email, Admin, Division);
            editUsers.ShowDialog(this);
        }

        public void ResetPass()
        {
            int IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value);
            string Usuario = dgvUsuarios.CurrentRow.Cells["NombreUsuario"].Value.ToString();
            frmResetPass resetPass = new frmResetPass(IdUsuario, Usuario);
            resetPass.ShowDialog(this);
        }

        private void agregarUsuariotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuarios crearUsuarios = new FrmCrearUsuarios();
            crearUsuarios.ShowDialog(this);
            LlenarDgv();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser();
            LlenarDgv();
        }

        private void bloquearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea bloquear este usuario?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString());
                Clases.VarGlobales.consultasTrans.PR_UsuariosBloqueo(IdUsuario, true);
                MessageBox.Show("Usuario Bloqueado", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }

        private void desbloquearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea desbloquear este usuario?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString());
                Clases.VarGlobales.consultasTrans.PR_UsuariosBloqueo(IdUsuario, false);
                MessageBox.Show("Usuario Desbloqueado", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }

        private void restablecerContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPass();
            LlenarDgv();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCrearUsuarios crearUsuarios = new FrmCrearUsuarios();
            crearUsuarios.ShowDialog(this);
            LlenarDgv();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditUser();
            LlenarDgv();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            ResetPass();
            LlenarDgv();
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            LlenarDgv();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            LlenarDgv();
        }

        private void dgvUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    cmsOpciones.Enabled = true;
                    if (bool.Parse(this.dgvUsuarios.CurrentRow.Cells["bloqueado"].Value.ToString()) == false)
                    {
                        cmsOpciones.Items[3].Visible = true;
                        cmsOpciones.Items[4].Visible = false;
                    }
                    else
                    {
                        cmsOpciones.Items[3].Visible = false;
                        cmsOpciones.Items[4].Visible = true;
                    }
                }
            }
            else
            {
                cmsOpciones.Enabled = false;
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
