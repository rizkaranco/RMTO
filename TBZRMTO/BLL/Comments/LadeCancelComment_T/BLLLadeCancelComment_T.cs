using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeCancelCommentBLL{

public class BLLLadeCancelComment_T
: BusinessObjectBase{

public enum LadeCancelComment_TField {
LadeCanceltCommentID_int
,LadeCancelComment_nvc
,UserGroupID_int
} 


private Int32 _LadeCanceltCommentID_int;
       public Int32 LadeCanceltCommentID_int
        {
            get
            {
                return _LadeCanceltCommentID_int;
            }
            set
            {
                this._LadeCanceltCommentID_int = value;
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


private Nullable< Int32> _UserGroupID_int;
       public Nullable< Int32> UserGroupID_int
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



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeCancelComment_nvc","توضیحات انصراف از اطلاع رسانی بار"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadeCancelComment_nvc","توضیحات انصراف از اطلاع رسانی بار",500));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int","گروه کاربری","UserGroup_T","UserGroupID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeCanceltCommentID_int","شناسه توضیحات انصراف از اطلاع رسانی بار","LadeCancelComment_T","LadeCanceltCommentID_int"));
}
}
}