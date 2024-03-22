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

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeOBTPControl : UserControl
    {
        int _empid = 0;

        public EmployeeOBTPControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmployeeOBTPControl_Load(object sender, EventArgs e)
        {
            cboPeriod2.SelectedIndex = 0;
            DisplayEmployeeOBTP();
        }

        void DisplayEmployeeOBTP()
        {
            iOBTP _iobtp = new HURISTransactionRepository.rOBTP();
            dgvOBTP.RowCount = 0;
            prb.Minimum = 0;
            prb.Value = 0;

            try
            {
                List<FiledOBTP> _filedobtp = (from d in _iobtp.GetFiledOBTPs(_empid) where d.filedobtpOBTPDATE.Value.Date >= dtpFromDate.Value.Date && d.filedobtpOBTPDATE.Value.Date <= dtpToDate.Value.Date orderby d.filedobtpOBTPDATE descending select d).ToList();

                prb.Maximum = _filedobtp.Count();

                if (_filedobtp != null)
                {
                    foreach (FiledOBTP _list in _filedobtp)
                    {
                        prb.Value = prb.Value + 1;
                        prb.Text = (prb.Value / prb.Maximum * 100).ToString();

                        int r = dgvOBTP.Rows.Add();
                        dgvOBTP.Rows[r].Cells[0].Value = _list.filedobtpID;
                        dgvOBTP.Rows[r].Cells[1].Value = _list.filedobtpFILEDDATE;
                        dgvOBTP.Rows[r].Cells[2].Value = _list.filedobtpOBTPDATE;
                        dgvOBTP.Rows[r].Cells[3].Value = _list.filedobtpDESTINATION;
                        dgvOBTP.Rows[r].Cells[4].Value = _list.filedobtpHRFROM;
                        dgvOBTP.Rows[r].Cells[5].Value = _list.filedobtpHRTO;
                        dgvOBTP.Rows[r].Cells[6].Value = _list.filedobtpDURATION;
                        dgvOBTP.Rows[r].Cells[7].Value = _list.filedobtpCONTACTNO;
                        dgvOBTP.Rows[r].Cells[8].Value = _list.filedobtpPURPOSE;
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
            DisplayEmployeeOBTP();
        }
    }
}
