using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.MessageBLL{

public class BLLMessage_T
: BusinessObjectBase{

public enum Message_TField {
MessageID_bint
,MessageTitle_nvc
,Message_nvc
,StartDate_nvc
,EndDate_nvc
,Visited_bit
,RecipientUserName_nvc
,Date_nvc
,Time_nvc
,UserName_nvc
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


private String _MessageTitle_nvc;
       public String MessageTitle_nvc
        {
            get
            {
                return _MessageTitle_nvc;
            }
            set
            {
                this._MessageTitle_nvc = value;
            }
        }


private String _Message_nvc;
       public String Message_nvc
        {
            get
            {
                return _Message_nvc;
            }
            set
            {
                this._Message_nvc = value;
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


private bool _Visited_bit;
       public bool Visited_bit
        {
            get
            {
                return _Visited_bit;
            }
            set
            {
                this._Visited_bit = value;
            }
        }


private String _RecipientUserName_nvc;
       public String RecipientUserName_nvc
        {
            get
            {
                return _RecipientUserName_nvc;
            }
            set
            {
                this._RecipientUserName_nvc = value;
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
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MessageTitle_nvc","عنوان پيام"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MessageTitle_nvc","عنوان پيام",200));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Message_nvc","متن پيام"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Message_nvc","متن پيام",1000));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartDate_nvc","از تاریخ",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("EndDate_nvc","تا تاریخ",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("StartDate_nvc", "از تاریخ", null, null));
ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("EndDate_nvc", "تا تاریخ", null, null));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Visited_bit","خوانده شده"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RecipientUserName_nvc","کاربر دریافت کننده",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر","User_T","UserName_nvc"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc","تاريخ"));
ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc","تاريخ",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc","ساعت"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc","ساعت",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc","کاربر"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc","کاربر",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر","User_T","UserName_nvc"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueMessageID_bint","شناسه پيام","Message_T","MessageID_bint"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("StartDate_nvc", "از تاریخ", "Message_T", "StartDate_nvc", "EndDate_nvc"));
}
}
}