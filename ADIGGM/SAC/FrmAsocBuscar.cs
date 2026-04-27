using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;

namespace ADIGGM.SAC
{
    public partial class FrmAsocBuscar : ADIGGM.FrmPrincipal
    {
        string CadenaBusqueda = "";
        public IContract contrato { get; set; }
        public FrmAsocBuscar()
        {
            InitializeComponent();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvAsoc);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            contrato.Ejecutar(0,0,0,DateTime.Now,DateTime.Now,
               dgvAsoc.CurrentRow.Cells["cidasociad"].Value.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAsocBuscar_Load(object sender, EventArgs e)
        {
            LlenarDgv(CadenaBusqueda);
        }

        private void LlenarDgv(string cadena)
        {
            this.cOD_SlcASMaestrasTableAdapter.FillByAsoc(this.dsCodeasAdiggm.COD_SlcASMaestras, cadena);
        }

        private void txtAsocBuscar_TextChanged(object sender, EventArgs e)
        {
            LlenarDgv(CadenaBusqueda);
        }

        private void txtAsocBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CadenaBusqueda = txtAsocBuscar.Text;
        }

        private void txtAsocBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            CadenaBusqueda = txtAsocBuscar.Text;
        }

        private void txtAsocBuscar_Leave(object sender, EventArgs e)
        {
            LlenarDgv(CadenaBusqueda);
        }
    }
}
