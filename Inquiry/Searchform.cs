using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DCLGlobal.Classes;

using CAL.Model;

using CAL.MASTER.Interface;
using CAL.MASTER.Repository;
using CAL.TRANSACTION.Interface;
using CAL.TRANSACTION.Repository;
using CAL.Global;

namespace DCLGlobal.Inquiry
{
    public partial class Searchform : Form
    {
        public string _searchby;
        public int _principalid = 0;
        public string _transactiontype;

        //iAccount _iaccount = new CMSFilesRepository.rAccount();
        //iPrincipal _iprincipal = new CMSFilesRepository.rPrincipal();
        //iVessel _ivessel = new CMSFilesRepository.rVessel();
        //iPayrollPrincipal _iPayrollPrincipal = new CMSFilesRepository.rPayrollPrincipal();
        //iPOEAPrincipal _iPOEAPrincipal = new CMSFilesRepository.rPOEAPrincipal();
        //iPOEAPosition _iPOEAPosition = new CMSFilesRepository.rPOEAPosition();
        //iCountry _icountry = new CMSFilesRepository.rCountry();
        iEmployee _iemployee = new HURISRepository.rEmployee();
        //iJobDescription _ijobdescription = new CMSFilesRepository.rJobDescription();
        //iPOEACountry _iPOEACountry = new CMSFilesRepository.rPOEACountry();
        //iPosition _iposition = new CMSFilesRepository.rPosition();
        //iDocument _idocument = new CMSFilesRepository.rDocument();
        //iLicense _ilicense = new CMSFilesRepository.rLicense();
        //iTraining _itraining = new CMSFilesRepository.rTraining();
        //iTrainingCenter _itrainingcenter = new CMSFilesRepository.rTrainingCenter();
        //iPort _iport = new CMSFilesRepository.rPort();
        //iCrew _icrew = new CMSFilesRepository.rCrew();
        //iDisembarkReason _idisembarkReason = new CMSFilesRepository.rDisembarkReason();
        //iCheckUp _icheckup = new CMSFilesRepository.rCheckup();
        //iClinic _iclinic = new CMSFilesRepository.rClinic();
        //iSource _isource = new CMSFilesRepository.rSource();
        //iMunicipality _imunicipality = new CMSFilesRepository.rMunicipality();
        //iMasterPosition _imasterposition = new CMSFilesRepository.rMasterPosition();
        //iPropose _iproposed = new CMSTransactionRepository.rProposed();
        iUser _iuser = new GlobalFilesRepository.rUser();
        iDepartment _idepartment = new HURISRepository.rDepartment();
        iAreaLibrary _iarealib = new HURISRepository.rAreaLibrary();
        iSalary _isalary = new HURISRepository.rSalary();
        //iApplicant _iapplicant = new HURISRepository.rApplicant();
        //iSchool _ischool = new HURISRepository.rSchool();
        //iDegree _idegree = new HURISRepository.rDegree();
        iHRTraining _ihrtraining = new HURISRepository.rHRTraining();
        //iNatureOfBusiness _inatureofbusiness = new HURISRepository.rNatureOfBusiness();
        //iSkills _iskills = new HURISRepository.rSkills();
        //ABSTransactionInterface.iBillingHD _ibilling = new ABSTransactionRepository.rBillingHD();
        //iHardwareType _ihardwaretype = new PCISFilesRepository.rHardwareType();
        //iBrand _ibrand = new PCISFilesRepository.rBrand();
        //iSoftwareCategory _isoftwarecategory = new PCISFilesRepository.rSoftwareCategory();
        //iHardwareInfo _ihardwareinfo = new PCISFilesRepository.rHardwareInfo();
        //iSoftwareInfo _isoftwareinfo = new PCISFilesRepository.rSoftwareInfo();
        //iSystemAccess _iaccess = new PCISFilesRepository.rSystemAccess();
        //iPurpose _ipurpose = new GlobalFilesRepository.rPurpose();
        //iComputerInfo _icomputerinfo = new PCISFilesRepository.rComputerInfo();
        //iDeployedUnits _ideployedunits = new PCISFilesRepository.rDeployedUnits();
        //iLocation _ilocation = new PCISFilesRepository.rLocation();
        iSeparationReason _iseparationreason = new HURISRepository.rSeparationReason();
        iCompany _icompany = new HURISRepository.rCompany();
        iRoom _iroom = new GlobalFilesRepository.rRoom();

        private int _id;
        private string _code;
        private int _crewstatus;
        private string _fromwho = "";
        private USP_V_GET_PRESENT_EMPLOYEEResult _result = new USP_V_GET_PRESENT_EMPLOYEEResult();

        #region ReturnValue
        public ZIPS_ROOM ReturnSearchRoom
        {
            get { return _id == 0 ? null : _iroom.GetRoom(_id); }
        }
        //public VMS_PURPOSE ReturnSearchPurpose
        //{
        //    get { return _id == 0 ? null : _ipurpose.GetPurpose(_id); }
        //}
        public USP_V_GET_PRESENT_EMPLOYEEResult ReturnSearchPresentEmployee
        { 
            get { return _id == 0 ? null : _result; }
        }
        //public BILLING_HD ReturnSearchInvoice
        //{
        //    get { return _id == 0 ? null : _ibilling.GetBillingHD(_id); }
        //}
        public Sys_User ReturnSearchUser 
        {
            get { return _id == 0 ? null : _iuser.GetUser(_id); }     
        }
        //public Crew ReturnSearchCrewById
        //{
        //    get { return _id == 0 ? null : _icrew.GetCrew(_id, 0); }     
        //}
        //public Document ReturnSearchDocument
        //{
        //    get { return _id == 0 ? null : _idocument.GetDocument(_id); }     
        //}
        //public Clinic ReturnSearchClinic
        //{
        //    get { return _id == 0 ? null : _iclinic.GetClinic(_id); }
        //}
        //public CheckUp ReturnSearchCheckup
        //{
        //    get { return _id == 0 ? null : _icheckup.GetCheckUp(_id); }
        //}
        //public DisembarkReason ReturnSearchDisembarkReason 
        //{
        //    get { return _id == 0 ? null : _idisembarkReason.GetDisembarkReason(_id); }
        //}
        //public Crew ReturnSearchCrew
        //{
        //    get { return _id == 0 ? null : _icrew.GetCrew(_id); }
        //}
        //public Port ReturnSearchPort
        //{
        //    get { return _id == 0 ? null : _iport.GetPort(_id); }
        //}
        //public TrainingCenter ReturnSearchTrainingCenter 
        //{
        //    get { return _id == 0 ? null : _itrainingcenter.GetTrainingCenter(_id); }
        //}
        //public CAL.Model.License ReturnSearchLicense
        //{
        //    get { return _id == 0 ? null : _ilicense.GetLicense(_id); }
        //}
        //public Training ReturnSearchTraining 
        //{
        //    get { return _id == 0 ? null : _itraining.GetTraining(_id); }
        //}
        
