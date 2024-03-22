namespace DCLGlobal.Master.Payroll
{
    partial class SSS_Table_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSS_Table_Form));
            this.lsvH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panDetails = new System.Windows.Forms.Panel();
            this.nudMonthlySalary = new System.Windows.Forms.NumericUpDown();
            this.nudRangeTo = new System.Windows.Forms.NumericUpDown();
            this.nudRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.nudTotalContri = new System.Windows.Forms.NumericUpDown();
            this.nudTC_Total = new System.Windows.Forms.NumericUpDown();
            this.nudTC_EE = new System.Windows.Forms.NumericUpDown();
            this.nudTC_ER = new System.Windows.Forms.NumericUpDown();
            this.nudER = new System.Windows.Forms.NumericUpDown();
            this.nudSSTotal = new System.Windows.Forms.NumericUpDown();
            this.nudSS_EE = new System.Windows.Forms.NumericUpDown();
            this.nudSS_ER = new System.Windows.Forms.NumericUpDown();
            this.txtTotalContri = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTC_Total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTC_EE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTC_ER = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtER = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSSTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSS_EE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSS_ER = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlySalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalContri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC_EE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC_ER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSSTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSS_EE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSS_ER)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lsvH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvH.FullRowSelect = true;
            this.lsvH.GridLines = true;
            this.lsvH.Location = new System.Drawing.Point(0, 91);
            this.lsvH.Name = "lsvH";
            this.lsvH.Size = new System.Drawing.Size(832, 409);
            this.lsvH.TabIndex = 10;
            this.lsvH.UseCompatibleStateImageBehavior = false;
            this.lsvH.View = System.Windows.Forms.View.Details;
            this.lsvH.DoubleClick += new System.EventHandler(this.lsvH_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Range from";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Range to";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monthly salary";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ER";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EE";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "EC";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ER";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "EE";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Total Contribution";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 98;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "id";
            this.columnHeader12.Width = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 76);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(148, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "SOCIAL SECURITY SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(148, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "REPUBLIC OF THE PHILIPPINES";
            // 
            // panDetails
            // 
            this.panDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.panDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panDetails.Controls.Add(this.nudMonthlySalary);
            this.panDetails.Controls.Add(this.nudRangeTo);
            this.panDetails.Controls.Add(this.nudRangeFrom);
            this.panDetails.Controls.Add(this.btncancel);
            this.panDetails.Controls.Add(this.btnsave);
            this.panDetails.Controls.Add(this.nudTotalContri);
            this.panDetails.Controls.Add(this.nudTC_Total);
            this.panDetails.Controls.Add(this.nudTC_EE);
            this.panDetails.Controls.Add(this.nudTC_ER);
            this.panDetails.Controls.Add(this.nudER);
            this.panDetails.Controls.Add(this.nudSSTotal);
            this.panDetails.Controls.Add(this.nudSS_EE);
            this.panDetails.Controls.Add(this.nudSS_ER);
            this.panDetails.Controls.Add(this.txtTotalContri);
            this.panDetails.Controls.Add(this.label14);
            this.panDetails.Controls.Add(this.txtTC_Total);
            this.panDetails.Controls.Add(this.label13);
            this.panDetails.Controls.Add(this.txtTC_EE);
            this.panDetails.Controls.Add(this.label12);
            this.panDetails.Controls.Add(this.txtTC_ER);
            this.panDetails.Controls.Add(this.label11);
            this.panDetails.Controls.Add(this.txtER);
            this.panDetails.Controls.Add(this.label10);
            this.panDetails.Controls.Add(this.txtSSTotal);
            this.panDetails.Controls.Add(this.label9);
            this.panDetails.Controls.Add(this.txtSS_EE);
            this.panDetails.Controls.Add(this.label8);
            this.panDetails.Controls.Add(this.txtSS_ER);
            this.panDetails.Controls.Add(this.label7);
            this.panDetails.Controls.Add(this.label6);
            this.panDetails.Controls.Add(this.label5);
            this.panDetails.Controls.Add(this.label4);
            this.panDetails.Controls.Add(this.panel2);
            this.panDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panDetails.Location = new System.Drawing.Point(13, 181);
            this.panDetails.Name = "panDetails";
            this.panDetails.Size = new System.Drawing.Size(801, 116);
            this.panDetails.TabIndex = 15;
            this.panDetails.Visible = false;
            // 
            // nudMonthlySalary
            // 
            this.nudMonthlySalary.DecimalPlaces = 2;
            this.nudMonthlySalary.Location = new System.Drawing.Point(189, 43);
            this.nudMonthlySalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMonthlySalary.Name = "nudMonthlySalary";
            this.nudMonthlySalary.Size = new System.Drawing.Size(102, 21);
            this.nudMonthlySalary.TabIndex = 39;
            this.nudMonthlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudRangeTo
            // 
            this.nudRangeTo.DecimalPlaces = 2;
            this.nudRangeTo.Location = new System.Drawing.Point(105, 43);
            this.nudRangeTo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudRangeTo.Name = "nudRangeTo";
            this.nudRangeTo.Size = new System.Drawing.Size(83, 21);
            this.nudRangeTo.TabIndex = 38;
            this.nudRangeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudRangeFrom
            // 
            this.nudRangeFrom.DecimalPlaces = 2;
            this.nudRangeFrom.Location = new System.Drawing.Point(2, 43);
            this.nudRangeFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudRangeFrom.Name = "nudRangeFrom";
            this.nudRangeFrom.Size = new System.Drawing.Size(102, 21);
            this.nudRangeFrom.TabIndex = 37;
            this.nudRangeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(694, 73);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(97, 29);
            this.btncancel.TabIndex = 36;
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
            this.btnsave.Location = new System.Drawing.Point(594, 73);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 29);
            this.btnsave.TabIndex = 35;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // nudTotalContri
            // 
            this.nudTotalContri.DecimalPlaces = 2;
            this.nudTotalContri.ForeColor = System.Drawing.Color.Blue;
            this.nudTotalContri.Location = new System.Drawing.Point(719, 43);
            this.nudTotalContri.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTotalContri.Name = "nudTotalContri";
            this.nudTotalContri.Size = new System.Drawing.Size(77, 21);
            this.nudTotalContri.TabIndex = 32;
            this.nudTotalContri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudTC_Total
            // 
            this.nudTC_Total.DecimalPlaces = 2;
            this.nudTC_Total.ForeColor = System.Drawing.Color.Blue;
            this.nudTC_Total.Location = new System.Drawing.Point(658, 43);
            this.nudTC_Total.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTC_Total.Name = "nudTC_Total";
            this.nudTC_Total.Size = new System.Drawing.Size(60, 21);
            this.nudTC_Total.TabIndex = 31;
            this.nudTC_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudTC_EE
            // 
            this.nudTC_EE.DecimalPlaces = 2;
            this.nudTC_EE.ForeColor = System.Drawing.Color.Blue;
            this.nudTC_EE.Location = new System.Drawing.Point(597, 43);
            this.nudTC_EE.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTC_EE.Name = "nudTC_EE";
            this.nudTC_EE.Size = new System.Drawing.Size(60, 21);
            this.nudTC_EE.TabIndex = 30;
            this.nudTC_EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudTC_ER
            // 
            this.nudTC_ER.DecimalPlaces = 2;
            this.nudTC_ER.ForeColor = System.Drawing.Color.Blue;
            this.nudTC_ER.Location = new System.Drawing.Point(536, 43);
            this.nudTC_ER.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTC_ER.Name = "nudTC_ER";
            this.nudTC_ER.Size = new System.Drawing.Size(60, 21);
            this.nudTC_ER.TabIndex = 29;
            this.nudTC_ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTC_ER.ValueChanged += new System.EventHandler(this.nudTC_ER_ValueChanged);
            this.nudTC_ER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudTC_ER_KeyDown);
            // 
            // nudER
            // 
            this.nudER.DecimalPlaces = 2;
            this.nudER.Location = new System.Drawing.Point(475, 43);
            this.nudER.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudER.Name = "nudER";
            this.nudER.Size = new System.Drawing.Size(60, 21);
            this.nudER.TabIndex = 28;
            this.nudER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudER.ValueChanged += new System.EventHandler(this.nudER_ValueChanged);
            this.nudER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudER_KeyDown);
            // 
            // nudSSTotal
            // 
            this.nudSSTotal.DecimalPlaces = 2;
            this.nudSSTotal.Location = new System.Drawing.Point(414, 43);
            this.nudSSTotal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSSTotal.Name = "nudSSTotal";
            this.nudSSTotal.Size = new System.Drawing.Size(60, 21);
            this.nudSSTotal.TabIndex = 27;
            this.nudSSTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudSS_EE
            // 
            this.nudSS_EE.DecimalPlaces = 2;
            this.nudSS_EE.Location = new System.Drawing.Point(353, 43);
            this.nudSS_EE.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSS_EE.Name = "nudSS_EE";
            this.nudSS_EE.Size = new System.Drawing.Size(60, 21);
            this.nudSS_EE.TabIndex = 26;
            this.nudSS_EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudSS_ER
            // 
            this.nudSS_ER.DecimalPlaces = 2;
            this.nudSS_ER.Location = new System.Drawing.Point(292, 43);
            this.nudSS_ER.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSS_ER.Name = "nudSS_ER";
            this.nudSS_ER.Size = new System.Drawing.Size(60, 21);
            this.nudSS_ER.TabIndex = 25;
            this.nudSS_ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSS_ER.ValueChanged += new System.EventHandler(this.nudSS_ER_ValueChanged);
            this.nudSS_ER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudSS_ER_KeyDown);
            // 
            // txtTotalContri
            // 
            this.txtTotalContri.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalContri.Location = new System.Drawing.Point(719, 173);
            this.txtTotalContri.Name = "txtTotalContri";
            this.txtTotalContri.Size = new System.Drawing.Size(78, 21);
            this.txtTotalContri.TabIndex = 22;
            this.txtTotalContri.Text = "0";
            this.txtTotalContri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Khaki;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(719, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 21;
            this.label14.Text = "Total";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTC_Total
            // 
            this.txtTC_Total.ForeColor = System.Drawing.Color.Blue;
            this.txtTC_Total.Location = new System.Drawing.Point(658, 173);
            this.txtTC_Total.Name = "txtTC_Total";
            this.txtTC_Total.Size = new System.Drawing.Size(60, 21);
            this.txtTC_Total.TabIndex = 20;
            this.txtTC_Total.Text = "0";
            this.txtTC_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Khaki;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(658, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTC_EE
            // 
            this.txtTC_EE.ForeColor = System.Drawing.Color.Blue;
            this.txtTC_EE.Location = new System.Drawing.Point(597, 173);
            this.txtTC_EE.Name = "txtTC_EE";
            this.txtTC_EE.Size = new System.Drawing.Size(60, 21);
            this.txtTC_EE.TabIndex = 18;
            this.txtTC_EE.Text = "0";
            this.txtTC_EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Khaki;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(597, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "EE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTC_ER
            // 
            this.txtTC_ER.ForeColor = System.Drawing.Color.Blue;
            this.txtTC_ER.Location = new System.Drawing.Point(536, 173);
            this.txtTC_ER.Name = "txtTC_ER";
            this.txtTC_ER.Size = new System.Drawing.Size(60, 21);
            this.txtTC_ER.TabIndex = 16;
            this.txtTC_ER.Text = "0";
            this.txtTC_ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Khaki;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(536, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "ER";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtER
            // 
            this.txtER.Location = new System.Drawing.Point(475, 173);
            this.txtER.Name = "txtER";
            this.txtER.Size = new System.Drawing.Size(60, 21);
            this.txtER.TabIndex = 14;
            this.txtER.Text = "0";
            this.txtER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Khaki;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(475, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "EC";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSSTotal
            // 
            this.txtSSTotal.Location = new System.Drawing.Point(414, 173);
            this.txtSSTotal.Name = "txtSSTotal";
            this.txtSSTotal.Size = new System.Drawing.Size(60, 21);
            this.txtSSTotal.TabIndex = 12;
            this.txtSSTotal.Text = "0";
            this.txtSSTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(414, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSS_EE
            // 
            this.txtSS_EE.Location = new System.Drawing.Point(353, 173);
            this.txtSS_EE.Name = "txtSS_EE";
            this.txtSS_EE.Size = new System.Drawing.Size(60, 21);
            this.txtSS_EE.TabIndex = 10;
            this.txtSS_EE.Text = "0";
            this.txtSS_EE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(353, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "EE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSS_ER
            // 
            this.txtSS_ER.Location = new System.Drawing.Point(292, 173);
            this.txtSS_ER.Name = "txtSS_ER";
            this.txtSS_ER.Size = new System.Drawing.Size(60, 21);
            this.txtSS_ER.TabIndex = 8;
            this.txtSS_ER.Text = "0";
            this.txtSS_ER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(292, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "ER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(189, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monthly salary";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(105, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Range from";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(2, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Range from";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 22);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Update Details";
            // 
            // SSS_Table_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(832, 500);
            this.Controls.Add(this.panDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lsvH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SSS_Table_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSS Table";
            this.Load += new System.EventHandler(this.SSS_Table_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panDetails.ResumeLayout(false);
            this.panDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlySalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalContri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC_EE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC_ER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSSTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSS_EE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSS_ER)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panDetails;
        private System.Windows.Forms.TextBox txtER;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSSTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSS_EE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSS_ER;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalContri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTC_Total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTC_EE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTC_ER;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudTotalContri;
        private System.Windows.Forms.NumericUpDown nudTC_Total;
        private System.Windows.Forms.NumericUpDown nudTC_EE;
        private System.Windows.Forms.NumericUpDown nudTC_ER;
        private System.Windows.Forms.NumericUpDown nudER;
        private System.Windows.Forms.NumericUpDown nudSSTotal;
        private System.Windows.Forms.NumericUpDown nudSS_EE;
        private System.Windows.Forms.NumericUpDown nudSS_ER;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.NumericUpDown nudMonthlySalary;
        private System.Windows.Forms.NumericUpDown nudRangeTo;
        private System.Windows.Forms.NumericUpDown nudRangeFrom;
    }
}