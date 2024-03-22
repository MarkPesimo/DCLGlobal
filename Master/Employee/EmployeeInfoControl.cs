using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

using DCLGlobal.Classes;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;

namespace DCLGlobal.Master.Employee
{
    public partial class EmployeeInfoControl : UserControl
    {
        int _empid = 0;
        public int _payrolldet_id = 0;
        ToolsControl _tool = new ToolsControl();

        public EmployeeInfoControl(int _Empid)
        {
            InitializeComponent();
            _empid = _Empid;
        }

        private void EmployeeInfoControl_Load(object sender, EventArgs e)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            DisplayRecord(_iemployee.GetEmployee(_empid));
        }

        void DisplayRecord(CAL.Model.Employee _employee)
        {
            try
            {
                if (_employee != null)
                {
                    txtEmployeeName.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    txtEmpno.Text = _employee.Emp_No;
                    txtDateHired.Text = _employee.Datehired.Value.ToShortDateString();
                    txtEmpType.Text = _employee.EmployeeType.EmpType_Desc;
                    txtAccountNo.Text = _employee.Account_no;

                    if (_payrolldet_id == 0)
                    {
                        txtPosition.Text = _employee.Salary.Salary_Desc;
                        txtBasicPay.Text = decimal.Parse(_employee.MonthlySalary.ToString()).ToString("N", new CultureInfo("en-US"));
                    }
                    else
                    {
                        //iPayrollDetails _i = new IHOPSTransactionRepository.rPayrollDetails();
                        //Payroll_Details _det = _i.GetPayrollDetail(_payrolldet_id);
                        //if (_det != null)
                        //{
                        //    txtPosition.Text = _det.Position;
                        //    txtBasicPay.Text = decimal.Parse(_det.BasicPay.ToString()).ToString("N", new CultureInfo("en-US"));
                        //}
                    }

                    LoadImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadImage()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {

                CAL.Model.Employee _employee = _iemployee.GetEmployee(_empid);
                if (_employee.ImageFile != null) { picImage.Image = GlobalToolsControl.Global.GetImageData(_employee.ImageFile); }
                else { picImage.Image = new Bitmap(DCLGlobal.Properties.Resources.Defualt_Image); }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
