using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using DCLGlobal.Reports.Employee;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Transaction.Attendance
{
    public partial class EmployeeAttandanceform : Form
    {
        string _filter = "";
        int _index = 0;
        int _leavetype = 0;
        int _attendeestype = 0;
        int _attendees = 0;
        int _eventattendees = 0;
        bool _isholiday = false;
        int _onleave = 0;
        int _count = 0;
        string _searchtext = "";
        int _empid;

#region Delegates
        
        private delegate void DisplayLoadImageDelegate(bool _value);
        public void DisplayImage(bool _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new DisplayLoadImageDelegate(this.DisplayImage), new object[] {_value});
            }
            else
            {
                panLoad.Visible = _value;
            }
        }

        private delegate void SetProgressBarValueDelegate(int _value);
        public void SetProgressBarValue(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetProgressBarValueDelegate(this.SetProgressBarValue), new object[] { _value });
            }
            else
            {
                prgBar.Value = _value;
            }
        }

        private delegate void SetProgressBarMaxValueDelegate(int _value);
        public void SetProgressBarMaxValue(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetProgressBarMaxValueDelegate(this.SetProgressBarMaxValue), new object[] { _value });
            }
            else
            {
                prgBar.Maximum = _value;
            }
        }

        private delegate void SetLabelProgressValueDelegate(string _value);
        public void SetLabelProgressValue(string _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetLabelProgressValueDelegate(this.SetLabelProgressValue), new object[] { _value });
            }
            else
            {
                lblPercent.Text = _value;
            }
        }

        private delegate void AddDataGridRowDelegate();
        public void AddDataGridRow()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new AddDataGridRowDelegate(this.AddDataGridRow));
            }
            else
            {
                dgvAttendance.Rows.Add();
            }
        }

        private delegate void SetDataGridRowDelegate();
        public void SetDataGridRow()
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetDataGridRowDelegate(this.SetDataGridRow));
            }
            else
            {
                dgvAttendance.RowCount = 0;
            }
        }

        private delegate void DisplayLoadingPanelDelegate(bool _value);
        public void DisplayLoadingPanel(bool _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new DisplayLoadingPanelDelegate(this.DisplayLoadingPanel), new object[] { _value });
            }
            else
            {
                Panel3.Visible = _value;
                Label5.Visible = _value;
                lblPercent.Visible = _value;
            }
        }

