using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CardCheckingLogBLL
{

    public partial class BLLCardCheckingLog_T : BusinessObjectBase
    {

        public enum CardCheckingLog_TField
        {
            CardCheckingLogID_int
            ,
            Date_vc
                ,
            Time_vc
                ,
            OperationType_nvc
                ,
            AcceptTurn_bit
            ,
            userName_nvc
            ,
            macAddress_nvc
            , DriverCardNumber_nvc
            , CarCardNumber_nvc
        }


        private Nullable<Int64> _CardCheckingLogID_int;
        public Nullable<Int64> CardCheckingLogID_int
        {
            get
            {
                return _CardCheckingLogID_int;
            }
            set
            {
                this._CardCheckingLogID_int = value;
            }
        }


        private String _Date_vc;
        public String Date_vc
        {
            get
            {
                return _Date_vc;
            }
            set
            {
                this._Date_vc = value;
            }
        }


        private String _Time_vc;
        public String Time_vc
        {
            get
            {
                return _Time_vc;
            }
            set
            {
                this._Time_vc = value;
            }
        }


        private String _OperationType_nvc;
        public String OperationType_nvc
        {
            get
            {
                return _OperationType_nvc;
            }
            set
            {
                this._OperationType_nvc = value;
            }
        }


        private Nullable<bool> _AcceptTurn_bit;
        public Nullable<bool> AcceptTurn_bit
        {
            get
            {
                return _AcceptTurn_bit;
            }
            set
            {
                this._AcceptTurn_bit = value;
            }
        }

        public string userName_nvc { get; set; }

        public string macAddress_nvc { get; set; }

        public string CarCardNumber_nvc { get; set; }

        public string DriverCardNumber_nvc { get; set; }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_vc", "تاریخ ارسال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_vc", "تاریخ ارسال", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_vc", "ساعت ارسال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_vc", "ساعت ارسال", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("OperationType_nvc", "نوع عملیات"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("OperationType_nvc", "نوع عملیات", 3000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("AcceptTurn_bit", "تأیید نوبت(اگر 0 بود یعنی مجوز است)"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCardCheckingLogID_int", "شناسه ثبت اطلاعات اتصال به سیستم کارت هوشمند", "CardCheckingLog_T", "CardCheckingLogID_int"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}