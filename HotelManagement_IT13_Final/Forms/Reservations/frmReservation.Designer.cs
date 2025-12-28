namespace HotelManagement_IT13_Final.Forms.Reservations
{
    partial class frmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.tabReservation = new System.Windows.Forms.TabControl();
            this.tabGuest = new System.Windows.Forms.TabPage();
            this.lblGuestSelection = new System.Windows.Forms.Label();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.txtSpecialRequests = new System.Windows.Forms.TextBox();
            this.lblReservationType = new System.Windows.Forms.Label();
            this.cboReservationType = new System.Windows.Forms.ComboBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.nudChildren = new System.Windows.Forms.NumericUpDown();
            this.lblAdults = new System.Windows.Forms.Label();
            this.nudAdults = new System.Windows.Forms.NumericUpDown();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.tabRoomAssignment = new System.Windows.Forms.TabPage();
            this.lblRoomSelection = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.dgvAvailableRooms = new System.Windows.Forms.DataGridView();
            this.tabRateSummary = new System.Windows.Forms.TabPage();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblRatePerNight = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblRatePerNightValue = new System.Windows.Forms.Label();
            this.tabConfirmation = new System.Windows.Forms.TabPage();
            this.lblBookingReference = new System.Windows.Forms.Label();
            this.btnConfirmReservation = new System.Windows.Forms.Button();
            this.lblBookingReferenceValue = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.tabReservation.SuspendLayout();
            this.tabGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.tabBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).BeginInit();
            this.tabRoomAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).BeginInit();
            this.tabRateSummary.SuspendLayout();
            this.tabConfirmation.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(250, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Reservation";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 680);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(20, 30);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(165, 28);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Reservation Steps";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.tabReservation);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // tabReservation
            // 
            this.tabReservation.Controls.Add(this.tabGuest);
            this.tabReservation.Controls.Add(this.tabBooking);
            this.tabReservation.Controls.Add(this.tabRoomAssignment);
            this.tabReservation.Controls.Add(this.tabRateSummary);
            this.tabReservation.Controls.Add(this.tabConfirmation);
            this.tabReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReservation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReservation.Location = new System.Drawing.Point(20, 20);
            this.tabReservation.Name = "tabReservation";
            this.tabReservation.SelectedIndex = 0;
            this.tabReservation.Size = new System.Drawing.Size(720, 640);
            this.tabReservation.TabIndex = 0;
            // 
            // tabGuest
            // 
            this.tabGuest.BackColor = System.Drawing.Color.White;
            this.tabGuest.Controls.Add(this.lblGuestSelection);
            this.tabGuest.Controls.Add(this.dgvGuests);
            this.tabGuest.Controls.Add(this.btnAddGuest);
            this.tabGuest.Location = new System.Drawing.Point(4, 29);
            this.tabGuest.Name = "tabGuest";
            this.tabGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuest.Size = new System.Drawing.Size(712, 607);
            this.tabGuest.TabIndex = 0;
            this.tabGuest.Text = "1. Guest Selection";
            // 
            // lblGuestSelection
            // 
            this.lblGuestSelection.AutoSize = true;
            this.lblGuestSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGuestSelection.Location = new System.Drawing.Point(30, 30);
            this.lblGuestSelection.Name = "lblGuestSelection";
            this.lblGuestSelection.Size = new System.Drawing.Size(144, 28);
            this.lblGuestSelection.TabIndex = 2;
            this.lblGuestSelection.Text = "Select Guest(s)";
            // 
            // dgvGuests
            // 
            this.dgvGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(30, 70);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.RowHeadersWidth = 51;
            this.dgvGuests.RowTemplate.Height = 24;
            this.dgvGuests.Size = new System.Drawing.Size(652, 490);
            this.dgvGuests.TabIndex = 0;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGuest.FlatAppearance.BorderSize = 0;
            this.btnAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.ForeColor = System.Drawing.Color.White;
            this.btnAddGuest.Location = new System.Drawing.Point(562, 25);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(120, 45);
            this.btnAddGuest.TabIndex = 1;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // tabBooking
            // 
            this.tabBooking.BackColor = System.Drawing.Color.White;
            this.tabBooking.Controls.Add(this.lblSpecialRequests);
            this.tabBooking.Controls.Add(this.txtSpecialRequests);
            this.tabBooking.Controls.Add(this.lblReservationType);
            this.tabBooking.Controls.Add(this.cboReservationType);
            this.tabBooking.Controls.Add(this.lblChildren);
            this.tabBooking.Controls.Add(this.nudChildren);
            this.tabBooking.Controls.Add(this.lblAdults);
            this.tabBooking.Controls.Add(this.nudAdults);
            this.tabBooking.Controls.Add(this.lblCheckOut);
            this.tabBooking.Controls.Add(this.dtpCheckOut);
            this.tabBooking.Controls.Add(this.lblCheckIn);
            this.tabBooking.Controls.Add(this.dtpCheckIn);
            this.tabBooking.Location = new System.Drawing.Point(4, 29);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(712, 607);
            this.tabBooking.TabIndex = 1;
            this.tabBooking.Text = "2. Booking Details";
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.AutoSize = true;
            this.lblSpecialRequests.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblSpecialRequests.Location = new System.Drawing.Point(50, 280);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(144, 25);
            this.lblSpecialRequests.TabIndex = 22;
            this.lblSpecialRequests.Text = "Special Requests";
            // 
            // txtSpecialRequests
            // 
            this.txtSpecialRequests.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialRequests.Location = new System.Drawing.Point(200, 280);
            this.txtSpecialRequests.Multiline = true;
            this.txtSpecialRequests.Name = "txtSpecialRequests";
            this.txtSpecialRequests.Size = new System.Drawing.Size(450, 150);
            this.txtSpecialRequests.TabIndex = 23;
            // 
            // lblReservationType
            // 
            this.lblReservationType.AutoSize = true;
            this.lblReservationType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblReservationType.Location = new System.Drawing.Point(50, 220);
            this.lblReservationType.Name = "lblReservationType";
            this.lblReservationType.Size = new System.Drawing.Size(147, 25);
            this.lblReservationType.TabIndex = 20;
            this.lblReservationType.Text = "Reservation Type";
            // 
            // cboReservationType
            // 
            this.cboReservationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReservationType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReservationType.FormattingEnabled = true;
            this.cboReservationType.Location = new System.Drawing.Point(200, 220);
            this.cboReservationType.Name = "cboReservationType";
            this.cboReservationType.Size = new System.Drawing.Size(450, 31);
            this.cboReservationType.TabIndex = 21;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblChildren.Location = new System.Drawing.Point(350, 160);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(80, 25);
            this.lblChildren.TabIndex = 18;
            this.lblChildren.Text = "Children";
            // 
            // nudChildren
            // 
            this.nudChildren.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudChildren.Location = new System.Drawing.Point(450, 160);
            this.nudChildren.Name = "nudChildren";
            this.nudChildren.Size = new System.Drawing.Size(120, 30);
            this.nudChildren.TabIndex = 19;
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAdults.Location = new System.Drawing.Point(50, 160);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(63, 25);
            this.lblAdults.TabIndex = 16;
            this.lblAdults.Text = "Adults";
            // 
            // nudAdults
            // 
            this.nudAdults.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdults.Location = new System.Drawing.Point(200, 160);
            this.nudAdults.Name = "nudAdults";
            this.nudAdults.Size = new System.Drawing.Size(120, 30);
            this.nudAdults.TabIndex = 17;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCheckOut.Location = new System.Drawing.Point(50, 100);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(98, 25);
            this.lblCheckOut.TabIndex = 14;
            this.lblCheckOut.Text = "Check-Out";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(200, 100);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(450, 30);
            this.dtpCheckOut.TabIndex = 15;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCheckIn.Location = new System.Drawing.Point(50, 40);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(81, 25);
            this.lblCheckIn.TabIndex = 12;
            this.lblCheckIn.Text = "Check-In";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(200, 40);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(450, 30);
            this.dtpCheckIn.TabIndex = 13;
            // 
            // tabRoomAssignment
            // 
            this.tabRoomAssignment.BackColor = System.Drawing.Color.White;
            this.tabRoomAssignment.Controls.Add(this.lblRoomSelection);
            this.tabRoomAssignment.Controls.Add(this.btnAddRoom);
            this.tabRoomAssignment.Controls.Add(this.dgvAvailableRooms);
            this.tabRoomAssignment.Location = new System.Drawing.Point(4, 29);
            this.tabRoomAssignment.Name = "tabRoomAssignment";
            this.tabRoomAssignment.Size = new System.Drawing.Size(712, 607);
            this.tabRoomAssignment.TabIndex = 2;
            this.tabRoomAssignment.Text = "3. Room Assignment";
            // 
            // lblRoomSelection
            // 
            this.lblRoomSelection.AutoSize = true;
            this.lblRoomSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRoomSelection.Location = new System.Drawing.Point(30, 30);
            this.lblRoomSelection.Name = "lblRoomSelection";
            this.lblRoomSelection.Size = new System.Drawing.Size(151, 28);
            this.lblRoomSelection.TabIndex = 3;
            this.lblRoomSelection.Text = "Available Rooms";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(562, 25);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 45);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            // 
            // dgvAvailableRooms
            // 
            this.dgvAvailableRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailableRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableRooms.Location = new System.Drawing.Point(30, 70);
            this.dgvAvailableRooms.Name = "dgvAvailableRooms";
            this.dgvAvailableRooms.RowHeadersWidth = 51;
            this.dgvAvailableRooms.RowTemplate.Height = 24;
            this.dgvAvailableRooms.Size = new System.Drawing.Size(652, 490);
            this.dgvAvailableRooms.TabIndex = 0;
            // 
            // tabRateSummary
            // 
            this.tabRateSummary.BackColor = System.Drawing.Color.White;
            this.tabRateSummary.Controls.Add(this.lblTotalAmount);
            this.tabRateSummary.Controls.Add(this.lblRatePerNight);
            this.tabRateSummary.Controls.Add(this.lblTotalAmountValue);
            this.tabRateSummary.Controls.Add(this.lblRatePerNightValue);
            this.tabRateSummary.Location = new System.Drawing.Point(4, 29);
            this.tabRateSummary.Name = "tabRateSummary";
            this.tabRateSummary.Size = new System.Drawing.Size(712, 607);
            this.tabRateSummary.TabIndex = 3;
            this.tabRateSummary.Text = "4. Rate Summary";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(200, 300);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(133, 28);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblRatePerNight
            // 
            this.lblRatePerNight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRatePerNight.AutoSize = true;
            this.lblRatePerNight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatePerNight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRatePerNight.Location = new System.Drawing.Point(200, 200);
            this.lblRatePerNight.Name = "lblRatePerNight";
            this.lblRatePerNight.Size = new System.Drawing.Size(145, 28);
            this.lblRatePerNight.TabIndex = 0;
            this.lblRatePerNight.Text = "Rate Per Night:";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(350, 290);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(90, 38);
            this.lblTotalAmountValue.TabIndex = 3;
            this.lblTotalAmountValue.Text = "$0.00";
            // 
            // lblRatePerNightValue
            // 
            this.lblRatePerNightValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRatePerNightValue.AutoSize = true;
            this.lblRatePerNightValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatePerNightValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblRatePerNightValue.Location = new System.Drawing.Point(350, 190);
            this.lblRatePerNightValue.Name = "lblRatePerNightValue";
            this.lblRatePerNightValue.Size = new System.Drawing.Size(90, 38);
            this.lblRatePerNightValue.TabIndex = 2;
            this.lblRatePerNightValue.Text = "$0.00";
            // 
            // tabConfirmation
            // 
            this.tabConfirmation.BackColor = System.Drawing.Color.White;
            this.tabConfirmation.Controls.Add(this.lblBookingReference);
            this.tabConfirmation.Controls.Add(this.btnConfirmReservation);
            this.tabConfirmation.Controls.Add(this.lblBookingReferenceValue);
            this.tabConfirmation.Location = new System.Drawing.Point(4, 29);
            this.tabConfirmation.Name = "tabConfirmation";
            this.tabConfirmation.Size = new System.Drawing.Size(712, 607);
            this.tabConfirmation.TabIndex = 4;
            this.tabConfirmation.Text = "5. Confirmation";
            // 
            // lblBookingReference
            // 
            this.lblBookingReference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookingReference.AutoSize = true;
            this.lblBookingReference.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblBookingReference.Location = new System.Drawing.Point(200, 200);
            this.lblBookingReference.Name = "lblBookingReference";
            this.lblBookingReference.Size = new System.Drawing.Size(177, 28);
            this.lblBookingReference.TabIndex = 0;
            this.lblBookingReference.Text = "Booking Reference:";
            // 
            // btnConfirmReservation
            // 
            this.btnConfirmReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmReservation.FlatAppearance.BorderSize = 0;
            this.btnConfirmReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReservation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReservation.Location = new System.Drawing.Point(256, 300);
            this.btnConfirmReservation.Name = "btnConfirmReservation";
            this.btnConfirmReservation.Size = new System.Drawing.Size(200, 60);
            this.btnConfirmReservation.TabIndex = 2;
            this.btnConfirmReservation.Text = "Confirm Reservation";
            this.btnConfirmReservation.UseVisualStyleBackColor = false;
            // 
            // lblBookingReferenceValue
            // 
            this.lblBookingReferenceValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookingReferenceValue.AutoSize = true;
            this.lblBookingReferenceValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingReferenceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblBookingReferenceValue.Location = new System.Drawing.Point(400, 195);
            this.lblBookingReferenceValue.Name = "lblBookingReferenceValue";
            this.lblBookingReferenceValue.Size = new System.Drawing.Size(110, 31);
            this.lblBookingReferenceValue.TabIndex = 1;
            this.lblBookingReferenceValue.Text = "REF-0000";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - New Reservation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.tabReservation.ResumeLayout(false);
            this.tabGuest.ResumeLayout(false);
            this.tabGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).EndInit();
            this.tabRoomAssignment.ResumeLayout(false);
            this.tabRoomAssignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).EndInit();
            this.tabRateSummary.ResumeLayout(false);
            this.tabRateSummary.PerformLayout();
            this.tabConfirmation.ResumeLayout(false);
            this.tabConfirmation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.TabControl tabReservation;
        private System.Windows.Forms.TabPage tabGuest;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabRoomAssignment;
        private System.Windows.Forms.TabPage tabRateSummary;
        private System.Windows.Forms.TabPage tabConfirmation;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.NumericUpDown nudAdults;
        private System.Windows.Forms.NumericUpDown nudChildren;
        private System.Windows.Forms.TextBox txtSpecialRequests;
        private System.Windows.Forms.ComboBox cboReservationType;
        private System.Windows.Forms.DataGridView dgvAvailableRooms;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblBookingReference;
        private System.Windows.Forms.Button btnConfirmReservation;

        // NEW LABELS ADDED:
        private System.Windows.Forms.Label lblGuestSelection;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.Label lblReservationType;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblRoomSelection;
        private System.Windows.Forms.Label lblRatePerNight;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblRatePerNightValue;
        private System.Windows.Forms.Label lblBookingReferenceValue;
    }
}