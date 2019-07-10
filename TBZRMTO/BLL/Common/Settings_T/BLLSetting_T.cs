using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.SettingsBLL
{

    public class BLLSetting_T
    : BusinessObjectBase
    {

        public enum Setting_TField
        {
            SettingID_int
            ,
            Setting_nvc
                ,
            Value_nvc
                ,
            Description_nvc
                ,
            Boolean_bit
                ,
            Shortcutkey_bit
                ,
            Numeric_bit
                ,
            Text_bit
                ,
            Account_bit
                ,
            Selective_bit
                ,
            SelectValue1_int
                ,
            SelectText1_nvc
                ,
            SelectValue2_int
                ,
            SelectText2_nvc
                ,
            SelectValue3_int
                ,
            SelectText3_nvc
                ,
            SelectValue4_int
                ,
            SelectText4_nvc
                ,
            SelectValue5_int
                ,
            SelectText5_nvc
                ,
            SelectValue6_int
                , SelectText6_nvc
        }


        private Int32 _SettingID_int;
        public Int32 SettingID_int
        {
            get
            {
                return _SettingID_int;
            }
            set
            {
                this._SettingID_int = value;
            }
        }


        private String _Setting_nvc;
        public String Setting_nvc
        {
            get
            {
                return _Setting_nvc;
            }
            set
            {
                this._Setting_nvc = value;
            }
        }


        private String _Value_nvc;
        public String Value_nvc
        {
            get
            {
                return _Value_nvc;
            }
            set
            {
                this._Value_nvc = value;
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


        private Nullable<bool> _Boolean_bit;
        public Nullable<bool> Boolean_bit
        {
            get
            {
                return _Boolean_bit;
            }
            set
            {
                this._Boolean_bit = value;
            }
        }


        private Nullable<bool> _Shortcutkey_bit;
        public Nullable<bool> Shortcutkey_bit
        {
            get
            {
                return _Shortcutkey_bit;
            }
            set
            {
                this._Shortcutkey_bit = value;
            }
        }


        private Nullable<bool> _Numeric_bit;
        public Nullable<bool> Numeric_bit
        {
            get
            {
                return _Numeric_bit;
            }
            set
            {
                this._Numeric_bit = value;
            }
        }


        private Nullable<bool> _Text_bit;
        public Nullable<bool> Text_bit
        {
            get
            {
                return _Text_bit;
            }
            set
            {
                this._Text_bit = value;
            }
        }


        private Nullable<bool> _Account_bit;
        public Nullable<bool> Account_bit
        {
            get
            {
                return _Account_bit;
            }
            set
            {
                this._Account_bit = value;
            }
        }


        private Nullable<bool> _Selective_bit;
        public Nullable<bool> Selective_bit
        {
            get
            {
                return _Selective_bit;
            }
            set
            {
                this._Selective_bit = value;
            }
        }


        private Nullable<Int32> _SelectValue1_int;
        public Nullable<Int32> SelectValue1_int
        {
            get
            {
                return _SelectValue1_int;
            }
            set
            {
                this._SelectValue1_int = value;
            }
        }


        private String _SelectText1_nvc;
        public String SelectText1_nvc
        {
            get
            {
                return _SelectText1_nvc;
            }
            set
            {
                this._SelectText1_nvc = value;
            }
        }


        private Nullable<Int32> _SelectValue2_int;
        public Nullable<Int32> SelectValue2_int
        {
            get
            {
                return _SelectValue2_int;
            }
            set
            {
                this._SelectValue2_int = value;
            }
        }


        private String _SelectText2_nvc;
        public String SelectText2_nvc
        {
            get
            {
                return _SelectText2_nvc;
            }
            set
            {
                this._SelectText2_nvc = value;
            }
        }


        private Nullable<Int32> _SelectValue3_int;
        public Nullable<Int32> SelectValue3_int
        {
            get
            {
                return _SelectValue3_int;
            }
            set
            {
                this._SelectValue3_int = value;
            }
        }


        private String _SelectText3_nvc;
        public String SelectText3_nvc
        {
            get
            {
                return _SelectText3_nvc;
            }
            set
            {
                this._SelectText3_nvc = value;
            }
        }


        private Nullable<Int32> _SelectValue4_int;
        public Nullable<Int32> SelectValue4_int
        {
            get
            {
                return _SelectValue4_int;
            }
            set
            {
                this._SelectValue4_int = value;
            }
        }


        private String _SelectText4_nvc;
        public String SelectText4_nvc
        {
            get
            {
                return _SelectText4_nvc;
            }
            set
            {
                this._SelectText4_nvc = value;
            }
        }


        private Nullable<Int32> _SelectValue5_int;
        public Nullable<Int32> SelectValue5_int
        {
            get
            {
                return _SelectValue5_int;
            }
            set
            {
                this._SelectValue5_int = value;
            }
        }


        private String _SelectText5_nvc;
        public String SelectText5_nvc
        {
            get
            {
                return _SelectText5_nvc;
            }
            set
            {
                this._SelectText5_nvc = value;
            }
        }


        private Nullable<Int32> _SelectValue6_int;
        public Nullable<Int32> SelectValue6_int
        {
            get
            {
                return _SelectValue6_int;
            }
            set
            {
                this._SelectValue6_int = value;
            }
        }


        private String _SelectText6_nvc;
        public String SelectText6_nvc
        {
            get
            {
                return _SelectText6_nvc;
            }
            set
            {
                this._SelectText6_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("SettingID_int", "شناسه تنظیمات"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SettingID_int", "شناسه تنظیمات", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Setting_nvc", "عنوان تنظیمات"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Setting_nvc", "عنوان تنظیمات", 1000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Value_nvc", "مقدار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Value_nvc", "مقدار", 1000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Description_nvc", "توضیحات", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SelectValue1_int", "", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SelectText1_nvc", "", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SelectValue2_int", "", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SelectText2_nvc", "", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SelectValue3_int", "", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SelectText3_nvc", "", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SelectValue4_int", "", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SelectText4_nvc", "", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SelectValue5_int", "", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SelectText5_nvc", "", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SelectValue6_int", "", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SelectText6_nvc", "", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueSettingID_int", "شناسه تنظیمات", "Setting_T", "SettingID_int"));
        }
    }
}