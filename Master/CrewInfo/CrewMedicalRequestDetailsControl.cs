using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Classes;

using CAL.Model;
using CAL.Global;

using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
//using CAL.CMS.Interface.Crew;
//using CAL.CMS.Repository.Crew;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewMedicalRequestDetailsControl : UserControl
    {
        private string _status;
        private string _applicantid;
        int _id;
        CrewMedicalRequestControl _parent;
        //iTransaction _itransaction = new TransactionRepository(DCLSystemConfiguration.Connection);

        public CrewMedicalRequestDetailsControl(string _Applicantid, string _Status, CrewMedicalRequestControl _Parent)
        {
            InitializeComponent();
            _status = _Status;
            _applicantid = _Applicantid;
            _parent = _Parent;
        }

        private void CrewMedicalRequestDetailsControl_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayList()
        {
            iCrewMedicalRequest _iCrewMedicalRequest = new CMSTransactionRepository.rCrewMedicalRequest();
            iContract _icontract = new CMSTransactionRepository.rContract();

            dgvList.RowCount = 0;
            List<CrewMedicalRequest> _requests = _iCrewMedicalRequest.GetMedicalRequests(_applicantid, _status);
            try
            {
                foreach (CrewMedicalRequest _request in _requests)
                {
                    int n = dgvList.Rows.Add();
                    dgvList.Rows[n].Cells[0].Value = _request.MedRequuestID;
                    dgvList.Rows[n].Cells[1].Value = "View";
                    dgvList.Rows[n].Cells[2].Value = _request.MedRequuestID;
                    dgvList.Rows[n].Cells[3].Value = _request.Category;
                    dgvList.Rows[n].Cells[4].Value = _request.DateRequest.Value.ToShortDateString();

                    CrewRecord _crewcecord = _icontract.GetCrewRecord(int.Parse(_request.CREWSTATUSID.ToString()));
                    if (_crewcecord != null)
                    {
                        dgvList.Rows[n].Cells[5].Value = _crewcecord.Principal.PrincipalDescription;
                        dgvList.Rows[n].Cells[6].Value = _crewcecord.Vessel.VesselDescription;
                        dgvList.Rows[n].Cells[7].Value = _crewcecord.Position.PositionName;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //iCrewMedicalRequest _iCrewMedicalRequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
            iCrewMedicalRequest _iCrewMedicalRequest = new CMSTransactionRepository.rCrewMedicalRequest();
            try 
            {
                _id = int.Parse(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());

                if (e.ColumnIndex == 1) { _parent.DisplayRecord(_iCrewMedicalRequest.GetMedicalRequest(_id, _applicantid)); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
