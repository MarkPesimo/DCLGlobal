using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.Global;
using CAL.Model;

using DCLGlobal.Master.Employee.Payroll;
using DCLGlobal.Reports.Employee;

namespace DCLGlobal.Master.Employee.Payroll
{
    public partial class PayrollDetailsInformationForm : Form
    {
        int _empid = 0;
        int _payroll_id = 0;
        int _detid = 0;
        int _payroll_group_id = 0;
        int _timesheet_id = 0;
        decimal _gross_amount = 0;
        DateTime _from;
        DateTime _to;
        int _compID = 0;
        int _index = 0;
        public PayrollDetailsInformationForm(int _Empid, int _Payrollid, int _timesheetID)
        {
            InitializeComponent();
            _empid = _Empid;
            _payroll_id = _Payrollid;
            _timesheet_id = _timesheetID;
        }

        private void PayrollDetailsInformationForm_Load(object sender, EventArgs e)
        {
            DisplayEmployeeControl();
            DisplayPayrollInformation();
            DisplayOvertime();
        }

        void DisplayEmployeeControl()
        {
            ClearPanel();
            var _control = new EmployeeInfoControl(_empid);
            AddControl(_control);
        }

        void ClearPanel()
        {
            panEmployee.Controls.Clear();
        }
        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            panEmployee.Controls.Add(_control);
        }

        void DisplayPayrollInformation()
        {
            iPayrollDetails _idetail = new IHOPSTransactionRepository.rPayrollDetails();
            DisplayDetail(_idetail.GetPayrollDet(_payroll_id, _empid));
        }

