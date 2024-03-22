namespace DCLGlobal.Reports.Crew
{
    partial class CandidateReportform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateReportform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.txtReportType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.print_btn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 100);
            this.pictureBox1.TabIndex = 583;
            this.pictureBox1.TabStop = false;
            // 
            // dtpto
            // 
            this.dtpto.Location = new System.Drawing.Point(383, 86);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(200, 21);
            this.dtpto.TabIndex = 597;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 601;
            this.label2.Text = "Date Range";
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(178, 86);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(200, 21);
            this.dtpfrom.TabIndex = 596;
            // 
            // txtReportType
            // 
            this.txtReportType.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtReportType.Border.Class = "TextBoxBorder";
            this.txtReportType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReportType.FocusHighlightEnabled = true;
            this.txtReportType.ForeColor = System.Drawing.Color.Black;
            this.txtReportType.Location = new System.Drawing.Point(178, 59);
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.ReadOnly = true;
            this.txtReportType.Size = new System.Drawing.Size(405, 21);
            this.txtReportType.TabIndex = 595;
            this.txtReportType.Tag = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 600;
            this.label1.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.print_btn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 39);
            this.toolStrip1.TabIndex = 614;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // print_btn
            // 
            this.print_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.print_btn.Image = ((System.Drawing.Image)(resources.GetObject("print_btn.Image")));
            this.print_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.print_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(36, 36);
            this.print_btn.Text = "toolStripButton1";
            this.print_btn.ToolTipText = "Print Record";
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // CandidateReportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 147);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtpto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CandidateReportform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate Report";
            this.Load += new System.EventHandler(this.CandidateReportform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtReportType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton print_btn;
    }
}