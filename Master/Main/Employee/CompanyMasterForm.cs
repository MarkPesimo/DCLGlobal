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
    public partial class CompanyMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public CompanyMasterForm()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.BRANCH, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtCompanyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtCompanyName.Text = "";
            txtCompanyCode.Text = "";
            txtCompanyCodeNo.Text = "";
            txtPresentingOffice.Text = "";
            txtCeilingAmount.Text = "";
            txtAccountNo.Text = "";
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
            txtCompanyName.ReadOnly = !_cond;
            txtCompanyCodeNo.ReadOnly = !_cond;
            txtCompanyCode.ReadOnly = !_cond;
            txtPresentingOffice.ReadOnly = !_cond;
            txtCeilingAmount.ReadOnly = !_cond;
            txtAccountNo.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iCompany _icompany = new HURISRepository.rCompany();

            try
            {
                lsvList.Items.Clear();
                List<Company> _company = (from d in _icompany.GetCompanies(_keyword) orderby d.CompanyName select d).ToList();
                foreach (Company _list in _company)
                {
                    ListViewItem _item = new ListViewItem(_list.CompID.ToString());
                    _item.SubItems.Add(_list.CompanyName);
                    _item.SubItems.Add(_list.CompanyCodeNo);
                    _item.SubItems.Add(_list.CompanyCode);
                    _item.SubItems.Add(_list.PresentingOfiz);
                    _item.SubItems.Add(_list.CeilingAmount.ToString());
                    _item.SubItems.Add(_list.Account_No);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Company _company)
        {
            try
            {
                if (_company != null)
                {
                    _id = _company.CompID;
                    txtCompanyName.Text = _company.CompanyName;
                    txtCompanyCodeNo.Text = _company.CompanyCodeNo;
                    txtCompanyCode.Text = _company.CompanyCode;
                    txtPresentingOffice.Text = _company.PresentingOfiz;
                    txtCeilingAmount.Text = _company.CeilingAmount.ToString();
                    txtAccountNo.Text = _company.Account_No;
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

            iCompany _icompany = new HURISRepository.rCompany();
            try
            {
                DisplayRecord(_icompany.GetCompany(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.BRANCH, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtCompanyName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageBranch()
        {
            iCompany _icompany = new HURISRepository.rCompany();
            Company _company = new Company();

            try
            {
                _company.CompID = _id;
                _company.CompanyName = txtCompanyName.Text;
                _company.CompanyCodeNo = txtCompanyCodeNo.Text;
                _company.CompanyCode = txtCompanyCode.Text;
                _company.PresentingOfiz = txtPresentingOffice.Text;
                _company.CeilingAmount = decimal.Parse(txtCeilingAmount.Text);
                _company.Account_No = txtAccountNo.Text;

                _id = _icompany.ManageCompany(_company, _mode);
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
            iCompany _icompany = new HURISRepository.rCompany();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icompany.GetCompany(_id));
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

        private void CompanyMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.BRANCH, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtCompanyName);
                txtCompanyName.Focus();
                return;
            }

            ManageBranch();
        }

        private void CompanyMasterForm_Load(object sender, EventArgs e)
        {
            iCompany _icompany = new HURISRepository.rCompany();
            try
            {
                DisplayList("");
                DisplayRecord(_icompany.GetCompany(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
