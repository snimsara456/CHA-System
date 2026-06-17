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
       


        public AdminDashboard()
        {
            InitializeComponent();
           
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();

            
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddCrime.Height;
            pnlNav.Top = btnAddCrime.Top;
            pnlNav.Left = btnAddCrime.Left;
            btnAddCrime.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmAddCrimes frmAddCrimes_vrb = new frmAddCrimes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddCrimes_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAddCrimes_vrb);
            frmAddCrimes_vrb.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        
        

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnReport.Height;
            pnlNav.Top = btnReport.Top;
            pnlNav.Left = btnReport.Left;
            btnReport.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmReport frmReport_vrb = new frmReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmReport_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmReport_vrb);
            frmReport_vrb.Show();
        }

        private void btnAddusers_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddusers.Height;
            pnlNav.Top = btnAddusers.Top;
            pnlNav.Left = btnAddusers.Left;
            btnAddusers.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmAddusers frmAddusers_vrb = new frmAddusers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddusers_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmAddusers_vrb);
            frmAddusers_vrb.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmProfile frmProfile_vrb = new frmProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProfile_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmProfile_vrb);
            frmProfile_vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAddCrime_Leave(object sender, EventArgs e)
        {
            btnAddCrime.BackColor = Color.FromArgb(24, 30, 54);
        }

        

        private void btnReport_Leave(object sender, EventArgs e)
        {
            btnReport.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAddusers_Leave(object sender, EventArgs e)
        {
            btnAddusers.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMDA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
