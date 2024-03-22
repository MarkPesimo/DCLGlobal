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

//using CAL.CMS.Interface.Tool;
//using CAL.CMS.Repository.Tool;

namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewMedicalDetailsControl : UserControl
    {
        private string _applicantid;
        private string _type;
        private int _id;

        //iFiles _ifiles = new FilesRepository(DCLSystemConfiguration.Connection);
        //iCrewMedical _icrewmedical = new CrewMedicalRepository(DCLSystemConfiguration.Connection);
        //iScanDocument _iscandocument = new ScanDocumentRepository(DCLSystemConfiguration.Connection);
        CrewMedicalControl _parent;

        public CrewMedicalDetailsControl(string _Applicantid, string _Type, CrewMedicalControl _Parent)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _type = _Type;
            _parent = _Parent;
        }

        void DisplayList()
        {
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            grdMed.RowCount = 0;
            try
            {
                List<SP_C_GET_CREW_MEDICALResult> _crewmedicals = _icrewmedical.GetCrewMedicals(_applicantid, _type);
                foreach (SP_C_GET_CREW_MEDICALResult _records in _crewmedicals)
                {
                    int n = grdMed.Rows.Add();
                    grdMed.Rows[n].Cells[0].Value = _records.ID;
                    grdMed.Rows[n].Cells[1].Value = "Open File";
                    grdMed.Rows[n].Cells[2].Value = "View";
                    grdMed.Rows[n].Cells[3].Value = _records.MEDCHECK_NAME;
                    grdMed.Rows[n].Cells[4].Value = _records.DATEISSUED == null ? "" : _records.DATEISSUED.Value.ToShortDateString();
                    grdMed.Rows[n].Cells[5].Value = _records.DATEEXPIRED == null ? "" : _records.DATEEXPIRED.Value.ToShortDateString();

                    if (_records.DOCTYPE2 == ".xlsx" || _records.DOCTYPE2 == ".xls")
                    { grdMed.Rows[n].Cells[6].Value = DCLGlobal.Properties.Resources.Excel_48; }
                    else if (_records.DOCTYPE2 == ".docx" || _records.DOCTYPE2 == ".doc")
                    { grdMed.Rows[n].Cells[6].Value = DCLGlobal.Properties.Resources.Word_32; }
                    else if (_records.DOCTYPE2 == ".JPG" || _records.DOCTYPE2 == ".jpeg" || _records.DOCTYPE2 == ".JPEG" || _records.DOCTYPE2 == ".JPG" || _records.DOCTYPE2 == ".jpg" || _records.DOCTYPE2 == ".bmp" || _records.DOCTYPE2 == ".gif" || _records.DOCTYPE2 == ".png" || _records.DOCTYPE2 == "ico")
                    { grdMed.Rows[n].Cells[6].Value = DCLGlobal.Properties.Resources.JPG; }
                    else if (_records.DOCTYPE2 == ".pdf")
                    { grdMed.Rows[n].Cells[6].Value = DCLGlobal.Properties.Resources.Reader_48; }
                    else if (_records.DOCTYPE2 == ".ppt" || _records.DOCTYPE2 == ".pptx")
                    { grdMed.Rows[n].Cells[6].Value = DCLGlobal.Properties.Resources.PowerPoint_48; }
                    else
                    { grdMed.Rows[n].Cells[6].Value = DCLGlobal.Properties.Resources.Cancel; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrewMedicalDetailsControl_Load(object sender, EventArgs e)
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

        private void grdMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iCrewMedical _icrewmedical = new CMSFilesRepository.rCrewMedical();
            //iTool _itool = new ToolRepository(DCLSystemConfiguration.Connection);
            try
            {
                _id = int.Parse(grdMed.Rows[e.RowIndex].Cells[0].Value.ToString());                

                if (e.ColumnIndex == 1)
                {
                    //string _path = _itool.OpenScanDocument(_id, "MM");
                    string _path = GlobalToolsControl.OpenScanDocument(_id, "MM");

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
                    _parent.DisplayRecord(_icrewmedical.GetCrewMedical(_id, _applicantid));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
