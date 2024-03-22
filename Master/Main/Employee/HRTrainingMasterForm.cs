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
    public partial class HRTrainingMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public HRTrainingMasterForm()
        {
            InitializeComponent();
        }

        private void HRTrainingMasterForm_Load(object sender, EventArgs e)
        {
            iHRTraining _ihrtraining = new HURISRepository.rHRTraining();
            try
            {
                DisplayList("");
                DisplayRecord(_ihrtraining.GetTraining(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HR_TRAINING, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
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
            _id = 0;
            txtTrainingName.Text = "";
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
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iHRTraining _ihrtraining = new HURISRepository.rHRTraining();

            try
            {
                lsvList.Items.Clear();
                List<HRTraining> _hrtraining = (from d in _ihrtraining.GetTrainings(_keyword) orderby d.Training_name select d).ToList();
                foreach (HRTraining _list in _hrtraining)
                {
                    ListViewItem _item = new ListViewItem(_list.Training_id.ToString());
                    _item.SubItems.Add(_list.Training_name);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(HRTraining _hrtraining)
        {
            try
            {
                if (_hrtraining != null)
                {
                    _id = _hrtraining.Training_id;
                    txtTrainingName.Text = _hrtraining.Training_name;
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

            iHRTraining _ihrtraining = new HURISRepository.rHRTraining();
            try
            {
                DisplayRecord(_ihrtraining.GetTraining(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HR_TRAINING, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtTrainingName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageHRTraining()
        {
            iHRTraining _ihrtraining = new HURISRepository.rHRTraining();
            HRTraining _hrtraining = new HRTraining();

            try
            {
                _hrtraining.Training_id = _id;
                _hrtraining.Training_name = txtTrainingName.Text;

                _id = _ihrtraining.ManageTraining(_hrtraining, _mode);
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
            iHRTraining _ihrtraining = new HURISRepository.rHRTraining();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ihrtraining.GetTraining(_id));
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

        private void HRTrainingMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.HR_TRAINING, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtTrainingName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtTrainingName);
                txtTrainingName.Focus();
                return;
            }

            ManageHRTraining();
        }
    }
}
