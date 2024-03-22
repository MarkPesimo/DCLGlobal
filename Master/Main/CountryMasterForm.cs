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
    public partial class CountryMasterForm : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        int _id = 0;

        public CountryMasterForm()
        {
            InitializeComponent();
        }

        private void CountryMasterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.COUNTRY, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtCountry.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtCountry.Text = "";
            txtNationality.Text = "";
            txtPOEACountry.Text = "";
            txtPOEACountry.Tag = 0;
            
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
            txtCountry.ReadOnly = !_cond;
            txtNationality.ReadOnly = !_cond;

            chkStatus.Enabled = _cond;
            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            iCountry _icountry = new CMSFilesRepository.rCountry();               
            try
            {
                lsvList.Items.Clear();
                List<Country> _countries = _icountry.GetCountries(_keyword, "ALL");
                foreach (Country _list in _countries)
                {
                    ListViewItem _item = new ListViewItem(_list.ID.ToString());
                    _item.SubItems.Add(_list.CountryName);
                    _item.SubItems.Add(_list.Nationality);
                    _item.SubItems.Add(_list.Status.ToUpper() == "ACTIVE" ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Country _country)
        {
            try
            {
                if (_country != null)
                {
                    _id = _country.ID;
                    txtCountry.Text = _country.CountryName;
                    txtNationality.Text = _country.Nationality;

                    txtPOEACountry.Tag = _country.POEACode;
                    txtPOEACountry.Text = _country.POEACountry.CountryName;

                    chkStatus.Checked = _country.Status.ToUpper() == "ACTIVE" ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CountryMasterForm_Load(object sender, EventArgs e)
        {
            iCountry _icountry = new CMSFilesRepository.rCountry();               
            try
            {
                DisplayList("");
                DisplayRecord(_icountry.GetCountry(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iCountry _icountry = new CMSFilesRepository.rCountry();               
            try
            {
                DisplayRecord(_icountry.GetCountry(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.COUNTRY, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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

                txtCountry.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {            
            if (txtCountry.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtCountry);
                txtCountry.Focus();
                return;
            }
            if (txtPOEACountry.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtPOEACountry);
                txtPOEACountry.Focus();
                return;
            }

            ManageCountries();
        }

        void ManageCountries()
        {
            iCountry _icountry = new CMSFilesRepository.rCountry();               
            Country _country = new Country();

            try
            {
                _country.ID = _id;
                _country.CountryName = txtCountry.Text;
                _country.Nationality = txtNationality.Text;

                _country.POEACode = txtPOEACountry.Tag.ToString();
                _country.Status = chkStatus.Checked ? "ACTIVE" : "INACTIVE";

                _id = _icountry.ManageCoutnry(_country, _mode);
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
            iCountry _icountry = new CMSFilesRepository.rCountry();               
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_icountry.GetCountry(int.Parse(txtCountry.Tag.ToString())));
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

        private void btnCountry_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtPOEACountry.Text = "";
            txtPOEACountry.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.POEA_COUNTRY;
            _Searchform.ShowDialog();

            //POEACountry _country = _Searchform.ReturnSearchPOEACountry;
            //if (_country != null)
            //{
            //    txtPOEACountry.Text = _country.CountryName;
            //    txtPOEACountry.Tag = _country.CountryID;
            //}
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.COUNTRY, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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
