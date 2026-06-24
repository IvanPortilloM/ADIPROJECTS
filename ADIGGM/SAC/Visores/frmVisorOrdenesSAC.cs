using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.Clases;

namespace ADIGGM.SAC.Visores
{
    public partial class frmVisorOrdenesSAC : FrmPrincipal
    {
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        private DataTable _datos;
        public frmVisorOrdenesSAC()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. Visor de solo lectura (dgvVisor.ReadOnly=true).</summary>
        private void ConfigurarColumnas()
        {
            var DC = DataGridViewAutoSizeColumnMode.DisplayedCells;
            var CH = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvVisor.AutoGenerateColumns = false;
            dgvVisor.Columns.Clear();
            dgvVisor.Columns.Add(GridColumnas.Texto("idOrdenFactDataGridViewTextBoxColumn", "IdOrdenFact", "IdOrdenFact", visible: false));
            dgvVisor.Columns.Add(GridColumnas.Texto("numOrdenDataGridViewTextBoxColumn", "NumOrden", "# Orden", width: 78, autoSize: CH));
            dgvVisor.Columns.Add(GridColumnas.Texto("fechaOrdenDataGridViewTextBoxColumn", "FechaOrden", "Fecha", width: 66, autoSize: DC));
            dgvVisor.Columns.Add(GridColumnas.Texto("idProveedorDataGridViewTextBoxColumn", "IdProveedor", "IdProveedor", visible: false));
            dgvVisor.Columns.Add(GridColumnas.Texto("nombreProveedorDataGridViewTextBoxColumn", "NombreProveedor", "Proveedor", width: 89, autoSize: DC));
            dgvVisor.Columns.Add(GridColumnas.Texto("idAsociadoDataGridViewTextBoxColumn", "IdAsociado", "Identidad", width: 87, autoSize: DC));
            dgvVisor.Columns.Add(GridColumnas.Texto("nombreAsociadoDataGridViewTextBoxColumn", "NombreAsociado", "Nombre", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvVisor.Columns.Add(GridColumnas.Texto("tipoOrdenDataGridViewTextBoxColumn", "TipoOrden", "Tipo de Orden", width: 101, autoSize: DC));
            dgvVisor.Columns.Add(GridColumnas.Texto("valorDataGridViewTextBoxColumn", "Valor", "Valor", width: 59, autoSize: DC));
            dgvVisor.Columns.Add(GridColumnas.Check("estadoDataGridViewCheckBoxColumn", "Estado", "Estado", width: 50, autoSize: CH));
            dgvVisor.DataSource = sACBuscarAsocBindingSource;
        }

        /// <summary>Llena el grid con las órdenes SAC filtradas (SP SAC_BuscarAsoc vía RepositorioCodeas).</summary>
        private void BuscarYMostrar()
        {
            _datos = _repoCodeas.BuscarOrdenesSac(txtTexto.Text, cboOrdenBusqueda.Text, cboOperador.Text);
            sACBuscarAsocBindingSource.DataSource = _datos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarYMostrar();
        }

        private void frmVisorOrdenesSAC_Load(object sender, EventArgs e)
        {
            cboOperador.SelectedIndex = 1;
            cboOrdenBusqueda.SelectedIndex = 0;
            BuscarYMostrar();
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
