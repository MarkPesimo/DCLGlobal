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
    public partial class TrainingMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        
        int _id = 0;
        int _mode = 0;

        public TrainingMasterform()
        {
            InitializeComponent();
        }

        private void TrainingMasterform_Load(object sender, EventArgs e)
        {
            iTraining _itraining = new CMSFilesRepository.rTraining();   
            try
            {
                DisplayList("");
                DisplayRecord(_itraining.GetTraining(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.TRAINING, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtTrainingName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtTrainingName.Text = "";
            _id = 0;
            txtTrainingType.Text = "";

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
            txtTrainingName.ReadOnly = !_cond;
            txtTrainingType.ReadOnly = !_cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iTraining _itraining = new CMSFilesRepository.rTraining();   
            try
            {
                lsvList.Items.Clear();
                List<Training> _trainings = _itraining.GetTrainings(_keyword, "ALL");
                foreach (Training _x in _trainings)
                {
                    ListViewItem _item = new ListViewItem(_x.Training_ID.ToString());
                    _item.SubItems.Add(_x.Training_Type);
                    _item.SubItems.Add(_x.Training_Name);
                    _item.SubItems.Add(_x.Active == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Training _training)
        {
            try
            {
                if (_training != null)
                {
                    _id = _training.Training_ID;
                    txtTrainingName.Text = _training.Training_Name;
                    txtTrainingType.Text = _training.Training_Type;

                    chkStatus.Checked = _training.Active == true ? true : false;
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

            iTraining _itraining = new CMSFilesRepository.rTraining();   
            try
            {
                DisplayRecord(_itraining.GetTraining(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.TRAINING, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtTrainingName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtTrainingName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtTrainingName);
                txtTrainingName.Focus();
                return;
            }

            ManageTraining();
        }

        void ManageTraining()
        {
            iTraining _itraining = new CMSFilesRepository.rTraining();   
            Training _training = new Training();

            try
            {
                _training.Training_ID = _id;
                _training.Training_Name = txtTrainingName.Text;
                _training.Training_Type = txtTrainingType.Text;

                if (chkStatus.Checked) { _training.Active = true; }
                else { _training.Active = false; }

                _id = _itraining.ManageTraining(_training, _mode);
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
            iTraining _itraining = new CMSFilesRepository.rTraining();   
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_itraining.GetTraining(_id));
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

        private void TrainingMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.TRAINING, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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
