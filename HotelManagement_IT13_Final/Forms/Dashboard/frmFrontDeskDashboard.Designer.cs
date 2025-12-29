namespace HotelManagement_IT13_Final.Forms.Dashboard
{
    partial class frmFrontDeskDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrontDeskDashboard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.btnRoomStatus = new System.Windows.Forms.Button();
            this.btnGuestSearch = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.grpTodaysActivities = new System.Windows.Forms.GroupBox();
            this.dgvTodaysActivities = new System.Windows.Forms.DataGridView();
            this.panelStatsContainer = new System.Windows.Forms.Panel();
            this.btnQuickCheckIn = new System.Windows.Forms.Button();
            this.btnQuickGuestLookup = new System.Windows.Forms.Button();
            this.lblActivitiesTitle = new System.Windows.Forms.Label();
            this.grpDeparturesToday = new System.Windows.Forms.GroupBox();
            this.lblDeparturesValue = new System.Windows.Forms.Label();
            this.lblDeparturesTitle = new System.Windows.Forms.Label();
            this.grpArrivalsToday = new System.Windows.Forms.GroupBox();
            this.lblArrivalsValue = new System.Windows.Forms.Label();
            this.lblArrivalsTitle = new System.Windows.Forms.Label();
            this.grpOccupancy = new System.Windows.Forms.GroupBox();
            this.lblOccupancyValue = new System.Windows.Forms.Label();
            this.lblOccupancyTitle = new System.Windows.Forms.Label();
            this.timerRefreshDashboard = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.grpTodaysActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaysActivities)).BeginInit();
            this.panelStatsContainer.SuspendLayout();
            this.grpDeparturesToday.SuspendLayout();
            this.grpArrivalsToday.SuspendLayout();
            this.grpOccupancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblDashboardTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(291, 41);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Front Desk Dashboard";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.lblQuickActions);
            this.panelSidebar.Controls.Add(this.btnRoomStatus);
            this.panelSidebar.Controls.Add(this.btnGuestSearch);
            this.panelSidebar.Controls.Add(this.btnCheckOut);
            this.panelSidebar.Controls.Add(this.btnCheckIn);
            this.panelSidebar.Controls.Add(this.btnNewReservation);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 680);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickActions.ForeColor = System.Drawing.Color.White;
            this.lblQuickActions.Location = new System.Drawing.Point(15, 30);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(130, 28);
            this.lblQuickActions.TabIndex = 5;
            this.lblQuickActions.Text = "Quick Actions";
            // 
            // btnRoomStatus
            // 
            this.btnRoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRoomStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomStatus.FlatAppearance.BorderSize = 0;
            this.btnRoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomStatus.ForeColor = System.Drawing.Color.White;
            this.btnRoomStatus.Location = new System.Drawing.Point(20, 300);
            this.btnRoomStatus.Name = "btnRoomStatus";
            this.btnRoomStatus.Size = new System.Drawing.Size(200, 45);
            this.btnRoomStatus.TabIndex = 4;
            this.btnRoomStatus.Text = "Room Status";
            this.btnRoomStatus.UseVisualStyleBackColor = false;
            // 
            // btnGuestSearch
            // 
            this.btnGuestSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnGuestSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuestSearch.FlatAppearance.BorderSize = 0;
            this.btnGuestSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestSearch.ForeColor = System.Drawing.Color.White;
            this.btnGuestSearch.Location = new System.Drawing.Point(20, 245);
            this.btnGuestSearch.Name = "btnGuestSearch";
            this.btnGuestSearch.Size = new System.Drawing.Size(200, 45);
            this.btnGuestSearch.TabIndex = 3;
            this.btnGuestSearch.Text = "Guest Search";
            this.btnGuestSearch.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(20, 190);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(200, 45);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(20, 135);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(200, 45);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNewReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewReservation.FlatAppearance.BorderSize = 0;
            this.btnNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReservation.ForeColor = System.Drawing.Color.White;
            this.btnNewReservation.Location = new System.Drawing.Point(20, 80);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(200, 45);
            this.btnNewReservation.TabIndex = 0;
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = false;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.grpTodaysActivities);
            this.panelMainContent.Controls.Add(this.panelStatsContainer);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // grpTodaysActivities
            // 
            this.grpTodaysActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTodaysActivities.BackColor = System.Drawing.Color.White;
            this.grpTodaysActivities.Controls.Add(this.dgvTodaysActivities);
            this.grpTodaysActivities.Controls.Add(this.btnQuickCheckIn);
            this.grpTodaysActivities.Controls.Add(this.btnQuickGuestLookup);
            this.grpTodaysActivities.Controls.Add(this.lblActivitiesTitle);
            this.grpTodaysActivities.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTodaysActivities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpTodaysActivities.Location = new System.Drawing.Point(20, 200);
            this.grpTodaysActivities.Name = "grpTodaysActivities";
            this.grpTodaysActivities.Size = new System.Drawing.Size(720, 460);
            this.grpTodaysActivities.TabIndex = 3;
            this.grpTodaysActivities.TabStop = false;
            // 
            // dgvTodaysActivities
            // 
            this.dgvTodaysActivities.AllowUserToAddRows = false;
            this.dgvTodaysActivities.AllowUserToDeleteRows = false;
            this.dgvTodaysActivities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTodaysActivities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodaysActivities.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodaysActivities.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodaysActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodaysActivities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTodaysActivities.Location = new System.Drawing.Point(30, 80);
            this.dgvTodaysActivities.MultiSelect = false;
            this.dgvTodaysActivities.Name = "dgvTodaysActivities";
            this.dgvTodaysActivities.ReadOnly = true;
            this.dgvTodaysActivities.RowHeadersWidth = 51;
            this.dgvTodaysActivities.RowTemplate.Height = 24;
            this.dgvTodaysActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodaysActivities.Size = new System.Drawing.Size(660, 320);
            this.dgvTodaysActivities.TabIndex = 0;
            // 
            // panelStatsContainer
            // 
            this.panelStatsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatsContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelStatsContainer.Controls.Add(this.grpDeparturesToday);
            this.panelStatsContainer.Controls.Add(this.grpArrivalsToday);
            this.panelStatsContainer.Controls.Add(this.grpOccupancy);
            this.panelStatsContainer.Location = new System.Drawing.Point(20, 20);
            this.panelStatsContainer.Name = "panelStatsContainer";
            this.panelStatsContainer.Size = new System.Drawing.Size(720, 160);
            this.panelStatsContainer.TabIndex = 2;
            // 
            // btnQuickCheckIn
            // 
            this.btnQuickCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnQuickCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickCheckIn.FlatAppearance.BorderSize = 0;
            this.btnQuickCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnQuickCheckIn.Location = new System.Drawing.Point(450, 410);
            this.btnQuickCheckIn.Name = "btnQuickCheckIn";
            this.btnQuickCheckIn.Size = new System.Drawing.Size(120, 40);
            this.btnQuickCheckIn.TabIndex = 1;
            this.btnQuickCheckIn.Text = "Quick Check-In";
            this.btnQuickCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnQuickGuestLookup
            // 
            this.btnQuickGuestLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickGuestLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuickGuestLookup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuickGuestLookup.FlatAppearance.BorderSize = 0;
            this.btnQuickGuestLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickGuestLookup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickGuestLookup.ForeColor = System.Drawing.Color.White;
            this.btnQuickGuestLookup.Location = new System.Drawing.Point(570, 410);
            this.btnQuickGuestLookup.Name = "btnQuickGuestLookup";
            this.btnQuickGuestLookup.Size = new System.Drawing.Size(120, 40);
            this.btnQuickGuestLookup.TabIndex = 2;
            this.btnQuickGuestLookup.Text = "Guest Lookup";
            this.btnQuickGuestLookup.UseVisualStyleBackColor = false;
            // 
            // lblActivitiesTitle
            // 
            this.lblActivitiesTitle.AutoSize = true;
            this.lblActivitiesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivitiesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblActivitiesTitle.Location = new System.Drawing.Point(30, 40);
            this.lblActivitiesTitle.Name = "lblActivitiesTitle";
            this.lblActivitiesTitle.Size = new System.Drawing.Size(152, 28);
            this.lblActivitiesTitle.TabIndex = 3;
            this.lblActivitiesTitle.Text = "Today\'s Activities";
            // 
            // grpDeparturesToday
            // 
            this.grpDeparturesToday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpDeparturesToday.BackColor = System.Drawing.Color.White;
            this.grpDeparturesToday.Controls.Add(this.lblDeparturesValue);
            this.grpDeparturesToday.Controls.Add(this.lblDeparturesTitle);
            this.grpDeparturesToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDeparturesToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeparturesToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpDeparturesToday.Location = new System.Drawing.Point(470, 20);
            this.grpDeparturesToday.Name = "grpDeparturesToday";
            this.grpDeparturesToday.Size = new System.Drawing.Size(220, 120);
            this.grpDeparturesToday.TabIndex = 2;
            this.grpDeparturesToday.TabStop = false;
            // 
            // lblDeparturesValue
            // 
            this.lblDeparturesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeparturesValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparturesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblDeparturesValue.Location = new System.Drawing.Point(3, 50);
            this.lblDeparturesValue.Name = "lblDeparturesValue";
            this.lblDeparturesValue.Size = new System.Drawing.Size(214, 67);
            this.lblDeparturesValue.TabIndex = 3;
            this.lblDeparturesValue.Text = "12";
            this.lblDeparturesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeparturesTitle
            // 
            this.lblDeparturesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeparturesTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparturesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDeparturesTitle.Location = new System.Drawing.Point(3, 18);
            this.lblDeparturesTitle.Name = "lblDeparturesTitle";
            this.lblDeparturesTitle.Size = new System.Drawing.Size(214, 32);
            this.lblDeparturesTitle.TabIndex = 2;
            this.lblDeparturesTitle.Text = "Departures";
            this.lblDeparturesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpArrivalsToday
            // 
            this.grpArrivalsToday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpArrivalsToday.BackColor = System.Drawing.Color.White;
            this.grpArrivalsToday.Controls.Add(this.lblArrivalsValue);
            this.grpArrivalsToday.Controls.Add(this.lblArrivalsTitle);
            this.grpArrivalsToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpArrivalsToday.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpArrivalsToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpArrivalsToday.Location = new System.Drawing.Point(240, 20);
            this.grpArrivalsToday.Name = "grpArrivalsToday";
            this.grpArrivalsToday.Size = new System.Drawing.Size(220, 120);
            this.grpArrivalsToday.TabIndex = 1;
            this.grpArrivalsToday.TabStop = false;
            // 
            // lblArrivalsValue
            // 
            this.lblArrivalsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArrivalsValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblArrivalsValue.Location = new System.Drawing.Point(3, 50);
            this.lblArrivalsValue.Name = "lblArrivalsValue";
            this.lblArrivalsValue.Size = new System.Drawing.Size(214, 67);
            this.lblArrivalsValue.TabIndex = 3;
            this.lblArrivalsValue.Text = "15";
            this.lblArrivalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArrivalsTitle
            // 
            this.lblArrivalsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArrivalsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblArrivalsTitle.Location = new System.Drawing.Point(3, 18);
            this.lblArrivalsTitle.Name = "lblArrivalsTitle";
            this.lblArrivalsTitle.Size = new System.Drawing.Size(214, 32);
            this.lblArrivalsTitle.TabIndex = 2;
            this.lblArrivalsTitle.Text = "Arrivals";
            this.lblArrivalsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpOccupancy
            // 
            this.grpOccupancy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOccupancy.BackColor = System.Drawing.Color.White;
            this.grpOccupancy.Controls.Add(this.lblOccupancyValue);
            this.grpOccupancy.Controls.Add(this.lblOccupancyTitle);
            this.grpOccupancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOccupancy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOccupancy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpOccupancy.Location = new System.Drawing.Point(10, 20);
            this.grpOccupancy.Name = "grpOccupancy";
            this.grpOccupancy.Size = new System.Drawing.Size(220, 120);
            this.grpOccupancy.TabIndex = 0;
            this.grpOccupancy.TabStop = false;
            // 
            // lblOccupancyValue
            // 
            this.lblOccupancyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOccupancyValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupancyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblOccupancyValue.Location = new System.Drawing.Point(3, 50);
            this.lblOccupancyValue.Name = "lblOccupancyValue";
            this.lblOccupancyValue.Size = new System.Drawing.Size(214, 67);
            this.lblOccupancyValue.TabIndex = 3;
            this.lblOccupancyValue.Text = "85%";
            this.lblOccupancyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOccupancyTitle
            // 
            this.lblOccupancyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOccupancyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupancyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblOccupancyTitle.Location = new System.Drawing.Point(3, 18);
            this.lblOccupancyTitle.Name = "lblOccupancyTitle";
            this.lblOccupancyTitle.Size = new System.Drawing.Size(214, 32);
            this.lblOccupancyTitle.TabIndex = 2;
            this.lblOccupancyTitle.Text = "Occupancy";
            this.lblOccupancyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefreshDashboard
            // 
            this.timerRefreshDashboard.Interval = 30000;
            // 
            // frmFrontDeskDashboard
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
            this.Name = "frmFrontDeskDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Front Desk Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.grpTodaysActivities.ResumeLayout(false);
            this.grpTodaysActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaysActivities)).EndInit();
            this.panelStatsContainer.ResumeLayout(false);
            this.grpDeparturesToday.ResumeLayout(false);
            this.grpArrivalsToday.ResumeLayout(false);
            this.grpOccupancy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Button btnRoomStatus;
        private System.Windows.Forms.Button btnGuestSearch;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.GroupBox grpTodaysActivities;
        private System.Windows.Forms.DataGridView dgvTodaysActivities;
        private System.Windows.Forms.Panel panelStatsContainer;
        private System.Windows.Forms.Button btnQuickCheckIn;
        private System.Windows.Forms.Button btnQuickGuestLookup;
        private System.Windows.Forms.Label lblActivitiesTitle;
        private System.Windows.Forms.GroupBox grpDeparturesToday;
        private System.Windows.Forms.Label lblDeparturesValue;
        private System.Windows.Forms.Label lblDeparturesTitle;
        private System.Windows.Forms.GroupBox grpArrivalsToday;
        private System.Windows.Forms.Label lblArrivalsValue;
        private System.Windows.Forms.Label lblArrivalsTitle;
        private System.Windows.Forms.GroupBox grpOccupancy;
        private System.Windows.Forms.Label lblOccupancyValue;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.Timer timerRefreshDashboard;
    }
}