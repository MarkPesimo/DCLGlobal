namespace DCLGlobal.Inquiry
{
    partial class LoanMonitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanMonitoring));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cntxMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuViewEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGenerateLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActivateLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeactivateLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.addLoanPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLoan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.close_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.cboSatus = new System.Windows.Forms.ComboBox();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.cboLoanType = new System.Windows.Forms.ComboBox();
            this.chkLoanType = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkLoandate = new System.Windows.Forms.CheckBox();
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filter_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewLoanPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxMnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntxMnu
            // 
            this.cntxMnu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntxMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewEmployee,
            this.toolStripSeparator2,
            this.mnuNewLoan,
            this.toolStripSeparator1,
            this.mnuGenerateLedger,
            this.mnuActivateLoan,
            this.mnuDeactivateLoan,
            this.addLoanPaymentToolStripMenuItem,
            this.viewLoanPaymentToolStripMenuItem});
            this.cntxMnu.Name = "cntxMnu";
            this.cntxMnu.Size = new System.Drawing.Size(198, 192);
            // 
            // mnuViewEmployee
            // 
            this.mnuViewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("mnuViewEmployee.Image")));
            this.mnuViewEmployee.Name = "mnuViewEmployee";
            this.mnuViewEmployee.Size = new System.Drawing.Size(197, 22);
            this.mnuViewEmployee.Text = "View Employee Profile";
            this.mnuViewEmployee.Click += new System.EventHandler(this.mnuViewEmployee_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuNewLoan
            // 
            this.mnuNewLoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuNewLoan.Image")));
            this.mnuNewLoan.Name = "mnuNewLoan";
            this.mnuNewLoan.Size = new System.Drawing.Size(197, 22);
            this.mnuNewLoan.Text = "New Loan";
            this.mnuNewLoan.Click += new System.EventHandler(this.mnuNewLoan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuGenerateLedger
            // 
            this.mnuGenerateLedger.Image = ((System.Drawing.Image)(resources.GetObject("mnuGenerateLedger.Image")));
            this.mnuGenerateLedger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuGenerateLedger.Name = "mnuGenerateLedger";
            this.mnuGenerateLedger.Size = new System.Drawing.Size(197, 22);
            this.mnuGenerateLedger.Text = "Generate Loan Ledger";
            this.mnuGenerateLedger.Click += new System.EventHandler(this.mnuGenerateLedger_Click);
            // 
            // mnuActivateLoan
            // 
            this.mnuActivateLoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuActivateLoan.Image")));
            this.mnuActivateLoan.Name = "mnuActivateLoan";
            this.mnuActivateLoan.Size = new System.Drawing.Size(197, 22);
            this.mnuActivateLoan.Text = "Activate Loan";
            this.mnuActivateLoan.Click += new System.EventHandler(this.mnuActivateLoan_Click);
            // 
            // mnuDeactivateLoan
            // 
            this.mnuDeactivateLoan.Image = ((System.Drawing.Image)(resources.GetObject("mnuDeactivateLoan.Image")));
            this.mnuDeactivateLoan.Name = "mnuDeactivateLoan";
            this.mnuDeactivateLoan.Size = new System.Drawing.Size(197, 22);
            this.mnuDeactivateLoan.Text = "Deactivate Loan";
            this.mnuDeactivateLoan.Click += new System.EventHandler(this.mnuDeactivateLoan_Click);
            // 
            // addLoanPaymentToolStripMenuItem
            // 
            this.addLoanPaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addLoanPaymentToolStripMenuItem.Image")));
            this.addLoanPaymentToolStripMenuItem.Name = "addLoanPaymentToolStripMenuItem";
            this.addLoanPaymentToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addLoanPaymentToolStripMenuItem.Text = "Add Loan Payment";
            this.addLoanPaymentToolStripMenuItem.Click += new System.EventHandler(this.addLoanPaymentToolStripMenuItem_Click);
            // 
            // dgvLoan
            // 
            this.dgvLoan.AllowUserToAddRows = false;
            this.dgvLoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvLoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column12,
            this.Column13,
            this.Column4,
            this.Column9,
            this.Column10,
            this.Column18,
            this.Column5});
            this.dgvLoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoan.Location = new System.Drawing.Point(0, 119);
            this.dgvLoan.Name = "dgvLoan";
            this.dgvLoan.ReadOnly = true;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvLoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvLoan.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoan.Size = new System.Drawing.Size(971, 336);
            this.dgvLoan.TabIndex = 887;
            this.dgvLoan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvLoan_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 18);
            this.panel3.TabIndex = 888;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.chkStatus);
            this.panel1.Controls.Add(this.cboSatus);
            this.panel1.Controls.Add(this.prb);
            this.panel1.Controls.Add(this.cboLoanType);
            this.panel1.Controls.Add(this.chkLoanType);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.chkLoandate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 86);
            this.panel1.TabIndex = 885;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(227, 53);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(104, 21);
            this.dtpTo.TabIndex = 900;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(121, 53);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(104, 21);
            this.dtpFrom.TabIndex = 899;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(943, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 22);
            this.close_btn.TabIndex = 881;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(913, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(28, 22);
            this.minimize_btn.TabIndex = 880;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(971, 22);
            this.label8.TabIndex = 898;
            this.label8.Text = "      Loan Monitoring";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus.ForeColor = System.Drawing.Color.Black;
            this.chkStatus.Location = new System.Drawing.Point(580, 30);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(79, 17);
            this.chkStatus.TabIndex = 897;
            this.chkStatus.Text = "By Status :";
            this.chkStatus.UseVisualStyleBackColor = false;
            // 
            // cboSatus
            // 
            this.cboSatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSatus.FormattingEnabled = true;
            this.cboSatus.Items.AddRange(new object[] {
            "Active",
            "In-Active",
            "Closed"});
            this.cboSatus.Location = new System.Drawing.Point(665, 28);
            this.cboSatus.Name = "cboSatus";
            this.cboSatus.Size = new System.Drawing.Size(133, 21);
            this.cboSatus.TabIndex = 896;
            this.cboSatus.SelectedIndexChanged += new System.EventHandler(this.cboSatus_SelectedIndexChanged);
            // 
            // prb
            // 
            this.prb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prb.Location = new System.Drawing.Point(0, 78);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(971, 8);
            this.prb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb.TabIndex = 887;
            // 
            // cboLoanType
            // 
            this.cboLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanType.FormattingEnabled = true;
            this.cboLoanType.Items.AddRange(new object[] {
            "Remittance",
            "Loan"});
            this.cboLoanType.Location = new System.Drawing.Point(121, 28);
            this.cboLoanType.Name = "cboLoanType";
            this.cboLoanType.Size = new System.Drawing.Size(210, 21);
            this.cboLoanType.TabIndex = 884;
            this.cboLoanType.SelectedIndexChanged += new System.EventHandler(this.cboLoanType_SelectedIndexChanged);
            // 
            // chkLoanType
            // 
            this.chkLoanType.AutoSize = true;
            this.chkLoanType.BackColor = System.Drawing.Color.Transparent;
            this.chkLoanType.ForeColor = System.Drawing.Color.Black;
            this.chkLoanType.Location = new System.Drawing.Point(10, 31);
            this.chkLoanType.Name = "chkLoanType";
            this.chkLoanType.Size = new System.Drawing.Size(98, 17);
            this.chkLoanType.TabIndex = 883;
            this.chkLoanType.Text = "By Loan Type :";
            this.chkLoanType.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1166, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 22);
            this.button1.TabIndex = 876;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1196, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 864;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // chkLoandate
            // 
            this.chkLoandate.AutoSize = true;
            this.chkLoandate.BackColor = System.Drawing.Color.Transparent;
            this.chkLoandate.ForeColor = System.Drawing.Color.Black;
            this.chkLoandate.Location = new System.Drawing.Point(12, 56);
            this.chkLoandate.Name = "chkLoandate";
            this.chkLoandate.Size = new System.Drawing.Size(96, 17);
            this.chkLoandate.TabIndex = 3;
            this.chkLoandate.Text = "By Loan date :";
            this.chkLoandate.UseVisualStyleBackColor = false;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKeyword.Border.Class = "TextBoxBorder";
            this.txtKeyword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKeyword.FocusHighlightEnabled = true;
            this.txtKeyword.ForeColor = System.Drawing.Color.Black;
            this.txtKeyword.Location = new System.Drawing.Point(121, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(257, 21);
            this.txtKeyword.TabIndex = 8;
            this.txtKeyword.Tag = "0";
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // filter_btn
            // 
            this.filter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.filter_btn.FlatAppearance.BorderSize = 0;
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.ForeColor = System.Drawing.Color.White;
            this.filter_btn.Image = ((System.Drawing.Image)(resources.GetObject("filter_btn.Image")));
            this.filter_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filter_btn.Location = new System.Drawing.Point(384, 6);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(99, 21);
            this.filter_btn.TabIndex = 9;
            this.filter_btn.Text = "Filter Records";
            this.filter_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filter_btn.UseVisualStyleBackColor = false;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(48, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 875;
            this.label14.Text = "Keyword :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.txtKeyword);
            this.panel2.Controls.Add(this.filter_btn);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 33);
            this.panel2.TabIndex = 886;
            // 
            // Column2
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column2.HeaderText = "Loan id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 60;
            // 
            // Column1
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column1.HeaderText = "Loan Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "d";
            dataGridViewCellStyle18.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column3.HeaderText = "Date Loan";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column12
            // 
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle19;
            this.Column12.HeaderText = "Company Name";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 120;
            // 
            // Column13
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle20;
            this.Column13.HeaderText = "Employee Name";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 200;
            // 
            // Column4
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = "0";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column4.HeaderText = "Loan Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column9
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            dataGridViewCellStyle22.NullValue = "0";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column9.HeaderText = "Balance";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.NullValue = "-";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle23;
            this.Column10.HeaderText = "Status";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // Column18
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column18.DefaultCellStyle = dataGridViewCellStyle24;
            this.Column18.HeaderText = "Created by";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Loantype_id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // viewLoanPaymentToolStripMenuItem
            // 
            this.viewLoanPaymentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewLoanPaymentToolStripMenuItem.Image")));
            this.viewLoanPaymentToolStripMenuItem.Name = "viewLoanPaymentToolStripMenuItem";
            this.viewLoanPaymentToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewLoanPaymentToolStripMenuItem.Text = "View Loan Payment";
            this.viewLoanPaymentToolStripMenuItem.Click += new System.EventHandler(this.viewLoanPaymentToolStripMenuItem_Click);
            // 
            // LoanMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 473);
            this.Controls.Add(this.dgvLoan);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoanMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Monitoring";
            this.cntxMnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.ContextMenuStrip cntxMnu;
        private System.Windows.Forms.ToolStripMenuItem mnuViewEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem mnuGenerateLedger;
        private System.Windows.Forms.ToolStripMenuItem mnuActivateLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDeactivateLoan;
        internal System.Windows.Forms.DataGridView dgvLoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ComboBox cboSatus;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.CheckBox chkLoanType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkLoandate;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboLoanType;
        private System.Windows.Forms.ToolStripMenuItem mnuNewLoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addLoanPaymentToolStripMenuItem;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem viewLoanPaymentToolStripMenuItem;
    }
}