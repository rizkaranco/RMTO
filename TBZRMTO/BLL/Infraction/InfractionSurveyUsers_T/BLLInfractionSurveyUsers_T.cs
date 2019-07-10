using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InfractionSurveyUsersBLL
{

    public class BLLInfractionSurveyUsers_T
    : BusinessObjectBase
    {

        public enum InfractionSurveyUsers_TField
        {
            InfractionSurveyUsersID_int
            ,
            UserName_nvc
                , InfractionSurveyGroupID_int
        }


        private Int32? _InfractionSurveyUsersID_int;
        public Int32? InfractionSurveyUsersID_int
        {
            get
            {
                return _InfractionSurveyUsersID_int;
            }
            set
            {
                this._InfractionSurveyUsersID_int = value;
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


        private Int32? _InfractionSurveyGroupID_int;
        public Int32? InfractionSurveyGroupID_int
        {
            get
            {
                return _InfractionSurveyGroupID_int;
            }
            set
            {
                this._InfractionSurveyGroupID_int = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "نام کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "نام کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionSurveyGroupID_int", "گروه برسی تخلفات"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionSurveyGroupID_int", "گروه برسی تخلفات", "InfractionSurveyGroup_T", "InfractionSurveyGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionSurveyUsersID_int", "شناسه کاربران بررسی تخلفات", "InfractionSurveyUsers_T", "InfractionSurveyUsersID_int"));
        }
    }
}