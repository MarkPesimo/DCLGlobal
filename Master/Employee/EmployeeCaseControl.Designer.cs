namespace DCLGlobal.Master.Employee
{
    partial class EmployeeCaseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeCaseControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCaseNo = new System.Windows.Forms.MaskedTextBox();
            this.cboMemo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtstatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.txtFileLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label8 = new System.Windows.Forms.Label();
            this.dtpEffectivity = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.chkForHearing = new System.Windows.Forms.CheckBox();
            this.dtpDateOfNOAH = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpDateNOAHIssued = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtpReplyReceived = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpReceived = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpIssued = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewButtonXColumn17 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEffectivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateOfNOAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateNOAHIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReplyReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
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
            this.toolStrip1.TabIndex = 500;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(97, 36);
            this.toolStripLabel1.Text = "Employee Case";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCaseNo);
            this.panel1.Controls.Add(this.cboMemo);
            this.panel1.Controls.Add(this.txtstatus);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtFileLocation);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.dtpEffectivity);
            this.panel1.Controls.Add(this.Label12);
            this.panel1.Controls.Add(this.Label11);
            this.panel1.Controls.Add(this.chkForHearing);
            this.panel1.Controls.Add(this.dtpDateOfNOAH);
            this.panel1.Controls.Add(this.dtpDateNOAHIssued);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.Label10);
            this.panel1.Controls.Add(this.dtpReplyReceived);
            this.panel1.Controls.Add(this.dtpReceived);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.dtpIssued);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.Label9);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 242);
            this.panel1.TabIndex = 516;
            // 
            // txtCaseNo
            // 
            this.txtCaseNo.Location = new System.Drawing.Point(119, 6);
            this.txtCaseNo.Mask = "0000-00";
            this.txtCaseNo.Name = "txtCaseNo";
            this.txtCaseNo.Size = new System.Drawing.Size(121, 21);
            this.txtCaseNo.TabIndex = 0;
            // 
            // cboMemo
            // 
            this.cboMemo.DisabledBackColor = System.Drawing.Color.White;
            this.cboMemo.DisabledForeColor = System.Drawing.Color.Black;
            this.cboMemo.DisplayMember = "Text";
            this.cboMemo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMemo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemo.FormattingEnabled = true;
            this.cboMemo.ItemHeight = 15;
            this.cboMemo.Location = new System.Drawing.Point(378, 6);
            this.cboMemo.Name = "cboMemo";
            this.cboMemo.Size = new System.Drawing.Size(397, 21);
            this.cboMemo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMemo.TabIndex = 1;
            // 
            // txtstatus
            // 
            // 
            // 
            // 
            this.txtstatus.Border.Class = "TextBoxBorder";
            this.txtstatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtstatus.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtstatus.FocusHighlightEnabled = true;
            this.txtstatus.Location = new System.Drawing.Point(119, 101);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtstatus.Size = new System.Drawing.Size(656, 52);
            this.txtstatus.TabIndex = 9;
            this.btxMsg.SetText(this.txtstatus, null);
            this.btxMsg.SetTitle(this.txtstatus, null);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(734, 213);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 21);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            this.txtFileLocation.ForeColor = System.Drawing.Color.Black;
            this.txtFileLocation.Location = new System.Drawing.Point(119, 213);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(609, 21);
            this.txtFileLocation.TabIndex = 11;
            this.btxMsg.SetText(this.txtFileLocation, "Case scanned document is required.");
            this.btxMsg.SetTitle(this.txtFileLocation, null);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Location = new System.Drawing.Point(45, 217);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(70, 13);
            this.Label8.TabIndex = 150;
            this.Label8.Text = "File Location:";
            // 
            // dtpEffectivity
            // 
            // 
            // 
            // 
            this.dtpEffectivity.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpEffectivity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpEffectivity.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpEffectivity.ButtonDropDown.Visible = true;
            this.dtpEffectivity.IsPopupCalendarOpen = false;
            this.dtpEffectivity.Location = new System.Drawing.Point(654, 77);
            this.dtpEffectivity.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtpEffectivity.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpEffectivity.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpEffectivity.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpEffectivity.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpEffectivity.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpEffectivity.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtpEffectivity.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpEffectivity.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpEffectivity.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpEffectivity.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpEffectivity.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpEffectivity.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpEffectivity.MonthCalendar.TodayButtonVisible = true;
            this.dtpEffectivity.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpEffectivity.Name = "dtpEffectivity";
            this.dtpEffectivity.ShowCheckBox = true;
            this.dtpEffectivity.Size = new System.Drawing.Size(121, 21);
            this.dtpEffectivity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpEffectivity.TabIndex = 8;
            this.dtpEffectivity.Value = new System.DateTime(2012, 10, 8, 10, 5, 6, 0);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(568, 81);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(86, 13);
            this.Label12.TabIndex = 148;
            this.Label12.Text = "Effectivity Date:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(74, 106);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(42, 13);
            this.Label11.TabIndex = 147;
            this.Label11.Text = "Status:";
            // 
            // chkForHearing
            // 
            this.chkForHearing.AutoSize = true;
            this.chkForHearing.Location = new System.Drawing.Point(119, 57);
            this.chkForHearing.Name = "chkForHearing";
            this.chkForHearing.Size = new System.Drawing.Size(15, 14);
            this.chkForHearing.TabIndex = 5;
            this.chkForHearing.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfNOAH
            // 
            // 
            // 
            // 
            this.dtpDateOfNOAH.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpDateOfNOAH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateOfNOAH.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpDateOfNOAH.ButtonDropDown.Visible = true;
            this.dtpDateOfNOAH.IsPopupCalendarOpen = false;
            this.dtpDateOfNOAH.Location = new System.Drawing.Point(378, 77);
            this.dtpDateOfNOAH.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtpDateOfNOAH.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpDateOfNOAH.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpDateOfNOAH.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateOfNOAH.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpDateOfNOAH.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateOfNOAH.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtpDateOfNOAH.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpDateOfNOAH.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpDateOfNOAH.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpDateOfNOAH.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDateOfNOAH.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpDateOfNOAH.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateOfNOAH.MonthCalendar.TodayButtonVisible = true;
            this.dtpDateOfNOAH.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpDateOfNOAH.Name = "dtpDateOfNOAH";
            this.dtpDateOfNOAH.ShowCheckBox = true;
            this.dtpDateOfNOAH.Size = new System.Drawing.Size(145, 21);
            this.dtpDateOfNOAH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpDateOfNOAH.TabIndex = 7;
            this.dtpDateOfNOAH.Value = new System.DateTime(2012, 10, 8, 10, 5, 6, 0);
            // 
            // dtpDateNOAHIssued
            // 
            // 
            // 
            // 
            this.dtpDateNOAHIssued.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpDateNOAHIssued.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateNOAHIssued.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpDateNOAHIssued.ButtonDropDown.Visible = true;
            this.dtpDateNOAHIssued.IsPopupCalendarOpen = false;
            this.dtpDateNOAHIssued.Location = new System.Drawing.Point(119, 77);
            this.dtpDateNOAHIssued.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtpDateNOAHIssued.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpDateNOAHIssued.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpDateNOAHIssued.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateNOAHIssued.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpDateNOAHIssued.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateNOAHIssued.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtpDateNOAHIssued.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpDateNOAHIssued.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpDateNOAHIssued.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpDateNOAHIssued.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDateNOAHIssued.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpDateNOAHIssued.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDateNOAHIssued.MonthCalendar.TodayButtonVisible = true;
            this.dtpDateNOAHIssued.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpDateNOAHIssued.Name = "dtpDateNOAHIssued";
            this.dtpDateNOAHIssued.ShowCheckBox = true;
            this.dtpDateNOAHIssued.Size = new System.Drawing.Size(121, 21);
            this.dtpDateNOAHIssued.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpDateNOAHIssued.TabIndex = 6;
            this.dtpDateNOAHIssued.Value = new System.DateTime(2012, 10, 8, 10, 5, 6, 0);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(295, 81);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(79, 13);
            this.Label5.TabIndex = 143;
            this.Label5.Text = "Date of NOAH:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(14, 81);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(101, 13);
            this.Label10.TabIndex = 142;
            this.Label10.Text = "Date NOAH Issued:";
            // 
            // dtpReplyReceived
            // 
            // 
            // 
            // 
            this.dtpReplyReceived.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpReplyReceived.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReplyReceived.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpReplyReceived.ButtonDropDown.Visible = true;
            this.dtpReplyReceived.IsPopupCalendarOpen = false;
            this.dtpReplyReceived.Location = new System.Drawing.Point(654, 30);
            this.dtpReplyReceived.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtpReplyReceived.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReplyReceived.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpReplyReceived.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReplyReceived.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpReplyReceived.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReplyReceived.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtpReplyReceived.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpReplyReceived.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReplyReceived.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpReplyReceived.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReplyReceived.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpReplyReceived.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReplyReceived.MonthCalendar.TodayButtonVisible = true;
            this.dtpReplyReceived.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpReplyReceived.Name = "dtpReplyReceived";
            this.dtpReplyReceived.ShowCheckBox = true;
            this.dtpReplyReceived.Size = new System.Drawing.Size(121, 21);
            this.dtpReplyReceived.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpReplyReceived.TabIndex = 4;
            this.dtpReplyReceived.Value = new System.DateTime(2012, 10, 8, 10, 5, 6, 0);
            // 
            // dtpReceived
            // 
            // 
            // 
            // 
            this.dtpReceived.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpReceived.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReceived.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpReceived.ButtonDropDown.Visible = true;
            this.dtpReceived.IsPopupCalendarOpen = false;
            this.dtpReceived.Location = new System.Drawing.Point(378, 30);
            this.dtpReceived.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtpReceived.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReceived.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpReceived.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReceived.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpReceived.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReceived.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtpReceived.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpReceived.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpReceived.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpReceived.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpReceived.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpReceived.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpReceived.MonthCalendar.TodayButtonVisible = true;
            this.dtpReceived.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpReceived.Name = "dtpReceived";
            this.dtpReceived.ShowCheckBox = true;
            this.dtpReceived.Size = new System.Drawing.Size(145, 21);
            this.dtpReceived.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpReceived.TabIndex = 3;
            this.dtpReceived.Value = new System.DateTime(2012, 10, 8, 10, 5, 6, 0);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(62, 161);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 138;
            this.Label3.Text = "Remarks:";
            // 
            // dtpIssued
            // 
            // 
            // 
            // 
            this.dtpIssued.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpIssued.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpIssued.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpIssued.ButtonDropDown.Visible = true;
            this.dtpIssued.IsPopupCalendarOpen = false;
            this.dtpIssued.Location = new System.Drawing.Point(119, 30);
            this.dtpIssued.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtpIssued.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpIssued.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpIssued.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpIssued.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpIssued.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpIssued.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtpIssued.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpIssued.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpIssued.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpIssued.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpIssued.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpIssued.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpIssued.MonthCalendar.TodayButtonVisible = true;
            this.dtpIssued.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpIssued.Name = "dtpIssued";
            this.dtpIssued.ShowCheckBox = true;
            this.dtpIssued.Size = new System.Drawing.Size(121, 21);
            this.dtpIssued.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpIssued.TabIndex = 2;
            this.dtpIssued.Value = new System.DateTime(2012, 10, 8, 10, 5, 6, 0);
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.Border.Class = "TextBoxBorder";
            this.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemarks.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtRemarks.FocusHighlightEnabled = true;
            this.txtRemarks.Location = new System.Drawing.Point(119, 156);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(656, 54);
            this.txtRemarks.TabIndex = 10;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(292, 34);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 13);
            this.Label9.TabIndex = 135;
            this.Label9.Text = "Date Received:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Location = new System.Drawing.Point(538, 34);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(111, 13);
            this.Label7.TabIndex = 134;
            this.Label7.Text = "Date Received Reply:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Location = new System.Drawing.Point(50, 57);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(67, 13);
            this.Label6.TabIndex = 133;
            this.Label6.Text = "For Hearing:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(312, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 13);
            this.Label4.TabIndex = 132;
            this.Label4.Text = "Memo type:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(48, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 131;
            this.Label2.Text = "Date Issued:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(63, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 13);
            this.Label1.TabIndex = 130;
            this.Label1.Text = "Case no.:";
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewButtonXColumn17,
            this.Column36,
            this.DataGridViewTextBoxColumn28,
            this.DataGridViewTextBoxColumn29,
            this.Column33,
            this.Column34,
            this.Location});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCases.EnableHeadersVisualStyles = false;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCases.HighlightSelectedColumnHeaders = false;
            this.dgvCases.Location = new System.Drawing.Point(0, 281);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCases.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCases.Size = new System.Drawing.Size(788, 319);
            this.dgvCases.TabIndex = 517;
            this.dgvCases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellClick);
            this.dgvCases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCases_CellContentClick);
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.DataGridViewTextBoxColumn3.HeaderText = "Id";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Visible = false;
            // 
            // DataGridViewButtonXColumn17
            // 
            this.DataGridViewButtonXColumn17.DataPropertyName = "_open";
            this.DataGridViewButtonXColumn17.HeaderText = "Open File";
            this.DataGridViewButtonXColumn17.Name = "DataGridViewButtonXColumn17";
            this.DataGridViewButtonXColumn17.ReadOnly = true;
            this.DataGridViewButtonXColumn17.Text = null;
            this.DataGridViewButtonXColumn17.Width = 80;
            // 
            // Column36
            // 
            this.Column36.DataPropertyName = "Caseno";
            this.Column36.HeaderText = "Case no.";
            this.Column36.Name = "Column36";
            this.Column36.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn28
            // 
            this.DataGridViewTextBoxColumn28.DataPropertyName = "MemoName";
            this.DataGridViewTextBoxColumn28.HeaderText = "Memo Type";
            this.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28";
            this.DataGridViewTextBoxColumn28.ReadOnly = true;
            this.DataGridViewTextBoxColumn28.Width = 160;
            // 
            // DataGridViewTextBoxColumn29
            // 
            this.DataGridViewTextBoxColumn29.DataPropertyName = "DateIssued";
            this.DataGridViewTextBoxColumn29.HeaderText = "Date Issued";
            this.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29";
            this.DataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // Column33
            // 
            this.Column33.DataPropertyName = "Status";
            this.Column33.HeaderText = "Status";
            this.Column33.Name = "Column33";
            this.Column33.ReadOnly = true;
            // 
            // Column34
            // 
            this.Column34.DataPropertyName = "Remarks";
            this.Column34.HeaderText = "Remarks";
            this.Column34.Name = "Column34";
            this.Column34.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // EmployeeCaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCases);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeCaseControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmployeeCasesControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEffectivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateOfNOAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDateNOAHIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReplyReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
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
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cboMemo;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtstatus;
        internal DevComponents.DotNetBar.ButtonX btnBrowse;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFileLocation;
        internal System.Windows.Forms.Label Label8;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtpEffectivity;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.CheckBox chkForHearing;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDateOfNOAH;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDateNOAHIssued;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label10;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtpReplyReceived;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtpReceived;
        internal System.Windows.Forms.Label Label3;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtpIssued;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DataGridViewButtonXColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        internal System.Windows.Forms.OpenFileDialog OFD1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.MaskedTextBox txtCaseNo;
    }
}
