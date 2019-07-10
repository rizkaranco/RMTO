using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL
{

    public partial class BLLInOut_T : BusinessObjectBase
    {

        public enum InOut_TField
        {
            inOutID_bint
            ,
            cameraPicturesID_bint
                ,
            date_vc
                ,
            time_vc
                , gate_tint
        }

        public enum  gateNumber
        {
            in_tint = 1,
            out_tint = 2
        }

        private Nullable<Int64> _inOutID_bint;
        public Nullable<Int64> inOutID_bint
        {
            get
            {
                return _inOutID_bint;
            }
            set
            {
                this._inOutID_bint = value;
            }
        }


        private Nullable<Int64> _cameraPicturesID_bint;
        public Nullable<Int64> cameraPicturesID_bint
        {
            get
            {
                return _cameraPicturesID_bint;
            }
            set
            {
                this._cameraPicturesID_bint = value;
            }
        }


        private string _date_vc;
        public string date_vc
        {
            get
            {
                return _date_vc;
            }
            set
            {
                this._date_vc = value;
            }
        }


        private String _time_vc;
        public String time_vc
        {
            get
            {
                return _time_vc;
            }
            set
            {
                this._time_vc = value;
            }
        }


        private Nullable<Byte> _gate_tint;
        public Nullable<Byte> gate_tint
        {
            get
            {
                return _gate_tint;
            }
            set
            {
                this._gate_tint = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("cameraPicturesID_bint", "شناسه تصویر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("cameraPicturesID_bint", "شناسه تصویر", "PlateNumber_T", "cameraPicturesID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("date_vc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("date_vc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("time_vc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("time_vc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("gate_tint", "شماره گیت[از برنامه به تعداد گیت ها زیاد می شود]"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Byte>("gate_tint", "شماره گیت[از برنامه به تعداد گیت ها زیاد می شود]", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueinOutID_bint", "شناسه ورود خروج", "InOut_T", "inOutID_bint"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}