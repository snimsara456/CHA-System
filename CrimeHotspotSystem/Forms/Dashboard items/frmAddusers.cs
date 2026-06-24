using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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

            // Wire up the paint event for our flat modern card
            panel1.Paint += panel1_Paint;
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
            cmbType.SelectedIndex = -1;

            dtpDOB.Value = DateTime.Now;
            dtpDateJoined.Value = DateTime.Now;

            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        // Draws the crisp Flat UI accent bar and border
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            // 1. Draw modern blue accent strip at the top
            using (SolidBrush accentBrush = new SolidBrush(Color.FromArgb(0, 126, 249)))
            {
                e.Graphics.FillRectangle(accentBrush, 0, 0, pnl.Width, 6);
            }

            // 2. Draw a very subtle, crisp flat border around the white card
            using (Pen pen = new Pen(Color.FromArgb(215, 220, 225), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            }
        }

        // Empty events kept to prevent designer breaks
        private void label19_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void frmAddusers_Load(object sender, EventArgs e) { }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}