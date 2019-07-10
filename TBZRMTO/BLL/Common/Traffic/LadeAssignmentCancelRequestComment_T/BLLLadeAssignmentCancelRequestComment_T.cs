using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeAssignmentCancelRequestCommentBLL
{

    public class BLLLadeAssignmentCancelRequestComment_T
    : BusinessObjectBase
    {

        public enum LadeAssignmentCancelRequestComment_TField
        {
            LadeAssignmentCancelRequestCommentID_int
            ,
            LadeAssignmentCancelRequestID_int
                ,
            LadeCancelCommentID_int
                ,
            LadeCancelComment_nvc
                ,
            Date_nvc
                ,
            Time_nvc
                , UserName_nvc
        }


        private Int32 _LadeAssignmentCancelRequestCommentID_int;
        public Int32 LadeAssignmentCancelRequestCommentID_int
        {
            get
            {
                return _LadeAssignmentCancelRequestCommentID_int;
            }
            set
            {
                this._LadeAssignmentCancelRequestCommentID_int = value;
            }
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


        private Int32 _LadeCancelCommentID_int;
        public Int32 LadeCancelCommentID_int
        {
            get
            {
                return _LadeCancelCommentID_int;
            }
            set
            {
                this._LadeCancelCommentID_int = value;
            }
        }


        private String _LadeCancelComment_nvc;
        public String LadeCancelComment_nvc
        {
            get
            {
                return _LadeCancelComment_nvc;
            }
            set
            {
                this._LadeCancelComment_nvc = value;
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



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeAssignmentCancelRequestID_int", "درخواست انصراف از اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeAssignmentCancelRequestID_int", "درخواست انصراف از اطلاع رسانی بار", "LadeAssignmentCacelRequest_T", "LadeAssignmentCancelRequestID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeCancelCommentID_int", "توضیحات انصراف از اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeCanceltCommentID_int", "توضیحات انصراف از اطلاع رسانی بار", "LadeCancelComment_T", "LadeCanceltCommentID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeCancelComment_nvc", "توضیحات انصراف از اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadeCancelComment_nvc", "توضیحات انصراف از اطلاع رسانی بار", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeAssignmentCancelRequestCommentID_int", "توضیحات درخواست انصراف از اطلاع رسانی بار", "LadeAssignmentCancelRequestComment_T", "LadeAssignmentCancelRequestCommentID_int"));
        }
    }
}