namespace DCLGlobal.Master.Payroll
{
    partial class Philhealth_Table_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Philhealth_Table_Form));
            this.lsvH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panDetails = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSalaryFrom = new System.Windows.Forms.NumericUpDown();
            this.nudSalaryTo = new System.Windows.Forms.NumericUpDown();
            this.nudSalarybase = new System.Windows.Forms.NumericUpDown();
            this.nudEmployerShare = new System.Windows.Forms.NumericUpDown();
            this.nudEmployeeShare = new System.Windows.Forms.NumericUpDown();
            this.nudMonthlyBase = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaryFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaryTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarybase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployerShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyBase)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvH
            // 
            this.lsvH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvH.FullRowSelect = true;
            this.lsvH.GridLines = true;
            this.lsvH.Location = new System.Drawing.Point(0, 87);
            this.lsvH.Name = "lsvH";
            this.lsvH.Size = new System.Drawing.Size(812, 409);
            this.lsvH.TabIndex = 9;
            this.lsvH.UseCompatibleStateImageBehavior = false;
            this.lsvH.View = System.Windows.Forms.View.Details;
            this.lsvH.DoubleClick += new System.EventHandler(this.lsvH_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Salary Bracket";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Salary from";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salary to";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salary Base";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total monthly";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Employee share";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Employer share";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 121;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "REPUBLIC OF THE PHILIPPINES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(231, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "PHILHEALTH";
            // 
            // panDetails
            // 
            this.panDetails.BackColor = System.Drawing.SystemColors.Control;
            this.panDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDetails.Controls.Add(this.nudEmployerShare);
            this.panDetails.Controls.Add(this.nudEmployeeShare);
            this.panDetails.Controls.Add(this.nudMonthlyBase);
            this.panDetails.Controls.Add(this.nudSalarybase);
            this.panDetails.Controls.Add(this.nudSalaryTo);
            this.panDetails.Controls.Add(this.nudSalaryFrom);
            this.panDetails.Controls.Add(this.btncancel);
            this.panDetails.Controls.Add(this.btnsave);
            this.panDetails.Controls.Add(this.label9);
            this.panDetails.Controls.Add(this.label8);
            this.panDetails.Controls.Add(this.label7);
            this.panDetails.Controls.Add(this.label6);
            this.panDetails.Controls.Add(this.label5);
            this.panDetails.Controls.Add(this.label4);
            this.panDetails.Controls.Add(this.panel2);
            this.panDetails.Location = new System.Drawing.Point(169, 165);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(480, 153);
            this.panDetails.TabIndex = 13;
            this.panDetails.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(247, 110);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(97, 29);
            this.btncancel.TabIndex = 38;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(147, 110);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 29);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(239, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Employer share";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(239, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Employee share";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(239, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total monthly";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(5, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Salary base";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(5, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Salary to";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(5, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salary from";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 20);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update Details";
            // 
            // nudSalaryFrom
            // 
            this.nudSalaryFrom.DecimalPlaces = 2;
            this.nudSalaryFrom.Location = new System.Drawing.Point(113, 24);
            this.nudSalaryFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSalaryFrom.Name = "nudSalaryFrom";
            this.nudSalaryFrom.Size = new System.Drawing.Size(120, 21);
            this.nudSalaryFrom.TabIndex = 39;
            this.nudSalaryFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSalaryTo
            // 
            this.nudSalaryTo.DecimalPlaces = 2;
            this.nudSalaryTo.Location = new System.Drawing.Point(113, 50);
            this.nudSalaryTo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSalaryTo.Name = "nudSalaryTo";
            this.nudSalaryTo.Size = new System.Drawing.Size(120, 21);
            this.nudSalaryTo.TabIndex = 40;
            this.nudSalaryTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudSalarybase
            // 
            this.nudSalarybase.DecimalPlaces = 2;
            this.nudSalarybase.Location = new System.Drawing.Point(113, 76);
            this.nudSalarybase.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSalarybase.Name = "nudSalarybase";
            this.nudSalarybase.Size = new System.Drawing.Size(120, 21);
            this.nudSalarybase.TabIndex = 41;
            this.nudSalarybase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudEmployerShare
            // 
            this.nudEmployerShare.DecimalPlaces = 2;
            this.nudEmployerShare.Location = new System.Drawing.Point(348, 77);
            this.nudEmployerShare.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudEmployerShare.Name = "nudEmployerShare";
            this.nudEmployerShare.Size = new System.Drawing.Size(120, 21);
            this.nudEmployerShare.TabIndex = 44;
            this.nudEmployerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudEmployeeShare
            // 
            this.nudEmployeeShare.DecimalPlaces = 2;
            this.nudEmployeeShare.Location = new System.Drawing.Point(348, 51);
            this.nudEmployeeShare.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudEmployeeShare.Name = "nudEmployeeShare";
            this.nudEmployeeShare.Size = new System.Drawing.Size(120, 21);
            this.nudEmployeeShare.TabIndex = 43;
            this.nudEmployeeShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMonthlyBase
            // 
            this.nudMonthlyBase.DecimalPlaces = 2;
            this.nudMonthlyBase.Location = new System.Drawing.Point(348, 25);
            this.nudMonthlyBase.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMonthlyBase.Name = "nudMonthlyBase";
            this.nudMonthlyBase.Size = new System.Drawing.Size(120, 21);
            this.nudMonthlyBase.TabIndex = 42;
            this.nudMonthlyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Philhealth_Table_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(812, 496);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lsvH);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Philhealth_Table_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Philhealth Table";
            this.Load += new System.EventHandler(this.Philhealth_Table_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panDetails.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaryFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaryTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarybase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployerShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmployeeShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlyBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.NumericUpDown nudEmployerShare;
        private System.Windows.Forms.NumericUpDown nudEmployeeShare;
        private System.Windows.Forms.NumericUpDown nudMonthlyBase;
        private System.Windows.Forms.NumericUpDown nudSalarybase;
        private System.Windows.Forms.NumericUpDown nudSalaryTo;
        private System.Windows.Forms.NumericUpDown nudSalaryFrom;
    }
}