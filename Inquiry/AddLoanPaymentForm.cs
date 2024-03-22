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
using CAL.Model;
using CAL.Global;

using DCLGlobal.Classes;

namespace DCLGlobal.Inquiry
{
    public partial class AddLoanPaymentForm : Form
    {
        int _mode;
        int _loanID;
        int _empID;
        public AddLoanPaymentForm(int _LOANID, int _EMPID)
        {
            InitializeComponent();
            _loanID = _LOANID;
            _empID = _EMPID;
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
        private void save_btn_Click(object sender, EventArgs e)
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
            InitializeForm();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ManageLoanPayment()
        {
            iEmployeeLoanPayment _iemployeeloanpayment = new HURISRepository.rEmployeeLoanPayment();
            EmployeeLoanPayment _employeeloanpayment = new EmployeeLoanPayment();
            try
            {
                _employeeloanpayment.Loan_ID = _loanID;
                _employeeloanpayment.Emp_ID = _empID;
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLoanPaymentForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void InitializeForm()
        {
            dtPaymentDate.Value = DateTime.Now.Date;
            txtAmount.Text = "0";
            txtORNo.Text = "";
            txtPaymentRemarks.Text = "";
        }
        private void AddLoanPaymentForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }
    }
}
