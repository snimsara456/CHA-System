namespace CrimeHotspotSystem.Forms
{
    partial class UserDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCrimeTable = new System.Windows.Forms.Button();
            this.btnAddCrime = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOfficerID = new System.Windows.Forms.Label();
            this.lblOfficerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnCrimeTable);
            this.panel1.Controls.Add(this.btnAddCrime);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 746);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 8;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnProfile.Location = new System.Drawing.Point(0, 399);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(265, 51);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.Leave += new System.EventHandler(this.btnProfile_Leave);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(0, 695);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(265, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCrimeTable
            // 
            this.btnCrimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrimeTable.FlatAppearance.BorderSize = 0;
            this.btnCrimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrimeTable.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCrimeTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCrimeTable.Location = new System.Drawing.Point(0, 297);
            this.btnCrimeTable.Name = "btnCrimeTable";
            this.btnCrimeTable.Size = new System.Drawing.Size(265, 51);
            this.btnCrimeTable.TabIndex = 4;
            this.btnCrimeTable.Text = "Crime Table";
            this.btnCrimeTable.UseVisualStyleBackColor = true;
            this.btnCrimeTable.Click += new System.EventHandler(this.btnCrimeTable_Click);
            this.btnCrimeTable.Leave += new System.EventHandler(this.btnCrimeTable_Leave);
            // 
            // btnAddCrime
            // 
            this.btnAddCrime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCrime.FlatAppearance.BorderSize = 0;
            this.btnAddCrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCrime.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddCrime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddCrime.Location = new System.Drawing.Point(0, 246);
            this.btnAddCrime.Name = "btnAddCrime";
            this.btnAddCrime.Size = new System.Drawing.Size(265, 51);
            this.btnAddCrime.TabIndex = 2;
            this.btnAddCrime.Text = "Add Crime";
            this.btnAddCrime.UseVisualStyleBackColor = true;
            this.btnAddCrime.Click += new System.EventHandler(this.btnAddCrime_Click);
            this.btnAddCrime.Leave += new System.EventHandler(this.btnAddCrime_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 195);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(265, 51);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblOfficerID);
            this.panel2.Controls.Add(this.lblOfficerName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 195);
            this.panel2.TabIndex = 0;
            // 
            // lblOfficerID
            // 
            this.lblOfficerID.AutoSize = true;
            this.lblOfficerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblOfficerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblOfficerID.Location = new System.Drawing.Point(77, 165);
            this.lblOfficerID.Name = "lblOfficerID";
            this.lblOfficerID.Size = new System.Drawing.Size(27, 18);
            this.lblOfficerID.TabIndex = 3;
            this.lblOfficerID.Text = "ID:";
            // 
            // lblOfficerName
            // 
            this.lblOfficerName.AutoSize = true;
            this.lblOfficerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblOfficerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblOfficerName.Location = new System.Drawing.Point(64, 135);
            this.lblOfficerName.Name = "lblOfficerName";
            this.lblOfficerName.Size = new System.Drawing.Size(123, 20);
            this.lblOfficerName.TabIndex = 2;
            this.lblOfficerName.Text = "Officer Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CrimeHotspotSystem.Properties.Resources.user_244;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(271, 56);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1100, 689);
            this.PnlFormLoader.TabIndex = 1;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1370, 746);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAddCrime;
        private System.Windows.Forms.Button btnCrimeTable;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lblOfficerName;
        private System.Windows.Forms.Label lblOfficerID;
    }
}