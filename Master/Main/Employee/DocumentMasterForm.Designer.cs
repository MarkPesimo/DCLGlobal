﻿namespace DCLGlobal.Master.Main.Employee
{
    partial class DocumentMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentMasterForm));
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DocumentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.txtDocumentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.ToolStrip1.SuspendLayout();
            this.pan_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.DocumentName});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(565, 269);
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
            // DocumentName
            // 
            this.DocumentName.Text = "Document Name";
            this.DocumentName.Width = 351;
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
            this.txtDocumentName.Location = new System.Drawing.Point(275, 52);
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.ReadOnly = true;
            this.txtDocumentName.Size = new System.Drawing.Size(283, 21);
            this.txtDocumentName.TabIndex = 574;
            this.txtDocumentName.Tag = "0";
            this.btxMsg.SetText(this.txtDocumentName, "Document name cannot be blank");
            this.btxMsg.SetTitle(this.txtDocumentName, null);
            // 
            // Search_txt
            // 
            this.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(300, 39);
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
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
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
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
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
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.AllowItemReorder = true;
            this.ToolStrip1.BackColor = System.Drawing.Color.Gray;
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(565, 39);
            this.ToolStrip1.TabIndex = 578;
            this.ToolStrip1.Text = "ToolStrip1";
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
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 577;
            this.label4.Text = "Document Name";
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 201);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(565, 269);
            this.pan_Search.TabIndex = 575;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(11, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 576;
            this.pictureBox1.TabStop = false;
            // 
            // DocumentMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 470);
            this.Controls.Add(this.txtDocumentName);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DocumentMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Master File";
            this.Load += new System.EventHandler(this.DocumentMasterForm_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.pan_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader DocumentName;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtDocumentName;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        internal System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel pan_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}