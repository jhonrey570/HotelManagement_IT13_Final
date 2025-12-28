namespace HotelManagement_IT13_Final.Forms.Reports
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabOccupancyReport = new System.Windows.Forms.TabPage();
            this.grpOccupancyReport = new System.Windows.Forms.GroupBox();
            this.dgvOccupancyReport = new System.Windows.Forms.DataGridView();
            this.lblOccupancyTitle = new System.Windows.Forms.Label();
            this.tabFinancialReport = new System.Windows.Forms.TabPage();
            this.grpFinancialReport = new System.Windows.Forms.GroupBox();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvFinancialReport = new System.Windows.Forms.DataGridView();
            this.lblFinancialTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabOccupancyReport.SuspendLayout();
            this.grpOccupancyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupancyReport)).BeginInit();
            this.tabFinancialReport.SuspendLayout();
            this.grpFinancialReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialReport)).BeginInit();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports & Analytics";
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
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(20, 30);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(82, 28);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Reports";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.tabReports);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.tabOccupancyReport);
            this.tabReports.Controls.Add(this.tabFinancialReport);
            this.tabReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabReports.Location = new System.Drawing.Point(20, 20);
            this.tabReports.Name = "tabReports";
            this.tabReports.SelectedIndex = 0;
            this.tabReports.Size = new System.Drawing.Size(720, 640);
            this.tabReports.TabIndex = 0;
            // 
            // tabOccupancyReport
            // 
            this.tabOccupancyReport.BackColor = System.Drawing.Color.White;
            this.tabOccupancyReport.Controls.Add(this.grpOccupancyReport);
            this.tabOccupancyReport.Location = new System.Drawing.Point(4, 29);
            this.tabOccupancyReport.Name = "tabOccupancyReport";
            this.tabOccupancyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabOccupancyReport.Size = new System.Drawing.Size(712, 607);
            this.tabOccupancyReport.TabIndex = 0;
            this.tabOccupancyReport.Text = "Occupancy Report";
            // 
            // grpOccupancyReport
            // 
            this.grpOccupancyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOccupancyReport.BackColor = System.Drawing.Color.White;
            this.grpOccupancyReport.Controls.Add(this.dgvOccupancyReport);
            this.grpOccupancyReport.Controls.Add(this.lblOccupancyTitle);
            this.grpOccupancyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOccupancyReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpOccupancyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpOccupancyReport.Location = new System.Drawing.Point(20, 20);
            this.grpOccupancyReport.Name = "grpOccupancyReport";
            this.grpOccupancyReport.Size = new System.Drawing.Size(672, 567);
            this.grpOccupancyReport.TabIndex = 0;
            this.grpOccupancyReport.TabStop = false;
            // 
            // dgvOccupancyReport
            // 
            this.dgvOccupancyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOccupancyReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvOccupancyReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOccupancyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccupancyReport.Location = new System.Drawing.Point(30, 80);
            this.dgvOccupancyReport.Name = "dgvOccupancyReport";
            this.dgvOccupancyReport.RowHeadersWidth = 51;
            this.dgvOccupancyReport.RowTemplate.Height = 24;
            this.dgvOccupancyReport.Size = new System.Drawing.Size(612, 470);
            this.dgvOccupancyReport.TabIndex = 1;
            // 
            // lblOccupancyTitle
            // 
            this.lblOccupancyTitle.AutoSize = true;
            this.lblOccupancyTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOccupancyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblOccupancyTitle.Location = new System.Drawing.Point(30, 30);
            this.lblOccupancyTitle.Name = "lblOccupancyTitle";
            this.lblOccupancyTitle.Size = new System.Drawing.Size(164, 28);
            this.lblOccupancyTitle.TabIndex = 2;
            this.lblOccupancyTitle.Text = "Occupancy Report";
            // 
            // tabFinancialReport
            // 
            this.tabFinancialReport.BackColor = System.Drawing.Color.White;
            this.tabFinancialReport.Controls.Add(this.grpFinancialReport);
            this.tabFinancialReport.Location = new System.Drawing.Point(4, 29);
            this.tabFinancialReport.Name = "tabFinancialReport";
            this.tabFinancialReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinancialReport.Size = new System.Drawing.Size(712, 607);
            this.tabFinancialReport.TabIndex = 1;
            this.tabFinancialReport.Text = "Financial Report";
            // 
            // grpFinancialReport
            // 
            this.grpFinancialReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFinancialReport.BackColor = System.Drawing.Color.White;
            this.grpFinancialReport.Controls.Add(this.chartRevenue);
            this.grpFinancialReport.Controls.Add(this.dgvFinancialReport);
            this.grpFinancialReport.Controls.Add(this.lblFinancialTitle);
            this.grpFinancialReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpFinancialReport.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpFinancialReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpFinancialReport.Location = new System.Drawing.Point(20, 20);
            this.grpFinancialReport.Name = "grpFinancialReport";
            this.grpFinancialReport.Size = new System.Drawing.Size(672, 567);
            this.grpFinancialReport.TabIndex = 0;
            this.grpFinancialReport.TabStop = false;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(30, 80);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(612, 250);
            this.chartRevenue.TabIndex = 4;
            this.chartRevenue.Text = "Revenue Trend";
            // 
            // dgvFinancialReport
            // 
            this.dgvFinancialReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFinancialReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinancialReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinancialReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinancialReport.Location = new System.Drawing.Point(30, 360);
            this.dgvFinancialReport.Name = "dgvFinancialReport";
            this.dgvFinancialReport.RowHeadersWidth = 51;
            this.dgvFinancialReport.RowTemplate.Height = 24;
            this.dgvFinancialReport.Size = new System.Drawing.Size(612, 190);
            this.dgvFinancialReport.TabIndex = 3;
            // 
            // lblFinancialTitle
            // 
            this.lblFinancialTitle.AutoSize = true;
            this.lblFinancialTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinancialTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblFinancialTitle.Location = new System.Drawing.Point(30, 30);
            this.lblFinancialTitle.Name = "lblFinancialTitle";
            this.lblFinancialTitle.Size = new System.Drawing.Size(154, 28);
            this.lblFinancialTitle.TabIndex = 5;
            this.lblFinancialTitle.Text = "Financial Report";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Reports & Analytics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabOccupancyReport.ResumeLayout(false);
            this.grpOccupancyReport.ResumeLayout(false);
            this.grpOccupancyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupancyReport)).EndInit();
            this.tabFinancialReport.ResumeLayout(false);
            this.grpFinancialReport.ResumeLayout(false);
            this.grpFinancialReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinancialReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabOccupancyReport;
        private System.Windows.Forms.TabPage tabFinancialReport;
        private System.Windows.Forms.GroupBox grpOccupancyReport;
        private System.Windows.Forms.DataGridView dgvOccupancyReport;
        private System.Windows.Forms.Label lblOccupancyTitle;
        private System.Windows.Forms.GroupBox grpFinancialReport;
        private System.Windows.Forms.DataGridView dgvFinancialReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label lblFinancialTitle;
    }
}