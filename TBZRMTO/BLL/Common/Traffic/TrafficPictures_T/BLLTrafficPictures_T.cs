using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.TrafficPicturesBLL
{

    public partial class BLLTrafficPictures_T : BusinessObjectBase
    {

        public enum TrafficPictures_TField
        {
            TrafficID_bint
            , Picture_vbnry
        }


        private Nullable<Int64> _TrafficID_bint;
        public Nullable<Int64> TrafficID_bint
        {
            get
            {
                return _TrafficID_bint;
            }
            set
            {
                this._TrafficID_bint = value;
            }
        }


        private byte[] _Picture_vbnry;
        public byte[] Picture_vbnry
        {
            get
            {
                return _Picture_vbnry;
            }
            set
            {
                this._Picture_vbnry = value;
            }
        }



        public override void AddValidationRules()
        {
            //ValidationRules.AddRules(new HPS.Validation.NotNullRule("TrafficID_bint", "شناسه تردد"));
            //ValidationRules.AddRules(new HPS.Validation.NumericRule<Int64>("TrafficID_bint", "شناسه تردد", null, null, 0, 0));
            //ValidationRules.AddRules(new HPS.Validation.NotNullRule("Picture_vbnry", "تصویر"));
            //ValidationRules.AddRules(new HPS.Validation.StringMaxLengthRule("Picture_vbnry", "تصویر", 2147483647));
            //ValidationRules.AddRules(new HPS.Validation.UniqueRule("UniqueTrafficID_bint", "شناسه تردد", "TrafficPictures_T", "TrafficID_bint"));
            //AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}