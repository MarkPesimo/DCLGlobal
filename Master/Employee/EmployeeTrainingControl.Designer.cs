namespace DCLGlobal.Master.Employee
{
    partial class EmployeeTrainingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTrainingControl));
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
            this.txtNoOfHours = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label12 = new System.Windows.Forms.Label();
            this.chkInternal = new System.Windows.Forms.CheckBox();
            this.dtDateTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.dblcost = new DevComponents.Editors.DoubleInput();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.txtFileLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboTraining = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtDateFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFacilitator = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvTrainings = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewButtonXColumn15 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainingLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblcost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
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
            this.toolStrip1.TabIndex = 497;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 36);
            this.toolStripLabel1.Text = "Employee Trainings";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNoOfHours);
            this.panel1.Controls.Add(this.Label12);
            this.panel1.Controls.Add(this.chkInternal);
            this.panel1.Controls.Add(this.dtDateTo);
            this.panel1.Controls.Add(this.Label9);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.dblcost);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtFileLocation);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.cboTraining);
            this.panel1.Controls.Add(this.dtDateFrom);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtFacilitator);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 181);
            this.panel1.TabIndex = 513;
            // 
            // txtNoOfHours
            // 
            this.txtNoOfHours.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNoOfHours.Border.Class = "TextBoxBorder";
            this.txtNoOfHours.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNoOfHours.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtNoOfHours.FocusHighlightEnabled = true;
            this.txtNoOfHours.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNoOfHours.Location = new System.Drawing.Point(579, 78);
            this.txtNoOfHours.Name = "txtNoOfHours";
            this.txtNoOfHours.Size = new System.Drawing.Size(67, 21);
            this.txtNoOfHours.TabIndex = 160;
            this.txtNoOfHours.Text = "0";
            this.btxMsg.SetText(this.txtNoOfHours, null);
            this.txtNoOfHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtNoOfHours, null);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.SystemColors.Control;
            this.Label12.Location = new System.Drawing.Point(505, 83);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(71, 13);
            this.Label12.TabIndex = 159;
            this.Label12.Text = "No. of hours:";
            // 
            // chkInternal
            // 
            this.chkInternal.AutoSize = true;
            this.chkInternal.BackColor = System.Drawing.Color.Transparent;
            this.chkInternal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInternal.Location = new System.Drawing.Point(347, 81);
            this.chkInternal.Name = "chkInternal";
            this.chkInternal.Size = new System.Drawing.Size(64, 17);
            this.chkInternal.TabIndex = 158;
            this.chkInternal.Text = "Internal";
            this.chkInternal.UseVisualStyleBackColor = false;
            // 
            // dtDateTo
            // 
            // 
            // 
            // 
            this.dtDateTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateTo.ButtonDropDown.Visible = true;
            this.dtDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateTo.IsPopupCalendarOpen = false;
            this.dtDateTo.Location = new System.Drawing.Point(346, 54);
            this.dtDateTo.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtDateTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtDateTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDateTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateTo.MonthCalendar.TodayButtonVisible = true;
            this.dtDateTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.ShowCheckBox = true;
            this.dtDateTo.Size = new System.Drawing.Size(110, 21);
            this.dtDateTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateTo.TabIndex = 157;
            this.dtDateTo.Value = new System.DateTime(2015, 9, 3, 15, 42, 7, 0);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(317, 57);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(23, 13);
            this.Label9.TabIndex = 156;
            this.Label9.Text = "To:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(129, 57);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(35, 13);
            this.Label8.TabIndex = 155;
            this.Label8.Text = "From:";
            // 
            // dblcost
            // 
            // 
            // 
            // 
            this.dblcost.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dblcost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dblcost.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dblcost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblcost.Increment = 1D;
            this.dblcost.Location = new System.Drawing.Point(168, 78);
            this.dblcost.Name = "dblcost";
            this.dblcost.ShowUpDown = true;
            this.dblcost.Size = new System.Drawing.Size(110, 21);
            this.dblcost.TabIndex = 154;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(651, 152);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 21);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 153;
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
            this.txtFileLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFileLocation.Location = new System.Drawing.Point(168, 152);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(479, 21);
            this.txtFileLocation.TabIndex = 152;
            this.btxMsg.SetText(this.txtFileLocation, "Training scanned document is required.");
            this.btxMsg.SetTitle(this.txtFileLocation, null);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(94, 156);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(70, 13);
            this.Label7.TabIndex = 151;
            this.Label7.Text = "File Location:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRemarks.Border.Class = "TextBoxBorder";
            this.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemarks.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtRemarks.FocusHighlightEnabled = true;
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRemarks.Location = new System.Drawing.Point(168, 127);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(479, 21);
            this.txtRemarks.TabIndex = 150;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(112, 132);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 13);
            this.Label6.TabIndex = 149;
            this.Label6.Text = "Remarks:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(131, 83);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(33, 13);
            this.Label2.TabIndex = 148;
            this.Label2.Text = "Cost:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(115, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(49, 13);
            this.Label4.TabIndex = 147;
            this.Label4.Text = "Training:";
            // 
            // cboTraining
            // 
            this.cboTraining.DisabledBackColor = System.Drawing.Color.White;
            this.cboTraining.DisabledForeColor = System.Drawing.Color.Black;
            this.cboTraining.DisplayMember = "Text";
            this.cboTraining.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraining.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTraining.FormattingEnabled = true;
            this.cboTraining.ItemHeight = 15;
            this.cboTraining.Location = new System.Drawing.Point(168, 6);
            this.cboTraining.Name = "cboTraining";
            this.cboTraining.Size = new System.Drawing.Size(478, 21);
            this.cboTraining.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTraining.TabIndex = 146;
            // 
            // dtDateFrom
            // 
            // 
            // 
            // 
            this.dtDateFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateFrom.ButtonDropDown.Visible = true;
            this.dtDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFrom.IsPopupCalendarOpen = false;
            this.dtDateFrom.Location = new System.Drawing.Point(168, 53);
            this.dtDateFrom.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtDateFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtDateFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDateFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtDateFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.ShowCheckBox = true;
            this.dtDateFrom.Size = new System.Drawing.Size(110, 21);
            this.dtDateFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateFrom.TabIndex = 145;
            this.dtDateFrom.Value = new System.DateTime(2015, 9, 3, 15, 41, 57, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtAddress.FocusHighlightEnabled = true;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Location = new System.Drawing.Point(168, 103);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(479, 21);
            this.txtAddress.TabIndex = 144;
            this.btxMsg.SetText(this.txtAddress, "Training address is required.");
            this.btxMsg.SetTitle(this.txtAddress, null);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(114, 107);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(50, 13);
            this.Label3.TabIndex = 143;
            this.Label3.Text = "Address:";
            // 
            // txtFacilitator
            // 
            this.txtFacilitator.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFacilitator.Border.Class = "TextBoxBorder";
            this.txtFacilitator.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFacilitator.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtFacilitator.FocusHighlightEnabled = true;
            this.txtFacilitator.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacilitator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFacilitator.Location = new System.Drawing.Point(168, 29);
            this.txtFacilitator.Name = "txtFacilitator";
            this.txtFacilitator.Size = new System.Drawing.Size(478, 21);
            this.txtFacilitator.TabIndex = 142;
            this.btxMsg.SetText(this.txtFacilitator, "Facilitator is required.");
            this.btxMsg.SetTitle(this.txtFacilitator, null);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(106, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 13);
            this.Label1.TabIndex = 141;
            this.Label1.Text = "Facilitator:";
            // 
            // dgvTrainings
            // 
            this.dgvTrainings.AllowUserToAddRows = false;
            this.dgvTrainings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn18,
            this.DataGridViewButtonXColumn15,
            this.DataGridViewTextBoxColumn19,
            this.DataGridViewTextBoxColumn20,
            this.Column17,
            this.DataGridViewTextBoxColumn21,
            this.DataGridViewTextBoxColumn22,
            this.TrainingLocation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainings.EnableHeadersVisualStyles = false;
            this.dgvTrainings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTrainings.HighlightSelectedColumnHeaders = false;
            this.dgvTrainings.Location = new System.Drawing.Point(0, 220);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainings.Size = new System.Drawing.Size(788, 380);
            this.dgvTrainings.TabIndex = 514;
            this.dgvTrainings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainings_CellClick);
            this.dgvTrainings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrainings_CellContentClick);
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.DataPropertyName = "ID";
            this.DataGridViewTextBoxColumn18.HeaderText = "Id";
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            this.DataGridViewTextBoxColumn18.ReadOnly = true;
            this.DataGridViewTextBoxColumn18.Visible = false;
            // 
            // DataGridViewButtonXColumn15
            // 
            this.DataGridViewButtonXColumn15.DataPropertyName = "_open";
            this.DataGridViewButtonXColumn15.HeaderText = "Open File";
            this.DataGridViewButtonXColumn15.Name = "DataGridViewButtonXColumn15";
            this.DataGridViewButtonXColumn15.ReadOnly = true;
            this.DataGridViewButtonXColumn15.Text = null;
            this.DataGridViewButtonXColumn15.Width = 80;
            // 
            // DataGridViewTextBoxColumn19
            // 
            this.DataGridViewTextBoxColumn19.DataPropertyName = "Training_name";
            this.DataGridViewTextBoxColumn19.HeaderText = "Training Name";
            this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            this.DataGridViewTextBoxColumn19.ReadOnly = true;
            this.DataGridViewTextBoxColumn19.Width = 130;
            // 
            // DataGridViewTextBoxColumn20
            // 
            this.DataGridViewTextBoxColumn20.DataPropertyName = "Dateissued";
            this.DataGridViewTextBoxColumn20.HeaderText = "From";
            this.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            this.DataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "DateTo";
            this.Column17.HeaderText = "To";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn21
            // 
            this.DataGridViewTextBoxColumn21.DataPropertyName = "Address";
            this.DataGridViewTextBoxColumn21.HeaderText = "Address";
            this.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21";
            this.DataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn22
            // 
            this.DataGridViewTextBoxColumn22.DataPropertyName = "Facilitator";
            this.DataGridViewTextBoxColumn22.HeaderText = "Facilitator";
            this.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22";
            this.DataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // TrainingLocation
            // 
            this.TrainingLocation.HeaderText = "Training Location";
            this.TrainingLocation.Name = "TrainingLocation";
            this.TrainingLocation.ReadOnly = true;
            this.TrainingLocation.Visible = false;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // EmployeeTrainingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvTrainings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeTrainingControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmployeeTrainingControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dblcost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
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
        internal System.Windows.Forms.CheckBox chkInternal;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateTo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        private DevComponents.Editors.DoubleInput dblcost;
        private DevComponents.DotNetBar.ButtonX btnBrowse;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFileLocation;
        internal System.Windows.Forms.Label Label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTraining;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateFrom;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        internal System.Windows.Forms.Label Label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFacilitator;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvTrainings;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal System.Windows.Forms.OpenFileDialog OFD1;
        internal System.Windows.Forms.Label Label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DataGridViewButtonXColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingLocation;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNoOfHours;
    }
}
