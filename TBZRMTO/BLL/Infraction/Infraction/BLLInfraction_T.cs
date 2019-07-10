using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InfractionBLL
{

    public class BLLInfraction_T
    : BusinessObjectBase
    {

        public enum Infraction_TField
        {
            InfractionID_int
            ,
            InfractionTypeID_int
                ,
            DriverID_bint
                ,
            DriverFirstName_nvc
                ,
            DriverLastName_nvc
                ,
            DriverLicenceNumber_int
                ,
            DriverNationalCode_bint
                ,
            CarID_int
                ,
            NumberPlate_nvc
                ,
            SerialPlate_nvc
                ,
            PlateCityCode_nvc
                ,
            CompanyID_int
                ,
            CompanyCode_nvc
                ,
            CompanyName_nvc
                ,
            RegisterUserName_nvc
                ,
            RegisterDate_nvc
                ,
            RegisterTime_nvc
                ,
            RegiaterComment_nvc
                ,
            SolverUserName_nvc
                ,
            SolveDate_nvc
                ,
            SolveTime_nvc
                ,
            SolveComment_nvc
                ,
            PenaltyFee_dec
                , 
            OtherOffender_nvc
                ,
            InfractionGroupID_int
            ,
            Traffic_bit,
            TurnAccept_bit,
            TurnSave_bit,
            Exit_bit,
            CommentControl_nvc
        }


        private Int32 _InfractionID_int;
        public Int32 InfractionID_int
        {
            get
            {
                return _InfractionID_int;
            }
            set
            {
                this._InfractionID_int = value;
            }
        }


        private Int32? _InfractionTypeID_int;
        public Int32? InfractionTypeID_int
        {
            get
            {
                return _InfractionTypeID_int;
            }
            set
            {
                this._InfractionTypeID_int = value;
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


        private String _DriverFirstName_nvc;
        public String DriverFirstName_nvc
        {
            get
            {
                return _DriverFirstName_nvc;
            }
            set
            {
                this._DriverFirstName_nvc = value;
            }
        }


        private String _DriverLastName_nvc;
        public String DriverLastName_nvc
        {
            get
            {
                return _DriverLastName_nvc;
            }
            set
            {
                this._DriverLastName_nvc = value;
            }
        }


        private Nullable<Int64> _DriverLicenceNumber_int;
        public Nullable<Int64> DriverLicenceNumber_int
        {
            get
            {
                return _DriverLicenceNumber_int;
            }
            set
            {
                this._DriverLicenceNumber_int = value;
            }
        }


        private Nullable<Int64> _DriverNationalCode_bint;
        public Nullable<Int64> DriverNationalCode_bint
        {
            get
            {
                return _DriverNationalCode_bint;
            }
            set
            {
                this._DriverNationalCode_bint = value;
            }
        }


        private Nullable<Int32> _CarID_int;
        public Nullable<Int32> CarID_int
        {
            get
            {
                return _CarID_int;
            }
            set
            {
                this._CarID_int = value;
            }
        }


        private String _NumberPlate_nvc;
        public String NumberPlate_nvc
        {
            get
            {
                return _NumberPlate_nvc;
            }
            set
            {
                this._NumberPlate_nvc = value;
            }
        }


        private String _SerialPlate_nvc;
        public String SerialPlate_nvc
        {
            get
            {
                return _SerialPlate_nvc;
            }
            set
            {
                this._SerialPlate_nvc = value;
            }
        }


        private String _PlateCityCode_nvc;
        public String PlateCityCode_nvc
        {
            get
            {
                return _PlateCityCode_nvc;
            }
            set
            {
                this._PlateCityCode_nvc = value;
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


        private String _CompanyName_nvc;
        public String CompanyName_nvc
        {
            get
            {
                return _CompanyName_nvc;
            }
            set
            {
                this._CompanyName_nvc = value;
            }
        }


        private String _RegisterUserName_nvc;
        public String RegisterUserName_nvc
        {
            get
            {
                return _RegisterUserName_nvc;
            }
            set
            {
                this._RegisterUserName_nvc = value;
            }
        }


        private String _RegisterDate_nvc;
        public String RegisterDate_nvc
        {
            get
            {
                return _RegisterDate_nvc;
            }
            set
            {
                this._RegisterDate_nvc = value;
            }
        }


        private String _RegisterTime_nvc;
        public String RegisterTime_nvc
        {
            get
            {
                return _RegisterTime_nvc;
            }
            set
            {
                this._RegisterTime_nvc = value;
            }
        }


        private String _RegiaterComment_nvc;
        public String RegiaterComment_nvc
        {
            get
            {
                return _RegiaterComment_nvc;
            }
            set
            {
                this._RegiaterComment_nvc = value;
            }
        }


        private String _SolverUserName_nvc;
        public String SolverUserName_nvc
        {
            get
            {
                return _SolverUserName_nvc;
            }
            set
            {
                this._SolverUserName_nvc = value;
            }
        }


        private String _SolveDate_nvc;
        public String SolveDate_nvc
        {
            get
            {
                return _SolveDate_nvc;
            }
            set
            {
                this._SolveDate_nvc = value;
            }
        }


        private String _SolveTime_nvc;
        public String SolveTime_nvc
        {
            get
            {
                return _SolveTime_nvc;
            }
            set
            {
                this._SolveTime_nvc = value;
            }
        }


        private String _SolveComment_nvc;
        public String SolveComment_nvc
        {
            get
            {
                return _SolveComment_nvc;
            }
            set
            {
                this._SolveComment_nvc = value;
            }
        }


        private Nullable<Decimal> _PenaltyFee_dec;
        public Nullable<Decimal> PenaltyFee_dec
        {
            get
            {
                return _PenaltyFee_dec;
            }
            set
            {
                this._PenaltyFee_dec = value;
            }
        }


        private String _OtherOffender_nvc;
        public String OtherOffender_nvc
        {
            get
            {
                return _OtherOffender_nvc;
            }
            set
            {
                this._OtherOffender_nvc = value;
            }
        }

        private Int32? _InfractionGroupID_int;
        public Int32? InfractionGroupID_int
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

        private Boolean  _Traffic_bit;
        public Boolean Traffic_bit
        {
            get
            {
                return _Traffic_bit;
            }
            set
            {
                this._Traffic_bit = value;
            }
        }

        private Boolean _TurnAccept_bit;
        public Boolean TurnAccept_bit
        {
            get
            {
                return _TurnAccept_bit;
            }
            set
            {
                this._TurnAccept_bit = value;
            }
        }

        private Boolean _TurnSave_bit;
        public Boolean TurnSave_bit
        {
            get
            {
                return _TurnSave_bit;
            }
            set
            {
                this._TurnSave_bit = value;
            }
        }

        private Boolean _Exit_bit;
        public Boolean Exit_bit
        {
            get
            {
                return _Exit_bit;
            }
            set
            {
                this._Exit_bit = value;
            }
        }

        private string _CommentControl_nvc;
        public string CommentControl_nvc
        {
            get { return _CommentControl_nvc; }
            set { this._CommentControl_nvc = value; }
        }
        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionTypeID_int", " نوع تخلف"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionTypeID_int", " نوع تخلف", "InfractionType_T", "InfractionTypeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("DriverID_bint", " راننده", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverFirstName_nvc", "نام راننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverLastName_nvc", "نام خانوادگی راننده", 200));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("DriverLicenceNumber_int", "شماره گواهینامه", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("DriverNationalCode_bint", "کد ملی", null, null, 0, 0));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CarID_int", " خودرو", "Car_T", "CarID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("NumberPlate_nvc", "شماره پلاک", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SerialPlate_nvc", "سری پلاک", 3));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateCityCode_nvc", "کد شهر شماره گذاری", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyID_int", "شرکت", "Company_T", "CompanyID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CompanyCode_nvc", "کد شرکت", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CompanyName_nvc", " نام شرکت", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("RegisterUserName_nvc", " کاربر ثبت کننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RegisterUserName_nvc", " کاربر ثبت کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", " کاربر ثبت کننده", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("RegisterDate_nvc", "تاریخ ثبت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RegisterDate_nvc", "تاریخ ثبت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("RegisterTime_nvc", "ساعت ثبت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RegisterTime_nvc", "ساعت ثبت", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RegiaterComment_nvc", "توضیحات ثبت", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SolverUserName_nvc", " کاربر رفع کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", " کاربر رفع کننده", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SolveDate_nvc", "تاریخ رفع", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SolveTime_nvc", "ساعت رفع", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SolveComment_nvc", "توضیحات رفع", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("PenaltyFee_dec", "مبلغ جریمه", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("OtherOffender_nvc", "دیگر متخلفان", 100));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "دیگر متخلفان", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionID_int", "شناسه  تخلفات", "Infraction_T", "InfractionID_int"));
            //ValidationRules.AddRules(new validators.DuplicateInfractionRule("DuplicateInfractionRule", "تخلف تکراری"));
            
        }
    }
}