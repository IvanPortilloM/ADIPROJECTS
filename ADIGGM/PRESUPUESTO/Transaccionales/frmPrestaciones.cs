using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Transaccionales
{
    public partial class frmPrestaciones : Form
    {
        int idPresupuesto = 0;
        int idSueldo = 0;
        public frmPrestaciones(int idPresupuesto, int idSueldo)
        {
            InitializeComponent();
            this.idPresupuesto = idPresupuesto;
            this.idSueldo = idSueldo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrestaciones_Load(object sender, EventArgs e)
        {
            this.pR_SelectPrestacionesTableAdapter.Fill(this.dsPresupuesto.PR_SelectPrestaciones, idPresupuesto, dtpCesantia.Value, dtp14Vo.Value);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.pR_SelectPrestacionesTableAdapter.Fill(this.dsPresupuesto.PR_SelectPrestaciones, idPresupuesto, dtpCesantia.Value, dtp14Vo.Value);
        }
    }
}
