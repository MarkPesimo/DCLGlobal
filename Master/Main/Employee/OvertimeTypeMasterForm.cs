﻿using System;
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
    public partial class OvertimeTypeMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public OvertimeTypeMasterForm()
        {
            InitializeComponent();
        }

        private void OvertimeMasterForm_Load(object sender, EventArgs e)
        {
            iOvertimeType _iovertimetype = new HURISRepository.rOvertimeType();
            try
            {
                DisplayList("");
                DisplayRecord(_iovertimetype.GetOvertimeType(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.OVERTIME_TYPE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtOvertimeType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtOvertimeType.Text = "";
            txtOvertimeRate.Text = "";
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
            txtOvertimeType.ReadOnly = !_cond;
            txtOvertimeRate.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iOvertimeType _iovertimetype = new HURISRepository.rOvertimeType();

            try
            {
                lsvList.Items.Clear();
                List<Overtime> _overtimetype = (from d in _iovertimetype.GetOvertimeTypes(_keyword) orderby d.Overtime_Desc select d).ToList();
                foreach (Overtime _list in _overtimetype)
                {
                    ListViewItem _item = new ListViewItem(_list.Overtime_ID.ToString());
                    _item.SubItems.Add(_list.Overtime_Desc);
                    _item.SubItems.Add(_list.Overtime_Rate.ToString());

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Overtime _overtimetype)
        {
            try
            {
                if (_overtimetype != null)
                {
                    _id = _overtimetype.Overtime_ID;
                    txtOvertimeType.Text = _overtimetype.Overtime_Desc;
                    txtOvertimeRate.Text = _overtimetype.Overtime_Rate.ToString();
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

            iOvertimeType _iovertimetype = new HURISRepository.rOvertimeType();
            try
            {
                DisplayRecord(_iovertimetype.GetOvertimeType(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.OVERTIME_TYPE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtOvertimeType.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageOvertimeType()
        {
            iOvertimeType _iovertimetype = new HURISRepository.rOvertimeType();
            Overtime _overtimetype = new Overtime();

            try
            {
                _overtimetype.Overtime_ID = _id;
                _overtimetype.Overtime_Desc = txtOvertimeType.Text;
                _overtimetype.Overtime_Rate =decimal.Parse(txtOvertimeRate.Text);

                _id = _iovertimetype.ManageOvertimeType(_overtimetype, _mode);
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
            iOvertimeType _iovertimetype = new HURISRepository.rOvertimeType();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_iovertimetype.GetOvertimeType(_id));
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

        private void OvertimeTypeMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.OVERTIME_TYPE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtOvertimeType.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtOvertimeType);
                txtOvertimeType.Focus();
                return;
            }

            ManageOvertimeType();
        }
    }
}
