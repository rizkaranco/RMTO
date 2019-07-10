using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadBillCreditCancelCommentBLL
{

    public class BLLLadBillCreditCancelComment_T
    : BusinessObjectBase
    {

        public enum LadBillCreditCancelComment_TField
        {
            LadBillCreditCancelCommentID_int
            ,
            LadBillCreditID_int
                ,
            LadBillCancelCommentID_int
                , LadbillCancelComment_nvc
        }


        private Int32 _LadBillCreditCancelCommentID_int;
        public Int32 LadBillCreditCancelCommentID_int
        {
            get
            {
                return _LadBillCreditCancelCommentID_int;
            }
            set
            {
                this._LadBillCreditCancelCommentID_int = value;
            }
        }


        private Int32 _LadBillCreditID_int;
        public Int32 LadBillCreditID_int
        {
            get
            {
                return _LadBillCreditID_int;
            }
            set
            {
                this._LadBillCreditID_int = value;
            }
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

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadBillCreditID_int", "ابطال مجوز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadBillCreditID_int", "ابطال مجوز", "LadBillCredit_T", "LadBillCreditID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadBillCancelCommentID_int", "توضیحات ابطال مجوز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadBillCancelCommentID_int", "توضیحات ابطال مجوز", "LadBillCancelComment_T", "LadBillCancelCommentID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadbillCancelComment_nvc", "توضیحات ابطال مجوز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadbillCancelComment_nvc", "توضیحات ابطال مجوز", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadBillCreditCancelCommentID_int", "شناسه توضیحات ابطال های مجوز", "LadBillCreditCancelComment_T", "LadBillCreditCancelCommentID_int"));
        }
    }
}