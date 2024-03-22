using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.Global;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main
{
    public partial class DocumentMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        int _id = 0;

        public DocumentMasterform()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
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
            txtDocumentName.Text = "";
            _id = 0;
            
            cboType.SelectedIndex = 0;            
            chkStatus.Checked = true;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            print_btn.Enabled = _cond;
            Search_txt.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            txtDocumentName.ReadOnly = !_cond;            
            cboType.Enabled = _cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            //iDocument _idocoument = new CMSFilesRepository.rDocument();      
            //try
            //{
            //    lsvList.Items.Clear();
            //    List<Document> _documents = _idocoument.GetDocuments(_keyword, "ALL");
            //    foreach (Document _x in _documents)
            //    {
            //        ListViewItem _item = new ListViewItem(_x.DocID.ToString());
            //        _item.SubItems.Add(_x.NameofDocument);
            //        _item.SubItems.Add(_x.Doctype);
            //        _item.SubItems.Add(_x.Status == true ? "Active" : "In-Active");

            //        lsvList.Items.Add(_item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void DisplayRecord()//Document _document)
        {
            //try
            //{
            //    if (_document != null)
            //    {
            //        _id = _document.DocID;
            //        txtDocumentName.Text = _document.NameofDocument;
            //        txtDocumentName.Tag = int.Parse(_document.DocID.ToString());

            //        if (_document.Type == null) 
            //        {
            //            cboType.SelectedIndex = 0;
            //        }
            //        else
            //        {
            //            cboType.Text = _document.Type;
            //        }

            //        chkStatus.Checked = _document.Status == true ? true : false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void DocumentMasterform_Load(object sender, EventArgs e)
        {
            //iDocument _idocoument = new CMSFilesRepository.rDocument();      
            //try
            //{
            //    DisplayList("");
            //    DisplayRecord(_idocoument.GetDocument(_id));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvList.SelectedItems.Count == 0) { return; }

            //iDocument _idocoument = new CMSFilesRepository.rDocument();      
            //try
            //{
            //    DisplayRecord(_idocoument.GetDocument(int.Parse(lsvList.SelectedItems[0].Text)));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtDocumentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDocumentName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDocumentName);
                txtDocumentName.Focus();
                return;
            }

            ManageDocument();
        }

        void ManageDocument()
        {
            //iDocument _idocoument = new CMSFilesRepository.rDocument();      
            //Document _document = new Document();

            //try
            //{
            //    _document.DocID = _id;
            //    _document.NameofDocument = txtDocumentName.Text;
            //    _document.Type = cboType.Text;

            //    _document.Status = chkStatus.Checked;
            //    //if (chkStatus.Checked) { _document.Status = true; }
            //    //else { _document.Status = false; }

            //    _id = _idocoument.ManageDocument(_document, _mode);
            //    Cancel();

            //    if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
            //    else { ToolsControl.CallShowNotification(this, 3, ""); }

            //    DisplayList(Search_txt.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Cancel()
        {
            //iDocument _idocoument = new CMSFilesRepository.rDocument();      
            //try
            //{
            //    EnableForm(false);
            //    EnableButton(true);

            //    DisplayRecord(_idocoument.GetDocument(_id));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void DocumentMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DOCUMENT, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

        }

        protected void Search_txt_GotFocus(object sender, EventArgs e)
        {
            Color _color_focus = Color.FromArgb(255, 255, 136);
            Search_txt.BackColor = _color_focus;
        }

        protected void Search_txt_LostFocus(object sender, EventArgs e)
        {
            Search_txt.BackColor = Color.White;
        }


    }
}
