namespace DCLGlobal.Master.Main
{
    partial class DocumentCheckListMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentCheckListMasterform));
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.lsvPrincipal = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClinicName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPrincipal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDocument = new DevComponents.DotNetBar.ButtonX();
            this.txtDocument = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.cboDoctype = new System.Windows.Forms.ComboBox();
            this.chkRequired = new System.Windows.Forms.CheckBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.delete_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.panPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.lsvPrincipal);
            this.panPrincipal.Controls.Add(this.txtSearch);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panPrincipal.Location = new System.Drawing.Point(0, 39);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(280, 471);
            this.panPrincipal.TabIndex = 401;
            // 
            // lsvPrincipal
            // 
            this.lsvPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.columnHeader1});
            this.lsvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPrincipal.FullRowSelect = true;
            this.lsvPrincipal.GridLines = true;
            this.lsvPrincipal.Location = new System.Drawing.Point(0, 21);
            this.lsvPrincipal.Name = "lsvPrincipal";
            this.lsvPrincipal.Size = new System.Drawing.Size(280, 450);
            this.lsvPrincipal.TabIndex = 1;
            this.lsvPrincipal.UseCompatibleStateImageBehavior = false;
            this.lsvPrincipal.View = System.Windows.Forms.View.Details;
            this.lsvPrincipal.SelectedIndexChanged += new System.EventHandler(this.lsvPrincipal_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Principal Name";
            this.columnHeader1.Width = 254;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.FocusHighlightEnabled = true;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 21);
            this.txtSearch.TabIndex = 0;
            this.btxMsg.SetText(this.txtSearch, null);
            this.btxMsg.SetTitle(this.txtSearch, null);
            this.txtSearch.GotFocus += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.LostFocus += new System.EventHandler(this.txtSearch_LostFocus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(286, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 402;
            this.pictureBox1.TabStop = false;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.ColumnHeader3,
            this.ClinicName,
            this.Address,
            this.columnHeader2});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(280, 201);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(793, 309);
            this.lvList.TabIndex = 403;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.SelectedIndexChanged += new System.EventHandler(this.lvSearch_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            this.columnHeader4.Width = 0;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Rank";
            this.ColumnHeader3.Width = 107;
            // 
            // ClinicName
            // 
            this.ClinicName.Text = "Document Group";
            this.ClinicName.Width = 196;
            // 
            // Address
            // 
            this.Address.Text = "Document Type";
            this.Address.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Document Name";
            this.columnHeader2.Width = 327;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPrincipal.Border.Class = "TextBoxBorder";
            this.txtPrincipal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrincipal.FocusHighlightEnabled = true;
            this.txtPrincipal.ForeColor = System.Drawing.Color.Black;
            this.txtPrincipal.Location = new System.Drawing.Point(553, 44);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ReadOnly = true;
            this.txtPrincipal.Size = new System.Drawing.Size(508, 21);
            this.txtPrincipal.TabIndex = 2;
            this.btxMsg.SetText(this.txtPrincipal, null);
            this.btxMsg.SetTitle(this.txtPrincipal, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 405;
            this.label1.Text = "Principal Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 406;
            this.label2.Text = "Rank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 407;
            this.label3.Text = "Document Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 408;
            this.label4.Text = "Document Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 409;
            this.label5.Text = "Document";
            // 
            // btnDocument
            // 
            this.btnDocument.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDocument.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDocument.Image = ((System.Drawing.Image)(resources.GetObject("btnDocument.Image")));
            this.btnDocument.Location = new System.Drawing.Point(1040, 154);
            this.btnDocument.Name = "btnDocument";
            this.btnDocument.Size = new System.Drawing.Size(19, 18);
            this.btnDocument.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDocument.TabIndex = 8;
            this.btnDocument.Click += new System.EventHandler(this.btnDocument_Click);
            // 
            // txtDocument
            // 
            this.txtDocument.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDocument.Border.Class = "TextBoxBorder";
            this.txtDocument.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocument.FocusHighlightEnabled = true;
            this.txtDocument.ForeColor = System.Drawing.Color.Black;
            this.txtDocument.Location = new System.Drawing.Point(553, 152);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ReadOnly = true;
            this.txtDocument.Size = new System.Drawing.Size(508, 21);
            this.txtDocument.TabIndex = 7;
            this.btxMsg.SetText(this.txtDocument, "Document cannot be blank");
            this.btxMsg.SetTitle(this.txtDocument, null);
            // 
            // cboRank
            // 
            this.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank.Enabled = false;
            this.cboRank.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Items.AddRange(new object[] {
            "Officer",
            "Rating"});
            this.cboRank.Location = new System.Drawing.Point(553, 71);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(193, 21);
            this.cboRank.TabIndex = 3;
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.Enabled = false;
            this.cboGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "TRAVEL DOCS",
            "VISAS",
            "MEDICAL & VACCINES",
            "LICENSES",
            "TRAININGS",
            "REQUIRED TRAINING (BY CLIENT)",
            "ADDITIONAL REQUIREMENTS",
            "PICTURE",
            "ALLOTEMENT"});
            this.cboGroup.Location = new System.Drawing.Point(553, 98);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(193, 21);
            this.cboGroup.TabIndex = 4;
            // 
            // cboDoctype
            // 
            this.cboDoctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoctype.Enabled = false;
            this.cboDoctype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctype.FormattingEnabled = true;
            this.cboDoctype.Items.AddRange(new object[] {
            "Document",
            "License",
            "Training",
            "Medical"});
            this.cboDoctype.Location = new System.Drawing.Point(553, 125);
            this.cboDoctype.Name = "cboDoctype";
            this.cboDoctype.Size = new System.Drawing.Size(193, 21);
            this.cboDoctype.TabIndex = 5;
            // 
            // chkRequired
            // 
            this.chkRequired.AutoSize = true;
            this.chkRequired.Enabled = false;
            this.chkRequired.Location = new System.Drawing.Point(769, 128);
            this.chkRequired.Name = "chkRequired";
            this.chkRequired.Size = new System.Drawing.Size(78, 17);
            this.chkRequired.TabIndex = 6;
            this.chkRequired.Text = "Mandatory";
            this.chkRequired.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.delete_btn,
            this.print_btn,
            this.Save_btn,
            this.cancel_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1073, 39);
            this.toolStrip1.TabIndex = 413;
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
            // delete_btn
            // 
            this.delete_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.delete_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(36, 36);
            this.delete_btn.Text = "toolStripButton3";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.Text = "toolStripButton4";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
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
            this.Save_btn.Text = "toolStripButton5";
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
            this.cancel_btn.Text = "toolStripButton6";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // DocumentCheckListMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 510);
            this.Controls.Add(this.chkRequired);
            this.Controls.Add(this.cboDoctype);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.cboRank);
            this.Controls.Add(this.btnDocument);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DocumentCheckListMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Check List Master";
            this.Load += new System.EventHandler(this.DocumentCheckListMasterform_Load);
            this.panPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ListView lvList;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ClinicName;
        internal System.Windows.Forms.ColumnHeader Address;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader4;
        internal System.Windows.Forms.ListView lsvPrincipal;
        internal System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDocument;
        internal DevComponents.DotNetBar.ButtonX btnDocument;
        internal System.Windows.Forms.ComboBox cboRank;
        internal System.Windows.Forms.ComboBox cboGroup;
        internal System.Windows.Forms.ComboBox cboDoctype;
        private System.Windows.Forms.CheckBox chkRequired;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton delete_btn;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
    }
}