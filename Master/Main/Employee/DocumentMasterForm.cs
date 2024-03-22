using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main.Employee
{
    public partial class DocumentMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public DocumentMasterForm()
        {
            InitializeComponent();
        }

        private void DocumentMasterForm_Load(object sender, EventArgs e)
        {
            iHRDocument _ihrdocument = new HURISRepository.rHRDocument();
            try
            {
                DisplayList("");
                DisplayRecord(_ihrdocument.GetDocument(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HR_DOCUMENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
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
            _id = 0;
            txtDocumentName.Text = "";
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
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iHRDocument _ihrdocument = new HURISRepository.rHRDocument();

            try
            {
                lsvList.Items.Clear();
                List<HRDocument> _hrdocument = (from d in _ihrdocument.GetDocuments(_keyword) orderby d.Description select d).ToList();
                foreach (HRDocument _list in _hrdocument)
                {
                    ListViewItem _item = new ListViewItem(_list.DocId.ToString());
                    _item.SubItems.Add(_list.Description);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(HRDocument _hrdocument)
        {
            try
            {
                if (_hrdocument != null)
                {
                    _id = _hrdocument.DocId;
                    txtDocumentName.Text = _hrdocument.Description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iHRDocument _ihrdocument = new HURISRepository.rHRDocument();
            try
            {
                DisplayRecord(_ihrdocument.GetDocument(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HR_DOCUMENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Please select a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void ManageHRDocument()
        {
            iHRDocument _ihrdocument = new HURISRepository.rHRDocument();
            HRDocument _hrdocument = new HRDocument();

            try
            {
                _hrdocument.DocId = _id;
                _hrdocument.Description = txtDocumentName.Text;

                _id = _ihrdocument.ManageDocument(_hrdocument, _mode);
                Cancel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayList(Search_txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iHRDocument _ihrdocument = new HURISRepository.rHRDocument();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ihrdocument.GetDocument(_id));
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
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HR_DOCUMENT, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDocumentName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDocumentName);
                txtDocumentName.Focus();
                return;
            }

            ManageHRDocument();
        }
    }
}
