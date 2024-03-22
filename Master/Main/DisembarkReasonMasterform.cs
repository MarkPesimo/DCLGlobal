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
    public partial class DisembarkReasonMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        int _mode = 0;
        int _id = 0;

        public DisembarkReasonMasterform()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DISEMBARKREASON, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtDisembarkReason.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtDisembarkReason.Text = "";
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
            txtDisembarkReason.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iDisembarkReason _idesimbarkreason = new CMSFilesRepository.rDisembarkReason();      
            try
            {
                lsvList.Items.Clear();
                List<DisembarkReason> _disembarkreasons = _idesimbarkreason.GetDisembarkReasons(_keyword, "All");
                foreach (DisembarkReason _x in _disembarkreasons)
                {
                    ListViewItem _item = new ListViewItem(_x.id.ToString());
                    _item.SubItems.Add(_x.Reason);
                    _item.SubItems.Add(_x.Status == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(DisembarkReason _disembarkreason)
        {
            try
            {
                if (_disembarkreason != null)
                {
                    _id = _disembarkreason.id;
                    txtDisembarkReason.Text = _disembarkreason.Reason;

                    chkStatus.Checked = _disembarkreason.Status == true ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DisembarkReasonMasterform_Load(object sender, EventArgs e)
        {
            iDisembarkReason _idesimbarkreason = new CMSFilesRepository.rDisembarkReason();      
            try
            {
                DisplayList("");
                DisplayRecord(_idesimbarkreason.GetDisembarkReason(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iDisembarkReason _idesimbarkreason = new CMSFilesRepository.rDisembarkReason();      
            try
            {
                DisplayRecord(_idesimbarkreason.GetDisembarkReason(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DISEMBARKREASON, Feature.Edit, SystemModuleType.Masterfile) == false) { return; } 
            if (_id== 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtDisembarkReason.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtDisembarkReason.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDisembarkReason);
                txtDisembarkReason.Focus();
                return;
            }

            ManageDisembarkReason();
        }

        void ManageDisembarkReason()
        {
            iDisembarkReason _idesimbarkreason = new CMSFilesRepository.rDisembarkReason();      
            DisembarkReason _disembarkreason = new DisembarkReason();

            try
            {
                _disembarkreason.id = _id;
                _disembarkreason.Reason = txtDisembarkReason.Text;
                
                _disembarkreason.Status = chkStatus.Checked;

                _id = _idesimbarkreason.ManageDisembarkResaon(_disembarkreason, _mode);
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
            iDisembarkReason _idesimbarkreason = new CMSFilesRepository.rDisembarkReason();      
            try
            {
                EnableForm(false);
                EnableButton(true);
                DisplayRecord(_idesimbarkreason.GetDisembarkReason(_id));
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

        private void DisembarkReasonMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.DISEMBARKREASON, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

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
