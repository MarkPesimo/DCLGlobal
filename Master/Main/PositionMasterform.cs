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
    public partial class PositionMasterform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        int _mode = 0;
        int _id = 0;
        int _principalid = 0;

        public PositionMasterform()
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

        private void PositionMasterform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                if (Search_txt.Enabled) { Search_txt.Focus(); }
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.POSITION, Feature.Add, SystemModuleType.Masterfile) == false) { return; }
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
            _id = 0;
            txtpositionname.Text = "";
            txtpositionname.Tag = 0;
            txtPOEAposition.Text = "";
            txtPOEAposition.Tag = 0;
            txtJobDescription.Text = "";
            txtJobDescription.Tag = 0;
            cboPositionType.SelectedIndex = 0;
            cboRank.SelectedIndex = 0;
            txtDescription.Text = "";
            txtDepartment.Text = "";

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
            txtpositionname.ReadOnly = !_cond;
            cboPositionType.Enabled = _cond;
            cboRank.Enabled = _cond;
            txtDepartment.ReadOnly = !_cond;
            txtDescription.ReadOnly = !_cond;            

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

            iPosition _iposition = new CMSFilesRepository.rPosition();            
            try
            {
                lsvList.Items.Clear();
                List<Position> _positions = _iposition.GetPositions(_principalid,  _keyword, true);
                foreach (Position _vessel in _positions)
                {
                    ListViewItem _item = new ListViewItem(_vessel.PositionID.ToString());
                    _item.SubItems.Add(_vessel.Principal.PrincipalDescription);
                    _item.SubItems.Add(_vessel.PositionName);
                    _item.SubItems.Add(_vessel.status == true ? "Active" : "Inactive");

                    lsvList.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayRecord(Position _position)
        {
            try
            {
                if (_position != null)
                {
                    _id = _position.PrincipalID;
                    txtPrincipalname.Text = _position.Principal.PrincipalDescription;
                    txtpositionname.Text = _position.PositionName;
                    txtpositionname.Tag = _position.PositionID;
                    txtPOEAposition.Text = _position.POEAPosition.PositionName;
                    txtPOEAposition.Tag = _position.POEAPositionID;
                    txtJobDescription.Text = _position.JobDescription.POSITIONName;
                    txtJobDescription.Tag = _position.JD_ID;

                    cboPositionType.Text = _position.Position_Type;
                    cboRank.Text = _position.Position_Rank;
                    txtDescription.Text = _position.Description;
                    
                    chkStatus.Checked = _position.status == true ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void PositionMasterform_Load(object sender, EventArgs e)
        {
            //iPosition _iposition = new CMSFilesRepository.rPosition();            
            try
            {
                displayPrincipals();
                //DisplayList("");
                //DisplayRecord(_iposition.GetPosition(_id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvList.SelectedItems.Count == 0) { return; }

            iPosition _iposition = new CMSFilesRepository.rPosition();            
            try
            {
                DisplayRecord(_iposition.GetPosition(int.Parse(lsvList.SelectedItems[0].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.POSITION, Feature.Edit, SystemModuleType.Masterfile) == false) { return; }
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
            if (txtpositionname.Text.Length == 0)
            {
                btxMsg.ShowBalloon(txtpositionname);
                txtpositionname.Focus();
                return;
            }
            if (txtPOEAposition.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtPOEAposition);
                txtPOEAposition.Focus();
                return;
            }
            if (txtJobDescription.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtJobDescription);
                txtJobDescription.Focus();
                return;
            }

            ManagePosition();
        }

        void ManagePosition()
        {
            iPosition _iposition = new CMSFilesRepository.rPosition();            
            Position _position = new Position();

            try
            {
                _position.PrincipalID = _id;
                _position.PositionName = txtpositionname.Text;
                _position.PositionID = int.Parse(txtpositionname.Tag.ToString());

                _position.POEAPositionID = txtPOEAposition.Tag.ToString();
                _position.JD_ID = int.Parse( txtJobDescription.Tag.ToString());

                _position.Position_Type = cboPositionType.Text;
                _position.Position_Rank = cboRank.Text;
                _position.Description = txtDescription.Text;
                _position.Department_code = txtDepartment.Text;

                _position.status = chkStatus.Checked ? true : false;

                _id = _iposition.ManagePosition(_position, _mode);
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
            iPosition _iposition = new CMSFilesRepository.rPosition();            
            try
            {
                EnableForm(false);
                EnableButton(true);

                DisplayRecord(_iposition.GetPosition(_id));
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

        private void btnPOEA_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtPOEAposition.Text = "";
            txtPOEAposition.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.POEA_POSITION;
            _Searchform.ShowDialog();

            //POEAPosition _position = _Searchform.ReturnSearchPOEAPosition;
            //if (_position != null)
            //{
            //    txtPOEAposition.Text = _position.PositionName;
            //    txtPOEAposition.Tag = _position.Code;
            //}
        }

        private void btnJD_Click(object sender, EventArgs e)
        {
            if (Add_btn.Enabled) { return; }

            txtJobDescription.Text = "";
            txtJobDescription.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.JOBDESCRIPTION;
            _Searchform.ShowDialog();

            //JobDescription _jobdescription = _Searchform.ReturnSearchJobDescription;
            //if (_jobdescription != null)
            //{
            //    txtJobDescription.Text = _jobdescription.POSITIONName;
            //    txtJobDescription.Tag = _jobdescription.JD_ID;
            //}
        }

        private void txtPrincipalname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnprincipal_Click(sender, e); }
        }

        private void txtPOEAposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPOEAposition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnPOEA_Click(sender, e); }
        }

        private void txtJobDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) { btnJD_Click(sender, e); }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            if (ToolsControl.FunctionAccess(this, SystemModule.CMS.Master.POSITION, Feature.Print, SystemModuleType.Masterfile) == false) { return; }
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

        private void Search_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
