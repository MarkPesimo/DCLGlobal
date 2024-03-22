namespace DCLGlobal.Systems.Admin
{
    partial class Loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.lbTitle = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblnotes = new DevComponents.DotNetBar.LabelX();
            this.chkRemember = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.LabelX10 = new DevComponents.DotNetBar.LabelX();
            this.UsernameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnok = new DevComponents.DotNetBar.ButtonX();
            this.LabelX1 = new DevComponents.DotNetBar.LabelX();
            this.PasswordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.balloonTip1 = new DevComponents.DotNetBar.BalloonTip();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.lbTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbTitle.Image")));
            this.lbTitle.Location = new System.Drawing.Point(163, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(191, 36);
            this.lbTitle.TabIndex = 85;
            this.lbTitle.Text = "Log on to ZMG System";
            this.lbTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(4, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // lblnotes
            // 
            this.lblnotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnotes.AutoSize = true;
            // 
            // 
            // 
            this.lblnotes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblnotes.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblnotes.Location = new System.Drawing.Point(338, 133);
            this.lblnotes.Name = "lblnotes";
            this.lblnotes.Size = new System.Drawing.Size(170, 35);
            this.lblnotes.TabIndex = 91;
            this.lblnotes.Text = " \r\nAll Rights Reserved \r\nDesigned and Developed by SysDev Team\r\n";
            this.lblnotes.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lblnotes.Click += new System.EventHandler(this.LabelX3_Click);
            // 
            // chkRemember
            // 
            // 
            // 
            // 
            this.chkRemember.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRemember.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.Location = new System.Drawing.Point(166, 133);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(100, 23);
            this.chkRemember.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRemember.TabIndex = 3;
            this.chkRemember.Text = "Remember Me";
            // 
            // LabelX10
            // 
            this.LabelX10.AutoSize = true;
            // 
            // 
            // 
            this.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX10.ForeColor = System.Drawing.Color.Black;
            this.LabelX10.Location = new System.Drawing.Point(166, 41);
            this.LabelX10.Name = "LabelX10";
            this.LabelX10.Size = new System.Drawing.Size(55, 16);
            this.LabelX10.TabIndex = 95;
            this.LabelX10.Text = "User name";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UsernameTextBox.Border.Class = "TextBoxBorder";
            this.UsernameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UsernameTextBox.FocusHighlightEnabled = true;
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTextBox.Location = new System.Drawing.Point(166, 61);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(336, 21);
            this.UsernameTextBox.TabIndex = 0;
            this.btxMsg.SetText(this.UsernameTextBox, "Username cannot be blank");
            this.btxMsg.SetTitle(this.UsernameTextBox, "");
            // 
            // btnok
            // 
            this.btnok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnok.Location = new System.Drawing.Point(399, 107);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(103, 19);
            this.btnok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Login";
            this.btnok.Click += new System.EventHandler(this.OK_Click);
            // 
            // LabelX1
            // 
            this.LabelX1.AutoSize = true;
            // 
            // 
            // 
            this.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX1.ForeColor = System.Drawing.Color.Black;
            this.LabelX1.Location = new System.Drawing.Point(166, 88);
            this.LabelX1.Name = "LabelX1";
            this.LabelX1.Size = new System.Drawing.Size(55, 16);
            this.LabelX1.TabIndex = 96;
            this.LabelX1.Text = "Password ";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AcceptsReturn = true;
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PasswordTextBox.Border.Class = "TextBoxBorder";
            this.PasswordTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PasswordTextBox.FocusHighlightEnabled = true;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(166, 106);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(336, 21);
            this.PasswordTextBox.TabIndex = 1;
            this.btxMsg.SetText(this.PasswordTextBox, "Password cannot be blank");
            this.btxMsg.SetTitle(this.PasswordTextBox, null);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 28);
            this.label1.TabIndex = 97;
            this.label1.Text = "       Did you know . . .";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.LabelX10);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.LabelX1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.lblnotes);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Loginform_FormClosed);
            this.Load += new System.EventHandler(this.Loginform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.LabelX lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal DevComponents.DotNetBar.LabelX lblnotes;
        internal DevComponents.DotNetBar.Controls.CheckBoxX chkRemember;
        internal DevComponents.DotNetBar.LabelX LabelX10;
        internal DevComponents.DotNetBar.Controls.TextBoxX UsernameTextBox;
        internal DevComponents.DotNetBar.ButtonX btnok;
        internal DevComponents.DotNetBar.LabelX LabelX1;
        internal DevComponents.DotNetBar.Controls.TextBoxX PasswordTextBox;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private DevComponents.DotNetBar.BalloonTip balloonTip1;
        private System.Windows.Forms.Label label1;
    }
}