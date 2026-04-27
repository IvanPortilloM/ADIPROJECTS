using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESUPUESTO.Mantenimiento
{
    public partial class frmTipoContratos : Form
    {
        public frmTipoContratos()
        {
            InitializeComponent();
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void frmTipoContratos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'presupuesto.PR_tipoContratos' Puede moverla o quitarla según sea necesario.
            this.pR_tipoContratosTableAdapter.Fill(this.presupuesto.PR_tipoContratos);

        }
    }
}
