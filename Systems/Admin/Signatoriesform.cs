using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using CAL.Global;
using DCLGlobal.Classes;

namespace DCLGlobal.Systems.Admin
{
    public partial class Signatoriesform : Form
    {
        Signatories _signatories = new Signatories();
        public Signatoriesform()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Save this signatories, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            _signatories.SetCMSSignatories(txtPresident.Text, 
                txtPresidentSig.Text, 
                txtVicepresident.Text, 
                txtVPSig.Text, 
                txtOM.Text, 
                txtOMSig.Text, 
                txtAH.Text, 
                txtAHSig.Text,
                txtAO.Text, 
                txtAOSig.Text,
                txtDA.Text, 
                txtDASig.Text, 
                txtLACAR.Text, 
                txtLACARSig.Text,
                txtLACOfficer.Text,
                txtLACOfficerSig.Text, 
                txtMedicalInCharge.Text, 
                txtMedicalSig.Text, 
                txtNotes1.Text, 
                txtRequestor.Text, 
                txtNotes2.Text, 
                txtMaker.Text, 
                txtCoOwner.Text, 
                txtCBA.Text);

            ToolsControl.CallPopMessage(this, "Information", "Signatories Saved");
            Thread.Sleep(1000);
            this.Close();
        }

        private void Signatoriesform_Load(object sender, EventArgs e)
        {
            DisplaySignatories();
        }

        private void DisplaySignatories()
        {
            
            try 
            {
                txtPresident.Text = Signatories.CMS.President;
                txtPresidentSig.Text = Signatories.CMS.PresidentSignatories;
                txtVicepresident.Text = Signatories.CMS.Vicepresident;
                txtVPSig.Text = Signatories.CMS.VicePresidentSignatories;
                txtOM.Text = Signatories.CMS.OperationsManager;
                txtOMSig.Text = Signatories.CMS.OperationsManagerSignatories;
                txtAH.Text = Signatories.CMS.AccountsHead;
                txtAHSig.Text = Signatories.CMS.AccountsHeadSignatories;
                txtAO.Text = Signatories.CMS.AccountsOfficer;
                txtAOSig.Text = Signatories.CMS.AccountsOfficerSignatories;
                txtAS.Text = Signatories.CMS.AccountSupervisor;
                txtASSig.Text = Signatories.CMS.AccountSupervisorSignatories;
                txtDA.Text = Signatories.CMS.DocumentAssistant;
                txtDASig.Text = Signatories.CMS.DocumentAssistantSignatories;
                txtLACAR.Text = Signatories.CMS.LACAuthorizedRepresentative;
                txtLACARSig.Text = Signatories.CMS.LACARSignatories;
                txtLACOfficer.Text = Signatories.CMS.LACOfficer;
                txtLACOfficerSig.Text = Signatories.CMS.LACOfficerSignatories;
                txtMedicalInCharge.Text = Signatories.CMS.MedicalInCharge;
                txtMedicalSig.Text = Signatories.CMS.MedicalInChargeSignatories;
                txtNotes1.Text = Signatories.CMS.Notes1;
                txtRequestor.Text = Signatories.CMS.Requestor;
                txtNotes2.Text = Signatories.CMS.Notes2;
                txtRequestor.Text = Signatories.CMS.Requestor;
                txtCoOwner.Text = Signatories.CMS.CoOwner;
                txtMaker.Text = Signatories.CMS.Maker;
                txtCBA.Text = Signatories.CMS.CBA;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
