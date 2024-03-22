using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using CAL.Model;
using CAL.Global;
using DCLGlobal.Inquiry;
using DCLGlobal.Classes;

namespace DCLGlobal.Transaction.Request
{
    public partial class GenerateCVform : Form
    {
        string _applicantid = "";
        int _candidateid = 0;
        string _applicantname = "";

        public GenerateCVform()
        {
            InitializeComponent();
        }

        public GenerateCVform(string _Applicantid, string _Applicantname, int _Candidateid)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _applicantname = _Applicantname;
            _candidateid = _Candidateid;
        }

        private void GenerateCVform_Load(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";
                cboCVFormat.SelectedIndex = 0;
                if (_applicantid != "")
                {
                    txtApplicantname.Text = _applicantname;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();

            _candidateid = 0;
            _applicantid = "";
            _applicantname = "";
            txtApplicantname.Text = "";

            if (optProposed.Checked)
            {
                _Searchform._searchby = searchby.CMS.GENERATE_PROPOSED_CANDIDATE;
                _Searchform.ShowDialog();
            }
            else if (optReprint.Checked)
            {
                _Searchform._searchby = searchby.CMS.GENERATE_REPRINT_CANDIDATE;
                _Searchform.ShowDialog();
            }
            //else if (optRehire.Checked)
            //{
                
            //    _Searchform._searchby = searchby.CMS.GENERATE_REHIRE_CANDIDATE;
            //    _Searchform.ShowDialog();
            //}

            //Proposed _proposed = _Searchform.ReturnSearchProposed;
            //if (_proposed != null)
            //{
            //    _candidateid = _proposed.CandidatesID;
            //    _applicantid = _proposed.ApplicantID;
            //    _applicantname = _proposed.Crew.LastName + ", " + _proposed.Crew.FirstName + " " + _proposed.Crew.MiddleName;

            //    txtApplicantname.Text = _applicantname;
            //}

        }

        private void btnReplanned_Click(object sender, EventArgs e)
        {

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            //if (_applicantid == "")
            //{
            //    btxMsg.ShowBalloon(txtApplicantname);
            //    txtApplicantname.Focus();
            //    return;
            //}

            //if (MessageBox.Show("Generate CV, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            //try
            //{
            //    ReportControl.CMS _reportcontrol = new ReportControl.CMS();
            //    if (cboCVFormat.SelectedIndex == 0)
            //    {
            //        Thread _thread = new Thread(() => _reportcontrol.PrintJumboCV(_applicantid, chkmasked.Checked, false, lblMessage, pbar, this ));
            //        _thread.IsBackground = true;
            //        _thread.Start();

            //        //_reportcontrol.PrintJumboCV(_applicantid, chkmasked.Checked, false, lblMessage, pbar);
            //    }
            //    else if (cboCVFormat.SelectedIndex == 1)
            //    {
            //        _reportcontrol.PrintLandbasedCV(_applicantid, false);
            //    }
            //    else 
            //    {
            //        _reportcontrol.PrintDaeAhCV(_applicantid, false);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        #region    Delegates
        private delegate void DisplaMessageDelegate(string _value);
        public void DisplaMessage(string _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new DisplaMessageDelegate(this.DisplaMessage), new object[] { _value });
            }
            else
            {
                this.lblMessage.Text = _value.ToString();
            }
        }

        private delegate void TotalRowDelegate(int _value);
        public void TotalRow(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new TotalRowDelegate(this.TotalRow), new object[] { _value });
            }
            else
            {
                this.lblMessage.Text = "Record Count : " + _value.ToString();
            }
        }

        private delegate void SetProgressBarMaxDelegate(int _value);
        public void SetProgressBarMax(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new SetProgressBarMaxDelegate(this.SetProgressBarMax), new object[] { _value });
            }
            else
            {
                this.pbar.Maximum = _value;
            }
        }

        private delegate void UpdateProgressBarDelegate(int _value);
        public void UpdateProgressBar(int _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new UpdateProgressBarDelegate(this.UpdateProgressBar), new object[] { _value });
            }
            else
            {
                this.pbar.Value = _value;
            }
        }
        #endregion

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
