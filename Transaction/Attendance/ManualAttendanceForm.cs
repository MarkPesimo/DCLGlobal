using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Inquiry;

using CAL.Global;
using CAL.Model;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Transaction.Attendance
{
    public partial class ManualAttendanceForm : Form
    {
        int _empid;

        public ManualAttendanceForm()
        {
            InitializeComponent();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                txtEmpname.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                _empid = _employee.Emp_ID;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (txtEmpname.Tag.ToString() == "0")
            {
                MessageBox.Show("Please select employee to view attendance record.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpname.Focus();
                return;
            }

            DisplayRecords(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Are you sure you want to set the attendance of this employee equal to his shift?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.No) { return; }

            DisplayRecords(1);
        }

        void DisplayRecords(int _mode)
        {
            iAttendance _iattendance = new HURISTransactionRepository.rAttendance();
            List<USP_H_PROCESS_MANUAL_ATTENDANCEResult> _records = new List<USP_H_PROCESS_MANUAL_ATTENDANCEResult>();
            int n = 0;

            dgvAttendance.RowCount = 0;

            try
            {
                _records = _iattendance.ProcessManualAttendance(_empid, dtFrom.Value, dtTo.Value, _mode);
                foreach (USP_H_PROCESS_MANUAL_ATTENDANCEResult _list in _records)
                {
                    dgvAttendance.Rows.Add();
                    dgvAttendance.Rows[n].Cells[0].Value = _list.employee_no;
                    dgvAttendance.Rows[n].Cells[1].Value = _list.employee_name;
                    dgvAttendance.Rows[n].Cells[2].Value = _list.date_log;
                    dgvAttendance.Rows[n].Cells[3].Value = _list.shift_name;
                    dgvAttendance.Rows[n].Cells[4].Value = _list.time_in;
                    dgvAttendance.Rows[n].Cells[5].Value = _list.time_out;

                    n++;
                }

                if (_mode == 1)
                {
                    MessageBox.Show("Process complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
