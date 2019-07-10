using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InCameraPicturesBLL
{

    public partial class BLLInCameraPictures_T : BusinessObjectBase
    {

        public enum InCameraPictures_TField
        {
            InCameraPicturesID_bint
            ,
            Date_vc
                ,
            Time_vc
                ,
            Picture_img
                ,
            PlateNumber_nvc
                ,
            PlateSerial_vc
                , TrafficTypeID_int
        }


        private Nullable<Int64> _InCameraPicturesID_bint;
        public Nullable<Int64> InCameraPicturesID_bint
        {
            get
            {
                return _InCameraPicturesID_bint;
            }
            set
            {
                this._InCameraPicturesID_bint = value;
            }
        }


        private String _Date_vc;
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


        private String _Time_vc;
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


        private Byte[] _Picture_img;
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


        private String _PlateNumber_nvc;
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


        private String _PlateSerial_vc;
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


        private Nullable<Int32> _TrafficTypeID_int;
        public Nullable<Int32> TrafficTypeID_int
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

        public override void AddValidationRules()
        {
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InCameraPicturesID_bint", "شناسه تصاویر ورودی"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("InCameraPicturesID_bint", "شناسه تصاویر ورودی", null, null, 0, 0));
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("TrafficTypeID_int", "شناسه تردد", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInCameraPicturesID_bint", "شناسه تصاویر ورودی", "InCameraPictures_T", "InCameraPicturesID_bint"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}