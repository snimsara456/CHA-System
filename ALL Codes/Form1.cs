using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PoliceInformationSystem
{
    public partial class Form1 : Form
    {
        // Data storage
        private List<CrimeRecord> crimeRecords;
        private List<PoliceOfficer> policeOfficers;
        private string currentOfficerName;
        private string currentOfficerID;

        // UI Controls
        private Label lblTitle;
        private Label lblOfficerName;
        private TextBox txtOfficerName;
        private Label lblOfficerID;
        private TextBox txtOfficerID;
        private Button btnLogin;
        private Label lblWelcome;
        private Label lblRecentCrimes;
        private ListBox lstRecentCrimes;
        private Label lblCrimeTable;
        private DataGridView dgvCrimeTable;
        private Button btnAddCrime;
        private GroupBox grpAddCrime;
        private Label lblCrimeName;
        private TextBox txtCrimeName;
        private Label lblCrimeArea;
        private TextBox txtCrimeArea;
        private Label lblHandledOfficer;
        private TextBox txtHandledOfficer;
        private Button btnSaveCrime;
        private Button btnRefresh;
        private Label lblStatus;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupUI();
        }

        private void InitializeComponent()
        {
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 700);
            this.Text = "Police Information System";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeData()
        {
            // Initialize sample data
            crimeRecords = new List<CrimeRecord>();
            policeOfficers = new List<PoliceOfficer>();

            // Add sample police officers
            policeOfficers.Add(new PoliceOfficer { Name = "John Smith", ID = "P001" });
            policeOfficers.Add(new PoliceOfficer { Name = "Sarah Johnson", ID = "P002" });
            policeOfficers.Add(new PoliceOfficer { Name = "Mike Wilson", ID = "P003" });

            // Add sample crime records
            crimeRecords.Add(new CrimeRecord 
            { 
                CrimeName = "Theft", 
                Area = "Downtown", 
                HandledOfficer = "John Smith",
                DateReported = DateTime.Now.AddDays(-2)
            });
            crimeRecords.Add(new CrimeRecord 
            { 
                CrimeName = "Vandalism", 
                Area = "East Side", 
                HandledOfficer = "Sarah Johnson",
                DateReported = DateTime.Now.AddDays(-1)
            });
            crimeRecords.Add(new CrimeRecord 
            { 
                CrimeName = "Robbery", 
                Area = "West End", 
                HandledOfficer = "Mike Wilson",
                DateReported = DateTime.Now.AddDays(-3)
            });
            crimeRecords.Add(new CrimeRecord 
            { 
                CrimeName = "Assault", 
                Area = "North District", 
                HandledOfficer = "John Smith",
                DateReported = DateTime.Now.AddDays(-5)
            });
        }

        private void SetupUI()
        {
            // Set form properties
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10F);

            // Title Label
            lblTitle = new Label
            {
                Text = "POLICE INFORMATION SYSTEM",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.Navy,
                Location = new Point(300, 20),
                Size = new Size(400, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblTitle);

            // Officer Name Label
            lblOfficerName = new Label
            {
                Text = "Officer Name:",
                Location = new Point(50, 80),
                Size = new Size(120, 25),
                TextAlign = ContentAlignment.MiddleRight
            };
            this.Controls.Add(lblOfficerName);

            // Officer Name TextBox
            txtOfficerName = new TextBox
            {
                Location = new Point(180, 80),
                Size = new Size(200, 25),
                Font = new Font("Segoe UI", 10F)
            };
            this.Controls.Add(txtOfficerName);

            // Officer ID Label
            lblOfficerID = new Label
            {
                Text = "Officer ID:",
                Location = new Point(400, 80),
                Size = new Size(120, 25),
                TextAlign = ContentAlignment.MiddleRight
            };
            this.Controls.Add(lblOfficerID);

            // Officer ID TextBox
            txtOfficerID = new TextBox
            {
                Location = new Point(530, 80),
                Size = new Size(200, 25),
                Font = new Font("Segoe UI", 10F)
            };
            this.Controls.Add(txtOfficerID);

            // Login Button
            btnLogin = new Button
            {
                Text = "Login",
                Location = new Point(750, 78),
                Size = new Size(100, 30),
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            // Welcome Label
            lblWelcome = new Label
            {
                Text = "Please login to continue",
                Font = new Font("Segoe UI", 12F, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(50, 120),
                Size = new Size(400, 30)
            };
            this.Controls.Add(lblWelcome);

            // Recent Crimes Section
            lblRecentCrimes = new Label
            {
                Text = "Recent Crime Areas",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Navy,
                Location = new Point(50, 170),
                Size = new Size(200, 25)
            };
            this.Controls.Add(lblRecentCrimes);

            // Recent Crimes ListBox
            lstRecentCrimes = new ListBox
            {
                Location = new Point(50, 200),
                Size = new Size(250, 200),
                Font = new Font("Segoe UI", 10F)
            };
            this.Controls.Add(lstRecentCrimes);

            // Crime Table Label
            lblCrimeTable = new Label
            {
                Text = "Crime Records",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Navy,
                Location = new Point(320, 170),
                Size = new Size(200, 25)
            };
            this.Controls.Add(lblCrimeTable);

            // Crime DataGridView
            dgvCrimeTable = new DataGridView
            {
                Location = new Point(320, 200),
                Size = new Size(630, 200),
                BackgroundColor = Color.White,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            this.Controls.Add(dgvCrimeTable);

            // Add Crime Button
            btnAddCrime = new Button
            {
                Text = "Add New Crime",
                Location = new Point(50, 420),
                Size = new Size(150, 30),
                BackColor = Color.ForestGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Enabled = false
            };
            btnAddCrime.Click += BtnAddCrime_Click;
            this.Controls.Add(btnAddCrime);

            // Refresh Button
            btnRefresh = new Button
            {
                Text = "Refresh Data",
                Location = new Point(220, 420),
                Size = new Size(120, 30),
                BackColor = Color.DarkOrange,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnRefresh.Click += BtnRefresh_Click;
            this.Controls.Add(btnRefresh);

            // Add Crime Group Box
            grpAddCrime = new GroupBox
            {
                Text = "Add New Crime Record",
                Location = new Point(50, 460),
                Size = new Size(900, 180),
                Visible = false,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            this.Controls.Add(grpAddCrime);

            // Crime Name
            lblCrimeName = new Label
            {
                Text = "Crime Name:",
                Location = new Point(30, 40),
                Size = new Size(120, 25),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 10F)
            };
            grpAddCrime.Controls.Add(lblCrimeName);

            txtCrimeName = new TextBox
            {
                Location = new Point(160, 40),
                Size = new Size(200, 25),
                Font = new Font("Segoe UI", 10F)
            };
            grpAddCrime.Controls.Add(txtCrimeName);

            // Crime Area
            lblCrimeArea = new Label
            {
                Text = "Crime Area:",
                Location = new Point(30, 80),
                Size = new Size(120, 25),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 10F)
            };
            grpAddCrime.Controls.Add(lblCrimeArea);

            txtCrimeArea = new TextBox
            {
                Location = new Point(160, 80),
                Size = new Size(200, 25),
                Font = new Font("Segoe UI", 10F)
            };
            grpAddCrime.Controls.Add(txtCrimeArea);

            // Handled Officer
            lblHandledOfficer = new Label
            {
                Text = "Handled Officer:",
                Location = new Point(30, 120),
                Size = new Size(120, 25),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 10F)
            };
            grpAddCrime.Controls.Add(lblHandledOfficer);

            txtHandledOfficer = new TextBox
            {
                Location = new Point(160, 120),
                Size = new Size(200, 25),
                Font = new Font("Segoe UI", 10F)
            };
            grpAddCrime.Controls.Add(txtHandledOfficer);

            // Save Crime Button
            btnSaveCrime = new Button
            {
                Text = "Save Crime",
                Location = new Point(450, 70),
                Size = new Size(150, 40),
                BackColor = Color.ForestGreen,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnSaveCrime.Click += BtnSaveCrime_Click;
            grpAddCrime.Controls.Add(btnSaveCrime);

            // Cancel Button
            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(620, 70),
                Size = new Size(150, 40),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnCancel.Click += (s, e) =>
            {
                grpAddCrime.Visible = false;
                btnAddCrime.Enabled = true;
                ClearAddCrimeFields();
            };
            grpAddCrime.Controls.Add(btnCancel);

            // Status Label
            lblStatus = new Label
            {
                Text = "Status: Ready",
                Location = new Point(50, 650),
                Size = new Size(900, 25),
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = Color.DarkGray
            };
            this.Controls.Add(lblStatus);

            // Load initial data
            RefreshCrimeTable();
            UpdateRecentCrimes();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name = txtOfficerName.Text.Trim();
            string id = txtOfficerID.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter both Officer Name and ID.", "Login Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate officer
            var officer = policeOfficers.FirstOrDefault(o => 
                o.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && 
                o.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (officer != null)
            {
                currentOfficerName = officer.Name;
                currentOfficerID = officer.ID;
                lblWelcome.Text = $"Welcome, Officer {officer.Name}! (ID: {officer.ID})";
                lblWelcome.ForeColor = Color.Green;
                btnAddCrime.Enabled = true;
                txtHandledOfficer.Text = officer.Name;
                txtHandledOfficer.Enabled = false;
                UpdateStatus($"Logged in as: {officer.Name}");
                MessageBox.Show($"Login successful! Welcome Officer {officer.Name}.", 
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Officer Name or ID. Please try again.", 
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblWelcome.Text = "Login failed. Please try again.";
                lblWelcome.ForeColor = Color.Red;
            }
        }

        private void BtnAddCrime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOfficerName))
            {
                MessageBox.Show("Please login first.", "Access Denied", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grpAddCrime.Visible = true;
            btnAddCrime.Enabled = false;
            txtCrimeName.Focus();
            UpdateStatus("Enter new crime details");
        }

        private void BtnSaveCrime_Click(object sender, EventArgs e)
        {
            string crimeName = txtCrimeName.Text.Trim();
            string area = txtCrimeArea.Text.Trim();
            string handledOfficer = txtHandledOfficer.Text.Trim();

            if (string.IsNullOrEmpty(crimeName) || string.IsNullOrEmpty(area))
            {
                MessageBox.Show("Please fill in Crime Name and Crime Area.", 
                    "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new crime record
            crimeRecords.Add(new CrimeRecord
            {
                CrimeName = crimeName,
                Area = area,
                HandledOfficer = handledOfficer,
                DateReported = DateTime.Now
            });

            // Update UI
            RefreshCrimeTable();
            UpdateRecentCrimes();
            ClearAddCrimeFields();
            grpAddCrime.Visible = false;
            btnAddCrime.Enabled = true;
            
            UpdateStatus($"New crime '{crimeName}' added successfully!");
            MessageBox.Show($"Crime record added successfully!\nCrime: {crimeName}\nArea: {area}", 
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCrimeTable();
            UpdateRecentCrimes();
            UpdateStatus("Data refreshed successfully");
        }

        private void RefreshCrimeTable()
        {
            dgvCrimeTable.DataSource = null;
            dgvCrimeTable.DataSource = crimeRecords
                .OrderByDescending(c => c.DateReported)
                .Select(c => new
                {
                    c.CrimeName,
                    c.Area,
                    c.HandledOfficer,
                    DateReported = c.DateReported.ToString("MM/dd/yyyy HH:mm")
                })
                .ToList();

            // Set column headers
            dgvCrimeTable.Columns["CrimeName"].HeaderText = "Crime Name";
            dgvCrimeTable.Columns["Area"].HeaderText = "Area";
            dgvCrimeTable.Columns["HandledOfficer"].HeaderText = "Handled Officer";
            dgvCrimeTable.Columns["DateReported"].HeaderText = "Date Reported";
        }

        private void UpdateRecentCrimes()
        {
            lstRecentCrimes.Items.Clear();
            var recentAreas = crimeRecords
                .OrderByDescending(c => c.DateReported)
                .Take(5)
                .Select(c => $"{c.Area} - {c.CrimeName} (by {c.HandledOfficer})")
                .ToList();

            if (recentAreas.Count == 0)
            {
                lstRecentCrimes.Items.Add("No crimes reported yet");
            }
            else
            {
                foreach (var area in recentAreas)
                {
                    lstRecentCrimes.Items.Add(area);
                }
            }
        }

        private void ClearAddCrimeFields()
        {
            txtCrimeName.Text = "";
            txtCrimeArea.Text = "";
            if (!string.IsNullOrEmpty(currentOfficerName))
            {
                txtHandledOfficer.Text = currentOfficerName;
            }
            else
            {
                txtHandledOfficer.Text = "";
            }
        }

        private void UpdateStatus(string message)
        {
            lblStatus.Text = $"Status: {message}";
        }
    }

    // Data Models
    public class PoliceOfficer
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }

    public class CrimeRecord
    {
        public string CrimeName { get; set; }
        public string Area { get; set; }
        public string HandledOfficer { get; set; }
        public DateTime DateReported { get; set; }
    }
}