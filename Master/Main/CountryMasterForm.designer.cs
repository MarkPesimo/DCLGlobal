namespace DCLGlobal.Master.Main
{
    partial class CountryMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountryMasterForm));
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrincipalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNationality = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCountry = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPOEACountry = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
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
            this.pan_Search.Size = new System.Drawing.Size(778, 334);
            this.pan_Search.TabIndex = 406;
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
            this.lsvList.Size = new System.Drawing.Size(778, 334);
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
            this.AccountName.Text = "Country";
            this.AccountName.Width = 351;
            // 
            // PrincipalName
            // 
            this.PrincipalName.Text = "Nationality";
            this.PrincipalName.Width = 250;
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
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 463;
            this.label9.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 461;
            this.label5.Text = "Country Name";
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
            this.txtCountry.Location = new System.Drawing.Point(261, 44);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(508, 21);
            this.txtCountry.TabIndex = 460;
            this.btxMsg.SetText(this.txtCountry, "Country name cannot be blank");
            this.btxMsg.SetTitle(this.txtCountry, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 465;
            this.label1.Text = "Nationality";
            // 
            // txtNationality
            // 
            this.txtNationality.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNationality.Border.Class = "TextBoxBorder";
            this.txtNationality.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNationality.FocusHighlightEnabled = true;
            this.txtNationality.ForeColor = System.Drawing.Color.Black;
            this.txtNationality.Location = new System.Drawing.Point(261, 71);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.ReadOnly = true;
            this.txtNationality.Size = new System.Drawing.Size(508, 21);
            this.txtNationality.TabIndex = 464;
            this.btxMsg.SetText(this.txtNationality, null);
            this.btxMsg.SetTitle(this.txtNationality, null);
            // 
            // btnCountry
            // 
            this.btnCountry.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCountry.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCountry.Image = ((System.Drawing.Image)(resources.GetObject("btnCountry.Image")));
            this.btnCountry.Location = new System.Drawing.Point(748, 100);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(19, 18);
            this.btnCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCountry.TabIndex = 467;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 468;
            this.label2.Text = "POEA Country";
            // 
            // txtPOEACountry
            // 
            this.txtPOEACountry.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPOEACountry.Border.Class = "TextBoxBorder";
            this.txtPOEACountry.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOEACountry.FocusHighlightEnabled = true;
            this.txtPOEACountry.ForeColor = System.Drawing.Color.Black;
            this.txtPOEACountry.Location = new System.Drawing.Point(261, 98);
            this.txtPOEACountry.Name = "txtPOEACountry";
            this.txtPOEACountry.ReadOnly = true;
            this.txtPOEACountry.Size = new System.Drawing.Size(508, 21);
            this.txtPOEACountry.TabIndex = 466;
            this.txtPOEACountry.Tag = "0";
            this.btxMsg.SetText(this.txtPOEACountry, "POEA Country cannot be blank");
            this.btxMsg.SetTitle(this.txtPOEACountry, null);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(261, 125);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 488;
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
            this.ToolStrip1.Size = new System.Drawing.Size(778, 39);
            this.ToolStrip1.TabIndex = 544;
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
            // CountryMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 535);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPOEACountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pan_Search);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CountryMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Country Master file";
            this.Load += new System.EventHandler(this.CountryMasterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountryMasterForm_KeyDown);
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
        internal System.Windows.Forms.ColumnHeader PrincipalName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCountry;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtNationality;
        internal DevComponents.DotNetBar.ButtonX btnCountry;
        private System.Windows.Forms.Label label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPOEACountry;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
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