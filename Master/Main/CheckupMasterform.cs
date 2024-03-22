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
    public partial class CheckupMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        int _id = 0;

        public CheckupMasterform()
        {
            InitializeComponent();
        }

        private void CheckupMasterform_Load(object sender, EventArgs e)
        {
            iCheckUp _icheckup = new CMSFilesRepository.rCheckup();    
            try
            {
                DisplayList("");
                DisplayRecord(_icheckup.GetCheckUp(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CHECKUP, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtCheckupName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtCheckupName.Text = "";
            _id = 0;
            cboType.SelectedIndex= 0;

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
            txtCheckupName.ReadOnly = !_cond;
            cboType.Enabled = _cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iCheckUp _icheckup = new CMSFilesRepository.rCheckup();    
            try
            {
                lsvList.Items.Clear();
                List<CheckUp> _checkups = _icheckup.GetCheckUps(_keyword, "ALL");
                foreach (CheckUp _x in _checkups)
                {
                    ListViewItem _item = new ListViewItem(_x.MEDCHECKID.ToString());
                    _item.SubItems.Add(_x.MEDCHECK_NAME);
                    _item.SubItems.Add(_x.CHECK_TYPE);
                    _item.SubItems.Add(_x.Status == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(CheckUp _checkup)
        {
            try
            {
                if (_checkup != null)
                {
                    _id = _checkup.MEDCHECKID;
                    txtCheckupName.Text = _checkup.MEDCHECK_NAME;
                    cboType.Text = _checkup.CHECK_TYPE;
                    
                    chkStatus.Checked = _checkup.Status == true ? true : false;
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

            iCheckUp _icheckup = new CMSFilesRepository.rCheckup();    
            try
            {
                DisplayRecord(_icheckup.GetCheckUp(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CHECKUP, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtCheckupName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtCheckupName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtCheckupName);
                txtCheckupName.Focus();
                return;
            }

            ManageCheckup();
        }

        void ManageCheckup()
        {
            iCheckUp _icheckup = new CMSFilesRepository.rCheckup();    
            CheckUp _checkup = new CheckUp();

            try
            {
                _checkup.MEDCHECKID = _id;
                _checkup.MEDCHECK_NAME = txtCheckupName.Text;
                _checkup.CHECK_TYPE = cboType.Text;

                if (chkStatus.Checked) { _checkup.Status = true; }
                else { _checkup.Status = false; }

                _id = _icheckup.ManageCheckUp(_checkup, _mode);
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
            iCheckUp _icheckup = new CMSFilesRepository.rCheckup();    
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icheckup.GetCheckUp(_id));
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

        private void CheckupMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CHECKUP, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

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
