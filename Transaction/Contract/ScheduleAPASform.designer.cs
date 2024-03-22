namespace DCLGlobal.Transaction.Contract
{
    partial class ScheduleAPASform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleAPASform));
            this.Label1 = new System.Windows.Forms.Label();
            this.mcAPAS = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdUnschedule = new System.Windows.Forms.Button();
            this.cmdSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(184, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(186, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Select the date you want to schedule";
            // 
            // mcAPAS
            // 
            this.mcAPAS.Location = new System.Drawing.Point(180, 33);
            this.mcAPAS.Name = "mcAPAS";
            this.mcAPAS.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 151);
            this.pictureBox1.TabIndex = 401;
            this.pictureBox1.TabStop = false;
            // 
            // cmdUnschedule
            // 
            this.cmdUnschedule.Enabled = false;
            this.cmdUnschedule.Image = ((System.Drawing.Image)(resources.GetObject("cmdUnschedule.Image")));
            this.cmdUnschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUnschedule.Location = new System.Drawing.Point(301, 207);
            this.cmdUnschedule.Name = "cmdUnschedule";
            this.cmdUnschedule.Size = new System.Drawing.Size(120, 23);
            this.cmdUnschedule.TabIndex = 403;
            this.cmdUnschedule.Text = "Unscheduled";
            this.cmdUnschedule.UseVisualStyleBackColor = true;
            this.cmdUnschedule.Click += new System.EventHandler(this.cmdUnschedule_Click);
            // 
            // cmdSchedule
            // 
            this.cmdSchedule.Image = ((System.Drawing.Image)(resources.GetObject("cmdSchedule.Image")));
            this.cmdSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSchedule.Location = new System.Drawing.Point(178, 207);
            this.cmdSchedule.Name = "cmdSchedule";
            this.cmdSchedule.Size = new System.Drawing.Size(120, 23);
            this.cmdSchedule.TabIndex = 402;
            this.cmdSchedule.Text = "Schedule";
            this.cmdSchedule.UseVisualStyleBackColor = true;
            this.cmdSchedule.Click += new System.EventHandler(this.cmdSchedule_Click);
            // 
            // ScheduleAPASform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.cmdUnschedule);
            this.Controls.Add(this.cmdSchedule);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.mcAPAS);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScheduleAPASform";
            this.Text = "Schedule for APAS";
            this.Load += new System.EventHandler(this.ScheduleAPASform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.MonthCalendar mcAPAS;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button cmdUnschedule;
        internal System.Windows.Forms.Button cmdSchedule;
    }
}