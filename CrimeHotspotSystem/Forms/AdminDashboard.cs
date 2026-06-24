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
using CrimeHotspotSystem.Forms.Dashboard_items;

namespace CrimeHotspotSystem.Forms
{
    public partial class AdminDashboard : Form
    {
        private Color sidebarColor = Color.FromArgb(34, 40, 52);
        private Color activeBtnColor = Color.FromArgb(220, 235, 255);
        private Color inactiveBtnColor = Color.FromArgb(34, 40, 52);

        public AdminDashboard()
        {
            InitializeComponent();

            SetActiveButton(btnDashboard);

            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

            this.FormClosing += (sender, e) => { Application.Exit(); };
        }

        private void SetActiveButton(Button btn)
        {
            btnDashboard.BackColor = inactiveBtnColor;
            btnDashboard.ForeColor = Color.White;
            btnAddCrime.BackColor = inactiveBtnColor;
            btnAddCrime.ForeColor = Color.White;
            btnReport.BackColor = inactiveBtnColor;
            btnReport.ForeColor = Color.White;
            btnAddusers.BackColor = inactiveBtnColor;
            btnAddusers.ForeColor = Color.White;
            btnProfile.BackColor = inactiveBtnColor;
            btnProfile.ForeColor = Color.White;

            btn.BackColor = activeBtnColor;
            btn.ForeColor = Color.FromArgb(34, 40, 52);

            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();

            lblUserName.Text = !string.IsNullOrEmpty(GlobalVariables.LoggedInUserID)
                               ? GlobalVariables.LoggedInUserID
                               : "Unknown User";

            if (string.Equals(GlobalVariables.userRole.Trim(), "REGULAR", StringComparison.OrdinalIgnoreCase))
            {
                btnReport.Enabled = false;
                btnAddusers.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAddCrime);
            this.PnlFormLoader.Controls.Clear();
            frmAddCrimes frmAddCrimes_vrb = new frmAddCrimes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddCrimes_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAddCrimes_vrb);
            frmAddCrimes_vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReport);
            this.PnlFormLoader.Controls.Clear();
            frmReport frmReport_vrb = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReport_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmReport_vrb);
            frmReport_vrb.Show();
        }

        private void btnAddusers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAddusers);
            this.PnlFormLoader.Controls.Clear();
            frmAddusers frmAddusers_vrb = new frmAddusers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddusers_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAddusers_vrb);
            frmAddusers_vrb.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProfile);
            this.PnlFormLoader.Controls.Clear();
            frmProfile frmProfile_vrb = new frmProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProfile_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmProfile_vrb);
            frmProfile_vrb.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Beautified Date & Time format with soft emojis
            lblDate.Text = "📅  " + DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            lblTime.Text = "🕒  " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnDashboard_Leave(object sender, EventArgs e) { }
        private void btnAddCrime_Leave(object sender, EventArgs e) { }
        private void btnReport_Leave(object sender, EventArgs e) { }
        private void btnAddusers_Leave(object sender, EventArgs e) { }
        private void btnProfile_Leave(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pnlNav_Paint(object sender, PaintEventArgs e) { }
        private void PnlFormLoader_Paint(object sender, PaintEventArgs e) { }
    }
}