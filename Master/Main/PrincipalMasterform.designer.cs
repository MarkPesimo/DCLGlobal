namespace DCLGlobal.Master.Main
{
    partial class PrincipalMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMasterform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrincipalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAccountname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrincipalname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPayrollPrincipal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPOEAprincipal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContactno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmailAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAccount = new DevComponents.DotNetBar.ButtonX();
            this.btnpayroll = new DevComponents.DotNetBar.ButtonX();
            this.btnPOEA = new DevComponents.DotNetBar.ButtonX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.expAccount = new DevComponents.DotNetBar.ExpandablePanel();
            this.lsvAccount = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_Search.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.expAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(36, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 401;
            this.pictureBox1.TabStop = false;
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(30, 255);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(766, 292);
            this.pan_Search.TabIndex = 402;
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AccountName,
            this.PrincipalName,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(766, 292);
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
            this.AccountName.Text = "Account Name";
            this.AccountName.Width = 282;
            // 
            // PrincipalName
            // 
            this.PrincipalName.Text = "Principal Name";
            this.PrincipalName.Width = 346;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 110;
            // 
            // txtAccountname
            // 
            this.txtAccountname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAccountname.Border.Class = "TextBoxBorder";
            this.txtAccountname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAccountname.FocusHighlightEnabled = true;
            this.txtAccountname.ForeColor = System.Drawing.Color.Black;
            this.txtAccountname.Location = new System.Drawing.Point(303, 42);
            this.txtAccountname.Name = "txtAccountname";
            this.txtAccountname.ReadOnly = true;
            this.txtAccountname.Size = new System.Drawing.Size(484, 21);
            this.txtAccountname.TabIndex = 0;
            this.btxMsg.SetText(this.txtAccountname, "Account name cannot be blank");
            this.btxMsg.SetTitle(this.txtAccountname, null);
            this.txtAccountname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 412;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 410;
            this.label1.Text = "Account Name";
            // 
            // txtPrincipalname
            // 
            this.txtPrincipalname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPrincipalname.Border.Class = "TextBoxBorder";
            this.txtPrincipalname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrincipalname.FocusHighlightEnabled = true;
            this.txtPrincipalname.ForeColor = System.Drawing.Color.Black;
            this.txtPrincipalname.Location = new System.Drawing.Point(303, 69);
            this.txtPrincipalname.Name = "txtPrincipalname";
            this.txtPrincipalname.ReadOnly = true;
            this.txtPrincipalname.Size = new System.Drawing.Size(484, 21);
            this.txtPrincipalname.TabIndex = 2;
            this.txtPrincipalname.Tag = "0";
            this.btxMsg.SetText(this.txtPrincipalname, "Principal Name cannot be blank");
            this.btxMsg.SetTitle(this.txtPrincipalname, null);
            // 
            // txtPayrollPrincipal
            // 
            this.txtPayrollPrincipal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPayrollPrincipal.Border.Class = "TextBoxBorder";
            this.txtPayrollPrincipal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPayrollPrincipal.FocusHighlightEnabled = true;
            this.txtPayrollPrincipal.ForeColor = System.Drawing.Color.Black;
            this.txtPayrollPrincipal.Location = new System.Drawing.Point(303, 96);
            this.txtPayrollPrincipal.Name = "txtPayrollPrincipal";
            this.txtPayrollPrincipal.ReadOnly = true;
            this.txtPayrollPrincipal.Size = new System.Drawing.Size(484, 21);
            this.txtPayrollPrincipal.TabIndex = 3;
            this.btxMsg.SetText(this.txtPayrollPrincipal, "Payroll Principal cannot be blank");
            this.btxMsg.SetTitle(this.txtPayrollPrincipal, null);
            this.txtPayrollPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayrollPrincipal_KeyDown);
            // 
            // txtPOEAprincipal
            // 
            this.txtPOEAprincipal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPOEAprincipal.Border.Class = "TextBoxBorder";
            this.txtPOEAprincipal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOEAprincipal.FocusHighlightEnabled = true;
            this.txtPOEAprincipal.ForeColor = System.Drawing.Color.Black;
            this.txtPOEAprincipal.Location = new System.Drawing.Point(303, 123);
            this.txtPOEAprincipal.Name = "txtPOEAprincipal";
            this.txtPOEAprincipal.ReadOnly = true;
            this.txtPOEAprincipal.Size = new System.Drawing.Size(484, 21);
            this.txtPOEAprincipal.TabIndex = 5;
            this.btxMsg.SetText(this.txtPOEAprincipal, "POEA principal cannot be blank");
            this.btxMsg.SetTitle(this.txtPOEAprincipal, null);
            this.txtPOEAprincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPOEAprincipal_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 416;
            this.label4.Text = "Principal Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 417;
            this.label5.Text = "Payroll Principal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 418;
            this.label6.Text = "POEA Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 421;
            this.label2.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 420;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 419;
            this.label8.Text = "Contact No.";
            // 
            // txtContactno
            // 
            this.txtContactno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtContactno.Border.Class = "TextBoxBorder";
            this.txtContactno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactno.FocusHighlightEnabled = true;
            this.txtContactno.ForeColor = System.Drawing.Color.Black;
            this.txtContactno.Location = new System.Drawing.Point(303, 204);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.ReadOnly = true;
            this.txtContactno.Size = new System.Drawing.Size(484, 21);
            this.txtContactno.TabIndex = 10;
            this.btxMsg.SetText(this.txtContactno, null);
            this.btxMsg.SetTitle(this.txtContactno, null);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmailAddress.Border.Class = "TextBoxBorder";
            this.txtEmailAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmailAddress.FocusHighlightEnabled = true;
            this.txtEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.txtEmailAddress.Location = new System.Drawing.Point(303, 177);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.ReadOnly = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(484, 21);
            this.txtEmailAddress.TabIndex = 9;
            this.btxMsg.SetText(this.txtEmailAddress, null);
            this.btxMsg.SetTitle(this.txtEmailAddress, null);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.FocusHighlightEnabled = true;
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(303, 150);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(484, 21);
            this.txtAddress.TabIndex = 8;
            this.btxMsg.SetText(this.txtAddress, null);
            this.btxMsg.SetTitle(this.txtAddress, null);
            // 
            // btnAccount
            // 
            this.btnAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAccount.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.Location = new System.Drawing.Point(766, 45);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(19, 18);
            this.btnAccount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnpayroll
            // 
            this.btnpayroll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnpayroll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnpayroll.Image = ((System.Drawing.Image)(resources.GetObject("btnpayroll.Image")));
            this.btnpayroll.Location = new System.Drawing.Point(766, 98);
            this.btnpayroll.Name = "btnpayroll";
            this.btnpayroll.Size = new System.Drawing.Size(19, 18);
            this.btnpayroll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnpayroll.TabIndex = 4;
            this.btnpayroll.Click += new System.EventHandler(this.btnpayroll_Click);
            // 
            // btnPOEA
            // 
            this.btnPOEA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPOEA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPOEA.Image = ((System.Drawing.Image)(resources.GetObject("btnPOEA.Image")));
            this.btnPOEA.Location = new System.Drawing.Point(766, 125);
            this.btnPOEA.Name = "btnPOEA";
            this.btnPOEA.Size = new System.Drawing.Size(19, 18);
            this.btnPOEA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPOEA.TabIndex = 6;
            this.btnPOEA.Click += new System.EventHandler(this.btnPOEA_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(303, 233);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 490;
            this.chkStatus.Text = "Active";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(796, 39);
            this.toolStrip2.TabIndex = 495;
            this.toolStrip2.Text = "toolStrip2";
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
            this.Add_btn.ToolTipText = "add record";
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
            this.Edit_btn.ToolTipText = "Edit selected record";
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
            this.print_btn.ToolTipText = "Print Records";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(400, 39);
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
            this.Save_btn.ToolTipText = "save record";
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
            this.cancel_btn.ToolTipText = " ";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // expAccount
            // 
            this.expAccount.CanvasColor = System.Drawing.SystemColors.Control;
            this.expAccount.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expAccount.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expAccount.Controls.Add(this.lsvAccount);
            this.expAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.expAccount.Expanded = false;
            this.expAccount.ExpandedBounds = new System.Drawing.Rectangle(0, 39, 417, 508);
            this.expAccount.ExpandOnTitleClick = true;
            this.expAccount.HideControlsWhenCollapsed = true;
            this.expAccount.Location = new System.Drawing.Point(0, 39);
            this.expAccount.Name = "expAccount";
            this.expAccount.Size = new System.Drawing.Size(30, 508);
            this.expAccount.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expAccount.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expAccount.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expAccount.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expAccount.Style.GradientAngle = 90;
            this.expAccount.TabIndex = 759;
            this.expAccount.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expAccount.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expAccount.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expAccount.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expAccount.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expAccount.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expAccount.TitleStyle.GradientAngle = 90;
            this.expAccount.TitleText = "List of account";
            // 
            // lsvAccount
            // 
            this.lsvAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lsvAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAccount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvAccount.FullRowSelect = true;
            this.lsvAccount.GridLines = true;
            this.lsvAccount.Location = new System.Drawing.Point(0, 26);
            this.lsvAccount.Name = "lsvAccount";
            this.lsvAccount.Size = new System.Drawing.Size(30, 482);
            this.lsvAccount.TabIndex = 5;
            this.lsvAccount.UseCompatibleStateImageBehavior = false;
            this.lsvAccount.View = System.Windows.Forms.View.Details;
            this.lsvAccount.SelectedIndexChanged += new System.EventHandler(this.lsvAccount_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account name";
            this.columnHeader3.Width = 380;
            // 
            // PrincipalMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.btnPOEA);
            this.Controls.Add(this.btnpayroll);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.expAccount);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtContactno);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPOEAprincipal);
            this.Controls.Add(this.txtPayrollPrincipal);
            this.Controls.Add(this.txtPrincipalname);
            this.Controls.Add(this.txtAccountname);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrincipalMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Master file";
            this.Load += new System.EventHandler(this.PrincipalMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrincipalMasterform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_Search.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.expAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel pan_Search;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader AccountName;
        internal System.Windows.Forms.ColumnHeader PrincipalName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtAccountname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPrincipalname;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPayrollPrincipal;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPOEAprincipal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtContactno;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtEmailAddress;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        internal DevComponents.DotNetBar.ButtonX btnAccount;
        internal DevComponents.DotNetBar.ButtonX btnpayroll;
        internal DevComponents.DotNetBar.ButtonX btnPOEA;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal DevComponents.DotNetBar.ExpandablePanel expAccount;
        internal System.Windows.Forms.ListView lsvAccount;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
    }
}