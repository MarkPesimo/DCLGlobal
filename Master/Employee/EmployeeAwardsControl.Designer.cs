namespace DCLGlobal.Master.Employee
{
    partial class EmployeeAwardsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAwardsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.txtFileLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboAwards = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtDateIssue = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.dgvAwards = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewButtonXColumn16 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.DataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).BeginInit();
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
            this.toolStrip1.TabIndex = 499;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 36);
            this.toolStripLabel1.Text = "Employee Awards";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtFileLocation);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.cboAwards);
            this.panel1.Controls.Add(this.dtDateIssue);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 83);
            this.panel1.TabIndex = 515;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(716, 53);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 21);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 3;
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
            this.txtFileLocation.Location = new System.Drawing.Point(104, 54);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(606, 21);
            this.txtFileLocation.TabIndex = 4;
            this.btxMsg.SetText(this.txtFileLocation, "Award scanned document is required.");
            this.btxMsg.SetTitle(this.txtFileLocation, null);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(30, 57);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 138;
            this.Label1.Text = "File Location:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(55, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 137;
            this.Label4.Text = "Awards:";
            // 
            // cboAwards
            // 
            this.cboAwards.DisabledBackColor = System.Drawing.Color.White;
            this.cboAwards.DisabledForeColor = System.Drawing.Color.Black;
            this.cboAwards.DisplayMember = "Text";
            this.cboAwards.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAwards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwards.FormattingEnabled = true;
            this.cboAwards.ItemHeight = 15;
            this.cboAwards.Location = new System.Drawing.Point(104, 6);
            this.cboAwards.Name = "cboAwards";
            this.cboAwards.Size = new System.Drawing.Size(347, 21);
            this.cboAwards.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboAwards.TabIndex = 0;
            // 
            // dtDateIssue
            // 
            // 
            // 
            // 
            this.dtDateIssue.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDateIssue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssue.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtDateIssue.ButtonDropDown.Visible = true;
            this.dtDateIssue.IsPopupCalendarOpen = false;
            this.dtDateIssue.Location = new System.Drawing.Point(561, 7);
            this.dtDateIssue.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtDateIssue.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateIssue.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtDateIssue.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssue.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDateIssue.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssue.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtDateIssue.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDateIssue.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDateIssue.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDateIssue.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDateIssue.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDateIssue.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtDateIssue.MonthCalendar.TodayButtonVisible = true;
            this.dtDateIssue.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtDateIssue.Name = "dtDateIssue";
            this.dtDateIssue.ShowCheckBox = true;
            this.dtDateIssue.Size = new System.Drawing.Size(149, 21);
            this.dtDateIssue.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateIssue.TabIndex = 1;
            this.dtDateIssue.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(489, 11);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 13);
            this.Label5.TabIndex = 134;
            this.Label5.Text = "Date Issued:";
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
            this.txtRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRemarks.Location = new System.Drawing.Point(104, 30);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(606, 21);
            this.txtRemarks.TabIndex = 2;
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(48, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 132;
            this.Label3.Text = "Remarks:";
            // 
            // dgvAwards
            // 
            this.dgvAwards.AllowUserToAddRows = false;
            this.dgvAwards.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewButtonXColumn16,
            this.DataGridViewTextBoxColumn24,
            this.DataGridViewTextBoxColumn25,
            this.DataGridViewTextBoxColumn26,
            this.DataGridViewTextBoxColumn27});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAwards.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAwards.EnableHeadersVisualStyles = false;
            this.dgvAwards.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAwards.HighlightSelectedColumnHeaders = false;
            this.dgvAwards.Location = new System.Drawing.Point(0, 122);
            this.dgvAwards.Name = "dgvAwards";
            this.dgvAwards.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwards.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAwards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAwards.Size = new System.Drawing.Size(788, 478);
            this.dgvAwards.TabIndex = 516;
            this.dgvAwards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwards_CellClick);
            this.dgvAwards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwards_CellContentClick);
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.DataGridViewTextBoxColumn4.HeaderText = "Id";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Visible = false;
            // 
            // DataGridViewButtonXColumn16
            // 
            this.DataGridViewButtonXColumn16.DataPropertyName = "_open";
            this.DataGridViewButtonXColumn16.HeaderText = "Open File";
            this.DataGridViewButtonXColumn16.Name = "DataGridViewButtonXColumn16";
            this.DataGridViewButtonXColumn16.ReadOnly = true;
            this.DataGridViewButtonXColumn16.Text = null;
            this.DataGridViewButtonXColumn16.Width = 80;
            // 
            // DataGridViewTextBoxColumn24
            // 
            this.DataGridViewTextBoxColumn24.DataPropertyName = "awards";
            this.DataGridViewTextBoxColumn24.HeaderText = "Award name";
            this.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24";
            this.DataGridViewTextBoxColumn24.ReadOnly = true;
            this.DataGridViewTextBoxColumn24.Width = 160;
            // 
            // DataGridViewTextBoxColumn25
            // 
            this.DataGridViewTextBoxColumn25.DataPropertyName = "dateissued";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTextBoxColumn25.HeaderText = "Date Issued";
            this.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25";
            this.DataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn26
            // 
            this.DataGridViewTextBoxColumn26.DataPropertyName = "remarks";
            this.DataGridViewTextBoxColumn26.HeaderText = "Remarks";
            this.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26";
            this.DataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn27
            // 
            this.DataGridViewTextBoxColumn27.DataPropertyName = "Location";
            this.DataGridViewTextBoxColumn27.HeaderText = "Location";
            this.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27";
            this.DataGridViewTextBoxColumn27.ReadOnly = true;
            this.DataGridViewTextBoxColumn27.Width = 200;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // EmployeeAwardsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAwards);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeAwardsControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmployeeAwardsControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).EndInit();
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
        private DevComponents.DotNetBar.ButtonX btnBrowse;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFileLocation;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboAwards;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateIssue;
        internal System.Windows.Forms.Label Label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal System.Windows.Forms.Label Label3;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DataGridViewButtonXColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn27;
        internal System.Windows.Forms.OpenFileDialog OFD1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}
