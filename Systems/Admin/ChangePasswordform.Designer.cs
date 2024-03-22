namespace DCLGlobal.Systems.Admin
{
    partial class ChangePasswordform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordform));
            this.cancelcopybtn = new System.Windows.Forms.Button();
            this.copybtn = new System.Windows.Forms.Button();
            this.txtOldpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtConfirmPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.SuspendLayout();
            // 
            // cancelcopybtn
            // 
            this.cancelcopybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelcopybtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelcopybtn.Image")));
            this.cancelcopybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelcopybtn.Location = new System.Drawing.Point(307, 120);
            this.cancelcopybtn.Name = "cancelcopybtn";
            this.cancelcopybtn.Size = new System.Drawing.Size(96, 23);
            this.cancelcopybtn.TabIndex = 4;
            this.cancelcopybtn.Text = "Cancel";
            this.cancelcopybtn.UseVisualStyleBackColor = true;
            this.cancelcopybtn.Click += new System.EventHandler(this.cancelcopybtn_Click);
            // 
            // copybtn
            // 
            this.copybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copybtn.Image = ((System.Drawing.Image)(resources.GetObject("copybtn.Image")));
            this.copybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copybtn.Location = new System.Drawing.Point(208, 120);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(93, 23);
            this.copybtn.TabIndex = 3;
            this.copybtn.Text = "Save";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // txtOldpassword
            // 
            this.txtOldpassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOldpassword.Border.Class = "TextBoxBorder";
            this.txtOldpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOldpassword.FocusHighlightEnabled = true;
            this.txtOldpassword.ForeColor = System.Drawing.Color.Black;
            this.txtOldpassword.Location = new System.Drawing.Point(131, 22);
            this.txtOldpassword.Name = "txtOldpassword";
            this.txtOldpassword.PasswordChar = '*';
            this.txtOldpassword.Size = new System.Drawing.Size(272, 21);
            this.txtOldpassword.TabIndex = 0;
            this.txtOldpassword.Tag = "0";
            this.btxMsg.SetText(this.txtOldpassword, "Previous password cannot be blank");
            this.btxMsg.SetTitle(this.txtOldpassword, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 515;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 514;
            this.label2.Text = "New Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 513;
            this.label6.Text = "Previous Password :";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNewPassword.Border.Class = "TextBoxBorder";
            this.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPassword.FocusHighlightEnabled = true;
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(131, 49);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(272, 21);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Tag = "0";
            this.btxMsg.SetText(this.txtNewPassword, "New Password cannot be blank");
            this.btxMsg.SetTitle(this.txtNewPassword, null);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtConfirmPassword.Border.Class = "TextBoxBorder";
            this.txtConfirmPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtConfirmPassword.FocusHighlightEnabled = true;
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Location = new System.Drawing.Point(131, 76);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(272, 21);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.Tag = "0";
            this.btxMsg.SetText(this.txtConfirmPassword, "Confirm Password cannot be blank");
            this.btxMsg.SetTitle(this.txtConfirmPassword, null);
            // 
            // ChangePasswordform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(415, 151);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldpassword);
            this.Controls.Add(this.cancelcopybtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ChangePasswordform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePasswordform_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelcopybtn;
        private System.Windows.Forms.Button copybtn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtConfirmPassword;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtNewPassword;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtOldpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
    }
}