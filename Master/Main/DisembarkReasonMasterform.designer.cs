namespace DCLGlobal.Master.Main
{
    partial class DisembarkReasonMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisembarkReasonMasterform));
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtDisembarkReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // txtDisembarkReason
            // 
            this.txtDisembarkReason.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDisembarkReason.Border.Class = "TextBoxBorder";
            this.txtDisembarkReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDisembarkReason.FocusHighlightEnabled = true;
            this.txtDisembarkReason.ForeColor = System.Drawing.Color.Black;
            this.txtDisembarkReason.Location = new System.Drawing.Point(278, 46);
            this.txtDisembarkReason.Name = "txtDisembarkReason";
            this.txtDisembarkReason.ReadOnly = true;
            this.txtDisembarkReason.Size = new System.Drawing.Size(405, 21);
            this.txtDisembarkReason.TabIndex = 407;
            this.btxMsg.SetText(this.txtDisembarkReason, "Disembark Reason cannot be blank");
            this.btxMsg.SetTitle(this.txtDisembarkReason, null);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 415;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 413;
            this.label1.Text = "Disembark Reason";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 110;
            // 
            // AccountName
            // 
            this.AccountName.Text = "Disembark Reason";
            this.AccountName.Width = 509;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 210);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(697, 268);
            this.pan_Search.TabIndex = 412;
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AccountName,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(697, 268);
            this.lsvList.TabIndex = 1;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 411;
            this.pictureBox1.TabStop = false;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Enabled = false;
            this.chkStatus.Location = new System.Drawing.Point(278, 73);
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
            this.ToolStrip1.Size = new System.Drawing.Size(697, 39);
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
            // DisembarkReasonMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 478);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisembarkReason);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "DisembarkReasonMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reason of Disembarkation Master File";
            this.Load += new System.EventHandler(this.DisembarkReasonMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisembarkReasonMasterform_KeyDown);
            this.pan_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDisembarkReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader AccountName;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.Panel pan_Search;
        internal System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.PictureBox pictureBox1;
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