        //public Account ReturnSearchAccount
        //{
        //    get { return _id == 0 ?  null : _iaccount.GetAccount(_id); }
        //}
        //public Principal ReturnSearchPrincipal
        //{
        //    get { return _id == 0 ? null : _iprincipal.GetPrincipal(_id); }
        //}
        //public Vessel ReturnSearchVessel
        //{
        //    get { return _id == 0 ? null: _ivessel.GetVessel(_id); }
        //}
        //public PrincipalSetUp ReturnSearchPayrollPrincipal 
        //{
        //    get { return _id == 0 ? null : _iPayrollPrincipal.GetPrincipal(_id, LoginUser.companycode); }
        //}
        //public POEAPrincipal ReturnSearchPOEAPrincipal
        //{
        //    get { return _id == 0 ? null : _iPOEAPrincipal.GetPrincipal(_id); }
        //}
        //public Country ReturnSearchCountry
        //{
        //    get { return _id == 0 ? null : _icountry.GetCountry(_id); }
        //}
        //public POEAPosition ReturnSearchPOEAPosition
        //{
        //    get { return _code == "" ? null : _iPOEAPosition.GetPosition(_code); }
        //}
        //public JobDescription ReturnSearchJobDescription            
        //{
        //    get { return _id == 0 ? null : _ijobdescription.GetJobDescription(_id); }
        //}
        //public POEACountry ReturnSearchPOEACountry
        //{
        //    get { return _code == "" ? null : _iPOEACountry.GetCountry(_code); }
        //}
        //public Position ReturnSearchPosition
        //{
        //    get { return _id == 0 ? null : _iposition.GetPosition(_id); }
        //}
        //public Municipality ReturnSearchMunicipality
        //{
        //    get { return _id == 0 ? null : _imunicipality.GetMunicipality(_id); }
        //}
        //public Source ReturnSearchSource
        //{
        //    get { return _id == 0 ? null : _isource.GetSource(_id); }
        //}
        //public Proposed ReturnSearchProposed
        //{
        //    get { return _id == 0 ? null : _iproposed.GetProposed(_id); }
        //}

        public Employee ReturnSearchEmployee
        {
            get { return _id == 0 ? null : _iemployee.GetEmployee(_id); }
        }

        public Department ReturnSearchDepartment
        {
            get {return _id == 0 ? null : _idepartment.GetDepartment(_id); }
        }

        public Salary ReturnSearchHURISPosition
        {
            get { return _id == 0 ? null : _isalary.GetSalary(_id); }
        }

        public UserDefineClass.HRIS.AreaLibrary ReturnSearchCity
        {
            get { return _id == 0 ? null : _iarealib.GetCity(_id); }
        }

        public AreaLibrary ReturnSearchProvince
        {
            get { return _id == 0 ? null : _iarealib.GetProvince(_id); }
        }

        //public Applicant ReturnSearcApplicant
        //{
        //    get { return _id == 0 ? null : _iapplicant.GetApplicant(_id); }
        //}

        //public School ReturnSearchSchool
        //{
        //    get { return _id == 0 ? null : _ischool.GetSchool(_id); }
        //}

        //public Degree ReturnSearchDegree
        //{
        //    get { return _id == 0 ? null : _idegree.GetDegree(_id); }
        //}

        public HRTraining ReturnSearchHRTraining
        {
            get { return _id == 0 ? null : _ihrtraining.GetTraining(_id); }
        }

        //public NatureOfBusiness ReturnSearchNatureofBusiness
        //{
        //    get { return _id == 0 ? null : _inatureofbusiness.GetNatureOfBusiness(_id); }
        //}

        //public Skill ReturnSearchSkill
        //{
        //    get { return _id == 0 ? null : _iskills.GetSkill(_id); }
        //}

        //public PC_Hardware_Type ReturnSearchHardwareType
        //{
        //    get { return _id == 0 ? null : _ihardwaretype.GetHardwareType(_id); }
        //}

        //public PC_Brand ReturnSearchBrand
        //{
        //    get { return _id == 0 ? null : _ibrand.GetBrand(_id); }
        //}

        //public PC_Software_Category ReturnSearchSoftwareCategory
        //{
        //    get { return _id == 0 ? null : _isoftwarecategory.GetSoftwareCategory(_id); }
        //}

        //public PC_Hardware_Det ReturnSearchHardwareInfo
        //{
        //    get { return _id == 0 ? null : _ihardwareinfo.GetHardwareInfo(_id); }
        //}

        //public PC_Software_Det ReturnSearchSoftwareInfo
        //{
        //    get { return _id == 0 ? null : _isoftwareinfo.GetSoftwareInfo(_id); }
        //}

        //public PC_System_Access ReturnSearchSystemAccess
        //{
        //    get { return _id == 0 ? null : _iaccess.GetSystemAccess(_id); }
        //}

        //public PC_HD ReturnSearchComputerInfo
        //{
        //    get { return _id == 0 ? null : _icomputerinfo.GetComputerInfo(_id); }
        //}

        //public PC_Deployed_Unit ReturnSearchDeployedUnits
        //{
        //    get { return _id == 0 ? null : _ideployedunits.GetDeployedUnit(_id); }
        //}

        //public PC_Location ReturnSearchLocation
        //{
        //    get { return _id == 0 ? null : _ilocation.GetLocation(_id); }
        //}

        public Separation_Reason ReturnSearchSeparationReason
        {
            get { return _id == 0 ? null : _iseparationreason.GetSeparationReason(_id); }
        }

        public Company ReturnSearchCompany
        {
            get { return _id == 0 ? null : _icompany.GetCompany(_id); }
        }

        #endregion

