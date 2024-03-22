namespace DCLGlobal.Master.Main.Employee
{
    partial class CompanyMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMasterForm));
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.txtCompanyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtCompanyCodeNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCompanyCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPresentingOffice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCeilingAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAccountNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ToolStrip1.SuspendLayout();
            this.pan_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyName.Border.Class = "TextBoxBorder";
            this.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyName.FocusHighlightEnabled = true;
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(288, 50);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(518, 21);
            this.txtCompanyName.TabIndex = 559;
            this.txtCompanyName.Tag = "0";
            this.btxMsg.SetText(this.txtCompanyName, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtCompanyName, null);
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
            this.ToolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(814, 39);
            this.ToolStrip1.TabIndex = 563;
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
            this.label4.Location = new System.Drawing.Point(183, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 562;
            this.label4.Text = "Company Name";
            // 
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 200);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(814, 269);
            this.pan_Search.TabIndex = 560;
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.CompanyName,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(814, 269);
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
            // CompanyName
            // 
            this.CompanyName.Text = "Company Name";
            this.CompanyName.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company Code No.";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Company Code";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Presenting Office";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ceiling Amount";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Account No.";
            this.columnHeader5.Width = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 561;
            this.pictureBox1.TabStop = false;
            // 
            // txtCompanyCodeNo
            // 
            this.txtCompanyCodeNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyCodeNo.Border.Class = "TextBoxBorder";
            this.txtCompanyCodeNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyCodeNo.FocusHighlightEnabled = true;
            this.txtCompanyCodeNo.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyCodeNo.Location = new System.Drawing.Point(288, 76);
            this.txtCompanyCodeNo.Name = "txtCompanyCodeNo";
            this.txtCompanyCodeNo.ReadOnly = true;
            this.txtCompanyCodeNo.Size = new System.Drawing.Size(110, 21);
            this.txtCompanyCodeNo.TabIndex = 565;
            this.txtCompanyCodeNo.Tag = "0";
            this.btxMsg.SetText(this.txtCompanyCodeNo, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtCompanyCodeNo, null);
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCompanyCode.Border.Class = "TextBoxBorder";
            this.txtCompanyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyCode.FocusHighlightEnabled = true;
            this.txtCompanyCode.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyCode.Location = new System.Drawing.Point(493, 76);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.ReadOnly = true;
            this.txtCompanyCode.Size = new System.Drawing.Size(101, 21);
            this.txtCompanyCode.TabIndex = 567;
            this.txtCompanyCode.Tag = "0";
            this.btxMsg.SetText(this.txtCompanyCode, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtCompanyCode, null);
            // 
            // txtPresentingOffice
            // 
            this.txtPresentingOffice.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPresentingOffice.Border.Class = "TextBoxBorder";
            this.txtPresentingOffice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPresentingOffice.FocusHighlightEnabled = true;
            this.txtPresentingOffice.ForeColor = System.Drawing.Color.Black;
            this.txtPresentingOffice.Location = new System.Drawing.Point(696, 76);
            this.txtPresentingOffice.Name = "txtPresentingOffice";
            this.txtPresentingOffice.ReadOnly = true;
            this.txtPresentingOffice.Size = new System.Drawing.Size(110, 21);
            this.txtPresentingOffice.TabIndex = 569;
            this.txtPresentingOffice.Tag = "0";
            this.btxMsg.SetText(this.txtPresentingOffice, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtPresentingOffice, null);
            // 
            // txtCeilingAmount
            // 
            this.txtCeilingAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCeilingAmount.Border.Class = "TextBoxBorder";
            this.txtCeilingAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCeilingAmount.FocusHighlightEnabled = true;
            this.txtCeilingAmount.ForeColor = System.Drawing.Color.Black;
            this.txtCeilingAmount.Location = new System.Drawing.Point(288, 102);
            this.txtCeilingAmount.Name = "txtCeilingAmount";
            this.txtCeilingAmount.ReadOnly = true;
            this.txtCeilingAmount.Size = new System.Drawing.Size(199, 21);
            this.txtCeilingAmount.TabIndex = 571;
            this.txtCeilingAmount.Tag = "0";
            this.btxMsg.SetText(this.txtCeilingAmount, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtCeilingAmount, null);
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAccountNo.Border.Class = "TextBoxBorder";
            this.txtAccountNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAccountNo.FocusHighlightEnabled = true;
            this.txtAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNo.Location = new System.Drawing.Point(607, 99);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.ReadOnly = true;
            this.txtAccountNo.Size = new System.Drawing.Size(199, 21);
            this.txtAccountNo.TabIndex = 573;
            this.txtAccountNo.Tag = "0";
            this.btxMsg.SetText(this.txtAccountNo, "Company name cannot be blank");
            this.btxMsg.SetTitle(this.txtAccountNo, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 564;
            this.label1.Text = "Company Code No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 566;
            this.label2.Text = "Company Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 568;
            this.label3.Text = "Presenting Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 570;
            this.label5.Text = "Ceiling Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 572;
            this.label6.Text = "Account No.";
            // 
            // CompanyMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 469);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCeilingAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPresentingOffice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompanyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompanyCodeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pan_Search);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompanyMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Master File";
            this.Load += new System.EventHandler(this.CompanyMasterForm_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.pan_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCompanyName;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        internal System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel pan_Search;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader CompanyName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCompanyCodeNo;
        private System.Windows.Forms.Label label2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCompanyCode;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPresentingOffice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCeilingAmount;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtAccountNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}