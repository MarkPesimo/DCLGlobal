using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

//using CAL.CMS.Interface.Tool;
//using CAL.CMS.Repository.Tool;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewTrainingControl : UserControl
    {
        private string _docdept;
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iCrewTraining _icrewtraining = new CrewTrainingRepository(DCLSystemConfiguration.Connection);
        //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);

        int _id = 0;
        int _mode = 0;
        int _crewid = 0;
        string _applicantid = "";

        public CrewTrainingControl(string _Applicantid, int _Crewid, string _Docdept)
        {
            InitializeComponent();
            _crewid = _Crewid;
            _applicantid = _Applicantid;
            _docdept = _Docdept;

        }

        private void CrewTrainingControl_Load(object sender, EventArgs e)
        {
            //iCrewTraining _icrewtraining = new CrewTrainingRepository(DCLSystemConfiguration.Connection);
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            try
            {
                DisplayList();
                DisplayRecord(_icrewtraining.GetCrewTraining(0, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_TRAINING, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtTrainingName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtTrainingName.Text = "";
            txtTrainingName.Tag = 0;
            txtTrainingCenter.Text = "";
            txtTrainingCenter.Tag = 0;
            txtPlace.Text = "";
            txtPlace.Tag = 0;
            dtpIssued.Checked = false;
            dtpExpired.Checked = false;
            dtpNAC.Checked = false;
            chkClienaccess.Checked = false;
            chkOriginal.Checked = false;
            chkPhotocopies.Checked = false;
            txtRemarks.Text = "";
            txtScanDocs.Text = "";
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            Delete_btn.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            dtpIssued.Enabled = _cond;
            dtpExpired.Enabled = _cond;
            chkClienaccess.Enabled = _cond;
            chkOriginal.Enabled = _cond;
            chkPhotocopies.Enabled = _cond;
            txtRemarks.ReadOnly = !_cond;

            tabGrid.Enabled = !_cond;
        }

        void DisplayList()
        {
            grdValidTraining.RowCount = 0;
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            try
            {
                List<UserDefineClass.CMS.TrainingList> _crewtrainings = _icrewtraining.GetCrewTrainings(_applicantid, _docdept);
                foreach (UserDefineClass.CMS.TrainingList _list in _crewtrainings)
                {
                    int n = grdValidTraining.Rows.Add();
                    grdValidTraining.Rows[n].Cells[0].Value = _list.Id;
                    grdValidTraining.Rows[n].Cells[1].Value = "Open File";
                    grdValidTraining.Rows[n].Cells[2].Value = "View";
                    grdValidTraining.Rows[n].Cells[3].Value = _list.TrainingName;
                    grdValidTraining.Rows[n].Cells[4].Value = _list.Institution;
                    grdValidTraining.Rows[n].Cells[5].Value = _list.CountryName;

                    if (_list.DateIssued != null) { grdValidTraining.Rows[n].Cells[6].Value = _list.DateIssued.Value.ToShortDateString(); }
                    else { grdValidTraining.Rows[n].Cells[5].Value = ""; }
                    if (_list.NACRevDate != null) { grdValidTraining.Rows[n].Cells[7].Value = _list.NACRevDate.Value.ToShortDateString(); }
                    else { grdValidTraining.Rows[n].Cells[6].Value = ""; }

                    if (_list.Doctype == ".xlsx" || _list.Doctype == ".xls")
                    { grdValidTraining.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Excel_48; }
                    else if (_list.Doctype == ".docx" || _list.Doctype == ".doc")
                    { grdValidTraining.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Word_32; }
                    else if (_list.Doctype == ".JPG" || _list.Doctype == ".jpeg" || _list.Doctype == ".JPEG" || _list.Doctype == ".JPG" || _list.Doctype == ".jpg" || _list.Doctype == ".bmp" || _list.Doctype == ".gif" || _list.Doctype == ".png" || _list.Doctype == "ico")
                    { grdValidTraining.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.JPG; }
                    else if (_list.Doctype == ".pdf")
                    { grdValidTraining.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Reader_48; }
                    else if (_list.Doctype == ".ppt" || _list.Doctype == ".pptx")
                    { grdValidTraining.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.PowerPoint_48; }
                    else
                    { grdValidTraining.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Cancel; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(CrewTraining _crewTraining)
        {
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            try
            {
                if (_crewTraining != null)
                {
                    _id = _crewTraining.ID;

                    if (_crewTraining.Training_ID == null)
                    {
                        txtTrainingName.Tag = 0;
                        txtTrainingName.Text = "";
                    }
                    else
                    {
                        txtTrainingName.Tag = _crewTraining.Training_ID;
                        txtTrainingName.Text = _crewTraining.Training.Training_Name;
                    }
                    txtTrainingCenter.Text = _crewTraining.TrainingCenter.Institution_Name;
                    txtTrainingCenter.Tag = _crewTraining.TrainingCenter_id;
                    txtPlace.Text = _crewTraining.Country.CountryName;
                    txtPlace.Tag = _crewTraining.COUNTRY_ID;

                    if (_crewTraining.ExpiredDate != null) { dtpExpired.Value = _crewTraining.ExpiredDate.Value; }
                    else { dtpExpired.Checked = false; }
                    if (_crewTraining.IssuedDate != null) { dtpIssued.Value = _crewTraining.IssuedDate.Value; }
                    else { dtpIssued.Checked = false; }
                    if (_crewTraining.NACRevDate != null) { dtpNAC.Value = _crewTraining.NACRevDate.Value; }
                    else { dtpNAC.Checked = false; }

                    if (_crewTraining.IsClientAccess == null) { chkClienaccess.Checked = false; }
                    else { chkClienaccess.Checked = _crewTraining.IsClientAccess == true ? true : false; }
                    if (_crewTraining.withoriginal == null) { chkOriginal.Checked = false; }
                    else { chkOriginal.Checked = _crewTraining.withoriginal == true ? true : false; }
                    if (_crewTraining.WithPhotocopy == null) { chkPhotocopies.Checked = false; }
                    else { chkPhotocopies.Checked = _crewTraining.WithPhotocopy == true ? true : false; }

                    txtRemarks.Text = _crewTraining.Remarks;

                    ScanDocument _scandocument = _iscandocument.GetScanDocument(_crewTraining.ID, _docdept);
                    if (_scandocument != null) { txtScanDocs.Text = _scandocument.Location + "\\" + _scandocument.FileName + _scandocument.DocType; }
                    else { txtScanDocs.Text = ""; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_TRAINING, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 2;
                EnableForm(true);
                EnableButton(false);

                txtTrainingName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtTrainingName.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtTrainingName);
                txtTrainingName.Focus();
                return;
            }
            if (txtTrainingCenter.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtTrainingCenter);
                txtTrainingCenter.Focus();
                return;
            }
            if (txtPlace.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtPlace);
                txtPlace.Focus();
                return;
            }

            ManageCrewTraining();
        }

        void ManageCrewTraining()
        {
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            CrewTraining _crewtraining = new CrewTraining();

            try
            {
                _crewtraining.ID = _id;
                _crewtraining.ApplicantID = _applicantid;
                _crewtraining.Training_ID = int.Parse(txtTrainingName.Tag.ToString());
                _crewtraining.TrainingCenter_id = int.Parse(txtTrainingCenter.Tag.ToString());
                _crewtraining.COUNTRY_ID = int.Parse(txtPlace.Tag.ToString());
                _crewtraining.Institution = txtTrainingCenter.Text;

                if (dtpNAC.Checked) { _crewtraining.NACRevDate = dtpExpired.Value; }
                else { _crewtraining.NACRevDate = null; }
                if (dtpExpired.Checked) { _crewtraining.ExpiredDate = dtpExpired.Value; }
                else { _crewtraining.ExpiredDate = null; }
                if (dtpIssued.Checked) { _crewtraining.IssuedDate = dtpIssued.Value; }
                else { _crewtraining.IssuedDate = null; }

                _crewtraining.IsClientAccess = chkClienaccess.Checked;
                _crewtraining.withoriginal = chkOriginal.Checked;
                _crewtraining.WithPhotocopy = chkPhotocopies.Checked;

                _crewtraining.Remarks = txtRemarks.Text;

                _id = _icrewtraining.ManageCrewTraining(_crewtraining, _mode);
                ToolsControl.CallShowNotification(this, _mode, "");

                _icrewtraining = new CMSFilesRepository.rCrewTraining();
                DisplayRecord(_icrewtraining.GetCrewTraining(_id, _applicantid));
                Cancel();

                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewtraining.GetCrewTraining(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void grdValidTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            //iTool _itool = new ToolRepository(DCLSystemConfiguration.Connection);
            try
            {
                _id = int.Parse(grdValidTraining.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                if (e.ColumnIndex == 1)
                {
                    //string _path = _itool.OpenScanDocument(_id, _docdept);
                    string _path = GlobalToolsControl.OpenScanDocument(_id, _docdept);

                    if (_path != "File not found") 
                    {
                        Impersonator iU = new Impersonator();
                        iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);
                        
                        Process.Start(_path);

                        iU.Undo();
                    }
                    else { MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (e.ColumnIndex == 2)
                {
                    DisplayRecord(_icrewtraining.GetCrewTraining(_id, _applicantid));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_TRAINING, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 3;

            ManageCrewTraining();
        }

        private void btnDetached_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "DETACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; } 
            if (Add_btn.Enabled == false)
            {
                MessageBox.Show("Feature not available in this mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Detached attached documents, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            ScanDocument _scandocument = new ScanDocument();
            try
            {
                _scandocument.CrewDocID = _id;
                _scandocument.docdept = _docdept;

                int _scandocid = _iscandocument.ManageScandocuments(_scandocument, 2, _docdept, _applicantid);

                ToolsControl.CallPopMessage(this, "Information", "Document successfully Detached");
                Thread.Sleep(1000);

                DisplayList();
                DisplayRecord(_icrewtraining.GetCrewTraining(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (ToolsControl.ModuleAccess(this, "ATTACHED SCAN DOCUMENTS", SystemModuleType.System) == false) { return; }
            if (Add_btn.Enabled == false)
            {
                MessageBox.Show("Feature not available in this mode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ScanDocumentform _scandocumentform = new ScanDocumentform(_id, _docdept, _applicantid);
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            try
            {
                _scandocumentform.ShowDialog();

                DisplayList();
                DisplayRecord(_icrewtraining.GetCrewTraining(_id, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtTrainingName.Text = "";
            txtTrainingName.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.TRAINING_LIST;
            _Searchform.ShowDialog();

            //Training _training = _Searchform.ReturnSearchTraining;
            //if (_training != null)
            //{
            //    txtTrainingName.Text = _training.Training_Name;
            //    txtTrainingName.Tag = _training.Training_ID;
            //}
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            btnPlace.Text = "";
            btnPlace.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    btnPlace.Text = _country.CountryName;
            //    btnPlace.Tag = _country.ID;
            //}
        }

        private void btnTrainingCenter_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            btnPlace.Text = "";
            btnPlace.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.TRAINING_CENTER;
            _Searchform.ShowDialog();

            //TrainingCenter _trainingcenter = _Searchform.ReturnSearchTrainingCenter;
            //if (_trainingcenter != null)
            //{
            //    txtTrainingCenter.Text = _trainingcenter.Institution_Name;
            //    txtTrainingCenter.Tag = _trainingcenter.Institution_ID;
            //}
        }

        private void txtTrainingName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnTraining_Click(sender, e); }
        }

        private void txtTrainingCenter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnTrainingCenter_Click(sender, e); }
        }

        private void txtPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnPlace_Click(sender, e); }
        }
    }
}
