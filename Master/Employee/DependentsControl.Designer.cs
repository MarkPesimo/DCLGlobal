namespace DCLGlobal.Master.Employee
{
    partial class DependentsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DependentsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.Cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYearlevel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtBDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtOccupation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbRelation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem3 = new DevComponents.Editors.ComboItem();
            this.ComboItem4 = new DevComponents.Editors.ComboItem();
            this.ComboItem5 = new DevComponents.Editors.ComboItem();
            this.ComboItem6 = new DevComponents.Editors.ComboItem();
            this.ComboItem7 = new DevComponents.Editors.ComboItem();
            this.ComboItem8 = new DevComponents.Editors.ComboItem();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmbGender = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.txtDependent = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvDependent = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependent)).BeginInit();
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
            this.toolStrip2.TabIndex = 508;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(81, 36);
            this.toolStripLabel2.Text = "Dependents";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtYearlevel);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.dtBDate);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.txtOccupation);
            this.panel1.Controls.Add(this.cmbRelation);
            this.panel1.Controls.Add(this.Label9);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.txtDependent);
            this.panel1.Controls.Add(this.Label8);
            this.panel1.Controls.Add(this.Label6);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 147);
            this.panel1.TabIndex = 509;
            // 
            // txtYearlevel
            // 
            // 
            // 
            // 
            this.txtYearlevel.Border.Class = "TextBoxBorder";
            this.txtYearlevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtYearlevel.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtYearlevel.FocusHighlightEnabled = true;
            this.txtYearlevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearlevel.Location = new System.Drawing.Point(165, 79);
            this.txtYearlevel.Name = "txtYearlevel";
            this.txtYearlevel.Size = new System.Drawing.Size(536, 21);
            this.txtYearlevel.TabIndex = 5;
            this.btxMsg.SetText(this.txtYearlevel, null);
            this.btxMsg.SetTitle(this.txtYearlevel, null);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(59, 83);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 13);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Year level/Position:";
            // 
            // dtBDate
            // 
            // 
            // 
            // 
            this.dtBDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtBDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtBDate.ButtonDropDown.Visible = true;
            this.dtBDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBDate.IsPopupCalendarOpen = false;
            this.dtBDate.Location = new System.Drawing.Point(580, 31);
            this.dtBDate.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtBDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtBDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtBDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtBDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtBDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtBDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtBDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtBDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtBDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtBDate.MonthCalendar.TodayButtonVisible = true;
            this.dtBDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtBDate.Name = "dtBDate";
            this.dtBDate.ShowCheckBox = true;
            this.dtBDate.Size = new System.Drawing.Size(121, 21);
            this.dtBDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtBDate.TabIndex = 3;
            this.dtBDate.Value = new System.DateTime(2015, 11, 17, 9, 48, 48, 0);
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
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(165, 102);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(536, 37);
            this.txtRemarks.TabIndex = 6;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // txtOccupation
            // 
            // 
            // 
            // 
            this.txtOccupation.Border.Class = "TextBoxBorder";
            this.txtOccupation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOccupation.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtOccupation.FocusHighlightEnabled = true;
            this.txtOccupation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupation.Location = new System.Drawing.Point(165, 56);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(536, 21);
            this.txtOccupation.TabIndex = 4;
            this.btxMsg.SetText(this.txtOccupation, null);
            this.btxMsg.SetTitle(this.txtOccupation, null);
            // 
            // cmbRelation
            // 
            this.cmbRelation.DisplayMember = "Text";
            this.cmbRelation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRelation.FormattingEnabled = true;
            this.cmbRelation.ItemHeight = 15;
            this.cmbRelation.Items.AddRange(new object[] {
            this.ComboItem3,
            this.ComboItem4,
            this.ComboItem5,
            this.ComboItem6,
            this.ComboItem7,
            this.ComboItem8});
            this.cmbRelation.Location = new System.Drawing.Point(371, 31);
            this.cmbRelation.Name = "cmbRelation";
            this.cmbRelation.Size = new System.Drawing.Size(121, 21);
            this.cmbRelation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbRelation.TabIndex = 2;
            // 
            // ComboItem3
            // 
            this.ComboItem3.Text = "Son";
            // 
            // ComboItem4
            // 
            this.ComboItem4.Text = "Daughter";
            // 
            // ComboItem5
            // 
            this.ComboItem5.Text = "Mother";
            // 
            // ComboItem6
            // 
            this.ComboItem6.Text = "Father";
            // 
            // ComboItem7
            // 
            this.ComboItem7.Text = "Brother";
            // 
            // ComboItem8
            // 
            this.ComboItem8.Text = "Sister";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(311, 35);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(50, 13);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Relation:";
            // 
            // cmbGender
            // 
            this.cmbGender.DisplayMember = "Text";
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 15;
            this.cmbGender.Items.AddRange(new object[] {
            this.ComboItem1,
            this.ComboItem2});
            this.cmbGender.Location = new System.Drawing.Point(165, 31);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbGender.TabIndex = 1;
            // 
            // ComboItem1
            // 
            this.ComboItem1.Text = "Male";
            // 
            // ComboItem2
            // 
            this.ComboItem2.Text = "Female";
            // 
            // txtDependent
            // 
            // 
            // 
            // 
            this.txtDependent.Border.Class = "TextBoxBorder";
            this.txtDependent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDependent.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtDependent.FocusHighlightEnabled = true;
            this.txtDependent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependent.Location = new System.Drawing.Point(165, 7);
            this.txtDependent.Name = "txtDependent";
            this.txtDependent.Size = new System.Drawing.Size(536, 21);
            this.txtDependent.TabIndex = 0;
            this.btxMsg.SetText(this.txtDependent, "Dependent name is required.");
            this.btxMsg.SetTitle(this.txtDependent, null);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(106, 106);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(52, 13);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Remarks:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(55, 59);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 13);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "Occupation/School:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(113, 34);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 13);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Gender:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(515, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Birth date:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(66, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Dependent name:";
            // 
            // dgvDependent
            // 
            this.dgvDependent.AllowUserToAddRows = false;
            this.dgvDependent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDependent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDependent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDependent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13,
            this.DataGridViewTextBoxColumn14,
            this.Column27});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDependent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDependent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDependent.EnableHeadersVisualStyles = false;
            this.dgvDependent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDependent.HighlightSelectedColumnHeaders = false;
            this.dgvDependent.Location = new System.Drawing.Point(0, 186);
            this.dgvDependent.Name = "dgvDependent";
            this.dgvDependent.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDependent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDependent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDependent.Size = new System.Drawing.Size(788, 414);
            this.dgvDependent.TabIndex = 510;
            this.dgvDependent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDependent_CellClick);
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.DataPropertyName = "Child_ID";
            this.DataGridViewTextBoxColumn8.HeaderText = "Id";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            this.DataGridViewTextBoxColumn8.ReadOnly = true;
            this.DataGridViewTextBoxColumn8.Visible = false;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.DataPropertyName = "Child_name";
            this.DataGridViewTextBoxColumn9.HeaderText = "Dependent name";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.ReadOnly = true;
            this.DataGridViewTextBoxColumn9.Width = 130;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.DataPropertyName = "Child_Bday";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTextBoxColumn10.HeaderText = "Date of Birth";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.DataPropertyName = "Child_Gender";
            this.DataGridViewTextBoxColumn11.HeaderText = "Gender";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.DataPropertyName = "Child_Age";
            this.DataGridViewTextBoxColumn12.HeaderText = "Age";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly = true;
            this.DataGridViewTextBoxColumn12.Width = 80;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.DataPropertyName = "Child_Relation";
            this.DataGridViewTextBoxColumn13.HeaderText = "Relation";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.DataPropertyName = "Occupation";
            this.DataGridViewTextBoxColumn14.HeaderText = "Occupation";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            this.DataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "Yearlevel";
            this.Column27.HeaderText = "Year Level";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            // 
            // DependentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDependent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DependentsControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.DependentsControl_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDependent)).EndInit();
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
        private DevComponents.DotNetBar.Controls.TextBoxX txtYearlevel;
        internal System.Windows.Forms.Label Label3;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtBDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOccupation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbRelation;
        internal DevComponents.Editors.ComboItem ComboItem3;
        internal DevComponents.Editors.ComboItem ComboItem4;
        internal DevComponents.Editors.ComboItem ComboItem5;
        internal DevComponents.Editors.ComboItem ComboItem6;
        internal DevComponents.Editors.ComboItem ComboItem7;
        internal DevComponents.Editors.ComboItem ComboItem8;
        internal System.Windows.Forms.Label Label9;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGender;
        internal DevComponents.Editors.ComboItem ComboItem1;
        internal DevComponents.Editors.ComboItem ComboItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDependent;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvDependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}
