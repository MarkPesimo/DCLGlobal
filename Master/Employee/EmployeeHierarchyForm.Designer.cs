namespace DCLGlobal.Master.Employee
{
    partial class EmployeeHierarchyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHierarchyForm));
            this.UserAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cntAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.cntSaveHead = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SetApproverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ElementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.NodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.ColumnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.ColumnHeader3 = new DevComponents.AdvTree.ColumnHeader();
            this.PanelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.treeEmployee = new DevComponents.AdvTree.AdvTree();
            this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
            this.chkExpand = new System.Windows.Forms.CheckBox();
            this.btnSaveHead = new DevComponents.DotNetBar.ButtonX();
            this.btnFind = new DevComponents.DotNetBar.ButtonX();
            this.txtname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Label1 = new System.Windows.Forms.Label();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.ContextMenuStrip1.SuspendLayout();
            this.PanelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeEmployee)).BeginInit();
            this.PanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserAccountToolStripMenuItem
            // 
            this.UserAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserAccountToolStripMenuItem.Image")));
            this.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem";
            this.UserAccountToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.UserAccountToolStripMenuItem.Text = "User Account";
            this.UserAccountToolStripMenuItem.Click += new System.EventHandler(this.UserAccountToolStripMenuItem_Click);
            // 
            // cntRemove
            // 
            this.cntRemove.Image = ((System.Drawing.Image)(resources.GetObject("cntRemove.Image")));
            this.cntRemove.Name = "cntRemove";
            this.cntRemove.Size = new System.Drawing.Size(145, 22);
            this.cntRemove.Text = "Remove";
            this.cntRemove.Click += new System.EventHandler(this.cntRemove_Click);
            // 
            // cntAddStaff
            // 
            this.cntAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("cntAddStaff.Image")));
            this.cntAddStaff.Name = "cntAddStaff";
            this.cntAddStaff.Size = new System.Drawing.Size(145, 22);
            this.cntAddStaff.Text = "Add Staff";
            this.cntAddStaff.Click += new System.EventHandler(this.cntAddStaff_Click);
            // 
            // cntSaveHead
            // 
            this.cntSaveHead.Image = ((System.Drawing.Image)(resources.GetObject("cntSaveHead.Image")));
            this.cntSaveHead.Name = "cntSaveHead";
            this.cntSaveHead.Size = new System.Drawing.Size(145, 22);
            this.cntSaveHead.Text = "Save as Head";
            this.cntSaveHead.Click += new System.EventHandler(this.cntSaveHead_Click);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntSaveHead,
            this.cntAddStaff,
            this.cntRemove,
            this.SetApproverToolStripMenuItem,
            this.UserAccountToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(146, 114);
            // 
            // SetApproverToolStripMenuItem
            // 
            this.SetApproverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SetApproverToolStripMenuItem.Image")));
            this.SetApproverToolStripMenuItem.Name = "SetApproverToolStripMenuItem";
            this.SetApproverToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.SetApproverToolStripMenuItem.Text = "Set Approver";
            this.SetApproverToolStripMenuItem.Click += new System.EventHandler(this.SetApproverToolStripMenuItem_Click);
            // 
            // ElementStyle1
            // 
            this.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ElementStyle1.Name = "ElementStyle1";
            this.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // NodeConnector1
            // 
            this.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Name = "ColumnHeader1";
            this.ColumnHeader1.Text = "Postion";
            this.ColumnHeader1.Width.Absolute = 180;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Name = "ColumnHeader3";
            this.ColumnHeader3.Text = "Employee Hierarchy";
            this.ColumnHeader3.Width.Absolute = 300;
            // 
            // PanelEx2
            // 
            this.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx2.Controls.Add(this.treeEmployee);
            this.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEx2.Enabled = false;
            this.PanelEx2.Location = new System.Drawing.Point(0, 64);
            this.PanelEx2.Name = "PanelEx2";
            this.PanelEx2.Size = new System.Drawing.Size(599, 494);
            this.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx2.Style.GradientAngle = 90;
            this.PanelEx2.TabIndex = 3;
            // 
            // treeEmployee
            // 
            this.treeEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeEmployee.AllowDrop = true;
            this.treeEmployee.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeEmployee.BackgroundStyle.Class = "TreeBorderKey";
            this.treeEmployee.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeEmployee.Columns.Add(this.ColumnHeader3);
            this.treeEmployee.Columns.Add(this.ColumnHeader1);
            this.treeEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeEmployee.DragDropEnabled = false;
            this.treeEmployee.DragDropNodeCopyEnabled = false;
            this.treeEmployee.GridColumnLines = false;
            this.treeEmployee.Location = new System.Drawing.Point(0, 0);
            this.treeEmployee.Name = "treeEmployee";
            this.treeEmployee.NodesConnector = this.NodeConnector1;
            this.treeEmployee.NodeStyle = this.ElementStyle1;
            this.treeEmployee.PathSeparator = ";";
            this.treeEmployee.Size = new System.Drawing.Size(599, 494);
            this.treeEmployee.Styles.Add(this.ElementStyle1);
            this.treeEmployee.TabIndex = 14;
            this.treeEmployee.Text = "AdvTree1";
            this.treeEmployee.NodeMouseDown += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeEmployee_NodeMouseDown);
            // 
            // ButtonX3
            // 
            this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonX3.Image = ((System.Drawing.Image)(resources.GetObject("ButtonX3.Image")));
            this.ButtonX3.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.ButtonX3.Location = new System.Drawing.Point(354, 39);
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Size = new System.Drawing.Size(86, 22);
            this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.ButtonX3.TabIndex = 16;
            this.ButtonX3.Text = "User Accnt.";
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // chkExpand
            // 
            this.chkExpand.AutoSize = true;
            this.chkExpand.Location = new System.Drawing.Point(75, 44);
            this.chkExpand.Name = "chkExpand";
            this.chkExpand.Size = new System.Drawing.Size(62, 17);
            this.chkExpand.TabIndex = 13;
            this.chkExpand.Text = "Expand";
            this.chkExpand.UseVisualStyleBackColor = true;
            this.chkExpand.CheckedChanged += new System.EventHandler(this.chkExpand_CheckedChanged);
            // 
            // btnSaveHead
            // 
            this.btnSaveHead.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveHead.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveHead.Enabled = false;
            this.btnSaveHead.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveHead.Image")));
            this.btnSaveHead.Location = new System.Drawing.Point(448, 39);
            this.btnSaveHead.Name = "btnSaveHead";
            this.btnSaveHead.Size = new System.Drawing.Size(86, 22);
            this.btnSaveHead.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSaveHead.TabIndex = 12;
            this.btnSaveHead.Text = "Set as Head";
            this.btnSaveHead.Click += new System.EventHandler(this.btnSaveHead_Click);
            // 
            // btnFind
            // 
            this.btnFind.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFind.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(542, 11);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(49, 22);
            this.btnFind.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtname.Border.Class = "TextBoxBorder";
            this.txtname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtname.Location = new System.Drawing.Point(75, 12);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(461, 21);
            this.txtname.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Employee:";
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx1.Controls.Add(this.ButtonX3);
            this.PanelEx1.Controls.Add(this.chkExpand);
            this.PanelEx1.Controls.Add(this.btnSaveHead);
            this.PanelEx1.Controls.Add(this.btnFind);
            this.PanelEx1.Controls.Add(this.txtname);
            this.PanelEx1.Controls.Add(this.Label1);
            this.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEx1.Location = new System.Drawing.Point(0, 0);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(599, 64);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 2;
            // 
            // EmployeeHierarchyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 558);
            this.Controls.Add(this.PanelEx2);
            this.Controls.Add(this.PanelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeHierarchyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Hierarchy";
            this.Load += new System.EventHandler(this.EmployeeHierarchyForm_Load);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.PanelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeEmployee)).EndInit();
            this.PanelEx1.ResumeLayout(false);
            this.PanelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem UserAccountToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem cntRemove;
        internal System.Windows.Forms.ToolStripMenuItem cntAddStaff;
        internal System.Windows.Forms.ToolStripMenuItem cntSaveHead;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem SetApproverToolStripMenuItem;
        internal DevComponents.DotNetBar.ElementStyle ElementStyle1;
        internal DevComponents.AdvTree.NodeConnector NodeConnector1;
        private DevComponents.AdvTree.ColumnHeader ColumnHeader1;
        private DevComponents.AdvTree.ColumnHeader ColumnHeader3;
        private DevComponents.DotNetBar.PanelEx PanelEx2;
        private DevComponents.AdvTree.AdvTree treeEmployee;
        private DevComponents.DotNetBar.ButtonX ButtonX3;
        internal System.Windows.Forms.CheckBox chkExpand;
        private DevComponents.DotNetBar.ButtonX btnSaveHead;
        private DevComponents.DotNetBar.ButtonX btnFind;
        private DevComponents.DotNetBar.Controls.TextBoxX txtname;
        internal System.Windows.Forms.Label Label1;
        private DevComponents.DotNetBar.PanelEx PanelEx1;
    }
}