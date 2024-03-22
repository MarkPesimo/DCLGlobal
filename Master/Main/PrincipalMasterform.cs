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
    public partial class PrincipalMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);       
        int _mode = 0;
        int _id = 0;
        int _accountid = 0;

        public PrincipalMasterform()
        {
            InitializeComponent();            
        }

        private void DisplayAccounts()
        {
            iAccount _iAccount = new CMSFilesRepository.rAccount();
            try
            {
                lsvAccount.Items.Clear();
                List<Account> _accounts = _iAccount.GetAccounts( "", "All");
                foreach (Account _x in _accounts)
                {
                    ListViewItem _item = new ListViewItem(_x.AccountID.ToString());
                    _item.SubItems.Add(_x.AcctDescription);

                    lsvAccount.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
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

                txtAccountname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtAccountname.Text = "";
            _id = 0;
            txtPrincipalname.Text = "";
            txtPrincipalname.Tag = 0;
            txtPayrollPrincipal.Text = "";
            txtPayrollPrincipal.Tag = 0;
            txtPOEAprincipal.Text = "";
            txtPOEAprincipal.Tag = 0;
                        
            chkStatus.Checked = true;
            txtAddress.Text = "";
            txtEmailAddress.Text = "";
            txtContactno.Text = "";
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
            txtPrincipalname.ReadOnly = !_cond;
            txtAddress.ReadOnly = !_cond;
            txtEmailAddress.ReadOnly = !_cond;
            txtContactno.ReadOnly = !_cond;

            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            if (_accountid == 0) 
            {
                MessageBox.Show("Kindly select first a account.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                expAccount.Expanded = true;
                lsvAccount.Focus();
                return;
            }

            iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
            try
            {
                lsvList.Items.Clear();
                List<Principal> _principals = _iprincipal.GetPrincipals(_accountid, _keyword, true);
                foreach (Principal _x in _principals)
                {
                    ListViewItem _item = new ListViewItem(_x.PrincipalID.ToString());
                    _item.SubItems.Add(_x.Account.AcctDescription);
                    _item.SubItems.Add(_x.PrincipalDescription);
                    _item.SubItems.Add(_x.Status == 0 ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Principal _principal)
        {
            try
            {
                if (_principal != null)
                {
                    txtAccountname.Tag = _principal.AccountID;
                    txtAccountname.Text = _principal.Account.AcctDescription;
                    txtPrincipalname.Text = _principal.PrincipalDescription;
                    _id = _principal.PrincipalID;

                    DCLAPSFilesRepository.rDCLAPSPrincipalSetUp _iprincipal = new DCLAPSFilesRepository.rDCLAPSPrincipalSetUp();
                    txtPayrollPrincipal.Text = _iprincipal.GetPrincipalSetup(int.Parse(_principal.PayrollPrincipalID.ToString())).Pname;
                    //txtPayrollPrincipal.Text =  _principal.PrincipalSetUp.Pname;
                    txtPayrollPrincipal.Tag = _principal.PayrollPrincipalID;
                    txtPOEAprincipal.Text = _principal.POEAPrincipal.PrincipalName;
                    txtPOEAprincipal.Tag = _principal.POEA_PrincipalID;

                    txtAddress.Text = _principal.Address;
                    txtEmailAddress.Text = _principal.E_Add;
                    txtContactno.Text = _principal.ContactNo;

                    chkStatus.Checked = _principal.Status == 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void PrincipalMasterform_Load(object sender, EventArgs e)
        {
            iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
            try
            {
                DisplayAccounts();
                //DisplayList("");
                //DisplayRecord(_iprincipal.GetPrincipal(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
            try
            {
                DisplayRecord(_iprincipal.GetPrincipal(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PRINCIPAL, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }            
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
            if (txtAccountname.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtAccountname);
                txtAccountname.Focus();
                return;
            }
            if (txtPrincipalname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPrincipalname);
                txtPrincipalname.Focus();
                return;
            }

            ManagePrincipal();
        }

        void ManagePrincipal()
        {
            iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
            Principal _Principal = new Principal();

            try
            {
                _Principal.AccountID = int.Parse(txtAccountname.Tag.ToString());
                _Principal.PrincipalDescription = txtPrincipalname.Text;
                _Principal.PrincipalID = _id;
                _Principal.PayrollPrincipalID = int.Parse(txtPayrollPrincipal.Tag.ToString());
                _Principal.POEA_PrincipalID = int.Parse(txtPOEAprincipal.Tag.ToString());

                if (chkStatus.Checked ) { _Principal.Status =  0; }
                else                    { _Principal.Status = 1; }

                _Principal.Address = txtAddress.Text;
                _Principal.E_Add = txtEmailAddress.Text;
                _Principal.ContactNo = txtContactno.Text;


                _id = _iprincipal.ManagePrincipal(_Principal, _mode);
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
            iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_iprincipal.GetPrincipal(_id));
            }
            catch(Exception ex)
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

            txtAccountname.Text = "";
            txtAccountname.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.ACCOUNTS;
            _Searchform.ShowDialog();

            //Account _account = _Searchform.ReturnSearchAccount;
            //if (_account != null)
            //{
            //    txtAccountname.Text = _account.AcctDescription;
            //    txtAccountname.Tag = _account.AccountID;
            //}
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtPayrollPrincipal.Text = "";
            txtPayrollPrincipal.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PAYROLL_PRINCIPAL;
            _Searchform.ShowDialog();

            //PrincipalSetUp _payrollprincipal = _Searchform.ReturnSearchPayrollPrincipal;
            //if (_payrollprincipal != null)
            //{
            //    txtPayrollPrincipal.Text = _payrollprincipal.Pname;
            //    txtPayrollPrincipal.Tag = _payrollprincipal.ID;
            //}
        }

        private void btnPOEA_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            if (Add_btn.Enabled) { return; }

            txtPOEAprincipal.Text = "";
            txtPOEAprincipal.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.POEA_PRINCIPAL;
            _Searchform.ShowDialog();

            //POEAPrincipal _POEAPrincipal = _Searchform.ReturnSearchPOEAPrincipal;
            //if (_POEAPrincipal != null)
            //{
            //    txtPOEAprincipal.Text = _POEAPrincipal.PrincipalName;
            //    txtPOEAprincipal.Tag = _POEAPrincipal.ID;
            //}
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void PrincipalMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void txtAccountname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnAccount_Click(sender, e); }
        }

        private void txtPayrollPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnpayroll_Click(sender, e); }
        }

        private void txtPOEAprincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnPOEA_Click(sender, e); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PRINCIPAL, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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

        private void lsvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count == 0) { return; }

            try
            {
                _accountid =int.Parse(lsvAccount.SelectedItems[0].Text);
                DisplayList("");
                //DisplayRecord(_iprincipal.GetPrincipal(int.Parse(lsvAccount.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
