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
using DCLGlobal.Inquiry;
using DCLGlobal.Classes;

namespace DCLGlobal.Systems.Admin
{
    public partial class AccessMatrixform : Form
    {
        int _moduletype = 0;
        int _mode = 0;
        int _moduleid = 0;

        public AccessMatrixform()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {            
            txtUsername.Text = "";
            txtUsername.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.GLOBAL.USER;
            _Searchform.ShowDialog();

            Sys_User _user = _Searchform.ReturnSearchUser;
            if (_user != null)
            {
                txtUsername.Text = _user.UserName;
                txtUsername.Tag = _user.UserID;
            }
        }

        private void cboModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //FillModuleList();
                //InitializeGrid(cboModule.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccessMatrixform_Load(object sender, EventArgs e)
        {
            try 
            {
                cboModule.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeGrid()
        {
            DataGridViewTextBoxColumn _ColumnModname            = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _ColumnModid              = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn _ColumnAccid              = new DataGridViewTextBoxColumn();
            DataGridViewCheckBoxColumn _ColumnAccess            = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn _ColumnAccessAdd         = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn _ColumnAccessEdit        = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn _ColumnAccessDel         = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn _ColumnAccessPrint       = new DataGridViewCheckBoxColumn();
            DataGridViewLinkColumn _columnRemoveAccess          = new DataGridViewLinkColumn();            

            try 
            {
                if (txtUsername.Tag.ToString() == "0") { return; }

                dgvAccess.ColumnCount = 0;

                if (_moduletype == 1 || _moduletype == 2)                 //master file and transaction
                {
                    _ColumnModname.DataPropertyName = "ModuleName";
                    _ColumnModname.HeaderText = "Module name";
                    _ColumnModname.Width = 280;
                    _ColumnModname.ReadOnly = true;
                    dgvAccess.Columns.Add(_ColumnModname);

                    _ColumnAccessAdd.DataPropertyName = "AccessAdd";
                    _ColumnAccessAdd.HeaderText = "Access Add";
                    _ColumnAccessAdd.Width = 90;
                    dgvAccess.Columns.Add(_ColumnAccessAdd);

                    
                    _ColumnAccessEdit.DataPropertyName = "AccessEdit";
                    _ColumnAccessEdit.HeaderText = "Access Edit";
                    _ColumnAccessEdit.Width = 90;                
                    dgvAccess.Columns.Add(_ColumnAccessEdit);

                    _ColumnAccessDel.DataPropertyName = "AccessDelete";
                    _ColumnAccessDel.HeaderText = "Access Delete";
                    _ColumnAccessDel.Width = 90;                
                    dgvAccess.Columns.Add(_ColumnAccessDel);

                    _ColumnAccessPrint.DataPropertyName = "AccessPrint";
                    _ColumnAccessPrint.HeaderText = "Access Print";
                    _ColumnAccessPrint.Width = 90;                
                    dgvAccess.Columns.Add(_ColumnAccessPrint);

                    _ColumnModid.DataPropertyName = "id";
                    _ColumnModid.HeaderText = "id";
                    _ColumnModid.Width = 0;
                    _ColumnModid.ReadOnly = true;
                    _ColumnModid.Visible = false;                    
                    dgvAccess.Columns.Add(_ColumnModid);

                    _ColumnAccid.DataPropertyName = "Accid";
                    _ColumnAccid.HeaderText = "id";
                    _ColumnAccid.Width = 0;
                    _ColumnAccid.ReadOnly = true;
                    _ColumnAccid.Visible = false;                
                    dgvAccess.Columns.Add(_ColumnAccid);

                    _columnRemoveAccess.DataPropertyName = "RemoveAccess";
                    _columnRemoveAccess.HeaderText = "Remove Access";
                    _columnRemoveAccess.Width = 120;
                    dgvAccess.Columns.Add(_columnRemoveAccess);
                }
                else if (_moduletype == 0 || _moduletype == 2 || _moduletype == 3 || _moduletype == 4 || _moduletype == 5 || _moduletype == 6)
                { 
                    _ColumnModname.DataPropertyName = "ModuleName";
                    _ColumnModname.HeaderText = "Module name";
                    _ColumnModname.Width = 280;
                    _ColumnModname.ReadOnly = true;                
                    dgvAccess.Columns.Add(_ColumnModname);

                    _ColumnModid.DataPropertyName = "id";
                    _ColumnModid.HeaderText = "id";
                    _ColumnModid.Width = 0;
                    _ColumnModid.ReadOnly = true;
                    _ColumnModid.Visible = false;                
                    dgvAccess.Columns.Add(_ColumnModid);


                    _ColumnAccid.DataPropertyName = "Accid";
                    _ColumnAccid.HeaderText = "id";
                    _ColumnAccid.Width = 0;
                    _ColumnAccid.ReadOnly = true;
                    _ColumnAccid.Visible = false;                
                    dgvAccess.Columns.Add(_ColumnAccid);

                    _columnRemoveAccess.DataPropertyName = "RemoveAccess";
                    _columnRemoveAccess.HeaderText = "Remove Access";
                    _columnRemoveAccess.Width = 120;
                    dgvAccess.Columns.Add(_columnRemoveAccess);
                }

                dgvAccess.RowCount = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillGrid()
        {
            iAccessMatrix _iaccessmatrix = new GlobalFilesRepository.rAccessMatrix();
            List<Sys_Access_Matrix> _accessmatrixes = _iaccessmatrix.GetAccessMatrixes(_moduletype, LoginAppModule.AppModuleId, int.Parse(txtUsername.Tag.ToString()));
            try
            {
                int n = 0;
                foreach (Sys_Access_Matrix _list in _accessmatrixes)
                {
                    if (_moduletype == 1 || _moduletype == 2)           //master file and transaction
                    {
                        dgvAccess.Rows.Add();
                        dgvAccess.Rows[n].Cells[0].Value = _list.Sys_Module.MODULE_NAME;
                        dgvAccess.Rows[n].Cells[1].Value = _list.ACCESS_ADD;
                        dgvAccess.Rows[n].Cells[2].Value = _list.ACCESS_EDIT;
                        dgvAccess.Rows[n].Cells[3].Value = _list.ACCESS_DELETE;
                        dgvAccess.Rows[n].Cells[4].Value = _list.ACCESS_PRINT;
                        dgvAccess.Rows[n].Cells[5].Value = _list.ID;
                        dgvAccess.Rows[n].Cells[6].Value = _list.MODULE_ID;
                        dgvAccess.Rows[n].Cells[7].Value = "Remove access";
                    }
                    else
                    {
                        dgvAccess.Rows.Add();
                        dgvAccess.Rows[n].Cells[0].Value = _list.Sys_Module.MODULE_NAME;                        
                        dgvAccess.Rows[n].Cells[1].Value = _list.ID;
                        dgvAccess.Rows[n].Cells[2].Value = _list.MODULE_ID;
                        dgvAccess.Rows[n].Cells[3].Value = "Remove access";
                    }
                    n++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillModuleList()
        {
            iModule _imodule = new GlobalFilesRepository.rModule();
            _moduletype = GetModuletype();
            List<UserDefineClass.GLOBAL.ModuleIDontHave> _modulesidonthave = _imodule.GetAvailables(_moduletype, LoginAppModule.AppModuleId, int.Parse(txtUsername.Tag.ToString()));
            try
            {
                lsvDetails.Items.Clear();
                foreach (UserDefineClass.GLOBAL.ModuleIDontHave _list in _modulesidonthave)
                {
                    ListViewItem _item = new ListViewItem(_list.moduleid.ToString());
                    _item.SubItems.Add(_list.modulename);                    

                    lsvDetails.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetModuletype()
        {
            int _return = 0;
            if (cboModule.SelectedIndex == 0) { _return = 3; }
            else if (cboModule.SelectedIndex == 1) { _return = 1; }
            else if (cboModule.SelectedIndex == 2) { _return = 6; }
            else if (cboModule.SelectedIndex == 3) { _return = 4; }
            else if (cboModule.SelectedIndex == 4) { _return = 5; }
            else if (cboModule.SelectedIndex == 5) { _return = 2; }

            return _return;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            PerformSearchClick();
        }

        void PerformSearchClick()
        {
            if (txtUsername.Tag.ToString() == "0")
            {
                btxMsg.ShowBalloon(txtUsername);
                txtUsername.Focus();
                return;
            }
            try
            {
                FillModuleList();
                InitializeGrid();
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }


        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _id = 0;
            iAccessMatrix _iaccessmatrix = new GlobalFilesRepository.rAccessMatrix();
            Sys_Access_Matrix _accessmatrix = new Sys_Access_Matrix();
            try
            {
                if (_moduletype == 3 || _moduletype == 6 || _moduletype == 4 || _moduletype == 5)       //3:INQUIRY | 6:PROCESS | 4:SYSTEM | 5:
                {
                    if (e.ColumnIndex == 3) //remove
                    {
                        _mode = 3;
                        _id = int.Parse(dgvAccess.Rows[e.RowIndex].Cells[1].Value.ToString());

                    }
                }
                else 
                {
                    if (e.ColumnIndex == 7) //remove
                    {
                        _mode = 3;
                        _id = int.Parse(dgvAccess.Rows[e.RowIndex].Cells[5].Value.ToString());
                    }
                }

                if (_id != 0)
                {
                    _accessmatrix.ID = _id;                    
                    _iaccessmatrix.ManageAccessMatrix(_accessmatrix, _mode);
                    FillModuleList();
                    InitializeGrid();

                    ToolsControl.CallShowNotification(this, 3, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccessMatrixform_KeyDown(object sender, KeyEventArgs e)
        {
            try 
            {
                if (e.KeyCode == Keys.F3)
                {
                    panCopy.Visible = true;
                    panCopy.BringToFront();

                    txtCopyFrom.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            bool _value = false;
            try
            {
                if (_moduletype == 1 || _moduletype == 2)
                {
                    if (checkbtn.Text == "Check All")
                    {
                        checkbtn.Text = "Uncheck All";
                        _value = true;                       
                    }
                    else
                    {
                        checkbtn.Text ="Uncheck All";
                        _value = false;
                    }

                    for (int i = 0; i < dgvAccess.RowCount - 2; i++)
                    {
                        dgvAccess.Rows[i].Cells[1].Value = _value;
                        dgvAccess.Rows[i].Cells[2].Value = _value;
                        dgvAccess.Rows[i].Cells[3].Value = _value;
                        dgvAccess.Rows[i].Cells[4].Value = _value;
                    }
                }
                else
                {
                    MessageBox.Show("Feature available only for module type Master file and Transaction.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            int _id = 0;
            iAccessMatrix _iaccessmatrix = new GlobalFilesRepository.rAccessMatrix();

            try 
            {
                _mode = 2;
                for (int i = 0; i < dgvAccess.RowCount - 2; i++)
                {
                    //if (dgvAccess.Rows[0].Cells[1].Value.ToString() == "")
                    if (dgvAccess.Rows[0].Cells[5].Value.ToString() == "")
                    {
                        return;
                    }
                    
                    Sys_Access_Matrix _accessmatrix = new Sys_Access_Matrix();
                    //_id = int.Parse(dgvAccess.Rows[i].Cells[1].Value.ToString());
                    _id = int.Parse(dgvAccess.Rows[i].Cells[5].Value.ToString());

                    _accessmatrix.ID = _id;
                    _accessmatrix.USERID = int.Parse(txtUsername.Tag.ToString());

                    if (dgvAccess.Rows[i].Cells[1].Value == null) { _accessmatrix.ACCESS_ADD = false; }
                    else { _accessmatrix.ACCESS_ADD = bool.Parse(dgvAccess.Rows[i].Cells[1].Value.ToString()); }

                    if (dgvAccess.Rows[i].Cells[2].Value == null) { _accessmatrix.ACCESS_EDIT = false; }
                    else { _accessmatrix.ACCESS_EDIT = bool.Parse(dgvAccess.Rows[i].Cells[2].Value.ToString()); }

                    if (dgvAccess.Rows[i].Cells[3].Value == null) { _accessmatrix.ACCESS_DELETE = false; }
                    else { _accessmatrix.ACCESS_DELETE = bool.Parse(dgvAccess.Rows[i].Cells[3].Value.ToString()); }

                    if (dgvAccess.Rows[i].Cells[4].Value == null) { _accessmatrix.ACCESS_PRINT = false; }
                    else { _accessmatrix.ACCESS_PRINT = bool.Parse(dgvAccess.Rows[i].Cells[4].Value.ToString()); }

                    _accessmatrix.MODULE_ID = int.Parse(dgvAccess.Rows[i].Cells[6].Value.ToString());  //added by Alen 6/16/16
                    _accessmatrix.ACCESS = true;  //added by Alen 6/16/16

                    _iaccessmatrix.ManageAccessMatrix(_accessmatrix, _mode);
                }

                FillModuleList();
                ToolsControl.CallShowNotification(this, 1, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            txtCopyFrom.Text = "";
            txtCopyFrom.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.GLOBAL.USER;
            _Searchform.ShowDialog();

            Sys_User _user = _Searchform.ReturnSearchUser;
            if (_user != null)
            {
                txtCopyFrom.Text = _user.UserName;
                txtCopyFrom.Tag = _user.UserID;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            txtCopyTo.Text = "";
            txtCopyTo.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.GLOBAL.USER;
            _Searchform.ShowDialog();

            Sys_User _user = _Searchform.ReturnSearchUser;
            if (_user != null)
            {
                txtCopyTo.Text = _user.UserName;
                txtCopyTo.Tag = _user.UserID;
            }
        }

        private void cancelcopybtn_Click(object sender, EventArgs e)
        {
            panCopy.Visible = false;
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            if (txtCopyFrom.Tag.ToString() == "")
            {
                btxMsg.ShowBalloon(txtCopyFrom);
                txtCopyFrom.Focus();
                return;
            }
            if (txtCopyTo.Tag.ToString() == "")
            {
                btxMsg.ShowBalloon(txtCopyTo);
                txtCopyTo.Focus();
                return;
            }

            iAccessMatrix _iaccessmatrix = new GlobalFilesRepository.rAccessMatrix();
            try 
            { 
                if (MessageBox.Show("Copy Access rights of " + txtCopyFrom.Text + " to " + txtCopyTo.Text + ", Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                _iaccessmatrix.CopyAccessRigths(int.Parse(txtCopyFrom.Tag.ToString()), int.Parse(txtCopyTo.Tag.ToString()));

                ToolsControl.CallShowNotification(this, 4, "Access Rights successfully copied.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lsvDetails.SelectedItems.Count == 0) { return; }
            //try
            //{ 
            //    _moduleid=  int.Parse(lsvDetails.SelectedItems[0].Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lsvDetails_DoubleClick(object sender, EventArgs e)
        {        
            if (lsvDetails.SelectedItems.Count == 0) { return; }
            iAccessMatrix _iaccessmatrix = new GlobalFilesRepository.rAccessMatrix();
            try
            {
                _mode = 1;
                Sys_Access_Matrix _accessmatrix = new Sys_Access_Matrix();

                _moduleid = int.Parse(lsvDetails.SelectedItems[0].Text);
                _accessmatrix.MODULE_ID = _moduleid;
                _accessmatrix.USERID = int.Parse(txtUsername.Tag.ToString());
                _accessmatrix.ACCESS_ADD = false;
                _accessmatrix.ACCESS_EDIT = false ;
                _accessmatrix.ACCESS_DELETE = false;
                _accessmatrix.ACCESS_PRINT = false;

                _iaccessmatrix.ManageAccessMatrix(_accessmatrix, _mode);

                FillModuleList();
                PerformSearchClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
