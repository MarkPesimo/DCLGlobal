using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;
using DCLGlobal.Reports;

using CAL.Model;
using CAL.Global;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewMedicalRequestControl : UserControl
    {
        private string _applicantid;
        int _id = 0;
        int _crewstatusid;
        int _mode = 0;

        public CrewMedicalRequestControl(string _Applicantid, int _Crewstatusid)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _crewstatusid = _Crewstatusid;
            
        }

        public CrewMedicalRequestControl(string _Applicantid, int _Crewstatusid,int  Id)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _crewstatusid = _Crewstatusid;
            _id = Id;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();

            if (keyData == Keys.F3)                 //add details
            {
                if (lblStatus.Visible)
                {
                    MessageBox.Show("Request cannot be edit once already posted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto jump;
                }

                AddMedicalRequestform _detail = new AddMedicalRequestform(_id);
                _detail.BringToFront();
                _detail.ShowDialog();


                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));
            }
            else if (keyData == Keys.F10)
            {
                if (lblStatus.Visible)
                {
                    MessageBox.Show("Request already posted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto jump;
                }

                _mode = 3;
                ManageCrewMedicalRequest();
                ToolsControl.CallShowNotification(this, _mode, "Request successfully posted"); 
                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));
            }
            else if (keyData == Keys.F11)
            {
                if (!lblStatus.Visible)
                {
                    MessageBox.Show("Request already Un-posted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto jump;
                }

                _mode = 4;
                ManageCrewMedicalRequest();
                ToolsControl.CallShowNotification(this, _mode, "Request successfully un-posted"); 
                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));
            }

            jump:
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void DisplayRecord(CrewMedicalRequest _crewmedicalrequest)
        {
            //iContract _icontract = new ContractRepositroy(DCLSystemConfiguration.Connection);
            iContract _icontract = new CMSTransactionRepository.rContract();
            try
            {
                if (_crewmedicalrequest != null)
                {
                    _id = _crewmedicalrequest.MedRequuestID;
                    txtRequestNo.Text = _id.ToString();
                    dtpRequest.Value = _crewmedicalrequest.DateRequest.Value;
                    dtpDepartureDate.Value = _crewmedicalrequest.DepartureDate.Value;
                    txtSeamansBook.Text = _crewmedicalrequest.SBno;

                    txtCountry.Text = _crewmedicalrequest.Country.CountryName;
                    txtCountry.Tag = int.Parse(_crewmedicalrequest.CountryID.ToString());
                    txtCategory.Text = _crewmedicalrequest.Category;
                    txtRemarks.Text = _crewmedicalrequest.Remarks;

                    CrewRecord _crewcecord = _icontract.GetCrewRecord(int.Parse(_crewmedicalrequest.CREWSTATUSID.ToString()));
                    if (_crewcecord != null)
                    {
                        txtPrincipal.Text = _crewcecord.Principal.PrincipalDescription;
                        txtPosition.Text = _crewcecord.Position.PositionName;
                        txtVessel.Text = _crewcecord.Vessel.VesselDescription;
                    }

                    txtClinic.Text = _crewmedicalrequest.Clinic.Clinic_name;
                    txtClinic.Tag = int.Parse(_crewmedicalrequest.ClinicID.ToString());

                    txtEndorse.Text = _crewmedicalrequest.EndorsedBy;
                    txtNoted.Text = _crewmedicalrequest.NotedBy;
                    lblStatus.Visible = _crewmedicalrequest.Status == 1 ? true : false;

                    DisplayRecordDetails(_crewmedicalrequest);
                    DisplayRecordMedicalReferral(_crewmedicalrequest);
                }
                
                var _control = new CrewMedicalRequestDetailsControl(_applicantid, "Pending", this);
                AddControl(_control, "On-Going/Pending Medical");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecordMedicalReferral(CrewMedicalRequest _crewmedicalrequest)
        {
            //_icrewmedicalrequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
            iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();
            CrewMedicalReferral _crewmedicalreferral = _icrewmedicalrequest.GetMedicalReferral(_crewmedicalrequest);
            try 
            {
                if (_crewmedicalreferral != null) 
                {
                    if (_crewmedicalreferral.DATE_REPORTED == null) { dtpReportToClinic.Checked = false; } else { dtpReportToClinic.Value = _crewmedicalreferral.DATE_REPORTED.Value; }
                    if (_crewmedicalreferral.DATE_RESULT == null) { dtpResultDate.Checked = false; } else { dtpResultDate.Value = _crewmedicalreferral.DATE_RESULT.Value; }
                    if (_crewmedicalreferral.DATE_PENDING == null) { dtpDatePending.Checked = false; } else { dtpDatePending.Value = _crewmedicalreferral.DATE_PENDING.Value; }
                    if (_crewmedicalreferral.DATE_UNFIT == null) { dtpDateUnfit.Checked = false; } else { dtpDateUnfit.Value = _crewmedicalreferral.DATE_UNFIT.Value; }
                    if (_crewmedicalreferral.DATE_FIT == null) { dtpDateFit.Checked = false; } else { dtpDateFit.Value = _crewmedicalreferral.DATE_FIT.Value; }
                    if (_crewmedicalreferral.DATE_RECEIVED_CERTIFICATE == null) { dtpCertificateReceived.Checked = false; } else { dtpCertificateReceived.Value = _crewmedicalreferral.DATE_RECEIVED_CERTIFICATE.Value; }

                    txtFindings.Text = _crewmedicalreferral.FINDINGS;
                    txtReferralRemarks.Text = _crewmedicalreferral.REMARKS;
                }
                else
                {
                    dtpReportToClinic.Checked = false; 
                    dtpResultDate.Checked = false; 
                    dtpDatePending.Checked = false; 
                    dtpDateUnfit.Checked = false; 
                    dtpDateFit.Checked = false; 
                    dtpCertificateReceived.Checked = false;

                    txtFindings.Text = "";
                    txtReferralRemarks.Text = "";
                }            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecordDetails(CrewMedicalRequest _crewmedicalrequest)
        {
            try                            
            {
                //_icrewmedicalrequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
                iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();
                List<CrewMedicalRequestDetail> _requestdetails = _icrewmedicalrequest.GetMedicalRequestDetails(_crewmedicalrequest);
                lsvDetails.Items.Clear();
                foreach (CrewMedicalRequestDetail _list in _requestdetails)
                {
                    ListViewItem _item = new ListViewItem(_list.CheckUp.MEDCHECK_NAME);
                    _item.SubItems.Add(_list.Id.ToString());

                    lsvDetails.Items.Add(_item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panOnBoard_Click(object sender, EventArgs e)
        {

        }

        private void tabGrid_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            ClearPanel(e.NewValue.Text);

            if (e.NewValue.Text == "On-Going/Pending Medical")
            {
                var _control = new CrewMedicalRequestDetailsControl(_applicantid, "Pending", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "Fit Medical")
            {
                var _control = new CrewMedicalRequestDetailsControl(_applicantid, "Fit", this);
                AddControl(_control, e.NewValue.Text);
            }
            else
            {
                var _control = new CrewMedicalRequestDetailsControl(_applicantid, "Unfit", this);
                AddControl(_control, e.NewValue.Text);
            }                                    
        }

        void AddControl(Control _control, string _status)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            if (_status == "On-Going/Pending Medical") { panPending.Controls.Add(_control); }
            else if (_status == "Fit Medical") { panFit.Controls.Add(_control); }
            else { PanUnfit.Controls.Add(_control); }

        }

        void ClearPanel(string _status)
        {
            if (_status == "On-Going/Pending Medical") { panPending.Controls.Clear(); }
            else if (_status == "Fit Medical") { panFit.Controls.Clear(); }
            else { PanUnfit.Controls.Clear(); }
        
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Transaction.MEDICAL_REQUEST, Feature.Add, SystemModuleType.Transaction) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                dtpRequest.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EnableForm(bool _cond)
        {
            dtpRequest.Enabled = _cond;
            dtpDepartureDate.Enabled = _cond;
            txtSeamansBook.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;
            
            txtEndorse.ReadOnly = !_cond;
            txtNoted.ReadOnly = !_cond;

            tabGrid.Enabled = !_cond;
        }   

        void EnableButton(bool _cond)
        {
            add_btn.Enabled = _cond;
            edit_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;
            print_btn.Enabled = _cond;

            save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }

        void InitializeField()
        {
            //iCrewDocument _icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            try
            {
                CrewDocument _crewdocument = _icrewdocument.GetCrewDocument(2, _applicantid, "P");

                _id = 0;
                dtpRequest.Value = DateTime.Now;
                txtSeamansBook.Text = _crewdocument == null ? "" : _crewdocument.Number;            
                dtpDepartureDate.Value = DateTime.Now;
                txtCountry.Text = "";
                txtCountry.Tag = 0;
                txtCategory.Text = "";
                txtRemarks.Text = "";
                txtPrincipal.Text = "";
                txtVessel.Text = "";
                txtPosition.Text = "";
                txtClinic.Text = "";
                txtClinic.Tag = 0;
                txtEndorse.Text = "";
                txtNoted.Text = "";
            }
            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void expandablePanel1_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (!txtSeamansBook.ReadOnly)
            {
                MessageBox.Show("Features not available on adding mode.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }

        }

        private void expanRequest_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (!txtSeamansBook.ReadOnly)
            {
                MessageBox.Show("Features not available on adding mode.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
                return;
            }

        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Transaction.MEDICAL_REQUEST, Feature.Edit, SystemModuleType.Transaction) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                dtpRequest.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            //_icrewmedicalrequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
            iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Transaction.MEDICAL_REQUEST, Feature.Delete, SystemModuleType.Transaction) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 2;

            ManageCrewMedicalRequest();
        }

        void ManageCrewMedicalRequest() 
        {
            //_icrewmedicalrequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
            iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();
            CrewMedicalRequest _crewmedicalrequest = new CrewMedicalRequest();

            try
            {
                _crewmedicalrequest.Category = txtCategory.Text;
                _crewmedicalrequest.DateRequest = dtpRequest.Value;
                _crewmedicalrequest.ApplicantID = _applicantid;
                _crewmedicalrequest.SBno = txtSeamansBook.Text;
                _crewmedicalrequest.DepartureDate = dtpDepartureDate.Value;
                _crewmedicalrequest.CountryID = int.Parse(txtCountry.Tag.ToString());
                _crewmedicalrequest.Remarks = txtRemarks.Text;
                _crewmedicalrequest.EndorsedBy = txtEndorse.Text;
                _crewmedicalrequest.NotedBy = txtNoted.Text;
                _crewmedicalrequest.ClinicID = int.Parse(txtClinic.Tag.ToString());
                _crewmedicalrequest.CREWSTATUSID = _crewstatusid;
                _crewmedicalrequest.MedRequuestID = _id;


                _id = _icrewmedicalrequest.ManageCrewMedicalRequest(_crewmedicalrequest, _mode);
                if (_mode < 3) { ToolsControl.CallShowNotification(this, _mode, ""); }

                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));
                Cancel();      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrewMedicalRequestControl_Load(object sender, EventArgs e)
        {
            //_icrewmedicalrequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
            iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();
            try
            {
                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete this selected check up, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                foreach (ListViewItem _itemselected in lsvDetails.SelectedItems)
                {
                    //iCrewMedicalRequest _icrewmedicalrequest = new CrewMedicalRequestRepository(DCLSystemConfiguration.Connection);
                    iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();

                    CrewMedicalRequestDetail _detail = new CrewMedicalRequestDetail();                    
                    _detail.Id = int.Parse( _itemselected.SubItems[1].Text);

                    _icrewmedicalrequest.ManageCrewMedicalRequestDetails(_detail, 2);
                    _itemselected.Remove();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Kindly select a record to print.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lblStatus.Text != "** Posted **")
            {
                MessageBox.Show("Medical request is not yet posted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string _selected = "";
                foreach (ListViewItem _list in lsvDetails.Items)
                {
                    if (_list.Checked)
                    {
                        _selected = _selected + _list.Text + ", ";
                    }
                }

                if (_selected == "")
                {
                    MessageBox.Show("Kindly select atleast 1 medical check up", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //iMedicalReferral _medicalreferral = new MedicalReferralRepository(DCLSystemConfiguration.Connection);

                GlobalReportViewerform _report = new GlobalReportViewerform("MEDICAL REFERRAL SLIP");
                _report._medicalid = _id;
                _report._applicantid = _applicantid;
                _report._selectedcheckup = _selected;
                _report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateReferral_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ToolsControl.ModuleAccess(this, "MEDICAL REFERRAL UPDATE", SystemModuleType.System ) == false) { return; }
            if (MessageBox.Show("Update medical referral Info? Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            CrewMedicalReferral _referral = new CrewMedicalReferral();

            try 
            {                
                if (dtpReportToClinic.Checked){_referral.DATE_REPORTED =  dtpReportToClinic.Value; }
                else {_referral.DATE_REPORTED =  null; }
                if (dtpResultDate.Checked) { _referral.DATE_RESULT = dtpResultDate.Value; }
                else { _referral.DATE_RESULT = null; }
                if (dtpDatePending.Checked) { _referral.DATE_PENDING = dtpDatePending.Value; }
                else { _referral.DATE_PENDING = null; }
                if (dtpDateUnfit.Checked) { _referral.DATE_UNFIT = dtpDateUnfit.Value; }
                else { _referral.DATE_UNFIT = null; }
                if (dtpDateFit.Checked) { _referral.DATE_FIT = dtpDateFit.Value; }
                else { _referral.DATE_FIT = null; }
                if (dtpCertificateReceived.Checked) { _referral.DATE_RECEIVED_CERTIFICATE = dtpCertificateReceived.Value; }
                else { _referral.DATE_RECEIVED_CERTIFICATE = null; }

                _referral.FINDINGS = txtFindings.Text;
                _referral.REMARKS = txtRemarks.Text;
                _referral.MEDREQUESTID = _id;
                
                 
                ToolsControl.CallShowNotification(this, _mode, "Medical referral info. successfully saved");
                iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();
                DisplayRecord(_icrewmedicalrequest.GetMedicalRequest(_id, _applicantid));

                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            txtCountry.Text = "";
            txtCountry.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtCountry.Text = _country.CountryName;
            //    txtCountry.Tag = _country.ID;
            //}
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            txtClinic.Text = "";
            txtClinic.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.CLINIC;
            _Searchform.ShowDialog();

            //Clinic _clinic = _Searchform.ReturnSearchClinic;
            //if (_clinic != null)
            //{
            //    txtClinic.Text = _clinic.Clinic_name;
            //    txtClinic.Tag = _clinic.ID;
            //}
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ManageCrewMedicalRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panPending_Click(object sender, EventArgs e)
        {

        }

    }
}
