namespace DCLGlobal.Timesheet
{
    partial class TimeSheetEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSheetEmployeeList));
            this.lstEmployee = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new DevComponents.DotNetBar.ButtonX();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.prgBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblPercent = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployee
            // 
            this.lstEmployee.CheckBoxes = true;
            this.lstEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.lstEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEmployee.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstEmployee.FullRowSelect = true;
            this.lstEmployee.GridLines = true;
            this.lstEmployee.Location = new System.Drawing.Point(0, 0);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(460, 434);
            this.lstEmployee.TabIndex = 0;
            this.lstEmployee.UseCompatibleStateImageBehavior = false;
            this.lstEmployee.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Employee Name";
            this.ColumnHeader1.Width = 431;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "EmpID";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeader2.Width = 0;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtCompany);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.btnGenerate);
            this.Panel1.Controls.Add(this.chkAll);
            this.Panel1.Controls.Add(this.txtFind);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(460, 87);
            this.Panel1.TabIndex = 3;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(77, 12);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(264, 21);
            this.txtCompany.TabIndex = 15;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Company:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.Location = new System.Drawing.Point(357, 31);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(91, 27);
            this.btnGenerate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(78, 62);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(69, 17);
            this.chkAll.TabIndex = 2;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(77, 35);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(264, 21);
            this.txtFind.TabIndex = 1;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(37, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Find :";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Panel3);
            this.Panel2.Controls.Add(this.lstEmployee);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 87);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(460, 434);
            this.Panel2.TabIndex = 4;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.prgBar);
            this.Panel3.Controls.Add(this.lblPercent);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Location = new System.Drawing.Point(3, 129);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(451, 59);
            this.Panel3.TabIndex = 1;
            this.Panel3.Visible = false;
            // 
            // prgBar
            // 
            // 
            // 
            // 
            this.prgBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prgBar.Location = new System.Drawing.Point(6, 3);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(440, 24);
            this.prgBar.TabIndex = 3;
            this.prgBar.Text = "ProgressBarX1";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(198, 38);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(44, 13);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "Percent";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(157, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Please wait...";
            // 
            // TimeSheetEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 521);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeSheetEmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.TimeSheetEmployeeList_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lstEmployee;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.Panel Panel1;
        private DevComponents.DotNetBar.ButtonX btnGenerate;
        internal System.Windows.Forms.CheckBox chkAll;
        internal System.Windows.Forms.TextBox txtFind;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel3;
        internal DevComponents.DotNetBar.Controls.ProgressBarX prgBar;
        internal System.Windows.Forms.Label lblPercent;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCompany;
        internal System.Windows.Forms.Label Label3;
    }
}