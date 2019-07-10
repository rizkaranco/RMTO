using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL
{

    public partial class BLLCompanyMobile_T : BusinessObjectBase
    {

        public enum CompanyMobile_TField
        {
            CompanyMobileID_int
            ,
            CompanyID_int
                , MobileNumber_nvc
            ,FirstName_nvc
            ,LastName_nvc
            ,Active_bit
        }


        private Nullable<Int32> _CompanyMobileID_int;
        public Nullable<Int32> CompanyMobileID_int
        {
            get
            {
                return _CompanyMobileID_int;
            }
            set
            {
                this._CompanyMobileID_int = value;
            }
        }


        private Nullable<Int32> _CompanyID_int;
        public Nullable<Int32> CompanyID_int
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


        private String _MobileNumber_nvc;
        public String MobileNumber_nvc
        {
            get
            {
                return _MobileNumber_nvc;
            }
            set
            {
                this._MobileNumber_nvc = value;
            }
        }

        private String _FirstName_nvc;
        public String FirstName_nvc
        {
            get
            {
                return _FirstName_nvc;
            }
            set
            {
                this._FirstName_nvc = value;
            }
        }

        private String _LastName_nvc;
        public String LastName_nvc
        {
            get
            {
                return _LastName_nvc;
            }
            set
            {
                this._LastName_nvc = value;
            }
        }

        private bool? _Active_bit;
        public bool? Active_bit
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

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CompanyID_int", "شناسه شرکت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyID_int", "شناسه شرکت", "Company_T", "CompanyID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MobileNumber_nvc", "شماره موبایل"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MobileNumber_nvc", "شماره موبایل", 11));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FirstName_nvc", "نام", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LastName_nvc", "نام خانوادگی", 150));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCompanyMobileID_int", "شناسه موبایل شرکت", "CompanyMobile_T", "CompanyMobileID_int"));
            AddCustomValidationRules();
            ValidationRules.AddRules(new Hepsa.Core.Validation.RegularExpressionRule("MobileNumber_nvc", "شماره موبایل", "[0][9]\\d{9}"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCompanyMobile", "شماره موبایل", "CompanyMobile_T", "MobileNumber_nvc"));
        }
        partial void AddCustomValidationRules();
    }
}