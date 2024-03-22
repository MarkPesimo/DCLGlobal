using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Inquiry
{
    public partial class SetApproverForm : Form
    {
        int _empid;
        string _approvertype;
        int _initialApproverID;
        int _finalApproverID;
        int _mode;

        public SetApproverForm(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        private void btnAddInitialApprover_Click(object sender, EventArgs e)
        {
            _approvertype = "I";
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                if (_approvertype == "I")
                {
                    txtInitialApprover.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    txtInitialApprover.Tag = _employee.Emp_ID;
                }
                else
                {
                    txtFinalApprover.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    txtFinalApprover.Tag = _employee.Emp_ID;
                }
            }
        }

        private void btnAddFinalApprover_Click(object sender, EventArgs e)
        {
            _approvertype = "F";
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.EMPLOYEES;
            _Searchform.ShowDialog();

            CAL.Model.Employee _employee = _Searchform.ReturnSearchEmployee;
            if (_employee != null)
            {
                if (_approvertype == "I")
                {
                    txtInitialApprover.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    txtInitialApprover.Tag = _employee.Emp_ID;
                }
                else
                {
                    txtFinalApprover.Text = _employee.Lastname + ", " + _employee.Firstname + " " + _employee.Middlename;
                    txtFinalApprover.Tag = _employee.Emp_ID;
                }
            }
        }

        private void btnRemoveInitialApprover_Click(object sender, EventArgs e)
        {
            txtInitialApprover.Clear();
            txtInitialApprover.Tag = 0;
        }

        private void btnFRemoveFinalApprover_Click(object sender, EventArgs e)
        {
            txtFinalApprover.Clear();
            txtFinalApprover.Tag = 0;
        }

        void LoadInitialApprover()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                UserDefineClass.HRIS.Approver _approver = _iemployee.GetApprover(_empid, "I");
                if (_approver != null)
                {
                    txtInitialApprover.Text = _approver.Name;
                    txtInitialApprover.Tag = _approver.HeadID;
                    _initialApproverID = _approver.ID;
                }
                else
                {
                    _initialApproverID = 0;
                    txtInitialApprover.Tag = 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadFinalApprover()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                UserDefineClass.HRIS.Approver _approver = _iemployee.GetApprover(_empid, "F");
                if (_approver != null)
                {
                    txtFinalApprover.Text = _approver.Name;
                    txtFinalApprover.Tag = _approver.HeadID;
                    _finalApproverID = _approver.ID;
                }
                else
                {
                    _finalApproverID = 0;
                    txtFinalApprover.Tag = 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetApproverForm_Load(object sender, EventArgs e)
        {
            LoadInitialApprover();
            LoadFinalApprover();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Save approver information?", "Save Approver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.No) { return; }
                      

            if (int.Parse(txtInitialApprover.Tag.ToString()) == int.Parse(txtFinalApprover.Tag.ToString()))
            {
                MessageBox.Show("Initial approver should not match with final approver. Please select another approver.", "Duplicate Approver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (_initialApproverID == 0 && int.Parse(txtInitialApprover.Tag.ToString()) != 0)
                { _mode = 1; }
                else if (_initialApproverID != 0 && int.Parse(txtInitialApprover.Tag.ToString()) != 0)
                { _mode = 2; }
                else if (_initialApproverID != 0 && int.Parse(txtInitialApprover.Tag.ToString()) == 0)
                { _mode = 3; }

                ManageApprover(_mode, _initialApproverID, _empid, int.Parse(txtInitialApprover.Tag.ToString()), "I");

                if (_finalApproverID == 0 && int.Parse(txtFinalApprover.Tag.ToString()) != 0)
                { _mode = 1; }
                else if (_finalApproverID != 0 && int.Parse(txtFinalApprover.Tag.ToString()) != 0)
                { _mode = 2; }
                else if (_finalApproverID != 0 && int.Parse(txtFinalApprover.Tag.ToString()) == 0)
                { _mode = 3; }

                ManageApprover(_mode, _finalApproverID, _empid, int.Parse(txtFinalApprover.Tag.ToString()), "F");
            }            

            Close();
        }

        void ManageApprover(int _MODE, int _ID, int _EMPID, int _HEADID, string _TYPE)
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                _iemployee.ManageApprover(_MODE, _ID, _EMPID, _HEADID, _TYPE);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetApproverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
