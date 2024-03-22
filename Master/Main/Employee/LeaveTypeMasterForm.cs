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
    public partial class LeaveTypeMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public LeaveTypeMasterForm()
        {
            InitializeComponent();
        }

        private void LeaveTypeMasterForm_Load(object sender, EventArgs e)
        {
            iLeaveType _ileavetype = new HURISRepository.rLeaveType();
            try
            {
                DisplayList("");
                DisplayRecord(_ileavetype.GetLeaveType(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.LEAVE_TYPE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtLeaveType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtLeaveType.Text = "";
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
            txtLeaveType.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iLeaveType _ileavetype = new HURISRepository.rLeaveType();

            try
            {
                lsvList.Items.Clear();
                List<LeaveType> _leavetype = (from d in _ileavetype.GetLeaveTypes(_keyword) orderby d.Leavetype_desc select d).ToList();
                foreach (LeaveType _list in _leavetype)
                {
                    ListViewItem _item = new ListViewItem(_list.Leavetype_ID.ToString());
                    _item.SubItems.Add(_list.Leavetype_desc);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(LeaveType _leavetype)
        {
            try
            {
                if (_leavetype != null)
                {
                    _id = _leavetype.Leavetype_ID;
                    txtLeaveType.Text = _leavetype.Leavetype_desc;
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

            iLeaveType _ileavetype = new HURISRepository.rLeaveType();
            try
            {
                DisplayRecord(_ileavetype.GetLeaveType(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.LEAVE_TYPE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtLeaveType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageLeaveType()
        {
            iLeaveType _ileavetype = new HURISRepository.rLeaveType();
            LeaveType _leavetype = new LeaveType();

            try
            {
                _leavetype.Leavetype_ID = _id;
                _leavetype.Leavetype_desc = txtLeaveType.Text;

                _id = _ileavetype.ManageLeaveType(_leavetype, _mode);
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
            iLeaveType _ileavetype = new HURISRepository.rLeaveType();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ileavetype.GetLeaveType(_id));
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

        private void LeaveTypeMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.LEAVE_TYPE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtLeaveType.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtLeaveType);
                txtLeaveType.Focus();
                return;
            }

            ManageLeaveType();
        }
    }
}
