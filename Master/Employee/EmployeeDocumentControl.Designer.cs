namespace DCLGlobal.Master.Employee
{
    partial class EmployeeDocumentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDocumentControl));
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
            this.cboDocument = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.dtDateIssued = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFileLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDocNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvDocs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateIssued)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
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
            this.toolStrip1.TabIndex = 498;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(138, 36);
            this.toolStripLabel1.Text = "Employee Documents";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboDocument);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.dtDateIssued);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txtFileLocation);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtDocNo);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 62);
            this.panel1.TabIndex = 514;
            // 
            // cboDocument
            // 
            this.cboDocument.DisabledBackColor = System.Drawing.Color.White;
            this.cboDocument.DisabledForeColor = System.Drawing.Color.Black;
            this.cboDocument.DisplayMember = "Text";
            this.cboDocument.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocument.FormattingEnabled = true;
            this.cboDocument.ItemHeight = 15;
            this.cboDocument.Location = new System.Drawing.Point(116, 9);
            this.cboDocument.Name = "cboDocument";
            this.cboDocument.Size = new System.Drawing.Size(397, 21);
            this.cboDocument.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDocument.TabIndex = 137;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(728, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 21);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 136;
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
            this.dtDateIssued.IsPopupCalendarOpen = false;
            this.dtDateIssued.Location = new System.Drawing.Point(116, 34);
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
            this.dtDateIssued.Size = new System.Drawing.Size(149, 21);
            this.dtDateIssued.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtDateIssued.TabIndex = 135;
            this.dtDateIssued.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Location = new System.Drawing.Point(46, 38);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 13);
            this.Label5.TabIndex = 134;
            this.Label5.Text = "Date Issued:";
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFileLocation.Border.Class = "TextBoxBorder";
            this.txtFileLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFileLocation.ForeColor = System.Drawing.Color.Black;
            this.txtFileLocation.Location = new System.Drawing.Point(355, 33);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(368, 21);
            this.txtFileLocation.TabIndex = 133;
            this.btxMsg.SetText(this.txtFileLocation, "Scanned document is required.");
            this.btxMsg.SetTitle(this.txtFileLocation, null);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(282, 37);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 13);
            this.Label3.TabIndex = 132;
            this.Label3.Text = "File Location:";
            // 
            // txtDocNo
            // 
            this.txtDocNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDocNo.Border.Class = "TextBoxBorder";
            this.txtDocNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNo.ForeColor = System.Drawing.Color.Black;
            this.txtDocNo.Location = new System.Drawing.Point(614, 9);
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.Size = new System.Drawing.Size(109, 21);
            this.txtDocNo.TabIndex = 131;
            this.btxMsg.SetText(this.txtDocNo, null);
            this.btxMsg.SetTitle(this.txtDocNo, null);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(532, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 13);
            this.Label2.TabIndex = 130;
            this.Label2.Text = "Document No.:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(25, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 129;
            this.Label1.Text = "Document name:";
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn15,
            this.Column24,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.EnableHeadersVisualStyles = false;
            this.dgvDocs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDocs.HighlightSelectedColumnHeaders = false;
            this.dgvDocs.Location = new System.Drawing.Point(0, 101);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocs.Size = new System.Drawing.Size(788, 499);
            this.dgvDocs.TabIndex = 515;
            this.dgvDocs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellClick);
            this.dgvDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellContentClick);
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.DataPropertyName = "ID";
            this.DataGridViewTextBoxColumn15.HeaderText = "Id";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.ReadOnly = true;
            this.DataGridViewTextBoxColumn15.Visible = false;
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "_open";
            this.Column24.HeaderText = "Open File";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Text = null;
            this.Column24.Width = 80;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "DocName";
            this.Column20.HeaderText = "Document name";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 160;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "DocNo";
            this.Column21.HeaderText = "Document No.";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.DataPropertyName = "DateIssued";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column22.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column22.HeaderText = "Date Issued";
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.DataPropertyName = "Location";
            this.Column23.HeaderText = "Location";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Width = 200;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // EmployeeDocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeDocumentControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmployeeDocumentControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateIssued)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
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
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cboDocument;
        internal DevComponents.DotNetBar.ButtonX btnBrowse;
        internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtDateIssued;
        internal System.Windows.Forms.Label Label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFileLocation;
        internal System.Windows.Forms.Label Label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDocNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        internal System.Windows.Forms.OpenFileDialog OFD1;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}
