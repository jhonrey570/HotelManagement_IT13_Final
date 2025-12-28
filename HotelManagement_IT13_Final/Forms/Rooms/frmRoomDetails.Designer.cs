namespace HotelManagement_IT13_Final.Forms.Rooms
{
    partial class frmRoomDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomDetails));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpAmenities = new System.Windows.Forms.GroupBox();
            this.clbAmenities = new System.Windows.Forms.CheckedListBox();
            this.grpBedConfiguration = new System.Windows.Forms.GroupBox();
            this.dgvRoomBeds = new System.Windows.Forms.DataGridView();
            this.grpRoomInfo = new System.Windows.Forms.GroupBox();
            this.cboRoomStatus = new System.Windows.Forms.ComboBox();
            this.lblRoomStatus = new System.Windows.Forms.Label();
            this.cboRoomView = new System.Windows.Forms.ComboBox();
            this.lblRoomView = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.nudFloor = new System.Windows.Forms.NumericUpDown();
            this.lblFloor = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelFormContainer.SuspendLayout();
            this.grpAmenities.SuspendLayout();
            this.grpBedConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBeds)).BeginInit();
            this.grpRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Room Details";
            // 
            // panelMainContent
            // 
            this.panelMainContent.AutoScroll = true;
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.panelFormContainer);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(40);
            this.panelMainContent.Size = new System.Drawing.Size(1000, 680);
            this.panelMainContent.TabIndex = 1;
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormContainer.AutoScroll = true;
            this.panelFormContainer.BackColor = System.Drawing.Color.White;
            this.panelFormContainer.Controls.Add(this.btnCancel);
            this.panelFormContainer.Controls.Add(this.btnSave);
            this.panelFormContainer.Controls.Add(this.grpAmenities);
            this.panelFormContainer.Controls.Add(this.grpBedConfiguration);
            this.panelFormContainer.Controls.Add(this.grpRoomInfo);
            this.panelFormContainer.Location = new System.Drawing.Point(40, 40);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Padding = new System.Windows.Forms.Padding(30);
            this.panelFormContainer.Size = new System.Drawing.Size(920, 600);
            this.panelFormContainer.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(680, 520);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(805, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // grpAmenities
            // 
            this.grpAmenities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAmenities.Controls.Add(this.clbAmenities);
            this.grpAmenities.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAmenities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpAmenities.Location = new System.Drawing.Point(30, 450);
            this.grpAmenities.Name = "grpAmenities";
            this.grpAmenities.Size = new System.Drawing.Size(860, 160);
            this.grpAmenities.TabIndex = 6;
            this.grpAmenities.TabStop = false;
            this.grpAmenities.Text = "Amenities";
            // 
            // clbAmenities
            // 
            this.clbAmenities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbAmenities.BackColor = System.Drawing.Color.White;
            this.clbAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAmenities.CheckOnClick = true;
            this.clbAmenities.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAmenities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.clbAmenities.FormattingEnabled = true;
            this.clbAmenities.Items.AddRange(new object[] {
            "Wi-Fi",
            "TV",
            "Mini Bar",
            "Air Conditioning",
            "Safe",
            "Coffee Maker",
            "Iron",
            "Hair Dryer",
            "Room Service",
            "Balcony"});
            this.clbAmenities.Location = new System.Drawing.Point(20, 30);
            this.clbAmenities.MultiColumn = true;
            this.clbAmenities.Name = "clbAmenities";
            this.clbAmenities.Size = new System.Drawing.Size(820, 120);
            this.clbAmenities.TabIndex = 0;
            // 
            // grpBedConfiguration
            // 
            this.grpBedConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBedConfiguration.Controls.Add(this.dgvRoomBeds);
            this.grpBedConfiguration.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBedConfiguration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpBedConfiguration.Location = new System.Drawing.Point(30, 240);
            this.grpBedConfiguration.Name = "grpBedConfiguration";
            this.grpBedConfiguration.Size = new System.Drawing.Size(860, 200);
            this.grpBedConfiguration.TabIndex = 5;
            this.grpBedConfiguration.TabStop = false;
            this.grpBedConfiguration.Text = "Bed Configuration";
            // 
            // dgvRoomBeds
            // 
            this.dgvRoomBeds.AllowUserToAddRows = false;
            this.dgvRoomBeds.AllowUserToDeleteRows = false;
            this.dgvRoomBeds.AllowUserToResizeRows = false;
            this.dgvRoomBeds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomBeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomBeds.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomBeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoomBeds.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoomBeds.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomBeds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomBeds.ColumnHeadersHeight = 40;
            this.dgvRoomBeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomBeds.EnableHeadersVisualStyles = false;
            this.dgvRoomBeds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvRoomBeds.Location = new System.Drawing.Point(20, 35);
            this.dgvRoomBeds.MultiSelect = false;
            this.dgvRoomBeds.Name = "dgvRoomBeds";
            this.dgvRoomBeds.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRoomBeds.RowHeadersVisible = false;
            this.dgvRoomBeds.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvRoomBeds.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomBeds.RowTemplate.Height = 35;
            this.dgvRoomBeds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRoomBeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomBeds.ShowCellToolTips = false;
            this.dgvRoomBeds.Size = new System.Drawing.Size(820, 150);
            this.dgvRoomBeds.TabIndex = 0;
            // 
            // grpRoomInfo
            // 
            this.grpRoomInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRoomInfo.Controls.Add(this.cboRoomStatus);
            this.grpRoomInfo.Controls.Add(this.lblRoomStatus);
            this.grpRoomInfo.Controls.Add(this.cboRoomView);
            this.grpRoomInfo.Controls.Add(this.lblRoomView);
            this.grpRoomInfo.Controls.Add(this.cboRoomType);
            this.grpRoomInfo.Controls.Add(this.lblRoomType);
            this.grpRoomInfo.Controls.Add(this.nudFloor);
            this.grpRoomInfo.Controls.Add(this.lblFloor);
            this.grpRoomInfo.Controls.Add(this.txtRoomNumber);
            this.grpRoomInfo.Controls.Add(this.lblRoomNumber);
            this.grpRoomInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoomInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpRoomInfo.Location = new System.Drawing.Point(30, 30);
            this.grpRoomInfo.Name = "grpRoomInfo";
            this.grpRoomInfo.Size = new System.Drawing.Size(860, 200);
            this.grpRoomInfo.TabIndex = 4;
            this.grpRoomInfo.TabStop = false;
            this.grpRoomInfo.Text = "Room Information";
            // 
            // cboRoomStatus
            // 
            this.cboRoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomStatus.FormattingEnabled = true;
            this.cboRoomStatus.Items.AddRange(new object[] {
            "Available",
            "Occupied",
            "Maintenance",
            "Cleaning",
            "Reserved"});
            this.cboRoomStatus.Location = new System.Drawing.Point(580, 135);
            this.cboRoomStatus.Name = "cboRoomStatus";
            this.cboRoomStatus.Size = new System.Drawing.Size(260, 31);
            this.cboRoomStatus.TabIndex = 4;
            // 
            // lblRoomStatus
            // 
            this.lblRoomStatus.AutoSize = true;
            this.lblRoomStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRoomStatus.Location = new System.Drawing.Point(580, 110);
            this.lblRoomStatus.Name = "lblRoomStatus";
            this.lblRoomStatus.Size = new System.Drawing.Size(113, 23);
            this.lblRoomStatus.TabIndex = 0;
            this.lblRoomStatus.Text = "Room Status:";
            // 
            // cboRoomView
            // 
            this.cboRoomView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomView.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomView.FormattingEnabled = true;
            this.cboRoomView.Items.AddRange(new object[] {
            "City View",
            "Garden View",
            "Sea View",
            "Mountain View",
            "Pool View"});
            this.cboRoomView.Location = new System.Drawing.Point(580, 65);
            this.cboRoomView.Name = "cboRoomView";
            this.cboRoomView.Size = new System.Drawing.Size(260, 31);
            this.cboRoomView.TabIndex = 2;
            // 
            // lblRoomView
            // 
            this.lblRoomView.AutoSize = true;
            this.lblRoomView.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRoomView.Location = new System.Drawing.Point(580, 40);
            this.lblRoomView.Name = "lblRoomView";
            this.lblRoomView.Size = new System.Drawing.Size(102, 23);
            this.lblRoomView.TabIndex = 0;
            this.lblRoomView.Text = "Room View:";
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "Suite",
            "Deluxe",
            "Executive",
            "Family"});
            this.cboRoomType.Location = new System.Drawing.Point(300, 135);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(260, 31);
            this.cboRoomType.TabIndex = 3;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRoomType.Location = new System.Drawing.Point(300, 110);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(102, 23);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type:";
            // 
            // nudFloor
            // 
            this.nudFloor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFloor.Location = new System.Drawing.Point(300, 65);
            this.nudFloor.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFloor.Name = "nudFloor";
            this.nudFloor.Size = new System.Drawing.Size(260, 30);
            this.nudFloor.TabIndex = 1;
            this.nudFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblFloor.Location = new System.Drawing.Point(300, 40);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(56, 23);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "Floor:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(20, 65);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(260, 30);
            this.txtRoomNumber.TabIndex = 0;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 40);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(129, 23);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // frmRoomDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoomDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Room Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelFormContainer.ResumeLayout(false);
            this.grpAmenities.ResumeLayout(false);
            this.grpBedConfiguration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomBeds)).EndInit();
            this.grpRoomInfo.ResumeLayout(false);
            this.grpRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpAmenities;
        private System.Windows.Forms.CheckedListBox clbAmenities;
        private System.Windows.Forms.GroupBox grpBedConfiguration;
        private System.Windows.Forms.DataGridView dgvRoomBeds;
        private System.Windows.Forms.GroupBox grpRoomInfo;
        private System.Windows.Forms.ComboBox cboRoomStatus;
        private System.Windows.Forms.Label lblRoomStatus;
        private System.Windows.Forms.ComboBox cboRoomView;
        private System.Windows.Forms.Label lblRoomView;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.NumericUpDown nudFloor;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
    }
}