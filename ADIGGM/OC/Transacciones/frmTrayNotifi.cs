using System;
using System.Drawing;
using System.ServiceProcess;
using System.Timers;
using System.Windows.Forms;

namespace ADIGGM.OC.Transacciones
{
    public partial class frmTrayNotifi : Form
    {
        private static NotifyIcon notifyIcon;

        private ServiceController serviceController;
        private System.Timers.Timer timer;
        public frmTrayNotifi()
        {
            InitializeComponent();

            if (notifyIcon == null)
            {
                notifyIcon = new NotifyIcon();
                notifyIcon.Icon = new Icon("logo_adi_ggm.ico");
                notifyIcon.Visible = true;
            }

            try
            {
                serviceController = new ServiceController("WSCorreos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
            timer.Interval = 300000; // check every 5 minutes
            timer.Start();

            UpdateNotifyIcon();
            // Subscribe to the FormClosing event
            FormClosing += frmTrayNotifi_FormClosing;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateNotifyIcon();
        }

        private void UpdateNotifyIcon()
        {
            serviceController.Refresh(); // refresh the status of the service

            if (serviceController.Status == ServiceControllerStatus.Running)
            {
                notifyIcon.Icon = SystemIcons.Application; // TODO: Replace with your own icon
                notifyIcon.Text = "WSCorreos está activo.";
            }
            else
            {
                notifyIcon.Icon = SystemIcons.Error; // TODO: Replace with your own icon
                notifyIcon.Text = "WSCorreos no está activo.";
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cancel the event so the form stays hidden
            e.Cancel = true;
            // Hide the form instead of closing it
            this.Hide();
        }

        private void frmTrayNotifi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the event so the form stays hidden
            e.Cancel = true;
            // Hide the form instead of closing it
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Unsubscribe from the FormClosing event
            this.FormClosing -= this.frmTrayNotifi_FormClosing;
            // Close the application
            Application.Exit();
        }
    }
}
