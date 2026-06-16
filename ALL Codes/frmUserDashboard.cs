using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmUserDashboard : Form
    {
        private string officerName;
        private string officerID;
        private DataTable crimeData;
        
        public frmUserDashboard(string name, string id)
        {
            InitializeComponent();
            officerName = name;
            officerID = id;
            LoadCrimeData();
            DisplayRecentCrimes();
        }

        private void LoadCrimeData()
        {
            // Sample crime data - In real application, load from database
            crimeData = new DataTable();
            crimeData.Columns.Add("CrimeType");
            crimeData.Columns.Add("Location");
            crimeData.Columns.Add("Area");
            crimeData.Columns.Add("Date");
            crimeData.Columns.Add("HandledBy");

            // Sample data
            crimeData.Rows.Add("Theft", "Main Street", "Downtown", DateTime.Now.AddDays(-1), "Officer Smith");
            crimeData.Rows.Add("Assault", "Park Avenue", "Northside", DateTime.Now.AddDays(-2), "Officer Johnson");
            crimeData.Rows.Add("Burglary", "Oak Road", "Eastside", DateTime.Now.AddDays(-3), "Officer Williams");
            crimeData.Rows.Add("Vandalism", "Elm Street", "Westside", DateTime.Now.AddDays(-4), "Officer Brown");
            crimeData.Rows.Add("Robbery", "Central Square", "Downtown", DateTime.Now.AddDays(-5), "Officer Davis");
        }

        private void DisplayRecentCrimes()
        {
            dgvRecentCrimes.DataSource = crimeData;
            
            // Customize DataGridView
            dgvRecentCrimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentCrimes.BackgroundColor = Color.White;
            dgvRecentCrimes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 126, 249);
            dgvRecentCrimes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRecentCrimes.RowHeadersVisible = false;
            dgvRecentCrimes.AllowUserToAddRows = false;
            dgvRecentCrimes.AllowUserToDeleteRows = false;
            dgvRecentCrimes.ReadOnly = true;

            // Add status column
            DataGridViewButtonColumn statusColumn = new DataGridViewButtonColumn();
            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.Text = "View Details";
            statusColumn.UseColumnTextForButtonValue = true;
            dgvRecentCrimes.Columns.Add(statusColumn);
        }

        private void dgvRecentCrimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRecentCrimes.Columns["Status"].Index && e.RowIndex >= 0)
            {
                string crimeType = dgvRecentCrimes.Rows[e.RowIndex].Cells["CrimeType"].Value.ToString();
                string location = dgvRecentCrimes.Rows[e.RowIndex].Cells["Location"].Value.ToString();
                string area = dgvRecentCrimes.Rows[e.RowIndex].Cells["Area"].Value.ToString();
                string date = dgvRecentCrimes.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                string handledBy = dgvRecentCrimes.Rows[e.RowIndex].Cells["HandledBy"].Value.ToString();

                MessageBox.Show($"Crime Details:\n\nType: {crimeType}\nLocation: {location}\nArea: {area}\nDate: {date}\nHandled By: {handledBy}", 
                    "Crime Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}