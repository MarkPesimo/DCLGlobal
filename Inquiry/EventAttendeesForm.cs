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

namespace DCLGlobal.Inquiry
{
    public partial class EventAttendeesForm : Form
    {
        List<EventAttendees> _eventattendees = new List<EventAttendees>();
        int _eventid = 0;
        int _mode = 0;
        int _empid = 0;
        bool _withnewattendees = false;

        public bool AddedNewAttendees
        {
            get { return _withnewattendees; }
        }
        public EventAttendeesForm(int _id, int _imode, List<EventAttendees> _attendees)
        {
            _eventattendees = _attendees;
            _eventid = _id;
            _mode = _imode;
            InitializeComponent();
        }

        private void EventAttendeesForm_Load(object sender, EventArgs e)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                ListView1.Items.Clear();
                List<UserDefineClass.HRIS.EmployeeSearchList> _employee = (from d in _iemployee.SearchEmployees("", "") orderby d.LastName, d.FirstName, d.MiddleName select d).ToList();
                if (_employee != null)
                {
                    foreach (UserDefineClass.HRIS.EmployeeSearchList _list in _employee)
                    {
                        ListViewItem _item = new ListViewItem(_list.LastName + ", " + _list.FirstName + " " + _list.MiddleName.Substring(0, 1) + ".");
                        _item.SubItems.Add(_list.EmpID.ToString());

                        ListView1.Items.Add(_item);

                        EventAttendees _attendees = new EventAttendees();
                        _attendees = (from d in _eventattendees where d.Event_ID == _eventid && d.EmpID == _list.EmpID select d).SingleOrDefault();
                        if (_attendees != null)
                        {
                            _item.Checked = true;
                        }
                    }
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Find()
        {
            ListView1.Refresh();
            ListViewItem _founditem = ListView1.FindItemWithText(txtFind.Text, true, 0, true);
            if (_founditem != null)
            {
                ListView1.TopItem = _founditem;
                ListView1.TopItem.EnsureVisible();
                ListView1.Select();
                _founditem.Selected = true;
            }
            else
            {
                MessageBox.Show("No record found.", "No record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Return)
            {
                Find();
            }
        }

        void SaveAttendees()
        {
            try
            {
                int _count = ListView1.CheckedItems.Count;
                prgBar.Minimum = 0;
                prgBar.Maximum = _count;
                prgBar .Value=0;
                Panel3.Visible = true;

                foreach (ListViewItem _item in ListView1.CheckedItems)
                {
                    prgBar.Value = prgBar.Value + 1;
                    lblPercent.Text = (prgBar.Value / prgBar.Maximum * 100) + "%";

                    _empid = Convert.ToInt32(_item.SubItems[1].Text);
                    _mode = 1;

                    ManageAttendees();

                    if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                    else { ToolsControl.CallShowNotification(this, 3, ""); }
                }
                Panel3.Visible = false;
                if (_count != 0)
                {
                    _withnewattendees = true;
                }
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageAttendees()
        {
            iEvent _ievent = new HURISRepository.rEvent();
            EventAttendees _eventattendees = new EventAttendees();

            try
            {
                _eventattendees.EmpID = _empid;
                _eventattendees.Event_ID = _eventid;

                _ievent.ManageEventAttendees(_eventattendees, _mode);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ListView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select employee to add in the list of attendees.", "No record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult _result = MessageBox.Show("Save list of attendees?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_result == DialogResult.Yes)
                {
                    SaveAttendees();
                }
            }
        }

    }
}
