using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.UserGroupBLL
{

    public class BLLUserGroup_T
    : BusinessObjectBase
    {
        public enum UserGroup
        {
            Admin=1
        }
        public enum UserGroup_TField
        {
            UserGroupID_int
            ,
            UserGroup_nvc
                ,
            Permission_nvc
                , Active_bit
        }


        private Int32? _UserGroupID_int;
        public Int32? UserGroupID_int
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


        private String _UserGroup_nvc;
        public String UserGroup_nvc
        {
            get
            {
                return _UserGroup_nvc;
            }
            set
            {
                this._UserGroup_nvc = value;
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


        private bool _Active_bit;
        public bool Active_bit
        {
            get
            {
                return _Active_bit;
            }
            set
            {
                this._Active_bit = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserGroup_nvc", "گروه کاربری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserGroup_nvc", "گروه کاربری", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Permission_nvc", "دسترسی", 2000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueUserGroupID_int", "شناسه گروه کاربری", "UserGroup_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueUserGroup_nvc", "گروه کاربری", "UserGroup_T", "UserGroup_nvc"));
        }
    }
}