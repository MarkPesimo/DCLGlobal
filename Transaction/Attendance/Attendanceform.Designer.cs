namespace DCLGlobal.Transaction.Attendance
{
    partial class Attendanceform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendanceform));
            this.label1 = new System.Windows.Forms.Label();
            this.btnemployeeName = new DevComponents.DotNetBar.ButtonX();
            this.txtEmployeeName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtempno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dtTimeIn = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbShift = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblShift = new System.Windows.Forms.Label();
            this.dtDateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dtDateTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 411;
            this.label1.Text = "Employee Name:";
            // 
            // btnemployeeName
            // 
            this.btnemployeeName.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnemployeeName.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnemployeeName.Image = ((System.Drawing.Image)(resources.GetObject("btnemployeeName.Image")));
            this.btnemployeeName.Location = new System.Drawing.Point(542, 50);
            this.btnemployeeName.Name = "btnemployeeName";
            this.btnemployeeName.Size = new System.Drawing.Size(19, 18);
            this.btnemployeeName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnemployeeName.TabIndex = 412;
            this.btnemployeeName.Click += new System.EventHandler(this.btnemployeeName_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmployeeName.Border.Class = "TextBoxBorder";
            this.txtEmployeeName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmployeeName.FocusHighlightEnabled = true;
            this.txtEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txtEmployeeName.Location = new System.Drawing.Point(129, 48);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(434, 21);
            this.txtEmployeeName.TabIndex = 410;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(130, 74);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 21);
            this.dtpDate.TabIndex = 523;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 524;
            this.label2.Text = "Date Log:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 525;
            this.label4.Text = "Employee No.:";
            // 
            // txtempno
            // 
            this.txtempno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtempno.Border.Class = "TextBoxBorder";
            this.txtempno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtempno.FocusHighlightEnabled = true;
            this.txtempno.ForeColor = System.Drawing.Color.Black;
            this.txtempno.Location = new System.Drawing.Point(129, 20);
            this.txtempno.Name = "txtempno";
            this.txtempno.ReadOnly = true;
            this.txtempno.Size = new System.Drawing.Size(121, 21);
            this.txtempno.TabIndex = 526;
            // 
            // dtTimeOut
            // 
            this.dtTimeOut.Checked = false;
            this.dtTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeOut.Location = new System.Drawing.Point(259, 125);
            this.dtTimeOut.Name = "dtTimeOut";
            this.dtTimeOut.ShowCheckBox = true;
            this.dtTimeOut.ShowUpDown = true;
            this.dtTimeOut.Size = new System.Drawing.Size(121, 21);
            this.dtTimeOut.TabIndex = 528;
            // 
            // dtTimeIn
            // 
            this.dtTimeIn.Checked = false;
            this.dtTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeIn.Location = new System.Drawing.Point(259, 100);
            this.dtTimeIn.Name = "dtTimeIn";
            this.dtTimeIn.ShowCheckBox = true;
            this.dtTimeIn.ShowUpDown = true;
            this.dtTimeIn.Size = new System.Drawing.Size(121, 21);
            this.dtTimeIn.TabIndex = 527;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(488, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 24);
            this.btnCancel.TabIndex = 536;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(385, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 24);
            this.btnSave.TabIndex = 537;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDateTimeOut);
            this.groupBox1.Controls.Add(this.dtDateTimeIn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbShift);
            this.groupBox1.Controls.Add(this.lblShift);
            this.groupBox1.Controls.Add(this.txtempno);
            this.groupBox1.Controls.Add(this.btnemployeeName);
            this.groupBox1.Controls.Add(this.dtTimeOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtTimeIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.txtEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 181);
            this.groupBox1.TabIndex = 538;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // cmbShift
            // 
            this.cmbShift.DisplayMember = "Text";
            this.cmbShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.ItemHeight = 15;
            this.cmbShift.Location = new System.Drawing.Point(129, 152);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(252, 21);
            this.cmbShift.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbShift.TabIndex = 530;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(92, 156);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(33, 13);
            this.lblShift.TabIndex = 529;
            this.lblShift.Text = "Shift:";
            // 
            // dtDateTimeOut
            // 
            this.dtDateTimeOut.Checked = false;
            this.dtDateTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTimeOut.Location = new System.Drawing.Point(130, 126);
            this.dtDateTimeOut.Name = "dtDateTimeOut";
            this.dtDateTimeOut.ShowCheckBox = true;
            this.dtDateTimeOut.Size = new System.Drawing.Size(123, 21);
            this.dtDateTimeOut.TabIndex = 534;
            // 
            // dtDateTimeIn
            // 
            this.dtDateTimeIn.Checked = false;
            this.dtDateTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateTimeIn.Location = new System.Drawing.Point(130, 100);
            this.dtDateTimeIn.Name = "dtDateTimeIn";
            this.dtDateTimeIn.ShowCheckBox = true;
            this.dtDateTimeIn.Size = new System.Drawing.Size(123, 21);
            this.dtDateTimeIn.TabIndex = 533;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 532;
            this.label5.Text = "Time Out (Date/Time):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 531;
            this.label6.Text = "Time In (Date/Time):";
            // 
            // Attendanceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Attendanceform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendanceform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.ButtonX btnemployeeName;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtempno;
        internal System.Windows.Forms.DateTimePicker dtTimeOut;
        internal System.Windows.Forms.DateTimePicker dtTimeIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbShift;
        internal System.Windows.Forms.Label lblShift;
        internal System.Windows.Forms.DateTimePicker dtDateTimeOut;
        internal System.Windows.Forms.DateTimePicker dtDateTimeIn;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
    }
}