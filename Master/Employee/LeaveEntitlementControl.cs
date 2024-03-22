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
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using DevComponents.DotNetBar;

namespace DCLGlobal.Master.Employee
{
    public partial class LeaveEntitlementControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        bool _flag;
        
        public LeaveEntitlementControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
            BindLeaveType(cmbLeaveType);
            GlobalToolsControl.DCLAPS.FillCboYear(cmbYear);
        }

        private void LeaveEntitlementControl_Load(object sender, EventArgs e)
        {
            DisplayEmployeeLeaveBalance();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
        }

        void BindLeaveType(ComboBox _cmb)
        {
            iLeaveType _ileavetype = new HURISRepository.rLeaveType();

            try
            {
                List<LeaveType> _leavetype = _ileavetype.GetLeaveTypes("");
                _cmb.DataSource = _leavetype;
                _cmb.DisplayMember = "Leavetype_desc";
                _cmb.ValueMember = "Leavetype_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayYear(ComboBox _cmb)
        { 
            List<string> _yearList=new List<string>();
            int _yearAdd = DateTime.Now.Year - 2012;
            
            for (int i = 1; i <= _yearAdd + 1; i++)
            {
                _yearList.Add((2011 + i).ToString());
            }
            _yearList.Reverse();

            _cmb.DataSource = _yearList;
        }

        void DisplayEmployeeLeaveBalance()
        {
            iLeave _ileave = new HURISTransactionRepository.rLeave();

            try
            {

                List<EmployeeLeaveMonitoring> _leavebalance = (from d in _ileave.GetEmployeeLeaveBalances(_empid) orderby d.YearEntitled descending select d).ToList();
                dgvLeave.RowCount = 0;

                if (_leavebalance != null)
                {
                    foreach (EmployeeLeaveMonitoring _list in _leavebalance)
                    {
                        int r = dgvLeave.Rows.Add();
                        dgvLeave.Rows[r].Cells[0].Value = _list.ID;
                        dgvLeave.Rows[r].Cells[1].Value = _list.LeaveType.Leavetype_desc;
                        dgvLeave.Rows[r].Cells[2].Value = _list.EntitleLeave;
                        dgvLeave.Rows[r].Cells[3].Value = _list.RemainingLeave;
                        dgvLeave.Rows[r].Cells[4].Value = _list.YearEntitled;

                        if (_list.YearEntitled != DateTime.Now.Year)
                        {
                            dgvLeave.Rows[r].Cells[1].Style.BackColor = Color.LightSkyBlue;
                            dgvLeave.Rows[r].Cells[2].Style.BackColor = Color.LightSkyBlue;
                            dgvLeave.Rows[r].Cells[3].Style.BackColor = Color.LightSkyBlue;
                            dgvLeave.Rows[r].Cells[4].Style.BackColor = Color.LightSkyBlue;

                            dgvLeave.Rows[r].Cells[1].Style.ForeColor = Color.Red;
                            dgvLeave.Rows[r].Cells[2].Style.ForeColor = Color.Red;
                            dgvLeave.Rows[r].Cells[3].Style.ForeColor = Color.Red;
                            dgvLeave.Rows[r].Cells[4].Style.ForeColor = Color.Red;
                        }
                        else
                        {
                            dgvLeave.Rows[r].Cells[1].Style.BackColor = Color.LightGreen;
                            dgvLeave.Rows[r].Cells[2].Style.BackColor = Color.LightGreen;
                            dgvLeave.Rows[r].Cells[3].Style.BackColor = Color.LightGreen;
                            dgvLeave.Rows[r].Cells[4].Style.BackColor = Color.LightGreen;

                            dgvLeave.Rows[r].Cells[1].Style.ForeColor = Color.Black;
                            dgvLeave.Rows[r].Cells[2].Style.ForeColor = Color.Black;
                            dgvLeave.Rows[r].Cells[3].Style.ForeColor = Color.Black;
                            dgvLeave.Rows[r].Cells[4].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLeave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvLeave.Rows[e.RowIndex].Cells[0].Value.ToString());

            iLeave _ileave = new HURISTransactionRepository.rLeave();

            try
            {
                EmployeeLeaveMonitoring _leave = _ileave.GetEmployeeLeaveBalance(_id);
                if (_leave != null)
                {
                    cmbLeaveType.SelectedValue = _leave.LeaveTypeID;
                    numLeaveDay.Value = Convert.ToDecimal(_leave.EntitleLeave);
                    numRemainingLeave.Value = Convert.ToDecimal(_leave.RemainingLeave);
                    cmbYear.Text = _leave.YearEntitled.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            cmbLeaveType.SelectedValue = -1;
            numLeaveDay.Value = 0;
            numRemainingLeave.Value = 0;
            cmbYear.Text = "";
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvLeave.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            cmbLeaveType.Enabled = _cond;
            numLeaveDay.Enabled = _cond;
            numRemainingLeave.Enabled = _cond;
            cmbYear.Enabled = _cond;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.LEAVE_ENTITLEMENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.LEAVE_ENTITLEMENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (cmbLeaveType.Text.Length == 0)
            {
                MessageBox.Show("Leave type is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbLeaveType.Focus();
                return;
            }

            if (numLeaveDay.Value == 0)
            {
                MessageBox.Show("Number of leave must be greater than zero.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numLeaveDay.Focus();
                return;
            }

            if (cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Year entitlement is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbYear.Focus();
                return;
            }
                        
            ManageLeaveEntitlement();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeLeaveBalance();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }                        
        }

        void ManageLeaveEntitlement()
        {
            iLeave _ileave = new HURISTransactionRepository.rLeave();
            EmployeeLeaveMonitoring _leave = new EmployeeLeaveMonitoring();
            
            try
            {
                _leave.ID = _id;
                _leave.EmpID = _empid;
                _leave.LeaveTypeID = int.Parse(cmbLeaveType.SelectedValue.ToString());
                _leave.EntitleLeave = numLeaveDay.Value;
                _leave.RemainingLeave = numRemainingLeave.Value;
                _leave.YearEntitled = int.Parse(cmbYear.Text);

                _ileave.ManageLeaveMonitoring(_leave, _mode);
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
