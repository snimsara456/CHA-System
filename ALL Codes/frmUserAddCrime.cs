using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmUserAddCrime : Form
    {
        private string officerName;
        private string officerID;
        
        public frmUserAddCrime(string name, string id)
        {
            InitializeComponent();
            officerName = name;
            officerID = id;
            cmbHandledBy.Items.Add(name);
            cmbHandledBy.SelectedItem = name;
            dtpDate.Value = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrEmpty(txtCrimeType.Text))
            {
                MessageBox.Show("Please enter crime type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please enter location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtArea.Text))
            {
                MessageBox.Show("Please enter area.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // In real application, save to database
            DialogResult result = MessageBox.Show(
                $"Crime Details:\n\nType: {txtCrimeType.Text}\nLocation: {txtLocation.Text}\nArea: {txtArea.Text}\nDate: {dtpDate.Value.ToShortDateString()}\nHandled By: {cmbHandledBy.SelectedItem}\nDescription: {txtDescription.Text}",
                "Confirm Crime Report",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Here you would save to database
                MessageBox.Show("Crime added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtCrimeType.Clear();
            txtLocation.Clear();
            txtArea.Clear();
            txtDescription.Clear();
            dtpDate.Value = DateTime.Now;
            cmbHandledBy.SelectedItem = officerName;
        }
    }
}