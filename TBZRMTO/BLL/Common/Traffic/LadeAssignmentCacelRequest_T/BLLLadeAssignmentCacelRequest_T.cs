using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeAssignmentCacelRequestBLL
{

    public class BLLLadeAssignmentCacelRequest_T
    : BusinessObjectBase
    {

        public enum LadeAssignmentCacelRequest_TField
        {
            LadeAssignmentCancelRequestID_int
            ,
            ResuestDate_nvc
                ,
            RequestTime_nvc
                ,
            RequestUserName_nvc
                ,
            AcceptedDate_nvc
                ,
            AcceptedTime_nvc
                ,
            AcceptedUserName_nvc
                ,
            Comment_nvc
                , LadeAssignmentID_bint
        }


        private Int32 _LadeAssignmentCancelRequestID_int;
        public Int32 LadeAssignmentCancelRequestID_int
        {
            get
            {
                return _LadeAssignmentCancelRequestID_int;
            }
            set
            {
                this._LadeAssignmentCancelRequestID_int = value;
            }
        }


        private String _ResuestDate_nvc;
        public String ResuestDate_nvc
        {
            get
            {
                return _ResuestDate_nvc;
            }
            set
            {
                this._ResuestDate_nvc = value;
            }
        }


        private String _RequestTime_nvc;
        public String RequestTime_nvc
        {
            get
            {
                return _RequestTime_nvc;
            }
            set
            {
                this._RequestTime_nvc = value;
            }
        }


        private String _RequestUserName_nvc;
        public String RequestUserName_nvc
        {
            get
            {
                return _RequestUserName_nvc;
            }
            set
            {
                this._RequestUserName_nvc = value;
            }
        }


        private String _AcceptedDate_nvc;
        public String AcceptedDate_nvc
        {
            get
            {
                return _AcceptedDate_nvc;
            }
            set
            {
                this._AcceptedDate_nvc = value;
            }
        }


        private String _AcceptedTime_nvc;
        public String AcceptedTime_nvc
        {
            get
            {
                return _AcceptedTime_nvc;
            }
            set
            {
                this._AcceptedTime_nvc = value;
            }
        }


        private String _AcceptedUserName_nvc;
        public String AcceptedUserName_nvc
        {
            get
            {
                return _AcceptedUserName_nvc;
            }
            set
            {
                this._AcceptedUserName_nvc = value;
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


        private Int64 _LadeAssignmentID_bint;
        public Int64 LadeAssignmentID_bint
        {
            get
            {
                return _LadeAssignmentID_bint;
            }
            set
            {
                this._LadeAssignmentID_bint = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ResuestDate_nvc", "تاریخ درخواست"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ResuestDate_nvc", "تاریخ درخواست", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("ResuestDate_nvc", "تاریخ درخواست", null, null));
          //  ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("ResuestDate_nvc", "تاریخ درخواست"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("RequestTime_nvc", "ساعت درخواست"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("RequestTime_nvc", "ساعت درخواست", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RequestTime_nvc", "ساعت درخواست", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("RequestUserName_nvc", "کاربر در خواست کننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("RequestUserName_nvc", "کاربر در خواست کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر در خواست کننده", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("AcceptedDate_nvc", "تاریخ قبول درخواست", 10));
           
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("AcceptedDate_nvc", "تاریخ قبول درخواست", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("AcceptedTime_nvc", "ساعت قبول درخواست", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("AcceptedTime_nvc", "ساعت قبول درخواست", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("AcceptedUserName_nvc", "کاربر ثبت درخواست", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر ثبت درخواست", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Comment_nvc", "توضیحات", 1000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeAssignmentID_bint", "اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeAssignmentID_bint", "اطلاع رسانی بار", "LadeAssignment_T", "LadeAssignmentID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeAssignmentCancelRequestID_int", "درخواست انصراف از اطلاع رسانی بار", "LadeAssignmentCacelRequest_T", "LadeAssignmentCancelRequestID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeAssignmentID_bint", "", "LadeAssignmentCacelRequest_T", "LadeAssignmentID_bint"));
        }
    }
}