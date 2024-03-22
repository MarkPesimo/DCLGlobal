using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.Global;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Master.Employee.Payroll
{
    public partial class EmployeePayrollDeductionControl : UserControl
    {
        int _empid = 0;
        DateTime _from;
        DateTime _to;
        int _id = 0;
        int _mode = 1;
        int _compid = 0;
        int _payrollid = 0;
        bool _status;
        public EmployeePayrollDeductionControl(int _Empid, DateTime _From, DateTime _To, int _compID, int _PAYROLLID)
        {
            InitializeComponent();
            _empid = _Empid;
            _from = _From;
            _to = _To;
            _compid = _compID;
            _payrollid = _PAYROLLID;
        }

        private void EmployeePayrollDeductionControl_Load(object sender, EventArgs e)
        {
            iPayrollHeader _ipayroll = new IHOPSTransactionRepository.rPayrollHeader();
            _status = bool.Parse(_ipayroll.GetPayroll(_payrollid).Status.ToString());

            DisplayDeductions();
        }

        void DisplayDeductions()
        {
            iEmployeePayrollDeduction _ideduction = new IHOPSTransactionRepository.rEmployeePayrollDeduction();
            List<OtherDeduction> _deductions = new List<OtherDeduction>();
            List<UserDefineClass.IHOPS.PayrollDeductions> _payrolldeductions = new List<UserDefineClass.IHOPS.PayrollDeductions>();

            dgvDetail.RowCount = 0;
            int n;

            try
            {
                if (_status == true)
                {
                    _payrolldeductions = _ideduction.GetPayrollDeductions(_payrollid, _empid, 0);

                    foreach (UserDefineClass.IHOPS.PayrollDeductions _list in _payrolldeductions)
                    {
                        n = dgvDetail.Rows.Add();
                        dgvDetail.Rows[n].Cells[0].Value = _list.OtherDed_ID.ToString();
                        dgvDetail.Rows[n].Cells[1].Value = _list.Ded_Desc;
                        dgvDetail.Rows[n].Cells[2].Value = _list.Trandate.ToShortDateString();
                        dgvDetail.Rows[n].Cells[3].Value = _list.Amount.ToString();
                        dgvDetail.Rows[n].Cells[4].Value = _list.Remarks;
                    }
                }
                else
                {
                    _deductions = _ideduction.GetPayrollDeductions(_empid, _from, _to, _compid);

                    foreach (OtherDeduction _list in _deductions)
                    {
                        n = dgvDetail.Rows.Add();
                        dgvDetail.Rows[n].Cells[0].Value = _list.OtherDed_ID.ToString();
                        dgvDetail.Rows[n].Cells[1].Value = _list.Deduction.Ded_Desc;
                        dgvDetail.Rows[n].Cells[2].Value = _list.Trandate.Value.ToShortDateString();
                        dgvDetail.Rows[n].Cells[3].Value = _list.Amount.ToString();
                        dgvDetail.Rows[n].Cells[4].Value = _list.Remarks;
                    }
                }


            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }
    }
}
