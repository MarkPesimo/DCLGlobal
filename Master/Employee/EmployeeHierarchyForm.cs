using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeHierarchyForm : Form
    {
        int HeadEmpID;
        int HeadID;
        int _mode;
        int SelectedEmpId = 0;
        int SelectedHeadId = 0;
        string StaffHead;
        int _empid;
        string _position = "";
        string _name = "";
        string _gender = "";
        bool _ismale;

        public EmployeeHierarchyForm()
        {
            InitializeComponent();
        }

        private void EmployeeHierarchyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            StaffHead = "head";
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                if (StaffHead == "head")
                {
                    txtname.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    HeadEmpID = _employee.Emp_ID;
                    DisplayHead(HeadEmpID);
                }
                else
                {
                    iEmployee _iemployee = new HURISRepository.rEmployee();
                    _iemployee.ManageSubordinate(HeadID, _empid, 1);
                }

                DisplayStaffAndHead();
            }     
        }

        void DisplayHead(int _empid)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                CompanyHead _companyhead = _iemployee.GetCompanyHead(_empid);
                if (_companyhead != null)
                {
                    HeadID = _companyhead.Head_ID;
                    btnSaveHead.Enabled = false;
                    PanelEx2.Enabled = true;
                }
                else
                {
                    btnSaveHead.Enabled = true;
                    PanelEx2.Enabled = false;
                }

                _mode = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayStaffAndHead()
        {
            _position = "";
            _name = "";
            _gender = "";

            DisplayHeadNode(HeadEmpID, _name, _position, _gender);

            treeEmployee.Nodes.Clear();
            if (_name == "") { return; }
            if (_gender == "MALE") {_ismale=true;} else{_ismale=false;}

            Node _headnode = new Node();
            Cell _headcell = new Cell();

            _headcell.Text = _position;
            _headcell.Tag = HeadID;

            _headnode.Tag = HeadEmpID;
            _headnode.Text = _name + " " + HeadEmpID;
            _headnode.Image = TreeViewImage(HeadEmpID, _ismale);
            _headnode.Cells.Add(_headcell);

            _headnode.Nodes.AddRange(GetSubNode(HeadID));
            _headnode.CollapseAll();

            treeEmployee.Nodes.Add(_headnode);

            if (chkExpand.Checked == true)
            {
                treeEmployee.ExpandAll();
            }
            else
            {
                treeEmployee.CollapseAll();
            }
        }

        void DisplayHeadNode(int _EMPID, string _NAME, string _POSITION, string _GENDER)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                CompanyHead _companyhead = _iemployee.GetCompanyHead(_EMPID);
                if (_companyhead != null)
                {
                    _name = _companyhead.Employee.Lastname + ", " + _companyhead.Employee.Firstname + " " + _companyhead.Employee.Middlename.Substring(0, 1) + ".";
                    _position = _companyhead.Employee.Salary.Salary_Desc;
                    _gender = _companyhead.Employee.Gender.ToUpper();
                }
                else
                {
                    _name = "";
                    _position = "";
                    _gender = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        System.Drawing.Bitmap TreeViewImage(int _EMPID, bool _ismale)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Bitmap bmp = null;
            try
            {
                //===========================================================================
                //updated by     : kuto
                //date updated   : 01132023 0542pm
                //description    : get image from the file folder

                string _path = DCLSystemConfiguration.HURIS.Imagepath;
                if (System.IO.File.Exists(_path + _EMPID.ToString() + ".JPEG"))
                {
                    Image _image = Image.FromFile(_path + _EMPID.ToString() + ".JPEG");
                    bmp =  ResizeImage(_image, 32, 32);
                }
                else
                {
                    if (_ismale == true)
                    {
                        bmp = ResizeImage(DCLGlobal.Properties.Resources.Male, 32, 32);
                    }
                    else
                    {
                        bmp = ResizeImage(DCLGlobal.Properties.Resources.Female, 32, 32);
                    }
                }

                //updated by     : kuto
                //description    : get image from the file folder
                //===========================================================================

                //===========================================================================
                //commented by   : kuto
                //date commented : 01132023 0542pm
                //description    : get image from the file folder

                //CAL.Model.Employee _employee = _iemployee.GetEmployee(_EMPID);
                //if (_employee != null)
                //{
                //    if (_employee.ImageFile == null)
                //    {
                //        if (_ismale == true)
                //        {
                //            bmp = ResizeImage(DCLGlobal.Properties.Resources.Male,32,32);
                //        }
                //        else
                //        {
                //            bmp = ResizeImage(DCLGlobal.Properties.Resources.Female,32,32);
                //        }
                //    }
                //    else
                //    {
                //        Image _image = GlobalToolsControl.Global.GetImageData(_employee.ImageFile);
                //        bmp = ResizeImage(_image, 32, 32);
                //    }
                //}
                //else
                //{
                //    if (_ismale == true)
                //    {
                //        bmp = ResizeImage(DCLGlobal.Properties.Resources.Male,32,32);
                //    }
                //    else
                //    {
                //        bmp = ResizeImage(DCLGlobal.Properties.Resources.Female,32,32);
                //    }
                //}


                //date commented : 01132023 0542pm
                //commented by   : kuto
                //===========================================================================
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bmp;
        }

        System.Drawing.Bitmap ResizeImage(Image _bmSource, Int32 _targetwidth, Int32 _targetheight)
        {
            System.Drawing.Bitmap _bmDest = new System.Drawing.Bitmap(_targetwidth, _targetheight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            float _sourcewidth = _bmSource.Width;
            float _sourceheight = _bmSource.Height;
            float _sourceAspectRatio = _sourcewidth / _sourceheight;
            float _destAspectRatio = _bmDest.Width / _bmDest.Height;

            float newX = 0;
            float newY = 0;
            float newWidth = _bmDest.Width;
            float newHeight = _bmDest.Height;

            if (_destAspectRatio == _sourceAspectRatio)
            { }
            else if (_destAspectRatio > _sourceAspectRatio) // Source is taller
            {
                newWidth = Convert.ToInt32(_sourceAspectRatio * newHeight);
                newX = Convert.ToInt32((_bmDest.Width - newWidth) / 2);
            }
            else // Source is Wider
            {
                newHeight = Convert.ToInt32((1 / _sourceAspectRatio) * newWidth);
                newY = Convert.ToInt32((_bmDest.Height - newHeight) / 2);
            }

            System.Drawing.Graphics grDest = System.Drawing.Graphics.FromImage(_bmDest);
            grDest.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            grDest.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            grDest.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            grDest.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            grDest.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            grDest.DrawImage(_bmSource, newX, newY, newWidth, newHeight);

            return _bmDest;
        }

        Node[] GetSubNode(int _HeadEmpID)
        {
            List<Node> _rootnode = new List<Node>();
            CompanyHead _companyhead = new CompanyHead();
            Node _childnode;
            Cell _cell;
            int _ishead = 0;

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<UserDefineClass.HRIS.Subordinates> _subordinate = _iemployee.GetSubordinates(_HeadEmpID);
                if (_subordinate != null)
                {
                    int _childheadID = 0;

                    foreach (UserDefineClass.HRIS.Subordinates _list in _subordinate)
                    {
                        _companyhead = _iemployee.GetCompanyHead(_list.EmpID);
                        //if (_list.IsHead == null) { _ishead = 0; } else { _ishead = _list.IsHead; }
                        _ishead = _list.IsHead;
                        if (_list.Gender == "MALE") { _ismale = true; } else { _ismale = false; }

                        _cell = new Cell();
                        //_cell.Tag = _list.IsHead;
                        if (_companyhead != null) { _cell.Tag = _companyhead.Head_ID; } else { _cell.Tag = 0; }
                        _cell.Text = _list.Position;
                        _childnode = new Node();

                        _childnode.Tag = _list.EmpID;
                        _childnode.Text = _list.EmployeeName + " " + _list.EmpID;
                        _childnode.Image = TreeViewImage(_list.EmpID, _ismale);
                        _childnode.Cells.Add(_cell);

                        
                        if (_companyhead != null) { _childheadID = _companyhead.Head_ID; } else { _childheadID = 0; }

                        if (_childheadID > 0)
                        {
                            _childnode.Nodes.AddRange(GetSubNode(_childheadID));
                        }
                        _rootnode.Add(_childnode);
                    }                             
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _rootnode.ToArray();
        }

        private void btnSaveHead_Click(object sender, EventArgs e)
        {
             DialogResult _result = MessageBox.Show("Save employee head?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (_result == DialogResult.Yes)
             {
                 iEmployee _iemployee = new HURISRepository.rEmployee();

                 try
                 {
                     CompanyHead _companyhead = new CompanyHead();
                     _companyhead.Emp_Id = HeadEmpID;
                     _companyhead.Head_ID = HeadID;
                     _companyhead.LevelID = 0;
                     _mode = 1;

                     HeadID = _iemployee.ManageEmployeeHead(_companyhead, _mode);

                     if (HeadID != 0)
                     {
                         MessageBox.Show("Employee head was successfully saved. You can now add a staff.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         PanelEx2.Enabled = true;
                         DisplayStaffAndHead();
                     }
                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
        }

        private void treeEmployee_NodeMouseDown(object sender, TreeNodeMouseEventArgs e)
        {
            if (treeEmployee.SelectedNodes.Count > 0)
            {
                SelectedEmpId = int.Parse(treeEmployee.SelectedNode.Tag.ToString());
                SelectedHeadId = int.Parse(treeEmployee.SelectedNode.Cells[1].Tag.ToString());

                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    treeEmployee.SelectedNode.ContextMenu = ContextMenuStrip1;
                    if (SelectedHeadId > 0)
                    {
                        cntAddStaff.Enabled = true;
                        cntSaveHead.Enabled = false;
                        cntRemove.Enabled = true;
                    }
                    else
                    {
                        cntAddStaff.Enabled = false;
                        cntSaveHead.Enabled = true;
                        cntRemove.Enabled = true;
                    }
                }
                else
                {
                    treeEmployee.SelectedNode.ContextMenu = null;
                    SelectedEmpId = 0;
                }
            }
        }

        private void cntSaveHead_Click(object sender, EventArgs e)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            CompanyHead _companyhead=new CompanyHead();

            DialogResult _result = MessageBox.Show("Save this as employee head under " + txtname.Text + " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                _companyhead.Head_ID = SelectedHeadId;
                _companyhead.Emp_Id = SelectedEmpId;
                _companyhead.LevelID = 0;
                _mode = 1;

                SelectedHeadId = _iemployee.ManageEmployeeHead(_companyhead, _mode);

                if (SelectedHeadId != 0)
                {
                    MessageBox.Show("Employee head was successfully saved. You can now add a staff.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStaffAndHead();
                }
            }
        }

        private void cntAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int _headid;

                StaffHead = "staff";
                _headid = SelectedHeadId;
                Searchform _Searchform = new Searchform();
                _Searchform._searchby = searchby.CMS.EMPLOYEES;
                _Searchform.ShowDialog();

                CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
                if (_employee != null)
                {
                    if (StaffHead == "head")
                    {
                        txtname.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                        HeadEmpID = _employee.Emp_ID;
                        DisplayHead(HeadEmpID);
                    }
                    else
                    {
                        iEmployee _iemployee = new HURISRepository.rEmployee();
                        _iemployee.ManageSubordinate(_headid, _employee.Emp_ID, 1);
                    }

                    DisplayStaffAndHead();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cntRemove_Click(object sender, EventArgs e)
        {
            iEmployee _iemeployee = new HURISRepository.rEmployee();
            
            DialogResult _result = MessageBox.Show("Remove this employee?", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                try
                {
                    _iemeployee.ManageSubordinate(SelectedHeadId, SelectedEmpId, 3);
                    DisplayStaffAndHead();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetApproverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetApproverForm _setapprover = new SetApproverForm(SelectedEmpId);
            _setapprover.ShowDialog();
        }

        private void UserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortalUserAccountForm _portaluser = new PortalUserAccountForm(SelectedEmpId);
            _portaluser.ShowDialog();
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            PortalUserAccountForm _portaluser = new PortalUserAccountForm(HeadEmpID);
            _portaluser.ShowDialog();
        }

        private void chkExpand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpand.Checked)
            { treeEmployee.ExpandAll(); }
            else
            { treeEmployee.CollapseAll(); }
        }
    }
}
