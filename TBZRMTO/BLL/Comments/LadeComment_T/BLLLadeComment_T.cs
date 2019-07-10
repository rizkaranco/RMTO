using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeCommentBLL
{

    public class BLLLadeComment_T
    : BusinessObjectBase
    {

        public enum LadeComment_TField
        {
            LadeCommentID_int
            ,
            LadeComment_nvc
                , UserGroupID_int
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


        private Nullable<Int32> _UserGroupID_int;
        public Nullable<Int32> UserGroupID_int
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



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeComment_nvc", "توضیحات اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadeComment_nvc", "توضیحات اطلاع رسانی بار", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int", "گروه کاربری", "UserGroup_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeComment_nvc", "توضیحات اطلاع رسانی بار", "LadeComment_T", "LadeComment_nvc", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeCommentID_int", "توضیحات اطلاع رسانی بار", "LadeComment_T"));

        }
    }
}