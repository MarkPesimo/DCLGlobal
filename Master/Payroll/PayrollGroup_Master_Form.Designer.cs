namespace DCLGlobal.Master.Payroll
{
    partial class PayrollGroup_Master_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollGroup_Master_Form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnadd = new System.Windows.Forms.ToolStripButton();
            this.btnedit = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.btnprint = new System.Windows.Forms.ToolStripButton();
            this.txtkeyword = new System.Windows.Forms.ToolStripTextBox();
            this.btnsave = new System.Windows.Forms.ToolStripButton();
            this.btncancel = new System.Windows.Forms.ToolStripButton();
            this.lsvloantype = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpagibigShare = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtdescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbpagibigSched = new System.Windows.Forms.ComboBox();
            this.cmbphilhealthSched = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbtaxSched = new System.Windows.Forms.ComboBox();
            this.cmbsssSched = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(487, 31);
            this.toolStrip1.TabIndex = 5;
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
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(53, 28);
            this.btnedit.Text = "Edit";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 28);
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(100, 31);
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
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(67, 28);
            this.btncancel.Text = "Cancel";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lsvloantype
            // 
            this.lsvloantype.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvloantype.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvloantype.FullRowSelect = true;
            this.lsvloantype.GridLines = true;
            this.lsvloantype.Location = new System.Drawing.Point(0, 135);
            this.lsvloantype.Name = "lsvloantype";
            this.lsvloantype.Size = new System.Drawing.Size(487, 282);
            this.lsvloantype.TabIndex = 8;
            this.lsvloantype.UseCompatibleStateImageBehavior = false;
            this.lsvloantype.View = System.Windows.Forms.View.Details;
            this.lsvloantype.SelectedIndexChanged += new System.EventHandler(this.lsvloantype_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SSS Sched";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Philhealth Sched";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tax Sched";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pagibig Sched";
            this.columnHeader6.Width = 83;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtpagibigShare);
            this.panel2.Controls.Add(this.txtdescription);
            this.panel2.Controls.Add(this.cmbpagibigSched);
            this.panel2.Controls.Add(this.cmbphilhealthSched);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbtaxSched);
            this.panel2.Controls.Add(this.cmbsssSched);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 104);
            this.panel2.TabIndex = 9;
            // 
            // txtpagibigShare
            // 
            this.txtpagibigShare.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpagibigShare.Border.Class = "TextBoxBorder";
            this.txtpagibigShare.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpagibigShare.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtpagibigShare.FocusHighlightEnabled = true;
            this.txtpagibigShare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpagibigShare.Location = new System.Drawing.Point(103, 75);
            this.txtpagibigShare.Name = "txtpagibigShare";
            this.txtpagibigShare.Size = new System.Drawing.Size(123, 21);
            this.txtpagibigShare.TabIndex = 11;
            this.btxMsg.SetText(this.txtpagibigShare, null);
            this.btxMsg.SetTitle(this.txtpagibigShare, null);
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdescription.Border.Class = "TextBoxBorder";
            this.txtdescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdescription.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtdescription.FocusHighlightEnabled = true;
            this.txtdescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdescription.Location = new System.Drawing.Point(103, 3);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(373, 21);
            this.txtdescription.TabIndex = 10;
            this.btxMsg.SetText(this.txtdescription, null);
            this.btxMsg.SetTitle(this.txtdescription, null);
            // 
            // cmbpagibigSched
            // 
            this.cmbpagibigSched.BackColor = System.Drawing.SystemColors.Window;
            this.cmbpagibigSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpagibigSched.FormattingEnabled = true;
            this.cmbpagibigSched.Items.AddRange(new object[] {
            "1st Cutoff",
            "2nd Cutoff",
            "1st & 2nd Cutoff"});
            this.cmbpagibigSched.Location = new System.Drawing.Point(353, 51);
            this.cmbpagibigSched.Name = "cmbpagibigSched";
            this.cmbpagibigSched.Size = new System.Drawing.Size(123, 21);
            this.cmbpagibigSched.TabIndex = 11;
            // 
            // cmbphilhealthSched
            // 
            this.cmbphilhealthSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbphilhealthSched.FormattingEnabled = true;
            this.cmbphilhealthSched.Items.AddRange(new object[] {
            "1st Cutoff",
            "2nd Cutoff",
            "1st & 2nd Cutoff"});
            this.cmbphilhealthSched.Location = new System.Drawing.Point(353, 28);
            this.cmbphilhealthSched.Name = "cmbphilhealthSched";
            this.cmbphilhealthSched.Size = new System.Drawing.Size(123, 21);
            this.cmbphilhealthSched.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(233, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pagibig Schedule";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(233, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Philhealth Schedule";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbtaxSched
            // 
            this.cmbtaxSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtaxSched.FormattingEnabled = true;
            this.cmbtaxSched.Items.AddRange(new object[] {
            "1st Cutoff",
            "2nd Cutoff",
            "1st & 2nd Cutoff"});
            this.cmbtaxSched.Location = new System.Drawing.Point(103, 50);
            this.cmbtaxSched.Name = "cmbtaxSched";
            this.cmbtaxSched.Size = new System.Drawing.Size(123, 21);
            this.cmbtaxSched.TabIndex = 7;
            // 
            // cmbsssSched
            // 
            this.cmbsssSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsssSched.FormattingEnabled = true;
            this.cmbsssSched.Items.AddRange(new object[] {
            "1st Cutoff",
            "2nd Cutoff",
            "1st & 2nd Cutoff"});
            this.cmbsssSched.Location = new System.Drawing.Point(103, 28);
            this.cmbsssSched.Name = "cmbsssSched";
            this.cmbsssSched.Size = new System.Drawing.Size(123, 21);
            this.cmbsssSched.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pagibig Share";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tax Schedule";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SSS Schedule";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PayrollGroup_Master_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsvloantype);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PayrollGroup_Master_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Group";
            this.Load += new System.EventHandler(this.PayrollGroup_Master_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnadd;
        private System.Windows.Forms.ToolStripButton btnedit;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ToolStripButton btnsave;
        private System.Windows.Forms.ToolStripButton btncancel;
        private System.Windows.Forms.ToolStripButton btnprint;
        private System.Windows.Forms.ListView lsvloantype;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpagibigSched;
        private System.Windows.Forms.ComboBox cmbphilhealthSched;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbtaxSched;
        private System.Windows.Forms.ComboBox cmbsssSched;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripTextBox txtkeyword;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdescription;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpagibigShare;
    }
}