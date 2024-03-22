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
    public partial class BranchMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public BranchMasterForm()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.BRANCH, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtBranchName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtBranchName.Text = "";
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
            txtBranchName.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iBranch _ibranch = new HURISRepository.rBranch();
            try
            {
                lsvList.Items.Clear();
                List<Branch> _branch = (from d in _ibranch.GetBranches(_keyword) orderby d.Branch_Desc select d).ToList();
                foreach (Branch _list in _branch)
                {
                    ListViewItem _item = new ListViewItem(_list.Branch_ID.ToString());
                    _item.SubItems.Add(_list.Branch_Desc);

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Branch _branch)
        {
            try
            {
                if (_branch != null)
                {
                    _id = _branch.Branch_ID;
                    txtBranchName.Text = _branch.Branch_Desc;
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

            iBranch _ibranch = new HURISRepository.rBranch();
            try
            {
                DisplayRecord(_ibranch.GetBranch(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.BRANCH, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtBranchName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageBranch()
        {
            iBranch _ibranch = new HURISRepository.rBranch();
            Branch _branch = new Branch();

            try
            {
                _branch.Branch_ID = _id;
                _branch.Branch_Desc = txtBranchName.Text;

                _id = _ibranch.ManageBranch(_branch, _mode);
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
            iBranch _ibranch = new HURISRepository.rBranch();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ibranch.GetBranch(_id));
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

        private void BranchMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.BRANCH, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void BranchMasterForm_Load(object sender, EventArgs e)
        {
            iBranch _ibranch = new HURISRepository.rBranch();
            try
            {
                DisplayList("");
                DisplayRecord(_ibranch.GetBranch(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtBranchName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtBranchName);
                txtBranchName.Focus();
                return;
            }

            ManageBranch();
        }


    }
}
