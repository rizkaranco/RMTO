using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadBillCancelCommentBLL
{

    public class BLLLadBillCancelComment_T
    : BusinessObjectBase
    {

        public enum LadBillCancelComment_TField
        {
            LadBillCancelCommentID_int
            ,
            LadbillCancelComment_nvc
                , UserGroupID_int
        }


        private Int32 _LadBillCancelCommentID_int;
        public Int32 LadBillCancelCommentID_int
        {
            get
            {
                return _LadBillCancelCommentID_int;
            }
            set
            {
                this._LadBillCancelCommentID_int = value;
            }
        }


        private String _LadbillCancelComment_nvc;
        public String LadbillCancelComment_nvc
        {
            get
            {
                return _LadbillCancelComment_nvc;
            }
            set
            {
                this._LadbillCancelComment_nvc = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadbillCancelComment_nvc", "توضیحات ابطال مجوز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadbillCancelComment_nvc", "توضیحات ابطال مجوز", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int", "گروه کاربری", "UserGroup_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadBillCancelCommentID_int", "شناسه ابطال مجوز", "LadBillCancelComment_T", "LadBillCancelCommentID_int"));
        }
    }
}