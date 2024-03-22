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
    public partial class ShiftMasterForm : Form
    {
        int _id = 0;
        int _mode = 0;

        public ShiftMasterForm()
        {
            InitializeComponent();
        }

        private void ShiftMasterForm_Load(object sender, EventArgs e)
        {
            iShift _ishift = new HURISRepository.rShift();
            try
            {
                DisplayList("");
                DisplayRecord(_ishift.GetShift(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.SHIFT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtShiftDesc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtShiftDesc.Text = "";
            txtGracePeriod.Text = "";
            dtpTimeIn.Value = DateTime.Now;
            dtpTimeOut.Value = DateTime.Now;
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
            txtShiftDesc.ReadOnly = !_cond;
            txtGracePeriod.ReadOnly = !_cond;
            dtpTimeIn.Enabled = _cond;
            dtpTimeOut.Enabled = _cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iShift _ishift = new HURISRepository.rShift();
            try
            {
                lsvList.Items.Clear();
                List<Shift> _shift = (from d in _ishift.GetShifts(_keyword) orderby d.Shift_in.TimeOfDay ascending select d).ToList();
                foreach (Shift _list in _shift)
                {
                    ListViewItem _item = new ListViewItem(_list.Shift_ID.ToString());
                    _item.SubItems.Add(_list.Description);
                    _item.SubItems.Add(_list.Shift_in.ToString("hh:mm tt"));
                    _item.SubItems.Add(_list.Shift_out.ToString("hh:mm tt"));
                    _item.SubItems.Add(_list.Grace_period.ToString());

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Shift _shift)
        {
            try
            {
                if (_shift != null)
                {
                    _id = _shift.Shift_ID;
                    txtShiftDesc.Text = _shift.Description;
                    dtpTimeIn.Value = _shift.Shift_in;
                    dtpTimeOut.Value = _shift.Shift_out;
                    txtGracePeriod.Text = _shift.Grace_period.ToString();
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

            iShift _ishift = new HURISRepository.rShift();
            try
            {
                DisplayRecord(_ishift.GetShift(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.SHIFT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtShiftDesc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageShift()
        {
            iShift _ishift = new HURISRepository.rShift();
            Shift _shift = new Shift();

            try
            {
                _shift.Shift_ID = _id;
                _shift.Description = txtShiftDesc.Text;
                _shift.Shift_in = dtpTimeIn.Value;
                _shift.Shift_out = dtpTimeOut.Value;
                _shift.Grace_period = int.Parse(txtGracePeriod.Text.ToString());

                _id = _ishift.ManageShift(_shift, _mode);
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
            iShift _ishift = new HURISRepository.rShift();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ishift.GetShift(_id));
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

        private void ShiftMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.SHIFT, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtShiftDesc.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtShiftDesc);
                txtShiftDesc.Focus();
                return;
            }

            ManageShift();
        }
    }
}
