using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using CAL.Global;
using CAL.MASTER;
using DCLGlobal.Master.Employee;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using DCLGlobal.Master.Employee.Payroll;

using System.IO;
using System.Data.Linq;

namespace DCLGlobal.Master.Main.Employee
{
    public partial class EmployeeInfo : Form
    {
        public int _empid = 0;

        public EmployeeInfo(int _Empid)
        {
            InitializeComponent();
            _empid = _Empid;
        }

        //private void btnPersonalInfo_Click(object sender, EventArgs e)
        //{
        //    if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE, SystemModuleType.Masterfile) == false) { return; }
        //    ClearPanel();
        //    var _control = new PersonalInfoControl(_empid, this);
        //    _control._empid = _empid;
        //    AddControl(_control);
        //}

        void AddControl(Control _control)
        {
            _control.Dock = DockStyle.Fill;
            //_control.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            panExpan.Controls.Add(_control);
        }

        void ClearPanel()
        {
            panExpan.Controls.Clear();
        }

        void LoadImage()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                if (_empid > 0)
                {
                    CAL.Model.Employee _employee = _iemployee.GetEmployee(_empid);
                    if (_employee.ImageFile != null)
                    {
                        picImage.Image = GlobalToolsControl.Global.GetImageData(_employee.ImageFile);
                    }
                    else
                    {
                        picImage.Image = new Bitmap(DCLGlobal.Properties.Resources.Defualt_Image);
                    }
                }
                else
                {
                    picImage.Image = new Bitmap(DCLGlobal.Properties.Resources.Defualt_Image);
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_FAMILY, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new FamilyControl(_empid);
            AddControl(_control);
        }

        private void EmployeeInfo_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F2)
            //{
            //    Searchform _Searchform = new Searchform();
            //    _Searchform._searchby = searchby.CMS.EMPLOYEES;
            //    _Searchform.ShowDialog();

