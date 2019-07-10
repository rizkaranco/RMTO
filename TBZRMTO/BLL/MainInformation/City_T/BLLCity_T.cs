using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CityBLL
{

    public class BLLCity_T
    : BusinessObjectBase
    {

        public enum City_TField
        {
            CityID_int
            ,
            CityCode_nvc
                ,
            City_nvc
                ,
            TravelTime_int
                , Active_bit
        }


        private Int32? _CityID_int;
        public Int32? CityID_int
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


        private String _City_nvc;
        public String City_nvc
        {
            get
            {
                return _City_nvc;
            }
            set
            {
                this._City_nvc = value;
            }
        }


        private Nullable<Int32> _TravelTime_int;
        public Nullable<Int32> TravelTime_int
        {
            get
            {
                return _TravelTime_int;
            }
            set
            {
                this._TravelTime_int = value;
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



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CityCode_nvc", "کد شهر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CityCode_nvc", "کد شهر", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("City_nvc", "نام شهر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("City_nvc", "نام شهر", 80));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("TravelTime_int", "مدت سفر", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCityID_int", "شناسه شهر", "City_T", "CityID_int"));
        }
    }
}