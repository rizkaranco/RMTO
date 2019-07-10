using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.DriverBLL
{

    public class BLLDriver_T
    : BusinessObjectBase
    {

        public enum Driver_TField
        {
            DriverID_bint
            ,
            DriverCardDate_nvc
                ,
            DriverCardNumber_nvc
                ,
            DriverType_nvc
                ,
            FirstName_nvc
                ,
            LastName_nvc
                ,
            InsuranceNumber_nvc
                ,
            CityID_int
                ,
            CityCode_nvc
                ,
            licenceNumber_nvc
                ,
            LicenceCityID_int
                ,
            LicenceType_nvc
                ,
            LiceniceDate_nvc
                ,
            ActivityScope_nvc
                ,
            NationalCode_int
                ,
            Active_bit
                ,
            InfractionGroupID_int
                ,
            DocNumber_nvc
                ,
            InsertDate_nvc
                ,
            UpdateDate_nvc
                , 
            Deleted_bit
                ,
            Mobile_nvc
        }


        private Int64 _DriverID_bint;
        public Int64 DriverID_bint
        {
            get
            {
                return _DriverID_bint;
            }
            set
            {
                this._DriverID_bint = value;
            }
        }


        private String _DriverCardDate_nvc;
        public String DriverCardDate_nvc
        {
            get
            {
                return _DriverCardDate_nvc;
            }
            set
            {
                this._DriverCardDate_nvc = value;
            }
        }


        private String _DriverCardNumber_nvc;
        public String DriverCardNumber_nvc
        {
            get
            {
                return _DriverCardNumber_nvc;
            }
            set
            {
                this._DriverCardNumber_nvc = value;
            }
        }


        private String _DriverType_nvc;
        public String DriverType_nvc
        {
            get
            {
                return _DriverType_nvc;
            }
            set
            {
                this._DriverType_nvc = value;
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


        private String _InsuranceNumber_nvc;
        public String InsuranceNumber_nvc
        {
            get
            {
                return _InsuranceNumber_nvc;
            }
            set
            {
                this._InsuranceNumber_nvc = value;
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


        private String _licenceNumber_nvc;
        public String licenceNumber_nvc
        {
            get
            {
                return _licenceNumber_nvc;
            }
            set
            {
                this._licenceNumber_nvc = value;
            }
        }


        private Nullable<Int32> _LicenceCityID_int;
        public Nullable<Int32> LicenceCityID_int
        {
            get
            {
                return _LicenceCityID_int;
            }
            set
            {
                this._LicenceCityID_int = value;
            }
        }


        private String _LicenceType_nvc;
        public String LicenceType_nvc
        {
            get
            {
                return _LicenceType_nvc;
            }
            set
            {
                this._LicenceType_nvc = value;
            }
        }


        private String _LiceniceDate_nvc;
        public String LiceniceDate_nvc
        {
            get
            {
                return _LiceniceDate_nvc;
            }
            set
            {
                this._LiceniceDate_nvc = value;
            }
        }


        private String _ActivityScope_nvc;
        public String ActivityScope_nvc
        {
            get
            {
                return _ActivityScope_nvc;
            }
            set
            {
                this._ActivityScope_nvc = value;
            }
        }


        private Nullable<Int64> _NationalCode_int;
        public Nullable<Int64> NationalCode_int
        {
            get
            {
                return _NationalCode_int;
            }
            set
            {
                this._NationalCode_int = value;
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


        private String _DocNumber_nvc;
        public String DocNumber_nvc
        {
            get
            {
                return _DocNumber_nvc;
            }
            set
            {
                this._DocNumber_nvc = value;
            }
        }


        private String _InsertDate_nvc;
        public String InsertDate_nvc
        {
            get
            {
                return _InsertDate_nvc;
            }
            set
            {
                this._InsertDate_nvc = value;
            }
        }


        private String _UpdateDate_nvc;
        public String UpdateDate_nvc
        {
            get
            {
                return _UpdateDate_nvc;
            }
            set
            {
                this._UpdateDate_nvc = value;
            }
        }


        private bool _Deleted_bit;
        public bool Deleted_bit
        {
            get
            {
                return _Deleted_bit;
            }
            set
            {
                this._Deleted_bit = value;
            }
        }

        private String _Mobile_nvc;

        public String Mobile_nvc
        {
            get { return _Mobile_nvc; }
            set { _Mobile_nvc = value; }
        }
        

        public override void AddValidationRules()
        {
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverCardDate_nvc", "تاریخ صدور کارت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardDate_nvc", "تاریخ صدور کارت", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverCardNumber_nvc", "شماره کارت راننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardNumber_nvc", "شماره کارت راننده", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverType_nvc", "نوع راننده", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("FirstName_nvc", "نام"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FirstName_nvc", "نام", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LastName_nvc", "نام خانوادگی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LastName_nvc", "نام خانوادگی", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InsuranceNumber_nvc", "شماره بیمه", 15));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int", "شهر محل سکونت", "City_T", "CityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CityCode_nvc", "کد شهر محل سکونت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("licenceNumber_nvc", "شماره گواهینامه", 20));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int", "محل صدور گواهینامه", "City_T", "CityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LicenceType_nvc", "نوع گواهینامه", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LiceniceDate_nvc", "تاریخ صدور گواهینامه", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ActivityScope_nvc", "حوزه فعالیت", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("NationalCode_int", "کد ملی", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionGroupID_int", "گروه تخلف", "InfractionGroup_T", "InfractionGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DocNumber_nvc", "شماره پرونده", 20));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InsertDate_nvc", "تاريخ ورود اطلاعات", 12));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UpdateDate_nvc", "تاريخ تغيير اطلاعات", 12));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Deleted_bit", "حذف شده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueDriverID_bint", "شناسه راننده", "Driver_T", "DriverID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RegularExpressionRule("Mobile_nvc", "شماره موبایل", "[0][9]\\d{9}"));

        }
    }
}