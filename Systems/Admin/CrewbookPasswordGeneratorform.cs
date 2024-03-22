using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace DCLGlobal.Systems.Admin
{
    public partial class CrewbookPasswordGeneratorform : Form
    {
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);

        public CrewbookPasswordGeneratorform()
        {
            InitializeComponent();
        }

        private void bntPrincipal_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "";
            txtPrincipal.Tag = 0;

            Searchform _Searchform = new Searchform();
            _Searchform._searchby = searchby.CMS.PRINCIPAL;
            _Searchform.ShowDialog();

            //Principal _principal = _Searchform.ReturnSearchPrincipal;
            //if (_principal != null)
            //{
            //    txtPrincipal.Text = _principal.PrincipalDescription;
            //    txtPrincipal.Tag = _principal.PrincipalID;

            //    DisplayList();
            //}
        }

        void DisplayList()
        {
            //iCrew _icrew = new CMSFilesRepository.rCrew();
            //List<SP_C_GENERATE_PASSWORDResult> _passwords = _icrew.GetPasswordGenerated(int.Parse( txtPrincipal.Tag.ToString()));
            //lsvList.Items.Clear();
            //try 
            //{
            //    foreach (SP_C_GENERATE_PASSWORDResult _list in _passwords)
            //    {
            //        ListViewItem _item = new ListViewItem("");
            //        _item.Checked = false;
            //        _item.SubItems.Add(_list.Crewname);
            //        _item.SubItems.Add(_list.password);
            //        _item.SubItems.Add(_list.CrewId.ToString());

            //        lsvList.Items.Add(_item);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            //}
        }

        private void btnReplanned_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Save selected generated password, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ////iCrew _icrew = new CrewRepository(DCLSystemConfiguration.Connection);
            //iCrew _icrew = new CMSFilesRepository.rCrew();
            //try
            //{
            //    foreach(ListViewItem _list in lsvList.CheckedItems)
            //    {
            //        _icrew.SavePasswordGenerated(int.Parse(_list.SubItems[2].ToString()), _list.SubItems[3].Text);
            //    }
            //    ToolsControl.CallShowNotification(this, 4, "Selected password successfully saved");
            //    DisplayList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            //}
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem _list in lsvList.Items)
            {
                _list.Checked = chkStatus.Checked;
            }
        }
    }
}
