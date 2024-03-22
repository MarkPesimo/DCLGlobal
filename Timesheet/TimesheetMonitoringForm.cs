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

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Timesheet
{
    public partial class TimesheetMonitoringForm : Form
    {
        int _timesheetid;
        int _mode;
        ToolsControl _tool = new ToolsControl();
        public TimesheetMonitoringForm()
        {
            InitializeComponent();
            GlobalToolsControl.Global.FillCboYear(cboYear);
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
            }
        }

        void DisplayTimesheets()
        {
            iUser _iuser = new GlobalFilesRepository.rUser();
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
            ListViewItem lstItem = new ListViewItem();
            List<TimeSheet_HD> _timesheethead = new List<TimeSheet_HD>();
            Payroll_HD _payroll = new Payroll_HD();
            bool _bycompany = false;
            bool _status = false;
            string _user;            

            try
            {
                lsvHds.Items.Clear();

                if (chkStatus.Checked)
                {
                    if (cboStatus.SelectedIndex == 0) { _status = false; }
                    else { _status = true; }

                    if (txtcompany.Text.Length == 0)
                    {
                        _timesheethead = (from d in _itimesheet.GetTimeSheetsHeader(int.Parse(cboYear.Text), cboMonth.SelectedIndex + 1, _status) orderby d.RangeFrom descending select d).ToList();
                    }
                    else
                    {
                        _timesheethead = (from d in _itimesheet.GetTimeSheetsHeader(int.Parse(cboYear.Text), cboMonth.SelectedIndex + 1, _status) where d.CompID == int.Parse(txtcompany.Tag.ToString()) orderby d.RangeFrom descending select d).ToList();
                    }
                }
                else
                {
                    if (txtcompany.Text.Length == 0)
                    {
                        _timesheethead = (from d in _itimesheet.GetTimeSheetsHD() where d.RangeTo.Value.Month == cboMonth.SelectedIndex + 1 && d.RangeTo.Value.Year == int.Parse(cboYear.Text) orderby d.RangeFrom descending select d).ToList();
                    }
                    else
                    {
                        _timesheethead = (from d in _itimesheet.GetTimeSheetsHD() where d.RangeTo.Value.Month == cboMonth.SelectedIndex + 1 && d.RangeTo.Value.Year == int.Parse(cboYear.Text) && d.CompID == int.Parse(txtcompany.Tag.ToString()) orderby d.RangeFrom descending select d).ToList();
                    }
                }
                

                foreach (TimeSheet_HD _list in _timesheethead)
                {
                    ListViewItem _item = new ListViewItem(_list.TimeSheetID.ToString());
                    _item.SubItems.Add(_list.CompanyProfile.CompanyName);
                    _item.SubItems.Add(_list.Title);

                    List<Timesheet_Details> _timesheetdet = (from d in _itimesheet.GetEmployeeTimeSheets(0, _list.TimeSheetID) select d).GroupBy(n => new { n.EmpID })
                                           .Select(g => g.FirstOrDefault())
                                           .ToList();
                    _item.SubItems.Add(_timesheetdet.Count().ToString());

                    _item.SubItems.Add(_list.RangeFrom.Value.ToShortDateString());
                    _item.SubItems.Add(_list.RangeTo.Value.ToShortDateString());
                    if (_list.Status == true) { _item.SubItems.Add("Posted"); }
                    else { _item.SubItems.Add("Unposted"); }

                    _user = _iuser.GetUser(int.Parse(_list.UserID.ToString())).UserName;
                    _item.SubItems.Add(_user);

                    lsvHds.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void TimesheetMonitoringForm_Load(object sender, EventArgs e)
        {
            cboMonth.SelectedIndex = DateTime.Now.Month - 1;
            cboYear.Text = DateTime.Now.Year.ToString();
            cboStatus.SelectedIndex = 1;
            DisplayTimesheets();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TimesheetMonitoringForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5) { filter_btn.PerformClick(); }
            else if (e.KeyCode == Keys.F1) { new_btn.PerformClick(); }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DisplayTimesheets();
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkCompany.Checked)
            {
                txtcompany.Text = "";
                txtcompany.Tag = 0;
                company_btn.Enabled = false;
            }
            else
            { company_btn.Enabled = true; }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lsvHds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHds.SelectedItems.Count == 0) { return; }
            try
            {
                _timesheetid = int.Parse(lsvHds.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            filter_btn.PerformClick();
        }

        private void lsvHds_DoubleClick(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.GENERATE_TIMESHEET, SystemModuleType.Transaction) == false) { return; }
            TimesheetForm _Timesheetform = new TimesheetForm(_timesheetid);
            _Timesheetform.BringToFront();
            _Timesheetform.Show();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.GENERATE_TIMESHEET, SystemModuleType.Transaction) == false) { return; }
            TimesheetForm _Timesheetform = new TimesheetForm(0);

            if (_tool.CheckFormAleadyOpen("TimesheetForm")) { return; }

            _Timesheetform.BringToFront();
            _Timesheetform.Show();
        }

        private void lsvHds_MouseDown(object sender, MouseEventArgs e)
        {
            if (lsvHds.SelectedItems.Count <= 0) { return; }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                lsvHds.ContextMenuStrip = cmsHeader;
                _timesheetid = int.Parse(lsvHds.SelectedItems[0].Text);

                if (lsvHds.SelectedItems[0].SubItems[6].Text == "Posted")
                {
                    PostTimesheetMenu.Enabled = false;
                    CancelTimesheetMenu.Enabled = false;
                    UnpostTimesheetMenu.Enabled = true;                   
                }
                else
                {
                    PostTimesheetMenu.Enabled = true;
                    CancelTimesheetMenu.Enabled = true;
                    UnpostTimesheetMenu.Enabled = false;
                }
            }
            else
            {
                lsvHds.ContextMenuStrip = null;
            }
        }

        private void PostTimesheetMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to post this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 2;

            if (_timesheetid == 0)
            {
                MessageBox.Show("Please select timesheet to post.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ManageRecord();
        }

        void ManageRecord()
        {
            iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();

            TimeSheet_HD _hd = new TimeSheet_HD();
            try
            {
                _hd.TimeSheetID = _timesheetid;
                _hd.CompID = 0;
                _hd.Title = "";
                _hd.RangeFrom = DateTime.Now;
                _hd.RangeTo = DateTime.Now;
                _hd.OTFrom = DateTime.Now;
                _hd.OTTo = DateTime.Now;

                _timesheetid = _itimesheet.ManageTimeSheetHeader(_hd, _mode);

                if (_mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 4, "Timesheet successfully Deleted."); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, 4, "Timesheet successfully Posted."); }
                else if (_mode == 4) { ToolsControl.CallShowNotification(this, 4, "Timesheet successfully Unposted."); }

                refresh_btn.PerformClick();
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void UnpostTimesheetMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to un-post this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 4;

            if (_timesheetid == 0)
            {
                MessageBox.Show("Please select timesheet to unpost.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ManageRecord();
        }

        private void CancelTimesheetMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this timesheet?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 3;

            if (_timesheetid == 0)
            {
                MessageBox.Show("Please select timesheet to cancel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ManageRecord();
        }

    }
}
