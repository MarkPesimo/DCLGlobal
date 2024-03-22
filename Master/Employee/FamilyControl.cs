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

using DCLGlobal;
using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

using DevComponents.DotNetBar;

namespace DCLGlobal.Master.Employee
{
    public partial class FamilyControl : UserControl
    {
        public int _empid;
        int _id;
        int _mode;
        bool _flag;

        public FamilyControl(int _EMPID)
        {
            InitializeComponent();
            BindRelation();
            _empid = _EMPID;
        }

        private void FamilyControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);            
            DisplayFamily();
        }

        void DisplayFamily()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                dgvFamily.RowCount = 0;

                List<Employee_Family> _family = _iemployee.GetEmployeeFamilies(_empid);
                if (_family != null)
                {
                    foreach (Employee_Family _list in _family)
                    {
                        int r = dgvFamily.Rows.Add();
                        dgvFamily.Rows[r].Cells[0].Value = _list.relid;
                        dgvFamily.Rows[r].Cells[1].Value = _list.Name;
                        dgvFamily.Rows[r].Cells[2].Value = _list.Relationship.Relation;
                        dgvFamily.Rows[r].Cells[3].Value = _list.Birthday;
                        dgvFamily.Rows[r].Cells[4].Value = _list.ContactNo;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BindRelation()
        {
            iRelation _irelation = new HURISRepository.rRelationship();

            try
            {
                List<Relationship> _relation = _irelation.GetRelations("");
                cboRelation.DataSource = _relation;
                cboRelation.DisplayMember = "Relation";
                cboRelation.ValueMember = "Relation_id";
                cboRelation.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFamily_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvFamily.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Family _family = _iemployee.GetEmployeeFamily(_id);
                if (_family != null)
                {
                    cboRelation.SelectedValue = int.Parse(_family.Relation_Id.ToString());
                    txtname.Text = _family.Name;
                    if (_family.Birthday != null)
                    {
                        dtbday.Value = _family.Birthday.Value.Date;
                        dtbday.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtbday.LockUpdateChecked = false;
                    }
                    txtcontactno.Text = _family.ContactNo;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            cboRelation.SelectedValue = -1;
            dtbday.Value = DateTime.Now;
            dtbday.LockUpdateChecked = false;
            txtname.Text = "";
            txtcontactno.Text = "";
        }

        void EnableForm(bool _cond)
        {
            txtname.ReadOnly = !_cond;
            txtcontactno.ReadOnly = !_cond;
            dtbday.Enabled = _cond;
            cboRelation.Enabled = _cond;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvFamily.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            Cancel_btn.Enabled = !_cond;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_FAMILY, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();            
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_FAMILY, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            if (_id == 0)
            {
                MessageBox.Show("Please select record to edit.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            DisplayFamily();
            EnableButton(true);
            EnableForm(false);
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtname);
                txtname.Focus();
                return;
            }

            if (cboRelation.SelectedIndex == -1)
            {
                MessageBox.Show("Relation is required.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboRelation.Focus();
                return;
            }

            ManageRelationship();
            DisplayFamily();
            EnableButton(true);
            EnableForm(false);
            InitializeField();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageRelationship()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Family _family = new Employee_Family(); 

            try
            {
                _family.EmpId = _empid;
                _family.relid = _id;
                _family.Relation_Id = int.Parse(cboRelation.SelectedValue.ToString());
                _family.Name = txtname.Text;
                _family.ContactNo = txtcontactno.Text;
                if (dtbday.LockUpdateChecked == true)
                {
                    _family.Birthday = dtbday.Value;
                }

                _iemployee.ManageEmployeeFamily(_family, _mode);
                _flag = true;
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
