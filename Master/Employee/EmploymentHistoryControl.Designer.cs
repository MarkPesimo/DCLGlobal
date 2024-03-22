namespace DCLGlobal.Master.Employee
{
    partial class EmploymentHistoryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmploymentHistoryControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.Cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtTo = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtFrom = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbostatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem6 = new DevComponents.Editors.ComboItem();
            this.ComboItem7 = new DevComponents.Editors.ComboItem();
            this.ComboItem8 = new DevComponents.Editors.ComboItem();
            this.ComboItem9 = new DevComponents.Editors.ComboItem();
            this.ComboItem11 = new DevComponents.Editors.ComboItem();
            this.ComboItem12 = new DevComponents.Editors.ComboItem();
            this.ComboItem10 = new DevComponents.Editors.ComboItem();
            this.cboRank = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.ComboItem3 = new DevComponents.Editors.ComboItem();
            this.ComboItem4 = new DevComponents.Editors.ComboItem();
            this.ComboItem5 = new DevComponents.Editors.ComboItem();
            this.txtImmediateHead = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtSalary = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtPosition = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCompany = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvEmpHistory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.Save_btn,
            this.Cancel_btn,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(788, 39);
            this.toolStrip2.TabIndex = 510;
            this.toolStrip2.Text = "toolStrip2";
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
            // Cancel_btn
            // 
            this.Cancel_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cancel_btn.Enabled = false;
            this.Cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("Cancel_btn.Image")));
            this.Cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(131, 36);
            this.toolStripLabel2.Text = "Employment History";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.cbostatus);
            this.panel1.Controls.Add(this.cboRank);
            this.panel1.Controls.Add(this.txtImmediateHead);
            this.panel1.Controls.Add(this.Label9);
            this.panel1.Controls.Add(this.Label7);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 114);
            this.panel1.TabIndex = 511;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 152;
            this.label10.Text = "Status:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtTo
            // 
            // 
            // 
            // 
            this.dtTo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtTo.ButtonDropDown.Visible = true;
            this.dtTo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.IsPopupCalendarOpen = false;
            this.dtTo.Location = new System.Drawing.Point(298, 85);
            this.dtTo.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtTo.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTo.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtTo.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtTo.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtTo.MonthCalendar.TodayButtonVisible = true;
            this.dtTo.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(109, 21);
            this.dtTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtTo.TabIndex = 151;
            this.dtTo.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // dtFrom
            // 
            // 
            // 
            // 
            this.dtFrom.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtFrom.ButtonDropDown.Visible = true;
            this.dtFrom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.IsPopupCalendarOpen = false;
            this.dtFrom.Location = new System.Drawing.Point(96, 85);
            this.dtFrom.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtFrom.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtFrom.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtFrom.MonthCalendar.TodayButtonVisible = true;
            this.dtFrom.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShowCheckBox = true;
            this.dtFrom.Size = new System.Drawing.Size(109, 21);
            this.dtFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtFrom.TabIndex = 150;
            this.dtFrom.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // cbostatus
            // 
            this.cbostatus.DisabledBackColor = System.Drawing.Color.White;
            this.cbostatus.DisabledForeColor = System.Drawing.Color.Black;
            this.cbostatus.DisplayMember = "Text";
            this.cbostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.ItemHeight = 15;
            this.cbostatus.Items.AddRange(new object[] {
            this.ComboItem6,
            this.ComboItem7,
            this.ComboItem8,
            this.ComboItem9,
            this.ComboItem11,
            this.ComboItem12,
            this.ComboItem10});
            this.cbostatus.Location = new System.Drawing.Point(515, 85);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(159, 21);
            this.cbostatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbostatus.TabIndex = 149;
            // 
            // ComboItem6
            // 
            this.ComboItem6.Text = "OJT";
            // 
            // ComboItem7
            // 
            this.ComboItem7.Text = "Contractual";
            // 
            // ComboItem8
            // 
            this.ComboItem8.Text = "Fixed term/Project Based";
            // 
            // ComboItem9
            // 
            this.ComboItem9.Text = "Probationary";
            // 
            // ComboItem11
            // 
            this.ComboItem11.Text = "Regular";
            // 
            // ComboItem12
            // 
            this.ComboItem12.Text = "Consultant";
            // 
            // ComboItem10
            // 
            this.ComboItem10.Text = "Unknown";
            // 
            // cboRank
            // 
            this.cboRank.DisabledBackColor = System.Drawing.Color.White;
            this.cboRank.DisabledForeColor = System.Drawing.Color.Black;
            this.cboRank.DisplayMember = "Text";
            this.cboRank.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRank.FormattingEnabled = true;
            this.cboRank.ItemHeight = 15;
            this.cboRank.Items.AddRange(new object[] {
            this.ComboItem1,
            this.ComboItem2,
            this.ComboItem3,
            this.ComboItem4,
            this.ComboItem5});
            this.cboRank.Location = new System.Drawing.Point(670, 33);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(109, 21);
            this.cboRank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboRank.TabIndex = 148;
            // 
            // ComboItem1
            // 
            this.ComboItem1.Text = "Rank & File";
            // 
            // ComboItem2
            // 
            this.ComboItem2.Text = "Officer";
            // 
            // ComboItem3
            // 
            this.ComboItem3.Text = "Supervisory";
            // 
            // ComboItem4
            // 
            this.ComboItem4.Text = "Managerial";
            // 
            // ComboItem5
            // 
            this.ComboItem5.Text = "Unknown";
            // 
            // txtImmediateHead
            // 
            // 
            // 
            // 
            this.txtImmediateHead.Border.Class = "TextBoxBorder";
            this.txtImmediateHead.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImmediateHead.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtImmediateHead.FocusHighlightEnabled = true;
            this.txtImmediateHead.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImmediateHead.Location = new System.Drawing.Point(96, 58);
            this.txtImmediateHead.Name = "txtImmediateHead";
            this.txtImmediateHead.Size = new System.Drawing.Size(311, 21);
            this.txtImmediateHead.TabIndex = 141;
            this.btxMsg.SetText(this.txtImmediateHead, null);
            this.btxMsg.SetTitle(this.txtImmediateHead, null);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(3, 63);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(89, 13);
            this.Label9.TabIndex = 147;
            this.Label9.Text = "Immediate Head:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(269, 88);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(23, 13);
            this.Label7.TabIndex = 146;
            this.Label7.Text = "To:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(56, 88);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(35, 13);
            this.Label8.TabIndex = 145;
            this.Label8.Text = "From:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(629, 37);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 13);
            this.Label6.TabIndex = 144;
            this.Label6.Text = "Rank:";
            // 
            // txtSalary
            // 
            // 
            // 
            // 
            this.txtSalary.Border.Class = "TextBoxBorder";
            this.txtSalary.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSalary.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtSalary.FocusHighlightEnabled = true;
            this.txtSalary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(515, 33);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(110, 21);
            this.txtSalary.TabIndex = 143;
            this.btxMsg.SetText(this.txtSalary, null);
            this.txtSalary.Text = "0";
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtSalary, null);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(469, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 13);
            this.Label5.TabIndex = 142;
            this.Label5.Text = "Salary:";
            // 
            // txtReason
            // 
            // 
            // 
            // 
            this.txtReason.Border.Class = "TextBoxBorder";
            this.txtReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReason.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtReason.FocusHighlightEnabled = true;
            this.txtReason.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(515, 60);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(264, 21);
            this.txtReason.TabIndex = 140;
            this.btxMsg.SetText(this.txtReason, null);
            this.btxMsg.SetTitle(this.txtReason, null);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(413, 65);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 13);
            this.Label4.TabIndex = 139;
            this.Label4.Text = "Reason for leaving:";
            // 
            // txtPosition
            // 
            // 
            // 
            // 
            this.txtPosition.Border.Class = "TextBoxBorder";
            this.txtPosition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPosition.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtPosition.FocusHighlightEnabled = true;
            this.txtPosition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(96, 33);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(311, 21);
            this.txtPosition.TabIndex = 138;
            this.btxMsg.SetText(this.txtPosition, "Position is required.");
            this.btxMsg.SetTitle(this.txtPosition, null);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(44, 38);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 137;
            this.Label3.Text = "Position:";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtAddress.FocusHighlightEnabled = true;
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(515, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 21);
            this.txtAddress.TabIndex = 136;
            this.btxMsg.SetText(this.txtAddress, "Company Address is required");
            this.btxMsg.SetTitle(this.txtAddress, null);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(412, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 13);
            this.Label2.TabIndex = 135;
            this.Label2.Text = "Company Address:";
            // 
            // txtCompany
            // 
            // 
            // 
            // 
            this.txtCompany.Border.Class = "TextBoxBorder";
            this.txtCompany.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompany.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtCompany.FocusHighlightEnabled = true;
            this.txtCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(96, 8);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(311, 21);
            this.txtCompany.TabIndex = 134;
            this.btxMsg.SetText(this.txtCompany, "Company name is required.");
            this.btxMsg.SetTitle(this.txtCompany, null);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(7, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 13);
            this.Label1.TabIndex = 133;
            this.Label1.Text = "Company name:";
            // 
            // dgvEmpHistory
            // 
            this.dgvEmpHistory.AllowUserToAddRows = false;
            this.dgvEmpHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmpHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.Column11,
            this.Column15,
            this.Column16,
            this.Column39});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpHistory.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmpHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpHistory.EnableHeadersVisualStyles = false;
            this.dgvEmpHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEmpHistory.HighlightSelectedColumnHeaders = false;
            this.dgvEmpHistory.Location = new System.Drawing.Point(0, 153);
            this.dgvEmpHistory.Name = "dgvEmpHistory";
            this.dgvEmpHistory.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmpHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpHistory.Size = new System.Drawing.Size(788, 447);
            this.dgvEmpHistory.TabIndex = 512;
            this.dgvEmpHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpHistory_CellClick);
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "Employ_ID";
            this.DataGridViewTextBoxColumn1.HeaderText = "Id";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Visible = false;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Company_name";
            this.DataGridViewTextBoxColumn2.HeaderText = "Company name";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 160;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Company_position";
            this.Column11.HeaderText = "Position";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Company_from";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.Column15.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column15.HeaderText = "From";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Company_to";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.Column16.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column16.HeaderText = "To";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column39
            // 
            this.Column39.DataPropertyName = "Employment_Status";
            this.Column39.HeaderText = "Status";
            this.Column39.Name = "Column39";
            this.Column39.ReadOnly = true;
            // 
            // EmploymentHistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmpHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmploymentHistoryControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmploymentHistoryControl_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton Cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label10;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtTo;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtFrom;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cbostatus;
        internal DevComponents.Editors.ComboItem ComboItem6;
        internal DevComponents.Editors.ComboItem ComboItem7;
        internal DevComponents.Editors.ComboItem ComboItem8;
        internal DevComponents.Editors.ComboItem ComboItem9;
        internal DevComponents.Editors.ComboItem ComboItem11;
        internal DevComponents.Editors.ComboItem ComboItem12;
        internal DevComponents.Editors.ComboItem ComboItem10;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cboRank;
        internal DevComponents.Editors.ComboItem ComboItem1;
        internal DevComponents.Editors.ComboItem ComboItem2;
        internal DevComponents.Editors.ComboItem ComboItem3;
        internal DevComponents.Editors.ComboItem ComboItem4;
        internal DevComponents.Editors.ComboItem ComboItem5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtImmediateHead;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtSalary;
        internal System.Windows.Forms.Label Label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtReason;
        internal System.Windows.Forms.Label Label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPosition;
        internal System.Windows.Forms.Label Label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        internal System.Windows.Forms.Label Label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCompany;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvEmpHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column39;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}
