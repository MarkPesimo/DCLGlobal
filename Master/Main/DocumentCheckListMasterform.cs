using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.Global;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Master.Main
{
    public partial class DocumentCheckListMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        int _id = 0;

        public DocumentCheckListMasterform()
        {
            InitializeComponent();
        }

        void DisplayPrincipal()
        {
            List<Principal> _principals = new List<Principal>();
            lsvPrincipal.Items.Clear();
            try
            {
                iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
                _principals = _iprincipal.GetPrincipals(txtSearch.Text, "Active");
                foreach (Principal _list in _principals)
                {
                    ListViewItem _item = new ListViewItem(_list.PrincipalID.ToString());
                    if (_list.PrincipalDescription == "Unknown Principal") { _item.SubItems.Add("Standby Pool"); }
                    else { _item.SubItems.Add(_list.PrincipalDescription); }

                    lsvPrincipal.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DocumentCheckListMasterform_Load(object sender, EventArgs e)
        {
            try 
            {
                DisplayPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { DisplayPrincipal(); }
        }

        protected void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Keyword here")
            {
                txtSearch.Text = "";
            }
        }

        protected void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Enter Keyword here";
            }
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            Searchform _Searchform = new Searchform();
            if (cboDoctype.Text == "Document")
            {                
                _Searchform._searchby = searchby.CMS.DOCUMENT;
                _Searchform.ShowDialog();

                //Document _document = _Searchform.ReturnSearchDocument;
                //if (_document != null)
                //{
                //    txtDocument.Text = _document.NameofDocument;
                //    txtDocument.Tag = _document.DocID;
                //}
            }
            else if (cboDoctype.Text == "License")
            {
                _Searchform._searchby = searchby.CMS.LICENSE_LIST;
                _Searchform.ShowDialog();

                //CAL.Model.License _license = _Searchform.ReturnSearchLicense;
                //if (_license != null)
                //{
                //    txtDocument.Text = _license.License_Name;
                //    txtDocument.Tag = _license.License_ID;
                //}
            }
            else if (cboDoctype.Text == "Training")
            {
                _Searchform._searchby = searchby.CMS.TRAINING_LIST;
                _Searchform.ShowDialog();

                //Training _training = _Searchform.ReturnSearchTraining;
                //if (_training != null)
                //{
                //    txtDocument.Text = _training.Training_Name;
                //    txtDocument.Tag = _training.Training_ID;
                //}
            }
            else 
            {
                _Searchform._searchby = searchby.CMS.CHECK;
                _Searchform.ShowDialog();

                //CheckUp _checkup = _Searchform.ReturnSearchCheckup;
                //if (_checkup != null)
                //{
                //    txtDocument.Text = _checkup.MEDCHECK_NAME;
                //    txtDocument.Tag = _checkup.MEDCHECKID;
                //}
            }
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            print_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            cboRank.Enabled = _cond;
            cboGroup.Enabled = _cond;
            cboDoctype.Enabled = _cond;
            chkRequired.Enabled = _cond;

            panPrincipal.Enabled = !_cond;
        }

        private void lsvPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPrincipal.SelectedItems.Count == 0) { return; }

            iDocumentCheckList _idocumentchecklist = new CMSFilesRepository.rDocumentCheckList();
            try 
            {
                txtPrincipal.Text = lsvPrincipal.SelectedItems[0].SubItems[1].Text;
                txtPrincipal.Tag = lsvPrincipal.SelectedItems[0].Text;

                DisplayRecords(int.Parse(txtPrincipal.Tag.ToString()));
                DisplayRecord(_idocumentchecklist.GetDocumentCheckList(int.Parse(txtPrincipal.Tag.ToString()), 0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (txtPrincipal.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select a principal first.","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                lsvPrincipal.Focus();
                return;
            }

            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT_CHECKLIST, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                cboRank.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            cboRank.SelectedIndex = 0;
            cboDoctype.SelectedIndex = 0;
            cboDoctype.SelectedIndex = 0;
            chkRequired.Checked = false;

            txtDocument.Text = "";
            txtDocument.Tag = 0;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT_CHECKLIST, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            
            if (_id== 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                cboRank.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count == 0) { return; }

            iDocumentCheckList _idocumentchecklist = new CMSFilesRepository.rDocumentCheckList();
            try 
            {
                _id = int.Parse( lvList.SelectedItems[0].Text);
                DisplayRecord(_idocumentchecklist.GetDocumentCheckList(int.Parse( txtPrincipal.Tag.ToString()), _id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecords(int _principalid)
        {
            iDocumentCheckList _idocumentchecklist = new CMSFilesRepository.rDocumentCheckList();
            
            try 
            {
                lvList.Items.Clear();
                List<DOCUMENT_CHECKLIST> _list = _idocumentchecklist.GetDocumentCheckLists(int.Parse(txtPrincipal.Tag.ToString()));
                foreach (DOCUMENT_CHECKLIST _x in _list)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.PositionRank);
                    _item.SubItems.Add(_x.DocumentGroup);
                    _item.SubItems.Add(_x.DocumentType);

                    if (_x.DocumentType == "Document")
                    {
                        iDocument _idocument = new CMSFilesRepository.rDocument();
                        Document _document = _idocument.GetDocument(int.Parse(_x.DocumentId.ToString()));
                        if (_document != null) { _item.SubItems.Add(_document.NameofDocument); }
                    }
                    else if (_x.DocumentType == "License")
                    {
                        iLicense _ilicense = new CMSFilesRepository.rLicense();
                        CAL.Model.License _license = _ilicense.GetLicense(int.Parse(_x.DocumentId.ToString()));
                        if (_license != null) { _item.SubItems.Add( _license.License_Name); }
                    }
                    else if (_x.DocumentType == "Training")
                    {
                        iTraining _itraining = new CMSFilesRepository.rTraining();
                        CAL.Model.Training _training = _itraining.GetTraining(int.Parse(_x.DocumentId.ToString()));
                        if (_training != null) { _item.SubItems.Add(_training.Training_Name); }
                    }
                    else
                    {
                        iCheckUp _icheckup = new CMSFilesRepository.rCheckup();
                        CAL.Model.CheckUp _checkup = _icheckup.GetCheckUp(int.Parse(_x.DocumentId.ToString()));
                        if (_checkup != null) { _item.SubItems.Add(_checkup.MEDCHECK_NAME); }
                    }

                    lvList.Items.Add(_item);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(DOCUMENT_CHECKLIST _documentchecklist)
        {
            try
            {
                if (_documentchecklist != null)
                {
                    txtPrincipal.Text = _documentchecklist.Principal.PrincipalDescription;
                    txtPrincipal.Tag = _documentchecklist.PrincipalId;
                    cboRank.Text = _documentchecklist.PositionRank;
                    cboGroup.Text = _documentchecklist.DocumentGroup;
                    cboDoctype.Text = _documentchecklist.DocumentType;

                    txtDocument.Tag = _documentchecklist.DocumentId;
                    if (cboDoctype.Text == "Document")
                    {
                        iDocument _idocument = new CMSFilesRepository.rDocument();
                        Document _document = _idocument.GetDocument(int.Parse(_documentchecklist.DocumentId.ToString()));
                        if (_document != null) { txtDocument.Text = _document.NameofDocument; }
                    }
                    else if (cboDoctype.Text == "License")
                    {
                        iLicense _ilicense = new CMSFilesRepository.rLicense();
                        CAL.Model.License _license = _ilicense.GetLicense(int.Parse(_documentchecklist.DocumentId.ToString()));
                        if (_license != null) { txtDocument.Text = _license.License_Name; }
                    }
                    else if (cboDoctype.Text == "Training")
                    {
                        iTraining _itraining = new CMSFilesRepository.rTraining();
                        CAL.Model.Training _training = _itraining.GetTraining(int.Parse(_documentchecklist.DocumentId.ToString()));
                        if (_training != null) { txtDocument.Text = _training.Training_Name; }
                    }
                    else
                    {
                        iCheckUp _icheckup = new CMSFilesRepository.rCheckup();
                        CAL.Model.CheckUp _checkup = _icheckup.GetCheckUp(int.Parse(_documentchecklist.DocumentId.ToString()));
                        if (_checkup != null) { txtDocument.Text = _checkup.MEDCHECK_NAME; }
                    }
                    

                    chkRequired.Checked = _documentchecklist.isRequired == true ? true : false;

                    _id = _documentchecklist.id;
                }
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
            iDocumentCheckList _idocumentchecklist = new CMSFilesRepository.rDocumentCheckList();
            try
            {
                EnableForm(false);
                EnableButton(true);
                DisplayRecord(_idocumentchecklist.GetDocumentCheckList(int.Parse(txtPrincipal.Tag.ToString()), _id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDocument.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDocument);
                txtDocument.Focus();
                return;
            }

            ManageDocuentChecklist();
        }

        void ManageDocuentChecklist()
        {
            iDocumentCheckList _idocumentchecklist = new CMSFilesRepository.rDocumentCheckList();
            DOCUMENT_CHECKLIST _documentchecklist = new DOCUMENT_CHECKLIST();

            try
            {
                _documentchecklist.PrincipalId = int.Parse(txtPrincipal.Tag.ToString());
                _documentchecklist.PositionRank = cboRank.Text;
                _documentchecklist.DocumentGroup = cboGroup.Text;
                _documentchecklist.DocumentType = cboDoctype.Text;
                _documentchecklist.isRequired = chkRequired.Checked;
                _documentchecklist.DocumentId = int.Parse( txtDocument.Tag.ToString());

                _id = _idocumentchecklist.ManageDocumentCheckList(_documentchecklist, _mode, LoginUser.userid);
                Cancel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayRecords(int.Parse( txtPrincipal.Tag.ToString()));
                _idocumentchecklist = new CMSFilesRepository.rDocumentCheckList();
                DisplayRecord(_idocumentchecklist.GetDocumentCheckList(int.Parse(txtPrincipal.Tag.ToString()),_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT_CHECKLIST, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }


            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try 
            {
                if (MessageBox.Show("Delete this document check list, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                _mode = 2;

                ManageDocuentChecklist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT_CHECKLIST, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }


    }
}
