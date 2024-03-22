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
    public partial class HolidayMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public HolidayMasterForm()
        {
            InitializeComponent();
        }

        private void HolidayMasterForm_Load(object sender, EventArgs e)
        {
            iHoliday _iholiday = new HURISRepository.rHoliday();
            try
            {
                DisplayList("");
                DisplayRecord(_iholiday.GetHoliday(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HOLIDAY, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtHolidayDesc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtHolidayDesc.Text = "";
            cboHolidayType.SelectedIndex = 0;
            dtpHolidayDate.Value = DateTime.Now;
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
            txtHolidayDesc.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
            cboHolidayType.Enabled = _cond;
        }

        void DisplayList(string _keyword)
        {
            iHoliday _iholiday = new HURISRepository.rHoliday();
            try
            {
                lsvList.Items.Clear();
                List<HolidayList> _holiday = (from d in _iholiday.GetHolidays(_keyword) orderby d.Holiday_Date.Value.Year descending, d.Holiday_Date.Value.Month descending, d.Holiday_Date.Value.Day descending select d).ToList();
                foreach (HolidayList _list in _holiday)
                {
                    ListViewItem _item = new ListViewItem(_list.Holiday_ID.ToString());
                    _item.SubItems.Add(_list.Holiday_desc);
                    _item.SubItems.Add(_list.Holiday_Date.Value.ToString("MM/dd/yyyy"));

                    if (_list.HolidayType == null)
                    {
                        _item.SubItems.Add((""));
                    }
                    else
                    {
                        _item.SubItems.Add((_list.HolidayTypes.HolidayTypeDesc));
                    }

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(HolidayList _holiday)
        {
            try
            {
                if (_holiday != null)
                {
                    _id = _holiday.Holiday_ID;
                    txtHolidayDesc.Text = _holiday.Holiday_desc;
                    dtpHolidayDate.Value = _holiday.Holiday_Date.Value;
                    if (_holiday.HolidayType == null)
                    {
                        cboHolidayType.SelectedIndex = 0;
                    }
                    else
                    {
                        cboHolidayType.SelectedIndex = _holiday.HolidayType.Value;
                    }
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

            iHoliday _iholiday = new HURISRepository.rHoliday();
            try
            {
                DisplayRecord(_iholiday.GetHoliday(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HOLIDAY, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtHolidayDesc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageHolidayList()
        {
            iHoliday _iholiday = new HURISRepository.rHoliday();
            HolidayList _holiday = new HolidayList();

            try
            {
                _holiday.Holiday_ID = _id;
                _holiday.Holiday_desc = txtHolidayDesc.Text;
                _holiday.Holiday_Date = dtpHolidayDate.Value;
                _holiday.HolidayType = cboHolidayType.SelectedIndex;

                _id = _iholiday.ManageHoliday(_holiday, _mode);
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
            iHoliday _iholiday = new HURISRepository.rHoliday();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_iholiday.GetHoliday(_id));
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

        private void HolidayMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HOLIDAY, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtHolidayDesc.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtHolidayDesc);
                txtHolidayDesc.Focus();
                return;
            }

            ManageHolidayList();
        }
    }
}
