using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.OnlineUserBLL
{

    public partial class BLLOnlineUser_T : BusinessObjectBase
    {

        public enum OnlineUser_TField
        {
            OnlineUserID_int
            ,
            UserName_nvc
                ,
            MacAddress_nvc
                ,
            LoginDate_vc
                ,
            LoginTime_vc
                ,
            LogOutDate_vc
                , LogOutTime_vc
        }


        private Nullable<Int32> _OnlineUserID_int;
        public Nullable<Int32> OnlineUserID_int
        {
            get
            {
                return _OnlineUserID_int;
            }
            set
            {
                this._OnlineUserID_int = value;
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


        private String _MacAddress_nvc;
        public String MacAddress_nvc
        {
            get
            {
                return _MacAddress_nvc;
            }
            set
            {
                this._MacAddress_nvc = value;
            }
        }


        private String _LoginDate_vc;
        public String LoginDate_vc
        {
            get
            {
                return _LoginDate_vc;
            }
            set
            {
                this._LoginDate_vc = value;
            }
        }


        private String _LoginTime_vc;
        public String LoginTime_vc
        {
            get
            {
                return _LoginTime_vc;
            }
            set
            {
                this._LoginTime_vc = value;
            }
        }


        private String _LogOutDate_vc;
        public String LogOutDate_vc
        {
            get
            {
                return _LogOutDate_vc;
            }
            set
            {
                this._LogOutDate_vc = value;
            }
        }


        private String _LogOutTime_vc;
        public String LogOutTime_vc
        {
            get
            {
                return _LogOutTime_vc;
            }
            set
            {
                this._LogOutTime_vc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "نام کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "نام کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "نام کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MacAddress_nvc", "مک آدرس"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MacAddress_nvc", "مک آدرس", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LoginDate_vc", "تاریخ ورود"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LoginDate_vc", "تاریخ ورود", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("LoginDate_vc", "تاریخ ورود", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LoginTime_vc", "ساعت ورود"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LoginTime_vc", "ساعت ورود", 8));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("LoginTime_vc", "ساعت ورود", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LogOutDate_vc", "تاریخ خروج", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("LogOutDate_vc", "تاریخ خروج", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LogOutTime_vc", "ساعت خروج", 8));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("LogOutTime_vc", "ساعت خروج", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueOnlineUserID_int", "شناسه کاربر آنلاین", "OnlineUser_T", "OnlineUserID_int"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}