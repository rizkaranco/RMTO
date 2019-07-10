using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HPS.validators
{
    class DriverInfractionRule : Hepsa.Core.Validation.BaseRule
    {
        public DriverInfractionRule(string PropertyName, string FriendlyName)
            : base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[4];
            Field[0] = "DriverCardNumber_nvc";
            Field[1] = "FirstName_nvc";
            Field[2] = "LastName_nvc";
            Field[3] = "NationalCode_int";
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
                string DriverCardNumber_nvc = Convert.ToString(value[0]);
                string DriverFirstName_nvc = Convert.ToString(value[1]);
                string DriverLastName_nvc = Convert.ToString(value[2]);
                Int64? DriverNationalCode_bint =  (Int64?)value[3];
                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = new List<HPS.BLL.InfractionBLL.BLLInfraction_T>();



                if (!string.IsNullOrEmpty(DriverCardNumber_nvc))
                {
                    HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                    List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
                    DriverList = DriverFactory.GetAllBy(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber_nvc);
                    if (DriverList != null && DriverList.Count > 0)
                    {
                        InfractionList = InfractionFactory.GetAllBy(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverID_bint, DriverList[0].DriverID_bint);
                        if (InfractionList != null && InfractionList.Count > 0)
                        {
                            this.Description = "جهت ادامه کار به مسئول کامپیوتر مراجعه کنید";
                            return false;
                        }
                    }
                }
                else
                {
                    string infractionCondition = "Infraction_T.DriverFirstName_nvc='" + DriverFirstName_nvc + "' AND Infraction_T.DriverLastName_nvc='" + DriverLastName_nvc + "' AND Infraction_T.DriverNationalCode_bint='" + DriverNationalCode_bint + "'";
                    
                   InfractionList= InfractionFactory.GetAllByCondition(infractionCondition);
                   if (InfractionList != null && InfractionList.Count > 0)
                   {
                       this.Description = "جهت ادامه کار به مسئول کامپیوتر مراجعه کنید";
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
