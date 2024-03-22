namespace DCLGlobal.Systems.Admin
{
    partial class CrewbookPasswordGeneratorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrewbookPasswordGeneratorform));
            this.bntPrincipal = new DevComponents.DotNetBar.ButtonX();
            this.txtPrincipal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnReplanned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntPrincipal
            // 
            this.bntPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntPrincipal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("bntPrincipal.Image")));
            this.bntPrincipal.Location = new System.Drawing.Point(660, 14);
            this.bntPrincipal.Name = "bntPrincipal";
            this.bntPrincipal.Size = new System.Drawing.Size(19, 18);
            this.bntPrincipal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntPrincipal.TabIndex = 1;
            this.bntPrincipal.Click += new System.EventHandler(this.bntPrincipal_Click);
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPrincipal.Border.Class = "TextBoxBorder";
            this.txtPrincipal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrincipal.FocusHighlightEnabled = true;
            this.txtPrincipal.ForeColor = System.Drawing.Color.Black;
            this.txtPrincipal.Location = new System.Drawing.Point(64, 12);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ReadOnly = true;
            this.txtPrincipal.Size = new System.Drawing.Size(617, 21);
            this.txtPrincipal.TabIndex = 0;
            this.txtPrincipal.Tag = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 497;
            this.label4.Text = "Principal";
            // 
            // lsvList
            // 
            this.lsvList.CheckBoxes = true;
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.AccountName,
            this.Company,
            this.columnHeader1});
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 68);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(687, 441);
            this.lsvList.TabIndex = 498;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Select";
            this.id.Width = 44;
            // 
            // AccountName
            // 
            this.AccountName.Text = "Name";
            this.AccountName.Width = 401;
            // 
            // Company
            // 
            this.Company.Text = "Username";
            this.Company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Company.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Password";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 97;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(64, 39);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(68, 17);
            this.chkStatus.TabIndex = 499;
            this.chkStatus.Text = "Select all";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // btnReplanned
            // 
            this.btnReplanned.Image = ((System.Drawing.Image)(resources.GetObject("btnReplanned.Image")));
            this.btnReplanned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplanned.Location = new System.Drawing.Point(549, 39);
            this.btnReplanned.Name = "btnReplanned";
            this.btnReplanned.Size = new System.Drawing.Size(132, 23);
            this.btnReplanned.TabIndex = 535;
            this.btnReplanned.Text = "Save";
            this.btnReplanned.UseVisualStyleBackColor = true;
            this.btnReplanned.Click += new System.EventHandler(this.btnReplanned_Click);
            // 
            // CrewbookPasswordGeneratorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 509);
            this.Controls.Add(this.btnReplanned);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.bntPrincipal);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrewbookPasswordGeneratorform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crewbook Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.ButtonX bntPrincipal;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtPrincipal;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ListView lsvList;
        internal System.Windows.Forms.ColumnHeader id;
        internal System.Windows.Forms.ColumnHeader AccountName;
        internal System.Windows.Forms.ColumnHeader Company;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnReplanned;
    }
}