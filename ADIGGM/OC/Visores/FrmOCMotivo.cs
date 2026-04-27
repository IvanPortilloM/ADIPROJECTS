using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.OC.Visores
{
    public partial class FrmOCMotivo : FrmPrincipal
    {
        int clic = 0;
        public FrmOCMotivo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.Green;
            VisOCSolicitudes motivo = Owner as VisOCSolicitudes;
            Close();
        }
    }
}
