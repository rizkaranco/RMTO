using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.UserBLL
{

    public class BLLUser_T
    : BusinessObjectBase
    {

        public enum User_TField
        {
            UserName_nvc
            ,
            FullName_nvc
                ,
            Password_nvc
                ,
            StartDate_vc
                ,
            ExpireDate_vc
                ,
            UserGroupID_int
                ,
            Picture_img
                ,
            Active_bit
                ,
            CreateDate_nvc
                ,
            CreateTime_nvc
                ,
            InfractionGroupID_int
                ,
            CompanyID_int
                ,
            Mobile_nvc
                ,
            MultiAccess_bit
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

        private String _FullName_nvc;
        public String FullName_nvc
        {
            get
            {
                return _FullName_nvc;
            }
            set
            {
                this._FullName_nvc = value;
            }
        }

        private String _Password_nvc;
        public String Password_nvc
        {
            get
            {
                return _Password_nvc;
            }
            set
            {
                this._Password_nvc = value;
            }
        }

        private String _StartDate_vc;
        public String StartDate_vc
        {
            get
            {
                return _StartDate_vc;
            }
            set
            {
                this._StartDate_vc = value;
            }
        }

        private String _ExpireDate_vc;
        public String ExpireDate_vc
        {
            get
            {
                return _ExpireDate_vc;
            }
            set
            {
                this._ExpireDate_vc = value;
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

        private Byte[] _Picture_img;
        public Byte[] Picture_img
        {
            get
            {
                return _Picture_img;
            }
            set
            {
                this._Picture_img = value;
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

        private String _CreateDate_nvc;
        public String CreateDate_nvc
        {
            get
            {
                return _CreateDate_nvc;
            }
            set
            {
                this._CreateDate_nvc = value;
            }
        }

        private String _CreateTime_nvc;
        public String CreateTime_nvc
        {
            get
            {
                return _CreateTime_nvc;
            }
            set
            {
                this._CreateTime_nvc = value;
            }
        }

        private Nullable<Int32> _InfractionGroupID_int;
        public Nullable<Int32> InfractionGroupID_int
        {
            get
            {
                return _InfractionGroupID_int;
            }
            set
            {
                this._InfractionGroupID_int = value;
            }
        }
       
        private string _ConfirmPassword_nvc;
        public string ConfirmPassword_nvc
        {
            get
            {
                return _ConfirmPassword_nvc;
            }
            set
            {
                this._ConfirmPassword_nvc = value;
            }
        }

        private Nullable<Int32> _CompanyID_int;
        public Nullable<Int32> CompanyID_int
        {
            get
            {
                return _CompanyID_int;
            }
            set
            {
                this._CompanyID_int = value;
            }
        }

        private String _Mobile_nvc;
        public String Mobile_nvc
        {
            get
            {
                return _Mobile_nvc;
            }
            set
            {
                this._Mobile_nvc = value ;
            }
        }

        private bool _MultiAccess_bit;
        public bool MultiAccess_bit
        {
            get
            {
                return _MultiAccess_bit;
            }
            set
            {
                this._MultiAccess_bit = value;
            }

        }

        public int? OnlineUserID_int { get; set; }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "شناسه کاربری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "شناسه کاربری", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FullName_nvc", "نام و نام خانوادگی", 100));

            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartDate_vc", "تاریخ شروع اعتبار", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ExpireDate_vc", "تاریخ پایان اعتبار", 10));

            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("StartDate_vc", "تاریخ شروع اعتبار", null,null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("ExpireDate_vc", "تاریخ پایان اعتبار", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int", "گروه کاربری", "UserGroup_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserGroupID_int", "گروه کاربری"));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UserGroupID_int", "گروه کاربری", "User_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyID_int", "شرکت", "Company_T", "CompanyID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CreateDate_nvc", "تاریخ ایجاد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("CreateDate_nvc", "تاریخ ایجاد", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CreateDate_nvc", "تاریخ ایجاد", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CreateTime_nvc", "ساعت ایجاد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CreateTime_nvc", "ساعت ایجاد", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionGroupID_int", "گروه تخلف", "InfractionGroup_T", "InfractionGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueUserName_nvc", "شناسه کاربری", "User_T", "UserName_nvc"));

            Hepsa.Core.Validation.LogicalOperationRule PasswordEqualValidation = new Hepsa.Core.Validation.LogicalOperationRule("PasswordEqualValidation");
            PasswordEqualValidation.AddItem("Password_nvc", Hepsa.Core.Validation.LogicalOperationRule.enumLogicOperator.Equal, "ConfirmPassword_nvc", "کلمه عبور", "تکرار کلمه عبور", true);
            ValidationRules.AddRules(PasswordEqualValidation);
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Password_nvc", "کلمه عبور"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Password_nvc", "کلمه عبور", 100));
            Hepsa.Core.Validation.LogicalOperationRule DateLogicValidation = new Hepsa.Core.Validation.LogicalOperationRule("DateLogicValidation");
            DateLogicValidation.AddItem("StartDate_vc", Hepsa.Core.Validation.LogicalOperationRule.enumLogicOperator.LessOrEqual, "ExpireDate_vc", "تاریخ شروع اعتبار", "تاریخ پایان اعتبار", false);
            ValidationRules.AddRules(DateLogicValidation);
            ValidationRules.AddRules(new Hepsa.Core.Validation.RegularExpressionRule("Mobile_nvc", "شماره موبایل", "[0][9]\\d{9}"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MultiAccess_bit", "دسترسی چندگانه"));
        }
    }
}