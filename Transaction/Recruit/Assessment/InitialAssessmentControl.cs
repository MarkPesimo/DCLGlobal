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
    public partial class InitialAssessmentControl : UserControl
    {
        string _viewtype = "LIVE";
        string _frommodule = "IRECRUIT";
        string _applicantid = "";
        int _initialid = 0;
        int _candidateid = 0;

        public InitialAssessmentControl(string Viewtype, string Frommodule, string Applicantid, int Candidateid)
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

        private void InitialAssessmentControl_Load(object sender, EventArgs e)
        {
            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            iCrew _icrew = new CMSFilesRepository.rCrew();
            
            try
            {
                CrewInitialInformation _initialinfo = _icrew.GetCrewInitialInfo(_applicantid);
                if (_initialinfo != null) { _initialid = _initialinfo.InitialID; }

                if (_viewtype == "LIVE") { DisplayInitialAssessment(_irecruit.GetInitialAssessment(_initialid)); }
                else { DisplayInitialAssessmentBack(_irecruit.GetInitialAssessmentHistory(_candidateid)); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayInitialAssessment(CrewInitalAssestment _initialAssessment)
        {
            if (_initialAssessment != null) 
            {
                dtpDateAssess.Value = _initialAssessment.CrewInitialInformation.DateInitial.Value;

                cboPhysical.Text = _initialAssessment.PhysicalApperance;
                txtPhysicalRemarks.Text = _initialAssessment.PhysicalRemarks;
                cboCommunication.Text = _initialAssessment.Comunication;
                txtCommunicationRemarks.Text = _initialAssessment.ComunicationRemarks;
                cboEducation.Text = _initialAssessment.Education;
                txtEducationRemarks.Text = _initialAssessment.EducationRemarks;
                cboPersonnality.Text = _initialAssessment.Personality;
                txtPersonalityRemarks.Text = _initialAssessment.PersonalityRemarks;
                cboOverall.Text = _initialAssessment.OverrAll;
                txtOverallRemarks.Text = _initialAssessment.OverrAllRemarks;
            
            }
        }

        void DisplayInitialAssessmentBack(CrewInitalAssestmentBack _initialAssessment)
        {
            if (_initialAssessment != null)
            {
                dtpDateAssess.Value = _initialAssessment.DateAssess.Value;

                cboPhysical.Text = _initialAssessment.PhysicalApperance;
                txtPhysicalRemarks.Text = _initialAssessment.PhysicalRemarks;
                cboCommunication.Text = _initialAssessment.Comunication;
                txtCommunicationRemarks.Text = _initialAssessment.ComunicationRemarks;
                cboEducation.Text = _initialAssessment.Education;
                txtEducationRemarks.Text = _initialAssessment.EducationRemarks;
                cboPersonnality.Text = _initialAssessment.Personality;
                txtPersonalityRemarks.Text = _initialAssessment.PersonalityRemarks;
                cboOverall.Text = _initialAssessment.OverrAll;
                txtOverallRemarks.Text = _initialAssessment.OverrAllRemarks;

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {   
            if (txtPhysicalRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPhysicalRemarks);
                txtPhysicalRemarks.Focus();
                return;
            }
            if (txtCommunicationRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtCommunicationRemarks);
                txtCommunicationRemarks.Focus();
                return;
            }
            if (txtEducationRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtEducationRemarks);
                txtEducationRemarks.Focus();
                return;
            }
            if (txtPersonalityRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPersonalityRemarks);
                txtPersonalityRemarks.Focus();
                return;
            }
            if (txtOverallRemarks.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtOverallRemarks);
                txtOverallRemarks.Focus();
                return;
            }
            if (!dtpDateAssess.Checked)
            {
                MessageBox.Show("Date Initial Assess cannot be blank.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDateAssess.Focus();
                return;
            }

            iRecruit _irecruit = new IRECRUITTransactionRepository.rRecruit();
            CrewInitalAssestment _crewinitialassessment = new CrewInitalAssestment();
            try 
            {
                if (MessageBox.Show("Save this initial Assessment, Are you sure?","Confirm" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                _crewinitialassessment.InitialID = _initialid;
                _crewinitialassessment.PhysicalApperance = cboPersonnality.Text;
                _crewinitialassessment.PersonalityRemarks = txtPhysicalRemarks.Text;
                _crewinitialassessment.Comunication = cboCommunication.Text;
                _crewinitialassessment.ComunicationRemarks = txtCommunicationRemarks.Text;
                _crewinitialassessment.Education = cboEducation.Text;
                _crewinitialassessment.EducationRemarks = txtEducationRemarks.Text;
                _crewinitialassessment.OverrAll = cboOverall.Text;
                _crewinitialassessment.OverrAllRemarks = txtOverallRemarks.Text;
                _crewinitialassessment.Personality = cboPersonnality.Text;
                _crewinitialassessment.PersonalityRemarks = txtPersonalityRemarks.Text;
                _crewinitialassessment.DateAssess = dtpDateAssess.Value;

                _irecruit.ManageInitialAssessment(_crewinitialassessment);

                ToolsControl.CallShowNotification(this, 4, "Initial Assessment successfully saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
