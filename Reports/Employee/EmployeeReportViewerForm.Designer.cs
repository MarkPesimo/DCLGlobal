namespace DCLGlobal.Reports.Employee
{
    partial class EmployeeReportViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReportViewerForm));
            this.CRViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panPrint = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.panPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRViewer
            // 
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRViewer.Location = new System.Drawing.Point(0, 36);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.Size = new System.Drawing.Size(927, 705);
            this.CRViewer.TabIndex = 5;
            this.CRViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panPrint
            // 
            this.panPrint.Controls.Add(this.Button1);
            this.panPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPrint.Location = new System.Drawing.Point(0, 0);
            this.panPrint.Name = "panPrint";
            this.panPrint.Size = new System.Drawing.Size(927, 36);
            this.panPrint.TabIndex = 6;
            this.panPrint.Visible = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(3, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(102, 30);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Print";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 741);
            this.Controls.Add(this.CRViewer);
            this.Controls.Add(this.panPrint);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeReportViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeReportViewerForm_Load);
            this.panPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer CRViewer;
        internal System.Windows.Forms.Panel panPrint;
        internal System.Windows.Forms.Button Button1;
    }
}