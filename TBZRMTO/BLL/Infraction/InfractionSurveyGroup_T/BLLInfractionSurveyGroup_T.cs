using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InfractionSurveyGroupBLL
{

    public class BLLInfractionSurveyGroup_T
    : BusinessObjectBase
    {

        public enum InfractionSurveyGroup_TField
        {
            InfractionSurveyGroupID_int
            , InfractionSurveyGroup_nvc
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


        private String _InfractionSurveyGroup_nvc;
        public String InfractionSurveyGroup_nvc
        {
            get
            {
                return _InfractionSurveyGroup_nvc;
            }
            set
            {
                this._InfractionSurveyGroup_nvc = value;
            }
        }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionSurveyGroup_nvc", "نام گروه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InfractionSurveyGroup_nvc", "نام گروه", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionSurveyGroupID_int", "شناسه گروه بررسی تخلفات", "InfractionSurveyGroup_T", "InfractionSurveyGroupID_int"));
        }

        

    }
}