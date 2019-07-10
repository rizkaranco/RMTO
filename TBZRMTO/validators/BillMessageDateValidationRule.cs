using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.validators
{
    class BillMessageDateValidationRule : Hepsa.Core.Validation.BaseRule
    {
        private HPS.BLL.BillMessageBLL.BLLBillMessage_T _Msg;
        public BillMessageDateValidationRule(string PropertyName, string FriendlyName)
            :base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[4];
            Field[0] = "StartDate_nvc";
            Field[1] = "EndDate_nvc";
            Field[2] = "BillMessageID_int";
            

        }

        public override bool Validate(params object[] value)
        {
            try
            {
                this.Description = string.Empty;

                string StartDate_nvc = (string)value[0];
                string EndDate_nvc = (string)value[1];
                Int32? BillMessageID_int = (Int32?)value[2];


                if (StartDate_nvc=="")
                {
                    this.Description = string.Format(Hepsa.Core.My.Resources.ValidationMessage.DataNotValid, FriendlyName);
                    return false;
                }

                if (string.Compare(StartDate_nvc, EndDate_nvc) > 0)
                {
                    this.Description = Hepsa.Core.My.Resources.ValidationMessage.DateRangeErrorEntered;
                    return false;
                }
                string Condition = string.Format("[BillMessage_T].[StartDate_nvc]<=N'{0}' And [BillMessage_T].[EndDate_nvc]>=N'{0}' And [BillMessage_T].[BillMessageID_int] <> {1}", StartDate_nvc,BillMessageID_int);
                HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory BilMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
                List<HPS.BLL.BillMessageBLL.BLLBillMessage_T> lst = BilMessageFactory.GetAllByCondition(Condition);
                if (lst != null && lst.Count > 0)
                {
                        this.Description = Hepsa.Core.My.Resources.ValidationMessage.DateRangeErrorEntered;
                        return false;
                }

                return true;
            }
            catch (System.Exception ex)
            {
                this.Description = ex.Message;
                return false;
            }
        }
    }
}
