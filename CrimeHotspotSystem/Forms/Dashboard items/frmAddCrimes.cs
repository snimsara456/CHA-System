using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmAddCrimes : Form
    {
        public frmAddCrimes()
        {
            InitializeComponent();

            // Wire up the custom paint events for our modern flat cards
            pnlCrimeInfo.Paint += Card_Paint;
            pnlLocation.Paint += Card_Paint;
        }

        private void frmAddCrimes_Load(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Basic Validation
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Please enter at least the Crime Type and Case Reference No (CrimeID).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtID.Text, out int crimeId))
            {
                MessageBox.Show("Case Reference No (CrimeID) must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Determine Severity Level from Radio Buttons
            string severity = "";
            if (radioLow.Checked) severity = "Low";
            else if (radioMedium.Checked) severity = "Medium";
            else if (radioHigh.Checked) severity = "High";
            else if (radioCritical.Checked) severity = "Critical";

            // 3. Database Connection and Insert Logic
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gs\Downloads\CHA-System-main\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

            string query = @"INSERT INTO [dbo].[Crimes] 
                             (CrimeID, Type, Date, Severity, District, Division, Street) 
                             VALUES 
                             (@CrimeID, @Type, @Date, @Severity, @District, @Division, @Street)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CrimeID", crimeId);
                        command.Parameters.AddWithValue("@Type", txtType.Text.Trim());
                        command.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                        command.Parameters.AddWithValue("@Severity", severity);
                        command.Parameters.AddWithValue("@District", txtDistict.Text.Trim());
                        command.Parameters.AddWithValue("@Division", txtDevision.Text.Trim());
                        command.Parameters.AddWithValue("@Street", txtLocation.Text.Trim());

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Crime record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("A crime record with this Case Reference No already exists. Please use a unique ID.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Clear all text boxes
            txtType.SelectedIndex = -1;
            txtID.Clear();
            txtDistict.Clear();
            txtDevision.Clear();
            txtLocation.Clear();

            // 2. Reset the Date picker to today's date
            dateTimePicker1.Value = DateTime.Now;

            // 3. Uncheck all severity radio buttons
            radioLow.Checked = false;
            radioMedium.Checked = false;
            radioHigh.Checked = false;
            radioCritical.Checked = false;

            // 4. Set the cursor focus back to the first combo box
            txtType.Focus();
        }

        // Custom Paint Method to draw flat modern cards
        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            // 1. Draw modern blue accent strip at the top
            using (SolidBrush accentBrush = new SolidBrush(Color.FromArgb(0, 126, 249)))
            {
                e.Graphics.FillRectangle(accentBrush, 0, 0, pnl.Width, 6);
            }

            // 2. Draw a crisp flat border around the white card
            using (Pen pen = new Pen(Color.FromArgb(215, 220, 225), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            }
        }

        // Dummy events kept to avoid breaking the designer
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}