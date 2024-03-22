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
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Transaction.Request
{
    public partial class ProposedHistoryControl : UserControl
    {
        string _applicantid;

        public ProposedHistoryControl(string _Applicantid)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
        }

        private void ProposedHistoryControl_Load(object sender, EventArgs e)
        {
            //iPropose _ipropose = new CMSTransactionRepository.rProposed();
            //List<Proposed> _candidates = _ipropose.GetProposedHistory(_applicantid);
            //try 
            //{
            //    foreach (Proposed _candidate in _candidates)
            //    { 
            //        int n = DataGridView1.Rows.Add();
            //        DataGridView1.Rows[n].Cells[0].Value = _candidate.CandidatesID;
            //        DataGridView1.Rows[n].Cells[1].Value = _candidate.ApplicantID;
            //        DataGridView1.Rows[n].Cells[2].Value = _candidate.Request.Principal.PrincipalDescription;
            //        DataGridView1.Rows[n].Cells[3].Value = _candidate.Request.Vessel.VesselDescription;
            //        DataGridView1.Rows[n].Cells[4].Value = _candidate.Request.Position.PositionName;
            //        DataGridView1.Rows[n].Cells[5].Value = _candidate.DateProposed.ToShortDateString();
            //        DataGridView1.Rows[n].Cells[6].Value = _candidate.DateProposedToClient == null ? "" : _candidate.DateProposedToClient.Value.ToShortDateString();
            //        DataGridView1.Rows[n].Cells[7].Value = _candidate.DateAccepted == null ? "" : _candidate.DateAccepted.Value.ToShortDateString();
            //        DataGridView1.Rows[n].Cells[8].Value = _candidate.DateCancelled == null ? "" : _candidate.DateCancelled.Value.ToShortDateString();
            //        DataGridView1.Rows[n].Cells[9].Value = _candidate.DateRejected == null ? "" : _candidate.DateRejected.Value.ToShortDateString();
            //        DataGridView1.Rows[n].Cells[10].Value = _candidate.ClientStatus;

            //        if (_candidate.ClientStatus == "Accepted") { DataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.ForestGreen; }
            //        else if (_candidate.ClientStatus == "Rejected") { DataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Red; }
            //        else if (_candidate.ClientStatus == "Cancelled") { DataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Blue; }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            //}
        }

        private void btnReplanned_Click(object sender, EventArgs e)
        {

        }
    }
}
