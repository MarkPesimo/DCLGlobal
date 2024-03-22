using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.TRANSACTION.Repository;
using CAL.TRANSACTION.Interface;
using CAL.MASTER.Repository;
using CAL.MASTER.Interface;
using DCLGlobal.Classes;

namespace DCLGlobal.Master.Employee
{
    public partial class TaxWithheldform : Form
    {
        int _empid;
        int _mode;
        int _id;
        ToolsControl _tool = new ToolsControl();
        public TaxWithheldform(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void TaxWithheldform_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayList();
                DisplayRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayList()
        {
            iPayrollPreviousCompany _ibranch = new IHOPSFilesRepository.rPayrollPreviousCompany();
            List<CAL.Model.PayrollPreviousCompany> _branch = _ibranch.GetPreviousCompanies(_empid);

            try
            {
                lvSearch.Items.Clear();
                if (_branch != null)
                {
                    foreach(CAL.Model.PayrollPreviousCompany _list in _branch)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.Calendar_Year.ToString());

                       lvSearch.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayRecord()
        {
            iPayrollPreviousCompany _ibranch = new IHOPSFilesRepository.rPayrollPreviousCompany();
            // CAL.Model.PayrollPreviousCompany _data = new CAL.Model.PayrollPreviousCompany();
            CAL.Model.PayrollPreviousCompany _data = _ibranch.GetPreviousCompany(_id, _empid);
            try
            {
                if(_data != null)
                {
                    _id = _data.id;
                    txtEmployeeName.Text = _data.Employee.Lastname + ", " + _data.Employee.Firstname;
                    txtYear.Text = _data.Calendar_Year.ToString();

                    txtEmployerName.Text = _data.Employer_name;
                    txtEmployerTinno.Text = _data.Employer_Tinno;

                    if (_data.date_from != null)
                    {
                        dtpfrom.Checked = true;
                        dtpfrom.Value = _data.date_from.Value;
                    }
                    else
                    {
                        dtpfrom.Checked = false;
                    }
                    if(_data.date_to !=null)
                    {
                        dtpto.Checked = true;
                        dtpto.Value = _data.date_to.Value;
                    }
                    else
                    {
                        dtpto.Checked = false;
                    }

                    txtGrossCompensationIncomeFromPresent.Text = _data.Gross_Compensation_Income_from_Present_Employer.ToString();
                    txtLessTotalNonTaxable.Text = _data.Less_Total_Non_Taxable.ToString();
                    txtTaxableCompensationIncomeFromPresentEmployer.Text = _data.Taxable_Compensation_Income.ToString();
                    txtAddTaxableCompensationIncomefromPreviousEmployer.Text = _data.Add_Taxable_Compensation_Income.ToString();
                    txtGrossTaxableCompensationIncome.Text = _data.Gross_Taxable_Compensation_Income.ToString();
                    txtLessTotalExemption.Text = _data.Less_Total_Exemptions.ToString();
                    txtLessPremiumPaidOnHealth.Text = _data.Less_Premium_Paid_On_Health.ToString();
                    txtNetTaxableCompensationIncome.Text = _data.Net_Taxable_Compensation_Income.ToString();
                    txtTaxDue.Text = _data.Tax_Due.ToString();
                    txtAmountofTaxedWithheldPresentEmployer.Text = _data.Amount_of_Taxes_Withheld_Present.ToString();
                    txtAmountofTaxesWithheldPreviousEmployer.Text = _data.Amount_of_Taxes_Withheld_Previous.ToString();
                    txtTotalAmountofTaxedWithheldasAdjusted.Text = _data.Total_Amount_of_Taxes_Withheld.ToString();

                    txtNT_BasicSalary.Text = _data.NT_Basic_Salary.ToString();
                    txtNT_HolidayPay.Text = _data.NT_Holiday_Pay.ToString();
                    txtNT_OvertimePAy.Text = _data.NT_Overtime_Pay.ToString();
                    txtNT_NightShiftDifferential.Text = _data.NT_Night_Shift_Differential.ToString();
                    txtNT_HazardPay.Text = _data.NT_Hazard_Pay.ToString();
                    txtNT_13thMonthPay.Text = _data.NT_13th_Month_Pay.ToString();
                    txtNT_DeMinimis.Text = _data.NT_De_Minimis_Benefits.ToString();
                    txtNT_GovernmentPremiums.Text = _data.NT_Government_Premiums.ToString();
                    txtNT_SalariesandOtherformsofCompensation.Text = _data.NT_Salaries_and_Other.ToString();
                    txtNT_TotalNottaxableCompensationIncome.Text = _data.NT_Total_Non_Taxable.ToString();

                    txtT_BasicSalary.Text = _data.T_Basic_Salary.ToString();
                    txtT_Representation.Text = _data.T_Representation.ToString();
                    txtT_Transaportation.Text = _data.T_Transportation.ToString();
                    txtT_CostofLivingALlowance.Text = _data.T_Cost_Of_Living_Allowance.ToString();
                    txtT_FixeHousingAllowance.Text = _data.T_Fixed_Housing_Allowance.ToString();
                    txtT_Others.Text = _data.T_Others.ToString();

                    txtTS_Commission.Text = _data.T_Commision.ToString();
                    txtTS_ProfitSharing.Text = _data.T_Profit_Sharing.ToString();
                    txtTS_FessIncludingDirectorsFees.Text = _data.T_Fees_Including_Directorss_Fees.ToString();
                    txtTS_Taxable13thMonthPay.Text = _data.T_13th_Month_Pay.ToString();
                    txtTS_HazardPay.Text = _data.T_Hazard_Pay.ToString();
                    txtTS_OvertimePay.Text = _data.T_Overtime_Pay.ToString();
                    txtTS_Others.Text = _data.t_Others2.ToString();
                    txtTS_TotalTaxableCompensationIncome.Text = _data.T_Total_Taxable.ToString();

                    txtGross.Text = _data.Gross_amount.ToString();
                    txtTax.Text = _data.Tax_Withheld.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void InitializeForm()
        {
            _id = 0;

            txtYear.Text = DateTime.Now.Year.ToString();
            txtEmployerName.Text = "";
            txtEmployerTinno.Text = "";


            txtGrossCompensationIncomeFromPresent.Text = "0";
            txtLessTotalNonTaxable.Text = "0";
            txtTaxableCompensationIncomeFromPresentEmployer.Text = "0";
            txtAddTaxableCompensationIncomefromPreviousEmployer.Text = "0";
            txtGrossTaxableCompensationIncome.Text = "0";
            txtLessTotalExemption.Text = "0";
            txtLessPremiumPaidOnHealth.Text = "0";
            txtNetTaxableCompensationIncome.Text = "0";
            txtTaxDue.Text = "0";
            txtAmountofTaxedWithheldPresentEmployer.Text = "0";
            txtAmountofTaxesWithheldPreviousEmployer.Text = "0";
            txtTotalAmountofTaxedWithheldasAdjusted.Text = "0";


            txtNT_BasicSalary.Text = "0";
            txtNT_HolidayPay.Text = "0";
            txtNT_OvertimePAy.Text = "0";
            txtNT_NightShiftDifferential.Text = "0";
            txtNT_HazardPay.Text = "0";
            txtNT_13thMonthPay.Text = "0";
            txtNT_DeMinimis.Text = "0";
            txtNT_GovernmentPremiums.Text = "0";
            txtNT_SalariesandOtherformsofCompensation.Text = "0";
            txtNT_TotalNottaxableCompensationIncome.Text = "0";


            txtT_BasicSalary.Text = "0";
            txtT_Representation.Text = "0";
            txtT_Transaportation.Text = "0";
            txtT_CostofLivingALlowance.Text = "0";
            txtT_FixeHousingAllowance.Text = "0";
            txtT_Others.Text = "0";


            txtTS_Commission.Text = "0";
            txtTS_ProfitSharing.Text = "0";
            txtTS_FessIncludingDirectorsFees.Text = "0";
            txtTS_Taxable13thMonthPay.Text = "0";
            txtTS_HazardPay.Text = "0";
            txtTS_OvertimePay.Text = "0";
            txtTS_Others.Text = "0";
            txtTS_TotalTaxableCompensationIncome.Text = "0";


            txtGross.Text = "0";
            txtTax.Text = "0";

        }
        void EnableForm(bool _cond)
        {
            txtYear.ReadOnly = !_cond;
            txtEmployerName.ReadOnly = !_cond;
            txtEmployerTinno.ReadOnly = !_cond;

            dtpfrom.Enabled = _cond;
            dtpto.Enabled = _cond;

            txtGrossCompensationIncomeFromPresent.ReadOnly = !_cond;
            txtLessTotalNonTaxable.ReadOnly = !_cond;
            txtTaxableCompensationIncomeFromPresentEmployer.ReadOnly = !_cond;
            txtAddTaxableCompensationIncomefromPreviousEmployer.ReadOnly = !_cond;
            txtGrossTaxableCompensationIncome.ReadOnly = !_cond;
            txtLessTotalExemption.ReadOnly = !_cond;
            txtLessPremiumPaidOnHealth.ReadOnly = !_cond;
            txtNetTaxableCompensationIncome.ReadOnly = !_cond;
            txtTaxDue.ReadOnly = !_cond;
            txtAmountofTaxedWithheldPresentEmployer.ReadOnly = !_cond;
            txtAmountofTaxesWithheldPreviousEmployer.ReadOnly = !_cond;
            txtTotalAmountofTaxedWithheldasAdjusted.ReadOnly = !_cond;

            txtNT_BasicSalary.ReadOnly = !_cond;
            txtNT_HolidayPay.ReadOnly = !_cond;
            txtNT_OvertimePAy.ReadOnly = !_cond;
            txtNT_NightShiftDifferential.ReadOnly = !_cond;
            txtNT_HazardPay.ReadOnly = !_cond;
            txtNT_13thMonthPay.ReadOnly = !_cond;
            txtNT_DeMinimis.ReadOnly = !_cond;
            txtNT_GovernmentPremiums.ReadOnly = !_cond;
            txtNT_SalariesandOtherformsofCompensation.ReadOnly = !_cond;
            txtNT_TotalNottaxableCompensationIncome.ReadOnly = !_cond;

            txtT_BasicSalary.ReadOnly = !_cond;
            txtT_Representation.ReadOnly = !_cond;
            txtT_Transaportation.ReadOnly = !_cond;
            txtT_CostofLivingALlowance.ReadOnly = !_cond;
            txtT_FixeHousingAllowance.ReadOnly = !_cond;
            txtT_Others.ReadOnly = !_cond;

            txtTS_Commission.ReadOnly = !_cond;
            txtTS_ProfitSharing.ReadOnly = !_cond;
            txtTS_FessIncludingDirectorsFees.ReadOnly = !_cond;
            txtTS_Taxable13thMonthPay.ReadOnly = !_cond;
            txtTS_HazardPay.ReadOnly = !_cond;
            txtTS_OvertimePay.ReadOnly = !_cond;
            txtTS_Others.ReadOnly = !_cond;
            txtTS_TotalTaxableCompensationIncome.ReadOnly = !_cond;

            txtGross.ReadOnly = !_cond;
            txtTax.ReadOnly = !_cond;

            pan_Search.Enabled = !_cond;
        }
        void EnableButton(bool _cond)
        {
            add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }
        private void lvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvSearch.SelectedItems.Count == 0) { return; }
            iPayrollPreviousCompany _ibranch = new IHOPSFilesRepository.rPayrollPreviousCompany();

            _id = int.Parse(lvSearch.SelectedItems[0].Text.ToString());
            DisplayRecord();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            InitializeForm();
            EnableForm(true);
            EnableButton(false);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if(_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);
                txtYear.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManageRecord()
        {
            iPayrollPreviousCompany _ibranch = new IHOPSFilesRepository.rPayrollPreviousCompany();
            CAL.Model.PayrollPreviousCompany _data = new CAL.Model.PayrollPreviousCompany();
            try
            {
                _data.id = _id;
                _data.emp_id = _empid;
                _data.Calendar_Year = int.Parse(txtYear.Text.ToString());
                _data.Gross_amount = decimal.Parse(txtGross.Text.ToString());
                _data.Tax_Withheld = decimal.Parse(txtTax.Text.ToString());
                _data.Employer_name = txtEmployerName.Text;
                _data.Employer_Tinno = txtEmployerTinno.Text;

                _data.Gross_Compensation_Income_from_Present_Employer = decimal.Parse(txtGrossCompensationIncomeFromPresent.Text.ToString());
                _data.Less_Total_Non_Taxable = decimal.Parse(txtLessTotalNonTaxable.Text.ToString());
                _data.Taxable_Compensation_Income = decimal.Parse(txtTaxableCompensationIncomeFromPresentEmployer.Text.ToString());
                _data.Add_Taxable_Compensation_Income = decimal.Parse(txtAddTaxableCompensationIncomefromPreviousEmployer.Text.ToString());
                _data.Gross_Taxable_Compensation_Income = decimal.Parse(txtGrossTaxableCompensationIncome.Text.ToString());
                _data.Less_Total_Exemptions = decimal.Parse(txtLessTotalExemption.Text.ToString());
                _data.Less_Premium_Paid_On_Health = decimal.Parse(txtLessPremiumPaidOnHealth.Text.ToString());
                _data.Net_Taxable_Compensation_Income = decimal.Parse(txtNetTaxableCompensationIncome.Text.ToString());
                _data.Tax_Due = decimal.Parse(txtTaxDue.Text.ToString());
                _data.Amount_of_Taxes_Withheld_Present = decimal.Parse(txtAmountofTaxedWithheldPresentEmployer.Text.ToString());
                _data.Amount_of_Taxes_Withheld_Previous = decimal.Parse(txtAmountofTaxesWithheldPreviousEmployer.Text.ToString());
                _data.Total_Amount_of_Taxes_Withheld = decimal.Parse(txtTotalAmountofTaxedWithheldasAdjusted.Text.ToString());

                _data.NT_Basic_Salary = decimal.Parse(txtNT_BasicSalary.Text.ToString());
                _data.NT_Holiday_Pay = decimal.Parse(txtNT_HolidayPay.Text.ToString());
                _data.NT_Overtime_Pay = decimal.Parse(txtNT_OvertimePAy.Text.ToString());
                _data.NT_Night_Shift_Differential = decimal.Parse(txtNT_NightShiftDifferential.Text.ToString());
                _data.NT_Hazard_Pay = decimal.Parse(txtNT_HazardPay.Text.ToString());
                _data.NT_13th_Month_Pay = decimal.Parse(txtNT_13thMonthPay.Text.ToString());
                _data.NT_De_Minimis_Benefits = decimal.Parse(txtNT_DeMinimis.Text.ToString());
                _data.NT_Government_Premiums = decimal.Parse(txtNT_GovernmentPremiums.Text.ToString());
                _data.NT_Salaries_and_Other = decimal.Parse(txtNT_SalariesandOtherformsofCompensation.Text.ToString());
                _data.NT_Total_Non_Taxable = decimal.Parse(txtNT_TotalNottaxableCompensationIncome.Text.ToString());

                _data.T_Basic_Salary = decimal.Parse(txtT_BasicSalary.Text.ToString());
                _data.T_Representation = decimal.Parse(txtT_Representation.Text.ToString());
                _data.T_Transportation = decimal.Parse(txtT_Transaportation.Text.ToString());
                _data.T_Cost_Of_Living_Allowance = decimal.Parse(txtT_CostofLivingALlowance.Text.ToString());
                _data.T_Fixed_Housing_Allowance = decimal.Parse(txtT_FixeHousingAllowance.Text.ToString());
                _data.T_Others = decimal.Parse(txtT_Others.Text.ToString());

                _data.T_Commision = decimal.Parse(txtTS_Commission.Text.ToString());
                _data.T_Profit_Sharing = decimal.Parse(txtTS_ProfitSharing.Text.ToString());
                _data.T_Fees_Including_Directorss_Fees = decimal.Parse(txtTS_FessIncludingDirectorsFees.Text.ToString());
                _data.T_13th_Month_Pay = decimal.Parse(txtTS_Taxable13thMonthPay.Text.ToString());
                _data.T_Hazard_Pay = decimal.Parse(txtTS_HazardPay.Text.ToString());
                _data.T_Overtime_Pay = decimal.Parse(txtTS_OvertimePay.Text.ToString());
                _data.t_Others2 = decimal.Parse(txtTS_Others.Text.ToString());
                _data.T_Total_Taxable = decimal.Parse(txtTS_TotalTaxableCompensationIncome.Text.ToString());

                _data.date_from = dtpfrom.Value;
                _data.date_to = dtpto.Value;

                _id = _ibranch.ManagePreviousCompany(_data, _mode);
                Cancel();

                if(_mode == 2)
                {
                    ToolsControl.CallShowNotification(this, 3, "Record successfully deleted.");
                }
                else
                {
                    ToolsControl.CallShowNotification(this, 1, "Record successfully save.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Cancel()
        {
            iPayrollPreviousCompany _ibranch = new IHOPSFilesRepository.rPayrollPreviousCompany();
            try
            {
                EnableForm(false);
                EnableButton(true);
                DisplayRecord();
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete selected record?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 2;
            ManageRecord();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if(txtYear.Text == "")
            {
                btxMsg.ShowBalloon(txtYear);
                txtYear.Focus();
                return;
            }
            ManageRecord();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
