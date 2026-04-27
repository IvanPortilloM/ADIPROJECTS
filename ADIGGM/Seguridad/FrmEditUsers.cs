using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class FrmEditUsers : FrmPrincipal
    {
        private readonly int idusuario, perfil;
        private readonly string nombres, email, Division;

        public FrmEditUsers(int idusuario, string username, string nombres, string email, int esadmin, string division)
        {
            InitializeComponent();
            this.idusuario = idusuario;
            txtUsuario.Text = username;
            txtNombres.Text = nombres;
            this.nombres = nombres;
            txtEmail.Text = email;
            this.email = email;
            perfil = esadmin;
            Division = division;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = nombres;
            txtEmail.Text = email;
            lblFooter.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.ToString();
            string email = txtEmail.Text.ToString();
            int idperfil = Convert.ToInt32(CboPerfiles.SelectedValue);

            //evalua si los campos estan vacios
            if (nombres.Length > 0 && email.Length > 0)
            {
                try
                {
                    Clases.VarGlobales.consultasTrans.PR_UsuariosUpdate(idusuario,nombres, email, idperfil, Convert.ToString(cboDivision.Text.Trim()));
                    txtNombres.Text = "";
                    txtUsuario.Text = "";
                    txtEmail.Text = "";
                    lblFooter.Text = "";

                    MessageBox.Show("Usuario Guardado Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                string Message = "Llene todos los campos requeridos";
                lblFooter.Text = Message.ToString();
            }
        }

        private void FrmEditUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Perfiles' Puede moverla o quitarla según sea necesario.
            this.tR_PerfilesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Perfiles);
            CboPerfiles.SelectedValue = perfil;
            int index = cboDivision.FindString(Division);
            cboDivision.SelectedIndex = index;
        }
    }
}
