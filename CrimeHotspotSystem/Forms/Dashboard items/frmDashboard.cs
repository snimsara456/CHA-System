using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmDashboard : Form

    {
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
               (
                   int nLeftRect,
                   int nTopRect,
                   int nRightRect,
                   int nBottomRect,
                   int nWidthEllipse,
                   int nHeightEllipse
               );
        public frmDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlTotCrime.Region = Region.FromHrgn(CreateRoundRectRgn
       (
           0,
           0,
           pnlTotCrime.Width,
           pnlTotCrime.Height,
           30,
           30
       ));

            pnlMDA.Region = Region.FromHrgn(CreateRoundRectRgn
     (
         0,
         0,
        pnlMDA.Width,
        pnlMDA.Height,
         30,
         30
     ));

            pnlCrimeMonth.Region = Region.FromHrgn(CreateRoundRectRgn
     (
         0,
         0,
       pnlCrimeMonth.Width,
        pnlCrimeMonth.Height,
         30,
         30
     ));
        }

        private void LoadCrimesData()
        {
            // Replace "YourDatabaseName" and "YourServerName" with your actual local server details.
            // "Server=localhost" or "Server=." usually works for local default instances.
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\BICT\sem 3\VAP\Project\CHA-System-Dev-Akalka\CHA-System-Dev-Akalka\CrimeHotspotSystem\CrimeDB.mdf"";Integrated Security=True";

            // SQL Query to fetch data and sort by Date in descending order
            string query = @"SELECT CrimeID, Type, Date, Severity, District, Division, Street 
                     FROM [dbo].[Crimes] 
                     ORDER BY Date DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable crimesTable = new DataTable();

                            // This opens the connection, executes the query, fills the DataTable, and closes the connection.
                            adapter.Fill(crimesTable);

                            // Bind the populated DataTable to your DataGridView
                            dataGridView1.DataSource = crimesTable;
                        }
                    }
                }

                // Optional: Auto-resize columns to fit the data cleanly
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                // Display any database connection or execution errors
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardMetrics()
        {
            // Adjust this connection string if your CrimeDB.mdf is located elsewhere
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\BICT\sem 3\VAP\Project\CHA-System-Dev-Akalka\CHA-System-Dev-Akalka\CrimeHotspotSystem\CrimeDB.mdf"";Integrated Security=True";

            // 1. Query for Total Crimes (Counts all rows)
            string queryTotal = "SELECT COUNT(CrimeID) FROM [dbo].[Crimes]";

            // 2. Query for Most Dangerous Area by Division (Groups by Division and orders by the highest count)
            string queryDangerous = "SELECT TOP 1 Division FROM [dbo].[Crimes] GROUP BY Division ORDER BY COUNT(CrimeID) DESC";

            // 3. Query for Crimes This Month (Matches the month and year of the Crime Date to the current system date)
            string queryThisMonth = "SELECT COUNT(CrimeID) FROM [dbo].[Crimes] WHERE MONTH(Date) = MONTH(GETDATE()) AND YEAR(Date) = YEAR(GETDATE())";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get Total Crimes
                    using (SqlCommand cmdTotal = new SqlCommand(queryTotal, connection))
                    {
                        object resultTotal = cmdTotal.ExecuteScalar();
                        lblTotCrimes.Text = (resultTotal != DBNull.Value && resultTotal != null) ? resultTotal.ToString() : "0";
                    }

                    // Get Most Dangerous Area (Division)
                    using (SqlCommand cmdDangerous = new SqlCommand(queryDangerous, connection))
                    {
                        object resultDangerous = cmdDangerous.ExecuteScalar();
                        // If there are no crimes, it might return null, so we handle that with "N/A"
                        lblDangerous.Text = (resultDangerous != DBNull.Value && resultDangerous != null) ? resultDangerous.ToString() : "N/A";
                    }

                    // Get Crimes This Month
                    using (SqlCommand cmdThisMonth = new SqlCommand(queryThisMonth, connection))
                    {
                        object resultThisMonth = cmdThisMonth.ExecuteScalar();
                        lblThisMonthCrimes.Text = (resultThisMonth != DBNull.Value && resultThisMonth != null) ? resultThisMonth.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred loading dashboard metrics: " + ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadCrimesData();
            LoadDashboardMetrics();
        }
    }
}
