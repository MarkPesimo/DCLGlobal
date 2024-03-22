namespace DCLGlobal.Inquiry
{
    partial class AddLoanPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLoanPaymentForm));
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtORNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPaymentRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panFoot = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtPaymentDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboPaymentType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.label53 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.panFoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(521, 8);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(96, 28);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(10, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 28);
            this.label13.TabIndex = 849;
            this.label13.Text = "Press Esc to close this form";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(609, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 24);
            this.close_btn.TabIndex = 948;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // txtORNo
            // 
            this.txtORNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtORNo.Border.Class = "TextBoxBorder";
            this.txtORNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtORNo.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtORNo.FocusHighlightEnabled = true;
            this.txtORNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtORNo.Location = new System.Drawing.Point(476, 62);
            this.txtORNo.Name = "txtORNo";
            this.txtORNo.Size = new System.Drawing.Size(141, 21);
            this.txtORNo.TabIndex = 957;
            this.btxMsg.SetText(this.txtORNo, null);
            this.btxMsg.SetTitle(this.txtORNo, null);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtAmount.FocusHighlightEnabled = true;
            this.txtAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmount.Location = new System.Drawing.Point(128, 62);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(141, 21);
            this.txtAmount.TabIndex = 956;
            this.btxMsg.SetText(this.txtAmount, "Please input amount");
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtAmount, null);
            // 
            // txtPaymentRemarks
            // 
            this.txtPaymentRemarks.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPaymentRemarks.Border.Class = "TextBoxBorder";
            this.txtPaymentRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPaymentRemarks.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtPaymentRemarks.FocusHighlightEnabled = true;
            this.txtPaymentRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPaymentRemarks.Location = new System.Drawing.Point(128, 89);
            this.txtPaymentRemarks.Multiline = true;
            this.txtPaymentRemarks.Name = "txtPaymentRemarks";
            this.txtPaymentRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPaymentRemarks.Size = new System.Drawing.Size(489, 45);
            this.txtPaymentRemarks.TabIndex = 955;
            this.btxMsg.SetText(this.txtPaymentRemarks, null);
            this.btxMsg.SetTitle(this.txtPaymentRemarks, null);
            // 
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.White;
            this.panFoot.Controls.Add(this.save_btn);
            this.panFoot.Controls.Add(this.cancel_btn);
            this.panFoot.Controls.Add(this.label13);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 150);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(637, 43);
            this.panFoot.TabIndex = 949;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(419, 8);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(96, 28);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblHeader.Image")));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(637, 24);
            this.lblHeader.TabIndex = 947;
            this.lblHeader.Text = "      Add New Loan Payment";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(419, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 959;
            this.label10.Text = "OR No.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(69, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 958;
            this.label9.Text = "Amount:";
            // 
            // dtPaymentDate
            // 
            // 
            // 
            // 
            this.dtPaymentDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPaymentDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPaymentDate.ButtonDropDown.Visible = true;
            this.dtPaymentDate.IsPopupCalendarOpen = false;
            this.dtPaymentDate.Location = new System.Drawing.Point(476, 35);
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtPaymentDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPaymentDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.MonthCalendar.DisplayMonth = new System.DateTime(2012, 10, 1, 0, 0, 0, 0);
            this.dtPaymentDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPaymentDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPaymentDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPaymentDate.MonthCalendar.TodayButtonVisible = true;
            this.dtPaymentDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.ShowCheckBox = true;
            this.dtPaymentDate.Size = new System.Drawing.Size(141, 21);
            this.dtPaymentDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPaymentDate.TabIndex = 954;
            this.dtPaymentDate.Value = new System.DateTime(2012, 10, 4, 19, 22, 30, 0);
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DisabledBackColor = System.Drawing.Color.White;
            this.cboPaymentType.DisabledForeColor = System.Drawing.Color.Black;
            this.cboPaymentType.DisplayMember = "Text";
            this.cboPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.ItemHeight = 15;
            this.cboPaymentType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cboPaymentType.Location = new System.Drawing.Point(128, 35);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(229, 21);
            this.cboPaymentType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPaymentType.TabIndex = 953;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Separation by Resignation";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Separation by Termination";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "AWOL";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(65, 91);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(52, 13);
            this.label53.TabIndex = 952;
            this.label53.Text = "Remarks:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(386, 38);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(79, 13);
            this.label39.TabIndex = 951;
            this.label39.Text = "Payment Date:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(36, 39);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(80, 13);
            this.label45.TabIndex = 950;
            this.label45.Text = "Payment Type:";
            // 
            // AddLoanPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 193);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtORNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPaymentRemarks);
            this.Controls.Add(this.dtPaymentDate);
            this.Controls.Add(this.cboPaymentType);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.panFoot);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AddLoanPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Loan Payment";
            this.Load += new System.EventHandler(this.AddLoanPaymentForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddLoanPaymentForm_KeyDown);
            this.panFoot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label lblHeader;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtORNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAmount;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPaymentRemarks;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPaymentDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboPaymentType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        internal System.Windows.Forms.Label label53;
        internal System.Windows.Forms.Label label39;
        internal System.Windows.Forms.Label label45;
    }
}