namespace DCLGlobal.Master.Employee
{
    partial class EmployeeAdjustmentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAdjustmentControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.Cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Print_btn = new System.Windows.Forms.ToolStripButton();
            this.dgvAdjustment = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonXColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDateTimeInputColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dataGridViewCheckBoxXColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.dataGridViewCheckBoxXColumn2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdjustment = new System.Windows.Forms.Panel();
            this.txtremarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkstatus = new System.Windows.Forms.CheckBox();
            this.chktaxable = new System.Windows.Forms.CheckBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cmbadjustment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.nudamount = new DevComponents.Editors.DoubleInput();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustment)).BeginInit();
            this.panelAdjustment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudamount)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.Save_btn,
            this.Cancel_btn,
            this.toolStripLabel2,
            this.Print_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1182, 39);
            this.toolStrip2.TabIndex = 512;
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
            this.Add_btn.Text = "Edit Record";
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
            this.Edit_btn.Text = "toolStripButton1";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.Image")));
            this.Save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(36, 36);
            this.Save_btn.Text = "toolStripButton1";
            this.Save_btn.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(115, 36);
            this.toolStripLabel2.Text = "Adjustment";
            // 
            // Print_btn
            // 
            this.Print_btn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Print_btn.Image = ((System.Drawing.Image)(resources.GetObject("Print_btn.Image")));
            this.Print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(36, 36);
            this.Print_btn.Text = "Save Record";
            this.Print_btn.Visible = false;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // dgvAdjustment
            // 
            this.dgvAdjustment.AllowUserToAddRows = false;
            this.dgvAdjustment.AllowUserToDeleteRows = false;
            this.dgvAdjustment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjustment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonXColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewDateTimeInputColumn1,
            this.dataGridViewCheckBoxXColumn1,
            this.dataGridViewCheckBoxXColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgvAdjustment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdjustment.EnableHeadersVisualStyles = false;
            this.dgvAdjustment.Location = new System.Drawing.Point(0, 194);
            this.dgvAdjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAdjustment.MultiSelect = false;
            this.dgvAdjustment.Name = "dgvAdjustment";
            this.dgvAdjustment.RowHeadersVisible = false;
            this.dgvAdjustment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdjustment.Size = new System.Drawing.Size(1182, 755);
            this.dgvAdjustment.TabIndex = 513;
            this.dgvAdjustment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjustment_CellClick);
            this.dgvAdjustment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdjustment_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewButtonXColumn2
            // 
            this.dataGridViewButtonXColumn2.HeaderText = "DELETE";
            this.dataGridViewButtonXColumn2.Name = "dataGridViewButtonXColumn2";
            this.dataGridViewButtonXColumn2.Text = null;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Adjusment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewDateTimeInputColumn1
            // 
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDateTimeInputColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDateTimeInputColumn1.HeaderText = "Date";
            this.dataGridViewDateTimeInputColumn1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewDateTimeInputColumn1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dataGridViewDateTimeInputColumn1.Name = "dataGridViewDateTimeInputColumn1";
            this.dataGridViewDateTimeInputColumn1.Width = 80;
            // 
            // dataGridViewCheckBoxXColumn1
            // 
            this.dataGridViewCheckBoxXColumn1.Checked = true;
            this.dataGridViewCheckBoxXColumn1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.dataGridViewCheckBoxXColumn1.CheckValue = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCheckBoxXColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCheckBoxXColumn1.HeaderText = "Is Taxable";
            this.dataGridViewCheckBoxXColumn1.Name = "dataGridViewCheckBoxXColumn1";
            this.dataGridViewCheckBoxXColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxXColumn1.Width = 70;
            // 
            // dataGridViewCheckBoxXColumn2
            // 
            this.dataGridViewCheckBoxXColumn2.Checked = true;
            this.dataGridViewCheckBoxXColumn2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.dataGridViewCheckBoxXColumn2.CheckValue = null;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCheckBoxXColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCheckBoxXColumn2.HeaderText = "Status";
            this.dataGridViewCheckBoxXColumn2.Name = "dataGridViewCheckBoxXColumn2";
            this.dataGridViewCheckBoxXColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxXColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // panelAdjustment
            // 
            this.panelAdjustment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdjustment.Controls.Add(this.nudamount);
            this.panelAdjustment.Controls.Add(this.txtremarks);
            this.panelAdjustment.Controls.Add(this.chkstatus);
            this.panelAdjustment.Controls.Add(this.chktaxable);
            this.panelAdjustment.Controls.Add(this.dtpdate);
            this.panelAdjustment.Controls.Add(this.cmbadjustment);
            this.panelAdjustment.Controls.Add(this.label4);
            this.panelAdjustment.Controls.Add(this.label3);
            this.panelAdjustment.Controls.Add(this.label2);
            this.panelAdjustment.Controls.Add(this.label5);
            this.panelAdjustment.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdjustment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAdjustment.Location = new System.Drawing.Point(0, 39);
            this.panelAdjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAdjustment.Name = "panelAdjustment";
            this.panelAdjustment.Size = new System.Drawing.Size(1182, 134);
            this.panelAdjustment.TabIndex = 514;
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtremarks.Border.Class = "TextBoxBorder";
            this.txtremarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtremarks.FocusHighlightEnabled = true;
            this.txtremarks.ForeColor = System.Drawing.Color.Black;
            this.txtremarks.Location = new System.Drawing.Point(736, 15);
            this.txtremarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtremarks.Multiline = true;
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(420, 72);
            this.txtremarks.TabIndex = 4;
            this.btxMsg.SetText(this.txtremarks, null);
            this.btxMsg.SetTitle(this.txtremarks, null);
            // 
            // chkstatus
            // 
            this.chkstatus.AutoSize = true;
            this.chkstatus.Location = new System.Drawing.Point(741, 97);
            this.chkstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkstatus.Name = "chkstatus";
            this.chkstatus.Size = new System.Drawing.Size(83, 25);
            this.chkstatus.TabIndex = 5;
            this.chkstatus.Text = "Status";
            this.chkstatus.UseVisualStyleBackColor = true;
            // 
            // chktaxable
            // 
            this.chktaxable.AutoSize = true;
            this.chktaxable.Checked = true;
            this.chktaxable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chktaxable.ForeColor = System.Drawing.Color.Red;
            this.chktaxable.Location = new System.Drawing.Point(352, 92);
            this.chktaxable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chktaxable.Name = "chktaxable";
            this.chktaxable.Size = new System.Drawing.Size(94, 25);
            this.chktaxable.TabIndex = 3;
            this.chktaxable.Text = "Taxable";
            this.chktaxable.UseVisualStyleBackColor = true;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(164, 54);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(178, 27);
            this.dtpdate.TabIndex = 1;
            // 
            // cmbadjustment
            // 
            this.cmbadjustment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbadjustment.FormattingEnabled = true;
            this.cmbadjustment.Location = new System.Drawing.Point(164, 17);
            this.cmbadjustment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbadjustment.Name = "cmbadjustment";
            this.cmbadjustment.Size = new System.Drawing.Size(391, 29);
            this.cmbadjustment.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 519;
            this.label4.Text = "Remarks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 518;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 517;
            this.label2.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 516;
            this.label5.Text = "Adjustment Desc:";
            // 
            // nudamount
            // 
            // 
            // 
            // 
            this.nudamount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudamount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nudamount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudamount.Increment = 1D;
            this.nudamount.Location = new System.Drawing.Point(164, 86);
            this.nudamount.Name = "nudamount";
            this.nudamount.ShowUpDown = true;
            this.nudamount.Size = new System.Drawing.Size(178, 27);
            this.nudamount.TabIndex = 520;
            // 
            // EmployeeAdjustmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAdjustment);
            this.Controls.Add(this.dgvAdjustment);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeAdjustmentControl";
            this.Size = new System.Drawing.Size(1182, 949);
            this.Load += new System.EventHandler(this.EmployeeAdjustmentControl_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjustment)).EndInit();
            this.panelAdjustment.ResumeLayout(false);
            this.panelAdjustment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Print_btn;
        private System.Windows.Forms.ToolStripButton Cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panelAdjustment;
        private System.Windows.Forms.CheckBox chkstatus;
        private System.Windows.Forms.CheckBox chktaxable;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.ComboBox cmbadjustment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        internal System.Windows.Forms.DataGridView dgvAdjustment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dataGridViewDateTimeInputColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn dataGridViewCheckBoxXColumn1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn dataGridViewCheckBoxXColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtremarks;
        internal DevComponents.Editors.DoubleInput nudamount;
    }
}
