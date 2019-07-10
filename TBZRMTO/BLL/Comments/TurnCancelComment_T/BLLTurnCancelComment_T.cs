using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.TurnCancelCommentBLL
{

    public class BLLTurnCancelComment_T
    : BusinessObjectBase
    {

        public enum TurnCancelComment_TField
        {
            TurnCancelCommentID_int
            ,
            TurnCancelComment_nvc
                , UserGroupID_int
        }


        private Int32? _TurnCancelCommentID_int;
        public Int32? TurnCancelCommentID_int
        {
            get
            {
                return _TurnCancelCommentID_int;
            }
            set
            {
                this._TurnCancelCommentID_int = value;
            }
        }


        private String _TurnCancelComment_nvc;
        public String TurnCancelComment_nvc
        {
            get
            {
                return _TurnCancelComment_nvc;
            }
            set
            {
                this._TurnCancelComment_nvc = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TurnCancelComment_nvc", "توضیحات ابطال نوبت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("TurnCancelComment_nvc", "توضیحات ابطال نوبت", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int", "گروه کاربری", "UserGroup_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueTurnCancelCommentID_int", " شناسه توضیحات ابطال نوبت", "TurnCancelComment_T", "TurnCancelCommentID_int"));
        }
    }
}