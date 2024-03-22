using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Master.CrewInfo;

using CAL.Model;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;
using CAL.Global;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewInfoControl : UserControl
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iCrew _icrew = new CrewRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        public string _applicant_id = "1006-00658";
        public int _crewstatusid;
        public int _crewid;
        CrewMasterform _parent;

        public CrewInfoControl(CrewMasterform _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            int _statusmode = 0;

            //CMS MODULE
            if (keyData == Keys.F11)                    //tag new hire / rehire
            {
                if (LoginUser.appmodule != "CMS")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                try
                {
                    if (lblHireStatus.Text == "** New Hire **")
                    {
                        if (MessageBox.Show("Tagged this crew " + txtLastname.Text + ", " + txtFirstname.Text + " " + txtMiddlename.Text + ", as Rehire, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return false; }
                        _statusmode = 3;
                    }
                    else 
                    {
                        if (MessageBox.Show("Tagged this crew " + txtLastname.Text + ", " + txtFirstname.Text + " " + txtMiddlename.Text + ", as New Hire, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return false; }
                        _statusmode = 2;
                    }
                    _icrew.UpdateCrewStatus(_statusmode, _applicant_id, "");
                    DisplayRecord(_icrew.GetCrew(_applicant_id));
                    ToolsControl.CallShowNotification(this, 4, "Crew Hire status successfully updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (keyData == Keys.F9)                //reset crewbook password
            {
                if (LoginUser.appmodule != "CMS")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ToolsControl.ModuleAccess(this, "RESET CREWBOOK PASSWORD", SystemModuleType.System) == false) { return false; }
                if (MessageBox.Show("Reset crewbook password, are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return false; }

                try 
                {                    
                    _icrew.ResetCrewbookPassword(_crewid);
                    ToolsControl.CallShowNotification(this, 4, "Crewbook password successfully reset to default.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (keyData == Keys.F10)               //tag active / inactive
            {
                if (LoginUser.appmodule != "CMS")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                bool _hirestatus = false;
                if (lblHireStatus.Text == "** New Hire **") {_hirestatus = true;}
                else { _hirestatus = false; }
                ReasonForm _reasonform = new ReasonForm("", false, false, _hirestatus, txtLastname.Text + ", " + txtFirstname.Text + " " + txtMiddlename.Text, _applicant_id);
                _reasonform.BringToFront();
                _reasonform.ShowDialog();

                DisplayRecord(_icrew.GetCrew(_applicant_id));
            }
            else if (keyData == Keys.F12)               //tag direct hire
            {
                if (LoginUser.appmodule != "CMS")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                try 
                {
                    int _dhmode = 0;
                    if (lbldirecthire.Text == "** Direct Hire**") { _dhmode = 5; }
                    else { _dhmode = 4; }

                    _icrew.UpdateCrewStatus(_dhmode, _applicant_id, "");
                    DisplayRecord(_icrew.GetCrew(_applicant_id));
                    ToolsControl.CallShowNotification(this, 4, "Crew Direct Hire status successfully updated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (keyData == Keys.F6)                //tag watchlist
            {
                if (LoginUser.appmodule != "CMS" && LoginUser.appmodule != "IRECRUIT")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                bool _watchliststatus = false;
                if (picWatchlist.Visible) { _watchliststatus = true; }
                else { _watchliststatus = false; }

                ReasonForm _reasonform = new ReasonForm("", true, _watchliststatus, false, txtLastname.Text + ", " + txtFirstname.Text + " " + txtMiddlename.Text, _applicant_id);
                _reasonform.BringToFront();
                _reasonform.ShowDialog();

                DisplayRecord(_icrew.GetCrew(_applicant_id));

            }
            else if (keyData == Keys.F7)                //enter date CV
            {
                if (LoginUser.appmodule != "IRECRUIT")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;                     
                }
            }

            //IRECRUIT MODULE
            else if (keyData == Keys.F8)                //enter qualification
            {
                if (LoginUser.appmodule != "IRECRUIT")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else if (keyData == Keys.F9)                //enter plan request
            {
                if (LoginUser.appmodule != "IRECRUIT")
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }

            //GLOBAL
            else if (keyData == Keys.F2)                //log audit
            { 
            
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FillWRRStatus()
        {
            cboWRR.DataSource = null;
            iWRR _iwrr = new IRECRUITFilesRepository.rWRR();
            
            try
            { 
                List<WRR_STATUS> _wrrs = _iwrr.GetWRRStatuses("", true);
                cboWRR.DataSource = _wrrs;
                cboWRR.DisplayMember = "WRRStatus";
                cboWRR.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CrewInfoControl_Load(object sender, EventArgs e)
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            try
            {
                FillWRRStatus();
                DisplayRecord(_icrew.GetCrew(_applicant_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtApplicantid.Text = "";
            txtPersonnelno.Text = "";
            txtcrewid.Text = "";
            txtLastname.Text = "";
            txtFirstname.Text = "";
            txtMiddlename.Text = "";
            cboGender.SelectedIndex = 0;
            cboCivilStatus.SelectedIndex = 0;
            dtpbday.Checked = true;
            txtAge.Text = "";
            txtPlaceOfbirth.Text ="";
            txtEmailAddress.Text = "";
            txtReligion.Text = "";
            txtaddress.Text = "";
            txtMunicipality.Text = "";
            txtMunicipality.Tag = 0;
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtHomeno.Text = "";
            txtPersonnalNo.Text = "";
            txtHighestEducation.Text = "";
            txtSchool.Text = "";
            txtDegree.Text = "";
            txtyearattend.Text = "";
            cboCategory.SelectedIndex = 0;
            txtMothersName.Text = "";
            txtFathersName.Text = "";
            txtDaugther.Text = "";
            txtSon.Text = "";
            txtWaistSize.Text = "";
            txtBlood.Text = "";
            txtEyeLeft.Text = "";
            txtEyeRight.Text = "";
            txtShoeSize.Text = "";
            txtPositionApplied.Text = "";
            txtDateApas.Text = "";
            txtSourceFrom.Text = "";
            txtContactPerson.Text = "";
            txtContactPersonAddress.Text = "";
            txtCPMobileno.Text = "";
            txtCPTelno.Text = "";
            chkStatus.Checked = false;
            cboWRR.SelectedIndex = 0;
        }

        void EnableButton(bool _cond)
        {
            //Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            txtPersonnelno.ReadOnly = !_cond;
            txtLastname.ReadOnly = !_cond;
            txtFirstname.ReadOnly = !_cond;
            txtMiddlename.ReadOnly = !_cond;
            cboGender.Enabled = _cond;
            cboCivilStatus.Enabled = _cond;
            dtpbday.Enabled = _cond;
            txtPlaceOfbirth.ReadOnly = !_cond;
            txtEmailAddress.ReadOnly = !_cond;
            txtReligion.ReadOnly = !_cond;
            txtaddress.ReadOnly = !_cond;
            txtHeight.ReadOnly = !_cond;
            txtWeight.ReadOnly = !_cond;
            txtHomeno.ReadOnly = !_cond;
            txtPersonnalNo.ReadOnly = !_cond;
            txtHighestEducation.ReadOnly = !_cond;
            txtSchool.ReadOnly = !_cond;
            txtDegree.ReadOnly = !_cond;
            txtyearattend.ReadOnly = !_cond;
            cboCategory.Enabled = _cond;
            txtMothersName.ReadOnly = !_cond;
            txtFathersName.ReadOnly = !_cond;
            txtDaugther.ReadOnly = !_cond;
            txtSon.ReadOnly = !_cond;
            txtWaistSize.ReadOnly = !_cond;
            txtBlood.ReadOnly = !_cond;
            txtEyeLeft.ReadOnly = !_cond;
            txtEyeRight.ReadOnly = !_cond;
            txtShoeSize.ReadOnly = !_cond;
            //txtPositionApplied.ReadOnly = !_cond;
            txtDateApas.ReadOnly = !_cond;
            //txtSourceFrom.ReadOnly = !_cond;
            txtContactPerson.ReadOnly = !_cond;
            txtContactPersonAddress.ReadOnly = !_cond;
            txtCPMobileno.ReadOnly = !_cond;
            txtCPTelno.ReadOnly = !_cond;

            cboExpMonth.Enabled = _cond;
            cboExpYear.Enabled = _cond;
            cboWRR.Enabled = _cond;

            chkStatus.Enabled = _cond;
        }

        void DisplayRecord(CAL.Model.Crew _crew)
        {
            try
            {
                if (_crew != null)
                {
                    _parent.Text = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
                    txtApplicantid.Text = _crew.ApplicantID;
                    txtPersonnelno.Text = _crew.Personnel_no;
                    txtcrewid.Text = _crew.CrewId.ToString();
                    txtLastname.Text = _crew.LastName;
                    txtFirstname.Text = _crew.FirstName;
                    txtMiddlename.Text = _crew.MiddleName;
                    cboGender.Text = _crew.Sex;
                    cboCivilStatus.Text = _crew.CivilStatus;
                    dtpbday.Value = _crew.BDay.Value;
                    
                    DateTime _today = DateTime.Today;
                    int _age = _today.Year - _crew.BDay.Value.Year;
                    if (_crew.BDay > _today.AddYears(-_age)) _age--;
                    txtAge.Text = _age.ToString();
                    
                    txtPlaceOfbirth.Text = _crew.PlaceOfBirth;
                    txtEmailAddress.Text = _crew.EmailAddress;
                    txtReligion.Text = _crew.Religion;
                    txtaddress.Text = _crew.Address;
                    txtMunicipality.Text = _crew.Municipality.MunicipalityName;
                    txtMunicipality.Tag = _crew.MUNICIPALITYID;
                    txtHeight.Text = _crew.Height;
                    txtWeight.Text = _crew.Weight;
                    txtHomeno.Text = _crew.TelNo;
                    txtPersonnalNo.Text = _crew.MobileNo;
                    txtHighestEducation.Text = _crew.HighestEducation;
                    txtSchool.Text = _crew.School;
                    txtDegree.Text = _crew.Degree;
                    txtyearattend.Text = _crew.YearAttended;
                    cboCategory.Text = _crew.Category;
                    txtMothersName.Text = _crew.MotherName;
                    txtFathersName.Text = _crew.FatherName;
                    txtDaugther.Text = _crew.FamilyDauther;
                    txtSon.Text = _crew.FamilySon;
                    txtWaistSize.Text = _crew.WaistSize;
                    txtBlood.Text = _crew.Blood;
                    txtEyeLeft.Text = _crew.EyeLeft;
                    txtEyeRight.Text = _crew.EyeRight;
                    txtShoeSize.Text = _crew.ShoeSize;
                    txtPositionApplied.Text = _crew.PositionApplied;
                    txtDateApas.Text = "";
                    txtSourceFrom.Text = _crew.Source;
                    txtContactPerson.Text = _crew.ContactPerson;
                    txtContactPersonAddress.Text = _crew.ContactPersonAddress;
                    txtCPMobileno.Text = _crew.ContactPersonCP;
                    txtCPTelno.Text = _crew.ContactPersonTelNo;

                    chkStatus.Checked = _crew.ACTIVE_STATUS == 1 ? true : false;
                    if (_crew.WATCH_LIST == 1)
                    {
                        picWatchlist.Visible = true;
                        _parent._iswatchlist = true;
                    }
                    else
                    {
                        picWatchlist.Visible = false;
                        _parent._iswatchlist = false;
                    }

                    _parent._status = _crew.ACTIVE_STATUS == 1 ? true : false;
                    _parent._iscrew = _crew.IsCrew == 1 ? true : false;

                    if (_parent._iscrew)
                    {
                        lblHireStatus.Text = _crew.HIRE_STATUS == 1 ? "** New Hire **" : "** Rehire **";
                    }
                    else
                    { lblHireStatus.Text = ""; }

                    if (_crew.DIRECT_HIRE != null)
                    {
                        if (_crew.DIRECT_HIRE == 1) { lbldirecthire.Text = "** Direct Hire **"; }
                        else { lbldirecthire.Text = ""; }
                    }
                    else { lbldirecthire.Text = ""; }


                    iCrew _icrew = new CMSFilesRepository.rCrew();
                    CrewInitialInformation _crewinitialinfo = _icrew.GetCrewInitialInfo(_applicant_id);
                    if (_crewinitialinfo != null)
                    {
                        if (_crewinitialinfo.YearofService != null)
                        {
                            if (cboExpYear.Items.Contains(_crewinitialinfo.YearofService)) { cboExpYear.Text = _crewinitialinfo.YearofService; }
                            else { cboExpYear.Text = "Please Update"; }
                        }
                        else { cboExpYear.Text = "Please Update"; }

                        if (_crewinitialinfo.Experience != null)
                        {
                            if (cboExpMonth.Items.Contains(_crewinitialinfo.Experience)) { cboExpMonth.Text = _crewinitialinfo.Experience; }
                            else { cboExpMonth.Text = "Please Update"; }
                        }
                        else { cboExpMonth.Text = "Please Update"; }

                        if (_crewinitialinfo.FailedInitial != null) { chkInitialSatus.Checked = bool.Parse(_crewinitialinfo.FailedInitial.ToString()); }
                        else { chkInitialSatus.Checked = false; }

                        txtRefferedby.Text = _crewinitialinfo.ReferredBy;
                        if (_crewinitialinfo.LastReported != null && _crewinitialinfo.LastReported.ToString() != "") { txtLastReported.Text = DateTime.Parse(_crewinitialinfo.LastReported.ToString()).ToString("MM/dd/yyyy"); }
                        else { txtLastReported.Text = ""; }

                        if (_crewinitialinfo.IsPolling != null)
                        {
                            if (bool.Parse(_crewinitialinfo.IsPolling.ToString())) { lbldirecthire.Text = "** For Pooling"; }
                            else { lbldirecthire.Text = ""; }
                        }
                        else { lbldirecthire.Text = ""; }

                        if (_crewinitialinfo.DateInitial != null && _crewinitialinfo.DateInitial.ToString() != "") { txtDateInitial.Text = _crewinitialinfo.DateInitial.Value.ToString("MM/dd/yyyy"); }
                        else { txtDateInitial.Text = ""; }

                        if (_crewinitialinfo.DateTechnical != null && _crewinitialinfo.DateTechnical.ToString() != "") { txtDateTechnical.Text = _crewinitialinfo.DateTechnical.Value.ToString("MM/dd/yyyy"); }
                        else { txtDateTechnical.Text = ""; }

                        if (_crewinitialinfo.DateTest != null && _crewinitialinfo.DateTest.ToString() != "") { txtDateTested.Text = _crewinitialinfo.DateTest.Value.ToString("MM/dd/yyyy"); }
                        else { txtDateTested.Text = ""; }

                        if (_crewinitialinfo.DateFinal != null && _crewinitialinfo.DateFinal.ToString() != "") { txtFinalAssess.Text = _crewinitialinfo.DateFinal.Value.ToString("MM/dd/yyyy"); }
                        else { txtFinalAssess.Text = ""; }

                        if (_crewinitialinfo.DateInputed != null && _crewinitialinfo.DateInputed.ToString() != "") { dtpDateEncoded.Value = _crewinitialinfo.DateInputed.Value; }
                        { dtpDateEncoded.Checked = false; }

                        if (_crewinitialinfo.DATE_CV != null && _crewinitialinfo.DATE_CV.ToString() != "") { txtdateCV.Text = _crewinitialinfo.DATE_CV.Value.ToString("MM/dd/yyyy"); }
                        else { txtdateCV.Text = ""; }

                        cboWRR.SelectedValue = _crewinitialinfo.WRRStatus;
                        txtInitialRemarks.Text = _crewinitialinfo.InitialRemarks;

                        //txtQualifications.Text = _Object.QUALIFICATIONS
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
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (txtcrewid.Text == "0")
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtApplicantid.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtLastname);
                txtLastname.Focus();
                return;
            }

            ManageCrew();
        }

        void ManageCrew()
        {
            //_icrew = new CrewRepository(DCLSystemConfiguration.Connection);
            iCrew _icrew = new CMSFilesRepository.rCrew();
            CAL.Model.Crew _crew = new CAL.Model.Crew();

            try
            {
                //_crew.AccountID = int.Parse(txtAccountname.Tag.ToString());
                //_crew.AcctDescription = txtAccountname.Text;
                //_crew.Company = cboCompany.Text;
                //_crew.Active = chkStatus.Checked;

                txtcrewid.Text = _icrew.ManageCrew(_crew, _mode).ToString();
                Cancel();

                _icrew = new CMSFilesRepository.rCrew();
                DisplayRecord(_icrew.GetCrew(_applicant_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            try
            {
                EnableForm(false);
                EnableButton(true);
                DisplayRecord(_icrew.GetCrew(_applicant_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
        }

        private void btnMunicipality_Click(object sender, EventArgs e)
        {
            if (Edit_btn.Enabled) 
            {
                return;
            }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.MUNICIPALITY;
            _Searchform.ShowDialog();

            //Municipality _municipality = _Searchform.ReturnSearchMunicipality;
            //if (_municipality != null)
            //{
            //    txtMunicipality.Text = _municipality.MunicipalityName;
            //    txtMunicipality.Tag = _municipality.MunicipalityID;
            //}
        }

        private void expCoca_Click(object sender, EventArgs e)
        {

        }

        //void ClearPanel()
        //{
        //    panCOCA.Controls.Clear();
        //}

        //void AddControl(Control _control)
        //{
        //    _control.Dock = DockStyle.Fill;
        //    panCOCA.Controls.Add(_control);
        //}

        private void expCoca_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (expCoca.Expanded)
            {
                ClearPanel();


                //var _control = new COCAcontrol(_crewstatusid, _crewid, _applicant_id, this);
                UserDefineClass.CMS._Cocacrewinformation _cocainfo = new UserDefineClass.CMS._Cocacrewinformation();
                _cocainfo._Crewid = _crewid;
                _cocainfo._Crewstatusid = _crewstatusid;
                _cocainfo._Applicantid = _applicant_id;

                var _control = new COCAcontrol(_cocainfo, this );
                ////_control._cocaapplicantid = _applicant_id;
                ////_control._cocacrewid = _crewid;
                ////_control._cocacrewstatusid = _crewstatusid;
                //_control._parent = this;

                AddControl(_control);

            }            
        }

        void ClearPanel()
        {
            panCOCA.Controls.Clear();
        }

        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            panCOCA.Controls.Add(_control);
        }


        private void expCoca_Click_1(object sender, EventArgs e)
        {

        }

        private void expCoca_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {

        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            if (Edit_btn.Enabled)
            {
                return;
            }

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.IRECRUIT.SOURCE;
            _Searchform.ShowDialog();

            //Source _source = _Searchform.ReturnSearchSource;
            //if (_source != null)
            //{
            //    txtSourceFrom.Text = _source.Source_Name;
            //    txtSourceFrom.Tag = _source.Source_ID;
            //}
        }

        private void btnPositionApplied_Click(object sender, EventArgs e)
        {

        }

        private void CrewInfoControl_KeyDown(object sender, KeyEventArgs e)
        {
            try { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
