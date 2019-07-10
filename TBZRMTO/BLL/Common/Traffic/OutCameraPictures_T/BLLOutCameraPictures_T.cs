using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.OutCameraPicturesBLL
{

    public partial class BLLOutCameraPictures_T : BusinessObjectBase
    {

        public enum OutCameraPictures_TField
        {
            OutCameraPicturesID_bint,
            Date_vc,
            Time_vc,
            Picture_img,
            PlateNumber_nvc,
            PlateSerial_vc,
            TrafficID_bint
        }

        private Nullable<Int64> _OutCameraPicturesID_bint;
        private String _Date_vc;
        private String _Time_vc;
        private Byte[] _Picture_img;
        private String _PlateNumber_nvc;
        private String _PlateSerial_vc;
        private Nullable<Int64> _TrafficID_bint;


        public Nullable<Int64> OutCameraPicturesID_bint
        {
            get
            {
                return _OutCameraPicturesID_bint;
            }
            set
            {
                this._OutCameraPicturesID_bint = value;
            }
        }
        public String Date_vc
        {
            get
            {
                return _Date_vc;
            }
            set
            {
                this._Date_vc = value;
            }
        }

        public String Time_vc
        {
            get
            {
                return _Time_vc;
            }
            set
            {
                this._Time_vc = value;
            }
        }

        public Byte[] Picture_img
        {
            get
            {
                return _Picture_img;
            }
            set
            {
                this._Picture_img = value;
            }
        }

        public String PlateNumber_nvc
        {
            get
            {
                return _PlateNumber_nvc;
            }
            set
            {
                this._PlateNumber_nvc = value;
            }
        }

        public String PlateSerial_vc
        {
            get
            {
                return _PlateSerial_vc;
            }
            set
            {
                this._PlateSerial_vc = value;
            }
        }

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

        public override void AddValidationRules()
        {
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("OutCameraPicturesID_bint", "شناسه تصاویر دوربین خروجی"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("OutCameraPicturesID_bint", "شناسه تصاویر دوربین خروجی", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_vc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_vc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_vc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_vc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Picture_img", "تصویر"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Picture_img", "تصویر", 2147483647));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PlateNumber_nvc", "شماره پلاک"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateNumber_nvc", "شماره پلاک", 8));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PlateSerial_vc", "سری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateSerial_vc", "سری", 2));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("TrafficID_bint", "شناسه تردد", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueOutCameraPicturesID_bint", "شناسه تصاویر دوربین خروجی", "OutCameraPictures_T", "OutCameraPicturesID_bint"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}