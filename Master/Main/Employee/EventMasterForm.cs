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
    public partial class EventMasterForm : Form
    {
        int _id = 0;
        int _mode = 0;
        int _attendeestype = 0;
        List<EventAttendees> _eventattendees;

        public EventMasterForm()
        {
            InitializeComponent();
        }

        private void EventMasterForm_Load(object sender, EventArgs e)
        {
            iEvent _ievent = new HURISRepository.rEvent();   
            try
            {
                DisplayList("");
                DisplayRecord(_ievent.GetEvent(_id));
                DisplayAttendees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EVENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
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
            cboAttendees.SelectedIndex = 0;
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
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
            cboAttendees.Enabled = _cond;
            dtpDateFrom.Enabled = _cond;
            dtpDateTo.Enabled = _cond;
            cbofrom.Enabled = _cond;
            cboTo.Enabled = _cond;
        }

        void DisplayList(string _keyword)
        {
            iEvent _ievent = new HURISRepository.rEvent();   
            try
            {
                lsvList.Items.Clear();
                List<EventList> _eventlist = (from d in _ievent.GetEvents(_keyword) orderby d.Event_DateFrom ascending select d).ToList();
                foreach (EventList _list in _eventlist)
                {
                    ListViewItem _item = new ListViewItem(_list.Event_ID.ToString());
                    _item.SubItems.Add(_list.Event_Description);
                    _item.SubItems.Add(_list.Event_DateFrom.Value.ToString("MM/dd/yyyy"));
                    _item.SubItems.Add(_list.Event_DateTo.Value.ToString("MM/dd/yyyy"));
                    if (_list.AttendeesType == 1)
                    {
                        _item.SubItems.Add("All");
                    }
                    else if (_list.AttendeesType == 2)
                    {
                        _item.SubItems.Add("Per Employee");
                    }

                    lsvList.Items.Add(_item);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(EventList _eventlist)
        {
            try
            {
                if (_eventlist != null)
                {
                    _id = _eventlist.Event_ID;
                    txtHolidayDesc.Text = _eventlist.Event_Description;
                    dtpDateFrom.Value = _eventlist.Event_DateFrom.Value;
                    dtpDateTo.Value = _eventlist.Event_DateTo.Value;
                    if (_eventlist.AttendeesType == 0)
                    {
                        cboAttendees.SelectedIndex = 0;
                    }
                    else
                    {
                        cboAttendees.SelectedIndex = _eventlist.AttendeesType.Value;
                    }
                    _attendeestype = int.Parse(_eventlist.AttendeesType.ToString());
                    cbofrom.Text = _eventlist.From_AMPM;
                    cboTo.Text = _eventlist.To_AMPM;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iEvent _ievent = new HURISRepository.rEvent();
            try
            {
                DisplayRecord(_ievent.GetEvent(int.Parse(lsvList.SelectedItems[0].Text)));
                DisplayAttendees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EVENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

        void ManageEvent()
        {
            iEvent _ievent = new HURISRepository.rEvent();
            EventList _eventlist = new EventList();

            try
            {
                _eventlist.Event_ID = _id;
                _eventlist.Event_Description = txtHolidayDesc.Text;
                _eventlist.Event_DateFrom = dtpDateFrom.Value;
                _eventlist.Event_DateTo = dtpDateTo.Value;
                _eventlist.AttendeesType = cboAttendees.SelectedIndex;
                _eventlist.From_AMPM = cbofrom.Text;
                _eventlist.To_AMPM = cboTo.Text;

                _id = _ievent.ManageEvent(_eventlist, _mode);
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
            iEvent _ievent = new HURISRepository.rEvent();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ievent.GetEvent(_id));
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

        private void EventMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }

            if (e.KeyCode == Keys.F2)
            {
                if (_id == 0)
                {
                    MessageBox.Show("Please select event to add attendees.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (_attendeestype == 2)
                { 
                    EventAttendeesForm frmEmpList = new EventAttendeesForm(_id, _mode, _eventattendees);
                    frmEmpList.BringToFront();
                    frmEmpList.ShowDialog();

                    if (frmEmpList.AddedNewAttendees)
                    {
                        DisplayAttendees();
                    }
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EVENT, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtHolidayDesc.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtHolidayDesc);
                txtHolidayDesc.Focus();
                return;
            }

            ManageEvent();
        }

        void DisplayAttendees()
        {
            iEvent _ieventattendees = new HURISRepository.rEvent();
            try
            {
                lstEmployee.Items.Clear();
                _eventattendees = (from d in _ieventattendees.GetAttendees(_id) orderby d.Employee.Lastname, d.Employee.Firstname select d).ToList();
                if (_eventattendees != null)
                {
                    foreach (EventAttendees _list in _eventattendees)
                    {
                        ListViewItem _item = new ListViewItem(_list.AttendeesID.ToString());
                        _item.SubItems.Add(_list.EmpID.ToString());
                        _item.SubItems.Add(_list.Employee.Lastname + ", " + _list.Employee.Firstname + " " + _list.Employee.Middlename.Substring(0, 1) + ".");

                        lstEmployee.Items.Add(_item);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
