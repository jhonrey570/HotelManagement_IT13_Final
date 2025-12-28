namespace HotelManagement_IT13_Final.Forms.CheckInOut
{
    partial class frmCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIn));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.grpArrivals = new System.Windows.Forms.GroupBox();
            this.dgvArrivalsToday = new System.Windows.Forms.DataGridView();
            this.btnConfirmCheckIn = new System.Windows.Forms.Button();
            this.lblTitleArrival = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.grpArrivals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivalsToday)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(121, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check-In";
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
            this.lblSidebarTitle.Size = new System.Drawing.Size(117, 28);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Today\'s List";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.grpArrivals);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // grpArrivals
            // 
            this.grpArrivals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpArrivals.BackColor = System.Drawing.Color.White;
            this.grpArrivals.Controls.Add(this.dgvArrivalsToday);
            this.grpArrivals.Controls.Add(this.btnConfirmCheckIn);
            this.grpArrivals.Controls.Add(this.lblTitleArrival);
            this.grpArrivals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpArrivals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpArrivals.Location = new System.Drawing.Point(20, 20);
            this.grpArrivals.Name = "grpArrivals";
            this.grpArrivals.Size = new System.Drawing.Size(720, 640);
            this.grpArrivals.TabIndex = 0;
            this.grpArrivals.TabStop = false;
            // 
            // dgvArrivalsToday
            // 
            this.dgvArrivalsToday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArrivalsToday.BackgroundColor = System.Drawing.Color.White;
            this.dgvArrivalsToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArrivalsToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArrivalsToday.Location = new System.Drawing.Point(30, 100);
            this.dgvArrivalsToday.Name = "dgvArrivalsToday";
            this.dgvArrivalsToday.RowHeadersWidth = 51;
            this.dgvArrivalsToday.RowTemplate.Height = 24;
            this.dgvArrivalsToday.Size = new System.Drawing.Size(660, 460);
            this.dgvArrivalsToday.TabIndex = 0;
            // 
            // btnConfirmCheckIn
            // 
            this.btnConfirmCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCheckIn.FlatAppearance.BorderSize = 0;
            this.btnConfirmCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCheckIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCheckIn.Location = new System.Drawing.Point(570, 570);
            this.btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            this.btnConfirmCheckIn.Size = new System.Drawing.Size(120, 45);
            this.btnConfirmCheckIn.TabIndex = 1;
            this.btnConfirmCheckIn.Text = "Check-In";
            this.btnConfirmCheckIn.UseVisualStyleBackColor = false;
            // 
            // lblTitleArrival
            // 
            this.lblTitleArrival.AutoSize = true;
            this.lblTitleArrival.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleArrival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitleArrival.Location = new System.Drawing.Point(30, 40);
            this.lblTitleArrival.Name = "lblTitleArrival";
            this.lblTitleArrival.Size = new System.Drawing.Size(185, 28);
            this.lblTitleArrival.TabIndex = 2;
            this.lblTitleArrival.Text = "Today\'s Arrivals List";
            // 
            // frmCheckIn
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
            this.Name = "frmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Check-In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.grpArrivals.ResumeLayout(false);
            this.grpArrivals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArrivalsToday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.GroupBox grpArrivals;
        private System.Windows.Forms.DataGridView dgvArrivalsToday;
        private System.Windows.Forms.Button btnConfirmCheckIn;
        private System.Windows.Forms.Label lblTitleArrival;
    }
}