using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ADIGGM
{
    public partial class FrmPrincipal : Form
    {
        public int xClick = 0, yClick = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.Dock == DockStyle.Fill)
            {
                this.Dock = DockStyle.None;
            }
            else
            {
                this.Dock = DockStyle.Fill;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (this.Dock == DockStyle.None)
            {
                restaurarToolStripMenuItem.Text = "Maximizar";
            }
            else
            if(this.Dock == DockStyle.Fill)
            {
                restaurarToolStripMenuItem.Text = "Restaurar";
            }
            if(this.btnMin.Visible == false)
            {
                minimizarToolStripMenuItem.Visible = false;
            }
            if (this.btnMax.Visible == false)
            {
                restaurarToolStripMenuItem.Visible = false;
            }
            if (this.btnCerrar.Visible == false)
            {
                salirToolStripMenuItem.Visible = false;
            }
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Dock == DockStyle.Fill)
            {
                this.Dock = DockStyle.None;
                restaurarToolStripMenuItem.Text = "Maximizar";
            }
            else
            {
                this.Dock = DockStyle.Fill;
                restaurarToolStripMenuItem.Text = "Restaurar";
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    if (this.Dock == DockStyle.Fill)
            //    {
            //        restaurarToolStripMenuItem.Text = "Maximizar";
            //    }
            //    else
            //    {
            //        restaurarToolStripMenuItem.Text = "Restaurar";
            //    }
            //}
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
