using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CarSystemBLL{

public class BLLCarSystem_T
: BusinessObjectBase{

public enum CarSystem_TField {
CarSystemID_int
,CarSystem_nvc
} 


private Int32 _CarSystemID_int;
       public Int32 CarSystemID_int
        {
            get
            {
                return _CarSystemID_int;
            }
            set
            {
                this._CarSystemID_int = value;
            }
        }


private String _CarSystem_nvc;
       public String CarSystem_nvc
        {
            get
            {
                return _CarSystem_nvc;
            }
            set
            {
                this._CarSystem_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CarSystem_nvc","سیستم",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCarSystemID_int","شناسه سیستم","CarSystem_T","CarSystemID_int"));
}
}
}