using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.ReportFormItems
{
    public partial class CrimeDetails : Form
    {
        public CrimeDetails()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboardadmin = new AdminDashboard();
            dashboardadmin.Show();
            this.Hide();
        }
    }
}
