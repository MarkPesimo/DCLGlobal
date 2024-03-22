namespace DCLGlobal.Master.Main
{
    partial class VesselMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VesselMasterform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrincipalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtyearbuilt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtclassification = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtofficialno = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvesseltype = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtvesselname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrincipalname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprincipal = new DevComponents.DotNetBar.ButtonX();
            this.txtgrosstonage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttraderoute = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtenginetype = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtkilowatt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcountry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtenginecapacity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btncountry = new DevComponents.DotNetBar.ButtonX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
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
            this.toolStrip2.SuspendLayout();
            this.expPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(39, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 402;
            this.pictureBox1.TabStop = false;
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(30, 256);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(861, 334);
            this.pan_Search.TabIndex = 403;
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
            this.lsvList.Size = new System.Drawing.Size(861, 334);
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
            this.PrincipalName.Text = "Vessel name";
            this.PrincipalName.Width = 346;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 110;
            // 
            // txtyearbuilt
            // 
            this.txtyearbuilt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtyearbuilt.Border.Class = "TextBoxBorder";
            this.txtyearbuilt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtyearbuilt.FocusHighlightEnabled = true;
            this.txtyearbuilt.ForeColor = System.Drawing.Color.Black;
            this.txtyearbuilt.Location = new System.Drawing.Point(626, 125);
            this.txtyearbuilt.Name = "txtyearbuilt";
            this.txtyearbuilt.ReadOnly = true;
            this.txtyearbuilt.Size = new System.Drawing.Size(252, 21);
            this.txtyearbuilt.TabIndex = 6;
            this.btxMsg.SetText(this.txtyearbuilt, null);
            this.btxMsg.SetTitle(this.txtyearbuilt, null);
            // 
            // txtclassification
            // 
            this.txtclassification.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtclassification.Border.Class = "TextBoxBorder";
            this.txtclassification.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtclassification.FocusHighlightEnabled = true;
            this.txtclassification.ForeColor = System.Drawing.Color.Black;
            this.txtclassification.Location = new System.Drawing.Point(294, 125);
            this.txtclassification.Name = "txtclassification";
            this.txtclassification.ReadOnly = true;
            this.txtclassification.Size = new System.Drawing.Size(252, 21);
            this.txtclassification.TabIndex = 5;
            this.btxMsg.SetText(this.txtclassification, null);
            this.btxMsg.SetTitle(this.txtclassification, null);
            // 
            // txtofficialno
            // 
            this.txtofficialno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtofficialno.Border.Class = "TextBoxBorder";
            this.txtofficialno.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtofficialno.FocusHighlightEnabled = true;
            this.txtofficialno.ForeColor = System.Drawing.Color.Black;
            this.txtofficialno.Location = new System.Drawing.Point(626, 98);
            this.txtofficialno.Name = "txtofficialno";
            this.txtofficialno.ReadOnly = true;
            this.txtofficialno.Size = new System.Drawing.Size(252, 21);
            this.txtofficialno.TabIndex = 4;
            this.btxMsg.SetText(this.txtofficialno, null);
            this.btxMsg.SetTitle(this.txtofficialno, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 435;
            this.label2.Text = "Classification";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 434;
            this.label7.Text = "Official no.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 433;
            this.label8.Text = "Year built";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 432;
            this.label6.Text = "Vessel type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 431;
            this.label5.Text = "Vessel name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 430;
            this.label4.Text = "Principal Name";
            // 
            // txtvesseltype
            // 
            this.txtvesseltype.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtvesseltype.Border.Class = "TextBoxBorder";
            this.txtvesseltype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvesseltype.FocusHighlightEnabled = true;
            this.txtvesseltype.ForeColor = System.Drawing.Color.Black;
            this.txtvesseltype.Location = new System.Drawing.Point(294, 98);
            this.txtvesseltype.Name = "txtvesseltype";
            this.txtvesseltype.ReadOnly = true;
            this.txtvesseltype.Size = new System.Drawing.Size(252, 21);
            this.txtvesseltype.TabIndex = 3;
            this.btxMsg.SetText(this.txtvesseltype, null);
            this.btxMsg.SetTitle(this.txtvesseltype, null);
            // 
            // txtvesselname
            // 
            this.txtvesselname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtvesselname.Border.Class = "TextBoxBorder";
            this.txtvesselname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtvesselname.FocusHighlightEnabled = true;
            this.txtvesselname.ForeColor = System.Drawing.Color.Black;
            this.txtvesselname.Location = new System.Drawing.Point(294, 71);
            this.txtvesselname.Name = "txtvesselname";
            this.txtvesselname.ReadOnly = true;
            this.txtvesselname.Size = new System.Drawing.Size(584, 21);
            this.txtvesselname.TabIndex = 2;
            this.btxMsg.SetText(this.txtvesselname, "vessel name cannot be blank");
            this.btxMsg.SetTitle(this.txtvesselname, null);
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
            this.txtPrincipalname.Location = new System.Drawing.Point(294, 44);
            this.txtPrincipalname.Name = "txtPrincipalname";
            this.txtPrincipalname.ReadOnly = true;
            this.txtPrincipalname.Size = new System.Drawing.Size(584, 21);
            this.txtPrincipalname.TabIndex = 0;
            this.txtPrincipalname.Tag = "0";
            this.btxMsg.SetText(this.txtPrincipalname, "Principal name cannot be blank");
            this.btxMsg.SetTitle(this.txtPrincipalname, null);
            this.txtPrincipalname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrincipalname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 426;
            this.label3.Text = "Status";
            // 
            // btnprincipal
            // 
            this.btnprincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnprincipal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnprincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnprincipal.Image")));
            this.btnprincipal.Location = new System.Drawing.Point(857, 46);
            this.btnprincipal.Name = "btnprincipal";
            this.btnprincipal.Size = new System.Drawing.Size(19, 18);
            this.btnprincipal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnprincipal.TabIndex = 1;
            this.btnprincipal.Click += new System.EventHandler(this.btnprincipal_Click);
            // 
            // txtgrosstonage
            // 
            this.txtgrosstonage.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtgrosstonage.Border.Class = "TextBoxBorder";
            this.txtgrosstonage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtgrosstonage.FocusHighlightEnabled = true;
            this.txtgrosstonage.ForeColor = System.Drawing.Color.Black;
            this.txtgrosstonage.Location = new System.Drawing.Point(626, 152);
            this.txtgrosstonage.Name = "txtgrosstonage";
            this.txtgrosstonage.ReadOnly = true;
            this.txtgrosstonage.Size = new System.Drawing.Size(252, 21);
            this.txtgrosstonage.TabIndex = 8;
            this.btxMsg.SetText(this.txtgrosstonage, null);
            this.btxMsg.SetTitle(this.txtgrosstonage, null);
            // 
            // txttraderoute
            // 
            this.txttraderoute.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttraderoute.Border.Class = "TextBoxBorder";
            this.txttraderoute.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttraderoute.FocusHighlightEnabled = true;
            this.txttraderoute.ForeColor = System.Drawing.Color.Black;
            this.txttraderoute.Location = new System.Drawing.Point(294, 152);
            this.txttraderoute.Name = "txttraderoute";
            this.txttraderoute.ReadOnly = true;
            this.txttraderoute.Size = new System.Drawing.Size(252, 21);
            this.txttraderoute.TabIndex = 7;
            this.btxMsg.SetText(this.txttraderoute, null);
            this.btxMsg.SetTitle(this.txttraderoute, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 441;
            this.label1.Text = "Trade route";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 440;
            this.label9.Text = "Gross tonage";
            // 
            // txtenginetype
            // 
            this.txtenginetype.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtenginetype.Border.Class = "TextBoxBorder";
            this.txtenginetype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtenginetype.FocusHighlightEnabled = true;
            this.txtenginetype.ForeColor = System.Drawing.Color.Black;
            this.txtenginetype.Location = new System.Drawing.Point(626, 179);
            this.txtenginetype.Name = "txtenginetype";
            this.txtenginetype.ReadOnly = true;
            this.txtenginetype.Size = new System.Drawing.Size(252, 21);
            this.txtenginetype.TabIndex = 10;
            this.btxMsg.SetText(this.txtenginetype, null);
            this.btxMsg.SetTitle(this.txtenginetype, null);
            // 
            // txtkilowatt
            // 
            this.txtkilowatt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtkilowatt.Border.Class = "TextBoxBorder";
            this.txtkilowatt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtkilowatt.FocusHighlightEnabled = true;
            this.txtkilowatt.ForeColor = System.Drawing.Color.Black;
            this.txtkilowatt.Location = new System.Drawing.Point(294, 179);
            this.txtkilowatt.Name = "txtkilowatt";
            this.txtkilowatt.ReadOnly = true;
            this.txtkilowatt.Size = new System.Drawing.Size(252, 21);
            this.txtkilowatt.TabIndex = 9;
            this.btxMsg.SetText(this.txtkilowatt, null);
            this.btxMsg.SetTitle(this.txtkilowatt, null);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 445;
            this.label10.Text = "Kilo watt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(556, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 444;
            this.label11.Text = "Engine type";
            // 
            // txtcountry
            // 
            this.txtcountry.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcountry.Border.Class = "TextBoxBorder";
            this.txtcountry.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcountry.FocusHighlightEnabled = true;
            this.txtcountry.ForeColor = System.Drawing.Color.Black;
            this.txtcountry.Location = new System.Drawing.Point(626, 206);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.ReadOnly = true;
            this.txtcountry.Size = new System.Drawing.Size(252, 21);
            this.txtcountry.TabIndex = 12;
            this.btxMsg.SetText(this.txtcountry, "Country cannot be blank");
            this.btxMsg.SetTitle(this.txtcountry, null);
            this.txtcountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcountry_KeyDown);
            // 
            // txtenginecapacity
            // 
            this.txtenginecapacity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtenginecapacity.Border.Class = "TextBoxBorder";
            this.txtenginecapacity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtenginecapacity.FocusHighlightEnabled = true;
            this.txtenginecapacity.ForeColor = System.Drawing.Color.Black;
            this.txtenginecapacity.Location = new System.Drawing.Point(294, 206);
            this.txtenginecapacity.Name = "txtenginecapacity";
            this.txtenginecapacity.ReadOnly = true;
            this.txtenginecapacity.Size = new System.Drawing.Size(252, 21);
            this.txtenginecapacity.TabIndex = 11;
            this.btxMsg.SetText(this.txtenginecapacity, null);
            this.btxMsg.SetTitle(this.txtenginecapacity, null);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 449;
            this.label12.Text = "Engine capacity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(574, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 448;
            this.label13.Text = "Country";
            // 
            // btncountry
            // 
            this.btncountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btncountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btncountry.Image = ((System.Drawing.Image)(resources.GetObject("btncountry.Image")));
            this.btncountry.Location = new System.Drawing.Point(857, 208);
            this.btncountry.Name = "btncountry";
            this.btncountry.Size = new System.Drawing.Size(19, 18);
            this.btncountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btncountry.TabIndex = 13;
            this.btncountry.Click += new System.EventHandler(this.btncountry_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(294, 235);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 488;
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
            this.toolStrip2.Size = new System.Drawing.Size(891, 39);
            this.toolStrip2.TabIndex = 543;
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
            this.Add_btn.ToolTipText = "Add Record";
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
            this.Edit_btn.ToolTipText = "Edit Selected Record";
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
            this.Search_txt.Size = new System.Drawing.Size(350, 39);
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
            this.Save_btn.ToolTipText = "Save Record";
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
            this.expPrincipal.ExpandedBounds = new System.Drawing.Rectangle(0, 39, 417, 551);
            this.expPrincipal.ExpandOnTitleClick = true;
            this.expPrincipal.HideControlsWhenCollapsed = true;
            this.expPrincipal.Location = new System.Drawing.Point(0, 39);
            this.expPrincipal.Name = "expPrincipal";
            this.expPrincipal.Size = new System.Drawing.Size(30, 551);
            this.expPrincipal.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expPrincipal.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expPrincipal.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expPrincipal.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expPrincipal.Style.GradientAngle = 90;
            this.expPrincipal.TabIndex = 761;
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
            this.lsvPrincipal.Size = new System.Drawing.Size(30, 525);
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
            // VesselMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 590);
            this.Controls.Add(this.btncountry);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtenginetype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtgrosstonage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnprincipal);
            this.Controls.Add(this.txtyearbuilt);
            this.Controls.Add(this.txtofficialno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.expPrincipal);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.txtenginecapacity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtkilowatt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttraderoute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclassification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvesseltype);
            this.Controls.Add(this.txtvesselname);
            this.Controls.Add(this.txtPrincipalname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VesselMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vessel Master file";
            this.Load += new System.EventHandler(this.VesselMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VesselMasterform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pan_Search.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.expPrincipal.ResumeLayout(false);
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
        internal DevComponents.DotNetBar.Controls.TextBoxX txtyearbuilt;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtclassification;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtofficialno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtvesseltype;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtvesselname;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPrincipalname;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.ButtonX btnprincipal;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtgrosstonage;
        internal DevComponents.DotNetBar.Controls.TextBoxX txttraderoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtenginetype;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtkilowatt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtcountry;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtenginecapacity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        internal DevComponents.DotNetBar.ButtonX btncountry;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ToolStrip toolStrip2;
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