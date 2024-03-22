using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main.Employee
{
    public partial class EmployeeShift : Form
    {
        int _id = 0;
        int _mode = 0;
        int _empid = 0;
        bool _shiftingstatus = false;
        string msg = "";
        
        public EmployeeShift()
        {
            InitializeComponent();
        }

        private void EmployeeShift_Load(object sender, EventArgs e)
        {
            BindShiftRule(cmbShiftRule);
            BindShifts(cmbFirstShift);
            BindShifts(cmbSecondShift);
            DisplayEmployee();
            DisplayEmployeeShifts(_empid);
        }

        void BindShiftRule(ComboBox _cmb)
        {
            iShiftRule _ishiftrule = new HURISRepository.rShiftRule();

            try
            {
                List<ShiftRule> _shiftrule = _ishiftrule.GetShiftRules("");
                _cmb.DataSource = _shiftrule;
                _cmb.DisplayMember = "Description";
                _cmb.ValueMember = "ShiftRuleID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindShifts(ComboBox _cmb)
        {
            iShift _ishift = new HURISRepository.rShift();

            try
            {
                List<Shift> _shift = _ishift.GetShifts("");
                _cmb.DataSource = _shift;
                _cmb.DisplayMember = "Description";
                _cmb.ValueMember="Shift_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            cmbShiftRule.SelectedIndex = -1;
            cmbFirstShift.SelectedIndex = -1;
            cmbSecondShift.SelectedIndex = -1;
            txtRemarks.Clear();
            dtEffectivedate.Value = DateTime.Now;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            print_btn.Enabled = _cond;
            Search_txt.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtRemarks.ReadOnly = !_cond;
            cmbShiftRule.Enabled = _cond;
            cmbFirstShift.Enabled = _cond;
            cmbSecondShift.Enabled = _cond;
            dtEffectivedate.Enabled = _cond;
        }

        void DisplayEmployee()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                lsvEmployee.Items.Clear();
                List<UserDefineClass.HRIS.EmployeeSearchList> _employee = (from d in _iemployee.SearchEmployees("", "") orderby d.LastName, d.FirstName, d.MiddleName select d).ToList();
                if (_employee != null)
                {
                    foreach (UserDefineClass.HRIS.EmployeeSearchList _list in _employee)
                    {
                        ListViewItem _item = new ListViewItem(_list.EmpID.ToString());
                        _item.SubItems.Add(_list.LastName + ", " + _list.FirstName + " " + _list.MiddleName.Substring(0, 1) + ".");

                        lsvEmployee.Items.Add(_item);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayEmployeeShifts(int EMPID)
        {
            iEmployee _iemployeeshift = new HURISRepository.rEmployee();

            try
            {
                lstShiftList.Items.Clear();
                List<CAL.Model.EmployeeShift> _employeeshift = (from d in _iemployeeshift.GetEmployeeShifts(EMPID) orderby d.StartDate ascending select d).ToList();
                if (_employeeshift != null)
                {
                    foreach (CAL.Model.EmployeeShift _list in _employeeshift)
                    {
                        ListViewItem _item = new ListViewItem(_list.EmpShiftID.ToString());
                        _item.SubItems.Add(_list.ShiftRule.Description);
                        _item.SubItems.Add(_list.StartDate.Value.ToShortDateString());
                        _item.SubItems.Add(_list.Shift.Description);
                        _item.SubItems.Add(_list.Shift1.Description);
                        _item.SubItems.Add(_list.Remarks);
                        if (_list.ShiftStatus == true)
                        {
                            _item.SubItems.Add("Active");
                        }
                        else
                        {
                            _item.SubItems.Add("Inactive");
                        }

                        lstShiftList.Items.Add(_item);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_SHIFTING, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                if (_empid == 0)
                {
                    MessageBox.Show("Please select employee to add a shifting schedule.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _mode = 1;
                InitializeField();
                EnableForm(true);
                EnableButton(false);

                cmbShiftRule.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvEmployee_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                _empid = int.Parse(e.Item.Text);
                lblEmployeeName.Text = e.Item.SubItems[1].Text;
                DisplayEmployeeShifts(_empid);
                InitializeField();
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_SHIFTING, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Please select a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 2;
                EnableForm(true);
                EnableButton(false);

                cmbShiftRule.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstShiftList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstShiftList.SelectedItems.Count == 0) { return; }

            iEmployee _iemployeeshift = new HURISRepository.rEmployee();
            try
            {
                _id = int.Parse(lstShiftList.SelectedItems[0].Text);
                CAL.Model.EmployeeShift _employeeshift = _iemployeeshift.GetEmployeeShift(_id);
                if (_employeeshift != null)
                {
                    cmbShiftRule.SelectedValue = _employeeshift.ShiftRuleID;
                    dtEffectivedate.Value = _employeeshift.StartDate.Value;
                    cmbFirstShift.SelectedValue = _employeeshift.FirtsShiftID;
                    cmbSecondShift.SelectedValue = _employeeshift.SecondShiftID;
                    txtRemarks.Text = _employeeshift.Remarks;
                    _shiftingstatus = _employeeshift.ShiftStatus.Value;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            try
            {
                EnableForm(false);
                EnableButton(true);
                InitializeField();
                DisplayEmployee();
                DisplayEmployeeShifts(_empid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void EmployeeShift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (_id == 0)
                {
                    MessageBox.Show("Please select employee shifting schedule to activate/deactivate", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult _result = MessageBox.Show("Are you sure you want to activate/deactivate this shifting schedule?", "Confirmation", MessageBoxButtons.YesNo);
                if (_result == DialogResult.Yes)
                {
                    if (_shiftingstatus == true)
                    {
                        _shiftingstatus = false;
                    }
                    else
                    {
                        _shiftingstatus = true;
                    }
                }
                else
                {
                    return;
                }

                _mode = 2;
                ManageEmployeeShift();
            }
        }

        void ManageEmployeeShift()
        {
            iEmployee _iemployeeshift = new HURISRepository.rEmployee();
            CAL.Model.EmployeeShift _employeeshift = new CAL.Model.EmployeeShift();

            try
            {
                _employeeshift.EmpId = _empid;
                _employeeshift.ShiftRuleID = int.Parse(cmbShiftRule.SelectedValue.ToString());
                _employeeshift.StartDate = dtEffectivedate.Value;
                _employeeshift.FirtsShiftID = int.Parse(cmbFirstShift.SelectedValue.ToString());
                _employeeshift.SecondShiftID = int.Parse(cmbSecondShift.SelectedValue.ToString());
                _employeeshift.Remarks = txtRemarks.Text;
                _employeeshift.ShiftStatus = _shiftingstatus;
                _employeeshift.EmpShiftID = _id;

                _iemployeeshift.ManageEmployeeShift(_employeeshift, _mode);
                Cancel();

                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayEmployeeShifts(_empid);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (cmbShiftRule.SelectedIndex == -1)
            {
                msg = "Please select shift rule";
            }
            else if (cmbFirstShift.SelectedIndex == -1)
            {
                msg = "Please select first shift.";
            }
            else if (cmbSecondShift.SelectedIndex == -1)
            {
                msg = "Please select second shift";
            }
            else
            {
                msg = "";
            }

            if (cmbSecondShift.SelectedValue != null)
            {
                if (int.Parse(cmbShiftRule.SelectedValue.ToString()) == 4)
                {
                    if (cmbFirstShift.Text != cmbSecondShift.Text)
                    {
                        msg = "First shift must be equal to the next shift";
                    }
                }
            }

            if (msg != "")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ManageEmployeeShift();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_SHIFTING, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }
    }
}
