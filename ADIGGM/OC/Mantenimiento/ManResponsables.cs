using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ADIGGM.Clases;
using Formularios_Base;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManResponsables : FrmMantenimiento
    {
        public ManResponsables()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvResponsables);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void ManResponsables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Responsables' Puede moverla o quitarla según sea necesario.
            this.oC_ResponsablesTableAdapter.Fill(this.dsOC.OC_Responsables);
            lblFooter.Text = "Responsables - #Registros: " + dgvResponsables.RowCount;
            dgvResponsables.RowTemplate.Height = 40;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResponsables.RowCount > 0)
            {
                dgvResponsables.CurrentRow.Cells["Usuario"].Value = VarGlobales.Usuario;
                dgvResponsables.CurrentRow.Cells["NombreEquipo"].Value = System.Environment.MachineName;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvResponsables.AllowUserToAddRows = true;
            dgvResponsables.ReadOnly = false;
            dgvResponsables.FirstDisplayedScrollingRowIndex = dgvResponsables.RowCount - 1;
            var cantidadRow = dgvResponsables.RowCount - 1;
            dgvResponsables.CurrentCell = dgvResponsables.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResponsables.Rows.Count > 0 && dgvResponsables.FirstDisplayedCell != null)
                {
                    dgvResponsables.EndEdit();
                    this.oC_ResponsablesTableAdapter.Update(this.dsOC.OC_Responsables);
                    dgvResponsables.CurrentCell = dgvResponsables.Rows[dgvResponsables.CurrentRow.Index].Cells[2];
                    dgvResponsables.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvResponsables.ReadOnly = true;
                    lblFooter.Text = "Responsables - #Registros: " + (dgvResponsables.RowCount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvResponsables.Rows.Count > 0 && dgvResponsables.FirstDisplayedCell != null)
            {
                saveRow = dgvResponsables.FirstDisplayedCell.RowIndex;
                dgvResponsables.ReadOnly = false;
                dgvResponsables.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvResponsables.Rows.Count)
                dgvResponsables.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvResponsables.Rows.Count > 0 && dgvResponsables.FirstDisplayedCell != null)
            {
                this.oC_ResponsablesTableAdapter.Fill(this.dsOC.OC_Responsables);
                dgvResponsables.CurrentCell = dgvResponsables.Rows[dgvResponsables.CurrentRow.Index].Cells[2];
                dgvResponsables.AllowUserToAddRows = false;

                dgvResponsables.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                lblFooter.Text = "Responsables - #Registros: " + (dgvResponsables.RowCount);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResponsables_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResponsables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResponsables.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                if (e.ColumnIndex == dgvResponsables.Columns["Firma"].Index && dgvResponsables.ReadOnly == false)
                {
                    Stream myStream = null;
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Image File(*.jpe; *.jpeg; *.png) | *.jpg;*.jpeg;*.png";
                    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            if ((myStream = openFileDialog.OpenFile()) != null)
                            {
                                string FileName = openFileDialog.FileName;
                                if (myStream.Length > 512000)
                                {
                                    MessageBox.Show("El tamaño de la imagen es demasiado grande");
                                }
                                else
                                {
                                    dgvResponsables.CurrentRow.Cells[3].Value = Image.FromFile(openFileDialog.FileName);
                                    //dgvResponsables.EndEdit();
                                    //this.oC_ResponsablesTableAdapter.Update(this.dsOC.OC_Responsables);
                                    //this.oC_ResponsablesTableAdapter.Fill(this.dsOC.OC_Responsables);
                                }
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}
