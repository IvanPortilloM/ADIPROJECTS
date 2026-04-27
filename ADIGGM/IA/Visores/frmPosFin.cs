using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.IA.Visores
{
    public partial class frmPosFin : FrmPrincipal
    {
        string Nombre;
        decimal TotalAport = 0, TotalCred = 0;
        public frmPosFin(string Nombre,decimal TotalAport, decimal TotalCred)
        {
            InitializeComponent();
            this.Nombre = Nombre;
            this.TotalAport = TotalAport;
            this.TotalCred = TotalCred;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPosFin_Load(object sender, EventArgs e)
        {
            txtNombre.Text = Nombre;
            txtProd.Text = "Total de Productos: " + TotalAport.ToString("N2");
            txtCred.Text = "Total de Créditos: " + TotalCred.ToString("N2");
            txtPosFin.Text = "Posición Financiera Neta: " + (TotalAport - TotalCred).ToString("N2");
            foreach (var series in chartPosFin.Series)
            {
                series.Points.Clear();
            }
            chartPosFin.Series["Posicion"].Points.AddXY("Patrimonio", TotalAport);
            chartPosFin.Series["Posicion"].Points.AddXY("Créditos", TotalCred);
        }
    }
}