        void DisplayDetail(USP_GET_PAYROLL_DETAILSResult _detail)
        {
            try
            {
                if (_detail != null)
                {
                    _detid = _detail.PAYROLLDET_ID;
                    _empid = _detail.EMP_ID;

                    this.Text = "PD : " + _detail.EMP_NAME;

                    _timesheet_id = int.Parse(_detail.TIMESHEET_ID.ToString());
                    _payroll_group_id = int.Parse(_detail.PAYROLLTYPE_ID.ToString());
                    lblRegularPay.Text = decimal.Parse(_detail.REGULAR_PAY.ToString()).ToString("N", new CultureInfo("en-US"));

                    lblOvertime.Text = decimal.Parse(_detail.OT_PAY.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblAdjustmentTaxable.Text = decimal.Parse(_detail.ADJUSTMENT_TAXABLE.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblAdjustmentNonTaxable.Text = decimal.Parse(_detail.ADJUSTMENT_NT.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblTotalAdjustment.Text = decimal.Parse(_detail.TOTAL_ADJUSTMENT.ToString()).ToString("N", new CultureInfo("en-US"));

                    lblLates.Text = decimal.Parse(_detail.LATE_DEDUCTION.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblUndertime.Text = decimal.Parse(_detail.UNDERTIME_DEDUCTION.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblAbsents.Text = decimal.Parse(_detail.ABSENT_DEDUCTION.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblDeductions.Text = decimal.Parse(_detail.TOTAL_TARDINESS.ToString()).ToString("N", new CultureInfo("en-US"));

                    lblGrossPay.Text = decimal.Parse(_detail.GROSS_AMOUNT.ToString()).ToString("N", new CultureInfo("en-US"));

                    lblSSS.Text = decimal.Parse(_detail.SSS.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblPhilhealth.Text = decimal.Parse(_detail.PHILHEALTH.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblPagibig.Text = decimal.Parse(_detail.PAGIBIG.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblTax.Text = decimal.Parse(_detail.TAX.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblTotalGovernment.Text = decimal.Parse(_detail.TOTAL_MANDATED.ToString()).ToString("N", new CultureInfo("en-US"));

                    lblSSSLoan.Text = decimal.Parse(_detail.SSS_LOAN.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblPagibigLoan.Text = decimal.Parse(_detail.PAGIBIG_LOAN.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblWNSloan.Text = decimal.Parse(_detail.WNS_LOAN.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblWNScontri.Text = decimal.Parse(_detail.WNS_CONTRIBUTION.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblCTBCloan.Text = decimal.Parse(_detail.CTBC_LOAN.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblHMO.Text = decimal.Parse(_detail.HMO.ToString()).ToString("N", new CultureInfo("en-US"));

                    lblOtherDeductions.Text = decimal.Parse(_detail.OTHER_DEDUCTION.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblTotalDeductions.Text = decimal.Parse(_detail.TOTAL_DEDUCTION.ToString()).ToString("N", new CultureInfo("en-US"));
                    lblNet.Text = decimal.Parse(_detail.NET.ToString()).ToString("N", new CultureInfo("en-US"));
                }

                if (_payroll_group_id == 6 || _payroll_group_id == 9)
                {
                    if (_detail.PAYROLL_STATUS == true) { reprocess_btn.Enabled = false; } else { reprocess_btn.Enabled = true; }
                }
                else
                { reprocess_btn.Enabled = false; }

            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void TabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            try
            {
                if (e.NewTab.ToString() == "Adjustments")
                {
                    panAdj.Controls.Clear();
                    var _control = new EmployeePayrollAdjustmentControl(_empid, _from, _to, _compID, _payroll_id);
                    _control.Dock = DockStyle.Fill;
                    panAdj.Controls.Add(_control);
                }
                else if (e.NewTab.ToString() == "Deductions")
                {
                    panDed.Controls.Clear();
                    var _control = new EmployeePayrollDeductionControl(_empid, _from, _to, _compID, _payroll_id);
                    _control.Dock = DockStyle.Fill;
                    panDed.Controls.Add(_control);
                }
                else if (e.NewTab.ToString() == "Timesheet")
                {
                    iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
                    DisplayLogs();
                }
            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        void DisplayLogs()
        {
            try
            {
                lsvAttendance.Items.Clear();

                iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
                iAttendance _iattendance = new HURISTransactionRepository.rAttendance();

                TimeSheet_HD _timesheet = _itimesheet.GetTimesheet(_timesheet_id);
                List<SP_VIEWATTENDANCESummaryResult> _attendances = _iattendance.GetEmployeeAttendances("PER_EMPLOYEE", _timesheet.RangeFrom.Value.Date, _timesheet.RangeTo.Value.Date, _empid.ToString());

                foreach (SP_VIEWATTENDANCESummaryResult _list in _attendances)
                {
                    ListViewItem _item = new ListViewItem(_list.ID.ToString());
                   
                    if (_list.DateLog == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_list.DateLog.Value.ToShortDateString()); }

                    _item.SubItems.Add(_list.Shift);         //shift

                    if (_list.TimeIn == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_list.TimeIn.Value.ToShortTimeString()); }

                    if (_list.Time_Out == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_list.Time_Out.Value.ToShortTimeString()); }

                    if (_list.HoursWorked == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_list.HoursWorked.ToString()); }

                    if (_list.Remarks != null)
                    {
                        _index = _list.Remarks.IndexOf("~");
                    }
                    else
                    {
                        _index = 0;
                    }

                    if (_index <= 0)
                    {
                        _item.SubItems.Add(_list.Remarks);
                    }
                    else
                    {
                        _item.SubItems.Add(_list.Remarks.Substring(0, _index));
                    }

                    lsvAttendance.Items.Add(_item);
                }
                
                
            }

            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        void DisplayOvertime()
        {
            try
            {
                iOvertime _iovertime = new HURISTransactionRepository.rOvertime();
                iTimeSheet _itimesheet = new HURISTransactionRepository.rTimesheet();
                TimeSheet_OT _ot = _itimesheet.GetTimesheetOT(_empid, _timesheet_id);
                if (_ot != null)
                {
                    lsvOT.Items.Clear();
                    //lblRegularPay OT / Saturday OT
                    DisplaytoOTView("REG_OT", "1", _ot.RegOTTHrs.ToString(), _iovertime.ComputeOvertime("REGOT", _timesheet_id, _empid).ToString());
                    DisplaytoOTView("ND_OT", "2", _ot.NightDiffOTHrs.ToString(), _iovertime.ComputeOvertime("NDOT", _timesheet_id, _empid).ToString());

                    DisplaytoOTView("SAT_OT", "3", _ot.SatOTHrs.ToString(), _iovertime.ComputeOvertime("SATOT", _timesheet_id, _empid).ToString());

                    //REST DAY OT
                    DisplaytoOTView("RD_OT", "4", _ot.SunOTHrs.ToString(), _iovertime.ComputeOvertime("SUNOT", _timesheet_id, _empid).ToString());
                    DisplaytoOTView("RD_OT_ND", "5", _ot.SunNDOTHrs.ToString(), _iovertime.ComputeOvertime("SUN_ND", _timesheet_id, _empid).ToString());

                    //SPECIAL HOLIDAY OT
                    DisplaytoOTView("SH_OT", "6", _ot.HolOTHours.ToString(), _iovertime.ComputeOvertime("HOLOT", _timesheet_id, _empid).ToString());
                    DisplaytoOTView("SH_OT_ND", "7", _ot.SpecialNDOt.ToString(), _iovertime.ComputeOvertime("NDHOLSPE", _timesheet_id, _empid).ToString());

                    //LEGAL HOLIDAY OT
                    DisplaytoOTView("LH_OT", "8", _ot.LegalOTHours.ToString(), _iovertime.ComputeOvertime("LEGOT", _timesheet_id, _empid).ToString());
                    DisplaytoOTView("LH_OT_ND", "9", _ot.LegalNDOt.ToString(), _iovertime.ComputeOvertime("NDHOLLEG", _timesheet_id, _empid).ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplaytoOTView(string _type, string _cnt, string _othours, string _otamount)
        {
            ListViewItem _item = new ListViewItem(_cnt);
            _item.SubItems.Add(_type);
            _item.SubItems.Add(_othours.ToString());
            decimal _amount = decimal.Parse(_otamount);
            _item.SubItems.Add(_amount.ToString("N", new CultureInfo("en-US")));
            lsvOT.Items.Add(_item);
        }

        private void payslip_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("View payslip?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            EmployeeReportViewerForm _payrollreport = new EmployeeReportViewerForm("PAYSLIP");
            _payrollreport._payrollID = _payroll_id;
            _payrollreport._empID = _empid;
            _payrollreport._category = "ALL";
            _payrollreport.BringToFront();
            _payrollreport.Show();
        }
    }
}
