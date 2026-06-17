using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmReport : Form
    {
        #region Fields

        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\richa\Downloads\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

        // Data sources
        private DataTable _currentTable = new DataTable();
        private string _currentView = "Crimes"; // "Crimes" or "Users"

        // Dynamic Controls
        private Label lblCriticalCount;
        private Label lblCategoryCount;
        private Label lblAreaCount;
        private Label lblMonthCount;
        private Label lblTotalCount;

        private TextBox txtSearch;
        private DataGridView dgvMain;
        private RadioButton rbCrimes;
        private RadioButton rbUsers;

        #endregion

        #region Constructor

        public frmReport()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Load

        private void frmReport_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 244, 248);
            BuildCompleteDynamicUI();
            LoadMetricsData();
            LoadGridData("Crimes"); // Default load
        }

        #endregion

        #region UI Generator (100% Code-Based)

        private void BuildCompleteDynamicUI()
        {
            // 1. Build Top Metrics Cards
            string[] titles = { "Total Critical Crimes", "Most Common Category", "Most Dangerous Area", "Crimes This Month", "Total Crimes" };
            System.Windows.Forms.Label[] targetLabels = {
                lblCriticalCount = new System.Windows.Forms.Label(),
                lblCategoryCount = new System.Windows.Forms.Label(),
                lblAreaCount = new System.Windows.Forms.Label(),
                lblMonthCount = new System.Windows.Forms.Label(),
                lblTotalCount = new System.Windows.Forms.Label()
            };

            int startX = 20;
            int startY = 20;
            int cardWidth = 145;
            int cardHeight = 90;
            int spacing = 15;

            for (int i = 0; i < titles.Length; i++)
            {
                int currentX = startX + (i * (cardWidth + spacing));

                Panel cardPanel = new Panel
                {
                    Location = new Point(currentX, startY),
                    Size = new Size(cardWidth, cardHeight),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.None
                };

                System.Windows.Forms.Label lblTitle = new System.Windows.Forms.Label
                {
                    Text = titles[i],
                    AutoSize = false,
                    Size = new Size(cardWidth - 10, 25),
                    Location = new Point(5, 12),
                    Font = new System.Drawing.Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(127, 140, 141),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                System.Windows.Forms.Label lblCount = targetLabels[i];
                lblCount.Text = "0";
                lblCount.AutoSize = false;
                lblCount.Size = new Size(cardWidth - 10, 40);
                lblCount.Location = new Point(5, 40);
                lblCount.Font = new System.Drawing.Font("Segoe UI", 22F, FontStyle.Bold);
                lblCount.ForeColor = Color.FromArgb(41, 128, 185);
                lblCount.TextAlign = ContentAlignment.MiddleCenter;

                cardPanel.Controls.Add(lblTitle);
                cardPanel.Controls.Add(lblCount);
                this.Controls.Add(cardPanel);
            }

            // 2. Build Controls Bar (Radio Buttons, Search, Export Buttons)
            int controlY = 130;

            rbCrimes = new RadioButton { Text = "📋 Crime Reports", Location = new Point(20, controlY), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9.5F, FontStyle.Bold), Checked = true };
            rbUsers = new RadioButton { Text = "👥 User Reports", Location = new Point(170, controlY), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9.5F, FontStyle.Bold) };

            rbCrimes.CheckedChanged += (s, e) => { if (rbCrimes.Checked) { _currentView = "Crimes"; LoadGridData("Crimes"); } };
            rbUsers.CheckedChanged += (s, e) => { if (rbUsers.Checked) { _currentView = "Users"; LoadGridData("Users"); } };

            System.Windows.Forms.Label lblSearch = new System.Windows.Forms.Label { Text = "🔍 Search:", Location = new Point(310, controlY + 2), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9.5F, FontStyle.Bold) };
            txtSearch = new TextBox { Location = new Point(390, controlY), Size = new Size(150, 25), Font = new System.Drawing.Font("Segoe UI", 10F) };
            txtSearch.TextChanged += TxtSearch_TextChanged;

            Button btnExcel = new Button { Text = "📊 Excel", Location = new Point(560, controlY - 5), Size = new Size(110, 35), BackColor = Color.FromArgb(46, 204, 113), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold), Cursor = Cursors.Hand };
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.Click += BtnExcel_Click;

            Button btnPdf = new Button { Text = "📕 PDF", Location = new Point(680, controlY - 5), Size = new Size(110, 35), BackColor = Color.FromArgb(231, 76, 60), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold), Cursor = Cursors.Hand };
            btnPdf.FlatAppearance.BorderSize = 0;
            btnPdf.Click += BtnPdf_Click;

            this.Controls.Add(rbCrimes);
            this.Controls.Add(rbUsers);
            this.Controls.Add(lblSearch);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnExcel);
            this.Controls.Add(btnPdf);

            // 3. Build DataGridView
            dgvMain = new DataGridView
            {
                Location = new Point(20, 180),
                Size = new Size(770, 450),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BorderStyle = BorderStyle.None,
                BackgroundColor = Color.White,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 249);
            dgvMain.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMain.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvMain.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMain.RowTemplate.Height = 32;

            this.Controls.Add(dgvMain);
        }

        #endregion

        #region Data Loading

        private void LoadMetricsData()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    lblTotalCount.Text = FetchCount("SELECT COUNT(*) FROM Crimes", conn);
                    lblCriticalCount.Text = FetchCount("SELECT COUNT(*) FROM Crimes WHERE Severity = 'Critical'", conn);
                    lblCategoryCount.Text = FetchCount("SELECT COUNT(*) FROM Crimes WHERE Severity = 'High'", conn);
                    lblAreaCount.Text = FetchCount("SELECT COUNT(*) FROM Crimes WHERE Severity = 'Medium'", conn);
                    lblMonthCount.Text = FetchCount("SELECT COUNT(*) FROM Crimes WHERE MONTH(Date) = MONTH(GETDATE()) AND YEAR(Date) = YEAR(GETDATE())", conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load metrics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadGridData(string tableName)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "";

                    if (tableName == "Crimes")
                    {
                        query = "SELECT CrimeID AS [ID], Type AS [Crime Type], Date AS [Date Logged], Severity AS [Severity Level], District AS [District], Street AS [Street] FROM Crimes";
                    }
                    else if (tableName == "Users")
                    {
                        query = "SELECT Id AS [ID], Username, FullName AS [Full Name], NIC, Phone, Rank FROM Users";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    // Creates a fresh DataTable so columns don't overlap when switching views
                    _currentTable = new DataTable();

                    // Reset columns to bind fresh data
                    dgvMain.Columns.Clear();
                    da.Fill(_currentTable);
                    dgvMain.DataSource = _currentTable;

                    // Dynamically inject a CheckBox column for selection
                    DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn
                    {
                        Name = "Select",
                        HeaderText = "Select",
                        Width = 60,
                        ReadOnly = false,
                        TrueValue = true,
                        FalseValue = false
                    };
                    dgvMain.Columns.Insert(0, chkCol);

                    // Make data columns read-only, but checkbox clickable
                    foreach (DataGridViewColumn col in dgvMain.Columns)
                    {
                        if (col.Name != "Select") col.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to populate data grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string FetchCount(string query, SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object obj = cmd.ExecuteScalar();
                return obj != null ? obj.ToString() : "0";
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvMain.DataSource != null)
            {
                DataView dv = _currentTable.DefaultView;
                string filter = txtSearch.Text.Trim().Replace("'", "''");

                if (_currentView == "Crimes")
                {
                    dv.RowFilter = string.Format("[Crime Type] LIKE '%{0}%' OR [District] LIKE '%{0}%' OR [Severity Level] LIKE '%{0}%'", filter);
                }
                else
                {
                    dv.RowFilter = string.Format("[Username] LIKE '%{0}%' OR [Full Name] LIKE '%{0}%' OR [NIC] LIKE '%{0}%'", filter);
                }
            }
        }

        #endregion

        #region Custom Export Logic (Checked Rows Only)

        private DataTable GetSelectedData()
        {
            // Create a clone of the table structure
            DataTable exportTable = _currentTable.Clone();

            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                // Check if the checkbox is checked
                bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);

                if (isSelected)
                {
                    DataRow newRow = exportTable.NewRow();
                    // Copy data (ignoring the checkbox column which is at index 0 in the Grid, but not in DataTable)
                    for (int i = 0; i < _currentTable.Columns.Count; i++)
                    {
                        newRow[i] = row.Cells[i + 1].Value;
                    }
                    exportTable.Rows.Add(newRow);
                }
            }
            return exportTable;
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            dgvMain.EndEdit(); // Ensure all checkbox states are committed
            DataTable dataToExport = GetSelectedData();

            if (dataToExport.Rows.Count == 0)
            {
                MessageBox.Show("Please check (select) at least one row to export!", "Selection Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|*.csv", FileName = $"Custom_{_currentView}_Report_{DateTime.Now:yyyyMMdd}" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();

                        // 1. Headers
                        string[] columnNames = new string[dataToExport.Columns.Count];
                        for (int i = 0; i < dataToExport.Columns.Count; i++)
                        {
                            columnNames[i] = dataToExport.Columns[i].ColumnName;
                        }
                        sb.AppendLine(string.Join(",", columnNames));

                        // 2. Data Rows
                        foreach (DataRow row in dataToExport.Rows)
                        {
                            string[] fields = new string[dataToExport.Columns.Count];
                            for (int i = 0; i < dataToExport.Columns.Count; i++)
                            {
                                fields[i] = row[i].ToString().Replace(",", " ");
                            }
                            sb.AppendLine(string.Join(",", fields));
                        }

                        // 3. Save
                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString());

                        MessageBox.Show($"Selected {_currentView} successfully exported to Excel.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            dgvMain.EndEdit(); // Ensure all checkbox states are committed
            DataTable dataToExport = GetSelectedData();

            if (dataToExport.Rows.Count == 0)
            {
                MessageBox.Show("Please check (select) at least one row to export!", "Selection Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = $"Custom_{_currentView}_Report_{DateTime.Now:yyyyMMdd}" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;

                Document doc = new Document(PageSize.A4.Rotate(), 15f, 15f, 20f, 20f);
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    Paragraph title = new Paragraph($"CUSTOM {_currentView.ToUpper()} REPORT\n", FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK)) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(title);

                    Paragraph metadata = new Paragraph($"Generated On: {DateTime.Now:yyyy-MM-dd HH:mm:ss} | Total Selected: {dataToExport.Rows.Count}\n\n", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.ITALIC, BaseColor.GRAY)) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(metadata);

                    PdfPTable pdfTable = new PdfPTable(dataToExport.Columns.Count) { WidthPercentage = 100 };

                    foreach (DataColumn col in dataToExport.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE)))
                        {
                            BackgroundColor = new BaseColor(44, 62, 80),
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            Padding = 8
                        };
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataRow row in dataToExport.Rows)
                    {
                        foreach (var cellValue in row.ItemArray)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(cellValue.ToString(), FontFactory.GetFont("Arial", 9))) { Padding = 6 };
                            pdfTable.AddCell(cell);
                        }
                    }

                    doc.Add(pdfTable);
                    MessageBox.Show($"Selected {_currentView} successfully exported to PDF.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF generation error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    doc.Close();
                }
            }
        }

        #endregion
    }
}