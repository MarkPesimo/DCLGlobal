namespace DCLGlobal.Master.CrewInfo
{
    partial class CrewDocumentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrewDocumentControl));
            this.txtDocumentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.tabGrid = new DevComponents.DotNetBar.SuperTabControl();
            this.panValid = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SuperTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.panExpired = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SuperTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.panRenewal = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SuperTabItem4 = new DevComponents.DotNetBar.SuperTabItem();
            this.panNoExpiration = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SuperTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            this.panOld = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SuperTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.txtNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIssuedBy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpIssued = new System.Windows.Forms.DateTimePicker();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDocumentType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlacedIssued = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPosition = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label11 = new System.Windows.Forms.Label();
            this.chkOriginal = new System.Windows.Forms.CheckBox();
            this.chkPhotocopies = new System.Windows.Forms.CheckBox();
            this.chkClienaccess = new System.Windows.Forms.CheckBox();
            this.cboVisaType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtScanDocs = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Delete_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.btnDetached = new System.Windows.Forms.Button();
            this.btnPlace = new DevComponents.DotNetBar.ButtonX();
            this.btnPosition = new DevComponents.DotNetBar.ButtonX();
            this.btnDocument = new DevComponents.DotNetBar.ButtonX();
            this.btnAttach = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrid)).BeginInit();
            this.tabGrid.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDocumentName.Border.Class = "TextBoxBorder";
            this.txtDocumentName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocumentName.FocusHighlightEnabled = true;
            this.txtDocumentName.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentName.Location = new System.Drawing.Point(108, 44);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.ReadOnly = true;
            this.txtDocumentName.Size = new System.Drawing.Size(307, 21);
            this.txtDocumentName.TabIndex = 0;
            this.txtDocumentName.Tag = "0";
            this.btxMsg.SetText(this.txtDocumentName, "Document cannot be blank");
            this.btxMsg.SetTitle(this.txtDocumentName, null);
            this.txtDocumentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumentName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 464;
            this.label4.Text = "Document Name";
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
            this.tabGrid.Controls.Add(this.panExpired);
            this.tabGrid.Controls.Add(this.panValid);
            this.tabGrid.Controls.Add(this.panRenewal);
            this.tabGrid.Controls.Add(this.panNoExpiration);
            this.tabGrid.Controls.Add(this.panOld);
            this.tabGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabGrid.ForeColor = System.Drawing.Color.Black;
            this.tabGrid.Location = new System.Drawing.Point(0, 248);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.ReorderTabsEnabled = false;
            this.tabGrid.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabGrid.SelectedTabIndex = 0;
            this.tabGrid.Size = new System.Drawing.Size(991, 354);
            this.tabGrid.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrid.TabIndex = 466;
            this.tabGrid.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.tabGrid.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SuperTabItem1,
            this.SuperTabItem2,
            this.SuperTabItem3,
            this.SuperTabItem4,
            this.SuperTabItem5});
            this.tabGrid.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
            this.tabGrid.Text = "SuperTabControl1";
            this.tabGrid.SelectedTabChanged += new System.EventHandler<DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs>(this.tabGrid_SelectedTabChanged);
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
            this.SuperTabItem1.Text = "Valid Document";
            // 
            // panExpired
            // 
            this.panExpired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panExpired.Location = new System.Drawing.Point(0, 27);
            this.panExpired.Name = "panExpired";
            this.panExpired.Size = new System.Drawing.Size(991, 327);
            this.panExpired.TabIndex = 0;
            this.panExpired.TabItem = this.SuperTabItem2;
            // 
            // SuperTabItem2
            // 
            this.SuperTabItem2.AttachedControl = this.panExpired;
            this.SuperTabItem2.GlobalItem = false;
            this.SuperTabItem2.Name = "SuperTabItem2";
            this.SuperTabItem2.Text = "Expired Document";
            // 
            // panRenewal
            // 
            this.panRenewal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRenewal.Location = new System.Drawing.Point(0, 0);
            this.panRenewal.Name = "panRenewal";
            this.panRenewal.Size = new System.Drawing.Size(991, 354);
            this.panRenewal.TabIndex = 0;
            this.panRenewal.TabItem = this.SuperTabItem4;
            // 
            // SuperTabItem4
            // 
            this.SuperTabItem4.AttachedControl = this.panRenewal;
            this.SuperTabItem4.GlobalItem = false;
            this.SuperTabItem4.Name = "SuperTabItem4";
            this.SuperTabItem4.Text = "For Renewal";
            // 
            // panNoExpiration
            // 
            this.panNoExpiration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panNoExpiration.Location = new System.Drawing.Point(0, 0);
            this.panNoExpiration.Name = "panNoExpiration";
            this.panNoExpiration.Size = new System.Drawing.Size(991, 354);
            this.panNoExpiration.TabIndex = 0;
            this.panNoExpiration.TabItem = this.SuperTabItem5;
            // 
            // SuperTabItem5
            // 
            this.SuperTabItem5.AttachedControl = this.panNoExpiration;
            this.SuperTabItem5.GlobalItem = false;
            this.SuperTabItem5.Name = "SuperTabItem5";
            this.SuperTabItem5.Text = "No Expiration";
            // 
            // panOld
            // 
            this.panOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panOld.Location = new System.Drawing.Point(0, 0);
            this.panOld.Name = "panOld";
            this.panOld.Size = new System.Drawing.Size(991, 354);
            this.panOld.TabIndex = 0;
            this.panOld.TabItem = this.SuperTabItem3;
            // 
            // SuperTabItem3
            // 
            this.SuperTabItem3.AttachedControl = this.panOld;
            this.SuperTabItem3.GlobalItem = false;
            this.SuperTabItem3.Name = "SuperTabItem3";
            this.SuperTabItem3.Text = "Old Document";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNumber.Border.Class = "TextBoxBorder";
            this.txtNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumber.FocusHighlightEnabled = true;
            this.txtNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.Location = new System.Drawing.Point(520, 44);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(307, 21);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Tag = "0";
            this.btxMsg.SetText(this.txtNumber, "Number cannot be blank");
            this.btxMsg.SetTitle(this.txtNumber, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 467;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 469;
            this.label2.Text = "Visa Type";
            // 
            // txtIssuedBy
            // 
            this.txtIssuedBy.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIssuedBy.Border.Class = "TextBoxBorder";
            this.txtIssuedBy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIssuedBy.FocusHighlightEnabled = true;
            this.txtIssuedBy.ForeColor = System.Drawing.Color.Black;
            this.txtIssuedBy.Location = new System.Drawing.Point(108, 150);
            this.txtIssuedBy.Name = "txtIssuedBy";
            this.txtIssuedBy.ReadOnly = true;
            this.txtIssuedBy.Size = new System.Drawing.Size(307, 21);
            this.txtIssuedBy.TabIndex = 12;
            this.txtIssuedBy.Tag = "0";
            this.btxMsg.SetText(this.txtIssuedBy, null);
            this.btxMsg.SetTitle(this.txtIssuedBy, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 471;
            this.label3.Text = "Issued By";
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
            this.txtRemarks.Location = new System.Drawing.Point(108, 175);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(719, 39);
            this.txtRemarks.TabIndex = 15;
            this.txtRemarks.Tag = "0";
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 473;
            this.label5.Text = "Remarks";
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
            // dtpExpired
            // 
            this.dtpExpired.Enabled = false;
            this.dtpExpired.Location = new System.Drawing.Point(108, 97);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.ShowCheckBox = true;
            this.dtpExpired.Size = new System.Drawing.Size(307, 21);
            this.dtpExpired.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 477;
            this.label6.Text = "Date Issued";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 478;
            this.label7.Text = "Date Expired";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 479;
            this.label8.Text = "Document Type";
            // 
            // cboDocumentType
            // 
            this.cboDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumentType.Enabled = false;
            this.cboDocumentType.FormattingEnabled = true;
            this.cboDocumentType.Items.AddRange(new object[] {
            "Travel",
            "Other",
            "Old"});
            this.cboDocumentType.Location = new System.Drawing.Point(520, 71);
            this.cboDocumentType.Name = "cboDocumentType";
            this.cboDocumentType.Size = new System.Drawing.Size(307, 21);
            this.cboDocumentType.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 481;
            this.label9.Text = "Document Copy";
            // 
            // txtPlacedIssued
            // 
            this.txtPlacedIssued.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPlacedIssued.Border.Class = "TextBoxBorder";
            this.txtPlacedIssued.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlacedIssued.FocusHighlightEnabled = true;
            this.txtPlacedIssued.ForeColor = System.Drawing.Color.Black;
            this.txtPlacedIssued.Location = new System.Drawing.Point(520, 149);
            this.txtPlacedIssued.Name = "txtPlacedIssued";
            this.txtPlacedIssued.ReadOnly = true;
            this.txtPlacedIssued.Size = new System.Drawing.Size(307, 21);
            this.txtPlacedIssued.TabIndex = 13;
            this.txtPlacedIssued.Tag = "0";
            this.btxMsg.SetText(this.txtPlacedIssued, "Place issued cannot be blank");
            this.btxMsg.SetTitle(this.txtPlacedIssued, null);
            this.txtPlacedIssued.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlacedIssued_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 484;
            this.label10.Text = "Placed Issued";
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPosition.Border.Class = "TextBoxBorder";
            this.txtPosition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPosition.FocusHighlightEnabled = true;
            this.txtPosition.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.Location = new System.Drawing.Point(520, 123);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(307, 21);
            this.txtPosition.TabIndex = 10;
            this.txtPosition.Tag = "0";
            this.btxMsg.SetText(this.txtPosition, null);
            this.btxMsg.SetTitle(this.txtPosition, null);
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 482;
            this.label11.Text = "Rank";
            // 
            // chkOriginal
            // 
            this.chkOriginal.AutoSize = true;
            this.chkOriginal.Enabled = false;
            this.chkOriginal.Location = new System.Drawing.Point(520, 99);
            this.chkOriginal.Name = "chkOriginal";
            this.chkOriginal.Size = new System.Drawing.Size(62, 17);
            this.chkOriginal.TabIndex = 6;
            this.chkOriginal.Text = "Original";
            this.chkOriginal.UseVisualStyleBackColor = true;
            // 
            // chkPhotocopies
            // 
            this.chkPhotocopies.AutoSize = true;
            this.chkPhotocopies.Enabled = false;
            this.chkPhotocopies.Location = new System.Drawing.Point(606, 98);
            this.chkPhotocopies.Name = "chkPhotocopies";
            this.chkPhotocopies.Size = new System.Drawing.Size(84, 17);
            this.chkPhotocopies.TabIndex = 7;
            this.chkPhotocopies.Text = "Photocopies";
            this.chkPhotocopies.UseVisualStyleBackColor = true;
            // 
            // chkClienaccess
            // 
            this.chkClienaccess.AutoSize = true;
            this.chkClienaccess.Enabled = false;
            this.chkClienaccess.Location = new System.Drawing.Point(702, 98);
            this.chkClienaccess.Name = "chkClienaccess";
            this.chkClienaccess.Size = new System.Drawing.Size(89, 17);
            this.chkClienaccess.TabIndex = 8;
            this.chkClienaccess.Text = "Client Access";
            this.chkClienaccess.UseVisualStyleBackColor = true;
            // 
            // cboVisaType
            // 
            this.cboVisaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisaType.Enabled = false;
            this.cboVisaType.FormattingEnabled = true;
            this.cboVisaType.Items.AddRange(new object[] {
            "BUSINESS",
            "OTHERS",
            "TRANSIT",
            "WORKING",
            "N/A",
            ""});
            this.cboVisaType.Location = new System.Drawing.Point(108, 123);
            this.cboVisaType.Name = "cboVisaType";
            this.cboVisaType.Size = new System.Drawing.Size(307, 21);
            this.cboVisaType.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 490;
            this.label12.Text = "Scanned Documents";
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
            this.txtScanDocs.Location = new System.Drawing.Point(108, 220);
            this.txtScanDocs.Name = "txtScanDocs";
            this.txtScanDocs.ReadOnly = true;
            this.txtScanDocs.Size = new System.Drawing.Size(691, 21);
            this.txtScanDocs.TabIndex = 16;
            this.txtScanDocs.Tag = "0";
            this.btxMsg.SetText(this.txtScanDocs, null);
            this.btxMsg.SetTitle(this.txtScanDocs, null);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.Delete_btn,
            this.Save_btn,
            this.cancel_btn,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(991, 39);
            this.toolStrip1.TabIndex = 494;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 36);
            this.toolStripLabel1.Text = "Crew Document";
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
            this.StatusStrip1.TabIndex = 769;
            this.StatusStrip1.Text = "StatusStrip1";
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
            // Delete_btn
            // 
            this.Delete_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_btn.Image")));
            this.Delete_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Delete_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(36, 36);
            this.Delete_btn.Text = "toolStripButton3";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
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
            // btnDetached
            // 
            this.btnDetached.Image = ((System.Drawing.Image)(resources.GetObject("btnDetached.Image")));
            this.btnDetached.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetached.Location = new System.Drawing.Point(897, 216);
            this.btnDetached.Name = "btnDetached";
            this.btnDetached.Size = new System.Drawing.Size(91, 26);
            this.btnDetached.TabIndex = 18;
            this.btnDetached.Text = "Detached";
            this.btnDetached.UseVisualStyleBackColor = true;
            this.btnDetached.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPlace.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPlace.Image = ((System.Drawing.Image)(resources.GetObject("btnPlace.Image")));
            this.btnPlace.Location = new System.Drawing.Point(806, 151);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(19, 18);
            this.btnPlace.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPlace.TabIndex = 14;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPosition.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnPosition.Image")));
            this.btnPosition.Location = new System.Drawing.Point(806, 125);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(19, 18);
            this.btnPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPosition.TabIndex = 11;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnDocument
            // 
            this.btnDocument.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDocument.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnDocument.Image")));
            this.btnDocument.Location = new System.Drawing.Point(394, 46);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(19, 18);
            this.btnDocument.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDocument.TabIndex = 1;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.Location = new System.Drawing.Point(805, 216);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(91, 26);
            this.btnAttach.TabIndex = 17;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(832, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 463;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel7.Image")));
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(41, 16);
            this.toolStripStatusLabel7.Text = "Info.";
            // 
            // CrewDocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDetached);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDocument);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtScanDocs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboVisaType);
            this.Controls.Add(this.chkClienaccess);
            this.Controls.Add(this.chkPhotocopies);
            this.Controls.Add(this.chkOriginal);
            this.Controls.Add(this.txtPlacedIssued);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboDocumentType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpExpired);
            this.Controls.Add(this.dtpIssued);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIssuedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabGrid);
            this.Controls.Add(this.txtDocumentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CrewDocumentControl";
            this.Size = new System.Drawing.Size(991, 624);
            this.Load += new System.EventHandler(this.CrewDocumentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabGrid)).EndInit();
            this.tabGrid.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDocumentName;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.SuperTabControl tabGrid;
        internal DevComponents.DotNetBar.SuperTabControlPanel panValid;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem1;
        internal DevComponents.DotNetBar.SuperTabControlPanel panNoExpiration;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem5;
        internal DevComponents.DotNetBar.SuperTabControlPanel panRenewal;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem4;
        internal DevComponents.DotNetBar.SuperTabControlPanel panOld;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem3;
        internal DevComponents.DotNetBar.SuperTabControlPanel panExpired;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtIssuedBy;
        private System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpIssued;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDocumentType;
        private System.Windows.Forms.Label label9;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPlacedIssued;
        private System.Windows.Forms.Label label10;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkOriginal;
        private System.Windows.Forms.CheckBox chkPhotocopies;
        private System.Windows.Forms.CheckBox chkClienaccess;
        private System.Windows.Forms.ComboBox cboVisaType;
        private System.Windows.Forms.Label label12;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtScanDocs;
        private System.Windows.Forms.Button btnAttach;
        internal DevComponents.DotNetBar.ButtonX btnDocument;
        internal DevComponents.DotNetBar.ButtonX btnPosition;
        internal DevComponents.DotNetBar.ButtonX btnPlace;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Button btnDetached;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Delete_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;

    }
}
