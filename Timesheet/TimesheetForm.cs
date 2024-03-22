using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Timesheet
{
    public partial class TimesheetForm : Form
    {
        int _timesheetID;
        int _mode;
        int _selected_empid;
        string _compcode;
        bool _status;
        int _empid;
        public TimesheetForm(int _TimesheetId)
        {
            InitializeComponent();
            GlobalToolsControl.Global.FillCboYear(cboYear);
            _timesheetID = _TimesheetId;
        }

        private void TimesheetForm_Load(object sender, EventArgs e)
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();

            DisplayRecord(_itimesheet.GetTimesheet(_timesheetID));
        }

        void DisplayRecord(TimeSheet_HD _hd)
        {
            iUser _iuser = new GlobalFilesRepository.rUser();

            try
            {
                if (_hd != null)
                {
                    _timesheetID = _hd.TimeSheetID;
                    txtcompany.Text = _hd.CompanyProfile.CompanyName;
                    txtcompany.Tag = _hd.CompID;
                    _compcode = _hd.CompanyProfile.CompanyCode;

                    txttitle.Text = _hd.Title;
                    dtpcutofffrom.Value = _hd.RangeFrom.Value;
                    dtpcutoffto.Value = _hd.RangeTo.Value;

                    dtpovertimefrom.Value = _hd.OTFrom.Value;
                    dtpovertimeto.Value = _hd.OTTo.Value;
                    _status = bool.Parse(_hd.Status.ToString());
                    cboTimesheetType.SelectedIndex = int.Parse(_hd.timesheet_type.ToString());

                    if (_hd.Status == true)
                    {
                        Edit_btn.Enabled = false;
                        delete_btn.Enabled = false;
                        cancel_btn.Enabled = true;
                    }
                    else
                    {
                        Edit_btn.Enabled = true;
                        delete_btn.Enabled = true;
                    }

                    DisplayEmployeeList();
                }
                else
                {
                    _mode = 1;
                    _timesheetID = 0;

                    Initializeform();
                    EnableButton(false);
                    Enableform(false);

                    txtcompany.Focus();
                }                
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        void DisplayEmployeeList()
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            try
            {
                lsvEmployee.Items.Clear();
                List<UserDefineClass.HRIS.EmployeeList> _employees = _itimesheet.GetTimesheetEmployees(_timesheetID);
                foreach (UserDefineClass.HRIS.EmployeeList _x in _employees)
                {
                    ListViewItem _item = new ListViewItem(_x.EmpID.ToString());
                    _item.SubItems.Add(_x.LastName + ", " + _x.FirstName + " " + _x.MiddleName);

                    lsvEmployee.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }

        void Enableform(bool _cond)
        {
            txttitle.ReadOnly = _cond;
            panFilter.Enabled = _cond;
            cboTimesheetType.Enabled = !_cond;

            dtpcutofffrom.Enabled = !_cond;
            dtpcutoffto.Enabled = !_cond;

            dtpovertimefrom.Enabled = !_cond;
            dtpovertimeto.Enabled = !_cond;
        }

        void Initializeform()
        {
            txtcompany.Text = "";
            txtcompany.Tag = 0;
            txttitle.Text = "";

            dtpcutofffrom.Value = DateTime.Now;
            dtpcutoffto.Value = DateTime.Now;

            dtpovertimefrom.Value = DateTime.Now;
            dtpovertimeto.Value = DateTime.Now;
        }

        void Cancel()
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            try
            {
                EnableButton(true);
                Enableform(true);

                DisplayRecord(_itimesheet.GetTimesheet(_timesheetID));

            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            _mode = 1;
            _timesheetID = 0;

            Initializeform();
            EnableButton(false);
            Enableform(false);

            txtcompany.Focus();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (_timesheetID == 0)
            {
                MessageBox.Show("Please select a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to proceed editing this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 2;

            EnableButton(false);
            Enableform(false);

            txtcompany.Focus();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (_timesheetID == 0)
            {
                MessageBox.Show("Please select a record to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to proceed deleting this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 3;
            ManageRecord();
        }

        void ManageRecord()
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();

            TimeSheet_HD _hd = new TimeSheet_HD();
            try
            {
                _hd.TimeSheetID = _timesheetID;
                _hd.CompID = int.Parse(txtcompany.Tag.ToString());
                _hd.Title = txttitle.Text;
                _hd.RangeFrom = dtpcutofffrom.Value;
                _hd.RangeTo = dtpcutoffto.Value;
                _hd.OTFrom = dtpovertimefrom.Value;
                _hd.OTTo = dtpovertimeto.Value;
                _hd.UserID = LoginUser.userid;
                _hd.timesheet_type = cboTimesheetType.SelectedIndex;

                _timesheetID = _itimesheet.ManageTimeSheetHeader(_hd, _mode);

                if (_mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 4, "Timesheet successfully Deleted."); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, 4, "Timesheet successfully Posted."); }
                else if (_mode == 4) { ToolsControl.CallShowNotification(this, 4, "Timesheet successfully Unposted."); }

                if (_timesheetID == 0)
                {
                    MessageBox.Show("Please select timesheet before you can add ann employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Add employee to this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                TimeSheetEmployeeList _selectemployee = new TimeSheetEmployeeList(_timesheetID, dtpcutofffrom.Value, dtpcutoffto.Value, _compcode, Convert.ToBoolean(cboTimesheetType.SelectedIndex));
                _selectemployee.ShowDialog();

                Cancel();
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtcompany.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtcompany);
                txtcompany.Focus();
                return;
            }

            if (txttitle.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txttitle);
                txttitle.Focus();
                return;
            }

            if (cboTimesheetType.Text.Length == 0)
            {
                MessageBox.Show("Please select timesheet type!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTimesheetType.Focus();
                return;
            }

            if (MessageBox.Show("Are you sure you want to save this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManageRecord();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void reprocessemployeetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reprocess the timesheet of this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            try
            {
                ProcessTimesheet(_selected_empid);
                ToolsControl.CallShowNotification(this, 4, "Employee timesheet successfully reprocess.");
                DisplayRecord(_itimesheet.GetTimesheet(_timesheetID));
                //DisplayLogs(_itimesheet.GetEmployeeTimeSheets(_selected_empid, _timesheetID));
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        void ProcessTimesheet(int _empid)
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            Timesheet_Details _timesheet = new Timesheet_Details();

            try
            {
                _timesheet.TimeSheetID = _timesheetID;
                _timesheet.EmpID = _empid;

                _itimesheet.GenerateTimeSheet(_timesheet, dtpcutofffrom.Value, dtpcutoffto.Value, Convert.ToBoolean(cboTimesheetType.SelectedIndex));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void DisplayLogs(List<Timesheet_Details> _details)
        {
            prb.Value = 0;
            prb.Maximum = _details.Count;
            try
            {
                lsvAttendance.Items.Clear();
                foreach (Timesheet_Details _x in _details)
                {
                    prb.Value = prb.Value + 1;
                    ListViewItem _item = new ListViewItem(_x.ID.ToString());
                    _item.SubItems.Add(_x.MonthRange.Value.ToShortDateString());
                    if (_x.TimeIn == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_x.TimeIn.Value.ToShortTimeString()); }

                    if (_x.TimeOut == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_x.TimeOut.Value.ToShortTimeString()); }

                    _item.SubItems.Add(_x.Employee.Shift.Description);         //shift
                    _item.SubItems.Add(_x.LateHours.ToString());
                    _item.SubItems.Add(_x.UndertimeHours.ToString());
                    _item.SubItems.Add("");         //leave

                    lsvAttendance.Items.Add(_item);
                }               

            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void deletetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Are you sure you want to remove this employee in this timesheet?", "Remove Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
                _itimesheet.RemoveEmployeeFromTimesheet(_timesheetID, _selected_empid);

                ToolsControl.CallShowNotification(this, 4, "Employee successfully remove from the timesheet.");
                DisplayEmployeeList();
                DisplayLogs(_itimesheet.GetEmployeeTimeSheets(_selected_empid, _timesheetID));
            }
        }

        private void AddEmployeeTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_timesheetID == 0)
            {
                MessageBox.Show("Please select timesheet before you can add ann employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Add employee to this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            TimeSheetEmployeeList _selectemployee = new TimeSheetEmployeeList(_timesheetID, dtpcutofffrom.Value, dtpcutoffto.Value, _compcode, Convert.ToBoolean(cboTimesheetType.SelectedIndex));
            _selectemployee.ShowDialog();
        }

        private void company_btn_Click(object sender, EventArgs e)
        {
            txtcompany.Text = "";
            txtcompany.Tag = 0;

            Searchform _searchform = new Searchform();
            _searchform._searchby = searchby.HURIS.COMPANY;
            _searchform.BringToFront();
            _searchform.ShowDialog();

            Company _company = _searchform.ReturnSearchCompany;
            if (_company != null)
            {
                txtcompany.Text = _company.CompanyName;
                txtcompany.Tag = int.Parse(_company.CompID.ToString());
                _compcode = _company.CompanyCode;
            }
        }

        void DisplayTimesheetDetails(int _EMPID, int TSID, string _viewtype)
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            iEmployee _iemployee = new HURISRepository.rEmployee();
            iAttendance _iattendance = new HURISTransactionRepository.rAttendance();
            bool _isholiday;
            int _eventattendees = 0;
            int _obtp = 0;
            int _attendees = 0;

            try
            {
                if (_viewtype == "EMPLOYEE")
                {
                    lsvEmployee.Items.Clear();
                    var EmployeeList = (from d in _itimesheet.GetEmployeeTimeSheets(_selected_empid, _timesheetID)
                                        select new { d.EmpID }).ToList().Distinct();
                    List<Employee> _employee = (from d in _iemployee.GetEmployees("", "")
                                                join x in EmployeeList on d.Emp_ID equals x.EmpID
                                                orderby d.Lastname, d.Firstname, d.Middlename
                                                select d).ToList();
                    if (_employee != null)
                    {
                        foreach (Employee _list in _employee)
                        {
                            ListViewItem lstItem = lsvEmployee.Items.Add(_list.Emp_ID.ToString());
                            lstItem.SubItems.Add(_list.Lastname + ", " + _list.Firstname + " " + _list.Middlename.Substring(0, 1) + ".");
                        }
                    }
                }
                else
                {
                    lsvAttendance.Items.Clear();
                    List<Timesheet_Details> _timesheet = (from d in _itimesheet.GetEmployeeTimeSheets(_selected_empid, _timesheetID) orderby d.MonthRange ascending select d).ToList();
                    if (_timesheet != null)
                    {
                        foreach (Timesheet_Details _list in _timesheet)
                        {
                            _isholiday = _iattendance.IsHoliday(_list.MonthRange.Value.Date);
                            ListViewItem lstItem = lsvAttendance.Items.Add(_list.ID.ToString());
                            lstItem.SubItems.Add(_list.MonthRange.Value.ToShortDateString());
                            if (_list.TimeIn == null) { lstItem.SubItems.Add(""); }
                            else { lstItem.SubItems.Add(_list.TimeIn.Value.ToLongTimeString()); }

                            if (_list.TimeOut == null) { lstItem.SubItems.Add(""); }
                            else { lstItem.SubItems.Add(_list.TimeOut.Value.ToLongTimeString()); }

                            if (_list.TotalWorkingHrs == null || _list.TotalWorkingHrs == 0) { lstItem.SubItems.Add(""); }
                            else { lstItem.SubItems.Add(_list.TotalWorkingHrs.ToString()); }

                            if (_list.LateHours == null || _list.LateHours == 0) { lstItem.SubItems.Add(""); }
                            else { lstItem.SubItems.Add(_list.LateHours.ToString()); }

                            if (_list.UndertimeHours == null || _list.UndertimeHours == 0) { lstItem.SubItems.Add(""); }
                            else { lstItem.SubItems.Add(_list.UndertimeHours.ToString()); }

                            //if (_list.IsAbsent != null) { lstItem.SubItems.Add(_list.IsAbsent.ToString()); }
                            if (_list.NoOfDaysAbsent != null) { lstItem.SubItems.Add(_list.NoOfDaysAbsent.ToString()); }
                            if (_list.SickLeave != null && _list.SickLeave != 0) { lstItem.SubItems.Add(_list.SickLeave.ToString()); } else { lstItem.SubItems.Add(""); }
                            if (_list.VacationLeave != null && _list.VacationLeave != 0) { lstItem.SubItems.Add(_list.VacationLeave.ToString()); } else { lstItem.SubItems.Add(""); }
                            if (_list.OtherLeave != null && _list.OtherLeave != 0) { lstItem.SubItems.Add(_list.OtherLeave.ToString()); } else { lstItem.SubItems.Add(""); }
                            if (_list.EmegencyLeave != null && _list.EmegencyLeave != 0) { lstItem.SubItems.Add(_list.EmegencyLeave.ToString()); } else { lstItem.SubItems.Add(""); }
                            if (_list.PaternityLeave != null && _list.PaternityLeave != 0) { lstItem.SubItems.Add(_list.PaternityLeave.ToString()); } else { lstItem.SubItems.Add(""); }
                            if (_list.MaternityLeave != null && _list.MaternityLeave != 0) { lstItem.SubItems.Add(_list.MaternityLeave.ToString()); } else { lstItem.SubItems.Add(""); }

                            //if (_list.LogDate != null)
                            if (_list.MonthRange != null)
                            {
                                int _attendeestype = _iattendance.CheckEvent(_list.MonthRange.Value.Date);
                                if (_attendeestype != 0)
                                {
                                    if (_attendeestype == 1 || _attendeestype == 2 || _attendeestype == 3) { _attendees = 1; }
                                    else
                                        _attendees = _iattendance.CheckEventAttendees(_list.MonthRange.Value.Date, Convert.ToInt16(_list.EmpID.ToString()));
                                    if (_attendees > 0) { _eventattendees = 1; } else { _eventattendees = 0; }
                                }
                                else { _eventattendees = 0; }
                            }

                            _obtp = _iattendance.CheckOBTP(Convert.ToInt16(_list.EmpID.ToString()), Convert.ToDateTime(_list.MonthRange.Value.ToLongDateString()));

                            if (Convert.ToInt16(_list.MonthRange.Value.Date.DayOfWeek) == 6 || Convert.ToInt16(_list.MonthRange.Value.Date.DayOfWeek) == 0)
                            {
                                lstItem.BackColor = Color.LightGray;
                            }
                            else if (_isholiday == true) { lstItem.BackColor = Color.CornflowerBlue; }
                            else if (_list.TimeIn == null && _list.TimeOut == null)
                            {
                                if (_list.SickLeave == 1 || _list.VacationLeave == 1) { lstItem.BackColor = Color.LimeGreen; }
                                else if (Convert.ToDouble(_list.SickLeave) == 0.5 || Convert.ToDouble(_list.VacationLeave) == 0.5) { lstItem.BackColor = Color.PaleGreen; }
                                else if (_list.OtherLeave != null && _list.OtherLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.EmegencyLeave != null && _list.EmegencyLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.PaternityLeave != null && _list.PaternityLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.MaternityLeave != null && _list.MaternityLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_eventattendees == 1) { lstItem.BackColor = Color.HotPink; }
                                else if (_obtp > 0) { lstItem.BackColor = Color.SaddleBrown; }
                                else { lstItem.BackColor = Color.Red; }
                            }
                            else if (_list.TimeIn != null && _list.TimeOut != null)
                            {
                                if (Convert.ToDouble(_list.SickLeave) == 0.5 || Convert.ToDouble(_list.VacationLeave) == 0.5) { lstItem.BackColor = Color.PaleGreen; }
                                else if (_list.OtherLeave != null && _list.OtherLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.EmegencyLeave != null && _list.EmegencyLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.PaternityLeave != null && _list.PaternityLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.MaternityLeave != null && _list.MaternityLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.SickLeave == 1 || _list.VacationLeave == 1) { lstItem.BackColor = Color.LimeGreen; }
                                else if (_eventattendees == 1) { lstItem.BackColor = Color.HotPink; }
                                else if (_obtp > 0) { lstItem.BackColor = Color.SaddleBrown; }
                                else if (_list.LateHours > 0) { lstItem.BackColor = Color.Gold; }
                                else if (_list.UndertimeHours > 0) { lstItem.BackColor = Color.Coral; }
                            }
                            else if (_list.TimeIn != null && _list.TimeOut == null)
                            {
                                if (_list.SickLeave == 1 || _list.VacationLeave == 1) { lstItem.BackColor = Color.LimeGreen; }
                                else if (_list.OtherLeave != null && _list.OtherLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.EmegencyLeave != null && _list.EmegencyLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.PaternityLeave != null && _list.PaternityLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (_list.MaternityLeave != null && _list.MaternityLeave != 0) { lstItem.BackColor = Color.ForestGreen; }
                                else if (Convert.ToDouble(_list.SickLeave) == 0.5 || Convert.ToDouble(_list.VacationLeave) == 0.5) { lstItem.BackColor = Color.PaleGreen; }
                                else if (_eventattendees == 1) { lstItem.BackColor = Color.HotPink; }
                                else if (_obtp > 0) { lstItem.BackColor = Color.SaddleBrown; }
                                else { lstItem.BackColor = Color.Plum; }
                            }
                            else { lstItem.BackColor = Color.Plum; }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvEmployee_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count == 0) { return; }

            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            try
            {

                //DisplayLogs(_itimesheet.GetEmployeeTimeSheets(_selected_empid, _timesheetID));

                if (lsvEmployee.SelectedItems.Count > 0)
                {
                    _selected_empid = int.Parse(lsvEmployee.SelectedItems[0].Text);
                    DisplayTimesheetDetails(_selected_empid, _timesheetID, "LOGS");
                    lblSelected.Text = e.Item.SubItems[1].Text;
                }
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void lsvEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            //if (lsvEmployee.SelectedItems.Count <= 0) { return; }
            if (_timesheetID == 0) { return; }

            if (e.Button == System.Windows.Forms.MouseButtons.Right && _status == false)
            {
                lsvEmployee.ContextMenuStrip = cmsEmployee;
            }
            else
            {
                lsvEmployee.ContextMenuStrip = null;
            }
        }

        private void AddemptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_timesheetID == 0)
            {
                MessageBox.Show("Please select timesheet before you can add ann employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Add employee to this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            TimeSheetEmployeeList _selectemployee = new TimeSheetEmployeeList(_timesheetID, dtpcutofffrom.Value, dtpcutoffto.Value, _compcode, Convert.ToBoolean(cboTimesheetType.SelectedIndex));
            _selectemployee.ShowDialog();

            Cancel();
        }

        private void TimesheetForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_status == true) { return; }
            if (e.KeyCode == Keys.F3) { RegenerateTimesheet(); }
        }

        void RegenerateTimesheet()
        {
            try
            {
                iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();

                DialogResult _result = MessageBox.Show("Are you sure you want to re-generate timesheet?", "Re-generate", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_result == DialogResult.Yes)
                {
                    Application.DoEvents();

                    this.Cursor = Cursors.WaitCursor;
                    foreach (ListViewItem _list in lsvEmployee.Items)
                    {
                        _empid = int.Parse(_list.Text);
                        ProcessTimesheet(_empid);
                    }
                    this.Cursor = Cursors.Default;
                    ToolsControl.CallShowNotification(this, 4, "Employee timesheet successfully reprocess.");
                    DisplayRecord(_itimesheet.GetTimesheet(_timesheetID));
                }
            }

            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
            
        }
    }
}
