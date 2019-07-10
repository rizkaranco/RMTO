using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.MessageRecipientBLL{

public class BLLMessageRecipient_T
: BusinessObjectBase{

public enum MessageRecipient_TField {
MessageRecipientID_int
,MessageID_bint
,UserGroupID_int
,StartDate_nvc
,EndDate_nvc
,Date_nvc
,Time_nvc
,UserName_nvc
} 


private Int32? _MessageRecipientID_int;
       public Int32? MessageRecipientID_int
        {
            get
            {
                return _MessageRecipientID_int;
            }
            set
            {
                this._MessageRecipientID_int = value;
            }
        }


private Int64? _MessageID_bint;
       public Int64? MessageID_bint
        {
            get
            {
                return _MessageID_bint;
            }
            set
            {
                this._MessageID_bint = value;
            }
        }


private Int32? _UserGroupID_int;
       public Int32? UserGroupID_int
        {
            get
            {
                return _UserGroupID_int;
            }
            set
            {
                this._UserGroupID_int = value;
            }
        }


private String _StartDate_nvc;
       public String StartDate_nvc
        {
            get
            {
                return _StartDate_nvc;
            }
            set
            {
                this._StartDate_nvc = value;
            }
        }


private String _EndDate_nvc;
       public String EndDate_nvc
        {
            get
            {
                return _EndDate_nvc;
            }
            set
            {
                this._EndDate_nvc = value;
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



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MessageID_bint","پیام"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("MessageID_bint", "پیام", "Message_T", "MessageID_bint"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserGroupID_int","گروه دریافت کننده"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int","گروه کاربری","UserGroup_T","UserGroupID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc","تاریخ"));
ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc","تاریخ",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc","ساعت"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc","ساعت",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc","کاربر",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر","User_T","UserName_nvc"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueMessageRecipientID_int","شناسه دریافت کننده پیام","MessageRecipient_T","MessageRecipientID_int"));
}
}
}