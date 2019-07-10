using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.DriverSpecificationBLL
{

    public class BLLDriverSpecification_T
    : BusinessObjectBase
    {

        public enum DriverSpecification_TField
        {
            DriverSpecificationID_int
            ,
            DriverID_bint
                ,
            DriverCardNumber_nvc
                ,
            FirstName_nvc
                ,
            LastName_nvc
                ,
            NationalCode_int
                ,
            licenceNumber_nvc
                ,
            CarExamination_bit
                ,
            LicenceEnd_nvc
                ,
            CarExaminationEndDate_nvc
                ,
            Insurance_bit
                ,
            InsuranceStartDate_nvc
                ,
            InsuranceEndDate_nvc
                ,
            ClassID_int
                ,
            HealthCard_bit
                ,
            HealthCardStartDate_nvc
                ,
            HealthCardEndDate_nvc
                ,
            DriverCardSharje_bit
                ,
            DriverCardSharjeStartDate_nvc
                ,
            DriverCardSharjeEndDate_nvc
                , StatisticCard_bit
            ,
            CarCardNumber_nvc
        }


        private Int32 _DriverSpecificationID_int;
        public Int32 DriverSpecificationID_int
        {
            get
            {
                return _DriverSpecificationID_int;
            }
            set
            {
                this._DriverSpecificationID_int = value;
            }
        }


        private Nullable<Int64> _DriverID_bint;
        public Nullable<Int64> DriverID_bint
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


        private Int64? _NationalCode_int;
        public Int64? NationalCode_int
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


        private bool _CarExamination_bit;
        public bool CarExamination_bit
        {
            get
            {
                return _CarExamination_bit;
            }
            set
            {
                this._CarExamination_bit = value;
            }
        }


        private String _LicenceEnd_nvc;
        public String LicenceEnd_nvc
        {
            get
            {
                return _LicenceEnd_nvc;
            }
            set
            {
                this._LicenceEnd_nvc = value;
            }
        }


        private String _CarExaminationEndDate_nvc;
        public String CarExaminationEndDate_nvc
        {
            get
            {
                return _CarExaminationEndDate_nvc;
            }
            set
            {
                this._CarExaminationEndDate_nvc = value;
            }
        }


        private bool _Insurance_bit;
        public bool Insurance_bit
        {
            get
            {
                return _Insurance_bit;
            }
            set
            {
                this._Insurance_bit = value;
            }
        }


        private String _InsuranceStartDate_nvc;
        public String InsuranceStartDate_nvc
        {
            get
            {
                return _InsuranceStartDate_nvc;
            }
            set
            {
                this._InsuranceStartDate_nvc = value;
            }
        }


        private String _InsuranceEndDate_nvc;
        public String InsuranceEndDate_nvc
        {
            get
            {
                return _InsuranceEndDate_nvc;
            }
            set
            {
                this._InsuranceEndDate_nvc = value;
            }
        }


        private Int32? _ClassID_int;
        public Int32? ClassID_int
        {
            get
            {
                return _ClassID_int;
            }
            set
            {
                this._ClassID_int = value;
            }
        }


        private bool _HealthCard_bit;
        public bool HealthCard_bit
        {
            get
            {
                return _HealthCard_bit;
            }
            set
            {
                this._HealthCard_bit = value;
            }
        }


        private String _HealthCardStartDate_nvc;
        public String HealthCardStartDate_nvc
        {
            get
            {
                return _HealthCardStartDate_nvc;
            }
            set
            {
                this._HealthCardStartDate_nvc = value;
            }
        }


        private String _HealthCardEndDate_nvc;
        public String HealthCardEndDate_nvc
        {
            get
            {
                return _HealthCardEndDate_nvc;
            }
            set
            {
                this._HealthCardEndDate_nvc = value;
            }
        }


        private bool _DriverCardSharje_bit;
        public bool DriverCardSharje_bit
        {
            get
            {
                return _DriverCardSharje_bit;
            }
            set
            {
                this._DriverCardSharje_bit = value;
            }
        }


        private String _DriverCardSharjeStartDate_nvc;
        public String DriverCardSharjeStartDate_nvc
        {
            get
            {
                return _DriverCardSharjeStartDate_nvc;
            }
            set
            {
                this._DriverCardSharjeStartDate_nvc = value;
            }
        }


        private String _DriverCardSharjeEndDate_nvc;
        public String DriverCardSharjeEndDate_nvc
        {
            get
            {
                return _DriverCardSharjeEndDate_nvc;
            }
            set
            {
                this._DriverCardSharjeEndDate_nvc = value;
            }
        }


        private bool _StatisticCard_bit;
        public bool StatisticCard_bit
        {
            get
            {
                return _StatisticCard_bit;
            }
            set
            {
                this._StatisticCard_bit = value;
            }
        }

        public string CarCardNumber_nvc { get; set; }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("DriverID_bint", "شناسه راننده", "Driver_T", "DriverID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardNumber_nvc", "شماره كارت راننده", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("FirstName_nvc", "نام"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FirstName_nvc", "نام", 50));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LastName_nvc", "نام خانوادگي"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LastName_nvc", "نام خانوادگي", 150));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("NationalCode_int", "كد ملي"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("NationalCode_int", "كد ملي", null, null, 0, 0));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("licenceNumber_nvc", "شماره گواهينامه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("licenceNumber_nvc", "شماره گواهينامه", 20));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CarExamination_bit", "معاينه كاميون"));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LicenceEnd_nvc", "تاريخ پایان گواهینامه"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("LicenceEnd_nvc", "تاريخ پایان گواهینامه", null, null));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LicenceEnd_nvc", "تاريخ پایان گواهینامه", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه", null, null));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه", 10));
//////            ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه"));
           //// ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Insurance_bit", "بيمه"));
////            ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("InsuranceEndDate_nvc", "تاريخ اتمام بيمه", null, null));
            ////////////////ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule());
          //  ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ClassID_int", "كلاس هاي آموزشي"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("ClassID_int", "كلاس هاي آموزشي", "Class_T", "ClassID_int"));
          //  ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("HealthCard_bit", "كارت سلامت"));
           
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت", null, null));
            ////////ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule());
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverCardSharje_bit", "شارژ كارت هوشمند"));
   
            //ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند", null, null));
            //////////ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند"));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverCardSharjeEndDate_nvc", "تاريخ اتمام شارژ كارت هوشمند"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardSharjeEndDate_nvc", "تاريخ اتمام شارژ كارت هوشمند", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("DriverCardSharjeEndDate_nvc", "تاريخ اتمام شارژ كارت هوشمند", null, null));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("StatisticCard_bit", "كارت آمار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StatisticCard_bit", "كارت آمار", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueDriverSpecificationID_int", "شناسه مشخصات راننده", "DriverSpecification_T", "DriverSpecificationID_int"));
        }
    }
}