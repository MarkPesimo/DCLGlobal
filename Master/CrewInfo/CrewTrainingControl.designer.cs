namespace DCLGlobal.Master.CrewInfo
{
    partial class CrewTrainingControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrewTrainingControl));
            this.tabGrid = new DevComponents.DotNetBar.SuperTabControl();
            this.SuperTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.grdValidTraining = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SuperTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.SuperTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.txtTrainingName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrainingCenter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlace = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.chkClienaccess = new System.Windows.Forms.CheckBox();
            this.chkPhotocopies = new System.Windows.Forms.CheckBox();
            this.chkOriginal = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.dtpIssued = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNAC = new System.Windows.Forms.DateTimePicker();
            this.txtScanDocs = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRemarks = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlace = new DevComponents.DotNetBar.ButtonX();
            this.btnTrainingCenter = new DevComponents.DotNetBar.ButtonX();
            this.btnTraining = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetached = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Delete_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabGrid)).BeginInit();
            this.tabGrid.SuspendLayout();
            this.SuperTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdValidTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
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
            this.tabGrid.Controls.Add(this.SuperTabControlPanel1);
            this.tabGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabGrid.ForeColor = System.Drawing.Color.Black;
            this.tabGrid.Location = new System.Drawing.Point(0, 254);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.ReorderTabsEnabled = false;
            this.tabGrid.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabGrid.SelectedTabIndex = 0;
            this.tabGrid.Size = new System.Drawing.Size(991, 348);
            this.tabGrid.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGrid.TabIndex = 470;
            this.tabGrid.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit;
            this.tabGrid.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SuperTabItem1});
            this.tabGrid.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Document;
            this.tabGrid.Text = "SuperTabControl1";
            // 
            // SuperTabControlPanel1
            // 
            this.SuperTabControlPanel1.Controls.Add(this.grdValidTraining);
            this.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperTabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.SuperTabControlPanel1.Name = "SuperTabControlPanel1";
            this.SuperTabControlPanel1.Size = new System.Drawing.Size(991, 321);
            this.SuperTabControlPanel1.TabIndex = 1;
            this.SuperTabControlPanel1.TabItem = this.SuperTabItem1;
            // 
            // grdValidTraining
            // 
            this.grdValidTraining.AllowUserToAddRows = false;
            this.grdValidTraining.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdValidTraining.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdValidTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdValidTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column12,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Column11});
            this.grdValidTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdValidTraining.Location = new System.Drawing.Point(0, 0);
            this.grdValidTraining.Name = "grdValidTraining";
            this.grdValidTraining.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdValidTraining.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdValidTraining.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdValidTraining.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grdValidTraining.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdValidTraining.Size = new System.Drawing.Size(991, 321);
            this.grdValidTraining.TabIndex = 172;
            this.grdValidTraining.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdValidTraining_CellContentClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "id";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            this.Column10.Width = 5;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 60;
            // 
            // Column5
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.HeaderText = "View";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Training Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 270;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Training Center";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Place";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Date Issued";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NAC Rev. Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "";
            this.Column11.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 25;
            // 
            // SuperTabItem1
            // 
            this.SuperTabItem1.AttachedControl = this.SuperTabControlPanel1;
            this.SuperTabItem1.GlobalItem = false;
            this.SuperTabItem1.Name = "SuperTabItem1";
            this.SuperTabItem1.Text = "Training List";
            // 
            // SuperTabItem2
            // 
            this.SuperTabItem2.GlobalItem = false;
            this.SuperTabItem2.Name = "SuperTabItem2";
            this.SuperTabItem2.Text = "Expired Training";
            // 
            // txtTrainingName
            // 
            this.txtTrainingName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTrainingName.Border.Class = "TextBoxBorder";
            this.txtTrainingName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTrainingName.FocusHighlightEnabled = true;
            this.txtTrainingName.ForeColor = System.Drawing.Color.Black;
            this.txtTrainingName.Location = new System.Drawing.Point(108, 44);
            this.txtTrainingName.Name = "txtTrainingName";
            this.txtTrainingName.ReadOnly = true;
            this.txtTrainingName.Size = new System.Drawing.Size(307, 21);
            this.txtTrainingName.TabIndex = 0;
            this.txtTrainingName.Tag = "0";
            this.btxMsg.SetText(this.txtTrainingName, "Training cannot be blank");
            this.btxMsg.SetTitle(this.txtTrainingName, null);
            this.txtTrainingName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrainingName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 496;
            this.label4.Text = "Training Name";
            // 
            // txtTrainingCenter
            // 
            this.txtTrainingCenter.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTrainingCenter.Border.Class = "TextBoxBorder";
            this.txtTrainingCenter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTrainingCenter.FocusHighlightEnabled = true;
            this.txtTrainingCenter.ForeColor = System.Drawing.Color.Black;
            this.txtTrainingCenter.Location = new System.Drawing.Point(517, 44);
            this.txtTrainingCenter.Name = "txtTrainingCenter";
            this.txtTrainingCenter.ReadOnly = true;
            this.txtTrainingCenter.Size = new System.Drawing.Size(307, 21);
            this.txtTrainingCenter.TabIndex = 2;
            this.txtTrainingCenter.Tag = "0";
            this.btxMsg.SetText(this.txtTrainingCenter, "Training center cannot be blank");
            this.btxMsg.SetTitle(this.txtTrainingCenter, null);
            this.txtTrainingCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrainingCenter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 499;
            this.label1.Text = "Training Center";
            // 
            // txtPlace
            // 
            this.txtPlace.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPlace.Border.Class = "TextBoxBorder";
            this.txtPlace.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlace.FocusHighlightEnabled = true;
            this.txtPlace.ForeColor = System.Drawing.Color.Black;
            this.txtPlace.Location = new System.Drawing.Point(108, 71);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.ReadOnly = true;
            this.txtPlace.Size = new System.Drawing.Size(307, 21);
            this.txtPlace.TabIndex = 4;
            this.txtPlace.Tag = "0";
            this.btxMsg.SetText(this.txtPlace, "Place cannot be blank");
            this.btxMsg.SetTitle(this.txtPlace, null);
            this.txtPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlace_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 502;
            this.label2.Text = "Place";
            // 
            // chkClienaccess
            // 
            this.chkClienaccess.AutoSize = true;
            this.chkClienaccess.Enabled = false;
            this.chkClienaccess.Location = new System.Drawing.Point(293, 125);
            this.chkClienaccess.Name = "chkClienaccess";
            this.chkClienaccess.Size = new System.Drawing.Size(89, 17);
            this.chkClienaccess.TabIndex = 11;
            this.chkClienaccess.Text = "Client Access";
            this.chkClienaccess.UseVisualStyleBackColor = true;
            // 
            // chkPhotocopies
            // 
            this.chkPhotocopies.AutoSize = true;
            this.chkPhotocopies.Enabled = false;
            this.chkPhotocopies.Location = new System.Drawing.Point(197, 125);
            this.chkPhotocopies.Name = "chkPhotocopies";
            this.chkPhotocopies.Size = new System.Drawing.Size(84, 17);
            this.chkPhotocopies.TabIndex = 10;
            this.chkPhotocopies.Text = "Photocopies";
            this.chkPhotocopies.UseVisualStyleBackColor = true;
            // 
            // chkOriginal
            // 
            this.chkOriginal.AutoSize = true;
            this.chkOriginal.Enabled = false;
            this.chkOriginal.Location = new System.Drawing.Point(111, 126);
            this.chkOriginal.Name = "chkOriginal";
            this.chkOriginal.Size = new System.Drawing.Size(62, 17);
            this.chkOriginal.TabIndex = 9;
            this.chkOriginal.Text = "Original";
            this.chkOriginal.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 505;
            this.label9.Text = "Training Copy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 512;
            this.label7.Text = "Date Expired";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 511;
            this.label6.Text = "Date Issued";
            // 
            // dtpExpired
            // 
            this.dtpExpired.Enabled = false;
            this.dtpExpired.Location = new System.Drawing.Point(517, 99);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.ShowCheckBox = true;
            this.dtpExpired.Size = new System.Drawing.Size(307, 21);
            this.dtpExpired.TabIndex = 8;
            // 
            // dtpIssued
            // 
            this.dtpIssued.Enabled = false;
            this.dtpIssued.Location = new System.Drawing.Point(108, 98);
            this.dtpIssued.Name = "dtpIssued";
            this.dtpIssued.ShowCheckBox = true;
            this.dtpIssued.Size = new System.Drawing.Size(307, 21);
            this.dtpIssued.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 514;
            this.label3.Text = "NAC Rev Date";
            // 
            // dtpNAC
            // 
            this.dtpNAC.Enabled = false;
            this.dtpNAC.Location = new System.Drawing.Point(517, 71);
            this.dtpNAC.Name = "dtpNAC";
            this.dtpNAC.ShowCheckBox = true;
            this.dtpNAC.Size = new System.Drawing.Size(307, 21);
            this.dtpNAC.TabIndex = 6;
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
            this.txtScanDocs.Location = new System.Drawing.Point(111, 221);
            this.txtScanDocs.Name = "txtScanDocs";
            this.txtScanDocs.ReadOnly = true;
            this.txtScanDocs.Size = new System.Drawing.Size(690, 21);
            this.txtScanDocs.TabIndex = 13;
            this.txtScanDocs.Tag = "0";
            this.btxMsg.SetText(this.txtScanDocs, null);
            this.btxMsg.SetTitle(this.txtScanDocs, null);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 517;
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
            this.txtRemarks.Location = new System.Drawing.Point(111, 149);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(715, 66);
            this.txtRemarks.TabIndex = 12;
            this.txtRemarks.Tag = "0";
            this.btxMsg.SetText(this.txtRemarks, null);
            this.btxMsg.SetTitle(this.txtRemarks, null);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 515;
            this.label5.Text = "Remarks";
            // 
            // btnPlace
            // 
            this.btnPlace.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPlace.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPlace.Image = ((System.Drawing.Image)(resources.GetObject("btnPlace.Image")));
            this.btnPlace.Location = new System.Drawing.Point(394, 73);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(19, 18);
            this.btnPlace.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPlace.TabIndex = 5;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnTrainingCenter
            // 
            this.btnTrainingCenter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrainingCenter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTrainingCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnTrainingCenter.Image")));
            this.btnTrainingCenter.Location = new System.Drawing.Point(803, 46);
            this.btnTrainingCenter.Name = "btnTrainingCenter";
            this.btnTrainingCenter.Size = new System.Drawing.Size(19, 18);
            this.btnTrainingCenter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrainingCenter.TabIndex = 3;
            this.btnTrainingCenter.Click += new System.EventHandler(this.btnTrainingCenter_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTraining.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTraining.Image = ((System.Drawing.Image)(resources.GetObject("btnTraining.Image")));
            this.btnTraining.Location = new System.Drawing.Point(394, 46);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(19, 18);
            this.btnTraining.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTraining.TabIndex = 1;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(832, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 469;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetached
            // 
            this.btnDetached.Image = ((System.Drawing.Image)(resources.GetObject("btnDetached.Image")));
            this.btnDetached.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetached.Location = new System.Drawing.Point(897, 218);
            this.btnDetached.Name = "btnDetached";
            this.btnDetached.Size = new System.Drawing.Size(91, 26);
            this.btnDetached.TabIndex = 15;
            this.btnDetached.Text = "Detached";
            this.btnDetached.UseVisualStyleBackColor = true;
            this.btnDetached.Click += new System.EventHandler(this.btnDetached_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttach.Location = new System.Drawing.Point(805, 218);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(91, 26);
            this.btnAttach.TabIndex = 14;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.Delete_btn,
            this.Save_btn,
            this.cancel_btn,
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(991, 39);
            this.toolStrip3.TabIndex = 518;
            this.toolStrip3.Text = "toolStrip3";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 36);
            this.toolStripLabel1.Text = "Crew Trainings";
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
            this.StatusStrip1.TabIndex = 771;
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
            // CrewTrainingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.btnDetached);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtScanDocs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNAC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpExpired);
            this.Controls.Add(this.dtpIssued);
            this.Controls.Add(this.chkClienaccess);
            this.Controls.Add(this.chkPhotocopies);
            this.Controls.Add(this.chkOriginal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrainingCenter);
            this.Controls.Add(this.txtTrainingCenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.txtTrainingName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CrewTrainingControl";
            this.Size = new System.Drawing.Size(991, 624);
            this.Load += new System.EventHandler(this.CrewTrainingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabGrid)).EndInit();
            this.tabGrid.ResumeLayout(false);
            this.SuperTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdValidTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.SuperTabControl tabGrid;
        internal DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel1;
        internal System.Windows.Forms.DataGridView grdValidTraining;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem1;
        internal DevComponents.DotNetBar.SuperTabItem SuperTabItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtTrainingName;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.ButtonX btnTraining;
        internal DevComponents.DotNetBar.ButtonX btnTrainingCenter;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtTrainingCenter;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.ButtonX btnPlace;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkClienaccess;
        private System.Windows.Forms.CheckBox chkPhotocopies;
        private System.Windows.Forms.CheckBox chkOriginal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.DateTimePicker dtpIssued;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNAC;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtScanDocs;
        private System.Windows.Forms.Label label12;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDetached;
        private System.Windows.Forms.Button btnAttach;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Delete_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewLinkColumn Column12;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column11;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
    }
}
