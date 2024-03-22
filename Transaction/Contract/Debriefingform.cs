using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using DCLGlobal.Classes;

namespace DCLGlobal.Transaction.Contract
{
    public partial class Debriefingform : Form
    {
        int _crewstatusid = 0;
        int _crewid = 0;
        string _applicantid = "";
        int _id = 0;
        int _principalid = 0;
        int _mode = 0;

        public Debriefingform(int Crewstatusid, int Crewid, string Applicantid, int Principalid)
        {
            _crewstatusid = Crewstatusid;
            _crewid = Crewid;
            _applicantid = Applicantid;
            _principalid = Principalid;
            InitializeComponent();
        }

        private void Debriefingform_Load(object sender, EventArgs e)
        {
            iContract _icontract = new CMSTransactionRepository.rContract();
            try
            {
                DisplayDebriefing(_icontract.GetDebriefing(_crewstatusid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayDebriefing(Debriefing _debriefing)
        {
            try
            {
                iCrew _icrew = new CMSFilesRepository.rCrew();
                Crew _crew =_icrew.GetCrew(_crewid);

                if (_debriefing != null)
                {
                    _mode = 1;
                    _id = _debriefing.DebriefID;
                                        
                    txtCrewName.Text = _crew.LastName + ", " + _crew.FirstName + " " +_crew.MiddleName;
                    
                     
                    if (_debriefing.CrewRecord.DateReported != null) { txtDateReported.Text = _debriefing.CrewRecord.DateReported.Value.ToString("MM/dd/yyyy"); }
                    else { txtDateReported.Text = "";  }

                    txtPosition.Text = _debriefing.CrewRecord.Position.PositionName;
                    txtVessel.Text = _debriefing.CrewRecord.Vessel.VesselDescription;
                    txtPrincipal.Text = _debriefing.CrewRecord.Principal.PrincipalDescription;
                    txtDispatch.Text = _debriefing.CrewRecord.DispatchDate.Value.ToString("MM/dd/yyyy");
                    txtDisembark.Text = _debriefing.CrewRecord.DisembarkDate.Value.ToString("MM/dd/yyyy");
                    txtReasonDisembarkation.Text = _debriefing.CrewRecord.Remarks;
                    txtDateArrived.Text = _debriefing.CrewRecord.DateArrived.Value.ToString("MM/dd/yyyy");

                    cboAccomodation.Text = _debriefing.Accomodation.ToString();
                    txtAccomodation.Text = _debriefing.Accomodation_Remarks;
                    cboFood.Text = _debriefing.Food.ToString();
                    txtFood.Text = _debriefing.Food_Remarks;

                    cboSalary.Text = _debriefing.Salary.ToString();
                    txtSalary.Text = _debriefing.Salary_Remarks;

                    cboHealth.Text = _debriefing.Safety.ToString();
                    txtHealth.Text = _debriefing.Safety_Remarks;

                    cboSchedule.Text = _debriefing.Working.ToString();
                    txtSchedule.Text = _debriefing.Working_Remarks;

                    cboSubordinates.Text = _debriefing.Subordinate.ToString();
                    txtRelationship.Text = _debriefing.Relation_Remarks;

                    cboCoWorker.Text = _debriefing.Coworker.ToString();
                    cboSuperior.Text = _debriefing.Superior.ToString();

                    cboWorkingGear.Text = _debriefing.WorkingGear.ToString();
                    txtWorkinggear.Text = _debriefing.WorkingGear_Remarks;

                    if( _debriefing.Overall == "Yes")
                    {
                        optYes.Checked = true;
                        optNo.Checked = false;
                    }
                    else
                    {
                        optNo.Checked = true;
                        optYes.Checked = false;
                    }

                    txtDateAvailable.Text = _debriefing.CrewRecord.DateAvailability.Value.ToString("MM/dd/yyyy");
                    txtContactNo.Text = _crew.TelNo + " / " + _crew.MobileNo;
                    txtAddress.Text = _crew.Address;
                    txtReason.Text = _debriefing.Reason;

                    txtComments.Text = _debriefing.Comments;
                    txtSuggestions.Text = _debriefing.Suggestions;
                    txtEvaluations.Text = _debriefing.Evaulation;
                    txtImportantInstruction.Text = _debriefing.ImportantInstruction;
                }
                else 
                { 
                    _id = 0;
                    txtCrewName.Text =  _crew.LastName + ", " + _crew.FirstName + " " +_crew.MiddleName;

                    iContract _icontract = new CMSTransactionRepository.rContract();
                    CrewRecord _crewrecord = _icontract.GetCrewRecord(_crewstatusid);
                    if (_crewrecord != null)
                    {
                        txtDateReported.Text = _crewrecord.DateReported == null ? "" : _crewrecord.DateReported.Value.ToString("MM/dd/yyyy");
                        txtPosition.Text = _crewrecord.Position.PositionName;
                        txtVessel.Text = _crewrecord.Vessel.VesselDescription;
                        txtPrincipal.Text = _crewrecord.Principal.PrincipalDescription;
                        txtDispatch.Text = _crewrecord.DispatchDate == null ? "" : _crewrecord.DispatchDate.Value.ToString("MM/dd/yyyy");
                        txtDisembark.Text = _crewrecord.DisembarkDate == null ? "" : _crewrecord.DisembarkDate.Value.ToString("MM/dd/yyyy");
                        txtReasonDisembarkation.Text = _crewrecord.DisembarkReason.Reason;
                        txtDateArrived.Text = _crewrecord.DateArrived == null ? "": _crewrecord.DateArrived.Value.ToString("MM/dd/yyyy");

                        if (_crewrecord.DateAvailability != null) { optYes.Checked = true; }
                    }
                    
                    txtAddress.Text = _crew.Address;
                    txtContactNo.Text = _crew.TelNo + " / " + _crew.MobileNo;

                    cboAccomodation.SelectedIndex = 0;
                    cboFood.SelectedIndex = 0;
                    cboSalary.SelectedIndex = 0;
                    cboHealth.SelectedIndex = 0;
                    cboSchedule.SelectedIndex = 0;
                    cboSubordinates.SelectedIndex = 0;
                    cboCoWorker.SelectedIndex = 0;
                    cboSuperior.SelectedIndex = 0;
                    cboWorkingGear.SelectedIndex = 0;
                }

                DisplayDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayDocuments()
        {
            List<CrewDocument> _crewdocuments = new List<CrewDocument>();
            List<CrewLicense> _crewlicenses = new List<CrewLicense>();
            List<CrewTraining> _crewtrainings = new List<CrewTraining>();
            List<CrewMedical> _crewmedicals = new List<CrewMedical>();

            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            iCrewTraining _icrewtraining = new CMSFilesRepository.rCrewTraining();
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            try 
            {
                lsvDocument.Items.Clear();
                _crewdocuments = (from d in _icrewdocument.GetCrewDocuments(_applicantid) where d.Doctype == "P" select d).ToList();
                if (_crewdocuments != null)
                {
                    foreach(CrewDocument _list in _crewdocuments)
                    {                    
                        ListViewItem _item = new ListViewItem(_list.Document.NameofDocument);
                        _item.SubItems.Add(_list.DocID.ToString());

                        if (_list.ForRenewal.ToString() == "1") { _item.Checked = true; }
                        lsvDocument.Items.Add(_item);
                    }
                }

                lsvLicences.Items.Clear();
                _crewlicenses = _icrewlicense.GetCrewLicenses(_applicantid);
                if (_crewlicenses != null)
                {
                    foreach (CrewLicense _list in _crewlicenses)
                    {
                        ListViewItem _item = new ListViewItem(_list.License.License_Name);
                        _item.SubItems.Add(_list.ID.ToString());

                        if (_list.ForRenewal.ToString() == "1") { _item.Checked = true; }
                        lsvLicences.Items.Add(_item);
                    }
                }

                lsvTraining.Items.Clear();
                _crewtrainings = _icrewtraining.GetCrewTrainings(_applicantid);
                if (_crewtrainings != null)
                {
                    foreach (CrewTraining _list in _crewtrainings)
                    {
                        ListViewItem _item = new ListViewItem(_list.Training.Training_Name);
                        _item.SubItems.Add(_list.ID.ToString());

                        if (_list.ForRenewal.ToString() == "1") { _item.Checked = true; }
                        lsvTraining.Items.Add(_item);
                    }
                }

                lsvMedical.Items.Clear();
                _crewmedicals = _icrewmedical.GetCrewMedicals(_applicantid);
                if (_crewmedicals  != null)
                {
                    foreach (CrewMedical _list in _crewmedicals)
                    {
                        ListViewItem _item = new ListViewItem(_list.CheckUp.MEDCHECK_NAME);
                        _item.SubItems.Add(_list.id.ToString());

                        lsvMedical.Items.Add(_item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReasonDisembarkation_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ManageDebriefing();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageDebriefing()
        {
            Debriefing _debriefing = new Debriefing();
            iContract _icontract = new CMSTransactionRepository.rContract();
            try
            {
                _debriefing.CrewStatusID = _crewstatusid;
                _debriefing.Accomodation = int.Parse( cboAccomodation.Text);
                _debriefing.Accomodation_Remarks = txtAccomodation.Text;
                _debriefing.Food = int.Parse( cboFood.Text);
                _debriefing.Food_Remarks = txtFood.Text;
                _debriefing.Salary = int.Parse( cboSalary.Text);
                _debriefing.Salary_Remarks = txtSalary.Text;
                _debriefing.Safety = int.Parse( cboHealth.Text);
                _debriefing.Safety_Remarks = txtHealth.Text;
                _debriefing.Working = int.Parse( cboSchedule.Text);
                _debriefing.Working_Remarks = txtSchedule.Text;
                _debriefing.Subordinate = int.Parse( cboSubordinates.Text);
                _debriefing.Coworker = int.Parse( cboCoWorker.Text);
                _debriefing.Superior  = int.Parse( cboSuperior.Text);
                _debriefing.Relation_Remarks = txtRelationship.Text;
                _debriefing.WorkingGear = int.Parse( cboWorkingGear.Text);
                _debriefing.WorkingGear_Remarks = txtWorkinggear.Text;

                if( optYes.Checked){ _debriefing.Overall = "Yes";}
                else { _debriefing.Overall = "No"; }

                _debriefing.Reason = txtReason.Text;
                _debriefing.Comments = txtComments.Text;
                _debriefing.Suggestions = txtSuggestions.Text;
                _debriefing.Evaulation = txtEvaluations.Text;
                _debriefing.UserId = LoginUser.userid;
                _debriefing.DebriefID = _id;

                _id = _icontract.ManageDebriefing(_debriefing, _mode);

                _icontract = new CMSTransactionRepository.rContract();
                ManageForRenewalDocument();
                DisplayDebriefing(_icontract.GetDebriefing(_crewstatusid));

                ToolsControl.CallShowNotification(this, _mode, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ManageForRenewalDocument()
        {
            try 
            {
                TagForRenewalDocument("D", lsvDocument);
                TagForRenewalDocument("L", lsvLicences);
                TagForRenewalDocument("T", lsvTraining);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TagForRenewalDocument(string _type, ListView _listview)
        {
            int _selectedid = 0;
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            try 
            {
                foreach (ListViewItem _lvi in _listview.Items)
                {
                    _icrewdocument = new CMSFilesRepository.rCrewDocument();
                    _selectedid = int.Parse(_lvi.SubItems[1].Text);
                    if (_lvi.Checked) { _icrewdocument.TagDocumentForRenewal(_selectedid, _type, 1); }
                    else { _icrewdocument.TagDocumentForRenewal(_selectedid, _type, 0); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (_mode == 0)
            {
                MessageBox.Show("You must save first this debriefing report before printing.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                ReportControl.CMS _reportcontrol = new ReportControl.CMS();
                _reportcontrol.PrintDebreifing(_principalid, _crewstatusid, _crewid, lsvDocument, lsvLicences, lsvTraining, lsvMedical);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //object objOpt = Type.Missing;
            //Debriefing _debriefing = new Debriefing();
            //iContract _icontract = new CMSTransactionRepository.rContract();

            //try
            //{
            //    Workbook wb;
            //    Worksheet ws;
            //    if (LoginUser.companycode == "SMS")
            //    {
            //        wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Form - SMS New.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);                    
            //    }
            //    else
            //    {
            //        if (_principalid == 15)         //dmm
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Form - MOC New.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);
            //        }
            //        else
            //        {
            //            wb = excel.Workbooks.Open(DCLSystemConfiguration.CMS.Reportpath + @"SMS REPORTS\Debriefing Form - MRA New.xlt", objOpt, true, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt, objOpt);                        
            //        }
            //    }

            //    ws = (Worksheet)wb.Worksheets[1];

            //    _debriefing = _icontract.GetDebriefing(_crewstatusid);
            //    if (_debriefing != null)
            //    {
            //        iCrew _icrew = new CMSFilesRepository.rCrew();
            //        Crew _crew =_icrew.GetCrew(_crewid);


            //        excel.Cells[8, 1] = _crew.LastName + ", " + _crew.FirstName + " " + _crew.MiddleName;
            //        if (_debriefing.CrewRecord.DateReported != null) { excel.Cells[8, 5] = _debriefing.CrewRecord.DateReported.Value.ToString("MM/dd/yyyy"); }
            //        else { excel.Cells[8, 5] = ""; }

            //        excel.Cells[10, 1] = _debriefing.CrewRecord.Position.PositionName;
            //        excel.Cells[10, 3] = _debriefing.CrewRecord.Vessel.VesselDescription;

            //        excel.Cells[10, 6] = _debriefing.CrewRecord.Principal.PrincipalDescription;
            //        excel.Cells[11, 2] = _debriefing.CrewRecord.DispatchDate.Value.ToString("MM/dd/yyyy");
            //        excel.Cells[12, 2] = _debriefing.CrewRecord.DisembarkDate.Value.ToString("MM/dd/yyyy");
            //        excel.Cells[12, 3] = _debriefing.CrewRecord.Remarks;
            //        excel.Cells[12, 6] = _debriefing.CrewRecord.DateArrived.Value.ToString("MM/dd/yyyy");

            //        excel.Cells[19, 4] = _debriefing.Accomodation;
            //        excel.Cells[19, 5] = _debriefing.Accomodation_Remarks;

            //        excel.Cells[21, 4] = _debriefing.Food;
            //        excel.Cells[21, 5] = _debriefing.Food_Remarks;

            //        excel.Cells[23, 4] = _debriefing.Salary;
            //        excel.Cells[23, 5] = _debriefing.Salary_Remarks;

            //        excel.Cells[25, 4] = _debriefing.Safety;
            //        excel.Cells[25, 5] = _debriefing.Safety_Remarks;

            //        excel.Cells[27, 4] = _debriefing.Working;
            //        excel.Cells[27, 5] = _debriefing.Working_Remarks;

            //        excel.Cells[31, 4] = _debriefing.Subordinate;
            //        excel.Cells[32, 4] = _debriefing.Coworker;
            //        excel.Cells[33, 4] = _debriefing.Superior;
            //        excel.Cells[29, 5] = _debriefing.Relation_Remarks;

            //        excel.Cells[34, 4] = _debriefing.WorkingGear;
            //        excel.Cells[34, 5] = _debriefing.WorkingGear_Remarks;

            //        excel.Cells[39, 2] = _debriefing.CrewRecord.DateAvailability.Value.ToString("MM/dd/yyyy");
            //        excel.Cells[39, 5] = _crew.TelNo + " / " + _crew.MobileNo;
            //        excel.Cells[40, 3] = _crew.Address;
            //        excel.Cells[42, 3] = _debriefing.CrewRecord.DisembarkReason.Reason;
                    
            //        ws = (Worksheet)wb.Worksheets[2];
            //        excel.Cells[2, 1] = _debriefing.Comments;
            //        excel.Cells[8, 1] = _debriefing.Evaulation;
            //        excel.Cells[41, 1] = _debriefing.ImportantInstruction;

            //        int _linectr = 15;
            //        foreach (ListViewItem _lvi in lsvDocument.Items)
            //        {
            //            if (_lvi.Checked)
            //            {
            //                excel.Cells[_linectr, 1] = _lvi.Text;
            //                _linectr++;
            //            }
            //        }
            //        _linectr = 15;
            //        foreach (ListViewItem _lvi in lsvLicences.Items)
            //        {
            //            if (_lvi.Checked)
            //            {
            //                excel.Cells[_linectr, 6] = _lvi.Text;
            //                _linectr++;
            //            }
            //        }
            //        _linectr = 27;
            //        foreach (ListViewItem _lvi in lsvTraining.Items)
            //        {
            //            if (_lvi.Checked)
            //            {
            //                excel.Cells[_linectr, 1] = _lvi.Text;
            //                _linectr++;
            //            }
            //        }
            //        _linectr = 27;
            //        foreach (ListViewItem _lvi in lsvMedical.Items)
            //        {
            //            if (_lvi.Checked)
            //            {
            //                excel.Cells[_linectr, 6] = _lvi.Text;
            //                _linectr++;
            //            }
            //        }
            //    }

            //    excel.Visible = true;
            //    CloseExcel(excel);
            //}
            //catch (Exception ex)
            //{
            //    excel.Quit();
            //    CloseExcel(excel);
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //private void CloseExcel(Microsoft.Office.Interop.Excel.Application _excel)
        //{
        //    System.Threading.Thread.Sleep(1000);
        //    System.Runtime.InteropServices.Marshal.ReleaseComObject(_excel);
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();
        //    System.Threading.Thread.Sleep(1000);
        //}

    }
}
