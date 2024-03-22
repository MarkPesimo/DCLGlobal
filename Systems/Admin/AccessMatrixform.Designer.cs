namespace DCLGlobal.Systems.Admin
{
    partial class AccessMatrixform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessMatrixform));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panBody = new System.Windows.Forms.Panel();
            this.pbar = new System.Windows.Forms.ProgressBar();
            this.btncancel = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.checkbtn = new System.Windows.Forms.Button();
            this.dgvAccess = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvDetails = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbtn = new DevComponents.DotNetBar.ButtonX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.txtCopyFrom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCopyTo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panCopy = new System.Windows.Forms.Panel();
            this.cancelcopybtn = new System.Windows.Forms.Button();
            this.copybtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.copytobtn = new DevComponents.DotNetBar.ButtonX();
            this.label6 = new System.Windows.Forms.Label();
            this.copyfrombtn = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panCopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 552);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 25);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 22);
            this.toolStripLabel1.Text = "F3 - Copy Access Rights";
            // 
            // panBody
            // 
            this.panBody.Controls.Add(this.pbar);
            this.panBody.Controls.Add(this.btncancel);
            this.panBody.Controls.Add(this.savebtn);
            this.panBody.Controls.Add(this.checkbtn);
            this.panBody.Controls.Add(this.dgvAccess);
            this.panBody.Controls.Add(this.label3);
            this.panBody.Controls.Add(this.panel1);
            this.panBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBody.Location = new System.Drawing.Point(0, 0);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(1076, 552);
            this.panBody.TabIndex = 43;
            // 
            // pbar
            // 
            this.pbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbar.Location = new System.Drawing.Point(239, 511);
            this.pbar.Name = "pbar";
            this.pbar.Size = new System.Drawing.Size(837, 15);
            this.pbar.TabIndex = 474;
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(947, 528);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 23);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.Image = ((System.Drawing.Image)(resources.GetObject("savebtn.Image")));
            this.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.Location = new System.Drawing.Point(820, 528);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(126, 23);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // checkbtn
            // 
            this.checkbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbtn.Image = ((System.Drawing.Image)(resources.GetObject("checkbtn.Image")));
            this.checkbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkbtn.Location = new System.Drawing.Point(241, 528);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(126, 23);
            this.checkbtn.TabIndex = 6;
            this.checkbtn.Text = "Check All";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // dgvAccess
            // 
            this.dgvAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccess.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAccess.Location = new System.Drawing.Point(239, 21);
            this.dgvAccess.Name = "dgvAccess";
            this.dgvAccess.Size = new System.Drawing.Size(837, 490);
            this.dgvAccess.TabIndex = 7;
            this.dgvAccess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccess_CellContentClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(837, 21);
            this.label3.TabIndex = 470;
            this.label3.Text = "Access Matrix";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvDetails);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 552);
            this.panel1.TabIndex = 0;
            // 
            // lsvDetails
            // 
            this.lsvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ModuleName});
            this.lsvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDetails.FullRowSelect = true;
            this.lsvDetails.GridLines = true;
            this.lsvDetails.Location = new System.Drawing.Point(0, 150);
            this.lsvDetails.Name = "lsvDetails";
            this.lsvDetails.Size = new System.Drawing.Size(239, 402);
            this.lsvDetails.TabIndex = 5;
            this.lsvDetails.UseCompatibleStateImageBehavior = false;
            this.lsvDetails.View = System.Windows.Forms.View.Details;
            this.lsvDetails.SelectedIndexChanged += new System.EventHandler(this.lsvDetails_SelectedIndexChanged);
            this.lsvDetails.DoubleClick += new System.EventHandler(this.lsvDetails_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // ModuleName
            // 
            this.ModuleName.Text = "Module Name";
            this.ModuleName.Width = 215;
            // 
            // txtKeyword
            // 
            this.txtKeyword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKeyword.Border.Class = "TextBoxBorder";
            this.txtKeyword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeyword.FocusHighlightEnabled = true;
            this.txtKeyword.ForeColor = System.Drawing.Color.Black;
            this.txtKeyword.Location = new System.Drawing.Point(0, 129);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.ReadOnly = true;
            this.txtKeyword.Size = new System.Drawing.Size(239, 21);
            this.txtKeyword.TabIndex = 4;
            this.txtKeyword.Tag = "0";
            this.btxMsg.SetText(this.txtKeyword, null);
            this.btxMsg.SetTitle(this.txtKeyword, null);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(0, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(239, 20);
            this.label17.TabIndex = 469;
            this.label17.Text = "Available Module";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboModule);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.searchbtn);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 109);
            this.panel2.TabIndex = 504;
            // 
            // cmdSearch
            // 
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.ForeColor = System.Drawing.Color.Black;
            this.cmdSearch.Image = ((System.Drawing.Image)(resources.GetObject("cmdSearch.Image")));
            this.cmdSearch.Location = new System.Drawing.Point(212, 84);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(23, 21);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 503;
            this.label1.Text = "Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "INQUIRY",
            "MASTER FILE",
            "PROCESS",
            "REPORT",
            "SYSTEM",
            "TRANSACTION"});
            this.cboModule.Location = new System.Drawing.Point(5, 84);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(205, 22);
            this.cboModule.TabIndex = 2;
            this.cboModule.SelectedIndexChanged += new System.EventHandler(this.cboModule_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 500;
            this.label4.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 502;
            this.label2.Text = "Module Type :";
            // 
            // searchbtn
            // 
            this.searchbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.searchbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.Location = new System.Drawing.Point(215, 44);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(18, 18);
            this.searchbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.FocusHighlightEnabled = true;
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(5, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(230, 21);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "0";
            this.btxMsg.SetText(this.txtUsername, "Kindly select a user first");
            this.btxMsg.SetTitle(this.txtUsername, null);
            // 
            // txtCopyFrom
            // 
            this.txtCopyFrom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCopyFrom.Border.Class = "TextBoxBorder";
            this.txtCopyFrom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCopyFrom.FocusHighlightEnabled = true;
            this.txtCopyFrom.ForeColor = System.Drawing.Color.Black;
            this.txtCopyFrom.Location = new System.Drawing.Point(95, 39);
            this.txtCopyFrom.Name = "txtCopyFrom";
            this.txtCopyFrom.ReadOnly = true;
            this.txtCopyFrom.Size = new System.Drawing.Size(325, 21);
            this.txtCopyFrom.TabIndex = 9;
            this.txtCopyFrom.Tag = "0";
            this.btxMsg.SetText(this.txtCopyFrom, "Kindly select a copy from User");
            this.btxMsg.SetTitle(this.txtCopyFrom, null);
            // 
            // txtCopyTo
            // 
            this.txtCopyTo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCopyTo.Border.Class = "TextBoxBorder";
            this.txtCopyTo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCopyTo.FocusHighlightEnabled = true;
            this.txtCopyTo.ForeColor = System.Drawing.Color.Black;
            this.txtCopyTo.Location = new System.Drawing.Point(95, 66);
            this.txtCopyTo.Name = "txtCopyTo";
            this.txtCopyTo.ReadOnly = true;
            this.txtCopyTo.Size = new System.Drawing.Size(325, 21);
            this.txtCopyTo.TabIndex = 11;
            this.txtCopyTo.Tag = "0";
            this.btxMsg.SetText(this.txtCopyTo, "Kindly select a Copy to user");
            this.btxMsg.SetTitle(this.txtCopyTo, null);
            // 
            // panCopy
            // 
            this.panCopy.Controls.Add(this.cancelcopybtn);
            this.panCopy.Controls.Add(this.copybtn);
            this.panCopy.Controls.Add(this.label7);
            this.panCopy.Controls.Add(this.copytobtn);
            this.panCopy.Controls.Add(this.txtCopyTo);
            this.panCopy.Controls.Add(this.label6);
            this.panCopy.Controls.Add(this.copyfrombtn);
            this.panCopy.Controls.Add(this.txtCopyFrom);
            this.panCopy.Controls.Add(this.label5);
            this.panCopy.Location = new System.Drawing.Point(320, 219);
            this.panCopy.Name = "panCopy";
            this.panCopy.Size = new System.Drawing.Size(437, 139);
            this.panCopy.TabIndex = 44;
            this.panCopy.Visible = false;
            // 
            // cancelcopybtn
            // 
            this.cancelcopybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelcopybtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelcopybtn.Image")));
            this.cancelcopybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelcopybtn.Location = new System.Drawing.Point(324, 98);
            this.cancelcopybtn.Name = "cancelcopybtn";
            this.cancelcopybtn.Size = new System.Drawing.Size(96, 23);
            this.cancelcopybtn.TabIndex = 14;
            this.cancelcopybtn.Text = "Cancel";
            this.cancelcopybtn.UseVisualStyleBackColor = true;
            this.cancelcopybtn.Click += new System.EventHandler(this.cancelcopybtn_Click);
            // 
            // copybtn
            // 
            this.copybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copybtn.Image = ((System.Drawing.Image)(resources.GetObject("copybtn.Image")));
            this.copybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copybtn.Location = new System.Drawing.Point(225, 98);
            this.copybtn.Name = "copybtn";
            this.copybtn.Size = new System.Drawing.Size(93, 23);
            this.copybtn.TabIndex = 13;
            this.copybtn.Text = "Copy";
            this.copybtn.UseVisualStyleBackColor = true;
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 510;
            this.label7.Text = "Copy To :";
            // 
            // copytobtn
            // 
            this.copytobtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.copytobtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.copytobtn.Image = ((System.Drawing.Image)(resources.GetObject("copytobtn.Image")));
            this.copytobtn.Location = new System.Drawing.Point(402, 68);
            this.copytobtn.Name = "copytobtn";
            this.copytobtn.Size = new System.Drawing.Size(18, 18);
            this.copytobtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.copytobtn.TabIndex = 12;
            this.copytobtn.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 507;
            this.label6.Text = "Copy From :";
            // 
            // copyfrombtn
            // 
            this.copyfrombtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.copyfrombtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.copyfrombtn.Image = ((System.Drawing.Image)(resources.GetObject("copyfrombtn.Image")));
            this.copyfrombtn.Location = new System.Drawing.Point(402, 41);
            this.copyfrombtn.Name = "copyfrombtn";
            this.copyfrombtn.Size = new System.Drawing.Size(18, 18);
            this.copyfrombtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.copyfrombtn.TabIndex = 10;
            this.copyfrombtn.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 23);
            this.label5.TabIndex = 504;
            this.label5.Text = "Copy Access Rights";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccessMatrixform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 577);
            this.Controls.Add(this.panCopy);
            this.Controls.Add(this.panBody);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AccessMatrixform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Matrix";
            this.Load += new System.EventHandler(this.AccessMatrixform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AccessMatrixform_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panCopy.ResumeLayout(false);
            this.panCopy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panBody;
        internal DevComponents.DotNetBar.ButtonX searchbtn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvAccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button checkbtn;
        internal System.Windows.Forms.ListView lsvDetails;
        internal System.Windows.Forms.ColumnHeader ModuleName;
        internal System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cboModule;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtKeyword;
        internal System.Windows.Forms.ProgressBar pbar;
        internal System.Windows.Forms.Button cmdSearch;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.Panel panCopy;
        private System.Windows.Forms.Button cancelcopybtn;
        private System.Windows.Forms.Button copybtn;
        private System.Windows.Forms.Label label7;
        internal DevComponents.DotNetBar.ButtonX copytobtn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCopyTo;
        private System.Windows.Forms.Label label6;
        internal DevComponents.DotNetBar.ButtonX copyfrombtn;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCopyFrom;
        private System.Windows.Forms.Label label5;
    }
}