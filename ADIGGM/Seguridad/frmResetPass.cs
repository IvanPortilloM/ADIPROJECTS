using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class frmResetPass : Form
    {
        //campos usados para editar viajes
        int IdUsuario = 0;

        public frmResetPass(int IdUsuario, string Usuario)
        {
            InitializeComponent();

            this.IdUsuario = IdUsuario;
            this.txtUsuario.Text = Usuario;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string newpassword = txtNuevoPass.Text.ToString();
            string confirmnewpass = txtConfirmPass.Text;
            string passwordsencyp = encryption(newpassword);

            //evalua si los campos estan vacios
            if (newpassword.Length > 0 && confirmnewpass.Length > 0)
            {
                if (newpassword == confirmnewpass)
                {
                    try
                    {
                        Clases.VarGlobales.consultasTrans.PR_UsuariosPassUpdate(IdUsuario, passwordsencyp, chkCambiarPass.Checked);

                        txtNuevoPass.Text = "";
                        txtConfirmPass.Text = "";
                        chkCambiarPass.Checked = false;

                        MessageBox.Show("Datos Guardados Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string Message = "Llene todos los campos requeridos";
                lblFooter.Text = Message.ToString();
            }
        }

        private void txtNuevoPass_KeyDown(object sender, KeyEventArgs e)
        {
            lblFooter.Text = "";
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            lblFooter.Text = "";
        }
    }
}
