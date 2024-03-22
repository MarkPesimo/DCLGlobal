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

namespace DCLGlobal.Reports
{
    public partial class GlobalReportViewerform : Form
    {
        //iTool _itool = new ToolRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);

        private string _reporttype = "";
        public int _crewstatusid = 0;
        public int _principalid = 0;
        public int _crewid = 0;
        public string _applicantid = "";
        public string _selectedcheckup = "";
        public int _medicalid = 0;
        public int _vesselid = 0;
        public string _principalname = "";
        public string _crewname = "";
        public string _rpstype = "";

        public string _x1 = "";
        public string _x2 = "";
        public string _x3 = "";
        public string _x4 = "";
        public string _x5 = "";
        public string _x6 = "";
        public string _x7 = "";
        public string _x8 = "";
        public string _x9 = "";
        public string _x10 = "";
        public string _x11 = "";
        public string _x12 = "";

        //crewstatusreport
        public DateTime _from = DateTime.Now;
        public DateTime _to = DateTime.Now;

        
        //signatories
        public string _prepared_by = "";
        public string _noted_by = "";
        public string _approved_by = "";

        //APPLICANT REPORT
        public string _applicant_status = "";
        
        //candidate report
        public string _candidate_status = "";
        public bool _savecv = false;

        //insurance report
        public int _month;
        public int _year;

        //Request Monitoring Report
        public int _request_status;
        public string _clientstatus;

        public GlobalReportViewerform()
        {
            InitializeComponent();
        }

        public GlobalReportViewerform(string _Reporttype)
        {
            InitializeComponent();
            _reporttype = _Reporttype;
        }

        //private void SetReportDataSource(string _server, string _database, string _username, string _password, ReportDocument _report)
        //{
        //    ConnectionInfo myConnectionInfo = new ConnectionInfo();
        //    myConnectionInfo.ServerName = _server;
        //    myConnectionInfo.DatabaseName = _database;
        //    myConnectionInfo.UserID = _username;
        //    myConnectionInfo.Password = _password;

        //    Tables myTables = _report.Database.Tables;
        //    TableLogOnInfo myTableLogonInfo = new TableLogOnInfo();
        //    myTableLogonInfo.ConnectionInfo = myConnectionInfo;

        //    foreach (CrystalDecisions.CrystalReports.Engine.Table mytable in myTables)
        //    {
        //        mytable.ApplyLogOnInfo(myTableLogonInfo);

        //        mytable.LogOnInfo.ConnectionInfo.DatabaseName = myTableLogonInfo.ConnectionInfo.DatabaseName;
        //        mytable.LogOnInfo.ConnectionInfo.ServerName = myTableLogonInfo.ConnectionInfo.ServerName;
        //        mytable.LogOnInfo.ConnectionInfo.UserID = myTableLogonInfo.ConnectionInfo.UserID;
        //        mytable.LogOnInfo.ConnectionInfo.Password = myTableLogonInfo.ConnectionInfo.Password;
        //    }
        //}
        

