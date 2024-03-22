using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

using DCLGlobal.Classes;
using CAL.Global;

namespace DCLGlobal.Systems.Admin
{
    public partial class Configureform : Form
    {
        string _module = "";
        public Configureform(string _Module)
        {
            InitializeComponent();
            _module = _Module;
        }

        private void Configureform_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            ConnectionControl _configure = new ConnectionControl();

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\CMS", "Server Name", null) != null)
            {
                txtCMSServername.Text               = DCLSystemConfiguration.CMS.Servername;
                txtCMSdatabase.Text                 = DCLSystemConfiguration.CMS.Databasename;
                txtCMSReportPath.Text               = DCLSystemConfiguration.CMS.Reportpath;
                txtCMSScandocsPath.Text             = DCLSystemConfiguration.CMS.Documentpath;
                txtCMSImagePath.Text                = DCLSystemConfiguration.CMS.Imagepath;

                txtCMSUsername.Text                 = DCLSystemConfiguration.CMS.Username;
                txtCMSPassword.Text                 = _configure.Dcrypt(DCLSystemConfiguration.CMS.Password);
            }

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\IHOPS", "Server Name", null) != null)
            {
                txtIHOPSServer.Text                 = DCLSystemConfiguration.IHOPS.Servername;
                txtIHOPSDB.Text                     = DCLSystemConfiguration.IHOPS.Databasename;
                txtIHOPSReportpath.Text             = DCLSystemConfiguration.IHOPS.Reportpath;
                txtIHOPSImagePath.Text              = DCLSystemConfiguration.IHOPS.Imagepath;
                txtIHOPSdocumentpath.Text           = DCLSystemConfiguration.IHOPS.Documentpath;

                txtIHOPSusername.Text               = DCLSystemConfiguration.IHOPS.Username;
                txtIHOPSpassword.Text               = _configure.Dcrypt(DCLSystemConfiguration.IHOPS.Password);
            }

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\HURIS", "Server Name", null) != null)
            {
                txtHURISServername.Text             = DCLSystemConfiguration.HURIS.Servername;
                txtHURISDatabase.Text               = DCLSystemConfiguration.HURIS.Databasename;
                txtHURISReportPath.Text             = DCLSystemConfiguration.HURIS.Reportpath;
                txtHURISImagepath.Text              = DCLSystemConfiguration.HURIS.Imagepath;
                txtHURISDocumentpath.Text           = DCLSystemConfiguration.HURIS.Documentpath;
                txtHURISTrainingPath.Text           = DCLSystemConfiguration.HURIS.Trainingpath;

                txtHURISusername.Text               = DCLSystemConfiguration.HURIS.Username;
                txtHURISpassword.Text               = _configure.Dcrypt(DCLSystemConfiguration.HURIS.Password);
            }

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\IRECRUIT", "Server Name", null) != null)
            {
                txtiRECRUITServername.Text          = DCLSystemConfiguration.IRECRUIT.Servername;
                txtiRECRUITDatabase.Text            = DCLSystemConfiguration.IRECRUIT.Databasename;
                txtiRECRUITReportPath.Text          = DCLSystemConfiguration.IRECRUIT.Reportpath;
                txtIRecruitScandocsPath.Text        = DCLSystemConfiguration.IRECRUIT.Documentpath;
                txtiRECRUITImageLocation.Text       = DCLSystemConfiguration.IRECRUIT.Imagepath;
                txtIRECRUITftpurl.Text              = DCLSystemConfiguration.IRECRUIT.ftpimageurl;
                txtIRECRUITftpimageurl.Text         = DCLSystemConfiguration.IRECRUIT.ftpimageurl;
                txtIRECRUITftpcmsusername.Text      = DCLSystemConfiguration.IRECRUIT.ftpcmsusername;
                txtIRECRUITftpirecruitusername.Text = DCLSystemConfiguration.IRECRUIT.ftpirecruitusername;
                txtIrecruitImagePath.Text           = DCLSystemConfiguration.IRECRUIT.imagecvpath;
                txtIrecruitServerReportPath.Text    = DCLSystemConfiguration.IRECRUIT.serverreportpath;
                txtIRECRUITftppassword.Text         = _configure.Dcrypt(DCLSystemConfiguration.IRECRUIT.ftppassword);

                txtIRECRUITusername.Text            = DCLSystemConfiguration.IRECRUIT.Username;
                txtIRECRUITpassword.Text            = _configure.Dcrypt(DCLSystemConfiguration.IRECRUIT.Password);
            }

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\DCLAPS", "Server Name", null) != null)
            {
                txtDCLAPSserver.Text                = DCLSystemConfiguration.DCLAPS.Servername;
                txtDCLAPSdb.Text                    = DCLSystemConfiguration.DCLAPS.Databasename;
                txtDCLAPSreport.Text                = DCLSystemConfiguration.DCLAPS.Reportpath;

                txtDCLAPScc.Text                    = DCLSystemConfiguration.DCLAPS.Carboncopy;
                txtDCLAPSexportpath.Text            = DCLSystemConfiguration.DCLAPS.Exportpath;
                txtDCLAPSusername.Text              = DCLSystemConfiguration.DCLAPS.Username;
                txtDCLAPSpassword.Text              = _configure.Dcrypt(DCLSystemConfiguration.DCLAPS.Password);
            }


            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\TAMS", "Server Name", null) != null)
            {
                txtTAMSServername.Text              = DCLSystemConfiguration.TAMS.Servername;
                txtTAMSDB.Text                      = DCLSystemConfiguration.TAMS.Databasename;
                txtTAMSimagepath.Text               = DCLSystemConfiguration.TAMS.Imagepath;
                txtTAMSusername.Text                = DCLSystemConfiguration.TAMS.Username;
                txtTAMSpassword.Text                = _configure.Dcrypt(DCLSystemConfiguration.TAMS.Password);
            }

            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\DCL System\ABS", "Server Name", null) != null)
            {
                txtAbsServerName.Text               = DCLSystemConfiguration.ABS.Servername;
                txtAbsDbName.Text                   = DCLSystemConfiguration.ABS.Databasename;
                txtabsReportPath.Text               = DCLSystemConfiguration.ABS.Reportpath;
                txtAbsDocumentPath.Text             = DCLSystemConfiguration.ABS.Documentpath;
                txtAbsUsername.Text                 = DCLSystemConfiguration.ABS.Username;
                txtAbsPassword.Text                 = _configure.Dcrypt(DCLSystemConfiguration.ABS.Password);
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.CMS, txtCMSServername.Text, txtCMSdatabase.Text, txtCMSReportPath.Text, txtCMSScandocsPath.Text, txtCMSImagePath.Text, "", txtCMSUsername.Text, txtCMSPassword.Text, "", "", "", "", "", "", "", "", "");

