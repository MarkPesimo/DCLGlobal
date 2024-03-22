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
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Timesheet
{
    public partial class TimeSheetEmployeeList : Form
    {
        int _id;
        int _empid;
        DateTime _datefrom;
        DateTime _dateto;
        public bool IsTSGenerated;
        string _compcode;
        bool _is_confidential;
        public TimeSheetEmployeeList(int _TSid, DateTime _dtFrom, DateTime _dtTo, string _COMPCODE, bool _IS_CONFIDENTIAL)
        {
            InitializeComponent();
            _id = _TSid;
            _datefrom = _dtFrom;
            _dateto = _dtTo;
            _compcode = _COMPCODE;
            _is_confidential = _IS_CONFIDENTIAL;
        }

        void DisplayEmployeeList(string _searchtext)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            ListViewItem lstItem = new ListViewItem();

            try
            {
                List<UserDefineClass.HRIS.EmployeeSearchList> _employee = (from d in _iemployee.SearchEmployees(_searchtext, "", _compcode) where d.IsIncludePayroll == true && d.Is_Confidential == _is_confidential orderby d.LastName, d.FirstName, d.MiddleName select d).ToList();
                if (_employee != null)
                {
                    foreach (UserDefineClass.HRIS.EmployeeSearchList _list in _employee)
                    {
                        lstItem = lstEmployee.Items.Add(_list.LastName + ", " + _list.FirstName + " " + _list.MiddleName.Substring(0, 1) + ".");
                        lstItem.SubItems.Add(_list.EmpID.ToString());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimeSheetEmployeeList_Load(object sender, EventArgs e)
        {
            DisplayEmployeeList("");
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                FindEmployee();
            }
        }

        void FindEmployee()
        {
            lstEmployee.Refresh();
            ListViewItem _namefound = lstEmployee.FindItemWithText(txtFind.Text, true, 0, true);
            if (_namefound != null)
            {
                lstEmployee.TopItem = _namefound;
                lstEmployee.TopItem.EnsureVisible();
                lstEmployee.Select();
                _namefound.Selected = true;
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem _item in lstEmployee.Items)
            {
                _item.Checked = chkAll.Checked;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (lstEmployee.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select employee to generate timesheet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult _result = MessageBox.Show("Are you sure you want to generate employee's timesheet?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.Yes)
            {
                GenerateTimesheet();
                this.Close();
            }
        }

        void GenerateTimesheet()
        {
            try
            {
                int _count = lstEmployee.CheckedItems.Count;
                prgBar.Minimum = 0;
                prgBar.Maximum = _count;
                prgBar.Value = 0;
                       
                Panel3.Visible = true;

                foreach (ListViewItem _item in lstEmployee.CheckedItems)
                {
                    prgBar.Value = prgBar.Value + 1;
                    lblPercent.Text = Convert.ToInt16(Convert.ToDecimal(prgBar.Value) / Convert.ToDecimal(prgBar.Maximum) * 100).ToString() + "%";
                    _empid = int.Parse(_item.SubItems[1].Text);
                    SaveTimesheetDetails(_empid);
                    Application.DoEvents();
                }

                Panel3.Visible = false;
                IsTSGenerated = true;
            }

            catch (Exception ex)
            {
                IsTSGenerated = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SaveTimesheetDetails(int _EMPID)
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            Timesheet_Details _timesheet = new Timesheet_Details();

            try
            {
                _timesheet.TimeSheetID = _id;
                _timesheet.EmpID = _empid;

                _itimesheet.GenerateTimeSheet(_timesheet, _datefrom, _dateto, _is_confidential);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
