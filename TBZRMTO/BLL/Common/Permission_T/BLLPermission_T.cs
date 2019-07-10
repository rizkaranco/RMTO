using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.PermissionBLL{

public class BLLPermission_T
: BusinessObjectBase{

public enum Permission_TField {
PermissionID_bint
,Permission_nvc
,PermissionGroupID_int
,FormName_nvc
,ControlName_nvc
,PropertyName_nvc
,Value_nvc
,ColumnName_nvc
} 


private Int64 _PermissionID_bint;
       public Int64 PermissionID_bint
        {
            get
            {
                return _PermissionID_bint;
            }
            set
            {
                this._PermissionID_bint = value;
            }
        }


private String _Permission_nvc;
       public String Permission_nvc
        {
            get
            {
                return _Permission_nvc;
            }
            set
            {
                this._Permission_nvc = value;
            }
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


private String _FormName_nvc;
       public String FormName_nvc
        {
            get
            {
                return _FormName_nvc;
            }
            set
            {
                this._FormName_nvc = value;
            }
        }


private String _ControlName_nvc;
       public String ControlName_nvc
        {
            get
            {
                return _ControlName_nvc;
            }
            set
            {
                this._ControlName_nvc = value;
            }
        }


private String _PropertyName_nvc;
       public String PropertyName_nvc
        {
            get
            {
                return _PropertyName_nvc;
            }
            set
            {
                this._PropertyName_nvc = value;
            }
        }


private String _Value_nvc;
       public String Value_nvc
        {
            get
            {
                return _Value_nvc;
            }
            set
            {
                this._Value_nvc = value;
            }
        }


private String _ColumnName_nvc;
       public String ColumnName_nvc
        {
            get
            {
                return _ColumnName_nvc;
            }
            set
            {
                this._ColumnName_nvc = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PermissionID_bint","کد مجوز"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("PermissionID_bint","کد مجوز",null,null,0,0));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Permission_nvc","عنوان مجوز"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Permission_nvc","عنوان مجوز",2000));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PermissionGroupID_int"," گروه کاربری"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("PermissionGroupID_int"," گروه کاربری","PermissionGroup_T","PermissionGroupID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FormName_nvc","نام فرم",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ControlName_nvc","نام کنترل",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PropertyName_nvc","نام خاصیت",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Value_nvc","مقدار",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ColumnName_nvc","نام ستون ",50));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquePermissionID_bint","کد مجوز","Permission_T","PermissionID_bint"));
}
}
}