using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.Model;
using CAL.Global;

using DCLGlobal.Classes;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeLoanPaymentForm : Form
    {
        int _loanid;
        int _id;
        int _empid;
        int _mode;
        public EmployeeLoanPaymentForm(int _LOANID)
        {
            InitializeComponent();
            _loanid = _LOANID;
            LoadLoanPaymentType(cboPaymentType);
        }

        void LoadLoanPaymentType(ComboBox _cbo)
        {
            _cbo.DataSource = null;
            iLoanPaymentType _iloanpaymenttype = new HURISRepository.rLoanPaymentType();
            List<Loan_Payment_Type> _obj = _iloanpaymenttype.GetLoanPaymentTypes("");

            _cbo.DataSource = _obj;
            _cbo.DisplayMember = "Payment_type_desc";
            _cbo.ValueMember = "id";
        }
        void DisplayLoanPayment()
        {
            iLoan _iemployeeloanmaster = new IHOPSTransactionRepository.rLoan();
            dgvLoan.RowCount = 0;
            int n;

            try
            {
                iEmployeeLoanPayment _iemployeeloanpayment = new HURISRepository.rEmployeeLoanPayment();
                List<EmployeeLoanPayment> _employeeloanpayment = _iemployeeloanpayment.GetEmployeeLoanPayments(_loanid);

                if (_employeeloanpayment != null)
                {
                    foreach (EmployeeLoanPayment _list in _employeeloanpayment)
                    {
                        n = dgvLoan.Rows.Add();
                        dgvLoan.Rows[n].Cells[0].Value = _list.id.ToString();
                        dgvLoan.Rows[n].Cells[1].Value = _list.Loan_Payment_Type.Payment_type_desc;
                        dgvLoan.Rows[n].Cells[2].Value = _list.Payment_Date;
                        dgvLoan.Rows[n].Cells[3].Value = _list.Amount;
                        dgvLoan.Rows[n].Cells[4].Value = _list.OR_No;
                        dgvLoan.Rows[n].Cells[5].Value = _list.Remarks;
                        dgvLoan.Rows[n].Cells[6].Value = _list.Loan_ID;
                        dgvLoan.Rows[n].Cells[7].Value = _list.Emp_ID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayLoanInfo()
        {
            iLoan _iloan = new IHOPSTransactionRepository.rLoan();
            EmployeeLoanMaster _loan = _iloan.GetLoan(_loanid);

            try
            {
                if (_loan != null)
                {
                    txtEmpName.Text = _loan.Employee.Lastname + ", " + _loan.Employee.Firstname + " " + _loan.Employee.Middlename.Substring(0, 1) + ".";
                    txtLoanType.Text = _loan.LoanType.LoanType_Desc;
                    txtLoanAmount.Text = _loan.LoanAmount.ToString();
                    txtAmortization.Text = _loan.Amortization.ToString();
                    txtBalance.Text = _loan.Balance.ToString();
                    dtLoanDate.Value = _loan.DateLoan.Value.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeLoanPaymentForm_Load(object sender, EventArgs e)
        {
            DisplayLoanInfo();
            DisplayLoanPayment();
            EnableForm(false);
            EnableButton(true);
        }

        void EnableForm(bool _cond)
        {
            cboPaymentType.Enabled = _cond;
            dtPaymentDate.Enabled = _cond;
            txtAmount.ReadOnly = !_cond;
            txtORNo.ReadOnly = !_cond;
            txtPaymentRemarks.ReadOnly = !_cond;
        }
        void EnableButton(bool _cond)
        {
            Edit_btn.Enabled = _cond;
            delete_btn.Enabled = _cond;
            Save_btn.Enabled = !_cond;           
        }

        private void dgvLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = int.Parse(dgvLoan.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployeeLoanPayment _iemployeeloanpayment = new HURISRepository.rEmployeeLoanPayment();
            EmployeeLoanPayment _loanpayment = _iemployeeloanpayment.GetEmployeeLoanPayment(_id);

            if (_loanpayment != null)
            {
                cboPaymentType.SelectedValue = _loanpayment.Paymenttype_ID;
                dtPaymentDate.Value = _loanpayment.Payment_Date;
                txtAmount.Text = _loanpayment.Amount.ToString();
                txtORNo.Text = _loanpayment.OR_No;
                txtPaymentRemarks.Text = _loanpayment.Remarks;
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Please select payment record to edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EnableButton(false);
            EnableForm(true);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save loan payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            if (cboPaymentType.Text == "")
            {
                MessageBox.Show("Please select payment type.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPaymentType.Focus();
                return;
            }
            else if (txtAmount.Text == "")
            {
                btxMsg.ShowBalloon(txtAmount);
                txtAmount.Focus();
                return;
            }
            _mode = 2;
            ManageLoanPayment();
            DisplayLoanInfo();
            DisplayLoanPayment();
        }

        void ManageLoanPayment()
        {
            iEmployeeLoanPayment _iemployeeloanpayment = new HURISRepository.rEmployeeLoanPayment();
            EmployeeLoanPayment _employeeloanpayment = new EmployeeLoanPayment();
            try
            {
                _employeeloanpayment.Loan_ID = _loanid;
                _employeeloanpayment.Emp_ID = _empid;
                _employeeloanpayment.Paymenttype_ID = int.Parse(cboPaymentType.SelectedValue.ToString());
                _employeeloanpayment.Amount = decimal.Parse(txtAmount.Text);
                _employeeloanpayment.Payment_Date = dtPaymentDate.Value.Date;
                _employeeloanpayment.OR_No = txtORNo.Text;
                _employeeloanpayment.Remarks = txtPaymentRemarks.Text;
                _employeeloanpayment.UserID = LoginUser.userid;
                _employeeloanpayment.id = _id;

                _iemployeeloanpayment.ManageEmployeeLoanPayment(_employeeloanpayment, _mode);


                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Loan payment successfully saved."); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 3, "Loan payment successfully deleted."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {            
            if (_id == 0)
            {
                MessageBox.Show("Please select payment record to edit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete loan payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _mode = 3;
            ManageLoanPayment();
            DisplayLoanPayment();
        }
    }
    
}
