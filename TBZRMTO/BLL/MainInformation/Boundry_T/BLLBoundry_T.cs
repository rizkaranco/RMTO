using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.BoundryBLL{

public class BLLBoundry_T
: BusinessObjectBase{

public enum Boundry_TField {
BoundryID_int
,BoundryCode_nvc
,Boundry_nvc
} 


private Int32 _BoundryID_int;
       public Int32 BoundryID_int
        {
            get
            {
                return _BoundryID_int;
            }
            set
            {
                this._BoundryID_int = value;
            }
        }


private String _BoundryCode_nvc;
       public String BoundryCode_nvc
        {
            get
            {
                return _BoundryCode_nvc;
            }
            set
            {
                this._BoundryCode_nvc = value;
            }
        }


private String _Boundry_nvc;
       public String Boundry_nvc
        {
            get
            {
                return _Boundry_nvc;
            }
            set
            {
                this._Boundry_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("BoundryCode_nvc","کد مرز"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("BoundryCode_nvc","کد مرز",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Boundry_nvc","نام مرز"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Boundry_nvc","نام مرز",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueBoundryID_int","شناسه مرز","Boundry_T","BoundryID_int"));
}
}
}