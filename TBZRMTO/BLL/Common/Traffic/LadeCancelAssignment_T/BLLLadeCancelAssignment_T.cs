using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeCancelAssignmentBLL
{

    public class BLLLadeCancelAssignment_T
    : BusinessObjectBase
    {

        public enum LadeCancelAssignment_TField
        {
            LadeCancelAssignmentID_int
            ,
            LadeCancelCommentID_int
                ,
            LadeCancelComment_nvc
                ,
            LadeAssignmentID_bint
                ,
            Count_int
                ,
            Date_nvc
                ,
            Time_nvc
                , UserName_nvc
        }


        private Int32 _LadeCancelAssignmentID_int;
        public Int32 LadeCancelAssignmentID_int
        {
            get
            {
                return _LadeCancelAssignmentID_int;
            }
            set
            {
                this._LadeCancelAssignmentID_int = value;
            }
        }


        private Int32? _LadeCancelCommentID_int;
        public Int32? LadeCancelCommentID_int
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


        private Nullable<Int32> _Count_int;
        public Nullable<Int32> Count_int
        {
            get
            {
                return _Count_int;
            }
            set
            {
                this._Count_int = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeCancelCommentID_int", "توضیحات "));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeCanceltCommentID_int", "توضیحات", "LadeCancelComment_T", "LadeCanceltCommentID_int"));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeCancelComment_nvc", "توضیحات انصراف از اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadeCancelComment_nvc", "توضیحات انصراف از اطلاع رسانی بار", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeAssignmentID_bint", "اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeAssignmentID_bint", "اطلاع رسانی بار", "LadeAssignment_T", "LadeAssignmentID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("Count_int", "تعداد ماشین حذفی", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Count_int", "تعداد ماشین حذفی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeCancelAssignmentID_int", "شناسه انصراف از اطلاع رسانی بار", "LadeCancelAssignment_T", "LadeCancelAssignmentID_int"));
            ValidationRules.AddRules(new HPS.validators.LadeAssignmentCancelRule("LadeAssignmentCancelRule", "LadeAssignmentCancelRule"));
        }
    }
}