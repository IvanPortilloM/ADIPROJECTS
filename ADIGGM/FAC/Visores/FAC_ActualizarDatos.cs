using System;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.FAC.Visores
{
    public partial class FAC_ActualizarDatos : ADIGGM.FrmPrincipal
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();
        int IdFactura = 0;
        public FAC_ActualizarDatos(int IdFactura)
        {
            InitializeComponent();
            this.IdFactura = IdFactura;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _repo.ActualizarDatosFactura(IdFactura, txtOrden.Text, txtSAG.Text, txtNProforma.Text, 1);
            MessageBox.Show("Datos actualizados!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FAC_ActualizarDatos_Load(object sender, EventArgs e)
        {
            var datos = _repo.ActualizarDatosFactura(IdFactura, "", "", "", 2);
            txtOrden.Text = datos.NumOrden;
            txtSAG.Text = datos.NumSAG;
            txtNProforma.Text = datos.NumProforma;
        }
    }
}
