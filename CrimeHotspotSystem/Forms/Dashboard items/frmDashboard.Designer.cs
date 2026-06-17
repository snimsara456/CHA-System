namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 416);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(96, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Recent Crime Records";
            // 
            // pnlCrimeMonth
            // 
            this.pnlCrimeMonth.BackColor = System.Drawing.Color.White;
            this.pnlCrimeMonth.Controls.Add(this.lblThisMonthCrimes);
            this.pnlCrimeMonth.Controls.Add(this.label4);
            this.pnlCrimeMonth.Location = new System.Drawing.Point(771, 7);
            this.pnlCrimeMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCrimeMonth.Name = "pnlCrimeMonth";
            this.pnlCrimeMonth.Size = new System.Drawing.Size(233, 153);
            this.pnlCrimeMonth.TabIndex = 13;
            // 
            // lblThisMonthCrimes
            // 
            this.lblThisMonthCrimes.AutoSize = true;
            this.lblThisMonthCrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonthCrimes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblThisMonthCrimes.Location = new System.Drawing.Point(77, 62);
            this.lblThisMonthCrimes.Name = "lblThisMonthCrimes";
            this.lblThisMonthCrimes.Size = new System.Drawing.Size(62, 42);
            this.lblThisMonthCrimes.TabIndex = 2;
            this.lblThisMonthCrimes.Text = "35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(45, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Crimes This Month";
            // 
            // pnlMDA
            // 
            this.pnlMDA.BackColor = System.Drawing.Color.White;
            this.pnlMDA.Controls.Add(this.lblDangerous);
            this.pnlMDA.Controls.Add(this.label3);
            this.pnlMDA.Location = new System.Drawing.Point(435, 7);
            this.pnlMDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMDA.Name = "pnlMDA";
            this.pnlMDA.Size = new System.Drawing.Size(233, 153);
            this.pnlMDA.TabIndex = 12;
            // 
            // lblDangerous
            // 
            this.lblDangerous.AutoSize = true;
            this.lblDangerous.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangerous.ForeColor = System.Drawing.Color.Tomato;
            this.lblDangerous.Location = new System.Drawing.Point(35, 62);
            this.lblDangerous.Name = "lblDangerous";
            this.lblDangerous.Size = new System.Drawing.Size(154, 29);
            this.lblDangerous.TabIndex = 2;
            this.lblDangerous.Text = "Colombo 03";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(37, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Most Dangerous Area";
            // 
            // pnlTotCrime
            // 
            this.pnlTotCrime.BackColor = System.Drawing.Color.White;
            this.pnlTotCrime.Controls.Add(this.lblTotCrimes);
            this.pnlTotCrime.Controls.Add(this.label2);
            this.pnlTotCrime.Location = new System.Drawing.Point(99, 7);
            this.pnlTotCrime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTotCrime.Name = "pnlTotCrime";
            this.pnlTotCrime.Size = new System.Drawing.Size(233, 153);
            this.pnlTotCrime.TabIndex = 11;
            // 
            // lblTotCrimes
            // 
            this.lblTotCrimes.AutoSize = true;
            this.lblTotCrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCrimes.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTotCrimes.Location = new System.Drawing.Point(68, 62);
            this.lblTotCrimes.Name = "lblTotCrimes";
            this.lblTotCrimes.Size = new System.Drawing.Size(84, 42);
            this.lblTotCrimes.TabIndex = 1;
            this.lblTotCrimes.Text = "245";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Crimes";
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(855, 213);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(137, 32);
            this.btnimport.TabIndex = 16;
            this.btnimport.Text = "Import Crimes";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1100, 689);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlCrimeMonth);
            this.Controls.Add(this.pnlMDA);
            this.Controls.Add(this.pnlTotCrime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlCrimeMonth.ResumeLayout(false);
            this.pnlCrimeMonth.PerformLayout();
            this.pnlMDA.ResumeLayout(false);
            this.pnlMDA.PerformLayout();
            this.pnlTotCrime.ResumeLayout(false);
            this.pnlTotCrime.PerformLayout();
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