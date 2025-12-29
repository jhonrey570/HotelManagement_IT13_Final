namespace HotelManagement_IT13_Final.Forms.Billing
{
    partial class frmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblBillingTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblBillingActions = new System.Windows.Forms.Label();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.btnCreateInvoice = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.tabBilling = new System.Windows.Forms.TabControl();
            this.tabInvoiceDetails = new System.Windows.Forms.TabPage();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.numPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblReferenceNumber = new System.Windows.Forms.Label();
            this.grpInvoiceItems = new System.Windows.Forms.GroupBox();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.grpGuestInformation = new System.Windows.Forms.GroupBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.tabPaymentProcessing = new System.Windows.Forms.TabPage();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabBillingHistory = new System.Windows.Forms.TabPage();
            this.grpBillingHistory = new System.Windows.Forms.GroupBox();
            this.btnSearchBilling = new System.Windows.Forms.Button();
            this.txtSearchBilling = new System.Windows.Forms.TextBox();
            this.dgvBillingHistory = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.tabBilling.SuspendLayout();
            this.tabInvoiceDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentAmount)).BeginInit();
            this.grpInvoiceItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.grpGuestInformation.SuspendLayout();
            this.tabBillingHistory.SuspendLayout();
            this.grpBillingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillingHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblBillingTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblBillingTitle
            // 
            this.lblBillingTitle.AutoSize = true;
            this.lblBillingTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingTitle.ForeColor = System.Drawing.Color.White;
            this.lblBillingTitle.Location = new System.Drawing.Point(20, 15);
            this.lblBillingTitle.Name = "lblBillingTitle";
            this.lblBillingTitle.Size = new System.Drawing.Size(251, 41);
            this.lblBillingTitle.TabIndex = 0;
            this.lblBillingTitle.Text = "Billing Management";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.lblBillingActions);
            this.panelSidebar.Controls.Add(this.btnExportReport);
            this.panelSidebar.Controls.Add(this.btnPrintReceipt);
            this.panelSidebar.Controls.Add(this.btnViewInvoice);
            this.panelSidebar.Controls.Add(this.btnProcessPayment);
            this.panelSidebar.Controls.Add(this.btnCreateInvoice);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 680);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblBillingActions
            // 
            this.lblBillingActions.AutoSize = true;
            this.lblBillingActions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingActions.ForeColor = System.Drawing.Color.White;
            this.lblBillingActions.Location = new System.Drawing.Point(15, 30);
            this.lblBillingActions.Name = "lblBillingActions";
            this.lblBillingActions.Size = new System.Drawing.Size(131, 28);
            this.lblBillingActions.TabIndex = 5;
            this.lblBillingActions.Text = "Billing Actions";
            // 
            // btnExportReport
            // 
            this.btnExportReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnExportReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportReport.FlatAppearance.BorderSize = 0;
            this.btnExportReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportReport.ForeColor = System.Drawing.Color.White;
            this.btnExportReport.Location = new System.Drawing.Point(20, 300);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(200, 45);
            this.btnExportReport.TabIndex = 4;
            this.btnExportReport.Text = "Export Report";
            this.btnExportReport.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location = new System.Drawing.Point(20, 245);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(200, 45);
            this.btnPrintReceipt.TabIndex = 3;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnViewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInvoice.FlatAppearance.BorderSize = 0;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnViewInvoice.Location = new System.Drawing.Point(20, 190);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(200, 45);
            this.btnViewInvoice.TabIndex = 2;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProcessPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessPayment.FlatAppearance.BorderSize = 0;
            this.btnProcessPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(20, 135);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(200, 45);
            this.btnProcessPayment.TabIndex = 1;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreateInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateInvoice.FlatAppearance.BorderSize = 0;
            this.btnCreateInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Location = new System.Drawing.Point(20, 80);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(200, 45);
            this.btnCreateInvoice.TabIndex = 0;
            this.btnCreateInvoice.Text = "Create Invoice";
            this.btnCreateInvoice.UseVisualStyleBackColor = false;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.tabBilling);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // tabBilling
            // 
            this.tabBilling.Controls.Add(this.tabInvoiceDetails);
            this.tabBilling.Controls.Add(this.tabPaymentProcessing);
            this.tabBilling.Controls.Add(this.tabBillingHistory);
            this.tabBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBilling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBilling.Location = new System.Drawing.Point(20, 20);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.SelectedIndex = 0;
            this.tabBilling.Size = new System.Drawing.Size(720, 640);
            this.tabBilling.TabIndex = 0;
            // 
            // tabInvoiceDetails
            // 
            this.tabInvoiceDetails.BackColor = System.Drawing.Color.White;
            this.tabInvoiceDetails.Controls.Add(this.btnSaveInvoice);
            this.tabInvoiceDetails.Controls.Add(this.btnCancel);
            this.tabInvoiceDetails.Controls.Add(this.grpPaymentDetails);
            this.tabInvoiceDetails.Controls.Add(this.grpInvoiceItems);
            this.tabInvoiceDetails.Controls.Add(this.grpGuestInformation);
            this.tabInvoiceDetails.Location = new System.Drawing.Point(4, 29);
            this.tabInvoiceDetails.Name = "tabInvoiceDetails";
            this.tabInvoiceDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoiceDetails.Size = new System.Drawing.Size(712, 607);
            this.tabInvoiceDetails.TabIndex = 0;
            this.tabInvoiceDetails.Text = "Invoice Details";
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPaymentDetails.BackColor = System.Drawing.Color.White;
            this.grpPaymentDetails.Controls.Add(this.dtpPaymentDate);
            this.grpPaymentDetails.Controls.Add(this.numPaymentAmount);
            this.grpPaymentDetails.Controls.Add(this.cboPaymentMethod);
            this.grpPaymentDetails.Controls.Add(this.txtReferenceNumber);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentDate);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentAmount);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentMethod);
            this.grpPaymentDetails.Controls.Add(this.lblReferenceNumber);
            this.grpPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpPaymentDetails.Location = new System.Drawing.Point(20, 380);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(672, 150);
            this.grpPaymentDetails.TabIndex = 2;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Location = new System.Drawing.Point(200, 100);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(450, 30);
            this.dtpPaymentDate.TabIndex = 3;
            // 
            // numPaymentAmount
            // 
            this.numPaymentAmount.DecimalPlaces = 2;
            this.numPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaymentAmount.Location = new System.Drawing.Point(200, 60);
            this.numPaymentAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPaymentAmount.Name = "numPaymentAmount";
            this.numPaymentAmount.Size = new System.Drawing.Size(450, 30);
            this.numPaymentAmount.TabIndex = 1;
            this.numPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPaymentAmount.ThousandsSeparator = true;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card",
            "Online Transfer",
            "Check"});
            this.cboPaymentMethod.Location = new System.Drawing.Point(200, 20);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(450, 31);
            this.cboPaymentMethod.TabIndex = 0;
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenceNumber.Location = new System.Drawing.Point(200, 140);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(450, 30);
            this.txtReferenceNumber.TabIndex = 5;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPaymentDate.Location = new System.Drawing.Point(20, 100);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(122, 25);
            this.lblPaymentDate.TabIndex = 0;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPaymentAmount.Location = new System.Drawing.Point(20, 60);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(149, 25);
            this.lblPaymentAmount.TabIndex = 0;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPaymentMethod.Location = new System.Drawing.Point(20, 20);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(146, 25);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblReferenceNumber
            // 
            this.lblReferenceNumber.AutoSize = true;
            this.lblReferenceNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblReferenceNumber.Location = new System.Drawing.Point(20, 140);
            this.lblReferenceNumber.Name = "lblReferenceNumber";
            this.lblReferenceNumber.Size = new System.Drawing.Size(162, 25);
            this.lblReferenceNumber.TabIndex = 0;
            this.lblReferenceNumber.Text = "Reference Number";
            // 
            // grpInvoiceItems
            // 
            this.grpInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInvoiceItems.BackColor = System.Drawing.Color.White;
            this.grpInvoiceItems.Controls.Add(this.lblTotalAmountValue);
            this.grpInvoiceItems.Controls.Add(this.lblTotalAmount);
            this.grpInvoiceItems.Controls.Add(this.btnRemoveItem);
            this.grpInvoiceItems.Controls.Add(this.btnAddItem);
            this.grpInvoiceItems.Controls.Add(this.dgvInvoiceItems);
            this.grpInvoiceItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoiceItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpInvoiceItems.Location = new System.Drawing.Point(20, 130);
            this.grpInvoiceItems.Name = "grpInvoiceItems";
            this.grpInvoiceItems.Size = new System.Drawing.Size(672, 240);
            this.grpInvoiceItems.TabIndex = 1;
            this.grpInvoiceItems.TabStop = false;
            this.grpInvoiceItems.Text = "Invoice Items";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalAmountValue.Location = new System.Drawing.Point(550, 200);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(90, 31);
            this.lblTotalAmountValue.TabIndex = 3;
            this.lblTotalAmountValue.Text = "$ 0.00";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(400, 200);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(124, 25);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(572, 20);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(466, 20);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(100, 30);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(20, 60);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersWidth = 51;
            this.dgvInvoiceItems.RowTemplate.Height = 24;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(632, 130);
            this.dgvInvoiceItems.TabIndex = 2;
            // 
            // grpGuestInformation
            // 
            this.grpGuestInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGuestInformation.BackColor = System.Drawing.Color.White;
            this.grpGuestInformation.Controls.Add(this.txtRoomNumber);
            this.grpGuestInformation.Controls.Add(this.txtGuestName);
            this.grpGuestInformation.Controls.Add(this.lblRoomNumber);
            this.grpGuestInformation.Controls.Add(this.lblGuestName);
            this.grpGuestInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGuestInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpGuestInformation.Location = new System.Drawing.Point(20, 20);
            this.grpGuestInformation.Name = "grpGuestInformation";
            this.grpGuestInformation.Size = new System.Drawing.Size(672, 100);
            this.grpGuestInformation.TabIndex = 0;
            this.grpGuestInformation.TabStop = false;
            this.grpGuestInformation.Text = "Guest Information";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(380, 50);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(270, 30);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(20, 50);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(270, 30);
            this.txtGuestName.TabIndex = 0;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(380, 20);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(133, 25);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGuestName.Location = new System.Drawing.Point(20, 20);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(110, 25);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name";
            // 
            // tabPaymentProcessing
            // 
            this.tabPaymentProcessing.BackColor = System.Drawing.Color.White;
            this.tabPaymentProcessing.Location = new System.Drawing.Point(4, 29);
            this.tabPaymentProcessing.Name = "tabPaymentProcessing";
            this.tabPaymentProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaymentProcessing.Size = new System.Drawing.Size(712, 607);
            this.tabPaymentProcessing.TabIndex = 1;
            this.tabPaymentProcessing.Text = "Payment Processing";
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveInvoice.FlatAppearance.BorderSize = 0;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Location = new System.Drawing.Point(572, 550);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(120, 45);
            this.btnSaveInvoice.TabIndex = 3;
            this.btnSaveInvoice.Text = "Save Invoice";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(446, 550);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tabBillingHistory
            // 
            this.tabBillingHistory.BackColor = System.Drawing.Color.White;
            this.tabBillingHistory.Controls.Add(this.grpBillingHistory);
            this.tabBillingHistory.Location = new System.Drawing.Point(4, 29);
            this.tabBillingHistory.Name = "tabBillingHistory";
            this.tabBillingHistory.Size = new System.Drawing.Size(712, 607);
            this.tabBillingHistory.TabIndex = 2;
            this.tabBillingHistory.Text = "Billing History";
            // 
            // grpBillingHistory
            // 
            this.grpBillingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBillingHistory.BackColor = System.Drawing.Color.White;
            this.grpBillingHistory.Controls.Add(this.btnSearchBilling);
            this.grpBillingHistory.Controls.Add(this.txtSearchBilling);
            this.grpBillingHistory.Controls.Add(this.dgvBillingHistory);
            this.grpBillingHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBillingHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpBillingHistory.Location = new System.Drawing.Point(20, 20);
            this.grpBillingHistory.Name = "grpBillingHistory";
            this.grpBillingHistory.Size = new System.Drawing.Size(672, 567);
            this.grpBillingHistory.TabIndex = 0;
            this.grpBillingHistory.TabStop = false;
            this.grpBillingHistory.Text = "Billing History";
            // 
            // btnSearchBilling
            // 
            this.btnSearchBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearchBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBilling.FlatAppearance.BorderSize = 0;
            this.btnSearchBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBilling.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBilling.ForeColor = System.Drawing.Color.White;
            this.btnSearchBilling.Location = new System.Drawing.Point(542, 40);
            this.btnSearchBilling.Name = "btnSearchBilling";
            this.btnSearchBilling.Size = new System.Drawing.Size(120, 30);
            this.btnSearchBilling.TabIndex = 1;
            this.btnSearchBilling.Text = "Search";
            this.btnSearchBilling.UseVisualStyleBackColor = false;
            // 
            // txtSearchBilling
            // 
            this.txtSearchBilling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBilling.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBilling.Location = new System.Drawing.Point(20, 40);
            this.txtSearchBilling.Name = "txtSearchBilling";
            this.txtSearchBilling.Size = new System.Drawing.Size(516, 30);
            this.txtSearchBilling.TabIndex = 0;
            // 
            // dgvBillingHistory
            // 
            this.dgvBillingHistory.AllowUserToAddRows = false;
            this.dgvBillingHistory.AllowUserToDeleteRows = false;
            this.dgvBillingHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillingHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillingHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillingHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillingHistory.Location = new System.Drawing.Point(20, 90);
            this.dgvBillingHistory.Name = "dgvBillingHistory";
            this.dgvBillingHistory.ReadOnly = true;
            this.dgvBillingHistory.RowHeadersWidth = 51;
            this.dgvBillingHistory.RowTemplate.Height = 24;
            this.dgvBillingHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillingHistory.Size = new System.Drawing.Size(642, 467);
            this.dgvBillingHistory.TabIndex = 2;
            // 
            // frmBilling
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
            this.Name = "frmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Billing Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.tabBilling.ResumeLayout(false);
            this.tabInvoiceDetails.ResumeLayout(false);
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentAmount)).EndInit();
            this.grpInvoiceItems.ResumeLayout(false);
            this.grpInvoiceItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.grpGuestInformation.ResumeLayout(false);
            this.grpGuestInformation.PerformLayout();
            this.tabBillingHistory.ResumeLayout(false);
            this.grpBillingHistory.ResumeLayout(false);
            this.grpBillingHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillingHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBillingTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblBillingActions;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Button btnCreateInvoice;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.TabControl tabBilling;
        private System.Windows.Forms.TabPage tabInvoiceDetails;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.NumericUpDown numPaymentAmount;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblReferenceNumber;
        private System.Windows.Forms.GroupBox grpInvoiceItems;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.GroupBox grpGuestInformation;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TabPage tabPaymentProcessing;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabBillingHistory;
        private System.Windows.Forms.GroupBox grpBillingHistory;
        private System.Windows.Forms.Button btnSearchBilling;
        private System.Windows.Forms.TextBox txtSearchBilling;
        private System.Windows.Forms.DataGridView dgvBillingHistory;
    }
}