namespace DCLGlobal.Master.Main.Employee
{
    partial class ShiftMasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftMasterForm));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTimeIn = new System.Windows.Forms.DateTimePicker();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtShiftDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGracePeriod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Shiftout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shiftin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shift = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lsvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.pan_Search = new System.Windows.Forms.Panel();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.pan_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 586;
            this.label2.Text = "Grace Period";
            // 
            // dtpTimeIn
            // 
            this.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeIn.Location = new System.Drawing.Point(269, 78);
            this.dtpTimeIn.Name = "dtpTimeIn";
            this.dtpTimeIn.Size = new System.Drawing.Size(118, 21);
            this.dtpTimeIn.TabIndex = 583;
            // 
            // txtShiftDesc
            // 
            this.txtShiftDesc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtShiftDesc.Border.Class = "TextBoxBorder";
            this.txtShiftDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtShiftDesc.FocusHighlightEnabled = true;
            this.txtShiftDesc.ForeColor = System.Drawing.Color.Black;
            this.txtShiftDesc.Location = new System.Drawing.Point(269, 52);
            this.txtShiftDesc.Name = "txtShiftDesc";
            this.txtShiftDesc.ReadOnly = true;
            this.txtShiftDesc.Size = new System.Drawing.Size(348, 21);
            this.txtShiftDesc.TabIndex = 578;
            this.txtShiftDesc.Tag = "0";
            this.btxMsg.SetText(this.txtShiftDesc, "Shift description cannot be blank");
            this.btxMsg.SetTitle(this.txtShiftDesc, null);
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGracePeriod.Border.Class = "TextBoxBorder";
            this.txtGracePeriod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGracePeriod.FocusHighlightEnabled = true;
            this.txtGracePeriod.ForeColor = System.Drawing.Color.Black;
            this.txtGracePeriod.Location = new System.Drawing.Point(269, 104);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.ReadOnly = true;
            this.txtGracePeriod.Size = new System.Drawing.Size(118, 21);
            this.txtGracePeriod.TabIndex = 587;
            this.txtGracePeriod.Tag = "0";
            this.btxMsg.SetText(this.txtGracePeriod, "Employee rank cannot be blank");
            this.btxMsg.SetTitle(this.txtGracePeriod, null);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 580;
            this.pictureBox1.TabStop = false;
            // 
            // Shiftout
            // 
            this.Shiftout.Text = "Shift Out";
            this.Shiftout.Width = 100;
            // 
            // Shiftin
            // 
            this.Shiftin.Text = "Shift In";
            this.Shiftin.Width = 100;
            // 
            // Shift
            // 
            this.Shift.Text = "Shift Description";
            this.Shift.Width = 300;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 585;
            this.label1.Text = "Shift in";
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Shift,
            this.Shiftin,
            this.Shiftout,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 0);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(623, 269);
            this.lsvList.TabIndex = 1;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Grace Period";
            this.columnHeader1.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 581;
            this.label4.Text = "Shift Description";
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
            this.ToolStrip1.Size = new System.Drawing.Size(623, 39);
            this.ToolStrip1.TabIndex = 582;
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
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(300, 39);
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
            // pan_Search
            // 
            this.pan_Search.BackColor = System.Drawing.SystemColors.Control;
            this.pan_Search.Controls.Add(this.lsvList);
            this.pan_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_Search.Location = new System.Drawing.Point(0, 203);
            this.pan_Search.Name = "pan_Search";
            this.pan_Search.Size = new System.Drawing.Size(623, 269);
            this.pan_Search.TabIndex = 579;
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeOut.Location = new System.Drawing.Point(499, 78);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.Size = new System.Drawing.Size(118, 21);
            this.dtpTimeOut.TabIndex = 588;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 589;
            this.label3.Text = "Shift out";
            // 
            // ShiftMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 472);
            this.Controls.Add(this.dtpTimeOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTimeIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.txtShiftDesc);
            this.Controls.Add(this.pan_Search);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShiftMasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Master File";
            this.Load += new System.EventHandler(this.ShiftMasterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.pan_Search.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimeIn;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtShiftDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Shiftout;
        private System.Windows.Forms.ColumnHeader Shiftin;
        internal System.Windows.Forms.ColumnHeader Shift;
        internal System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListView lsvList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton Save_btn;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        internal System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        internal System.Windows.Forms.Panel pan_Search;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtGracePeriod;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}