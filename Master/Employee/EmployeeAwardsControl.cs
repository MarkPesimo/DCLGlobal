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
    public partial class EmployeeAwardsControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        string _fileExtension;
        string _targetpath;
        string _filepath;
        bool _flag;

        public EmployeeAwardsControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
            BindAwardsList(cboAwards);
        }

        private void EmployeeAwardsControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeAwards();
        }

        void InitializeField()
        {
            _id = 0;
            cboAwards.SelectedIndex = -1;
            txtRemarks.Text = "";
            txtFileLocation.Text = "";
            dtDateIssue.Value = DateTime.Now;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvAwards.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
            btnBrowse.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            cboAwards.Enabled = _cond;
            dtDateIssue.Enabled = _cond;
            txtRemarks.ReadOnly = !_cond;
        }

        void DisplayEmployeeAwards()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Award> _employeeaward = _iemployee.GetEmployeeAwards(_empid);
                dgvAwards.RowCount = 0;
                if (_employeeaward != null)
                {
                    foreach (Employee_Award _list in _employeeaward)
                    {
                        int r = dgvAwards.Rows.Add();
                        dgvAwards.Rows[r].Cells[0].Value = _list.id;
                        dgvAwards.Rows[r].Cells[1].Value = "Open File";
                        dgvAwards.Rows[r].Cells[2].Value = _list.Award.Awards;
                        dgvAwards.Rows[r].Cells[3].Value = _list.Dateissued;
                        dgvAwards.Rows[r].Cells[4].Value = _list.Remarks;
                        dgvAwards.Rows[r].Cells[5].Value = _list.Location;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAwards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvAwards.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Award _employeeaward = _iemployee.GetEmployeeAward(_id);
                if (_employeeaward != null)
                {
                    cboAwards.SelectedValue = _employeeaward.Awards_id;
                    if (_employeeaward.Dateissued != null)
                    {
                        dtDateIssue.Value = _employeeaward.Dateissued.Value;
                        dtDateIssue.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtDateIssue.LockUpdateChecked = false;
                    }
                    txtRemarks.Text = _employeeaward.Remarks;
                    txtFileLocation.Text = _employeeaward.Location;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindAwardsList(ComboBox _cmb)
        {
            iAward _iaward = new HURISRepository.rAward();

            try
            {
                List<Award> _award = _iaward.GetAwards("");
                _cmb.DataSource = _award;
                _cmb.DisplayMember = "awards";
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
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_AWARD, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_AWARD, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeAwards();
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
            _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Awards\";
            _filepath = _targetpath + cboAwards.Text + _fileExtension;

            if (cboAwards.SelectedIndex == -1)
            {
                MessageBox.Show("Please select awards title.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboAwards.Focus();
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

            ManageEmployeeAward();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeAwards();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmployeeAward()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Award _employeeaward = new Employee_Award();

            try
            {
                _employeeaward.id = _id;
                _employeeaward.EmpId = _empid;
                _employeeaward.Awards_id = int.Parse(cboAwards.SelectedValue.ToString());
                if (dtDateIssue.LockUpdateChecked == true)
                {
                    _employeeaward.Dateissued = dtDateIssue.Value;
                }
                _employeeaward.Remarks = txtRemarks.Text;
                _employeeaward.Location = _filepath;

                _iemployee.ManageEmployeeAward(_employeeaward, _mode);
                _flag = true;

                if (txtFileLocation.Text.Length != 0)
                {
                    if (txtFileLocation.Text != _filepath)
                    {
                        if (System.IO.File.Exists(_filepath))
                        {
                            System.IO.File.Delete(_filepath);
                        }
                        System.IO.File.Copy(txtFileLocation.Text, _filepath, true);
                    }
                }
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAwards_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    System.Diagnostics.Process.Start(dgvAwards.Rows[e.RowIndex].Cells[5].Value.ToString());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
