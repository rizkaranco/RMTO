using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.BillBLL{

public class BLLBill_T
: BusinessObjectBase{

public enum Bill_TField {
BillID_int
,BillType_nvc
,TrafficTypeID_int
} 


private Int32 _BillID_int;
       public Int32 BillID_int
        {
            get
            {
                return _BillID_int;
            }
            set
            {
                this._BillID_int = value;
            }
        }


private String _BillType_nvc;
       public String BillType_nvc
        {
            get
            {
                return _BillType_nvc;
            }
            set
            {
                this._BillType_nvc = value;
            }
        }


private Nullable< Int32> _TrafficTypeID_int;
       public Nullable< Int32> TrafficTypeID_int
        {
            get
            {
                return _TrafficTypeID_int;
            }
            set
            {
                this._TrafficTypeID_int = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("BillType_nvc","نوع قبض"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("BillType_nvc","نوع قبض",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("TrafficTypeID_int","نوع تردد","TrafficType_T","TrafficTypeID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueBillID_int","شناسه قبض","Bill_T","BillID_int"));
}
}
}