using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HPS.validators
{
    class PriceNormRule : Hepsa.Core.Validation.BaseRule
    {
        public PriceNormRule(string PropertyName, string FriendlyName)
            : base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[5];
            Field[0] = "CityID_int";
            Field[1] = "GoodID_int";
            Field[2] = "LaderTypeID_int";
            Field[3] = "PortageFee_dec";
            Field[4] = "OriginCityID_int";
        }

        public override bool Validate(params object[] value)
        {
            try
            {
                this.Description = string.Empty;

                int? CityID_int = (int?)value[0];
                int? GoodID_int = (int?)value[1];
                int? LaderTypeID_int = (int?)value[2];
                decimal? PortageFee_dec = (decimal?)value[3];
                int? OriginCityID_int = (int?)value[4];

                if (!CityID_int.HasValue || !GoodID_int.HasValue || !LaderTypeID_int.HasValue || !PortageFee_dec.HasValue)
                {
                    this.Description = string.Format(Hepsa.Core.My.Resources.ValidationMessage.DataNotValid, FriendlyName);
                    return false;
                }

                string Condition = string.Format("[PriceNorm_T].[CityID_int]={0} And [PriceNorm_T].[LaderTypeID_int]={1} And [PriceNorm_T].[GoodID_int]={2} ", CityID_int, LaderTypeID_int, GoodID_int);//AND [PriceNorm_T].[OriginCityID_int]='{3}',OriginCityID_int

                HPS.BLL.PriceNormBLL.BLLPriceNorm_TFactory PriceNormFactory = new HPS.BLL.PriceNormBLL.BLLPriceNorm_TFactory();
                List<HPS.BLL.PriceNormBLL.BLLPriceNorm_T> lst = PriceNormFactory.GetAllByCondition(Condition);
                if (lst != null && lst.Count > 0)
                {
                    if (PortageFee_dec < lst[0].Price_dec)
                    {
                        this.Description = string.Format(Hepsa.Core.My.Resources.ValidationMessage.ValueIsNotEquelWithPriceNorm,string.Format(PortageFee_dec.ToString(),"N0"),string.Format(lst[0].Price_dec.ToString(),"N0"));
                        return false;
                    }
                }
                else
                {
                    this.Description = string.Format(Hepsa.Core.My.Resources.ValidationMessage.RelationError, "نرخ عرف کشوری");
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
