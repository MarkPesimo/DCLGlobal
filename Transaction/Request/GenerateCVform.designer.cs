namespace DCLGlobal.Transaction.Request
{
    partial class GenerateCVform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateCVform));
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnApplicant = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApplicantname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCVFormat = new System.Windows.Forms.ComboBox();
            this.optReprint = new System.Windows.Forms.RadioButton();
            this.optProposed = new System.Windows.Forms.RadioButton();
            this.chkmasked = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbar.Location = new System.Drawing.Point(0, 208);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(722, 15);
            this.pbar.TabIndex = 333;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Navy;
            this.lblMessage.Location = new System.Drawing.Point(208, 190);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(93, 13);
            this.lblMessage.TabIndex = 334;
            this.lblMessage.Text = "** Some Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMessage.Click += new System.EventHandler(this.Label6_Click);
            // 
            // btnApplicant
            // 
            this.btnApplicant.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApplicant.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnApplicant.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicant.Image")));
            this.btnApplicant.Location = new System.Drawing.Point(695, 44);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(19, 18);
            this.btnApplicant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnApplicant.TabIndex = 1;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 431;
            this.label5.Text = "Candidate Name ";
            // 
            // txtApplicantname
            // 
            this.txtApplicantname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtApplicantname.Border.Class = "TextBoxBorder";
            this.txtApplicantname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApplicantname.FocusHighlightEnabled = true;
            this.txtApplicantname.ForeColor = System.Drawing.Color.Black;
            this.txtApplicantname.Location = new System.Drawing.Point(211, 42);
            this.txtApplicantname.Name = "txtApplicantname";
            this.txtApplicantname.ReadOnly = true;
            this.txtApplicantname.Size = new System.Drawing.Size(505, 21);
            this.txtApplicantname.TabIndex = 0;
            this.btxMsg.SetText(this.txtApplicantname, "Kindly select a record");
            this.btxMsg.SetTitle(this.txtApplicantname, null);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 432;
            this.label1.Text = "Select CV Format";
            // 
            // cboCVFormat
            // 
            this.cboCVFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCVFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCVFormat.FormattingEnabled = true;
            this.cboCVFormat.Items.AddRange(new object[] {
            "Seabase Format",
            "Landbase Format",
            "Dae-ah Format"});
            this.cboCVFormat.Location = new System.Drawing.Point(211, 158);
            this.cboCVFormat.Name = "cboCVFormat";
            this.cboCVFormat.Size = new System.Drawing.Size(254, 21);
            this.cboCVFormat.TabIndex = 5;
            // 
            // optReprint
            // 
            this.optReprint.AutoSize = true;
            this.optReprint.Location = new System.Drawing.Point(211, 92);
            this.optReprint.Name = "optReprint";
            this.optReprint.Size = new System.Drawing.Size(80, 17);
            this.optReprint.TabIndex = 433;
            this.optReprint.Text = "Re-Print CV";
            this.optReprint.UseVisualStyleBackColor = true;
            // 
            // optProposed
            // 
            this.optProposed.AutoSize = true;
            this.optProposed.Checked = true;
            this.optProposed.Location = new System.Drawing.Point(211, 69);
            this.optProposed.Name = "optProposed";
            this.optProposed.Size = new System.Drawing.Size(122, 17);
            this.optProposed.TabIndex = 436;
            this.optProposed.TabStop = true;
            this.optProposed.Text = "Proposed Candidate";
            this.optProposed.UseVisualStyleBackColor = true;
            // 
            // chkmasked
            // 
            this.chkmasked.AutoSize = true;
            this.chkmasked.Location = new System.Drawing.Point(211, 115);
            this.chkmasked.Name = "chkmasked";
            this.chkmasked.Size = new System.Drawing.Size(78, 17);
            this.chkmasked.TabIndex = 437;
            this.chkmasked.Text = "Masked CV";
            this.chkmasked.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 100);
            this.pictureBox1.TabIndex = 607;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.print_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(722, 39);
            this.toolStrip1.TabIndex = 608;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // print_btn
            // 
            this.print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.Text = "toolStripButton1";
            this.print_btn.ToolTipText = "Generate CV";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(316, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 13);
            this.label2.TabIndex = 609;
            this.label2.Text = "** Checked Masked CV to hide critical information about the Candidate/Crew";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(316, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 610;
            this.label3.Text = "** Reprint already generated CV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateCVform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 223);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkmasked);
            this.Controls.Add(this.optProposed);
            this.Controls.Add(this.optReprint);
            this.Controls.Add(this.cboCVFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApplicant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApplicantname);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenerateCVform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Curriculum Vitae";
            this.Load += new System.EventHandler(this.GenerateCVform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ProgressBar pbar;
        internal System.Windows.Forms.Label lblMessage;
        internal DevComponents.DotNetBar.ButtonX btnApplicant;
        private System.Windows.Forms.Label label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtApplicantname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCVFormat;
        private System.Windows.Forms.RadioButton optReprint;
        private System.Windows.Forms.RadioButton optProposed;
        private System.Windows.Forms.CheckBox chkmasked;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton print_btn;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
    }
}