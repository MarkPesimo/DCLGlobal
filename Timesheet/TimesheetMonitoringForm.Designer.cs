namespace DCLGlobal.Timesheet
{
    partial class TimesheetMonitoringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimesheetMonitoringForm));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.company_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmsHeader = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PostTimesheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UnpostTimesheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelTimesheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filter_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtcompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lsvHds = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.cmsHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.refresh_btn);
            this.panel2.Controls.Add(this.new_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 32);
            this.panel2.TabIndex = 876;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(196, 4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(138, 25);
            this.refresh_btn.TabIndex = 876;
            this.refresh_btn.Text = "       F5 - Refresh";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.new_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.new_btn.FlatAppearance.BorderSize = 0;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.ForeColor = System.Drawing.Color.White;
            this.new_btn.Image = ((System.Drawing.Image)(resources.GetObject("new_btn.Image")));
            this.new_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_btn.Location = new System.Drawing.Point(337, 4);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(145, 25);
            this.new_btn.TabIndex = 874;
            this.new_btn.Text = "      F1 - New Timesheet";
            this.new_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "User Created";
            this.columnHeader7.Width = 80;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(839, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 22);
            this.close_btn.TabIndex = 875;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 22);
            this.label1.TabIndex = 874;
            this.label1.Text = "      Timesheet Monitoring";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // company_btn
            // 
            this.company_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.company_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.company_btn.Enabled = false;
            this.company_btn.FlatAppearance.BorderSize = 0;
            this.company_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company_btn.ForeColor = System.Drawing.Color.White;
            this.company_btn.Image = ((System.Drawing.Image)(resources.GetObject("company_btn.Image")));
            this.company_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.company_btn.Location = new System.Drawing.Point(485, 27);
            this.company_btn.Name = "company_btn";
            this.company_btn.Size = new System.Drawing.Size(115, 21);
            this.company_btn.TabIndex = 872;
            this.company_btn.Text = "Search Company";
            this.company_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.company_btn.UseVisualStyleBackColor = false;
            this.company_btn.Click += new System.EventHandler(this.company_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 586);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(867, 22);
            this.panel4.TabIndex = 854;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(5, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(444, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "      Double click record to open";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmsHeader
            // 
            this.cmsHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PostTimesheetMenu,
            this.UnpostTimesheetMenu,
            this.CancelTimesheetMenu});
            this.cmsHeader.Name = "cntxMnu";
            this.cmsHeader.Size = new System.Drawing.Size(176, 70);
            // 
            // PostTimesheetMenu
            // 
            this.PostTimesheetMenu.Image = ((System.Drawing.Image)(resources.GetObject("PostTimesheetMenu.Image")));
            this.PostTimesheetMenu.Name = "PostTimesheetMenu";
            this.PostTimesheetMenu.Size = new System.Drawing.Size(175, 22);
            this.PostTimesheetMenu.Text = "Post Timesheet";
            this.PostTimesheetMenu.Click += new System.EventHandler(this.PostTimesheetMenu_Click);
            // 
            // UnpostTimesheetMenu
            // 
            this.UnpostTimesheetMenu.Image = ((System.Drawing.Image)(resources.GetObject("UnpostTimesheetMenu.Image")));
            this.UnpostTimesheetMenu.Name = "UnpostTimesheetMenu";
            this.UnpostTimesheetMenu.Size = new System.Drawing.Size(175, 22);
            this.UnpostTimesheetMenu.Text = "Unpost Timesheet";
            this.UnpostTimesheetMenu.Click += new System.EventHandler(this.UnpostTimesheetMenu_Click);
            // 
            // CancelTimesheetMenu
            // 
            this.CancelTimesheetMenu.Image = ((System.Drawing.Image)(resources.GetObject("CancelTimesheetMenu.Image")));
            this.CancelTimesheetMenu.Name = "CancelTimesheetMenu";
            this.CancelTimesheetMenu.Size = new System.Drawing.Size(175, 22);
            this.CancelTimesheetMenu.Text = "Cancel Timesheet";
            this.CancelTimesheetMenu.Click += new System.EventHandler(this.CancelTimesheetMenu_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.filter_btn.FlatAppearance.BorderSize = 0;
            this.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_btn.ForeColor = System.Drawing.Color.White;
            this.filter_btn.Image = ((System.Drawing.Image)(resources.GetObject("filter_btn.Image")));
            this.filter_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filter_btn.Location = new System.Drawing.Point(485, 72);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(115, 22);
            this.filter_btn.TabIndex = 873;
            this.filter_btn.Text = "      Filter";
            this.filter_btn.UseVisualStyleBackColor = false;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chkCompany);
            this.panel1.Controls.Add(this.minimize_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.filter_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.company_btn);
            this.panel1.Controls.Add(this.cboMonth);
            this.panel1.Controls.Add(this.chkStatus);
            this.panel1.Controls.Add(this.txtcompany);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 132);
            this.panel1.TabIndex = 853;
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.ForeColor = System.Drawing.Color.Black;
            this.chkCompany.Location = new System.Drawing.Point(40, 30);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(78, 17);
            this.chkCompany.TabIndex = 879;
            this.chkCompany.Text = " Company:";
            this.chkCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCompany.UseVisualStyleBackColor = true;
            this.chkCompany.CheckedChanged += new System.EventHandler(this.chkCompany_CheckedChanged);
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(812, -1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(24, 23);
            this.minimize_btn.TabIndex = 878;
            this.minimize_btn.UseVisualStyleBackColor = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(124, 49);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(159, 21);
            this.cboMonth.TabIndex = 857;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus.Location = new System.Drawing.Point(40, 74);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(79, 17);
            this.chkStatus.TabIndex = 856;
            this.chkStatus.Text = "By Status :";
            this.chkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.UseVisualStyleBackColor = false;
            // 
            // txtcompany
            // 
            this.txtcompany.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcompany.Border.Class = "TextBoxBorder";
            this.txtcompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcompany.FocusHighlightEnabled = true;
            this.txtcompany.ForeColor = System.Drawing.Color.Black;
            this.txtcompany.Location = new System.Drawing.Point(124, 27);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.ReadOnly = true;
            this.txtcompany.Size = new System.Drawing.Size(358, 21);
            this.txtcompany.TabIndex = 817;
            this.txtcompany.Tag = "0";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Unposted",
            "Posted"});
            this.cboStatus.Location = new System.Drawing.Point(124, 71);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(86, 21);
            this.cboStatus.TabIndex = 853;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(72, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 850;
            this.label8.Text = "Month :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(353, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 852;
            this.label7.Text = "Year :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(396, 49);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(86, 21);
            this.cboYear.TabIndex = 851;
            // 
            // lsvHds
            // 
            this.lsvHds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvHds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvHds.FullRowSelect = true;
            this.lsvHds.GridLines = true;
            this.lsvHds.Location = new System.Drawing.Point(0, 132);
            this.lsvHds.Name = "lsvHds";
            this.lsvHds.Size = new System.Drawing.Size(867, 454);
            this.lsvHds.TabIndex = 852;
            this.lsvHds.UseCompatibleStateImageBehavior = false;
            this.lsvHds.View = System.Windows.Forms.View.Details;
            this.lsvHds.SelectedIndexChanged += new System.EventHandler(this.lsvHds_SelectedIndexChanged);
            this.lsvHds.DoubleClick += new System.EventHandler(this.lsvHds_DoubleClick);
            this.lsvHds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsvHds_MouseDown);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Company";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Title";
            this.columnHeader9.Width = 270;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "No. of Employee";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cut off from";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cut off to";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 85;
            // 
            // TimesheetMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 608);
            this.Controls.Add(this.lsvHds);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TimesheetMonitoringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheet Monitoring";
            this.Load += new System.EventHandler(this.TimesheetMonitoringForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimesheetMonitoringForm_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.cmsHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button company_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ContextMenuStrip cmsHeader;
        private System.Windows.Forms.ToolStripMenuItem PostTimesheetMenu;
        private System.Windows.Forms.ToolStripMenuItem UnpostTimesheetMenu;
        private System.Windows.Forms.ToolStripMenuItem CancelTimesheetMenu;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.CheckBox chkStatus;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtcompany;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboYear;
        internal System.Windows.Forms.ListView lsvHds;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}