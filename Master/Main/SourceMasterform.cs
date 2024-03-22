using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
//using CAL.HURIS.Interface.Employe;
//using CAL.HURIS.Repository.Employe;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.Global;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main
{
    public partial class SourceMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _id = 0;
        int _mode = 0;

        public SourceMasterform()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.IRECRUIT.Master.SOURCE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtSource.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtSource.Text = "";
            _id = 0;            

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
            txtSource.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iSource _isource = new CMSFilesRepository.rSource();
            try
            {
                lsvList.Items.Clear();
                List<Source> _sources = _isource.GetSources(_keyword, "ALL");
                foreach (Source _x in _sources)
                {
                    ListViewItem _item = new ListViewItem(_x.Source_ID.ToString());
                    _item.SubItems.Add(_x.Source_Name);
                    _item.SubItems.Add(_x.Active == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Source _source)
        {
            try
            {
                if (_source != null)
                {
                    _id = _source.Source_ID;
                    txtSource.Text = _source.Source_Name;

                    chkStatus.Checked = _source.Active == true ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SourceMasterform_Load(object sender, EventArgs e)
        {
            iSource _isource = new CMSFilesRepository.rSource();
            try
            {
                DisplayList("");
                DisplayRecord(_isource.GetSource(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iSource _isource = new CMSFilesRepository.rSource();
            try
            {
                DisplayRecord(_isource.GetSource(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.IRECRUIT.Master.SOURCE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtSource.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtSource.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtSource);
                txtSource.Focus();
                return;
            }

            ManageSource();
        }

        void ManageSource()
        {
            iSource _isource = new CMSFilesRepository.rSource();
            Source _source = new Source();

            try
            {
                _source.Source_ID = _id;
                _source.Source_Name = txtSource.Text;

                _source.Active = chkStatus.Checked ? true : false;

                _id = _isource.ManageSource(_source, _mode);
                Cancel();

                DisplayList("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iSource _isource = new CMSFilesRepository.rSource();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_isource.GetSource(_id));
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

        private void SourceMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.IRECRUIT.Master.SOURCE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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
