using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Model;
using CAL.Global;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using DCLGlobal.Classes;
using DCLGlobal.Inquiry;

namespace DCLGlobal.Master.Main.Fleet
{
    public partial class PrincipalFleetMasterform : Form
    {
        int _fleetid = 0;
        int _mode = 0;
        int _id = 0;

        public PrincipalFleetMasterform()
        {
            InitializeComponent();
        }

        private void DisplayRecord(FLEET_VESSEL _fleetvessel)
        {
            try
            {
                if (_fleetvessel != null)
                { 
                    _fleetid = int.Parse( _fleetvessel.FLEET_ID.ToString());
                    txtFleetname.Text = _fleetvessel.FLEET.FLEET_NAME;
                    txtVessel.Text = _fleetvessel.Vessel.VesselDescription;

                    _id = _fleetvessel.ID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void EnabledForm(bool _cond)
        //{ 
        //    Add_btn.Enabled = !_cond;
        //    Edit_btn.Enabled = !_cond;
        //    delete_btn.Enabled = !_cond;
        //    print_btn.Enabled = !_cond;

        //    txtKeyword.Enabled = !_cond;
        //    lsvList.Enabled = !_cond;

        //    Save_btn.Enabled = !_cond;
        //    cancel_btn.Enabled = !_cond;

        //    txtFleetname.ReadOnly = !_cond;        
        //}

        private void ManageFleetVessel()
        {
            FLEET_VESSEL _fleetvessel = new FLEET_VESSEL();
            iFleetVessel _ifleetvessel = new CMSFilesRepository.rFleetVessel();
            try 
            {
                _fleetvessel.FLEET_ID = _fleetid;
                _fleetvessel.VESSEL_ID = int.Parse( txtVessel.Tag.ToString());
                _fleetvessel.ID = _id;

                _id = _ifleetvessel.ManageFleetVessel(_fleetvessel, _mode);
                Cancel();

                _ifleetvessel = new CMSFilesRepository.rFleetVessel();

                if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
                else { ToolsControl.CallShowNotification(this, 3, ""); }

                DisplayList(Search_txt.Text);               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrincipalFleetMasterform_Load(object sender, EventArgs e)
        {
            try
            {
                FillFleets("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeForm()
        {
            txtVessel.Text = "";
            _id = 0;
        }

        private void FillFleets(string _keyword)
        {
            iFleet _ifleet = new CMSFilesRepository.rFleet();
            try
            {
                lsvList.Items.Clear();
                List<FLEET> _fleets = _ifleet.GetFleets(_keyword);
                foreach (FLEET _x in _fleets)
                {
                    ListViewItem _item = new ListViewItem(_x.ID.ToString());
                    _item.SubItems.Add(_x.FLEET_NAME);

                    lsvList.Items.Add(_item);
                }
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


        private void Cancel()
        {
            iFleetVessel _ifleetvessel = new CMSFilesRepository.rFleetVessel();
            try
            {
                //EnabledForm(false);
                EnableForm(false);
                EnableButton(true);
                DisplayRecord(_ifleetvessel.GetFleetVessel(_id , _fleetid));
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
            txtFleetname.ReadOnly = !_cond;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PRINCIPAL_FLEET, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtFleetname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayList(string _keyword)
        {
            iFleetVessel _ifleetvessel = new CMSFilesRepository.rFleetVessel();
            try
            {
                lvVessel.Items.Clear();
                List<FLEET_VESSEL> _fleetvessels = _ifleetvessel.GetFleetVessels(_fleetid);
                foreach (FLEET_VESSEL _x in _fleetvessels)
                {
                    ListViewItem _item = new ListViewItem(_x.ID.ToString());
                    _item.SubItems.Add(_x.Vessel.VesselDescription);

                    lvVessel.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iFleet _ifleet = new CMSFilesRepository.rFleet();
            try
            {
                _id = 0;
                txtVessel.Text = "";
                _fleetid =int.Parse(lsvList.SelectedItems[0].Text);
                txtFleetname.Text = lsvList.SelectedItems[0].SubItems[1].Text;
                DisplayList("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvVessel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVessel.SelectedItems.Count == 0) { return; }

            iFleetVessel _ifleetvessel = new CMSFilesRepository.rFleetVessel();
            try
            {
                _id = int.Parse(lvVessel.SelectedItems[0].Text);
                DisplayRecord(_ifleetvessel.GetFleetVessel(_id, _fleetid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PRINCIPAL_FLEET, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtFleetname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (_fleetid == 0)
            {
                btxMsg.ShowBalloon(txtFleetname);
                txtFleetname.Focus();
                return;
            }
            if (txtFleetname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtFleetname);
                txtFleetname.Focus();
                return;
            }

            ManageFleetVessel();
        }

        private void btnVessel_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtVessel.Text = "";
            txtVessel.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.VESSEL;
            _Searchform.ShowDialog();

            //Vessel _vessel = _Searchform.ReturnSearchVessel;
            //if (_vessel != null)
            //{
            //    txtVessel.Text = _vessel.VesselDescription;
            //    txtVessel.Tag = _vessel.VesselID;
            //}
        }

        private void Search_txt_Click(object sender, EventArgs e)
        {

        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void PrincipalFleetMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void txtVessel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnVessel_Click(sender, e); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.PRINCIPAL_FLEET, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
        }

        protected void Search_txt_GotFocus(object sender, EventArgs e)
        {
            Color _color_focus = Color.FromArgb(255, 255, 136);
            Search_txt.BackColor = _color_focus;
        }

        protected void Search_txt_LostFocus(object sender, EventArgs e)
        {
            Search_txt.BackColor = Color.White;
        }

    }
}
