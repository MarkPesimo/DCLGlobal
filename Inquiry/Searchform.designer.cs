namespace DCLGlobal.Inquiry
{
    partial class Searchform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searchform));
            this.txtkeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lsvList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtkeyword
            // 
            this.txtkeyword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtkeyword.Border.Class = "TextBoxBorder";
            this.txtkeyword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtkeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtkeyword.FocusHighlightEnabled = true;
            this.txtkeyword.ForeColor = System.Drawing.Color.Black;
            this.txtkeyword.Location = new System.Drawing.Point(0, 0);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(670, 21);
            this.txtkeyword.TabIndex = 1;
            this.txtkeyword.Text = "Enter Keyword here";
            this.txtkeyword.TextChanged += new System.EventHandler(this.txtkeyword_TextChanged);
            this.txtkeyword.GotFocus += new System.EventHandler(this.txtkeyword_GotFocus);
            this.txtkeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkeyword_KeyDown);
            this.txtkeyword.LostFocus += new System.EventHandler(this.txtkeyword_LostFocus);
            // 
            // lsvList
            // 
            this.lsvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvList.FullRowSelect = true;
            this.lsvList.GridLines = true;
            this.lsvList.Location = new System.Drawing.Point(0, 21);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(670, 552);
            this.lsvList.TabIndex = 2;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvList_SelectedIndexChanged);
            this.lsvList.DoubleClick += new System.EventHandler(this.lsvList_DoubleClick);
            this.lsvList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvList_KeyDown);
            // 
            // Searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 573);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.txtkeyword);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Searchform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search form";
            this.Load += new System.EventHandler(this.Searchform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Searchform_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.TextBoxX txtkeyword;
        internal System.Windows.Forms.ListView lsvList;
    }
}