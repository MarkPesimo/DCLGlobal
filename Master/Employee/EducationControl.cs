using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using DevComponents.DotNetBar;

namespace DCLGlobal.Master.Employee
{
    public partial class EducationControl : UserControl
    {
        int _empid;
        int _id;
        int _mode;
        bool _flag;
        int _schoolID;
        int _levelID;
        int _degreeID;

        public EducationControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EducationControl_Load(object sender, EventArgs e)
        {
            EnableForm(false);
            EnableButton(true);
            DisplayEducation();
            //BindSchoolLevel(cmbLevel);
        }

        //void BindSchoolLevel(ComboBox _cmb)
        //{
        //    iSchoolLevel _ischoollevel = new HURISRepository.rSchoolLevel();


        //    try
        //    {
        //        List<SchoolLevel> _schoollevel = (from d in _ischoollevel.GetSchoolLevels("") orderby d.SchoolLevelDescn select d).ToList();
        //        _cmb.DataSource = _schoollevel;
        //        _cmb.DisplayMember = "SchoolLevelDescn";
        //        _cmb.ValueMember = "LevelID";
        //        _cmb.SelectedIndex = -1;
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        void InitializeField()
        {
            txtSchool.Text = "";
            txtDegree.Text = "";
            txtAwards.Text = "";
            txtRemarks.Text = "";
            dtFrom.Value = DateTime.Now;
            dtFrom.LockUpdateChecked = false;
            dtTo.Value = DateTime.Now;
            dtTo.LockUpdateChecked = false;
            cmbLevel.SelectedIndex = -1;
            _id = 0;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvEducation.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtSchool.ReadOnly = !_cond;
            txtDegree.ReadOnly = !_cond;
            txtAwards.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;
            cmbLevel.Enabled = _cond;
            dtFrom.Enabled = _cond;
            dtTo.Enabled = _cond;
        }

        void DisplayEducation()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Education> _education = _iemployee.GetEmployeeEducations(_empid);
                dgvEducation.RowCount = 0;
                if (_education != null)
                {
                    foreach (Employee_Education _list in _education)
                    {
                        int r = dgvEducation.Rows.Add();
                        dgvEducation.Rows[r].Cells[0].Value = _list.School_Id;
                        if (_list.SchoolLevelID != null)
                        { dgvEducation.Rows[r].Cells[1].Value = _list.SchoolLevel.SchoolLevelDescn; }
                        else { dgvEducation.Rows[r].Cells[1].Value = _list.School_Level; }
                        if (_list.SchoolLibID != null)
                        { dgvEducation.Rows[r].Cells[2].Value = _list.School.SchoolName; }
                        else { dgvEducation.Rows[r].Cells[2].Value = _list.School_Name; }
                        if (_list.SchoolLibID != null)
                        { dgvEducation.Rows[r].Cells[3].Value = _list.Degree.DegreeName; }
                        else
                        {
                            if (_list.School_Remarks != null && _list.School_Remarks != "")
                            { dgvEducation.Rows[r].Cells[3].Value = _list.School_Remarks; }
                            else { dgvEducation.Rows[r].Cells[3].Value = _list.School_Grade; }
                        }
                            
                        
                        dgvEducation.Rows[r].Cells[4].Value = _list.School_From;
                        dgvEducation.Rows[r].Cells[5].Value = _list.School_To;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEducation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvEducation.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Education _education = _iemployee.GetEmployeeEducation(_id);
                if (_education != null)
                {
                    if (_education.SchoolLibID != null)
                    { txtSchool.Text = _education.School.SchoolName; }
                    else { txtSchool.Text = _education.School_Name; }
                    if (_education.DegreeID != null)
                    { txtDegree.Text = _education.Degree.DegreeName; }
                    else { txtDegree.Text = _education.School_Grade; }                   
                    txtAwards.Text = _education.Awards;
                    txtRemarks.Text = _education.School_Remarks;
                    cmbLevel.SelectedValue = _education.SchoolLevelID;
                    if (_education.School_From != null)
                    {
                        dtFrom.Value = _education.School_From.Value.Date;
                        dtFrom.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtFrom.LockUpdateChecked = false;
                    }

                    if (_education.School_To != null)
                    {
                        dtTo.Value = _education.School_To.Value.Date;
                        dtTo.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtTo.LockUpdateChecked = false;
                    }
                    _schoolID = Convert.ToInt16(_education.SchoolLibID);
                    _levelID = Convert.ToInt16(_education.SchoolLevelID);
                    _degreeID = Convert.ToInt16(_education.DegreeID);
                    chkGraduate.Checked = Convert.ToBoolean(_education.Graduated);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_EDUCATION, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_EDUCATION, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtSchool.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtSchool);
                txtSchool.Focus();
                return;
            }

            if (cmbLevel.SelectedIndex == -1)
            {
                MessageBox.Show("School level is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLevel.Focus();
                return;
            }

            ManageEmployeeEducation();
            InitializeField();
            DisplayEducation();
            EnableForm(false);
            EnableButton(true);

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }  
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            DisplayEducation();
            EnableButton(true);
            EnableForm(false);
        }

        void ManageEmployeeEducation()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Education _education = new Employee_Education();

            try
            {
                _education.School_Id = _id;
                _education.Emp_id = _empid;
                _education.School_Name = txtSchool.Text;
                _education.School_Level = cmbLevel.SelectedItem.ToString();
                _education.School_Grade = txtDegree.Text;
                _education.Awards = txtAwards.Text;
                _education.School_Remarks = txtRemarks.Text;
                if (dtFrom.LockUpdateChecked == true)
                {
                    _education.School_From = dtFrom.Value;
                }
                if (dtTo.LockUpdateChecked == true)
                {
                    _education.School_To = dtTo.Value;
                }

                _iemployee.ManageEmployeeEducation(_education, _mode);
                _flag = true;
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
