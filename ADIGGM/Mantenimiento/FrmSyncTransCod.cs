using System;
using System.Drawing;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmSyncTransCod : FrmPrincipal, IContract
    {
        private readonly RepositorioCodeas _repo = new RepositorioCodeas();
        int IdCierre, IdCliente, IdTipoFac;
        DateTime FechaInicio, FechaFin;
        string Usuario = Clases.VarGlobales.Usuario;
        public FrmSyncTransCod()
        {
            InitializeComponent();
            ConfigurarColumnas();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            Clases.VarGlobales varGlobales = new Clases.VarGlobales();
            DgvStyle.EstiloDgv(dgvAsiento);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Grid de solo lectura (visor del asiento contable).</summary>
        private void ConfigurarColumnas()
        {
            const DataGridViewAutoSizeColumnMode fill = DataGridViewAutoSizeColumnMode.Fill;
            const DataGridViewAutoSizeColumnMode dc = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsiento.AutoGenerateColumns = false;
            dgvAsiento.Columns.Clear();
            dgvAsiento.Columns.Add(GridColumnas.Texto("cuentaContable", "CuentaContable", "Cuenta Contable", autoSize: fill));
            dgvAsiento.Columns.Add(GridColumnas.Texto("descripcion", "Descripcion", "Descripción", autoSize: fill));
            dgvAsiento.Columns.Add(GridColumnas.Texto("debe", "Debe", "Debe", format: "C2", width: 62, autoSize: dc));
            dgvAsiento.Columns.Add(GridColumnas.Texto("haber", "Haber", "Haber", format: "C2", width: 66, autoSize: dc));
            dgvAsiento.Columns.Add(GridColumnas.Texto("nDoc", "NDoc", "N° Doc.", width: 72, autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader));
            dgvAsiento.Columns.Add(GridColumnas.Texto("detalle", "Detalle", "Detalle", autoSize: fill));
        }

        private void CargarTipoAsiento()
        {
            cODSlcTipoAsientoBindingSource.DataMember = "";
            cODSlcTipoAsientoBindingSource.DataSource = _repo.ListarTipoAsiento();
        }
        public void Ejecutar1(string Var1)
        {

        }
        public void Ejecutar(int Var1, int Var2, int Var3, DateTime Fec1, DateTime Fec2, string Var4)
        {
            this.IdCierre = Var1;
            this.IdCliente = Var2;
            this.IdTipoFac = Var3;
            this.FechaInicio = Fec1;
            this.FechaFin = Fec2;
        }
        public void LlenarDgv()
        {
            double Debe = 0, Haber = 0;
            pRSyncTransCodBindingSource.DataMember = "";
            pRSyncTransCodBindingSource.DataSource = _repo.ListarSyncTransCod(IdCierre, IdCliente, IdTipoFac, txtFactura.Text, txtAbvFac.Text, txtDetHeader.Text);
            dgvAsiento.DataSource = pRSyncTransCodBindingSource;
            CargarTipoAsiento();
            if (dgvAsiento.RowCount > 0)
            {
                btnVerificarCta.Enabled = true;
                VistaPrev();
                foreach (DataGridViewRow row in dgvAsiento.Rows)
                {
                    Debe += Convert.ToDouble($"{row.Cells["debe"].Value:n}");
                    Haber += Convert.ToDouble($"{row.Cells["haber"].Value:n}"); 
                }
            }
            else
            {
                btnVerificarCta.Enabled = false;
            }
            txtDebe.Text = $"{Debe:n}";
            txtHaber.Text = $"{Haber:n}";
            txtDif.Text = $"{Convert.ToDouble(txtHaber.Text) - Convert.ToDouble(txtDebe.Text):n}";
            if((Convert.ToDecimal(txtHaber.Text) - Convert.ToDecimal(txtDebe.Text)) != 0)
            {
                txtDif.BackColor = Color.Red;
            }
            else
            {
                txtDif.BackColor = Color.LightSteelBlue;
            }
        }
        private void btnActualizarHeader_Click(object sender, EventArgs e)
        {
            LlenarDgv();
        }
        private void btnBuscarCierre_Click(object sender, EventArgs e)
        {
            FrmCierresBuscar cierresBuscar = new FrmCierresBuscar();
            cierresBuscar.contrato = this;
            if (cierresBuscar.ShowDialog(this) == DialogResult.OK)
            {
                LlenarDgv();
                btnSync.Enabled = false;
            }
        }
        private void VistaPrev()
        {
            if (txtFactura.TextLength > 0 && txtDetHeader.TextLength > 0 && dgvAsiento.RowCount > 0)
            {
                txtVistaPrev.Text = txtFactura.Text +" "+ txtDetHeader.Text + " DEL " + FechaInicio.ToString("dd/MM/yyyy") + " AL " + FechaFin.ToString("dd/MM/yyyy");
            }
            else
            {
                txtVistaPrev.Text = "";
            }
        }
        private void txtDetHeader_TextChanged(object sender, EventArgs e)
        {
            VistaPrev();
        }
        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
            VistaPrev();
        }
        private void btnVerificarCta_Click(object sender, EventArgs e)
        {
            if (dgvAsiento.RowCount > 0)
            {
                int NoExiste = 0;
                foreach (DataGridViewRow row in dgvAsiento.Rows)
                {
                    if (_repo.VerificarCuentaContable(row.Cells["cuentaContable"].Value.ToString()) == 0)
                    {
                        MessageBox.Show("La siguiente Cuenta Contable no existe en el sistema de CODEAS: " + row.Cells["cuentaContable"].Value.ToString(), Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSync.Enabled = false;
                        NoExiste = 1;
                        break;
                    }
                }
                 if(NoExiste < 1)
                {
                    lblFooter.Text = "Verificación de Cuentas Contables Finalizada Exitosamente";

                    Timer timer1 = new Timer();
                    timer1.Interval = 10000;

                    timer1.Tick += (s, a) =>
                    {
                        ((Timer)s).Stop();
                        lblFooter.Text = "";
                    };

                    timer1.Start();
                    btnSync.Enabled = true;
                }
            }
        }
        private void btnSync_Click(object sender, EventArgs e)
        {
                if (dgvAsiento.RowCount > 0 && txtFactura.TextLength > 0 && txtAbvFac.TextLength > 0 && txtDetHeader.TextLength > 0)
                {
                DialogResult dialogResult =
                MessageBox.Show("Se Sincronizarán los Datos con el Sistema de CODEAS ¿Desea Continuar?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    _repo.GuardarSyncTransCod(IdCierre, IdCliente, IdTipoFac, txtFactura.Text, txtAbvFac.Text, txtDetHeader.Text, txtNumAsiento.Text, dtpFecha.Value, Usuario);
                    lblFooter.Text = "Datos Sincronizados Exitosamente";
                    IdCliente = 0;
                    IdCierre = 0;
                    IdTipoFac = 0;
                    txtFactura.Text = "";
                    txtAbvFac.Text = "";
                    txtDetHeader.Text = "";
                    CargarTipoAsiento();
                    LlenarDgv();
                    txtFactura.Focus();

                    Timer timer1 = new Timer();
                    timer1.Interval = 10000;

                    timer1.Tick += (s, a) =>
                    {
                        ((Timer)s).Stop();
                        lblFooter.Text = "";
                    };

                    timer1.Start();
                }
                }
                else
                {
                    lblFooter.Text = "Favor Llene Todos los Campos Requeridos";
                    txtFactura.Focus();
                    CargarTipoAsiento();

                    Timer timer1 = new Timer();
                    timer1.Interval = 10000;

                    timer1.Tick += (s, a) => {
                        ((Timer)s).Stop();
                        lblFooter.Text = "";
                    };
                    timer1.Start();
                }
        }
        private void FrmSyncTransCod_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            CargarTipoAsiento();
            txtFactura.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}