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
    public partial class EmployeeDocumentControl : UserControl
    {
        int _id;
        int _empid;
        int _mode;
        string _fileExtension;
        string _targetpath;
        string _filepath;
        bool _flag;

        public EmployeeDocumentControl(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
            BindDocumentList(cboDocument);
        }

        private void EmployeeDocumentControl_Load(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeDocuments();
        }

        void InitializeField()
        {
            _id = 0;
            cboDocument.SelectedIndex = -1;
            txtDocNo.Text = "";
            txtFileLocation.Text = "";
            dtDateIssued.Value = DateTime.Now;
            dtDateIssued.LockUpdateChecked = false;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            dgvDocs.Enabled = _cond;
            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
            btnBrowse.Enabled = !_cond;
        }

        void EnableForm(bool _cond)
        {
            cboDocument.Enabled = _cond;
            txtDocNo.ReadOnly = !_cond;
            txtFileLocation.ReadOnly = !_cond;
            dtDateIssued.Enabled = _cond;
        }

        void DisplayEmployeeDocuments()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                List<Employee_Document> _employeedocument = _iemployee.GetEmployeeDocuments(_empid);
                dgvDocs.RowCount = 0;
                if (_employeedocument != null)
                {
                    foreach (Employee_Document _list in _employeedocument)
                    {
                        int r = dgvDocs.Rows.Add();
                        dgvDocs.Rows[r].Cells[0].Value = _list.ID;
                        dgvDocs.Rows[r].Cells[1].Value = "Open File";
                        dgvDocs.Rows[r].Cells[2].Value = _list.HRDocument.Description;
                        dgvDocs.Rows[r].Cells[3].Value = _list.DocNo;
                        dgvDocs.Rows[r].Cells[4].Value = _list.DateIssued;
                        dgvDocs.Rows[r].Cells[5].Value = _list.Location;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            _id = int.Parse(dgvDocs.Rows[e.RowIndex].Cells[0].Value.ToString());

            iEmployee _iemployee = new HURISRepository.rEmployee();

            try
            {
                Employee_Document _employeedocument = _iemployee.GetEmployeeDocument(_id);
                if (_employeedocument != null)
                {
                    cboDocument.SelectedValue = _employeedocument.DocId;
                    txtDocNo.Text = _employeedocument.DocNo;
                    if (_employeedocument.DateIssued != null)
                    {
                        dtDateIssued.Value = _employeedocument.DateIssued.Value;
                        dtDateIssued.LockUpdateChecked = true;
                    }
                    else
                    {
                        dtDateIssued.LockUpdateChecked = false;
                    }
                    txtFileLocation.Text = _employeedocument.Location;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DOCUMENT, Feature.Add, SystemModuleType.Masterfile) == false) { return; }

            _mode = 1;
            InitializeField();
            EnableButton(false);
            EnableForm(true);
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.HURIS.Master.EMPLOYEE_DOCUMENT, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }

            _mode = 2;
            EnableButton(false);
            EnableForm(true);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeDocuments();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            _fileExtension = Path.GetExtension(txtFileLocation.Text);
            _targetpath = DCLSystemConfiguration.HURIS.Documentpath + _empid + @"\Document\";
            _filepath = _targetpath + cboDocument.Text + _fileExtension;

            if (cboDocument.SelectedIndex == -1)
            {
                MessageBox.Show("Document name is required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboDocument.Focus();
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

            ManageEmployeeDocuments();
            InitializeField();
            EnableButton(true);
            EnableForm(false);
            DisplayEmployeeDocuments();

            if (_flag == true)
            {
                if (_mode == 1 || _mode == 2) { ToolsControl.CallShowNotification(this, _mode, "", eToastGlowColor.Blue, eToastPosition.MiddleCenter); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }
            }            
        }

        void ManageEmployeeDocuments()
        {
            iEmployee _iemployee = new HURISRepository.rEmployee();
            Employee_Document _employeedocument = new Employee_Document();

            try
            {
                _employeedocument.ID = _id;
                _employeedocument.EmpID = _empid;
                _employeedocument.DocName = cboDocument.Text;
                _employeedocument.DocNo = txtDocNo.Text;
                _employeedocument.Location = _filepath;
                _employeedocument.DocId = int.Parse(cboDocument.SelectedValue.ToString());
                if (dtDateIssued.LockUpdateChecked == true)
                {
                    _employeedocument.DateIssued = dtDateIssued.Value;
                }

                _id =  _iemployee.ManageEmployeeDocument_new(_employeedocument, _mode);
                _flag = true;

                //updated by   : kuto 
                //date updated : 11/09/2021 0437pm
                //description  : save the id as filename
                _filepath = _targetpath + _id.ToString() + _fileExtension;
                //date updated : 11/09/2021 0437pm

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

        void BindDocumentList(ComboBox _cmb)
        {
            iHRDocument _ihrdocument = new HURISRepository.rHRDocument();

            try
            {
                List<HRDocument> _hrdocument = _ihrdocument.GetDocuments("");
                _cmb.DataSource = _hrdocument;
                _cmb.DisplayMember = "description";
                _cmb.ValueMember = "docid";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    System.Diagnostics.Process.Start(dgvDocs.Rows[e.RowIndex].Cells[5].Value.ToString());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
