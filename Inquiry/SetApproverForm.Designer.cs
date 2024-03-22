namespace DCLGlobal.Inquiry
{
    partial class SetApproverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetApproverForm));
            this.btnFRemoveFinalApprover = new System.Windows.Forms.Button();
            this.btnAddFinalApprover = new System.Windows.Forms.Button();
            this.btnRemoveInitialApprover = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtFinalApprover = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAddInitialApprover = new System.Windows.Forms.Button();
            this.txtInitialApprover = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFRemoveFinalApprover
            // 
            this.btnFRemoveFinalApprover.Image = ((System.Drawing.Image)(resources.GetObject("btnFRemoveFinalApprover.Image")));
            this.btnFRemoveFinalApprover.Location = new System.Drawing.Point(453, 99);
            this.btnFRemoveFinalApprover.Name = "btnFRemoveFinalApprover";
            this.btnFRemoveFinalApprover.Size = new System.Drawing.Size(38, 26);
            this.btnFRemoveFinalApprover.TabIndex = 20;
            this.btnFRemoveFinalApprover.UseVisualStyleBackColor = true;
            this.btnFRemoveFinalApprover.Click += new System.EventHandler(this.btnFRemoveFinalApprover_Click);
            // 
            // btnAddFinalApprover
            // 
            this.btnAddFinalApprover.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFinalApprover.Image")));
            this.btnAddFinalApprover.Location = new System.Drawing.Point(413, 99);
            this.btnAddFinalApprover.Name = "btnAddFinalApprover";
            this.btnAddFinalApprover.Size = new System.Drawing.Size(38, 26);
            this.btnAddFinalApprover.TabIndex = 19;
            this.btnAddFinalApprover.UseVisualStyleBackColor = true;
            this.btnAddFinalApprover.Click += new System.EventHandler(this.btnAddFinalApprover_Click);
            // 
            // btnRemoveInitialApprover
            // 
            this.btnRemoveInitialApprover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveInitialApprover.Image")));
            this.btnRemoveInitialApprover.Location = new System.Drawing.Point(453, 33);
            this.btnRemoveInitialApprover.Name = "btnRemoveInitialApprover";
            this.btnRemoveInitialApprover.Size = new System.Drawing.Size(38, 26);
            this.btnRemoveInitialApprover.TabIndex = 18;
            this.btnRemoveInitialApprover.UseVisualStyleBackColor = true;
            this.btnRemoveInitialApprover.Click += new System.EventHandler(this.btnRemoveInitialApprover_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(393, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(292, 146);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(98, 28);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Save";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtFinalApprover
            // 
            this.txtFinalApprover.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFinalApprover.Border.Class = "TextBoxBorder";
            this.txtFinalApprover.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFinalApprover.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalApprover.Location = new System.Drawing.Point(13, 100);
            this.txtFinalApprover.Name = "txtFinalApprover";
            this.txtFinalApprover.ReadOnly = true;
            this.txtFinalApprover.Size = new System.Drawing.Size(398, 23);
            this.txtFinalApprover.TabIndex = 15;
            this.txtFinalApprover.WatermarkText = "Select Final approver";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(81, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Final Approver:";
            // 
            // btnAddInitialApprover
            // 
            this.btnAddInitialApprover.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInitialApprover.Image")));
            this.btnAddInitialApprover.Location = new System.Drawing.Point(413, 33);
            this.btnAddInitialApprover.Name = "btnAddInitialApprover";
            this.btnAddInitialApprover.Size = new System.Drawing.Size(38, 26);
            this.btnAddInitialApprover.TabIndex = 13;
            this.btnAddInitialApprover.UseVisualStyleBackColor = true;
            this.btnAddInitialApprover.Click += new System.EventHandler(this.btnAddInitialApprover_Click);
            // 
            // txtInitialApprover
            // 
            this.txtInitialApprover.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtInitialApprover.Border.Class = "TextBoxBorder";
            this.txtInitialApprover.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInitialApprover.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialApprover.Location = new System.Drawing.Point(13, 35);
            this.txtInitialApprover.Name = "txtInitialApprover";
            this.txtInitialApprover.ReadOnly = true;
            this.txtInitialApprover.Size = new System.Drawing.Size(398, 23);
            this.txtInitialApprover.TabIndex = 12;
            this.txtInitialApprover.WatermarkText = "Select initial approver";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(85, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Initial Approver:";
            // 
            // SetApproverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 189);
            this.Controls.Add(this.btnFRemoveFinalApprover);
            this.Controls.Add(this.btnAddFinalApprover);
            this.Controls.Add(this.btnRemoveInitialApprover);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtFinalApprover);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnAddInitialApprover);
            this.Controls.Add(this.txtInitialApprover);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SetApproverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Approver";
            this.Load += new System.EventHandler(this.SetApproverForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetApproverForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFRemoveFinalApprover;
        internal System.Windows.Forms.Button btnAddFinalApprover;
        internal System.Windows.Forms.Button btnRemoveInitialApprover;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSet;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtFinalApprover;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnAddInitialApprover;
        internal DevComponents.DotNetBar.Controls.TextBoxX txtInitialApprover;
        internal System.Windows.Forms.Label Label1;
    }
}