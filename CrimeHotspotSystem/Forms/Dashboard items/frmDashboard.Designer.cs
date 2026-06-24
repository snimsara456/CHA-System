namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCrimeMonth = new System.Windows.Forms.Panel();
            this.lblThisMonthCrimes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMDA = new System.Windows.Forms.Panel();
            this.lblDangerous = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTotCrime = new System.Windows.Forms.Panel();
            this.lblTotCrimes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlCrimeMonth.SuspendLayout();
            this.pnlMDA.SuspendLayout();
            this.pnlTotCrime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 396);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(78, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Recent Crime Records";
            // 
            // pnlCrimeMonth
            // 
            this.pnlCrimeMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCrimeMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.pnlCrimeMonth.Controls.Add(this.lblThisMonthCrimes);
            this.pnlCrimeMonth.Controls.Add(this.label4);
            this.pnlCrimeMonth.Location = new System.Drawing.Point(750, 43);
            this.pnlCrimeMonth.Name = "pnlCrimeMonth";
            this.pnlCrimeMonth.Size = new System.Drawing.Size(268, 143);
            this.pnlCrimeMonth.TabIndex = 13;
            // 
            // lblThisMonthCrimes
            // 
            this.lblThisMonthCrimes.BackColor = System.Drawing.Color.White;
            this.lblThisMonthCrimes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblThisMonthCrimes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblThisMonthCrimes.Location = new System.Drawing.Point(19, 64);
            this.lblThisMonthCrimes.Name = "lblThisMonthCrimes";
            this.lblThisMonthCrimes.Size = new System.Drawing.Size(236, 54);
            this.lblThisMonthCrimes.TabIndex = 2;
            this.lblThisMonthCrimes.Text = "35";
            this.lblThisMonthCrimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crimes This Month";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMDA
            // 
            this.pnlMDA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlMDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.pnlMDA.Controls.Add(this.lblDangerous);
            this.pnlMDA.Controls.Add(this.label3);
            this.pnlMDA.Location = new System.Drawing.Point(417, 43);
            this.pnlMDA.Name = "pnlMDA";
            this.pnlMDA.Size = new System.Drawing.Size(268, 143);
            this.pnlMDA.TabIndex = 12;
            // 
            // lblDangerous
            // 
            this.lblDangerous.BackColor = System.Drawing.Color.White;
            this.lblDangerous.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblDangerous.ForeColor = System.Drawing.Color.Tomato;
            this.lblDangerous.Location = new System.Drawing.Point(40, 64);
            this.lblDangerous.Name = "lblDangerous";
            this.lblDangerous.Size = new System.Drawing.Size(204, 54);
            this.lblDangerous.TabIndex = 2;
            this.lblDangerous.Text = "Kurunegala";
            this.lblDangerous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Most Dangerous Area";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotCrime
            // 
            this.pnlTotCrime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTotCrime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.pnlTotCrime.Controls.Add(this.lblTotCrimes);
            this.pnlTotCrime.Controls.Add(this.label2);
            this.pnlTotCrime.Location = new System.Drawing.Point(82, 43);
            this.pnlTotCrime.Name = "pnlTotCrime";
            this.pnlTotCrime.Size = new System.Drawing.Size(268, 143);
            this.pnlTotCrime.TabIndex = 11;
            // 
            // lblTotCrimes
            // 
            this.lblTotCrimes.BackColor = System.Drawing.Color.White;
            this.lblTotCrimes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotCrimes.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTotCrimes.Location = new System.Drawing.Point(26, 60);
            this.lblTotCrimes.Name = "lblTotCrimes";
            this.lblTotCrimes.Size = new System.Drawing.Size(212, 54);
            this.lblTotCrimes.TabIndex = 1;
            this.lblTotCrimes.Text = "245";
            this.lblTotCrimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Crimes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnimport
            // 
            this.btnimport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnimport.FlatAppearance.BorderSize = 0;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnimport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.btnimport.Location = new System.Drawing.Point(870, 219);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(148, 38);
            this.btnimport.TabIndex = 16;
            this.btnimport.Text = "↑ Import Crimes";
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1100, 689);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlCrimeMonth);
            this.Controls.Add(this.pnlMDA);
            this.Controls.Add(this.pnlTotCrime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlCrimeMonth.ResumeLayout(false);
            this.pnlMDA.ResumeLayout(false);
            this.pnlTotCrime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlCrimeMonth;
        private System.Windows.Forms.Label lblThisMonthCrimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMDA;
        private System.Windows.Forms.Label lblDangerous;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTotCrime;
        private System.Windows.Forms.Label lblTotCrimes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnimport;
    }
}