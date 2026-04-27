using System;

namespace ADIGGM.OC.Visores
{
    public partial class VisCxP : ADIGGM.FrmPrincipal
    {
        int opcion = 0;
        public VisCxP()
        {
            InitializeComponent();
        }

        private void VisCxP_Load(object sender, EventArgs e)
        {
            if (rdbTodas.Checked == true)
            {
                opcion = 2;
            }
            else if (rdbActivas.Checked == true)
            {
                opcion = 1;
            }
            else if (rdbCanceladas.Checked == true)
            {
                opcion = 0;
            }
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillByTodos(this.dsOC.OC_Proveedores);

            this.cP_CxPVisorTableAdapter.Fill(dsOC.CP_CxPVisor, int.Parse(cboProveedor.SelectedValue.ToString()), dtpDesde.Value.Date, dtpHasta.Value.Date, chkTodos.Checked, opcion);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (rdbTodas.Checked == true)
            {
                opcion = 2;
            }
            else if (rdbActivas.Checked == true)
            {
                opcion = 1;
            }
            else if (rdbCanceladas.Checked == true)
            {
                opcion = 0;
            }
            this.cP_CxPVisorTableAdapter.Fill(dsOC.CP_CxPVisor, int.Parse(cboProveedor.SelectedValue.ToString()), dtpDesde.Value.Date, dtpHasta.Value.Date, chkTodos.Checked, opcion);
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            OC.Transacciones.TranAbonar tranAbonar = new Transacciones.TranAbonar();
            tranAbonar.ShowDialog(this);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (rdbTodas.Checked == true)
            {
                opcion = 2;
            }
            else if (rdbActivas.Checked == true)
            {
                opcion = 1;
            }
            else if (rdbCanceladas.Checked == true)
            {
                opcion = 0;
            }
            Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(-1, dtpDesde.Value.Date.ToString(),
                                                                               dtpHasta.Value.Date.ToString(),
                                                                               0,
                                                                               int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                               "",
                                                                               "",
                                                                               "",
                                                                               opcion,
                                                                               0,
                                                                               "",
                                                                               chkTodos.Checked);
            reporte.ShowDialog();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(-4, dtpDesde.Value.Date.ToString(),
                                                                               dtpHasta.Value.Date.ToString(),
                                                                               0,
                                                                               int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                               "",
                                                                               "",
                                                                               "",
                                                                               opcion,
                                                                               0,
                                                                               "",
                                                                               chkTodos.Checked);
            reporte.ShowDialog();
        }
    }
}
