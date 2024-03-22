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
    public partial class SSS_Table_Form : Form
    {
        int _id = 0;
        public SSS_Table_Form()
        {
            InitializeComponent();
        }

        private void SSS_Table_Form_Load(object sender, EventArgs e)
        {
            DisplaySSSTable();
        }
        void EnableForm(bool _cond)
        {
            lsvH.Enabled = _cond;
        }
        void DisplaySSSTable()
        {
            iSSS _isss = new IHOPSFilesRepository.rSSS();
            List<SSS_Table> _sss = _isss.GetSSSTables();
            lsvH.Items.Clear();

            try
            {
                if(_sss != null)
                {
                    foreach(SSS_Table _x in _sss)
                    {
                        ListViewItem _item = new ListViewItem(_x.Range_From.ToString());
                        _item.SubItems.Add(_x.Range_To.ToString());
                        _item.SubItems.Add(_x.Monthly_Salary.ToString());
                        _item.SubItems.Add(_x.SS_ER.ToString());
                        _item.SubItems.Add(_x.SS_EE.ToString());
                        _item.SubItems.Add(_x.SS_Total.ToString());
                        _item.SubItems.Add(_x.ER.ToString());
                        _item.SubItems.Add(_x.TC_ER.ToString());
                        _item.SubItems.Add(_x.TC_EE.ToString());
                        _item.SubItems.Add(_x.TC_Total.ToString());
                        _item.SubItems.Add(_x.Total_Contribution.ToString());
                        _item.SubItems.Add(_x.id.ToString());

                        lsvH.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lsvH_DoubleClick(object sender, EventArgs e)
        {
            EnableForm(false);
            if (lsvH.SelectedItems.Count == 0) { return; }
            try
            {
                panDetails.Visible = true;
                panDetails.BringToFront();

                _id = int.Parse(lsvH.SelectedItems[0].SubItems[11].Text);

                DisplayInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayInfo()
        {
            iSSS _isss = new IHOPSFilesRepository.rSSS();
            SSS_Table _sss = _isss.GetSSSTable(_id);
            try
            {
                if (_sss != null)
                {
                    nudRangeFrom.Text = _sss.Range_From.ToString();
                    nudRangeTo.Text = _sss.Range_To.ToString();
                    nudMonthlySalary.Text = _sss.Monthly_Salary.ToString();
                    nudSS_ER.Value = decimal.Parse(_sss.SS_ER.ToString());
                    nudSS_EE.Value = decimal.Parse(_sss.SS_EE.ToString());
                    nudSSTotal.Value = decimal.Parse(_sss.SS_Total.ToString());
                    nudER.Value = decimal.Parse(_sss.ER.ToString());
                    nudTC_ER.Value = decimal.Parse(_sss.TC_ER.ToString());
                    nudTC_EE.Value = decimal.Parse(_sss.TC_EE.ToString());
                    nudTC_Total.Value = decimal.Parse(_sss.TC_Total.ToString());
                    nudTotalContri.Value = decimal.Parse(_sss.Total_Contribution.ToString());
                    _id = _sss.id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManageSSSTable()
        {
            iSSS _isss = new IHOPSFilesRepository.rSSS();
            SSS_Table _sss = new SSS_Table();

            try
            {
                if (nudRangeFrom.Value == 0) { nudRangeFrom.Value = 0; }
                if (nudRangeTo.Value == 0) { nudRangeTo.Value = 0; }
                if (nudMonthlySalary.Value == 0) { nudMonthlySalary.Value = 0; }
                if (nudSS_ER.Value == 0) { nudSS_ER.Value = 0; }
                if (nudSS_EE.Value == 0) { nudSS_EE.Value = 0; }
                if (nudSSTotal.Value == 0) { nudSSTotal.Value = 0; }
                if (nudER.Value == 0) { nudER.Value = 0; }

                _sss.Range_From = nudRangeFrom.Value;
                _sss.Range_To = nudRangeTo.Value;
                _sss.Monthly_Salary = nudMonthlySalary.Value;
                _sss.SS_ER = nudSS_ER.Value;
                _sss.SS_EE = nudSS_EE.Value;
                _sss.SS_Total = nudSSTotal.Value;
                _sss.ER = nudER.Value;
                _sss.TC_ER = nudTC_ER.Value;
                _sss.TC_EE = nudTC_EE.Value;
                _sss.TC_Total = nudTC_Total.Value;
                _sss.Total_Contribution = nudTotalContri.Value;
                _sss.id = _id;

                _id = _isss.ManageSSSTable(_sss);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update SSS table?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManageSSSTable();

            DisplaySSSTable();
            ToolsControl.CallShowNotification(this, 1, "Record successfully save.");
            EnableForm(true);
            panDetails.Visible = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            panDetails.Visible = false;
            panDetails.SendToBack();
        }
        private void nudSS_ER_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (nudSS_ER.Value == 0) { nudSS_ER.Value = 0; }
                if (nudSS_EE.Value == 0) { nudSS_EE.Value = 0; }

                decimal _ssstotal;

                _ssstotal = nudSS_EE.Value + nudSS_ER.Value;

                nudSSTotal.Text = _ssstotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void nudER_ValueChanged(object sender, EventArgs e)
        {
            nudSS_ER_ValueChanged(sender, e);
        }
        private void nudTC_ER_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (nudTC_ER.Value == 0) { nudTC_ER.Value = 0; }
                if (nudTC_EE.Value == 0) { nudTC_EE.Value = 0; }

                decimal _tcTotal;
                decimal _totalContri;
                decimal _tcER;

                _tcTotal = nudTC_ER.Value + nudTC_EE.Value;
                nudTC_Total.Value = _tcTotal;

                _tcER = decimal.Parse(txtTC_ER.Text);

                _totalContri = nudTC_Total.Value - nudTC_ER.Value;
                nudTotalContri.Value = _totalContri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void BGChnager(object _Object, int _Cond)
        {
            if (_Cond == 1)
            {
                //Color.LightBlue = BackColor
            }
            else
            {
                //Color.White = BackColor
            }
        }

        private void nudSS_ER_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (nudSS_ER.Value == 0) { nudSS_ER.Value = 0; }
                if (nudSS_EE.Value == 0) { nudSS_EE.Value = 0; }

                decimal _ssstotal;

                _ssstotal = nudSS_EE.Value + nudSS_ER.Value;

                nudSSTotal.Text = _ssstotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudER_KeyDown(object sender, KeyEventArgs e)
        {
            nudSS_ER_KeyDown(sender, e);
        }

        private void nudTC_ER_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (nudTC_ER.Value == 0) { nudTC_ER.Value = 0; }
                if (nudTC_EE.Value == 0) { nudTC_EE.Value = 0; }

                decimal _tcTotal;
                decimal _totalContri;
                decimal _tcER;

                _tcTotal = nudTC_ER.Value + nudTC_EE.Value;
                nudTC_Total.Value = _tcTotal;

                _tcER = decimal.Parse(txtTC_ER.Text);

                _totalContri = nudTC_Total.Value - nudTC_ER.Value;
                nudTotalContri.Value = _totalContri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
