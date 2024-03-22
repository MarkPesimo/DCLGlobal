using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;

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
    public partial class ContractOnBoardControl : UserControl
    {
        private int _crewstatusid;
        
        int _crewid = 0;
        int _mode = 0;
        string _applicantid = "";
        int _status;
        int _current_principal;
        CrewContractControl _parent;

        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        //iTransaction _itransaction = new TransactionRepository(DCLSystemConfiguration.Connection);
        //iCrew _icrew = new CrewRepository(DCLSystemConfiguration.Connection);
        //iContract _icontract = new ContractRepositroy(DCLSystemConfiguration.Connection);

        public ContractOnBoardControl(int _Crewstatusid, CrewContractControl _Parent)
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
                    if (_crewrecord.DispatchDate == null) { dtpDateDispatch.Checked = false; }
                    else { dtpDateDispatch.Value = _crewrecord.DispatchDate.Value; }

                    if (_crewrecord.DueDate == null) { dtpDateDue.Checked = false; }
                    else { dtpDateDue.Value = _crewrecord.DueDate.Value; }                    

                    txtPort.Text = _crewrecord.DispatchPort;
                    cboRotation.Text = _crewrecord.WorkRotationTable.WorkRotationName;

                    if (_crewrecord.Reliever != "0" || _crewrecord.Reliever != null)
                    {                        
                        _crew = _icrew.GetCrew(_crewrecord.Reliever);
                        if (_crew != null)
                        {
                            txtReliever.Tag = _crewrecord.Reliever;
                            txtReliever.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                        }
                        else
                        {
                            txtReliever.Tag = 0; txtReliever.Text = "";
                        }
                    }
                    else
                    {
                        txtReliever.Tag = 0; txtReliever.Text = "";
                    }
                    txtRemarks.Text = _crewrecord.DispatchRemarks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContractOnBoardControl_Load(object sender, EventArgs e)
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
                _crewrecord.DispatchDate = dtpDateDispatch.Value;
                _crewrecord.DueDate = dtpDateDue.Value;
                _crewrecord.DispatchPort = txtPort.Text;

                if (txtReliever.Tag.ToString() == "0") { _crewrecord.OnSigner = null; }
                else { _crewrecord.OnSigner = int.Parse(txtReliever.Tag.ToString()); }
                _crewrecord.WORK_ROTATION_id = cboRotation.SelectedIndex + 1;
                _crewrecord.PlanRemarks = txtRemarks.Text;

                _crewstatusid = _icontract.PlannedCrew(_crewrecord, _mode, _applicantid);
                if (_mode == 0) { ToolsControl.CallShowNotification(this, 4, "Crew successfully Dispatched"); }
                else { ToolsControl.CallShowNotification(this, 4, "Crew satus successfully return to planned"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnport_Click(object sender, EventArgs e)
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

        private void btnReliever_Click(object sender, EventArgs e)
        {
            txtReliever.Text = "";
            txtReliever.Tag = 0;

            Searchform _Searchform = new Searchform(1, int.Parse(_parent.txtPrincipal.Tag.ToString()));
            _Searchform._searchby = searchby.CMS.OFFSIGNER;
            _Searchform.ShowDialog();

            //Crew _crew = _Searchform.ReturnSearchCrew;
            //if (_crew != null)
            //{
            //    txtReliever.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
            //    txtReliever.Tag = _crew.CrewId;
            //}
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {            
            try 
            {
                if (ToolsControl.ModuleAccess(this, "DISPATCH CREW", SystemModuleType.System ) == false) { return; }

                if (_status == 3)
                {
                    MessageBox.Show("Crew currently On-vacation and cannot be Dispatch", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                if (_parent.txtDurationMonth.Text == "" || _parent.txtDurationMonth.Text == "0")
                {
                    btxMsg.ShowBalloon(_parent.txtDurationMonth);
                    _parent.txtDurationMonth.Focus();
                    return;
                }

                int _res;
                if (int.TryParse(_parent.txtDurationMonth.Text, out _res) == false)
                {
                    MessageBox.Show("Kindly input a valid contract duration","Info",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _parent.txtDurationMonth.Focus();
                    return;
                }

                if (dtpDateDispatch.Checked == false)
                {
                    MessageBox.Show("Date Dispatch cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpDateDispatch.Focus();
                    return;
                }

                if (dtpDateDispatch.Value.Year < DateTime.Now.Year)
                {
                    MessageBox.Show("Date Dispatch cannot be less than the date year today", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpDateDispatch.Focus();
                    return;
                }

                if (!dtpDateDue.Checked)
                {
                    MessageBox.Show("Due date cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpDateDue.Focus();
                    return;
                }

                if (txtPort.Text == "")
                {
                    btxMsg.ShowBalloon(txtPort);
                    txtPort.Focus();
                    return;
                }

                if (_parent.cboOEC.SelectedIndex < 0)
                {
                    MessageBox.Show("OEC Remarks cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    _parent.cboOEC.Focus();
                    return;
                }

                if (_status == 2)                   //currently on board, update info
                {
                    if (ToolsControl.ModuleAccess(this, "CREW REDISPATCHED", SystemModuleType.System ) == false) { return; }
                    if (MessageBox.Show("Crew is Already Dispatched, do you want to Update Dispatched Information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    if (int.Parse(_parent.txtPrincipal.Tag.ToString()) != _current_principal)
                    {
                        if (ToolsControl.ModuleAccess(this, "CHANGE PRINCIPAL", SystemModuleType.System ) == false) { return; }
                    }

                    _mode = 0;
                    ManageCrewProcess();
                }
                else if (_status == 1)              //currently on process, set to onboard
                {
                    if (ToolsControl.ModuleAccess(this, "CREW REDISPATCHED", SystemModuleType.System ) == false) { return; }
                    if (MessageBox.Show("Dispatched this Crew, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                    if (int.Parse(_parent.txtPrincipal.Tag.ToString()) != _current_principal)
                    {
                        if (ToolsControl.ModuleAccess(this, "CHANGE PRINCIPAL", SystemModuleType.System ) == false) { return; }
                    }

                    _mode = 1;
                    ManageCrewProcess();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReplanned_Click(object sender, EventArgs e)
        {
            try 
            {
                if (_status == 1)
                {
                    MessageBox.Show("Cannot cancel dispatch. Crew is currently on planned", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (_status == 3)
                {
                    MessageBox.Show("Cannot Re-Plan. Crew is currently on Vacation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (ToolsControl.ModuleAccess(this, "CREW RETURN TO PLAN", SystemModuleType.System) == false) { return; }
                if (MessageBox.Show("Crew status will return to Planned. Cancel Dispatched?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                _mode = 2;
                ManageCrewProcess();
                iContract _icontract = new CMSTransactionRepository.rContract();
                _parent.DisplayRecord(_icontract.GetCrewRecord(_crewstatusid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
