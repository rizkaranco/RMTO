using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CompanyLadBillBLL{

public class BLLCompanyLadBill_T
: BusinessObjectBase{

public enum CompanyLadBill_TField {
CompanyLadBillID_bint
,CompanyID_int
,CompanyCode_nvc
,Date_nvc
,Serial_nvc
,StartNumber_int
,EndNumber_int
,AssignmentNumber_nvc
,DeliveryUserCode_nvc
} 


private Int64 _CompanyLadBillID_bint;
       public Int64 CompanyLadBillID_bint
        {
            get
            {
                return _CompanyLadBillID_bint;
            }
            set
            {
                this._CompanyLadBillID_bint = value;
            }
        }


private Int32 _CompanyID_int;
       public Int32 CompanyID_int
        {
            get
            {
                return _CompanyID_int;
            }
            set
            {
                this._CompanyID_int = value;
            }
        }


private String _CompanyCode_nvc;
       public String CompanyCode_nvc
        {
            get
            {
                return _CompanyCode_nvc;
            }
            set
            {
                this._CompanyCode_nvc = value;
            }
        }


private String _Date_nvc;
       public String Date_nvc
        {
            get
            {
                return _Date_nvc;
            }
            set
            {
                this._Date_nvc = value;
            }
        }


private String _Serial_nvc;
       public String Serial_nvc
        {
            get
            {
                return _Serial_nvc;
            }
            set
            {
                this._Serial_nvc = value;
            }
        }


private Int32 _StartNumber_int;
       public Int32 StartNumber_int
        {
            get
            {
                return _StartNumber_int;
            }
            set
            {
                this._StartNumber_int = value;
            }
        }


private Int32 _EndNumber_int;
       public Int32 EndNumber_int
        {
            get
            {
                return _EndNumber_int;
            }
            set
            {
                this._EndNumber_int = value;
            }
        }


private String _AssignmentNumber_nvc;
       public String AssignmentNumber_nvc
        {
            get
            {
                return _AssignmentNumber_nvc;
            }
            set
            {
                this._AssignmentNumber_nvc = value;
            }
        }


private String _DeliveryUserCode_nvc;
       public String DeliveryUserCode_nvc
        {
            get
            {
                return _DeliveryUserCode_nvc;
            }
            set
            {
                this._DeliveryUserCode_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CompanyID_int","شرکت"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyID_int","شرکت","Company_T","CompanyID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CompanyCode_nvc","کد شرکت"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CompanyCode_nvc","کد شرکت",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc","تاریخ تحویل",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Serial_nvc","سریال"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Serial_nvc","سریال",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("StartNumber_int"," از شماره "));
ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("StartNumber_int"," از شماره ",null,null,0,0));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("EndNumber_int","تا شماره"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("EndNumber_int","تا شماره",null,null,0,0));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("AssignmentNumber_nvc","شماره حواله"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("AssignmentNumber_nvc","شماره حواله",15));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DeliveryUserCode_nvc","کد تحویل دهنده",5));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCompanyLadBillID_bint","شناسه بارنامه","CompanyLadBill_T","CompanyLadBillID_bint"));
}
}
}