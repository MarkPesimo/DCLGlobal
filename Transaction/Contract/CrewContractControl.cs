using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;
using DCLGlobal.Systems.Admin;
using DCLGlobal.Master.CrewInfo;
using DCLGlobal.Transaction.Contract;
using DCLGlobal.Reports;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Transaction.Contract
{
    public partial class CrewContractControl : UserControl
    {
        ToolsControl _tool = new ToolsControl();
        private int _crewstatusid;
        private int _crewid;
        private string _applicantid;
        private Crew _ThisCrew;
        private int _notesid;
        private int _crewstatus;
        CrewMasterform _parent;

        public int _principalid { get { return int.Parse( txtPrincipal.Tag.ToString()); }}

        public CrewContractControl(CrewMasterform Parent, int _Crewstatusid, int _Crewid, string _Applicantid)
        {
            InitializeComponent();

            _parent = Parent;
            _crewstatusid = _Crewstatusid;
            _crewid = _Crewid;
            _applicantid = _Applicantid;

            iCrew _icrew = new CMSFilesRepository.rCrew();
            _ThisCrew = _icrew.GetCrew(_applicantid);
        }

        public CrewContractControl()
        {
            InitializeComponent();
        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }

        private void tabGrid_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            ClearPanel(e.NewValue.Text);

            if (e.NewValue.Text == "On-Process")
            {
                var _control = new ContractOnprocessControl(_crewstatusid, this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "On-Board")
            {
                var _control = new ContractOnBoardControl(_crewstatusid, this);
                AddControl(_control, e.NewValue.Text);
            }
            else
            {
                var _control = new ContractOnVacationControl(_crewstatusid, this);
                AddControl(_control, e.NewValue.Text);
            }                                    
        }

        void AddControl(Control _control, string _status)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            if (_status == "On-Process") { PanOnProcess.Controls.Add(_control); }
            else if (_status == "On-Board") { panOnBoard.Controls.Add(_control); }
            else { panOnVacation.Controls.Add(_control); }

        }

        void ClearPanel(string _status)
        {
            if (_status == "On-Process") { PanOnProcess.Controls.Clear(); }
            else if (_status == "On-Board") { panOnBoard.Controls.Clear(); }
            else { panOnVacation.Controls.Clear(); }
        }

        private void CrewContractControl_Load(object sender, EventArgs e)
        {
            iContract _icontract = new CMSTransactionRepository.rContract();

            try 
            {
                DisplayRecord(_icontract.GetCrewRecord(_crewid, 0 ));
                DisplayNotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayRecord(CrewRecord _crewrecord)
        {            
            try
            {
                if (_crewrecord != null)
                {
                    _crewstatusid = _crewrecord.CrewStatusID;
                    txtPrincipal.Tag = _crewrecord.PrincipalID;
                    txtPrincipal.Text = _crewrecord.Principal.PrincipalDescription;
                    txtPosition.Tag = _crewrecord.PositionID;
                    txtPosition.Text = _crewrecord.Position.PositionName;
                    txtVessel.Tag = _crewrecord.VesselID;
                    txtVessel.Text = _crewrecord.Vessel.VesselDescription;
                    txtjobsite.Text = _crewrecord.Country.CountryName;
                    txtjobsite.Tag = _crewrecord.CountryId;

                    cboContractType.Text = _crewrecord.ContractType;
                    txtDurationMonth.Text = _crewrecord.ContractDuration;
                    txtDurationWeek.Text = _crewrecord.ContractWeeks.ToString();
                    txtDurationDay.Text = _crewrecord.ContractDays.ToString();

                    txtAllotementPercent.Text = _crewrecord.PERCENT_ALLOTEE.ToString();
                    if (_crewrecord.OEC_REMARKS == null) { cboOEC.SelectedIndex = 0; }
                    else
                    {
                        int _out;
                        if (int.TryParse(_crewrecord.OEC_REMARKS.ToString(), out _out))
                        {
                            if (int.Parse(_crewrecord.OEC_REMARKS.ToString()) > 3) { cboOEC.SelectedIndex = 0; }
                            else
                            {
                                if (int.Parse(_crewrecord.OEC_REMARKS.ToString()) == 0) { cboOEC.SelectedIndex = 0; }
                                else { cboOEC.SelectedIndex = int.Parse(_crewrecord.OEC_REMARKS.ToString()); }
                            }
                        }
                        else { cboOEC.SelectedIndex = 0; }
                    }

                    txtContractRemarks.Text = _crewrecord.ContractRemarks;
                    txtPOEAStatus.Text = _crewrecord.POEA_STATUS;
                    txtBadgeNo.Text = _crewrecord.BadgeNo;
                    txtCostcenter.Text = _crewrecord.CostCenter;
                    txtAirline.Text = _crewrecord.Airline;
                    txtAirtime.Text = _crewrecord.AirTime;
                    txtAirticket.Text = _crewrecord.AirTicket;

                    //hire status----------------------------------------------------------------------------------------------
                    iCrew _icrew = new CMSFilesRepository.rCrew();
                    Crew _crew = _icrew.GetCrew(_crewrecord.CrewID);
                    if (_crew != null)
                    {
                        if (_crew.ACTIVE_STATUS != null)
                        {
                            if (_crew.ACTIVE_STATUS == 1) { tssHireStatus.Text = "Hire Status : New Hire"; }
                            else { tssHireStatus.Text = "Hire Status : Rehire"; }
                        }
                        else { tssHireStatus.Text = "Hire Status : New Hire"; }
                    }
                    //---------------------------------------------------------------------------------------------------------

                    //IN DCLAPS------------------------------------------------------------------------------------------------
                    DCLAPSFilesInterface.iCrew _idcrew = new DCLAPSFilesRepository.rCrew();
                    DCLAPS_CREW _dcrew = _idcrew.GetCrew(_crewrecord.CrewID);
                    if (_dcrew != null) { tssDCLaps.Text = "In DCLaps : Yes"; }
                    else { tssDCLaps.Text = "In DCLaps : No"; }
                    //---------------------------------------------------------------------------------------------------------


                    //WITH DEBRIEFING------------------------------------------------------------------------------------------
                    iContract _icontract = new CMSTransactionRepository.rContract();
                    Debriefing _debriefing = _icontract.GetDebriefing(_crewrecord.CrewStatusID);
                    if (_debriefing != null) { tssWDebriefing.Text = "With Debriefing : Yes"; }
                    else { tssWDebriefing.Text = "With Debriefing : No"; }
                    //---------------------------------------------------------------------------------------------------------

                    if (_crewrecord.EstimateDispatchDate == null)
                    { txtGapPeriod.Text = "0.00"; }
                    else
                    {
                        DateTime _date1 = _crewrecord.PlanDate.Value;
                        DateTime _date2 = _crewrecord.EstimateDispatchDate.Value;

                        TimeSpan ts = Convert.ToDateTime(_date2) - Convert.ToDateTime(_date1);
                        txtGapPeriod.Text = Convert.ToDouble(string.Format("{0:00.000}", double.Parse(ts.TotalDays.ToString()))).ToString();
                    }

                    _crewstatus = _crewrecord.CrewStatus;

                    if (_crewrecord.CrewStatus == 1)
                    {
                        tssCurrentStatus.Text = "Current Status : On-Process";
                        tabGrid.SelectedTabIndex = 0;
                        ClearPanel("On-Process");
                        var _control = new ContractOnprocessControl(_crewstatusid, this);
                        AddControl(_control, "On-Process");
                    }
                    else if (_crewrecord.CrewStatus == 2)
                    {
                        tssCurrentStatus.Text = "Current Status : On-Board";
                        tabGrid.SelectedTabIndex = 1;
                        ClearPanel("On-Board");
                        var _control = new ContractOnBoardControl(_crewstatusid, this);
                        AddControl(_control, "On-Board");
                    }
                    else if (_crewrecord.CrewStatus == 3)
                    {
                        tssCurrentStatus.Text = "Current Status : On-Vacation";
                        tabGrid.SelectedTabIndex = 2;
                        ClearPanel("On-Vacation");
                        var _control = new ContractOnVacationControl(_crewstatusid, this);
                        AddControl(_control, "On-Vacation");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Edit_btn_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void PanOnProcess_Click(object sender, EventArgs e)
        {

        }

        #region ReportCode
        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (_tool.CheckFormAleadyOpen("Signatoriesform")) { return; }
            Signatoriesform _Signatoriesform = new Signatoriesform();
            _Signatoriesform.ShowDialog();
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform(LoginUser.companycode == "SMS" ? "POEA CONTRACT" : "MRA CONTRACT");
            _viewer._crewstatusid = _crewstatusid;
            _viewer._crewid = _crewid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer._applicantid = _applicantid;
            _viewer.Show();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("NEW MRA CONTRACT LANDBASED SEABASED");
            _viewer._crewstatusid = _crewstatusid;
            _viewer._crewid = _crewid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer._applicantid = _applicantid;
            _viewer.Show();
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Addendum");
            _viewer._crewstatusid = _crewstatusid;
            _viewer._crewid = _crewid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer._applicantid = _applicantid;
            _viewer.Show();
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Addendum Undertaking");
            _viewer._crewid = _crewid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer.Show();
        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Addendum Notarial");
            _viewer._crewid = _crewid;
            _viewer._crewstatusid = _crewstatusid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer.Show();
        }

        private void buttonItem51_Click(object sender, EventArgs e)
        {

            //spliethoff
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Addendum UndertakingTagalog");
            _viewer._crewid = _crewid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer.Show();
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Addendum undertaking to employment contract");
            _viewer._crewid = _crewid;
            _viewer._crewstatusid = _crewstatusid;
            _viewer._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _viewer.Show();
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Amendment");
            _viewer.Show();
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("ExtensionContract");
            _viewer._crewname = _ThisCrew.FirstName + " " + _ThisCrew.MiddleName.Substring(0, 1) + " " + _ThisCrew.LastName;
            _viewer.Show();
        }

        private void buttonItem24_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("MEMORANDUM OF UNDERSTANDING");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem25_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("CERTIFICATE OF EMPLOYMENT");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("EMPLOYMENT CONTRACT TERMS AND CONDITIONS");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Employment contract Surveyor");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem29_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Addendum Reassigned");
            _viewer._crewid = _crewid;
            _viewer._crewstatusid = _crewstatusid;
            _viewer._principalid = _principalid;
            _viewer.Show();
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("MRA Undertaking Jump Ship");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem30_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Affidavit, No Collection of Fees");
            _viewer._crewid = _crewid;
            _viewer._crewstatusid = _crewstatusid;
            _viewer._principalid = _principalid;
            _viewer.Show();
        }

        private void buttonItem52_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("Allotment");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("INFOSHEET");
            _viewer._principalid = _principalid;
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("CREW BIODATA");
            _viewer._applicantid = _applicantid;
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            if (LoginUser.companycode == "MRA") 
            {
                GlobalReportViewerform _viewer = new GlobalReportViewerform("CERTIFICATE OF EMPLOYMENT");
                _viewer._crewid = _crewid;
                _viewer.Show();
            }
            else 
            {
                GlobalReportViewerform _viewer = new GlobalReportViewerform("CERTIFICATE OF SEA SERVICE");
                _viewer._principalid = _principalid;
                _viewer._crewid = _crewid;
                _viewer.Show();
            }
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("RPS");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem34_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("NameSpelling");
        }

        void RPSAmmendmentReport(string _type)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("RPS AMMENDMENT");
            _viewer._rpstype = _type;
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem35_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("PositionRank");
        }

        private void buttonItem36_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("ContractDuration");
        }

        private void buttonItem37_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("ContractContinuation");
        }

        private void buttonItem38_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("VesselTransfer");
        }

        private void buttonItem39_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("Salary");
        }

        private void buttonItem40_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("ReIssuance");
        }

        private void buttonItem41_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("ChangePrincipal");
        }

        private void buttonItem42_Click(object sender, EventArgs e)
        {
            RPSAmmendmentReport("Change Management");
        }

        private void buttonItem45_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("RPS RE-ENGAGED");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem46_Click(object sender, EventArgs e)
        {
            GlobalReportViewerform _viewer = new GlobalReportViewerform("RPS ENGAGED");
            _viewer._crewid = _crewid;
            _viewer.Show();
        }

        private void buttonItem47_Click(object sender, EventArgs e)
        {
            rpsAmmendmentform _rps = new rpsAmmendmentform(_crewid, "RPS AMMENDMENT RE-ENGAGED");
            _rps.ShowDialog();
        }

        private void buttonItem48_Click(object sender, EventArgs e)
        {
            rpsAmmendmentform _rps = new rpsAmmendmentform(_crewid, "RPS AMMENDMENT ENGAGED");
            _rps.ShowDialog();            
        }
        #endregion

        private void bntPrincipal_Click(object sender, EventArgs e)
        {
            //txtPrincipal.Text = "";
            //txtPrincipal.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PRINCIPAL;
            _Searchform.ShowDialog();

            //Principal _principal = _Searchform.ReturnSearchPrincipal;
            //if (_principal != null)            
            //{
            //    txtVessel.Text = "";
            //    txtVessel.Tag = 0;
            //    txtPosition.Text = "";
            //    txtPosition.Tag = 0;

            //    txtPrincipal.Text = _principal.PrincipalDescription;
            //    txtPrincipal.Tag = _principal.PrincipalID;
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntPosition_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select a principal first", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrincipal.Focus();
                return;
            }
            txtPosition.Text = "";
            txtPosition.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _Searchform._searchby = searchby.CMS.POSITION;
            _Searchform.ShowDialog();

            //Position _position = _Searchform.ReturnSearchPosition;
            //if (_position != null)
            //{
            //    txtPosition.Text = _position.PositionName;
            //    txtPosition.Tag = _position.PositionID;
            //}
        }

        private void btnVessel_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select a principal first", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrincipal.Focus();
                return;
            }
            
            //txtVessel.Text = "";
            //txtVessel.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _Searchform._searchby = searchby.CMS.VESSEL;
            _Searchform.ShowDialog();

            //Vessel _vessel = _Searchform.ReturnSearchVessel;
            //if (_vessel != null)
            //{
            //    txtVessel.Text = _vessel.VesselDescription;
            //    txtVessel.Tag = _vessel.VesselID;
            //}
        }

        private void btnJobsite_Click(object sender, EventArgs e)
        {            
            txtjobsite.Text = "";
            txtjobsite.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtjobsite.Text = _country.CountryName;
            //    txtjobsite.Tag = _country.ID;
            //}
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {

        }

        private void rPSDefaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNotes.SelectedItems.Count == 0) { return; }
            try 
            { 
                _notesid = int.Parse( lsvNotes.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ManageCrewStatusNotes(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageCrewStatusNotes(int _mode)
        {            
            iCrewstatusNotes _icrewstatusnotes = new CMSFilesRepository.rCrewStatusNotes();
            CREWSTATUS_NOTE _crewstatusnote = new CREWSTATUS_NOTE();
            try 
            {
                _crewstatusnote.CrewStatusId = _crewstatusid;
                _crewstatusnote.id = _notesid;
                _crewstatusnote.Remarks = txtNotes.Text;
                _crewstatusnote.UserId = LoginUser.userid;

                _notesid = _icrewstatusnotes.ManageCrewStatusNotes(_crewstatusnote, _mode);

                DisplayNotes();
                add_btn.Visible = true;
                save_btn.Visible = false;
                lsvNotes.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayNotes()
        {
            iCrewstatusNotes _icrewstatusnotes = new CMSFilesRepository.rCrewStatusNotes();
            try
            {
                lsvNotes.Items.Clear();
                List<CREWSTATUS_NOTE> _crewstatusnotes = _icrewstatusnotes.GetCrewStatusNotes(_crewstatusid);
                foreach (CREWSTATUS_NOTE _list in _crewstatusnotes)
                {
                    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    _item.SubItems.Add(_list.Remarks);
                    _item.SubItems.Add(_list.User.UserName);

                    lsvNotes.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtNotes.Text = "";
            lsvNotes.Visible = false;   
            txtNotes.Focus();

            save_btn.Visible = true;
            add_btn.Visible = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtNotes.Text == "")
                {
                    btxMsg.ShowBalloon(txtNotes);
                    txtNotes.Focus();
                    return;
                }

                ManageCrewStatusNotes(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void requestToAttendAPASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this,  "REQUEST FOR APAS", SystemModuleType.System) == false) { return; }

            try
            {
                if (_crewstatus != 1)
                {
                    ToolsControl.CallPopMessage(this, "Information", "Crew must be on process/planned to schedule a APAS");
                    return;
                }

                ScheduleAPASform _scheduleapas = new ScheduleAPASform(DateTime.Now, _crewstatusid, _applicantid, "");
                _scheduleapas.BringToFront();
                _scheduleapas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reAssessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "REQUEST FOR APAS", SystemModuleType.System) == false) { return; }

            if (_crewstatus != 3)
            {
                ToolsControl.CallPopMessage(this, "Information", "Only onvacation crew can be Reassess.");
                return;
            }

            if (MessageBox.Show("Reassess this crew, Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            try
            {
                iContract _icontract = new CMSTransactionRepository.rContract();
                _icontract.ReassessCrew(_crewstatusid);

                ToolsControl.CallShowNotification(this, 5, "Crew Successfully reassess.");

                _parent.btnbiodataclick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void debriefingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_crewstatus != 3)
            {
                ToolsControl.CallPopMessage(this, "Information", "Only those crew tagged as on-vacation, can access debriefing report");
                return;
            }

            try
            {
                Debriefingform _debriefing = new Debriefingform(_crewstatusid, _crewid, _applicantid, int.Parse( txtPrincipal.Tag.ToString()));
                _debriefing.BringToFront();
                _debriefing.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personnalDataFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginUser.accountid != 30)
            {
                ToolsControl.CallPopMessage(this, "Information", "This module is not available on this account");
                return;
            }

            try
            {
                ReportControl.CMS _reportcontrol = new ReportControl.CMS();
                _reportcontrol.PrintPersonnalDataForm(_crewid, _applicantid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
