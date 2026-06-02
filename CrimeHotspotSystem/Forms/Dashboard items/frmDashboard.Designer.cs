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
            this.CLMcrimetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMsvrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMofficer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCrimeMonth = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMDA = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTotCrime = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlCrimeMonth.SuspendLayout();
            this.pnlMDA.SuspendLayout();
            this.pnlTotCrime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLMcrimetype,
            this.CLMarea,
            this.CLMdate,
            this.CLMsvrt,
            this.CLMofficer});
            this.dataGridView1.Location = new System.Drawing.Point(99, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 416);
            this.dataGridView1.TabIndex = 15;
            // 
            // CLMcrimetype
            // 
            this.CLMcrimetype.HeaderText = "CRIME TYPE";
            this.CLMcrimetype.MinimumWidth = 6;
            this.CLMcrimetype.Name = "CLMcrimetype";
            this.CLMcrimetype.Width = 125;
            // 
            // CLMarea
            // 
            this.CLMarea.HeaderText = "AREA";
            this.CLMarea.MinimumWidth = 6;
            this.CLMarea.Name = "CLMarea";
            this.CLMarea.Width = 125;
            // 
            // CLMdate
            // 
            this.CLMdate.HeaderText = "DATE";
            this.CLMdate.MinimumWidth = 6;
            this.CLMdate.Name = "CLMdate";
            this.CLMdate.Width = 125;
            // 
            // CLMsvrt
            // 
            this.CLMsvrt.HeaderText = "SEVERITY";
            this.CLMsvrt.MinimumWidth = 6;
            this.CLMsvrt.Name = "CLMsvrt";
            this.CLMsvrt.Width = 125;
            // 
            // CLMofficer
            // 
            this.CLMofficer.HeaderText = "OFFICER";
            this.CLMofficer.MinimumWidth = 6;
            this.CLMofficer.Name = "CLMofficer";
            this.CLMofficer.Width = 125;
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
            this.pnlCrimeMonth.Controls.Add(this.label7);
            this.pnlCrimeMonth.Controls.Add(this.label4);
            this.pnlCrimeMonth.Location = new System.Drawing.Point(771, 7);
            this.pnlCrimeMonth.Name = "pnlCrimeMonth";
            this.pnlCrimeMonth.Size = new System.Drawing.Size(233, 152);
            this.pnlCrimeMonth.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(78, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 42);
            this.label7.TabIndex = 2;
            this.label7.Text = "35";
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
            this.pnlMDA.Controls.Add(this.label6);
            this.pnlMDA.Controls.Add(this.label3);
            this.pnlMDA.Location = new System.Drawing.Point(434, 7);
            this.pnlMDA.Name = "pnlMDA";
            this.pnlMDA.Size = new System.Drawing.Size(233, 152);
            this.pnlMDA.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(35, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Colombo 03";
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
            this.pnlTotCrime.Controls.Add(this.label5);
            this.pnlTotCrime.Controls.Add(this.label2);
            this.pnlTotCrime.Location = new System.Drawing.Point(99, 7);
            this.pnlTotCrime.Name = "pnlTotCrime";
            this.pnlTotCrime.Size = new System.Drawing.Size(233, 152);
            this.pnlTotCrime.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(68, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "245";
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
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1100, 689);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMcrimetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMsvrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMofficer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlCrimeMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTotCrime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}