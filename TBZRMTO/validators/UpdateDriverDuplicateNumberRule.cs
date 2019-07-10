using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HPS.validators
{
    class UpdateDriverDuplicateNumberRule : Hepsa.Core.Validation.BaseRule
    {
        public UpdateDriverDuplicateNumberRule(string PropertyName, string FriendlyName)
            : base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[3];
            Field[0] = "DriverMobileNumber_nvc";
            Field[1] = "NationalCode_int";
            Field[2] = "In_bit";
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
                string DriverMobileNumber_nvc = Convert.ToString(value[0]);
                Int64 DriverNationalCode_bint = Convert.ToInt64(value[1]);
                bool In_bit = Convert.ToBoolean(value[2]);

                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                List<HPS.BLL.TrafficBLL.BLLTraffic_TFactory> TrafficList = new List<HPS.BLL.TrafficBLL.BLLTraffic_TFactory>();
                DataTable DublicateNumberDataTable = new DataTable();

                if (In_bit)
                {
                    if (!string.IsNullOrEmpty(DriverMobileNumber_nvc) && !string.IsNullOrEmpty(DriverNationalCode_bint.ToString()))
                    {
                        TrafficFactory.SelectDriverDuplicateNumber(DriverMobileNumber_nvc, null, DublicateNumberDataTable);
                        if (DublicateNumberDataTable != null && DublicateNumberDataTable.Rows.Count > 0)
                        {
                            DataRow[] dr = DublicateNumberDataTable.Select(string.Format("DriverMobileNumber_nvc={0} AND NationalCode_int={1}", DriverMobileNumber_nvc, DriverNationalCode_bint));
                            if (dr.Length > 0)
                            {
                                return true;
                            }
                            else
                            {
                                DataRow[] drNotMine = DublicateNumberDataTable.Select(string.Format("DriverMobileNumber_nvc <> {0} OR NationalCode_int <> {1}", DriverMobileNumber_nvc, DriverNationalCode_bint));
                                if (drNotMine.Length > 0)
                                {
                                    this.Description = "شماره موبایل از قبل موجود می باشد";
                                    return false;
                                }
                            }
                        }
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
