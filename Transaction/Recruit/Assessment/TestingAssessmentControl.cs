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
    public partial class TestingAssessmentControl : UserControl
    {
        string _viewtype = "LIVE";
        string _frommodule = "IRECRUIT";
        string _applicantid = "";
        int _initialid = 0;
        int _candidateid = 0;

        public TestingAssessmentControl(string Viewtype, string Frommodule, string Applicantid, int Candidateid)
        {
            InitializeComponent();

            _viewtype = Viewtype;
            _frommodule = Frommodule;
            _applicantid = Applicantid;
            _candidateid = Candidateid;

            if (_viewtype == "LIVE")
            {
                if (_frommodule == appmodule.IRECRUIT) { savebtn.Enabled = true; }
                else { savebtn.Enabled = false; }
            }
            else { savebtn.Enabled = false; }
        }

        private void TestingAssessmentControl_Load(object sender, EventArgs e)
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            iCrew _icrew = new CMSFilesRepository.rCrew();

            try
            {
                CrewInitialInformation _initialinfo = _icrew.GetCrewInitialInfo(_applicantid);
                if (_initialinfo != null) { _initialid = _initialinfo.InitialID; }

                if (_viewtype == "LIVE") { DisplayTestingAssessment(_irecruit.GetTestingAssessment(_initialid)); }
                else { DisplayTestingAssessmentBack(_irecruit.GetTestingAssessmentHistory(_candidateid)); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayTestingAssessment(CrewTesting _crewtesting)
        {
            try
            {
                if (_crewtesting != null)
                {                    
                    if (_crewtesting.DescriptionType != null) { cboDescription.Text = _crewtesting.DescriptionType; }
                    else { cboDescription.SelectedIndex = 0; }

                    dtpDateAssess.Value = _crewtesting.CrewInitialInformation.DateTest.Value;
                    rateMental.Stars = ConvertToStarValue(_crewtesting.MentalAbility.ToString() == "" ? "NA" : _crewtesting.MentalAbility.ToString(), "MENTALABILITY");
                    txtMentalRemark.Text = _crewtesting.MentalAbilityRemarks;

                    rateApritude.Stars = ConvertToStarValue(_crewtesting.Attitude.ToString() == "" ? "NA" : _crewtesting.Attitude.ToString(), "ATTITUDE");
                    txtAptirudeRemark.Text = _crewtesting.AttitudeRemarks;

                    ratePersonnality.Stars = ConvertToStarValue(_crewtesting.Personality.ToString() == "" ? "NA" : _crewtesting.Personality.ToString(), "PERSONALITY");
                    txtPersonnalityRemark.Text = _crewtesting.PersonalityRemarks;

                    rateTechnical.Stars = ConvertToStarValue(_crewtesting.Technical.ToString() == "" ? "NA" : _crewtesting.Technical.ToString(), "TECHNICAL");
                    txtTechnicalRemark.Text = _crewtesting.Remarks;

                    rateITest.Stars = ConvertToStarValue(_crewtesting.Technical_Itest.ToString() == "" ? "NA" : _crewtesting.Technical_Itest.ToString(), "TECHNICAL ITEST");
                    txtITestRemarks.Text = _crewtesting.ITest_Remarks;    

                    txtMarlinScore.Text = _crewtesting.MarlinsScore;

                    if (bool.Parse(_crewtesting.Status.ToString())) 
                    { chkPassed.Checked = bool.Parse( _crewtesting.Status.ToString()); }
                    else 
                    { chkPassed.Checked = false; }

                    if (bool.Parse( _crewtesting.English_Status.ToString())) 
                    { cboEnglish.SelectedIndex = 0; }
                    else 
                    { cboEnglish.SelectedIndex = 1; }

                    if (bool.Parse(_crewtesting.Written_Status.ToString())) 
                    { cboWritten.SelectedIndex = 0;}
                    else 
                    {cboWritten.SelectedIndex = 1;}

                    if (bool.Parse(_crewtesting.ITest_Status.ToString())) 
                    { cboItest.SelectedIndex = 0; }
                    else 
                    { cboItest.SelectedIndex = 1; }                        
                }
                else
                {
                    cboDescription.SelectedIndex = 0;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ConvertToStarValue(string _value, string _type)
        {
            int _return = 0;

            if (_type == "MENTALABILITY")
            {
                if (_value == "NA") { _return = 0; }
                else if (_value == "Low-Mental") { _return = 1; }
                else if (_value == "Below Average-Mental") { _return = 2; }
                else if (_value == "Average-Mental") { _return = 3; }
                else if (_value == "Above Average-Mental") { _return = 4; }
                else if (_value == "Superrior-Mental") { _return = 5; }
                else { _return = 0; }
            }
            else if (_type == "ATTITUDE")
            {
                if (_value == "NA") { _return = 0; }
                else if (_value == "Low-Aptitude") { _return = 1; }
                else if (_value == "Below Average-Aptitude") { _return = 2; }
                else if (_value == "Average-Aptitude") { _return = 3; }
                else if (_value == "Above Average-Aptitude") { _return = 4; }
                else if (_value == "Superior-Aptitude") { _return = 5; }
                else { _return = 0; }
            }
            else if (_type == "PERSONALITY")
            {
                if (_value == "NA") { _return = 0; }
                else if (_value == "Low-Personlity") { _return = 1; }
                else if (_value == "Below Average-Personlity") { _return = 2; }
                else if (_value == "Average-Personlity") { _return = 3; }
                else if (_value == "Above-Personlity") { _return = 4; }
                else if (_value == "Superrior-Personlity") { _return = 5; }
                else { _return = 0; }
            }
            else if (_type == "TECHNICAL")
            {
                if (_value == "NA") { _return = 0; }
                else if (_value == "Low-Technical") { _return = 1; }
                else if (_value == "Below Average-Technical") { _return = 2; }
                else if (_value == "Average-Technical") { _return = 3; }
                else if (_value == "Above Average-Technical") { _return = 4; }
                else if (_value == "Superior-Technical") { _return = 5; }
                else { _return = 0; }
            }
            else if (_type == "TECHNICAL ITEST")
            {
                if (_value == "NA") { _return = 0; }
                else if (_value == "Low-ITest") { _return = 1; }
                else if (_value == "Below Average-ITest") { _return = 2; }
                else if (_value == "Average-ITest") { _return = 3; }
                else if (_value == "Above Average-ITest") { _return = 4; }
                else if (_value == "Superior-Itest") { _return = 5; }
                else { _return = 0; }
            }

            return _return;
        }

        void DisplayTestingAssessmentBack(CrewTestingBack _crewtesting)
        {
            try
            {
                if (_crewtesting != null)
                {                
                    if (_crewtesting.DescriptionType != null) { cboDescription.Text = _crewtesting.DescriptionType; }
                    else { cboDescription.SelectedIndex = 0; }

                    dtpDateAssess.Value = _crewtesting.dateassess.Value;
                    rateMental.Stars = ConvertToStarValue(_crewtesting.MentalAbility.ToString() == "" ? "NA" : _crewtesting.MentalAbility.ToString(), "MENTALABILITY");
                    txtMentalRemark.Text = _crewtesting.MentalAbilityRemarks;

                    rateApritude.Stars = ConvertToStarValue(_crewtesting.Attitude.ToString() == "" ? "NA" : _crewtesting.Attitude.ToString(), "ATTITUDE");
                    txtAptirudeRemark.Text = _crewtesting.AttitudeRemarks;

                    ratePersonnality.Stars = ConvertToStarValue(_crewtesting.Personality.ToString() == "" ? "NA" : _crewtesting.Personality.ToString(), "PERSONALITY");
                    txtPersonnalityRemark.Text = _crewtesting.PersonalityRemarks;

                    rateTechnical.Stars = ConvertToStarValue(_crewtesting.Technical.ToString() == "" ? "NA" : _crewtesting.Technical.ToString(), "TECHNICAL");
                    txtTechnicalRemark.Text = _crewtesting.Remarks;

                    rateITest.Stars = ConvertToStarValue(_crewtesting.Technical_Itest.ToString() == "" ? "NA" : _crewtesting.Technical_Itest.ToString(), "TECHNICAL ITEST");
                    txtITestRemarks.Text = _crewtesting.ITest_Remarks;

                    txtMarlinScore.Text = _crewtesting.MarlinsScore;

                    if (bool.Parse( _crewtesting.Status.ToString()))
                    { chkPassed.Checked = bool.Parse( _crewtesting.Status.ToString()); }
                    else { chkPassed.Checked = false; }

                    if (bool.Parse( _crewtesting.English_Status.ToString())) 
                    { cboEnglish.SelectedIndex = 0; }
                    else { cboEnglish.SelectedIndex = 1; }

                    if (bool.Parse(_crewtesting.Written_Status.ToString())) 
                    { cboWritten.SelectedIndex = 0;}
                    else {cboWritten.SelectedIndex = 1;}

                    if (bool.Parse(_crewtesting.ITest_Status.ToString()))
                    { cboItest.SelectedIndex = 0; }
                    else { cboItest.SelectedIndex = 1; }                        
                }
                else
                {
                    cboDescription.SelectedIndex = 0;
                }                                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void chkMental_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMental.Checked )
            {
                rateMental.Stars = 0;
                txtMentalRemark.Text = "NA";
            }
            else
            {
                txtMentalRemark.Text = "";
            }
        }

        private void chkAppt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAppt.Checked ) { txtAptirudeRemark.Text = "NA"; }
            else { txtAptirudeRemark.Text = ""; }
        }

        private void chkPersonality_CheckedChanged(object sender, EventArgs e)
        {
            if( chkPersonality.Checked)
            {
                ratePersonnality.Stars = 0;
                txtPersonnalityRemark.Text = "NA";
            }
            else
            {
                txtPersonnalityRemark.Text = "";
            }
        }

        private void chkTechnical_CheckedChanged(object sender, EventArgs e)
        {
            if( chkTechnical.Checked )
            {   rateTechnical.Stars = 0;
                txtTechnicalRemark.Text = "NA";
            }
            else
            {
                txtTechnicalRemark.Text = "";}
            
        }

        private void chkItest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkItest.Checked) { txtITestRemarks.Text = "NA"; }
            else { txtITestRemarks.Text = ""; }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
        //    If txtMentalRemark.Text.Length = 0 Then
        //    BalloonNotify.ShowBalloon(txtMentalRemark)
        //    txtMentalRemark.Focus()
        //    Exit Sub
        //End If
        //If txtAptirudeRemark.Text.Length = 0 Then
        //    BalloonNotify.ShowBalloon(txtAptirudeRemark)
        //    txtAptirudeRemark.Focus()
        //    Exit Sub
        //End If
        //If txtPersonnalityRemark.Text.Length = 0 Then
        //    BalloonNotify.ShowBalloon(txtPersonnalityRemark)
        //    txtPersonnalityRemark.Focus()
        //    Exit Sub
        //End If
        //If txtTechnicalRemark.Text.Length = 0 Then
        //    BalloonNotify.ShowBalloon(txtTechnicalRemark)
        //    txtTechnicalRemark.Focus()
        //    Exit Sub
        //End If
        //If dtpDateTesting.Checked = False Then
        //    MsgBox("Date testing cannot be blank", MsgBoxStyle.Information, "Info")
        //    dtpDateTesting.Focus()
        //    Exit Sub
        //End If

            if (txtMentalRemark.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtMentalRemark);
                txtMentalRemark.Focus();
                return;
            }
            if (txtAptirudeRemark.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtAptirudeRemark);
                txtAptirudeRemark.Focus();
                return;
            }
            if (txtPersonnalityRemark.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPersonnalityRemark);
                txtPersonnalityRemark.Focus();
                return;
            }
            if (txtTechnicalRemark.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtTechnicalRemark);
                txtTechnicalRemark.Focus();
                return;
            }
            if (!dtpDateAssess.Checked)
            {
                MessageBox.Show("Date Assess cannot be blank.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDateAssess.Focus();
                return;
            }

            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            CrewTesting _crewtesting = new CrewTesting();
            try 
            {
                if (MessageBox.Show("Save this Testing Assessment, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                _crewtesting.InitialID = _initialid;
                _crewtesting.MentalAbility = rateMental.Stars.ToString();
                _crewtesting.MentalAbilityRemarks = txtMentalRemark.Text;
                _crewtesting.Attitude = rateApritude.Stars.ToString();
                _crewtesting.AttitudeRemarks = txtAptirudeRemark.Text;
                _crewtesting.Personality = ratePersonnality.Stars.ToString();
                _crewtesting.PersonalityRemarks = txtPersonnalityRemark.Text;
                _crewtesting.Technical = rateTechnical.Stars.ToString();
                _crewtesting.Remarks = txtTechnicalRemark.Text;
                _crewtesting.MarlinsScore = txtMarlinScore.Text;
                _crewtesting.Status = chkPassed.Checked;
                _crewtesting.DescriptionType = cboDescription.Text;
                _crewtesting.ITest_Remarks = txtITestRemarks.Text;
                
                if (cboEnglish.SelectedIndex == 0){ _crewtesting.English_Status = true;}
                else { _crewtesting.English_Status = false; }
                if( cboWritten.SelectedIndex == 0) { _crewtesting.Written_Status = true; }
                else { _crewtesting.Written_Status = false; }
                if (cboItest.SelectedIndex == 0) { _crewtesting.ITest_Status = true; }
                else { _crewtesting.ITest_Status = false; }
            
                _irecruit.ManageTestingAssessment(_crewtesting, rateITest.Stars.ToString());

                ToolsControl.CallShowNotification(this, 4, "Testing Assessment successfully saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rateMental_Load(object sender, EventArgs e)
        {

        }

        private void rateMental_ValueChanged(object sender, EventArgs e)
        {
            iRating _irating = new CMSFilesRepository.rRating();
            try
            {
                txtMentalRemark.Text = _irating.GetRating(rateMental.Stars, "MENTAL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void rateApritude_Load(object sender, EventArgs e)
        {
            
        }

        private void rateTechnical_Load(object sender, EventArgs e)
        {
            
        }

        private void ratePersonnality_Load(object sender, EventArgs e)
        {
            
        }

        private void rateITest_Load(object sender, EventArgs e)
        {                
          
            
        }

        private void rateApritude_ValueChanged(object sender, EventArgs e)
        {
            iRating _irating = new CMSFilesRepository.rRating();
            try
            {
                txtAptirudeRemark.Text = _irating.GetRating(rateApritude.Stars, "APTITUDE");
                if (rateApritude.Stars > 2) { cboEnglish.Text = "Passed"; }
                else { cboEnglish.Text = "Failed"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rateITest_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rateITest.Stars > 2) { cboItest.Text = "Passed"; }
                else { cboItest.Text = "Failed"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void ratePersonnality_ValueChanged(object sender, EventArgs e)
        {
            iRating _irating = new CMSFilesRepository.rRating();
            try
            {
                txtPersonnalityRemark.Text = _irating.GetRating(ratePersonnality.Stars, "PERSONALITY");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void rateTechnical_ValueChanged(object sender, EventArgs e)
        {
            iRating _irating = new CMSFilesRepository.rRating();
            try
            {
                if (cboDescription.SelectedIndex == 0)
                { txtTechnicalRemark.Text = _irating.GetRating(rateTechnical.Stars, "TECHNICAL"); }
                else { txtTechnicalRemark.Text = _irating.GetRating(rateTechnical.Stars, "TECHNICAL DECK"); }

                if (rateTechnical.Stars > 2) { cboWritten.Text = "Passed"; }
                else { cboWritten.Text = "Failed"; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
