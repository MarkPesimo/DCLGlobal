namespace DCLGlobal.Master.Employee
{
    partial class FamilyControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyControl));
            this.dgvFamily = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label4 = new System.Windows.Forms.Label();
            this.cboRelation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dtbday = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtcontactno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.Cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbday)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFamily
            // 
            this.dgvFamily.AllowUserToAddRows = false;
            this.dgvFamily.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn17});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFamily.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFamily.EnableHeadersVisualStyles = false;
            this.dgvFamily.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFamily.HighlightSelectedColumnHeaders = false;
            this.dgvFamily.Location = new System.Drawing.Point(0, 99);
            this.dgvFamily.Name = "dgvFamily";
            this.dgvFamily.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamily.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFamily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFamily.Size = new System.Drawing.Size(788, 501);
            this.dgvFamily.TabIndex = 497;
            this.dgvFamily.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamily_CellClick);
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.DataPropertyName = "relid";
            this.DataGridViewTextBoxColumn5.HeaderText = "Id";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Visible = false;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.DataGridViewTextBoxColumn6.HeaderText = "Name";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            this.DataGridViewTextBoxColumn6.Width = 160;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.DataPropertyName = "Relation";
            this.DataGridViewTextBoxColumn7.HeaderText = "Relation";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            this.DataGridViewTextBoxColumn7.Width = 150;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.DataPropertyName = "birthday";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTextBoxColumn16.HeaderText = "Birthday";
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            this.DataGridViewTextBoxColumn16.ReadOnly = true;
            this.DataGridViewTextBoxColumn16.Width = 150;
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.DataPropertyName = "contactno";
            this.DataGridViewTextBoxColumn17.HeaderText = "Contact no.";
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            this.DataGridViewTextBoxColumn17.ReadOnly = true;
            this.DataGridViewTextBoxColumn17.Width = 180;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(492, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 13);
            this.Label4.TabIndex = 505;
            this.Label4.Text = "Relation:";
            // 
            // cboRelation
            // 
            this.cboRelation.DisabledBackColor = System.Drawing.Color.White;
            this.cboRelation.DisabledForeColor = System.Drawing.Color.Black;
            this.cboRelation.DisplayMember = "Text";
            this.cboRelation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRelation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRelation.FormattingEnabled = true;
            this.cboRelation.ItemHeight = 15;
            this.cboRelation.Location = new System.Drawing.Point(544, 6);
            this.cboRelation.Name = "cboRelation";
            this.cboRelation.Size = new System.Drawing.Size(222, 21);
            this.cboRelation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboRelation.TabIndex = 504;
            // 
            // dtbday
            // 
            // 
            // 
            // 
            this.dtbday.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtbday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtbday.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtbday.ButtonDropDown.Visible = true;
            this.dtbday.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbday.IsPopupCalendarOpen = false;
            this.dtbday.Location = new System.Drawing.Point(95, 32);
            this.dtbday.LockUpdateChecked = false;
            // 
            // 
            // 
            this.dtbday.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtbday.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtbday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtbday.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtbday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtbday.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtbday.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtbday.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtbday.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtbday.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtbday.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtbday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtbday.MonthCalendar.TodayButtonVisible = true;
            this.dtbday.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtbday.Name = "dtbday";
            this.dtbday.ShowCheckBox = true;
            this.dtbday.Size = new System.Drawing.Size(149, 21);
            this.dtbday.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtbday.TabIndex = 503;
            this.dtbday.Value = new System.DateTime(2012, 10, 9, 9, 52, 9, 0);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(42, 36);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 13);
            this.Label5.TabIndex = 502;
            this.Label5.Text = "Birthday:";
            // 
            // txtcontactno
            // 
            this.txtcontactno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcontactno.Border.Class = "TextBoxBorder";
            this.txtcontactno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcontactno.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtcontactno.FocusHighlightEnabled = true;
            this.txtcontactno.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcontactno.Location = new System.Drawing.Point(544, 32);
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(222, 21);
            this.txtcontactno.TabIndex = 501;
            this.btxMsg.SetText(this.txtcontactno, null);
            this.btxMsg.SetTitle(this.txtcontactno, null);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(473, 36);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 13);
            this.Label3.TabIndex = 500;
            this.Label3.Text = "Contact No.:";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtname.FocusHighlightEnabled = true;
            this.txtname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtname.Location = new System.Drawing.Point(95, 6);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(347, 21);
            this.txtname.TabIndex = 499;
            this.btxMsg.SetText(this.txtname, "Family member\'s name is required.");
            this.btxMsg.SetTitle(this.txtname, null);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(51, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 498;
            this.Label1.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.cboRelation);
            this.panel1.Controls.Add(this.dtbday);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txtcontactno);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 60);
            this.panel1.TabIndex = 506;
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
            this.toolStrip2.TabIndex = 507;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(103, 36);
            this.toolStripLabel2.Text = "Family Members";
            // 
            // FamilyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFamily);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FamilyControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.FamilyControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbday)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvFamily;
        internal System.Windows.Forms.Label Label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboRelation;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtbday;
        internal System.Windows.Forms.Label Label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcontactno;
        internal System.Windows.Forms.Label Label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton Cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}
