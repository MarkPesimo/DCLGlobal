using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Transaction.Contract;
using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
//using CAL.CMS.Interface.Crew;
//using CAL.CMS.Repository.Crew;

namespace DCLGlobal.Transaction.Contract
{
    public partial class ContractOnprocessControl : UserControl
    {
        private int _crewstatusid = 0;
        private string _applicantid = "";

        int _mode = 0;
        int _current_principal;
        int _status;
        int _crewid = 0;
        
        CrewContractControl _parent;

        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        //iTransaction _itransaction = new TransactionRepository(DCLSystemConfiguration.Connection);

        //iCrew _icrew = new CrewRepository(DCLSystemConfiguration.Connection);
        //iContract _icontract = new ContractRepositroy(DCLSystemConfiguration.Connection);
        //
        public ContractOnprocessControl(int _Crewstatusid, CrewContractControl _Parent)
        {
            InitializeComponent();
            _crewstatusid = _Crewstatusid;
            _parent = _Parent;
        }

        public void FillWorkRotationList()
        {
            iWorkRotation _iworkrotation = new CMSFilesRepository.rWorkRotation();
            try
            {
                List<WorkRotationTable> _workrotations = _iworkrotation.GetWorkRotations("", "All");
                foreach (WorkRotationTable _list in _workrotations)
                {
                    cboRotation.Items.Add(_list.WorkRotationName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContractOnprocessControl_Load(object sender, EventArgs e)
        {
            iContract _icontract = new CMSTransactionRepository.rContract();
            try
            {
                FillWorkRotationList();
                DisplayRecord(_icontract.GetCrewRecord(_crewstatusid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (_crewrecord.PlanDate == null) { dtpDatePlanned.Checked = false; }
                    else { dtpDatePlanned.Value = _crewrecord.PlanDate.Value; }

                    if (_crewrecord.EstimateDispatchDate == null) { dtpETD.Checked = false; }
                    else { dtpETD.Value = _crewrecord.EstimateDispatchDate.Value; }

                    if (_crewrecord.Projected_Readiness == null) { dtpProjectedReadiness.Checked = false; }
                    else { dtpProjectedReadiness.Value = _crewrecord.Projected_Readiness.Value; }

                    if (_crewrecord.Last_Date_Reported == null) { dtpLastDateReported.Checked = false; }
                    else { dtpLastDateReported.Checked = true; dtpLastDateReported.Value = _crewrecord.Last_Date_Reported.Value; }

                    txtPort.Text = _crewrecord.PlanPort;
                    cboRotation.Text = _crewrecord.WorkRotationTable.WorkRotationName;

                    if (_crewrecord.OnSigner != 0 && _crewrecord.OnSigner != null)
                    {                        
                        _crew = _icrew.GetCrew(int.Parse(_crewrecord.OnSigner.ToString()));
                        if (_crew != null) 
                        {
                            txtOffsigner.Tag = _crewrecord.OnSigner;
                            txtOffsigner.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName; 
                        }
                        else 
                        { 
                            txtOffsigner.Text = ""; 
                            txtOffsigner.Tag = 0; 
                        }
                    }
                    else 
                    { 
                        txtOffsigner.Text = ""; 
                        txtOffsigner.Tag = 0; 
                    }
                    txtRemarks.Text = _crewrecord.PlanRemarks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlanned_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "PLAN CREW", SystemModuleType.System ) == false) { return; }

            if (_status == 2)
            {
                MessageBox.Show("Crew is currently dispatched and cannot be planned/update.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(_parent.txtPrincipal.Tag.ToString()) == 0)
            {
                btxMsg.ShowBalloon(_parent.txtPrincipal);
                _parent.txtPrincipal.Focus();
                return;
            }
            if (int.Parse(_parent.txtVessel.Tag.ToString()) == 0)
            {
                btxMsg.ShowBalloon(_parent.txtVessel);
                _parent.txtVessel.Focus();
                return;
            }
            if (int.Parse(_parent.txtPosition.Tag.ToString()) == 0)
            {
                btxMsg.ShowBalloon(_parent.txtPosition);
                _parent.txtPosition.Focus();
                return;
            }
            if (int.Parse(_parent.txtjobsite.Tag.ToString()) == 0)
            {
                btxMsg.ShowBalloon(_parent.txtjobsite);
                _parent.txtjobsite.Focus();
                return;
            }

            if (!dtpETD.Checked)
            {
                MessageBox.Show("Estimated date dispatch cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpETD.Value = DateTime.Now;
                dtpETD.Checked = true;
                dtpETD.Focus();
                return;
            }

            if (!dtpProjectedReadiness.Checked)
            {
                MessageBox.Show("Projected Readiness cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpProjectedReadiness.Value = DateTime.Now;
                dtpProjectedReadiness.Checked = true;
                dtpProjectedReadiness.Focus();
                return;
            }


            if (cboRotation.SelectedIndex == 0)
            {
                MessageBox.Show("Kindly select a work rotation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRotation.Focus();
                return;
            }
        

            try 
            {
                if (_status == 1)
                {
                    if (ToolsControl.ModuleAccess(this, "PLAN REPLAN", SystemModuleType.System ) == false) { return; }
                    if (int.Parse(_parent.txtPrincipal.Tag.ToString()) != _current_principal)
                    {
                        if (ToolsControl.ModuleAccess(this, "CHANGE PRINCIPAL", SystemModuleType.System ) == false) { return; }
                        if (MessageBox.Show("Crew will be transferred to " + _parent.txtPrincipal.Text + ", Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; } 
                    }
                    else { if (MessageBox.Show("Continue Replanning?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; } }

                    _mode = 2;
                }
                else if(_status == 3) 
                {
                    if (MessageBox.Show("Planned this crew, Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    if (int.Parse(_parent.txtPrincipal.Tag.ToString()) != _current_principal)
                    {
                        if (ToolsControl.ModuleAccess(this, "CHANGE PRINCIPAL", SystemModuleType.System ) == false) { return; }
                        if (MessageBox.Show("Continue Replanning?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; } 
                    }

                    _mode = 1;
                }

                ManageCrewProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ManageCrewProcess()
        {
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

                if (_parent.txtDurationWeek.Text == "") { _crewrecord.ContractWeeks =  null; }
                else { _crewrecord.ContractWeeks = int.Parse(_parent.txtDurationWeek.Text); }
                if (_parent.txtDurationDay.Text == "") { _crewrecord.ContractDays = null; }
                else { _crewrecord.ContractDays = int.Parse(_parent.txtDurationDay.Text); }

                _crewrecord.PlanRemarks = _parent.txtContractRemarks.Text;
                _crewrecord.PERCENT_ALLOTEE = decimal.Parse( _parent.txtAllotementPercent.Text);
                _crewrecord.OEC_REMARKS = _parent.cboOEC.SelectedIndex;
                _crewrecord.POEA_STATUS = _parent.txtPOEAStatus.Text;
                _crewrecord.BadgeNo = _parent.txtBadgeNo.Text;
                _crewrecord.Airline = _parent.txtAirline.Text;
                _crewrecord.AirTime = _parent.txtAirtime.Text;
                _crewrecord.AirTicket = _parent.txtAirticket.Text;
                _crewrecord.CostCenter = _parent.txtCostcenter.Text;
                _crewrecord.PlanDate = dtpDatePlanned.Value;
                _crewrecord.EstimateDispatchDate = dtpETD.Value;
                _crewrecord.Projected_Readiness = dtpProjectedReadiness.Value;
                //_crewrecord.Last_Date_Reported = dtp
                _crewrecord.PlanPort = txtPort.Text;
                
                if (txtOffsigner.Tag.ToString() == "0") { _crewrecord.OnSigner = 0; }
                else { _crewrecord.OnSigner = int.Parse(txtOffsigner.Tag.ToString()); }
                _crewrecord.WORK_ROTATION_id =  cboRotation.SelectedIndex + 1;
                _crewrecord.PlanRemarks = txtRemarks.Text;

                _crewstatusid = _icontract.PlannedCrew(_crewrecord, _mode, _applicantid);
                ToolsControl.CallShowNotification(this, 4, "Crew successfully Planned");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            txtPort.Text = "";
            txtPort.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PORT;
            _Searchform.ShowDialog();

            //Port _port = _Searchform.ReturnSearchPort;
            //if (_port  != null)
            //{
            //    txtPort.Text = _port.PortName;
            //    txtPort.Tag = _port.PortID;
            //}
        }

        private void btnOffsigner_Click(object sender, EventArgs e)
        {
            txtOffsigner.Text = "";
            txtOffsigner.Tag = 0;

            Searchform _Searchform = new Searchform(2, int.Parse(_parent.txtPrincipal.Tag.ToString()));
            _Searchform._searchby = searchby.CMS.OFFSIGNER;
            _Searchform.ShowDialog();

            //Crew _crew = _Searchform.ReturnSearchCrew;
            //if (_crew != null)
            //{
            //    txtOffsigner.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
            //    txtOffsigner.Tag = _crew.CrewId;
            //}
        }

        private void btnReDisembark_Click(object sender, EventArgs e)
        {
            iContract _icontract = new CMSTransactionRepository.rContract();
            try 
            {
                if (_status != 1)
                { 
                    MessageBox.Show("Crew not yet on Planned", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ToolsControl.ModuleAccess(this, "PLAN REDISEMBARK", SystemModuleType.System ) == false) { return; }
                if (MessageBox.Show("Crew status will return to his last On Vacation contract, Procced?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                _icontract.RedisembarkedCrew(_crewstatusid);
                ToolsControl.CallShowNotification(this, 4, "Crew successfully Redisembarked");

                _parent.DisplayRecord(_icontract.GetCrewRecord(_crewstatusid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
