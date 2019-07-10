using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPS.validators
{
    class DuplicateInfractionRule:Hepsa.Core.Validation.BaseRule
    {
        public DuplicateInfractionRule(string PropertyName, string FriendlyName)
            : base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[7];
            //driver
            Field[0] = "DriverFirstName_nvc";
            Field[1] = "DriverLastName_nvc";
            Field[2] = "DriverNationalCode_bint";
            //Truck
            Field[3] = "NumberPlate_nvc";
            Field[4] = "SerialPlate_nvc";
            Field[5] = "PlateCityCode_nvc";           
            //Company
            Field[6] = "CompanyID_int";

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

                string DriverFirstName_nvc = Convert.ToString(value[0]);
                string DriverLastName_nvc = Convert.ToString(value[1]);
                Int64? DriverNationalCode_bint = (Int64?)value[2];
                string NumberPlate_nvc = Convert.ToString(value[3]);
                string SerialPlate_nvc = Convert.ToString(value[4]);
                string PlateCityCode_nvc = Convert.ToString(value[5]);
                Int32? CompanyID_int = (Int32?)value[6];
               
                string InfractionCondition = string.Empty;

                if (!string.IsNullOrEmpty(DriverFirstName_nvc) && !string.IsNullOrEmpty(DriverLastName_nvc) && !string.IsNullOrEmpty(DriverNationalCode_bint.ToString()))
                {
                    InfractionCondition = string.Format(" ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.DriverFirstName_nvc='{0}' AND Infraction_T.DriverLastName_nvc='{1}' AND Infraction_T.DriverNationalCode_bint='{2}'", DriverFirstName_nvc, DriverLastName_nvc, DriverNationalCode_bint);
                }
                else if (!string.IsNullOrEmpty(NumberPlate_nvc) && !string.IsNullOrEmpty(SerialPlate_nvc) && !string.IsNullOrEmpty(PlateCityCode_nvc))
                {
                   InfractionCondition= string.Format(" ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.NumberPlate_nvc='{0}' AND Infraction_T.SerialPlate_nvc='{1}' AND Infraction_T.PlateCityCode_nvc='{2}'", NumberPlate_nvc, SerialPlate_nvc, PlateCityCode_nvc);
                }
                else
                {
                    InfractionCondition = string.Format(" ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL) AND Infraction_T.CompanyID_int={0}", CompanyID_int);
                }

                HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = new List<HPS.BLL.InfractionBLL.BLLInfraction_T>();

                InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                if (InfractionList != null && InfractionList.Count > 0)
                {
                    this.Description = Exceptions.ExceptionCs.DuplicateInfraction;
                    return false;
                }
                else
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
