using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Threading;
using System.Data.OleDb;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Reports;
using DCLGlobal.Transaction.Request;
using System.Globalization;

namespace DCLGlobal.Classes
{
    public class ReportControl
    {
        public class CMS
        {
            ReportControl _close = new ReportControl();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            object objOpt = Type.Missing;

            public void PrintPOEALAC(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'POEA LAC', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\SMS  POEA - LAC.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    excel.Cells[1, 2] = "From " + _from.ToShortDateString() + " to " + _to.ToShortDateString();
                    excel.Cells[2, 2] = _principal;
                    excel.Cells[1, 8] = LoginUser.username;
                    excel.Cells[3, 8] = _position;

                    ws.Range["A7"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintAntiPiracy(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'ANTI PIRACY', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Anti-Piracy.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    string _company = "";
                    if (LoginUser.companycode == "SMS") { _company = "SEALANES MARINE SERVICES, INC."; }
                    else if (LoginUser.companycode == "MRA") { _company = "MANPOWER RESOURCES OF ASIA, INC."; }
                    else if (LoginUser.companycode == "MOC") { _company = "MRA OFFSHORE CORPORATION"; }
                    excel.Cells[5, "B"] = _company;

                    excel.Cells[6, 1] = _principal;
                    ws.Range["A9"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    // _close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    // _close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintListOfAging(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'LIST OF AGING', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\List of Aging.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    excel.Cells[1, 1] = _principal;
                    ws.Range["A5"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintPDOSReportNew()
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC USP_C_GET_PDOS ";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\PDOS Template.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    string _company = "";
                    if (LoginUser.companycode == "SMS") { _company = "SEALANES MARINE SERVICES, INC."; }
                    else if (LoginUser.companycode == "MRA") { _company = "MANPOWER RESOURCES OF ASIA, INC."; }
                    else if (LoginUser.companycode == "MOC") { _company = "MRA OFFSHORE CORPORATION"; }
                    excel.Cells[4, 3] = _company;
                    ws.Range["A10"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintListOfContacts(int _principalid, string _principal)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_C_REPORT_CREWLIST " + _principalid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Crew Personal Data.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    excel.Cells[2, 2] = _principal;
                    ws.Range["B6"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintDebriefingSummaryReport(int _principalid, string _principal, DateTime _from)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_C_DEBRIEFING_REPORT_SUMMARY " + _principalid + ", '" + _from.ToShortDateString() + "', " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debreifing Report Summary.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    excel.Cells[2, 1] = _principal;

                    _con.Open(_conn);
                    //_rstmp = _con.Execute(_sql, out objOpt);
                    //ws.Range["A6", objOpt].CopyFromRecordset(_rstmp);

                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["A6"].CopyFromRecordset(_rstmp);

                    ws = (Worksheet)wb.Worksheets[2];

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'ACCOMODATION', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B3"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'FOOD', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B5"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'SALARY', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B7"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'SAFETY', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B9"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'WORKING SCHEDULE', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B11"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'SUBORDINATES', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B15"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'CO-WORKERS', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B16"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'SUPERIORS', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B17"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'WORKING GEAR', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B18"].CopyFromRecordset(_rstmp);

                    _sql = "EXEC SP_C_DEBRIEFING_REPORT_STATISTICS " + _principalid + ", '" + _from.ToShortDateString() + "', 'OVERALL', " + LoginUser.userid + "";
                    _rstmp = _con.Execute(_sql, out objOpt);
                    ws.Range["B20"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintDebriefing(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'DEBRIEFING', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Report.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    excel.Cells[1, 1] = _from.ToString("MMM", CultureInfo.InvariantCulture) + " " + _from.Year;
                    ws.Range["A3"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintEmergencyReport(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'EMERGENCY', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\EMERGENCY LIST.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    ws.Range["B2"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    // _close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    // _close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintAMOSUP(int _principalid, int _vesselid)
            {
                try
                {
                    GlobalReportViewerform _viewer = new GlobalReportViewerform("AMOSUP");
                    _viewer._principalid = _principalid;
                    _viewer._vesselid = _vesselid;
                    _viewer.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintPDOSReport(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'PDOS', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\PDOS REPORT.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    string _company = "";
                    if (LoginUser.companycode == "SMS") { _company = "SEALANES MARINE SERVICES, INC."; }
                    else if (LoginUser.companycode == "MRA") { _company = "MANPOWER RESOURCES OF ASIA, INC."; }
                    else if (LoginUser.companycode == "MOC") { _company = "MRA OFFSHORE CORPORATION"; }

                    excel.Cells[9, 3] = _company;
                    ws.Range["A13"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    // _close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintDeploymentReport(DateTime _from, DateTime _to, int _principalid, int _vesselid, int _positionid, string _principal, string _position)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_GENERATE_SMS_REPORT 'DEPLOYMENT', " + LoginUser.accountid + ", '" + LoginUser.companycode + "', '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "', " + _principalid + ", " + _vesselid + ", " + _positionid + ", " + LoginUser.userid + "";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\DEPLOYMENT REPORT.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    string _company = "";
                    if (LoginUser.companycode == "SMS") { _company = "SEALANES MARINE SERVICES, INC."; }
                    else if (LoginUser.companycode == "MRA") { _company = "MANPOWER RESOURCES OF ASIA, INC."; }
                    else if (LoginUser.companycode == "MOC") { _company = "MRA OFFSHORE CORPORATION"; }

                    excel.Cells[2, 1] = _company;
                    excel.Cells[3, 1] = "DEPLOYMENT REPORT - " + _from.ToString("MMM", CultureInfo.InvariantCulture) + " " + _from.Year;
                    ws.Range["A5"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    // _close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    // _close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintMedicalReport(DateTime _from, DateTime _to)
            {
                ADODB.Recordset _rstmp = new ADODB.Recordset();
                ADODB.Connection _con = new ADODB.Connection();

                try
                {
                    Workbook wb;
                    Worksheet ws;
                    ConnectionControl _control = new ConnectionControl();

                    string _conn = "Data Source = " + DCLSystemConfiguration.CMS.Servername + "; Initial Catalog = " + DCLSystemConfiguration.CMS.Databasename + "; User ID = " + DCLSystemConfiguration.CMS.Username + "; Password = " + _control.Dcrypt(DCLSystemConfiguration.CMS.Password) + "; Pooling = false; Connect Timeout = 0;";
                    string _sql = "EXEC SP_C_MEDICAL_REPORT '" + _from.ToShortDateString() + "', '" + _to.ToShortDateString() + "'";

                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\MEDICAL REPORT.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                    ws = (Worksheet)wb.Worksheets[1];

                    _con.Open(_conn);
                    _rstmp = _con.Execute(_sql, out objOpt);

                    excel.Cells[2, 1] = "Date Range : " + _from.ToShortDateString() + " to " + _to.ToShortDateString();
                    ws.Range["A4"].CopyFromRecordset(_rstmp);

                    _rstmp = null;
                    excel.Visible = true;
                    //_close.CloseExcel(excel);
                }
                catch (Exception ex)
                {
                    _rstmp = null;
                    excel.Quit();
                    //_close.CloseExcel(excel);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void PrintRFPSchedule(int _vesselid)
            {
                //try
                //{
                //    Workbook wb;
                //    Worksheet ws;

                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);


                //    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"TRANSACTION\RFP Processing.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    ws = (Worksheet)wb.Worksheets[1];

                //    iCMSInquiry _irfp = new CMSTransactionRepository.rCMSInquiry();

                //    int _cnt = 5;
                //    List<USP_C_GENERATE_RFPResult> _rfps = _irfp.GetRFPInquiry(_vesselid);
                //    if (_rfps != null)
                //    {
                //        foreach (USP_C_GENERATE_RFPResult _list in _rfps)
                //        {
                //            excel.Cells[_cnt, 1] = _list.ETD.Value.ToShortDateString();
                //            excel.Cells[_cnt, 2] = _list.CrewName;
                //            excel.Cells[_cnt, 3] = _list.Position;
                //            excel.Cells[_cnt, 4] = _list.HIRING_STATUS;
                //            excel.Cells[_cnt, 5] = _list.SALARY;
                //            excel.Cells[_cnt, 6] = _list.PrincipalDescription;
                //            excel.Cells[_cnt, 7] = _list.SITE_VESSEL;
                //            excel.Cells[_cnt, 8] = _list.MEDICAL_VALIDITY;
                //            excel.Cells[_cnt, 9] = _list.PHILHEALTH_VALIDITY;
                //            excel.Cells[_cnt, 10] = _list.OEC_NO;
                //            excel.Cells[_cnt, 11] = _list.REMARKS;

                //            _cnt++;
                //        }

                //    }

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

            public void PrintAPASMonthlyReport(DateTime _from)
            {
                //try
                //{
                //    Workbook wb;
                //    Worksheet ws;

                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);


                //    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"TRANSACTION\APAS Monthly.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    ws = (Worksheet)wb.Worksheets[1];

                //    iAPAS _iapas = new CMSTransactionRepository.rAPAS();

                //    int _cnt = 6;
                //    List<USP_C_APAS_MONTHLY_REPORTResult> _attendance = _iapas.GetAPAsMonthlyReport(_from);
                //    if (_attendance != null)
                //    {
                //        excel.Cells[2, 1] = _from.ToString("MMM", CultureInfo.InvariantCulture) + " " + _from.Year + " - Report";
                //        foreach (USP_C_APAS_MONTHLY_REPORTResult _list in _attendance)
                //        {
                //            excel.Cells[_cnt, 1] = _list.Row;
                //            excel.Cells[_cnt, 2] = _list.APAS_CERTIFICATE;
                //            excel.Cells[_cnt, 3] = _list.APAS_SCHEDULE;
                //            excel.Cells[_cnt, 4] = _list.PrincipalDescription;
                //            excel.Cells[_cnt, 5] = _list.Lastname;
                //            excel.Cells[_cnt, 6] = _list.Firstname;
                //            excel.Cells[_cnt, 7] = _list.Middlename;

                //            _cnt++;
                //        }
                //    }

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}            
            }

            public void PrintAPASSchedule(DateTime _from, DateTime _to)
            {
                //try
                //{
                //    Workbook wb;
                //    Worksheet ws;

                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);


                //    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"TRANSACTION\APAS.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    ws = (Worksheet)wb.Worksheets[1];

                //    iAPAS _iapas = new CMSTransactionRepository.rAPAS();

                //    int _cnt = 6;
                //    List<USP_C_APAS_ATTENDANCE_REPORTResult> _attendance = _iapas.GetAPASAttendanceReport(_from, _to);
                //    if (_attendance != null)
                //    {
                //        foreach (USP_C_APAS_ATTENDANCE_REPORTResult _list in _attendance)
                //        {
                //            excel.Cells[_cnt, 1] = _list.Row;
                //            excel.Cells[_cnt, 2] = _list.PrincipalDescription;
                //            excel.Cells[_cnt, 3] = _list.VesselDescription;
                //            excel.Cells[_cnt, 4] = _list.Lastname + ", " + _list.Firstname + " " + _list.Middlename;
                //            excel.Cells[_cnt, 5] = _list.Position;
                //            excel.Cells[_cnt, 6] = _list.HireStatus;
                //            excel.Cells[_cnt, 7] = _list.EstimateDispatchDate;
                //            excel.Cells[_cnt, 8] = _list.Jobsite;

                //            _cnt++;
                //        }

                //    }

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }

            public void PrintAPASAttendee(DateTime _from, DateTime _to)
            {
                //try
                //{
                //    Workbook wb;
                //    Worksheet ws;

                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);


                //    wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"TRANSACTION\APAS Attendees.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    ws = (Worksheet)wb.Worksheets[1];

                //    iAPAS _iapas = new CMSTransactionRepository.rAPAS();

                //    int _cnt = 6;
                //    List<USP_C_APAS_ATTENDANCE_REPORTResult> _attendance = _iapas.GetAPASAttendanceReport(_from, _to);
                //    if (_attendance != null)
                //    {
                //        foreach (USP_C_APAS_ATTENDANCE_REPORTResult _list in _attendance)
                //        {
                //            excel.Cells[_cnt, 1] = _list.Row;
                //            excel.Cells[_cnt, 2] = _list.PrincipalDescription;
                //            excel.Cells[_cnt, 3] = _list.VesselDescription;
                //            excel.Cells[_cnt, 4] = _list.Lastname + ", " + _list.Firstname + " " + _list.Middlename;
                //            excel.Cells[_cnt, 5] = _list.Position;
                //            excel.Cells[_cnt, 6] = _list.HireStatus;
                //            excel.Cells[_cnt, 7] = _list.EstimateDispatchDate;
                //            excel.Cells[_cnt, 8] = _list.Jobsite;
                //            excel.Cells[_cnt, 9] = _list.APAS_CERTIFICATE;

                //            _cnt++;
                //        }

                //    }

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }

            public void PrintCOCA(int _crewstatusid, int _crewid, string _applicantid)
            {
                //iContract _icontract = new CMSTransactionRepository.rContract(); 

                //try
                //{
                //    Workbook wb;
                //    Worksheet ws;

                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                //    if (LoginUser.companycode == "SMS")
                //    {
                //        wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"COCA\SMS COCA NEW.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    }
                //    else if (LoginUser.companycode == "MRA")
                //    {
                //        wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"COCA\MRA COCA NEW.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    }
                //    else
                //    {
                //        wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"COCA\MOC COCA NEW.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    }

                //    iU.Undo();

                //    ws = (Worksheet)wb.Worksheets[1];

                //    int _positionid = 0;
                //    CrewRecord _crewrecord = _icontract.GetCrewRecord(_crewstatusid);
                //    if (_crewrecord != null)
                //    {
                //        _positionid = _crewrecord.PositionID;

                //        excel.Cells[2, 11] = _crewrecord.DispatchDate.Value.Date;
                //        excel.Cells[8, 11] = _crewrecord.DispatchDate.Value.Date;
                //        excel.Cells[8, 7] = _crewrecord.Principal.PrincipalDescription + "/" + _crewrecord.Vessel.VesselDescription;

                //        excel.Cells[10, 1] = _crewrecord.Position.PositionName;                
                //        excel.Cells[10, 7] = _crewrecord.ContractDuration;                
                //    }

                //    iCrew _icrew = new CMSFilesRepository.rCrew();
                //    Crew _crew = _icrew.GetCrew(_crewid);
                //    if (_crew != null)
                //    {
                //        if (_crew.HIRE_STATUS == 1) { excel.Cells[2, 9] = "NEW HIRE"; }
                //        else { excel.Cells[2, 9] = "REHIRE"; }

                //        excel.Cells[8, 1] = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                //        excel.Cells[10, 10] = _crew.CivilStatus;

                //        excel.Cells[58, 11] = _crew.CivilStatus;
                //        excel.Cells[58, 12] = _crew.CivilStatus;
                //    }

                //    iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
                //    CrewDocument _crewdocument = _icrewdocument.GetCrewDocument(15, _applicantid, "P");                 //PHILHEALTH NO
                //    if (_crewdocument != null) { excel.Cells[12, 1] = _crewdocument.Number;}

                //    _crewdocument = new CrewDocument();
                //    _crewdocument = _icrewdocument.GetCrewDocument(13, _applicantid, "P");                              //tin NO
                //    if (_crewdocument != null) { excel.Cells[12, 5] = _crewdocument.Number; }

                //    _crewdocument = new CrewDocument();
                //    _crewdocument = _icrewdocument.GetCrewDocument(12, _applicantid, "P");                              //SSS NO
                //    if (_crewdocument != null) { excel.Cells[12, 8] = _crewdocument.Number; }

                //    _crewdocument = new CrewDocument();
                //    _crewdocument = _icrewdocument.GetCrewDocument(17, _applicantid, "P");                              //PAGIBIG NO
                //    if (_crewdocument != null) { excel.Cells[12, 10] = _crewdocument.Number; }

                //    //GET COMPUTATION AND ALLOWANCE
                //    iCoca _icoca = new CMSFilesRepository.rCoca();
                //    int _begin = 14;
                //    int _beginallotte = 17;
                //    List<CREWSTATUS_COMPENSATION> _addons = _icoca.GetCrewStatusAddOns(_crewstatusid, false);
                //    if (_addons != null)
                //    {
                //        foreach (CREWSTATUS_COMPENSATION _x in _addons)
                //        {
                //            excel.Cells[_begin, 2] = _x.ADDON.DESCRIPTION;

                //            if ( bool.Parse(_x.FOR_COMPUTATION.ToString())) { excel.Cells[_begin, 6] = _x.AMOUNT; }
                //            else { excel.Cells[_begin, 5] = _x.AMOUNT; }

                //            _beginallotte = _beginallotte + 1;
                //            _begin = _begin + 1;
                //        }               
                //    }

                //    _addons = new List<CREWSTATUS_COMPENSATION>();
                //    _addons = _icoca.GetCrewStatusAddOns(_crewstatusid, true);
                //    excel.Cells[_begin, 2] = "Other Benefits";
                //    _begin = _begin + 1;
                //    if (_addons != null)
                //    {
                //        foreach (CREWSTATUS_COMPENSATION _x in _addons)
                //        {
                //            excel.Cells[_begin, 2] = _x.ADDON.DESCRIPTION;

                //            if (bool.Parse(_x.FOR_COMPUTATION.ToString())) { excel.Cells[_begin, 6] = _x.AMOUNT; }
                //            else { excel.Cells[_begin, 5] = _x.AMOUNT; }

                //            _begin = _begin + 1;
                //        }
                //    }

                //    List<CrewStatus_Allottee> _allottee = new List<CrewStatus_Allottee>();
                //    _begin = 14;
                //    _allottee = _icoca.GetCrewstatusAllottee(_crewstatusid);
                //    if (_allottee != null)
                //    {
                //        foreach (CrewStatus_Allottee _x in _allottee)
                //        {
                //            excel.Cells[_begin, 8] = _x.Description;
                //            excel.Cells[_begin, 11] = _x.Amount.ToString();

                //            _begin = _begin + 1;
                //        }
                //    }
                //    //GET COMPUTATION AND ALLOWANCE

                //    List<CREWSTATUS_COCA> _coca = _icoca.GetCrewStatusCOCA(_crewstatusid);
                //    if (_coca != null)
                //    {
                //        foreach (CREWSTATUS_COCA _list in _coca)
                //        {
                //            if (_list.AlloteeType == 1)
                //            {
                //                if (_list.Self_allotee)
                //                { 
                //                    excel.Cells[29, 3] = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                //                    excel.Cells[30, 3] = "SELF ALLOTEE";
                //                    excel.Cells[31, 3] = _crew.Address;
                //                    excel.Cells[32, 3] = _crew.EmailAddress;
                //                }
                //                else
                //                {
                //                    if (_list.Name != "")
                //                    {
                //                        excel.Cells[29, 3] = _list.Name;
                //                        if (_list.RelationShip == "N/A") { excel.Cells[30, 3] = ""; }
                //                        else { excel.Cells[30, 3] = _list.RelationShip; }
                //                    }
                //                    excel.Cells[31, 3] = _crew.Address;
                //                    excel.Cells[32, 3] = _crew.EmailAddress;
                //                }

                //                excel.Cells[29, 9] = _list.Amount.ToString();
                //                excel.Cells[30, 9] = _list.BankName;
                //                excel.Cells[31, 9] = _list.AccountNumber;
                //                excel.Cells[32, 9] = _list.AccountName;
                //            }
                //            else if (_list.AlloteeType == 2)
                //            {
                //                if (_list.Self_allotee)
                //                {
                //                    excel.Cells[24, 3] = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                //                    excel.Cells[35, 3] = "SELF ALLOTEE";
                //                    excel.Cells[36, 3] = _crew.Address;
                //                    excel.Cells[37, 3] = _crew.EmailAddress;
                //                }
                //                else 
                //                {
                //                    if (_list.Name != "")
                //                    {
                //                        excel.Cells[34, 3] = _list.Name;
                //                        if (_list.RelationShip == "N/A") { excel.Cells[35, 3] = ""; }
                //                        else { excel.Cells[35, 3] = _list.RelationShip; }
                //                    }
                //                    excel.Cells[36, 3] = _crew.Address;
                //                    excel.Cells[37, 3] = _crew.EmailAddress;
                //                }

                //                excel.Cells[34, 9] = _list.Amount.ToString();
                //                excel.Cells[35, 9] = _list.BankName;
                //                excel.Cells[36, 9] = _list.AccountNumber;
                //                excel.Cells[37, 9] = _list.AccountName;
                //            }
                //            else 
                //            {
                //                if (_list.Name != "")
                //                {
                //                    excel.Cells[39, 3] = _list.Name;
                //                    if (_list.RelationShip == "N/A") { excel.Cells[40, 3] = ""; }
                //                    else { excel.Cells[40, 3] = _list.RelationShip; }

                //                    excel.Cells[31, 3] = _crew.Address;
                //                }

                //                if (bool.Parse( _list.Show_Remaing.ToString())) { excel.Cells[39, 9] = "REMAINING SALARY"; }
                //                else { excel.Cells[39, 9] = _list.Amount.ToString(); }

                //                excel.Cells[40, 9] = _list.BankName;
                //                excel.Cells[41, 9] = _list.AccountNumber;
                //                excel.Cells[42, 9] = _list.AccountName;
                //                excel.Cells[42, 3] = _list.EmailAddress;
                //            }
                //        }
                //    }

                //    excel.Cells[58, 1] = Signatories.CMS.DocumentAssistant;
                //    excel.Cells[59, 1] = Signatories.CMS.DocumentAssistantSignatories;

                //    excel.Cells[58, 5] = Signatories.CMS.AccountSupervisor;
                //    excel.Cells[59, 5] = Signatories.CMS.AccountSupervisorSignatories;

                //    excel.Cells[58, 9] = _crew.LastName + ", " + _crew.FirstName ;

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

            public void PrintDebreifing(int _principalid, int _crewstatusid, int _crewid, ListView _lsvdocument, ListView _lsvlicense, ListView _lsvtraining, ListView _lsvmedical)
            {
                //Debriefing _debriefing = new Debriefing();
                //iContract _icontract = new CMSTransactionRepository.rContract();

                //try
                //{
                //    Workbook wb;
                //    Worksheet ws;

                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                //    if (LoginUser.companycode == "SMS")
                //    {
                //        wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Form - SMS New.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //    }
                //    else
                //    {
                //        if (_principalid == 15)         //dmm
                //        {
                //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Form - MOC New.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //        }
                //        else
                //        {
                //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Form - MRA New.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
                //        }
                //    }

                //    iU.Undo();

                //    ws = (Worksheet)wb.Worksheets[1];

                //    _debriefing = _icontract.GetDebriefing(_crewstatusid);
                //    if (_debriefing != null)
                //    {
                //        iCrew _icrew = new CMSFilesRepository.rCrew();
                //        Crew _crew = _icrew.GetCrew(_crewid);


                //        excel.Cells[8, 1] = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                //        if (_debriefing.CrewRecord.DateReported != null) { excel.Cells[8, 5] = _debriefing.CrewRecord.DateReported.Value.ToString("MM/dd/yyyy"); }
                //        else { excel.Cells[8, 5] = ""; }

                //        excel.Cells[10, 1] = _debriefing.CrewRecord.Position.PositionName;
                //        excel.Cells[10, 3] = _debriefing.CrewRecord.Vessel.VesselDescription;

                //        excel.Cells[10, 6] = _debriefing.CrewRecord.Principal.PrincipalDescription;
                //        excel.Cells[11, 2] = _debriefing.CrewRecord.DispatchDate.Value.ToString("MM/dd/yyyy");
                //        excel.Cells[12, 2] = _debriefing.CrewRecord.DisembarkDate.Value.ToString("MM/dd/yyyy");
                //        excel.Cells[12, 3] = _debriefing.CrewRecord.Remarks;
                //        excel.Cells[12, 6] = _debriefing.CrewRecord.DateArrived.Value.ToString("MM/dd/yyyy");

                //        excel.Cells[19, 4] = _debriefing.Accomodation;
                //        excel.Cells[19, 5] = _debriefing.Accomodation_Remarks;

                //        excel.Cells[21, 4] = _debriefing.Food;
                //        excel.Cells[21, 5] = _debriefing.Food_Remarks;

                //        excel.Cells[23, 4] = _debriefing.Salary;
                //        excel.Cells[23, 5] = _debriefing.Salary_Remarks;

                //        excel.Cells[25, 4] = _debriefing.Safety;
                //        excel.Cells[25, 5] = _debriefing.Safety_Remarks;

                //        excel.Cells[27, 4] = _debriefing.Working;
                //        excel.Cells[27, 5] = _debriefing.Working_Remarks;

                //        excel.Cells[31, 4] = _debriefing.Subordinate;
                //        excel.Cells[32, 4] = _debriefing.Coworker;
                //        excel.Cells[33, 4] = _debriefing.Superior;
                //        excel.Cells[29, 5] = _debriefing.Relation_Remarks;

                //        excel.Cells[34, 4] = _debriefing.WorkingGear;
                //        excel.Cells[34, 5] = _debriefing.WorkingGear_Remarks;

                //        excel.Cells[39, 2] = _debriefing.CrewRecord.DateAvailability.Value.ToString("MM/dd/yyyy");
                //        excel.Cells[39, 5] = _crew.TelNo + " / " + _crew.MobileNo;
                //        excel.Cells[40, 3] = _crew.Address;
                //        excel.Cells[42, 3] = _debriefing.CrewRecord.DisembarkReason.Reason;

                //        if (_debriefing.Overall == "Yes")
                //        {                            
                //            ws.Shapes.AddShape(MsoAutoShapeType.msoShapeRectangle, float.Parse("33.00"), float.Parse("278.00"), float.Parse("15.00"), float.Parse("15.00"));
                //            //xlWorkSheet.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle, 33, 278, 15.0, 15.0).Select()
                //        }
                //        else
                //        {
                //            ws.Shapes.AddShape(MsoAutoShapeType.msoShapeRectangle, float.Parse("33.00"), float.Parse("338.00"), float.Parse("15.00"), float.Parse("15.00"));
                //            //xlWorkSheet.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle, 33, 330, 15.0, 15.0).Select()
                //        }

                //        ws = (Worksheet)wb.Worksheets[2];
                //        excel.Cells[2, 1] = _debriefing.Comments;
                //        excel.Cells[8, 1] = _debriefing.Evaulation;
                //        excel.Cells[41, 1] = _debriefing.ImportantInstruction;

                //        int _linectr = 15;
                //        foreach (ListViewItem _lvi in _lsvdocument.Items)
                //        {
                //            if (_lvi.Checked)
                //            {
                //                excel.Cells[_linectr, 1] = _lvi.Text;
                //                _linectr++;
                //            }
                //        }
                //        _linectr = 15;
                //        foreach (ListViewItem _lvi in _lsvlicense.Items)
                //        {
                //            if (_lvi.Checked)
                //            {
                //                excel.Cells[_linectr, 6] = _lvi.Text;
                //                _linectr++;
                //            }
                //        }
                //        _linectr = 27;
                //        foreach (ListViewItem _lvi in _lsvtraining.Items)
                //        {
                //            if (_lvi.Checked)
                //            {
                //                excel.Cells[_linectr, 1] = _lvi.Text;
                //                _linectr++;
                //            }
                //        }
                //        _linectr = 27;
                //        foreach (ListViewItem _lvi in _lsvmedical.Items)
                //        {
                //            if (_lvi.Checked)
                //            {
                //                excel.Cells[_linectr, 6] = _lvi.Text;
                //                _linectr++;
                //            }
                //        }
                //    }

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            public void PrintPersonnalDataForm(int _crewid, string _appid)
            {
                //Workbook wb;
                //Worksheet ws;
                //iCrew _icrew = new CMSFilesRepository.rCrew();
                //string _address = "";
                //DateTime? _date;
                //try
                //{                    
                //    Crew _crew = _icrew.GetCrew(_crewid);
                //    if (_crew != null)
                //    {
                //        Impersonator iU = new Impersonator();
                //        iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                //        wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"TRANSACTION\PDF FORMAT.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);

                //        iU.Undo();

                //        ws = (Worksheet)wb.Worksheets[1];

                //        excel.Cells[11, 3] = _crew.LastName.ToString() != "" ? _crew.LastName.ToUpper() : "";
                //        excel.Cells[11, 5] = _crew.LastName.ToString() != "" ? _crew.FirstName.ToUpper() : "";
                //        excel.Cells[11, 6] = _crew.LastName.ToString() != "" ? _crew.MiddleName.ToUpper() : "";

                //        excel.Cells[12, 2] = _crew.LastName.ToString() != "" ? _crew.Nationality.ToUpper() : "";
                //        excel.Cells[12, 4] = _crew.BDay != null ? _crew.BDay.Value.ToString("MM/dd/yyyy") : "";                                                

                //        excel.Cells[13, 2] = _crew.Sex.ToString() != "" ? _crew.Sex.ToUpper() : "";
                //        excel.Cells[13, 4] = _crew.CivilStatus.ToString() != "" ? _crew.CivilStatus.ToUpper() : "";

                //        excel.Cells[18, 2] = _crew.FatherName.ToString() != "" ? _crew.FatherName.ToUpper() : "";
                //        excel.Cells[18, 5] = _crew.MotherName.ToString() != "" ? _crew.MotherName.ToUpper() : "";

                //        if (_crew.Address != null)
                //        {
                //            _address = _crew.Address.ToUpper();
                //            excel.Cells[21, 2] = _address;
                //        }

                //        excel.Cells[23, 4] = _crew.EmailAddress.ToString() != "" ? _crew.EmailAddress.ToUpper() : "";
                //        excel.Cells[22, 6] = _crew.TelNo.ToString() != "" ? _crew.TelNo.ToUpper() : "";
                //        excel.Cells[23, 6] = _crew.MobileNo.ToString() != "" ? _crew.MobileNo.ToUpper() : "";

                //        excel.Cells[26, 3] = _crew.HighestEducation.ToString() != "" ? _crew.HighestEducation.ToUpper() : "";
                //        excel.Cells[27, 2] = _crew.School.ToString() != "" ? _crew.School.ToUpper() : "";
                //        excel.Cells[27, 5] = _crew.Degree.ToString() != "" ? _crew.Degree.ToUpper() : "";

                //        excel.Cells[54, 2] = _crew.HighestEducation.ToString() != "" ? _crew.HighestEducation.ToUpper() : "";
                //        excel.Cells[56, 2] = _crew.School.ToString() != "" ? _crew.School.ToUpper() : "";
                //        excel.Cells[55, 6] = _crew.ContactPersonTelNo.ToString() != "" ? _crew.ContactPersonTelNo.ToUpper() : "";
                //        excel.Cells[56, 6] = _crew.ContactPersonCP.ToString() != "" ? _crew.ContactPersonCP.ToUpper() : "";
                //    }

                //    iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
                //    CrewDocument _crewdocument = _icrewdocument.GetCrewDocument(1, _appid, "P");
                //    if (_crewdocument != null)
                //    {
                //        excel.Cells[14, 2] = _crewdocument.Number.ToString() != "" ? _crewdocument.Number.ToUpper() : "";
                //        excel.Cells[15, 2] = _crewdocument.DateIssued != null ? _crewdocument.DateIssued.Value.ToString("MM/dd/yyyy") : "";
                //        excel.Cells[16, 2] = _crewdocument.DateExpired != null ? _crewdocument.DateExpired.Value.ToString("MM/dd/yyyy") : "";

                //        excel.Cells[17, 2] = _crewdocument.Country.CountryName.ToUpper();
                //    }

                //    _icrewdocument = new CMSFilesRepository.rCrewDocument();
                //    _crewdocument = new CrewDocument();
                //    _crewdocument = _icrewdocument.GetCrewDocument(2, _appid, "P");
                //    if (_crewdocument != null)
                //    {
                //        excel.Cells[14, 5] = _crewdocument.Number.ToString() != "" ? _crewdocument.Number.ToUpper() : "";
                //        excel.Cells[15, 5] = _crewdocument.DateIssued != null ? _crewdocument.DateIssued.Value.ToString("MM/dd/yyyy") : "";
                //        excel.Cells[16, 5] = _crewdocument.DateExpired != null ? _crewdocument.DateExpired.Value.ToString("MM/dd/yyyy") : "";

                //        excel.Cells[17, 5] = _crewdocument.Country.CountryName.ToUpper();
                //    }

                //    iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
                //    CrewBeneficiary _crewbeneficiary = (from d in _icrewbeneficiaries.GetCrewBeneficiaries(_appid) where d.RelationShip == "SPOUSE" select d).SingleOrDefault();
                //    if (_crewbeneficiary != null)
                //    {
                //        excel.Cells[42, 2] = _crewbeneficiary.LastName.ToString().ToUpper() + ", " + _crewbeneficiary.FirstName.ToString().ToUpper() + " " + _crewbeneficiary.MiddleName.ToString().ToUpper();                        
                //        excel.Cells[43, 2] =  _crewbeneficiary.Sex == "1" ? "MALE" : "FEMALE";
                //        excel.Cells[44, 2] = _address;

                //        excel.Cells[46, 2] = _crewbeneficiary.BirthDay.ToString() != "" ? _crewbeneficiary.BirthDay.Value.ToString("MM/dd/yyyy") : "";
                //    }


                //    _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
                //    int _col = 3;
                //    List<CrewBeneficiary> _beneficiaries = (from d in _icrewbeneficiaries.GetCrewBeneficiaries(_appid) where (d.RelationShip.ToUpper() == "SON" || d.RelationShip.ToUpper() == "DAUGHTER") select d).ToList();
                //    foreach (CrewBeneficiary _list in _beneficiaries)
                //    {
                //        excel.Cells[42, _col] = _list.LastName.ToString().ToUpper() + ", " + _list.FirstName.ToString().ToUpper() + " " + _list.MiddleName.ToString().ToUpper();
                //        excel.Cells[43, _col] = _list.Sex == "1" ? "MALE" : "FEMALE";
                //        excel.Cells[44, _col] = _address;
                //        excel.Cells[46, _col] = _list.BirthDay.ToString() == "" ? _list.BirthDay.Value.ToString("MM/dd/yyyy") : "";

                //        _col++;
                //    }
                //    excel.Visible = true;
                //    _close.CloseExcel(excel);                    
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}                
            }

            //public void PrintJumboCV(string _applicantid, bool _masked, bool _save, System.Windows.Forms.Label _label, System.Windows.Forms.ProgressBar _progressbar, GenerateCVform _parent)
            //{
            //    //Workbook wb;
            //Worksheet ws;

            //int _initialid = 0;

            //try 
            //{
            //    _parent.SetProgressBarMax(100);
            //    Thread.Sleep(200);

            //    Impersonator iU = new Impersonator();
            //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

            //    if (LoginUser.companycode == "MRA")
            //    {
            //        if (_masked)
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\MRA MASKED CV.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);                        
            //        }
            //        else
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\MRA CV.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
            //        }
            //    }
            //    else if (LoginUser.companycode == "SMS")
            //    {
            //        if (_masked)
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\SMS MASKED CV.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
            //        }
            //        else
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\SMS CV.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
            //        }                    
            //    }
            //    else
            //    {
            //        if (_masked)
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\MOC MASKED CV.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
            //        }
            //        else
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\MOC CV.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
            //        }                                                
            //    }

            //    iU.Undo();

            //    _parent.DisplaMessage("Loading Report template from the server...");
            //    Thread.Sleep(200);
            //    _parent.UpdateProgressBar(10);
            //    Thread.Sleep(5);

            //    _parent.DisplaMessage("Generating Personnal information...");
            //    Thread.Sleep(200);
            //    _parent.UpdateProgressBar(15);
            //    Thread.Sleep(5);
            //    ws = (Worksheet)wb.Worksheets[1];
            //    iCrew _icrew = new CMSFilesRepository.rCrew();
            //    Crew _crew = _icrew.GetCrew(_applicantid);
            //    if (_crew != null)
            //    { 
            //        excel.Cells[15, 1] = _masked ? _crew.CrewId.ToString() : _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;

            //        if (LoginUser.accountid == 30 || LoginUser.accountid == 17)
            //        {

            //        }
            //        else 
            //        {
            //            excel.Cells[13, 3] = _masked ? "On Request" : _crew.Address.ToString();                             
            //        }

            //        excel.Cells[14, 3] = _crew.BDay.ToString() != "" ? _crew.BDay.Value.ToString("MM/dd/yyyy") + "                                               " + GlobalToolsControl.HURIS.ComputeAge(_crew.BDay) : "";

            //        excel.Cells[15, 7] = _crew.PlaceOfBirth.ToString(); 
            //        excel.Cells[16, 7] = _crew.CivilStatus.ToString();
            //        excel.Cells[17, 7] = _crew.Religion.ToString();

            //        if (_masked)
            //        {
            //            excel.Cells[18, 7] = "On Request";
            //            excel.Cells[19, 7] = "On Request";
            //            excel.Cells[13, 21] = "On Request";
            //        }
            //        else
            //        {
            //            excel.Cells[18, 7] = _crew.ContactPerson.ToString();
            //            excel.Cells[19, 7] = _crew.ContactPersonAddress.ToString();
            //            excel.Cells[13, 21] = _crew.TelNo.ToString();
            //        }

            //        if (LoginUser.accountid == 30 || LoginUser.accountid == 17) { }
            //        else
            //        {
            //            excel.Cells[14, 21] = _masked ? "On Request" : _crew.MobileNo.ToString();
            //        }

            //        excel.Cells[15, 21] = _crew.HighestEducation.ToString();
            //        excel.Cells[16, 21] = _crew.School.ToString();
            //        excel.Cells[17, 21] = _crew.YearAttended.ToString();
            //    }

            //    _parent.DisplaMessage("Generating License information...");
            //    Thread.Sleep(200);
            //    _parent.UpdateProgressBar(20);
            //    Thread.Sleep(5);
            //    iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            //    List<CrewLicense> _licenses = (from d in _icrewlicense.GetCrewLicenses(_applicantid) select d).Take(7).ToList();
            //    int _licensecnt = 29;
            //    foreach (CrewLicense _list in _licenses)
            //    {
            //        excel.Cells[_licensecnt, 1] = _list.License.License_Name.ToString();
            //        excel.Cells[_licensecnt, 7] = _list.Capacity.ToString();
            //        excel.Cells[_licensecnt, 9] = _list.Regulation.ToString();

            //        excel.Cells[_licensecnt, 13] =  _masked ? "On Request" : _list.Number.ToString();

            //        excel.Cells[_licensecnt, 15] = _list.Country.CountryName.ToString();
            //        excel.Cells[_licensecnt, 16] = _list.Limitation.ToString();
            //        excel.Cells[_licensecnt, 19] = _list.IssuedDate.ToString() != "" ? _list.IssuedDate.Value.ToString("MM/dd/yyyy") : "";
            //        excel.Cells[_licensecnt, 22] = _list.ExpiryDate.ToString() != "" ? _list.ExpiryDate.Value.ToString("MM/dd/yyyy") : "";

            //        _licensecnt++;
            //    }

            //    _parent.DisplaMessage("Generating Training information...");
            //    Thread.Sleep(200);
            //    _parent.UpdateProgressBar(30);
            //    Thread.Sleep(5);
            //    iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            //    List<CrewTraining> _trainings = (from d in _icrewtraining.GetCrewTrainings(_applicantid) select d).Take(25).ToList();
            //    int _trainingcnt = 40;
            //    foreach (CrewTraining _list in _trainings)
            //    {
            //        excel.Cells[_trainingcnt, 1] = _list.Training.Training_Name.ToString();
            //        excel.Cells[_trainingcnt, 7] = _list.TrainingCenter.Institution_Name.ToString();
            //        excel.Cells[_trainingcnt, 16] = _list.Country.CountryName.ToString();
            //        excel.Cells[_trainingcnt, 19] = _list.IssuedDate.ToString() != "" ? _list.IssuedDate.Value.ToString("MM/dd/yyyy") : "";
            //        excel.Cells[_trainingcnt, 22] = _list.NACRevDate.ToString();

            //        _trainingcnt++;
            //    }

            //    _parent.DisplaMessage("Generating Document information...");
            //    Thread.Sleep(200);
            //    _parent.UpdateProgressBar(40);
            //    Thread.Sleep(5);
            //    iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            //    List<CrewDocument> _documents = (from d in _icrewdocument.GetCrewDocuments(_applicantid) select d).Take(11).ToList();
            //    int _documentcnt = 68;
            //    foreach (CrewDocument _list in _documents)
            //    {
            //        excel.Cells[_documentcnt, 1] = _list.Document.NameofDocument.ToString();
            //        excel.Cells[_documentcnt, 7] = _masked ? "On Request" :  _list.Number.ToString();
            //        excel.Cells[_documentcnt, 10] = _list.IssuedBy.ToString();
            //        excel.Cells[_documentcnt, 14] = _list.Country.CountryName.ToString();
            //        excel.Cells[_documentcnt, 18] = _list.DateIssued.ToString() != "" ? _list.DateIssued.Value.ToString("MM/dd/yyyy") : "";
            //        excel.Cells[_documentcnt, 22] = _list.DateExpired.ToString() != "" ? _list.DateExpired.Value.ToString("MM/dd/yyyy") : "";

            //        _documentcnt++;
            //    }

            //    _parent.DisplaMessage("Generating Experience information...");
            //    Thread.Sleep(200);
            //    _parent.UpdateProgressBar(50);
            //    Thread.Sleep(5);
            //    iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
            //    List<CrewExperience> _experiences = (from d in _icrewexperience.GetCrewExperiences(_applicantid) select d).Take(19).ToList();
            //    int _experiencecnt = 82;
            //    foreach (CrewExperience _list in _experiences)
            //    {
            //        excel.Cells[_experiencecnt, 1] = _list.VesselName.ToString();
            //        excel.Cells[_experiencecnt, 5] = _list.PositionName.ToString();
            //        excel.Cells[_experiencecnt, 8] = _list.VesselType.ToString();
            //        excel.Cells[_experiencecnt, 10] = _list.GRT_Engine_BHP.ToString();
            //        excel.Cells[_experiencecnt, 13] = _list.From.ToString() != "" ? _list.From.Value.ToString("MM/dd/yyyy") : "";
            //        excel.Cells[_experiencecnt, 15] = _list.To.ToString() != "" ? _list.To.Value.ToString("MM/dd/yyyy") : "";
            //        excel.Cells[_experiencecnt, 17] = (_list.Agency == null ? "" : _list.Agency.ToString()) + " " + _list.CountryName.ToString();
            //        excel.Cells[_experiencecnt, 22] = _list.Remarks.ToString().Replace(System.Environment.NewLine, "");

            //        _experiencecnt++;
            //    }

            //    int _score_physical = 0;
            //    int _score_communication = 0;
            //    int _score_education = 0;

            //    _parent.DisplaMessage("Generating Assessment information...");
            //    Thread.Sleep(200);

            //    _icrew = new CMSFilesRepository.rCrew();
            //    int? _candidateid = 0;                    
            //    CrewInitialInformation _crewinitial = _icrew.GetCrewInitialInfo(_applicantid);
            //    if (_crewinitial != null)
            //    {
            //        _candidateid = _crewinitial.CANDIDATEID;
            //        //PHYSICAL APPEARANCE
            //        _parent.DisplaMessage("Generating Physical Appearance information...");
            //        Thread.Sleep(200);
            //        _parent.UpdateProgressBar(55);
            //        Thread.Sleep(5);
            //        if (_crewinitial.CrewInitalAssestment.PhysicalApperance == "EXCELLENT")
            //        {
            //            _score_physical = 5;
            //            excel.Cells[109, 10] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.PhysicalApperance == "ABOVE AVERAGE")
            //        {
            //            _score_physical = 4;
            //            excel.Cells[109, 11] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.PhysicalApperance == "AVERAGE")
            //        {
            //            _score_physical = 3;
            //            excel.Cells[109, 12] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.PhysicalApperance == "NEEDS IMPROVEMENT")
            //        {
            //            _score_physical = 2;
            //            excel.Cells[109, 13] = "X";
            //        }
            //        else
            //        {
            //            _score_physical = 1;
            //            excel.Cells[109, 14] = "X";
            //        }
            //        excel.Cells[109, 15] = _crewinitial.CrewInitalAssestment.PhysicalRemarks.ToString();

            //        //COMMUNICATION
            //        _parent.DisplaMessage("Generating Communication Assessment information...");
            //        Thread.Sleep(200);
            //        _parent.UpdateProgressBar(60);
            //        Thread.Sleep(5);
            //        if (_crewinitial.CrewInitalAssestment.Comunication == "EXCELLENT")
            //        {
            //            _score_communication = 5;
            //            excel.Cells[110, 10] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.Comunication == "ABOVE AVERAGE")
            //        {
            //            _score_communication = 4;
            //            excel.Cells[110, 11] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.Comunication == "AVERAGE")
            //        {
            //            _score_communication = 3;
            //            excel.Cells[110, 12] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.Comunication == "NEEDS IMPROVEMENT")
            //        {
            //            _score_communication = 2;
            //            excel.Cells[110, 13] = "X";
            //        }
            //        else 
            //        {
            //            _score_communication = 1;
            //            excel.Cells[110, 14] = "X";
            //        }
            //        excel.Cells[110, 15] = _crewinitial.CrewInitalAssestment.ComunicationRemarks.ToString();

            //        //EDUCATION TRAINING
            //        _parent.DisplaMessage("Generating Education and Training information...");
            //        Thread.Sleep(200);
            //        _parent.UpdateProgressBar(65);
            //        Thread.Sleep(5);
            //        if (_crewinitial.CrewInitalAssestment.Education == "EXCELLENT")
            //        {
            //            _score_education = 5;
            //            excel.Cells[111, 10] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.Education == "ABOVE AVERAGE")
            //        {
            //            _score_education = 4;
            //            excel.Cells[111, 11] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.Education == "AVERAGE")
            //        {
            //            _score_education = 3;
            //            excel.Cells[111, 12] = "X";
            //        }
            //        else if (_crewinitial.CrewInitalAssestment.Education == "NEEDS IMPROVEMENT")
            //        {
            //            _score_education = 2;
            //            excel.Cells[111, 13] = "X";
            //        }
            //        else
            //        {
            //            _score_education = 1;
            //            excel.Cells[111, 14] = "X";
            //        }
            //        excel.Cells[111, 15] = _crewinitial.CrewInitalAssestment.EducationRemarks.ToString();

            //        //PERSONNALITY
            //        _parent.DisplaMessage("Generating Personnality Assessment information...");
            //        Thread.Sleep(100);
            //        _parent.UpdateProgressBar(70);
            //        Thread.Sleep(5);
            //        if (_crewinitial.CrewInitalAssestment.Personality.ToUpper() == "EXCELLENT") { excel.Cells[112, 10] = "X"; }
            //        else if (_crewinitial.CrewInitalAssestment.Personality.ToUpper() == "ABOVE AVERAGE") { excel.Cells[112, 11] = "X"; }
            //        else if (_crewinitial.CrewInitalAssestment.Personality.ToUpper() == "AVERAGE") { excel.Cells[112, 12] = "X"; }
            //        else if (_crewinitial.CrewInitalAssestment.Personality.ToUpper() == "ANEEDS IMPROVEMENT") { excel.Cells[112, 13] = "X"; }
            //        else { excel.Cells[112, 14] = "X"; }

            //        excel.Cells[112, 15] = _crewinitial.CrewInitalAssestment.PersonalityRemarks;

            //        //TECHNICAL COMPETENCE
            //        _parent.DisplaMessage("Generating TECHNICAL COMPETENCE information...");
            //        Thread.Sleep(100);
            //        _parent.UpdateProgressBar(75);
            //        Thread.Sleep(5);
            //        _initialid = _crewinitial.InitialID;
            //        string _overall = "";
            //        int _checkerid = 0;
            //        string _assessby = "";
            //        CrewTechnical _crewtechnical = _icrew.GetCrewTechnical(_initialid);
            //        if (_crewtechnical != null)
            //        {
            //            int _result = 0;
            //            string _overallassess = "";

            //            _checkerid = _crewtechnical.UserID;
            //            _assessby = _crewtechnical.AssessBy;

            //            if (_crewtechnical.Result == "Not Qualified") { _result = 0; }
            //            else if (_crewtechnical.Result == "Poor") { _result = 1; }
            //            else if (_crewtechnical.Result == "Below Average") { _result = 2; }
            //            else if (_crewtechnical.Result == "Average") { _result = 3; }
            //            else if (_crewtechnical.Result == "Above Average") { _result = 4; }
            //            else { _result = 5; }

            //            iRating _irating = new CMSFilesRepository.rRating();

            //            if (LoginUser.companycode == "SMS")
            //            {
            //                _overallassess = _irating.GetRating(_result, "TECHNICAL OVERALL SMS");    
            //            }
            //            else 
            //            {
            //                _overallassess = _irating.GetRating(_result, "TECHNICAL OVERALL MRA");
            //            }

            //            excel.Cells[114, 1] = _crewtechnical.Remarks + " " + _overallassess;
            //        }

            //        int _totalscore = (_score_communication + _score_education + _score_physical) / 3;
            //        if (_totalscore == 5) { excel.Cells[122, 5] = "Excellent"; }
            //        else if (_totalscore == 4) { excel.Cells[122, 5] = "Above Average"; }
            //        else if (_totalscore == 3) {  excel.Cells[122, 5] = _masked ? "Normal" : "Average"; }
            //        else if (_totalscore == 2) { excel.Cells[122, 5] = "Needs Improvement"; }
            //        else { excel.Cells[122, 5] = "Poor"; }

            //        if (_masked) { excel.Cells[107, 8] = "3 - Normal"; }


            //        //CHECKER
            //        excel.Cells[123, 5] = _assessby;
            //        excel.Cells[124, 5] = _crewinitial.DateInitial.Value.ToString("MM/dd/yyyy");


            //        //TEST RESULT
            //        string[] _mental = _crewinitial.CrewTesting.MentalAbility.Split('-');
            //        excel.Cells[122, 16] = _mental[0];

            //        string[] _attitude = _crewinitial.CrewTesting.Attitude.Split('-');
            //        excel.Cells[123, 16] = _attitude[0];

            //        string[] _technical = _crewinitial.CrewTesting.Technical.Split('-');
            //        excel.Cells[124, 16] = _technical[0];

            //        string[] _marlin = _crewinitial.CrewTesting.MarlinsScore.Split('-');
            //        excel.Cells[125, 16] = _marlin[0];
            //    }

            //    //SET IMAGE
            //    _parent.DisplaMessage("Setting up Image...");
            //    Thread.Sleep(100);
            //    _parent.UpdateProgressBar(80);
            //    Thread.Sleep(5);
            //    try
            //    {
            //        ws.Shapes.AddPicture(DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".JPEG", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 940, 75, 125, 105);
            //    }
            //    catch (Exception ee)
            //    {
            //        MessageBox.Show("Image not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    _parent.DisplaMessage("Saving Generated CV...");
            //    Thread.Sleep(100);
            //    _parent.UpdateProgressBar(90);
            //    Thread.Sleep(5);
            //    if (_save) 
            //    {                        
            //        ws.SaveAs(DCLSystemConfiguration.CMS.Imagepath + _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName + " CV-" + _applicantid.Substring(0, 4) + ".xls");
            //        iPropose _ipropose = new CMSTransactionRepository.rProposed();
            //        _ipropose.ManageGenerateCV(int.Parse( _candidateid.ToString()), _applicantid, _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName + " CV-" + _applicantid.Substring(0, 4) + ".xls", DCLSystemConfiguration.CMS.Imagepath, 1);
            //    }

            //    _parent.UpdateProgressBar(100);
            //    Thread.Sleep(5);
            //    excel.Visible = true;
            //    _close.CloseExcel(excel);   
            //}
            //catch (Exception ex)
            //{
            //    excel.Quit();
            //    _close.CloseExcel(excel);
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //}

            public void PrintLandbasedCV(string _applicantid, bool _save)
            {
                GlobalReportViewerform _report = new GlobalReportViewerform("LANDBASED CV");
                _report.BringToFront();
                _report.Show();
            }

            public void PrintDaeAhCV(string _applicantid, bool _save)
            {
                //Workbook wb;
                //Worksheet ws;

                //try
                //{
                //    Impersonator iU = new Impersonator();
                //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                // wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"CV TEMPLATE\Dae ah.xls", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);

                //iU.Undo();

                //ws = (Worksheet)wb.Worksheets[1];
                //iCrew _icrew = new CMSFilesRepository.rCrew();
                //Crew _crew = _icrew.GetCrew(_applicantid);
                //if (_crew != null)
                //{
                //    excel.Cells[4, 2] = "";
                //    excel.Cells[4, 7] = "";

                //    excel.Cells[5, 2] = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                //    excel.Cells[6, 2] = _crew.PlaceOfBirth;
                //    excel.Cells[7, 3] = _crew.FamilySon;
                //    excel.Cells[7, 5] = _crew.FamilyDauther;

                //    excel.Cells[8, 3] = _crew.EyeLeft;
                //    excel.Cells[8, 5] = _crew.EyeRight;

                //    excel.Cells[8, 7] = _crew.Blood;
                //    excel.Cells[10, 2] = _crew.WaistSize;
                //    excel.Cells[10, 7] = _crew.ShoeSize;
                //    excel.Cells[5, 7] = _crew.CivilStatus;
                //    excel.Cells[6, 7] = _crew.BDay.Value.ToString("MM/dd/yyyy");

                //    excel.Cells[7, 7] = _crew.FatherName + " / " + _crew.MotherName;
                //    excel.Cells[9, 2] = _crew.Height;
                //    excel.Cells[9, 7] = _crew.Weight;

                //    excel.Cells[12, 2] = _crew.Address;
                //    excel.Cells[12, 6] = _crew.TelNo + " / " + _crew.MobileNo;

                //    excel.Cells[36, 7] = _crew.Religion;
                //    excel.Cells[36, 2] = _crew.Degree + " / " + _crew.School;
                //    excel.Cells[73, 2] = _crew.PositionApplied;
                //    excel.Cells[73, 7] = _crew.DateInitial.Value.ToString("MM/dd/yyyy");

                //}

                //iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
                //List<CrewDocument> _crewdocuments = _icrewdocument.GetCrewDocuments(_applicantid);
                //int _doccnt = 16;
                //foreach (CrewDocument _list in _crewdocuments)
                //{
                //    excel.Cells[_doccnt, 1] = _list.Document.NameofDocument;
                //    excel.Cells[_doccnt, 2] = _list.Number.ToString() + " / " + _list.DateIssued.Value.ToString("MM/dd/yyyy");
                //    excel.Cells[_doccnt, 6] = "Expire / Plc of Issue";
                //    excel.Cells[_doccnt, 7] = _list.DateExpired.Value.ToString("MM/dd/yyyy") + " / " + _list.IssuedBy;

                //    _doccnt++;                   
                //}

                //iCrewLicense _iCrewlicense = new CMSFilesRepository.rCrewLicense();
                //List<CrewLicense> _crewlicenses = _iCrewlicense.GetCrewLicenses(_applicantid);
                //foreach (CrewLicense _list in _crewlicenses)
                //{
                //    excel.Cells[_doccnt, 1] = _list.License.License_Name;
                //    excel.Cells[_doccnt, 2] = _list.Number.ToString() + " / " + _list.IssuedDate.Value.ToString("MM/dd/yyyy");
                //    excel.Cells[_doccnt, 6] = "Expire / Plc of Issue";
                //    excel.Cells[_doccnt, 7] = _list.ExpiryDate.Value.ToString("MM/dd/yyyy") + " / " + _list.Country.CountryName;

                //    _doccnt++;                   
                //}

                //iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
                //List<CrewExperience> _crewexperiences = _icrewexperience.GetCrewExperiences(_applicantid).Take(14).ToList();
                //_doccnt =42;
                //foreach (CrewExperience _list in _crewexperiences)
                //{
                //    excel.Cells[_doccnt, 1] = _list.VesselName;
                //    excel.Cells[_doccnt + 1, 1] = _list.FlagofVessel;

                //    excel.Cells[_doccnt , 2] = _list.Agency;
                //    excel.Cells[_doccnt + 1, 2] = _list.CompanyName;

                //    excel.Cells[_doccnt , 3] = _list.PositionName;
                //    excel.Cells[_doccnt , 4] = _list.VesselType;
                //    excel.Cells[_doccnt , 5] = _list.GRT_Engine_BHP;
                //    excel.Cells[_doccnt , 6] = _list.VesselEngine;
                //    if (_list.From != null && _list.To != null)
                //    { excel.Cells[_doccnt, 7] = (_list.To.Value.Month - _list.From.Value.Month) + 12 * (_list.To.Value.Year - _list.From.Value.Year); }
                //    else { excel.Cells[_doccnt, 7] = 0; }

                //    excel.Cells[_doccnt , 8] = _list.From.Value.ToString("MM/dd/yyyy");
                //    excel.Cells[_doccnt + 1 , 8] = _list.To.Value.ToString("MM/dd/yyyy");
                //    excel.Cells[_doccnt , 9] = _list.Remarks;

                //    _doccnt ++;
                //}

                //    CrewInitialInformation _crewinitial = _icrew.GetCrewInitialInfo(_applicantid);
                //    int _candidateid = 0;
                //    if (_crewinitial != null)
                //    {
                //        _candidateid = int.Parse( _crewinitial.CANDIDATEID.ToString());
                //        string[] _attitude = _crewinitial.CrewTechnical.Attititude.Split('-');
                //        excel.Cells[71, 7] = _attitude[0];     

                //        excel.Cells[71, 2]  = _crewinitial.CrewTechnical.Remarks;
                //        excel.Cells[74, 2]  = _crewinitial.CrewTechnical.Remarks;
                //    }

                //    //SET IMAGE
                //    try
                //    {
                //        ws.Shapes.AddPicture(DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".JPEG", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 940, 75, 125, 105);
                //    }
                //    catch (Exception ee)
                //    {
                //        MessageBox.Show("Image not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }

                //    if (_save)
                //    {
                //        ws.SaveAs(DCLSystemConfiguration.CMS.Imagepath + _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName + " DAE-AH CV-" + _applicantid.Substring(0, 4) + ".xls");
                //        iPropose _ipropose = new CMSTransactionRepository.rProposed();
                //        _ipropose.ManageGenerateCV(int.Parse(_candidateid.ToString()), _applicantid, _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName + " CV-" + _applicantid.Substring(0, 4) + ".xls", DCLSystemConfiguration.CMS.Imagepath, 1);
                //    }

                //    excel.Visible = true;
                //    _close.CloseExcel(excel);   
                //}
                //catch (Exception ex)
                //{
                //    excel.Quit();
                //    _close.CloseExcel(excel);

                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //}
            }

            //    public void CloseExcel(Microsoft.Office.Interop.Excel.Application _excel)
            //{
            //    //System.Threading.Thread.Sleep(1000);
            //    //System.Runtime.InteropServices.Marshal.ReleaseComObject(_excel);
            //    //GC.Collect();
            //    //GC.WaitForPendingFinalizers();
            //    //System.Threading.Thread.Sleep(1000);
            //}
        }
    }
}
