using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmAddusers : Form
    {
        public frmAddusers()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gs\Downloads\CHA-System-main\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

            string gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "");

            string query = "INSERT INTO Users (FullName, NameWithInitials, PoliceID, NIC, DOB, Gender, Address, Phone, Rank, PoliceStation, Department, DateJoined, Username, Password, role) " +
                           "VALUES (@FullName, @NameWithInitials, @PoliceID, @NIC, @DOB, @Gender, @Address, @Phone, @Rank, @PoliceStation, @Department, @DateJoined, @Username, @Password, @Role)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@NameWithInitials", txtNameWithInitials.Text);
                        cmd.Parameters.AddWithValue("@PoliceID", txtPoliceID.Text);
                        cmd.Parameters.AddWithValue("@NIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhoneNo.Text);
                        cmd.Parameters.AddWithValue("@Rank", cmbRank.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@PoliceStation", cmbPoliceStation.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Department", cmbDepartment.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@DateJoined", dtpDateJoined.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.Parameters.AddWithValue("@Role", cmbType.SelectedItem?.ToString() ?? "");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User details saved successfully to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtNameWithInitials.Clear();
            txtPoliceID.Clear();
            txtNIC.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtUserName.Clear();
            txtPassword.Clear();

           
            cmbRank.SelectedIndex = -1;
            cmbPoliceStation.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;

            dtpDOB.Value = DateTime.Now;
            dtpDateJoined.Value = DateTime.Now;

            
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddusers_Load(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
