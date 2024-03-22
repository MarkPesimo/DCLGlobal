namespace DCLGlobal.Transaction.Contract
{
    partial class ContractOnprocessControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractOnprocessControl));
            this.dtpDatePlanned = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpETD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboRotation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOffsigner = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReDisembark = new System.Windows.Forms.Button();
            this.btnPlanned = new System.Windows.Forms.Button();
            this.btnOffsigner = new DevComponents.DotNetBar.ButtonX();
            this.btnPort = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpProjectedReadiness = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpLastDateReported = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatePlanned
            // 
            this.dtpDatePlanned.Checked = false;
            this.dtpDatePlanned.Location = new System.Drawing.Point(122, 15);
            this.dtpDatePlanned.Name = "dtpDatePlanned";
            this.dtpDatePlanned.ShowCheckBox = true;
            this.dtpDatePlanned.Size = new System.Drawing.Size(233, 21);
            this.dtpDatePlanned.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 516;
            this.label9.Text = "Date planned";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpETD
            // 
            this.dtpETD.Checked = false;
            this.dtpETD.Location = new System.Drawing.Point(567, 15);
            this.dtpETD.Name = "dtpETD";
            this.dtpETD.ShowCheckBox = true;
            this.dtpETD.Size = new System.Drawing.Size(233, 21);
            this.dtpETD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 518;
            this.label1.Text = "Estimated Dispatched";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPort.Border.Class = "TextBoxBorder";
            this.txtPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPort.FocusHighlightEnabled = true;
            this.txtPort.ForeColor = System.Drawing.Color.Black;
            this.txtPort.Location = new System.Drawing.Point(122, 71);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(678, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Tag = "0";
            this.btxMsg.SetText(this.txtPort, "Port cannot be blank");
            this.btxMsg.SetTitle(this.txtPort, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 520;
            this.label4.Text = "Port";
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
            this.txtRemarks.Location = new System.Drawing.Point(122, 152);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(678, 90);
            this.txtRemarks.TabIndex = 8;
            this.txtRemarks.Tag = "0";
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // cboRotation
            // 
            this.cboRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRotation.FormattingEnabled = true;
            this.cboRotation.Location = new System.Drawing.Point(122, 125);
            this.cboRotation.Name = "cboRotation";
            this.cboRotation.Size = new System.Drawing.Size(233, 21);
            this.cboRotation.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 524;
            this.label8.Text = "Working Rotation";
            // 
            // txtOffsigner
            // 
            this.txtOffsigner.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOffsigner.Border.Class = "TextBoxBorder";
            this.txtOffsigner.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOffsigner.FocusHighlightEnabled = true;
            this.txtOffsigner.ForeColor = System.Drawing.Color.Black;
            this.txtOffsigner.Location = new System.Drawing.Point(122, 98);
            this.txtOffsigner.Name = "txtOffsigner";
            this.txtOffsigner.ReadOnly = true;
            this.txtOffsigner.Size = new System.Drawing.Size(678, 21);
            this.txtOffsigner.TabIndex = 5;
            this.txtOffsigner.Tag = "0";
            this.btxMsg.SetText(this.txtOffsigner, null);
            this.btxMsg.SetTitle(this.txtOffsigner, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 526;
            this.label2.Text = "Off Signer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 532;
            this.label3.Text = "Remarks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(821, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 531;
            this.pictureBox1.TabStop = false;
            // 
            // btnReDisembark
            // 
            this.btnReDisembark.Image = ((System.Drawing.Image)(resources.GetObject("btnReDisembark.Image")));
            this.btnReDisembark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReDisembark.Location = new System.Drawing.Point(6, 287);
            this.btnReDisembark.Name = "btnReDisembark";
            this.btnReDisembark.Size = new System.Drawing.Size(132, 23);
            this.btnReDisembark.TabIndex = 9;
            this.btnReDisembark.Text = "Re-Disembark";
            this.btnReDisembark.UseVisualStyleBackColor = true;
            this.btnReDisembark.Click += new System.EventHandler(this.btnReDisembark_Click);
            // 
            // btnPlanned
            // 
            this.btnPlanned.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanned.Image")));
            this.btnPlanned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanned.Location = new System.Drawing.Point(821, 287);
            this.btnPlanned.Name = "btnPlanned";
            this.btnPlanned.Size = new System.Drawing.Size(156, 23);
            this.btnPlanned.TabIndex = 10;
            this.btnPlanned.Text = "Plan / Update";
            this.btnPlanned.UseVisualStyleBackColor = true;
            this.btnPlanned.Click += new System.EventHandler(this.btnPlanned_Click);
            // 
            // btnOffsigner
            // 
            this.btnOffsigner.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOffsigner.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOffsigner.Image = ((System.Drawing.Image)(resources.GetObject("btnOffsigner.Image")));
            this.btnOffsigner.Location = new System.Drawing.Point(779, 100);
            this.btnOffsigner.Name = "btnOffsigner";
            this.btnOffsigner.Size = new System.Drawing.Size(19, 18);
            this.btnOffsigner.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOffsigner.TabIndex = 6;
            this.btnOffsigner.Click += new System.EventHandler(this.btnOffsigner_Click);
            // 
            // btnPort
            // 
            this.btnPort.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPort.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPort.Image = ((System.Drawing.Image)(resources.GetObject("btnPort.Image")));
            this.btnPort.Location = new System.Drawing.Point(779, 73);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(19, 18);
            this.btnPort.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPort.TabIndex = 4;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 533;
            this.label5.Text = "Projected Readiness";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpProjectedReadiness
            // 
            this.dtpProjectedReadiness.Checked = false;
            this.dtpProjectedReadiness.Location = new System.Drawing.Point(122, 44);
            this.dtpProjectedReadiness.Name = "dtpProjectedReadiness";
            this.dtpProjectedReadiness.ShowCheckBox = true;
            this.dtpProjectedReadiness.Size = new System.Drawing.Size(233, 21);
            this.dtpProjectedReadiness.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(119, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 535;
            this.label6.Text = "** Some notes to be put here ...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 536;
            this.label7.Text = "Last Date Reported";
            // 
            // dtpLastDateReported
            // 
            this.dtpLastDateReported.Checked = false;
            this.dtpLastDateReported.Enabled = false;
            this.dtpLastDateReported.Location = new System.Drawing.Point(567, 42);
            this.dtpLastDateReported.Name = "dtpLastDateReported";
            this.dtpLastDateReported.ShowCheckBox = true;
            this.dtpLastDateReported.Size = new System.Drawing.Size(233, 21);
            this.dtpLastDateReported.TabIndex = 537;
            // 
            // ContractOnprocessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpLastDateReported);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpProjectedReadiness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReDisembark);
            this.Controls.Add(this.btnPlanned);
            this.Controls.Add(this.btnOffsigner);
            this.Controls.Add(this.txtOffsigner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRotation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpETD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatePlanned);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ContractOnprocessControl";
            this.Size = new System.Drawing.Size(991, 316);
            this.Load += new System.EventHandler(this.ContractOnprocessControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatePlanned;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpETD;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.ButtonX btnPort;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPort;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        private System.Windows.Forms.ComboBox cboRotation;
        private System.Windows.Forms.Label label8;
        internal DevComponents.DotNetBar.ButtonX btnOffsigner;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtOffsigner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlanned;
        private System.Windows.Forms.Button btnReDisembark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProjectedReadiness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpLastDateReported;
    }
}
