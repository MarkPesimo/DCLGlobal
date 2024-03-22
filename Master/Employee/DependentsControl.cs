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
    public partial class DependentsControl : UserControl
    {
        int _empid;
        int _id;
        int _mode;
        bool _flag;

        public DependentsControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void DependentsControl_Load(object sender, EventArgs e)
        {
            EnableForm(false);
            EnableButton(true);
            DisplayDependents();
        }

        void InitializeField()
        {
            txtDependent.Text = "";
            dtBDate.LockUpdateChecked = false;
            dtBDate.Value = DateTime.Now;
            cmbRelation.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtOccupation.Text = "";
            txtYearlevel.Text = "";
            txtRemarks.Text = "";
        }

        void EnableForm(bool _cond)
        {
            txtDependent.ReadOnly = !_cond;
            txtOccupation.ReadOnly = !_cond;
            txtYearlevel.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;
            cmbGender.Enabled = _cond;
            cmbRelation.Enabled = _cond;
            dtBDate.Enabled = _cond;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvDependent.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }

        void DisplayDependents()
        {
            iEmployee _iemeployee = new HURISRepository.rEmployee();

            try
            {
                dgvDependent.RowCount = 0;

                List<Employee_Child> _dependent = _iemeployee.GetEmployeeChildren(_empid);
                if (_dependent != null)
                {
                    foreach (Employee_Child _list in _dependent)
                    {
                        int r = dgvDependent.Rows.Add();
                        dgvDependent.Rows[r].Cells[0].Value = _list.Child_ID;
                        dgvDependent.Rows[r].Cells[1].Value = _list.Child_name;
                        dgvDependent.Rows[r].Cells[2].Value = _list.Child_Bday;
                        dgvDependent.Rows[r].Cells[3].Value = _list.Child_Gender;
                        dgvDependent.Rows[r].Cells[4].Value = GlobalToolsControl.HURIS.ComputeAge(_list.Child_Bday);
                        dgvDependent.Rows[r].Cells[5].Value = _list.Child_Relation;
                        dgvDependent.Rows[r].Cells[6].Value = _list.Occupation;
                        dgvDependent.Rows[r].Cells[7].Value = _list.YearLevel;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDependent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvDependent.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Child _dependent = _iemployee.GetEmployeeChild(_id);
                if (_dependent != null)
                {
                    txtDependent.Text = _dependent.Child_name;
                    if (_dependent.Child_Bday != null)
                    {
                        dtBDate.LockUpdateChecked = true;
                        dtBDate.Value = _dependent.Child_Bday.Value.Date;
                    }
                    else
                    {
                        dtBDate.LockUpdateChecked = false;
                    }
                    cmbGender.Text = _dependent.Child_Gender.TrimEnd();
                    cmbRelation.Text = _dependent.Child_Relation;
                    txtOccupation.Text = _dependent.Occupation;
                    txtRemarks.Text = _dependent.Remarks;
                    txtYearlevel.Text = _dependent.YearLevel;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DEPENDENTS, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            EnableButton(false);
            EnableForm(true);
            InitializeField();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DEPENDENTS, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);            
        }

        void ManageEmployeeDependent()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Child _dependent = new Employee_Child();

            try
            {
                _dependent.Child_ID = _id;
                _dependent.Emp_id = _empid;
                _dependent.Child_name = txtDependent.Text;
                if (dtBDate.LockUpdateChecked == true)
                {
                    _dependent.Child_Bday = dtBDate.Value;
                }
                _dependent.Child_Gender = cmbGender.SelectedItem.ToString();
                _dependent.Child_Relation = cmbRelation.SelectedItem.ToString();
                _dependent.Occupation = txtOccupation.Text;
                _dependent.Child_Age = int.Parse(GlobalToolsControl.HURIS.ComputeAge(dtBDate.Value).ToString());
                _dependent.Remarks = txtRemarks.Text;
                _dependent.YearLevel = txtYearlevel.Text;

                _iemployee.ManageEmployeeDependent(_dependent, _mode);
                _flag = true;
            }

            catch(Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDependent.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDependent);
                txtDependent.Focus();
                return;
            }

            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Gender is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbGender.Focus();
                return;
            }

            if (cmbRelation.SelectedIndex == -1)
            {
                MessageBox.Show("Relation is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbRelation.Focus();
                return;
            }

            ManageEmployeeDependent();
            InitializeField();
            DisplayDependents();
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
            DisplayDependents();
            EnableButton(true);
            EnableForm(false);
        }
    }
}
