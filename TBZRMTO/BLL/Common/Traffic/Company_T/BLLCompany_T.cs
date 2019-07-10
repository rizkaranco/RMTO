using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CompanyBLL
{

    public class BLLCompany_T
    : BusinessObjectBase
    {

        public enum Company_TField
        {
            CompanyID_int
            ,
            CompanyCode_nvc
                ,
            Company_nvc
                ,
            DirectorName_nvc
                ,
            DirectorMobile_nvc
                ,
            Phone_nvc
                ,
            Fax_nvc
                ,
            Email_nvc
                ,
            WebAddress_nvc
                ,
            Active_bit
                ,
            InfractionGroupID_int
                ,
            Address_nvc
                ,
            CityID_int
                , 
            CityCode_nvc
                ,
            GroupID_int
        }


        private Int32? _CompanyID_int;
        public Int32? CompanyID_int
        {
            get
            {
                return _CompanyID_int;
            }
            set
            {
                this._CompanyID_int = value;
            }
        }


        private String _CompanyCode_nvc;
        public String CompanyCode_nvc
        {
            get
            {
                return _CompanyCode_nvc;
            }
            set
            {
                this._CompanyCode_nvc = value;
            }
        }


        private String _Company_nvc;
        public String Company_nvc
        {
            get
            {
                return _Company_nvc;
            }
            set
            {
                this._Company_nvc = value;
            }
        }


        private String _DirectorName_nvc;
        public String DirectorName_nvc
        {
            get
            {
                return _DirectorName_nvc;
            }
            set
            {
                this._DirectorName_nvc = value;
            }
        }


        private String _DirectorMobile_nvc;
        public String DirectorMobile_nvc
        {
            get
            {
                return _DirectorMobile_nvc;
            }
            set
            {
                this._DirectorMobile_nvc = value;
            }
        }


        private String _Phone_nvc;
        public String Phone_nvc
        {
            get
            {
                return _Phone_nvc;
            }
            set
            {
                this._Phone_nvc = value;
            }
        }


        private String _Fax_nvc;
        public String Fax_nvc
        {
            get
            {
                return _Fax_nvc;
            }
            set
            {
                this._Fax_nvc = value;
            }
        }


        private String _Email_nvc;
        public String Email_nvc
        {
            get
            {
                return _Email_nvc;
            }
            set
            {
                this._Email_nvc = value;
            }
        }


        private String _WebAddress_nvc;
        public String WebAddress_nvc
        {
            get
            {
                return _WebAddress_nvc;
            }
            set
            {
                this._WebAddress_nvc = value;
            }
        }


        private bool _Active_bit;
        public bool Active_bit
        {
            get
            {
                return _Active_bit;
            }
            set
            {
                this._Active_bit = value;
            }
        }


        private Nullable<Int32> _InfractionGroupID_int;
        public Nullable<Int32> InfractionGroupID_int
        {
            get
            {
                return _InfractionGroupID_int;
            }
            set
            {
                this._InfractionGroupID_int = value;
            }
        }


        private String _Address_nvc;
        public String Address_nvc
        {
            get
            {
                return _Address_nvc;
            }
            set
            {
                this._Address_nvc = value;
            }
        }


        private Nullable<Int32> _CityID_int;
        public Nullable<Int32> CityID_int
        {
            get
            {
                return _CityID_int;
            }
            set
            {
                this._CityID_int = value;
            }
        }


        private String _CityCode_nvc;
        public String CityCode_nvc
        {
            get
            {
                return _CityCode_nvc;
            }
            set
            {
                this._CityCode_nvc = value;
            }
        }

        private Int32? _GroupID_int;
        public Int32? GroupID_int
        {
            get
            {
                return _GroupID_int;
            }
            set
            {
                this._GroupID_int = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyID_int", "شناسه شرکت/موسسه", "Company_T", "CompanyID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CompanyCode_nvc", "کد شرکت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CompanyCode_nvc", "کد شرکت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Company_nvc", "نام شرکت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Company_nvc", "نام شرکت", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DirectorName_nvc", "نام مدیر عامل"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DirectorName_nvc", "نام مدیر عامل", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DirectorMobile_nvc", "موبایل مدیر عامل", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Phone_nvc", "تلفن"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Phone_nvc", "تلفن", 20));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Fax_nvc", "فکس", 30));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Email_nvc", "پست الکترونیکی", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("WebAddress_nvc", "سایت", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionGroupID_int", "گروه تخلف", "InfractionGroup_T", "InfractionGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Address_nvc", "آدرس", 1000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int", "شهر", "City_T", "CityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CityCode_nvc", "کد شهر", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCompanyID_int", "شناسه شرکت/موسسه", "Company_T", "CompanyID_int"));
        }
    }
}