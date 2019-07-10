using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CarBLL
{

    public class BLLCar_T
    : BusinessObjectBase
    {

        public enum Car_TField
        {
            CarID_int
            ,
            CarCardDate_nvc
                ,
            CarCardNumber_nvc
                ,
            PlateType_nvc
                ,
            NumberPlate_nvc
                ,
            SerialPlate_nvc
                ,
            PlateCityID_int
                ,
            PlateColorID_int
                ,
            CountryID_int
                ,
            CountryCode_nvc
                ,
            Country_nvc
                ,
            YearType_nvc
                ,
            ProductionYear_int
                ,
            LaderTypeID_int
                ,
            LaderTypeCode_nvc
                ,
            SystemCode_nvc
                ,
            System_nvc
                ,
            Capacity_flt
                ,
            InfractionGroupID_int
                ,
            InsertDate_nvc
                ,
            UpdateDate_nvc
                ,
            Active_bit
                , Deleted_bit
        }


        private Int32 _CarID_int;
        public Int32 CarID_int
        {
            get
            {
                return _CarID_int;
            }
            set
            {
                this._CarID_int = value;
            }
        }


        private String _CarCardDate_nvc;
        public String CarCardDate_nvc
        {
            get
            {
                return _CarCardDate_nvc;
            }
            set
            {
                this._CarCardDate_nvc = value;
            }
        }


        private String _CarCardNumber_nvc;
        public String CarCardNumber_nvc
        {
            get
            {
                return _CarCardNumber_nvc;
            }
            set
            {
                this._CarCardNumber_nvc = value;
            }
        }


        private String _PlateType_nvc;
        public String PlateType_nvc
        {
            get
            {
                return _PlateType_nvc;
            }
            set
            {
                this._PlateType_nvc = value;
            }
        }


        private String _NumberPlate_nvc;
        public String NumberPlate_nvc
        {
            get
            {
                return _NumberPlate_nvc;
            }
            set
            {
                this._NumberPlate_nvc = value;
            }
        }


        private String _SerialPlate_nvc;
        public String SerialPlate_nvc
        {
            get
            {
                return _SerialPlate_nvc;
            }
            set
            {
                this._SerialPlate_nvc = value;
            }
        }


        private Nullable<Int32> _PlateCityID_int;
        public Nullable<Int32> PlateCityID_int
        {
            get
            {
                return _PlateCityID_int;
            }
            set
            {
                this._PlateCityID_int = value;
            }
        }


        private Nullable<Int32> _PlateColorID_int;
        public Nullable<Int32> PlateColorID_int
        {
            get
            {
                return _PlateColorID_int;
            }
            set
            {
                this._PlateColorID_int = value;
            }
        }


        private Int32 _CountryID_int;
        public Int32 CountryID_int
        {
            get
            {
                return _CountryID_int;
            }
            set
            {
                this._CountryID_int = value;
            }
        }


        private String _CountryCode_nvc;
        public String CountryCode_nvc
        {
            get
            {
                return _CountryCode_nvc;
            }
            set
            {
                this._CountryCode_nvc = value;
            }
        }


        private String _Country_nvc;
        public String Country_nvc
        {
            get
            {
                return _Country_nvc;
            }
            set
            {
                this._Country_nvc = value;
            }
        }


        private String _YearType_nvc;
        public String YearType_nvc
        {
            get
            {
                return _YearType_nvc;
            }
            set
            {
                this._YearType_nvc = value;
            }
        }


        private Int32 _ProductionYear_int;
        public Int32 ProductionYear_int
        {
            get
            {
                return _ProductionYear_int;
            }
            set
            {
                this._ProductionYear_int = value;
            }
        }


        private Nullable<Int32> _LaderTypeID_int;
        public Nullable<Int32> LaderTypeID_int
        {
            get
            {
                return _LaderTypeID_int;
            }
            set
            {
                this._LaderTypeID_int = value;
            }
        }


        private String _LaderTypeCode_nvc;
        public String LaderTypeCode_nvc
        {
            get
            {
                return _LaderTypeCode_nvc;
            }
            set
            {
                this._LaderTypeCode_nvc = value;
            }
        }


        private String _SystemCode_nvc;
        public String SystemCode_nvc
        {
            get
            {
                return _SystemCode_nvc;
            }
            set
            {
                this._SystemCode_nvc = value;
            }
        }


        private String _System_nvc;
        public String System_nvc
        {
            get
            {
                return _System_nvc;
            }
            set
            {
                this._System_nvc = value;
            }
        }


        private Nullable<Double> _Capacity_flt;
        public Nullable<Double> Capacity_flt
        {
            get
            {
                return _Capacity_flt;
            }
            set
            {
                this._Capacity_flt = value;
            }
        }


        private Nullable<Int32> _InfractionGroupID_int;
        public Nullable<Int32> InfractionGroupID_int
        {
            get
            {
                return _InfractionGroupID_int;
            }
            set
            {
                this._InfractionGroupID_int = value;
            }
        }


        private String _InsertDate_nvc;
        public String InsertDate_nvc
        {
            get
            {
                return _InsertDate_nvc;
            }
            set
            {
                this._InsertDate_nvc = value;
            }
        }


        private String _UpdateDate_nvc;
        public String UpdateDate_nvc
        {
            get
            {
                return _UpdateDate_nvc;
            }
            set
            {
                this._UpdateDate_nvc = value;
            }
        }


        private bool _Active_bit;
        public bool Active_bit
        {
            get
            {
                return _Active_bit;
            }
            set
            {
                this._Active_bit = value;
            }
        }


        private bool _Deleted_bit;
        public bool Deleted_bit
        {
            get
            {
                return _Deleted_bit;
            }
            set
            {
                this._Deleted_bit = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CarCardDate_nvc", "تاریخ صدور کارت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CarCardDate_nvc", "تاریخ صدور کارت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CarCardNumber_nvc", "شماره کارت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CarCardNumber_nvc", "شماره کارت", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PlateType_nvc", "نوع پلاک"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateType_nvc", "نوع پلاک", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("NumberPlate_nvc", "شماره پلاک"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("NumberPlate_nvc", "شماره پلاک", 15));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SerialPlate_nvc", "سری پلاک", 3));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("PlateCityID_int", "محل شماره گذاری", "PlateCity_T", "PlateCityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("ColorID_int", "رنگ پلاک", "Color_T", "ColorID_int"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CountryID_int", "کشور سازنده"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CountryID_int", "کشور سازنده", "Country_T", "CountryID_int"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CountryCode_nvc", "کد کشور"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CountryCode_nvc", "کد کشور", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Country_nvc", "نام کشور سازنده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Country_nvc", "نام کشور سازنده", 50));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("YearType_nvc", "نوع سال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("YearType_nvc", "نوع سال", 50));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ProductionYear_int", "سال ساخت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("ProductionYear_int", "سال ساخت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LaderTypeID_int", " نوع بارگیر", "LaderType_T", "LaderTypeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LaderTypeCode_nvc", "کد نوع بارگیر", 30));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SystemCode_nvc", "کد سیستم", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("System_nvc", "نام سیستم", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Double>("Capacity_flt", "ظرفیت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("InfractionGroupID_int", "گروه تخلف", "InfractionGroup_T", "InfractionGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InsertDate_nvc", "تاريخ ورود اطلاعات", 12));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UpdateDate_nvc", "تاريخ تغيير اطلاعات", 12));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Deleted_bit", "حذف شده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueCarID_int", "شناسه خودرو", "Car_T", "CarID_int"));
        }
    }
}