            //    CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            //    if (_employee != null)
            //    {                 
            //        _empid = _employee.Emp_ID;
            //        LoadImage();
            //        personalinfo_btn_Click(sender, e);
            //    }   
            //}
            //if (e.KeyCode == Keys.F6)
            //{
            //    if (_empid == 0)
            //    {
            //        MessageBox.Show("Kindly select a employee first before adding a previous Employer info.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //    TaxWithheldform _taxwithheld = new TaxWithheldform(_empid);
            //    _taxwithheld.BringToFront();
            //    _taxwithheld.ShowDialog();
            //}
        }

        private void btnDependents_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DEPENDENTS, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new DependentsControl(_empid);
            AddControl(_control);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            bool _updateimage = false;
            iEmployee _iemployee = new HURISRepository.rEmployee();
            byte[] m_barrImg;
            
            try
            {
                OFD1.Title = "Select a file";
                OFD1.Filter = "All Picture Files|*.jpeg;*.jpg;*.bmp;*.gif;*.png";
                
                OFD1.ShowDialog();
                if (OFD1.FileName == "") { return; }
                picImage.ImageLocation = OFD1.FileName;
                string _filename = OFD1.FileName;

                string _path = DCLSystemConfiguration.HURIS.Imagepath;

                if (System.IO.File.Exists(_path + "\\" + _empid + ".JPEG"))
                {
                    System.IO.File.Delete(_path + "\\" + _empid + ".JPEG");
                }

                System.IO.File.Copy(OFD1.FileName, _path + "\\" + _empid + ".JPEG");
                ToolsControl.CallShowNotification(this, 4, "Image successfully uploaded");

                //FileInfo _fiImage = new FileInfo(_filename);
                //m_barrImg = new byte[Convert.ToInt32(_fiImage.Length)];

                //FileStream fs = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                //int _byteread = fs.Read(m_barrImg, 0, Convert.ToInt32(_fiImage.Length));
                //fs.Close();

                ////_updateimage = _iemployee.UpdateEmployeeImage(_empid, GlobalToolsControl.Global.ConvertImageToByte(picImage.Image));
                //_updateimage = _iemployee.UpdateEmployeeImage(_empid, m_barrImg);
                //if (_updateimage == true)
                //{
                //    ToolsControl.CallShowNotification(this, 4, "Image successfully uploaded");
                //}
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_EDUCATION, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EducationControl(_empid);
            AddControl(_control);
        }

        private void btnEmploymentHistory_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYMENT_HISTORY, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmploymentHistoryControl(_empid);
            AddControl(_control);
        }

        private void btnLicensure_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LICENSURE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeLicensureControl(_empid);
            AddControl(_control);
        }

        private void btnTrainings_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TRAINING, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeTrainingControl(_empid);
            AddControl(_control);
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DOCUMENT, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeDocumentControl(_empid);
            AddControl(_control);
        }

        private void btnAwards_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_AWARD, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeAwardsControl(_empid);
            AddControl(_control);
        }

        private void btnCases_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_CASE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeCaseControl(_empid);
            AddControl(_control);
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_INSURANCE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeInsuranceControl(_empid);
            AddControl(_control);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.EMPLOYEE_FILED_LEAVE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeLeaveControl(_empid);
            AddControl(_control);
        }

        private void btnOvertime_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.EMPLOYEE_FILED_OVERTIME, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeOvertimeControl(_empid);
            AddControl(_control);
        }

        private void btnOBTP_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.EMPLOYEE_FILED_OBTP, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeOBTPControl(_empid);
            AddControl(_control);
        }

        private void btnLeaveBalance_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.LEAVE_ENTITLEMENT, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new LeaveEntitlementControl(_empid);
            AddControl(_control);
        }

        public void ClearImage()
        {
            _empid = 0;
            LoadImage();
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new PersonalInfoControl(_empid, this);
            _control._empid = _empid;
            AddControl(_control);

            if (_empid >= 1)
            //{ LoadImage(); } else { }
            {
                    Thread _thread = new Thread(new ThreadStart(DisplayImage));
                    _thread.IsBackground = true;
                    _thread.Start();
            }
        }

        #region DELEGATES
        private delegate void DisplayImageDelegate(string _value);
        public void DisplayEmployeeImage(string _value)
        {
            if (base.InvokeRequired)
            {
                base.Invoke(new DisplayImageDelegate(this.DisplayEmployeeImage), new object[] { _value });
            }
            else
            {
                string _path = DCLSystemConfiguration.HURIS.Imagepath;
                this.picImage.ImageLocation = _path + _value;
            }
        }
        #endregion

        void DisplayImage()
        {
            try
            {
                string _path = DCLSystemConfiguration.HURIS.Imagepath;
                if (System.IO.File.Exists(_path + _empid.ToString() + ".JPEG"))
                {
                    DisplayEmployeeImage(_empid + ".jpeg");
                }
                else
                {
                    DisplayEmployeeImage("0.png");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsalary_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var _control = new EmployeePayrollInfocontrol(this);          
            AddControl(_control);
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var _control = new EmployeeLoanInfo(this);
            AddControl(_control);
        }

        private void btnothherdeduct_Click(object sender, EventArgs e)
        {

        }

        private void btnadjustment_Click_1(object sender, EventArgs e)
        {
            ClearPanel();
            var _control = new EmployeeAdjustmentControl(this);
            AddControl(_control);
        }

        private void btnothherdeduct_Click_1(object sender, EventArgs e)
        {
            ClearPanel();
            var _control = new EmployeeOtherDeductionControl(this);
            AddControl(_control);
        }

        private void personalinfo_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Employee Information", SystemModuleType.Masterfile) == false) { return; }
            SetHighlight(personalinfo_btn);
            ClearPanel();
            var _control = new PersonalInfoControl(_empid, this);
            _control._empid = _empid;
            AddControl(_control);
        }

        private void SetHighlight(Button _btn)
        {
            SidePanel.Top = _btn.Top;
        }
        private void files_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SetHighlight(files_btn);

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                cntxFiles.Show(ptLowerLeft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DocumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DOCUMENT, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeDocumentControl(_empid);
            AddControl(_control);
        }

        private void LicensuretoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_LICENSURE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeLicensureControl(_empid);
            AddControl(_control);
        }

        private void TrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_TRAINING, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeTrainingControl(_empid);
            AddControl(_control);
        }

        private void CasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_CASE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeCaseControl(_empid);
            AddControl(_control);
        }

        private void awardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_AWARD, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeAwardsControl(_empid);
            AddControl(_control);
        }

        private void FamilytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_FAMILY, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new FamilyControl(_empid);
            AddControl(_control);
        }

        private void DependenttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DEPENDENTS, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new DependentsControl(_empid);
            AddControl(_control);
        }

        private void EducationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE_EDUCATION, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EducationControl(_empid);
            AddControl(_control);
        }

        private void background_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SetHighlight(background_btn);

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                cntxBackground.Show(ptLowerLeft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void employment_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYMENT_HISTORY, SystemModuleType.Masterfile) == false) { return; }
            SetHighlight(employment_btn);
            ClearPanel();
            var _control = new EmploymentHistoryControl(_empid);
            AddControl(_control);
        }

        private void benefits_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SetHighlight(benefits_btn);

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                cntxBenefits.Show(ptLowerLeft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeavetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.EMPLOYEE_FILED_LEAVE, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeLeaveControl(_empid);
            AddControl(_control);
        }

        private void OvertimetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.EMPLOYEE_FILED_OVERTIME, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeOvertimeControl(_empid);
            AddControl(_control);
        }

        private void OBtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Transaction.EMPLOYEE_FILED_OBTP, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeOBTPControl(_empid);
            AddControl(_control);
        }

        private void leaveCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.LEAVE_ENTITLEMENT, SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new LeaveEntitlementControl(_empid);
            AddControl(_control);
        }

        private void SalarytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Salary Information", SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeePayrollInfocontrol(this);
            AddControl(_control);
        }

        private void adjustmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Employee Adjustment", SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeAdjustmentControl(this);
            AddControl(_control);
        }

        private void DeductionstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Employee Deduction", SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeOtherDeductionControl(this);
            AddControl(_control);
        }

        private void loansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Employee Loan", SystemModuleType.Masterfile) == false) { return; }
            ClearPanel();
            var _control = new EmployeeLoanInfo(this);
            AddControl(_control);
        }

        private void payroll_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SetHighlight(payroll_btn);

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                cntxPayroll.Show(ptLowerLeft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payrollrecords_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SetHighlight(payrollrecords_btn);

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                cntxPayrollRecords.Show(ptLowerLeft);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BIR2316toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "BIR 2316", SystemModuleType.Masterfile) == false) { return; }

            if (_empid == 0)
            {
                MessageBox.Show("Kindly select a employee first before adding a previous Employer info.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TaxWithheldform _taxwithheld = new TaxWithheldform(_empid);
            _taxwithheld.BringToFront();
            _taxwithheld.ShowDialog();
        }

        private void PayrolltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "Payroll Records", SystemModuleType.Masterfile) == false) { return; }
            SetHighlight(payrollrecords_btn);
            ClearPanel();
            var _control = new PayrollInfoControl(_empid);
            //_control._empid = _empid;
            AddControl(_control);
        }

        private void PayrollAdjustmenttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var _control = new EmployeeAdjustmentControl(this);
            AddControl(_control);
        }

        private void PayrollDeductiontoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            var _control = new EmployeeOtherDeductionControl(this);
            AddControl(_control);
        }
    }
}
