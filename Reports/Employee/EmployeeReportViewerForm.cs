using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Reports.Employee
{
    public partial class EmployeeReportViewerForm : Form
    {
        string _reporttype;
        public string _company;
        public int _num;
        public int _empID;
        public string _filter;
        public DateTime _datefrom;
        public DateTime _dateto;
        public int _deptID;

        public int _loanTypeID;
        public bool _loanStat;
        public string _DateRange;

        public int _payrollID;
        public int _compID;
        public int _sortfrom;
        public int _sortto;
        public string _view_type;
        public string _category;
        string _compcode = "";
        int _lenAccountNo = 0;

        public bool _by_loantype;
        public bool _by_date;
        public bool _by_employee;
        public bool _by_status;
        public string _loanstatus;
        public bool _by_as_of_date;
        public DateTime _asofdate;
        public bool _per_month;
        public DateTime _month_year;

        public string _employeename;

        public EmployeeReportViewerForm(string _ReportType)
        {
            InitializeComponent();
            _reporttype = _ReportType;
        }

        private void EmployeeReportViewerForm_Load(object sender, EventArgs e)
        {
            DisplayReport();
        }

        void DisplayReport()
        {
            ConnectionControl _connectioncontrol = new ConnectionControl();
            ReportDocument _reportdoc = new ReportDocument();

            try
            {
                if (_reporttype == "BIRTHDAY CELEBRANT")
                {
                    _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "HRIS Birthday Celebrants.rpt");
                    //_reportdoc.DataDefinition.RecordSelectionFormula = "MONTH({Employee.Birthday}) = " + _num + " and ISNULL({Employee.Dateresigned}) = true and {Employee.ActiveInactive} = 1 and {Employee.CompanyCode} = " + "'" + _company + "'" ;
                    _reportdoc.DataDefinition.FormulaFields["Filter"].Text = "'" + _company + "'";
                    _reportdoc.DataDefinition.FormulaFields["BdayMonth"].Text = "" + _num + "";

                    goto Report_Path;
                }
                else if (_reporttype == "YEARS IN SERVICE")
                {
                    _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "Years in Service.rpt");
                    _reportdoc.DataDefinition.FormulaFields["Filter"].Text = "'" + _company + "'";
                    _reportdoc.DataDefinition.FormulaFields["ServiceYear"].Text = "" + _num + "";
                }
                else if (_reporttype == "LEAVE MONITORING")
                {
                    _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "Leave Monitoring.rpt");
                    _reportdoc.DataDefinition.FormulaFields["Filter"].Text = "'" + _company + "'";
                    _reportdoc.DataDefinition.FormulaFields["ServiceYear"].Text = "" + _num + "";
                }
                else if (_reporttype == "EMPLOYMENT STATUS")
                {
                    _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "HRIS Employment Status.rpt");
                    _reportdoc.DataDefinition.FormulaFields["CompanyCode"].Text = "'" + _company + "'";
                    if (_company == "All")
                    { _reportdoc.DataDefinition.RecordSelectionFormula = "{Employee.ActiveInactive} = 1"; }
                    else { _reportdoc.DataDefinition.RecordSelectionFormula = "{Employee.ActiveInactive} = 1 and {Employee.CompanyCode} = " + "'" + _company + "'"; }
                }
                else if (_reporttype == "Reimbursable OT")
                {
                    _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "ReImbursableOT.rpt");
                    _reportdoc.DataDefinition.FormulaFields["EMPID"].Text = "" + _empID + "";
                }
                else if (_reporttype == "ZIPS ATTENDANCE")
                {
                    _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "ZiPS Attendance");
                    _reportdoc.SetParameterValue("@EMPID", _empID);
                    _reportdoc.SetParameterValue("@FROM", _datefrom);
                    _reportdoc.SetParameterValue("@TO", _by_date);
                    _reportdoc.DataDefinition.FormulaFields["EmployeeName"].Text = "'" + _employeename + "'";
                }
                else if (_reporttype == "LOAN REPORT")
                {
                    //if (_filter == "All")
                    //{                   

                    if (_by_employee == true)
                    {
                        _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "Loan Report Per Emp.rpt");
                        //_reportdoc.DataDefinition.FormulaFields["EMPID"].Text = "" + _empID + "";
                        //_reportdoc.DataDefinition.FormulaFields["LoanStat"].Text = "" + _loanStat + "";
                        //_reportdoc.DataDefinition.FormulaFields["LoanTypeID"].Text = "" + _loanTypeID + "";
                        //_reportdoc.DataDefinition.FormulaFields["byStatus"].Text = "" + _by_status + "";
                    }
                    else
                    {
                        if (_loanTypeID == 6)
                        { _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "Loan Report - Contri.rpt"); }
                        else
                        { _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "Loan Report - As of Date.rpt"); }
                    }

                    _reportdoc.SetParameterValue("@BY_LOANTYPE", _by_loantype);
                    _reportdoc.SetParameterValue("@LOAN_TYPE_ID", _loanTypeID);
                    _reportdoc.SetParameterValue("@BY_DATE", _by_date);
                    _reportdoc.SetParameterValue("@FROM_DATE", _datefrom);
                    _reportdoc.SetParameterValue("@TO_DATE", _dateto);
                    _reportdoc.SetParameterValue("@BY_STATUS", _by_status);
                    _reportdoc.SetParameterValue("@STATUS", _loanstatus);
                    _reportdoc.SetParameterValue("@PER_EMPLOYEE", _by_employee);
                    _reportdoc.SetParameterValue("@EMP_ID", _empID);
                    _reportdoc.SetParameterValue("@AS_OF_DATE", _by_as_of_date);
                    _reportdoc.SetParameterValue("@DATE", _asofdate);
                    _reportdoc.DataDefinition.FormulaFields["LoanTypeID"].Text = "" + _loanTypeID + "";
                    _reportdoc.SetParameterValue("@PER_MONTH", _per_month);
                    _reportdoc.SetParameterValue("@MONTH_YEAR", _month_year);
                    //_reportdoc.DataDefinition.FormulaFields["Filter"].Text = "'" + _filter + "'";
                    //_reportdoc.DataDefinition.FormulaFields["LoanStat"].Text = "" + _loanStat + "";
                    //_reportdoc.DataDefinition.FormulaFields["LoanTypeID"].Text = "" + _loanTypeID + "";
                    //_reportdoc.DataDefinition.FormulaFields["dateFrom"].Text = "#" + _datefrom.Date + "#";
                    //_reportdoc.DataDefinition.FormulaFields["dateTo"].Text = "#" + _dateto.Date + "#";
                    //_reportdoc.DataDefinition.FormulaFields["DateRange"].Text = "'" + _DateRange + "'";

                    //    goto Report_Path;
                    //}
                    //else
                    //{
                    //    _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "Loan Report Per Emp.rpt");
                    //    _reportdoc.DataDefinition.FormulaFields["EMPID"].Text = "" + _empID + "";
                    //    _reportdoc.DataDefinition.FormulaFields["LoanStat"].Text = "" + _loanStat + "";
                    //    _reportdoc.DataDefinition.FormulaFields["LoanTypeID"].Text = "" + _loanTypeID + "";
                    //}

                }
                else if (_reporttype == "OT")
                {
                    if (_filter == "ALL")
                    { _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "OvertimeSummary.rpt"); }
                    else if (_filter == "SMS")
                    { _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "OvertimeSummarySMS.rpt"); }
                    else if (_filter == "MRA")
                    { _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "OvertimeSummaryMRA.rpt"); }
                    else if (_filter == "MOC")
                    { _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "OvertimeSummaryMOC.rpt"); }
                    else if (_filter == "PER_EM")
                    {
                        _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "OvertimeSummaryPerEmp.rpt");
                        _reportdoc.DataDefinition.FormulaFields["EmpID"].Text = "" + _empID + "";
                    }
                    else if (_filter == "PER_DEPT")
                    {
                        _reportdoc.Load(DCLSystemConfiguration.HURIS.Reportpath + "OvertimeSummaryPerDept.rpt");
                        _reportdoc.DataDefinition.FormulaFields["DepartmentID"].Text = "" + _deptID + "";
                    }

                    _reportdoc.DataDefinition.FormulaFields["dateFrom"].Text = "#" + _datefrom.Date + "#";
                    _reportdoc.DataDefinition.FormulaFields["dateTo"].Text = "#" + _dateto.Date + "#";
                    _reportdoc.SetDatabaseLogon(DCLSystemConfiguration.HURIS.Username, _connectioncontrol.Dcrypt(DCLSystemConfiguration.HURIS.Password));

                }
                else if (_reporttype == "JOURNAL ENTRY")
                {
                    _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "Journal Entry.rpt");

                    _reportdoc.SetParameterValue("@PAYROLL_ID", _payrollID);
                    _reportdoc.SetParameterValue("@COMP_ID", _compID);
                    _reportdoc.SetParameterValue("@SORT_FROM", _sortfrom);
                    _reportdoc.SetParameterValue("@SORT_TO", _sortto);
                    _reportdoc.SetParameterValue("@REPORT_TYPE", _view_type);

                    goto Report_Path;
                }
                else if (_reporttype == "PAYSLIP")
                {

                    if (_category == "ALL")
                    {

                        if (_payrollID > 299)
                        {
                            _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "PayslipNew2.rpt");
                        }
                        else
                        {
                            _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "Payslipnew.rpt");
                        }
                        _reportdoc.DataDefinition.FormulaFields["Payroll_ID"].Text = "" + _payrollID + "";
                        _reportdoc.DataDefinition.FormulaFields["CompanyCode"].Text = "'" + _compcode + "'";
                        _reportdoc.DataDefinition.FormulaFields["EmpID"].Text = "" + _empID + "";

                        goto Report_Path;
                    }
                    else
                    {
                        _reportdoc.Load(DCLSystemConfiguration.IHOPS.Reportpath + "PayslipWithAccountAndNoAccount.rpt");
                        _reportdoc.DataDefinition.FormulaFields["Payroll_ID"].Text = "" + _payrollID + "";
                        _reportdoc.DataDefinition.FormulaFields["CompanyCode"].Text = "'" + _compcode + "'";
                        _reportdoc.DataDefinition.FormulaFields["LenAccountNo"].Text = "" + _lenAccountNo + "";

                        goto Report_Path;
                    }
                }

                    Report_Path:                
                string _password = _connectioncontrol.Dcrypt(DCLSystemConfiguration.HURIS.Password);
                GlobalToolsControl.Global.SetReportDataSource(DCLSystemConfiguration.HURIS.Servername, DCLSystemConfiguration.HURIS.Databasename, DCLSystemConfiguration.HURIS.Username, _password, _reportdoc);

                CRViewer.ReportSource = _reportdoc;
                CRViewer.Refresh();
                CRViewer = null;
            }        

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
