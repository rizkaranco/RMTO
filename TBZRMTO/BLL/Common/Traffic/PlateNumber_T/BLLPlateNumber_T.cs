using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL
{

    public partial class BLLPlateNumber_T : BusinessObjectBase
    {

        public enum PlateNumber_TField
        {
            cameraPicturesID_bint
            ,
            plateNumber_nvc
                ,
            plateSerial_vc
                ,
            date_vc
                ,
            time_vc
                , 
            PlateColor_nvc
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


        private string _plateNumber_nvc;
        public string plateNumber_nvc
        {
            get
            {
                return _plateNumber_nvc;
            }
            set
            {
                this._plateNumber_nvc = value;
            }
        }


        private string _plateSerial_vc;
        public string plateSerial_vc
        {
            get
            {
                return _plateSerial_vc;
            }
            set
            {
                this._plateSerial_vc = value;
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


        private string _time_vc;
        public string time_vc
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



        public string PlateColor_nvc { get; set; }


        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("plateNumber_nvc", "شماره پلاک"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("plateNumber_nvc", "شماره پلاک", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("plateSerial_vc", "سری"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("plateSerial_vc", "سری", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("date_vc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("date_vc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("time_vc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("time_vc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquecameraPicturesID_bint", "شناسه تصاویر دوربین", "PlateNumber_T", "cameraPicturesID_bint"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}