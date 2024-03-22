namespace DCLGlobal.Master.Employee
{
    partial class EmployeeLicensureControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLicensureControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPlaceIssued = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtLicenseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtDateExpired = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.dtDateIssued = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFileLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtLicenseNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvLicensure = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewButtonXColumn23 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.DataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicensureLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateExpired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicensure)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.Save_btn,
            this.cancel_btn,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 39);
            this.toolStrip1.TabIndex = 496;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_btn
            // 
            this.Add_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_btn.Image")));
            this.Add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(36, 36);
            this.Add_btn.Text = "Add Record";
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
            this.Edit_btn.Text = "Edit Record";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
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
            this.Save_btn.Text = "Save Record";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 36);
            this.toolStripLabel1.Text = "Employee Licensure";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPlaceIssued);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.txtLicenseName);
            this.panel1.Controls.Add(this.dtDateExpired);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.dtDateIssued);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txtFileLocation);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtLicenseNo);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 120);
            this.panel1.TabIndex = 512;
            // 
            // txtPlaceIssued
            // 
            this.txtPlaceIssued.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPlaceIssued.Border.Class = "TextBoxBorder";
            this.txtPlaceIssued.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlaceIssued.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtPlaceIssued.FocusHighlightEnabled = true;
            this.txtPlaceIssued.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceIssued.ForeColor = System.Drawing.Color.Black;
            this.txtPlaceIssued.Location = new System.Drawing.Point(121, 62);
            this.txtPlaceIssued.Multiline = true;
            this.txtPlaceIssued.Name = "txtPlaceIssued";
            this.txtPlaceIssued.Size = new System.Drawing.Size(626, 21);
            this.txtPlaceIssued.TabIndex = 4;
            this.btxMsg.SetText(this.txtPlaceIssued, "Place issued is required.");
            this.btxMsg.SetTitle(this.txtPlaceIssued, null);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(15, 61);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(93, 21);
            this.Label6.TabIndex = 145;
            this.Label6.Text = "Place Issued:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLicenseName
            // 
            this.txtLicenseName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicenseName.Border.Class = "TextBoxBorder";
            this.txtLicenseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseName.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtLicenseName.FocusHighlightEnabled = true;
            this.txtLicenseName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseName.ForeColor = System.Drawing.Color.Black;
            this.txtLicenseName.Location = new System.Drawing.Point(121, 9);
            this.txtLicenseName.Name = "txtLicenseName";
            this.txtLicenseName.Size = new System.Drawing.Size(626, 21);
            this.txtLicenseName.TabIndex = 0;
            this.btxMsg.SetText(this.txtLicenseName, "License name is required.");
            this.btxMsg.SetTitle(this.txtLicenseName, null);
            // 
            // dtDateExpired
            // 
            // 
            // 
            // 
            this.dtDateExpired.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateExpired.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateExpired.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateExpired.ButtonDropDown.Visible = true;
            this.dtDateExpired.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateExpired.IsPopupCalendarOpen = false;
            this.dtDateExpired.Location = new System.Drawing.Point(635, 35);
            this.dtDateExpired.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtDateExpired.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateExpired.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtDateExpired.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateExpired.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateExpired.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateExpired.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtDateExpired.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDateExpired.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateExpired.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateExpired.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateExpired.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateExpired.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateExpired.MonthCalendar.TodayButtonVisible = true;
            this.dtDateExpired.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDateExpired.Name = "dtDateExpired";
            this.dtDateExpired.ShowCheckBox = true;
            this.dtDateExpired.Size = new System.Drawing.Size(112, 21);
            this.dtDateExpired.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateExpired.TabIndex = 3;
            this.dtDateExpired.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(529, 36);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 20);
            this.Label4.TabIndex = 142;
            this.Label4.Text = "Date expired:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(706, 88);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 21);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dtDateIssued
            // 
            // 
            // 
            // 
            this.dtDateIssued.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateIssued.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssued.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateIssued.ButtonDropDown.Visible = true;
            this.dtDateIssued.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateIssued.IsPopupCalendarOpen = false;
            this.dtDateIssued.Location = new System.Drawing.Point(398, 36);
            this.dtDateIssued.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtDateIssued.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateIssued.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtDateIssued.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssued.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateIssued.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssued.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtDateIssued.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDateIssued.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateIssued.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateIssued.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateIssued.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateIssued.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssued.MonthCalendar.TodayButtonVisible = true;
            this.dtDateIssued.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDateIssued.Name = "dtDateIssued";
            this.dtDateIssued.ShowCheckBox = true;
            this.dtDateIssued.Size = new System.Drawing.Size(112, 21);
            this.dtDateIssued.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateIssued.TabIndex = 2;
            this.dtDateIssued.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(316, 36);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 20);
            this.Label5.TabIndex = 139;
            this.Label5.Text = "Date Issued:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFileLocation.Border.Class = "TextBoxBorder";
            this.txtFileLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFileLocation.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtFileLocation.FocusHighlightEnabled = true;
            this.txtFileLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.ForeColor = System.Drawing.Color.Black;
            this.txtFileLocation.Location = new System.Drawing.Point(121, 88);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(579, 21);
            this.txtFileLocation.TabIndex = 6;
            this.btxMsg.SetText(this.txtFileLocation, "Licensure scanned document is required.");
            this.btxMsg.SetTitle(this.txtFileLocation, null);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(37, 89);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 21);
            this.Label3.TabIndex = 137;
            this.Label3.Text = "File Location:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicenseNo.Border.Class = "TextBoxBorder";
            this.txtLicenseNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenseNo.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtLicenseNo.FocusHighlightEnabled = true;
            this.txtLicenseNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNo.ForeColor = System.Drawing.Color.Black;
            this.txtLicenseNo.Location = new System.Drawing.Point(121, 36);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(166, 21);
            this.txtLicenseNo.TabIndex = 1;
            this.btxMsg.SetText(this.txtLicenseNo, "License no. is required.");
            this.btxMsg.SetTitle(this.txtLicenseNo, null);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(29, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 21);
            this.Label2.TabIndex = 135;
            this.Label2.Text = "License No.:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(20, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 21);
            this.Label1.TabIndex = 134;
            this.Label1.Text = "License Name:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvLicensure
            // 
            this.dgvLicensure.AllowUserToAddRows = false;
            this.dgvLicensure.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLicensure.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLicensure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicensure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn34,
            this.DataGridViewButtonXColumn23,
            this.DataGridViewTextBoxColumn35,
            this.DataGridViewTextBoxColumn37,
            this.DataGridViewTextBoxColumn38,
            this.DataGridViewTextBoxColumn39,
            this.Column38,
            this.LicensureLocation});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLicensure.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLicensure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLicensure.EnableHeadersVisualStyles = false;
            this.dgvLicensure.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLicensure.Location = new System.Drawing.Point(0, 159);
            this.dgvLicensure.Name = "dgvLicensure";
            this.dgvLicensure.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLicensure.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLicensure.Size = new System.Drawing.Size(788, 441);
            this.dgvLicensure.TabIndex = 513;
            this.dgvLicensure.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLicensure_CellClick);
            this.dgvLicensure.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLicensure_CellContentClick);
            // 
            // DataGridViewTextBoxColumn34
            // 
            this.DataGridViewTextBoxColumn34.DataPropertyName = "employeelicensureID";
            this.DataGridViewTextBoxColumn34.HeaderText = "ID";
            this.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34";
            this.DataGridViewTextBoxColumn34.ReadOnly = true;
            this.DataGridViewTextBoxColumn34.Visible = false;
            // 
            // DataGridViewButtonXColumn23
            // 
            this.DataGridViewButtonXColumn23.DataPropertyName = "_open";
            this.DataGridViewButtonXColumn23.HeaderText = "Open File";
            this.DataGridViewButtonXColumn23.Name = "DataGridViewButtonXColumn23";
            this.DataGridViewButtonXColumn23.ReadOnly = true;
            this.DataGridViewButtonXColumn23.Text = null;
            this.DataGridViewButtonXColumn23.Width = 80;
            // 
            // DataGridViewTextBoxColumn35
            // 
            this.DataGridViewTextBoxColumn35.DataPropertyName = "employeelicensureNAME";
            this.DataGridViewTextBoxColumn35.HeaderText = "License Name";
            this.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35";
            this.DataGridViewTextBoxColumn35.ReadOnly = true;
            this.DataGridViewTextBoxColumn35.Width = 160;
            // 
            // DataGridViewTextBoxColumn37
            // 
            this.DataGridViewTextBoxColumn37.DataPropertyName = "employeelicensureNO";
            this.DataGridViewTextBoxColumn37.HeaderText = "License No.";
            this.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37";
            this.DataGridViewTextBoxColumn37.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn38
            // 
            this.DataGridViewTextBoxColumn38.DataPropertyName = "employeelicensureDATEISSUED";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataGridViewTextBoxColumn38.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTextBoxColumn38.HeaderText = "Date Issued";
            this.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38";
            this.DataGridViewTextBoxColumn38.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn39
            // 
            this.DataGridViewTextBoxColumn39.DataPropertyName = "employeelicensureDATEEXPIRED";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DataGridViewTextBoxColumn39.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTextBoxColumn39.HeaderText = "Date Expired";
            this.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39";
            this.DataGridViewTextBoxColumn39.ReadOnly = true;
            this.DataGridViewTextBoxColumn39.Width = 200;
            // 
            // Column38
            // 
            this.Column38.DataPropertyName = "employeelicensurePLACEISSUED";
            this.Column38.HeaderText = "Place Issued";
            this.Column38.Name = "Column38";
            this.Column38.ReadOnly = true;
            // 
            // LicensureLocation
            // 
            this.LicensureLocation.HeaderText = "File Location";
            this.LicensureLocation.Name = "LicensureLocation";
            this.LicensureLocation.ReadOnly = true;
            this.LicensureLocation.Visible = false;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // EmployeeLicensureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLicensure);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeLicensureControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmployeeLicensureControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDateExpired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicensure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPlaceIssued;
        internal System.Windows.Forms.Label Label6;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtLicenseName;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateExpired;
        internal System.Windows.Forms.Label Label4;
        internal DevComponents.DotNetBar.ButtonX btnBrowse;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateIssued;
        internal System.Windows.Forms.Label Label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFileLocation;
        internal System.Windows.Forms.Label Label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtLicenseNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvLicensure;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn34;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DataGridViewButtonXColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column38;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicensureLocation;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal System.Windows.Forms.OpenFileDialog OFD1;
    }
}
