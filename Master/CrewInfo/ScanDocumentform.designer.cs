namespace DCLGlobal.Master.CrewInfo
{
    partial class ScanDocumentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanDocumentform));
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.txtfilename = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.search_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // txtfilename
            // 
            this.txtfilename.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtfilename.Border.Class = "TextBoxBorder";
            this.txtfilename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtfilename.FocusHighlightEnabled = true;
            this.txtfilename.ForeColor = System.Drawing.Color.Black;
            this.txtfilename.Location = new System.Drawing.Point(85, 18);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.ReadOnly = true;
            this.txtfilename.Size = new System.Drawing.Size(565, 21);
            this.txtfilename.TabIndex = 0;
            this.txtfilename.Tag = "0";
            this.btxMsg.SetText(this.txtfilename, "Kindly select a file");
            this.btxMsg.SetTitle(this.txtfilename, null);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 467;
            this.label4.Text = "Filename";
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Gray;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancel_btn,
            this.btnSave,
            this.search_btn});
            this.toolStrip3.Location = new System.Drawing.Point(0, 55);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip3.Size = new System.Drawing.Size(662, 39);
            this.toolStrip3.TabIndex = 519;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // cancel_btn
            // 
            this.cancel_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("cancel_btn.Image")));
            this.cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.cancel_btn.Text = "toolStripButton1";
            this.cancel_btn.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 36);
            this.btnSave.Text = "toolStripButton2";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // search_btn
            // 
            this.search_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.search_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(36, 36);
            this.search_btn.Text = "toolStripButton3";
            this.search_btn.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ScanDocumentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 94);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfilename);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScanDocumentform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browse File";
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OFD1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtfilename;
        private System.Windows.Forms.Label label4;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton search_btn;
    }
}