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
using DCLGlobal.Reports.Employee;

using DevComponents.DotNetBar;

namespace DCLGlobal.Master.Payroll
{
    public partial class Adjustment_Master_Form : Form
    {
        int _mode = 0;
        int _id = 0;
        //string _labid;
        public Adjustment_Master_Form()
        {
            InitializeComponent();
        }

        private void Adjustment_Master_Form_Load(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            DisplayRecord();
        }

        void InitializeForm()
        {
            txtadjustment.Text = "";
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
            txtadjustment.ReadOnly = _cond;
            txtkeyword.ReadOnly = !_cond;
        }

        void DisplayRecord()
        {
            iAdjustment _iadjustment = new HURISRepository.rAdjustment();
            List<CAL.Model.Adjustment> _adjustment = _iadjustment.GetAdjustments(txtkeyword.Text);
            lsvadjustment.Items.Clear();
            try
            {
                if (_adjustment != null)
                {
                    foreach (Adjustment _x in _adjustment)
                    {
                        ListViewItem _item = new ListViewItem(_x.Adjustment_ID.ToString());
                        _item.SubItems.Add(_x.Adjustment_Desc);
                        lsvadjustment.Items.Add(_item);
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

        private void lsvadjustment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvadjustment.SelectedItems.Count == 0) { return;  }
            try
            {
                _id = int.Parse(lsvadjustment.SelectedItems[0].Text);
                txtadjustment.Text = lsvadjustment.SelectedItems[0].SubItems[1].Text;

                lsvadjustment.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageRecord()
        {
            iAdjustment _iadjustment = new HURISRepository.rAdjustment();
            Adjustment _adjustment = new Adjustment();

            try
            {
                _adjustment.Adjustment_ID = _id;
                _adjustment.Adjustment_Desc = txtadjustment.Text;

                _iadjustment.ManageAdjustment(_adjustment, _mode);


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
            
            txtadjustment.Focus();
            lsvadjustment.Enabled = false;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtadjustment.Text == "")
            {
                btxMsg.ShowBalloon(txtadjustment);
                txtadjustment.Focus();
                return;
            }
            else
            {
                _mode = 1;
                EnableForm(false);
                EnableButton(false);

                txtadjustment.Focus();
                lsvadjustment.Enabled = false;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this Record", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.No) { return;  }
            _mode = 2;
            ManageRecord();

            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvadjustment.Enabled = true;

            DisplayRecord();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtadjustment.Text == "")
            {
                btxMsg.ShowBalloon(txtadjustment);
                //MessageBox.Show("Adjustment cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtadjustment.Focus();
                return;
            }
            ManageRecord();

            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvadjustment.Enabled = true;

            DisplayRecord();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(true);
            lsvadjustment.Enabled = true;

            DisplayRecord();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            // if (ToolsControl.FunctionAccess(this, SystemModule.GLOBAL.Master.USER , Feature.Print, SystemModuleType.Masterfile) == false) { return; }
            lsvadjustment.Enabled = true;
        }


    }
}
