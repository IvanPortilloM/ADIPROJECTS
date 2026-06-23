using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.SAC
{
    public partial class FrmAsocBuscar : ADIGGM.FrmPrincipal
    {
        string CadenaBusqueda = "";
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        public IContract contrato { get; set; }
        public FrmAsocBuscar()
        {
            InitializeComponent();
            ConfigurarColumnas();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvAsoc);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. Grid de solo lectura (selección de asociado); el .cs usa
        /// Cells["cidasociad"] → Name exacto. Replica las 34 columnas (5 visibles) del diseño.</summary>
        private void ConfigurarColumnas()
        {
            dgvAsoc.AutoGenerateColumns = false;
            dgvAsoc.Columns.Clear();
            dgvAsoc.Columns.Add(GridColumnas.Texto("cidasociad", "cidasociad", "Identificación", width: 106, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombreasoDataGridViewTextBoxColumn", "cnombreaso", "Nombre", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvAsoc.Columns.Add(GridColumnas.Texto("ccedulasocDataGridViewTextBoxColumn", "ccedulasoc", "Cédula", width: 73, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvAsoc.Columns.Add(GridColumnas.Texto("dfechasaliDataGridViewTextBoxColumn", "dfechasali", "dfechasali", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombcondaDataGridViewTextBoxColumn", "cnombconda", "Estátus", width: 69, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombinstiDataGridViewTextBoxColumn", "cnombinsti", "cnombinsti", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombdeptoDataGridViewTextBoxColumn", "cnombdepto", "cnombdepto", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombdivisDataGridViewTextBoxColumn", "cnombdivis", "cnombdivis", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombtipopDataGridViewTextBoxColumn", "cnombtipop", "cnombtipop", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cteletrabaDataGridViewTextBoxColumn", "cteletraba", "cteletraba", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("ctelecelulDataGridViewTextBoxColumn", "ctelecelul", "ctelecelul", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cextentrabDataGridViewTextBoxColumn", "cextentrab", "cextentrab", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cteledomicDataGridViewTextBoxColumn", "cteledomic", "cteledomic", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cdireccasoDataGridViewTextBoxColumn", "cdireccaso", "cdireccaso", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("nsalarioasDataGridViewTextBoxColumn", "nsalarioas", "nsalarioas", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("nsalarioneDataGridViewTextBoxColumn", "nsalarione", "nsalarione", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cmuestclavDataGridViewTextBoxColumn", "cmuestclav", "cmuestclav", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cconoccomoDataGridViewTextBoxColumn", "cconoccomo", "cconoccomo", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cemailasocDataGridViewTextBoxColumn", "cemailasoc", "cemailasoc", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("crutafotoaDataGridViewTextBoxColumn", "crutafotoa", "crutafotoa", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cclavelocaDataGridViewTextBoxColumn", "cclaveloca", "cclaveloca", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnomfamcomDataGridViewTextBoxColumn", "cnomfamcom", "cnomfamcom", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("ctelefamiDataGridViewTextBoxColumn", "ctelefami", "ctelefami", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("nporcbenefDataGridViewTextBoxColumn", "nporcbenef", "nporcbenef", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cctabancasDataGridViewTextBoxColumn", "cctabancas", "N° Cuenta", width: 89, autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvAsoc.Columns.Add(GridColumnas.Texto("aniosDataGridViewTextBoxColumn", "anios", "anios", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("mesesDataGridViewTextBoxColumn", "meses", "meses", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("diasDataGridViewTextBoxColumn", "dias", "dias", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombrecomDataGridViewTextBoxColumn", "cnombrecom", "cnombrecom", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("ccoddelegaDataGridViewTextBoxColumn", "ccoddelega", "ccoddelega", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("cnombredelDataGridViewTextBoxColumn", "cnombredel", "cnombredel", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("dfechaingaDataGridViewTextBoxColumn", "dfechainga", "dfechainga", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("dfechanaciDataGridViewTextBoxColumn", "dfechanaci", "dfechanaci", visible: false));
            dgvAsoc.Columns.Add(GridColumnas.Texto("dfechaingcDataGridViewTextBoxColumn", "dfechaingc", "dfechaingc", visible: false));
            dgvAsoc.DataSource = cODSlcASMaestrasBindingSource;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Sin fila seleccionada (búsqueda sin resultados) no se hace nada en vez de reventar.
            if (dgvAsoc.CurrentRow == null) return;
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
            cODSlcASMaestrasBindingSource.DataSource = _repoCodeas.BuscarAsociados(cadena);
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
