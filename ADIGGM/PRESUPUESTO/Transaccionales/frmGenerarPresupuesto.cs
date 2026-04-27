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
    public partial class frmGenerarPresupuesto : Form
    {
        public frmGenerarPresupuesto()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int resultado;
            resultado = Convert.ToInt32(Clases.VarGlobales.consultasPR.PR_GenerarPres(int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                     Clases.VarGlobales.IdUsuario,
                                                                      int.Parse(cboAño.SelectedValue.ToString()),
                                                                      txtObservacion.Text));
            if (resultado == 0)
            {
                MessageBox.Show("El presupuesto se ha creado correctamente.", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);          
            }
            else 
            {
                MessageBox.Show("No se pudo generar el presupuesto, debido a que existen presupuestos abiertos y/o aprobados.",Clases.VarGlobales.nombreSistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
  
            }
        }

        private void frmGenerarPresupuesto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.FillByUsuario(this.dsPresupuesto.PR_Departamentos, Clases.VarGlobales.IdUsuario);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Anios' Puede moverla o quitarla según sea necesario.
            this.pR_AniosTableAdapter.Fill(this.dsPresupuesto.PR_Anios);
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
