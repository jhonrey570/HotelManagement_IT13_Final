namespace HotelManagement_IT13_Final.Forms.CheckInOut
{
    partial class frmCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckOut));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.grpDepartures = new System.Windows.Forms.GroupBox();
            this.dgvDeparturesToday = new System.Windows.Forms.DataGridView();
            this.btnConfirmCheckOut = new System.Windows.Forms.Button();
            this.lblTitleDepartures = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.grpDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeparturesToday)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(138, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check-Out";
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
            this.lblSidebarTitle.Size = new System.Drawing.Size(163, 28);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Departures List";
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.grpDepartures);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // grpDepartures
            // 
            this.grpDepartures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDepartures.BackColor = System.Drawing.Color.White;
            this.grpDepartures.Controls.Add(this.dgvDeparturesToday);
            this.grpDepartures.Controls.Add(this.btnConfirmCheckOut);
            this.grpDepartures.Controls.Add(this.lblTitleDepartures);
            this.grpDepartures.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDepartures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpDepartures.Location = new System.Drawing.Point(20, 20);
            this.grpDepartures.Name = "grpDepartures";
            this.grpDepartures.Size = new System.Drawing.Size(720, 640);
            this.grpDepartures.TabIndex = 0;
            this.grpDepartures.TabStop = false;
            // 
            // dgvDeparturesToday
            // 
            this.dgvDeparturesToday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeparturesToday.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeparturesToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeparturesToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeparturesToday.Location = new System.Drawing.Point(30, 100);
            this.dgvDeparturesToday.Name = "dgvDeparturesToday";
            this.dgvDeparturesToday.RowHeadersWidth = 51;
            this.dgvDeparturesToday.RowTemplate.Height = 24;
            this.dgvDeparturesToday.Size = new System.Drawing.Size(660, 460);
            this.dgvDeparturesToday.TabIndex = 0;
            // 
            // btnConfirmCheckOut
            // 
            this.btnConfirmCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnConfirmCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCheckOut.FlatAppearance.BorderSize = 0;
            this.btnConfirmCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmCheckOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCheckOut.Location = new System.Drawing.Point(570, 570);
            this.btnConfirmCheckOut.Name = "btnConfirmCheckOut";
            this.btnConfirmCheckOut.Size = new System.Drawing.Size(120, 45);
            this.btnConfirmCheckOut.TabIndex = 1;
            this.btnConfirmCheckOut.Text = "Check-Out";
            this.btnConfirmCheckOut.UseVisualStyleBackColor = false;
            // 
            // lblTitleDepartures
            // 
            this.lblTitleDepartures.AutoSize = true;
            this.lblTitleDepartures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleDepartures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitleDepartures.Location = new System.Drawing.Point(30, 40);
            this.lblTitleDepartures.Name = "lblTitleDepartures";
            this.lblTitleDepartures.Size = new System.Drawing.Size(172, 28);
            this.lblTitleDepartures.TabIndex = 2;
            this.lblTitleDepartures.Text = "Departures Today";
            // 
            // frmCheckOut
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
            this.Name = "frmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Check-Out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.grpDepartures.ResumeLayout(false);
            this.grpDepartures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeparturesToday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.GroupBox grpDepartures;
        private System.Windows.Forms.DataGridView dgvDeparturesToday;
        private System.Windows.Forms.Button btnConfirmCheckOut;
        private System.Windows.Forms.Label lblTitleDepartures;
    }
}