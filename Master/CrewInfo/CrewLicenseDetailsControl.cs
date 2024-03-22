using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

using DCLGlobal.Inquiry;
using DCLGlobal.Classes;
using CAL.Global;
using CAL.Model;


using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using System.Diagnostics;


namespace DCLGlobal.Master.CrewInfo
{
    public partial class CrewLicenseDetailsControl : UserControl
    {
        string _docdept = "L";
        private string _applicantid;
        private string _type;
        private int _id;

        CrewLicenseControl _parent;

        public CrewLicenseDetailsControl(string _Applicantid, string _Type, CrewLicenseControl Parent)
        {
            InitializeComponent();
            _applicantid = _Applicantid;
            _type = _Type;
            _parent = Parent;
        }

        private void CrewLicenseDetailsControl_Load(object sender, EventArgs e)
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

        void DisplayList()
        {
            grdValidDoc.RowCount = 0;
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            try
            {
                List<UserDefineClass.CMS.LicenseList> _crewlicenses = _icrewlicense.GetCrewLicenses(_applicantid, _docdept, _type);
                foreach (UserDefineClass.CMS.LicenseList _list in _crewlicenses)
                {
                    int n = grdValidDoc.Rows.Add();
                    grdValidDoc.Rows[n].Cells[0].Value = _list.Id;
                    grdValidDoc.Rows[n].Cells[1].Value = "Open File";
                    grdValidDoc.Rows[n].Cells[2].Value = "View";
                    grdValidDoc.Rows[n].Cells[3].Value = _list.LicenseName;
                    grdValidDoc.Rows[n].Cells[4].Value = _list.Number;

                    if (_list.DateIssued != null) { grdValidDoc.Rows[n].Cells[5].Value = _list.DateIssued.Value.ToShortDateString(); }
                    else { grdValidDoc.Rows[n].Cells[5].Value = ""; }
                    if (_list.DateExpired != null) { grdValidDoc.Rows[n].Cells[6].Value = _list.DateExpired.Value.ToShortDateString(); }
                    else { grdValidDoc.Rows[n].Cells[6].Value = ""; }
                    grdValidDoc.Rows[n].Cells[7].Value = _list.Regulation;

                    if (_list.Doctype == ".xlsx" || _list.Doctype == ".xls")
                    { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Excel_48; }
                    else if (_list.Doctype == ".docx" || _list.Doctype == ".doc")
                    { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Word_32; }
                    else if (_list.Doctype == ".JPG" || _list.Doctype == ".jpeg" || _list.Doctype == ".JPEG" || _list.Doctype == ".JPG" || _list.Doctype == ".jpg" || _list.Doctype == ".bmp" || _list.Doctype == ".gif" || _list.Doctype == ".png" || _list.Doctype == "ico")
                    { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.JPG; }
                    else if (_list.Doctype == ".pdf")
                    { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Reader_48; }
                    else if (_list.Doctype == ".ppt" || _list.Doctype == ".pptx")
                    { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.PowerPoint_48; }
                    else
                    { grdValidDoc.Rows[n].Cells[8].Value = DCLGlobal.Properties.Resources.Cancel; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdValidDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iCrewLicense _icrewlicense = new CMSFilesRepository.rCrewLicense();
            try
            {
                _id = int.Parse(grdValidDoc.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (e.ColumnIndex == 1)
                {
                    string _path = GlobalToolsControl.OpenScanDocument(_id, _docdept);

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
                    _parent.DisplayRecord(_icrewlicense.GetCrewLicense(_id, _applicantid));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
