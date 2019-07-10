using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InfractionTypeBLL
{

    public class BLLInfractionType_T
    : BusinessObjectBase
    {

        public enum InfractionType_TField
        {
            InfractionTypeID_int
            ,
            InfractionType_nvc
                ,
            InfractionGroupID_int
                ,
            InfractionSurveyGroupID_int
                ,
            PenaltyFee_dec
                ,
            Date_nvc
                ,
            Time_nvc
                ,
            Active_bit
                , UserName_nvc
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


        private String _InfractionType_nvc;
        public String InfractionType_nvc
        {
            get
            {
                return _InfractionType_nvc;
            }
            set
            {
                this._InfractionType_nvc = value;
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


        private Int32? _InfractionSurveyGroupID_int;
        public Int32? InfractionSurveyGroupID_int
        {
            get
            {
                return _InfractionSurveyGroupID_int;
            }
            set
            {
                this._InfractionSurveyGroupID_int = value;
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


        private String _Date_nvc;
        public String Date_nvc
        {
            get
            {
                return _Date_nvc;
            }
            set
            {
                this._Date_nvc = value;
            }
        }


        private String _Time_nvc;
        public String Time_nvc
        {
            get
            {
                return _Time_nvc;
            }
            set
            {
                this._Time_nvc = value;
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


        private String _UserName_nvc;
        public String UserName_nvc
        {
            get
            {
                return _UserName_nvc;
            }
            set
            {
                this._UserName_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionType_nvc", "نوع تخلف"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InfractionType_nvc", "نوع تخلف", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionGroupID_int", "گروه تخلف"));
          //  ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionType_nvc", "نوع تخلف", "InfractionType_T", "InfractionType_nvc"));
          //  ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionGroupID_int", "گروه تخلف", "InfractionType_T", "InfractionGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionGroupID_int", "گروه تخلف", "InfractionGroup_T", "InfractionGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionSurveyGroupID_int", "گروه بررسی تخلفات"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionSurveyGroupID_int", "FK Not Exits", "InfractionSurveyGroup_T", "InfractionSurveyGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("PenaltyFee_dec", "مبلغ جریمه", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر ثبت کننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر ثبت کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionTypeID_int", "شناسه  نوع تخلف", "InfractionType_T", "InfractionTypeID_int"));
        }
    }
}