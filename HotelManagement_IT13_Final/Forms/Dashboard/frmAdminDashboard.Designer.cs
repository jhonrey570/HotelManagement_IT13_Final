namespace HotelManagement_IT13_Final.Forms.Dashboard
{
    partial class frmAdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            this.grpOccupancy = new System.Windows.Forms.GroupBox();
            this.lblOccupancyValue = new System.Windows.Forms.Label();
            this.lblOccupancyTitle = new System.Windows.Forms.Label();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRoomManagement = new System.Windows.Forms.Button();
            this.btnRateManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.chartOccupancyTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.panelStatsContainer = new System.Windows.Forms.Panel();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupancyTrend)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelStatsContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.grpOccupancy.Location = new System.Drawing.Point(0, 40);
            this.grpOccupancy.Name = "grpOccupancy";
            this.grpOccupancy.Size = new System.Drawing.Size(250, 120);
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
            this.lblOccupancyValue.Size = new System.Drawing.Size(244, 67);
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
            this.lblOccupancyTitle.Size = new System.Drawing.Size(244, 32);
            this.lblOccupancyTitle.TabIndex = 2;
            this.lblOccupancyTitle.Text = "Occupancy";
            this.lblOccupancyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRevenue
            // 
            this.grpRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpRevenue.BackColor = System.Drawing.Color.White;
            this.grpRevenue.Controls.Add(this.lblRevenueValue);
            this.grpRevenue.Controls.Add(this.lblRevenueTitle);
            this.grpRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpRevenue.Location = new System.Drawing.Point(270, 40);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Size = new System.Drawing.Size(250, 120);
            this.grpRevenue.TabIndex = 2;
            this.grpRevenue.TabStop = false;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(3, 50);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(244, 67);
            this.lblRevenueValue.TabIndex = 3;
            this.lblRevenueValue.Text = "$15,230";
            this.lblRevenueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(3, 18);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(244, 32);
            this.lblRevenueTitle.TabIndex = 2;
            this.lblRevenueTitle.Text = "Revenue";
            this.lblRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnNewReservation.TabIndex = 4;
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = false;
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
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
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
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnRoomManagement
            // 
            this.btnRoomManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnRoomManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomManagement.FlatAppearance.BorderSize = 0;
            this.btnRoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomManagement.ForeColor = System.Drawing.Color.White;
            this.btnRoomManagement.Location = new System.Drawing.Point(20, 245);
            this.btnRoomManagement.Name = "btnRoomManagement";
            this.btnRoomManagement.Size = new System.Drawing.Size(200, 45);
            this.btnRoomManagement.TabIndex = 7;
            this.btnRoomManagement.Text = "Room Management";
            this.btnRoomManagement.UseVisualStyleBackColor = false;
            // 
            // btnRateManagement
            // 
            this.btnRateManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnRateManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRateManagement.FlatAppearance.BorderSize = 0;
            this.btnRateManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRateManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRateManagement.ForeColor = System.Drawing.Color.White;
            this.btnRateManagement.Location = new System.Drawing.Point(20, 300);
            this.btnRateManagement.Name = "btnRateManagement";
            this.btnRateManagement.Size = new System.Drawing.Size(200, 45);
            this.btnRateManagement.TabIndex = 8;
            this.btnRateManagement.Text = "Rate Management";
            this.btnRateManagement.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(20, 355);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 45);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // chartOccupancyTrend
            // 
            this.chartOccupancyTrend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartOccupancyTrend.ChartAreas.Add(chartArea1);
            this.chartOccupancyTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            legend1.Name = "Legend1";
            this.chartOccupancyTrend.Legends.Add(legend1);
            this.chartOccupancyTrend.Location = new System.Drawing.Point(20, 210);
            this.chartOccupancyTrend.Name = "chartOccupancyTrend";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            series1.Legend = "Legend1";
            series1.Name = "Occupancy %";
            this.chartOccupancyTrend.Series.Add(series1);
            this.chartOccupancyTrend.Size = new System.Drawing.Size(720, 420);
            this.chartOccupancyTrend.TabIndex = 10;
            this.chartOccupancyTrend.Text = "Occupancy Trend";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 15);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(295, 41);
            this.lblDashboardTitle.TabIndex = 11;
            this.lblDashboardTitle.Text = "Admin Dashboard";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.lblQuickActions);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnRateManagement);
            this.panelSidebar.Controls.Add(this.btnRoomManagement);
            this.panelSidebar.Controls.Add(this.btnCheckOut);
            this.panelSidebar.Controls.Add(this.btnCheckIn);
            this.panelSidebar.Controls.Add(this.btnNewReservation);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 680);
            this.panelSidebar.TabIndex = 12;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickActions.ForeColor = System.Drawing.Color.White;
            this.lblQuickActions.Location = new System.Drawing.Point(15, 30);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(130, 28);
            this.lblQuickActions.TabIndex = 10;
            this.lblQuickActions.Text = "Quick Actions";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblDashboardTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 14;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.lblChartTitle);
            this.panelMainContent.Controls.Add(this.chartOccupancyTrend);
            this.panelMainContent.Controls.Add(this.panelStatsContainer);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 13;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblChartTitle.Location = new System.Drawing.Point(20, 180);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(163, 28);
            this.lblChartTitle.TabIndex = 12;
            this.lblChartTitle.Text = "Occupancy Trend";
            // 
            // panelStatsContainer
            // 
            this.panelStatsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatsContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelStatsContainer.Controls.Add(this.lblStatsTitle);
            this.panelStatsContainer.Controls.Add(this.grpRevenue);
            this.panelStatsContainer.Controls.Add(this.grpOccupancy);
            this.panelStatsContainer.Location = new System.Drawing.Point(20, 20);
            this.panelStatsContainer.Name = "panelStatsContainer";
            this.panelStatsContainer.Size = new System.Drawing.Size(720, 160);
            this.panelStatsContainer.TabIndex = 11;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStatsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(105, 28);
            this.lblStatsTitle.TabIndex = 3;
            this.lblStatsTitle.Text = "Key Stats";
            // 
            // frmAdminDashboard
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
            this.Name = "frmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupancyTrend)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelMainContent.PerformLayout();
            this.panelStatsContainer.ResumeLayout(false);
            this.panelStatsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOccupancy;
        private System.Windows.Forms.Label lblOccupancyValue;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Button btnNewReservation;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnRoomManagement;
        private System.Windows.Forms.Button btnRateManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOccupancyTrend;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel panelStatsContainer;
        private System.Windows.Forms.Label lblStatsTitle;
    }
}