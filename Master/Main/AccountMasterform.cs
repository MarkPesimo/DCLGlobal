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
    public partial class AccountMasterform : Form
    { 
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        int _mode = 0;
        int _id = 0;

        public AccountMasterform()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.ACCOUNT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtAccountname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtAccountname.Text = "";
            cboCompany.SelectedIndex = 0;
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
            txtAccountname.ReadOnly = !_cond;
            cboCompany.Enabled = _cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            //iAccount _iAccount = new CMSFilesRepository.rAccount();                       
            //try
            //{
            //    lsvList.Items.Clear();
            //    List<Account> _accounts = _iAccount.GetAccounts(_keyword, "All");
            //    foreach (Account _x in _accounts)
            //    {
            //        ListViewItem _item = new ListViewItem(_x.AccountID.ToString());
            //        _item.SubItems.Add(_x.AcctDescription);
            //        _item.SubItems.Add(_x.Company);
            //        _item.SubItems.Add(_x.Active==true? "Active":"Inactive");

            //        lsvList.Items.Add(_item);
            //    }                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //void DisplayRecord(Account _account)
        //{
        //    try 
        //    {
        //        if (_account != null)
        //        {
        //            _id = _account.AccountID;
        //            txtAccountname.Text = _account.AcctDescription;
        //            cboCompany.Text = _account.Company;
        //            chkStatus.Checked = _account.Active == true? true: false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void AccountMasterform_Load(object sender, EventArgs e)
        {
            //iAccount _iAccount = new CMSFilesRepository.rAccount();
            //try 
            //{
            //    DisplayList("");
            //    DisplayRecord(_iAccount.GetAccount(_id));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvList.SelectedItems.Count == 0) { return; }

            //iAccount _iAccount = new CMSFilesRepository.rAccount();
            //try
            //{
            //    DisplayRecord(_iAccount.GetAccount(int.Parse( lsvList.SelectedItems[0].Text)));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.ACCOUNT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtAccountname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtAccountname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtAccountname);
                txtAccountname.Focus();
                return;
            }

            ManageAccount();
        }

        void ManageAccount()
        {
            //iAccount _iAccount = new CMSFilesRepository.rAccount();
            //Account _account = new Account();

            //try
            //{
            //    _account.AccountID = _id;
            //    _account.AcctDescription = txtAccountname.Text;
            //    _account.Company = cboCompany.Text;
            //    _account.Active = chkStatus.Checked;

            //    _id = _iAccount.ManageAccount(_account, _mode);
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
            //iAccount _iAccount = new CMSFilesRepository.rAccount();
            //try
            //{
            //    EnableForm(false);
            //    EnableButton(true);
            //    DisplayRecord(_iAccount.GetAccount(_id));
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

        private void AccountMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.ADDONS, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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
