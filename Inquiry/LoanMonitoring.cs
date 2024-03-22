using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

using DCLGlobal.Classes;
using DCLGlobal.Reports.Employee;
using DCLGlobal.Master.Main.Employee;
using DCLGlobal.Inquiry;
using DCLGlobal.Master.Employee;

using CAL.Global;
using CAL.Model;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Inquiry
{
    public partial class LoanMonitoring : Form
    {
        ToolsControl _tool = new ToolsControl();
        bool _loading = true;
        bool _loan_status = false;
        int _loanid = 0;
        int _empid = 0;
        int _loantype_id = 0;
        int _loantypeid = 0;

        public LoanMonitoring()
        {
            InitializeComponent();

            GlobalToolsControl.HURIS.FillCboLoan(cboLoanType);

            cboLoanType.SelectedIndex = 0;
            cboSatus.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Parse("1/1/" + DateTime.Now.Year.ToString());
            dtpTo.Value = DateTime.Now;

            DisplayRecords();

            _loading = false;
        }

        void DisplayRecords()
        {
            iLoan _i = new IHOPSTransactionRepository.rLoan();

            dgvLoan.RowCount = 0;
            int n;
            prb.Value = 0;


            try
            {
                List<USP_H_GET_LOAN_MONITORINGResult> _list = _i.GetLoanMonitoring(chkLoanType.Checked,
                    int.Parse(cboLoanType.SelectedValue.ToString()),
                    chkLoandate.Checked,
                    dtpFrom.Value,
                    dtpTo.Value,
                    chkStatus.Checked,
                    cboSatus.Text,
                    txtKeyword.Text).ToList();
                prb.Maximum = _list.Count;

                if (_list.Count() > 0)
                {
                    foreach (USP_H_GET_LOAN_MONITORINGResult _loan in _list)
                    {
                        prb.Value = prb.Value + 1;

                        n = dgvLoan.Rows.Add();
                        dgvLoan.Rows[n].Cells[0].Value = _loan.id.ToString();
                        dgvLoan.Rows[n].Cells[1].Value = _loan.loan_type;
                        dgvLoan.Rows[n].Cells[2].Value = _loan.date_loan.Value.ToShortDateString();
                        dgvLoan.Rows[n].Cells[3].Value = _loan.company_name;
                        dgvLoan.Rows[n].Cells[4].Value = _loan.employee_name;

                        dgvLoan.Rows[n].Cells[5].Value = decimal.Parse(_loan.loan_amount.ToString()).ToString("N", new CultureInfo("en-US")); ;
                        dgvLoan.Rows[n].Cells[6].Value = decimal.Parse(_loan.balance.ToString()).ToString("N", new CultureInfo("en-US")); ;
                        dgvLoan.Rows[n].Cells[7].Value = _loan.status;
                        dgvLoan.Rows[n].Cells[8].Value = _loan.created_by;
                        dgvLoan.Rows[n].Cells[9].Value = _loan.loantype_id;
                    }
                }
                else
                {
                    ToolsControl.CallShowNotification(this, 4, "No record found.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) { return; }
            if (chkLoanType.Checked) { DisplayRecords(); }
        }

        private void cboSatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) { return; }
            if (chkStatus.Checked) { DisplayRecords(); }
        }

        private void dgvLoan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dgvLoan.HitTest(e.X, e.Y).RowIndex;

                if (rowIndex == -1) { return; }


                dgvLoan.ClearSelection();
                dgvLoan.Rows[rowIndex].Selected = true;

                iLoan _i = new IHOPSTransactionRepository.rLoan();
                _loanid = int.Parse(dgvLoan.Rows[rowIndex].Cells[0].Value.ToString());
                _loantype_id = int.Parse(dgvLoan.Rows[rowIndex].Cells[9].Value.ToString());

                if (_loantype_id == 11) { _loantypeid = 0; }
                else if (_loantype_id == 33) { _loantypeid = 1; }
                else if (_loantype_id == 6 || _loantype_id == 25) { _loantypeid = 2; }
                else if (_loantype_id == 2 || _loantype_id == 18 || _loantype_id == 32) { _loantypeid = 3; }
                else if (_loantype_id == 19 || _loantype_id == 26) { _loantypeid = 4; }
                else if (_loantype_id == 1 || _loantype_id == 17 || _loantype_id == 42) { _loantypeid = 5; }
                else if (_loantype_id == 4 || _loantype_id == 34) { _loantypeid = 6; }
                else if (_loantype_id == 5 || _loantype_id == 7 || _loantype_id == 8 || _loantype_id == 9 ||
                        _loantype_id == 10 || _loantype_id == 12 || _loantype_id == 13 || _loantype_id == 14 ||
                        _loantype_id == 15 || _loantype_id == 16 || _loantype_id == 20 || _loantype_id == 21 ||
                        _loantype_id == 22 || _loantype_id == 23 || _loantype_id == 24 || _loantype_id == 27 ||
                        _loantype_id == 28 || _loantype_id == 29 || _loantype_id == 30 || _loantype_id == 31 ||
                        _loantype_id == 37 || _loantype_id == 38 || _loantype_id == 39 || _loantype_id == 40 ||
                        _loantype_id == 41) { _loantypeid = 7; }

                EmployeeLoanMaster _hd = new EmployeeLoanMaster();
                _hd = _i.GetEmployeeLoan(0, _loanid);
                if (_hd != null)
                {
                    _loan_status = bool.Parse(_hd.LoanStat.ToString());
                    _empid = int.Parse(_hd.EmpID.ToString());
                }

                if (_loan_status)
                {
                    mnuDeactivateLoan.Enabled = true;
                    mnuActivateLoan.Enabled = false;
                }
                else
                {
                    mnuDeactivateLoan.Enabled = false;
                    mnuActivateLoan.Enabled = true;
                }


                dgvLoan.ContextMenuStrip = cntxMnu;
            }
        }

        void ManageLoan(bool _status)
        {
            iEmployeeLoanMaster _iemployeeloanmaster = new HURISRepository.rEmployeeLoanMaster();
            EmployeeLoanMaster _employeeloanmaster = new EmployeeLoanMaster();

            try
            {
                EmployeeLoanMaster _loan = new EmployeeLoanMaster();
                _loan.LoanID = _loanid;
                _loan.EmpID = 0;
                _loan.LoanTypeID = 0;
                _loan.DateLoan = DateTime.Now;
                _loan.LoanAmount = 0;
                _loan.Balance = 0;
                _loan.Amortization = 0;
                _loan.LoanStat = _status;
                _loan.DeductStatus = _status;
                _loan.DeductAmnt = 0;
                _loan.UserID = 0;
                _loan.Remarks = "";

                _iemployeeloanmaster.ManageEmployeeLoanMaster(_loan, 4);
                ToolsControl.CallShowNotification(this, 4, "Loan information successfully updated.");

                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        private void mnuActivateLoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to activate this loan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageLoan(true);
        }

        private void mnuDeactivateLoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to de-activate this loan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageLoan(false);
        }

        private void mnuGenerateLedger_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to generate loan ledger?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            EmployeeReportViewerForm _report = new EmployeeReportViewerForm("LOAN REPORT");
            _report._filter = "Per Employee";
            _report._empID = _empid;
            //_report._loanTypeID = _loanTypeID;
            _report._loanTypeID = _loantypeid;
            _report._loanStat = _loan_status;
            _report._company = "";
            _report._datefrom = dtpFrom.Value.Date;
            _report._dateto = dtpTo.Value.Date;
            _report._DateRange = "";
            _report.BringToFront();
            _report.Show();
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { filter_btn.PerformClick(); }
        }

        private void mnuViewEmployee_Click(object sender, EventArgs e)
        {
            if (_tool.CheckFormAleadyOpen("EmployeeInfo", _empid.ToString())) { return; }

            EmployeeInfo _employeeinfo = new EmployeeInfo(_empid);
            _employeeinfo.Tag = _empid.ToString();
            _employeeinfo.BringToFront();
            _employeeinfo.Show();
        }

        private void mnuNewLoan_Click(object sender, EventArgs e)
        {
            NewLoanForm _form = new NewLoanForm();
            _form.BringToFront();
            _form.ShowDialog();
        }

        private void addLoanPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LOAN_PAYMENT, SystemModuleType.Masterfile) == false) { return; }
            if (_tool.CheckFormAleadyOpen("AddLoanPaymentForm")) { return; }

            AddLoanPaymentForm _addloanpayment = new AddLoanPaymentForm(_loanid, _empid);
            _addloanpayment.BringToFront();
            _addloanpayment.Show();
        }

        private void viewLoanPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LOAN_PAYMENT, SystemModuleType.Masterfile) == false) { return; }
            if (_tool.CheckFormAleadyOpen("EmployeeLoanPaymentForm")) { return; }

            EmployeeLoanPaymentForm _employeeloanpayment = new EmployeeLoanPaymentForm(_loanid);
            _employeeloanpayment.BringToFront();
            _employeeloanpayment.Show();
        }
    }
}
