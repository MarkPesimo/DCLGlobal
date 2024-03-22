using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DCLGlobal.Master.Main.Employee;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using DCLGlobal.Classes;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeePayrollInfocontrol : UserControl
    {        
        EmployeeInfo _parent;

        public EmployeePayrollInfocontrol(EmployeeInfo _Parent)
        {
            InitializeComponent();
            _parent = _Parent;    
        }
        private void EmployeePayrollInfocontrol_Load(object sender, EventArgs e)
        {
            DisplaySalaryInfo();
            EnableForm(true);
        }
        void EnableForm(bool _cond)
        {
            nudMonthlySal.ReadOnly = _cond;
            nudAllowance.ReadOnly = _cond;
            cmbExemption.Enabled = !_cond;
            nudAnualTaxEx.ReadOnly = _cond;
            nudAllowance.ReadOnly = _cond;
            nudCola.ReadOnly = _cond;
            txtAccntNo.ReadOnly = _cond;
            txtTIN.ReadOnly = _cond;
            txtCardNo.ReadOnly = _cond;

            nudRiceAllowance.ReadOnly = _cond;
            nudMealAllowance.ReadOnly = _cond;
            nudPagibig.ReadOnly = _cond;
            nudTax.ReadOnly = _cond;
            chkPagibig.Enabled = !_cond;
            chkTax.Enabled = !_cond;
            chkInclude.Enabled = !_cond;
            chkConfidential.Enabled = !_cond;
            numTaxPercentage.ReadOnly = _cond;
        }
        void EnableButton(bool _cond)
        {
            Edit_btn.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }
        void DisplaySalaryInfo()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            SP_DISPLAY_EMP_BASICINFOResult _employee = _iemployee.GetEmployeeInfo(_parent._empid, 0, "");
            try
            {
                if (_employee != null)
                {
                    nudRiceAllowance.Value = _employee.RiceAllowance;
                    nudMealAllowance.Value = _employee.MealAllowance;
                    nudMonthlySal.Value = _employee.MonthlySalary;
                    cmbExemption.SelectedItem = _employee.TaxExemption;
                    nudAnualTaxEx.Value = _employee.AnnualTax;
                    nudAllowance.Value = _employee.Allowance;
                    txtAccntNo.Text = _employee.ACCOUNTNO;
                    nudPagibig.Value = _employee.PAGIBIGCONT;
                    nudTax.Value = _employee.ManualTax;
                    txtTIN.Text = _employee.TIN;
                    nudCola.Value = _employee.Cola;

                    if (nudPagibig.Value == 0) { chkPagibig.Checked = false; } else { chkPagibig.Checked = true; }
                    if (nudTax.Value == 0) { chkTax.Checked = false; } else chkTax.Checked = true;

                    if (_employee.IsIncludePayroll != null)
                    {
                        chkInclude.Checked = Convert.ToBoolean(_employee.IsIncludePayroll);
                    }
                    else
                    {
                        chkInclude.Checked = false;
                    }

                    chkConfidential.Checked = _employee.is_confidential;
                    numTaxPercentage.Value = _employee.TAX_PERCENTAGE;
                    txtCardNo.Text = _employee.CARD_NO;
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            EnableForm(false);
            EnableButton(false);
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            EnableForm(true);
            EnableButton(true);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (nudMonthlySal.Value <= 0)
                //{
                //    MessageBox.Show("Invalid Monthly Salary amount info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    nudMonthlySal.Focus();
                //    return;
                //}
                //else if (cmbExemption.SelectedIndex <= 0)
                //{
                //    MessageBox.Show("Invalid Tax Exemption amount info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    cmbExemption.Focus();
                //    return;
                //}
                //else if (nudAnualTaxEx.Value <= 0)
                //{
                //    MessageBox.Show("Invalid Annual Tax Exemption amount info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    nudAnualTaxEx.Focus();
                //    return;
                //}
                //if (nudAllowance.Value <= 0)
                //{
                //    MessageBox.Show("Invalid Allowance amount info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    nudAllowance.Focus();
                //    return;
                //}
                //if (nudCola.Value <= 0)
                //{
                //    MessageBox.Show("Invalid COLA amount info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    nudCola.Focus();
                //    return;
                //}
                //else if(txtAccntNo.Text == "")
                //{
                //    MessageBox.Show("Invalid Account Number info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtAccntNo.Focus();
                //    return;
                //}

                //if (txtTIN.Text == "")
                //{
                //    MessageBox.Show("Invalid TIN  info. Please check your entry.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtTIN.Focus();
                //    return;
                //}

                if (MessageBox.Show("Are you sure you want to save?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                ManageSalary();
                //MessageBox.Show("Successfully Saved");
                DisplaySalaryInfo();
                EnableForm(true);
                EnableButton(true);
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageSalary()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            CAL.Model.Employee _employee = new CAL.Model.Employee();

            try
            {
                _employee.Emp_ID = _parent._empid;
                _employee.MonthlySalary = nudMonthlySal.Value;
                _employee.MealAllowance = nudMealAllowance.Value;
                _employee.RiceAllowance = nudRiceAllowance.Value;
                _employee.TaxExemption = cmbExemption.SelectedItem.ToString(); //textBox1.Text;//cmbExemption.SelectedText;
                _employee.AnnualTaxExcemp = nudAnualTaxEx.Value;
                _employee.Allowance = nudAllowance.Value;
                _employee.Account_no = txtAccntNo.Text;
                _employee.PagIbigCont = nudPagibig.Value;
                _employee.ManualTaxDed = nudTax.Value;
                _employee.Cola = nudCola.Value;
                _employee.Tax_no = txtTIN.Text;
                _employee.UserID = LoginUser.userid;
                _employee.IsIncludePayroll = chkInclude.Checked;
                _employee.is_confidential = chkConfidential.Checked;
                _employee.tax_percentage = numTaxPercentage.Value;
                _employee.card_no = txtCardNo.Text;

                _iemployee.ManageSalary(_employee);

                ToolsControl.CallShowNotification(this, 1, "Payroll information successfully save.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void chkConfidential_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (LoginUser.usertype.ToUpper() != "ADMIN")
        //    {
        //        MessageBox.Show("You have no access to tag employee as confidential.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        chkConfidential.Checked = false;
        //    }
        //}

        private void chkConfidential_Click(object sender, EventArgs e)
        {
            if (LoginUser.usertype.ToUpper() != "ADMIN")
            {
                MessageBox.Show("You have no access to tag employee as confidential.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                chkConfidential.Checked = false;
            }
        }

        private void chkConfidential_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfidential.Checked == true)
            {
                numTaxPercentage.Value = 10;
                numTaxPercentage.ReadOnly = false;
            }
            else
            {
                numTaxPercentage.Value = 0;
                numTaxPercentage.ReadOnly = true;
            }
        }
    }
}
