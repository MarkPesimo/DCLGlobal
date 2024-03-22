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

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeAdjustmentControl : UserControl
    {
        EmployeeInfo _parent;
        int _mode = 0;
        int _id = 0;
        public EmployeeAdjustmentControl(EmployeeInfo _Parent)
        {
            InitializeComponent();
            _parent = _Parent;
            LoadAdjustmentDesc(cmbadjustment);
        }
        private void EmployeeAdjustmentControl_Load(object sender, EventArgs e)
        {
            DisplayAdjustmentInfo();
            InitializeForm();
            EnableForm1(true);
            EnableButton(true);
        }
        void InitializeForm()
        {
            cmbadjustment.SelectedItem = "";
            dtpdate.Value = DateTime.Now;
            nudamount.Value = 0;
            chktaxable.Checked = true;
            txtremarks.Text = "";
            chkstatus.Checked = true;
        }
        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Print_btn.Enabled = _cond;
            Cancel_btn.Enabled = !_cond;
        }
        void EnableForm1(bool _cond)
        {
            cmbadjustment.Enabled = !_cond;
            dtpdate.Enabled = !_cond;
            nudamount.Enabled = !_cond;
            chktaxable.Enabled = !_cond;
            txtremarks.ReadOnly = _cond;
            chkstatus.Enabled = !_cond;
        }
        void DisplayAdjustmentInfo()
        {
            iAdjustmentFile _iadjustmentfile = new HURISRepository.rAdjustmentFile();
            dgvAdjustment.RowCount = 0;
            int n;
            try
            {
                List<AdjustmentFile> _adjustmentfile = (from d in _iadjustmentfile.GetAdjustmentFiles(_parent._empid) orderby d.Trandate descending select d).ToList();
                if (_adjustmentfile != null)
                {
                    foreach (AdjustmentFile _x in _adjustmentfile)
                    {
                        n = dgvAdjustment.Rows.Add();
                        dgvAdjustment.Rows[n].Cells[0].Value = _x.AdjusmentFile_ID.ToString();
                       // dgvAdjustment.Rows[n].Cells[1].Value = "EDIT";
                        dgvAdjustment.Rows[n].Cells[1].Value = "DELETE";
                        dgvAdjustment.Rows[n].Cells[2].Value = _x.Adjustment.Adjustment_Desc;
                        dgvAdjustment.Rows[n].Cells[3].Value = _x.Amount;
                        dgvAdjustment.Rows[n].Cells[4].Value = _x.Trandate;
                        dgvAdjustment.Rows[n].Cells[5].Value = _x.Taxable;
                        dgvAdjustment.Rows[n].Cells[6].Value = _x.Status;
                        dgvAdjustment.Rows[n].Cells[7].Value = _x.Remarks;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void paneladjustment()
        {
            //LoadAdjustmentDesc(cmbadjustment);

            if (_mode == 2)
            {
                //label1.Text = "Adjusment Information [Edit]";
                cmbadjustment.SelectedValue = 0;
                DisplayAdjustment();
            }
            else
            {
                //label1.Text = "Adjusment Information [Add]";
                InitializeForm();
            }
        }
        void LoadAdjustmentDesc(ComboBox _cbo)
        {

            _cbo.DataSource = null;
            iAdjustment _iadjustment = new HURISRepository.rAdjustment();
            List<Adjustment> _obj = _iadjustment.GetAdjustments("");

            _cbo.DataSource = _obj;
            _cbo.DisplayMember = "Adjustment_Desc";
            _cbo.ValueMember = "Adjustment_ID";

        }
        void DisplayAdjustment()
        {
            iAdjustmentFile _iadjustment = new HURISRepository.rAdjustmentFile();
            AdjustmentFile _adjustment = _iadjustment.GetAdjustmentFile(_id);
            try
            {
                if (_adjustment != null)
                {
                    _id = int.Parse(_adjustment.AdjusmentFile_ID.ToString());
                    _parent._empid = int.Parse(_adjustment.Emp_ID.ToString());
                    cmbadjustment.SelectedValue = _adjustment.Adjustment_ID;
                    dtpdate.Value = DateTime.Parse(_adjustment.Trandate.ToString());
                    nudamount.Value = double.Parse(_adjustment.Amount.ToString());
                    if (_adjustment.Taxable == true)
                    {
                        chktaxable.Checked = true;
                    }
                    else
                    {
                        chktaxable.Checked = false;
                    }
                    txtremarks.Text = _adjustment.Remarks;
                    if (_adjustment.Status == true)
                    {
                        chkstatus.Checked = true;
                    }
                    else
                    {
                        chkstatus.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Add Adjustment?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            //panelAdjustment.Show();
            //paneladjustment();
            _mode = 1;
            dgvAdjustment.Enabled = false;
            InitializeForm();
            EnableButton(false);
            EnableForm1(false);
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbadjustment.SelectedIndex == -1)
            {
                //btxMsg.ShowBalloon(cmbadjustment);
                MessageBox.Show("Please select Adjustment description");
                cmbadjustment.Focus();
                return;
            }
            else if (nudamount.Value == 0)
            {
                //btxMsg.ShowBalloon(nudamount);
                MessageBox.Show("Please provide a valid amount");
                nudamount.Focus();
                return;
            }
            //else if(txtremarks.Text == "")
            //{
            //    MessageBox.Show("Please input a remarks");
            //    txtremarks.Focus();
            //    return;
            //}
            else
            {
            if (MessageBox.Show("Are you sure you want to save adjustment?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            }

            ManageAdjustment();

            DisplayAdjustmentInfo();
            InitializeForm();
            EnableButton(true);
            EnableForm1(true);
            RefreshRecord();
            dgvAdjustment.Enabled = true;
        }
        void RefreshRecord()
        {
            if (_mode == 2)
            {
                EmployeeAdjustmentControl _adjustment = new EmployeeAdjustmentControl(_parent);
                DisplayAdjustmentInfo();
            }
            else
            {

            }
        }
        private void dgvAdjustment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (e.ColumnIndex == 1)
                //{
                //    _id = int.Parse(dgvAdjustment.Rows[e.RowIndex].Cells[0].Value.ToString());

                //    //panelAdjustment.Show();
                //    _mode = 2;
                //    //paneladjustment();
                //    EnableForm1(false);
                //    InitiliazeForm();
                //}
                if (e.ColumnIndex == 1)
                {
                    _id = int.Parse(dgvAdjustment.Rows[e.RowIndex].Cells[0].Value.ToString());

                    if (_id == 0)
                    {
                        MessageBox.Show("No record");
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to delete this loan", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
                        _mode = 3;

                        ManageAdjustment();
                    }
                    DisplayAdjustmentInfo();
                    //MessageBox.Show("Successfully deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ManageAdjustment()
        {
            iAdjustmentFile _iadjustmentfile = new HURISRepository.rAdjustmentFile();
            AdjustmentFile _adjustmentFile = new AdjustmentFile();

            try
            {
                _adjustmentFile.AdjusmentFile_ID = _id;
                _adjustmentFile.Emp_ID = _parent._empid;
                _adjustmentFile.Adjustment_ID = int.Parse(cmbadjustment.SelectedValue.ToString());
                _adjustmentFile.Trandate = dtpdate.Value;
                _adjustmentFile.Amount = decimal.Parse(nudamount.Value.ToString());
                _adjustmentFile.Remarks = txtremarks.Text;
                if (chktaxable.Checked == true)
                {
                    _adjustmentFile.Taxable = true;
                }
                else
                {
                    _adjustmentFile.Taxable = false;
                }
                if (chkstatus.Checked == true)
                {
                    _adjustmentFile.Status = true;
                }
                else
                {
                    _adjustmentFile.Status = false;
                }
                _adjustmentFile.UserID = LoginUser.userid;

                _iadjustmentfile.ManageAdjustmentFile(_adjustmentFile, _mode);

                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else if (_mode == 3) { ToolsControl.CallShowNotification(this, 3, "Adjustment successfully deleted."); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit_btn_Click(object sender, EventArgs e)
        {
            _mode = 2;
            DisplayAdjustmentInfo();
            dgvAdjustment.Enabled = false;
            EnableButton(false);
            EnableForm1(false);
        }
        private void dgvAdjustment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvAdjustment.Rows[e.RowIndex].Cells[0].Value.ToString());

            DisplayAdjustment();
        }
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            DisplayAdjustmentInfo();
            EnableForm1(true);
            InitializeForm();
            EnableButton(true);
            dgvAdjustment.Enabled = true;
        }

        private void Print_btn_Click(object sender, EventArgs e)
        {
            dgvAdjustment.Enabled = true;
        }
    }
}
