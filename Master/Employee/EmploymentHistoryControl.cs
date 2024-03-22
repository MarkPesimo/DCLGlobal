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
    public partial class EmploymentHistoryControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        bool _flag;

        public EmploymentHistoryControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmploymentHistoryControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmploymentHistory();
        }

        void InitializeField()
        {
            txtCompany.Text = "";
            txtAddress.Text = "";
            txtPosition.Text = "";
            txtReason.Text = "";
            txtImmediateHead.Text = "";
            txtSalary.Text = "0";
            cboRank.SelectedIndex = -1;
            cbostatus.SelectedIndex = -1;
            dtFrom.Value = DateTime.Now;
            dtFrom.LockUpdateChecked = false;
            dtTo.Value = DateTime.Now;
            dtTo.LockUpdateChecked = false;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvEmpHistory.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtCompany.ReadOnly = !_cond;
            txtAddress.ReadOnly = !_cond;
            txtPosition.ReadOnly = !_cond;
            txtReason.ReadOnly = !_cond;
            txtImmediateHead.ReadOnly = !_cond;
            txtSalary.ReadOnly = !_cond;
            cboRank.Enabled = _cond;
            cbostatus.Enabled = _cond;
            dtFrom.Enabled = _cond;
            dtTo.Enabled = _cond;
        }

        void DisplayEmploymentHistory()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Employment> _employmenthistory = _iemployee.GetEmployeeEmploymentHistory(_empid);
                dgvEmpHistory.RowCount = 0;
                if (_employmenthistory != null)
                {
                    foreach (Employee_Employment _list in _employmenthistory)
                    {
                        int r = dgvEmpHistory.Rows.Add();
                        dgvEmpHistory.Rows[r].Cells[0].Value = _list.Employ_ID;
                        dgvEmpHistory.Rows[r].Cells[1].Value = _list.Company_name;
                        dgvEmpHistory.Rows[r].Cells[2].Value = _list.Company_position;
                        dgvEmpHistory.Rows[r].Cells[3].Value = _list.Company_from;
                        dgvEmpHistory.Rows[r].Cells[4].Value = _list.Company_to;
                        dgvEmpHistory.Rows[r].Cells[5].Value = _list.employment_Status;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmpHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvEmpHistory.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Employment _employmenthistory = _iemployee.GetEmployeeEmployment(_id);
                if (_employmenthistory != null)
                {
                    txtCompany.Text = _employmenthistory.Company_name;
                    txtAddress.Text = _employmenthistory.Company_Address;
                    txtPosition.Text = _employmenthistory.Company_position;
                    txtReason.Text = _employmenthistory.Reason_for_leaving;
                    txtImmediateHead.Text = _employmenthistory.Emidiate_head;
                    txtSalary.Text = _employmenthistory.Company_Salary.ToString();
                    cboRank.Text = _employmenthistory.Company_Rank;
                    cbostatus.Text = _employmenthistory.employment_Status;
                    if (_employmenthistory.Company_from != null)
                    {
                        dtFrom.Value = _employmenthistory.Company_from.Value.Date;
                        dtFrom.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtFrom.LockUpdateChecked = false;
                    }
                    if (_employmenthistory.Company_to != null)
                    {
                        dtTo.Value = _employmenthistory.Company_to.Value.Date;
                        dtTo.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtTo.LockUpdateChecked = false;
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
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYMENT_HISTORY, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYMENT_HISTORY, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmploymentHistory();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtCompany);
                txtCompany.Focus();
                return;
            }

            if (txtPosition.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPosition);
                txtPosition.Focus();
                return;
            }

            if (txtAddress.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtAddress);
                txtAddress.Focus();
                return;
            }

            ManageEmploymentHistory();
            InitializeField();
            DisplayEmploymentHistory();
            EnableForm(false);
            EnableButton(true);

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmploymentHistory()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Employment _employmenthistory = new Employee_Employment();

            try
            {
                _employmenthistory.Employ_ID = _id;
                _employmenthistory.Emp_ID = _empid;
                _employmenthistory.Company_name = txtCompany.Text;
                _employmenthistory.Company_Address = txtAddress.Text;
                _employmenthistory.Company_position = txtPosition.Text;
                _employmenthistory.Reason_for_leaving = txtReason.Text;
                if (txtSalary.Text != null || txtSalary.Text != "")
                {
                    _employmenthistory.Company_Salary = decimal.Parse(txtSalary.Text.ToString());
                }                
                _employmenthistory.Company_Rank = cboRank.SelectedItem.ToString();
                _employmenthistory.employment_Status = cbostatus.SelectedItem.ToString();
                if (dtFrom.LockUpdateChecked == true)
                {
                    _employmenthistory.Company_from = dtFrom.Value;
                }
                if (dtTo.LockUpdateChecked == true)
                {
                    _employmenthistory.Company_to = dtTo.Value;
                }

                _iemployee.ManageEmploymentHistory(_employmenthistory, _mode);
                _flag = true;
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
