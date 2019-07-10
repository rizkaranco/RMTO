using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LaderPivotGroupBLL{

public class BLLLaderPivotGroup_T
: BusinessObjectBase{

public enum LaderPivotGroup_TField {
LaderPivotGroupID_int
,LaderPivotGroup_nvc
} 


private Int32? _LaderPivotGroupID_int;
       public Int32? LaderPivotGroupID_int
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


private String _LaderPivotGroup_nvc;
       public String LaderPivotGroup_nvc
        {
            get
            {
                return _LaderPivotGroup_nvc;
            }
            set
            {
                this._LaderPivotGroup_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LaderPivotGroup_nvc","گروه انواع بارگیر"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LaderPivotGroup_nvc","گروه انواع بارگیر",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLaderPivotGroupID_int","شناسه گروه انواع بارگیر","LaderPivotGroup_T","LaderPivotGroupID_int"));
}
}
}