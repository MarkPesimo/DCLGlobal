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
    public partial class TechnicalAssessmentControl : UserControl
    {
        string _viewtype = "LIVE";
        string _frommodule = "IRECRUIT";
        string _applicantid = "";
        int _initialid = 0;
        int _candidateid = 0;

        public TechnicalAssessmentControl(string Viewtype, string Frommodule, string Applicantid, int Candidateid)
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

        private void TechnicalAssessmentControl_Load(object sender, EventArgs e)
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            iCrew _icrew = new CMSFilesRepository.rCrew();

            try
            {
                CrewInitialInformation _initialinfo = _icrew.GetCrewInitialInfo(_applicantid);
                if (_initialinfo != null) { _initialid = _initialinfo.InitialID; }

                if (_viewtype == "LIVE") { DisplayTechnicalAssessment(_irecruit.GetTechnicalAssessment(_initialid)); }
                else { DisplayTechnicalAssessmentHistory(_irecruit.GetTechnicalAssessmentHistory(_candidateid)); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetStarsValue(string _value)
        {
            int _return = 0;
            try
            {
                if (_value == "Not Qualified") { _return = 0; }
                else if (_value == "Poor") { _return = 1; }
                else if (_value == "Below Average") { _return = 2; }
                else if (_value == "Average") { _return = 3; }
                else if (_value == "Above Average") { _return = 4; }
                else if (_value == "Superior") { _return = 5; }
                else { _return = 0; }                

                return _return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        void DisplayTechnicalAssessment(CrewTechnical _crewtechnical)
        {
            try
            {
                if (_crewtechnical != null)
                {
                    dtpDateAssess.Value = _crewtechnical.CrewInitialInformation.DateTechnical.Value;

                    rateKnowledge.Stars = GetStarsValue(_crewtechnical.Knowledge.ToString());
                    rateSkill.Stars = GetStarsValue(_crewtechnical.Skills.ToString());
                    rateExperience.Stars = GetStarsValue(_crewtechnical.Experience.ToString());
                    rateAttitude.Stars = GetStarsValue(_crewtechnical.Attititude.ToString());
                    rateOverall.Stars = GetStarsValue(_crewtechnical.Result.ToString());
                    txtRemarks.Text = _crewtechnical.Remarks;

                    if (_crewtechnical.Status != null) { chkPassed.Checked = true; }
                    else { chkPassed.Checked = false; }

                    if (_crewtechnical.AssessBy != null) { txtAssessby.Text = _crewtechnical.AssessBy; }
                    else { txtAssessby.Text = ""; }

                    if (_crewtechnical.OverallAssess != null) { txtOverallAssess.Text = _crewtechnical.OverallAssess; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayTechnicalAssessmentHistory(CrewTechnicalBack _crewtechnical)
        {
            try
            {
                if (_crewtechnical != null)
                {
                    dtpDateAssess.Value = _crewtechnical.dateassess.Value;

                    rateKnowledge.Stars = GetStarsValue(_crewtechnical.Knowledge.ToString());
                    rateSkill.Stars = GetStarsValue(_crewtechnical.Skills.ToString());
                    rateExperience.Stars = GetStarsValue(_crewtechnical.Experience.ToString());
                    rateAttitude.Stars = GetStarsValue(_crewtechnical.Attititude.ToString());
                    rateOverall.Stars = GetStarsValue(_crewtechnical.OverallAssess.ToString());
                    txtRemarks.Text = _crewtechnical.Remarks;

                    if (_crewtechnical.Status != null) { chkPassed.Checked = true; }
                    else { chkPassed.Checked = false; }

                    if (_crewtechnical.AssessBy != null) { txtAssessby.Text = _crewtechnical.AssessBy; }
                    else { txtAssessby.Text = ""; }

                    if (_crewtechnical.OverallAssess != null) { txtOverallAssess.Text = _crewtechnical.OverallAssess; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (txtRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtRemarks);
                txtRemarks.Focus();
                return;
            }
            if (!dtpDateAssess.Checked)
            {
                MessageBox.Show("Date Assess cannot be blank.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDateAssess.Focus();
                return;
            }


            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            CrewTechnical _crewtechnical = new CrewTechnical();
            try
            {
                if (MessageBox.Show("Save this Technical Assessment, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                _crewtechnical.InitialID = _initialid;
                _crewtechnical.Knowledge = rateKnowledge.Stars.ToString();
                _crewtechnical.Skills = rateSkill.Stars.ToString();
                _crewtechnical.Experience = rateExperience.Stars.ToString();
                _crewtechnical.Attititude = rateAttitude.Stars.ToString();
                _crewtechnical.OverallAssess = rateOverall.Stars.ToString();
                _crewtechnical.Remarks = txtRemarks.Text;
                _crewtechnical.Status = chkPassed.Checked;
                _crewtechnical.DateAssess = dtpDateAssess.Value;


                _irecruit.ManageTechnicalAssessment(_crewtechnical);
                ToolsControl.CallShowNotification(this, 4, "Testing Assessment successfully saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkPassed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rateOverall_ValueChanged(object sender, EventArgs e)
        {        
            try 
            {
                iRating _irating = new CMSFilesRepository.rRating();
                if (LoginUser.companycode == "SMS") { txtOverallAssess.Text = _irating.GetRating(rateOverall.Stars, "TECHNICAL OVERALL SMS"); }
                else { txtOverallAssess.Text = _irating.GetRating(rateOverall.Stars, "TECHNICAL OVERALL MRA"); }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
