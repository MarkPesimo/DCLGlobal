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
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using System.IO;
using DevComponents.DotNetBar;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeCaseControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        string _fileExtension;
        string _targetpath;
        string _filepath;
        bool _flag;
        string _destinationpath;

        public EmployeeCaseControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
            BindMemoList(cboMemo);
        }

        private void EmployeeCasesControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeCase();
        }

        void InitializeField()
        {
            _id = 0;
            txtCaseNo.Text = "";
            cboMemo.SelectedIndex = -1;
            dtpIssued.Value = DateTime.Now;
            dtpIssued.LockUpdateChecked = false;
            dtpReceived.Value = DateTime.Now;
            dtpReceived.LockUpdateChecked = false;
            dtpReplyReceived.Value = DateTime.Now;
            dtpReplyReceived.LockUpdateChecked = false;
            chkForHearing.Checked = false;
            dtpDateNOAHIssued.Value = DateTime.Now;
            dtpDateNOAHIssued.LockUpdateChecked = false;
            dtpDateOfNOAH.Value = DateTime.Now;
            dtpDateOfNOAH.LockUpdateChecked = false;
            dtpEffectivity.Value = DateTime.Now;
            dtpEffectivity.LockUpdateChecked = false;
            txtstatus.Text = "";
            txtRemarks.Text = "";
            txtFileLocation.Text = "";
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvCases.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
            btnBrowse.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtCaseNo.ReadOnly = !_cond;
            cboMemo.Enabled = _cond;
            dtpIssued.Enabled = _cond;
            dtpReceived.Enabled = _cond;
            dtpReplyReceived.Enabled = _cond;
            chkForHearing.Enabled = _cond;
            dtpDateNOAHIssued.Enabled = _cond;
            dtpDateOfNOAH.Enabled = _cond;
            dtpEffectivity.Enabled = _cond;
            txtstatus.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;        
        }

        void DisplayEmployeeCase()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {                
                List<EmployeeCase> _employeecase = _iemployee.GetEmployeeCases(_empid);
                dgvCases.RowCount = 0;
                if (_employeecase != null)
                {
                    foreach (EmployeeCase _list in _employeecase)
                    {
                        int r = dgvCases.Rows.Add();
                        dgvCases.Rows[r].Cells[0].Value = _list.ID;
                        dgvCases.Rows[r].Cells[1].Value = "Open File";
                        dgvCases.Rows[r].Cells[2].Value = _list.Caseno;
                        dgvCases.Rows[r].Cells[3].Value = _list.Memo.MemoName;
                        dgvCases.Rows[r].Cells[4].Value = _list.DateIssued;
                        dgvCases.Rows[r].Cells[5].Value = _list.Status;
                        dgvCases.Rows[r].Cells[6].Value = _list.Remarks;
                        dgvCases.Rows[r].Cells[7].Value = _list.Location;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvCases.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                EmployeeCase _employeecase = _iemployee.GetEmployeeCase(_id);
                if (_employeecase != null)
                {
                    txtCaseNo.Text = _employeecase.Caseno;
                    cboMemo.SelectedValue = _employeecase.Memo_ID;
                    if (_employeecase.DateIssued != null)
                    {
                        dtpIssued.Value = _employeecase.DateIssued.Value;
                        dtpIssued.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtpIssued.LockUpdateChecked = false;
                    }
                    if (_employeecase.DateReceived != null)
                    {
                        dtpReceived.Value = _employeecase.DateReceived.Value;
                        dtpReceived.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtpReceived.LockUpdateChecked = false;
                    }
                    if (_employeecase.DateReceivedReply != null)
                    {
                        dtpReplyReceived.Value = _employeecase.DateReceivedReply.Value;
                        dtpReplyReceived.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtpReplyReceived.LockUpdateChecked = false;
                    }
                    chkForHearing.Checked = Convert.ToBoolean(_employeecase.ForHearing);
                    if (_employeecase.DateNOAHIssued != null)
                    {
                        dtpDateNOAHIssued.Value = _employeecase.DateNOAHIssued.Value;
                        dtpDateNOAHIssued.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtpDateNOAHIssued.LockUpdateChecked = false;
                    }
                    if (_employeecase.DateOfNOAH != null)
                    {
                        dtpDateOfNOAH.Value = _employeecase.DateOfNOAH.Value;
                        dtpDateOfNOAH.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtpDateOfNOAH.LockUpdateChecked = false;
                    }
                    if (_employeecase.EffectivityDate != null)
                    {
                        dtpEffectivity.Value = _employeecase.EffectivityDate.Value;
                        dtpEffectivity.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtpEffectivity.LockUpdateChecked = false;
                    }
                    txtstatus.Text = _employeecase.Status;
                    txtRemarks.Text = _employeecase.Remarks;
                    txtFileLocation.Text = _employeecase.Location;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindMemoList(ComboBox _cmb)
        {
            iMemo _imemo = new HURISRepository.rMemo();

            try
            {
                List<Memo> _memo = _imemo.GetMemos("");
                _cmb.DataSource = _memo;
                _cmb.DisplayMember = "MemoName";
                _cmb.ValueMember = "id";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_CASE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_CASE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeCase();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OFD1.Title = "Select a file";
            OFD1.Filter = "MS Excel(*.xls;*.xlsx)|*.xls;*.xlsx|" +
                            "MS Word(*.doc;*.docx)|*.doc;*.docx|" +
                            "MS Powerpoint(*.ppt;*.pptx)|*.ppt;*.pptx|" +
                            "Acrobat reader(*.pdf)|*.pdf|" +
                            "Picture(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png|All Files(*.*)|*.*";
            OFD1.RestoreDirectory = true;

            if (OFD1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (OFD1.FileName != null)
                {
                    txtFileLocation.Text = OFD1.FileName;
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            _fileExtension = Path.GetExtension(txtFileLocation.Text);
            _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Case\";
            _filepath = _targetpath + cboMemo.Text + _fileExtension;

            if (txtCaseNo.Text.Length == 0)
            {
                MessageBox.Show("Case no. is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCaseNo.Focus();
                return;
            }
            if (cboMemo.SelectedIndex == -1)
            {
                MessageBox.Show("Memo type is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMemo.Focus();
                return;
            }
            if (txtFileLocation.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtFileLocation);
                txtFileLocation.Focus();
                return;
            }

            if (System.IO.Directory.Exists(_targetpath) == false)
            {
                Directory.CreateDirectory(_targetpath);
            }

            ManageEmployeeCases();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeCase();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmployeeCases()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            EmployeeCase _employeecase = new EmployeeCase();

            try
            {
                _employeecase.ID = _id;
                _employeecase.EmpID = _empid;
                _employeecase.Caseno = txtCaseNo.Text;
                _employeecase.Memo_ID = int.Parse(cboMemo.SelectedValue.ToString());
                if (dtpIssued.LockUpdateChecked == true)
                {
                    _employeecase.DateIssued = dtpIssued.Value;
                }
                if (dtpReceived.LockUpdateChecked == true)
                {
                    _employeecase.DateReceived = dtpReceived.Value;
                }
                if (dtpReplyReceived.LockUpdateChecked == true)
                {
                    _employeecase.DateReceivedReply = dtpReplyReceived.Value;
                }
                _employeecase.ForHearing = Convert.ToInt16(chkForHearing.Checked);
                if (dtpDateNOAHIssued.LockUpdateChecked == true)
                {
                    _employeecase.DateNOAHIssued = dtpDateNOAHIssued.Value;
                }
                if (dtpDateOfNOAH.LockUpdateChecked == true)
                {
                    _employeecase.DateOfNOAH = dtpDateOfNOAH.Value;
                }
                if (dtpEffectivity.LockUpdateChecked == true)
                {
                    _employeecase.EffectivityDate = dtpEffectivity.Value;
                }
                _employeecase.Status = txtstatus.Text;
                _employeecase.Remarks = txtRemarks.Text;
                _employeecase.Location = txtFileLocation.Text;
                _employeecase.FileExtension = _fileExtension;

                _iemployee.ManageEmployeeCase(_employeecase, _mode);
                _flag = true;

                _destinationpath = _targetpath + _id.ToString() + _fileExtension;

                if (txtFileLocation.Text.Length != 0)
                {
                    if (System.IO.File.Exists(txtFileLocation.Text))
                    {
                        if (System.IO.File.Exists(_destinationpath))
                        {
                            System.IO.File.Delete(_destinationpath);
                        }
                        System.IO.File.Copy(txtFileLocation.Text, _destinationpath, true);
                    }
                }
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            if (e.ColumnIndex == 1)
            {
                DialogResult _result = MessageBox.Show("Open file attachment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_result == DialogResult.No)
                {
                    return;
                }

                try
                {
                    System.Diagnostics.Process.Start(dgvCases.Rows[e.RowIndex].Cells[5].Value.ToString());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
