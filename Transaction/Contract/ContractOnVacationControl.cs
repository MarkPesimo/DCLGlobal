using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;
using CAL.Global;
using CAL.Model;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Master.CrewInfo;

namespace DCLGlobal.Transaction.Contract
{
    public partial class ContractOnVacationControl : UserControl
    {
        private int _crewstatusid;

        int _mode = 0;
        int _crewid = 0;
        //string _applicantid = "";
        int _status;
        int _current_principal;
        CrewContractControl _parent;

        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        iFiles _ifiles = new FilesRepository();
        //iTransaction _itransaction = new TransactionRepository(DCLSystemConfiguration.Connection);
        //iCrew _icrew = new CrewRepository(DCLSystemConfiguration.Connection);
        //iContract _icontract = new ContractRepositroy(DCLSystemConfiguration.Connection);

        public ContractOnVacationControl(int _Crewstatusid, CrewContractControl _Parent)
        {
            InitializeComponent();
            _crewstatusid = _Crewstatusid;
            _parent = _Parent;
        }

        public void DisplayRecord(CrewRecord _crewrecord)
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            Crew _crew = new Crew();
            try
            {
                if (_crewrecord != null)
                {
                    _status = _crewrecord.CrewStatus;
                    _current_principal = _crewrecord.PrincipalID;

                    if (_crewrecord.DisembarkDate == null) { dtpDisembarkDate.Checked = false; }
                    else { dtpDisembarkDate.Value = _crewrecord.DisembarkDate.Value; }

                    if (_crewrecord.DateDeparted == null) { dtpDateDeparture.Checked = false; }
                    else { dtpDateDeparture.Value = _crewrecord.DateDeparted.Value; }

                    if (_crewrecord.DateArrived == null) { dtpDateArrival.Checked = false; }
                    else { dtpDateArrival.Value = _crewrecord.DateArrived.Value; }

                    if (_crewrecord.DateReported == null) { dtpDateReported.Checked = false; }
                    else { dtpDateReported.Value = _crewrecord.DateReported.Value; }

                    if (_crewrecord.DateAvailability == null) { dtpDateAvailability.Checked = false; }
                    else { dtpDateAvailability.Value = _crewrecord.DateAvailability.Value; }

                    txtPort.Text = _crewrecord.DispatchPort;
                    txtDisembarkReason.Text = _crewrecord.DisembarkReason.Reason;
                    txtDisembarkReason.Tag = _crewrecord.DisembarkReasonId;

                    txtRemarks.Text = _crewrecord.Remarks2;

                    iVessel _ivessel = new CMSFilesRepository.rVessel();
                    if (_crewrecord.NextVessel == "0" || _crewrecord.NextVessel == null) { txtNextVessel.Text = ""; }
                    else { txtNextVessel.Text = _ivessel.GetVessel(int.Parse(_crewrecord.NextVessel.ToString())).VesselDescription; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContractOnVacationControl_Load(object sender, EventArgs e)
        {
            iContract _icontract = new CMSTransactionRepository.rContract();
            try
            {
                DisplayRecord(_icontract.GetCrewRecord(_crewstatusid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntPrincipal_Click(object sender, EventArgs e)
        {
            txtPort.Text = "";
            txtPort.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PORT;
            _Searchform.ShowDialog();

            //Port _port = _Searchform.ReturnSearchPort;
            //if (_port != null)
            //{
            //    txtPort.Text = _port.PortName;
            //    txtPort.Tag = _port.PortID;
            //}
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            txtNextVessel.Text = "";
            txtNextVessel.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._principalid = int.Parse(_parent.txtPrincipal.Tag.ToString());
            _Searchform._searchby = searchby.CMS.VESSEL;
            _Searchform.ShowDialog();

            //Vessel _vessel = _Searchform.ReturnSearchVessel;
            //if (_vessel != null)
            //{
            //    txtNextVessel.Text = _vessel.VesselDescription;
            //    txtNextVessel.Tag = _vessel.VesselID;
            //}
        }

        private void btnReDispatched_Click(object sender, EventArgs e)
        {
            try
            {
                if (_status == 1)
                {
                    MessageBox.Show("Cannot Re-Dispatched, Crew is currently on planned", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_status == 2)
                {
                    MessageBox.Show("Cannot Re-Disembark. Crew is currently on Board", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (ToolsControl.ModuleAccess(this, "CREW RETURN TO DISPATCH", SystemModuleType.System ) == false) { return; }
                if (MessageBox.Show("Crew status will return to Dispatch. Cancel Disembarked?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                _mode = 1;

                ManageCrewProcess();
                iContract _icontract = new CMSTransactionRepository.rContract();
                _parent.DisplayRecord(_icontract.GetCrewRecord(_crewstatusid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageCrewProcess()
        {
            //_icontract = new ContractRepositroy(DCLSystemConfiguration.Connection);
            iContract _icontract = new CMSTransactionRepository.rContract();
            CrewRecord _crewrecord = new CrewRecord();
            try
            {
                _crewrecord.CrewStatusID = _crewstatusid;
                _crewrecord.CrewID = _crewid;
                _crewrecord.PrincipalID = int.Parse(_parent.txtPrincipal.Tag.ToString());
                _crewrecord.VesselID = int.Parse(_parent.txtVessel.Tag.ToString());
                _crewrecord.PositionID = int.Parse(_parent.txtPosition.Tag.ToString());
                _crewrecord.Jobsite = _parent.txtjobsite.Text;
                _crewrecord.ContractType = _parent.cboContractType.Text;
                _crewrecord.ContractDuration = _parent.txtDurationMonth.Text;
                if (_parent.txtDurationWeek.Text == "") { _crewrecord.ContractWeeks = null; }
                else { _crewrecord.ContractWeeks = int.Parse(_parent.txtDurationWeek.Text); }
                if (_parent.txtDurationDay.Text == "") { _crewrecord.ContractDays = null; }
                else { _crewrecord.ContractDays = int.Parse(_parent.txtDurationDay.Text); }
                _crewrecord.PlanRemarks = _parent.txtContractRemarks.Text;
                _crewrecord.PERCENT_ALLOTEE = decimal.Parse(_parent.txtAllotementPercent.Text);
                _crewrecord.OEC_REMARKS = _parent.cboOEC.SelectedIndex + 1;
                _crewrecord.POEA_STATUS = _parent.txtPOEAStatus.Text;
                _crewrecord.BadgeNo = _parent.txtBadgeNo.Text;
                _crewrecord.Airline = _parent.txtAirline.Text;
                _crewrecord.AirTime = _parent.txtAirtime.Text;
                _crewrecord.AirTicket = _parent.txtAirticket.Text;
                _crewrecord.CostCenter = _parent.txtCostcenter.Text;

                _crewrecord.DisembarkDate = dtpDisembarkDate.Value;
                _crewrecord.DateDeparted = dtpDateDeparture.Value;
                _crewrecord.DateArrived = dtpDateArrival.Value;
                _crewrecord.DateReported = dtpDateReported.Value;
                _crewrecord.DateAvailability = dtpDateAvailability.Value;
                _crewrecord.DisembarkPort = txtPort.Text;
                _crewrecord.DisembarkReasonId = int.Parse(txtDisembarkReason.Tag.ToString());
                _crewrecord.DisembarkRemarks = txtRemarks.Text;
                _crewrecord.NextVessel = txtNextVessel.Tag.ToString();


                _crewstatusid = _icontract.DisembarkedCrew(_crewrecord, _mode);
                if (_mode == 0) { ToolsControl.CallShowNotification(this, 4, "Crew successfully Disembark"); }
                else { ToolsControl.CallShowNotification(this, 4, "Crew status successfully return to Dispatched"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisembark_Click(object sender, EventArgs e)
        {
            iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();

            try
            {
                if (ToolsControl.ModuleAccess(this, "DISEMBARKED CREW", SystemModuleType.System ) == false) { return; }

                if (_status == 1)
                {
                    MessageBox.Show("Crew is currently On-planned, Kindly Dispatch first before disembarking the crew", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (int.Parse(_parent.txtPrincipal.Tag.ToString()) != _current_principal)
                {
                    MessageBox.Show("Unable to transfer principal when crew is being disembarked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _parent.txtPrincipal.Focus();
                    return;
                }

                if (int.Parse(txtDisembarkReason.Tag.ToString()) == 0)
                {
                    btxMsg.ShowBalloon(txtDisembarkReason);
                    txtDisembarkReason.Focus();
                    return;
                }

                if (_isalaryscale.GetSalaryScale(int.Parse(_parent.txtPrincipal.Tag.ToString()), int.Parse(_parent.txtPosition.Tag.ToString())) == null)
                {
                    MessageBox.Show("Salary does not exist in the salary scale master file", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _parent.txtPrincipal.Focus();
                    return;
                }

                if (dtpDisembarkDate.Value.Year < DateTime.Now.Year)
                {
                    MessageBox.Show("Date Disembark cannot be less than the date year today", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpDisembarkDate.Focus();
                    return;
                }


                if (_status == 2)
                {
                    if (MessageBox.Show("Disembarked this crew, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                    _mode = 0;

                    ManageCrewProcess();
                    iContract _icontract = new CMSTransactionRepository.rContract();
                    _parent.DisplayRecord(_icontract.GetCrewRecord(_crewstatusid));
                }
                else
                {
                    if (ToolsControl.ModuleAccess(this, "CREW REDISEMBARKED", SystemModuleType.System) == false) { return; }
                    if (MessageBox.Show("Crew is currently on vacation. do you want to update his information, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                    _mode = 1;

                    ManageCrewProcess();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}