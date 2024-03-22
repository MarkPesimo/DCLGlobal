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
    public partial class EmployeeInsuranceControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        string _fileExtension;
        string _targetpath;
        string _filepath;
        bool _flag;

        public EmployeeInsuranceControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmployeeInsuranceControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeInsurance();
        }

        void InitializeField()
        {
            _id = 0;
            txtFileLocation.Text = "";
            txtInsuranceName.Text = "";
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvInsurance.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
            btnBrowse.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtInsuranceName.ReadOnly = !_cond;
        }

        void DisplayEmployeeInsurance()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Insurance> _employeeinsurance = _iemployee.GetEmployeeInsurances(_empid);
                dgvInsurance.RowCount = 0;
                if (_employeeinsurance != null)
                {
                    foreach (Employee_Insurance _list in _employeeinsurance)
                    {
                        int r = dgvInsurance.Rows.Add();
                        dgvInsurance.Rows[r].Cells[0].Value = _list.employeeinsuranceID;
                        dgvInsurance.Rows[r].Cells[1].Value = "Open File";
                        dgvInsurance.Rows[r].Cells[2].Value = _list.employeeinsuranceNAME;
                        dgvInsurance.Rows[r].Cells[3].Value = _list.employeeinsuranceLOCATION;
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
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_INSURANCE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
            txtInsuranceName.Focus();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_INSURANCE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeInsurance();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            _fileExtension = Path.GetExtension(txtFileLocation.Text);
            _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Insurance\";
            _filepath = _targetpath + txtInsuranceName.Text + _fileExtension;

            if (txtInsuranceName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtInsuranceName);
                txtInsuranceName.Focus();
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

            ManageEmployeeInsurance();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeInsurance();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmployeeInsurance()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Insurance _employeeinsurance = new Employee_Insurance();

            try
            {
                _employeeinsurance.employeeinsuranceID = _id;
                _employeeinsurance.empID = _empid;
                _employeeinsurance.employeeinsuranceNAME = txtInsuranceName.Text;
                _employeeinsurance.employeeinsuranceLOCATION = _filepath;

                _iemployee.ManageEmployeeInsurance(_employeeinsurance, _mode);
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

        private void dgvInsurance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvInsurance.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Insurance _employeeinsurance = _iemployee.GetEmployeeInsurance(_id);
                if (_employeeinsurance != null)
                {
                    txtInsuranceName.Text = _employeeinsurance.employeeinsuranceNAME;
                    txtFileLocation.Text = _employeeinsurance.employeeinsuranceLOCATION;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInsurance_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    System.Diagnostics.Process.Start(dgvInsurance.Rows[e.RowIndex].Cells[3].Value.ToString());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
