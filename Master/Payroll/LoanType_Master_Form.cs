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
    public partial class LoanType_Master_Form : Form
    {
        int _mode = 0;
        int _id = 0;

        public LoanType_Master_Form()
        {
            InitializeComponent();
        }

        private void LoanType_Master_Form_Load(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            DisplayRecord();
        }
        void InitializeForm()
        {
            txtloantype.Text = "";
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
            txtloantype.ReadOnly = _cond;
            txtkeyword.ReadOnly = !_cond;
        }
        void DisplayRecord()
        {
            iLoanType _iloantype = new HURISRepository.rLoanType();
            List<LoanType> _loantype = _iloantype.GetLoanTypes(txtkeyword.Text);
            lsvloantype.Items.Clear();
            try
            {
                if (_loantype != null)
                {
                    foreach (LoanType _x in _loantype)
                    {
                        ListViewItem _item = new ListViewItem(_x.LoanType_ID.ToString());
                        _item.SubItems.Add(_x.LoanType_Desc);
                        lsvloantype.Items.Add(_item);
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

        private void lsvloantype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvloantype.SelectedItems.Count == 0) { return; }
            try
            {
                _id = int.Parse(lsvloantype.SelectedItems[0].Text);
                txtloantype.Text = lsvloantype.SelectedItems[0].SubItems[1].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManageRecord()
        {
            iLoanType _iloantype = new HURISRepository.rLoanType();
            LoanType _loantype = new LoanType();

            try
            {
                _loantype.LoanType_ID = _id;
                _loantype.LoanType_Desc = txtloantype.Text;

                _iloantype.ManageLoanType(_loantype, _mode);

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
            lsvloantype.Enabled = false;

            txtloantype.Focus();
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            if(txtloantype.Text == "")
            {
                btxMsg.ShowBalloon(txtloantype);
                txtloantype.Focus();
                return;
            }
            else
            {
                _mode = 1;
                EnableForm(false);
                EnableButton(false);
                lsvloantype.Enabled = false;

                txtloantype.Focus();
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
            lsvloantype.Enabled = true;

            DisplayRecord();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (txtloantype.Text == "")
            {
                btxMsg.ShowBalloon(txtloantype);
                //MessageBox.Show("Adjustment cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtloantype.Focus();
                return;
            }
            ManageRecord();

            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvloantype.Enabled = true;

            DisplayRecord();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvloantype.Enabled = true;

            DisplayRecord();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            lsvloantype.Enabled = true;
        }
    }
}
