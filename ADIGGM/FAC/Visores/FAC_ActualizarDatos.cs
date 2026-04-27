using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;

namespace ADIGGM.FAC.Visores
{
    public partial class FAC_ActualizarDatos : ADIGGM.FrmPrincipal
    {
        int IdFactura = 0;
        public FAC_ActualizarDatos(int IdFactura)
        {
            InitializeComponent();
            this.IdFactura = IdFactura;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string text1 = "", text2 = "", text3 = "";
            VarGlobales.consultasFAC.FAC_ActualizarDatos(IdFactura, txtOrden.Text, txtSAG.Text, txtNProforma.Text, ref text1, ref text2, ref text3, 1);
            MessageBox.Show("Datos actualizados!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FAC_ActualizarDatos_Load(object sender, EventArgs e)
        {
            string text1="", text2="", text3 = "";
            VarGlobales.consultasFAC.FAC_ActualizarDatos(IdFactura, "", "", "", ref text1, ref text2, ref text3, 2);
            txtOrden.Text = text1;
            txtSAG.Text = text2;
            txtNProforma.Text = text3;
        }
    }
}
