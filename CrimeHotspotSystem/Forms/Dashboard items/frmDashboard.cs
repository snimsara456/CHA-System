using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            // Wire up the custom paint event to draw smooth cards
            pnlTotCrime.Paint += Card_Paint;
            pnlMDA.Paint += Card_Paint;
            pnlCrimeMonth.Paint += Card_Paint;

            SetupDataGridViewStyle();
        }

        // Custom Paint Method to draw beautifully smooth rounded cards
        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear the background to match the form, giving a transparent effect
            e.Graphics.Clear(this.BackColor);

            // Create a slightly inset rectangle for the card
            Rectangle rect = new Rectangle(1, 1, pnl.Width - 3, pnl.Height - 3);
            int radius = 15; // Smooth corner radius

            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            {
                // 1. Fill the main card body with White
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 2. Determine accent color based on which panel is painting
                Color accentColor = Color.Gray;
                if (pnl.Name == "pnlTotCrime") accentColor = Color.Firebrick;
                if (pnl.Name == "pnlMDA") accentColor = Color.Tomato;
                if (pnl.Name == "pnlCrimeMonth") accentColor = Color.DodgerBlue;

                // 3. Draw a modern colored accent strip at the top of the card
                e.Graphics.SetClip(path);
                using (SolidBrush accentBrush = new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(accentBrush, rect.X, rect.Y, rect.Width, 6); // 6px tall strip
                }
                e.Graphics.ResetClip();

                // 4. Draw a very subtle, soft border around the card
                using (Pen pen = new Pen(Color.FromArgb(215, 220, 225), 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // Helper method to calculate the curved edges
        private GraphicsPath GetRoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            path.AddArc(arc, 180, 90); // Top left arc
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90); // Top right arc
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);   // Bottom right arc
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);  // Bottom left arc

            path.CloseFigure();
            return path;
        }

        private void SetupDataGridViewStyle()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(215, 228, 242);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 235, 255);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.GridColor = Color.FromArgb(235, 235, 235);

            dataGridView1.CellPainting += DataGridView1_CellPainting;
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex].Name.Equals("Severity", StringComparison.OrdinalIgnoreCase))
            {
                e.PaintBackground(e.CellBounds, true);

                string severityValue = (e.Value?.ToString() ?? "").Trim();

                if (!string.IsNullOrEmpty(severityValue))
                {
                    Color badgeColor = Color.LightGray;
                    Color textColor = Color.DimGray;

                    if (severityValue.Equals("Low", StringComparison.OrdinalIgnoreCase))
                    {
                        badgeColor = Color.FromArgb(200, 240, 200);
                        textColor = Color.DarkGreen;
                    }
                    else if (severityValue.Equals("Medium", StringComparison.OrdinalIgnoreCase))
                    {
                        badgeColor = Color.FromArgb(255, 230, 180);
                        textColor = Color.DarkOrange;
                    }
                    else if (severityValue.Equals("Critical", StringComparison.OrdinalIgnoreCase))
                    {
                        badgeColor = Color.FromArgb(255, 180, 180);
                        textColor = Color.DarkRed;
                    }

                    Rectangle rect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, e.CellBounds.Width - 10, e.CellBounds.Height - 10);
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int radius = 15;
                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseFigure();

                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        using (SolidBrush brush = new SolidBrush(badgeColor))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }

                    TextRenderer.DrawText(e.Graphics, severityValue, e.CellStyle.Font, rect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    e.Handled = true;
                }
            }
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
        }

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

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] data = line.Split(',');

                        if (data.Length >= 6)
                        {
                            if (!int.TryParse(data[0].Trim(), out int crimeId)) continue;

                            string type = data[1].Trim();

                            if (!DateTime.TryParse(data[2].Trim(), out DateTime dateLogged)) continue;

                            string severity = data[3].Trim();
                            string district = data[4].Trim();
                            string street = data[5].Trim();
                            string division = "";

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
                                    successCount++;
                                else
                                    skipCount++;
                            }
                        }
                    }
                }

                MessageBox.Show($"Import Complete!\n\nSuccessfully Imported: {successCount}\nSkipped (Duplicates): {skipCount}", "Import Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

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