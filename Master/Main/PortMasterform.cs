using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using DCLGlobal.Classes;
using CAL.Global;

namespace DCLGlobal.Master.Main
{
    public partial class PortMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        int _id = 0;

        public PortMasterform()
        {
            InitializeComponent();
        }

        private void PortMasterform_Load(object sender, EventArgs e)
        {
            iPort _iport = new CMSFilesRepository.rPort(); 
            try
            {
                DisplayList("");
                DisplayRecord(_iport.GetPort(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PORT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtPort.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtPort.Text = "";
            _id = 0;
            chkStatus.Checked = true;
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
            txtPort.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iPort _iport = new CMSFilesRepository.rPort(); 
            try
            {
                lsvList.Items.Clear();
                List<Port> _ports = _iport.GetPorts(_keyword, "All");
                foreach (Port _x in _ports)
                {
                    ListViewItem _item = new ListViewItem(_x.PortID.ToString());
                    _item.SubItems.Add(_x.PortName);
                    _item.SubItems.Add(_x.Status == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Port _port)
        {
            try
            {
                if (_port != null)
                {
                    _id = _port.PortID;
                    txtPort.Text = _port.PortName;

                    chkStatus.Checked = _port.Status == true ? true : false;
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

            iPort _iport = new CMSFilesRepository.rPort(); 
            try
            {
                DisplayRecord(_iport.GetPort(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PORT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtPort.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtPort.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPort);
                txtPort.Focus();
                return;
            }

            ManagePort();
        }

        void ManagePort()
        {
            iPort _iport = new CMSFilesRepository.rPort(); 
            Port _port = new Port();

            try
            {
                _port.PortID = _id;
                _port.PortName = txtPort.Text;

                _port.Status = chkStatus.Checked;

                _id = _iport.ManagePort(_port, _mode);
                Cancel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayList(Search_txt.Text);
                //DisplayRecord(_iport.GetPort(int.Parse(txtPort.Tag.ToString())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iPort _iport = new CMSFilesRepository.rPort(); 
            try
            {
                EnableForm(false);
                EnableButton(true);
                DisplayRecord(_iport.GetPort(_id));
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

        private void PortMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PORT, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

        }

        protected void Search_txt_GotFocus(object sender, EventArgs e)
        {
            Color _color_focus = Color.FromArgb(255, 255, 136);
            Search_txt.BackColor = _color_focus;
        }

        protected void Search_txt_LostFocus(object sender, EventArgs e)
        {
            Search_txt.BackColor = Color.White;
        }
    }
}
