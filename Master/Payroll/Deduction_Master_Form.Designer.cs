namespace DCLGlobal.Master.Payroll
{
    partial class Deduction_Master_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deduction_Master_Form));
            this.lsvdeduction = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdeduction = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.btnedit = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.btnprint = new System.Windows.Forms.ToolStripButton();
            this.txtkeyword = new System.Windows.Forms.ToolStripTextBox();
            this.btnsave = new System.Windows.Forms.ToolStripButton();
            this.btncancel = new System.Windows.Forms.ToolStripButton();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvdeduction
            // 
            this.lsvdeduction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvdeduction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvdeduction.FullRowSelect = true;
            this.lsvdeduction.GridLines = true;
            this.lsvdeduction.Location = new System.Drawing.Point(0, 60);
            this.lsvdeduction.Name = "lsvdeduction";
            this.lsvdeduction.Size = new System.Drawing.Size(508, 430);
            this.lsvdeduction.TabIndex = 6;
            this.lsvdeduction.UseCompatibleStateImageBehavior = false;
            this.lsvdeduction.View = System.Windows.Forms.View.Details;
            this.lsvdeduction.SelectedIndexChanged += new System.EventHandler(this.lsvdeduction_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Deduction";
            this.columnHeader2.Width = 441;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtdeduction);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 29);
            this.panel1.TabIndex = 7;
            // 
            // txtdeduction
            // 
            this.txtdeduction.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdeduction.Border.Class = "TextBoxBorder";
            this.txtdeduction.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdeduction.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtdeduction.FocusHighlightEnabled = true;
            this.txtdeduction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdeduction.Location = new System.Drawing.Point(71, 4);
            this.txtdeduction.Name = "txtdeduction";
            this.txtdeduction.Size = new System.Drawing.Size(429, 20);
            this.txtdeduction.TabIndex = 4;
            this.btxMsg.SetText(this.txtdeduction, null);
            this.btxMsg.SetTitle(this.txtdeduction, null);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjusment";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnadd,
            this.btnedit,
            this.btndelete,
            this.btnprint,
            this.txtkeyword,
            this.btnsave,
            this.btncancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(508, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(54, 28);
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(53, 28);
            this.btnedit.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 28);
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnprint
            // 
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(57, 28);
            this.btnprint.Text = "Print";
            this.btnprint.Visible = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtkeyword
            // 
            this.txtkeyword.AutoSize = false;
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(120, 26);
            this.txtkeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkeyword_KeyDown);
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(59, 28);
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // btncancel
            // 
            this.btncancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(67, 28);
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // Deduction_Master_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 490);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvdeduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deduction_Master_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deduction Master File";
            this.Load += new System.EventHandler(this.Deduction_Master_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvdeduction;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton btnedit;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripButton btnprint;
        private System.Windows.Forms.ToolStripTextBox txtkeyword;
        private System.Windows.Forms.ToolStripButton btnsave;
        private System.Windows.Forms.ToolStripButton btncancel;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdeduction;
    }
}