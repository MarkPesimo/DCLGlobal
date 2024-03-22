using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;
using DCLGlobal.Transaction.Contract;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewExperienceControl : UserControl
    {
        public int _crewid = 0;
        public int _crewstatusid = 0;
        public string _applicantid = "";
        int _id = 0;
        int _mode = 0;

        public CrewExperienceControl(int Crewid, int Crewstatusid, string Applicantid)
        {
            _crewid = Crewid;
            _crewstatusid = Crewstatusid;
            _applicantid = Applicantid;
            InitializeComponent();
        }

        void DisplayList()
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();

            try 
            {
                lsvList.Items.Clear();
                List<CrewRecord> _crewrecords = _icrew.GetCrewHistoryRecords(_crewid);
                foreach (CrewRecord _list in _crewrecords)
                {
                    ListViewItem _item = new ListViewItem(_list.CrewStatusID.ToString());
                    _item.SubItems.Add(_list.Principal.PrincipalDescription);
                    _item.SubItems.Add(_list.Vessel.VesselDescription);
                    _item.SubItems.Add(_list.Position.PositionName);
                    if (_list.DispatchDate == null) { _item.SubItems.Add(""); }
                    else { _item.SubItems.Add(_list.DispatchDate.Value.Date.ToString("MM/dd/yyyy"));  }
                    
                    if (_list.DisembarkDate == null) { _item.SubItems.Add(""); } 
                    else { _item.SubItems.Add(_list.DisembarkDate.Value.Date.ToString("MM/dd/yyyy")); }

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void displayRecord(CrewRecord _crewrecord)
        {
            try
            {
                if (_crewrecord != null)
                {
                    _id = _crewrecord.CrewStatusID;
                    
                    txtRegistrationNo.Text = _crewrecord.JobOrderNo;
                    
                    if (_crewrecord.JobOrderValidity == null ) { dtpValidity.Checked = false; }
                    else
                    {
                        dtpValidity.Checked = true;
                        dtpValidity.Value = _crewrecord.JobOrderValidity.Value.Date;
                    }
                    

                    txtPrincipal.Text = _crewrecord.Principal.PrincipalDescription;
                    txtPrincipal.Tag = _crewrecord.PrincipalID.ToString();
                    txtVessel.Text = _crewrecord.Vessel.VesselDescription;
                    txtVessel.Tag = _crewrecord.VesselID.ToString();
                    txtPosition.Text = _crewrecord.Position.PositionName;
                    txtPosition.Tag = _crewrecord.PositionID;
                    txtJobsite.Text = _crewrecord.Country.CountryName;
                    txtJobsite.Tag = _crewrecord.CountryId.ToString();

                    cboContractType.Text = _crewrecord.ContractType;
                    txtMonth.Text = _crewrecord.ContractDuration == null ? "0" : _crewrecord.ContractDuration.ToString();
                    txtWeek.Text = _crewrecord.ContractWeeks == null  ? "0" : _crewrecord.ContractWeeks.ToString();
                    txtDay.Text = _crewrecord.ContractDays == null ? "0" : _crewrecord.ContractDays.ToString();
                    txtRemarks.Text = _crewrecord.ContractRemarks;

                    txtPercentAllottee.Text = _crewrecord.PERCENT_ALLOTEE == null ? "0" : _crewrecord.PERCENT_ALLOTEE.ToString();
                    txtPOEAStatus.Text = _crewrecord.POEA_STATUS;

                    if (_crewrecord.OEC_REMARKS == null) { cboEOCRemark.SelectedIndex = 0; }
                    else
                    {
                        cboEOCRemark.SelectedIndex = _crewrecord.OEC_REMARKS == 0 ? 0 :  int.Parse(_crewrecord.OEC_REMARKS.ToString()) - 1;
                    }

                    txtAirline.Text = _crewrecord.Airline;
                    txtAirticket.Text = _crewrecord.AirTicket;
                    txtAirtime.Text = _crewrecord.AirTime;
                    txtBadgeNo.Text = _crewrecord.BadgeNo;
                    txtCostCenter.Text = _crewrecord.CostCenter;


                    //planned
                    if (_crewrecord.PlanDate == null) { dtpDatePlanned.Checked = false; }
                    else { dtpDatePlanned.Checked = true; dtpDatePlanned.Value = _crewrecord.PlanDate.Value.Date; }

                    if (_crewrecord.EstimateDispatchDate == null) { dtpETD.Checked = false; }
                    else { dtpETD.Checked = true; dtpETD.Value = _crewrecord.EstimateDispatchDate.Value.Date; }

                    if (_crewrecord.Projected_Readiness == null) { dtpProjectedReadiness.Checked = false; }
                    else { dtpProjectedReadiness.Checked = true; dtpProjectedReadiness.Value = _crewrecord.Projected_Readiness.Value.Date; }

                    if (_crewrecord.Last_Date_Reported == null) { dtpLastDateReported.Checked = false; }
                    else { dtpLastDateReported.Checked = true; dtpLastDateReported.Value = _crewrecord.Last_Date_Reported.Value.Date; }

                    txtPlannedPort.Text = _crewrecord.PlanPort;
                    txtPlanRemarks.Text = _crewrecord.PlanRemarks;

                    if (_crewrecord.WORK_ROTATION_id != null)
                    {
                        if (_crewrecord.WORK_ROTATION_id.ToString() != "") { cboWorkStation.SelectedIndex = int.Parse( _crewrecord.WORK_ROTATION_id.ToString()) - 1; }
                    }
                    else { cboWorkStation.SelectedIndex = 0; }

                    iCrew _icrew = new CMSFilesRepository.rCrew();
                    Crew _crew = new Crew();
                    if (_crewrecord.OnSigner == null) { txtOffsigner.Text = ""; txtOffsigner.Tag = 0; }
                    else
                    {
                        txtOffsigner.Tag = _crewrecord.OnSigner;
                        _crew = _icrew.GetCrew(int.Parse( _crewrecord.OnSigner.ToString()));
                        if (_crew != null) { txtOffsigner.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName; }
                        else { txtOffsigner.Text = ""; }
                    }


                    //dispatched
                    if (_crewrecord.DispatchDate == null) { dtpDispatch.Checked = false; }
                    else { dtpDispatch.Checked = true; dtpDispatch.Value = _crewrecord.DispatchDate.Value.Date; }

                    if (_crewrecord.DueDate == null) { dtpDateDue.Checked = false; }
                    else { dtpDateDue.Checked = true; dtpDateDue.Value = _crewrecord.DueDate.Value.Date; }

                    txtDispatchPort.Text = _crewrecord.DispatchPort;
                    txtDispatchRemarks.Text = _crewrecord.DispatchRemarks;

                    _icrew = new CMSFilesRepository.rCrew();
                    _crew = new Crew();
                    if (_crewrecord.Reliever == null) { txtReliever.Text = ""; txtOffsigner.Tag = 0; }
                    else
                    {
                        txtReliever.Tag = _crewrecord.Reliever;
                        _crew = _icrew.GetCrew(int.Parse(_crewrecord.Reliever.ToString()));
                        if (_crew != null) { txtReliever.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName; }
                        else { txtReliever.Text = ""; }
                    }

                    if (_crewrecord.DisembarkDate == null) { dtpDisembark.Checked = false; }
                    else { dtpDisembark.Checked = true; dtpDisembark.Value = _crewrecord.DisembarkDate.Value.Date; }

                    if (_crewrecord.DateDeparted == null) { dtpDateDeparture.Checked = false; }
                    else { dtpDateDeparture.Checked = true; dtpDateDeparture.Value = _crewrecord.DateDeparted.Value.Date; }

                    if (_crewrecord.DateArrived == null) { dtpDateArrival.Checked = false; }
                    else { dtpDateArrival.Checked = true; dtpDateArrival.Value = _crewrecord.DateArrived.Value.Date; }

                    if (_crewrecord.DateReported == null) { dtpDateReported.Checked = false; }
                    else { dtpDateReported.Checked = true; dtpDateReported.Value = _crewrecord.DateReported.Value.Date; }

                    if (_crewrecord.DateAvailability == null) { dtpDateAvailability.Checked = false; }
                    else { dtpDateAvailability.Checked = true; dtpDateAvailability.Value = _crewrecord.DateAvailability.Value.Date; }

                    txtDisembarkPort.Text = _crewrecord.DisembarkPort;
                    txtDisembarkReason.Text = _crewrecord.Remarks;
                    txtDisembarkRemarks.Text = _crewrecord.Remarks2;

                    if (_crewrecord.NextVessel == null) { txtNextVessel.Text = ""; txtNextVessel.Tag = 0; }
                    else 
                    {
                        txtNextVessel.Tag = _crewrecord.NextVessel;
                        iVessel _ivessel = new CMSFilesRepository.rVessel();
                        Vessel _vessel = new Vessel();
                        if (int.Parse(_crewrecord.NextVessel.ToString()) == 0) { txtNextVessel.Text = ""; }
                        else 
                        {
                            _vessel = _ivessel.GetVessel(int.Parse(_crewrecord.NextVessel.ToString()));
                            if (_vessel != null) { txtNextVessel.Text = _vessel.VesselDescription; }
                            else { txtNextVessel.Text = ""; }
                        }                        
                    }

                    iContract _icontract = new CMSTransactionRepository.rContract();
                    if (_icontract.GetDebriefing(_id) != null) { lblDebriefing.Visible = true; }
                    else { lblDebriefing.Visible = false; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtRegistrationNo.Text = "";

            txtPrincipal.Text = ""; txtPrincipal.Tag = 0;
            txtVessel.Text = ""; txtVessel.Tag = 0;
            txtPosition.Text = ""; txtPosition.Tag = 0;
            txtJobsite.Text = ""; txtJobsite.Tag = 0;

            cboContractType.SelectedIndex = 0;
            txtMonth.Text = ""; txtWeek.Text = ""; txtDay.Text = "";

            txtRemarks.Text = "";
            txtPercentAllottee.Text = "100";
            txtPOEAStatus.Text = "";
            cboEOCRemark.SelectedIndex = 0;
            txtBadgeNo.Text = "";

            txtCostCenter.Text = "";
            txtAirline.Text = "";
            txtAirticket.Text = "";
            txtAirtime.Text = "";

            //lblDebriefing.Text = "";


            dtpDatePlanned.Checked = false;
            dtpETD.Checked = false;
            dtpProjectedReadiness.Checked = false;
            dtpLastDateReported.Checked = false;
            txtPlannedPort.Text = "";
            txtPlanRemarks.Text = "";
            cboWorkStation.SelectedIndex = 0;
            txtOffsigner.Text = ""; txtOffsigner.Tag = 0;

            dtpDispatch.Checked = false;
            dtpDateDue.Checked = false;
            txtDispatchPort.Text = "";
            txtDispatchRemarks.Text = "";
            txtReliever.Text = ""; txtReliever.Tag = 0;

            dtpDisembark.Checked = false;
            dtpDateDeparture.Checked = false;
            dtpDateArrival.Checked = false;
            dtpDateReported.Checked = false;
            dtpDateAvailability.Checked = false;
            txtDisembarkPort.Text = "";
            txtDisembarkReason.Text = ""; txtDisembarkReason.Tag = 0;
            txtDisembarkRemarks.Text = "";
            txtNextVessel.Text = ""; txtNextVessel.Tag = 0;
        }

        void EnableForm(bool _cond)
        {
            txtRegistrationNo.ReadOnly = !_cond;
            dtpValidity.Enabled = _cond;

            cboContractType.Enabled= _cond;
            txtMonth.ReadOnly = !_cond;
            txtWeek.ReadOnly = !_cond;
            txtDay.ReadOnly = !_cond;

            txtRemarks.ReadOnly = !_cond;
            txtPercentAllottee.ReadOnly = !_cond;
            txtPOEAStatus.ReadOnly = !_cond;
            cboEOCRemark.Enabled = _cond;
            txtBadgeNo.ReadOnly = !_cond;

            txtCostCenter.ReadOnly = !_cond;
            txtAirline.ReadOnly = !_cond;
            txtAirticket.ReadOnly = !_cond;
            txtAirtime.ReadOnly = !_cond;


            dtpDatePlanned.Enabled = _cond;
            dtpETD.Enabled = _cond;
            dtpProjectedReadiness.Enabled = _cond;
            dtpLastDateReported.Enabled = _cond;
            txtPlanRemarks.ReadOnly = !_cond;
            cboWorkStation.Enabled = _cond;

            dtpDispatch.Enabled = _cond;
            dtpDateDue.Enabled = _cond;
            txtDispatchRemarks.ReadOnly = !_cond;

            dtpDisembark.Enabled = _cond;
            dtpDateDeparture.Enabled = _cond;
            dtpDateArrival.Enabled = _cond;
            dtpDateReported.Enabled = _cond;
            dtpDateAvailability.Enabled = _cond;

            txtDisembarkRemarks.ReadOnly = !_cond;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;
            debrief_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_CONTRACT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtRegistrationNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_CONTRACT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtRegistrationNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_CONTRACT, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Delete this crew Expierience, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            try
            {
                _mode = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillWorkRotation()
        {
            iWorkRotation _iworkstation = new CMSFilesRepository.rWorkRotation();
            try
            {
                cboWorkStation.DataSource = null;
                List<WorkRotationTable> _list = _iworkstation.GetWorkRotations("", "All");
                cboWorkStation.DataSource = _list;
                cboWorkStation.DisplayMember = "WorkRotationName";
                cboWorkStation.ValueMember = "id";
                cboWorkStation.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrewExperienceControl_Load(object sender, EventArgs e)
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            try
            {
                FillWorkRotation();
                displayRecord(_icrew.GetCrewHistoryRecord(0, _crewid));
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }
            iCrew _icrew = new CMSFilesRepository.rCrew();
            try
            {
                displayRecord(_icrew.GetCrewHistoryRecord(int.Parse(lsvList.SelectedItems[0].Text), _crewid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

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

        private void btnVessel_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            if (txtPrincipal.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select a principal first", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrincipal.Focus();
                return;
            }

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

        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

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

        private void jobsitebtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtJobsite.Text = "";
            txtJobsite.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtJobsite.Text = _country.CountryName;
            //    txtJobsite.Tag = _country.ID;
            //}
        }

        private void planportbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }
            txtPlannedPort.Text = "";
            txtPlannedPort.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PORT;
            _Searchform.ShowDialog();

            //Port _port = _Searchform.ReturnSearchPort;
            //if (_port != null)
            //{
            //    txtPlannedPort.Text = _port.PortName;
            //    txtPlannedPort.Tag = _port.PortID;
            //}
        }

        private void Offsignerbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtOffsigner.Text = "";
            txtOffsigner.Tag = 0;

            Searchform _Searchform = new Searchform(2, int.Parse(txtPrincipal.Tag.ToString()));
            _Searchform._searchby = searchby.CMS.OFFSIGNER;
            _Searchform.ShowDialog();

            //Crew _crew = _Searchform.ReturnSearchCrew;
            //if (_crew != null)
            //{
            //    txtOffsigner.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
            //    txtOffsigner.Tag = _crew.CrewId;
            //}
        }

        private void dispatchportbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }
            
            txtDispatchPort.Text = "";
            txtDispatchPort.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PORT;
            _Searchform.ShowDialog();

            //Port _port = _Searchform.ReturnSearchPort;
            //if (_port != null)
            //{
            //    txtDispatchPort.Text = _port.PortName;
            //    txtDispatchPort.Tag = _port.PortID;
            //}
        }

        private void relieverbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtReliever.Text = "";
            txtReliever.Tag = 0;

            Searchform _Searchform = new Searchform(1, int.Parse(txtPrincipal.Tag.ToString()));
            _Searchform._searchby = searchby.CMS.OFFSIGNER;
            _Searchform.ShowDialog();

            //Crew _crew = _Searchform.ReturnSearchCrew;
            //if (_crew != null)
            //{
            //    txtReliever.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
            //    txtReliever.Tag = _crew.CrewId;
            //}
        }

        private void DisembarkPortbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtDisembarkPort.Text = "";
            txtDisembarkPort.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PORT;
            _Searchform.ShowDialog();

            //Port _port = _Searchform.ReturnSearchPort;
            //if (_port != null)
            //{
            //    txtDisembarkPort.Text = _port.PortName;
            //    txtDisembarkPort.Tag = _port.PortID;
            //}
        }

        private void DisembarkReasonbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtDisembarkReason.Text = "";
            txtDisembarkReason.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.DISEMBARK_REASON;
            _Searchform.ShowDialog();

            //DisembarkReason _reason = _Searchform.ReturnSearchDisembarkReason;
            //if (_reason != null)
            //{
            //    txtDisembarkReason.Text = _reason.Reason;
            //    txtDisembarkReason.Tag = _reason.id;
            //}
        }

        private void nextVesselbtn_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtNextVessel.Text = "";
            txtNextVessel.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._principalid = int.Parse(txtPrincipal.Tag.ToString());
            _Searchform._searchby = searchby.CMS.VESSEL;
            _Searchform.ShowDialog();

            //Vessel _vessel = _Searchform.ReturnSearchVessel;
            //if (_vessel != null)
            //{
            //    txtNextVessel.Text = _vessel.VesselDescription;
            //    txtNextVessel.Tag = _vessel.VesselID;
            //}
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            try
            {
                EnableForm(false);
                EnableButton(true);
                displayRecord(_icrew.GetCrewRecord(_id, _crewid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtPrincipal);
                txtPrincipal.Focus();
                return;
            }
            if (txtVessel.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtVessel);
                txtVessel.Focus();
                return;
            }
            if (txtPosition.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtPosition);
                txtPosition.Focus();
                return;
            }
            if (txtJobsite.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtJobsite);
                txtJobsite.Focus();
                return;
            }
            if (txtPlannedPort.Text == "")
            {
                btxMsg.ShowBalloon(txtPlannedPort);
                txtPlannedPort.Focus();
                return;
            }
            if (txtDispatchPort.Text == "")
            {
                btxMsg.ShowBalloon(txtDispatchPort);
                txtDispatchPort.Focus();
                return;
            }
            if (txtDisembarkPort.Text == "")
            {
                btxMsg.ShowBalloon(txtDisembarkPort);
                txtDisembarkPort.Focus();
                return;
            }

            try
            {
                ManageCrewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageCrewRecord()
        {
            iContract _icontract = new CMSTransactionRepository.rContract();
            CrewRecord _crewrecord = new CrewRecord();

            try
            {
                _crewrecord.CrewStatusID = _id;
                _crewrecord.CrewID = _crewid;
                _crewrecord.PrincipalID = int.Parse( txtPrincipal.Tag.ToString());
                _crewrecord.VesselID  = int.Parse( txtVessel.Tag.ToString());
                _crewrecord.PositionID = int.Parse( txtPosition.Tag.ToString());
                _crewrecord.Jobsite = txtJobsite.Text;
                _crewrecord.PlanDate = dtpDatePlanned.Value;
                _crewrecord.DispatchDate = dtpDispatch.Value;
                _crewrecord.DueDate = dtpDateDue.Value;
                _crewrecord.DisembarkDate = dtpDisembark.Value;
                _crewrecord.DateDeparted = dtpDateDeparture.Value;
                _crewrecord.DateArrived = dtpDateArrival.Value;
                _crewrecord.DateReported = dtpDateReported.Value;
                _crewrecord.ContractDuration = txtMonth.Text;
                _crewrecord.ContractRemarks = txtRemarks.Text;
                _crewrecord.PlanPort = txtPlannedPort.Text;
                _crewrecord.DispatchPort = txtDispatchPort.Text;
                _crewrecord.DisembarkPort = txtDisembarkPort.Text;
                _crewrecord.ArrivalPort = txtDisembarkPort.Text;
                _crewrecord.Remarks = "";
                _crewrecord.Remarks2 = "";
                _crewrecord.PERCENT_ALLOTEE = int.Parse( txtPercentAllottee.Text);
                _crewrecord.Airline = txtAirline.Text;
                _crewrecord.AirTime = txtAirtime.Text;
                _crewrecord.AirTicket = txtAirticket.Text;
                _crewrecord.BadgeNo = txtBadgeNo.Text;
                _crewrecord.CostCenter = txtCostCenter.Text;
                _crewrecord.JobOrderNo = txtJobsite.Text;
                _crewrecord.JobOrderValidity = dtpValidity.Value;
                _crewrecord.ContractWeeks = int.Parse( txtWeek.Text);
                _crewrecord.ContractDays = int.Parse( txtDay.Text);
                _crewrecord.DateAvailability = dtpDateAvailability.Value;
                _crewrecord.ContractType = cboContractType.Text;

                _id = _icontract.ManageCrewRecord(_crewrecord, _mode);
                Cancel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void debrief_btn_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to debrief.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Debriefingform _debriefingform = new Debriefingform(_id, _crewid, _applicantid, int.Parse( txtPrincipal.Tag.ToString()));
                _debriefingform.BringToFront();
                _debriefingform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
