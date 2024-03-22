using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Transaction.Attendance
{
    public partial class Attendanceform : Form
    {
        int _id;
        int _mode;
        int _shiftid;
        int _empid;

        public Attendanceform()
        {
            InitializeComponent();
        }

        public Attendanceform(int _Id, int _Mode, int _EmpID)
        {
            InitializeComponent();
            _id = _Id;
            _mode = _Mode;
            _empid = _EmpID;
        }

        private void Attendanceform_Load(object sender, EventArgs e)
        {
            iAttendance _iattendance = new HURISTransactionRepository.rAttendance();
            if (_mode == 2)
            {
                btnemployeeName.Enabled = false;
                BindShift(cmbShift);
                DisplayAttendance(_iattendance.GetAttendance(_id));
                this.Text = "Attendance [Edit]";
                lblShift.Visible = true;
                cmbShift.Visible = true;
            }
            else 
            {
                btnemployeeName.Enabled = true;
                InitializeForm();
                this.Text = "Attendance [Add]";
                lblShift.Visible = false;
                cmbShift.Visible = false;
            }
        }

        void InitializeForm()
        {
            try
            {
                txtempno.Text = "";
                txtEmployeeName.Text = "";
                txtEmployeeName.Tag = 0;
                dtpDate.Value = DateTime.Now;
                dtTimeIn.Value = DateTime.Now;
                dtTimeOut.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayAttendance(CAL.Model.Attendance _attendance)
        {                        
            try
            {
                if (_attendance != null)
                {
                    txtempno.Text = _attendance.Emp_No;
                    txtEmployeeName.Text = _attendance.Employee.Lastname + ", " + _attendance.Employee.Firstname + " " + _attendance.Employee.Middlename;
                    dtpDate.Value = _attendance.Datelog.Value;
                    
                    if (_attendance.TimeIn == null)
                    { dtTimeIn.Checked = false; dtDateTimeIn.Checked = false; }
                    else
                    {
                        dtTimeIn.Checked = true;
                        dtTimeIn.Value = _attendance.TimeIn.Value;
                        dtDateTimeIn.Checked = true;
                        dtDateTimeIn.Value = _attendance.TimeIn.Value;
                    }

                    if (_attendance.TimeOut == null)
                    { dtTimeOut.Checked = false; dtDateTimeOut.Checked = false; }
                    else 
                    {
                        dtTimeOut.Checked = true;
                        dtTimeOut.Value = _attendance.TimeOut.Value;
                        dtDateTimeOut.Checked = true;
                        dtDateTimeOut.Value = _attendance.TimeOut.Value; 
                    }
                    cmbShift.SelectedValue = _attendance.ShiftID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnemployeeName_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Text = "";
            txtEmployeeName.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                txtempno.Text = _employee.Emp_No;
                txtEmployeeName.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                txtEmployeeName.Tag = _employee.Emp_ID;
                _shiftid = _employee.Shift_ID;
                _empid = _employee.Emp_ID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iAttendance _iAttendance = new HURISTransactionRepository.rAttendance();
            DateTime _timein = dtDateTimeIn.Value.Date + dtTimeIn.Value.TimeOfDay;
            DateTime _timeout = dtDateTimeOut.Value.Date + dtTimeOut.Value.TimeOfDay;

            try
            {                
                CAL.Model.Attendance _attendance = new CAL.Model.Attendance();

                if (dtDateTimeIn.Checked == false || dtTimeIn.Checked == false)
                {
                    MessageBox.Show("Time in is required.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_timeout < _timein)
                {
                    MessageBox.Show("Time out must be greater than time in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _attendance.EmpID = _empid;
                _attendance.Emp_No = txtempno.Text;
                _attendance.Datelog = dtpDate.Value;

                if (dtTimeIn.Checked == true) { _attendance.TimeIn = _timein; }
                else { _attendance.TimeIn = null; }

                if (dtTimeOut.Checked == true) { _attendance.TimeOut = _timeout; }
                else { _attendance.TimeOut = null; }

                if (_mode != 2)
                { _attendance.ShiftID = _shiftid; }
                else { _attendance.ShiftID = int.Parse(cmbShift.SelectedValue.ToString()); }
                
                _attendance.AttendanceID = _id;

                _iAttendance.ManageAttendance(_attendance, _mode);

                //ToolsControl.CallShowNotification(this, 2, "");
                ToolsControl.CallPopMessage(this, "Record Saved", "Record successfully saved");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindShift(ComboBox _cmb)
        { 
            iShift _ishift = new HURISRepository.rShift();

            try
            {
                List<Shift> _shift = _ishift.GetShifts("");
                _cmb.DataSource = _shift;
                _cmb.DisplayMember = "Description";
                _cmb.ValueMember = "Shift_ID";
                _cmb.SelectedIndex = -1;
            }
                 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
