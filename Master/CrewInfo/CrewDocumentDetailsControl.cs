using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using CAL.Global;
using CAL.Model;


using CAL.MASTER.Interface;
using CAL.MASTER.Repository;


namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewDocumentDetailsControl : UserControl
    {
        private string _applicantid;
        private string _type;
        private int _id;

        CrewDocumentControl _parent;

        public CrewDocumentDetailsControl(string _Applicantid, string _Type, CrewDocumentControl _Parent)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _type = _Type;
            _parent = _Parent;
        }
        
        void DisplayList()
        {
            //_icrewdocument = new CrewDocumentRepository(DCLSystemConfiguration.Connection);
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            grdDoc.RowCount = 0;
            try
            {
                List<SP_C_GET_CREW_DOCUMENTResult> _crewdocuments = _icrewdocument.GetCrewDocuments(_applicantid, _type);
                foreach (SP_C_GET_CREW_DOCUMENTResult _records in _crewdocuments)
                {
                    int n = grdDoc.Rows.Add();
                    grdDoc.Rows[n].Cells[0].Value = _records.CrewDocID;
                    grdDoc.Rows[n].Cells[1].Value = "Open File";
                    grdDoc.Rows[n].Cells[2].Value = "View";
                    grdDoc.Rows[n].Cells[3].Value = _records.NameofDocument;
                    grdDoc.Rows[n].Cells[4].Value = _records.Number;
                    grdDoc.Rows[n].Cells[5].Value = _records.DATEISSUED;
                    grdDoc.Rows[n].Cells[6].Value = _records.DATEEXPIRED;
                    grdDoc.Rows[n].Cells[7].Value = _records.IssuedBy;

                    if (_records.DOCTYPE == ".xlsx" || _records.DOCTYPE == ".xls")
                    { grdDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Excel_48; }
                    else if (_records.DOCTYPE == ".docx" || _records.DOCTYPE == ".doc")
                    { grdDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Word_32; }
                    else if (_records.DOCTYPE == ".JPG" || _records.DOCTYPE == ".jpeg" || _records.DOCTYPE == ".JPEG" || _records.DOCTYPE == ".JPG" || _records.DOCTYPE == ".jpg" || _records.DOCTYPE == ".bmp" || _records.DOCTYPE == ".gif" || _records.DOCTYPE == ".png" || _records.DOCTYPE == "ico")
                    { grdDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.JPG; }
                    else if (_records.DOCTYPE == ".pdf")
                    { grdDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Reader_48; }
                    else if (_records.DOCTYPE == ".ppt" || _records.DOCTYPE == ".pptx")
                    { grdDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.PowerPoint_48; }
                    else
                    { grdDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Cancel; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrewDocumentDetailsControl_Load(object sender, EventArgs e)
        {
            try 
            {
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iCrewDocument _icrewdocument = new CMSFilesRepository.rCrewDocument();
            try
            {
                _id = int.Parse(grdDoc.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                if (e.ColumnIndex == 1)
                {
                    string _path = GlobalToolsControl.OpenScanDocument(_id, "D");

                    if (_path != "File not found") 
                    {
                        Impersonator iU = new Impersonator();
                        iU.Impersonate(FakeMe._domain, FakeMe._username, FakeMe._password);
                        
                        Process.Start(_path);

                        iU.Undo();
                    }
                    else { MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (e.ColumnIndex == 2)
                {
                    _parent.DisplayRecord(_icrewdocument.GetCrewDocument(_id, _applicantid));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