        void DisplayReport()
        {
            ////_itool = new ToolRepository(DCLSystemConfiguration.Connection);
            //iCrew _icrew = new CMSFilesRepository.rCrew();
            //string _category = "";

            //if (_crewid != 0) { _category = _icrew.GetCrew(_crewid).Category; }

            //ReportDocument cr1 = new ReportDocument();
            //try
            //{
            //    //SP_C_GET_REPORT_PATHResult _report = _itool.GetReportPath(_reporttype, _principalid, LoginUser.accountid, _crewid, _applicantid);
            //    SP_C_GET_REPORT_PATHResult _report = GlobalToolsControl.GetReportPath(_reporttype, _principalid, LoginUser.accountid, _crewid, _applicantid);

            //    Impersonator iU = new Impersonator();
            //    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

            //    cr1.Load(_report.ReportPath);

            //    iU.Undo();

            //    if (_reporttype == "LANDBASED CV")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;

            //        cr1.DataDefinition.FormulaFields["ImagePath"].Text = "'" + DCLSystemConfiguration.CMS.Imagepath + "'";

            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "REQUEST MONITORING REPORT")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["Status"].Text = "" + _request_status + "";
            //        cr1.DataDefinition.FormulaFields["Datefrom"].Text = "#" + _from.ToShortDateString() + "#";
            //        cr1.DataDefinition.FormulaFields["Dateto"].Text = "#" + _to.ToShortDateString() + "#";
            //        cr1.DataDefinition.FormulaFields["ClientStatus"].Text = "'" + _clientstatus + "'";
            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "WATCHLIST")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "INSURANCE REPORT")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;

            //        cr1.DataDefinition.FormulaFields["DocumentAssistant"].Text = "'" + Signatories.CMS.DocumentAssistant + "'";
            //        cr1.DataDefinition.FormulaFields["Month"].Text = "" + _month + "";
            //        cr1.DataDefinition.FormulaFields["Year"].Text = "" + _year + "";

            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "AMOSUP")
            //    {
            //        cr1.DataDefinition.FormulaFields["DocumentAssistant"].Text = "'" + Signatories.CMS.DocumentAssistant + "'";

            //        if (_vesselid == 0)
            //        {
            //            cr1.DataDefinition.RecordSelectionFormula = " {tblDCL_CrewStatus.PrincipalID} = " + _principalid + "  AND {tblDCL_CrewStatus.dispatchdate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')";
            //        }
            //        else
            //        {
            //            cr1.DataDefinition.RecordSelectionFormula = " {tblDCL_CrewStatus.PrincipalID} = " + _principalid + "  and {tblDCL_CrewStatus.VesselID} = " + _vesselid + " AND {tblDCL_CrewStatus.dispatchdate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')";
            //        }

            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "MEDICAL REFERRAL SLIP")
            //    {
            //        cr1.DataDefinition.FormulaFields["CompanyCode"].Text = "'" + LoginUser.companycode + "'";
            //        cr1.DataDefinition.FormulaFields["CompanyAddress"].Text = "'" + CAL.Global.CompanyProfile.CompanyAddress + "'";

            //        cr1.DataDefinition.FormulaFields["MedicalID"].Text = "" + _medicalid + "";
            //        _selectedcheckup = _selectedcheckup.Substring(1, _selectedcheckup.Length - 2);
            //        cr1.DataDefinition.FormulaFields["Medical"].Text = "'" + _selectedcheckup + "'";
            //        cr1.DataDefinition.FormulaFields["ImagePath"].Text = "'" + DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".jpeg" + "'";
            //        cr1.DataDefinition.FormulaFields["MedicalInCharge"].Text = "'" + Signatories.CMS.MedicalInCharge + "'";
            //        cr1.DataDefinition.FormulaFields["SignatoryMedInCharge"].Text = "'" + Signatories.CMS.MedicalInChargeSignatories + "'";

            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "CANDIDATE REPORT")
            //    {
            //        cr1.DataDefinition.FormulaFields["Datefrom"].Text = "#" + _from.Date.ToString("MM/dd/yyyy") + "#";
            //        cr1.DataDefinition.FormulaFields["Dateto"].Text = "#" + _to.Date.ToString("MM/dd/yyyy") + "#";
            //        cr1.DataDefinition.FormulaFields["ClientStatus"].Text = "'" + _candidate_status + "'";
            //    }
            //    else if (_reporttype == "APPLICANT REPORT")
            //    {
            //        cr1.DataDefinition.FormulaFields["ReportType"].Text = "'" + _applicant_status + "'";
            //        cr1.DataDefinition.FormulaFields["DateRange"].Text = "'" + _from.Date.ToString("MM/dd/yyyy") + " to " + _to.Date.ToString("MM/dd/yyyy") + "'";

            //        if (_applicant_status == "Initial") { cr1.DataDefinition.RecordSelectionFormula = " {tblMPS_DCL_InitialInformation.DateInitial} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //        else if (_applicant_status == "Testing") { cr1.DataDefinition.RecordSelectionFormula = " {tblMPS_DCL_InitialInformation.DateTest} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //        else if (_applicant_status == "Technical") { cr1.DataDefinition.RecordSelectionFormula = " {tblMPS_DCL_InitialInformation.DateTechnical} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //        else if (_applicant_status == "Final") { cr1.DataDefinition.RecordSelectionFormula = " {tblMPS_DCL_InitialInformation.DateFinal} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }

            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "CREW PLANNED REPORT" || _reporttype == "CREW DISPATCH REPORT" || _reporttype == "CREW DISEMBARK REPORT")
            //    {
            //        cr1.DataDefinition.FormulaFields["ReportType"].Text = "'" + _reporttype + "'";

            //        if (_reporttype == "CREW PLANNED REPORT")
            //        {
            //            if (_principalid != 0)
            //            {
            //                if (_principalid == 123 || _principalid == 121) { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'MULTIPLAN INTERNATIONAL TECH. SERVICES LTD. - DREDGING INTERNATIONAL - " + _principalname + "'"; }
            //                else { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'" + _principalname + "'"; }

            //                cr1.DataDefinition.RecordSelectionFormula = " {tbldcl_crewstatus.Principalid} = " + _principalid + " AND {tblDCL_CrewStatus.Plandate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')";
            //            }
            //            else
            //            {
            //                cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'All Principal'";
            //                if (LoginUser.ismanager) { cr1.DataDefinition.RecordSelectionFormula = " UCASE({tblDCL_Principals.Company}) = '" + LoginUser.companycode + "' AND {tblDCL_CrewStatus.Plandate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //                else { cr1.DataDefinition.RecordSelectionFormula = " {tblDCL_Principals.AccountID} = " + LoginUser.accountid + " AND {tblDCL_CrewStatus.Plandate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //            }
            //        }
            //        else if (_reporttype == "CREW DISPATCH REPORT")
            //        {
            //            if (_principalid != 0)
            //            {
            //                if (_principalid == 123 || _principalid == 121) { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'MULTIPLAN INTERNATIONAL TECH. SERVICES LTD. - DREDGING INTERNATIONAL - " + _principalname + "'"; }
            //                else if (_principalid == 124) { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'Middle East Dredging Company QSC'"; }
            //                else { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'" + _principalname + "'"; }

            //                cr1.DataDefinition.RecordSelectionFormula = " {tbldcl_crewstatus.Principalid} = " + _principalid + " AND {tblDCL_CrewStatus.Dispatchdate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')";
            //            }
            //            else
            //            {
            //                cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'All Principal'";
            //                if (LoginUser.ismanager) { cr1.DataDefinition.RecordSelectionFormula = " UCASE({tblDCL_Principals.Company}) = '" + LoginUser.companycode + "' AND {tblDCL_CrewStatus.Dispatchdate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //                else { cr1.DataDefinition.RecordSelectionFormula = " {tblDCL_Principals.AccountID} = " + LoginUser.accountid + " AND {tblDCL_CrewStatus.Dispatchdate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //            }
            //        }
            //        else if (_reporttype == "CREW DISEMBARK REPORT")
            //        {
            //            if (_principalid != 0)
            //            {
            //                if (_principalid == 123 || _principalid == 121) { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'MULTIPLAN INTERNATIONAL TECH. SERVICES LTD. - DREDGING INTERNATIONAL - " + _principalname + "'"; }
            //                else { cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'" + _principalname + "'"; }

            //                cr1.DataDefinition.RecordSelectionFormula = " {tbldcl_crewstatus.Principalid} = " + _principalid + " AND {tblDCL_CrewStatus.DisembarkDate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')";
            //            }
            //            else
            //            {
            //                cr1.DataDefinition.FormulaFields["PrincipalName"].Text = "'All Principal'";
            //                if (LoginUser.ismanager) { cr1.DataDefinition.RecordSelectionFormula = " UCASE({tblDCL_Principals.Company}) = '" + LoginUser.companycode + "' AND {tblDCL_CrewStatus.DisembarkDate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //                else { cr1.DataDefinition.RecordSelectionFormula = " {tblDCL_Principals.AccountID} = " + LoginUser.accountid + " AND {tblDCL_CrewStatus.DisembarkDate} IN CDATE('" + _from.Date.ToString() + "') TO CDATE('" + _to.Date.ToString() + "')"; }
            //            }
            //        }

            //        cr1.DataDefinition.FormulaFields["DateRange"].Text = "'From " + _from.Date.ToString("MM/dd/yyyy") + " to " + _to.Date.ToString("MM/dd/yyyy") + "'";
            //        cr1.DataDefinition.FormulaFields["Preparedby"].Text = "'" + _prepared_by + "'";
            //        cr1.DataDefinition.FormulaFields["Notedby"].Text = "'" + _noted_by + "'";
            //        cr1.DataDefinition.FormulaFields["ApprovedBy"].Text = "'" + _approved_by + "'";

            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "RPS AMMENDMENT RE-ENGAGED" || _reporttype == "RPS AMMENDMENT ENGAGED")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["opt1"].Text = "'" + _x1 + "'";
            //        cr1.DataDefinition.FormulaFields["opt2"].Text = "'" + _x2 + "'";
            //        cr1.DataDefinition.FormulaFields["opt3"].Text = "'" + _x3 + "'";
            //        cr1.DataDefinition.FormulaFields["opt4"].Text = "'" + _x4 + "'";
            //        cr1.DataDefinition.FormulaFields["opt5"].Text = "'" + _x5 + "'";
            //        cr1.DataDefinition.FormulaFields["opt6"].Text = "'" + _x6 + "'";
            //        cr1.DataDefinition.FormulaFields["opt7"].Text = "'" + _x7 + "'";
            //        cr1.DataDefinition.FormulaFields["opt8"].Text = "'" + _x8 + "'";
            //        cr1.DataDefinition.FormulaFields["opt9"].Text = "'" + _x9 + "'";
            //        cr1.DataDefinition.FormulaFields["opt10"].Text = "'" + _x10 + "'";
            //        cr1.DataDefinition.FormulaFields["opt11"].Text = "'" + _x11 + "'";
            //        cr1.DataDefinition.FormulaFields["opt12"].Text = "'" + _x12 + "'";
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "RPS ENGAGED")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "RPS RE-ENGAGED")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "RPS AMMENDMENT")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["Ammendment"].Text = "'" + _rpstype + "'";
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "RPS")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "CERTIFICATE OF EMPLOYMENT" || _reporttype == "CERTIFICATE OF SEA SERVICE")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["FirstRemarks"].Text = "'" + Signatories.CMS.Notes1 + "'";
            //        cr1.DataDefinition.FormulaFields["Requestor"].Text = "'" + Signatories.CMS.Requestor + "'";
            //        cr1.DataDefinition.FormulaFields["SecondRemarks"].Text = "'" + Signatories.CMS.Notes2 + "'";
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "CREW BIODATA")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["CompanyCode"].Text = "'" + LoginUser.companycode + "'";
            //        cr1.DataDefinition.FormulaFields["ImagePath"].Text = "'" + DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".jpeg" + "'";
            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "INFOSHEET")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "Affidavit, No Collection of Fees")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (_principalid == 15) { goto Signatories_Path; }
            //        else { goto Report_Path; }
            //    }
            //    else if (_reporttype == "Addendum Reassigned")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (_principalid == 31) { goto Signatories_Path; }
            //        else { goto Report_Path; }
            //    }
            //    else if (_reporttype == "Employment contract Surveyor")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "EMPLOYMENT CONTRACT TERMS AND CONDITIONS")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "CERTIFICATE OF EMPLOYMENT")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["FirstRemarks"].Text = "'" + Signatories.CMS.Notes1 + "'";
            //        cr1.DataDefinition.FormulaFields["Requestor"].Text = "'" + Signatories.CMS.Requestor + "'";
            //        cr1.DataDefinition.FormulaFields["SecondRemarks"].Text = "'" + Signatories.CMS.Notes2 + "'";
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "MEMORANDUM OF UNDERSTANDING")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "ExtensionContract")
            //    {
            //        cr1.DataDefinition.FormulaFields["CrewName"].Text = "'" + _crewname + "'";
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "MRA Undertaking Jump Ship")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (LoginUser.companycode == "SMS")
            //        {
            //            cr1.DataDefinition.FormulaFields["WITNESS1"].Text = "'" + Signatories.CMS.Maker + "'";
            //            cr1.DataDefinition.FormulaFields["WITNESS2"].Text = "'" + Signatories.CMS.CoOwner + "'";
            //        }
            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "Amendment") { goto Signatories_Path; }
            //    else if (_reporttype == "Addendum undertaking to employment contract")
            //    {
            //        if (LoginUser.accountid == 15) { goto Signatories_Path; }
            //        else { goto Report_Path; }
            //    }
            //    else if (_reporttype == "Addendum Undertaking")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (_principalid == 17) { goto Signatories_Path; }
            //        else if (_principalid == 18) { goto Signatories_Path; }
            //        else if (_principalid == 21) { goto Signatories_Path; }
            //        else if (_principalid == 26)
            //        {
            //            if (_category == "SEABASED") { goto Signatories_Path; }
            //            else { goto Report_Path; }
            //        }
            //        else if (_principalid == 98)
            //        {
            //            if (_category == "SEABASED") { goto Signatories_Path; }
            //            else { goto Report_Path; }
            //        }
            //    }
            //    else if (_reporttype == "Addendum Notarial")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (LoginUser.accountid == 14) { goto Signatories_Path; }
            //        else
            //        {
            //            if (_principalid == 26)
            //            {
            //                if (_category == "SEABASED") { goto Signatories_Path; }
            //                else { goto Signatories_Path; }
            //            }
            //            else if (_principalid == 98)
            //            {
            //                if (_category == "SEABASED") { goto Signatories_Path; }
            //                else { goto Signatories_Path; }
            //            }
            //            else { goto Signatories_Path; }
            //        }
            //    }
            //    else if (_reporttype == "Addendum UndertakingTagalog")
            //    {

            //    }
            //    else if (_reporttype == "Addendum")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;

            //        if (_principalid == 18) { goto Signatories_Path; }
            //        else if (_principalid == 21) { goto Signatories_Path; }
            //        else if (_principalid == 15) { goto Signatories_Path; }
            //        else if (_principalid == 98 || _principalid == 121 || _principalid == 123 || _principalid == 124 || _principalid == 130)
            //        {
            //            if (_category == "LANDBASED") { goto Signatories_Path; }
            //            else { goto Report_Path; }
            //        }
            //        else if (_principalid == 26)
            //        {
            //            if (_category == "LANDBASED") { goto Signatories_Path; }
            //            else { goto Report_Path; }
            //        }
            //        else if (_principalid == 31)
            //        {
            //            cr1.DataDefinition.FormulaFields["VICE_PRESIDENT"].Text = "'" + Signatories.CMS.Vicepresident + "'";
            //            cr1.DataDefinition.FormulaFields["VICE_PRES_SIGNATORIES"].Text = "'" + Signatories.CMS.VicePresidentSignatories + "'";
            //            goto Signatories_Path;
            //        }
            //        else { goto Report_Path; }
            //    }
            //    else if (_reporttype == "NEW MRA CONTRACT LANDBASED SEABASED")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (LoginUser.accountid == 15)
            //        {
            //            if (_principalid == 26 || _principalid == 98)
            //            { goto Signatories_Path; }
            //            else { goto Report_Path; }
            //        }
            //        else if (LoginUser.accountid == 14) { goto Signatories_Path; }
            //        else { goto Report_Path; }
            //    }
            //    else if (_reporttype == "POEA CONTRACT")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        cr1.DataDefinition.FormulaFields["CBA"].Text = "'" + Signatories.CMS.CBA + "'";

            //        goto Signatories_Path;
            //    }
            //    else if (_reporttype == "WATCHLIST")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        goto Report_Path;
            //    }
            //    else if (_reporttype == "MRA CONTRACT")
            //    {
            //        cr1.DataDefinition.RecordSelectionFormula = _report.ReportLink;
            //        if (LoginUser.accountid == 14)
            //        {
            //            if (_category == "SEABASED")
            //            {
            //                cr1.DataDefinition.FormulaFields["CBA"].Text = "'" + Signatories.CMS.CBA + "'";
            //                goto Signatories_Path;
            //            }
            //            else
            //            {
            //                cr1.DataDefinition.FormulaFields["CompanyCode"].Text = "'" + LoginUser.companycode + "'";
            //                goto Signatories_Path;
            //            }
            //        }
            //        else if (LoginUser.accountid == 15)
            //        {
            //            if (_principalid == 26 || _principalid == 123 || _principalid == 121 || _principalid == 130)
            //            {
            //                if (_category == "SEABASED")
            //                {
            //                    cr1.DataDefinition.FormulaFields["VICE_PRESIDENT"].Text = "'" + Signatories.CMS.Vicepresident + "'";
            //                    cr1.DataDefinition.FormulaFields["VICE_PRES_SIGNATORIES"].Text = "'" + Signatories.CMS.VicePresidentSignatories + "'";
            //                    goto Signatories_Path;
            //                }
            //                else { }
            //            }
            //            else if (_principalid == 27) { goto Signatories_Path; }
            //            else if (_principalid == 31)
            //            {
            //                cr1.DataDefinition.FormulaFields["VICE_PRESIDENT"].Text = "'" + Signatories.CMS.Vicepresident + "'";
            //                cr1.DataDefinition.FormulaFields["VICE_PRES_SIGNATORIES"].Text = "'" + Signatories.CMS.VicePresidentSignatories + "'";
            //                goto Signatories_Path;
            //            }
            //            else if (_principalid == 98)
            //            {
            //                if (_category == "SEABASED") { goto Signatories_Path; }
            //                else { goto Signatories_Path; }
            //            }
            //            else if (_principalid == 142) { goto Signatories_Path; }
            //            else { goto Report_Path; }
            //        }
            //        else
            //        {
            //            if (_principalid == 15)
            //            {
            //                if (_category == "SEABASED")
            //                {
            //                    cr1.DataDefinition.FormulaFields["CBA"].Text = "'" + Signatories.CMS.CBA + "'";
            //                    goto Signatories_Path;
            //                }
            //                else { goto Signatories_Path; }
            //            }
            //            else if (_principalid == 21)
            //            { goto Signatories_Path; }
            //        }
            //    }

            //Signatories_Path:
            //    cr1.DataDefinition.FormulaFields["PRESIDENT"].Text = "'" + Signatories.CMS.President + "'";
            //    cr1.DataDefinition.FormulaFields["PRES_SIGNATORIES"].Text = "'" + Signatories.CMS.PresidentSignatories + "'";
            //    cr1.DataDefinition.FormulaFields["OPERATIONS_MANAGER"].Text = "'" + Signatories.CMS.OperationsManager + "'";
            //    cr1.DataDefinition.FormulaFields["OM_SIGNATORIES"].Text = "'" + Signatories.CMS.OperationsManagerSignatories + "'";
            //    cr1.DataDefinition.FormulaFields["ACCOUNTS_MANAGER"].Text = "'" + Signatories.CMS.AccountsHead + "'";
            //    cr1.DataDefinition.FormulaFields["AM_SIGNATORIES"].Text = "'" + Signatories.CMS.AccountsHeadSignatories + "'";
            //    cr1.DataDefinition.FormulaFields["ACCOUNTS_OFFICER"].Text = "'" + Signatories.CMS.AccountsOfficer + "'";
            //    cr1.DataDefinition.FormulaFields["AO_SIGNATORIES"].Text = "'" + Signatories.CMS.AccountsOfficerSignatories + "'";
            //    cr1.DataDefinition.FormulaFields["ACCOUNTS_SUPERVISOR"].Text = "'" + Signatories.CMS.AccountSupervisor + "'";
            //    cr1.DataDefinition.FormulaFields["AS_SIGNATORIES"].Text = "'" + Signatories.CMS.AccountSupervisorSignatories + "'";

            //Report_Path:
            //    ConnectionControl _connectioncontrol = new ConnectionControl();
            //    string _password = _connectioncontrol.Dcrypt(DCLSystemConfiguration.CMS.Password);
            //    GlobalToolsControl.Global.SetReportDataSource(DCLSystemConfiguration.CMS.Servername, DCLSystemConfiguration.CMS.Databasename, DCLSystemConfiguration.CMS.Username, _password, cr1);
            //    //SetReportDataSource(DCLSystemConfiguration.CMS.Servername, DCLSystemConfiguration.CMS.Databasename, DCLSystemConfiguration.CMS.Username, _password, cr1);

            //    CrysViewer.ReportSource = cr1;
            //    CrysViewer.Refresh();
            //    CrysViewer = null;

            //    if (_reporttype == "LANDBASED CV")
            //    {
            //        if (_savecv) { ExportToWordAuto(cr1); }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        

        private void ExportToWordAuto(ReportDocument _rd)
        {
            try
            {
                ReportDocument _reportdocument = new ReportDocument();
                _reportdocument = _rd;
                string _strexportfile = DCLSystemConfiguration.CMS.Imagepath + " CV-" + _applicantid.Substring(0, 4) + ".doc";
                _reportdocument.ExportToDisk(ExportFormatType.WordForWindows, _strexportfile);
                                
                _reportdocument.Export();
                _reportdocument = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    //     Sub ExportToWordAuto(ByVal cr1 As ReportDocument)
    //    Dim reportWord As New ReportDocument
    //    reportWord = cr1
    //    Dim strExportFile As String = GetImagePath() & local_appname & " CV-" & Microsoft.VisualBasic.Left(local_appid, 4) & ".doc"
    //    reportWord.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
    //    reportWord.ExportOptions.ExportFormatType = ExportFormatType.WordForWindows
    //    Dim objOptions As DiskFileDestinationOptions = New DiskFileDestinationOptions()
    //    objOptions.DiskFileName = strExportFile
    //    reportWord.ExportOptions.DestinationOptions = objOptions
    //    reportWord.Export()
    //    objOptions = Nothing
    //    reportWord = Nothing

    //    Call xManageproposedCandidate(local_candidate_id, local_appid, local_appname & " CV-" & Microsoft.VisualBasic.Left(local_appid, 4) & ".doc", GetImagePath(), Local_Mode)
    //End Sub
        private void GlobalReportViewerform_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
