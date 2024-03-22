namespace DCLGlobal.Master.Main
{
    partial class PositionMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionMasterform));
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtPrincipalname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpositionname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPOEAposition = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtJobDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDepartment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrincipalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnprincipal = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPOEA = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJD = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPositionType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.expPrincipal = new DevComponents.DotNetBar.ExpandablePanel();
            this.lsvPrincipal = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pan_Search.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.expPrincipal.SuspendLayout();
            this.SuspendLayout();
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
            this.txtPrincipalname.Location = new System.Drawing.Point(280, 44);
            this.txtPrincipalname.Name = "txtPrincipalname";
            this.txtPrincipalname.ReadOnly = true;
            this.txtPrincipalname.Size = new System.Drawing.Size(584, 21);
            this.txtPrincipalname.TabIndex = 0;
            this.txtPrincipalname.Tag = "0";
            this.btxMsg.SetText(this.txtPrincipalname, "Principal name cannot be blank");
            this.btxMsg.SetTitle(this.txtPrincipalname, null);
            this.txtPrincipalname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipalname_KeyDown);
            // 
            // txtpositionname
            // 
            this.txtpositionname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpositionname.Border.Class = "TextBoxBorder";
            this.txtpositionname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpositionname.FocusHighlightEnabled = true;
            this.txtpositionname.ForeColor = System.Drawing.Color.Black;
            this.txtpositionname.Location = new System.Drawing.Point(280, 71);
            this.txtpositionname.Name = "txtpositionname";
            this.txtpositionname.ReadOnly = true;
            this.txtpositionname.Size = new System.Drawing.Size(584, 21);
            this.txtpositionname.TabIndex = 2;
            this.btxMsg.SetText(this.txtpositionname, "Position name cannot be blank");
            this.btxMsg.SetTitle(this.txtpositionname, null);
            // 
            // txtPOEAposition
            // 
            this.txtPOEAposition.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPOEAposition.Border.Class = "TextBoxBorder";
            this.txtPOEAposition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOEAposition.FocusHighlightEnabled = true;
            this.txtPOEAposition.ForeColor = System.Drawing.Color.Black;
            this.txtPOEAposition.Location = new System.Drawing.Point(280, 98);
            this.txtPOEAposition.Name = "txtPOEAposition";
            this.txtPOEAposition.ReadOnly = true;
            this.txtPOEAposition.Size = new System.Drawing.Size(584, 21);
            this.txtPOEAposition.TabIndex = 3;
            this.txtPOEAposition.Tag = "0";
            this.btxMsg.SetText(this.txtPOEAposition, "POEA Position cannot be blank");
            this.btxMsg.SetTitle(this.txtPOEAposition, null);
            this.txtPOEAposition.TextChanged += new System.EventHandler(this.txtPOEAposition_TextChanged);
            this.txtPOEAposition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPOEAposition_KeyDown);
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJobDescription.Border.Class = "TextBoxBorder";
            this.txtJobDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJobDescription.FocusHighlightEnabled = true;
            this.txtJobDescription.ForeColor = System.Drawing.Color.Black;
            this.txtJobDescription.Location = new System.Drawing.Point(280, 125);
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.ReadOnly = true;
            this.txtJobDescription.Size = new System.Drawing.Size(584, 21);
            this.txtJobDescription.TabIndex = 5;
            this.txtJobDescription.Tag = "0";
            this.btxMsg.SetText(this.txtJobDescription, "Job Description cannot be blank");
            this.btxMsg.SetTitle(this.txtJobDescription, null);
            this.txtJobDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJobDescription_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDescription.Border.Class = "TextBoxBorder";
            this.txtDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDescription.FocusHighlightEnabled = true;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(282, 180);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(584, 62);
            this.txtDescription.TabIndex = 9;
            this.btxMsg.SetText(this.txtDescription, "");
            this.btxMsg.SetTitle(this.txtDescription, null);
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDepartment.Border.Class = "TextBoxBorder";
            this.txtDepartment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDepartment.FocusHighlightEnabled = true;
            this.txtDepartment.ForeColor = System.Drawing.Color.Black;
            this.txtDepartment.Location = new System.Drawing.Point(282, 248);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(584, 21);
            this.txtDepartment.TabIndex = 10;
            this.btxMsg.SetText(this.txtDepartment, "");
            this.btxMsg.SetTitle(this.txtDepartment, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(37, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 404;
            this.pictureBox1.TabStop = false;
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(30, 298);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(846, 223);
            this.pan_Search.TabIndex = 405;
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
            this.lsvList.Size = new System.Drawing.Size(846, 223);
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
            this.AccountName.Text = "Principal Name";
            this.AccountName.Width = 351;
            // 
            // PrincipalName
            // 
            this.PrincipalName.Text = "Position name";
            this.PrincipalName.Width = 346;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 110;
            // 
            // btnprincipal
            // 
            this.btnprincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnprincipal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnprincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnprincipal.Image")));
            this.btnprincipal.Location = new System.Drawing.Point(843, 46);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Size = new System.Drawing.Size(19, 18);
            this.btnprincipal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnprincipal.TabIndex = 1;
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 441;
            this.label4.Text = "Principal Name";
            // 
            // btnPOEA
            // 
            this.btnPOEA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPOEA.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPOEA.Image = ((System.Drawing.Image)(resources.GetObject("btnPOEA.Image")));
            this.btnPOEA.Location = new System.Drawing.Point(843, 100);
            this.btnPOEA.Name = "btnPOEA";
            this.btnPOEA.Size = new System.Drawing.Size(19, 18);
            this.btnPOEA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPOEA.TabIndex = 4;
            this.btnPOEA.Click += new System.EventHandler(this.btnPOEA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 446;
            this.label5.Text = "Position name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 445;
            this.label1.Text = "POEA position";
            // 
            // btnJD
            // 
            this.btnJD.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnJD.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnJD.Image = ((System.Drawing.Image)(resources.GetObject("btnJD.Image")));
            this.btnJD.Location = new System.Drawing.Point(843, 127);
            this.btnJD.Name = "btnJD";
            this.btnJD.Size = new System.Drawing.Size(19, 18);
            this.btnJD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnJD.TabIndex = 6;
            this.btnJD.Click += new System.EventHandler(this.btnJD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 449;
            this.label2.Text = "Job  Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 452;
            this.label3.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 453;
            this.label6.Text = "Position Type";
            // 
            // cboPositionType
            // 
            this.cboPositionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPositionType.Enabled = false;
            this.cboPositionType.FormattingEnabled = true;
            this.cboPositionType.Items.AddRange(new object[] {
            "Deck",
            "Engine",
            "Service"});
            this.cboPositionType.Location = new System.Drawing.Point(282, 153);
            this.cboPositionType.Name = "cboPositionType";
            this.cboPositionType.Size = new System.Drawing.Size(235, 21);
            this.cboPositionType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 455;
            this.label7.Text = "Rank";
            // 
            // cboRank
            // 
            this.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank.Enabled = false;
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Items.AddRange(new object[] {
            "Rank & File",
            "Officer",
            "Highly Skilled",
            "Rating"});
            this.cboRank.Location = new System.Drawing.Point(629, 152);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(235, 21);
            this.cboRank.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 457;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(237, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 459;
            this.label9.Text = "Status";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(282, 276);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 491;
            this.chkStatus.Text = "Active";
            this.chkStatus.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(876, 39);
            this.toolStrip1.TabIndex = 492;
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
            this.Add_btn.ToolTipText = "add Record";
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
            this.Edit_btn.ToolTipText = "edit selected record";
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
            this.print_btn.ToolTipText = "print records";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(400, 39);
            this.Search_txt.GotFocus += new System.EventHandler(this.Search_txt_GotFocus);
            this.Search_txt.LostFocus += new System.EventHandler(this.Search_txt_LostFocus);
            this.Search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_txt_KeyDown);
            this.Search_txt.Click += new System.EventHandler(this.Search_txt_Click);
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
            // expPrincipal
            // 
            this.expPrincipal.CanvasColor = System.Drawing.SystemColors.Control;
            this.expPrincipal.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expPrincipal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expPrincipal.Controls.Add(this.lsvPrincipal);
            this.expPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.expPrincipal.Expanded = false;
            this.expPrincipal.ExpandedBounds = new System.Drawing.Rectangle(0, 39, 417, 482);
            this.expPrincipal.ExpandOnTitleClick = true;
            this.expPrincipal.HideControlsWhenCollapsed = true;
            this.expPrincipal.Location = new System.Drawing.Point(0, 39);
            this.expPrincipal.Name = "expPrincipal";
            this.expPrincipal.Size = new System.Drawing.Size(30, 482);
            this.expPrincipal.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expPrincipal.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expPrincipal.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expPrincipal.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expPrincipal.Style.GradientAngle = 90;
            this.expPrincipal.TabIndex = 760;
            this.expPrincipal.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expPrincipal.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expPrincipal.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expPrincipal.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expPrincipal.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expPrincipal.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expPrincipal.TitleStyle.GradientAngle = 90;
            this.expPrincipal.TitleText = "List of Principal";
            // 
            // lsvPrincipal
            // 
            this.lsvPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lsvPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPrincipal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvPrincipal.FullRowSelect = true;
            this.lsvPrincipal.GridLines = true;
            this.lsvPrincipal.Location = new System.Drawing.Point(0, 26);
            this.lsvPrincipal.Name = "lsvPrincipal";
            this.lsvPrincipal.Size = new System.Drawing.Size(30, 456);
            this.lsvPrincipal.TabIndex = 5;
            this.lsvPrincipal.UseCompatibleStateImageBehavior = false;
            this.lsvPrincipal.View = System.Windows.Forms.View.Details;
            this.lsvPrincipal.SelectedIndexChanged += new System.EventHandler(this.lsvPrincipal_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Principal Name";
            this.columnHeader3.Width = 380;
            // 
            // PositionMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 521);
            this.Controls.Add(this.cboRank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnJD);
            this.Controls.Add(this.btnPOEA);
            this.Controls.Add(this.btnprincipal);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.expPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboPositionType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpositionname);
            this.Controls.Add(this.txtPOEAposition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrincipalname);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PositionMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Position Master file";
            this.Load += new System.EventHandler(this.PositionMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PositionMasterform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_Search.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.expPrincipal.ResumeLayout(false);
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
        internal DevComponents.DotNetBar.ButtonX btnprincipal;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPrincipalname;
        internal DevComponents.DotNetBar.ButtonX btnPOEA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtpositionname;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPOEAposition;
        internal DevComponents.DotNetBar.ButtonX btnJD;
        private System.Windows.Forms.Label label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtJobDescription;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboPositionType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRank;
        private System.Windows.Forms.Label label8;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal DevComponents.DotNetBar.ExpandablePanel expPrincipal;
        internal System.Windows.Forms.ListView lsvPrincipal;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
    }
}