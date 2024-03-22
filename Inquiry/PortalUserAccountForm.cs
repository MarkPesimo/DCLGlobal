using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Inquiry
{
    public partial class PortalUserAccountForm : Form
    {
        int _empid;
        int _userid;
        bool _flag;

        public PortalUserAccountForm(int _EMPID)
        {
            InitializeComponent();
            _empid = _EMPID;
        }

        void BindPortalRole(ComboBox _cmb)
        {
            iPortal _iportal = new HURISRepository.rPortal();

            try
            {
                List<PortalRole> _portalrole = _iportal.GetPortalRoles();
                _cmb.DataSource = _portalrole;
                _cmb.DisplayMember = "Name";
                _cmb.ValueMember = "RoleID";
                _cmb.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadUserRole()
        {
            iPortal _iportal = new HURISRepository.rPortal();

            try
            {
                PortalUser _portaluser = _iportal.GetPortalUser(_empid);
                if (_portaluser != null)
                {
                    txtUname.Text = _portaluser.UserName;
                    cmbRole.SelectedValue = _portaluser.RoleID;
                    cmbUType.Text=_portaluser.UserType;
                    chkStat.Checked = Convert.ToBoolean(_portaluser.Status);
                    _userid = _portaluser.UserID;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Update user account?", "Save User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.No) { return; }

            UpdateUserTypeRole();
            Close();
        }

        void UpdateUserTypeRole()
        {
            iPortal _iportal = new HURISRepository.rPortal();

            try
            {
                _iportal.ManagePortalUser(_userid, txtUname.Text, int.Parse(cmbRole.SelectedValue.ToString()), cmbUType.SelectedItem.ToString(), Convert.ToBoolean(chkStat.Checked));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PortalUserAccountForm_Load(object sender, EventArgs e)
        {
            BindPortalRole(cmbRole);
            LoadUserRole();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Reset password?", "Password reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_result == DialogResult.No) { return; }

            ResetPassword();
            if (_flag == true)
            {
                MessageBox.Show("Password was succesfully reset.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        void ResetPassword()
        {
            iPortal _iportal = new HURISRepository.rPortal();

            try
            {
                _iportal.ResetPassword(_userid);
                _flag = true;
            }

            catch (Exception ex)
            {
                _flag = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PortalUserAccountForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
