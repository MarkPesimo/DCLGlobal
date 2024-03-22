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
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Inquiry
{
    public partial class NewLoanForm : Form
    {
        public NewLoanForm()
        {
            InitializeComponent();
            GlobalToolsControl.HURIS.FillCboLoan(cboLoanType);
        }

        private void NewLoanForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this Loan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            if (txtLoanAmount.Text == "")
            {
                btxMsg.ShowBalloon(txtLoanAmount);
                txtLoanAmount.Focus();
                return;
            }

            if (txtBalance.Text == "")
            {
                btxMsg.ShowBalloon(txtBalance);
                txtBalance.Focus();
                return;
            }

            if (txtDeductionAmount.Text == "")
            {
                btxMsg.ShowBalloon(txtDeductionAmount);
                txtDeductionAmount.Focus();
                return;
            }

            iEmployeeLoanMaster _iemployeeloanmaster = new HURISRepository.rEmployeeLoanMaster();
            EmployeeLoanMaster _loan = new EmployeeLoanMaster();

            try
            {
                _loan.LoanID = 0;
                _loan.EmpID = int.Parse(txtEmployee.Tag.ToString());
                _loan.LoanTypeID = int.Parse(cboLoanType.SelectedValue.ToString());
                _loan.DateLoan = dtpLoanDate.Value;
                _loan.LoanAmount = decimal.Parse(txtLoanAmount.Text);
                _loan.Balance = decimal.Parse(txtBalance.Text);
                _loan.DeductAmnt = decimal.Parse(txtDeductionAmount.Text);
                _loan.Amortization = decimal.Parse(txtDeductionAmount.Text);
                _loan.Remarks = txtRemarks.Text;
                _loan.DeductStatus = chkActive.Checked;
                _loan.LoanStat = chkActive.Checked;

                _iemployeeloanmaster.ManageEmployeeLoanMaster(_loan, 1);

                MessageBox.Show("Loan successfully saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                txtEmployee.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                txtEmployee.Tag = _employee.Emp_ID;
            }
        }
    }
}
