using System;
using System.Windows.Forms;
using CrimeHotspotSystem.Forms;

namespace CrimeHotspotSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboardadmin = new AdminDashboard();  
            dashboardadmin.Show();
            this.Hide();
        }
    }
}
