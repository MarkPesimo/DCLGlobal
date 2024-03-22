using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

using DCLGlobal.Master.Main.Employee;
using DCLGlobal.Classes;

namespace DCLGlobal.Inquiry
{
    public partial class EmployeeMonitoring : Form
    {
        int _record_count = 0;
        int _page = 1;
        int _maxpage = 0;
        bool _fromnavigation = false;
        int _empid = 0;
        ToolsControl _tool = new ToolsControl();
        public EmployeeMonitoring()
        {
            InitializeComponent();
            cboRows.SelectedIndex = 2;
        }

        private void searchcompany_btn_Click(object sender, EventArgs e)
        {
            txtCompany.Text = "";
            txtCompany.Tag = 0;

            Searchform _searchform = new Searchform();
            _searchform._searchby = searchby.HURIS.COMPANY;
            _searchform.BringToFront();
            _searchform.ShowDialog();

            Company _company = _searchform.ReturnSearchCompany;
            if (_company != null)
            {
                txtCompany.Text = _company.CompanyName;
                txtCompany.Tag = int.Parse(_company.CompID.ToString());

                _page = 1;
                lblPage.Text = _page.ToString();
                _fromnavigation = false;
                DisplayEmployees(int.Parse(txtCompany.Tag.ToString()));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkKeyword.Checked)
            {
                _page = 1;
                lblPage.Text = _page.ToString();
                _fromnavigation = false;
                DisplayEmployees(0);
            }
        }

        void CountPage(List<USP_H_GET_EMPLOYEE_MONITORINGResult> _data)
        {
            try
            {
                USP_H_GET_EMPLOYEE_MONITORINGResult _rec = (from d in _data select d).FirstOrDefault();
                if (_rec != null)
                {
                    if (int.Parse(_rec.Cnt.ToString()) < int.Parse(cboRows.Text))
                    {
                        _maxpage = 1;
                    }
                    else
                    {
                        _maxpage = (int.Parse(_rec.Cnt.ToString()) / int.Parse(cboRows.Text)) + 1;
                    }

                    lblCount.Text = "Record Count : " + _rec.Cnt.ToString();
                }
                else { lblCount.Text = "Record Count : 0"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DisplayEmployees(int _compid)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            try
            {
                dgvList.RowCount = 0;
                int n;
                string _status;
                List<USP_H_GET_EMPLOYEE_MONITORINGResult> _employees = _iemployee.SearchEmployees(txtKeyword.Text, chkCompany.Checked, int.Parse(txtCompany.Tag.ToString()), _page, int.Parse(cboRows.Text));
                if (!_fromnavigation) { CountPage(_employees); }

                //prb.Maximum = int.Parse(cboRows.Text);
                //prb.Value = 0;
                List<UserDefineClass.HRIS.EmployeeSearchList> _list = (
                    from d in _employees
                    select new UserDefineClass.HRIS.EmployeeSearchList
                    {
                        EmpID = int.Parse(d.EmpID.ToString()),
                        EmpNo = d.EmpNo,
                        LastName = d.LastName,
                        FirstName = d.FirstName,
                        MiddleName = d.MiddleName,
                        CompanyName = d.CompanyName,
                        Branch = d.Branch,
                        EmpStatus = d.EmpStatus == true ? 1 : 0,
                        IsIncludePayroll = bool.Parse(d.IsIncludePayroll.ToString()),
                        RankID = int.Parse(d.RankID.ToString()),
                        Position = d.Position,
                        Department = d.Department,
                        DateHired = DateTime.Parse(d.Datehired.ToString())
                    }).ToList();

                foreach (UserDefineClass.HRIS.EmployeeSearchList _x in _list)
                {
                    //prb.Value = prb.Value + 1;
                    n = dgvList.Rows.Add();
                    dgvList.Rows[n].Cells[0].Value = _x.EmpID.ToString();
                    dgvList.Rows[n].Cells[1].Value = _x.EmpNo;
                    dgvList.Rows[n].Cells[2].Value = _x.LastName + ", " + _x.FirstName + " " + _x.MiddleName.Substring(0, 1) + ".";
                    dgvList.Rows[n].Cells[3].Value = _x.CompanyName;
                    dgvList.Rows[n].Cells[4].Value = _x.Branch;
                    dgvList.Rows[n].Cells[5].Value = _x.Department;
                    dgvList.Rows[n].Cells[6].Value = _x.Position;
                    dgvList.Rows[n].Cells[7].Value = _x.DateHired.ToShortDateString();

                    if (_x.EmpStatus == 1)
                    {
                        dgvList.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.icon_unposted; _status = "Active";
                    }
                    else
                    {
                        //dgvList.Rows[n].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#d9534f");
                        dgvList.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.icon_void; _status = "Inactive";
                    }

                    //dgvList.Rows[n].Cells[11].Value = _status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeMonitoring_Load(object sender, EventArgs e)
        {
            DisplayEmployees();
        }

        void DisplayEmployees()
        {
            if (txtCompany.Tag.ToString() == "") { return; }

            DisplayEmployees(int.Parse(txtCompany.Tag.ToString()));
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompany.Checked == true) { searchcompany_btn.Enabled = true; }
            else { searchcompany_btn.Enabled = false; txtCompany.Text = ""; txtCompany.Tag = 0; }
        }

        private void chkKeyword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKeyword.Checked == true) { txtKeyword.ReadOnly = false; txtKeyword.Focus(); }
            else { txtKeyword.ReadOnly = true; txtKeyword.Text = ""; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayEmployees();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            DisplayEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeInfo _employeeinfo = new EmployeeInfo(0);

            if (ToolsControl.ModuleAccess(this, SystemModule.HURIS.Master.EMPLOYEE, SystemModuleType.Masterfile) == false) { return; }
            if (_tool.CheckFormAleadyOpen("EmployeeInfo", _empid.ToString())) { return; }

            _employeeinfo.Tag = _empid.ToString();
            _employeeinfo.BringToFront();
            _employeeinfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_page == _maxpage) { _page = _maxpage; ToolsControl.CallShowNotification(this, 4, "End of Records"); }
            else
            {
                _fromnavigation = true;
                _page++;
                lblPage.Text = _page.ToString();
                DisplayEmployees(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_page == 1) { _page = 1; ToolsControl.CallShowNotification(this, 4, "Begin of Records"); }
            else
            {
                _fromnavigation = true;
                _page--;
                lblPage.Text = _page.ToString();
                DisplayEmployees(0);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            try
            {
                iEmployee _iemployee = new HURISRepository.rEmployee();
                
                _empid = int.Parse(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());


                bool _confidential = _iemployee.GetEmployee(_empid).is_confidential;
                if (e.ColumnIndex == 2)
                {
                    if (LoginUser.usertype.ToUpper() == "USER" && _confidential == true)
                    {
                        MessageBox.Show("You do not have access to view confidential employee profile!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        EmployeeInfo _employeeinfo = new EmployeeInfo(_empid);

                        //if (ToolsControl.ModuleAccess(this, _employeeinfo.Text, SystemModuleType.Masterfile) == false) { return; }
                        if (_tool.CheckFormAleadyOpen("EmployeeInfo", _empid.ToString())) { return; }

                        _employeeinfo.Tag = _empid.ToString();
                        _employeeinfo.BringToFront();
                        _employeeinfo.Show();
                    }                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblnotes.ForeColor == Color.Blue) { lblnotes.ForeColor = Color.Lime; }
            else { lblnotes.ForeColor = Color.Blue; }
        }
    }
}
