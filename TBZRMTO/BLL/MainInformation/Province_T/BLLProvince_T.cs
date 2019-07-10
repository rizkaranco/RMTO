using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ProvinceBLL{

public class BLLProvince_T
: BusinessObjectBase{

public enum Province_TField {
Province_int
,ProvinceCode_nvc
,Province_nvc
,Active_bit
} 


private Int32? _Province_int;
       public Int32? Province_int
        {
            get
            {
                return _Province_int;
            }
            set
            {
                this._Province_int = value;
            }
        }


private String _ProvinceCode_nvc;
       public String ProvinceCode_nvc
        {
            get
            {
                return _ProvinceCode_nvc;
            }
            set
            {
                this._ProvinceCode_nvc = value;
            }
        }


private String _Province_nvc;
       public String Province_nvc
        {
            get
            {
                return _Province_nvc;
            }
            set
            {
                this._Province_nvc = value;
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
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ProvinceCode_nvc","کد استان"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ProvinceCode_nvc","کد استان",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Province_nvc","نام استان"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Province_nvc","نام استان",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit","فعال"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueProvince_int","شناسه استان","Province_T","Province_int"));
}
}
}