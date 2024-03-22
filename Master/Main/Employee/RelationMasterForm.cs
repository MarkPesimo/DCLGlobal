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
    public partial class RelationMasterForm : Form
    {
        int _mode = 0;
        int _id = 0;

        public RelationMasterForm()
        {
            InitializeComponent();
        }

        private void RelationMasterForm_Load(object sender, EventArgs e)
        {
            iRelation _irelation = new HURISRepository.rRelationship();
            try
            {
                DisplayList("");
                DisplayRecord(_irelation.GetRelation(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.RELATIONSHIP, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtRelation.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtRelation.Text = "";
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
            txtRelation.ReadOnly = !_cond;
            pan_Search.Enabled = !_cond;
            chkStatus.Enabled = _cond; 
        }

        void DisplayList(string _keyword)
        {
            iRelation _irelation = new HURISRepository.rRelationship();

            try
            {
                lsvList.Items.Clear();
                List<Relationship> _relationship = (from d in _irelation.GetRelations(_keyword) orderby d.Relation select d).ToList();
                foreach (Relationship _list in _relationship)
                {
                    ListViewItem _item = new ListViewItem(_list.Relation_id.ToString());
                    _item.SubItems.Add(_list.Relation);
                    if (_list.IsActive == 1)
                    {
                        _item.SubItems.Add("Active");
                    }
                    else
                    {
                        _item.SubItems.Add("InActive");
                    }

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Relationship _relationship)
        {
            try
            {
                if (_relationship != null)
                {
                    _id = _relationship.Relation_id;
                    txtRelation.Text = _relationship.Relation;
                    if (_relationship.IsActive == 1)
                    {
                        chkStatus.Checked = true;
                    }
                    else
                    {
                        chkStatus.Checked = false;
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

            iRelation _irelation = new HURISRepository.rRelationship();
            try
            {
                DisplayRecord(_irelation.GetRelation(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.RELATIONSHIP, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtRelation.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageRelationship()
        {
            iRelation _irelation = new HURISRepository.rRelationship();
            Relationship _relationship = new Relationship();

            try
            {
                _relationship.Relation_id = _id;
                _relationship.Relation = txtRelation.Text;
                if (chkStatus.Checked == true)
                {
                    _relationship.IsActive = 1;
                }
                else
                {
                    _relationship.IsActive = 0;
                }
                

                _id = _irelation.ManageRelation(_relationship, _mode);
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
            iRelation _irelation = new HURISRepository.rRelationship();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_irelation.GetRelation(_id));
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

        private void RelationMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.RELATIONSHIP, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtRelation.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtRelation);
                txtRelation.Focus();
                return;
            }

            ManageRelationship();
        }
    }
}
