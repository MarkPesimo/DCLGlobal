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

//using CAL.CMS.Interface.Tool;
//using CAL.CMS.Repository.Tool;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewLicenseControl : UserControl
    {
        private string _docdept;
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iCrewLicense _icrewlicense = new CrewLicenseRepository(DCLSystemConfiguration.Connection);
        //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);

        int _id = 0;
        int _mode = 0;
        int _crewid = 0;
        string _applicantid = "";

        public CrewLicenseControl(string _Applicantid, int _Crewid, string _Docdept)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _applicantid = _Applicantid;
            _docdept = _Docdept;
        }

        private void CrewLicenseControl_Load(object sender, EventArgs e)
        {
            //_icrewlicense = new CrewLicenseRepository(DCLSystemConfiguration.Connection);
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            try
            {
                //DisplayList();
                DisplayRecord(_icrewlicense.GetCrewLicense(0, _applicantid));
                var _control = new CrewLicenseDetailsControl(_applicantid, "VALID", this);
                AddControl(_control, "Valid License");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_LICENSE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtLicenceName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtLicenceName.Text = "";
            txtLicenceName.Tag = 0;
            txtCapacity.Text = "";
            dtpIssued.Checked = false;
            dtpExpired.Checked = false;
            txtRegulation.Text = "";
            txtCountry.Text = "";
            txtCountry.Tag = 0;
            txtnumber.Text = "";
            txtLimitation.Text = "";
            chkClienaccess.Checked = false;
            chkOriginal.Checked = false;
            chkPhotocopies.Checked = false;
            txtRemarks.Text = "";
            txtScanDocs.Text = "";
        }

        void EnableButton(bool _cond)
        {
            add_btn.Enabled = _cond;
            edit_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;

            save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            txtCapacity.ReadOnly = !_cond;
            dtpIssued.Enabled = _cond;
            dtpExpired.Enabled = _cond;
            txtRegulation.ReadOnly = !_cond;
            chkClienaccess.Enabled = _cond;
            chkOriginal.Enabled = _cond;
            chkPhotocopies.Enabled = _cond;
            txtLimitation.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;

            tabGrid.Enabled = !_cond;
        }

        //void DisplayList()
        //{
        //    grdValidDoc.RowCount = 0;
        //    iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
        //    try
        //    {
        //        List<UserDefineClass.CMS.LicenseList> _crewlicenses = _icrewlicense.GetCrewLicenses(_applicantid, _docdept);
        //        foreach (UserDefineClass.CMS.LicenseList _list in _crewlicenses)
        //        {
        //            int n = grdValidDoc.Rows.Add();
        //            grdValidDoc.Rows[n].Cells[0].Value = _list.Id;
        //            grdValidDoc.Rows[n].Cells[1].Value = "Open File";
        //            grdValidDoc.Rows[n].Cells[2].Value = "View";
        //            grdValidDoc.Rows[n].Cells[3].Value = _list.LicenseName;
        //            grdValidDoc.Rows[n].Cells[4].Value = _list.Number;

        //            if (_list.DateIssued != null) { grdValidDoc.Rows[n].Cells[5].Value = _list.DateIssued.Value.ToShortDateString(); }
        //            else { grdValidDoc.Rows[n].Cells[5].Value = ""; }
        //            if (_list.DateExpired != null) { grdValidDoc.Rows[n].Cells[6].Value = _list.DateExpired.Value.ToShortDateString(); }
        //            else { grdValidDoc.Rows[n].Cells[6].Value = ""; }
        //            grdValidDoc.Rows[n].Cells[7].Value = _list.Regulation;

        //            if (_list.Doctype == ".xlsx" || _list.Doctype == ".xls")
        //            { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Excel_48; }
        //            else if (_list.Doctype == ".docx" || _list.Doctype == ".doc")
        //            { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Word_32; }
        //            else if (_list.Doctype == ".JPG" || _list.Doctype == ".jpeg" || _list.Doctype == ".JPEG" || _list.Doctype == ".JPG" || _list.Doctype == ".jpg" || _list.Doctype == ".bmp" || _list.Doctype == ".gif" || _list.Doctype == ".png" || _list.Doctype == "ico")
        //            { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.JPG; }
        //            else if (_list.Doctype == ".pdf")
        //            { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Reader_48; }
        //            else if (_list.Doctype == ".ppt" || _list.Doctype == ".pptx")
        //            { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.PowerPoint_48; }
        //            else
        //            { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Cancel; }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

      
        public void DisplayRecord(CrewLicense _crewlicense)
        {
            //_iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            try
            {
                if (_crewlicense != null)
                {
                    _id = _crewlicense.ID;
                    txtLicenceName.Tag = _crewlicense.LICENSE_ID;
                    txtLicenceName.Text = _crewlicense.License.License_Name;
                    txtCapacity.Text = _crewlicense.Capacity;

                    if (_crewlicense.ExpiryDate != null) { dtpExpired.Value = _crewlicense.ExpiryDate.Value; }
                    else { dtpExpired.Checked = false; }
                    if (_crewlicense.IssuedDate != null) { dtpIssued.Value = _crewlicense.IssuedDate.Value; }
                    else { dtpIssued.Checked = false; }

                    txtRegulation.Text = _crewlicense.Regulation;
                    txtCountry.Text = _crewlicense.Country.CountryName;
                    txtCountry.Tag = int.Parse(_crewlicense.COUNTRY_ID.ToString());
                    txtnumber.Text = _crewlicense.Number;
                    txtLimitation.Text = _crewlicense.Limitation;


                    if (_crewlicense.IsClientAccess == null) { chkClienaccess.Checked = false; }
                    else { chkClienaccess.Checked = _crewlicense.IsClientAccess == true ? true : false; }
                    if (_crewlicense.withoriginal == null) { chkOriginal.Checked = false; }
                    else { chkOriginal.Checked = _crewlicense.withoriginal == true ? true : false; }
                    if (_crewlicense.WithPhotocopy == null) { chkPhotocopies.Checked = false; }
                    else { chkPhotocopies.Checked = _crewlicense.WithPhotocopy == true ? true : false; }

                    txtRemarks.Text = _crewlicense.Remarks;

                    ScanDocument _scandocument = _iscandocument.GetScanDocument(_crewlicense.ID, _docdept);
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
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_LICENSE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtLicenceName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtLicenceName.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtLicenceName);
                txtLicenceName.Focus();
                return;
            }
            if (txtCountry.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtCountry);
                txtCountry.Focus();
                return;
            }

            ManageCrewLicense();
        }

        void ManageCrewLicense()
        {
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            CrewLicense _crewlicense = new CrewLicense();

            try
            {
                _crewlicense.ID = _id;
                _crewlicense.ApplicantID = _applicantid;
                _crewlicense.LICENSE_ID = int.Parse(txtLicenceName.Tag.ToString());
                _crewlicense.Number = txtnumber.Text;

                if (dtpExpired.Checked) { _crewlicense.ExpiryDate = dtpExpired.Value; }
                else { _crewlicense.ExpiryDate  = null; }
                if (dtpIssued.Checked) { _crewlicense.IssuedDate = dtpIssued.Value; }
                else { _crewlicense.IssuedDate = null; }

                _crewlicense.IsClientAccess = chkClienaccess.Checked;
                _crewlicense.withoriginal = chkOriginal.Checked;
                _crewlicense.WithPhotocopy = chkPhotocopies.Checked;
                
                _crewlicense.Regulation = txtRegulation.Text;
                _crewlicense.COUNTRY_ID = int.Parse(txtCountry.Tag.ToString());
                _crewlicense.CountryName = txtCountry.Text;
                _crewlicense.Limitation = txtLimitation.Text;
                _crewlicense.Remarks = txtRemarks.Text;

                _id = _icrewlicense.ManageCrewLicense(_crewlicense, _mode);
                ToolsControl.CallShowNotification(this, _mode, "");

                DisplayRecord(_icrewlicense.GetCrewLicense(_id, _applicantid));
                Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewlicense.GetCrewLicense(_id, _applicantid));
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

        //private void grdValidDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
        //    //iTool _itool = new ToolRepository(DCLSystemConfiguration.Connection);    
        //    try
        //    {
        //        _id = int.Parse(grdValidDoc.Rows[e.RowIndex].Cells[0].Value.ToString());                
        //        if (e.ColumnIndex == 1)
        //        {
        //            //string _path = _itool.OpenScanDocument(_id, _docdept);
        //            string _path = GlobalToolsControl.OpenScanDocument(_id, _docdept);

        //            if (_path != "File not found") 
        //            {
        //                Impersonator iU = new Impersonator();
        //                iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);
                        
        //                Process.Start(_path);

        //                iU.Undo();
        //            }
        //            else { MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //        }
        //        else if (e.ColumnIndex == 2)
        //        {
        //            DisplayRecord(_icrewlicense.GetCrewLicense(_id, _applicantid));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_LICENSE, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 3;

            ManageCrewLicense();
        }

        private void btnDetached_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "DETACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; }
            if (add_btn.Enabled == false)
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

                //DisplayList();
                iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
                DisplayRecord(_icrewlicense.GetCrewLicense(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "ATTACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; }
            if (add_btn.Enabled == false)
            {
                MessageBox.Show("Feature not available in this mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ScanDocumentform _scandocumentform = new ScanDocumentform(_id, _docdept, _applicantid);
            //_icrewlicense = new CrewLicenseRepository(DCLSystemConfiguration.Connection);
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            try
            {
                _scandocumentform.ShowDialog();

                //DisplayList();
                DisplayRecord(_icrewlicense.GetCrewLicense(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLicense_Click(object sender, EventArgs e)
        {
            if (add_btn.Enabled) { return; }

            txtLicenceName.Text = "";
            txtLicenceName.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.LICENSE_LIST;
            _Searchform.ShowDialog();

            //CAL.Model.License _license = _Searchform.ReturnSearchLicense;
            //if (_license != null)
            //{
            //    txtLicenceName.Text = _license.License_Name;
            //    txtLicenceName.Tag = _license.License_ID;
            //}
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

        private void txtLicenceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnLicense_Click(sender, e); }
        }

        private void txtCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnCountry_Click(sender, e); }
        }

        private void tabGrid_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {
            ClearPanel(e.NewValue.Text);

            if (e.NewValue.Text == "Valid License")
            {
                var _control = new CrewLicenseDetailsControl(_applicantid, "VALID", this);
                AddControl(_control, e.NewValue.Text);
            }
            else if (e.NewValue.Text == "Expired License")
            {
                var _control = new CrewLicenseDetailsControl(_applicantid, "EXPIRED", this);
                AddControl(_control, e.NewValue.Text);
            }
        }

        void ClearPanel(string _status)
        {
            if (_status == "Valid License") { panValid.Controls.Clear(); }
            else if (_status == "Expired License") { panExpired.Controls.Clear(); }            
        }

        void AddControl(Control _control, string _status)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            if (_status == "Valid License") { panValid.Controls.Add(_control); }
            else if (_status == "Expired License") { panExpired.Controls.Add(_control); }
            
        }
    }
}
