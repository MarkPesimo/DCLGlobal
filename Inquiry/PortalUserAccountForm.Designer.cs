namespace DCLGlobal.Inquiry
{
    partial class PortalUserAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalUserAccountForm));
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbRole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtUname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboItem3 = new DevComponents.Editors.ComboItem();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ComboItem2 = new DevComponents.Editors.ComboItem();
            this.chkStat = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbUType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboItem1 = new DevComponents.Editors.ComboItem();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(120, 49);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(221, 38);
            this.btnResetPassword.TabIndex = 0;
            this.btnResetPassword.Text = "RESET";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(38, 81);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "User Type:";
            // 
            // cmbRole
            // 
            this.cmbRole.DisplayMember = "Text";
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 15;
            this.cmbRole.Location = new System.Drawing.Point(104, 51);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(144, 21);
            this.cmbRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbRole.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(66, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Role:";
            // 
            // txtUname
            // 
            // 
            // 
            // 
            this.txtUname.Border.Class = "TextBoxBorder";
            this.txtUname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUname.Location = new System.Drawing.Point(104, 24);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(375, 21);
            this.txtUname.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(36, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "User name:";
            // 
            // ComboItem3
            // 
            this.ComboItem3.Text = "E";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.btnResetPassword);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(490, 144);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "User Password";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // ComboItem2
            // 
            this.ComboItem2.Text = "H";
            // 
            // chkStat
            // 
            this.chkStat.AutoSize = true;
            this.chkStat.Location = new System.Drawing.Point(104, 109);
            this.chkStat.Name = "chkStat";
            this.chkStat.Size = new System.Drawing.Size(57, 17);
            this.chkStat.TabIndex = 7;
            this.chkStat.Text = "Status";
            this.chkStat.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(378, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 40);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbUType
            // 
            this.cmbUType.DisplayMember = "Text";
            this.cmbUType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUType.FormattingEnabled = true;
            this.cmbUType.ItemHeight = 15;
            this.cmbUType.Items.AddRange(new object[] {
            this.ComboItem1,
            this.ComboItem2,
            this.ComboItem3});
            this.cmbUType.Location = new System.Drawing.Point(104, 78);
            this.cmbUType.Name = "cmbUType";
            this.cmbUType.Size = new System.Drawing.Size(144, 21);
            this.cmbUType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbUType.TabIndex = 5;
            // 
            // ComboItem1
            // 
            this.ComboItem1.Text = "HM";
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.chkStat);
            this.TabPage1.Controls.Add(this.btnUpdate);
            this.TabPage1.Controls.Add(this.cmbUType);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.cmbRole);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.txtUname);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(490, 144);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Role and User Type";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(498, 170);
            this.TabControl1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(413, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnClose);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 170);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(498, 30);
            this.Panel1.TabIndex = 2;
            // 
            // PortalUserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 200);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PortalUserAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal User Account";
            this.Load += new System.EventHandler(this.PortalUserAccountForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PortalUserAccountForm_KeyDown);
            this.TabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnResetPassword;
        internal System.Windows.Forms.Label Label3;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbRole;
        internal System.Windows.Forms.Label Label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtUname;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.Editors.ComboItem ComboItem3;
        internal System.Windows.Forms.TabPage TabPage2;
        internal DevComponents.Editors.ComboItem ComboItem2;
        internal System.Windows.Forms.CheckBox chkStat;
        internal System.Windows.Forms.Button btnUpdate;
        internal DevComponents.DotNetBar.Controls.ComboBoxEx cmbUType;
        internal DevComponents.Editors.ComboItem ComboItem1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Panel Panel1;
    }
}