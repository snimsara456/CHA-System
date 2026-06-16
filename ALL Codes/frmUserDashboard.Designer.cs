namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    partial class frmUserDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRecentCrimes = new System.Windows.Forms.Label();
            this.dgvRecentCrimes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentCrimes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(116, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblRecentCrimes
            // 
            this.lblRecentCrimes.AutoSize = true;
            this.lblRecentCrimes.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRecentCrimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblRecentCrimes.Location = new System.Drawing.Point(20, 80);
            this.lblRecentCrimes.Name = "lblRecentCrimes";
            this.lblRecentCrimes.Size = new System.Drawing.Size(222, 32);
            this.lblRecentCrimes.TabIndex = 1;
            this.lblRecentCrimes.Text = "Recent Crime Areas";
            // 
            // dgvRecentCrimes
            // 
            this.dgvRecentCrimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentCrimes.Location = new System.Drawing.Point(26, 125);
            this.dgvRecentCrimes.Name = "dgvRecentCrimes";
            this.dgvRecentCrimes.RowHeadersWidth = 51;
            this.dgvRecentCrimes.RowTemplate.Height = 24;
            this.dgvRecentCrimes.Size = new System.Drawing.Size(1050, 500);
            this.dgvRecentCrimes.TabIndex = 2;
            this.dgvRecentCrimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentCrimes_CellContentClick);
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1100, 689);
            this.Controls.Add(this.dgvRecentCrimes);
            this.Controls.Add(this.lblRecentCrimes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserDashboard";
            this.Text = "User Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentCrimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRecentCrimes;
        private System.Windows.Forms.DataGridView dgvRecentCrimes;
    }
}