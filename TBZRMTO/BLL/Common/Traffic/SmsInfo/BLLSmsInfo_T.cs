using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL
{

    public partial class BLLSmsInfo_T : BusinessObjectBase
    {

        public enum SmsInfo_TField
        {
            SmsInfoID_bint
            , RecivedSmsID_bint
        }


        private Nullable<Int64> _SmsInfoID_bint;
        public Nullable<Int64> SmsInfoID_bint
        {
            get
            {
                return _SmsInfoID_bint;
            }
            set
            {
                this._SmsInfoID_bint = value;
            }
        }


        private Nullable<Int64> _RecivedSmsID_bint;
        public Nullable<Int64> RecivedSmsID_bint
        {
            get
            {
                return _RecivedSmsID_bint;
            }
            set
            {
                this._RecivedSmsID_bint = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("RecivedSmsID_bint", "شماره اس ام اس"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("RecivedSmsID_bint", "شماره اس ام اس", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueSmsInfoID_bint", "شناسه اطلاعات اس ام اس", "SmsInfo_T", "SmsInfoID_bint"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}