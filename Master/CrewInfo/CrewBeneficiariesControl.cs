using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using CAL.Global;
using CAL.Model;
//using CAL.CMS.Interface.Crew;
//using CAL.CMS.Repository.Crew;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

//using CAL.CMS.Interface.Tool;
//using CAL.CMS.Repository.Tool;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewBeneficiariesControl : UserControl
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        
        int _id = 0;
        int _mode = 0;
        int _crewid = 0;
        string _applicantid = "";

        public CrewBeneficiariesControl(int _Crewid, string _Applicantid)
        {
            InitializeComponent();
            FillRelationShip();
            _crewid = _Crewid;
            _applicantid = _Applicantid;
        }

        private void CrewBeneficiariesControl_Load(object sender, EventArgs e)
        {
            iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
            try
            {
                DisplayList();
                DisplayRecord(_icrewbeneficiaries.GetCrewBeneficiary(0,_applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillRelationShip()
        {
            List<POEARelatioship> _relationships = new List<POEARelatioship>();
            iRelationship _irelationship = new CMSFilesRepository.rRelationship();

            try
            {
                _relationships = _irelationship.GetRelationships("");
                foreach (POEARelatioship _list in _relationships)
                {
                    cborelationship.Items.Add(_list.Relationship);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_BENEFICIARIES, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtlastname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtlastname.Text = "";
            txtfirstname.Tag = 0;
            txtmiddlename.Text = "";
            txtcontactno.Text = "";
            txtaddress.Text = "";
            cborelationship.SelectedIndex = 0;
            dtpbday.Checked = false;
            cboCivilstatus.SelectedIndex = 0;
            cbogender.SelectedIndex = 0;
            txtdisability.Text = "";
            txtoccupation.Text = "";

            chkprimary.Checked = false;
            chkowwa.Checked = false;
            chkPhilhealth.Checked = false;
            chkEmployed.Checked = false;
            chkAllotee.Checked = false;
            chkDisable.Checked = false;
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
            txtlastname.ReadOnly = !_cond;
            txtfirstname.ReadOnly = !_cond;
            txtmiddlename.ReadOnly = !_cond;
            txtcontactno.ReadOnly = !_cond;
            txtaddress.ReadOnly = !_cond;
            cborelationship.Enabled = _cond;
            dtpbday.Enabled = _cond;
            cboCivilstatus.Enabled = _cond;
            cbogender.Enabled = _cond;
            txtdisability.ReadOnly = !_cond;
            txtoccupation.ReadOnly = !_cond;

            chkprimary.Enabled = _cond;
            chkowwa.Enabled = _cond;
            chkPhilhealth.Enabled = _cond;
            chkEmployed.Enabled = _cond;
            chkAllotee.Enabled = _cond;
            chkDisable.Enabled = _cond;
            
            tabGrid.Enabled = !_cond;
        }

        void DisplayList()
        {
            grdValidTraining.RowCount = 0;
            iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
            try
            {
                List<CrewBeneficiary> _crewbeneficiaries = _icrewbeneficiaries.GetCrewBeneficiaries(_applicantid);
                foreach (CrewBeneficiary _list in _crewbeneficiaries)
                {
                    int n = grdValidTraining.Rows.Add();
                    grdValidTraining.Rows[n].Cells[0].Value = _list.ID;
                    grdValidTraining.Rows[n].Cells[1].Value = "View";
                    grdValidTraining.Rows[n].Cells[2].Value = _list.LastName + ", " + _list.FirstName + " " + _list.MiddleName;
                    grdValidTraining.Rows[n].Cells[3].Value = _list.RelationShip;
                    grdValidTraining.Rows[n].Cells[4].Value = _list.BirthDay == null ? "" : _list.BirthDay.Value.ToShortDateString();
                    grdValidTraining.Rows[n].Cells[5].Value = _list.Sex == "1" ? "Male" : "Female";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void DisplayRecord(CrewBeneficiary _crewbeneficiary)
        {
            iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();            
            try
            {
                if (_crewbeneficiary != null)
                {
                    _id = _crewbeneficiary.ID;
                    txtlastname.Text = _crewbeneficiary.LastName;
                    txtfirstname.Text = _crewbeneficiary.FirstName;
                    txtmiddlename.Text = _crewbeneficiary.MiddleName;
                    txtcontactno.Text = _crewbeneficiary.ContactNo;
                    txtaddress.Text = _crewbeneficiary.Address;

                    cborelationship.Text = _crewbeneficiary.RelationShip;
                    dtpbday.Value = _crewbeneficiary.BirthDay.Value;
                    cboCivilstatus.Text = _crewbeneficiary.CivilStatus;
                    cbogender.Text = _crewbeneficiary.Sex == "1" ? "Male": "Female";

                    txtdisability.Text = _crewbeneficiary.Nature;
                    txtoccupation.Text = _crewbeneficiary.Occupation;

                    
                    if (_crewbeneficiary.IsBenif == null) { chkprimary.Checked = false; }
                    else { chkprimary.Checked = _crewbeneficiary.IsBenif == 1 ? true : false; }

                    if (_crewbeneficiary.OWWA == null) { chkowwa.Checked = false; }
                    else { chkowwa.Checked = _crewbeneficiary.OWWA == 1 ? true : false; }

                    if (_crewbeneficiary.PhilHealth == null) { chkPhilhealth.Checked = false; }
                    else { chkPhilhealth.Checked = _crewbeneficiary.PhilHealth == 1 ? true : false; }

                    if (_crewbeneficiary.IsEmployed == null) { chkEmployed.Checked = false; }
                    else { chkEmployed.Checked = _crewbeneficiary.IsEmployed == 1 ? true : false; }

                    if (_crewbeneficiary.IsAllotee == null) { chkAllotee.Checked = false; }
                    else { chkAllotee.Checked = _crewbeneficiary.IsAllotee == 1 ? true : false; }

                    if (_crewbeneficiary.IsDisable == null) { chkDisable.Checked = false; }
                    else { chkDisable.Checked = _crewbeneficiary.IsDisable == 1 ? true : false; }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_BENEFICIARIES, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtlastname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtlastname.TextLength == 0)
            {
                btxMsg.ShowBalloon(txtlastname);
                txtlastname.Focus();
                return;
            }
            if (txtfirstname.TextLength == 0)
            {
                btxMsg.ShowBalloon(txtfirstname);
                txtfirstname.Focus();
                return;
            }
            if (txtmiddlename.TextLength == 0)
            {
                btxMsg.ShowBalloon(txtmiddlename);
                txtmiddlename.Focus();
                return;
            }

            ManageCrewBeneficiaries();
        }

        void ManageCrewBeneficiaries()
        {
            iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
            CrewBeneficiary _crewbeneficiaries = new CrewBeneficiary();

            try
            {
                _crewbeneficiaries.ID = _id;
                _crewbeneficiaries.Applicantid = _applicantid;
                _crewbeneficiaries.CrewID = _crewid;
                _crewbeneficiaries.LastName = txtlastname.Text;
                _crewbeneficiaries.FirstName = txtfirstname.Text;
                _crewbeneficiaries.MiddleName = txtmiddlename.Text;
                _crewbeneficiaries.ContactNo = txtcontactno.Text;
                _crewbeneficiaries.Address = txtaddress.Text;

                _crewbeneficiaries.RelationShip = cborelationship.Text;
                if (dtpbday.Checked) { _crewbeneficiaries.BirthDay = dtpbday.Value; }
                else { _crewbeneficiaries.BirthDay = null; }
                _crewbeneficiaries.CivilStatus = cboCivilstatus.Text;

                _crewbeneficiaries.Sex = cbogender.Text;
                _crewbeneficiaries.Nature = txtdisability.Text;
                _crewbeneficiaries.Occupation = txtoccupation.Text;

                _crewbeneficiaries.IsBenif = chkprimary.Checked == true ? byte.Parse("1"): byte.Parse("0");
                _crewbeneficiaries.OWWA = chkowwa.Checked == true ? byte.Parse("1") : byte.Parse("0");
                _crewbeneficiaries.PhilHealth = chkPhilhealth.Checked == true ? byte.Parse("1") : byte.Parse("0");
                _crewbeneficiaries.IsEmployed = chkEmployed.Checked == true ? byte.Parse("1") : byte.Parse("0");
                _crewbeneficiaries.IsAllotee = chkAllotee.Checked == true ? byte.Parse("1") : byte.Parse("0");
                _crewbeneficiaries.IsDisable = chkDisable.Checked == true ? byte.Parse("1") : byte.Parse("0");


                _id = _icrewbeneficiaries.ManageCrewBeneficiary(_crewbeneficiaries, _mode);
                ToolsControl.CallShowNotification(this, _mode, "");

                DisplayRecord(_icrewbeneficiaries.GetCrewBeneficiary(_id, _applicantid));
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
            iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewbeneficiaries.GetCrewBeneficiary(_id, _applicantid));
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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_BENEFICIARIES, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 3;

            ManageCrewBeneficiaries();
        }

        private void grdValidTraining_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iCrewBeneficiaries _icrewbeneficiaries = new CMSFilesRepository.rCrewBeneficiary();
            try
            {
                _id = int.Parse(grdValidTraining.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (e.ColumnIndex == 1)
                {
                    DisplayRecord(_icrewbeneficiaries.GetCrewBeneficiary(_id, _applicantid));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRelationship()
        {

        }
    }
}
