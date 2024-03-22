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

using DevComponents.DotNetBar;
using System.IO;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeTrainingControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        string _fileExtension;
        string _targetpath;
        string _filepath;
        bool _flag;

        public EmployeeTrainingControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmployeeTrainingControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            BindTrainingList(cboTraining);
            DisplayEmployeeTraining();
        }

        void InitializeField()
        {
            _id = 0;
            cboTraining.SelectedIndex = -1;
            txtFacilitator.Text = "";
            txtAddress.Text = "";
            txtRemarks.Text = "";
            txtFileLocation.Text = "";
            dblcost.Value = 0;
            chkInternal.Checked = false;
            dtDateFrom.Value = DateTime.Now;
            dtDateFrom.LockUpdateChecked = false;
            dtDateTo.Value = DateTime.Now;
            dtDateTo.LockUpdateChecked = false;
            txtNoOfHours.Text = "0";
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            btnBrowse.Enabled = _cond;
            dgvTrainings.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;            
            btnBrowse.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtFacilitator.ReadOnly = !_cond;
            txtAddress.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;
            txtNoOfHours.ReadOnly = !_cond;
            cboTraining.Enabled = _cond;
            dblcost.Enabled = _cond;
            chkInternal.Enabled = _cond;
            dtDateFrom.Enabled = _cond;
            dtDateTo.Enabled = _cond;
        }

        void BindTrainingList(ComboBox _cmb)
        {
            iHRTraining _itraining = new HURISRepository.rHRTraining();

            try
            {
                List<HRTraining> _training = _itraining.GetTrainings("");
                _cmb.DataSource = _training;
                _cmb.DisplayMember = "training_name";
                _cmb.ValueMember = "training_id";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayEmployeeTraining()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Training> _employeetraining = _iemployee.GetEmployeeTrainings(_empid);
                dgvTrainings.RowCount = 0;
                if (_employeetraining != null)
                {
                    foreach (Employee_Training _list in _employeetraining)
                    {
                        int r = dgvTrainings.Rows.Add();
                        dgvTrainings.Rows[r].Cells[0].Value = _list.ID;
                        dgvTrainings.Rows[r].Cells[1].Value = "Open File";
                        dgvTrainings.Rows[r].Cells[2].Value = _list.HRTraining.Training_name;
                        if (_list.DateIssued != null)
                        {
                            dgvTrainings.Rows[r].Cells[3].Value = _list.DateIssued.Value.ToShortDateString();
                        }
                        if (_list.DateTo != null)
                        {
                            dgvTrainings.Rows[r].Cells[4].Value = _list.DateTo.Value.ToShortDateString();
                        }                           
                        dgvTrainings.Rows[r].Cells[5].Value = _list.Address;
                        dgvTrainings.Rows[r].Cells[6].Value = _list.Facilitator;
                        dgvTrainings.Rows[r].Cells[7].Value = _list.Location;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTrainings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvTrainings.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Training _employeetraining = _iemployee.GetEmployeeTraining(_id);
                if (_employeetraining != null)
                {
                    cboTraining.SelectedValue = _employeetraining.Training_id;
                    txtFacilitator.Text = _employeetraining.Facilitator;
                    if (_employeetraining.DateIssued != null)
                    {
                        dtDateFrom.Value = _employeetraining.DateIssued.Value;
                        dtDateFrom.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtDateFrom.LockUpdateChecked = false;
                    }
                    if (_employeetraining.DateTo != null)
                    {
                        dtDateTo.Value = _employeetraining.DateTo.Value;
                        dtDateTo.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtDateTo.LockUpdateChecked = false;
                    }
                    txtAddress.Text = _employeetraining.Address;
                    dblcost.Value = double.Parse(_employeetraining.Cost.ToString());
                    chkInternal.Checked = Convert.ToBoolean(_employeetraining.Internal);
                    txtNoOfHours.Text = _employeetraining.NoOfHours.ToString();
                    txtRemarks.Text = _employeetraining.Remarks;
                    txtFileLocation.Text = _employeetraining.Location;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TRAINING, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TRAINING, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            if (_id == 0)
            {
                MessageBox.Show("Please select a record to edit.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeTraining();
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
            _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Trainings\";
            _filepath = _targetpath + cboTraining.Text + _fileExtension;

            if (cboTraining.SelectedIndex == -1)
            {
                MessageBox.Show("Training title is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTraining.Focus();
                return;
            }
            if (txtFacilitator.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtFacilitator);
                txtFacilitator.Focus();
                return;
            }
            if (txtAddress.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtAddress);
                txtAddress.Focus();
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

            ManageEmployeeTrainings();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeTraining();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmployeeTrainings()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Training _employeetraining = new Employee_Training();

            try
            {
                _employeetraining.ID = _id;
                _employeetraining.EmpID = _empid;
                _employeetraining.Training_id = int.Parse(cboTraining.SelectedValue.ToString());
                _employeetraining.Address = txtAddress.Text;
                _employeetraining.Facilitator = txtFacilitator.Text;
                _employeetraining.Remarks = txtRemarks.Text;
                _employeetraining.Cost = Convert.ToDecimal(dblcost.Value);
                _employeetraining.Location = _filepath;
                _employeetraining.NoOfHours = Convert.ToDecimal(txtNoOfHours.Text);
                _employeetraining.Internal = Convert.ToInt16(chkInternal.Checked);
                if (dtDateFrom.LockUpdateChecked == true)
                {
                    _employeetraining.DateIssued = dtDateFrom.Value;
                }
                if (dtDateTo.LockUpdateChecked == true)
                {
                    _employeetraining.DateTo = dtDateTo.Value;
                }

                _id =_iemployee.ManageEmployeeTraining_new(_employeetraining, _mode);
                
                //updated by   : kuto 
                //date updated : 11/09/2021 0437pm
                //description  : save the id as filename
                _filepath = _targetpath + _id.ToString() + _fileExtension;
                //date updated : 11/09/2021 0437pm

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

        private void dgvTrainings_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Trainings\";
                    _fileExtension = Path.GetExtension(txtFileLocation.Text);
                    _filepath = _targetpath + _id + _fileExtension;

                    System.Diagnostics.Process.Start(_filepath);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
