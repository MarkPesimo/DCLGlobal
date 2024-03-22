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

namespace DCLGlobal.Systems.Admin
{
    public partial class ChangePasswordform : Form
    {
        public ChangePasswordform()
        {
            InitializeComponent();
        }

        private void ChangePasswordform_Load(object sender, EventArgs e)
        {

        }

        private void cancelcopybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            iUser _iuser = new GlobalFilesRepository.rUser();

            try
            {
                if (_iuser.ChangePassword(txtOldpassword.Text, txtNewPassword.Text, LoginUser.userid))
                {
                    ToolsControl.CallShowNotification(this, 4, "Password successfully changed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePasswordform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
