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
using System.IO;
using System.Data.Linq;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeLoanInfo : UserControl
    {
        EmployeeInfo _parent;
        int _mode = 0;
        int _loanid = 0;
        ToolsControl _tool = new ToolsControl();
        public EmployeeLoanInfo(EmployeeInfo _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
            LoadLoanType(cmbLoanType);
            LoadLoanPaymentType(cboPaymentType);
        }

        private void EmployeeLoanInfo_Load(object sender, EventArgs e)
        {
            DisplayLoanInfo();
            InitializeForm();
            EnableButton(true);
            EnableForm(true);
            chkAplySetup.Enabled = false;
        }

        void InitializeForm()
        {
            cmbLoanType.SelectedValue = 11;
            dtDateLoan.Value = DateTime.Now;
            txtBalance.Text = "";
            txtLoanAmnt.Text = "";
            txtMnthlyAmor.Text = "";
            txtDeductAmnt.Text = "";
            txtRemarks.Text = "";
            chkDeducStat.Checked = false;
            chkLoanStat.Checked = false;
            chkAplySetup.Checked = true;
            dtPaymentDate.Value = DateTime.Now;
        }
        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
            Print_btn.Enabled = _cond;
        }
        void EnableForm(bool _cond)
        {
            cmbLoanType.Enabled = !_cond;
            dtDateLoan.Enabled = !_cond;
            txtBalance.ReadOnly = _cond;
            txtLoanAmnt.ReadOnly = _cond;
            txtMnthlyAmor.ReadOnly = _cond;
            //txtDeductAmnt.ReadOnly = _cond;
            chkAplySetup.Enabled = !_cond;
            chkDeducStat.Enabled = !_cond;
            chkLoanStat.Enabled = !_cond;
            txtRemarks.ReadOnly = _cond;
        }
        void DisplayLoanInfo()
        {
            iLoan _iemployeeloanmaster = new IHOPSTransactionRepository.rLoan();
            dgvLoan.RowCount = 0;
            int n;

            try
            {
                //List<EmployeeLoanMaster> _employeeloanmaster = (from d in _iemployeeloanmaster.GetLoans(_parent._empid) where d.DeductStatus == true && d.LoanStat == true orderby d.DateLoan descending select d).ToList();
                List<EmployeeLoanMaster> _employeeloanmaster = (from d in _iemployeeloanmaster.GetLoans(_parent._empid) orderby d.DateLoan descending select d).ToList();
                if (_employeeloanmaster != null)
                {
                    foreach (EmployeeLoanMaster _x in _employeeloanmaster)
                    {
                        n = dgvLoan.Rows.Add();
                        dgvLoan.Rows[n].Cells[0].Value = _x.LoanID.ToString();
                        //dgvLoan.Rows[n].Cells[1].Value = "EDIT";
                        dgvLoan.Rows[n].Cells[1].Value = "DELETE";
                        dgvLoan.Rows[n].Cells[2].Value = "VIEW";
                        dgvLoan.Rows[n].Cells[3].Value = "ADD PAYMENT";
                        dgvLoan.Rows[n].Cells[4].Value = _x.LoanType.LoanType_Desc;
                        dgvLoan.Rows[n].Cells[5].Value = _x.DateLoan;
                        dgvLoan.Rows[n].Cells[6].Value = _x.LoanAmount;
                        dgvLoan.Rows[n].Cells[7].Value = _x.Balance;
                        dgvLoan.Rows[n].Cells[8].Value = _x.Amortization;
                        dgvLoan.Rows[n].Cells[9].Value = _x.DeductStatus;
                        dgvLoan.Rows[n].Cells[10].Value = _x.LoanStat;
                        dgvLoan.Rows[n].Cells[11].Value = _x.Remarks;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void panelLoan()
        {
            //LoadLoanType(cmbLoanType);

            if (_mode == 2)
            {
                //label1.Text = "Loan Information [Edit]";
                cmbLoanType.SelectedValue = 0;
                Displayloan();
            }
            else
            {
                //label1.Text = "Loan Information [Add]";
                InitializeForm();
            }
        }
        void LoadLoanType(ComboBox _cbo)
        {
            _cbo.DataSource = null;
            iLoan _iloantype = new IHOPSTransactionRepository.rLoan();
            List<LoanType> _obj = _iloantype.GetLoanType();

            _cbo.DataSource = _obj;
            _cbo.DisplayMember = "LoanType_Desc";
            _cbo.ValueMember = "LoanType_ID";
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

        void Displayloan()
        {
            iLoan _iloan = new IHOPSTransactionRepository.rLoan();
            EmployeeLoanMaster _loan = _iloan.GetLoan(_loanid);
            try
            {
                if (_loan != null)
                {
                    _loanid = _loan.LoanID;
                    _parent._empid = int.Parse(_loan.EmpID.ToString());
                    cmbLoanType.SelectedValue = _loan.LoanTypeID;
                    dtDateLoan.Value = Convert.ToDateTime(_loan.DateLoan);
                    txtBalance.Text = _loan.Balance.ToString();
                    txtLoanAmnt.Text = _loan.LoanAmount.ToString();
                    txtMnthlyAmor.Text = _loan.Amortization.ToString();
                    txtDeductAmnt.Text = _loan.DeductAmnt.ToString();
                    if (_loan.DeductStatus == true)
                    {
                        chkDeducStat.Checked = true;
                    }
                    else
                    {
                        chkDeducStat.Checked = false;
                    }
                    if (_loan.LoanStat == true)
                    {
                        chkLoanStat.Checked = true;
                    }
                    else
                    {
                        chkLoanStat.Checked = false;
                    }
                    txtRemarks.Text = _loan.Remarks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Add Loan?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            //panelManageLoan.Show();
            _mode = 1;
            //panelLoan();   
            InitializeForm();
            EnableButton(false);
            EnableForm(false);
            dgvLoan.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbLoanType.Text == "")
            {
                MessageBox.Show("Select Loan Type", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbLoanType.Focus();
                return;
            }
            else if (txtBalance.Text == "")
            {
                btxMsg.ShowBalloon(txtBalance);
                //MessageBox.Show("Balance cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBalance.Focus();
                return;
            }
            else if (txtLoanAmnt.Text == "")
            {
                btxMsg.ShowBalloon(txtLoanAmnt);
                //MessageBox.Show("Loan Amount cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanAmnt.Focus();
                return;
            }
            else if (txtMnthlyAmor.Text == "")
            {
                btxMsg.ShowBalloon(txtMnthlyAmor);
                //MessageBox.Show("Monthly Amortization cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMnthlyAmor.Focus();
                return;
            }
            else if (txtDeductAmnt.Text == "")
            {
                btxMsg.ShowBalloon(txtDeductAmnt);
                //MessageBox.Show("Deduction Amount cannot be blank", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDeductAmnt.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to save loan", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            }
            ManageLoan();
            //MessageBox.Show("Successfully saved!");

            DisplayLoanInfo();
            InitializeForm();
            EnableButton(true);
            EnableForm(true);
            dgvLoan.Enabled = true;
        }

        private void dgvLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.ColumnIndex == 1)
                //{
                //    _loanid = int.Parse(dgvLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                //    _mode = 2;

                //    panelManageLoan.Show();
                //panelLoan();
                //}
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure you want to delete this loan", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                    _loanid = int.Parse(dgvLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                    _mode = 3;
                    ManageLoan();
                    DisplayLoanInfo();
                }
                else if (e.ColumnIndex == 2)
                {
                    _loanid = int.Parse(dgvLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //iLoan _iloan = new IHOPSTransactionRepository.rLoan();
                    //List<LoanTransaction> _loandetails = _iloan.GetLoanDetails(_loanid);
                    //lsvledger.Items.Clear();

                    //if (_loandetails != null)
                    //{
                    //    foreach (LoanTransaction _x in _loandetails)
                    //    {
                    //        ListViewItem _item = new ListViewItem(_x.ID.ToString());
                    //        _item.SubItems.Add(_x.TransDate.Value.ToShortDateString());
                    //        _item.SubItems.Add(_x.Amount.ToString());

                    //        lsvledger.Items.Add(_item);
                    //    }
                    //}
                    iEmployeeLoanPayment _iemployeeloanpayment = new HURISRepository.rEmployeeLoanPayment();
                    List<USP_I_GET_EMPLOYEE_LOAN_PAYMENTResult> _loanpayments = _iemployeeloanpayment.GetEmployeeLoanPayments(_loanid, _parent._empid);
                    lsvledger.Items.Clear();

                    if (_loanpayments != null)
                    {
                        foreach (USP_I_GET_EMPLOYEE_LOAN_PAYMENTResult _list in _loanpayments)
                        {
                            ListViewItem _item = new ListViewItem(_list.Loan_id.ToString());
                            _item.SubItems.Add(_list.Payment_date.Value.ToShortDateString());
                            _item.SubItems.Add(string.Format("{0:###,##0.00}", Convert.ToDecimal(_list.Amount)));
                            _item.SubItems.Add(_list.Remarks);

                            lsvledger.Items.Add(_item);
                        }
                    }

                    panelledger.Show();
                    toolStrip2.Enabled = false;
                    panelManageLoan.Enabled = false;
                    dgvLoan.Enabled = false;
                }
                else if (e.ColumnIndex == 3)
                {
                    //panPayment.Visible = true;
                    //toolStrip2.Enabled = false;
                    //panelManageLoan.Enabled = false;
                    //dgvLoan.Enabled = false;
                    if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LOAN_PAYMENT, SystemModuleType.Masterfile) == false) { return; }
                    if (_tool.CheckFormAleadyOpen("AddLoanPaymentForm")) { return; }

                    AddLoanPaymentForm _addloanpayment = new AddLoanPaymentForm(_loanid, _parent._empid);
                    _addloanpayment.BringToFront();
                    _addloanpayment.Show();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            toolStrip2.Enabled = true;
            panelManageLoan.Enabled = true;
            dgvLoan.Enabled = true;

            panelledger.Visible = false;
            lsvledger.Items.Clear();
        }
        void ManageLoan()
        {
            iEmployeeLoanMaster _iemployeeloanmaster = new HURISRepository.rEmployeeLoanMaster();
            EmployeeLoanMaster _employeeloanmaster = new EmployeeLoanMaster();
            try
            {
                _employeeloanmaster.LoanID = _loanid;
                _employeeloanmaster.EmpID = _parent._empid;
                _employeeloanmaster.LoanTypeID = int.Parse(cmbLoanType.SelectedValue.ToString());
                _employeeloanmaster.DateLoan = dtDateLoan.Value;
                _employeeloanmaster.LoanAmount = decimal.Parse(txtLoanAmnt.Text);
                _employeeloanmaster.Balance = decimal.Parse(txtBalance.Text);
                _employeeloanmaster.Amortization = decimal.Parse(txtMnthlyAmor.Text);
                if(chkLoanStat.Checked == true)
                {
                    _employeeloanmaster.LoanStat = true;
                }
                else
                {
                    _employeeloanmaster.LoanStat = false;
                }
                if(chkDeducStat.Checked == true)
                {
                    _employeeloanmaster.DeductStatus = true;
                }
                else
                {
                    _employeeloanmaster.DeductStatus = false;
                }
                _employeeloanmaster.DeductAmnt = decimal.Parse(txtDeductAmnt.Text);
                _employeeloanmaster.Remarks = txtRemarks.Text;

                _iemployeeloanmaster.ManageEmployeeLoanMaster(_employeeloanmaster, _mode);


                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 3, "Adjustment successfully deleted."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if(txtLoanAmnt.Text == "")
            {
                btxMsg.ShowBalloon(txtLoanAmnt);
                txtLoanAmnt.Focus();
                return;
            }
            else
            {
                _mode = 2;
                DisplayLoanInfo();
                //InitializeForm();
                EnableButton(false);
                EnableForm(false);
                dgvLoan.Enabled = false;
            }
        }

        private void dgvLoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _loanid = int.Parse(dgvLoan.Rows[e.RowIndex].Cells[0].Value.ToString());
            Displayloan();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            DisplayLoanInfo();
            InitializeForm();
            EnableButton(true);
            EnableForm(true);
            dgvLoan.Enabled = true;
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            dgvLoan.Enabled = true;
        }

        private void chkAplySetup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAplySetup.Checked ==  true)
            {
                txtDeductAmnt.Enabled = false;
            }
            else
            {
                txtDeductAmnt.Enabled = true;
            }
        }

        private void save_loan_payment_btn_Click(object sender, EventArgs e)
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
            _mode = 1;
            ManageLoanPayment();
        }

        void ManageLoanPayment()
        {
            iEmployeeLoanPayment _iemployeeloanpayment = new HURISRepository.rEmployeeLoanPayment();
            EmployeeLoanPayment _employeeloanpayment = new EmployeeLoanPayment();
            try
            {
                _employeeloanpayment.Loan_ID = _loanid;
                _employeeloanpayment.Emp_ID = _parent._empid;
                _employeeloanpayment.Paymenttype_ID = int.Parse(cboPaymentType.SelectedValue.ToString());
                _employeeloanpayment.Amount = decimal.Parse(txtAmount.Text);
                _employeeloanpayment.Payment_Date = dtPaymentDate.Value.Date;
                _employeeloanpayment.OR_No = txtORNo.Text;
                _employeeloanpayment.Remarks = txtPaymentRemarks.Text;
                _employeeloanpayment.UserID = LoginUser.userid;

                _iemployeeloanpayment.ManageEmployeeLoanPayment(_employeeloanpayment, 1);


                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "Loan payment successfully saved."); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 3, "Loan payment successfully deleted."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_payment_btn_Click(object sender, EventArgs e)
        {
            panPayment.Visible = false;

            toolStrip2.Enabled = true;
            panelManageLoan.Enabled = true;
            dgvLoan.Enabled = true;
        }

    }
}
