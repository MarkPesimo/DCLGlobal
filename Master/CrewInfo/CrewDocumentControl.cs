using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
//using CAL.CMS.Interface.Crew;
//using CAL.CMS.Repository.Crew;
//using CAL.CMS.Interface.Tool;
//using CAL.CMS.Repository.Tool;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewDocumentControl : UserControl
    {
        private string _docdept;
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iCrewDocument _icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
        //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);

        int _id = 0;
        int _mode = 0;
        int _crewid = 0;
        string _applicantid = "";
        
        public CrewDocumentControl(string _Applicantid, int _Crewid, string _Docdept)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _applicantid = _Applicantid;
            _docdept = _Docdept;
        }
        
        private void CrewDocumentControl_Load(object sender, EventArgs e)
        {
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            //_icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
            try 
            {
                DisplayRecord(_icrewdocument.GetCrewDocument(0, _applicantid));
                var _control = new CrewDocumentDetailsControl(_applicantid, "VALID", this);
                AddControl(_control, "Valid Document");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_DOCUMENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();                
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtDocumentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtDocumentName.Text = "";
            txtDocumentName.Tag = 0;
            txtNumber.Text = "";
            dtpIssued.Checked = false;
            dtpExpired.Checked = false;
            cboDocumentType.SelectedIndex = 0;
            chkClienaccess.Checked = false;
            chkOriginal.Checked = false;
            chkPhotocopies.Checked = false;
            cboVisaType.SelectedIndex = 0;
            txtPosition.Text = "";
            txtIssuedBy.Text = "";
            txtPlacedIssued.Text = "";
            txtPlacedIssued.Tag = 0;
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
            txtNumber.ReadOnly = !_cond;
            dtpIssued.Enabled = _cond;
            dtpExpired.Enabled = _cond;
            cboDocumentType.Enabled = _cond;
            chkClienaccess.Enabled = _cond;
            chkOriginal.Enabled = _cond;
            chkPhotocopies.Enabled = _cond;
            txtIssuedBy.ReadOnly = !_cond;
            cboVisaType.Enabled = _cond;
            txtRemarks.ReadOnly = !_cond;

            tabGrid.Enabled = !_cond;
        }       

        public void DisplayRecord(CrewDocument _crewdocument)
        {
            //_iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            try
            {
                if (_crewdocument != null)
                {
                    _id = _crewdocument.CrewDocID;
                    txtDocumentName.Tag = _crewdocument.DocID;
                    txtDocumentName.Text = _crewdocument.Document.NameofDocument;
                    txtNumber.Text = _crewdocument.Number;

                    if (_crewdocument.DateExpired != null) { dtpExpired.Value = _crewdocument.DateExpired.Value; }
                    else { dtpExpired.Checked = false; }
                    if (_crewdocument.DateIssued != null) { dtpIssued.Value = _crewdocument.DateIssued.Value; }
                    else { dtpIssued.Checked = false;  }                    

                    if (_crewdocument.VisaType != "TRANSIT" || _crewdocument.VisaType != "BUSINESS" || _crewdocument.VisaType != "WORKING" || _crewdocument.VisaType != "OTHERS") { cboVisaType.Text = "N/A"; }
                    else{ cboVisaType.Text = _crewdocument.VisaType; }

                    if (_crewdocument.Doctype == "P") { cboDocumentType.SelectedIndex = 0; }
                    else if (_crewdocument.Doctype == "O") { cboDocumentType.SelectedIndex = 1; }
                    else {  cboDocumentType.SelectedIndex = 2; } 
                    
                    txtPosition.Text = _crewdocument.Rank;
                    txtIssuedBy.Text = _crewdocument.IssuedBy;
                    txtPlacedIssued.Text = _crewdocument.Country.CountryName;
                    txtRemarks.Text = _crewdocument.Remarks;

                    if (_crewdocument.IsClientAccess ==null) { chkClienaccess.Checked = false; }
                    else { chkClienaccess.Checked = _crewdocument.IsClientAccess == true ? true : false; }
                    if (_crewdocument.WithOriginal == null) { chkOriginal.Checked = false; }
                    else { chkOriginal.Checked = _crewdocument.WithOriginal == true ? true : false; }
                    if (_crewdocument.WithPhotocopy == null) { chkPhotocopies.Checked = false; }
                    else { chkPhotocopies.Checked = _crewdocument.WithPhotocopy == true ? true : false; }

                    ScanDocument _scandocument = _iscandocument.GetScanDocument(_crewdocument.CrewDocID, _docdept);
                    if (_scandocument != null) { txtScanDocs.Text = _scandocument.Location + "\\" + _scandocument.FileName + _scandocument.DocType; }
                    else { txtScanDocs.Text = ""; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_DOCUMENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 2;
                EnableForm(true);
                EnableButton(false);

                txtDocumentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDocumentName.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtDocumentName);
                txtDocumentName.Focus();
                return;
            }
            if (txtNumber.TextLength == 0)
            {
                btxMsg.ShowBalloon(txtNumber);
                txtNumber.Focus();
                return;
            }
            if (txtPlacedIssued.TextLength == 0)
            {
                btxMsg.ShowBalloon(txtPlacedIssued);
                txtPlacedIssued.Focus();
                return;
            }

            ManageCrewDocument();
        }

        void ManageCrewDocument()
        {
            //_icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            CrewDocument _crewdocument = new CrewDocument();

            try
            {
                _crewdocument.CrewDocID = _id;
                _crewdocument.ApplicantID = _applicantid;
                _crewdocument.DocID = int.Parse(txtDocumentName.Tag.ToString());
                _crewdocument.Number = txtNumber.Text;

                if (dtpExpired.Checked) { _crewdocument.DateExpired = dtpExpired.Value; }
                else { _crewdocument.DateExpired = null; }
                if (dtpIssued.Checked) { _crewdocument.DateIssued = dtpIssued.Value; }
                else { _crewdocument.DateIssued = null; }

                if (cboDocumentType.SelectedIndex == 0) { _crewdocument.Doctype = "P"; }
                else if (cboDocumentType.SelectedIndex == 1) { _crewdocument.Doctype = "O"; }
                else { _crewdocument.Doctype = "L"; }
                
                _crewdocument.IsClientAccess = chkClienaccess.Checked;
                _crewdocument.WithOriginal = chkOriginal.Checked;
                _crewdocument.WithPhotocopy = chkPhotocopies.Checked;
                _crewdocument.VisaType = cboVisaType.Text;
                _crewdocument.Rank = txtPosition.Text;
                _crewdocument.COUNTRY_ID = int.Parse(txtPlacedIssued.Tag.ToString());
                _crewdocument.Remarks = txtRemarks.Text;
                _crewdocument.IssuedBy = txtIssuedBy.Text;

                _id = _icrewdocument.ManageCrewDocument(_crewdocument, _mode);
                ToolsControl.CallShowNotification(this, _mode, "");

                DisplayRecord(_icrewdocument.GetCrewDocument(_id, _applicantid));
                Cancel();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            //_icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewdocument.GetCrewDocument(_id, _applicantid));
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
     
        void DisplayClickDocument(int _columnindex)
        {
            //iTool _itool = new ToolRepository(DCLSystemConfiguration.Connection);
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            try 
            {
                DisplayRecord(_icrewdocument.GetCrewDocument(_id, _applicantid));
                if (_columnindex == 1)
                {
                    string _path = GlobalToolsControl.OpenScanDocument(_id, _docdept);

                    if (_path != "File not found") { Process.Start(_path); }
                    else { MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_DOCUMENT, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 3;

            ManageCrewDocument();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "DETACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; }
            if (Add_btn.Enabled == false)
            {
                MessageBox.Show("Feature not available in this mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Detached attached documents, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            ScanDocument _scandocument = new ScanDocument();
            try 
            {
                _scandocument.CrewDocID = _id;
                _scandocument.docdept = _docdept;

                int _scandocid = _iscandocument.ManageScandocuments(_scandocument, 2, _docdept, _applicantid);

                ToolsControl.CallPopMessage(this, "Information", "Document successfully Detached");
                Thread.Sleep(1000);


                //_icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
                iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
                DisplayRecord(_icrewdocument.GetCrewDocument(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            //_icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            try 
            {
                _scandocumentform.ShowDialog();

                DisplayRecord(_icrewdocument.GetCrewDocument(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtDocumentName.Text = "";
            txtDocumentName.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.DOCUMENT;
            _Searchform.ShowDialog();

            //Document _document = _Searchform.ReturnSearchDocument;
            //if (_document != null)
            //{
            //    txtDocumentName.Text = _document.NameofDocument;
            //    txtDocumentName.Tag = _document.DocID;
            //}
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtPlacedIssued.Text = "";
            txtPlacedIssued.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtPlacedIssued.Text = _country.CountryName;
            //    txtPlacedIssued.Tag = _country.ID;
            //}
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtPosition.Text = "";
            txtPosition.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.POSITION;
            _Searchform.ShowDialog();

            //Position _position = _Searchform.ReturnSearchPosition;
            //if (_position != null)
            //{
            //    txtPosition.Text = _position.PositionName;
            //    txtPosition.Tag = _position.PositionID;
            //}
        }

        private void txtDocumentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnDocument_Click(sender, e); }
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnPosition_Click(sender, e); }
        }

        private void txtPlacedIssued_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnPlace_Click(sender, e); }
        }

        private void tabGrid_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            ClearPanel(e.NewValue.Text);

            if (e.NewValue.Text == "Valid Document")
            {
                var _control = new CrewDocumentDetailsControl(_applicantid, "VALID", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "Expired Document")
            {
                var _control = new CrewDocumentDetailsControl(_applicantid, "EXPIRED", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "Old Document")
            {
                var _control = new CrewDocumentDetailsControl(_applicantid, "OLD", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "For Renewal")
            {
                var _control = new CrewDocumentDetailsControl(_applicantid, "FOR RENEWAL", this);
                AddControl(_control, e.NewValue.Text);
            }
            else 
            {
                var _control = new CrewDocumentDetailsControl(_applicantid, "NO EXPIRATION", this);
                AddControl(_control, e.NewValue.Text);
            }
        }

        void AddControl(Control _control, string _status)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            if (_status == "Valid Document") { panValid.Controls.Add(_control); }
            else if (_status == "Expired Document") { panExpired.Controls.Add(_control); }
            else if (_status == "Old Document") { panOld.Controls.Add(_control); }
            else if (_status == "For Renewal") { panRenewal.Controls.Add(_control); }
            else { panNoExpiration.Controls.Add(_control); }
        }

        void ClearPanel(string _status)
        {
            if (_status == "Valid Document") { panValid.Controls.Clear(); }
            else if (_status == "Expired Document") { panExpired.Controls.Clear(); }
            else if (_status == "Old Document") { panOld.Controls.Clear(); }
            else if (_status == "For Renewal") { panRenewal.Controls.Clear(); }
            else { panNoExpiration.Controls.Clear(); }
                
        }
    }
}
