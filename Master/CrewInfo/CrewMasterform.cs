using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;


using CAL.Global;
using DCLGlobal.Classes;
using DCLGlobal.Master.CrewInfo;

using DCLGlobal.Transaction.Contract;
using DCLGlobal.Transaction.Request;
using DCLGlobal.Transaction.Recruit.Assessment;
using DCLGlobal.Master.Accounting;
using DCLGlobal.Inquiry;
using CAL.Model;

using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
//using CMS.Transaction.Medical;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewMasterform : Form
    {
        int _crewid = 0;
        int _crewstatusid = 0;
        //int _candidateid = 0;

        string _applicantid = "";
        public bool _status = false;
        public bool _iscrew = false;
        public bool _iswatchlist = false;
        public int _medicalrequestid = 0;
        public int _crewstatus = 0;
        public bool _crewrecord = false;

        public CrewMasterform(int _Crewid, int _Crewstatusid, string _Applicantid)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _crewstatusid = _Crewstatusid;
            _applicantid = _Applicantid;
        }

        public CrewMasterform(int _Crewid, int _Crewstatusid, string _Applicantid, bool Crewrecord)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _crewstatusid = _Crewstatusid;
            _applicantid = _Applicantid;
            _crewrecord = Crewrecord;
        }

        public CrewMasterform(int _Crewid, int _Crewstatusid, string _Applicantid, int Medicalrequestid)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _crewstatusid = _Crewstatusid;
            _applicantid = _Applicantid;
            _medicalrequestid = Medicalrequestid;
        }

        private void btnBiodata_Click(object sender, EventArgs e)
        {
            btnbiodataclick();
        }

        public void btnbiodataclick()
        {            
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW, SystemModuleType.Masterfile ) == false) { return; }
            ClearPanel();
            var _control = new CrewInfoControl(this);
            _control._applicant_id = _applicantid;
            _control._crewid = _crewid;
            _control._crewstatusid = _crewstatusid;
            AddControl(_control);
        }

        private void item_document_Click(object sender, EventArgs e)
        {

        }

        void ClearPanel()
        {
            panExpan.Controls.Clear();
        }

        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            panExpan.Controls.Add(_control);
        }



        private void item_document_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnCrewdocument_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_DOCUMENT, SystemModuleType.Masterfile ) == false) { return; }
            ClearPanel();
            var _control = new CrewDocumentControl(_applicantid, _crewid, "D");            
            AddControl(_control);
        }

        private void btnCrewLicense_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_LICENSE, SystemModuleType.Masterfile ) == false) { return; }
            ClearPanel();
            var _control = new CrewLicenseControl(_applicantid, _crewid, "L");
            AddControl(_control);
        }

        private void CrewMasterform_Load(object sender, EventArgs e)
        {
            try 
            {
                btnbiodataclick();
                if (_medicalrequestid != 0) { ClickMedicalRecords();                }
                if (_crewrecord) { ClickCurrentContract(); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                Thread _thread = new Thread(new ThreadStart(DisplayCrewImage));
                _thread.IsBackground = true;
                _thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayCrewImage()
        {
            try
            {
                if (System.IO.File.Exists(DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".JPEG")) 
                {
                    Impersonator iU = new Impersonator();
                    iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);
                    DisplayImage(_applicantid + ".jpeg");
                    iU.Undo();
                }
                else 
                { 
                    DisplayImage("default_face.gif");   
                }

                ChangeBGStatusColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeBGStatusColor()
        {
            if (_crewstatus == 0) { panStatus.BackColor = Color.Black; }
            else if (_crewstatus == 1) { panStatus.BackColor = Color.Yellow; }
            else if (_crewstatus == 2) { panStatus.BackColor = Color.Green; }
            else if (_crewstatus == 3) { panStatus.BackColor = Color.Blue; }
            
            if (_iswatchlist) { panStatus.BackColor = Color.Red; }
        }
        #region DELEGATES
        private delegate void DisplayImageDelegate(string _value);
        public void DisplayImage(string _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new DisplayImageDelegate(this.DisplayImage), new object[] { _value });
            }
            else
            {
                this.picCrew.ImageLocation = DCLSystemConfiguration.CMS.Imagepath + _value;
            }
        }

        private void btnCrewTraining_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_TRAINING, SystemModuleType.Masterfile ) == false) { return; }
            ClearPanel();
            var _control = new CrewTrainingControl(_applicantid, _crewid, "T");
            AddControl(_control);
        }

        private void btnCrewMedical_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_MEDICAL, SystemModuleType.Transaction ) == false) { return; }
            ClearPanel();
            var _control = new CrewMedicalControl(_applicantid, "M");
            AddControl(_control);
        }

        private void btnCrewBenificiaries_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_BENEFICIARIES, SystemModuleType.Masterfile ) == false) { return; }
            ClearPanel();
            var _control = new CrewBeneficiariesControl(_crewid, _applicantid);
            AddControl(_control);
        }
        #endregion

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            ClickCurrentContract();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {            
            if (LoginUser.appmodule != appmodule.IRECRUIT)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClearPanel();
            var _control = new InitialAssessmentControl("LIVE", LoginAppModule.AppModule, _applicantid, 0);
            AddControl(_control);
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.IRECRUIT)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClearPanel();
            var _control = new TestingAssessmentControl("LIVE", LoginAppModule.AppModule, _applicantid, 0);
            AddControl(_control);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.IRECRUIT)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClearPanel();
            var _control = new TechnicalAssessmentControl("LIVE", LoginAppModule.AppModule, _applicantid, 0);
            AddControl(_control);
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.IRECRUIT)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClearPanel();
            var _control = new FinalAssessmentControl("LIVE", LoginAppModule.AppModule, _applicantid, 0 );
            AddControl(_control);
        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Inquiry.PROPOSED_HISTORY, SystemModuleType.Inquiry ) == false) { return; }
            ClearPanel();
            var _control = new ProposedHistoryControl(_applicantid);
            AddControl(_control);
        }

        public void ClickMedicalRecords()
        {
            try
            {
                if (LoginUser.appmodule != appmodule.CMS)
                {
                    MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnbiodataclick();
                    return;
                }

                if (this._iscrew == false)
                {
                    MessageBox.Show("You cannot edit/update any contract information once Candidate is not yet accepted by client. kindly update his/her status first on iRequest before proceeding.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnbiodataclick();
                    return;
                }
                if (this._status == false)
                {
                    MessageBox.Show("You cannot edit/update any contract information once crew is inactive. kindly update his/her status first before proceeding.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnbiodataclick();
                    return;
                }
                if (this._iswatchlist == true)
                {
                    MessageBox.Show("You cannot edit/update any contract information once crew is tag Watch List. kindly update his/her status first before proceeding.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnbiodataclick();
                    return;
                }


                if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Transaction.MEDICAL_REQUEST, SystemModuleType.Transaction) == false) { return; }
                ClearPanel();
                var _control = new CrewMedicalRequestControl(_applicantid, _crewstatusid, _medicalrequestid);
                AddControl(_control);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        public void ClickCurrentContract()
        {

            if (LoginUser.appmodule != appmodule.CMS)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this._iscrew == false)
            {
                MessageBox.Show("You cannot edit/update any contract information if Candidate is not yet accepted by client. kindly update his/her status first on iRequest before proceeding.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this._status == false)
            {
                MessageBox.Show("You cannot edit/update any contract information once crew is inactive. kindly update his/her status first before proceeding.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this._iswatchlist == true)
            {
                MessageBox.Show("You cannot edit/update any contract information once crew is tag Watch List. kindly update his/her status first before proceeding.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ClearPanel();
            var _control = new CrewContractControl(this, _crewstatusid, _crewid, _applicantid);
            AddControl(_control);
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            ClickMedicalRecords();           
        }

        private void btnEmploymentHistory_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_EXPERIENCE, SystemModuleType.Masterfile ) == false) { return; }
            ClearPanel();
            var _control = new CrewEmploymentHistoryControl(_applicantid);
            AddControl(_control);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OFD1.Title = "Select a file";

                OFD1.Filter = "All Picture Files|*.jpeg;*.jpg;*.bmp;*.gif;*.png";

                
                OFD1.ShowDialog();

                if (OFD1.FileName == "") { return; }
                picCrew.ImageLocation = OFD1.FileName;

                Impersonator iU = new Impersonator();
                iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);

                if (System.IO.File.Exists(DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".JPEG"))
                {
                    System.IO.File.Delete(DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".JPEG");
                }
                File.Copy(OFD1.FileName, DCLSystemConfiguration.CMS.Imagepath + _applicantid + ".JPEG");
                iU.Undo();

                ToolsControl.CallShowNotification(this, 4, "Image successfully uploaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.CMS && LoginUser.appmodule != appmodule.IRECRUIT)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnbiodataclick();
                return;
            }

            if (_applicantid == "")
            {
                MessageBox.Show("Kindly select a crew first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnbiodataclick();
                return;
            }

            if (_crewid == 0)
            {
                MessageBox.Show("Selected Record is not yet a valid Crew", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnbiodataclick();
                return;
            }

            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_CONTRACT, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new CrewExperienceControl(_crewid, _crewstatusid, _applicantid);
            //_control._crewid = _crewid;
            AddControl(_control);
        }

        private void ItemPanel1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnCOCA_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.DCLAPS)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (ToolsControl.ModuleAccess(this, SystemModule.CMS.Master.CREW_CONTRACT, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new AccountingPersonnalControl();
            AddControl(_control);
        }

        private void buttonItem2_Click_1(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.DCLAPS)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.DCLAPS)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            if (LoginUser.appmodule != appmodule.DCLAPS)
            {
                MessageBox.Show("You dont have access to this module. Kindly coordinate to your System Administrator.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void CrewMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                try
                {
                    Searchform _Searchform = new Searchform();
                    _Searchform._searchby = searchby.CMS.CREW;
                    _Searchform.ShowDialog();

                    //Crew _crew = _Searchform.ReturnSearchCrewById;
                    //if (_crew != null)
                    //{
                    //    _applicantid = _crew.ApplicantID;
                    //    if (_crew.IsCrew == 1)
                    //    {
                    //        _crewid = int.Parse(_crew.CrewId.ToString());
                    //        _crewstatusid = 0;

                    //        iContract _icontract = new CMSTransactionRepository.rContract();
                    //        CrewRecord _crewrecord = _icontract.GetCrewRecord(_crewid, 0);
                    //        if (_crewrecord != null)
                    //        {
                    //            _crewstatusid = _crewrecord.CrewStatusID;
                    //            _crewstatus = _crewrecord.CrewStatus;                                
                    //        }
                    //    }
                    //    else 
                    //    {
                    //        _crewid = 0;
                    //        _crewstatusid = 0;
                    //        _crewstatus = 0;
                    //    }

                    //    btnbiodataclick();
                    //    DisplayCrewImage();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Municipality _municipality = _Searchform.ReturnSearchMunicipality;
                //if (_municipality != null)
                //{
                //    txtMunicipality.Text = _municipality.MunicipalityName;
                //    txtMunicipality.Tag = _municipality.MunicipalityID;
                //}
            }
        }
    }
}
