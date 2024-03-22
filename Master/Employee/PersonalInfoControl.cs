using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

using CAL.Model;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using DCLGlobal.Classes;
using CAL.Global;
using DCLGlobal.Master.Main.Employee;

namespace DCLGlobal.Master.Employee
{
    public partial class PersonalInfoControl : UserControl
    {
        public int _empid;
        List<double> _los = new List<double>();
        int _mode = 0;
        int _stat;
        bool _flag;
        int cnt = 0;
        int _cityID = 0;
        int _provinceID = 0;
        bool _loading = true;
        EmployeeInfo _parent;

        public PersonalInfoControl(int _EMPID, EmployeeInfo _Parent)
        {

            InitializeComponent();
            _parent = _Parent;
            BindCompany(cmbCompany);
            BindBranch(cmbBranch);
            //BindDepartment(cmbDepartment);
            BindPosition(cmbPosition);
            BindSalaryType(cmbSalaryType);
            BindEmployeeRank(cmbEmpRank);
            BindEmployeeType(cmbEmpType);
            BindShift(cmbShift);
            _empid = _EMPID;
        }

        private void PersonalInfoControl_Load(object sender, EventArgs e)
        {            
            DisplayEmployeeInfo();
            //EnableButton(true);
            //EnableForm(false);
            if (_empid == 0)
            {
                if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
                _parent.ClearImage();
                _mode = 1;
                EnableForm(true);
                EnableButton(false);
                InitializeField();
                _loading = false;
            }
            else
            {
                EnableButton(true);
                EnableForm(false);
            }
        }

