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
    public partial class UserDashboard : Form
    {
        public string OfficerName { get; set; }
        public string OfficerID { get; set; }

        public UserDashboard()
        {
            InitializeComponent();
            
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LoadDashboard();
        }

        public UserDashboard(string officerName, string officerID)
        {
            InitializeComponent();
            
            OfficerName = officerName;
            OfficerID = officerID;
            
            // Set officer info in the panel
            lblOfficerName.Text = officerName;
            lblOfficerID.Text = "ID: " + officerID;

            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            this.PnlFormLoader.Controls.Clear();
            frmUserDashboard userDashboard = new frmUserDashboard(OfficerName, OfficerID) 
            { 
                Dock = DockStyle.Fill, 
                TopLevel = false, 
                TopMost = true 
            };
            userDashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(userDashboard);
            userDashboard.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            
            this.PnlFormLoader.Controls.Clear();
            frmUserDashboard userDashboard = new frmUserDashboard(OfficerName, OfficerID) 
            { 
                Dock = DockStyle.Fill, 
                TopLevel = false, 
                TopMost = true 
            };
            userDashboard.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(userDashboard);
            userDashboard.Show();
        }

        private void btnAddCrime_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddCrime.Height;
            pnlNav.Top = btnAddCrime.Top;
            pnlNav.Left = btnAddCrime.Left;
            btnAddCrime.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmUserAddCrime addCrime = new frmUserAddCrime(OfficerName, OfficerID) 
            { 
                Dock = DockStyle.Fill, 
                TopLevel = false, 
                TopMost = true 
            };
            addCrime.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(addCrime);
            addCrime.Show();
        }

        private void btnCrimeTable_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCrimeTable.Height;
            pnlNav.Top = btnCrimeTable.Top;
            pnlNav.Left = btnCrimeTable.Left;
            btnCrimeTable.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmUserCrimeTable crimeTable = new frmUserCrimeTable(OfficerName, OfficerID) 
            { 
                Dock = DockStyle.Fill, 
                TopLevel = false, 
                TopMost = true 
            };
            crimeTable.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(crimeTable);
            crimeTable.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProfile.Height;
            pnlNav.Top = btnProfile.Top;
            pnlNav.Left = btnProfile.Left;
            btnProfile.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmUserProfile profile = new frmUserProfile(OfficerName, OfficerID) 
            { 
                Dock = DockStyle.Fill, 
                TopLevel = false, 
                TopMost = true 
            };
            profile.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(profile);
            profile.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", 
                "Logout Confirmation", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        // Reset button colors on leave
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAddCrime_Leave(object sender, EventArgs e)
        {
            btnAddCrime.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCrimeTable_Leave(object sender, EventArgs e)
        {
            btnCrimeTable.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}