using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Transaccionales
{
    public partial class FrmAcciones : ADIGGM.FrmPrincipal
    {
        public FrmAcciones()
        {
            InitializeComponent();
        }

        private void FrmAcciones_Load(object sender, EventArgs e)
        {

        }

        private void mskId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string t = mskId.Text.Replace("-", "");
                t = t.Replace(" ", "");
                if (t != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void mskId_Leave(object sender, EventArgs e)
        {
            //if (Editar == false && EditarDatosAct == false)
            //{
                //LlenarDgv();
                string t = mskId.Text.Replace("-", "");
                t = t.Replace(" ", "");
                //if (t != "")
                //{
                //    btnEstado.Enabled = true;
                //}
                //else if (t == "")
                //    btnEstado.Enabled = false;
            //}
        }
    }
}