        void DisplayEmployeeInfo()
        { 
            iEmployee _iemployee = new HURISRepository.rEmployee();
            _loading = true;

            try
            {
                CAL.Model.Employee _employee = _iemployee.GetEmployee(_empid);
                if (_employee != null)
                {
                    txtEmpNo.Text = _employee.Emp_No;
                    txtLname.Text = _employee.Lastname;
                    txtFname.Text = _employee.Firstname;
                    txtMName.Text = _employee.Middlename;
                    if (_employee.Birthday != null)
                    {
                        dtBDate.Value = _employee.Birthday.Value;
                        dtBDate.LockUpdateChecked = true;                                       
                    }
                    else
                    {
                        dtBDate.LockUpdateChecked = false;
                    }
                    txtAge.Text = GlobalToolsControl.HURIS.ComputeAge(_employee.Birthday.Value).ToString();                                          
                    txtBPlace.Text = _employee.Birthplace;
                    txtCitizenship.Text = _employee.Citizenship;
                    txtAddress.Text = _employee.Address;
                    txtProvAdress.Text = _employee.Prov_Address;
                    txtSpouseName.Text = _employee.Spouse;
                    txtSpouseCompany.Text = _employee.Spouse_comp;
                    txtSpouseCompAdd.Text = _employee.Spouse_address;
                    cmbGender.Text = _employee.Gender;
                    cmbCivilStat.Text = _employee.CivilStatus;
                    txtHeight.Text = _employee.Height;
                    txtWeight.Text = _employee.Weight;
                    txtReligion.Text = _employee.Religion;
                    txtHomeMobileno.Text = _employee.Contact_No;
                    txtEmail.Text = _employee.EmailAddress;
                    txtHobbies.Text = _employee.Hobbies;
                    txtContPerson.Text = _employee.Contact_person;
                    txtContRelation.Text = _employee.Contact_relation;
                    txtContNo.Text = _employee.Contact_Telno;
                    txtContAddres.Text = _employee.Contact_Address;
                    cmbCompany.SelectedValue = _employee.CompID;
                    BindDepartment(cmbDepartment, int.Parse(cmbCompany.SelectedValue.ToString()));

                    cmbBranch.SelectedValue = _employee.Branch_ID;
                    cmbDepartment.SelectedValue = _employee.Department_ID;
                    cmbPosition.SelectedValue = _employee.Salary_ID;
                    cmbSalaryType.SelectedValue = _employee.SalaryType_ID;
                    cmbEmpRank.SelectedValue = _employee.EmpRank_ID;
                    cmbEmpType.SelectedValue = _employee.EmpType_ID;
                    cmbShift.SelectedValue = _employee.Shift_ID;
                    _los = GlobalToolsControl.HURIS.ComputeLOS(_employee.Datehired, _employee.Dateresigned);                    
                    txtYear.Text = _los[0].ToString();
                    txtMonth.Text = _los[1].ToString();
                    txtPhilNo.Text = _employee.Philhealth_no;
                    txtPagIbig.Text = _employee.Pagibig_no;
                    txtSSSNo.Text = _employee.SSS_no;
                    txtTINNo.Text = _employee.Tax_no;
                    if (_employee.Datehired != null)
                    {
                        dtDateHire.Checked = true;
                        dtDateHire.Value = _employee.Datehired.Value;
                    }
                    else
                    {
                        dtDateHire.Checked = false;
                    }
                    if (_employee.Dateregular != null)
                    {
                        dtDateRegular.Checked = true;
                        dtDateRegular.Value = _employee.Dateregular.Value;
                    }
                    else
                    {
                        dtDateRegular.Checked = false;
                    }
                    //if (_employee.Dateresigned != null)
                    //{
                    //    dtDateResigned.Checked = true;
                    //    dtDateResigned.Value = _employee.Dateresigned.Value;
                    //}
                    //else
                    //{
                    //    dtDateResigned.Checked = false;
                    //}
                    //txtResignRemarks.Text = _employee.ResignedRemarks;
                    if (_employee.ActiveInactive == 1)
                    {
                        chkIsActive.Checked = true;
                    }
                    else
                    {
                        chkIsActive.Checked = false;
                    }
                    if (_employee.ContractStart != null)
                    {
                        dtContractStart.Checked = true;
                        dtContractStart.Value = _employee.ContractStart.Value;
                    }
                    else
                    {
                        dtContractStart.Checked = false;
                    }
                    if (_employee.ContractEnd != null)
                    {
                        dtContractEnd.Checked = true;
                        dtContractEnd.Value = _employee.ContractEnd.Value;
                    }
                    else
                    {
                        dtContractEnd.Checked = false;
                    }
                    if (_employee.CityID == null)
                    {
                        txtCity.Text = "";
                        _cityID = 0;
                    }
                    else
                    {
                        txtCity.Text = _employee.AreaLibrary.AreaDescription;
                        _cityID = Convert.ToInt16(_employee.CityID);
                    }
                    if (_employee.ProvinceID == null)
                    {
                        txtProvince.Text = "";
                        _provinceID = 0;
                    }
                    else
                    {
                        txtProvince.Text = _employee.AreaLibrary1.AreaDescription;
                        _provinceID = Convert.ToInt16(_employee.ProvinceID);
                    }                                        
                }

                _loading = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindCompany(ComboBox _cmb)
        {
            iCompany _icompany = new HURISRepository.rCompany();

            try
            {
                List<Company> _company = (from d in _icompany.GetCompanies("") orderby d.CompanyName select d).ToList();
                _cmb.DataSource = _company;
                _cmb.DisplayMember = "CompanyName";
                _cmb.ValueMember = "CompID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindBranch(ComboBox _cmb)
        {
            iBranch _ibranch = new HURISRepository.rBranch();

            try
            {
                List<Branch> _branch = (from d in _ibranch.GetBranches("") orderby d.Branch_Desc select d).ToList();
                _cmb.DataSource = _branch;
                _cmb.DisplayMember = "Branch_Desc";
                _cmb.ValueMember = "Branch_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindDepartment(ComboBox _cmb, int _compID)
        {
            iDepartment _idepartment = new HURISRepository.rDepartment();

            try
            {
                List<Department> _department = (from d in _idepartment.GetDepartments("", _compID) orderby d.Dept_Name select d).ToList();
                _cmb.DataSource = _department;
                _cmb.DisplayMember = "Dept_Name";
                _cmb.ValueMember = "Dept_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindPosition(ComboBox _cmb)
        {
            iSalary _isalary = new HURISRepository.rSalary();

            try
            {
                List<Salary> _salary = (from d in _isalary.GetSalaries("") orderby d.Salary_Desc select d).ToList();
                _cmb.DataSource = _salary;
                _cmb.DisplayMember = "Salary_Desc";
                _cmb.ValueMember = "Salary_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindSalaryType(ComboBox _cmb)
        {
            iSalaryType _isalarytype = new HURISRepository.rSalaryType();

            try
            {
                List<Salarytype> _salarytype = (from d in _isalarytype.GetSalaryTypes("") orderby d.Salarytype_Desc select d).ToList();
                _cmb.DataSource = _salarytype;
                _cmb.DisplayMember = "Salarytype_Desc";
                _cmb.ValueMember = "Salarytype_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindEmployeeRank(ComboBox _cmb)
        {
            iEmployeeRank _iemployeerank = new HURISRepository.rEmployeeRank();

            try
            {
                List<EmployeeRank> _employeerank = (from d in _iemployeerank.GetEmployeeRanks("") orderby d.RankName select d).ToList();
                _cmb.DataSource = _employeerank;
                _cmb.DisplayMember = "RankName";
                _cmb.ValueMember = "Rank_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindEmployeeType(ComboBox _cmb)
        {
            iEmployeeType _iemployeetype = new HURISRepository.rEmployeeType();

            try
            {
                List<EmployeeType> _employeetype = (from d in _iemployeetype.GetEmployeeTypes("") orderby d.EmpType_Desc select d).ToList();
                _cmb.DataSource = _employeetype;
                _cmb.DisplayMember = "EmpType_Desc";
                _cmb.ValueMember = "EmpType_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindShift(ComboBox _cmb)
        {
            iShift _ishift = new HURISRepository.rShift();

            try
            {
                List<Shift> _shift = (from d in _ishift.GetShifts("") orderby d.Description select d).ToList();
                _cmb.DataSource = _shift;
                _cmb.DisplayMember = "Description";
                _cmb.ValueMember = "Shift_ID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        void BindSeparation_Reason(ComboBox _cmb)
        {

        }
        void EnableForm(bool _cond)
        {
            txtEmpNo.ReadOnly = !_cond;
            txtFname.ReadOnly = !_cond;
            txtLname.ReadOnly = !_cond;
            txtMName.ReadOnly = !_cond;
            dtBDate.Enabled = _cond;
            txtBPlace.ReadOnly = !_cond;
            txtCitizenship.ReadOnly = !_cond;
            txtAddress.ReadOnly = !_cond;
            txtProvAdress.ReadOnly = !_cond;
            cmbGender.Enabled = _cond;
            cmbCivilStat.Enabled = _cond;
            txtHeight.ReadOnly = !_cond;
            txtWeight.ReadOnly = !_cond;
            txtReligion.ReadOnly = !_cond;
            txtHomeMobileno.ReadOnly = !_cond;
            txtEmail.ReadOnly = !_cond;
            txtHobbies.ReadOnly = !_cond;
            txtSpouseName.ReadOnly = !_cond;
            txtSpouseCompany.ReadOnly = !_cond;
            txtSpouseCompAdd.ReadOnly = !_cond;
            txtContPerson.ReadOnly = !_cond;
            txtContRelation.ReadOnly = !_cond;
            txtContNo.ReadOnly = !_cond;
            txtContAddres.ReadOnly = !_cond;
            cmbCompany.Enabled = _cond;
            cmbBranch.Enabled = _cond;
            cmbDepartment.Enabled = _cond;
            cmbPosition.Enabled = _cond;
            cmbSalaryType.Enabled = _cond;
            cmbEmpRank.Enabled = _cond;
            cmbEmpType.Enabled = _cond;
            cmbShift.Enabled = _cond;
            txtPhilNo.ReadOnly = !_cond;
            txtSSSNo.ReadOnly = !_cond;
            txtPagIbig.ReadOnly = !_cond;
            txtTINNo.ReadOnly = !_cond;
            dtDateHire.Enabled = _cond;
            dtDateRegular.Enabled = _cond;
            //dtDateResigned.Enabled = _cond;
            //txtResignRemarks.ReadOnly = !_cond;
            chkIsActive.Enabled = _cond;
            dtContractStart.Enabled = _cond;
            dtContractEnd.Enabled = _cond;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            _parent.ClearImage();
            _mode = 1;
            EnableForm(true);
            EnableButton(false);
            InitializeField();
            _loading = false;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableForm(true);
            EnableButton(false);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

            //iPayroll _ipayroll = new IHOPSFilesRepository.rPayroll();
            //Payroll_HD _payroll = _ipayroll.GetPayrollHeader(false);

            //if (_payroll != null)
            //{
            //    if (_payroll.Status == false)
            //    {
            //        MessageBox.Show("Editing of employee information is not permitted while payroll processing is on-going.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            
            DialogResult _result = MessageBox.Show("Are you sure you want to save employee information?", "Save", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (_result == DialogResult.No)
            {
                return;
            }

            ManageEmployee();
            DisplayEmployeeInfo();
            EnableButton(true);
            EnableForm(false);

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }
        }

        void ManageEmployee()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            CAL.Model.Employee _employee = new CAL.Model.Employee();

            try
            {
                if (chkIsActive.Checked == true)
                {
                    _stat = 1;
                }
                else
                {
                    _stat = 0;
                }

                _employee.Emp_ID = _empid;
                _employee.Emp_No = txtEmpNo.Text;
                _employee.Firstname = txtFname.Text;
                _employee.Lastname = txtLname.Text;
                _employee.Middlename = txtMName.Text;
                _employee.Birthday = dtBDate.Value;
                _employee.Birthplace = txtBPlace.Text;
                _employee.Citizenship = txtCitizenship.Text;
                _employee.Gender = cmbGender.Text;
                _employee.CivilStatus = cmbCivilStat.Text;
                _employee.Height = txtHeight.Text;
                _employee.Weight = txtWeight.Text;
                _employee.Religion = txtReligion.Text;
                _employee.Contact_No = txtHomeMobileno.Text;
                _employee.EmailAddress = txtEmail.Text;
                _employee.Hobbies = txtHobbies.Text;
                _employee.Address = txtAddress.Text;
                _employee.Prov_Address = txtProvAdress.Text;
                _employee.Spouse = txtSpouseName.Text;
                _employee.Spouse_comp = txtSpouseCompAdd.Text;
                _employee.Spouse_address = txtSpouseCompAdd.Text;
                _employee.Contact_person = txtContPerson.Text;
                _employee.Contact_Telno = txtContNo.Text;
                _employee.Contact_relation = txtContRelation.Text;
                _employee.Contact_Address = txtContAddres.Text;
                _employee.CompID = int.Parse(cmbCompany.SelectedValue.ToString());
                _employee.Branch_ID = int.Parse(cmbBranch.SelectedValue.ToString());
                _employee.Department_ID = int.Parse(cmbDepartment.SelectedValue.ToString());
                _employee.Salary_ID = int.Parse(cmbPosition.SelectedValue.ToString());
                _employee.SalaryType_ID = int.Parse(cmbSalaryType.SelectedValue.ToString());
                _employee.EmpRank_ID = int.Parse(cmbEmpRank.SelectedValue.ToString());
                _employee.EmpType_ID = int.Parse(cmbEmpType.SelectedValue.ToString());
                _employee.Shift_ID = int.Parse(cmbShift.SelectedValue.ToString());
                _employee.Philhealth_no = txtPhilNo.Text;
                _employee.SSS_no = txtSSSNo.Text;
                _employee.Pagibig_no = txtPagIbig.Text;
                _employee.Tax_no = txtTINNo.Text;
                _employee.Datehired = dtDateHire.Value;
                if (dtDateRegular.Checked == true)
                {
                    _employee.Dateregular = dtDateRegular.Value;
                }
                //if (dtDateResigned.Checked == true)
                //{
                //    _employee.Dateresigned = dtDateResigned.Value;
                //}                
                //_employee.ResignedRemarks = txtResignRemarks.Text;
                _employee.ActiveInactive = Int16.Parse(_stat.ToString());

                _empid = _iemployee.ManageEmployee(_employee, _mode);
                _flag = true;
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _loading = true;
            _empid = 0;
            txtEmpNo.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtMName.Text = "";
            dtBDate.Value = DateTime.Now;
            dtBDate.LockUpdateChecked = false;
            txtBPlace.Text = "";
            txtCitizenship.Text = "";
            txtAddress.Text = "";
            txtProvAdress.Text = "";
            cmbGender.Text = "";
            cmbCivilStat.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtReligion.Text = "";
            txtHomeMobileno.Text = "";
            txtEmail.Text = "";
            txtHobbies.Text = "";
            txtSpouseName.Text = "";
            txtSpouseCompany.Text = "";
            txtSpouseCompAdd.Text = "";
            txtContPerson.Text = "";
            txtContRelation.Text = "";
            txtContNo.Text = "";
            txtContAddres.Text = "";
            txtAge.Text = "";
            cmbCompany.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            //cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            cmbSalaryType.SelectedIndex = -1;
            cmbEmpRank.SelectedIndex = -1;
            cmbEmpType.SelectedIndex = -1;
            cmbShift.SelectedIndex = -1;
            txtPhilNo.Text = "";
            txtSSSNo.Text = "";
            txtPagIbig.Text = "";
            txtTINNo.Text = "";
            dtDateHire.Value = DateTime.Now;
            dtDateHire.Checked = false;
            dtDateRegular.Value = DateTime.Now;
            dtDateRegular.Checked = false;
            //dtDateResigned.Value = DateTime.Now;
            //dtDateResigned.Checked = false;
            //txtResignRemarks.Text = "";
            chkIsActive.Checked = true;
            _loading = false;        
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {           
            EnableForm(false);
            EnableButton(true);
            DisplayEmployeeInfo();
            //InitializeField();
        }

        private void PrintCV_btn_Click(object sender, EventArgs e)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook xlWorkbook;
            Worksheet xlWorksheet;

            if (txtEmpNo.Text == "" || _empid == 0) { return; }

            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

            if (MessageBox.Show("Generate employee CV?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            try
            {
                string Path = DCLSystemConfiguration.HURIS.Reportpath + "Application Form 2011.xlsx";

                if (File.Exists(Path) == false)
                {
                    MessageBox.Show(Path + "does not exist!", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                xlWorkbook = excel.Workbooks.Open(Path);
                xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Cells[3, "A"] = cmbCompany.Text;

                CAL.Model.Employee _employee = _iemployee.GetEmployee(_empid);

                if (_employee != null)
                {
                    xlWorksheet.Cells[8, "B"] = _employee.Department.Dept_Name;
                    xlWorksheet.Cells[9, "B"] = _employee.Salary.Salary_Desc;

                    xlWorksheet.Cells[13, "A"] = _employee.Lastname;
                    xlWorksheet.Cells[13, "D"] = _employee.Firstname;
                    xlWorksheet.Cells[13, "H"] = _employee.Middlename;

                    xlWorksheet.Cells[15, "B"] = _employee.Birthday;
                    xlWorksheet.Cells[15, "F"] = _employee.Birthplace;
                    xlWorksheet.Cells[15, "J"] = GlobalToolsControl.HURIS.ComputeAge(_employee.Birthday);

                    xlWorksheet.Cells[16, "B"] = _employee.Address;
                    xlWorksheet.Cells[17, "H"] = _employee.Contact_No;

                    xlWorksheet.Cells[18, "B"] = _employee.Prov_Address;
                    xlWorksheet.Cells[19, "B"] = _employee.Gender;
                    
                    xlWorksheet.Cells[19, "E"] = _employee.Citizenship;
                    xlWorksheet.Cells[19, "H"] = _employee.Religion;

                    xlWorksheet.Cells[20, "B"] = _employee.Height;
                    xlWorksheet.Cells[20, "D"] = _employee.SSS_no;
                    xlWorksheet.Cells[20, "H"] = _employee.Tax_no;
                    xlWorksheet.Cells[21, "B"] = _employee.Weight;
                    xlWorksheet.Cells[21, "D"] = _employee.Pagibig_no;
                    xlWorksheet.Cells[21, "H"] = _employee.Philhealth_no;

                    if (_employee.CivilStatus == "Single")
                        {xlWorksheet.Cells[22, "B"] = "X";}
                    else if (_employee.CivilStatus == "Married")
                        {xlWorksheet.Cells[22, "D"] = "X";}
                    else if (_employee.CivilStatus == "Widow")
                        {xlWorksheet.Cells[22, "F"] = "X";}
                    else if (_employee.CivilStatus == "Separated")
                        {xlWorksheet.Cells[22, "H"] = "X";}

                    xlWorksheet.Cells[23, "C"] = _employee.Spouse;
                    xlWorksheet.Cells[24, "C"] = _employee.Spouse_comp;
                    xlWorksheet.Cells[24, "C"] = _employee.Spouse_address;
                    
                    xlWorksheet.Cells[37, "B"] = _employee.Contact_person;
                    xlWorksheet.Cells[37, "F"] = _employee.Contact_relation;
                    xlWorksheet.Cells[37, "I"] = _employee.Contact_Telno;
                    xlWorksheet.Cells[38, "B"] = _employee.Contact_Address;

                    cnt = 26;
                    List<Employee_Child> _employeechild = (from d in _iemployee.GetEmployeeChildren(_empid) select d).Take(6).ToList();

                    if (_employeechild != null)
                    {
                        foreach(Employee_Child _list in _employeechild)
                        {
                            xlWorksheet.Cells[cnt, "A"] = _list.Child_name;
                            xlWorksheet.Cells[cnt, "F"] = _list.Occupation;
                            xlWorksheet.Cells[cnt, "I"] = GlobalToolsControl.HURIS.ComputeAge(_list.Child_Bday);

                            cnt = cnt + 1;
                        }
                    }

                    List<Employee_Education> _employeeeducation = _iemployee.GetEmployeeEducations(_empid);
                    if (_employeeeducation != null)
                    {
                        foreach (Employee_Education _list in _employeeeducation)
                        {
                            if (_list.School_Level == "Secondary")
                            {
                                cnt = 43;
                                xlWorksheet.Cells[cnt, "A"] = "Secondary: " + _list.School_Name;
                                xlWorksheet.Cells[cnt, "F"] = _list.School_From;
                                xlWorksheet.Cells[cnt, "G"] = _list.School_To;
                                xlWorksheet.Cells[cnt, "H"] = _list.School_Grade;
                            }
                            else if (_list.School_Level == "Tertiary")
                            {
                                cnt = 44;
                                xlWorksheet.Cells[cnt, "A"] = "Tertiary: " + _list.School_Name;
                                xlWorksheet.Cells[cnt, "F"] = _list.School_From;
                                xlWorksheet.Cells[cnt, "G"] = _list.School_To;
                                xlWorksheet.Cells[cnt, "H"] = _list.School_Grade;
                            }
                            else if (_list.School_Level == "Vocational")
                            {
                                cnt = 45;
                                xlWorksheet.Cells[cnt, "A"] = "Vocational: " + _list.School_Name;
                                xlWorksheet.Cells[cnt, "F"] = _list.School_From;
                                xlWorksheet.Cells[cnt, "G"] = _list.School_To;
                                xlWorksheet.Cells[cnt, "H"] = _list.School_Grade;
                            }
                            else if (_list.School_Level == "Post Graduate")
                            {
                                cnt = 46;
                                xlWorksheet.Cells[cnt, "A"] = "Post Graduate: " + _list.School_Name;
                                xlWorksheet.Cells[cnt, "F"] = _list.School_From;
                                xlWorksheet.Cells[cnt, "G"] = _list.School_To;
                                xlWorksheet.Cells[cnt, "H"] = _list.School_Grade;
                            }
                        }
                    }

                    cnt = 47;
                    string _awards = "";

                    List<Employee_Award> _employeeaward = _iemployee.GetEmployeeAwards(_empid);
                    if (_employeeaward != null && _employeeaward.Count != 0)
                    {
                        foreach (Employee_Award _list in _employeeaward)
                        {
                            _awards = _list.Award.Awards + ", " + _awards;
                        }
                        xlWorksheet.Cells[cnt, "C"] = _awards.Substring(0, _awards.Length - 2);
                    }

                    cnt = 52;

                    List<Employee_Employment> _employeeemployment = (from d in _iemployee.GetEmployeeEmploymentHistory(_empid) orderby d.Company_from descending select d).ToList();
                    if (_employeeemployment != null)
                    {
                        foreach (Employee_Employment _list in _employeeemployment)
                        {
                            xlWorksheet.Cells[cnt, "A"] = _list.Company_name;
                            xlWorksheet.Cells[cnt, "D"] = _list.Company_from;
                            if (_list.Company_to == null)
                            {
                                xlWorksheet.Cells[cnt, "E"] = "Present";
                            }
                            else
                            {
                                xlWorksheet.Cells[cnt, "E"] = _list.Company_to;
                            }
                            xlWorksheet.Cells[cnt, "F"] = _list.Company_position;
                            xlWorksheet.Cells[cnt, "H"] = _list.Reason_for_leaving;

                            cnt = cnt + 1;
                        }
                    }

                }

                excel.Visible = true;
                xlWorksheet = null;

                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void picSearchCity_Click(object sender, EventArgs e)
        {

        }

        private void picSearchProvince_Click(object sender, EventArgs e)
        {

        }

        private void Resigned_btn_Click(object sender, EventArgs e)
        {
            if (chkIsActive.Checked == true)
            {
                panSeparation.Visible = true;
                dtSeparationDate.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Selected employee was already inactive, tagging as separated is not applicable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            
        }

        private void ButtonX1_Click(object sender, EventArgs e)
        {
            panSeparation.Visible = false;
        }

        private void save_separation_btn_Click(object sender, EventArgs e)
        {
            _mode = 0;
            ManageEmployee_Separation();
        }

        void ManageEmployee_Separation()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Separation _employeeseparation = new Employee_Separation();

            try
            {
                _employeeseparation.EmpID = _empid;
                _employeeseparation.Reason_ID = cboReason.SelectedIndex + 1;
                _employeeseparation.Separation_Date = dtSeparationDate.Value;
                _employeeseparation.Remarks = txtSeparationRemarks.Text;
                _employeeseparation.Is_History = false;

                _iemployee.ManageEmployeeSeparation(_employeeseparation, _mode, "", "", 0, 0);

                ToolsControl.CallShowNotification(this, 4, "Employee already tagged as inactive/separated");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_loading) { return; }
            BindDepartment(cmbDepartment, int.Parse(cmbCompany.SelectedValue.ToString()));
        }
    
    }
}
