using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCLGlobal.Reports.Crew
{
    public partial class CandidateReportform : Form
    {
        string _reporttype = "";
        string _candidatestatus = "";

        public CandidateReportform(string Reporttype, string Candidatestatus)
        {
            _reporttype = Reporttype;
            _candidatestatus = Candidatestatus;
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CandidateReportform_Load(object sender, EventArgs e)
        {
            try
            {
                txtReportType.Text = _reporttype;
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
                GlobalReportViewerform _report = new GlobalReportViewerform(_reporttype);
                _report._applicant_status = _candidatestatus;
                _report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
