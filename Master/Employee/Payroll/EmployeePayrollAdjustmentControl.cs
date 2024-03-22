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
    public partial class EmployeePayrollAdjustmentControl : UserControl
    {
        int _empid = 0;
        DateTime _from;
        DateTime _to;
        int _id = 0;
        int _mode = 1;
        int _compid = 0;
        int _payrollid = 0;
        bool _status;
        public EmployeePayrollAdjustmentControl(int _Empid, DateTime _From, DateTime _To, int _CompID, int _PAYROLLID)
        {
            InitializeComponent();
            _empid = _Empid;
            _from = _From;
            _to = _To;
            _compid = _CompID;
            _payrollid = _PAYROLLID;
        }

        private void EmployeeAdjustmentControl_Load(object sender, EventArgs e)
        {
            iPayrollHeader _ipayroll = new IHOPSTransactionRepository.rPayrollHeader();
            _status = bool.Parse(_ipayroll.GetPayroll(_payrollid).Status.ToString());

            DisplayAdjustments();
        }

        void DisplayAdjustments()
        {
            iEmployeePayrollAdjustment _iadjustment = new IHOPSTransactionRepository.rEmployeePayrollAdjustment();
            List<AdjustmentFile> _adjustments = new List<AdjustmentFile>();
            List<UserDefineClass.IHOPS.PayrollAdjustments> _payrolladjustments = new List<UserDefineClass.IHOPS.PayrollAdjustments>();

            dgvDetail.RowCount = 0;
            int n;

            try
            {
                if (_status == true)
                {
                    _payrolladjustments = _iadjustment.GetPayrollAdjustments(_payrollid, _empid, 0);

                    foreach (UserDefineClass.IHOPS.PayrollAdjustments _list in _payrolladjustments)
                    {
                        n = dgvDetail.Rows.Add();
                        dgvDetail.Rows[n].Cells[0].Value = _list.AdjusmentFile_ID.ToString();
                        dgvDetail.Rows[n].Cells[1].Value = _list.Adjustment_Desc;
                        dgvDetail.Rows[n].Cells[2].Value = _list.Trandate.ToShortDateString();
                        dgvDetail.Rows[n].Cells[3].Value = _list.Amount.ToString();
                        if (bool.Parse(_list.Taxable.ToString())) { dgvDetail.Rows[n].Cells[4].Value = "Yes"; }
                        else { dgvDetail.Rows[n].Cells[4].Value = "No"; }
                        dgvDetail.Rows[n].Cells[5].Value = _list.Remarks;
                    }
                }
                else
                {
                    _adjustments = _iadjustment.GetPayrollAdjustments(_empid, _from, _to, _compid);

                    foreach (AdjustmentFile _list in _adjustments)
                    {
                        n = dgvDetail.Rows.Add();
                        dgvDetail.Rows[n].Cells[0].Value = _list.AdjusmentFile_ID.ToString();
                        dgvDetail.Rows[n].Cells[1].Value = _list.Adjustment.Adjustment_Desc;
                        dgvDetail.Rows[n].Cells[2].Value = _list.Trandate.Value.ToShortDateString();
                        dgvDetail.Rows[n].Cells[3].Value = _list.Amount.ToString();
                        if (bool.Parse(_list.Taxable.ToString())) { dgvDetail.Rows[n].Cells[4].Value = "Yes"; }
                        else { dgvDetail.Rows[n].Cells[4].Value = "No"; }
                        dgvDetail.Rows[n].Cells[5].Value = _list.Remarks;
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
