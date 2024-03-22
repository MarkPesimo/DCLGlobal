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

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeLeaveControl : UserControl
    {
        int _empid = 0;

        public EmployeeLeaveControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmployeeLeaveControl_Load(object sender, EventArgs e)
        {
            cboPeriod2.SelectedIndex = 0;
            DisplayFiledLeave();
        }

        void DisplayFiledLeave()
        {
            iLeave _ileave = new HURISTransactionRepository.rLeave();
            dgvEmpLeaveFile.RowCount = 0;
            prb.Minimum = 0;
            prb.Value = 0;

            try
            {
                List<FiledLeave> _filedleave = (from d in _ileave.GetFiledLeaves(_empid) where d.FromDate.Value.Date >= dtpFromDate.Value.Date && d.FromDate.Value.Date <= dtpToDate.Value.Date orderby d.FromDate descending select d).ToList();
                prb.Maximum = _filedleave.Count();

                if (_filedleave != null)
                {
                    foreach(FiledLeave _list in _filedleave)
                    {
                        prb.Value = prb.Value + 1;
                        prb.Text = (prb.Value / prb.Maximum * 100).ToString();

                        int r = dgvEmpLeaveFile.Rows.Add();
                        dgvEmpLeaveFile.Rows[r].Cells[0].Value = _list.ID;
                        dgvEmpLeaveFile.Rows[r].Cells[1].Value = _list.LeaveType.Leavetype_desc;
                        dgvEmpLeaveFile.Rows[r].Cells[2].Value = _list.DateFiled;
                        dgvEmpLeaveFile.Rows[r].Cells[3].Value = _list.FromDate;
                        dgvEmpLeaveFile.Rows[r].Cells[4].Value = _list.ToDate;
                        dgvEmpLeaveFile.Rows[r].Cells[5].Value = _list.TotalLeaveDays;
                        dgvEmpLeaveFile.Rows[r].Cells[6].Value = _list.Remarks;
                    }     
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DisplayFiledLeave();
        }
    }
}
