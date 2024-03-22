namespace DCLGlobal.Reports.Employee
{
    partial class GeneralReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralReportForm));
            this.chkExcel = new System.Windows.Forms.CheckBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.prgBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblPercent = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panLoad = new System.Windows.Forms.Panel();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtLogTo = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtLogFrom = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel3.SuspendLayout();
            this.panLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkExcel
            // 
            this.chkExcel.AutoSize = true;
            this.chkExcel.Location = new System.Drawing.Point(22, 164);
            this.chkExcel.Name = "chkExcel";
            this.chkExcel.Size = new System.Drawing.Size(99, 17);
            this.chkExcel.TabIndex = 17;
            this.chkExcel.Text = "Export to Excel";
            this.chkExcel.UseVisualStyleBackColor = true;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.prgBar);
            this.Panel3.Controls.Add(this.lblPercent);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Location = new System.Drawing.Point(11, 58);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(348, 59);
            this.Panel3.TabIndex = 14;
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
            this.prgBar.Size = new System.Drawing.Size(335, 24);
            this.prgBar.TabIndex = 3;
            this.prgBar.Text = "ProgressBarX1";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(223, 35);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(44, 13);
            this.lblPercent.TabIndex = 2;
            this.lblPercent.Text = "Percent";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 35);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(203, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Please wait...Exporting records to excel.";
            // 
            // btnPreview
            // 
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(190, 158);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 26);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(286, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 26);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panLoad
            // 
            this.panLoad.Controls.Add(this.picLoad);
            this.panLoad.Controls.Add(this.Label6);
            this.panLoad.Location = new System.Drawing.Point(13, 58);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(346, 59);
            this.panLoad.TabIndex = 16;
            this.panLoad.Visible = false;
            // 
            // picLoad
            // 
            this.picLoad.Image = ((System.Drawing.Image)(resources.GetObject("picLoad.Image")));
            this.picLoad.Location = new System.Drawing.Point(117, 11);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(110, 18);
            this.picLoad.TabIndex = 16;
            this.picLoad.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(93, 38);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(166, 13);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Please wait... Generating data...";
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(305, 114);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(49, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "&Find";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtEmp
            // 
            this.txtEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmp.Location = new System.Drawing.Point(11, 115);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.ReadOnly = true;
            this.txtEmp.Size = new System.Drawing.Size(292, 21);
            this.txtEmp.TabIndex = 6;
            this.txtEmp.Text = "Search Text Here";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "APS",
            "APW",
            "ASI",
            "ZMG",
            "Per Employee",
            "Per Department"});
            this.cmbFilter.Location = new System.Drawing.Point(69, 15);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(284, 21);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Filter:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtLogTo
            // 
            this.dtLogTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLogTo.Location = new System.Drawing.Point(69, 72);
            this.dtLogTo.Name = "dtLogTo";
            this.dtLogTo.Size = new System.Drawing.Size(284, 21);
            this.dtLogTo.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(40, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(23, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "To:";
            // 
            // dtLogFrom
            // 
            this.dtLogFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLogFrom.Location = new System.Drawing.Point(69, 43);
            this.dtLogFrom.Name = "dtLogFrom";
            this.dtLogFrom.Size = new System.Drawing.Size(284, 21);
            this.dtLogFrom.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "From:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Panel3);
            this.GroupBox1.Controls.Add(this.panLoad);
            this.GroupBox1.Controls.Add(this.btnFind);
            this.GroupBox1.Controls.Add(this.txtEmp);
            this.GroupBox1.Controls.Add(this.cmbFilter);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.dtLogTo);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.dtLogFrom);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(360, 148);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            // 
            // GeneralReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 197);
            this.Controls.Add(this.chkExcel);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GeneralReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Options";
            this.Load += new System.EventHandler(this.GeneralReportForm_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.panLoad.ResumeLayout(false);
            this.panLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox chkExcel;
        internal System.Windows.Forms.Panel Panel3;
        internal DevComponents.DotNetBar.Controls.ProgressBarX prgBar;
        internal System.Windows.Forms.Label lblPercent;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnPreview;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Panel panLoad;
        internal System.Windows.Forms.PictureBox picLoad;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.TextBox txtEmp;
        internal System.Windows.Forms.ComboBox cmbFilter;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtLogTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtLogFrom;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}