        public Searchform(Form _form)
        {
            InitializeComponent();
            this.MdiParent = _form;
        }

        public Searchform(string Fromwho)
        {
            InitializeComponent();
            _fromwho = Fromwho;
        }

        public Searchform()
        {
            InitializeComponent();
        }

        public Searchform(int _Crewstatus, int _Principalid)
        {
            InitializeComponent();
            _crewstatus = _Crewstatus;
            _principalid = _Principalid;
        }

        private void lsvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ConnectionControl _connectioncontrol = new ConnectionControl();

        void InitializeGrid()
        {
            //iTool _itool = new ToolRepository(DCLSystemConfiguration.Connection);
            try
            {
                //SP_C_GET_LISTVIEW_SIZEResult _lvsize = _itool.GetListViewSize(_searchby);
                SP_C_GET_LISTVIEW_SIZEResult _lvsize = GlobalToolsControl.Global.GetListViewSize(_searchby);
                this.Width = _lvsize.LEN1.Value;
                lsvList.Width = _lvsize.LEN1.Value;

                //    if (_searchby == searchby.CMS.ACCOUNTS)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Account Name", 300, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Company", 80, HorizontalAlignment.Center);
                //    }
                //    else if (_searchby == "PRESENT EMPLOYEE")
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Employee Name", 300, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("User Name", 0, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.GLOBAL.PURPOSED)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Purpose", 250, HorizontalAlignment.Center);
                //    }
                //    else if (_searchby == searchby.ABS.CREDIT_MEMO)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Credit No.", 100, HorizontalAlignment.Center);
                //        lsvList.Columns.Add("Amount", 100, HorizontalAlignment.Right);
                //    }
                //    else if (_searchby == searchby.ABS.INVOICE)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Invoice Type", 100, HorizontalAlignment.Center);
                //        lsvList.Columns.Add("Invoice No.", 100, HorizontalAlignment.Center);
                //        lsvList.Columns.Add("Amount", 100, HorizontalAlignment.Right);
                //    }
                if (_searchby == searchby.GLOBAL.USER)
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Username", 100, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Employee Name", 250, HorizontalAlignment.Left);
                }
                else if (_searchby == "ROOM")
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Room code", 100, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Room Description", 250, HorizontalAlignment.Left);
                }
                //    else if (_searchby == searchby.CMS.GENERATE_PROPOSED_CANDIDATE || _searchby == searchby.CMS.GENERATE_REHIRE_CANDIDATE || _searchby == searchby.CMS.GENERATE_REPRINT_CANDIDATE)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("apllicant id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Applicant name", 300, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("company", 0, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.CREW)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("applicantid", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("crewid", 0, HorizontalAlignment.Center);
                //        lsvList.Columns.Add("Crew Name", 350, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Status", 100, HorizontalAlignment.Left);

                //    }
                //    else if (_searchby == searchby.CMS.MASTER_POSITION)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Department", 150, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Position", 150, HorizontalAlignment.Center);
                //    }
                //    else if (_searchby == searchby.CMS.MUNICIPALITY)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Municipality", 300, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.IRECRUIT.SOURCE)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Source Name", 300, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.CLINIC)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Clinic Name", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Clinic Address", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.CHECK)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Check up", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Check up type", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.RELIEVER || _searchby == searchby.CMS.OFFSIGNER)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Crew Name", 250, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.DISEMBARK_REASON)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Disembark Reason", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.PORT)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Port Name", 180, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.PRINCIPAL)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Account Name", 180, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Principal Name", 350, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.VESSEL)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Principal Name", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Vessel", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.PAYROLL_PRINCIPAL)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Principal Name", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.POEA_POSITION)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Position Name", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.POEA_PRINCIPAL)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Principal Name", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.COUNTRY)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Country name", 280, HorizontalAlignment.Left);
                //    }
                else if (_searchby == searchby.CMS.EMPLOYEES)
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Employee name", 350, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Status", 80, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Company", 80, HorizontalAlignment.Left);
                }
                //    else if (_searchby == searchby.CMS.JOBDESCRIPTION)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Position Name", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.POEA_COUNTRY)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Country Name", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.POSITION)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Position Name", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Description", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.POEA_CURRENCY)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Currency", 200, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.DOCUMENT)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Document Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.LICENSE_LIST)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("License Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.TRAINING_LIST)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Training Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.CMS.TRAINING_CENTER)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Training Center Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.HURIS.DEPARTMENT)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Department Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.HURIS.CITY)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("City Name", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Province Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.HURIS.PROVINCE)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Province Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.HURIS.EMPLOYEE_POSITION)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Position Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.AIMS.APPLICANT)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Applicant Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.AIMS.SCHOOL)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("School Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.AIMS.DEGREE)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Degree Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.AIMS.TRAINING)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Training Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.AIMS.NATURE_OF_BUSINESS)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Nature of Business", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.AIMS.SKILLS)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Skills Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.HARDWARE_TYPE)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Hardware Type", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.BRAND)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Brand Name", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.SOFTWARE_CATEGORY)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Softcare Category", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.HARDWARE_INFO)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Hardware Type", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Brand", 150, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Model", 150, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Serial", 150, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.SOFTWARE_INFO)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Software Category", 200, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Software Name", 150, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Version", 150, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.SYSTEM_ACCESS)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("System Access", 400, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.COMPUTER_INFO)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Computer Name", 250, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("MAC Address", 150, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.DEPLOYED_UNITS)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Employee Name", 250, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Computer Name", 150, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("IP Address", 100, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Inventory Date", 120, HorizontalAlignment.Left);
                //    }
                //    else if (_searchby == searchby.PCIS.LOCATION)
                //    {
                //        lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                //        lsvList.Columns.Add("Location", 350, HorizontalAlignment.Left);
                //    }
                else if (_searchby == searchby.HURIS.SEPARATION_REASON)
                {
                    lsvList.Columns.Add("id", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Separation Reason", 250, HorizontalAlignment.Left);
                }
                else if (_searchby == searchby.HURIS.COMPANY)
                {
                    lsvList.Columns.Add("CompID", 0, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Company Name", 250, HorizontalAlignment.Left);
                    lsvList.Columns.Add("Company Code", 150, HorizontalAlignment.Left);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisplayList()
        {
            try 
            {
                if (txtkeyword.Text == "Enter Keyword here") { txtkeyword.Text = ""; }
                lsvList.Items.Clear();

                if (_searchby == searchby.CMS.ACCOUNTS)
                {
                    //_iaccount = new CMSFilesRepository.rAccount();
                    //List<Account> _accounts = _iaccount.GetAccounts(txtkeyword.Text, "Active");
                    //foreach (Account _list in _accounts)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.AccountID.ToString());
                    //    _item.SubItems.Add(_list.AcctDescription);
                    //    _item.SubItems.Add(_list.Company);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == "ROOM")
                {
                    _iroom = new GlobalFilesRepository.rRoom();
                    List<ZIPS_ROOM> _rooms = _iroom.GetRooms(txtkeyword.Text);
                    foreach (ZIPS_ROOM _list in _rooms)
                    {
                        ListViewItem _item = new ListViewItem(_list.id.ToString());
                        _item.SubItems.Add(_list.room_code);
                        _item.SubItems.Add(_list.Description);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == "PRESENT EMPLOYEE")
                {
                    iPurpose _ipurpose = new GlobalFilesRepository.rPurpose();
                    List<USP_V_GET_PRESENT_EMPLOYEEResult> _presents = _ipurpose.GetPresentEmployees("%" + txtkeyword.Text + "%");
                    foreach (USP_V_GET_PRESENT_EMPLOYEEResult _list in _presents)
                    {
                        ListViewItem _item = new ListViewItem(_list.Emp_id.ToString());
                        _item.SubItems.Add(_list.Employee_Name);
                        _item.SubItems.Add(_list.Domain_username);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.GLOBAL.PURPOSED)
                {
                    //_ipurpose = new GlobalFilesRepository.rPurpose();
                    //List<VMS_PURPOSE> _purposes = _ipurpose.GetPurposes(txtkeyword.Text);
                    //foreach (VMS_PURPOSE _list in _purposes)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    //    _item.SubItems.Add(_list.purpose_description);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.ABS.CREDIT_MEMO)
                {
                    //_ibilling = new ABSTransactionRepository.rBillingHD();
                    //List<BILLING_HD> _hds = _ibilling.GetBillingHDs(_transactiontype, _principalid, txtkeyword.Text);
                    //foreach (BILLING_HD _list in _hds)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    //    //_item.SubItems.Add(_list.BILLING_INVOICETYPE.invoice_type);
                    //    _item.SubItems.Add(_list.invoice_no);
                    //    _item.SubItems.Add(_list.grand_total.ToString());

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.ABS.INVOICE)
                {
                    //_ibilling = new ABSTransactionRepository.rBillingHD();
                    //List<BILLING_HD> _hds = _ibilling.GetBillingHDs(_transactiontype, _principalid, txtkeyword.Text);
                    //foreach (BILLING_HD _list in _hds)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    //    _item.SubItems.Add(_list.BILLING_INVOICETYPE.invoice_type);
                    //    _item.SubItems.Add(_list.invoice_no);
                    //    _item.SubItems.Add(_list.grand_total.ToString());

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.CREW)
                {
                    //_icrew = new CMSFilesRepository.rCrew();
                    //List<UserDefineClass.CMS.SearchCrew> _crews = _icrew.GetCrews(txtkeyword.Text);
                    //foreach (UserDefineClass.CMS.SearchCrew _list in _crews)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list._id.ToString());
                    //    _item.SubItems.Add(_list._applicantid);
                    //    _item.SubItems.Add(_list._crewid.ToString());
                    //    _item.SubItems.Add(_list._crewname);
                    //    if (_list._iscrew == 1) { _item.SubItems.Add("Crew"); }
                    //    else { _item.SubItems.Add("Applicant"); }

                    //    lsvList.Items.Add(_item);

                    //}
                }
                else if (_searchby == searchby.GLOBAL.USER)
                {
                    _iuser = new GlobalFilesRepository.rUser();
                    List<Sys_User> _users = _iuser.GetUsers(txtkeyword.Text, "ALL");
                    foreach (Sys_User _list in _users)
                    {
                        ListViewItem _item = new ListViewItem(_list.UserID.ToString());
                        _item.SubItems.Add(_list.UserName);
                        iEmployee _iemployee = new HURISRepository.rEmployee();
                        //Employee _employee = _iemployee.GetEmployee(int.Parse(_list.EmpID.ToString()));
                        UserDefineClass.HRIS.EmployeeSearchList _employee = _iemployee.SearchEmployee(Convert.ToInt16(_list.EmpID.ToString()));
                        if (_employee != null) { _item.SubItems.Add(_employee.LastName + ", " + _employee.FirstName + " " + _employee.MiddleName); }
                        else { _item.SubItems.Add(""); }

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.CMS.GENERATE_PROPOSED_CANDIDATE || _searchby == searchby.CMS.GENERATE_REHIRE_CANDIDATE || _searchby == searchby.CMS.GENERATE_REPRINT_CANDIDATE)
                {
                    //_icrew = new CMSFilesRepository.rCrew();
                    //List<Proposed> _proposeds = _icrew.GetCandidates(txtkeyword.Text, _searchby);
                    //foreach (Proposed _list in _proposeds)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.CandidatesID.ToString());
                    //    _item.SubItems.Add(_list.Crew.ApplicantID);
                    //    _item.SubItems.Add(_list.Crew.LastName + ", " + _list.Crew.FirstName + " " + _list.Crew.MiddleName);
                    //    _item.SubItems.Add(_list.Request.Principal.Account.Company);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.MASTER_POSITION)
                {
                    //_imasterposition = new CMSFilesRepository.rMasterPosition();
                    //List<MasterPosition> _masterpositions = _imasterposition.GetPositions(txtkeyword.Text, "active");
                    //foreach (MasterPosition _list in _masterpositions)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    //    _item.SubItems.Add(_list.Department);
                    //    _item.SubItems.Add(_list.Position);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.MUNICIPALITY)
                {
                    //_imunicipality = new CMSFilesRepository.rMunicipality();
                    //List<Municipality> _Municipalities = _imunicipality.GetMunicipalities(txtkeyword.Text);
                    //foreach (Municipality _list in _Municipalities)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.MunicipalityID.ToString());
                    //    _item.SubItems.Add(_list.MunicipalityName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.IRECRUIT.SOURCE)
                {
                    //_isource = new CMSFilesRepository.rSource();
                    //List<Source> _sources = _isource.GetSources(txtkeyword.Text, "active");
                    //foreach (Source _list in _sources)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.Source_ID.ToString());
                    //    _item.SubItems.Add(_list.Source_Name);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.CLINIC)
                {
                    //_iclinic = new CMSFilesRepository.rClinic();
                    //List<Clinic> _clinics = _iclinic.GetClinics(txtkeyword.Text, "Active");
                    //foreach (Clinic _list in _clinics)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.ID.ToString());
                    //    _item.SubItems.Add(_list.Clinic_name);
                    //    _item.SubItems.Add(_list.Clinic_address);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.CHECK)
                {
                    //_icheckup = new CMSFilesRepository.rCheckup();
                    //List<CheckUp> _checkups = _icheckup.GetCheckUps(txtkeyword.Text, "Äctive");
                    //foreach (CheckUp _list in _checkups)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.MEDCHECKID.ToString());
                    //    _item.SubItems.Add(_list.MEDCHECK_NAME);
                    //    _item.SubItems.Add(_list.CHECK_TYPE);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.DISEMBARK_REASON)
                {
                    //_idisembarkReason = new CMSFilesRepository.rDisembarkReason();
                    //List<DisembarkReason> _reasons = _idisembarkReason.GetDisembarkReasons(txtkeyword.Text, "Äctive");
                    //foreach (DisembarkReason _list in _reasons)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.id.ToString());
                    //    _item.SubItems.Add(_list.Reason);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.OFFSIGNER || _searchby == searchby.CMS.RELIEVER)
                {
                    ////_icrew = new CrewRepository(DCLSystemConfiguration.Connection);
                    //_icrew = new CMSFilesRepository.rCrew();
                    //List<Crew> _crews = _icrew.GetCrews(_principalid, _crewstatus);
                    //foreach (Crew _list in _crews)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.CrewId.ToString());
                    //    _item.SubItems.Add(_list.LastName + ", " + _list.FirstName + " " + _list.MiddleName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.PORT)
                {
                    //_iport = new CMSFilesRepository.rPort();
                    //List<Port> _ports = _iport.GetPorts(txtkeyword.Text, "Active");
                    //foreach (Port _list in _ports)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.PortID.ToString());
                    //    _item.SubItems.Add(_list.PortName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.PRINCIPAL)
                {
                    //_iprincipal = new CMSFilesRepository.rPrincipal();
                    //List<Principal> _principals = _iprincipal.GetPrincipals(txtkeyword.Text, "Active");
                    //foreach (Principal _list in _principals)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.PrincipalID.ToString());
                    //    _item.SubItems.Add(_list.Account.AcctDescription);
                    //    _item.SubItems.Add(_list.PrincipalDescription);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.VESSEL)
                {
                    //_ivessel = new CMSFilesRepository.rVessel();
                    //if (_fromwho == "PRINCIPAL FLEET")
                    //{
                    //    List<Vessel> _vessels = _ivessel.GetVessels(txtkeyword.Text, LoginUser.accountid);
                    //    foreach (Vessel _list in _vessels)
                    //    {
                    //        ListViewItem _item = new ListViewItem(_list.VesselID.ToString());
                    //        _item.SubItems.Add(_list.Principal.PrincipalDescription);
                    //        _item.SubItems.Add(_list.VesselDescription);

                    //        lsvList.Items.Add(_item);
                    //    }
                    //}
                    //else
                    //{
                    //    List<Vessel> _vessels = _ivessel.GetVessels(_principalid, txtkeyword.Text);
                    //    foreach (Vessel _list in _vessels)
                    //    {
                    //        ListViewItem _item = new ListViewItem(_list.VesselID.ToString());
                    //        _item.SubItems.Add(_list.Principal.PrincipalDescription);
                    //        _item.SubItems.Add(_list.VesselDescription);

                    //        lsvList.Items.Add(_item);
                    //    }
                    //}
                }
                else if (_searchby == searchby.CMS.PAYROLL_PRINCIPAL)
                {
                    //_iPayrollPrincipal = new CMSFilesRepository.rPayrollPrincipal();
                    //List<PrincipalSetUp> _PayrollPrincipals = _iPayrollPrincipal.GetPrincipals(txtkeyword.Text, LoginUser.companycode);
                    //foreach (PrincipalSetUp _list in _PayrollPrincipals)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.ID.ToString());
                    //    _item.SubItems.Add(_list.Pname);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.POEA_PRINCIPAL)
                {
                    //_iPOEAPrincipal = new CMSFilesRepository.rPOEAPrincipal();
                    //List<POEAPrincipal> _POEAPrincipal = _iPOEAPrincipal.Getprincipals(txtkeyword.Text);
                    //foreach (POEAPrincipal _list in _POEAPrincipal)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.PrincipalID.ToString());
                    //    _item.SubItems.Add(_list.PrincipalName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.COUNTRY)
                {
                    //_icountry = new CMSFilesRepository.rCountry();
                    //List<Country> _countries = _icountry.GetCountries(txtkeyword.Text, "INACTIVE");
                    //foreach (Country _list in _countries)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.ID.ToString());
                    //    _item.SubItems.Add(_list.CountryName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.EMPLOYEES)
                {
                    //_connectioncontrol.GetSystemConfiguration(appmodule.HURIS);
                    //_iemployee = new EmployeeRepository(DCLSystemConfiguration.Connection);
                    _iemployee = new HURISRepository.rEmployee();
                    string _empstatus = "";

                    List<UserDefineClass.HRIS.EmployeeSearchList> _employees = (from d in _iemployee.SearchEmployees(txtkeyword.Text, "All", "All") orderby d.LastName, d.FirstName select d).ToList();
                    foreach (UserDefineClass.HRIS.EmployeeSearchList _list in _employees)
                    {
                        ListViewItem _item = new ListViewItem(_list.EmpID.ToString());
                        _item.SubItems.Add(_list.LastName + ", " + _list.FirstName + " " + _list.MiddleName);
                        if (_list.EmpStatus == 0) { _empstatus = "Inactive"; } else { _empstatus = "Active"; }
                        _item.SubItems.Add(_empstatus);
                        _item.SubItems.Add(_list.CompanyCode);

                        lsvList.Items.Add(_item);
                    }
                    //_connectioncontrol.GetSystemConfiguration(appmodule.CMS);
                }
                else if (_searchby == searchby.CMS.POEA_POSITION)
                {
                    //_iPOEAPosition = new CMSFilesRepository.rPOEAPosition();
                    //List<POEAPosition> _positions = _iPOEAPosition.GetPositions(txtkeyword.Text);
                    //foreach (POEAPosition _list in _positions)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.Code);
                    //    _item.SubItems.Add(_list.PositionName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.JOBDESCRIPTION)
                {
                    //_ijobdescription = new CMSFilesRepository.rJobDescription();
                    //List<JobDescription> _jobdescriptions = _ijobdescription.GetJobDescriptions(txtkeyword.Text, "Active");
                    //foreach (JobDescription _list in _jobdescriptions)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.JD_ID.ToString());
                    //    _item.SubItems.Add(_list.POSITIONName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.POEA_CURRENCY)
                {
                    //_iPOEACountry = new CMSFilesRepository.rPOEACountry();
                    //List<POEACountry> _countries = _iPOEACountry.GetCurreny(txtkeyword.Text);
                    //foreach (POEACountry _list in _countries)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.CountryID.ToString());
                    //    _item.SubItems.Add(_list.Currency);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.POEA_COUNTRY)
                {
                    //_iPOEACountry = new CMSFilesRepository.rPOEACountry();
                    //List<POEACountry> _countries = _iPOEACountry.GetCountries(txtkeyword.Text);
                    //foreach (POEACountry _list in _countries)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.CountryID.ToString());
                    //    _item.SubItems.Add(_list.CountryName);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.POSITION)
                {
                    //_iposition = new CMSFilesRepository.rPosition();
                    //List<Position> _positions = new List<Position>();
                    //if (_principalid == 0) { _positions = _iposition.GetPositions(txtkeyword.Text); }
                    //else { _positions = _iposition.GetPositions(_principalid, txtkeyword.Text); }
                    //foreach (Position _list in _positions)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.PositionID.ToString());
                    //    _item.SubItems.Add(_list.PositionName);
                    //    _item.SubItems.Add(_list.Description);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.DOCUMENT)
                {
                    //_idocument = new CMSFilesRepository.rDocument();
                    //List<Document> _documents = _idocument.GetDocuments(txtkeyword.Text, "Active");
                    //foreach (Document _list in _documents)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.DocID.ToString());
                    //    _item.SubItems.Add(_list.NameofDocument);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.LICENSE_LIST)
                {
                    //_ilicense = new CMSFilesRepository.rLicense();
                    //List<CAL.Model.License> _licenses = _ilicense.GetLicenses(txtkeyword.Text, "Active");
                    //foreach (CAL.Model.License _list in _licenses)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.License_ID.ToString());
                    //    _item.SubItems.Add(_list.License_Name);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.TRAINING_LIST)
                {
                    //_itraining = new CMSFilesRepository.rTraining();
                    //List<Training> _trainings = _itraining.GetTrainings(txtkeyword.Text, "Active");
                    //foreach (Training _list in _trainings)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.Training_ID.ToString());
                    //    _item.SubItems.Add(_list.Training_Name);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.CMS.TRAINING_CENTER)
                {
                    //_itrainingcenter = new CMSFilesRepository.rTrainingCenter();
                    //List<TrainingCenter> _trainingCenters = _itrainingcenter.GetTrainingCenters(txtkeyword.Text, "Active");
                    //foreach (TrainingCenter _list in _trainingCenters)
                    //{
                    //    ListViewItem _item = new ListViewItem(_list.Institution_ID.ToString());
                    //    _item.SubItems.Add(_list.Institution_Name);

                    //    lsvList.Items.Add(_item);
                    //}
                }
                else if (_searchby == searchby.HURIS.DEPARTMENT)
                {
                    iDepartment _idepartment = new HURISRepository.rDepartment();
                    List<Department> _department = (from d in _idepartment.GetDepartments(txtkeyword.Text) orderby d.Dept_Name select d).ToList();
                    foreach (Department _list in _department)
                    {
                        ListViewItem _item = new ListViewItem(_list.Dept_ID.ToString());
                        _item.SubItems.Add(_list.Dept_Name);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.HURIS.CITY)
                {
                    iAreaLibrary _iarealibrary = new HURISRepository.rAreaLibrary();
                    List<UserDefineClass.HRIS.AreaLibrary> _city = _iarealibrary.GetCities(txtkeyword.Text);

                    foreach (UserDefineClass.HRIS.AreaLibrary _list in _city)
                    {
                        ListViewItem _item = new ListViewItem(_list.AreaID.ToString());
                        _item.SubItems.Add(_list.City);
                        _item.SubItems.Add(_list.Province);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.HURIS.PROVINCE)
                {
                    iAreaLibrary _iarealibrary = new HURISRepository.rAreaLibrary();
                    List<AreaLibrary> _province = _iarealibrary.GetProvinces(txtkeyword.Text);

                    foreach (AreaLibrary _list in _province)
                    {
                        ListViewItem _item = new ListViewItem(_list.AreaID.ToString());
                        _item.SubItems.Add(_list.AreaDescription);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.HURIS.EMPLOYEE_POSITION)
                {
                    iSalary _isalry = new HURISRepository.rSalary();
                    List<Salary> _salary = (from d in _isalary.GetSalaries(txtkeyword.Text) orderby d.Salary_Desc select d).ToList();

                    foreach (Salary _list in _salary)
                    {
                        ListViewItem _item = new ListViewItem(_list.Salary_ID.ToString());
                        _item.SubItems.Add(_list.Salary_Desc);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.AIMS.APPLICANT)
                {
                    iApplicant _iapplicant = new HURISRepository.rApplicant();
                    List<Applicant> _applicant = (from d in _iapplicant.GetApplicants(txtkeyword.Text) orderby d.Lastname, d.FirstName select d).ToList();

                    foreach (Applicant _list in _applicant)
                    {
                        ListViewItem _item = new ListViewItem(_list.ApplicantID.ToString());
                        _item.SubItems.Add(_list.Lastname + ", " + _list.FirstName + " " + _list.MiddleName);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.AIMS.SCHOOL)
                {
                    iSchool _ischool = new HURISRepository.rSchool();
                    List<School> _school = (from d in _ischool.GetSchools(txtkeyword.Text) orderby d.SchoolName select d).ToList();

                    foreach (School _list in _school)
                    {
                        ListViewItem _item = new ListViewItem(_list.SchoolID.ToString());
                        _item.SubItems.Add(_list.SchoolName);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.AIMS.DEGREE)
                {
                    iDegree _idegree = new HURISRepository.rDegree();
                    List<Degree> _degree = (from d in _idegree.GetDegrees(txtkeyword.Text) orderby d.DegreeName select d).ToList();

                    foreach (Degree _list in _degree)
                    {
                        ListViewItem _item = new ListViewItem(_list.DegreeID.ToString());
                        _item.SubItems.Add(_list.DegreeName);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.AIMS.TRAINING)
                {
                    iHRTraining _ihrtraining = new HURISRepository.rHRTraining();
                    List<HRTraining> _hrtraining = (from d in _ihrtraining.GetTrainings(txtkeyword.Text) orderby d.Training_name select d).ToList();

                    foreach (HRTraining _list in _hrtraining)
                    {
                        ListViewItem _item = new ListViewItem(_list.Training_id.ToString());
                        _item.SubItems.Add(_list.Training_name);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.AIMS.NATURE_OF_BUSINESS)
                {
                    iNatureOfBusiness _inatureofbusiness = new HURISRepository.rNatureOfBusiness();
                    List<NatureOfBusiness> _natureofbusiness = (from d in _inatureofbusiness.GetNatureOfBusinesses(txtkeyword.Text) orderby d.Description select d).ToList();

                    foreach (NatureOfBusiness _list in _natureofbusiness)
                    {
                        ListViewItem _item = new ListViewItem(_list.ID.ToString());
                        _item.SubItems.Add(_list.Description);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.AIMS.SKILLS)
                {
                    iSkills _iskills = new HURISRepository.rSkills();
                    List<Skill> _skills = (from d in _iskills.GetSkills(txtkeyword.Text) orderby d.SkillsName select d).ToList();

                    foreach (Skill _list in _skills)
                    {
                        ListViewItem _item = new ListViewItem(_list.SkillsID.ToString());
                        _item.SubItems.Add(_list.SkillsName);

                        lsvList.Items.Add(_item);
                    }
                }
                //else if (_searchby == searchby.PCIS.HARDWARE_TYPE)
                //{
                //    iHardwareType _ihardwaretype = new PCISFilesRepository.rHardwareType();
                //    List<PC_Hardware_Type> _hardwaretype = (from d in _ihardwaretype.GetHardwareTypes(txtkeyword.Text) where d.Status == true orderby d.Type_Name select d).ToList();

                //    foreach (PC_Hardware_Type _list in _hardwaretype)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.Type_Name);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.BRAND)
                //{
                //    iBrand _ibrand = new PCISFilesRepository.rBrand();
                //    List<PC_Brand> _brand = (from d in _ibrand.GetBrands(txtkeyword.Text) where d.Status == true orderby d.Brand_Name select d).ToList();

                //    foreach (PC_Brand _list in _brand)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.Brand_Name);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.SOFTWARE_CATEGORY)
                //{
                //    iSoftwareCategory _isoftwarecategory = new PCISFilesRepository.rSoftwareCategory();
                //    List<PC_Software_Category> _softwarecategory = (from d in _isoftwarecategory.GetSoftwareCategories(txtkeyword.Text) where d.Status == true orderby d.Category select d).ToList();

                //    foreach (PC_Software_Category _list in _softwarecategory)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.Category);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.HARDWARE_INFO)
                //{
                //    iHardwareInfo _ihardwareinfo = new PCISFilesRepository.rHardwareInfo();
                //    List<PC_Hardware_Det> _hardwareinfo = (from d in _ihardwareinfo.GetHardwareInfos(txtkeyword.Text) orderby d.PC_Hardware_Type.Type_Name, d.PC_Brand.Brand_Name select d).ToList();

                //    foreach (PC_Hardware_Det _list in _hardwareinfo)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.PC_Hardware_Type.Type_Name);
                //        _item.SubItems.Add(_list.PC_Brand.Brand_Name);
                //        _item.SubItems.Add(_list.Model);
                //        _item.SubItems.Add(_list.SerialNo);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.SOFTWARE_INFO)
                //{
                //    iSoftwareInfo _isoftwareinfo = new PCISFilesRepository.rSoftwareInfo();
                //    List<PC_Software_Det> _softwareinfo = (from d in _isoftwareinfo.GetSoftwareInfos(txtkeyword.Text) orderby d.PC_Software_Category.Category, d.Software_Name select d).ToList();

                //    foreach (PC_Software_Det _list in _softwareinfo)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.PC_Software_Category.Category);
                //        _item.SubItems.Add(_list.Software_Name);
                //        _item.SubItems.Add(_list.Version);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.SYSTEM_ACCESS)
                //{
                //    iSystemAccess _isystemaccess = new PCISFilesRepository.rSystemAccess();
                //    List<PC_System_Access> _systemaccess = (from d in _isystemaccess.GetSystemAccesses(txtkeyword.Text) where d.Status == true orderby d.Access_Name select d).ToList();

                //    foreach (PC_System_Access _list in _systemaccess)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.Access_Name);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.COMPUTER_INFO)
                //{
                //    iComputerInfo _icomputerinfo = new PCISFilesRepository.rComputerInfo();
                //    List<PC_HD> _computerinfo = (from d in _icomputerinfo.GetComputerInfos(txtkeyword.Text) orderby d.PC_Name select d).ToList();

                //    foreach (PC_HD _list in _computerinfo)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_list.PC_Name);
                //        _item.SubItems.Add(_list.MAC_Address);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.DEPLOYED_UNITS)
                //{
                //    iDeployedUnits _ideployedunits = new PCISFilesRepository.rDeployedUnits();
                //    List<PC_Deployed_Unit> _deployedunit = (from d in _ideployedunits.GetDeployedUnits(txtkeyword.Text) orderby d.PC_HD.PC_Name select d).ToList();
                //    iEmployee _iemployee = new HURISRepository.rEmployee();
                //    UserDefineClass.HRIS.EmployeeSearchList _employee = new UserDefineClass.HRIS.EmployeeSearchList();

                //    foreach (PC_Deployed_Unit _list in _deployedunit)
                //    {
                //        _employee = _iemployee.SearchEmployee(Convert.ToInt16(_list.Emp_Id.ToString()));

                //        ListViewItem _item = new ListViewItem(_list.Id.ToString());
                //        _item.SubItems.Add(_employee.LastName + ", " + _employee.FirstName + " " + _employee.MiddleName);
                //        _item.SubItems.Add(_list.PC_HD.PC_Name);
                //        _item.SubItems.Add(_list.PC_HD.MAC_Address);
                //        if (_list.PC_HD.Inventory_date != null)
                //        { _item.SubItems.Add(_list.PC_HD.Inventory_date.Value.ToShortDateString()); }
                //        else
                //        { _item.SubItems.Add(""); }

                //        lsvList.Items.Add(_item);
                //    }
                //}
                //else if (_searchby == searchby.PCIS.LOCATION)
                //{
                //    iLocation _ilocation = new PCISFilesRepository.rLocation();
                //    List<PC_Location> _location = (from d in _ilocation.GetLocations(txtkeyword.Text) where d.ACTIVE == true orderby d.LOCATION_ID select d).ToList();

                //    foreach (PC_Location _list in _location)
                //    {
                //        ListViewItem _item = new ListViewItem(_list.LOCATION_ID.ToString());
                //        _item.SubItems.Add(_list.NAME);

                //        lsvList.Items.Add(_item);
                //    }
                //}
                else if (_searchby == searchby.HURIS.SEPARATION_REASON)
                {
                    iSeparationReason _iseparationreason = new HURISRepository.rSeparationReason();
                    List<Separation_Reason> _separationreason = (from d in _iseparationreason.GetSeparationReasons(txtkeyword.Text) orderby d.Reason select d).ToList();

                    foreach (Separation_Reason _list in _separationreason)
                    {
                        ListViewItem _item = new ListViewItem(_list.ID.ToString());
                        _item.SubItems.Add(_list.Reason);

                        lsvList.Items.Add(_item);
                    }
                }
                else if (_searchby == searchby.HURIS.COMPANY)
                {
                    iCompany _icompany = new HURISRepository.rCompany();
                    List<Company> _company = (from d in _icompany.GetCompanies(txtkeyword.Text) orderby d.CompanyName select d).ToList();

                    foreach (Company _list in _company)
                    {
                        ListViewItem _item = new ListViewItem(_list.CompID.ToString());
                        _item.SubItems.Add(_list.CompanyName);
                        _item.SubItems.Add(_list.CompanyCode);

                        lsvList.Items.Add(_item);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (_searchby == searchby.CMS.ACCOUNTS) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.CREW) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.PRINCIPAL) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.VESSEL) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.PAYROLL_PRINCIPAL) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.POEA_PRINCIPAL) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.EMPLOYEES) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.POEA_POSITION) { _code = lsvList.SelectedItems[0].Text; }
                else if (_searchby == searchby.CMS.JOBDESCRIPTION) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.POEA_COUNTRY) { _code = lsvList.SelectedItems[0].Text; }
                else if (_searchby == searchby.CMS.POEA_CURRENCY) { _code = lsvList.SelectedItems[0].Text; }
                else if (_searchby == searchby.CMS.POSITION) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.DOCUMENT) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.COUNTRY) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.LICENSE_LIST) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.TRAINING_LIST) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.TRAINING_CENTER) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.PORT) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.RELIEVER || _searchby == searchby.CMS.OFFSIGNER) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.DISEMBARK_REASON) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.CHECK) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.CLINIC) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.IRECRUIT.SOURCE) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.MUNICIPALITY) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.MASTER_POSITION) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.CMS.GENERATE_PROPOSED_CANDIDATE || _searchby == searchby.CMS.GENERATE_REHIRE_CANDIDATE || _searchby == searchby.CMS.GENERATE_REPRINT_CANDIDATE) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.HURIS.DEPARTMENT) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.GLOBAL.USER) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.HURIS.EMPLOYEE_POSITION) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.HURIS.CITY) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.HURIS.PROVINCE) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.AIMS.APPLICANT) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.AIMS.SCHOOL) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.AIMS.DEGREE) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.AIMS.TRAINING) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.AIMS.NATURE_OF_BUSINESS) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.AIMS.SKILLS) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.ABS.INVOICE) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.ABS.CREDIT_MEMO) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.HARDWARE_TYPE) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.BRAND) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.SOFTWARE_CATEGORY) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.HARDWARE_INFO) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.SOFTWARE_INFO) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.SYSTEM_ACCESS) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.COMPUTER_INFO) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.DEPLOYED_UNITS) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.PCIS.LOCATION) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.GLOBAL.PURPOSED) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == "PRESENT EMPLOYEE")
                {
                    //_result = new USP_V_GET_PRESENT_EMPLOYEEResult();
                    _id = int.Parse(lsvList.SelectedItems[0].Text);
                    _result.Emp_id = int.Parse(lsvList.SelectedItems[0].Text);
                    _result.Employee_Name = lsvList.SelectedItems[0].SubItems[1].Text;
                    _result.Domain_username = lsvList.SelectedItems[0].SubItems[2].Text;
                }
                else if (_searchby == searchby.HURIS.SEPARATION_REASON) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == searchby.HURIS.COMPANY) { _id = int.Parse(lsvList.SelectedItems[0].Text); }
                else if (_searchby == "ROOM") { _id = int.Parse(lsvList.SelectedItems[0].Text); }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchform_Load(object sender, EventArgs e)
        {
            try 
            {
                InitializeGrid();
                DisplayList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtkeyword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtkeyword_GotFocus(object sender, EventArgs e)
        {
            if (txtkeyword.Text == "Enter Keyword here")
            {
                Color _color_focus = Color.FromArgb(255, 255, 136);
                txtkeyword.Text = "";
                txtkeyword.BackColor = _color_focus;
            }
        }

        protected void txtkeyword_LostFocus(object sender, EventArgs e)
        {
            if (txtkeyword.Text == "")
            {
                txtkeyword.Text = "Enter Keyword here";
                txtkeyword.BackColor = Color.White;
            }
        }

        private void txtkeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DisplayList();
                if (lsvList.Items.Count != 0) { lsvList.Focus(); }
            }
        }

        private void Searchform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) { txtkeyword.Focus(); }
        }

        private void lsvList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return) { lsvList_DoubleClick(sender, e); }              
        }
    }
}
