using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class FrmCrearUsuarios : FrmPrincipal
    {
        public FrmCrearUsuarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtUsuario.Text = "";
            txtPassword1.Text = "";
            txtPassword2.Text = "";
            txtEmail.Text = "";
            lblFooter.Text = "";
            ckbBloqueado.Checked = false;
        }

        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.ToString();
            string nombres = txtNombres.Text.ToString();
            string password = txtPassword1.Text.ToString();
            string password2 = txtPassword2.Text.ToString();
            string email = txtEmail.Text.ToString();

            //obtiene la contraseña encriptada desde la función
            string passwords = encryption(password);

            //evalua si los campos estan vacios
            if (username.Length > 0 && password.Length > 0 && nombres.Length > 0 && password2.Length > 0)
            {
                // evalua si el usuario ingresado existe en la BD
                int search = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_UsuarioExiste(username));

                if (search <= 0)
                {
                    //evalúa que las contraseñas introducias coincidan
                    if(password == password2)
                    {
                        try
                        {
                            Clases.VarGlobales.consultasTrans.PR_UsuariosInsert(nombres, username, passwords, email, ckbBloqueado.Checked,Convert.ToInt32(cboPerfiles.SelectedValue), Convert.ToString(cboDivision.Text.Trim()));
                            txtNombres.Text = "";
                            txtUsuario.Text = "";
                            txtPassword1.Text = "";
                            txtPassword2.Text = "";
                            txtEmail.Text = "";
                            lblFooter.Text = "";
                            ckbBloqueado.Checked = false;

                            MessageBox.Show("Usuario Guardado Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string Message = "El Nombre de Usuario ya Existe";
                    lblFooter.Text = Message.ToString();
                }
            }
            else
            {
                string Message = "Llene todos los campos requeridos";
                lblFooter.Text = Message.ToString();
            }
        }

        private void FrmCrearUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Perfiles' Puede moverla o quitarla según sea necesario.
            this.tR_PerfilesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Perfiles);
            cboDivision.SelectedIndex = 0;

        }
    }
}
