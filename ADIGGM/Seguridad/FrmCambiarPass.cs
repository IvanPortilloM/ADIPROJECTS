using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class FrmCambiarPass : FrmPrincipal
    {
        string username;

        public FrmCambiarPass(string username)
        {
            InitializeComponent();

            this.txtUsuario.Text = username;
            this.username = username;
        }

        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encripta la cadena de la contraseña
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //crea una nueva cadena utilizando los datos encriptados 
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            lblFooter.Text = ("");
            string passactual = txtPassActual.Text.ToString();
            string newpassword = txtNuevoPass.Text;
            string confirmnewpass = txtConfirmPass.Text;
            string passwordsencyp = encryption(newpassword);

            int login;

            login = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_UsuarioLogin(username, encryption(passactual)));
            
            //evalua si los campos estan vacios
            if (passactual.Length > 0 && newpassword.Length > 0 && confirmnewpass.Length > 0)
            {
                if(login > 0)
                {
                    if (newpassword == confirmnewpass)
                    {
                        try
                        {
                            Clases.VarGlobales.consultasTrans.PR_UsuariosPassUpdate(login, passwordsencyp, false);

                            txtPassActual.Text = "";
                            txtNuevoPass.Text = "";
                            txtConfirmPass.Text = "";

                            MessageBox.Show("Contraseña Actualizada Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        string Message = "Las contraseñas no coinciden";
                        lblFooter.Text = Message.ToString();
                    }
                }
                else
                {
                    string Message = "Contraseña Incorrecta";
                    lblFooter.Text = Message.ToString();
                }
            }
            else
            {
                string Message = "Llene todos los campos requeridos";
                lblFooter.Text = Message.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCambiar.PerformClick();
            }
        }
    }
}
