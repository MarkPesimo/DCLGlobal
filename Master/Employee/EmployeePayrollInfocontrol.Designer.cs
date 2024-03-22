namespace DCLGlobal.Master.Employee
{
    partial class EmployeePayrollInfocontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePayrollInfocontrol));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Edit_btn = new System.Windows.Forms.ToolStripButton();
            this.Save_btn = new System.Windows.Forms.ToolStripButton();
            this.Cancel_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.nudTax = new System.Windows.Forms.NumericUpDown();
            this.nudPagibig = new System.Windows.Forms.NumericUpDown();
            this.nudMealAllowance = new System.Windows.Forms.NumericUpDown();
            this.nudRiceAllowance = new System.Windows.Forms.NumericUpDown();
            this.chkInclude = new System.Windows.Forms.CheckBox();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.chkPagibig = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCola = new System.Windows.Forms.NumericUpDown();
            this.nudAllowance = new System.Windows.Forms.NumericUpDown();
            this.nudAnualTaxEx = new System.Windows.Forms.NumericUpDown();
            this.cmbExemption = new System.Windows.Forms.ComboBox();
            this.nudMonthlySal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTIN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAccntNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numTaxPercentage = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.chkConfidential = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCardNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagibig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMealAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRiceAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllowance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnualTaxEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlySal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_btn,
            this.Save_btn,
            this.Cancel_btn,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(788, 39);
            this.toolStrip2.TabIndex = 510;
            this.toolStrip2.Text = "toolStrip2";
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
            // Cancel_btn
            // 
            this.Cancel_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cancel_btn.Enabled = false;
            this.Cancel_btn.Image = ((System.Drawing.Image)(resources.GetObject("Cancel_btn.Image")));
            this.Cancel_btn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cancel_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(36, 36);
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(122, 36);
            this.toolStripLabel2.Text = "Salary Information";
            // 
            // nudTax
            // 
            this.nudTax.DecimalPlaces = 2;
            this.nudTax.Location = new System.Drawing.Point(296, 107);
            this.nudTax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTax.Name = "nudTax";
            this.nudTax.Size = new System.Drawing.Size(110, 21);
            this.nudTax.TabIndex = 12;
            this.nudTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPagibig
            // 
            this.nudPagibig.DecimalPlaces = 2;
            this.nudPagibig.Location = new System.Drawing.Point(296, 84);
            this.nudPagibig.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPagibig.Name = "nudPagibig";
            this.nudPagibig.Size = new System.Drawing.Size(110, 21);
            this.nudPagibig.TabIndex = 10;
            this.nudPagibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMealAllowance
            // 
            this.nudMealAllowance.DecimalPlaces = 2;
            this.nudMealAllowance.Location = new System.Drawing.Point(296, 62);
            this.nudMealAllowance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMealAllowance.Name = "nudMealAllowance";
            this.nudMealAllowance.Size = new System.Drawing.Size(110, 21);
            this.nudMealAllowance.TabIndex = 8;
            this.nudMealAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudRiceAllowance
            // 
            this.nudRiceAllowance.DecimalPlaces = 2;
            this.nudRiceAllowance.Location = new System.Drawing.Point(296, 40);
            this.nudRiceAllowance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRiceAllowance.Name = "nudRiceAllowance";
            this.nudRiceAllowance.Size = new System.Drawing.Size(110, 21);
            this.nudRiceAllowance.TabIndex = 7;
            this.nudRiceAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkInclude
            // 
            this.chkInclude.AutoSize = true;
            this.chkInclude.Location = new System.Drawing.Point(299, 137);
            this.chkInclude.Name = "chkInclude";
            this.chkInclude.Size = new System.Drawing.Size(113, 17);
            this.chkInclude.TabIndex = 13;
            this.chkInclude.Text = "Include for payroll";
            this.chkInclude.UseVisualStyleBackColor = true;
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Location = new System.Drawing.Point(157, 109);
            this.chkTax.Name = "chkTax";
            this.chkTax.Size = new System.Drawing.Size(136, 17);
            this.chkTax.TabIndex = 11;
            this.chkTax.Text = "Manual Tax Deduction:";
            this.chkTax.UseVisualStyleBackColor = true;
            // 
            // chkPagibig
            // 
            this.chkPagibig.AutoSize = true;
            this.chkPagibig.Location = new System.Drawing.Point(201, 87);
            this.chkPagibig.Name = "chkPagibig";
            this.chkPagibig.Size = new System.Drawing.Size(92, 17);
            this.chkPagibig.TabIndex = 9;
            this.chkPagibig.Text = "PagIbig Cont:";
            this.chkPagibig.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(198, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Deminimis benifits:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Rice Allowance:";
            // 
            // nudCola
            // 
            this.nudCola.DecimalPlaces = 2;
            this.nudCola.Location = new System.Drawing.Point(296, 113);
            this.nudCola.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCola.Name = "nudCola";
            this.nudCola.Size = new System.Drawing.Size(110, 21);
            this.nudCola.TabIndex = 4;
            this.nudCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudAllowance
            // 
            this.nudAllowance.DecimalPlaces = 2;
            this.nudAllowance.Location = new System.Drawing.Point(296, 91);
            this.nudAllowance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAllowance.Name = "nudAllowance";
            this.nudAllowance.Size = new System.Drawing.Size(110, 21);
            this.nudAllowance.TabIndex = 3;
            this.nudAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudAnualTaxEx
            // 
            this.nudAnualTaxEx.DecimalPlaces = 2;
            this.nudAnualTaxEx.Location = new System.Drawing.Point(296, 69);
            this.nudAnualTaxEx.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAnualTaxEx.Name = "nudAnualTaxEx";
            this.nudAnualTaxEx.Size = new System.Drawing.Size(110, 21);
            this.nudAnualTaxEx.TabIndex = 2;
            this.nudAnualTaxEx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbExemption
            // 
            this.cmbExemption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExemption.FormattingEnabled = true;
            this.cmbExemption.Items.AddRange(new object[] {
            "Z",
            "S/ME",
            "ME1/S1",
            "ME2/S2",
            "ME3/S3",
            "ME4/S4"});
            this.cmbExemption.Location = new System.Drawing.Point(296, 47);
            this.cmbExemption.Name = "cmbExemption";
            this.cmbExemption.Size = new System.Drawing.Size(110, 21);
            this.cmbExemption.TabIndex = 1;
            // 
            // nudMonthlySal
            // 
            this.nudMonthlySal.DecimalPlaces = 2;
            this.nudMonthlySal.Location = new System.Drawing.Point(296, 25);
            this.nudMonthlySal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMonthlySal.Name = "nudMonthlySal";
            this.nudMonthlySal.Size = new System.Drawing.Size(110, 21);
            this.nudMonthlySal.TabIndex = 0;
            this.nudMonthlySal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TIN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Account No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "COLA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Allowance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Annual Tax Excemption:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax Exception:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Salary:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCardNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtTIN);
            this.panel1.Controls.Add(this.txtAccntNo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudAnualTaxEx);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudCola);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbExemption);
            this.panel1.Controls.Add(this.nudMonthlySal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudAllowance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 225);
            this.panel1.TabIndex = 512;
            // 
            // txtTIN
            // 
            this.txtTIN.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTIN.Border.Class = "TextBoxBorder";
            this.txtTIN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTIN.FocusHighlightEnabled = true;
            this.txtTIN.ForeColor = System.Drawing.Color.Black;
            this.txtTIN.Location = new System.Drawing.Point(296, 158);
            this.txtTIN.Multiline = true;
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(111, 22);
            this.txtTIN.TabIndex = 6;
            // 
            // txtAccntNo
            // 
            this.txtAccntNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAccntNo.Border.Class = "TextBoxBorder";
            this.txtAccntNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAccntNo.FocusHighlightEnabled = true;
            this.txtAccntNo.ForeColor = System.Drawing.Color.Black;
            this.txtAccntNo.Location = new System.Drawing.Point(296, 135);
            this.txtAccntNo.Multiline = true;
            this.txtAccntNo.Name = "txtAccntNo";
            this.txtAccntNo.Size = new System.Drawing.Size(111, 22);
            this.txtAccntNo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 136);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(788, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "      Salary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.numTaxPercentage);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.chkConfidential);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nudTax);
            this.panel2.Controls.Add(this.nudPagibig);
            this.panel2.Controls.Add(this.nudMealAllowance);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.nudRiceAllowance);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.chkInclude);
            this.panel2.Controls.Add(this.chkPagibig);
            this.panel2.Controls.Add(this.chkTax);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 229);
            this.panel2.TabIndex = 513;
            // 
            // numTaxPercentage
            // 
            this.numTaxPercentage.DecimalPlaces = 2;
            this.numTaxPercentage.Location = new System.Drawing.Point(299, 174);
            this.numTaxPercentage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTaxPercentage.Name = "numTaxPercentage";
            this.numTaxPercentage.ReadOnly = true;
            this.numTaxPercentage.Size = new System.Drawing.Size(110, 21);
            this.numTaxPercentage.TabIndex = 27;
            this.numTaxPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tax Percentage:";
            // 
            // chkConfidential
            // 
            this.chkConfidential.AutoSize = true;
            this.chkConfidential.Location = new System.Drawing.Point(299, 156);
            this.chkConfidential.Name = "chkConfidential";
            this.chkConfidential.Size = new System.Drawing.Size(83, 17);
            this.chkConfidential.TabIndex = 26;
            this.chkConfidential.Text = "Confidential";
            this.chkConfidential.UseVisualStyleBackColor = true;
            this.chkConfidential.CheckedChanged += new System.EventHandler(this.chkConfidential_CheckedChanged);
            this.chkConfidential.Click += new System.EventHandler(this.chkConfidential_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 150);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(788, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "      Deduction";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCardNo
            // 
            this.txtCardNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCardNo.Border.Class = "TextBoxBorder";
            this.txtCardNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCardNo.FocusHighlightEnabled = true;
            this.txtCardNo.ForeColor = System.Drawing.Color.Black;
            this.txtCardNo.Location = new System.Drawing.Point(296, 182);
            this.txtCardNo.Multiline = true;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(111, 22);
            this.txtCardNo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Card No.:";
            // 
            // EmployeePayrollInfocontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeePayrollInfocontrol";
            this.Size = new System.Drawing.Size(788, 617);
            this.Load += new System.EventHandler(this.EmployeePayrollInfocontrol_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPagibig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMealAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRiceAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAllowance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnualTaxEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthlySal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Edit_btn;
        private System.Windows.Forms.ToolStripButton Save_btn;
        private System.Windows.Forms.ToolStripButton Cancel_btn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTax;
        private System.Windows.Forms.NumericUpDown nudPagibig;
        private System.Windows.Forms.NumericUpDown nudMealAllowance;
        private System.Windows.Forms.NumericUpDown nudRiceAllowance;
        private System.Windows.Forms.CheckBox chkInclude;
        private System.Windows.Forms.CheckBox chkTax;
        private System.Windows.Forms.CheckBox chkPagibig;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudCola;
        private System.Windows.Forms.NumericUpDown nudAllowance;
        private System.Windows.Forms.NumericUpDown nudAnualTaxEx;
        private System.Windows.Forms.ComboBox cmbExemption;
        private System.Windows.Forms.NumericUpDown nudMonthlySal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtTIN;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtAccntNo;
        private System.Windows.Forms.CheckBox chkConfidential;
        private System.Windows.Forms.NumericUpDown numTaxPercentage;
        private System.Windows.Forms.Label label10;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtCardNo;
        private System.Windows.Forms.Label label11;
    }
}
