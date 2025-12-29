namespace HotelManagement_IT13_Final.Forms.Billing
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblPaymentActions = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnViewReceipt = new System.Windows.Forms.Button();
            this.btnProcessPayment = new System.Windows.Forms.Button();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.btnCancelPayment = new System.Windows.Forms.Button();
            this.grpCashPayment = new System.Windows.Forms.GroupBox();
            this.chkCashPayment = new System.Windows.Forms.CheckBox();
            this.grpCardDetails = new System.Windows.Forms.GroupBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCardHolderName = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.grpPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtTransactionNotes = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.numPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblTransactionNotes = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblReferenceNumber = new System.Windows.Forms.Label();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.grpInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalAmountDueValue = new System.Windows.Forms.Label();
            this.lblGuestNameValue = new System.Windows.Forms.Label();
            this.lblInvoiceNumberValue = new System.Windows.Forms.Label();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbOnlineTransfer = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.grpCashPayment.SuspendLayout();
            this.grpCardDetails.SuspendLayout();
            this.grpPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentAmount)).BeginInit();
            this.grpInvoiceDetails.SuspendLayout();
            this.grpPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblPaymentTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaymentTitle.Location = new System.Drawing.Point(20, 15);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(189, 41);
            this.lblPaymentTitle.TabIndex = 0;
            this.lblPaymentTitle.Text = "Process Payment";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelSidebar.Controls.Add(this.lblPaymentActions);
            this.panelSidebar.Controls.Add(this.btnPrintReceipt);
            this.panelSidebar.Controls.Add(this.btnViewReceipt);
            this.panelSidebar.Controls.Add(this.btnProcessPayment);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 680);
            this.panelSidebar.TabIndex = 1;
            // 
            // lblPaymentActions
            // 
            this.lblPaymentActions.AutoSize = true;
            this.lblPaymentActions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentActions.ForeColor = System.Drawing.Color.White;
            this.lblPaymentActions.Location = new System.Drawing.Point(15, 30);
            this.lblPaymentActions.Name = "lblPaymentActions";
            this.lblPaymentActions.Size = new System.Drawing.Size(154, 28);
            this.lblPaymentActions.TabIndex = 3;
            this.lblPaymentActions.Text = "Payment Actions";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location = new System.Drawing.Point(20, 190);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(200, 45);
            this.btnPrintReceipt.TabIndex = 2;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // btnViewReceipt
            // 
            this.btnViewReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnViewReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewReceipt.FlatAppearance.BorderSize = 0;
            this.btnViewReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReceipt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReceipt.ForeColor = System.Drawing.Color.White;
            this.btnViewReceipt.Location = new System.Drawing.Point(20, 135);
            this.btnViewReceipt.Name = "btnViewReceipt";
            this.btnViewReceipt.Size = new System.Drawing.Size(200, 45);
            this.btnViewReceipt.TabIndex = 1;
            this.btnViewReceipt.Text = "View Receipt";
            this.btnViewReceipt.UseVisualStyleBackColor = false;
            // 
            // btnProcessPayment
            // 
            this.btnProcessPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProcessPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessPayment.FlatAppearance.BorderSize = 0;
            this.btnProcessPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPayment.ForeColor = System.Drawing.Color.White;
            this.btnProcessPayment.Location = new System.Drawing.Point(20, 80);
            this.btnProcessPayment.Name = "btnProcessPayment";
            this.btnProcessPayment.Size = new System.Drawing.Size(200, 45);
            this.btnProcessPayment.TabIndex = 0;
            this.btnProcessPayment.Text = "Process Payment";
            this.btnProcessPayment.UseVisualStyleBackColor = false;
            // 
            // panelMainContent
            // 
            this.panelMainContent.AutoScroll = true;
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelMainContent.Controls.Add(this.btnCancelPayment);
            this.panelMainContent.Controls.Add(this.grpCashPayment);
            this.panelMainContent.Controls.Add(this.grpCardDetails);
            this.panelMainContent.Controls.Add(this.grpPaymentDetails);
            this.panelMainContent.Controls.Add(this.grpInvoiceDetails);
            this.panelMainContent.Controls.Add(this.grpPaymentMethod);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(240, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(20);
            this.panelMainContent.Size = new System.Drawing.Size(760, 680);
            this.panelMainContent.TabIndex = 2;
            // 
            // btnCancelPayment
            // 
            this.btnCancelPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancelPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelPayment.FlatAppearance.BorderSize = 0;
            this.btnCancelPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPayment.ForeColor = System.Drawing.Color.White;
            this.btnCancelPayment.Location = new System.Drawing.Point(620, 620);
            this.btnCancelPayment.Name = "btnCancelPayment";
            this.btnCancelPayment.Size = new System.Drawing.Size(120, 45);
            this.btnCancelPayment.TabIndex = 5;
            this.btnCancelPayment.Text = "Cancel";
            this.btnCancelPayment.UseVisualStyleBackColor = false;
            // 
            // grpCashPayment
            // 
            this.grpCashPayment.BackColor = System.Drawing.Color.White;
            this.grpCashPayment.Controls.Add(this.chkCashPayment);
            this.grpCashPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCashPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpCashPayment.Location = new System.Drawing.Point(20, 450);
            this.grpCashPayment.Name = "grpCashPayment";
            this.grpCashPayment.Size = new System.Drawing.Size(720, 80);
            this.grpCashPayment.TabIndex = 4;
            this.grpCashPayment.TabStop = false;
            this.grpCashPayment.Text = "Cash Payment Confirmation";
            // 
            // chkCashPayment
            // 
            this.chkCashPayment.AutoSize = true;
            this.chkCashPayment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCashPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.chkCashPayment.Location = new System.Drawing.Point(30, 35);
            this.chkCashPayment.Name = "chkCashPayment";
            this.chkCashPayment.Size = new System.Drawing.Size(272, 27);
            this.chkCashPayment.TabIndex = 0;
            this.chkCashPayment.Text = "I confirm receiving cash payment";
            this.chkCashPayment.UseVisualStyleBackColor = true;
            // 
            // grpCardDetails
            // 
            this.grpCardDetails.BackColor = System.Drawing.Color.White;
            this.grpCardDetails.Controls.Add(this.txtCVV);
            this.grpCardDetails.Controls.Add(this.txtExpiryDate);
            this.grpCardDetails.Controls.Add(this.txtCardHolderName);
            this.grpCardDetails.Controls.Add(this.txtCardNumber);
            this.grpCardDetails.Controls.Add(this.lblCVV);
            this.grpCardDetails.Controls.Add(this.lblExpiryDate);
            this.grpCardDetails.Controls.Add(this.lblCardHolderName);
            this.grpCardDetails.Controls.Add(this.lblCardNumber);
            this.grpCardDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCardDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpCardDetails.Location = new System.Drawing.Point(20, 540);
            this.grpCardDetails.Name = "grpCardDetails";
            this.grpCardDetails.Size = new System.Drawing.Size(720, 180);
            this.grpCardDetails.TabIndex = 3;
            this.grpCardDetails.TabStop = false;
            this.grpCardDetails.Text = "Credit Card Details";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVV.Location = new System.Drawing.Point(480, 130);
            this.txtCVV.MaxLength = 4;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '*';
            this.txtCVV.Size = new System.Drawing.Size(200, 30);
            this.txtCVV.TabIndex = 3;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiryDate.Location = new System.Drawing.Point(480, 80);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(200, 30);
            this.txtExpiryDate.TabIndex = 2;
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardHolderName.Location = new System.Drawing.Point(150, 130);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(300, 30);
            this.txtCardHolderName.TabIndex = 1;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(150, 80);
            this.txtCardNumber.MaxLength = 19;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(300, 30);
            this.txtCardNumber.TabIndex = 0;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCVV.Location = new System.Drawing.Point(480, 100);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(45, 25);
            this.lblCVV.TabIndex = 0;
            this.lblCVV.Text = "CVV";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblExpiryDate.Location = new System.Drawing.Point(480, 50);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(100, 25);
            this.lblExpiryDate.TabIndex = 0;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblCardHolderName
            // 
            this.lblCardHolderName.AutoSize = true;
            this.lblCardHolderName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardHolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCardHolderName.Location = new System.Drawing.Point(30, 100);
            this.lblCardHolderName.Name = "lblCardHolderName";
            this.lblCardHolderName.Size = new System.Drawing.Size(164, 25);
            this.lblCardHolderName.TabIndex = 0;
            this.lblCardHolderName.Text = "Cardholder Name";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblCardNumber.Location = new System.Drawing.Point(30, 50);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(119, 25);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // grpPaymentDetails
            // 
            this.grpPaymentDetails.BackColor = System.Drawing.Color.White;
            this.grpPaymentDetails.Controls.Add(this.txtTransactionNotes);
            this.grpPaymentDetails.Controls.Add(this.dtpPaymentDate);
            this.grpPaymentDetails.Controls.Add(this.txtReferenceNumber);
            this.grpPaymentDetails.Controls.Add(this.numPaymentAmount);
            this.grpPaymentDetails.Controls.Add(this.cboPaymentMethod);
            this.grpPaymentDetails.Controls.Add(this.lblTransactionNotes);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentDate);
            this.grpPaymentDetails.Controls.Add(this.lblReferenceNumber);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentAmount);
            this.grpPaymentDetails.Controls.Add(this.lblPaymentMethod);
            this.grpPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpPaymentDetails.Location = new System.Drawing.Point(20, 240);
            this.grpPaymentDetails.Name = "grpPaymentDetails";
            this.grpPaymentDetails.Size = new System.Drawing.Size(720, 200);
            this.grpPaymentDetails.TabIndex = 2;
            this.grpPaymentDetails.TabStop = false;
            this.grpPaymentDetails.Text = "Payment Details";
            // 
            // txtTransactionNotes
            // 
            this.txtTransactionNotes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionNotes.Location = new System.Drawing.Point(200, 150);
            this.txtTransactionNotes.Multiline = true;
            this.txtTransactionNotes.Name = "txtTransactionNotes";
            this.txtTransactionNotes.Size = new System.Drawing.Size(500, 40);
            this.txtTransactionNotes.TabIndex = 4;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPaymentDate.Location = new System.Drawing.Point(200, 110);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(500, 30);
            this.dtpPaymentDate.TabIndex = 3;
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenceNumber.Location = new System.Drawing.Point(200, 70);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(500, 30);
            this.txtReferenceNumber.TabIndex = 2;
            // 
            // numPaymentAmount
            // 
            this.numPaymentAmount.DecimalPlaces = 2;
            this.numPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPaymentAmount.Location = new System.Drawing.Point(200, 30);
            this.numPaymentAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPaymentAmount.Name = "numPaymentAmount";
            this.numPaymentAmount.Size = new System.Drawing.Size(500, 30);
            this.numPaymentAmount.TabIndex = 0;
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
            this.cboPaymentMethod.Location = new System.Drawing.Point(200, 30);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(500, 31);
            this.cboPaymentMethod.TabIndex = 1;
            // 
            // lblTransactionNotes
            // 
            this.lblTransactionNotes.AutoSize = true;
            this.lblTransactionNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTransactionNotes.Location = new System.Drawing.Point(30, 150);
            this.lblTransactionNotes.Name = "lblTransactionNotes";
            this.lblTransactionNotes.Size = new System.Drawing.Size(156, 25);
            this.lblTransactionNotes.TabIndex = 0;
            this.lblTransactionNotes.Text = "Transaction Notes";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPaymentDate.Location = new System.Drawing.Point(30, 110);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(122, 25);
            this.lblPaymentDate.TabIndex = 0;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblReferenceNumber
            // 
            this.lblReferenceNumber.AutoSize = true;
            this.lblReferenceNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferenceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblReferenceNumber.Location = new System.Drawing.Point(30, 70);
            this.lblReferenceNumber.Name = "lblReferenceNumber";
            this.lblReferenceNumber.Size = new System.Drawing.Size(162, 25);
            this.lblReferenceNumber.TabIndex = 0;
            this.lblReferenceNumber.Text = "Reference Number";
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPaymentAmount.Location = new System.Drawing.Point(30, 30);
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
            this.lblPaymentMethod.Location = new System.Drawing.Point(30, 30);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(146, 25);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // grpInvoiceDetails
            // 
            this.grpInvoiceDetails.BackColor = System.Drawing.Color.White;
            this.grpInvoiceDetails.Controls.Add(this.lblTotalAmountDueValue);
            this.grpInvoiceDetails.Controls.Add(this.lblGuestNameValue);
            this.grpInvoiceDetails.Controls.Add(this.lblInvoiceNumberValue);
            this.grpInvoiceDetails.Controls.Add(this.lblTotalAmountDue);
            this.grpInvoiceDetails.Controls.Add(this.lblGuestName);
            this.grpInvoiceDetails.Controls.Add(this.lblInvoiceNumber);
            this.grpInvoiceDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoiceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpInvoiceDetails.Location = new System.Drawing.Point(20, 20);
            this.grpInvoiceDetails.Name = "grpInvoiceDetails";
            this.grpInvoiceDetails.Size = new System.Drawing.Size(720, 100);
            this.grpInvoiceDetails.TabIndex = 1;
            this.grpInvoiceDetails.TabStop = false;
            this.grpInvoiceDetails.Text = "Invoice Details";
            // 
            // lblTotalAmountDueValue
            // 
            this.lblTotalAmountDueValue.AutoSize = true;
            this.lblTotalAmountDueValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTotalAmountDueValue.Location = new System.Drawing.Point(550, 50);
            this.lblTotalAmountDueValue.Name = "lblTotalAmountDueValue";
            this.lblTotalAmountDueValue.Size = new System.Drawing.Size(90, 31);
            this.lblTotalAmountDueValue.TabIndex = 2;
            this.lblTotalAmountDueValue.Text = "$ 0.00";
            // 
            // lblGuestNameValue
            // 
            this.lblGuestNameValue.AutoSize = true;
            this.lblGuestNameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGuestNameValue.Location = new System.Drawing.Point(200, 60);
            this.lblGuestNameValue.Name = "lblGuestNameValue";
            this.lblGuestNameValue.Size = new System.Drawing.Size(90, 23);
            this.lblGuestNameValue.TabIndex = 1;
            this.lblGuestNameValue.Text = "John Doe";
            // 
            // lblInvoiceNumberValue
            // 
            this.lblInvoiceNumberValue.AutoSize = true;
            this.lblInvoiceNumberValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblInvoiceNumberValue.Location = new System.Drawing.Point(200, 30);
            this.lblInvoiceNumberValue.Name = "lblInvoiceNumberValue";
            this.lblInvoiceNumberValue.Size = new System.Drawing.Size(110, 23);
            this.lblInvoiceNumberValue.TabIndex = 0;
            this.lblInvoiceNumberValue.Text = "INV-2024-001";
            // 
            // lblTotalAmountDue
            // 
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotalAmountDue.Location = new System.Drawing.Point(400, 50);
            this.lblTotalAmountDue.Name = "lblTotalAmountDue";
            this.lblTotalAmountDue.Size = new System.Drawing.Size(134, 25);
            this.lblTotalAmountDue.TabIndex = 0;
            this.lblTotalAmountDue.Text = "Amount Due:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblGuestName.Location = new System.Drawing.Point(30, 60);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(110, 25);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblInvoiceNumber.Location = new System.Drawing.Point(30, 30);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(139, 25);
            this.lblInvoiceNumber.TabIndex = 0;
            this.lblInvoiceNumber.Text = "Invoice Number";
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.BackColor = System.Drawing.Color.White;
            this.grpPaymentMethod.Controls.Add(this.rbOnlineTransfer);
            this.grpPaymentMethod.Controls.Add(this.rbCash);
            this.grpPaymentMethod.Controls.Add(this.rbCreditCard);
            this.grpPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpPaymentMethod.Location = new System.Drawing.Point(20, 130);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(720, 100);
            this.grpPaymentMethod.TabIndex = 0;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "Select Payment Method";
            // 
            // rbOnlineTransfer
            // 
            this.rbOnlineTransfer.AutoSize = true;
            this.rbOnlineTransfer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnlineTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.rbOnlineTransfer.Location = new System.Drawing.Point(500, 40);
            this.rbOnlineTransfer.Name = "rbOnlineTransfer";
            this.rbOnlineTransfer.Size = new System.Drawing.Size(147, 27);
            this.rbOnlineTransfer.TabIndex = 2;
            this.rbOnlineTransfer.TabStop = true;
            this.rbOnlineTransfer.Text = "Online Transfer";
            this.rbOnlineTransfer.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.rbCash.Location = new System.Drawing.Point(250, 40);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(67, 27);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCreditCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.rbCreditCard.Location = new System.Drawing.Point(30, 40);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(114, 27);
            this.rbCreditCard.TabIndex = 0;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // frmPayment
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
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System - Process Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.grpCashPayment.ResumeLayout(false);
            this.grpCashPayment.PerformLayout();
            this.grpCardDetails.ResumeLayout(false);
            this.grpCardDetails.PerformLayout();
            this.grpPaymentDetails.ResumeLayout(false);
            this.grpPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaymentAmount)).EndInit();
            this.grpInvoiceDetails.ResumeLayout(false);
            this.grpInvoiceDetails.PerformLayout();
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblPaymentActions;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnViewReceipt;
        private System.Windows.Forms.Button btnProcessPayment;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.RadioButton rbOnlineTransfer;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.GroupBox grpInvoiceDetails;
        private System.Windows.Forms.Label lblTotalAmountDueValue;
        private System.Windows.Forms.Label lblGuestNameValue;
        private System.Windows.Forms.Label lblInvoiceNumberValue;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.GroupBox grpPaymentDetails;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.NumericUpDown numPaymentAmount;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblReferenceNumber;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.GroupBox grpCardDetails;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblCardHolderName;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.GroupBox grpCashPayment;
        private System.Windows.Forms.CheckBox chkCashPayment;
        private System.Windows.Forms.Button btnCancelPayment;
        private System.Windows.Forms.TextBox txtTransactionNotes;
        private System.Windows.Forms.Label lblTransactionNotes;
    }
}