namespace DCLGlobal.Master.Employee
{
    partial class EmployeeInsuranceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInsuranceControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add_btn = new System.Windows.Forms.ToolStripButton();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInsuranceName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBrowse = new DevComponents.DotNetBar.ButtonX();
            this.txtFileLocation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvInsurance = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewButtonXColumn20 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.DataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.btxMsg = new WindowsFormsToolkit.Controls.BalloonTipExtender();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_btn,
            this.Edit_btn,
            this.Save_btn,
            this.cancel_btn,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 39);
            this.toolStrip1.TabIndex = 500;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add_btn
            // 
            this.Add_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_btn.Image = ((System.Drawing.Image)(resources.GetObject("Add_btn.Image")));
            this.Add_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Add_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(36, 36);
            this.Add_btn.Text = "Add Record";
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
            this.Edit_btn.Text = "Edit Record";
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
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
            this.Save_btn.Text = "Save Record";
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
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 36);
            this.toolStripLabel1.Text = "Employee Insurance";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtInsuranceName);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.txtFileLocation);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 64);
            this.panel1.TabIndex = 516;
            // 
            // txtInsuranceName
            // 
            this.txtInsuranceName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtInsuranceName.Border.Class = "TextBoxBorder";
            this.txtInsuranceName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInsuranceName.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtInsuranceName.FocusHighlightEnabled = true;
            this.txtInsuranceName.ForeColor = System.Drawing.Color.Black;
            this.txtInsuranceName.Location = new System.Drawing.Point(153, 9);
            this.txtInsuranceName.Name = "txtInsuranceName";
            this.txtInsuranceName.Size = new System.Drawing.Size(499, 21);
            this.txtInsuranceName.TabIndex = 134;
            this.btxMsg.SetText(this.txtInsuranceName, "Insurance name is required.");
            this.btxMsg.SetTitle(this.txtInsuranceName, null);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(657, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 20);
            this.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBrowse.TabIndex = 133;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFileLocation.Border.Class = "TextBoxBorder";
            this.txtFileLocation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFileLocation.FocusHighlightColor = System.Drawing.Color.LightBlue;
            this.txtFileLocation.FocusHighlightEnabled = true;
            this.txtFileLocation.ForeColor = System.Drawing.Color.Black;
            this.txtFileLocation.Location = new System.Drawing.Point(153, 35);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(499, 21);
            this.txtFileLocation.TabIndex = 132;
            this.btxMsg.SetText(this.txtFileLocation, "Insurance scanned document is required.");
            this.btxMsg.SetTitle(this.txtFileLocation, null);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(78, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 20);
            this.Label3.TabIndex = 131;
            this.Label3.Text = "File Location:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(62, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 20);
            this.Label1.TabIndex = 130;
            this.Label1.Text = "Insurance name:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInsurance
            // 
            this.dgvInsurance.AllowUserToAddRows = false;
            this.dgvInsurance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn32,
            this.DataGridViewButtonXColumn20,
            this.DataGridViewTextBoxColumn33,
            this.DataGridViewTextBoxColumn36});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsurance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInsurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInsurance.EnableHeadersVisualStyles = false;
            this.dgvInsurance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInsurance.Location = new System.Drawing.Point(0, 103);
            this.dgvInsurance.Name = "dgvInsurance";
            this.dgvInsurance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsurance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInsurance.Size = new System.Drawing.Size(788, 497);
            this.dgvInsurance.TabIndex = 517;
            this.dgvInsurance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsurance_CellClick);
            this.dgvInsurance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsurance_CellContentClick);
            // 
            // DataGridViewTextBoxColumn32
            // 
            this.DataGridViewTextBoxColumn32.DataPropertyName = "employeeinsuranceID";
            this.DataGridViewTextBoxColumn32.HeaderText = "Id";
            this.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32";
            this.DataGridViewTextBoxColumn32.ReadOnly = true;
            this.DataGridViewTextBoxColumn32.Visible = false;
            // 
            // DataGridViewButtonXColumn20
            // 
            this.DataGridViewButtonXColumn20.DataPropertyName = "_open";
            this.DataGridViewButtonXColumn20.HeaderText = "Open File";
            this.DataGridViewButtonXColumn20.Name = "DataGridViewButtonXColumn20";
            this.DataGridViewButtonXColumn20.ReadOnly = true;
            this.DataGridViewButtonXColumn20.Text = null;
            this.DataGridViewButtonXColumn20.Width = 80;
            // 
            // DataGridViewTextBoxColumn33
            // 
            this.DataGridViewTextBoxColumn33.DataPropertyName = "employeeinsuranceNAME";
            this.DataGridViewTextBoxColumn33.HeaderText = "Document name";
            this.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33";
            this.DataGridViewTextBoxColumn33.ReadOnly = true;
            this.DataGridViewTextBoxColumn33.Width = 160;
            // 
            // DataGridViewTextBoxColumn36
            // 
            this.DataGridViewTextBoxColumn36.DataPropertyName = "employeeinsuranceLOCATION";
            this.DataGridViewTextBoxColumn36.HeaderText = "Location";
            this.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36";
            this.DataGridViewTextBoxColumn36.ReadOnly = true;
            this.DataGridViewTextBoxColumn36.Width = 500;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "OpenFileDialog1";
            // 
            // EmployeeInsuranceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInsurance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeInsuranceControl";
            this.Size = new System.Drawing.Size(788, 600);
            this.Load += new System.EventHandler(this.EmployeeInsuranceControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsurance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_btn;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtInsuranceName;
        internal DevComponents.DotNetBar.ButtonX btnBrowse;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFileLocation;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal DevComponents.DotNetBar.Controls.DataGridViewX dgvInsurance;
        internal WindowsFormsToolkit.Controls.BalloonTipExtender btxMsg;
        internal System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn32;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn DataGridViewButtonXColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn36;
    }
}
