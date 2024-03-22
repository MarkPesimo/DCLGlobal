using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using DCLGlobal.Inquiry;
using CAL.MASTER.Repository;
using CAL.MASTER.Interface;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.Model;
using DCLGlobal.Classes;

namespace DCLGlobal.Master.Main
{
    public partial class TelephoneMasterfileForm : Form
    {
        int _mode;
        int _empid;
        int _id;
        public TelephoneMasterfileForm()
        {
            InitializeComponent();
        }

        private void TelephoneMasterfileForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
            EnbaleForm(true);
            EnableButton(true);
            DisplayRecords();
        }
        void InitializeForm()
        {
            txtemployee.Text = "";
            txtlocalno.Text = "";
            txtkeyword.Text = "";
        }
        void EnbaleForm(bool _cond)
        {
            txtemployee.ReadOnly = _cond;
            txtlocalno.ReadOnly = _cond;
            txtkeyword.ReadOnly = !_cond;
        }
        void EnableButton(bool _cond)
        {
            btnadd.Enabled = _cond;
            btnedit.Enabled = _cond;
            btndelete.Enabled = _cond;
            btnfilter.Enabled = _cond;
            btnsave.Enabled = !_cond;
            btncancel.Enabled = !_cond;
            btnsearch.Enabled = !_cond;
            dgvtelephone.Enabled = _cond;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            _mode = 1;
            InitializeForm();
            EnbaleForm(false);
            EnableButton(false);
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            _mode = 2;
            EnbaleForm(false);
            EnableButton(false);
        }
        void DisplayRecords()
        {
            iTelephoneMasterfile _itel = new HURISRepository.rTelephoneMasterfile();
            List<TelephoneMasterfile> _tel = ( from d in _itel.GetTelMasterfiles(txtkeyword.Text) orderby d.Employee.Lastname select d).ToList();
            dgvtelephone.RowCount = 0;
            int n;
            try
            {
                if(_tel != null)
                {
                    foreach(TelephoneMasterfile _x in _tel)
                    {
                        n = dgvtelephone.Rows.Add();
                        dgvtelephone.Rows[n].Cells[0].Value = _x.ID;
                        dgvtelephone.Rows[n].Cells[1].Value = _x.EmpID;
                        dgvtelephone.Rows[n].Cells[2].Value = _x.Employee.Lastname + ", " + _x.Employee.Firstname + " " + _x.Employee.Middlename;
                        dgvtelephone.Rows[n].Cells[3].Value = _x.Localphoneno;
                        dgvtelephone.Rows[n].Cells[4].Value = _x.Employee.Salary.Salary_Desc;
                        dgvtelephone.Rows[n].Cells[5].Value = _x.Employee.Department.Dept_Name;
                        dgvtelephone.Rows[n].Cells[6].Value = _x.Employee.Companycode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                _empid = _employee.Emp_ID;
                txtemployee.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
            }
            txtlocalno.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            InitializeForm();
            EnbaleForm(true);
            EnableButton(true);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtemployee.Text == "")
            {
                btxMsg.ShowBalloon(txtemployee);
                txtemployee.Focus();
                return;
            }
            else if(txtlocalno.Text == "")
            {
                btxMsg.ShowBalloon(txtlocalno);
                txtlocalno.Focus();
                return;
            }
            if (MessageBox.Show("Are you sure you want to save telephone number?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageRecord();

            EnbaleForm(true);
            EnableButton(true);
        }
        void ManageRecord()
        {
            iTelephoneMasterfile _itel = new HURISRepository.rTelephoneMasterfile();
            TelephoneMasterfile _tel = new TelephoneMasterfile();
            try
            {
                _tel.ID = _id;
                _tel.EmpID = _empid;
                _tel.Localphoneno = int.Parse(txtlocalno.Text); // int.Parse(nudlocalno.Value.ToString());

                _itel.ManageTelMasterfile(_tel, _mode);

                if (_mode == 3)
                {
                    ToolsControl.CallShowNotification(this, 3, "Record successfully deleted.");
                }
                else if (_mode == 1 || _mode == 2)
                {
                    ToolsControl.CallShowNotification(this, 2, "Record successfully saved.");
                }

                DisplayRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvtelephone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { dgvtelephone.Enabled = false; return; }

            _id = int.Parse(dgvtelephone.Rows[e.RowIndex].Cells[0].Value.ToString());
            _empid = int.Parse(dgvtelephone.Rows[e.RowIndex].Cells[1].Value.ToString());

            iTelephoneMasterfile _itel = new HURISRepository.rTelephoneMasterfile();
            TelephoneMasterfile _tel = _itel.GetTelMasterfile(_id);
            try
            {
                txtemployee.Text = _tel.Employee.Lastname + ", " + _tel.Employee.Firstname + " " + _tel.Employee.Middlename;
                txtlocalno.Text = _tel.Localphoneno.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            _mode = 3;
            if (MessageBox.Show("Are you sure you want to delete telephone number?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageRecord();
        }

        private void txtkeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DisplayRecords();
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }
    }
}