#endregion

        public EmployeeAttandanceform()
        {
            InitializeComponent();
        }

        public void LoadImage(bool _visible)
        {
            Thread.Sleep(500);
            DisplayImage(_visible);
            Thread.Sleep(500);
        }

        public void LoadImageThread(bool _visible)
        {
            Thread _trd = new Thread(() => LoadImage(_visible));
            _trd.IsBackground = true;
            _trd.Start();
        }

        void DisplayAttendance(string _filter)
        {
            FillDatagridView(_filter);
        }

        private void EmployeeAttandanceform_Load(object sender, EventArgs e)
        {
            cboFilter.SelectedIndex = 0;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (cboFilter.SelectedIndex == 1)
            {
                txtEmployeeName.Text = "";
                txtEmployeeName.Tag = 0;

                Searchform _Searchform = new Searchform();
                _Searchform._searchby = searchby.CMS.EMPLOYEES;
                _Searchform.ShowDialog();

                Employee _employee = _Searchform.ReturnSearchEmployee;
                if (_employee != null)
                {
                    txtEmployeeName.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    _empid = _employee.Emp_ID;
                }
            }
        }

        private void btnReplanned_Click(object sender, EventArgs e)
        {
            if (cboFilter.SelectedIndex == 0)
            {
                _filter = "ALL";
            }
            else if (cboFilter.SelectedIndex == 1)
            {
                _filter = "PER_EMPLOYEE"; 
                if (txtEmployeeName.Text.Length == 0)
                {
                    btxMsg.ShowBalloon(this.txtEmployeeName);
                    this.txtEmployeeName.Focus();
                    return;
                }               
            }
            else if (cboFilter.SelectedIndex == 2)
            {
                _filter = "APS";
            }
            else if (cboFilter.SelectedIndex == 3)
            {
                _filter = "APW";
            }
            else if (cboFilter.SelectedIndex == 4)
            {
                _filter = "ASI";
            }
            else if (cboFilter.SelectedIndex == 5)
            {
                _filter = "ZMG";
            }
            else if (cboFilter.SelectedIndex == 6)
            {
                _filter = "PER_SEARCHTEXT";
                if (txtEmployeeName.Text.Length == 0)
                {
                    MessageBox.Show("Please input search text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmployeeName.Focus();
                    return;
                }
            }

            if (cboFilter.SelectedIndex == 1)
            {
                _searchtext = _empid.ToString();
            }
            else
            {
                _searchtext = "%" + txtEmployeeName.Text + "%"; 
            }

            Thread _trd = new Thread(() => DisplayAttendance(_filter));
            _trd.IsBackground = true;
            _trd.Start();
            //FillDatagridView(_filter);
        }

        private void FillDatagridView(string _filter)
        {
            //iEmployee _iemployee = new HURISRepository.rEmployee();
            iAttendance _iattendance = new HURISTransactionRepository.rAttendance(); 
            //dgvAttendance.RowCount = 0;
            int n = 0;
            try 
            {
                DisplayImage(true);
                Thread.Sleep(500);

                SetDataGridRow();
                //List<SP_VIEWATTENDANCEResult> _attendances = _iemployee.GetEmployeeAttendances(_filter, dtpFrom.Value, dtpTo.Value, txtEmployeeName.Tag.ToString());
                //List<SP_VIEWATTENDANCEResult> _attendances = _iattendance.GetEmployeeAttendances(_filter, dtpFrom.Value, dtpTo.Value, txtEmployeeName.Tag.ToString());
                List<SP_VIEWATTENDANCESummaryResult> _attendances = _iattendance.GetEmployeeAttendances(_filter, dtpFrom.Value, dtpTo.Value, _searchtext);
                if (_attendances != null)
                {
                    _count = _attendances.Count;
                    SetProgressBarMaxValue(_count);
                    SetProgressBarValue(0);

                    DisplayImage(false);
                    Thread.Sleep(500);

                    foreach (SP_VIEWATTENDANCESummaryResult _list in _attendances)
                    {   
                        if (_list.Remarks != null)
                        {
                            _index = _list.Remarks.IndexOf("~");
                        }
                        else 
                        {
                            _index = 0;
                        }

                        AddDataGridRow();
                        //dgvAttendance.Rows.Add();
                        dgvAttendance.Rows[n].Cells[0].Value = "Edit";
                        dgvAttendance.Rows[n].Cells[1].Value = "Delete";
                        dgvAttendance.Rows[n].Cells[2].Value = _list.ID;
                        dgvAttendance.Rows[n].Cells[3].Value = _list.EmpID;
                        dgvAttendance.Rows[n].Cells[4].Value = _list.EmpNo;
                        dgvAttendance.Rows[n].Cells[5].Value = _list.EmpName;
                        dgvAttendance.Rows[n].Cells[6].Value = _list.DateLog.Value.ToString("MM/dd/yyyy");
                        dgvAttendance.Rows[n].Cells[7].Value = _list.Shift;
                        if (_list.TimeIn != null)
                        {
                            dgvAttendance.Rows[n].Cells[8].Value = _list.TimeIn.Value.ToString("hh:mm tt");
                        }
                        if (_list.Time_Out != null)
                        {
                            dgvAttendance.Rows[n].Cells[9].Value = _list.Time_Out.Value.ToString("hh:mm tt");
                        } 
                        dgvAttendance.Rows[n].Cells[10].Value = _list.HoursWorked;

                        if (_index <= 0)
                        {
                            dgvAttendance.Rows[n].Cells[11].Value = _list.Remarks;
                            _leavetype = 0;
                        }
                        else
                        {
                            dgvAttendance.Rows[n].Cells[11].Value = _list.Remarks.Substring(0, _index);
                            _leavetype = int.Parse(_list.Remarks.Substring(_index + 1));
                        }

                        //------------------- color legend -------------------------
                        iAttendance _attendance = new HURISTransactionRepository.rAttendance();
                        _isholiday = _attendance.IsHoliday(_list.DateLog.Value.Date);
                        if (_isholiday == true)
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.CornflowerBlue;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.CornflowerBlue;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.CornflowerBlue;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.CornflowerBlue;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.CornflowerBlue;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.CornflowerBlue;
                        }

                        _onleave = _attendance.IsOnLeave(int.Parse(_list.EmpID.ToString()), _list.DateLog.Value.Date);
                        if (_leavetype == 1 | _leavetype == 2)
                        {
                            if (_onleave == 2)
                            {
                                dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.LimeGreen;
                                dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.LimeGreen;
                                dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.LimeGreen;
                                dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.LimeGreen;
                                dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.LimeGreen;
                                dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.LimeGreen;
                            }
                            else if (_onleave == 1)
                            {
                                dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.PaleGreen;
                                dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.PaleGreen;
                                dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.PaleGreen;
                                dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.PaleGreen;
                                dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.PaleGreen;
                                dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.PaleGreen;
                            }
                        }
                        else if (_leavetype == 3)
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.ForestGreen;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.ForestGreen;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.ForestGreen;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.ForestGreen;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.ForestGreen;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.ForestGreen;
                        }
                        else if (_leavetype == 4)
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.LawnGreen;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.LawnGreen;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.LawnGreen;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.LawnGreen;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.LawnGreen;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.LawnGreen;
                        }
                        else if (_list.Remarks == "Filed OBTP")
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.SaddleBrown;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.SaddleBrown;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.SaddleBrown;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.SaddleBrown;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.SaddleBrown;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.SaddleBrown;
                        }
                        else if (_onleave == 0 & _list.TimeIn == null & _list.Time_Out == null & _isholiday == false)
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.Red;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.Red;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.Red;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.Red;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.Red;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.Red;
                        }

                        _attendeestype = _attendance.CheckEvent(_list.DateLog.Value.Date);
                        if (_attendeestype != 0)
                        {
                            if (_attendeestype == 1)
                            {
                                _eventattendees = 1;
                            }
                            else
                            {
                                _attendees = _attendance.CheckEventAttendees(_list.DateLog.Value.Date, int.Parse(_list.EmpID.ToString()));
                                if (_attendees > 0)
                                {
                                    _eventattendees = 1;
                                }
                                else
                                {
                                    _eventattendees = 0;
                                }
                            }
                        }
                        else
                        {
                            _eventattendees = 0;
                        }

                        if (_list.Remarks == "Saturday" | _list.Remarks == "Sunday")
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.LightGray;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.LightGray;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.LightGray;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.LightGray;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.LightGray;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.LightGray;
                        }
                        //else if (_eventattendees == 1 & _list.TimeIn != null)
                        else if (_eventattendees == 1)
                        {
                            dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.HotPink;
                            dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.HotPink;
                            dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.HotPink;
                            dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.HotPink;
                            dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.HotPink;
                            dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.HotPink;
                        }
                        else
                        {
                            if ((_list.TimeIn != null & _list.Time_Out == null) | (_list.TimeIn == null & _list.Time_Out != null) & _onleave == 0 & _isholiday == false & _eventattendees == 0)
                            {
                                dgvAttendance.Rows[n].Cells[6].Style.BackColor = Color.Plum;
                                dgvAttendance.Rows[n].Cells[7].Style.BackColor = Color.Plum;
                                dgvAttendance.Rows[n].Cells[8].Style.BackColor = Color.Plum;
                                dgvAttendance.Rows[n].Cells[9].Style.BackColor = Color.Plum;
                                dgvAttendance.Rows[n].Cells[10].Style.BackColor = Color.Plum;
                                dgvAttendance.Rows[n].Cells[11].Style.BackColor = Color.Plum;
                            }
                        }
                        //------------------- color legend -------------------------

                        DisplayLoadingPanel(true);
                        SetProgressBarValue(prgBar.Value + 1);
                        Thread.Sleep(50);

                        decimal _pgbar = prgBar.Value;
                        decimal _pgmax = prgBar.Maximum;
                        decimal _res = (_pgbar / _pgmax) * 100;

                        SetLabelProgressValue((decimal.ToInt32(_res)).ToString() + "%");
                        //SetLabelProgressValue((prgBar.Value / prgBar.Maximum * 100) + "%");

                        if (prgBar.Value ==_count)
                        {
                            Thread.Sleep(500);
                            DisplayLoadingPanel(false);
                        }

                        n++;
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
            try
            {
                if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Transaction.ATTENDANCE, Feature.Edit, SystemModuleType.Transaction) == false) { return; }

                Attendanceform _attendanceform = new Attendanceform(0, 1, 0);
                _attendanceform.ShowDialog();

                FillDatagridView(_filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int _id = int.Parse(dgvAttendance.Rows[e.RowIndex].Cells[2].Value.ToString());
                int _empid = int.Parse(dgvAttendance.Rows[e.RowIndex].Cells[3].Value.ToString());
                if (e.ColumnIndex == 0)         //edit
                {
                    if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Transaction.ATTENDANCE, Feature.Edit, SystemModuleType.Transaction) == false) { return; }
                    if (MessageBox.Show("Do you really want to edit this Log?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    Attendanceform _attendanceform = new Attendanceform(_id, 2, _empid);
                    _attendanceform.ShowDialog();

                    //ToolsControl.CallShowNotification(this, 2, "");
                    FillDatagridView(_filter);
                }
                else if (e.ColumnIndex == 1)    //delete
                {
                    //if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Transaction.ATTENDANCE, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
                    if (MessageBox.Show("This will delete the record permanently, Do you want to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    iAttendance _iAttendance = new HURISTransactionRepository.rAttendance();
                    CAL.Model.Attendance _attendance = new CAL.Model.Attendance();

                    _attendance.AttendanceID = _id;
                    _attendance.EmpID = _empid;

                    _iAttendance.ManageAttendance(_attendance, 3);

                    ToolsControl.CallShowNotification(this, 3, "");
                    FillDatagridView(_filter);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmployeeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnAccount.PerformClick(); }
        }

        private void add_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Transaction.ATTENDANCE, Feature.Edit, SystemModuleType.Transaction) == false) { return; }

                Attendanceform _attendanceform = new Attendanceform(0, 1, 0);
                _attendanceform.ShowDialog();

                FillDatagridView(_filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFilter.SelectedIndex == 1)
            {
                txtEmployeeName.ReadOnly = true;
                btnAccount.Enabled = true;
            }
            else
            {
                txtEmployeeName.Clear();
                txtEmployeeName.ReadOnly = false;
                btnAccount.Enabled = true;
            }
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Attendance Report", SystemModuleType.Report) == false) { return; }

            GeneralReportForm _report = new GeneralReportForm("LOG", 0);
            _report.BringToFront();
            _report.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Manual Attendance", SystemModuleType.Transaction) == false) { return; }

            ManualAttendanceForm _manuallattendance = new ManualAttendanceForm();
            _manuallattendance.BringToFront();
            _manuallattendance.Show();
        }
    }
}
