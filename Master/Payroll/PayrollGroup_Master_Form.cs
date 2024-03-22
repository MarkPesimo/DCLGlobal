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
    public partial class PayrollGroup_Master_Form : Form
    {
        int _mode = 0;
        int _id = 0;
        public PayrollGroup_Master_Form()
        {
            InitializeComponent();
        }

        private void PayrollGroup_Master_Form_Load(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            DisplayRecord();
        }
        void InitializeForm()
        {
            txtkeyword.Text = "";
            txtdescription.Text = "Bonus/13th Month Pay";
            cmbsssSched.SelectedItem = "1st Cutoff";
            cmbtaxSched.SelectedItem = "1st Cutoff";
            cmbphilhealthSched.SelectedItem = "1st Cutoff";
            cmbpagibigSched.SelectedItem = "1st Cutoff";
            txtpagibigShare.Text = "0.00";
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
            //txtkeyword.ReadOnly = _cond;
            txtdescription.ReadOnly = _cond;
            //cmbsssSched.Enabled = !_cond;
            //cmbtaxSched.Enabled = !_cond;
            txtpagibigShare.ReadOnly = _cond;
            //cmbphilhealthSched.Enabled = !_cond;
            //cmbpagibigSched.Enabled = !_cond;
        }
        void DisplayRecord()
        {
            iPayrollGroup _ipayrollgroup = new HURISRepository.rPayrollGroup();
            List<CAL.Model.Payroll_Group> _payrollgroup = _ipayrollgroup.GetPayrollGroups(txtkeyword.Text);
            lsvloantype.Items.Clear();
            try
            {
                if (_payrollgroup != null)
                {
                    foreach (Payroll_Group _x in _payrollgroup)
                    {
                        ListViewItem _item = new ListViewItem(_x.PayrollGroup_ID.ToString());
                        _item.SubItems.Add(_x.Description);
                        _item.SubItems.Add(_x.SSS_Sched.ToString());
                        _item.SubItems.Add(_x.Philhealth_Sched.ToString());
                        _item.SubItems.Add(_x.Tax_Sched.ToString());
                        _item.SubItems.Add(_x.Pagibig_Sched.ToString());
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
                txtdescription.Text = lsvloantype.SelectedItems[0].SubItems[1].Text;
                DisplayDocument();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayDocument()
        {
            iPayrollGroup _ipayrollgroup = new HURISRepository.rPayrollGroup();
            Payroll_Group _payrollgroup = _ipayrollgroup.GetPayrollGroup(_id);
            try
            {
                if(_payrollgroup != null)
                {
                    _id = _payrollgroup.PayrollGroup_ID;
                    txtdescription.Text = _payrollgroup.Description;
                    cmbsssSched.SelectedIndex = int.Parse(_payrollgroup.SSS_Sched.ToString());
                    cmbphilhealthSched.SelectedIndex = int.Parse(_payrollgroup.Philhealth_Sched.ToString());
                    cmbtaxSched.SelectedIndex = int.Parse(_payrollgroup.Tax_Sched.ToString());
                    cmbpagibigSched.SelectedIndex = int.Parse(_payrollgroup.Pagibig_Sched.ToString());
                    txtpagibigShare.Text = _payrollgroup.Pagibig.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        void ManageRecord()
        {
            iPayrollGroup _ipayrollgroup = new HURISRepository.rPayrollGroup();
            Payroll_Group _payrollgroup = new Payroll_Group();

            try
            {
                _payrollgroup.PayrollGroup_ID = _id;
                _payrollgroup.Description = txtdescription.Text;
                _payrollgroup.SSS_Sched = cmbsssSched.SelectedIndex;
                _payrollgroup.Philhealth_Sched = cmbphilhealthSched.SelectedIndex;
                _payrollgroup.Tax_Sched = cmbtaxSched.SelectedIndex;
                _payrollgroup.Pagibig_Sched = cmbpagibigSched.SelectedIndex;
                _payrollgroup.Pagibig = decimal.Parse(txtpagibigShare.Text);

                _ipayrollgroup.ManagePayrollGroup(_payrollgroup, _mode);

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

        private void btnadd_Click(object sender, EventArgs e)
        {
            _mode = 0;
            InitializeForm();
            EnableForm(false);
            EnableButton(false);
            lsvloantype.Enabled = false;

            txtdescription.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtdescription.Text == "")
            {
                btxMsg.ShowBalloon(txtdescription);
                txtdescription.Focus();
                return;
            }
            _mode = 1;
            EnableForm(false);
            EnableButton(false);
            lsvloantype.Enabled = false;

            txtdescription.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtdescription.Text == "")
            {
                btxMsg.ShowBalloon(txtdescription);
                //MessageBox.Show("Adjustment cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescription.Focus();
                return;
            }
            ManageRecord();

            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvloantype.Enabled = true;

            DisplayRecord();
        }

        private void btncancel_Click(object sender, EventArgs e)
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
