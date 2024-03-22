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
using DCLGlobal.Inquiry;
using DCLGlobal.Reports.Employee;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeOvertimeControl : UserControl
    {
        int _empid = 0;
        int _emprankID = 0;

        public EmployeeOvertimeControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmployeeOvertimeControl_Load(object sender, EventArgs e)
        {
            cboPeriod2.SelectedIndex = 0;
            DisplayEmployeeOvertime();
        }

        void DisplayEmployeeOvertime()
        {
            iOvertime _iovertime = new HURISTransactionRepository.rOvertime();
            dgvOT.RowCount = 0;
            prb.Minimum = 0;
            prb.Value = 0;

            try
            {
                List<FiledOvertime> _filedovertime = (from d in _iovertime.GetFiledOvertimes(_empid) where d.DateFiled.Value.Date >= dtpFromDate.Value.Date && d.DateFiled.Value.Date <= dtpToDate.Value.Date orderby d.DateFiled descending select d).ToList();
                prb.Maximum = _filedovertime.Count();

                if (_filedovertime != null)
                {
                    foreach (FiledOvertime _list in _filedovertime)
                    {
                        prb.Value = prb.Value + 1;
                        prb.Text = (prb.Value / prb.Maximum * 100).ToString();

                        int r = dgvOT.Rows.Add();
                        dgvOT.Rows[r].Cells[0].Value = _list.ID;
                        dgvOT.Rows[r].Cells[1].Value = _list.Overtime.Overtime_Desc;
                        dgvOT.Rows[r].Cells[2].Value = _list.DateFiled;
                        dgvOT.Rows[r].Cells[3].Value = _list.TotalOTHrs;
                        dgvOT.Rows[r].Cells[4].Value = _list.Remarks;
                        if (_list.P_OvertimeID == null)
                        {
                            dgvOT.Rows[r].Cells[5].Value = DateTime.Parse(_list.DateFiled.ToString()).DayOfWeek.ToString();
                        }
                        else
                        {
                            if (_iovertime.GetFiledOvertime(int.Parse(_list.P_OvertimeID.ToString())) != null)
                            {
                                dgvOT.Rows[r].Cells[5].Value = DateTime.Parse(_iovertime.GetOvertime(int.Parse(_list.P_OvertimeID.ToString())).OTDate.ToString()).DayOfWeek.ToString();
                            }
                            else
                            {
                                dgvOT.Rows[r].Cells[5].Value = DateTime.Parse(_list.DateFiled.ToString()).DayOfWeek.ToString();
                            }
                        }
                        _emprankID = _list.Employee.EmpRank_ID;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GeneralReportForm _report = new GeneralReportForm("OT", 0);
            _report.BringToFront();
            _report.Show();
        }

        private void btnReimbursableOT_Click(object sender, EventArgs e)
        {
            if (_emprankID == 2 || _emprankID == 3 || _emprankID == 4 || _emprankID == 6)
            {
                
                EmployeeReportViewerForm _report = new EmployeeReportViewerForm("Reimbursable OT");
                _report.panPrint.Visible = true;
                _report._empID = _empid;
                _report.BringToFront();
                _report.Show();
            }
        }

        private void cboPeriod2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPeriod2.SelectedIndex == 0)                  //This Month
            {
                dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpToDate.Value = DateTime.Now;
            }
            else if (cboPeriod2.SelectedIndex == 1)              //Last Month
            {
                var _1stdaycurrentmonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpFromDate.Value = _1stdaycurrentmonth.AddMonths(-1);
                dtpToDate.Value = _1stdaycurrentmonth.AddDays(-1);
            }
            else if (cboPeriod2.SelectedIndex == 2)              //Year-to-Date
            {
                dtpFromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
                dtpToDate.Value = DateTime.Now;
            }
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            DisplayEmployeeOvertime();
        }


    }
}
