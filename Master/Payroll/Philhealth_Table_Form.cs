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
    public partial class Philhealth_Table_Form : Form
    {
        int _SalaryBracket = 0;

        public Philhealth_Table_Form()
        {
            InitializeComponent();
        }

        private void Philhealth_Table_Form_Load(object sender, EventArgs e)
        {
            DisplyaPhilhealthTable();
        }

        void EnableForm(bool _cond)
        {
            lsvH.Enabled = _cond;
        }

        void DisplyaPhilhealthTable()
        {
            iPhilHealth _iphilhealth = new IHOPSFilesRepository.rPhilHealth();
            List<Philhealth_Table> _tax = (from d in _iphilhealth.GetPhilHealthTables() orderby d.Salary_Bracket ascending select d).ToList();
            lsvH.Items.Clear();
            try
            {
                if(_tax !=null)
                {
                    foreach (Philhealth_Table _x in _tax)
                    {
                        ListViewItem _item = new ListViewItem(_x.Salary_Bracket.ToString());
                        _item.SubItems.Add(_x.Salary_From.ToString());
                        _item.SubItems.Add(_x.Salary_to.ToString());
                        _item.SubItems.Add(_x.Salary_Base.ToString());
                        _item.SubItems.Add(_x.Total_monthly.ToString());
                        _item.SubItems.Add(_x.Employee_share.ToString());
                        _item.SubItems.Add(_x.Employer_Share.ToString());

                        lsvH.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayInfo()
        {
            iPhilHealth _iphilhealth = new IHOPSFilesRepository.rPhilHealth();
            Philhealth_Table _philhealth = _iphilhealth.GetPhilhealthTable(_SalaryBracket);
            try
            {
                if (_philhealth != null)
                {
                    nudSalaryFrom.Value = _philhealth.Salary_From.Value;
                    nudSalaryTo.Value = _philhealth.Salary_to.Value;
                    nudSalarybase.Value = _philhealth.Salary_Base.Value;
                    nudMonthlyBase.Value = _philhealth.Total_monthly.Value;
                    nudEmployeeShare.Value = _philhealth.Employee_share.Value;
                    nudEmployerShare.Value = _philhealth.Employer_Share.Value;
                    _SalaryBracket = _philhealth.Salary_Bracket;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManagePhilhealthTable()
        {
            iPhilHealth _iphilhealth = new IHOPSFilesRepository.rPhilHealth();
            Philhealth_Table _philhealth = new Philhealth_Table();

            try
            {
                _philhealth.Salary_From = nudSalaryFrom.Value;
                _philhealth.Salary_to = nudSalaryTo.Value;
                _philhealth.Salary_Base = nudSalarybase.Value;
                _philhealth.Total_monthly = nudMonthlyBase.Value;
                _philhealth.Employee_share = nudEmployeeShare.Value;
                _philhealth.Employer_Share = nudEmployerShare.Value;
                _philhealth.Salary_Bracket = _SalaryBracket;

                _SalaryBracket = _iphilhealth.ManagePhilHealthTable(_philhealth);
                
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

                _SalaryBracket = int.Parse(lsvH.SelectedItems[0].SubItems[0].Text);

                DisplayInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Update Philhealth table?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            ManagePhilhealthTable();

            DisplyaPhilhealthTable();
            ToolsControl.CallShowNotification(this, 1, "Record successfully save.");
            EnableForm(true);
            panDetails.Visible = false;
            panDetails.SendToBack();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            panDetails.Visible = false;
            panDetails.SendToBack();
        }
    }
}
