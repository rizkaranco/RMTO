using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadBillCreditCancelBLL{

public class BLLLadBillCreditCancel_T
: BusinessObjectBase{

public enum LadBillCreditCancel_TField {
LadBillCreditCancelID_int
,Date_nvc
,Time_nvc
,UserName_nvc
,LadBillCreditID_int
,Comment_nvc
} 


private Int32 _LadBillCreditCancelID_int;
       public Int32 LadBillCreditCancelID_int
        {
            get
            {
                return _LadBillCreditCancelID_int;
            }
            set
            {
                this._LadBillCreditCancelID_int = value;
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


private String _Time_nvc;
       public String Time_nvc
        {
            get
            {
                return _Time_nvc;
            }
            set
            {
                this._Time_nvc = value;
            }
        }


private String _UserName_nvc;
       public String UserName_nvc
        {
            get
            {
                return _UserName_nvc;
            }
            set
            {
                this._UserName_nvc = value;
            }
        }


private Int32 _LadBillCreditID_int;
       public Int32 LadBillCreditID_int
        {
            get
            {
                return _LadBillCreditID_int;
            }
            set
            {
                this._LadBillCreditID_int = value;
            }
        }


private String _Comment_nvc;
       public String Comment_nvc
        {
            get
            {
                return _Comment_nvc;
            }
            set
            {
                this._Comment_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc","تاریخ"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc","تاریخ",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc","ساعت"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc","ساعت",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc","کاربر"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc","کاربر",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc","کاربر","User_T","UserName_nvc"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadBillCreditID_int","مجوز بارگیری"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadBillCreditID_int","مجوز بارگیری","LadBillCredit_T","LadBillCreditID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Comment_nvc","توضیحات"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Comment_nvc","توضیحات",500));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadBillCreditCancelID_int","شناسه حذف مجوز بارگیری","LadBillCreditCancel_T","LadBillCreditCancelID_int"));
}
}
}