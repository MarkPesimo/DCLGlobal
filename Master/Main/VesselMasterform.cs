using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.Global;

using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main
{
    public partial class VesselMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        int _id = 0;
        int _mode = 0;
        int _principalid = 0;

        public VesselMasterform()
        {
            InitializeComponent();
        }

        private void displayPrincipals()
        {
            iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
            try
            {
                lsvPrincipal.Items.Clear();
                List<Principal> _principals = _iprincipal.GetPrincipals("", "All");
                foreach (Principal _principal in _principals)
                {
                    ListViewItem _item = new ListViewItem(_principal.PrincipalID.ToString());
                    _item.SubItems.Add(_principal.PrincipalDescription);

                    lsvPrincipal.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.VESSEL, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtPrincipalname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            txtPrincipalname.Text = "";
            txtPrincipalname.Tag = 0;
            txtvesselname.Text = "";
            _id = 0;
            txtvesseltype.Text = "";
            txtofficialno.Text = "";
            txtclassification.Text = "";
            txtyearbuilt.Text = "";
            txttraderoute.Text = "";
            txtgrosstonage.Text = "";
            txtkilowatt.Text = "";
            txtenginetype.Text = "";
            txtenginecapacity.Text = "";
            txtcountry.Text = "";
            txtcountry.Tag= 0;

            chkStatus.Checked = true;
        }

        void EnableButton(bool _cond)
        {
            Add_btn.Enabled = _cond;
            Edit_btn.Enabled = _cond;
            print_btn.Enabled = _cond;
            Search_txt.Enabled = _cond;

            Save_btn.Enabled = !_cond;
            cancel_btn.Enabled = !_cond;
        }


        void EnableForm(bool _cond)
        {
            txtvesselname.ReadOnly = !_cond;
            txtvesseltype.ReadOnly = !_cond;
            txtofficialno.ReadOnly = !_cond;
            txtclassification.ReadOnly = !_cond;
            txtyearbuilt.ReadOnly = !_cond;
            txttraderoute.ReadOnly = !_cond;
            txtgrosstonage.ReadOnly = !_cond;
            txtkilowatt.ReadOnly = !_cond;
            txtenginetype.ReadOnly = !_cond;
            txtenginecapacity.ReadOnly = !_cond;
                       
            chkStatus.Enabled = _cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            if (_principalid == 0)
            {
                MessageBox.Show("Kindly select first a account.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                expPrincipal.Expanded = true;
                lsvPrincipal.Focus();
                return;
            }

            iVessel _ivessel = new CMSFilesRepository.rVessel();     
            try
            {
                lsvList.Items.Clear();
                List<Vessel> _vessels = _ivessel.GetVessels(_principalid, _keyword, true);
                foreach (Vessel _vessel in _vessels)
                {
                    ListViewItem _item = new ListViewItem(_vessel.VesselID.ToString());                  
                    _item.SubItems.Add(_vessel.Principal.PrincipalDescription);
                    _item.SubItems.Add(_vessel.VesselDescription);
                    _item.SubItems.Add(_vessel.Status == "0" ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Vessel _vessel)
        {
            try
            {
                if (_vessel != null)
                {
                    txtPrincipalname.Tag = _vessel.PrincipalID;
                    txtPrincipalname.Text = _vessel.Principal.PrincipalDescription;
                    txtvesselname.Text = _vessel.VesselDescription;
                    _id = _vessel.VesselID;
                    txtvesseltype.Text = _vessel.VesselType;
                    txtofficialno.Text   = _vessel.OfficialNo;
                    txtclassification.Text = _vessel.Clasiification;
                    txtyearbuilt.Text = _vessel.YearBuilt  ;
                    txttraderoute.Text = _vessel.JoiningPort;
                    txtgrosstonage.Text = _vessel.GrossTon;
                    txtkilowatt.Text = _vessel.Kilowatt;
                    txtenginetype.Text = _vessel.EngineType;
                    txtenginecapacity.Text = _vessel.EngineCapacity;
                    txtcountry.Text = _vessel.Country.CountryName;
                    txtcountry.Tag = _vessel.CountryID;

                    chkStatus.Checked = _vessel.Status == "0" ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VesselMasterform_Load(object sender, EventArgs e)
        {
            //iVessel _ivessel = new CMSFilesRepository.rVessel();     
            try
            {
                displayPrincipals();
                //DisplayList("");
                //DisplayRecord(_ivessel.GetVessel(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iVessel _ivessel = new CMSFilesRepository.rVessel();     
            try
            {
                DisplayRecord(_ivessel.GetVessel(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.VESSEL, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (_id == 0)
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtPrincipalname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtPrincipalname.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtPrincipalname);
                txtPrincipalname.Focus();
                return;
            }
            if (txtvesselname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtvesselname);
                txtvesselname.Focus();
                return;
            }
            if (txtcountry.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtcountry);
                txtcountry.Focus();
                return;
            }

            ManageVessel();
        }

        void ManageVessel()
        {
            iVessel _ivessel = new CMSFilesRepository.rVessel();     
            Vessel _vessel = new Vessel();

            try
            {
                _vessel.PrincipalID = int.Parse(txtPrincipalname.Tag.ToString());
                _vessel.VesselDescription = txtvesselname.Text;
                _vessel.VesselID = _id;
                _vessel.VesselType = txtvesseltype.Text;
                _vessel.OfficialNo= txtofficialno.Text;
                _vessel.Clasiification = txtclassification.Text;
                _vessel.YearBuilt = txtyearbuilt.Text;
                _vessel.JoiningPort = txttraderoute.Text;
                _vessel.GrossTon = txtgrosstonage.Text;
                _vessel.Kilowatt = txtkilowatt.Text;
                _vessel.EngineType = txtenginetype.Text;
                _vessel.EngineCapacity = txtenginecapacity.Text;
                _vessel.CountryID = int.Parse( txtcountry.Tag.ToString());
                _vessel.Status = chkStatus.Checked ? "0" : "1";

                _id = _ivessel.ManageVessel(_vessel, _mode);
                Cancel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayList(Search_txt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel()
        {
            iVessel _ivessel = new CMSFilesRepository.rVessel();     
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_ivessel.GetVessel(_id));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnprincipal_Click(object sender, EventArgs e)
        {
             if (Add_btn.Enabled) { return; }

            txtPrincipalname.Text = "";
            txtPrincipalname.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PRINCIPAL;
            _Searchform.ShowDialog();

            //Principal _principal = _Searchform.ReturnSearchPrincipal;
            //if (_principal != null)
            //{
            //    txtPrincipalname.Text = _principal.PrincipalDescription;
            //    txtPrincipalname.Tag = _principal.PrincipalID;
            //}
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void btncountry_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtcountry.Text = "";
            txtcountry.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtcountry.Text = _country.CountryName;
            //    txtcountry.Tag = _country.ID;
            //}
        }

        private void VesselMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void txtPrincipalname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnprincipal_Click(sender, e); }
        }

        private void txtcountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btncountry_Click(sender, e); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.VESSEL, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        private void lsvPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPrincipal.SelectedItems.Count == 0) { return; }

            try
            {
                _principalid = int.Parse(lsvPrincipal.SelectedItems[0].Text);
                DisplayList("");
                //DisplayRecord(_iprincipal.GetPrincipal(int.Parse(lsvAccount.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
