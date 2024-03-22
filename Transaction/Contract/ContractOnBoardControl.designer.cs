namespace DCLGlobal.Transaction.Contract
{
    partial class ContractOnBoardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractOnBoardControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReplanned = new System.Windows.Forms.Button();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.dtpDateDue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateDispatch = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnport = new DevComponents.DotNetBar.ButtonX();
            this.txtPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReliever = new DevComponents.DotNetBar.ButtonX();
            this.txtReliever = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRotation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(821, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 532;
            this.pictureBox1.TabStop = false;
            // 
            // btnReplanned
            // 
            this.btnReplanned.Image = ((System.Drawing.Image)(resources.GetObject("btnReplanned.Image")));
            this.btnReplanned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplanned.Location = new System.Drawing.Point(6, 287);
            this.btnReplanned.Name = "btnReplanned";
            this.btnReplanned.Size = new System.Drawing.Size(132, 23);
            this.btnReplanned.TabIndex = 534;
            this.btnReplanned.Text = "Re-Planned";
            this.btnReplanned.UseVisualStyleBackColor = true;
            this.btnReplanned.Click += new System.EventHandler(this.btnReplanned_Click);
            // 
            // btnDispatch
            // 
            this.btnDispatch.Image = ((System.Drawing.Image)(resources.GetObject("btnDispatch.Image")));
            this.btnDispatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDispatch.Location = new System.Drawing.Point(821, 287);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(156, 23);
            this.btnDispatch.TabIndex = 533;
            this.btnDispatch.Text = "Dispatch / Update";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // dtpDateDue
            // 
            this.dtpDateDue.Checked = false;
            this.dtpDateDue.Location = new System.Drawing.Point(567, 15);
            this.dtpDateDue.Name = "dtpDateDue";
            this.dtpDateDue.ShowCheckBox = true;
            this.dtpDateDue.Size = new System.Drawing.Size(233, 21);
            this.dtpDateDue.TabIndex = 538;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 537;
            this.label1.Text = "Date Due";
            // 
            // dtpDateDispatch
            // 
            this.dtpDateDispatch.Checked = false;
            this.dtpDateDispatch.Location = new System.Drawing.Point(122, 15);
            this.dtpDateDispatch.Name = "dtpDateDispatch";
            this.dtpDateDispatch.ShowCheckBox = true;
            this.dtpDateDispatch.Size = new System.Drawing.Size(233, 21);
            this.dtpDateDispatch.TabIndex = 536;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 35);
            this.label9.TabIndex = 535;
            this.label9.Text = "Date Dispatched";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnport
            // 
            this.btnport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnport.Image = ((System.Drawing.Image)(resources.GetObject("btnport.Image")));
            this.btnport.Location = new System.Drawing.Point(779, 44);
            this.btnport.Name = "btnport";
            this.btnport.Size = new System.Drawing.Size(19, 18);
            this.btnport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnport.TabIndex = 541;
            this.btnport.Click += new System.EventHandler(this.btnport_Click);
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
            this.txtPort.Location = new System.Drawing.Point(122, 42);
            this.txtPort.Name = "txtPort";
            this.txtPort.ReadOnly = true;
            this.txtPort.Size = new System.Drawing.Size(678, 21);
            this.txtPort.TabIndex = 540;
            this.txtPort.Tag = "0";
            this.btxMsg.SetText(this.txtPort, null);
            this.btxMsg.SetTitle(this.txtPort, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 539;
            this.label4.Text = "Port";
            // 
            // btnReliever
            // 
            this.btnReliever.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReliever.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReliever.Image = ((System.Drawing.Image)(resources.GetObject("btnReliever.Image")));
            this.btnReliever.Location = new System.Drawing.Point(779, 71);
            this.btnReliever.Name = "btnReliever";
            this.btnReliever.Size = new System.Drawing.Size(19, 18);
            this.btnReliever.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReliever.TabIndex = 544;
            this.btnReliever.Click += new System.EventHandler(this.btnReliever_Click);
            // 
            // txtReliever
            // 
            this.txtReliever.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtReliever.Border.Class = "TextBoxBorder";
            this.txtReliever.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReliever.FocusHighlightEnabled = true;
            this.txtReliever.ForeColor = System.Drawing.Color.Black;
            this.txtReliever.Location = new System.Drawing.Point(122, 69);
            this.txtReliever.Name = "txtReliever";
            this.txtReliever.ReadOnly = true;
            this.txtReliever.Size = new System.Drawing.Size(678, 21);
            this.txtReliever.TabIndex = 543;
            this.txtReliever.Tag = "0";
            this.btxMsg.SetText(this.txtReliever, null);
            this.btxMsg.SetTitle(this.txtReliever, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 542;
            this.label2.Text = "Reliever";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 548;
            this.label3.Text = "Remarks";
            // 
            // cboRotation
            // 
            this.cboRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRotation.FormattingEnabled = true;
            this.cboRotation.Location = new System.Drawing.Point(122, 96);
            this.cboRotation.Name = "cboRotation";
            this.cboRotation.Size = new System.Drawing.Size(233, 21);
            this.cboRotation.TabIndex = 547;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 546;
            this.label8.Text = "Working Rotation";
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
            this.txtRemarks.Location = new System.Drawing.Point(122, 123);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(678, 123);
            this.txtRemarks.TabIndex = 545;
            this.txtRemarks.Tag = "0";
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(119, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 549;
            this.label6.Text = "** Some notes to be put here ...";
            // 
            // ContractOnBoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboRotation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnReliever);
            this.Controls.Add(this.txtReliever);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnport);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateDue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateDispatch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReplanned);
            this.Controls.Add(this.btnDispatch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ContractOnBoardControl";
            this.Size = new System.Drawing.Size(991, 316);
            this.Load += new System.EventHandler(this.ContractOnBoardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReplanned;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.DateTimePicker dtpDateDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateDispatch;
        private System.Windows.Forms.Label label9;
        internal DevComponents.DotNetBar.ButtonX btnport;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPort;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.ButtonX btnReliever;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtReliever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRotation;
        private System.Windows.Forms.Label label8;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Label label6;
    }
}
