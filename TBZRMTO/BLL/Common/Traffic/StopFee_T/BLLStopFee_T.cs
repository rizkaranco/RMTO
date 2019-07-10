using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.StopFeeBLL
{

    public class BLLStopFee_T
    : BusinessObjectBase
    {

        public enum StopFee_TField
        {
            StopFeeID_int
            ,
            AllowedHoure_int
                ,
            Fee_dec
                ,
            ExtraHour_int
                ,
            ExtraHourFee_dec
                ,
            TrafficTypeID_int
                ,
            LaderPivotGroupID_int
                ,
            StartDate_nvc
                ,
            EndDate_nvc
                ,
            Date_nvc
                ,
            Time_nvc
                ,
            UserName_nvc
                ,
            WithLadeExtraHourFee_dec
                , ServicesID_int, 
  Tax_bit,
            TurnNotLadBillExtraHourFee_dec,
            TurnNotLadBillExtraHour_int
        }


        private Int32 _StopFeeID_int;
        public Int32 StopFeeID_int
        {
            get
            {
                return _StopFeeID_int;
            }
            set
            {
                this._StopFeeID_int = value;
            }
        }


        private Int32 _AllowedHoure_int;
        public Int32 AllowedHoure_int
        {
            get
            {
                return _AllowedHoure_int;
            }
            set
            {
                this._AllowedHoure_int = value;
            }
        }


        private Decimal _Fee_dec;
        public Decimal Fee_dec
        {
            get
            {
                return _Fee_dec;
            }
            set
            {
                this._Fee_dec = value;
            }
        }


        private Int32 _ExtraHour_int;
        public Int32 ExtraHour_int
        {
            get
            {
                return _ExtraHour_int;
            }
            set
            {
                this._ExtraHour_int = value;
            }
        }


        private Nullable<Decimal> _ExtraHourFee_dec;
        public Nullable<Decimal> ExtraHourFee_dec
        {
            get
            {
                return _ExtraHourFee_dec;
            }
            set
            {
                this._ExtraHourFee_dec = value;
            }
        }


        private Nullable<Int32> _TrafficTypeID_int;
        public Nullable<Int32> TrafficTypeID_int
        {
            get
            {
                return _TrafficTypeID_int;
            }
            set
            {
                this._TrafficTypeID_int = value;
            }
        }


        private Nullable<Int32> _LaderPivotGroupID_int;
        public Nullable<Int32> LaderPivotGroupID_int
        {
            get
            {
                return _LaderPivotGroupID_int;
            }
            set
            {
                this._LaderPivotGroupID_int = value;
            }
        }


        private String _StartDate_nvc;
        public String StartDate_nvc
        {
            get
            {
                return _StartDate_nvc;
            }
            set
            {
                this._StartDate_nvc = value;
            }
        }


        private String _EndDate_nvc;
        public String EndDate_nvc
        {
            get
            {
                return _EndDate_nvc;
            }
            set
            {
                this._EndDate_nvc = value;
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


        private Nullable<Decimal> _WithLadeExtraHourFee_dec;
        public Nullable<Decimal> WithLadeExtraHourFee_dec
        {
            get
            {
                return _WithLadeExtraHourFee_dec;
            }
            set
            {
                this._WithLadeExtraHourFee_dec = value;
            }
        }


        private Nullable<Int32> _ServicesID_int;
        public Nullable<Int32> ServicesID_int
        {
            get
            {
                return _ServicesID_int;
            }
            set
            {
                this._ServicesID_int = value;
            }
        }
        private Boolean _Tax_bit;
        public Boolean Tax_bit
        {
            get
            { return _Tax_bit; }
            set
            { this._Tax_bit=value ; }
        }

        public int? TurnNotLadBillExtraHour_int { get; set; }
        public decimal? TurnNotLadBillExtraHourFee_dec { get; set; }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("AllowedHoure_int", "ساعت مجاز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("AllowedHoure_int", "ساعت مجاز", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Fee_dec", "هزینه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("Fee_dec", "هزینه", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ExtraHour_int", "اضافه ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("ExtraHour_int", "اضافه ساعت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("ExtraHourFee_dec", "هزینه اضافه ساعت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("TrafficTypeID_int", "نوع تردد", "TrafficType_T", "TrafficTypeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LaderPivotGroupID_int", "محور بارگیر", "LaderPivotGroup_T", "LaderPivotGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartDate_nvc", "از تاریخ", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("StartDate_nvc", "از تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("EndDate_nvc", "تا تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("EndDate_nvc", "تا تاریخ", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("WithLadeExtraHourFee_dec", "هزينه اضافه ساعت با بار", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("ServicesID_int", "مراجعه به", "Services_T", "ServicesID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueStopFeeID_int", "شناسه هزینه ماندن در پارکینگ", "StopFee_T", "StopFeeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Tax_bit", "استفاده از ارزش افزوده"));
        }
    }
}