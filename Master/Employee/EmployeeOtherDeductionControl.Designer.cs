namespace DCLGlobal.Master.Employee
{
    partial class EmployeeOtherDeductionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeOtherDeductionControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.Cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Print_btn = new System.Windows.Forms.ToolStripButton();
            this.dgvDeduction = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonXColumn4 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dataGridViewCheckBoxXColumn3 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOtherDeduct = new System.Windows.Forms.Panel();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkStat = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComputeAbsent = new System.Windows.Forms.Button();
            this.nudAbsentDays = new System.Windows.Forms.NumericUpDown();
            this.dtpTrans = new System.Windows.Forms.DateTimePicker();
            this.cmbdesc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudAmount = new DevComponents.Editors.DoubleInput();
            this.nudBalance = new DevComponents.Editors.DoubleInput();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduction)).BeginInit();
            this.panelOtherDeduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsentDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
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
            this.toolStrip2.TabIndex = 513;
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
            this.toolStripLabel2.Size = new System.Drawing.Size(160, 36);
            this.toolStripLabel2.Text = "Other Deduction";
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
            // dgvDeduction
            // 
            this.dgvDeduction.AllowUserToAddRows = false;
            this.dgvDeduction.AllowUserToDeleteRows = false;
            this.dgvDeduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewButtonXColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxXColumn3,
            this.dataGridViewTextBoxColumn9});
            this.dgvDeduction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDeduction.EnableHeadersVisualStyles = false;
            this.dgvDeduction.Location = new System.Drawing.Point(0, 232);
            this.dgvDeduction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDeduction.Name = "dgvDeduction";
            this.dgvDeduction.RowHeadersVisible = false;
            this.dgvDeduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeduction.Size = new System.Drawing.Size(1182, 717);
            this.dgvDeduction.TabIndex = 514;
            this.dgvDeduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeduction_CellClick);
            this.dgvDeduction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeduction_CellContentClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewButtonXColumn4
            // 
            this.dataGridViewButtonXColumn4.HeaderText = "DELETE";
            this.dataGridViewButtonXColumn4.Name = "dataGridViewButtonXColumn4";
            this.dataGridViewButtonXColumn4.Text = null;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            // 
            // 
            // 
            this.dataGridViewTextBoxColumn8.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.dataGridViewTextBoxColumn8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.dataGridViewTextBoxColumn8.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewTextBoxColumn8.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewTextBoxColumn8.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.dataGridViewTextBoxColumn8.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewTextBoxColumn8.MonthCalendar.DisplayMonth = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dataGridViewTextBoxColumn8.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dataGridViewTextBoxColumn8.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dataGridViewTextBoxColumn8.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dataGridViewTextBoxColumn8.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewCheckBoxXColumn3
            // 
            this.dataGridViewCheckBoxXColumn3.Checked = true;
            this.dataGridViewCheckBoxXColumn3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.dataGridViewCheckBoxXColumn3.CheckValue = null;
            this.dataGridViewCheckBoxXColumn3.HeaderText = "Status";
            this.dataGridViewCheckBoxXColumn3.Name = "dataGridViewCheckBoxXColumn3";
            this.dataGridViewCheckBoxXColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxXColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // panelOtherDeduct
            // 
            this.panelOtherDeduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOtherDeduct.Controls.Add(this.nudBalance);
            this.panelOtherDeduct.Controls.Add(this.nudAmount);
            this.panelOtherDeduct.Controls.Add(this.txtRemarks);
            this.panelOtherDeduct.Controls.Add(this.chkStat);
            this.panelOtherDeduct.Controls.Add(this.label6);
            this.panelOtherDeduct.Controls.Add(this.btnComputeAbsent);
            this.panelOtherDeduct.Controls.Add(this.nudAbsentDays);
            this.panelOtherDeduct.Controls.Add(this.dtpTrans);
            this.panelOtherDeduct.Controls.Add(this.cmbdesc);
            this.panelOtherDeduct.Controls.Add(this.label5);
            this.panelOtherDeduct.Controls.Add(this.label4);
            this.panelOtherDeduct.Controls.Add(this.label3);
            this.panelOtherDeduct.Controls.Add(this.label2);
            this.panelOtherDeduct.Controls.Add(this.label7);
            this.panelOtherDeduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOtherDeduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOtherDeduct.Location = new System.Drawing.Point(0, 39);
            this.panelOtherDeduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOtherDeduct.Name = "panelOtherDeduct";
            this.panelOtherDeduct.Size = new System.Drawing.Size(1182, 174);
            this.panelOtherDeduct.TabIndex = 515;
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRemarks.Border.Class = "TextBoxBorder";
            this.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemarks.FocusHighlightEnabled = true;
            this.txtRemarks.ForeColor = System.Drawing.Color.Black;
            this.txtRemarks.Location = new System.Drawing.Point(700, 60);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(417, 65);
            this.txtRemarks.TabIndex = 532;
            // 
            // chkStat
            // 
            this.chkStat.AutoSize = true;
            this.chkStat.Location = new System.Drawing.Point(700, 135);
            this.chkStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkStat.Name = "chkStat";
            this.chkStat.Size = new System.Drawing.Size(83, 25);
            this.chkStat.TabIndex = 531;
            this.chkStat.Text = "Status";
            this.chkStat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(908, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 527;
            this.label6.Text = "Balance:";
            // 
            // btnComputeAbsent
            // 
            this.btnComputeAbsent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnComputeAbsent.FlatAppearance.BorderSize = 0;
            this.btnComputeAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputeAbsent.ForeColor = System.Drawing.Color.White;
            this.btnComputeAbsent.Image = ((System.Drawing.Image)(resources.GetObject("btnComputeAbsent.Image")));
            this.btnComputeAbsent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputeAbsent.Location = new System.Drawing.Point(280, 103);
            this.btnComputeAbsent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComputeAbsent.Name = "btnComputeAbsent";
            this.btnComputeAbsent.Size = new System.Drawing.Size(108, 34);
            this.btnComputeAbsent.TabIndex = 526;
            this.btnComputeAbsent.Text = "Refresh";
            this.btnComputeAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComputeAbsent.UseVisualStyleBackColor = false;
            this.btnComputeAbsent.Click += new System.EventHandler(this.btnComputeAbsent_Click);
            // 
            // nudAbsentDays
            // 
            this.nudAbsentDays.Location = new System.Drawing.Point(141, 105);
            this.nudAbsentDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAbsentDays.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudAbsentDays.Name = "nudAbsentDays";
            this.nudAbsentDays.Size = new System.Drawing.Size(135, 27);
            this.nudAbsentDays.TabIndex = 525;
            this.nudAbsentDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpTrans
            // 
            this.dtpTrans.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTrans.Location = new System.Drawing.Point(141, 65);
            this.dtpTrans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTrans.Name = "dtpTrans";
            this.dtpTrans.Size = new System.Drawing.Size(178, 27);
            this.dtpTrans.TabIndex = 524;
            // 
            // cmbdesc
            // 
            this.cmbdesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdesc.FormattingEnabled = true;
            this.cmbdesc.Location = new System.Drawing.Point(141, 23);
            this.cmbdesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbdesc.Name = "cmbdesc";
            this.cmbdesc.Size = new System.Drawing.Size(354, 29);
            this.cmbdesc.TabIndex = 522;
            this.cmbdesc.SelectedIndexChanged += new System.EventHandler(this.cmbdesc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 521;
            this.label5.Text = "Remarks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 520;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 519;
            this.label3.Text = "Days Absent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 518;
            this.label2.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 517;
            this.label7.Text = "Description:";
            // 
            // nudAmount
            // 
            // 
            // 
            // 
            this.nudAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nudAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudAmount.Increment = 1D;
            this.nudAmount.Location = new System.Drawing.Point(700, 20);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.ShowUpDown = true;
            this.nudAmount.Size = new System.Drawing.Size(122, 27);
            this.nudAmount.TabIndex = 533;
            // 
            // nudBalance
            // 
            // 
            // 
            // 
            this.nudBalance.BackgroundStyle.Class = "DateTimeInputBackground";
            this.nudBalance.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nudBalance.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.nudBalance.Increment = 1D;
            this.nudBalance.Location = new System.Drawing.Point(989, 20);
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.ShowUpDown = true;
            this.nudBalance.Size = new System.Drawing.Size(128, 27);
            this.nudBalance.TabIndex = 534;
            // 
            // EmployeeOtherDeductionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOtherDeduct);
            this.Controls.Add(this.dgvDeduction);
            this.Controls.Add(this.toolStrip2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeOtherDeductionControl";
            this.Size = new System.Drawing.Size(1182, 949);
            this.Load += new System.EventHandler(this.EmployeeOtherDeductionControl_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduction)).EndInit();
            this.panelOtherDeduct.ResumeLayout(false);
            this.panelOtherDeduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbsentDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Print_btn;
        private System.Windows.Forms.ToolStripButton Cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dgvDeduction;
        private System.Windows.Forms.Panel panelOtherDeduct;
        private System.Windows.Forms.CheckBox chkStat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnComputeAbsent;
        private System.Windows.Forms.NumericUpDown nudAbsentDays;
        private System.Windows.Forms.DateTimePicker dtpTrans;
        private System.Windows.Forms.ComboBox cmbdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn dataGridViewTextBoxColumn8;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn dataGridViewCheckBoxXColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal DevComponents.Editors.DoubleInput nudBalance;
        internal DevComponents.Editors.DoubleInput nudAmount;
    }
}
