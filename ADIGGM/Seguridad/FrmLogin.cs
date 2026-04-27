using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class FrmLogin : FrmPrincipal
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblFooter.Text = ("");
            string username = txtUsuario.Text.ToString();
            string password = txtPassword.Text;
            string passwordsencyp = encryption(password);

            int login;
            bool bloqueado;

            if(username.Length > 0 && password.Length > 0)
            {
                bloqueado = Convert.ToBoolean(Clases.VarGlobales.consultasTrans.TR_UsuarioBloqueado(username, passwordsencyp));

                if(bloqueado == false)
                {
                    login = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_UsuarioLogin(username, passwordsencyp));
                    if (login > 0)
                    {
                        bool cambiarpass;
                        cambiarpass = Convert.ToBoolean(Clases.VarGlobales.consultasTrans.TR_UsuariosValCambPass(login));

                        if (cambiarpass == false)
                        {
                            Clases.VarGlobales.IdPerfil = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_UsuarioPerfil(username, passwordsencyp));
                            Clases.VarGlobales.Usuario = username.ToUpper();
                            Clases.VarGlobales.IdUsuario = login;
                            Clases.VarGlobales.Division = Convert.ToString(Clases.VarGlobales.consultasTrans.PR_UsuariosDiv(username));
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                            Formularios_Base.MdiPrincipal mdi = new Formularios_Base.MdiPrincipal(login);
                            mdi.Show();
                        }
                        else
                        {
                            FrmCambiarPass cambiarPass = new FrmCambiarPass(username);
                            cambiarPass.ShowDialog(this);

                            txtPassword.Text = "";
                            txtPassword.Focus();
                        }
                    }
                    else
                    {
                        lblFooter.Text = ("Nombre de usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    lblFooter.Text = ("El usuario se encuentra bloqueado");
                }
            }
            else
            {
                lblFooter.Text = ("Ingrese usuario y contraseña");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            lblFooter.Text = ("");
        }
    }
}
