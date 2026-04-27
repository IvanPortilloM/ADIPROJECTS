using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    public partial class frm_Genero : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frm_Genero()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvGenero);
        }
        public void HabilitarBtn()
        {
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void frm_Genero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Genero' Puede moverla o quitarla según sea necesario.
            this.pR_GeneroTableAdapter.Fill(this.dsPresupuesto.PR_Genero);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvGenero.Rows.Count > 0 && dgvGenero.FirstDisplayedCell != null)
            {
                saveRow = dgvGenero.FirstDisplayedCell.RowIndex;
                dgvGenero.ReadOnly = false;
                dgvGenero.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvGenero.Rows.Count)
                dgvGenero.FirstDisplayedScrollingRowIndex = saveRow;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGenero.Rows.Count > 0 && dgvGenero.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvGenero.CurrentRow.Index;
                    dgvGenero.EndEdit();
                    this.pR_GeneroTableAdapter.Update(this.dsPresupuesto.PR_Genero);
                    dgvGenero.CurrentCell = dgvGenero.Rows[selectedIndex].Cells[1];
                    dgvGenero.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvGenero.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvGenero.Rows.Count > 0 && dgvGenero.FirstDisplayedCell != null)
            {
                selectedIndex = dgvGenero.CurrentRow.Index;

                this.pR_GeneroTableAdapter.Fill(this.dsPresupuesto.PR_Genero);
                dgvGenero.CurrentCell = dgvGenero.Rows[selectedIndex].Cells[1];
                dgvGenero.AllowUserToAddRows = false;

                dgvGenero.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
