namespace DCLGlobal.Timesheet
{
    partial class TimesheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimesheetForm));
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.chkClient = new System.Windows.Forms.CheckBox();
            this.filter_btn = new DevComponents.DotNetBar.ButtonX();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lsvAttendance = new System.Windows.Forms.ListView();
            this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.lsvEmployee = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reprocessemployeetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddemptoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txttitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtclient_search = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.filterclient_btn = new DevComponents.DotNetBar.ButtonX();
            this.company_btn = new System.Windows.Forms.Button();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.dtpcutoffto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpovertimeto = new System.Windows.Forms.DateTimePicker();
            this.dtpcutofffrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpovertimefrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.delete_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.panFilter = new DevComponents.DotNetBar.ExpandablePanel();
            this.lsvHds = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboTimesheetType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.cmsEmployee.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.panFilter.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.cboMonth.Location = new System.Drawing.Point(111, 71);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(159, 21);
            this.cboMonth.TabIndex = 857;
            // 
            // chkClient
            // 
            this.chkClient.AutoSize = true;
            this.chkClient.BackColor = System.Drawing.Color.Transparent;
            this.chkClient.Location = new System.Drawing.Point(9, 30);
            this.chkClient.Name = "chkClient";
            this.chkClient.Size = new System.Drawing.Size(99, 17);
            this.chkClient.TabIndex = 855;
            this.chkClient.Text = "   Client Name :";
            this.chkClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClient.UseVisualStyleBackColor = false;
            // 
            // filter_btn
            // 
            this.filter_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filter_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.filter_btn.Image = ((System.Drawing.Image)(resources.GetObject("filter_btn.Image")));
            this.filter_btn.Location = new System.Drawing.Point(203, 111);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(67, 26);
            this.filter_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.filter_btn.TabIndex = 854;
            this.filter_btn.Text = "Filter";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Unposted",
            "Posted"});
            this.cboStatus.Location = new System.Drawing.Point(111, 115);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(86, 21);
            this.cboStatus.TabIndex = 853;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(68, 97);
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
            this.cboYear.Location = new System.Drawing.Point(111, 93);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(86, 21);
            this.cboYear.TabIndex = 851;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(61, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 850;
            this.label8.Text = "Month :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSelected);
            this.panel1.Controls.Add(this.lsvAttendance);
            this.panel1.Controls.Add(this.expandablePanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 410);
            this.panel1.TabIndex = 838;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSelected.Location = new System.Drawing.Point(243, 6);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(35, 13);
            this.lblSelected.TabIndex = 837;
            this.lblSelected.Text = "____";
            // 
            // lsvAttendance
            // 
            this.lsvAttendance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader18,
            this.ColumnHeader19,
            this.ColumnHeader20,
            this.ColumnHeader21,
            this.ColumnHeader22,
            this.ColumnHeader23,
            this.ColumnHeader24,
            this.ColumnHeader25,
            this.ColumnHeader26,
            this.ColumnHeader27,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvAttendance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvAttendance.FullRowSelect = true;
            this.lsvAttendance.GridLines = true;
            this.lsvAttendance.Location = new System.Drawing.Point(241, 26);
            this.lsvAttendance.Name = "lsvAttendance";
            this.lsvAttendance.Size = new System.Drawing.Size(859, 384);
            this.lsvAttendance.TabIndex = 836;
            this.lsvAttendance.UseCompatibleStateImageBehavior = false;
            this.lsvAttendance.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader18
            // 
            this.ColumnHeader18.Width = 0;
            // 
            // ColumnHeader19
            // 
            this.ColumnHeader19.Text = "Date Log";
            this.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader19.Width = 90;
            // 
            // ColumnHeader20
            // 
            this.ColumnHeader20.Text = "Time In";
            this.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader20.Width = 90;
            // 
            // ColumnHeader21
            // 
            this.ColumnHeader21.Text = "Time Out";
            this.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader21.Width = 90;
            // 
            // ColumnHeader22
            // 
            this.ColumnHeader22.Text = "Work Hrs.";
            this.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader22.Width = 80;
            // 
            // ColumnHeader23
            // 
            this.ColumnHeader23.Text = "Late Mins.";
            this.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader23.Width = 80;
            // 
            // ColumnHeader24
            // 
            this.ColumnHeader24.Text = "Und. Mins.";
            this.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader24.Width = 80;
            // 
            // ColumnHeader25
            // 
            this.ColumnHeader25.Text = "Absent";
            this.ColumnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader25.Width = 0;
            // 
            // ColumnHeader26
            // 
            this.ColumnHeader26.Text = "SL";
            this.ColumnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ColumnHeader27
            // 
            this.ColumnHeader27.Text = "VL";
            this.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Other Leave";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Emergency Leave";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Paternity Leave";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Maternity Leave";
            this.columnHeader11.Width = 90;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.expandablePanel1.Controls.Add(this.lsvEmployee);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.ExpandOnTitleClick = true;
            this.expandablePanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(241, 410);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 835;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Employee List";
            // 
            // lsvEmployee
            // 
            this.lsvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1});
            this.lsvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployee.FullRowSelect = true;
            this.lsvEmployee.GridLines = true;
            this.lsvEmployee.Location = new System.Drawing.Point(0, 26);
            this.lsvEmployee.Name = "lsvEmployee";
            this.lsvEmployee.Size = new System.Drawing.Size(241, 384);
            this.lsvEmployee.TabIndex = 4;
            this.lsvEmployee.UseCompatibleStateImageBehavior = false;
            this.lsvEmployee.View = System.Windows.Forms.View.Details;
            this.lsvEmployee.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvEmployee_ItemSelectionChanged);
            this.lsvEmployee.SelectedIndexChanged += new System.EventHandler(this.lsvEmployee_SelectedIndexChanged);
            this.lsvEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsvEmployee_MouseDown);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "empid";
            this.columnHeader3.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee Name";
            this.columnHeader1.Width = 257;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.BackColor = System.Drawing.Color.Transparent;
            this.chkStatus.Location = new System.Drawing.Point(8, 118);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(79, 17);
            this.chkStatus.TabIndex = 856;
            this.chkStatus.Text = "By Status :";
            this.chkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStatus.UseVisualStyleBackColor = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // reprocessemployeetoolStripMenuItem
            // 
            this.reprocessemployeetoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reprocessemployeetoolStripMenuItem.Image")));
            this.reprocessemployeetoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reprocessemployeetoolStripMenuItem.Name = "reprocessemployeetoolStripMenuItem";
            this.reprocessemployeetoolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reprocessemployeetoolStripMenuItem.Text = "Reprocess Employee";
            this.reprocessemployeetoolStripMenuItem.Click += new System.EventHandler(this.reprocessemployeetoolStripMenuItem_Click);
            // 
            // cmsEmployee
            // 
            this.cmsEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddemptoolStripMenuItem,
            this.toolStripSeparator2,
            this.reprocessemployeetoolStripMenuItem,
            this.deletetoolStripMenuItem});
            this.cmsEmployee.Name = "cntxMnu";
            this.cmsEmployee.Size = new System.Drawing.Size(183, 76);
            // 
            // AddemptoolStripMenuItem
            // 
            this.AddemptoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddemptoolStripMenuItem.Image")));
            this.AddemptoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddemptoolStripMenuItem.Name = "AddemptoolStripMenuItem";
            this.AddemptoolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AddemptoolStripMenuItem.Text = "Add Employee";
            this.AddemptoolStripMenuItem.Click += new System.EventHandler(this.AddemptoolStripMenuItem_Click);
            // 
            // deletetoolStripMenuItem
            // 
            this.deletetoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletetoolStripMenuItem.Image")));
            this.deletetoolStripMenuItem.Name = "deletetoolStripMenuItem";
            this.deletetoolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deletetoolStripMenuItem.Text = "Delete Employee";
            this.deletetoolStripMenuItem.Click += new System.EventHandler(this.deletetoolStripMenuItem_Click);
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttitle.Border.Class = "TextBoxBorder";
            this.txttitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttitle.FocusHighlightEnabled = true;
            this.txttitle.ForeColor = System.Drawing.Color.Black;
            this.txttitle.Location = new System.Drawing.Point(147, 70);
            this.txttitle.Name = "txttitle";
            this.txttitle.ReadOnly = true;
            this.txttitle.Size = new System.Drawing.Size(309, 21);
            this.txttitle.TabIndex = 817;
            this.btxMsg.SetText(this.txttitle, "Timesheet title is required");
            this.btxMsg.SetTitle(this.txttitle, null);
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
            this.txtcompany.Location = new System.Drawing.Point(147, 44);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.ReadOnly = true;
            this.txtcompany.Size = new System.Drawing.Size(309, 21);
            this.txtcompany.TabIndex = 814;
            this.btxMsg.SetText(this.txtcompany, "Company Name is required");
            this.btxMsg.SetTitle(this.txtcompany, null);
            // 
            // txtclient_search
            // 
            this.txtclient_search.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtclient_search.Border.Class = "TextBoxBorder";
            this.txtclient_search.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtclient_search.FocusHighlightEnabled = true;
            this.txtclient_search.ForeColor = System.Drawing.Color.Black;
            this.txtclient_search.Location = new System.Drawing.Point(9, 48);
            this.txtclient_search.Name = "txtclient_search";
            this.txtclient_search.ReadOnly = true;
            this.txtclient_search.Size = new System.Drawing.Size(240, 21);
            this.txtclient_search.TabIndex = 817;
            this.txtclient_search.Tag = "0";
            this.btxMsg.SetText(this.txtclient_search, null);
            this.btxMsg.SetTitle(this.txtclient_search, null);
            // 
            // filterclient_btn
            // 
            this.filterclient_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.filterclient_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.filterclient_btn.Image = ((System.Drawing.Image)(resources.GetObject("filterclient_btn.Image")));
            this.filterclient_btn.Location = new System.Drawing.Point(250, 48);
            this.filterclient_btn.Name = "filterclient_btn";
            this.filterclient_btn.Size = new System.Drawing.Size(20, 21);
            this.filterclient_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.filterclient_btn.TabIndex = 819;
            this.filterclient_btn.Tooltip = "Press me to select a Client";
            // 
            // company_btn
            // 
            this.company_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.company_btn.FlatAppearance.BorderSize = 0;
            this.company_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.company_btn.ForeColor = System.Drawing.Color.White;
            this.company_btn.Image = ((System.Drawing.Image)(resources.GetObject("company_btn.Image")));
            this.company_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.company_btn.Location = new System.Drawing.Point(462, 44);
            this.company_btn.Name = "company_btn";
            this.company_btn.Size = new System.Drawing.Size(118, 21);
            this.company_btn.TabIndex = 871;
            this.company_btn.Text = "Search Company";
            this.company_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.company_btn.UseVisualStyleBackColor = false;
            this.company_btn.Click += new System.EventHandler(this.company_btn_Click);
            // 
            // prb
            // 
            this.prb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prb.Location = new System.Drawing.Point(0, 122);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(1098, 10);
            this.prb.TabIndex = 827;
            // 
            // dtpcutoffto
            // 
            this.dtpcutoffto.Enabled = false;
            this.dtpcutoffto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcutoffto.Location = new System.Drawing.Point(911, 44);
            this.dtpcutoffto.Name = "dtpcutoffto";
            this.dtpcutoffto.Size = new System.Drawing.Size(114, 21);
            this.dtpcutoffto.TabIndex = 823;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(841, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 826;
            this.label4.Text = "Cut Off To :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(834, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 825;
            this.label5.Text = "Overtime To :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpovertimeto
            // 
            this.dtpovertimeto.Enabled = false;
            this.dtpovertimeto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpovertimeto.Location = new System.Drawing.Point(911, 66);
            this.dtpovertimeto.Name = "dtpovertimeto";
            this.dtpovertimeto.Size = new System.Drawing.Size(114, 21);
            this.dtpovertimeto.TabIndex = 824;
            // 
            // dtpcutofffrom
            // 
            this.dtpcutofffrom.Enabled = false;
            this.dtpcutofffrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcutofffrom.Location = new System.Drawing.Point(703, 44);
            this.dtpcutofffrom.Name = "dtpcutofffrom";
            this.dtpcutofffrom.Size = new System.Drawing.Size(105, 21);
            this.dtpcutofffrom.TabIndex = 819;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(622, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 822;
            this.label3.Text = "Cut Off From :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cboTimesheetType);
            this.panel2.Controls.Add(this.company_btn);
            this.panel2.Controls.Add(this.prb);
            this.panel2.Controls.Add(this.dtpcutoffto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpovertimeto);
            this.panel2.Controls.Add(this.dtpcutofffrom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dtpovertimefrom);
            this.panel2.Controls.Add(this.txttitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtcompany);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ToolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 134);
            this.panel2.TabIndex = 836;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(614, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 821;
            this.label9.Text = "Overtime From :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpovertimefrom
            // 
            this.dtpovertimefrom.Enabled = false;
            this.dtpovertimefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpovertimefrom.Location = new System.Drawing.Point(703, 66);
            this.dtpovertimefrom.Name = "dtpovertimefrom";
            this.dtpovertimefrom.Size = new System.Drawing.Size(105, 21);
            this.dtpovertimefrom.TabIndex = 820;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 818;
            this.label2.Text = "Title :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 816;
            this.label1.Text = "Company Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.delete_btn,
            this.toolStripSplitButton1,
            this.Save_btn,
            this.cancel_btn,
            this.toolStripSeparator1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1098, 39);
            this.ToolStrip1.TabIndex = 550;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Add_btn
            // 
            this.Add_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_btn.Image")));
            this.Add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(36, 36);
            this.Add_btn.Text = "Add";
            this.Add_btn.ToolTipText = "Add record";
            this.Add_btn.Visible = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("Edit_btn.Image")));
            this.Edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(36, 36);
            this.Edit_btn.Text = "Edit";
            this.Edit_btn.ToolTipText = "Edit selected record";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.delete_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(36, 36);
            this.delete_btn.Text = "Print";
            this.delete_btn.ToolTipText = "Delete Records";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 39);
            // 
            // Save_btn
            // 
            this.Save_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_btn.Enabled = false;
            this.Save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.Image")));
            this.Save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(36, 36);
            this.Save_btn.Text = "Save";
            this.Save_btn.ToolTipText = "Save Record";
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel_btn.Enabled = false;
            this.cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancel_btn.Image")));
            this.cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 818;
            this.label6.Text = "Client Name :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panFilter
            // 
            this.panFilter.CanvasColor = System.Drawing.SystemColors.Control;
            this.panFilter.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.panFilter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.panFilter.Controls.Add(this.cboMonth);
            this.panFilter.Controls.Add(this.chkStatus);
            this.panFilter.Controls.Add(this.chkClient);
            this.panFilter.Controls.Add(this.filter_btn);
            this.panFilter.Controls.Add(this.cboStatus);
            this.panFilter.Controls.Add(this.label7);
            this.panFilter.Controls.Add(this.cboYear);
            this.panFilter.Controls.Add(this.label8);
            this.panFilter.Controls.Add(this.filterclient_btn);
            this.panFilter.Controls.Add(this.txtclient_search);
            this.panFilter.Controls.Add(this.label6);
            this.panFilter.Controls.Add(this.lsvHds);
            this.panFilter.ExpandOnTitleClick = true;
            this.panFilter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panFilter.HideControlsWhenCollapsed = true;
            this.panFilter.Location = new System.Drawing.Point(562, 310);
            this.panFilter.Name = "panFilter";
            this.panFilter.Size = new System.Drawing.Size(281, 241);
            this.panFilter.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panFilter.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panFilter.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panFilter.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panFilter.Style.GradientAngle = 90;
            this.panFilter.TabIndex = 837;
            this.panFilter.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.panFilter.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panFilter.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panFilter.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panFilter.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panFilter.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panFilter.TitleStyle.GradientAngle = 90;
            this.panFilter.TitleText = "Filter Records";
            this.panFilter.Visible = false;
            // 
            // lsvHds
            // 
            this.lsvHds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9});
            this.lsvHds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvHds.FullRowSelect = true;
            this.lsvHds.GridLines = true;
            this.lsvHds.Location = new System.Drawing.Point(0, 231);
            this.lsvHds.Name = "lsvHds";
            this.lsvHds.Size = new System.Drawing.Size(281, 10);
            this.lsvHds.TabIndex = 5;
            this.lsvHds.UseCompatibleStateImageBehavior = false;
            this.lsvHds.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Company";
            this.columnHeader8.Width = 127;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Title";
            this.columnHeader9.Width = 126;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 544);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1100, 22);
            this.panel4.TabIndex = 855;
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
            this.label10.Text = "          Press F3 to re-generate timesheet";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 880;
            this.label12.Text = "Timesheet Type :";
            // 
            // cboTimesheetType
            // 
            this.cboTimesheetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimesheetType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimesheetType.FormattingEnabled = true;
            this.cboTimesheetType.Items.AddRange(new object[] {
            "Regular",
            "Confidential"});
            this.cboTimesheetType.Location = new System.Drawing.Point(147, 95);
            this.cboTimesheetType.Name = "cboTimesheetType";
            this.cboTimesheetType.Size = new System.Drawing.Size(154, 21);
            this.cboTimesheetType.TabIndex = 881;
            // 
            // TimesheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panFilter);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TimesheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheet";
            this.Load += new System.EventHandler(this.TimesheetForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimesheetForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.expandablePanel1.ResumeLayout(false);
            this.cmsEmployee.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.panFilter.ResumeLayout(false);
            this.panFilter.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.CheckBox chkClient;
        internal DevComponents.DotNetBar.ButtonX filter_btn;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        internal DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        internal System.Windows.Forms.ListView lsvEmployee;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox chkStatus;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem reprocessemployeetoolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip cmsEmployee;
        private System.Windows.Forms.ToolStripMenuItem deletetoolStripMenuItem;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal DevComponents.DotNetBar.Controls.TextBoxX txttitle;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtcompany;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtclient_search;
        internal DevComponents.DotNetBar.ButtonX filterclient_btn;
        private System.Windows.Forms.Button company_btn;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.DateTimePicker dtpcutoffto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpovertimeto;
        private System.Windows.Forms.DateTimePicker dtpcutofffrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpovertimefrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton delete_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label6;
        internal DevComponents.DotNetBar.ExpandablePanel panFilter;
        internal System.Windows.Forms.ListView lsvAttendance;
        internal System.Windows.Forms.ColumnHeader ColumnHeader18;
        internal System.Windows.Forms.ColumnHeader ColumnHeader19;
        internal System.Windows.Forms.ColumnHeader ColumnHeader20;
        internal System.Windows.Forms.ColumnHeader ColumnHeader21;
        internal System.Windows.Forms.ColumnHeader ColumnHeader22;
        internal System.Windows.Forms.ColumnHeader ColumnHeader23;
        internal System.Windows.Forms.ColumnHeader ColumnHeader24;
        internal System.Windows.Forms.ColumnHeader ColumnHeader25;
        internal System.Windows.Forms.ColumnHeader ColumnHeader26;
        internal System.Windows.Forms.ColumnHeader ColumnHeader27;
        internal System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        internal System.Windows.Forms.Label lblSelected;
        internal System.Windows.Forms.ToolStripMenuItem AddemptoolStripMenuItem;
        internal System.Windows.Forms.ListView lsvHds;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTimesheetType;
    }
}