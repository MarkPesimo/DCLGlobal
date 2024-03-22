namespace DCLGlobal.Master.Main.Fleet
{
    partial class PrincipalFleetMasterform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFleetMasterform));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.delete_btn = new System.Windows.Forms.ToolStripButton();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            this.Search_txt = new System.Windows.Forms.ToolStripTextBox();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvVessel = new System.Windows.Forms.ListView();
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panHead = new System.Windows.Forms.Panel();
            this.txtFleetname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnVessel = new DevComponents.DotNetBar.ButtonX();
            this.Label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVessel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.delete_btn,
            this.print_btn,
            this.Search_txt,
            this.Save_btn,
            this.cancel_btn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(848, 39);
            this.toolStrip2.TabIndex = 496;
            this.toolStrip2.Text = "toolStrip2";
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
            this.delete_btn.Text = "toolStripButton1";
            // 
            // print_btn
            // 
            this.print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.Text = "toolStripButton3";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.GotFocus += new System.EventHandler(this.Search_txt_GotFocus);
            this.Search_txt.LostFocus += new System.EventHandler(this.Search_txt_LostFocus);
            this.Search_txt.Size = new System.Drawing.Size(350, 39);
            this.Search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_txt_KeyDown);
            this.Search_txt.Click += new System.EventHandler(this.Search_txt_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvList);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 425);
            this.panel1.TabIndex = 497;
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AccountName});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 32);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(270, 393);
            this.lsvList.TabIndex = 503;
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
            this.AccountName.Text = "Fleet Name";
            this.AccountName.Width = 239;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKeyword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeyword.FocusHighlightEnabled = true;
            this.txtKeyword.ForeColor = System.Drawing.Color.Black;
            this.txtKeyword.Location = new System.Drawing.Point(0, 17);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ReadOnly = true;
            this.txtKeyword.Size = new System.Drawing.Size(270, 15);
            this.txtKeyword.TabIndex = 499;
            this.btxMsg.SetText(this.txtKeyword, "Fleet name cannot be blank");
            this.btxMsg.SetTitle(this.txtKeyword, null);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 17);
            this.label2.TabIndex = 502;
            this.label2.Text = "Enter Keyword";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvVessel);
            this.panel2.Controls.Add(this.panHead);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 425);
            this.panel2.TabIndex = 498;
            // 
            // lvVessel
            // 
            this.lvVessel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lvVessel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVessel.FullRowSelect = true;
            this.lvVessel.GridLines = true;
            this.lvVessel.Location = new System.Drawing.Point(0, 60);
            this.lvVessel.Name = "lvVessel";
            this.lvVessel.Size = new System.Drawing.Size(578, 365);
            this.lvVessel.TabIndex = 28;
            this.lvVessel.UseCompatibleStateImageBehavior = false;
            this.lvVessel.View = System.Windows.Forms.View.Details;
            this.lvVessel.SelectedIndexChanged += new System.EventHandler(this.lvVessel_SelectedIndexChanged);
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "id";
            this.ColumnHeader3.Width = 0;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Vessel name";
            this.ColumnHeader4.Width = 548;
            // 
            // panHead
            // 
            this.panHead.BackColor = System.Drawing.SystemColors.Control;
            this.panHead.Controls.Add(this.txtFleetname);
            this.panHead.Controls.Add(this.btnVessel);
            this.panHead.Controls.Add(this.Label1);
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.txtVessel);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(578, 60);
            this.panHead.TabIndex = 27;
            // 
            // txtFleetname
            // 
            this.txtFleetname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFleetname.Border.Class = "TextBoxBorder";
            this.txtFleetname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFleetname.FocusHighlightEnabled = true;
            this.txtFleetname.ForeColor = System.Drawing.Color.Black;
            this.txtFleetname.Location = new System.Drawing.Point(94, 3);
            this.txtFleetname.Name = "txtFleetname";
            this.txtFleetname.ReadOnly = true;
            this.txtFleetname.Size = new System.Drawing.Size(458, 21);
            this.txtFleetname.TabIndex = 508;
            this.btxMsg.SetText(this.txtFleetname, "Fleet name cannot be blank");
            this.btxMsg.SetTitle(this.txtFleetname, null);
            // 
            // btnVessel
            // 
            this.btnVessel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnVessel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnVessel.Image = ((System.Drawing.Image)(resources.GetObject("btnVessel.Image")));
            this.btnVessel.Location = new System.Drawing.Point(532, 31);
            this.btnVessel.Name = "btnVessel";
            this.btnVessel.Size = new System.Drawing.Size(19, 18);
            this.btnVessel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnVessel.TabIndex = 506;
            this.btnVessel.Click += new System.EventHandler(this.btnVessel_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(3, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 19);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Fleet Name";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vessel Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVessel
            // 
            this.txtVessel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVessel.Border.Class = "TextBoxBorder";
            this.txtVessel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVessel.FocusHighlightEnabled = true;
            this.txtVessel.ForeColor = System.Drawing.Color.Black;
            this.txtVessel.Location = new System.Drawing.Point(94, 29);
            this.txtVessel.Name = "txtVessel";
            this.txtVessel.ReadOnly = true;
            this.txtVessel.Size = new System.Drawing.Size(459, 21);
            this.txtVessel.TabIndex = 507;
            this.btxMsg.SetText(this.txtVessel, "Account name cannot be blank");
            this.btxMsg.SetTitle(this.txtVessel, null);
            this.txtVessel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVessel_KeyDown);
            // 
            // PrincipalFleetMasterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PrincipalFleetMasterform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Fleet Master File";
            this.Load += new System.EventHandler(this.PrincipalFleetMasterform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrincipalFleetMasterform_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panHead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton print_btn;
        private System.Windows.Forms.ToolStripTextBox Search_txt;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStripButton delete_btn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader AccountName;
        internal System.Windows.Forms.ListView lvVessel;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.Panel panHead;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label3;
        internal DevComponents.DotNetBar.ButtonX btnVessel;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtVessel;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFleetname;
    }
}