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
    public partial class EmployeeLicensureControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        string _fileExtension;
        string _targetpath;
        string _filepath;
        bool _flag;

        public EmployeeLicensureControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void EmployeeLicensureControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeLicensure();
        }

        void InitializeField()
        {
            _id = 0;
            txtLicenseName.Text = "";
            txtLicenseNo.Text = "";
            txtPlaceIssued.Text = "";
            txtFileLocation.Text = "";
            dtDateExpired.Value = DateTime.Now;
            dtDateExpired.LockUpdateChecked = false;
            dtDateIssued.Value = DateTime.Now;
            dtDateIssued.LockUpdateChecked = false;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvLicensure.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
            btnBrowse.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            txtLicenseName.ReadOnly = !_cond;
            txtLicenseNo.ReadOnly = !_cond;
            txtPlaceIssued.ReadOnly = !_cond;
            //txtFileLocation.ReadOnly = !_cond;
            dtDateExpired.Enabled = _cond;
            dtDateIssued.Enabled = _cond;
        }

        void DisplayEmployeeLicensure()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Licensure> _employeelicensure = _iemployee.GetEmployeeLicensures(_empid);
                dgvLicensure.RowCount = 0;
                if (_employeelicensure != null)
                {
                    foreach (Employee_Licensure _list in _employeelicensure)
                    {
                        int r = dgvLicensure.Rows.Add();
                        dgvLicensure.Rows[r].Cells[0].Value=_list.employeelicensureID;
                        dgvLicensure.Rows[r].Cells[1].Value = "Open File";
                        dgvLicensure.Rows[r].Cells[2].Value = _list.employeelicensureNAME;
                        dgvLicensure.Rows[r].Cells[3].Value = _list.employeelicensureNO;
                        dgvLicensure.Rows[r].Cells[4].Value = _list.employeelicensureDATEISSUED.Value.ToShortDateString();
                        dgvLicensure.Rows[r].Cells[5].Value = _list.employeelicensureDATEEXPIRED.Value.ToShortDateString();
                        dgvLicensure.Rows[r].Cells[6].Value = _list.employeelicensurePLACEISSUED;
                        dgvLicensure.Rows[r].Cells[7].Value = _list.employeelicensureLOCATION;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLicensure_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvLicensure.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Licensure _employeelicensure = _iemployee.GetEmployeeLicensure(_id);
                if (_employeelicensure != null)
                {
                    txtLicenseName.Text = _employeelicensure.employeelicensureNAME;
                    txtLicenseNo.Text = _employeelicensure.employeelicensureNO;
                    txtPlaceIssued.Text = _employeelicensure.employeelicensurePLACEISSUED;
                    txtFileLocation.Text = _employeelicensure.employeelicensureLOCATION;
                    if (_employeelicensure.employeelicensureDATEISSUED != null)
                    {
                        dtDateIssued.Value = _employeelicensure.employeelicensureDATEISSUED.Value;
                        dtDateIssued.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtDateIssued.LockUpdateChecked = false;
                    }
                    if (_employeelicensure.employeelicensureDATEEXPIRED != null)
                    {
                        dtDateExpired.Value = _employeelicensure.employeelicensureDATEEXPIRED.Value;
                        dtDateExpired.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtDateExpired.LockUpdateChecked = false;
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
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LICENSURE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LICENSURE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OFD1.Title = "Select a file";
            OFD1.Filter =   "MS Excel(*.xls;*.xlsx)|*.xls;*.xlsx|" +
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
            _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Licensure\";
            _filepath = _targetpath + txtLicenseName.Text + _fileExtension;

            if (txtLicenseName.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtLicenseName);
                txtLicenseName.Focus();
                return;
            }
            if (txtLicenseNo.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtLicenseNo);
                txtLicenseNo.Focus();
                return;
            }
            if (txtPlaceIssued.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtPlaceIssued);
                txtPlaceIssued.Focus();
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

            ManageEmployeeLicensure();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeLicensure();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmployeeLicensure()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Licensure _employeelicensure = new Employee_Licensure();

            try
            {
                _employeelicensure.employeelicensureID = _id;
                _employeelicensure.empID = _empid;
                _employeelicensure.employeelicensureNAME = txtLicenseName.Text;
                _employeelicensure.employeelicensureNO = txtLicenseNo.Text;
                _employeelicensure.employeelicensurePLACEISSUED = txtPlaceIssued.Text;
                _employeelicensure.employeelicensureLOCATION = _filepath;
                if (dtDateIssued.LockUpdateChecked == true)
                {
                    _employeelicensure.employeelicensureDATEISSUED = dtDateIssued.Value;
                }
                if (dtDateExpired.LockUpdateChecked == true)
                {
                    _employeelicensure.employeelicensureDATEEXPIRED = dtDateExpired.Value;
                }

                _id =  _iemployee.ManageEmployeeLicensure_new(_employeelicensure, _mode);
                
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

        private void dgvLicensure_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    System.Diagnostics.Process.Start(dgvLicensure.Rows[e.RowIndex].Cells[7].Value.ToString());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
