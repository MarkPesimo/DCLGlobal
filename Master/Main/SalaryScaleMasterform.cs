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
    public partial class SalaryScaleMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iFiles _ifiles = new FilesRepository();
        int _principalid = 0;        
        int _mode = 0;
        int _id = 0;
        int _addons_id = 0;

        public SalaryScaleMasterform()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.SALARYSCALE, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
            try
            {
                InitializeField();
                _mode = 0;
                EnableForm(true);
                EnableButton(false);

                txtprincipalname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeField()
        {
            _id = 0;
            txtprincipalname.Text = "";
            txtprincipalname.Tag = 0;
            txtpositionname.Text = "";
            txtpositionname.Tag = 0;
            txtjobsite.Text = "";
            txtjobsite.Tag = 0;
            txtcontractmonths.Text = "";
            txtcontractdays.Text = "";
            txtbasicsalary.Text = "0";
            cbocontracttype.SelectedIndex = 0;
            txtcurrencytype.Text = "";
            txtconsolidatedamount.Text = "0";
            txtworkinghours.Text = "";
            txtovertime.Text = "";
            txtleavepay.Text = "";
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
            txtcontractmonths.ReadOnly = !_cond;
            txtcontractdays.ReadOnly = !_cond;
            txtbasicsalary.ReadOnly = !_cond;
            txtconsolidatedamount.ReadOnly = !_cond;
            txtworkinghours.ReadOnly = !_cond;
            txtovertime.ReadOnly = !_cond;
            txtleavepay.ReadOnly = !_cond;
            cbocontracttype.Enabled = _cond;
            chkStatus.Enabled = _cond;

            pan_Search.Enabled = !_cond;
        }

        void DisplayList(string _keyword)
        {
            //iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();        
            //try
            //{
            //    lsvList.Items.Clear();
            //    List<SalaryScale> _salaryscales = _isalaryscale.GetSalaryScales(_keyword, _principalid);
            //    foreach (SalaryScale _x in _salaryscales)
            //    {
            //        ListViewItem _item = new ListViewItem(_x.SalaryID.ToString());
            //        _item.SubItems.Add(_x.Position.Principal.PrincipalDescription);
            //        _item.SubItems.Add(_x.Position.PositionName);
            //        _item.SubItems.Add(_x.Inactive == true ? "Active" : "Inactive");

            //        lsvList.Items.Add(_item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void DisplayRecord()//SalaryScale _salaryscale)
        {
            //try
            //{
            //    if (_salaryscale != null)
            //    {
            //        _id = _salaryscale.SalaryID;
            //        txtprincipalname.Tag = _salaryscale.PrincipalID;
            //        txtprincipalname.Text = _salaryscale.Principal.PrincipalDescription;
            //        txtpositionname.Text = _salaryscale.Position.PositionName;
            //        txtpositionname.Tag = _salaryscale.PositionID;
            //        txtjobsite.Text = _salaryscale.Country.CountryName;
            //        txtjobsite.Tag = _salaryscale.CountryId;
                    
            //        txtcontractmonths.Text = _salaryscale.ContractYear;
            //        txtcontractdays.Text = _salaryscale.ContractDays;
            //        txtbasicsalary.Text = _salaryscale.Amount.ToString();
            //        txtconsolidatedamount.Text = _salaryscale.ConsolidatedSalary.ToString();
            //        txtcurrencytype.Text = _salaryscale.Symbol;
            //        cbocontracttype.Text = _salaryscale.SalaryType;

            //        txtworkinghours.Text = _salaryscale.Particulars;
            //        //txtworkinghours.Tag = int.Parse(_salaryscale.SalaryID.ToString());
            //        txtovertime.Text = _salaryscale.Remarks;
            //        txtleavepay.Text = _salaryscale.VacationLeaveWithPay;                   

            //        chkStatus.Checked = _salaryscale.Inactive == true ? false : true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void SalaryScaleMasterform_Load(object sender, EventArgs e)
        {
            //iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();        
            try
            {
                DisplayPrincipals();
                //DisplayList("");
                //DisplayRecord(_isalaryscale.GetSalaryScale(0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPrincipals()
        {
            //iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal(); 
            //try
            //{
            //    lsvPrincipal.Items.Clear();
            //    List<Principal> _principals = _iprincipal.GetPrincipals("", "");
            //    foreach (Principal _x in _principals)
            //    {
            //        ListViewItem _item = new ListViewItem(_x.PrincipalID.ToString());
            //        _item.SubItems.Add(_x.PrincipalDescription);

            //        lsvPrincipal.Items.Add(_item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvList.SelectedItems.Count == 0) { return; }

            //iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();        
            //try
            //{
            //    DisplayRecord(_isalaryscale.GetSalaryScale(int.Parse(lsvList.SelectedItems[0].Text)));
            //    DisplaySalaryScaleAddOns();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.SALARYSCALE, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
            if (txtworkinghours.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select first a record to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _mode = 1;
                EnableForm(true);
                EnableButton(false);

                txtprincipalname.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (txtprincipalname.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtprincipalname);
                txtprincipalname.Focus();
                return;
            }
            if (txtpositionname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtpositionname);
                txtpositionname.Focus();
                return;
            }
            if (txtjobsite.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtjobsite);
                txtjobsite.Focus();
                return;
            }
            if (txtcontractmonths.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtcontractmonths);
                txtcontractmonths.Focus();
                return;
            }
            if (txtbasicsalary.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtbasicsalary);
                txtbasicsalary.Focus();
                return;
            }


            ManageSalaryScale();
        }

        void ManageSalaryScale()
        {
            //iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();        
            //SalaryScale _salaryscale = new SalaryScale();

            //try
            //{
            //    _salaryscale.PrincipalID = int.Parse(txtprincipalname.Tag.ToString());
            //    _salaryscale.PositionID = int.Parse(txtpositionname.Tag.ToString());
            //    _salaryscale.CountryId = int.Parse(txtjobsite.Tag.ToString());
            //    _salaryscale.ContractYear = txtcontractmonths.Text;
            //    _salaryscale.ContractDays = txtcontractdays.Text;
            //    _salaryscale.Amount = decimal.Parse( txtbasicsalary.Text);
            //    _salaryscale.ConsolidatedSalary = decimal.Parse(txtconsolidatedamount.Text);
            //    _salaryscale.SalaryType = cbocontracttype.Text;
            //    _salaryscale.Particulars = txtworkinghours.Text;
            //    _salaryscale.Remarks = txtovertime.Text;
            //    _salaryscale.VacationLeaveWithPay = txtleavepay.Text;
            //    _salaryscale.SalaryID = _id;

            //    if (chkStatus.Checked) { _salaryscale.Inactive = false; }
            //    else { _salaryscale.Inactive = true; }

            //    _id = _isalaryscale.ManageSalaryScale(_salaryscale, _mode);
            //    Cancel();

            //    if (_mode == 0 || _mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
            //    else { ToolsControl.CallShowNotification(this, 3, ""); }

            //    DisplayList(Search_txt.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Cancel()
        {
            //iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();        
            //try
            //{
            //    EnableForm(false);
            //    EnableButton(true);

            //    DisplayRecord(_isalaryscale.GetSalaryScale(_id));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnprincipal_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtprincipalname.Text = "";
            txtprincipalname.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PRINCIPAL;
            _Searchform.ShowDialog();

            //Principal _principal = _Searchform.ReturnSearchPrincipal;
            //if (_principal != null)
            //{
            //    txtprincipalname.Text = _principal.PrincipalDescription;
            //    txtprincipalname.Tag = _principal.PrincipalID;
            //}
        }

        private void btnjobsite_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtjobsite.Text = "";
            txtjobsite.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.COUNTRY;
            _Searchform.ShowDialog();

            //Country _country = _Searchform.ReturnSearchCountry;
            //if (_country != null)
            //{
            //    txtjobsite.Text = _country.CountryName;
            //    txtjobsite.Tag = _country.ID;
            //}
        }

        private void btnposition_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            if (txtprincipalname.Tag.ToString() == "0")
            {
                MessageBox.Show("Kindly select a principal first", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprincipalname.Focus();
                return;
            }
            txtpositionname.Text = "";
            txtpositionname.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._principalid = int.Parse(txtprincipalname.Tag.ToString());
            _Searchform._searchby = searchby.CMS.POSITION;
            _Searchform.ShowDialog();

            //Position _position = _Searchform.ReturnSearchPosition;
            //if (_position != null)
            //{
            //    txtpositionname.Text = _position.PositionName;
            //    txtpositionname.Tag = _position.PositionID;
            //}
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtcurrencytype.Text = "";
            
            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.POEA_CURRENCY;
            _Searchform.ShowDialog();

            //POEACountry _poeacountry = _Searchform.ReturnSearchPOEACountry;
            //if (_poeacountry != null)
            //{
            //    txtcurrencytype.Text = _poeacountry.Currency;
            //}
        }

        private void Search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList(Search_txt.Text);
            }
        }

        private void SalaryScaleMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.SALARYSCALE, Feature.Print, SystemModuleType.Masterfile) == false) { return; }

        }

        private void Search_txt_Click(object sender, EventArgs e)
        {

        }

        private void lsvPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvPrincipal.SelectedItems.Count == 0) { return; }

            //iSalaryScale _isalaryscale = new CMSFilesRepository.rSalaryScale();        
            //try
            //{
            //    _principalid = int.Parse( lsvPrincipal.SelectedItems[0].Text);
            //    DisplayList("");
            //    DisplayRecord(_isalaryscale.GetSalaryScale(_principalid, 0));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lsvAddons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAddons.SelectedItems.Count == 0) { return; }

            try
            {
                _addons_id = int.Parse(lsvList.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvAddons_DoubleClick(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Delete this Salary Addons, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            //try 
            //{
            //    SALARYSCALE_ADDON _addon = new SALARYSCALE_ADDON();
            //    _addon.ADDONS_ID = 0;
            //    _addon.SALARYSCALE_ID =_id;
            //    _addon.AMOUNT = 0;
            //    _addon.FOR_COMPUTATION = false;
            //    _addon.OTHER_BENIFITS = false;
            //    _addon.id = _addons_id;

            //    ManageSalaryAddons(2, _addon);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void ManageSalaryAddons()//int Mode, SALARYSCALE_ADDON _salaryaddon)
        {
            //iSalaryAddons _isalaryaddons = new CMSFilesRepository.rSalaryAddons();
            //int Id = 0;
            //try
            //{
            //    Id = _isalaryaddons.ManageSalaryScaleAddOns(_salaryaddon, Mode);

            //    cboAddOns.SelectedIndex = 0;
            //    txtLineno.Text = "";
            //    txtAddOnAmount.Text = "0";
            //    chkComputation.Checked = true;
            //    chkOtherBenefits.Checked = false;
            //    chkIsAllotement.Checked = false;

            //    if (Mode == 0 || Mode == 1) { ToolsControl.CallShowNotification(this, _mode, ""); }
            //    else { ToolsControl.CallShowNotification(this, 3, ""); }

            //    DisplaySalaryScaleAddOns();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        void DisplaySalaryScaleAddOns()
        {
            //iSalaryAddons _isalaryaddons = new CMSFilesRepository.rSalaryAddons(); 
            //try
            //{
            //    lsvAddons.Items.Clear();
            //    List<SALARYSCALE_ADDON> _addons = _isalaryaddons.GetSalaryAddons(_id);
            //    foreach (SALARYSCALE_ADDON _x in _addons)
            //    {
            //        ListViewItem _item = new ListViewItem(_x.id.ToString());
            //        _item.SubItems.Add(_x.LINE_NO.ToString());
            //        _item.SubItems.Add(_x.ADDON.DESCRIPTION);
            //        _item.SubItems.Add(_x.AMOUNT.ToString());
            //        if (bool.Parse( _x.FOR_COMPUTATION.ToString())) { _item.SubItems.Add("Yes"); }
            //        else { _item.SubItems.Add("No"); }
            //        if (bool.Parse(_x.OTHER_BENIFITS.ToString())) { _item.SubItems.Add("Yes"); }
            //        else { _item.SubItems.Add("No"); }
            //        if (bool.Parse(_x.IS_ALLOTEMENT.ToString())) { _item.SubItems.Add("Yes"); }
            //        else { _item.SubItems.Add("No"); }

            //        lsvAddons.Items.Add(_item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnAddOns_Click(object sender, EventArgs e)
        {            
            try
            {                
                cboAddOns.DataSource = null;
                FillCboAddons();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillCboAddons()
        {
            //iAddons _iaddon = new CMSFilesRepository.rAddon();
            //try
            //{
            //    List<ADDON> _list = _iaddon.GetAddOns("", true);
            //    cboAddOns.DataSource = _list;
            //    cboAddOns.DisplayMember = "DESCRIPTION";
            //    cboAddOns.ValueMember = "id";
            //    cboAddOns.SelectedIndex = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {            
            //try 
            //{
            //    if (txtLineno.Text.Length == 0)
            //    {
            //        btxMsg.ShowBalloon(txtLineno);
            //        txtLineno.Focus();
            //        return;
            //    }

            //    if (cboAddOns.SelectedIndex == -1)
            //    {
            //        MessageBox.Show("Kindly select a add-ons", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        cboAddOns.SelectedIndex = 0;
            //        cboAddOns.Focus();
            //        return;
            //    }
            //    if (MessageBox.Show("Save Salary Addons, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }
            //    iAddons _iaddon = new CMSFilesRepository.rAddon();

            //    SALARYSCALE_ADDON _addon = new SALARYSCALE_ADDON();
            //    _addon.ADDONS_ID = int.Parse(cboAddOns.SelectedValue.ToString());
            //    _addon.SALARYSCALE_ID = _id;
            //    _addon.LINE_NO  = int.Parse( txtLineno.Text);
            //    _addon.AMOUNT = decimal.Parse( txtAddOnAmount.Text);
            //    _addon.FOR_COMPUTATION = chkComputation.Checked;
            //    _addon.OTHER_BENIFITS = chkOtherBenefits.Checked;
            //    _addon.IS_ALLOTEMENT = chkIsAllotement.Checked;
            //    _addon.id = 0;

            //    ManageSalaryAddons(0, _addon);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}       
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
