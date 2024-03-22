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
    public partial class ApplicantStatusReportform : Form
    {
        string _reporttype = "";
        string _applicantstatus = "";

        public ApplicantStatusReportform(string Reporttype, string Applicantstatus)
        {
            _reporttype = Reporttype;
            _applicantstatus = Applicantstatus;
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplicantStatusReportform_Load(object sender, EventArgs e)
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
                GlobalReportViewerform _report = new GlobalReportViewerform(_reporttype );
                _report._applicant_status = _applicantstatus;
                _report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
