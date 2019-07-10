using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.TrafficTypeBLL
{

    public class BLLTrafficType_T
    : BusinessObjectBase
    {

        public enum TrafficType
        {
            LadBillCredit=9
        }
        public enum TrafficType_TField
        {
            TrafficTypeID_int
            , TrafficType_nvc
        }


        private Int32? _TrafficTypeID_int;
        public Int32? TrafficTypeID_int
        {
            get
            {
                return _TrafficTypeID_int;
            }
            set
            {
                this._TrafficTypeID_int = value;
            }
        }


        private String _TrafficType_nvc;
        public String TrafficType_nvc
        {
            get
            {
                return _TrafficType_nvc;
            }
            set
            {
                this._TrafficType_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TrafficType_nvc", "نوع تردد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueTrafficType_nvc", "نوع تردد", "TrafficType_T", "TrafficType_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("TrafficType_nvc", "نوع تردد", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueTrafficTypeID_int", "شناسه نوع تردد", "TrafficType_T", "TrafficTypeID_int"));
        }
    }
}