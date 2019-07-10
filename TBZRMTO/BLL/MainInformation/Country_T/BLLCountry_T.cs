using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CountryBLL{

public class BLLCountry_T
: BusinessObjectBase{

public enum Country_TField {
CountryID_int
,CountryCode_nvc
,Country_nvc
,Active_bit
} 


private Int32 _CountryID_int;
       public Int32 CountryID_int
        {
            get
            {
                return _CountryID_int;
            }
            set
            {
                this._CountryID_int = value;
            }
        }


private String _CountryCode_nvc;
       public String CountryCode_nvc
        {
            get
            {
                return _CountryCode_nvc;
            }
            set
            {
                this._CountryCode_nvc = value;
            }
        }


private String _Country_nvc;
       public String Country_nvc
        {
            get
            {
                return _Country_nvc;
            }
            set
            {
                this._Country_nvc = value;
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



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CountryCode_nvc","کد کشور"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CountryCode_nvc","کد کشور",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Country_nvc","نام کشور"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Country_nvc","نام کشور",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit","فعال"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCountryID_int","شناسه کشور","Country_T","CountryID_int"));
}
}
}