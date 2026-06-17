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
           
        }
       

        private void frmAddCrimes_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kavix haresh\Downloads\CHA-System-Dev-Nirmal\CHA-System-Dev-Nirmal\CrimeHotspotSystem\CrimeDB.mdf"";Integrated Security=True";

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
                        // Add parameters mapping UI controls to database columns
                        command.Parameters.AddWithValue("@CrimeID", crimeId);
                        command.Parameters.AddWithValue("@Type", txtType.Text.Trim());
                        command.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                        command.Parameters.AddWithValue("@Severity", severity);
                        command.Parameters.AddWithValue("@District", txtDistict.Text.Trim()); // Used your exact variable name
                        command.Parameters.AddWithValue("@Division", txtDevision.Text.Trim()); // Used your exact variable name
                        command.Parameters.AddWithValue("@Street", txtLocation.Text.Trim());

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Crime record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ClearForm(); // Optional: Call a method to reset the form
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
                // Specifically catch SQL errors (like duplicate Primary Keys)
                if (sqlEx.Number == 2627) // Primary Key Violation error code
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
            txtType.Clear();
            txtID.Clear();
            txtDistict.Clear(); // Using your exact control name
            txtDevision.Clear(); // Using your exact control name
            txtLocation.Clear();

            // 2. Reset the Date picker to today's date
            dateTimePicker1.Value = DateTime.Now;

            // 3. Uncheck all severity radio buttons
            radioLow.Checked = false;
            radioMedium.Checked = false;
            radioHigh.Checked = false;
            radioCritical.Checked = false;

            // 4. Set the cursor focus back to the first text box so the user can start typing immediately
            txtType.Focus();
        }
    }
}
