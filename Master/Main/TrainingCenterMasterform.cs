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
using CAL.Global;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main
{
    public partial class TrainingCenterMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        int _mode = 0;
        int _id = 0;

        public TrainingCenterMasterform()
        {
            InitializeComponent();
        }

        private void TrainingCenterMasterform_Load(object sender, EventArgs e)
        {
            iTrainingCenter _itrainingcenter = new CMSFilesRepository.rTrainingCenter();         
            try
            {
                DisplayList("");
                DisplayRecord(_itrainingcenter.GetTrainingCenter(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.TRAININGCENTER, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtTrainingCenterName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtTrainingCenterName.Text = "";
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
            txtTrainingCenterName.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iTrainingCenter _itrainingcenter = new CMSFilesRepository.rTrainingCenter();         
            try
            {
                lsvList.Items.Clear();
                List<TrainingCenter> _trainingcenters = _itrainingcenter.GetTrainingCenters(_keyword, "ALL");
                foreach (TrainingCenter _x in _trainingcenters)
                {
                    ListViewItem _item = new ListViewItem(_x.Institution_ID.ToString());
                    _item.SubItems.Add(_x.Institution_Name);
                    _item.SubItems.Add(_x.Active == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(TrainingCenter _trainingcenter)
        {
            try
            {
                if (_trainingcenter != null)
                {
                    _id = _trainingcenter.Institution_ID;
                    txtTrainingCenterName.Text = _trainingcenter.Institution_Name;

                    chkStatus.Checked = _trainingcenter.Active == true ? true : false;
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

            iTrainingCenter _itrainingcenter = new CMSFilesRepository.rTrainingCenter();         
            try
            {
                DisplayRecord(_itrainingcenter.GetTrainingCenter(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.TRAININGCENTER, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtTrainingCenterName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtTrainingCenterName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtTrainingCenterName);
                txtTrainingCenterName.Focus();
                return;
            }

            ManageTrainingCenter();
        }

        void ManageTrainingCenter()
        {
            iTrainingCenter _itrainingcenter = new CMSFilesRepository.rTrainingCenter();         
            TrainingCenter _trainingcenter = new TrainingCenter();

            try
            {
                _trainingcenter.Institution_ID = _id;
                _trainingcenter.Institution_Name = txtTrainingCenterName.Text;

                if (chkStatus.Checked) { _trainingcenter.Active = true; }
                else { _trainingcenter.Active = false; }

                _id = _itrainingcenter.ManageTrainingCenter(_trainingcenter, _mode);
                Cancel();

                DisplayList(Search_txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iTrainingCenter _itrainingcenter = new CMSFilesRepository.rTrainingCenter();         
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_itrainingcenter.GetTrainingCenter(_id));
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

        private void TrainingCenterMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.TRAININGCENTER, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

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
