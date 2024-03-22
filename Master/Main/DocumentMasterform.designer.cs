namespace DCLGlobal.Master.Main
{
    partial class DocumentMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentMasterform));
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDocumentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.pan_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 201);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(789, 343);
            this.pan_Search.TabIndex = 404;
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AccountName,
            this.columnHeader2,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(789, 343);
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
            this.AccountName.Text = "License Name";
            this.AccountName.Width = 429;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Document Type";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 405;
            this.pictureBox1.TabStop = false;
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
            this.txtDocumentName.Location = new System.Drawing.Point(279, 44);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.ReadOnly = true;
            this.txtDocumentName.Size = new System.Drawing.Size(502, 21);
            this.txtDocumentName.TabIndex = 452;
            this.txtDocumentName.Tag = "0";
            this.btxMsg.SetText(this.txtDocumentName, "Document name cannot be blank");
            this.btxMsg.SetTitle(this.txtDocumentName, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 449;
            this.label4.Text = "Document Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 455;
            this.label13.Text = "Status";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Enabled = false;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "National",
            "Travel"});
            this.cboType.Location = new System.Drawing.Point(279, 72);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(294, 21);
            this.cboType.TabIndex = 456;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 457;
            this.label1.Text = "Document Type";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(279, 100);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 487;
            this.chkStatus.Text = "Active";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(789, 39);
            this.ToolStrip1.TabIndex = 545;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Add_btn
            // 
            this.Add_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_btn.Image")));
            this.Add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(36, 36);
            this.Add_btn.Text = "Add";
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
            this.Edit_btn.Text = "Edit";
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
            this.print_btn.Text = "Print";
            this.print_btn.ToolTipText = "Print Records";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Save_btn.Text = "Save";
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
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // DocumentMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 544);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDocumentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pan_Search);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DocumentMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Master file";
            this.Load += new System.EventHandler(this.DocumentMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DocumentMasterform_KeyDown);
            this.pan_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pan_Search;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader AccountName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDocumentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkStatus;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
    }
}