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
    public partial class DepartmentMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public DepartmentMasterForm()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.DEPARTMENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtDepartmentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtDepartmentName.Text = "";
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
            txtDepartmentName.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
            txtCostCode.ReadOnly = !_cond;
            cmbCompany.Enabled = _cond;
        }

        void DisplayList(string _keyword)
        {
            iDepartment _idepartment = new HURISRepository.rDepartment();
            try
            {
                lsvList.Items.Clear();
                List<Department> _department = (from d in _idepartment.GetDepartments(_keyword) orderby d.Dept_Name select d).ToList();
                foreach (Department _list in _department)
                {
                    ListViewItem _item = new ListViewItem(_list.Dept_ID.ToString());
                    _item.SubItems.Add(_list.CompanyProfile.CompanyName);
                    _item.SubItems.Add(_list.Dept_Name);
                    _item.SubItems.Add(_list.Cost_Code);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Department _department)
        {
            try
            {
                if (_department != null)
                {
                    _id = _department.Dept_ID;
                    txtDepartmentName.Text = _department.Dept_Name;
                    cmbCompany.Text = _department.CompanyProfile.CompanyName;
                    txtCostCode.Text = _department.Cost_Code;
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

            iDepartment _idepartment = new HURISRepository.rDepartment();
            try
            {
                DisplayRecord(_idepartment.GetDepartment(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.DEPARTMENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtDepartmentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageDepartment()
        {
            iDepartment _idepartment = new HURISRepository.rDepartment();
            Department _department = new Department();

            try
            {
                _department.Dept_ID = _id;
                _department.Dept_Name = txtDepartmentName.Text;
                _department.CompID = int.Parse(cmbCompany.SelectedValue.ToString());
                _department.Cost_Code = txtCostCode.Text;

                _id = _idepartment.ManageDepartment(_department, _mode);
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
            iDepartment _idepartment = new HURISRepository.rDepartment();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_idepartment.GetDepartment(_id));
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

        private void DepartmentMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.DEPARTMENT, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDepartmentName);
                txtDepartmentName.Focus();
                return;
            }

            if (cmbCompany.Text.Length == 0)
            {
                MessageBox.Show("Please select company.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCompany.Focus();
                return;
            }

            ManageDepartment();
        }

        void BindCompany(ComboBox _cmb)
        {
            iCompany _icompany = new HURISRepository.rCompany();

            try
            {
                List<Company> _company = (from d in _icompany.GetCompanies("") orderby d.CompanyName select d).ToList();
                _cmb.DataSource = _company;
                _cmb.DisplayMember = "CompanyName";
                _cmb.ValueMember = "CompID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepartmentMasterForm_Load(object sender, EventArgs e)
        {
            BindCompany(cmbCompany);

            iDepartment _idepartment = new HURISRepository.rDepartment();
            try
            {
                DisplayList("");
                DisplayRecord(_idepartment.GetDepartment(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
