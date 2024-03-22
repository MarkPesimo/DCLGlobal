using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;
using CAL.Global;
using CAL.Model;
//using CAL.CMS.Interface.Crew;
//using CAL.CMS.Repository.Crew;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewMedicalControl : UserControl
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iCrewMedical _icrewmedical = new CrewMedicalRepository(DCLSystemConfiguration.Connection);
        //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);

        int _id = 0;
        string _docdept = "";
        int _mode = 0;
        int _crewid = 0;
        string _applicantid = "";

        public CrewMedicalControl(string _Applicantid, string _Docdept)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _docdept = _Docdept;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_MEDICAL, Feature.Add, SystemModuleType.Masterfile) == false) { return; }            
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtMedical.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_MEDICAL, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtMedical.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_MEDICAL, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 2;

            ManageCrewMedical();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "ATTACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; }

            if (Add_btn.Enabled == false)
            {
                MessageBox.Show("Feature not available in this mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ScanDocumentform _scandocumentform = new ScanDocumentform(_id, _docdept, _applicantid);
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            try
            {
                _scandocumentform.ShowDialog();

                DisplayRecord(_icrewmedical.GetCrewMedical(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetached_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "DETACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; }
            if (Add_btn.Enabled == false)
            {
                MessageBox.Show("Feature not available in this mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Detached attached documents, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            ScanDocument _scandocument = new ScanDocument();
            try
            {
                _scandocument.CrewDocID = _id;
                _scandocument.docdept = _docdept;

                int _scandocid = _iscandocument.ManageScandocuments(_scandocument, 2, _docdept, _applicantid);

                ToolsControl.CallPopMessage(this, "Information", "Document successfully Detached");
                Thread.Sleep(1000);

                iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
                DisplayRecord(_icrewmedical.GetCrewMedical(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrewMedicalControl_Load(object sender, EventArgs e)
        {
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            try
            {
                DisplayRecord(_icrewmedical.GetCrewMedical(0, _applicantid));
                var _control = new CrewMedicalDetailsControl(_applicantid, "VALID", this);
                AddControl(_control, "Valid Medical");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtMedical.Text = "";
            txtMedical.Tag = 0;
            cboDocumentType.SelectedIndex = 0;
            dtpIssued.Checked = false;
            dtpExpired.Checked = false;

            chkClienaccess.Checked = false;
            chkOriginal.Checked = false;
            chkPhotocopies.Checked = false;
            
            txtRemarks.Text = "";
            txtScanDocs.Text = "";
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            Delete_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            dtpIssued.Enabled = _cond;
            dtpExpired.Enabled = _cond;
            cboDocumentType.Enabled = _cond;
            chkClienaccess.Enabled = _cond;
            chkOriginal.Enabled = _cond;
            chkPhotocopies.Enabled = _cond;
            txtRemarks.ReadOnly = !_cond;

            tabGrid.Enabled = !_cond;
        }

        public void DisplayRecord(CrewMedical _crewmedical)
        {
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            try
            {
                if (_crewmedical != null)
                {
                    _id = _crewmedical.id;
                    txtMedical.Tag = _crewmedical.CheckUpId;
                    txtMedical.Text = _crewmedical.CheckUp.MEDCHECK_NAME;
                    

                    if (_crewmedical.DateExpired != null) { dtpExpired.Value = _crewmedical.DateExpired.Value; }
                    else { dtpExpired.Checked = false; }
                    if (_crewmedical.DateIssued != null) { dtpIssued.Value = _crewmedical.DateIssued.Value; }
                    else { dtpIssued.Checked = false; }



                    if (_crewmedical.DocType == "P") { cboDocumentType.SelectedIndex = 0; }
                    else if (_crewmedical.DocType == "O") { cboDocumentType.SelectedIndex = 1; }
                    else { cboDocumentType.SelectedIndex = 2; }

                    txtRemarks.Text = _crewmedical.Remarks;

                    if (_crewmedical.IsClientAccess == null) { chkClienaccess.Checked = false; }
                    else { chkClienaccess.Checked = _crewmedical.IsClientAccess == true ? true : false; }
                    if (_crewmedical.WithOriginal == null) { chkOriginal.Checked = false; }
                    else { chkOriginal.Checked = _crewmedical.WithOriginal == true ? true : false; }
                    if (_crewmedical.WithPhotocopy == null) { chkPhotocopies.Checked = false; }
                    else { chkPhotocopies.Checked = _crewmedical.WithPhotocopy == true ? true : false; }

                    ScanDocument _scandocument = _iscandocument.GetScanDocument(_crewmedical.id, _docdept);
                    if (_scandocument != null) { txtScanDocs.Text = _scandocument.Location + "\\" + _scandocument.FileName + _scandocument.DocType; }
                    else { txtScanDocs.Text = ""; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtMedical.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtMedical);
                txtMedical.Focus();
                return;
            }

            ManageCrewMedical();
        }

        void ManageCrewMedical()
        {
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            CrewMedical _crewmedical = new CrewMedical();

            try
            {
                _crewmedical.id = _id;
                _crewmedical.ApplicantId = _applicantid;
                _crewmedical.CheckUpId = int.Parse(txtMedical.Tag.ToString());

                if (dtpExpired.Checked) { _crewmedical.DateExpired = dtpExpired.Value; }
                else { _crewmedical.DateExpired = null; }
                if (dtpIssued.Checked) { _crewmedical.DateIssued = dtpIssued.Value; }
                else { _crewmedical.DateIssued = null; }

                if (cboDocumentType.SelectedIndex == 0) { _crewmedical.DocType = "P"; }
                else if (cboDocumentType.SelectedIndex == 1) { _crewmedical.DocType = "O"; }
                else { _crewmedical.DocType = "L"; }

                _crewmedical.IsClientAccess = chkClienaccess.Checked;
                _crewmedical.WithOriginal = chkOriginal.Checked;
                _crewmedical.WithPhotocopy = chkPhotocopies.Checked;

                _crewmedical.Remarks = txtRemarks.Text;

                _id = _icrewmedical.ManageCrewMedicalRecords(_crewmedical, _mode);
                ToolsControl.CallShowNotification(this, _mode, "");

                DisplayRecord(_icrewmedical.GetCrewMedical(_id, _applicantid));
                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewmedical.GetCrewMedical(_id, _applicantid));
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

        private void btnMedical_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtMedical.Text = "";
            txtMedical.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.CHECK;
            _Searchform.ShowDialog();

            //CheckUp _checkup  = _Searchform.ReturnSearchCheckup;
            //if (_checkup != null)
            //{
            //    txtMedical.Text = _checkup.MEDCHECK_NAME;
            //    txtMedical.Tag = _checkup.MEDCHECKID;
            //}
        }

        private void txtMedical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnMedical_Click(sender, e); }
        }

        void AddControl(Control _control, string _status)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            if (_status == "Valid Medical") { panValid.Controls.Add(_control); }
            else if (_status == "Expired Medical") { panExpired.Controls.Add(_control); }
            else if (_status == "Old Medical") { panOld.Controls.Add(_control); }
            else if (_status == "For Renewal") { panRenewal.Controls.Add(_control); }
            else { panNoExpiration.Controls.Add(_control); }
        }

        void ClearPanel(string _status)
        {
            if (_status == "Valid Medical") { panValid.Controls.Clear(); }
            else if (_status == "Expired Medical") { panExpired.Controls.Clear(); }
            else if (_status == "Old Medical") { panOld.Controls.Clear(); }
            else if (_status == "For Renewal") { panRenewal.Controls.Clear(); }
            else { panNoExpiration.Controls.Clear(); }

        }

        private void tabGrid_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            ClearPanel(e.NewValue.Text);

            if (e.NewValue.Text == "Valid Medical")
            {
                var _control = new CrewMedicalDetailsControl(_applicantid, "VALID", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "Expired Medical")
            {
                var _control = new CrewMedicalDetailsControl(_applicantid, "EXPIRED", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "Old Medical")
            {
                var _control = new CrewMedicalDetailsControl(_applicantid, "OLD", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "For Renewal")
            {
                var _control = new CrewMedicalDetailsControl(_applicantid, "FOR RENEWAL", this);
                AddControl(_control, e.NewValue.Text);
            }
            else
            {
                var _control = new CrewMedicalDetailsControl(_applicantid, "NO EXPIRATION", this);
                AddControl(_control, e.NewValue.Text);
            }
        }
    }
}
