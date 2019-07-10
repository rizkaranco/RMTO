using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.DestinationAddressBLL{

public class BLLDestinationAddress_T
: BusinessObjectBase{

public enum DestinationAddress_TField {
DestinationAddressID_int
,DestinationAddress_nvc
} 


private Int32 _DestinationAddressID_int;
       public Int32 DestinationAddressID_int
        {
            get
            {
                return _DestinationAddressID_int;
            }
            set
            {
                this._DestinationAddressID_int = value;
            }
        }


private String _DestinationAddress_nvc;
       public String DestinationAddress_nvc
        {
            get
            {
                return _DestinationAddress_nvc;
            }
            set
            {
                this._DestinationAddress_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DestinationAddress_nvc","آدرس مقصد",300));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueDestinationAddressID_int","شناسه آدرس مقصد","DestinationAddress_T","DestinationAddressID_int"));
}
}
}