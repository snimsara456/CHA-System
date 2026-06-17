
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

            pnlTotCrime.Region = Region.FromHrgn(CreateRoundRectRgn(
               0, 0, pnlTotCrime.Width, pnlTotCrime.Height, 30, 30));

            pnlMDA.Region = Region.FromHrgn(CreateRoundRectRgn(
               0, 0, pnlMDA.Width, pnlMDA.Height, 30, 30));

            pnlCrimeMonth.Region = Region.FromHrgn(CreateRoundRectRgn(
               0, 0, pnlCrimeMonth.Width, pnlCrimeMonth.Height, 30, 30));
        }

        private void LoadCrimesData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gs\Downloads\CHA-System-main\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

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
                            adapter.Fill(crimesTable);
                            dataGridView1.DataSource = crimesTable;
                        }
                    }
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardMetrics()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gs\Downloads\CHA-System-main\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

            string queryTotal = "SELECT COUNT(CrimeID) FROM [dbo].[Crimes]";
            string queryDangerous = "SELECT TOP 1 Division FROM [dbo].[Crimes] GROUP BY Division ORDER BY COUNT(CrimeID) DESC";
            string queryThisMonth = "SELECT COUNT(CrimeID) FROM [dbo].[Crimes] WHERE MONTH(Date) = MONTH(GETDATE()) AND YEAR(Date) = YEAR(GETDATE())";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmdTotal = new SqlCommand(queryTotal, connection))
                    {
                        object resultTotal = cmdTotal.ExecuteScalar();
                        lblTotCrimes.Text = (resultTotal != DBNull.Value && resultTotal != null) ? resultTotal.ToString() : "0";
                    }

                    using (SqlCommand cmdDangerous = new SqlCommand(queryDangerous, connection))
                    {
                        object resultDangerous = cmdDangerous.ExecuteScalar();
                        lblDangerous.Text = (resultDangerous != DBNull.Value && resultDangerous != null) ? resultDangerous.ToString() : "N/A";
                    }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Leave empty or add logic if needed
        }

        // --- NEW IMPORT LOGIC STARTS HERE ---

        private void btnimport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV Files|*.csv", Title = "Select Crimes CSV File" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImportCrimesFromCSV(ofd.FileName);
                }
            }
        }

        private void ImportCrimesFromCSV(string filePath)
        {
            int successCount = 0;
            int skipCount = 0;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gs\Downloads\CHA-System-main\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                if (lines.Length <= 1)
                {
                    MessageBox.Show("The selected file is empty or contains only headers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Start at i = 1 to skip the header row in the CSV
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // Split the row by commas
                        string[] data = line.Split(',');

                        // Make sure the row has at least the 6 columns
                        if (data.Length >= 6)
                        {
                            // Parse Data
                            if (!int.TryParse(data[0].Trim(), out int crimeId)) continue;

                            string type = data[1].Trim();

                            if (!DateTime.TryParse(data[2].Trim(), out DateTime dateLogged)) continue;

                            string severity = data[3].Trim();
                            string district = data[4].Trim();
                            string street = data[5].Trim();

                            // Division is kept blank if your CSV doesn't have it
                            string division = "";

                            // Insert into Database safely (Checking for duplicates using IF NOT EXISTS)
                            string query = @"
                                IF NOT EXISTS (SELECT 1 FROM Crimes WHERE CrimeID = @CrimeID)
                                BEGIN
                                    INSERT INTO Crimes (CrimeID, Type, Date, Severity, District, Division, Street)
                                    VALUES (@CrimeID, @Type, @Date, @Severity, @District, @Division, @Street)
                                END";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@CrimeID", crimeId);
                                cmd.Parameters.AddWithValue("@Type", type);
                                cmd.Parameters.AddWithValue("@Date", dateLogged.Date);
                                cmd.Parameters.AddWithValue("@Severity", severity);
                                cmd.Parameters.AddWithValue("@District", district);
                                cmd.Parameters.AddWithValue("@Division", division);
                                cmd.Parameters.AddWithValue("@Street", street);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                    successCount++; // Successfully inserted
                                else
                                    skipCount++;    // Skipped because CrimeID already exists
                            }
                        }
                    }
                }

                // Show Results
                MessageBox.Show($"Import Complete!\n\nSuccessfully Imported: {successCount}\nSkipped (Duplicates): {skipCount}", "Import Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the Dashboard Data and Metrics!
                LoadCrimesData();
                LoadDashboardMetrics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
