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
    public partial class frmProfile : Form
    {
        //private readonly object GlobalVariables;

        public frmProfile()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        // 1. Connection string defined as a class field
        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\richa\Downloads\CHA-System-main\CrimeHotspotSystem\CrimeDB.mdf;Integrated Security=True";

        

        private void frmProfile_Load(object sender, EventArgs e)
        {
            // 2. Simply call the method here
            LoadUserData();
        }

        private void LoadUserData()
        {
            // CHANGED: Used 'Id' instead of 'UserID' to match your database schema
            string query = "SELECT FullName, Rank, PoliceID, NIC, PoliceStation, Department, Phone FROM Users WHERE Username = @Id";

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Ensure GlobalVariables.LoggedInUserID is holding the 'Id' value
                    cmd.Parameters.AddWithValue("@Id", GlobalVariables.LoggedInUserID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Map database columns to your UI labels
                        lblName.Text = reader["FullName"].ToString();
                        lblRank.Text = reader["Rank"].ToString();
                        lblPoliceID.Text = reader["PoliceID"].ToString();
                        lblNIC.Text = reader["NIC"].ToString();
                        lblPoliceStation.Text = reader["PoliceStation"].ToString();
                        lblDepartment.Text = reader["Department"].ToString();
                        lblPhone.Text = reader["Phone"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("User details not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }
    }
}
