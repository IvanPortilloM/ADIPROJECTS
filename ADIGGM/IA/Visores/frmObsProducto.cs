using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.IA.Visores
{
    public partial class frmObsProducto : FrmPrincipal
    {
        string PrmCnumasient, PrmCtipasient;
        public frmObsProducto(string PrmCnumasient, string PrmCtipasient)
        {
            InitializeComponent();
            this.PrmCnumasient = PrmCnumasient;
            this.PrmCtipasient = PrmCtipasient;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmObsProducto_Load(object sender, EventArgs e)
        {
            txtObs.Text = new ADIGGM.CapaDatos.RepositorioCA().ObtenerObservacionAsiento(PrmCnumasient, PrmCtipasient);
        }
    }
}
