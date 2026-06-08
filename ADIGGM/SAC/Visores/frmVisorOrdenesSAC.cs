using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.SAC.Visores
{
    public partial class frmVisorOrdenesSAC : FrmPrincipal
    {
        string cadenaConexion = ADIGGM.CapaDatos.Conexion.Cadena("TransporteAdiggm");
        public frmVisorOrdenesSAC()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.sAC_BuscarAsocTableAdapter.Fill(this.dsCodeasAdiggm.SAC_BuscarAsoc, txtTexto.Text, cboOrdenBusqueda.Text, cboOperador.Text);
        }

        private void frmVisorOrdenesSAC_Load(object sender, EventArgs e)
        {
            cboOperador.SelectedIndex = 1;
            cboOrdenBusqueda.SelectedIndex = 0;
            this.sAC_BuscarAsocTableAdapter.Fill(this.dsCodeasAdiggm.SAC_BuscarAsoc, txtTexto.Text, cboOrdenBusqueda.Text, cboOperador.Text);
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtTexto.Text != "")
                {
                    btnBuscar.PerformClick();
                }
            }
        }
    }
}
