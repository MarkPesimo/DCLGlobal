using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Xml;

using CAL.Model;
using CAL.Global;
using DCLGlobal.Classes;

namespace DCLGlobal.Classes
{
    public class VersionControl
    {
        enum AppType
        {
            Test,
            Development,
            Production
        }
        public string _applicationtitle;

        public string GetAppName(string _module)
        {
            if (_module == appmodule.CMS) { _applicationtitle = "Crew Management System"; }
            else if (_module == appmodule.IRECRUIT) { _applicationtitle = "iRecruit"; }
            else if (_module == appmodule.IHOPS) { _applicationtitle = "InHouse Payroll System"; }
            else if (_module == appmodule.HURIS) { _applicationtitle = "Human Resource Information System"; }
            else if (_module == appmodule.DCLAPS) { _applicationtitle = "DCL Automated Payroll System"; }
            else if (_module == appmodule.TAMS) { _applicationtitle = "Time and Attendance Management System"; }
            else if (_module == appmodule.ABS) { _applicationtitle = "Automated Billing System"; }
            else if (_module == appmodule.AIMS) { _applicationtitle = "Applicant Information Management System"; }
            else if (_module == appmodule.PCIS) { _applicationtitle = "Personal Computer Information System"; }
            else if (_module == appmodule.ILOAN) { _applicationtitle = "WNS Loan System"; }

            return _applicationtitle;
        }

        public string GetAppVersion(string _module)
        {
            try
            {
                XmlDocument m_xmld = new XmlDocument();

                if (_module == appmodule.CMS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "CMS.exe.manifest"); }
                else if (_module == appmodule.IRECRUIT) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "iRECRUIT.exe.manifest"); }
                else if (_module == appmodule.IHOPS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "IHOPS.exe.manifest"); }
                else if (_module == appmodule.HURIS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "HURIS.exe.manifest"); }
                else if (_module == appmodule.DCLAPS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "DCLAPS.exe.manifest"); }
                else if (_module == appmodule.TAMS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "TAMS.exe.manifest"); }
                else if (_module == appmodule.ABS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "ABS.exe.manifest"); }
                else if (_module == appmodule.AIMS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "AIMS.vshost.exe.manifest"); }
                else if (_module == appmodule.PCIS) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "PCIS.vshost.exe.manifest"); }
                else if (_module == appmodule.ILOAN) { m_xmld.Load(AppDomain.CurrentDomain.BaseDirectory + "WORNNSAVE.vshost.exe.manifest"); }

                return m_xmld.ChildNodes.Item(1).ChildNodes.Item(0).Attributes.GetNamedItem("version").Value;
            }
            catch (Exception ex)
            {
                return "";
            }
        }


    }
}
