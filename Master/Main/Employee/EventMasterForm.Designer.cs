namespace DCLGlobal.Master.Main.Employee
{
    partial class EventMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventMasterForm));
            this.label2 = new System.Windows.Forms.Label();
            this.cboAttendees = new System.Windows.Forms.ComboBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtHolidayDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dateto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lsvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.lstEmployee = new System.Windows.Forms.ListView();
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panDetails = new System.Windows.Forms.Panel();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.cbofrom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.pan_Search.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            this.ExpandablePanel1.SuspendLayout();
            this.panDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 586;
            this.label2.Text = "Type of Attendees:";
            // 
            // cboAttendees
            // 
            this.cboAttendees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAttendees.Enabled = false;
            this.cboAttendees.FormattingEnabled = true;
            this.cboAttendees.Items.AddRange(new object[] {
            "",
            "ALL",
            "PER EMPLOYEE"});
            this.cboAttendees.Location = new System.Drawing.Point(282, 93);
            this.cboAttendees.Name = "cboAttendees";
            this.cboAttendees.Size = new System.Drawing.Size(177, 21);
            this.cboAttendees.TabIndex = 584;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(283, 42);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(232, 21);
            this.dtpDateFrom.TabIndex = 583;
            // 
            // txtHolidayDesc
            // 
            this.txtHolidayDesc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHolidayDesc.Border.Class = "TextBoxBorder";
            this.txtHolidayDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHolidayDesc.FocusHighlightEnabled = true;
            this.txtHolidayDesc.ForeColor = System.Drawing.Color.Black;
            this.txtHolidayDesc.Location = new System.Drawing.Point(282, 17);
            this.txtHolidayDesc.Name = "txtHolidayDesc";
            this.txtHolidayDesc.ReadOnly = true;
            this.txtHolidayDesc.Size = new System.Drawing.Size(316, 21);
            this.txtHolidayDesc.TabIndex = 578;
            this.txtHolidayDesc.Tag = "0";
            this.btxMsg.SetText(this.txtHolidayDesc, "Employee rank cannot be blank");
            this.btxMsg.SetTitle(this.txtHolidayDesc, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 580;
            this.pictureBox1.TabStop = false;
            // 
            // Dateto
            // 
            this.Dateto.Text = "Date To";
            this.Dateto.Width = 100;
            // 
            // DateFrom
            // 
            this.DateFrom.Text = "Date From";
            this.DateFrom.Width = 100;
            // 
            // EventDesc
            // 
            this.EventDesc.Text = "Event Description";
            this.EventDesc.Width = 250;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 585;
            this.label1.Text = "Event Date From:";
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.EventDesc,
            this.DateFrom,
            this.Dateto,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(607, 244);
            this.lsvList.TabIndex = 1;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type of Attendees";
            this.columnHeader1.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 581;
            this.label4.Text = "Event Description:";
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
            this.ToolStrip1.Size = new System.Drawing.Size(815, 39);
            this.ToolStrip1.TabIndex = 582;
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
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Controls.Add(this.ToolStrip2);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 209);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(607, 269);
            this.pan_Search.TabIndex = 579;
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.AllowItemReorder = true;
            this.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 244);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(607, 25);
            this.ToolStrip2.TabIndex = 592;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(115, 22);
            this.ToolStripLabel1.Text = "F2 - Add Attendees";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(283, 67);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(232, 21);
            this.dtpDateTo.TabIndex = 587;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 588;
            this.label3.Text = "Event Date To:";
            // 
            // ExpandablePanel1
            // 
            this.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.LeftToRight;
            this.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExpandablePanel1.Controls.Add(this.lstEmployee);
            this.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExpandablePanel1.ExpandButtonVisible = false;
            this.ExpandablePanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandablePanel1.HideControlsWhenCollapsed = true;
            this.ExpandablePanel1.Location = new System.Drawing.Point(607, 39);
            this.ExpandablePanel1.Name = "ExpandablePanel1";
            this.ExpandablePanel1.Size = new System.Drawing.Size(208, 439);
            this.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ExpandablePanel1.Style.GradientAngle = 90;
            this.ExpandablePanel1.TabIndex = 589;
            this.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ExpandablePanel1.TitleStyle.GradientAngle = 90;
            this.ExpandablePanel1.TitleText = "List of Attendees";
            // 
            // lstEmployee
            // 
            this.lstEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader4,
            this.ColumnHeader6,
            this.ColumnHeader5});
            this.lstEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEmployee.FullRowSelect = true;
            this.lstEmployee.GridLines = true;
            this.lstEmployee.Location = new System.Drawing.Point(0, 26);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(208, 413);
            this.lstEmployee.TabIndex = 0;
            this.lstEmployee.UseCompatibleStateImageBehavior = false;
            this.lstEmployee.View = System.Windows.Forms.View.Details;
            this.lstEmployee.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "ID";
            this.ColumnHeader4.Width = 0;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "EmpID";
            this.ColumnHeader6.Width = 0;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Employee Name";
            this.ColumnHeader5.Width = 230;
            // 
            // panDetails
            // 
            this.panDetails.BackColor = System.Drawing.SystemColors.Control;
            this.panDetails.Controls.Add(this.cboTo);
            this.panDetails.Controls.Add(this.cbofrom);
            this.panDetails.Controls.Add(this.pictureBox1);
            this.panDetails.Controls.Add(this.txtHolidayDesc);
            this.panDetails.Controls.Add(this.label4);
            this.panDetails.Controls.Add(this.dtpDateTo);
            this.panDetails.Controls.Add(this.label1);
            this.panDetails.Controls.Add(this.label3);
            this.panDetails.Controls.Add(this.dtpDateFrom);
            this.panDetails.Controls.Add(this.label2);
            this.panDetails.Controls.Add(this.cboAttendees);
            this.panDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDetails.Location = new System.Drawing.Point(0, 39);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(607, 439);
            this.panDetails.TabIndex = 590;
            // 
            // cboTo
            // 
            this.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTo.Enabled = false;
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Items.AddRange(new object[] {
            "",
            "AM",
            "PM"});
            this.cboTo.Location = new System.Drawing.Point(520, 67);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(77, 21);
            this.cboTo.TabIndex = 590;
            // 
            // cbofrom
            // 
            this.cbofrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofrom.Enabled = false;
            this.cbofrom.FormattingEnabled = true;
            this.cbofrom.Items.AddRange(new object[] {
            "",
            "AM",
            "PM"});
            this.cbofrom.Location = new System.Drawing.Point(520, 42);
            this.cbofrom.Name = "cbofrom";
            this.cbofrom.Size = new System.Drawing.Size(77, 21);
            this.cbofrom.TabIndex = 589;
            // 
            // EventMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 478);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.ExpandablePanel1);
            this.Controls.Add(this.ToolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "EventMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Master File";
            this.Load += new System.EventHandler(this.EventMasterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EventMasterform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.pan_Search.ResumeLayout(false);
            this.pan_Search.PerformLayout();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.ExpandablePanel1.ResumeLayout(false);
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAttendees;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtHolidayDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Dateto;
        private System.Windows.Forms.ColumnHeader DateFrom;
        internal System.Windows.Forms.ColumnHeader EventDesc;
        internal System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton Save_btn;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal System.Windows.Forms.Panel pan_Search;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.ExpandablePanel ExpandablePanel1;
        internal System.Windows.Forms.ListView lstEmployee;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ComboBox cboTo;
        internal System.Windows.Forms.ComboBox cbofrom;
    }
}