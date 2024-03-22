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
using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

//using CAL.CMS.Interface.Tool;
//using CAL.CMS.Repository.Tool;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewEmploymentHistoryControl : UserControl
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        
        string _applicantid = "";
        int _mode = 0;
        int _id = 0;

        public CrewEmploymentHistoryControl(string _Applicantid)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
        }

        private void CrewEmploymentHistoryControl_Load(object sender, EventArgs e)
        {
            iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
            try
            {
                DisplayList();
                DisplayRecord(_icrewexperience.GetCrewExperience(0, _applicantid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_EXPERIENCE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtVessel.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtVessel.Text = "";           
            txtCompany.Text = "";            
            txtVesselType.Text = "";
            txtGRT.Text = "";            
            txtVesselFlag.Text = "";
            txtEngine.Text = "";
            txtPosition.Text = "";
            txtCountry.Text = "";
            txtRemarks.Text = "";

            dtpFrom.Checked = false;
            dtpTo.Checked = false;
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
            txtVessel.ReadOnly = !_cond;
            txtCompany.ReadOnly = !_cond;
            txtVesselType.ReadOnly = !_cond;
            txtCompany.ReadOnly = !_cond;
            txtVesselFlag.ReadOnly = !_cond;
            txtEngine.ReadOnly = !_cond;
            txtPosition.ReadOnly = !_cond;
            txtRemarks.ReadOnly = !_cond;
            
            dtpFrom.Enabled = _cond;
            dtpTo.Enabled = _cond;
            
            tabGrid.Enabled = !_cond;
        }

        void DisplayList()
        {
            grdExperience.RowCount = 0;
            iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
            try
            {
                List<CrewExperience> _crewexperiences = _icrewexperience.GetCrewExperiences(_applicantid);
                foreach (CrewExperience _list in _crewexperiences)
                {
                    int n = grdExperience.Rows.Add();
                    grdExperience.Rows[n].Cells[0].Value = _list.ID;
                    grdExperience.Rows[n].Cells[1].Value = "View";
                    grdExperience.Rows[n].Cells[2].Value = _list.VesselName;
                    grdExperience.Rows[n].Cells[3].Value = _list.VesselType;
                    grdExperience.Rows[n].Cells[4].Value = _list.CompanyName;
                    grdExperience.Rows[n].Cells[5].Value = _list.GRT_Engine_BHP;

                    if (_list.From == null) { grdExperience.Rows[n].Cells[6].Value = ""; }
                    else { grdExperience.Rows[n].Cells[6].Value = _list.From.Value.ToShortDateString(); }
                    if (_list.To == null) { grdExperience.Rows[n].Cells[7].Value = ""; }
                    else { grdExperience.Rows[n].Cells[7].Value = _list.To.Value.ToShortDateString(); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(CrewExperience _crewexperience)
        {            
            try
            {
                if (_crewexperience != null)
                {
                    _id = _crewexperience.ID;
                    txtVessel.Text = _crewexperience.VesselName;
                    txtCompany.Text = _crewexperience.CompanyName;
                    txtVesselType.Text = _crewexperience.VesselType;
                    txtGRT.Text = _crewexperience.GRT_Engine_BHP;
                    txtVesselFlag.Text = _crewexperience.FlagofVessel;
                    txtEngine.Text = _crewexperience.VesselEngine;
                    txtPosition.Text = _crewexperience.PositionName;

                    txtCountry.Text = _crewexperience.CountryName;


                    if (_crewexperience.From != null) { dtpFrom.Value = _crewexperience.From.Value; }
                    else { dtpFrom.Checked = false; }
                    if (_crewexperience.To != null) { dtpTo.Value = _crewexperience.To.Value; }
                    else { dtpTo.Checked = false; }

                    txtRemarks.Text = _crewexperience.Remarks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_EXPERIENCE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtVessel.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtVessel.Text == "")
            {
                btxMsg.ShowBalloon(txtVessel);
                txtVessel.Focus();
                return;
            }
            

            ManageCrewExperience();
        }

        void ManageCrewExperience()
        {
            iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
            CrewExperience _crewexperience = new CrewExperience();

            try
            {
                _crewexperience.ID = _id;
                _crewexperience.ApplicantID = _applicantid;
                _crewexperience.VesselName = txtVessel.Text;
                _crewexperience.VesselType = txtVesselType.Text;
                _crewexperience.CompanyName = txtCompany.Text;
                _crewexperience.VesselType = txtVesselType.Text;
                _crewexperience.GRT_Engine_BHP = txtGRT.Text;
                _crewexperience.FlagofVessel = txtVesselFlag.Text;
                _crewexperience.VesselEngine = txtEngine.Text;
                _crewexperience.PositionName = txtPosition.Text;
                _crewexperience.CountryName = txtCountry.Text;
                _crewexperience.Remarks = txtRemarks.Text;
                
                
                if (dtpFrom.Checked) { _crewexperience.From = dtpFrom.Value; }
                else { _crewexperience.From = null; }
                if (dtpTo.Checked) { _crewexperience.To = dtpTo.Value; }
                else { _crewexperience.To = null; }                                

                _icrewexperience.ManageCrewExperience(_crewexperience, _mode);
                ToolsControl.CallShowNotification(this, _mode, "");

                DisplayRecord(_icrewexperience.GetCrewExperience(_id, _applicantid));
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
            iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icrewexperience.GetCrewExperience(_id, _applicantid));
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

        private void grdExperience_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iCrewExperience _icrewexperience = new CMSFilesRepository.rCrewExperience();
            try
            {
                _id = int.Parse(grdExperience.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (e.ColumnIndex == 1)
                { DisplayRecord(_icrewexperience.GetCrewExperience(_id, _applicantid)); }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.CREW_EXPERIENCE, Feature.Delete, SystemModuleType.Masterfile) == false) { return; }
            if (MessageBox.Show("Delete this selected record, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            _mode = 3;

            ManageCrewExperience();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtCountry.Text = "";
            txtCountry.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtCountry.Text = _country.CountryName;
            //    txtCountry.Tag = _country.ID;
            //}
        }

        private void txtCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnCountry_Click(sender, e); }
        }

    }
}
