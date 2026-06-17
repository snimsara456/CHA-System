using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmReport : Form
    {
        // ඔබේ Connection String එක මෙතන තියෙනවා. වැඩ කරන්නේ නැත්නම් එක පාරක් check කරන්න.
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kavix haresh\Downloads\CHA-System-Dev-Nirmal\CHA-System-Dev-Nirmal\CrimeHotspotSystem\CrimeDB.mdf"";Integrated Security=True";

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            StyleDashboardLabels();
            LoadReportStatistics();
        }

        private void StyleDashboardLabels()
        {
            // මෙතන label6 සිට label10 දක්වා ඔබේ UI එකේ ඇති නම් වලටම ගැලපෙනවාදැයි බලාගන්න.
            Label[] labels = { label6, label7, label8, label9, label10 };

            foreach (Label lbl in labels)
            {
                if (lbl != null)
                {
                    lbl.AutoSize = false;
                    lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                    lbl.ForeColor = Color.FromArgb(41, 128, 185);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void LoadReportStatistics()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // 1. Critical Crimes Count
                    string queryCritical = "SELECT COUNT(*) FROM Crimes WHERE Severity = 'Critical'";
                    ExecuteQuery(queryCritical, connection, label6);

                    // 2. Most Common Category
                    string queryCommon = "SELECT TOP 1 Type FROM Crimes GROUP BY Type ORDER BY COUNT(*) DESC";
                    ExecuteQuery(queryCommon, connection, label7);

                    // 3. Most Dangerous Area
                    string queryDangerous = "SELECT TOP 1 District FROM Crimes GROUP BY District ORDER BY COUNT(*) DESC";
                    ExecuteQuery(queryDangerous, connection, label8);

                    // 4. Crimes This Month
                    string queryMonth = "SELECT COUNT(*) FROM Crimes WHERE MONTH(Date) = MONTH(GETDATE()) AND YEAR(Date) = YEAR(GETDATE())";
                    ExecuteQuery(queryMonth, connection, label9);

                    // 5. Total Crimes
                    string queryTotal = "SELECT COUNT(*) FROM Crimes";
                    ExecuteQuery(queryTotal, connection, label10);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading statistics: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method to execute and assign
        private void ExecuteQuery(string query, SqlConnection conn, Label targetLabel)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                targetLabel.Text = result != null ? result.ToString() : "0";
            }
        }

        // --- මෙන්න මේ ටික තමයි Error එක නැති කරන්න ඕනේ වෙන්නේ (Empty Event Handlers) ---
        private void button1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void button2_Click_1(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void frmReport_Load_1(object sender, EventArgs e)
        {

        }
    }
}