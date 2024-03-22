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

namespace DCLGlobal.Master.Payroll
{
    public partial class Deduction_Master_Form : Form
    {
        int _mode = 0;
        int _id = 0;
        string _labid;

        public Deduction_Master_Form()
        {
            InitializeComponent();
        }

        private void Deduction_Master_Form_Load(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            DisplayRecord();
        }
        void InitializeForm()
        {
            txtdeduction.Text = "";
            txtkeyword.Text = "";
        }
        void EnableButton(bool _cond)
        {
            btnadd.Enabled = _cond;
            btnedit.Enabled = _cond;
            btndelete.Enabled = _cond;
            btnprint.Enabled = _cond;
            btnsave.Enabled = !_cond;
            btncancel.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtdeduction.ReadOnly = _cond;
            txtkeyword.ReadOnly = !_cond;
        }
        void DisplayRecord()
        {
            iDeduction _ideduction = new HURISRepository.rDeduction();
            List<CAL.Model.Deduction> _deduction = _ideduction.GetDeductions(txtkeyword.Text);
            lsvdeduction.Items.Clear();
            try
            {
                if (_deduction != null)
                {
                    foreach (Deduction _x in _deduction)
                    {
                        ListViewItem _item = new ListViewItem(_x.Ded_id.ToString());
                        _item.SubItems.Add(_x.Ded_Desc);
                        lsvdeduction.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtkeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayRecord();
            }
        }
        private void lsvdeduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvdeduction.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(lsvdeduction.SelectedItems[0].Text);
                txtdeduction.Text = lsvdeduction.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageRecord()
        {
            iDeduction _ideduction = new HURISRepository.rDeduction();
            Deduction _deduction = new Deduction();

            try
            {
                _deduction.Ded_id = _id;
                _deduction.Ded_Desc = txtdeduction.Text;

                _ideduction.ManageDeduction(_deduction, _mode);


                if (_id > 0)
                {
                    if (_mode == 2)
                    {
                        ToolsControl.CallShowNotification(this, 3, "Record successfully deleted.");
                    }
                    else if (_mode == 0 || _mode == 1)
                    {
                        ToolsControl.CallShowNotification(this, 2, "Record successfully saved.");
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableForm(false);
            EnableButton(false);
            lsvdeduction.Enabled = false;

            txtdeduction.Focus();
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            if(txtdeduction.Text == "")
            {
                btxMsg.ShowBalloon(txtdeduction);
                txtdeduction.Focus();
                return;
            }
            else
            {
                _mode = 1;
                EnableForm(false);
                EnableButton(false);
                lsvdeduction.Enabled = false;

                txtdeduction.Focus();
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Record", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 2;
            ManageRecord();

            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvdeduction.Enabled = true;

            DisplayRecord();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (txtdeduction.Text == "")
            {
                btxMsg.ShowBalloon(txtdeduction);
                //MessageBox.Show("Adjustment cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdeduction.Focus();
                return;
            }
            ManageRecord();

            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvdeduction.Enabled = true;

            DisplayRecord();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvdeduction.Enabled = true;

            DisplayRecord();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            lsvdeduction.Enabled = true;
        }
    }
}
