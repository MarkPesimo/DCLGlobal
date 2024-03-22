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

namespace DCLGlobal.Master.Main.Fleet
{
    public partial class FleetMasterform : Form
    {
        int _mode = 0;
        int _id = 0;

        public FleetMasterform()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PRINCIPAL, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtFleetname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtAccount.Text = "";
            txtAccount.Tag = 0;
            txtFleetname.Text = "";
            txtFleetname.Tag = 0;
            
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
            txtFleetname.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iFleet _ifleet = new CMSFilesRepository.rFleet();
            try
            {
                lsvList.Items.Clear();
                List<FLEET> _fleets = _ifleet.GetFleets(_keyword);
                foreach (FLEET _x in _fleets)
                {
                    ListViewItem _item = new ListViewItem(_x.ID.ToString());
                    _item.SubItems.Add(_x.FLEET_NAME);
                    _item.SubItems.Add(_x.VOID == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(FLEET _fleet)
        {
            try
            {
                if (_fleet != null)
                {
                    _id = _fleet.ID;
                    txtAccount.Tag = _fleet.ACCOUNT_ID;
                    txtAccount.Text = _fleet.Account.AcctDescription;
                    txtFleetname.Text = _fleet.FLEET_NAME;                                       

                    chkStatus.Checked = _fleet.VOID == true ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FleetMasterform_Load(object sender, EventArgs e)
        {
            iFleet _ifleet = new CMSFilesRepository.rFleet();
            try
            {
                DisplayList("");
                DisplayRecord(_ifleet.GetFleet(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iFleet _ifleet = new CMSFilesRepository.rFleet();
            try
            {
                _id = int.Parse(lsvList.SelectedItems[0].Text);
                DisplayRecord(_ifleet.GetFleet(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.FLEET, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtFleetname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtAccount.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtAccount);
                txtAccount.Focus();
                return;
            }
            if (txtFleetname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtFleetname);
                txtFleetname.Focus();
                return;
            }

            ManageFleet();
        }


        void ManageFleet()
        {
            iFleet _ifleet = new CMSFilesRepository.rFleet();
            FLEET   _fleet = new FLEET();

            try
            {
                _fleet.ACCOUNT_ID = int.Parse(txtAccount.Tag.ToString());
                _fleet.FLEET_NAME = txtFleetname.Text;
                _fleet.ID = _id;

                if (chkStatus.Checked) { _fleet.VOID = false; ; }
                else { _fleet.VOID = true; }

                _id = _ifleet.ManageFleet(_fleet, _mode);
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
            iFleet _ifleet = new CMSFilesRepository.rFleet();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ifleet.GetFleet(_id));
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtAccount.Text = "";
            txtAccount.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.ACCOUNTS;
            _Searchform.ShowDialog();

            //Account _account = _Searchform.ReturnSearchAccount;
            //if (_account != null)
            //{
            //    txtAccount.Text = _account.AcctDescription;
            //    txtAccount.Tag = _account.AccountID;
            //}
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void FleetMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void txtAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnAccount_Click(sender, e); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.FLEET, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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
