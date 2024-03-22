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
    public partial class EmployeeTypeMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public EmployeeTypeMasterForm()
        {
            InitializeComponent();
        }

        private void EmployeeTypeMasterForm_Load(object sender, EventArgs e)
        {
            iEmployeeType _iemployeetype = new HURISRepository.rEmployeeType();
            try
            {
                DisplayList("");
                DisplayRecord(_iemployeetype.GetEmployeeType(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TYPE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtEmployeeType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtEmployeeType.Text = "";
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
            txtEmployeeType.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iEmployeeType _iemployeetype = new HURISRepository.rEmployeeType();
            try
            {
                lsvList.Items.Clear();
                List<EmployeeType> _employeetype =  (from d in _iemployeetype.GetEmployeeTypes(_keyword) orderby d.EmpType_Desc select d).ToList();
                foreach (EmployeeType _list in _employeetype)
                { 
                    ListViewItem _item = new ListViewItem(_list.EmpType_ID.ToString());
                    _item.SubItems.Add(_list.EmpType_Desc);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(EmployeeType _employeetype)
        {
            try
            {
                if (_employeetype != null)
                {
                    _id = _employeetype.EmpType_ID;
                    txtEmployeeType.Text = _employeetype.EmpType_Desc;
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

            iEmployeeType _iemployeetype = new HURISRepository.rEmployeeType();
            try
            {
                DisplayRecord(_iemployeetype.GetEmployeeType(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TYPE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtEmployeeType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageEmployeeType()
        {
            iEmployeeType _iemployeetype = new HURISRepository.rEmployeeType();
            EmployeeType _employeetype = new EmployeeType();

            try
            {
                _employeetype.EmpType_ID = _id;
                _employeetype.EmpType_Desc = txtEmployeeType.Text;

                _id = _iemployeetype.ManageEmployeeType(_employeetype, _mode);
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
            iEmployeeType _iemployeetype = new HURISRepository.rEmployeeType();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_iemployeetype.GetEmployeeType(_id));
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

        private void EmployeeTypeMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TYPE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtEmployeeType.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtEmployeeType);
                txtEmployeeType.Focus();
                return;
            }

            ManageEmployeeType();
        }
    }
}
