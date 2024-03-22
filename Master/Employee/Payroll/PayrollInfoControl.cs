using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using CAL.Model;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Master.Employee.Payroll;

namespace DCLGlobal.Master.Employee.Payroll
{
    public partial class PayrollInfoControl : UserControl
    {
        int _empid = 0;
        int _payrolldetid;
        int _payrollid;
        int _compid;
        DateTime _timesheet_datefrom;
        DateTime _timesheet_dateto;
        ToolsControl _tool = new ToolsControl();
        int _timesheetid = 0;
        public PayrollInfoControl(int _Empid)
        {
            InitializeComponent();
            _empid = _Empid;
        }

        private void PayrollInfoControl_Load(object sender, EventArgs e)
        {
            DisplayRecords();
        }

        void DisplayRecords()
        {
            iPayrollDetails _idetail = new IHOPSTransactionRepository.rPayrollDetails();
            dgvPayroll.RowCount = 0;
            int n;

            try
            {
                List<Payroll_Details> _details = (from d in _idetail.GetEmployeePayrollDetails(_empid) orderby d.Payroll_HD.PayDate descending select d).ToList();
                foreach (Payroll_Details _list in _details)
                {
                    n = dgvPayroll.Rows.Add();
                    dgvPayroll.Rows[n].Cells[0].Value = _list.Payroll_ID.ToString();
                    dgvPayroll.Rows[n].Cells[1].Value = _list.Payroll_HD.Company.CompanyName;                    
                    dgvPayroll.Rows[n].Cells[2].Value = _list.Payroll_HD.Title;
                    dgvPayroll.Rows[n].Cells[3].Value = _list.Payroll_HD.Payroll_Group.Description;
                    dgvPayroll.Rows[n].Cells[4].Value = _list.Payroll_HD.PayDate.Value.ToShortDateString();
                    if (_list.Payroll_HD.Status == true)
                    { dgvPayroll.Rows[n].Cells[5].Value = "Posted"; }
                    else { dgvPayroll.Rows[n].Cells[5].Value = "Unposted"; }
                    dgvPayroll.Rows[n].Cells[6].Value = _list.RegularPay.ToString();
                    dgvPayroll.Rows[n].Cells[7].Value = _list.GrossAmount.ToString();
                    dgvPayroll.Rows[n].Cells[8].Value = _list.TotalDeductions.ToString();
                    dgvPayroll.Rows[n].Cells[9].Value = _list.Net.ToString();
                    dgvPayroll.Rows[n].Cells[10].Value = _list.PayrollDet_ID.ToString();
                    dgvPayroll.Rows[n].Cells[11].Value = _list.Payroll_HD.CompID.ToString();
                    dgvPayroll.Rows[n].Cells[12].Value = _list.Timesheet_ID;
                }

            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }

        private void dgvPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            try
            {
                _payrolldetid = int.Parse(dgvPayroll.Rows[e.RowIndex].Cells[10].Value.ToString());
                _payrollid = int.Parse(dgvPayroll.Rows[e.RowIndex].Cells[0].Value.ToString());
                _compid = int.Parse(dgvPayroll.Rows[e.RowIndex].Cells[11].Value.ToString());
                _timesheetid = int.Parse(dgvPayroll.Rows[e.RowIndex].Cells[12].Value.ToString());

                if (e.ColumnIndex == 1)
                {
                    if (_tool.CheckFormAleadyOpen("PayrollDetailsInformationform", _payrolldetid.ToString())) { return; }
                    PayrollDetailsInformationForm _detail = new PayrollDetailsInformationForm(_empid, _payrollid, _timesheetid);
                    _detail.Tag = _payrolldetid.ToString();
                    _detail.BringToFront();
                    _detail.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                              (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                    _detail.Show();
                }

            }
            catch (Exception ex)
            {
                GlobalToolsControl.Global.ShowErrorMessage(ex);
            }
        }
    }
}
