namespace DCLGlobal.Master.CrewInfo
{
    partial class AddMedicalRequestform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicalRequestform));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.lsvSelected = new System.Windows.Forms.ListView();
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvAvailable = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label1 = new System.Windows.Forms.Label();
            this.lblLeftSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(472, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 26);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(556, 467);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 25);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Button2
            // 
            this.Button2.Image = ((System.Drawing.Image)(resources.GetObject("Button2.Image")));
            this.Button2.Location = new System.Drawing.Point(305, 94);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(33, 25);
            this.Button2.TabIndex = 11;
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Image = ((System.Drawing.Image)(resources.GetObject("Button1.Image")));
            this.Button1.Location = new System.Drawing.Point(305, 63);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(33, 25);
            this.Button1.TabIndex = 10;
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // lsvSelected
            // 
            this.lsvSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvSelected.FullRowSelect = true;
            this.lsvSelected.GridLines = true;
            this.lsvSelected.Location = new System.Drawing.Point(342, 1);
            this.lsvSelected.Name = "lsvSelected";
            this.lsvSelected.Size = new System.Drawing.Size(297, 465);
            this.lsvSelected.TabIndex = 9;
            this.lsvSelected.UseCompatibleStateImageBehavior = false;
            this.lsvSelected.View = System.Windows.Forms.View.Details;
            this.lsvSelected.SelectedIndexChanged += new System.EventHandler(this.lsvSelected_SelectedIndexChanged);
            this.lsvSelected.DoubleClick += new System.EventHandler(this.lsvSelected_DoubleClick);
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Check up";
            this.ColumnHeader3.Width = 253;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "id";
            this.ColumnHeader4.Width = 0;
            // 
            // lsvAvailable
            // 
            this.lsvAvailable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.lsvAvailable.FullRowSelect = true;
            this.lsvAvailable.GridLines = true;
            this.lsvAvailable.Location = new System.Drawing.Point(2, 1);
            this.lsvAvailable.Name = "lsvAvailable";
            this.lsvAvailable.Size = new System.Drawing.Size(297, 465);
            this.lsvAvailable.TabIndex = 8;
            this.lsvAvailable.UseCompatibleStateImageBehavior = false;
            this.lsvAvailable.View = System.Windows.Forms.View.Details;
            this.lsvAvailable.DoubleClick += new System.EventHandler(this.lsvAvailable_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Check up";
            this.ColumnHeader1.Width = 253;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "id";
            this.ColumnHeader2.Width = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(339, 473);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(13, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "0";
            this.Label1.Visible = false;
            // 
            // lblLeftSelected
            // 
            this.lblLeftSelected.AutoSize = true;
            this.lblLeftSelected.ForeColor = System.Drawing.Color.Red;
            this.lblLeftSelected.Location = new System.Drawing.Point(2, 473);
            this.lblLeftSelected.Name = "lblLeftSelected";
            this.lblLeftSelected.Size = new System.Drawing.Size(13, 13);
            this.lblLeftSelected.TabIndex = 14;
            this.lblLeftSelected.Text = "0";
            // 
            // AddMedicalRequestform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 495);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblLeftSelected);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lsvSelected);
            this.Controls.Add(this.lsvAvailable);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddMedicalRequestform";
            this.Text = "Choose medical check up(s)";
            this.Load += new System.EventHandler(this.AddMedicalRequestform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ListView lsvSelected;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ListView lsvAvailable;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblLeftSelected;
    }
}