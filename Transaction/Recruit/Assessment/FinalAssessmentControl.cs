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

namespace DCLGlobal.Transaction.Recruit.Assessment
{
    public partial class FinalAssessmentControl : UserControl
    {
        string _viewtype = "LIVE";
        string _frommodule = "IRECRUIT";
        string _applicantid = "";
        int _initialid = 0;
        int _candidateid = 0;

        public FinalAssessmentControl(string Viewtype, string Frommodule, string Applicantid, int Candidateid)
        {
            _viewtype = Viewtype;
            _frommodule = Frommodule;
            _applicantid = Applicantid;
            _candidateid = Candidateid;

            InitializeComponent();  

            if (_viewtype == "LIVE")
            {
                if (_frommodule == appmodule.IRECRUIT)
                {
                    passedbtn.Enabled = true;
                    failedbtn.Enabled = true;
                }
                else
                {
                    passedbtn.Enabled = false;
                    failedbtn.Enabled = false;
                }
            }
            else
            {
                passedbtn.Enabled = false;
                failedbtn.Enabled = false;
            }                      
        }

        void DisplayFinalInformation()
        {
            iCrew _icrew = new CMSFilesRepository.rCrew();
            
            try
            {
                CrewInitialInformation _initialinfo = _icrew.GetCrewInitialInfo(_applicantid);
                if (_initialinfo != null)
                {
                    if (bool.Parse(_initialinfo.IsPolling.ToString())) { lblForPooling.Text = "YES"; }
                    else { lblForPooling.Text = "NO";}


                    txtFinalRemarks.Text = _initialinfo.Remarks;
                    if( _initialinfo.DateFinal != null)
                    {
                        dtpFinalAssess.Checked = true;
                        dtpFinalAssess.Value = _initialinfo.DateFinal.Value;
                    }
                    else
                    {
                        dtpFinalAssess.Checked = false;
                    }

                    if (_initialinfo.DateTest != null) { txtDateTesting.Text = _initialinfo.DateTest.Value.ToString("MM/dd/yyyy"); }
                    if (_initialinfo.DateTechnical != null) { txtDateTechnical.Text = _initialinfo.DateTechnical.Value.ToString("MM/dd/yyyy"); }
                    if (_initialinfo.DateInitial != null) { txtDateInitial.Text = _initialinfo.DateInitial.Value.ToString("MM/dd/yyyy"); }


                    if (_initialinfo.FAILED_BUT_PASSED.ToString() != "")
                    {
                        if (_initialinfo.FAILED_BUT_PASSED == 1) { chkNameHired.Checked = true; }
                        else { chkNameHired.Checked = false; }

                    }
                    else
                    {
                        chkNameHired.Checked = false;
                    }

                    if (_initialinfo.Status == 0) { lblStatus.Text = ""; }
                    else if (_initialinfo.Status == 5) { lblStatus.Text = "FAILED"; }
                    else { lblStatus.Text = "PASSED"; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }
        void DisplayTestingAssessment()
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            try
            {
                CrewTesting _crewtesting = _irecruit.GetTestingAssessment(_initialid);
                if (_crewtesting != null)
                {
                    txtTMental.Text = _crewtesting.MentalAbilityRemarks;
                    txtTAptitude.Text = _crewtesting.AttitudeRemarks;
                    txtTPersonality.Text = _crewtesting.PersonalityRemarks;
                    txtTTechnical.Text = _crewtesting.Remarks;
                    txtTMarlin.Text = _crewtesting.MarlinsScore;
            
                    if(bool.Parse( _crewtesting.Status.ToString()) )
                    {
                        txtTestResult.Text = "Passed"; 
                        txtTestResult.ForeColor = Color.Blue;
                    }
                    else
                    {
                        txtTestResult.Text = "Failed";
                        txtTestResult.ForeColor = Color.Red;
                    }
                }                
            }                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayTechnicalAssessment()
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            try
            {
                CrewTechnical _crewtechnical = _irecruit.GetTechnicalAssessment(_initialid);
                if (_crewtechnical != null)
                {
                    txtTIKnowledge.Text = _crewtechnical.Knowledge;
                    txtTISkills.Text = _crewtechnical.Skills;
                    txtTIExperience.Text = _crewtechnical.Experience;
                    txtTIAttitude.Text = _crewtechnical.Attititude;
                    txtTIOverall.Text = _crewtechnical.Result;
                    txtTIRemarks.Text = _crewtechnical.Remarks;

                    if (_crewtechnical.Status == null) { txtTechnicalResult.Text = ""; }
                    else  
                    {
                        if(bool.Parse( _crewtechnical.Status.ToString()))
                        {
                            txtTechnicalResult.Text = "Passed";
                            txtTechnicalResult.ForeColor = Color.Blue;
                        }
                        else
                        {
                            txtTechnicalResult.Text = "Failed";
                            txtTechnicalResult.ForeColor = Color.Red;
                        }
                    }
                    if(_crewtechnical.AssessBy == null) { txtTechnicalAssess.Text = "";}
                    else { txtTechnicalAssess.Text = _crewtechnical.AssessBy;}
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayInitialAssessment()
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            
            try 
            {
                CrewInitalAssestment _crewinitialassessment = _irecruit.GetInitialAssessment(_initialid);
                if (_crewinitialassessment != null)
                { 
                    txtIAPhysical.Text = _crewinitialassessment.PhysicalRemarks;
                    txtAICommunication.Text = _crewinitialassessment.ComunicationRemarks;
                    txtAIEducation.Text = _crewinitialassessment.EducationRemarks;
                    txtAIPersonnality.Text = _crewinitialassessment.PersonalityRemarks;
                    txtIAOverall.Text = _crewinitialassessment.OverrAllRemarks;                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalAssessmentControl_Load(object sender, EventArgs e)
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            iCrew _icrew = new CMSFilesRepository.rCrew();

            try
            {
                CrewInitialInformation _initialinfo = _icrew.GetCrewInitialInfo(_applicantid);
                if (_initialinfo != null) { _initialid = _initialinfo.InitialID; }

                DisplayInitialAssessment();
                DisplayTestingAssessment();
                DisplayTechnicalAssessment();

                DisplayFinalInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void failedbtn_Click(object sender, EventArgs e)
        {
            try
            {                
                if (MessageBox.Show("Save this Final Assessment, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                ManageFinalAssessment(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageFinalAssessment(int _mode)
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            if (txtFinalRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtFinalRemarks);
                txtFinalRemarks.Focus();
                return;
            }

            try
            {
                int _failedbutpassed = 0;
                if (chkNameHired.Checked) { _failedbutpassed = 1; }
                else { _failedbutpassed = 0; }


                _irecruit.FinalAssessment(0, _initialid, _applicantid, txtFinalRemarks.Text, _failedbutpassed);

                ToolsControl.CallShowNotification(this, 4, "Final Assessment successfully saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void passedbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save this Final Assessment, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                ManageFinalAssessment(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
