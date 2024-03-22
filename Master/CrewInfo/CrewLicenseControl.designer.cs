namespace DCLGlobal.Master.CrewInfo
{
    partial class CrewLicenseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrewLicenseControl));
            this.tabGrid = new DevComponents.DotNetBar.SuperTabControl();
            this.panExpired = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.panValid = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SuperTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.SuperTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.dtpIssued = new System.Windows.Forms.DateTimePicker();
            this.txtCapacity = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicenceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegulation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLimitation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScanDocs = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.chkClienaccess = new System.Windows.Forms.CheckBox();
            this.chkPhotocopies = new System.Windows.Forms.CheckBox();
            this.chkOriginal = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.add_btn = new System.Windows.Forms.ToolStripButton();
            this.edit_btn = new System.Windows.Forms.ToolStripButton();
            this.delete_btn = new System.Windows.Forms.ToolStripButton();
            this.save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDetached = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnCountry = new DevComponents.DotNetBar.ButtonX();
            this.btnLicense = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrid)).BeginInit();
            this.tabGrid.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGrid
            // 
            this.tabGrid.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabGrid.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabGrid.ControlBox.MenuBox.Name = "";
            this.tabGrid.ControlBox.Name = "";
            this.tabGrid.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabGrid.ControlBox.MenuBox,
            this.tabGrid.ControlBox.CloseBox});
            this.tabGrid.Controls.Add(this.panValid);
            this.tabGrid.Controls.Add(this.panExpired);
            this.tabGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabGrid.ForeColor = System.Drawing.Color.Black;
            this.tabGrid.Location = new System.Drawing.Point(0, 248);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.ReorderTabsEnabled = false;
            this.tabGrid.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabGrid.SelectedTabIndex = 0;
            this.tabGrid.Size = new System.Drawing.Size(991, 354);
            this.tabGrid.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrid.TabIndex = 467;
            this.tabGrid.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.tabGrid.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SuperTabItem1,
            this.superTabItem3});
            this.tabGrid.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
            this.tabGrid.Text = "SuperTabControl1";
            this.tabGrid.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tabGrid_SelectedTabChanged);
            // 
            // panExpired
            // 
            this.panExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panExpired.Location = new System.Drawing.Point(0, 27);
            this.panExpired.Name = "panExpired";
            this.panExpired.Size = new System.Drawing.Size(991, 327);
            this.panExpired.TabIndex = 0;
            this.panExpired.TabItem = this.superTabItem3;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.panExpired;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "Expired License";
            // 
            // panValid
            // 
            this.panValid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panValid.Location = new System.Drawing.Point(0, 27);
            this.panValid.Name = "panValid";
            this.panValid.Size = new System.Drawing.Size(991, 327);
            this.panValid.TabIndex = 1;
            this.panValid.TabItem = this.SuperTabItem1;
            // 
            // SuperTabItem1
            // 
            this.SuperTabItem1.AttachedControl = this.panValid;
            this.SuperTabItem1.GlobalItem = false;
            this.SuperTabItem1.Name = "SuperTabItem1";
            this.SuperTabItem1.Text = "Valid License";
            // 
            // SuperTabItem2
            // 
            this.SuperTabItem2.GlobalItem = false;
            this.SuperTabItem2.Name = "SuperTabItem2";
            this.SuperTabItem2.Text = "Expired License";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 501;
            this.label7.Text = "Date Expired";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 500;
            this.label6.Text = "Date Issued";
            // 
            // dtpExpired
            // 
            this.dtpExpired.Enabled = false;
            this.dtpExpired.Location = new System.Drawing.Point(523, 71);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.ShowCheckBox = true;
            this.dtpExpired.Size = new System.Drawing.Size(303, 21);
            this.dtpExpired.TabIndex = 4;
            // 
            // dtpIssued
            // 
            this.dtpIssued.Enabled = false;
            this.dtpIssued.Location = new System.Drawing.Point(108, 71);
            this.dtpIssued.Name = "dtpIssued";
            this.dtpIssued.ShowCheckBox = true;
            this.dtpIssued.Size = new System.Drawing.Size(307, 21);
            this.dtpIssued.TabIndex = 3;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCapacity.Border.Class = "TextBoxBorder";
            this.txtCapacity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCapacity.FocusHighlightEnabled = true;
            this.txtCapacity.ForeColor = System.Drawing.Color.Black;
            this.txtCapacity.Location = new System.Drawing.Point(523, 44);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(303, 21);
            this.txtCapacity.TabIndex = 2;
            this.txtCapacity.Tag = "0";
            this.btxMsg.SetText(this.txtCapacity, null);
            this.btxMsg.SetTitle(this.txtCapacity, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 496;
            this.label1.Text = "Capacity";
            // 
            // txtLicenceName
            // 
            this.txtLicenceName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicenceName.Border.Class = "TextBoxBorder";
            this.txtLicenceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicenceName.FocusHighlightEnabled = true;
            this.txtLicenceName.ForeColor = System.Drawing.Color.Black;
            this.txtLicenceName.Location = new System.Drawing.Point(108, 44);
            this.txtLicenceName.Name = "txtLicenceName";
            this.txtLicenceName.ReadOnly = true;
            this.txtLicenceName.Size = new System.Drawing.Size(307, 21);
            this.txtLicenceName.TabIndex = 0;
            this.txtLicenceName.Tag = "0";
            this.btxMsg.SetText(this.txtLicenceName, "License name cannot be blank");
            this.btxMsg.SetTitle(this.txtLicenceName, null);
            this.txtLicenceName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLicenceName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 494;
            this.label4.Text = "Licence Name";
            // 
            // txtRegulation
            // 
            this.txtRegulation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRegulation.Border.Class = "TextBoxBorder";
            this.txtRegulation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRegulation.FocusHighlightEnabled = true;
            this.txtRegulation.ForeColor = System.Drawing.Color.Black;
            this.txtRegulation.Location = new System.Drawing.Point(108, 98);
            this.txtRegulation.Name = "txtRegulation";
            this.txtRegulation.ReadOnly = true;
            this.txtRegulation.Size = new System.Drawing.Size(307, 21);
            this.txtRegulation.TabIndex = 5;
            this.txtRegulation.Tag = "0";
            this.btxMsg.SetText(this.txtRegulation, null);
            this.btxMsg.SetTitle(this.txtRegulation, null);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 503;
            this.label2.Text = "Regulation";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCountry.Border.Class = "TextBoxBorder";
            this.txtCountry.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCountry.FocusHighlightEnabled = true;
            this.txtCountry.ForeColor = System.Drawing.Color.Black;
            this.txtCountry.Location = new System.Drawing.Point(523, 98);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(302, 21);
            this.txtCountry.TabIndex = 6;
            this.txtCountry.Tag = "0";
            this.btxMsg.SetText(this.txtCountry, "country cannot be blank");
            this.btxMsg.SetTitle(this.txtCountry, null);
            this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountry_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 505;
            this.label3.Text = "Country";
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnumber.Border.Class = "TextBoxBorder";
            this.txtnumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnumber.FocusHighlightEnabled = true;
            this.txtnumber.ForeColor = System.Drawing.Color.Black;
            this.txtnumber.Location = new System.Drawing.Point(108, 125);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.ReadOnly = true;
            this.txtnumber.Size = new System.Drawing.Size(307, 21);
            this.txtnumber.TabIndex = 8;
            this.txtnumber.Tag = "0";
            this.btxMsg.SetText(this.txtnumber, null);
            this.btxMsg.SetTitle(this.txtnumber, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 508;
            this.label5.Text = "Number";
            // 
            // txtLimitation
            // 
            this.txtLimitation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLimitation.Border.Class = "TextBoxBorder";
            this.txtLimitation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLimitation.FocusHighlightEnabled = true;
            this.txtLimitation.ForeColor = System.Drawing.Color.Black;
            this.txtLimitation.Location = new System.Drawing.Point(523, 125);
            this.txtLimitation.Name = "txtLimitation";
            this.txtLimitation.ReadOnly = true;
            this.txtLimitation.Size = new System.Drawing.Size(303, 21);
            this.txtLimitation.TabIndex = 9;
            this.txtLimitation.Tag = "0";
            this.btxMsg.SetText(this.txtLimitation, null);
            this.btxMsg.SetTitle(this.txtLimitation, null);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 510;
            this.label8.Text = "Limitation";
            // 
            // txtScanDocs
            // 
            this.txtScanDocs.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtScanDocs.Border.Class = "TextBoxBorder";
            this.txtScanDocs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtScanDocs.FocusHighlightEnabled = true;
            this.txtScanDocs.ForeColor = System.Drawing.Color.Black;
            this.txtScanDocs.Location = new System.Drawing.Point(108, 218);
            this.txtScanDocs.Name = "txtScanDocs";
            this.txtScanDocs.ReadOnly = true;
            this.txtScanDocs.Size = new System.Drawing.Size(691, 21);
            this.txtScanDocs.TabIndex = 15;
            this.txtScanDocs.Tag = "0";
            this.btxMsg.SetText(this.txtScanDocs, null);
            this.btxMsg.SetTitle(this.txtScanDocs, null);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 514;
            this.label12.Text = "Scanned Documents";
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
            this.txtRemarks.Location = new System.Drawing.Point(108, 174);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(718, 40);
            this.txtRemarks.TabIndex = 14;
            this.txtRemarks.Tag = "0";
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 512;
            this.label9.Text = "Remarks";
            // 
            // chkClienaccess
            // 
            this.chkClienaccess.AutoSize = true;
            this.chkClienaccess.Enabled = false;
            this.chkClienaccess.Location = new System.Drawing.Point(291, 151);
            this.chkClienaccess.Name = "chkClienaccess";
            this.chkClienaccess.Size = new System.Drawing.Size(89, 17);
            this.chkClienaccess.TabIndex = 12;
            this.chkClienaccess.Text = "Client Access";
            this.chkClienaccess.UseVisualStyleBackColor = true;
            // 
            // chkPhotocopies
            // 
            this.chkPhotocopies.AutoSize = true;
            this.chkPhotocopies.Enabled = false;
            this.chkPhotocopies.Location = new System.Drawing.Point(195, 151);
            this.chkPhotocopies.Name = "chkPhotocopies";
            this.chkPhotocopies.Size = new System.Drawing.Size(84, 17);
            this.chkPhotocopies.TabIndex = 11;
            this.chkPhotocopies.Text = "Photocopies";
            this.chkPhotocopies.UseVisualStyleBackColor = true;
            // 
            // chkOriginal
            // 
            this.chkOriginal.AutoSize = true;
            this.chkOriginal.Enabled = false;
            this.chkOriginal.Location = new System.Drawing.Point(109, 152);
            this.chkOriginal.Name = "chkOriginal";
            this.chkOriginal.Size = new System.Drawing.Size(62, 17);
            this.chkOriginal.TabIndex = 10;
            this.chkOriginal.Text = "Original";
            this.chkOriginal.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 517;
            this.label10.Text = "License Copy";
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_btn,
            this.edit_btn,
            this.delete_btn,
            this.save_btn,
            this.cancel_btn,
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(991, 39);
            this.toolStrip3.TabIndex = 524;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // add_btn
            // 
            this.add_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(36, 36);
            this.add_btn.Text = "toolStripButton1";
            this.add_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edit_btn.Image = ((System.Drawing.Image)(resources.GetObject("edit_btn.Image")));
            this.edit_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(36, 36);
            this.edit_btn.Text = "toolStripButton2";
            this.edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.delete_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(36, 36);
            this.delete_btn.Text = "toolStripButton3";
            this.delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_btn.Enabled = false;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.save_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(36, 36);
            this.save_btn.Text = "toolStripButton4";
            this.save_btn.Click += new System.EventHandler(this.Save_btn_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 36);
            this.toolStripLabel1.Text = "Crew Licenses";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel9,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 602);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(991, 22);
            this.StatusStrip1.TabIndex = 770;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel7.Image")));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel7.Text = "Info.";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(205, 17);
            this.toolStripStatusLabel6.Text = "** Click on the view column to view the details";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel9.Text = "|";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(277, 17);
            this.ToolStripStatusLabel2.Text = "** Click on the Open file to open the attached scanned document";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.ToolStripStatusLabel1.Text = "|";
            // 
            // btnDetached
            // 
            this.btnDetached.Image = ((System.Drawing.Image)(resources.GetObject("btnDetached.Image")));
            this.btnDetached.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetached.Location = new System.Drawing.Point(897, 215);
            this.btnDetached.Name = "btnDetached";
            this.btnDetached.Size = new System.Drawing.Size(91, 26);
            this.btnDetached.TabIndex = 523;
            this.btnDetached.Text = "Detached";
            this.btnDetached.UseVisualStyleBackColor = true;
            this.btnDetached.Click += new System.EventHandler(this.btnDetached_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.Location = new System.Drawing.Point(805, 215);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(91, 26);
            this.btnAttach.TabIndex = 522;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnCountry.Image")));
            this.btnCountry.Location = new System.Drawing.Point(804, 100);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(19, 18);
            this.btnCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCountry.TabIndex = 7;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnLicense
            // 
            this.btnLicense.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLicense.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnLicense.Image")));
            this.btnLicense.Location = new System.Drawing.Point(394, 46);
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.Size = new System.Drawing.Size(19, 18);
            this.btnLicense.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLicense.TabIndex = 1;
            this.btnLicense.Click += new System.EventHandler(this.btnLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(832, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 465;
            this.pictureBox1.TabStop = false;
            // 
            // CrewLicenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.btnDetached);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.chkClienaccess);
            this.Controls.Add(this.chkPhotocopies);
            this.Controls.Add(this.chkOriginal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtScanDocs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLimitation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegulation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLicense);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpExpired);
            this.Controls.Add(this.dtpIssued);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLicenceName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CrewLicenseControl";
            this.Size = new System.Drawing.Size(991, 624);
            this.Load += new System.EventHandler(this.CrewLicenseControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabGrid)).EndInit();
            this.tabGrid.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal DevComponents.DotNetBar.SuperTabControl tabGrid;
        internal DevComponents.DotNetBar.SuperTabControlPanel panValid;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem1;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem2;
        internal DevComponents.DotNetBar.ButtonX btnLicense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.DateTimePicker dtpIssued;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCapacity;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtLicenceName;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRegulation;
        private System.Windows.Forms.Label label2;
        internal DevComponents.DotNetBar.ButtonX btnCountry;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCountry;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtnumber;
        private System.Windows.Forms.Label label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtLimitation;
        private System.Windows.Forms.Label label8;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtScanDocs;
        private System.Windows.Forms.Label label12;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkClienaccess;
        private System.Windows.Forms.CheckBox chkPhotocopies;
        private System.Windows.Forms.CheckBox chkOriginal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDetached;
        private System.Windows.Forms.Button btnAttach;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton add_btn;
        private System.Windows.Forms.ToolStripButton edit_btn;
        private System.Windows.Forms.ToolStripButton delete_btn;
        private System.Windows.Forms.ToolStripButton save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private DevComponents.DotNetBar.SuperTabControlPanel panExpired;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
    }
}
