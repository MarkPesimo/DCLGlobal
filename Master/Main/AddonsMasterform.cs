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
using DCLGlobal.Classes;
using CAL.Global;

namespace DCLGlobal.Master.Main
{
    public partial class AddonsMasterform : Form
    {
        int _mode = 0;
        int _id = 0;

        public AddonsMasterform()
        {
            InitializeComponent();
        }

        private void Addonsform_Load(object sender, EventArgs e)
        {
            //iAddons _iaddon = new CMSFilesRepository.rAddon();
            //try
            //{
            //    DisplayList("");
            //    DisplayRecord(_iaddon.GetAddOn(_id));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.ADDONS, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtDescription.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtDescription.Text = "";
            chkStatus.Checked = true;
            txtDescription.Tag = 0;
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
            txtDescription.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            //iAddons _iaddons = new CMSFilesRepository.rAddon();
            //try
            //{
            //    lsvList.Items.Clear();
            //    List<ADDON> _addons = _iaddons.GetAddOns(_keyword, true);
            //    foreach (ADDON _x in _addons)
            //    {
            //        ListViewItem _item = new ListViewItem(_x.id.ToString());
            //        _item.SubItems.Add(_x.DESCRIPTION);
            //        _item.SubItems.Add(_x.STATUS == true ? "Active" : "Inactive");

            //        lsvList.Items.Add(_item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //void DisplayRecord(ADDON _addon)
        //{
        //    try
        //    {
        //        if (_addon != null)
        //        {
        //            _id = _addon.id; 
        //            txtDescription.Text = _addon.DESCRIPTION;
        //            chkStatus.Checked = _addon.STATUS == true ? true : false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvList.SelectedItems.Count == 0) { return; }

            //iAddons _iaddon = new CMSFilesRepository.rAddon();
            //try
            //{
            //    _id = int.Parse(lsvList.SelectedItems[0].Text);
            //    DisplayRecord(_iaddon.GetAddOn(_id));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.ADDONS, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtDescription.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDescription);
                txtDescription.Focus();
                return;
            }

            ManageAddon();
        }

        void ManageAddon()
        {
            //iAddons _iAddon = new CMSFilesRepository.rAddon();
            //ADDON _addon = new ADDON();

            //try
            //{
            //    _addon.id = _id;
            //    _addon.DESCRIPTION = txtDescription.Text;
            //    _addon.STATUS = chkStatus.Checked;

            //    DisplayRecord(_iAddon.ManageAddOns(_addon, _mode, LoginUser.userid));
                
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
            //iAddons _iAddon = new CMSFilesRepository.rAddon();
            //try
            //{
            //    EnableForm(false);
            //    EnableButton(true);
            //    DisplayRecord(_iAddon.GetAddOn(_id));
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

        private void Addonsform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {

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
