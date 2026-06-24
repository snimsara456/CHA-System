namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    partial class frmAddCrimes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCrimeInfo = new System.Windows.Forms.Panel();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioHigh = new System.Windows.Forms.RadioButton();
            this.radioCritical = new System.Windows.Forms.RadioButton();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDistict = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDevision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlCrimeInfo.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Crime Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill in all required fields to record a new crime incident.";
            // 
            // pnlCrimeInfo
            // 
            this.pnlCrimeInfo.BackColor = System.Drawing.Color.White;
            this.pnlCrimeInfo.Controls.Add(this.lblCard1Title);
            this.pnlCrimeInfo.Controls.Add(this.label3);
            this.pnlCrimeInfo.Controls.Add(this.txtType);
            this.pnlCrimeInfo.Controls.Add(this.label5);
            this.pnlCrimeInfo.Controls.Add(this.txtID);
            this.pnlCrimeInfo.Controls.Add(this.label4);
            this.pnlCrimeInfo.Controls.Add(this.dateTimePicker1);
            this.pnlCrimeInfo.Controls.Add(this.label6);
            this.pnlCrimeInfo.Controls.Add(this.radioLow);
            this.pnlCrimeInfo.Controls.Add(this.radioMedium);
            this.pnlCrimeInfo.Controls.Add(this.radioHigh);
            this.pnlCrimeInfo.Controls.Add(this.radioCritical);
            this.pnlCrimeInfo.Location = new System.Drawing.Point(47, 120);
            this.pnlCrimeInfo.Name = "pnlCrimeInfo";
            this.pnlCrimeInfo.Size = new System.Drawing.Size(480, 360);
            this.pnlCrimeInfo.TabIndex = 2;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCard1Title.Location = new System.Drawing.Point(25, 25);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(218, 28);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "CRIME INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Crime Type:";
            // 
            // txtType
            // 
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Murder",
            "Assault",
            "Robbery",
            "Kidnapping",
            "Fraud",
            "DUI",
            "Drug Possesion",
            "Trespassing"});
            this.txtType.Location = new System.Drawing.Point(180, 77);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(260, 31);
            this.txtType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Case Ref. No.:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtID.Location = new System.Drawing.Point(180, 132);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(260, 30);
            this.txtID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Incident:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 30);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label6.Location = new System.Drawing.Point(25, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Severity Level:";
            // 
            // radioLow
            // 
            this.radioLow.AutoSize = true;
            this.radioLow.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.radioLow.Location = new System.Drawing.Point(180, 243);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(62, 27);
            this.radioLow.TabIndex = 8;
            this.radioLow.TabStop = true;
            this.radioLow.Text = "Low";
            this.radioLow.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.radioMedium.Location = new System.Drawing.Point(260, 243);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(94, 27);
            this.radioMedium.TabIndex = 9;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioHigh
            // 
            this.radioHigh.AutoSize = true;
            this.radioHigh.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.radioHigh.Location = new System.Drawing.Point(180, 280);
            this.radioHigh.Name = "radioHigh";
            this.radioHigh.Size = new System.Drawing.Size(67, 27);
            this.radioHigh.TabIndex = 10;
            this.radioHigh.TabStop = true;
            this.radioHigh.Text = "High";
            this.radioHigh.UseVisualStyleBackColor = true;
            // 
            // radioCritical
            // 
            this.radioCritical.AutoSize = true;
            this.radioCritical.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.radioCritical.Location = new System.Drawing.Point(260, 280);
            this.radioCritical.Name = "radioCritical";
            this.radioCritical.Size = new System.Drawing.Size(83, 27);
            this.radioCritical.TabIndex = 11;
            this.radioCritical.TabStop = true;
            this.radioCritical.Text = "Critical";
            this.radioCritical.UseVisualStyleBackColor = true;
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.Color.White;
            this.pnlLocation.Controls.Add(this.lblCard2Title);
            this.pnlLocation.Controls.Add(this.label7);
            this.pnlLocation.Controls.Add(this.txtDistict);
            this.pnlLocation.Controls.Add(this.label8);
            this.pnlLocation.Controls.Add(this.txtDevision);
            this.pnlLocation.Controls.Add(this.label9);
            this.pnlLocation.Controls.Add(this.txtLocation);
            this.pnlLocation.Location = new System.Drawing.Point(550, 120);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(480, 360);
            this.pnlLocation.TabIndex = 3;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblCard2Title.Location = new System.Drawing.Point(25, 25);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(199, 28);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "LOCATION DETAILS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label7.Location = new System.Drawing.Point(25, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "District:";
            // 
            // txtDistict
            // 
            this.txtDistict.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDistict.Location = new System.Drawing.Point(180, 77);
            this.txtDistict.Name = "txtDistict";
            this.txtDistict.Size = new System.Drawing.Size(260, 30);
            this.txtDistict.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label8.Location = new System.Drawing.Point(25, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Division:";
            // 
            // txtDevision
            // 
            this.txtDevision.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDevision.Location = new System.Drawing.Point(180, 132);
            this.txtDevision.Name = "txtDevision";
            this.txtDevision.Size = new System.Drawing.Size(260, 30);
            this.txtDevision.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.label9.Location = new System.Drawing.Point(25, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Street/Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtLocation.Location = new System.Drawing.Point(180, 187);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(260, 30);
            this.txtLocation.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.button1.Location = new System.Drawing.Point(750, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(900, 520);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 42);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Record";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddCrimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 689);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlCrimeInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCrimes";
            this.Text = "frmAddCrimes";
            this.Load += new System.EventHandler(this.frmAddCrimes_Load);
            this.pnlCrimeInfo.ResumeLayout(false);
            this.pnlCrimeInfo.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCrimeInfo;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioLow;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioHigh;
        private System.Windows.Forms.RadioButton radioCritical;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDistict;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDevision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubmit;
    }
}