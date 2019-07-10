using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.PermissionGroupBLL{

public class BLLPermissionGroup_T
: BusinessObjectBase{

public enum PermissionGroup_TField {
PermissionGroupID_int
,PermissionGroup_nvc
,ParentID_int
} 


private Int32 _PermissionGroupID_int;
       public Int32 PermissionGroupID_int
        {
            get
            {
                return _PermissionGroupID_int;
            }
            set
            {
                this._PermissionGroupID_int = value;
            }
        }


private String _PermissionGroup_nvc;
       public String PermissionGroup_nvc
        {
            get
            {
                return _PermissionGroup_nvc;
            }
            set
            {
                this._PermissionGroup_nvc = value;
            }
        }


private Nullable< Int32> _ParentID_int;
       public Nullable< Int32> ParentID_int
        {
            get
            {
                return _ParentID_int;
            }
            set
            {
                this._ParentID_int = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PermissionGroup_nvc","عنوان گروه دسترسی"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PermissionGroup_nvc","عنوان گروه دسترسی",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("PermissionGroupID_int","","PermissionGroup_T","PermissionGroupID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquePermissionGroupID_int","شناسه گروه دسترسی","PermissionGroup_T","PermissionGroupID_int"));
}
}
}