namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    partial class frmUserAddCrime
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCrimeType = new System.Windows.Forms.Label();
            this.txtCrimeType = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblHandledBy = new System.Windows.Forms.Label();
            this.cmbHandledBy = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Crime";
            // 
            // lblCrimeType
            // 
            this.lblCrimeType.AutoSize = true;
            this.lblCrimeType.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblCrimeType.Location = new System.Drawing.Point(30, 90);
            this.lblCrimeType.Name = "lblCrimeType";
            this.lblCrimeType.Size = new System.Drawing.Size(93, 23);
            this.lblCrimeType.TabIndex = 1;
            this.lblCrimeType.Text = "Crime Type:";
            // 
            // txtCrimeType
            // 
            this.txtCrimeType.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.txtCrimeType.Location = new System.Drawing.Point(150, 87);
            this.txtCrimeType.Name = "txtCrimeType";
            this.txtCrimeType.Size = new System.Drawing.Size(300, 30);
            this.txtCrimeType.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblLocation.Location = new System.Drawing.Point(30, 130);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(74, 23);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(150, 127);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(300, 30);
            this.txtLocation.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblArea.Location = new System.Drawing.Point(30, 170);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 23);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area:";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(150, 167);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(300, 30);
            this.txtArea.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblDate.Location = new System.Drawing.Point(30, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 23);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.dtpDate.Location = new System.Drawing.Point(150, 207);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(300, 30);
            this.dtpDate.TabIndex = 8;
            // 
            // lblHandledBy
            // 
            this.lblHandledBy.AutoSize = true;
            this.lblHandledBy.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.lblHandledBy.Location = new System.Drawing.Point(30, 250);
            this.lblHandledBy.Name = "lblHandledBy";
            this.lblHandledBy.Size =