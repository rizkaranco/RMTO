using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ChargePriceBLL
{

    public class BLLChargePrice_T
    : BusinessObjectBase
    {

        public enum ChargePrice_TField
        {
            ChargePriceID_int
            ,
            DriverID_bint
                ,
            DriverName_nvc
                ,
            DriverCardNumber_nvc
                ,
            Price_dec
                ,
            Date_nvc
                ,
            Time_nvc
                ,
            UserName_nvc
                , Description_nvc
        }


        private Int32? _ChargePriceID_int;
        public Int32? ChargePriceID_int
        {
            get
            {
                return _ChargePriceID_int;
            }
            set
            {
                this._ChargePriceID_int = value;
            }
        }


        private Int64? _DriverID_bint;
        public Int64? DriverID_bint
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


        private String _DriverName_nvc;
        public String DriverName_nvc
        {
            get
            {
                return _DriverName_nvc;
            }
            set
            {
                this._DriverName_nvc = value;
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


        private Nullable<Decimal> _Price_dec;
        public Nullable<Decimal> Price_dec
        {
            get
            {
                return _Price_dec;
            }
            set
            {
                this._Price_dec = value;
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


        private String _Description_nvc;
        public String Description_nvc
        {
            get
            {
                return _Description_nvc;
            }
            set
            {
                this._Description_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverID_bint", "راننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("DriverID_bint", "FK Not Exits", "Driver_T", "DriverID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverName_nvc", "نام راننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverName_nvc", "نام راننده", 200));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardNumber_nvc", "شماره کارت راننده", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Price_dec", "مبلغ شارژ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("Price_dec", "مبلغ شارژ", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Description_nvc", "توضیحات", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueChargePriceID_int", "شارژ مالی", "ChargePrice_T", "ChargePriceID_int"));
        }
    }
}