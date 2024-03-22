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
using CAL.Model;
using CAL.MASTER.Interface;
using CAL.MASTER.Repository;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class ScanDocumentform : Form
    {
        private int _id;
        private string _doctype;
        private string _applicantid;
        private int _scandocid;

        private string _scandocument;
        private string _docext;
        private string _filename;
        private string _location;

        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);

        public ScanDocumentform(int _Id, string _Doctype, string _Applicantid)
        {
            InitializeComponent();
            _id = _Id;
            _doctype = _Doctype;
            _applicantid = _Applicantid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OFD1.Title = "Select a file";
            
                OFD1.Filter = "MS Excel(*.xls;*.xlsx)|*.xls;*.xlsx|" +
                "MS Word(*.doc;*.docx)|*.doc;*.docx|" + 
                "MS Powerpoint(*.ppt;*.pptx)|*.ppt;*.pptx|" +
                "Acrobat reader(*.pdf)|*.pdf|" +
                "Picture(*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png|" +
                "All Files(*.*)|*.*";

                OFD1.FilterIndex = 6;
                OFD1.FileName = "";
                OFD1.ShowDialog();

                if (OFD1.FileName == "") { return; }

                btnSave.Enabled = true;
                txtfilename.Text = OFD1.FileName;

                _scandocument = OFD1.FileName;
                _docext = System.IO.Path.GetExtension(_scandocument);
                _filename = System.IO.Path.GetFileNameWithoutExtension(_scandocument);
                _location = System.IO.Path.GetDirectoryName(_scandocument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtfilename.TextLength == 0)
            {
                btxMsg.ShowBalloon(txtfilename);
                txtfilename.Focus();
                return;
            }

            
            if (MessageBox.Show("Save this scan documents, Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) { return; }

            ManageScandocument();
        }

        void ManageScandocument()
        {
            iScanDocument _iscandocument = new CMSFilesRepository.rScanDocument();
            ScanDocument _scandocument = new ScanDocument();
            try 
            {
                _scandocument.CrewDocID = _id;
                _scandocument.docdept = _doctype;
                _scandocument.DocType = _docext;
                _scandocument.FileName = _filename;
                _scandocument.Location = _location;

                _scandocid = _iscandocument.ManageScandocuments(_scandocument, 1, _doctype, _applicantid);

                ToolsControl.CallPopMessage(this, "Information", "Document successfully Attached");                 
                Thread.Sleep(1000);

                
                this.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
