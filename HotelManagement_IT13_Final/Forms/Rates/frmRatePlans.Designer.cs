namespace HotelManagement_IT13_Final.Forms.Rates
{
    partial class frmRatePlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRatePlans));
            this.dgvRatePlans = new System.Windows.Forms.DataGridView();
            this.btnAddRatePlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatePlans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRatePlans
            // 
            this.dgvRatePlans.AllowUserToAddRows = false;
            this.dgvRatePlans.AllowUserToDeleteRows = false;
            this.dgvRatePlans.AllowUserToResizeRows = false;
            this.dgvRatePlans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRatePlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRatePlans.BackgroundColor = System.Drawing.Color.White;
            this.dgvRatePlans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRatePlans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRatePlans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRatePlans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRatePlans.ColumnHeadersHeight = 45;
            this.dgvRatePlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRatePlans.EnableHeadersVisualStyles = false;
            this.dgvRatePlans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvRatePlans.Location = new System.Drawing.Point(240, 70);
            this.dgvRatePlans.MultiSelect = false;
            this.dgvRatePlans.Name = "dgvRatePlans";
            this.dgvRatePlans.ReadOnly = true;
            this.dgvRatePlans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRatePlans.RowHeadersVisible = false;
            this.dgvRatePlans.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvRatePlans.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRatePlans.RowTemplate.Height = 40;
            this.dgvRatePlans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRatePlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRatePlans.ShowCellToolTips = false;
            this.dgvRatePlans.Size = new System.Drawing.Size(740, 660);
            this.dgvRatePlans.TabIndex = 0;
            // 
            // btnAddRatePlan
            // 
            this.btnAddRatePlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddRatePlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRatePlan.FlatAppearance.BorderSize = 0;
            this.btnAddRatePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRatePlan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRatePlan.ForeColor = System.Drawing.Color.White;
            this.btnAddRatePlan.Location = new System.Drawing.Point(20, 80);
            this.btnAddRatePlan.Name = "btnAddRatePlan";
            this.btnAddRatePlan.Size = new System.Drawing.Size(200, 45);
            this.btnAddRatePlan.TabIndex = 1;
            this.btnAddRatePlan.Text = "Add Rate Plan";
            this.btnAddRatePlan.UseVisualStyleBackColor = false;
            // 
            // frmRatePlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.btnAddRatePlan);
            this.Controls.Add(this.dgvRatePlans);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRatePlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Rate Plan Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvRatePlans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRatePlans;
        private System.Windows.Forms.Button btnAddRatePlan;
    }
}