using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Visores
{
    public partial class frmReporteMaestro : Form
    {
        public frmReporteMaestro()
        {
            InitializeComponent();
        }

        private void frmReporteMaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Materiales' Puede moverla o quitarla según sea necesario.
            this.pR_MaterialesTableAdapter.FillByTodo(this.dsPresupuesto.PR_Materiales);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cuentas' Puede moverla o quitarla según sea necesario.
            this.pR_CuentasTableAdapter.FillByTodo(this.dsPresupuesto.PR_Cuentas);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.FillByTodo(this.dsPresupuesto.PR_Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Presupuestos' Puede moverla o quitarla según sea necesario.
           this.pR_AniosTableAdapter.Fill(this.dsPresupuesto.PR_Anios);

            this.pR_PresupuestosTableAdapter.FillByTodo(this.dsPresupuesto.PR_Presupuestos, Convert.ToInt32(cboAño.SelectedValue));

            this.pR_ctaCategoriaTableAdapter.FillByTodo(this.dsPresupuesto.PR_ctaCategoria);

            cboTipoReporte.SelectedIndex = 0;

            if (cboTipoReporte.SelectedItem == "Reporte por Mes")
            {

                this.pR_R_ReporteMaestroTableAdapter.Fill(this.dsPresupuesto.PR_R_ReporteMaestro, Convert.ToInt32(cboAño.SelectedValue), Convert.ToInt32(cboPresupuesto.SelectedValue),
                    Convert.ToInt32(cboDepartamento.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue), Convert.ToInt32(cboMateriales.SelectedValue));

                this.rvPresSemanal.Visible = false;
                this.rvPresMensual.Visible = true;
                this.rvPresMensual.Dock = DockStyle.Fill;

                this.rvPresMensual.RefreshReport();
            }
            else
               if (cboTipoReporte.SelectedItem == "Reporte por Semana")
            {

                this.pR_R_ReporteMaestroTableAdapter.Fill(this.dsPresupuesto.PR_R_ReporteMaestro, Convert.ToInt32(cboAño.SelectedValue), Convert.ToInt32(cboPresupuesto.SelectedValue),
                    Convert.ToInt32(cboDepartamento.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue), Convert.ToInt32(cboMateriales.SelectedValue));

                this.rvPresSemanal.Visible = true;
                this.rvPresMensual.Visible = false;
                this.rvPresSemanal.Dock = DockStyle.Fill;

                this.rvPresSemanal.RefreshReport();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cboTipoReporte.SelectedItem == "Reporte por Mes")
            {

                this.pR_R_ReporteMaestroTableAdapter.Fill(this.dsPresupuesto.PR_R_ReporteMaestro, Convert.ToInt32(cboAño.SelectedValue), Convert.ToInt32(cboPresupuesto.SelectedValue),
                    Convert.ToInt32(cboDepartamento.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue), Convert.ToInt32(cboMateriales.SelectedValue));
                
                this.rvPresSemanal.Visible = false;
                this.rvPresMensual.Visible = true;
                this.rvPresMensual.Dock = DockStyle.Fill;

                this.rvPresMensual.RefreshReport();
            }else
                if (cboTipoReporte.SelectedItem == "Reporte por Semana")
            {

                this.pR_R_ReporteMaestroTableAdapter.Fill(this.dsPresupuesto.PR_R_ReporteMaestro, Convert.ToInt32(cboAño.SelectedValue), Convert.ToInt32(cboPresupuesto.SelectedValue),
                    Convert.ToInt32(cboDepartamento.SelectedValue), Convert.ToInt32(cboCategoria.SelectedValue), Convert.ToInt32(cboCuenta.SelectedValue), Convert.ToInt32(cboMateriales.SelectedValue));
                
                this.rvPresSemanal.Visible = true;
                this.rvPresMensual.Visible = false;
                this.rvPresSemanal.Dock = DockStyle.Fill;

                this.rvPresSemanal.RefreshReport();
            }
        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
