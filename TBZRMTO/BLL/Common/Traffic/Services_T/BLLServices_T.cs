using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ServicesBLL{

public class BLLServices_T
: BusinessObjectBase{

public enum Services_TField {
ServicesID_int
,ServicesType_nvc
,Activie_bit
} 


private Int32? _ServicesID_int;
       public Int32? ServicesID_int
        {
            get
            {
                return _ServicesID_int;
            }
            set
            {
                this._ServicesID_int = value;
            }
        }


private String _ServicesType_nvc;
       public String ServicesType_nvc
        {
            get
            {
                return _ServicesType_nvc;
            }
            set
            {
                this._ServicesType_nvc = value;
            }
        }


private bool _Activie_bit;
       public bool Activie_bit
        {
            get
            {
                return _Activie_bit;
            }
            set
            {
                this._Activie_bit = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ServicesType_nvc","نوع خدمت"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ServicesType_nvc","نوع خدمت",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Activie_bit","فعال"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueServicesID_int","شناسه خدمات","Services_T","ServicesID_int"));
}
}
}