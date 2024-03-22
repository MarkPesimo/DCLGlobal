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

namespace DCLGlobal.Master.Admin
{
    public partial class UserMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        //iEmployee _iemployee = new FilesRepository(DCLSystemConfiguration.Connection);
        //iEmployee _iemployee = new EmployeeRepository(DCLSystemConfiguration.Connection);
        ConnectionControl _connectioncontrol = new ConnectionControl();
        
        int _mode = 0;

        public UserMasterform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.GLOBAL.Master.USER, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtusername.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtusername.Text = "";
            txtusername.Tag = 0;
            txtpassword.Text   = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtmiddlename.Text = "";
            txtaccount.Text = "";
            txtaccount.Tag = 0;
            txtEmployee.Text = "";
            txtEmployee.Tag = 0;
            txtemailaddress.Text = "";

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
            txtusername.ReadOnly = !_cond;
            txtpassword.ReadOnly = !_cond;
            txtfirstname.ReadOnly = !_cond;
            txtlastname.ReadOnly = !_cond;
            txtmiddlename.ReadOnly = !_cond;
            txtemailaddress.ReadOnly = !_cond;
            
            chkStatus.Enabled = _cond;
            chkmanager.Enabled = _cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iUser _iuser = new GlobalFilesRepository.rUser();
            try
            {
                lsvList.Items.Clear();
                List<Sys_User> _users = _iuser.GetUsers(_keyword, "ALL");
                foreach (Sys_User _x in _users)
                {
                    ListViewItem _item = new ListViewItem(_x.UserID.ToString());
                    _item.SubItems.Add(_x.UserName);
                    if (_x.EmpID.ToString() != "")
                    {
                        //_connectioncontrol.GetSystemConfiguration(appmodule.HURIS);
                        
                        //_iemployee = new EmployeeRepository(DCLSystemConfiguration.Connection);
                        iEmployee _iemployee = new HURISRepository.rEmployee();
                        UserDefineClass.HRIS.EmployeeSearchList _employee = _iemployee.SearchEmployee(_x.EmpID.Value);
                        if (_employee != null) { _item.SubItems.Add(_employee.LastName + ", " + _employee.FirstName + " " + _employee.MiddleName); }
                        else { _item.SubItems.Add(""); }

                        //_connectioncontrol.GetSystemConfiguration(appmodule.CMS);
                    }
                    else
                    {
                        _item.SubItems.Add("");
                    }

                    if (_x.Account.ToString() != "0")
                    {
                        //iAccount _iaccount = new CMSFilesRepository.rAccount();
                        //Account _Account = _iaccount.GetAccount(_x.Account.Value);
                        //if (_Account != null)
                        //{ _item.SubItems.Add(_Account.AcctDescription); }
                        //else { _item.SubItems.Add(""); }
                    }
                    else
                    {
                        _item.SubItems.Add("");
                    }
                    _item.SubItems.Add(_x.Active == true ? "Active" : "Inactive");


                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Sys_User _user)
        {
            //try
            //{
            //    if (_user != null)
            //    {
            //        txtusername.Tag = _user.UserID;
            //        txtusername.Text = _user.UserName;
            //        txtpassword.Text = _user.Password;
            //        txtfirstname.Text= _user.FirstName;
            //        txtlastname.Text = _user.LastName;
            //        txtmiddlename.Text = _user.MiddleName;
            //        txtemailaddress.Text = _user.Email;
            //        if (_user.Account.ToString() != "0" && _user.Account.ToString() != "")
            //        {
            //            iAccount _iaccount = new CMSFilesRepository.rAccount();
            //            Account _Account = _iaccount.GetAccount(_user.Account.Value);
            //            if (_Account != null)
            //            { 
            //                txtaccount.Text = _Account.AcctDescription;
            //                txtaccount.Tag = _user.Account;
            //            }
            //            else 
            //            {
            //                txtaccount.Text = "";
            //                txtaccount.Tag = 0;
            //            }
            //        }
            //        else
            //        {
            //            txtaccount.Text = "";
            //            txtaccount.Tag = 0;
            //        }
            //        if (_user.EmpID.ToString() != "0" && _user.EmpID.ToString() != "")
            //        {
            //            //_connectioncontrol.GetSystemConfiguration(appmodule.HURIS);
            //            // _iemployee = new EmployeeRepository(DCLSystemConfiguration.Connection);

            //            iEmployee _iemployee = new HURISRepository.rEmployee();
            //            UserDefineClass.HRIS.EmployeeSearchList _employee = _iemployee.SearchEmployee(_user.EmpID.Value);
            //            if (_employee != null)
            //            {
            //                txtEmployee.Text = _employee.LastName + ", " + _employee.FirstName + " " + _employee.MiddleName;
            //                txtEmployee.Tag = _user.EmpID;
            //            }
            //            else
            //            {
            //                txtEmployee.Text = "";
            //                txtEmployee.Tag = 0;
            //            }
            //            //_connectioncontrol.GetSystemConfiguration(appmodule.CMS);
            //        }
            //        else
            //        {
            //            txtEmployee.Text = "";
            //            txtEmployee.Tag = 0;
            //        }

            //        chkStatus.Checked = _user.Active == true ? true : false;
            //        chkmanager.Checked = _user.IsManager == true ? true : false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void UserMasterform_Load(object sender, EventArgs e)
        {
            iUser _iuser = new GlobalFilesRepository.rUser();
            try
            {
                DisplayList("");
                DisplayRecord(_iuser.GetUser(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iUser _iuser = new GlobalFilesRepository.rUser();
            try
            {
                DisplayRecord(_iuser.GetUser(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.GLOBAL.Master.USER, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (txtusername.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtusername.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtusername);
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtpassword);
                txtpassword.Focus();
                return;
            }
            if (txtfirstname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtfirstname);
                txtfirstname.Focus();
                return;
            }
            if (txtlastname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtlastname);
                txtlastname.Focus();
                return;
            }
            if (txtmiddlename.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtmiddlename);
                txtmiddlename.Focus();
                return;
            }
            if (txtaccount.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtaccount);
                txtaccount.Focus();
                return;
            }
            if (txtemailaddress.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtemailaddress);
                txtemailaddress.Focus();
                return;
            }

            ManageUser();
        }

        void ManageUser()
        {
            iUser _iuser = new GlobalFilesRepository.rUser();
            Sys_User _user = new Sys_User();

            try
            {
                _user.UserID = int.Parse(txtusername.Tag.ToString());
                _user.UserName = txtusername.Text;
                _user.Password = SecurityControl.PasswordHasher( txtpassword.Text);
                _user.FirstName = txtfirstname.Text;
                _user.LastName = txtlastname.Text;
                _user.MiddleName = txtmiddlename.Text;
                _user.Account = int.Parse(txtaccount.Tag.ToString());
                _user.Address = "-";
                _user.EmpID = int.Parse(txtEmployee.Tag.ToString());
                _user.Email = txtemailaddress.Text;
                _user.SqlUser  = "-";
                _user.SystemAccess = "Both";
                _user.CompanyCode = LoginUser.companycode;
                _user.App_Module = LoginAppModule.AppModule;
                _user.app_id = LoginAppModule.AppModuleId;
                _user.UserType = "User";
                _user.Active = chkStatus.Checked ? true : false;
                _user.IsManager = chkmanager.Checked ? true : false;

                txtusername.Tag = _iuser.ManageUser(_user, _mode);
                Cancel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                _iuser = new GlobalFilesRepository.rUser();
                DisplayRecord(_iuser.GetUser(int.Parse(txtusername.Tag.ToString())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iUser _iuser = new GlobalFilesRepository.rUser();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_iuser.GetUser(int.Parse(txtusername.Tag.ToString())));
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

        private void btnaccount_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtaccount.Text = "";
            txtaccount.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.ACCOUNTS;
            _Searchform.ShowDialog();

            //Account _account = _Searchform.ReturnSearchAccount;
            //if (_account != null)
            //{
            //    txtaccount.Text = _account.AcctDescription;
            //    txtaccount.Tag = _account.AccountID;
            //}
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtEmployee.Text = "";
            txtEmployee.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                txtEmployee.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                txtEmployee.Tag = _employee.Emp_ID;
                //_connectioncontrol.GetSystemConfiguration(appmodule.CMS);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaccount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtaccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnaccount_Click(sender, e); }
        }

        private void txtEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnemployee_Click(sender, e); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.GLOBAL.Master.USER, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

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
