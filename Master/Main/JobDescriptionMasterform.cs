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
    public partial class JobDescriptionMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        int _mode = 0;
        int _id = 0;

        public JobDescriptionMasterform()
        {
            InitializeComponent();
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.JOBDESCRIPTION, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void JobDescriptionMasterform_Load(object sender, EventArgs e)
        {
            iJobDescription _ijobdescription = new CMSFilesRepository.rJobDescription();    
            try
            {
                DisplayList("");
                DisplayRecord(_ijobdescription.GetJobDescription(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.JOBDESCRIPTION, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtPosition.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtPosition.Text = "";
            txtPosition.Tag = 0;
            txtDepartment.Text = "";
            txtJobDescription.Text = "";
            chkStatus.Checked = true;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            print_btn.Enabled = _cond;
            attached_btn.Enabled = _cond;
            Search_txt.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            txtPosition.ReadOnly = !_cond;
            txtDepartment.ReadOnly = !_cond;
            txtJobDescription.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iJobDescription _ijobdescription = new CMSFilesRepository.rJobDescription();    
            try
            {
                lsvList.Items.Clear();
                List<JobDescription> _jobdescriptions = _ijobdescription.GetJobDescriptions(_keyword, "All");
                foreach (JobDescription _x in _jobdescriptions)
                {
                    ListViewItem _item = new ListViewItem(_x.JD_ID.ToString());
                    _item.SubItems.Add(_x.POSITIONName);
                    _item.SubItems.Add(_x.DEPARTMENT);
                    _item.SubItems.Add(_x.Status == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(JobDescription _jobdescription)
        {
            try
            {
                if (_jobdescription != null)
                {
                    _id = _jobdescription.JD_ID;
                    txtPosition.Text = _jobdescription.POSITIONName;
                    txtDepartment.Text = _jobdescription.DEPARTMENT;
                    txtJobDescription.Text = _jobdescription.DESCRIPTION;

                    chkStatus.Checked = _jobdescription.Status == true ? true : false;
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

            iJobDescription _ijobdescription = new CMSFilesRepository.rJobDescription();    
            try
            {
                DisplayRecord(_ijobdescription.GetJobDescription(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.JOBDESCRIPTION, Feature.Edit, SystemModuleType.Masterfile) == false) { return; } 
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

                txtPosition.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPosition);
                txtPosition.Focus();
                return;
            }

            if (txtDepartment.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtDepartment);
                txtDepartment.Focus();
                return;
            }

            if (txtJobDescription.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtJobDescription);
                txtJobDescription.Focus();
                return;
            }
            ManageJobDescription();
        }

        void ManageJobDescription()
        {
            iJobDescription _ijobdescription = new CMSFilesRepository.rJobDescription();    
            JobDescription _jobdescription = new JobDescription();

            try
            {
                _jobdescription.JD_ID = _id;
                _jobdescription.POSITIONName = txtPosition.Text;
                _jobdescription.DESCRIPTION = txtJobDescription.Text;
                _jobdescription.DEPARTMENT = txtDepartment.Text;

                _jobdescription.Status = chkStatus.Checked;

                _id = _ijobdescription.ManageJobDescription(_jobdescription, _mode);
                Cancel();

                DisplayList(Search_txt.Text);
                //DisplayRecord(_ijobdescription.GetJobDescription(int.Parse(txtPosition.Tag.ToString())));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iJobDescription _ijobdescription = new CMSFilesRepository.rJobDescription();    
            try
            {
                EnableForm(false);
                EnableButton(true);
                DisplayRecord(_ijobdescription.GetJobDescription(_id));
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

        private void JobDescriptionMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void attached_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "ATTACHED JOB DESCRIPTION", SystemModuleType.System) == false) { return; }
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
