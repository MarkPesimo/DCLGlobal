namespace DCLGlobal.Master.Admin
{
    partial class UserMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMasterform));
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtfirstname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtusername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtlastname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmiddlename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtaccount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmployee = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtemailaddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrincipalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnaccount = new DevComponents.DotNetBar.ButtonX();
            this.label7 = new System.Windows.Forms.Label();
            this.btnemployee = new DevComponents.DotNetBar.ButtonX();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkmanager = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_Search.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfirstname
            // 
            this.txtfirstname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtfirstname.Border.Class = "TextBoxBorder";
            this.txtfirstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfirstname.FocusHighlightEnabled = true;
            this.txtfirstname.ForeColor = System.Drawing.Color.Black;
            this.txtfirstname.Location = new System.Drawing.Point(265, 71);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.ReadOnly = true;
            this.txtfirstname.Size = new System.Drawing.Size(595, 21);
            this.txtfirstname.TabIndex = 2;
            this.txtfirstname.Tag = "";
            this.btxMsg.SetText(this.txtfirstname, "Firstname cannot be blank");
            this.btxMsg.SetTitle(this.txtfirstname, null);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtusername.Border.Class = "TextBoxBorder";
            this.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusername.FocusHighlightEnabled = true;
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(265, 44);
            this.txtusername.Name = "txtusername";
            this.txtusername.ReadOnly = true;
            this.txtusername.Size = new System.Drawing.Size(246, 21);
            this.txtusername.TabIndex = 0;
            this.txtusername.Tag = "0";
            this.btxMsg.SetText(this.txtusername, "Username cannot be blank");
            this.btxMsg.SetTitle(this.txtusername, null);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpassword.Border.Class = "TextBoxBorder";
            this.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpassword.FocusHighlightEnabled = true;
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(614, 44);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.ReadOnly = true;
            this.txtpassword.Size = new System.Drawing.Size(246, 21);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Tag = "";
            this.btxMsg.SetText(this.txtpassword, "Password cannot be blank");
            this.btxMsg.SetTitle(this.txtpassword, null);
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtlastname.Border.Class = "TextBoxBorder";
            this.txtlastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtlastname.FocusHighlightEnabled = true;
            this.txtlastname.ForeColor = System.Drawing.Color.Black;
            this.txtlastname.Location = new System.Drawing.Point(265, 98);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.ReadOnly = true;
            this.txtlastname.Size = new System.Drawing.Size(595, 21);
            this.txtlastname.TabIndex = 3;
            this.txtlastname.Tag = "";
            this.btxMsg.SetText(this.txtlastname, "Lastname cannot be blank");
            this.btxMsg.SetTitle(this.txtlastname, null);
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtmiddlename.Border.Class = "TextBoxBorder";
            this.txtmiddlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmiddlename.FocusHighlightEnabled = true;
            this.txtmiddlename.ForeColor = System.Drawing.Color.Black;
            this.txtmiddlename.Location = new System.Drawing.Point(265, 125);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.ReadOnly = true;
            this.txtmiddlename.Size = new System.Drawing.Size(595, 21);
            this.txtmiddlename.TabIndex = 4;
            this.txtmiddlename.Tag = "";
            this.btxMsg.SetText(this.txtmiddlename, "Middlename cannot be blank");
            this.btxMsg.SetTitle(this.txtmiddlename, null);
            // 
            // txtaccount
            // 
            this.txtaccount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtaccount.Border.Class = "TextBoxBorder";
            this.txtaccount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtaccount.FocusHighlightEnabled = true;
            this.txtaccount.ForeColor = System.Drawing.Color.Black;
            this.txtaccount.Location = new System.Drawing.Point(265, 152);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.ReadOnly = true;
            this.txtaccount.Size = new System.Drawing.Size(595, 21);
            this.txtaccount.TabIndex = 5;
            this.btxMsg.SetText(this.txtaccount, "Account cannot be blank");
            this.btxMsg.SetTitle(this.txtaccount, null);
            this.txtaccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaccount_KeyDown);
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmployee.Border.Class = "TextBoxBorder";
            this.txtEmployee.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmployee.FocusHighlightEnabled = true;
            this.txtEmployee.ForeColor = System.Drawing.Color.Black;
            this.txtEmployee.Location = new System.Drawing.Point(265, 179);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(595, 21);
            this.txtEmployee.TabIndex = 7;
            this.txtEmployee.Tag = "0";
            this.btxMsg.SetText(this.txtEmployee, "Employee Name cannot be blank");
            this.btxMsg.SetTitle(this.txtEmployee, null);
            this.txtEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmployee_KeyDown);
            // 
            // txtemailaddress
            // 
            this.txtemailaddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtemailaddress.Border.Class = "TextBoxBorder";
            this.txtemailaddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtemailaddress.FocusHighlightEnabled = true;
            this.txtemailaddress.ForeColor = System.Drawing.Color.Black;
            this.txtemailaddress.Location = new System.Drawing.Point(265, 206);
            this.txtemailaddress.Name = "txtemailaddress";
            this.txtemailaddress.ReadOnly = true;
            this.txtemailaddress.Size = new System.Drawing.Size(595, 21);
            this.txtemailaddress.TabIndex = 9;
            this.btxMsg.SetText(this.txtemailaddress, "Email address cannot be blank");
            this.btxMsg.SetTitle(this.txtemailaddress, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 258);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(872, 269);
            this.pan_Search.TabIndex = 408;
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AccountName,
            this.PrincipalName,
            this.columnHeader2,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(872, 269);
            this.lsvList.TabIndex = 1;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // AccountName
            // 
            this.AccountName.Text = "Username";
            this.AccountName.Width = 204;
            // 
            // PrincipalName
            // 
            this.PrincipalName.Text = "Employee Name";
            this.PrincipalName.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 435;
            this.label5.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 434;
            this.label4.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 437;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 439;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 441;
            this.label3.Text = "Middlename";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 443;
            this.label6.Text = "Account";
            // 
            // btnaccount
            // 
            this.btnaccount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnaccount.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnaccount.Image = ((System.Drawing.Image)(resources.GetObject("btnaccount.Image")));
            this.btnaccount.Location = new System.Drawing.Point(839, 154);
            this.btnaccount.Name = "btnaccount";
            this.btnaccount.Size = new System.Drawing.Size(19, 18);
            this.btnaccount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnaccount.TabIndex = 6;
            this.btnaccount.Click += new System.EventHandler(this.btnaccount_Click);
            this.btnaccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnaccount_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 446;
            this.label7.Text = "Status";
            // 
            // btnemployee
            // 
            this.btnemployee.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnemployee.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnemployee.Image = ((System.Drawing.Image)(resources.GetObject("btnemployee.Image")));
            this.btnemployee.Location = new System.Drawing.Point(839, 182);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(19, 18);
            this.btnemployee.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnemployee.TabIndex = 8;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 448;
            this.label8.Text = "Employee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 451;
            this.label9.Text = "Email Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 452;
            this.label10.Text = "User type";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(265, 233);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 456;
            this.chkStatus.Text = "Active";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkmanager
            // 
            this.chkmanager.AutoSize = true;
            this.chkmanager.Enabled = false;
            this.chkmanager.Location = new System.Drawing.Point(614, 233);
            this.chkmanager.Name = "chkmanager";
            this.chkmanager.Size = new System.Drawing.Size(68, 17);
            this.chkmanager.TabIndex = 457;
            this.chkmanager.Text = "Manager";
            this.chkmanager.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(872, 39);
            this.toolStrip1.TabIndex = 494;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_btn
            // 
            this.Add_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_btn.Image")));
            this.Add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(36, 36);
            this.Add_btn.Text = "toolStripButton1";
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
            this.Edit_btn.Text = "toolStripButton2";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.Text = "toolStripButton3";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(350, 39);
            this.Search_txt.GotFocus += new System.EventHandler(this.Search_txt_GotFocus);
            this.Search_txt.LostFocus += new System.EventHandler(this.Search_txt_LostFocus);
            this.Search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_txt_KeyDown);
            // 
            // Save_btn
            // 
            this.Save_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save_btn.Enabled = false;
            this.Save_btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_btn.Image")));
            this.Save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(36, 36);
            this.Save_btn.Text = "toolStripButton4";
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel_btn.Enabled = false;
            this.cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancel_btn.Image")));
            this.cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.cancel_btn.Text = "toolStripButton5";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // UserMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 527);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkmanager);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtemailaddress);
            this.Controls.Add(this.btnemployee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.btnaccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pan_Search);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Master file";
            this.Load += new System.EventHandler(this.UserMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserMasterform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_Search.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel pan_Search;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader AccountName;
        internal System.Windows.Forms.ColumnHeader PrincipalName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtfirstname;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtusername;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtpassword;
        private System.Windows.Forms.Label label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtlastname;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtmiddlename;
        private System.Windows.Forms.Label label6;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtaccount;
        internal DevComponents.DotNetBar.ButtonX btnaccount;
        private System.Windows.Forms.Label label7;
        internal DevComponents.DotNetBar.ButtonX btnemployee;
        private System.Windows.Forms.Label label8;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtEmployee;
        private System.Windows.Forms.Label label9;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtemailaddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkmanager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
    }
}