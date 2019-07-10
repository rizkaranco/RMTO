using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeAssignmentCommentBLL
{

    public class BLLLadeAssignmentComment_T
    : BusinessObjectBase
    {

        public enum LadeAssignmentComment_TField
        {
            LadeAssignmentCommentID_int
            ,
            LadeCommentID_int
                ,
            LadeComment_nvc
                ,
            LadeAssignmentID_bint
                ,
            Date_nvc
                ,
            Time_nvc
                , UserName_nvc
        }


        private Int32? _LadeAssignmentCommentID_int;
        public Int32? LadeAssignmentCommentID_int
        {
            get
            {
                return _LadeAssignmentCommentID_int;
            }
            set
            {
                this._LadeAssignmentCommentID_int = value;
            }
        }


        private Int32? _LadeCommentID_int;
        public Int32? LadeCommentID_int
        {
            get
            {
                return _LadeCommentID_int;
            }
            set
            {
                this._LadeCommentID_int = value;
            }
        }


        private String _LadeComment_nvc;
        public String LadeComment_nvc
        {
            get
            {
                return _LadeComment_nvc;
            }
            set
            {
                this._LadeComment_nvc = value;
            }
        }


        private Int64? _LadeAssignmentID_bint;
        public Int64? LadeAssignmentID_bint
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeCommentID_int", "توضیحات اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeCommentID_int", "توضیحات اطلاع رسانی بار", "LadeComment_T", "LadeCommentID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeComment_nvc", "توضیحات اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadeComment_nvc", "توضیحات اطلاع رسانی بار", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeAssignmentID_bint", "اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeAssignmentID_bint", "اطلاع رسانی بار", "LadeAssignment_T", "LadeAssignmentID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("Time_nvc", "ساعت", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeAssignmentCommentID_int", "توضیحات اطلاع رسانی بار", "LadeAssignmentComment_T", "LadeAssignmentCommentID_int"));
        }
    }
}