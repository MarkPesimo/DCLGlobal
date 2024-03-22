namespace DCLGlobal.Inquiry
{
    partial class NewLoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLoanForm));
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeductionAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.txtBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtLoanAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmployee = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cboLoanType = new System.Windows.Forms.ComboBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panFoot = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(115, 212);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 938;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
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
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.Black;
            this.txtRemarks.Location = new System.Drawing.Point(115, 123);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(526, 82);
            this.txtRemarks.TabIndex = 927;
            this.txtRemarks.Tag = "0";
            this.btxMsg.SetText(this.txtRemarks, null);
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 937;
            this.label5.Text = "Remarks :";
            // 
            // txtDeductionAmount
            // 
            this.txtDeductionAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDeductionAmount.Border.Class = "TextBoxBorder";
            this.txtDeductionAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeductionAmount.FocusHighlightEnabled = true;
            this.txtDeductionAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeductionAmount.ForeColor = System.Drawing.Color.Black;
            this.txtDeductionAmount.Location = new System.Drawing.Point(489, 78);
            this.txtDeductionAmount.Name = "txtDeductionAmount";
            this.txtDeductionAmount.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDeductionAmount.Size = new System.Drawing.Size(152, 21);
            this.txtDeductionAmount.TabIndex = 926;
            this.txtDeductionAmount.Tag = "0";
            this.btxMsg.SetText(this.txtDeductionAmount, null);
            this.txtDeductionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtDeductionAmount, "Deduction amount cannot be blank");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(381, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 936;
            this.label6.Text = "Deduction Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(417, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 935;
            this.label4.Text = "Loan Date :";
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(489, 32);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(152, 21);
            this.dtpLoanDate.TabIndex = 921;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBalance.Border.Class = "TextBoxBorder";
            this.txtBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBalance.FocusHighlightEnabled = true;
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.Location = new System.Drawing.Point(115, 101);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBalance.Size = new System.Drawing.Size(152, 21);
            this.txtBalance.TabIndex = 925;
            this.txtBalance.Tag = "0";
            this.btxMsg.SetText(this.txtBalance, null);
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtBalance, "Balance cannot be blank");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 934;
            this.label3.Text = "Balance :";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLoanAmount.Border.Class = "TextBoxBorder";
            this.txtLoanAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLoanAmount.FocusHighlightEnabled = true;
            this.txtLoanAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanAmount.ForeColor = System.Drawing.Color.Black;
            this.txtLoanAmount.Location = new System.Drawing.Point(115, 78);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoanAmount.Size = new System.Drawing.Size(152, 21);
            this.txtLoanAmount.TabIndex = 924;
            this.txtLoanAmount.Tag = "0";
            this.btxMsg.SetText(this.txtLoanAmount, null);
            this.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btxMsg.SetTitle(this.txtLoanAmount, "Loan amount cannot be blank");
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.txtEmployee.Border.Class = "TextBoxBorder";
            this.txtEmployee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmployee.FocusHighlightEnabled = true;
            this.txtEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtEmployee.Location = new System.Drawing.Point(115, 55);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(423, 21);
            this.txtEmployee.TabIndex = 922;
            this.txtEmployee.Tag = "0";
            this.btxMsg.SetText(this.txtEmployee, null);
            this.btxMsg.SetTitle(this.txtEmployee, "Employee cannot be blank");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 933;
            this.label1.Text = "Loan Amount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 932;
            this.label2.Text = "Employee Name :";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(542, 55);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(99, 21);
            this.search_btn.TabIndex = 923;
            this.search_btn.Text = "       Search";
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(45, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 931;
            this.label14.Text = "Loan Type :";
            // 
            // cboLoanType
            // 
            this.cboLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanType.FormattingEnabled = true;
            this.cboLoanType.Items.AddRange(new object[] {
            "Remittance",
            "Loan"});
            this.cboLoanType.Location = new System.Drawing.Point(115, 32);
            this.cboLoanType.Name = "cboLoanType";
            this.cboLoanType.Size = new System.Drawing.Size(244, 21);
            this.cboLoanType.TabIndex = 920;
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
            this.save_btn.Location = new System.Drawing.Point(443, 8);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(96, 28);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(545, 8);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(96, 28);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = false;
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
            // panFoot
            // 
            this.panFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panFoot.Controls.Add(this.save_btn);
            this.panFoot.Controls.Add(this.cancel_btn);
            this.panFoot.Controls.Add(this.label13);
            this.panFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFoot.ForeColor = System.Drawing.Color.White;
            this.panFoot.Location = new System.Drawing.Point(0, 232);
            this.panFoot.Name = "panFoot";
            this.panFoot.Size = new System.Drawing.Size(650, 43);
            this.panFoot.TabIndex = 930;
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(622, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(28, 24);
            this.close_btn.TabIndex = 929;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(650, 24);
            this.label8.TabIndex = 928;
            this.label8.Text = "      Create New Loan";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            // 
            // NewLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 275);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDeductionAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpLoanDate);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboLoanType);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panFoot);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NewLoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Loan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewLoanForm_KeyDown);
            this.panFoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActive;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDeductionAmount;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBalance;
        internal System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLoanAmount;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtEmployee;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboLoanType;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panFoot;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label8;
    }
}