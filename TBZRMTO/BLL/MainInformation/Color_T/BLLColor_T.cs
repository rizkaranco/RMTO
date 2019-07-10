using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ColorBLL{

public class BLLColor_T
: BusinessObjectBase{

public enum Color_TField {
ColorID_int
,Color_nvc
,ColorCode_nvc
} 


private Int32 _ColorID_int;
       public Int32 ColorID_int
        {
            get
            {
                return _ColorID_int;
            }
            set
            {
                this._ColorID_int = value;
            }
        }


private String _Color_nvc;
       public String Color_nvc
        {
            get
            {
                return _Color_nvc;
            }
            set
            {
                this._Color_nvc = value;
            }
        }


private String _ColorCode_nvc;
       public String ColorCode_nvc
        {
            get
            {
                return _ColorCode_nvc;
            }
            set
            {
                this._ColorCode_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Color_nvc","رنگ"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Color_nvc","رنگ",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ColorCode_nvc","کد رنگ",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueColorID_int","شناسه رنگ","Color_T","ColorID_int"));
}
}
}