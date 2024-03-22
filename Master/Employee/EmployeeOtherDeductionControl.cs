using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Master.Main.Employee;
using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using System.IO;
using System.Data.Linq;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using DCLGlobal.Classes;
using System.Globalization;


namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeOtherDeductionControl : UserControl
    {
        EmployeeInfo _parent;
        int _id = 0;
        int _mode = 0;
        decimal _salary = 0;
        public EmployeeOtherDeductionControl(EmployeeInfo _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
            DisplayDesc(cmbdesc);
        }

        private void EmployeeOtherDeductionControl_Load(object sender, EventArgs e)
        {
            DisplayOtherDeductionInfo();
            InitializeForm();
            EnableButton(true);
            EnableForm(true);

            nudAbsentDays.Enabled = false;
            btnComputeAbsent.Enabled = false;
        }
        void InitializeForm()
        {
            cmbdesc.SelectedValue = 1;
            dtpTrans.Value = DateTime.Now;
            nudAbsentDays.Value = 0;
            nudAmount.Value = 0;
            nudBalance.Value = 0;
            txtRemarks.Text = "";
            chkStat.Checked = false;
        }
        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
            Print_btn.Enabled = _cond;
        }
        void EnableForm(bool _cond)
        {
            cmbdesc.Enabled = !_cond;
            dtpTrans.Enabled = !_cond;
            //nudAbsentDays.ReadOnly = _cond;
            nudAmount.Enabled = !_cond;
            nudBalance.Enabled = !_cond;
            txtRemarks.ReadOnly = _cond;
            chkStat.Enabled = !_cond;
        }
        void DisplayOtherDeductionInfo()
        {
            iOtherDeduction _iotherdeduction = new HURISRepository.rOtherDeduction();
            dgvDeduction.RowCount = 0;
            int n;
            try
            {
                List<OtherDeduction> _otherdeduction = (from d in _iotherdeduction.GetOtherDeductions(_parent._empid) orderby d.Trandate descending select d).ToList();

                //iEmployee _iemployee = new HURISRepository.rEmployee();

                foreach (OtherDeduction _x in _otherdeduction)
                {
                    n = dgvDeduction.Rows.Add();
                    dgvDeduction.Rows[n].Cells[0].Value = _x.OtherDed_ID.ToString();
                    //dgvDeduction.Rows[n].Cells[1].Value = "EDIT";
                    dgvDeduction.Rows[n].Cells[1].Value = "DELETE";
                    dgvDeduction.Rows[n].Cells[2].Value = _x.Deduction.Ded_Desc;
                    dgvDeduction.Rows[n].Cells[3].Value = _x.Amount;
                    dgvDeduction.Rows[n].Cells[4].Value = _x.Trandate;
                    dgvDeduction.Rows[n].Cells[5].Value = _x.Status;
                    dgvDeduction.Rows[n].Cells[6].Value = _x.Remarks;

                    //_salary = decimal.Parse((from d in _iemployee.GetEmployee(_x.Emp_ID) select d.)).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            //panelOtherDeduct.Show();
            //paneLoad();
            _mode = 1;
            InitializeForm();
            EnableButton(false);
            EnableForm(false);
            dgvDeduction.Enabled = false;
        }


        void paneLoad()
        {
            //DisplayDesc(cmbdesc);

            if (_mode == 2)
            {
                //label1.Text = "Adjusment Information [Edit]";
                cmbdesc.SelectedValue = 0;
                DisplayOtherDeduct();
            }
            else
            {
                //label1.Text = "Adjusment Information [Add]";
                InitializeForm();
            }
        }
        void DisplayDesc(ComboBox _cbo)
        {
            _cbo.DataSource = null;
            iDeduction _ideduction = new HURISRepository.rDeduction();
            List<Deduction> _obj = _ideduction.GetDeductions("");
        
            _cbo.DataSource = _obj;
            _cbo.DisplayMember = "Ded_Desc";
            _cbo.ValueMember = "Ded_id";
        }

        void DisplayOtherDeduct()
        {
            iOtherDeduction _iotherdeduction = new HURISRepository.rOtherDeduction();
            OtherDeduction _otherdeduction = _iotherdeduction.GetOtherDeduction(_id);

            try
            {
                if (_otherdeduction != null)
                {
                    _id = int.Parse(_otherdeduction.OtherDed_ID.ToString());
                    _parent._empid = int.Parse(_otherdeduction.Emp_ID.ToString());
                    cmbdesc.SelectedValue = _otherdeduction.Ded_ID;
                    dtpTrans.Value = Convert.ToDateTime(_otherdeduction.Trandate);
                    nudAbsentDays.Value = decimal.Parse(_otherdeduction.DaysAbsent.ToString());
                    nudAmount.Value = double.Parse(_otherdeduction.Amount.ToString());
                    nudBalance.Value = double.Parse(_otherdeduction.Balance.ToString());
                    txtRemarks.Text = _otherdeduction.Remarks;
                    if(_otherdeduction.Status == true)
                    {
                        chkStat.Checked = true;
                    }
                    else
                    {
                        chkStat.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDeduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.ColumnIndex == 1)
                //{
                //    _id = int.Parse(dgvDeduction.Rows[e.RowIndex].Cells[0].Value.ToString());
                //    _mode = 2;

                //    panelOtherDeduct.Show();
                //    paneLoad();
                //}
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Are you sure you want to delete this deduction", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                    _id = int.Parse(dgvDeduction.Rows[e.RowIndex].Cells[0].Value.ToString());
                    _mode = 3;
                    ManageOtherDeduction();
                    
                    DisplayOtherDeductionInfo();
                    InitializeForm();
                    EnableButton(true);
                    EnableForm(true);

                    //MessageBox.Show("Successfully deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbdesc.SelectedValue == null)
                {
                    MessageBox.Show("Please select a description");
                    cmbdesc.Focus();
                    return;
                }
                if (cmbdesc.SelectedIndex == 3)
                {
                    if (nudAbsentDays.Value == 0)
                    {
                        MessageBox.Show("Absent day(s) is invalid. Please provide valid day(s).");
                        nudAbsentDays.Focus();
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to save deduction", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                }
                ManageOtherDeduction();

                DisplayOtherDeductionInfo();
                InitializeForm();
                EnableButton(true);
                EnableForm(true);

                dgvDeduction.Enabled = true;

                nudAbsentDays.Enabled = false;
                btnComputeAbsent.Enabled = false;

                RefreshRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RefreshRecord()
        {
            if (_mode == 2)
            {
                EmployeeOtherDeductionControl _deduction = new EmployeeOtherDeductionControl(_parent);
                DisplayOtherDeductionInfo();
            }
            else
            {

            }
        }
        void ManageOtherDeduction()
        {
            iOtherDeduction _iotherdeduction = new HURISRepository.rOtherDeduction();
            OtherDeduction _otherdeduction = new OtherDeduction();
            try
            {
                _otherdeduction.Emp_ID = _parent._empid;
                _otherdeduction.Ded_ID = int.Parse(cmbdesc.SelectedValue.ToString());
                _otherdeduction.Trandate = dtpTrans.Value;
                _otherdeduction.DaysAbsent = nudAbsentDays.Value;
                _otherdeduction.Amount = decimal.Parse(nudAmount.Value.ToString());
                _otherdeduction.Remarks = txtRemarks.Text;
                if (chkStat.Checked == true)
                {
                    _otherdeduction.Status = true;
                }
                else
                {
                    _otherdeduction.Status = false;
                }
                _otherdeduction.OtherDed_ID = _id;
                _otherdeduction.Balance = decimal.Parse(nudBalance.Value.ToString());

                _iotherdeduction.ManageOtherDeduction(_otherdeduction, _mode);

                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 3, "Adjustment successfully deleted."); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDeduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvDeduction.Rows[e.RowIndex].Cells[0].Value.ToString());

            DisplayOtherDeduct();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if(cmbdesc.SelectedIndex == -1)
            {
                MessageBox.Show("Select Description");
                cmbdesc.Focus();
                return;
            }
            else
            {
                _mode = 2;
                //InitializeForm();
                EnableButton(false);
                EnableForm(false);
                dgvDeduction.Enabled = false;

                if (cmbdesc.SelectedIndex == 3)
                {
                    nudAbsentDays.Enabled = true;
                    btnComputeAbsent.Enabled = true;
                }
                else
                {
                    nudAbsentDays.Enabled = false;
                    btnComputeAbsent.Enabled = false;
                }
            } 
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            DisplayOtherDeductionInfo();
            InitializeForm();
            EnableButton(true);
            EnableForm(true);

            nudAbsentDays.Enabled = false;
            btnComputeAbsent.Enabled = false;

            dgvDeduction.Enabled = true;
        }

        void GetSalary()
        {
            iProcessPayroll _ipayroll = new IHOPSTransactionRepository.rProcessPayroll();

            decimal _result;
            decimal _days;

            _days = nudAbsentDays.Value;

            try
            {
                _result = _ipayroll.ComputeDailyRate(_parent._empid) * _days;
                nudAmount.Value = double.Parse(_result.ToString());
            }
            catch (Exception ex)
            {
                _result = 0;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComputeAbsent_Click(object sender, EventArgs e)
        {

                if (nudAbsentDays.Value == 0)
                {
                    MessageBox.Show("Absent day(s) is invalid. Please provide valid day(s).");
                    nudAbsentDays.Focus();
                    return;
                }
                else
                {
                    GetSalary();
                }         
        }

        private void cmbdesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdesc.SelectedIndex == 3)
            {
                nudAbsentDays.Enabled = true;
                btnComputeAbsent.Enabled = true;
            }
            else
            {
                nudAbsentDays.Enabled = false;
                btnComputeAbsent.Enabled = false;
            }
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            dgvDeduction.Enabled = true;
        }
    }
}
