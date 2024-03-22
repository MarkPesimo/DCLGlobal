namespace DCLGlobal.Master.Main.Employee
{
    partial class EmployeeShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeShift));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.panEmployee = new System.Windows.Forms.Panel();
            this.lsvEmployee = new System.Windows.Forms.ListView();
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.panDetails = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lstShiftList = new System.Windows.Forms.ListView();
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbSecondShift = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbFirstShift = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.dtEffectivedate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmbShiftRule = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Label1 = new System.Windows.Forms.Label();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStrip1.SuspendLayout();
            this.panEmployee.SuspendLayout();
            this.panDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEffectivedate)).BeginInit();
            this.ToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.BackColor = System.Drawing.Color.Gray;
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(931, 39);
            this.ToolStrip1.TabIndex = 554;
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
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.Text = "Print";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(300, 39);
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
            // panEmployee
            // 
            this.panEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEmployee.Controls.Add(this.lsvEmployee);
            this.panEmployee.Controls.Add(this.txtSearch);
            this.panEmployee.Controls.Add(this.Label8);
            this.panEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.panEmployee.Location = new System.Drawing.Point(0, 39);
            this.panEmployee.Name = "panEmployee";
            this.panEmployee.Size = new System.Drawing.Size(242, 553);
            this.panEmployee.TabIndex = 555;
            // 
            // lsvEmployee
            // 
            this.lsvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader13,
            this.ColumnHeader14});
            this.lsvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEmployee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvEmployee.FullRowSelect = true;
            this.lsvEmployee.GridLines = true;
            this.lsvEmployee.Location = new System.Drawing.Point(0, 0);
            this.lsvEmployee.Name = "lsvEmployee";
            this.lsvEmployee.Size = new System.Drawing.Size(240, 551);
            this.lsvEmployee.TabIndex = 3;
            this.lsvEmployee.UseCompatibleStateImageBehavior = false;
            this.lsvEmployee.View = System.Windows.Forms.View.Details;
            this.lsvEmployee.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvEmployee_ItemSelectionChanged);
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = "EmpID";
            this.ColumnHeader13.Width = 0;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = "Employee Name";
            this.ColumnHeader14.Width = 280;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 21);
            this.txtSearch.TabIndex = 1;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(7, 9);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(218, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "(Search: Lastname or Firstname then Enter)";
            // 
            // panDetails
            // 
            this.panDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDetails.Controls.Add(this.lblEmployeeName);
            this.panDetails.Controls.Add(this.lstShiftList);
            this.panDetails.Controls.Add(this.txtRemarks);
            this.panDetails.Controls.Add(this.cmbSecondShift);
            this.panDetails.Controls.Add(this.cmbFirstShift);
            this.panDetails.Controls.Add(this.Label5);
            this.panDetails.Controls.Add(this.Label4);
            this.panDetails.Controls.Add(this.dtEffectivedate);
            this.panDetails.Controls.Add(this.Label3);
            this.panDetails.Controls.Add(this.Label2);
            this.panDetails.Controls.Add(this.cmbShiftRule);
            this.panDetails.Controls.Add(this.Label1);
            this.panDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDetails.Location = new System.Drawing.Point(242, 39);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(689, 528);
            this.panDetails.TabIndex = 556;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(13, 6);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 13);
            this.lblEmployeeName.TabIndex = 31;
            // 
            // lstShiftList
            // 
            this.lstShiftList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader1});
            this.lstShiftList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstShiftList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstShiftList.FullRowSelect = true;
            this.lstShiftList.GridLines = true;
            this.lstShiftList.Location = new System.Drawing.Point(0, 193);
            this.lstShiftList.Name = "lstShiftList";
            this.lstShiftList.ShowItemToolTips = true;
            this.lstShiftList.Size = new System.Drawing.Size(687, 333);
            this.lstShiftList.TabIndex = 30;
            this.lstShiftList.UseCompatibleStateImageBehavior = false;
            this.lstShiftList.View = System.Windows.Forms.View.Details;
            this.lstShiftList.SelectedIndexChanged += new System.EventHandler(this.lstShiftList_SelectedIndexChanged);
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "id";
            this.ColumnHeader3.Width = 0;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Shifting Rule";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 140;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Effective Date";
            this.ColumnHeader5.Width = 90;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "First Shift";
            this.ColumnHeader6.Width = 120;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Next Shift";
            this.ColumnHeader7.Width = 120;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Remarks";
            this.ColumnHeader8.Width = 150;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Status";
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.Border.Class = "TextBoxBorder";
            this.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemarks.Location = new System.Drawing.Point(106, 130);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(247, 54);
            this.txtRemarks.TabIndex = 24;
            // 
            // cmbSecondShift
            // 
            this.cmbSecondShift.DisplayMember = "Text";
            this.cmbSecondShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSecondShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecondShift.Enabled = false;
            this.cmbSecondShift.FormattingEnabled = true;
            this.cmbSecondShift.ItemHeight = 15;
            this.cmbSecondShift.Location = new System.Drawing.Point(106, 106);
            this.cmbSecondShift.Name = "cmbSecondShift";
            this.cmbSecondShift.Size = new System.Drawing.Size(247, 21);
            this.cmbSecondShift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSecondShift.TabIndex = 23;
            // 
            // cmbFirstShift
            // 
            this.cmbFirstShift.DisplayMember = "Text";
            this.cmbFirstShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFirstShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFirstShift.Enabled = false;
            this.cmbFirstShift.FormattingEnabled = true;
            this.cmbFirstShift.ItemHeight = 15;
            this.cmbFirstShift.Location = new System.Drawing.Point(106, 82);
            this.cmbFirstShift.Name = "cmbFirstShift";
            this.cmbFirstShift.Size = new System.Drawing.Size(247, 21);
            this.cmbFirstShift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbFirstShift.TabIndex = 22;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(42, 133);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(52, 13);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Remarks:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(34, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 13);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Next Shift:";
            // 
            // dtEffectivedate
            // 
            // 
            // 
            // 
            this.dtEffectivedate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtEffectivedate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEffectivedate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtEffectivedate.ButtonDropDown.Visible = true;
            this.dtEffectivedate.Enabled = false;
            this.dtEffectivedate.IsPopupCalendarOpen = false;
            this.dtEffectivedate.Location = new System.Drawing.Point(106, 58);
            // 
            // 
            // 
            this.dtEffectivedate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEffectivedate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtEffectivedate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEffectivedate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtEffectivedate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEffectivedate.MonthCalendar.DisplayMonth = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtEffectivedate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtEffectivedate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtEffectivedate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtEffectivedate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtEffectivedate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtEffectivedate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtEffectivedate.MonthCalendar.TodayButtonVisible = true;
            this.dtEffectivedate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtEffectivedate.Name = "dtEffectivedate";
            this.dtEffectivedate.Size = new System.Drawing.Size(247, 21);
            this.dtEffectivedate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtEffectivedate.TabIndex = 19;
            this.dtEffectivedate.Value = new System.DateTime(2013, 5, 8, 9, 48, 53, 0);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(36, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(57, 13);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "First Shift:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Effective Date:";
            // 
            // cmbShiftRule
            // 
            this.cmbShiftRule.DisplayMember = "Text";
            this.cmbShiftRule.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbShiftRule.Enabled = false;
            this.cmbShiftRule.FormattingEnabled = true;
            this.cmbShiftRule.ItemHeight = 15;
            this.cmbShiftRule.Location = new System.Drawing.Point(106, 33);
            this.cmbShiftRule.Name = "cmbShiftRule";
            this.cmbShiftRule.Size = new System.Drawing.Size(247, 21);
            this.cmbShiftRule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbShiftRule.TabIndex = 16;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Shifting Rule:";
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.AllowItemReorder = true;
            this.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1});
            this.ToolStrip2.Location = new System.Drawing.Point(242, 567);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(689, 25);
            this.ToolStrip2.TabIndex = 557;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Navy;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(159, 22);
            this.ToolStripButton1.Text = "F2 - Activate/Deactivate Status";
            // 
            // EmployeeShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 592);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.panEmployee);
            this.Controls.Add(this.ToolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EmployeeShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee\'s Shifting Schedule";
            this.Load += new System.EventHandler(this.EmployeeShift_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeShift_KeyDown);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.panEmployee.ResumeLayout(false);
            this.panEmployee.PerformLayout();
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEffectivedate)).EndInit();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal System.Windows.Forms.Panel panEmployee;
        internal System.Windows.Forms.ListView lsvEmployee;
        internal System.Windows.Forms.ColumnHeader ColumnHeader13;
        internal System.Windows.Forms.ColumnHeader ColumnHeader14;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Panel panDetails;
        internal System.Windows.Forms.Label lblEmployeeName;
        internal System.Windows.Forms.ListView lstShiftList;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader7;
        internal System.Windows.Forms.ColumnHeader ColumnHeader8;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbSecondShift;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbFirstShift;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtEffectivedate;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbShiftRule;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripLabel ToolStripButton1;
    }
}