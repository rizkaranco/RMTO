using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPS.validators
{
    class LadeAssignmentCancelRule : Hepsa.Core.Validation.BaseRule
    {
        public LadeAssignmentCancelRule(string PropertyName, string FriendlyName)
            : base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[2];
            Field[0] = "LadeAssignmentID_bint";
            Field[1] = "Count_int";
        }

        public override bool Validate(params object[] value)
        {
            try
            {
                this.Description = string.Empty;
                if (value.Length != Field.Length)
                {
                    this.Description = Hepsa.Core.My.Resources.ValidationMessage.IncorrectDataType;
                    return false;
                }
                Int64? LadeAssignmentID_bint = (Int64?)value[0];
                int? Count_int = (int?)value[1];

                if (LadeAssignmentID_bint.HasValue == false || Count_int.HasValue == false || Count_int == 0)
                    return true;

                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                string condition = string.Format(" LadBillCredit_T.LadeAssignmentID_bint={0} AND Canceled_bit=0", LadeAssignmentID_bint);
                List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllByCondition(condition);
                int LadBillCreditCount = 0;
                if (LadBillCreditList != null && LadBillCreditList.Count > 0)
                    LadBillCreditCount = LadBillCreditList.Count;

                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKey = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                LadeAssignmentKey.LadeAssignmentID_bint = LadeAssignmentID_bint;
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKey);

                if (LadeAssignmentEntity != null)
                {
                    if (LadeAssignmentEntity.CarCount_int - LadBillCreditCount < Count_int)
                    {
                        this.Description = string.Format(Hepsa.Core.My.Resources.ValidationMessage.ValueShouldNotGreater, "تعداد ماشین حذفی", LadeAssignmentEntity.CarCount_int - LadBillCreditCount);
                        return false;
                    }
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
