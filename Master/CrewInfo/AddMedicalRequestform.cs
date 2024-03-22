using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CAL.Global;
using DCLGlobal.Classes;
using CAL.Model;

//using CAL.CMS.Interface.Crew;
//using CAL.CMS.Repository.Crew;

using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class AddMedicalRequestform : Form
    {
        private int _requestid;
        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iTransaction _itransaction = new TransactionRepository(DCLSystemConfiguration.Connection);
        
        public AddMedicalRequestform(int _RequestId)
        {
            InitializeComponent();
            _requestid = _RequestId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void AvailableCheckups()
        {
            iCheckUp _iCheckUp = new CMSFilesRepository.rCheckup();
            try 
            {
                lsvAvailable.Items.Clear();
                List<CheckUp> _checkups = _iCheckUp.GetAvailableCheckups(_requestid);
                foreach (CheckUp _list in _checkups)
                {
                    ListViewItem _item = new ListViewItem(_list.MEDCHECK_NAME);
                    _item.SubItems.Add(_list.MEDCHECK_NAME);

                    lsvAvailable.Items.Add(_item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMedicalRequestform_Load(object sender, EventArgs e)
        {
            try 
            {
                AvailableCheckups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvAvailable_DoubleClick(object sender, EventArgs e)
        {            
            try 
            {               
                foreach (ListViewItem _itemselected in lsvAvailable.SelectedItems)
                {
                    ListViewItem _selected = new ListViewItem(_itemselected.Text);
                    _selected.SubItems.Add(_itemselected.SubItems[1].Text);                   
                    
                    _itemselected.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvSelected_DoubleClick(object sender, EventArgs e)
        {
            try 
            {
                foreach (ListViewItem _itemselected in lsvSelected.SelectedItems)
                {
                    _itemselected.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if (lsvSelected.Items.Count == 0)
                {
                    MessageBox.Show("Kindly select atleast one medical check up before saving.", "Info.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Save all selected medical check up, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

                foreach (ListViewItem _item in lsvSelected.Items)
                {
                    iCrewMedicalRequest _icrewmedicalrequest = new CMSTransactionRepository.rCrewMedicalRequest();

                    CrewMedicalRequestDetail _detail = new CrewMedicalRequestDetail();
                    _detail.CheckID = int.Parse(_item.SubItems[1].Text);
                    _detail.MedRequestID = _requestid;
                    _detail.Id = 0;

                    _icrewmedicalrequest.ManageCrewMedicalRequestDetails(_detail, 0);
                }


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