                ShowMessage(appmodule.CMS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void tabGrid_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.HURIS, txtHURISServername.Text, txtHURISDatabase.Text, txtHURISReportPath.Text, txtHURISDocumentpath.Text, txtHURISImagepath.Text, txtHURISTrainingPath.Text, txtHURISusername.Text, txtHURISpassword.Text, "", "", "", "", "", "", "", "", "");

                ShowMessage(appmodule.HURIS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigureIrecruit_Click(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.IRECRUIT, txtiRECRUITServername.Text, txtiRECRUITDatabase.Text, txtiRECRUITReportPath.Text, txtIRecruitScandocsPath.Text, txtiRECRUITImageLocation.Text, "", txtIRECRUITusername.Text, txtIRECRUITpassword.Text, txtIRECRUITftpurl.Text, txtIRECRUITftpimageurl.Text, txtIRECRUITftpcmsusername.Text, txtIRECRUITftpirecruitusername.Text, txtIRECRUITftppassword.Text, txtIrecruitImagePath.Text, txtIrecruitServerReportPath.Text, "", "");

                ShowMessage(appmodule.IRECRUIT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIHOPSconfigure_Click(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.IHOPS, txtIHOPSServer.Text, txtIHOPSDB.Text, txtIHOPSReportpath.Text, txtIHOPSdocumentpath.Text, txtIHOPSImagePath.Text, "", txtIHOPSusername.Text, txtIHOPSpassword.Text, "", "", "", "", "","" , "", "", "");

                ShowMessage(appmodule.IHOPS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDCLAPSconfigure_Click(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.DCLAPS, txtDCLAPSserver.Text, txtDCLAPSdb.Text, txtDCLAPSreport.Text, "", "", "", txtDCLAPSusername.Text, txtDCLAPSpassword.Text, "", "", "", "", "", "", "", txtDCLAPScc.Text, txtDCLAPSexportpath.Text);

                ShowMessage(appmodule.DCLAPS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigureTAMS_Click(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.TAMS, txtTAMSServername.Text, txtTAMSDB.Text, "","", txtTAMSimagepath.Text, "", txtTAMSusername.Text, txtTAMSpassword.Text, "", "", "", "", "", "", "", "", "");

                ShowMessage(appmodule.TAMS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfigureAbs_Click(object sender, EventArgs e)
        {
            ConnectionControl _configure = new ConnectionControl();
            try
            {
                _configure.SetSystemConfiguration(appmodule.ABS, txtAbsServerName.Text, txtAbsDbName.Text, txtabsReportPath.Text, txtAbsDocumentPath.Text,"", "", txtAbsUsername.Text, txtAbsPassword.Text, "", "", "", "", "", "", "", "", "");

                ShowMessage(appmodule.ABS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowMessage(string _module)
        {
            try
            {
                ToolsControl.CallPopMessage(this, _module +  " System Configuration updated.", "");
                Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
