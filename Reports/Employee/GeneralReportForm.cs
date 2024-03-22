using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace DCLGlobal.Reports.Employee
{
    public partial class GeneralReportForm : Form
    {
        string _reporttype;
        int _id;
        int _empid;
        string _filter;
        int _deptID;
#region Delegates
        private delegate void DisplayLoadImageDelegate(bool _value);
        public void DisplayImage(bool _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new DisplayLoadImageDelegate(this.DisplayImage), new object[] { _value });
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
                lblPercent.Visible = _value;
            }
        }
#endregion

        public GeneralReportForm(string _ReportType, int _ID)
        {
            InitializeComponent();
            _reporttype = _ReportType;
            _id = _ID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneralReportForm_Load(object sender, EventArgs e)
        {
            if (_reporttype == "TS_OT")
            {
                dtLogFrom.Enabled = false;
                dtLogTo.Enabled = false;
                txtEmp.Enabled = false;
                btnFind.Enabled = false;
                chkExcel.Enabled = false;
                this.Text = "Timesheet Overtime Report";
            }
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == -1)
            {
                MessageBox.Show("Please select report to filter.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbFilter.SelectedIndex == 5 && _empid == 0)
            {
                MessageBox.Show("Please select employee.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cmbFilter.SelectedIndex == 0) { _filter = "ALL"; }
            if (cmbFilter.SelectedIndex == 1) { _filter = "APS"; }
            if (cmbFilter.SelectedIndex == 2) { _filter = "APW"; }
            if (cmbFilter.SelectedIndex == 3) { _filter = "ASI"; }
            if (cmbFilter.SelectedIndex == 4) { _filter = "ZMG"; }
            if (cmbFilter.SelectedIndex == 5) { _filter = "PER_EM"; }
            if (cmbFilter.SelectedIndex == 6) { _filter = "PER_DEP"; }

            if (_reporttype == "LOG")
            {
                if (chkExcel.Checked == true)
                {
                    if (MessageBox.Show("Export Employee log(s)?", "Confirm Export", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Thread _trd = new Thread(() => ExportToExcel());
                        _trd.IsBackground = true;
                        _trd.Start();
                    }
                }
            }

            if (_reporttype == "OT")
            {
                ShowOvertimeReport();
            }

            Panel3.Visible = false;
        }

        void ExportToExcel()
        {
            ReportControl _close = new ReportControl();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook;
            Worksheet xlWorksheet;
            iAttendance _iattendance = new HURISTransactionRepository.rAttendance();

            string Path = DCLSystemConfiguration.HURIS.Reportpath + "LogTemplate3.xlt";

            if (File.Exists(Path) == false)
            {
                MessageBox.Show(Path + "does not exist!", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int cnt = 3;

            try
            {
                DisplayImage(true);
                Thread.Sleep(500);

                List<SP_REPORT_ATTENDANCE_LOGResult> _attendance = _iattendance.GetAttendanceReports(dtLogFrom.Value.Date, dtLogTo.Value.Date, _filter, _empid);
                if (_attendance != null)
                {
                    xlWorkbook = excel.Workbooks.Open(Path);

                    int _sheet2_details_header = 2;
                    int _sheet2_details = 0;
                    int _details_cnt = 0;
                    int _header_cnt = 0;
                    int _sheet2_name = 1;
                    _empid = 0;

                    int _count = _attendance.Count;
                    SetProgressBarMaxValue(_count);
                    SetProgressBarValue(0);

                    DisplayImage(false);
                    Thread.Sleep(500);

                    DisplayLoadingPanel(true);

                    xlWorksheet = xlWorkbook.Worksheets["sheet1"];
                    xlWorksheet.Cells[1, "A"] = "Attendance from " + dtLogFrom.Value.ToString("MMMM dd, yyyy") + " to " + dtLogTo.Value.ToString("MMMM dd, yyyy");

                    foreach (SP_REPORT_ATTENDANCE_LOGResult _list in _attendance)
                    {
                        if (_empid != _list.EmpID)
                        {
                            _sheet2_name = _sheet2_name + _details_cnt + 1;
                            _sheet2_details_header = _sheet2_name + 1;
                            _sheet2_details = _sheet2_details_header + 1;

                            xlWorksheet = xlWorkbook.Worksheets["sheet2"];
                            xlWorksheet.Cells[_sheet2_name, "A"] = _list.LastName + ", " + _list.FirstName + " " + _list.MidName;
                            xlWorksheet.Cells[_sheet2_name, "B"] = _list.Department;
                            xlWorksheet.Cells[_sheet2_name, "C"] = _list.Position;
                            xlWorksheet.Cells[_sheet2_name, "D"] = _list.LateCount;
                            xlWorksheet.Cells[_sheet2_name, "E"] = _list.TotalLate;
                            xlWorksheet.Cells[_sheet2_name, "F"] = _list.TotalUndertime;

                            xlWorksheet.Range["A" + _sheet2_name.ToString()].Interior.Color = Color.SteelBlue;
                            xlWorksheet.Range["A" + _sheet2_name.ToString()].Font.Color = Color.White;
                            xlWorksheet.Range["A" + _sheet2_name.ToString()].Font.Bold = true;
                            xlWorksheet.Range["A" + _sheet2_name.ToString()].BorderAround();
                            xlWorksheet.Range["B" + _sheet2_name.ToString()].Interior.Color = Color.SteelBlue;
                            xlWorksheet.Range["B" + _sheet2_name.ToString()].Font.Color = Color.White;
                            xlWorksheet.Range["B" + _sheet2_name.ToString()].Font.Bold = true;
                            xlWorksheet.Range["B" + _sheet2_name.ToString()].BorderAround();
                            xlWorksheet.Range["C" + _sheet2_name.ToString()].Interior.Color = Color.SteelBlue;
                            xlWorksheet.Range["C" + _sheet2_name.ToString()].Font.Color = Color.White;
                            xlWorksheet.Range["C" + _sheet2_name.ToString()].Font.Bold = true;
                            xlWorksheet.Range["C" + _sheet2_name.ToString()].BorderAround();
                            xlWorksheet.Range["D" + _sheet2_name.ToString()].Interior.Color = Color.SteelBlue;
                            xlWorksheet.Range["D" + _sheet2_name.ToString()].Font.Color = Color.White;
                            xlWorksheet.Range["D" + _sheet2_name.ToString()].Font.Bold = true;
                            xlWorksheet.Range["D" + _sheet2_name.ToString()].BorderAround();
                            xlWorksheet.Range["E" + _sheet2_name.ToString()].Interior.Color = Color.SteelBlue;
                            xlWorksheet.Range["E" + _sheet2_name.ToString()].Font.Color = Color.White;
                            xlWorksheet.Range["E" + _sheet2_name.ToString()].Font.Bold = true;
                            xlWorksheet.Range["E" + _sheet2_name.ToString()].BorderAround();
                            xlWorksheet.Range["F" + _sheet2_name.ToString()].Interior.Color = Color.SteelBlue;
                            xlWorksheet.Range["F" + _sheet2_name.ToString()].Font.Color = Color.White;
                            xlWorksheet.Range["F" + _sheet2_name.ToString()].Font.Bold = true;
                            xlWorksheet.Range["F" + _sheet2_name.ToString()].BorderAround();

                            xlWorksheet.Cells[_sheet2_details_header, "B"] = "Date Log";
                            xlWorksheet.Cells[_sheet2_details_header, "C"] = "Time In";
                            xlWorksheet.Cells[_sheet2_details_header, "D"] = "Time Out";
                            xlWorksheet.Cells[_sheet2_details_header, "E"] = "Late Minutes";
                            xlWorksheet.Cells[_sheet2_details_header, "F"] = "Undertime Minutes";

                            xlWorksheet.Range["B" + _sheet2_details_header.ToString()].Interior.Color = Color.LightBlue;
                            xlWorksheet.Range["B" + _sheet2_details_header.ToString()].Font.Bold = true;
                            xlWorksheet.Range["B" + _sheet2_details_header.ToString()].Font.Size = 10;
                            xlWorksheet.Range["B" + _sheet2_details_header.ToString()].BorderAround();
                            xlWorksheet.Range["C" + _sheet2_details_header.ToString()].Interior.Color = Color.LightBlue;
                            xlWorksheet.Range["C" + _sheet2_details_header.ToString()].Font.Bold = true;
                            xlWorksheet.Range["C" + _sheet2_details_header.ToString()].Font.Size = 10;
                            xlWorksheet.Range["C" + _sheet2_details_header.ToString()].BorderAround();
                            xlWorksheet.Range["D" + _sheet2_details_header.ToString()].Interior.Color = Color.LightBlue;
                            xlWorksheet.Range["D" + _sheet2_details_header.ToString()].Font.Bold = true;
                            xlWorksheet.Range["D" + _sheet2_details_header.ToString()].Font.Size = 10;
                            xlWorksheet.Range["D" + _sheet2_details_header.ToString()].BorderAround();
                            xlWorksheet.Range["E" + _sheet2_details_header.ToString()].Interior.Color = Color.LightBlue;
                            xlWorksheet.Range["E" + _sheet2_details_header.ToString()].Font.Bold = true;
                            xlWorksheet.Range["E" + _sheet2_details_header.ToString()].Font.Size = 10;
                            xlWorksheet.Range["E" + _sheet2_details_header.ToString()].BorderAround();
                            xlWorksheet.Range["F" + _sheet2_details_header.ToString()].Interior.Color = Color.LightBlue;
                            xlWorksheet.Range["F" + _sheet2_details_header.ToString()].Font.Bold = true;
                            xlWorksheet.Range["F" + _sheet2_details_header.ToString()].Font.Size = 10;
                            xlWorksheet.Range["F" + _sheet2_details_header.ToString()].BorderAround();

                            _details_cnt = 0;
                            _sheet2_name += 1;                            
                        }

                        _empid = int.Parse(_list.EmpID.ToString());

                        xlWorksheet = xlWorkbook.Worksheets["sheet1"];
                        xlWorksheet.Cells[cnt, "A"] = _list.DateLog;
                        xlWorksheet.Cells[cnt, "B"] = _list.EmpNo;
                        xlWorksheet.Cells[cnt, "C"] = _list.LastName;
                        xlWorksheet.Cells[cnt, "D"] = _list.FirstName;
                        xlWorksheet.Cells[cnt, "E"] = _list.MidName;
                        xlWorksheet.Cells[cnt, "F"] = _list.TimeIn;
                        xlWorksheet.Cells[cnt, "G"] = _list.Time_Out;
                        xlWorksheet.Cells[cnt, "H"] = _list.LateMinutes;
                        xlWorksheet.Cells[cnt, "I"] = _list.UndertimeMinutes;

                        xlWorksheet.Range["A" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["B" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["C" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["D" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["E" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["F" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["G" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["H" + cnt.ToString()].BorderAround();
                        xlWorksheet.Range["I" + cnt.ToString()].BorderAround();

                        xlWorksheet = xlWorkbook.Worksheets["sheet2"];
                        xlWorksheet.Cells[_sheet2_details, "B"] = _list.DateLog.Value.Date;
                        if (_list.TimeIn != null)
                        { xlWorksheet.Cells[_sheet2_details, "C"] = _list.TimeIn.Value.ToLongTimeString(); }
                        if (_list.Time_Out != null)
                        { xlWorksheet.Cells[_sheet2_details, "D"] = _list.Time_Out.Value.ToLongTimeString(); }
                        xlWorksheet.Cells[_sheet2_details, "E"] = _list.LateMinutes;
                        xlWorksheet.Cells[_sheet2_details, "F"] = _list.UndertimeMinutes;

                        xlWorksheet.Range["B" + _sheet2_details.ToString()].Font.Size = 10;
                        xlWorksheet.Range["B" + _sheet2_details.ToString()].BorderAround();
                        xlWorksheet.Range["C" + _sheet2_details.ToString()].Font.Size = 10;
                        xlWorksheet.Range["C" + _sheet2_details.ToString()].BorderAround();
                        xlWorksheet.Range["D" + _sheet2_details.ToString()].Font.Size = 10;
                        xlWorksheet.Range["D" + _sheet2_details.ToString()].BorderAround();
                        xlWorksheet.Range["E" + _sheet2_details.ToString()].Font.Size = 10;
                        xlWorksheet.Range["E" + _sheet2_details.ToString()].BorderAround();
                        xlWorksheet.Range["F" + _sheet2_details.ToString()].Font.Size = 10;
                        xlWorksheet.Range["F" + _sheet2_details.ToString()].BorderAround();

                        _details_cnt += 1;
                        _sheet2_details += 1;
                        cnt += 1;

                        SetProgressBarValue(prgBar.Value + 1);
                        Thread.Sleep(50);

                        decimal _pgbar = prgBar.Value;
                        decimal _pgmax = prgBar.Maximum;
                        decimal _res = (_pgbar / _pgmax) * 100;

                        SetLabelProgressValue((decimal.ToInt32(_res)).ToString() + "%");

                        if (prgBar.Value == _count)
                        {
                            Thread.Sleep(500);
                            DisplayLoadingPanel(false);
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("No record found!", "Message alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                excel.Visible = true;
                xlWorksheet = null;
                
                System.Threading.Thread.Sleep(1000);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                System.Threading.Thread.Sleep(1000); 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedIndex == 5)
            {
                txtEmp.Text = "";
                _empid = 0;

                Searchform _Searchform = new Searchform();
                _Searchform._searchby = searchby.CMS.EMPLOYEES;
                _Searchform.ShowDialog();

                CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
                if (_employee != null)
                {
                    txtEmp.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    _empid = _employee.Emp_ID;
                }
            }
            if (cmbFilter.SelectedIndex == 6)
            {
                txtEmp.Text = "";
                _empid = 0;
                _deptID = 0;

                Searchform _Searchform = new Searchform();
                _Searchform._searchby = searchby.HURIS.DEPARTMENT;
                _Searchform.ShowDialog();

                Department _department = _Searchform.ReturnSearchDepartment;
                if (_department != null)
                {
                    txtEmp.Text = _department.Dept_Name;
                    _deptID = _department.Dept_ID;
                    _empid = _department.Dept_ID;
                }
            }
        }

        void ShowOvertimeReport()
        {
            EmployeeReportViewerForm _report = new EmployeeReportViewerForm("OT");
            _report.panPrint.Visible = false;
            _report._filter = _filter;
            _report._empID = _empid;
            _report._datefrom = dtLogFrom.Value.Date;
            _report._dateto = dtLogTo.Value.Date;
            _report._deptID = _deptID;
            _report.BringToFront();
            _report.Show();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
