using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ClassBLL{

public class BLLClass_T
: BusinessObjectBase{

public enum Class_TField {
ClassID_int
,ClassName_nvc
} 


private Int32 _ClassID_int;
       public Int32 ClassID_int
        {
            get
            {
                return _ClassID_int;
            }
            set
            {
                this._ClassID_int = value;
            }
        }


private String _ClassName_nvc;
       public String ClassName_nvc
        {
            get
            {
                return _ClassName_nvc;
            }
            set
            {
                this._ClassName_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ClassName_nvc","نام كلاس"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ClassName_nvc","نام كلاس",150));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueClassID_int","شناسه كلاس","Class_T","ClassID_int"));
}
}
}