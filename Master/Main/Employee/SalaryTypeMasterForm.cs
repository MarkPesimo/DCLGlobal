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
    public partial class SalaryTypeMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public SalaryTypeMasterForm()
        {
            InitializeComponent();
        }

        private void SalaryTypeMasterForm_Load(object sender, EventArgs e)
        {
            iSalaryType _isalarytype = new HURISRepository.rSalaryType();
            try
            {
                DisplayList("");
                DisplayRecord(_isalarytype.GetSalaryType(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.SALARY_TYPE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtSalaryType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtSalaryType.Text = "";
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
            txtSalaryType.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iSalaryType _isalarytype = new HURISRepository.rSalaryType();

            try
            {
                lsvList.Items.Clear();
                List<Salarytype> _salarytype = (from d in _isalarytype.GetSalaryTypes(_keyword) orderby d.Salarytype_Desc select d).ToList();
                foreach (Salarytype _list in _salarytype)
                {
                    ListViewItem _item = new ListViewItem(_list.Salarytype_ID.ToString());
                    _item.SubItems.Add(_list.Salarytype_Desc);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Salarytype _salarytype)
        {
            try
            {
                if (_salarytype != null)
                {
                    _id = _salarytype.Salarytype_ID;
                    txtSalaryType.Text = _salarytype.Salarytype_Desc;
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

            iSalaryType _isalarytype = new HURISRepository.rSalaryType();
            try
            {
                DisplayRecord(_isalarytype.GetSalaryType(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.SALARY_TYPE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtSalaryType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageSalaryType()
        {
            iSalaryType _isalarytype = new HURISRepository.rSalaryType();
            Salarytype _salarytype = new Salarytype();

            try
            {
                _salarytype.Salarytype_ID = _id;
                _salarytype.Salarytype_Desc = txtSalaryType.Text;

                _id = _isalarytype.ManageSalaryType(_salarytype, _mode);
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
            iSalaryType _isalarytype = new HURISRepository.rSalaryType();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_isalarytype.GetSalaryType(_id));
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

        private void SalaryTypeMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.SALARY_TYPE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtSalaryType.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtSalaryType);
                txtSalaryType.Focus();
                return;
            }

            ManageSalaryType();
        }
    }
}
