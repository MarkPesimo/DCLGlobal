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
using DCLGlobal.Classes;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class COCAcontrol : UserControl
    {
        //public int _cocacrewstatusid;
        //public int _cocacrewid;
        //public string _cocaapplicantid;
        string _crewname;
        string _address;
        string _emailaddress;

        int _addons_id = 0;
        int _allottee_id = 0;
        private UserDefineClass.CMS._Cocacrewinformation _cocainfo;
        public CrewInfoControl _parent;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F11)
            {
                MessageBox.Show("F11 keys press");
            }
            else if (keyData == Keys.F9)
            { }
            else if (keyData == Keys.F10)
            { }
            else if (keyData == Keys.F11)
            { }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public COCAcontrol(UserDefineClass.CMS._Cocacrewinformation Cocainfo, CrewInfoControl Parent)
        {
            _cocainfo = new UserDefineClass.CMS._Cocacrewinformation();
            _cocainfo._Applicantid = Cocainfo._Applicantid;
            _cocainfo._Crewid = Cocainfo._Crewid;
            _cocainfo._Crewstatusid = Cocainfo._Crewstatusid;
            _parent = Parent;                      

            InitializeComponent();


            
            //_cocacrewstatusid = Crewstatusid;
            //_cocacrewid = Crewid;
            //_cocaapplicantid = Applicantid;
            
        }

        public COCAcontrol()
        {
            InitializeComponent();            
        }

        private void COCAcontrol_Load(object sender, EventArgs e)
        {
            try
            {
                GetCrew();
                GetCoca();
                DisplayCrewstatusAddons();
                DisplayCrewStatusAllottee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        void GetCrew()
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            try
            {

                Crew _crew = _icrew.GetCrew(_cocainfo._Crewid);
                if (_crew != null)
                {
                    _crewname = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                    _address = _crew.Address;
                    _emailaddress = _crew.EmailAddress;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void GetCoca()
        {
            List<CREWSTATUS_COCA> _crewstatus_coca = new List<CREWSTATUS_COCA>();
            iCoca _icoca = new CMSFilesRepository.rCoca();

            try
            {
                _crewstatus_coca = _icoca.GetCrewStatusCOCA(_cocainfo._Crewstatusid);
                if (_crewstatus_coca != null)
                {
                    foreach (CREWSTATUS_COCA _list in _crewstatus_coca)
                    {
                        if (_list.AlloteeType == 1)
                        {
                            if (_list.Self_allotee)
                            {
                                txtName1.Text = _crewname;
                                CboRelationship1.Text = "SELF ALLOTEE";
                                txtAddress1.Text = _address;
                                txtEmailAddress1.Text = _emailaddress;
                            }
                            else
                            {
                                txtName1.Text = _list.Name;
                                CboRelationship1.Text = _list.RelationShip;
                                txtAddress1.Text = _list.Address;
                                txtEmailAddress1.Text = _list.EmailAddress;
                            }

                            txtAmount1.Text = _list.Amount.ToString();
                            txtBankName1.Text = _list.BankName;
                            txtAccountName1.Text = _list.AccountName;
                            txtAccountNumber1.Text = _list.AccountNumber;
                            chkSelfAllotee1.Checked = _list.Self_allotee;
                        }
                        else if (_list.AlloteeType == 2)
                        {
                            if (_list.Self_allotee)
                            {
                                txtName2.Text = _crewname;
                                cboRelationship2.Text = "SELF ALLOTEE";
                                txtAddress2.Text = _address;
                                txtemailaddress2.Text = _emailaddress;
                            }
                            else
                            {
                                txtName2.Text = _list.Name;
                                cboRelationship2.Text = "SELF ALLOTEE";
                                txtAddress2.Text = _list.Address;
                                txtemailaddress2.Text = _list.EmailAddress;
                            }

                            txtAmount2.Text = _list.Amount.ToString();
                            txtBankName2.Text = _list.BankName;
                            txtAccountName2.Text = _list.AccountName;
                            txtAccountNumber2.Text = _list.AccountNumber;

                            chkSelfAllotee2.Checked = _list.Self_allotee;
                        }
                        else
                        {
                            txtName3.Text = _list.Name;
                            cboRelationship3.Text = _list.RelationShip;
                            txtAddress3.Text = _list.Address;

                            txtBankName3.Text = _list.BankName;
                            txtAccountName3.Text = _list.AccountName;
                            txtAccountNumber3.Text = _list.AccountNumber;

                            if (bool.Parse(_list.Show_Remaing.ToString()))
                            {
                                chkShowRemainingSalary.Checked = bool.Parse(_list.Show_Remaing.ToString());
                                txtAmount3.Text = "0";
                            }
                            else
                            {
                                txtAmount3.Text = _list.Amount.ToString();
                            }

                            txtEmailAddress3.Text = _list.EmailAddress;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayCrewStatusAllottee()
        {
            iCoca _icoca = new CMSFilesRepository.rCoca();
            List<CrewStatus_Allottee> _allottee = new List<CrewStatus_Allottee>();
            try
            {
                lsvAllottees.Items.Clear();
                _allottee = _icoca.GetCrewstatusAllottee(_cocainfo._Crewstatusid);
                foreach (CrewStatus_Allottee _list in _allottee)
                {
                    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    _item.SubItems.Add(_list.Line_no.ToString());
                    _item.SubItems.Add(_list.Description);
                    _item.SubItems.Add(_list.Amount.ToString());

                    lsvAllottees.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void DisplayCrewstatusAddons()
        {
            iCoca _icoca = new CMSFilesRepository.rCoca();
            List<CREWSTATUS_COMPENSATION> _salaryscaleaddons = new List<CREWSTATUS_COMPENSATION>();
            try
            {
                lsvAddons.Items.Clear();
                _salaryscaleaddons = _icoca.GetCrewStatusAddOns(_cocainfo._Crewstatusid);
                foreach (CREWSTATUS_COMPENSATION _list in _salaryscaleaddons)
                {
                    ListViewItem _item = new ListViewItem(_list.ID.ToString());
                    _item.SubItems.Add(_list.LINE_NO.ToString());
                    _item.SubItems.Add(_list.ADDON.DESCRIPTION);
                    _item.SubItems.Add(_list.AMOUNT.ToString());

                    if (bool.Parse(_list.FOR_COMPUTATION.ToString())) { _item.SubItems.Add("Yes"); }
                    else { _item.SubItems.Add("No"); }
                    if (bool.Parse(_list.OTHER_BENIFITS.ToString())) { _item.SubItems.Add("Yes"); }
                    else { _item.SubItems.Add("No"); }
                    if (bool.Parse(_list.IS_ALLOTEMENT.ToString())) { _item.SubItems.Add("Yes"); }
                    else { _item.SubItems.Add("No"); }

                    lsvAddons.Items.Add(_item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "COPY PREVIOUS CREW COMPENSATION", SystemModuleType.System) == false) { return; }
            if (MessageBox.Show("Copying previous compensation of allowance info. from his/her last contract, will delete the current Compensation setup of this Crew, Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            try
            {
                iCoca _icoca = new CMSFilesRepository.rCoca();
                CREWSTATUS_COCA _coca = new CREWSTATUS_COCA();

                _coca.CrewStatus_id = _cocainfo._Crewstatusid;
                _coca.AlloteeType = 1;
                _coca.Name = "";
                _coca.RelationShip = "";
                _coca.Address = "";
                _coca.Amount = 0;
                _coca.BankName = "";
                _coca.AccountName = "";
                _coca.AccountNumber = "";
                _coca.Self_allotee = false;
                _coca.Show_Remaing = false;

                _icoca.ManageCrewStatusCOCA(_coca, _cocainfo._Applicantid, 0);

                GetCoca();

                ToolsControl.CallPopMessage(this, "Information", "Crew Compensation successfully copied from his/her previous last contract.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "UPDATE CREW COMPENSATION", SystemModuleType.System) == false) { return; }
            if (MessageBox.Show("Save Compensation details, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            
            try
            {
                iCoca _icoca = new CMSFilesRepository.rCoca();
                CREWSTATUS_COCA _coca = new CREWSTATUS_COCA();

                _coca.CrewStatus_id = _cocainfo._Crewstatusid;
                _coca.AlloteeType = 1;
                _coca.Name = txtName1.Text;
                _coca.RelationShip = CboRelationship1.Text;
                _coca.Address = txtAddress1.Text;
                _coca.Amount =decimal.Parse(  txtAmount1.Text);
                _coca.BankName = txtBankName1.Text;
                _coca.AccountName = txtAccountName1.Text;
                _coca.AccountNumber = txtAccountNumber1.Text;
                _coca.Self_allotee = chkSelfAllotee1.Checked;
                _coca.Show_Remaing = false;
                _coca.EmailAddress = txtEmailAddress1.Text;
                _icoca.ManageCrewStatusCOCA(_coca, _cocainfo._Applicantid, 1);

                _coca = new CAL.Model.CREWSTATUS_COCA();
                _icoca = new CMSFilesRepository.rCoca();

                _coca.CrewStatus_id = _cocainfo._Crewstatusid;
                _coca.AlloteeType = 2;
                _coca.Name = txtName2.Text;
                _coca.RelationShip = cboRelationship2.Text;
                _coca.Address = txtAddress2.Text;
                _coca.Amount = decimal.Parse( txtAmount2.Text);
                _coca.BankName = txtBankName2.Text;
                _coca.AccountName = txtAccountName2.Text;
                _coca.AccountNumber = txtAccountNumber2.Text;
                _coca.Self_allotee = chkSelfAllotee2.Checked;
                _coca.Show_Remaing = false;
                _coca.EmailAddress = txtemailaddress2.Text;
                _icoca.ManageCrewStatusCOCA(_coca, _cocainfo._Applicantid, 1);

                _coca = new CAL.Model.CREWSTATUS_COCA();
                _icoca = new CMSFilesRepository.rCoca();

                _coca.CrewStatus_id = _cocainfo._Crewstatusid;
                _coca.AlloteeType = 3;
                _coca.Name = txtName3.Text;
                _coca.Address = txtAddress3.Text;
                _coca.RelationShip = cboRelationship3.Text;
                _coca.Amount = decimal.Parse( txtAmount3.Text);
                _coca.BankName = txtBankName3.Text;
                _coca.AccountName = txtAccountName3.Text;
                _coca.AccountNumber = txtAccountNumber3.Text;
                _coca.Self_allotee = false;
                _coca.Show_Remaing = chkShowRemainingSalary.Checked;
                _coca.EmailAddress = txtEmailAddress3.Text;
                _icoca.ManageCrewStatusCOCA(_coca, _cocainfo._Applicantid, 1);

                ToolsControl.CallPopMessage(this, "Information", "Crew Compensation successfully saved !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "COPY CREW COMPENSATION FROM SALARY SCALE", SystemModuleType.System) == false) { return; }
            if (MessageBox.Show("Copying Compensation of allowance info. from Salary Scale, will delete this current Compensation setup of this Crew, Continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
           
            try 
            {
                CREWSTATUS_COMPENSATION _compensation = new CREWSTATUS_COMPENSATION();
                _compensation.ADDONS_ID = 0;
                _compensation.CREWSTATUSID = _cocainfo._Crewstatusid;
                _compensation.AMOUNT = 0;
                _compensation.FOR_COMPUTATION = chkComputation.Checked;
                _compensation.OTHER_BENIFITS = chkOtherBenefits.Checked;
                _compensation.ID = 0;

                ManageCrewstatusAddons(3, _compensation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        void ManageCrewstatusAddons(int _mode, CREWSTATUS_COMPENSATION _addons)
        {
            int _id = 0;
            iCoca _icoca = new CMSFilesRepository.rCoca();
            try
            {
                _id = _icoca.ManageCrewStatusAddOns(_addons, _mode, LoginUser.userid);

                cboAddOns.SelectedIndex = 0;
                txtAddOnAmount.Text = "0";
                chkComputation.Checked = true;
                chkOtherBenefits.Checked = false;
                chkIsAllotement.Checked = false;

                if (_mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, _mode, "Addons successfully copied from the salary scale"); }

                DisplayCrewstatusAddons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (txtLineAddon.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtLineAddon);
                txtLineAddon.Focus();
                return;
            }

            if (cboAddOns.SelectedIndex == -1)
            {
                MessageBox.Show("Kindly select a add-ons", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboAddOns.SelectedIndex = 0;
                cboAddOns.Focus();
                return;
            }

            if (MessageBox.Show("Save Addons, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            try
            { 
                CREWSTATUS_COMPENSATION _object = new CREWSTATUS_COMPENSATION();
                _object.ADDONS_ID = int.Parse( cboAddOns.SelectedValue.ToString());
                _object.CREWSTATUSID = _cocainfo._Crewstatusid;
                _object.LINE_NO = int.Parse( txtLineAddon.Text);
                _object.AMOUNT  = decimal.Parse( txtAddOnAmount.Text);
                _object.FOR_COMPUTATION = chkComputation.Checked;
                _object.OTHER_BENIFITS = chkOtherBenefits.Checked;
                _object.IS_ALLOTEMENT = chkIsAllotement.Checked;
                _object.ID = 0;

                ManageCrewstatusAddons(0, _object);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void btnAddOns_Click(object sender, EventArgs e)
        {
            try
            {
                cboAddOns.DataSource = null;
                FillCboAddons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        void FillCboAddons()
        {
            iAddons _iaddon = new CMSFilesRepository.rAddon();            
            try 
            {
                List<ADDON> _list = _iaddon.GetAddOns("", true);
                cboAddOns.DataSource = _list;
                cboAddOns.DisplayMember = "DESCRIPTION";
                cboAddOns.ValueMember = "id";
                cboAddOns.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (txtLineAllottee.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtLineAllottee);
                txtLineAllottee.Focus();
                return;
            }
            if (txtAllotteeDescription.Text == "")
            {
                btxMsg.ShowBalloon(txtAllotteeDescription);
                txtAllotteeDescription.Focus();
                return;
            }

            if (MessageBox.Show("Save Allottee, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            try
            {
                CrewStatus_Allottee _allottee = new CrewStatus_Allottee();

                _allottee.CrewStatusId = _cocainfo._Crewstatusid;
                _allottee.Line_no = int.Parse( txtLineAllottee.Text);
                _allottee.Amount = decimal.Parse( txtAllotteeAmount.Text);
                _allottee.Description = txtAllotteeDescription.Text;
                _allottee.id = 0;

                ManageCrewstatusAllottee(0, _allottee);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        void ManageCrewstatusAllottee(int _mode, CrewStatus_Allottee _allotte)
        {
            int _id = 0;
            iCoca _icoca = new CMSFilesRepository.rCoca();
            try 
            {
                _id = _icoca.ManageCrewstatusAllottee(_allotte, LoginUser.userid, _mode);

                txtAllotteeDescription.Text = "";
                txtAllotteeAmount.Text = "0";

                if (_mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }

                DisplayCrewStatusAllottee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void lsvAllottees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAllottees.SelectedItems.Count == 0) { return; }

            try
            {
                _allottee_id = int.Parse(lsvAllottees.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvAddons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAddons.SelectedItems.Count == 0) { return; }

            try
            {
                _addons_id = int.Parse(lsvAddons.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvAddons_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Crew Process Addons, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            CREWSTATUS_COMPENSATION _compensation = new CREWSTATUS_COMPENSATION();
            try
            {
                btnAddOns.PerformClick();
                _compensation.ADDONS_ID = cboAddOns.SelectedIndex;
                _compensation.CREWSTATUSID = _cocainfo._Crewstatusid;
                _compensation.AMOUNT = 0;
                _compensation.FOR_COMPUTATION = false;
                _compensation.OTHER_BENIFITS = false;
                _compensation.ID = _addons_id;

                ManageCrewstatusAddons(2, _compensation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lsvAllottees_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Crew Process allottee, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            CrewStatus_Allottee _allottee = new CrewStatus_Allottee();
            try 
            {
                _allottee.CrewStatusId = _cocainfo._Crewstatusid;
                _allottee.Amount = 0;
                _allottee.Description = "";
                _allottee.id = _allottee_id;

                ManageCrewstatusAllottee(2, _allottee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ReportControl.CMS _reportcontrol = new ReportControl.CMS();
                _reportcontrol.PrintCOCA(_cocainfo._Crewstatusid, _cocainfo._Crewid, _cocainfo._Applicantid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
