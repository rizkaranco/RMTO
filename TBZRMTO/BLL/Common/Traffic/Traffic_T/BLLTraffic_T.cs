using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.TrafficBLL
{

    public class BLLTraffic_T
    : BusinessObjectBase
    {

        public enum Traffic_TField
        {
            TrafficID_bint
            ,
            TurnHour_int
                ,
            TrafficNumber_bint
                ,
            TurnNumber_bint
                ,
            DriverID_bint
                ,
            DriverCardDate_nvc
                ,
            DriverCardNumber_nvc
                ,
            DriverType_nvc
                ,
            FirstName_nvc
                ,
            LastName_nvc
                ,
            InsuranceNumber_nvc
                ,
            CityID_int
                ,
            CityCode_nvc
                ,
            licenceNumber_int
                ,
            LicenceCityID_int
                ,
            LicenceType_nvc
                ,
            LiceniceDate_nvc
                ,
            ActivityScope_nvc
                ,
            NationalCode_int
                ,
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
            UserName_nvc
                ,
            StopFeeID_int
                ,
            AllowableHour_int
                ,
            ExtraHour_int
                ,
            ExtraHourFee_dec
                ,
            Fee_dec
                ,
            ComputerID_int
                ,
            Computer_nvc
                ,
            IPAddress_nvc
                ,
            MacAddress_nvc
                ,
            TrafficTypeID_int
                ,
            Date_nvc
                ,
            Time_nvc
                ,
            WithFlat_bit
                ,
            NationalityCountryID_int
                ,
            OriginCountryID_int
                ,
            DestinationCountryID_int
                ,
            EntranceBoundaryID_int
                ,
            In_bit
                ,
            Out_bit
                ,
            BillMessageID_int
                ,
            Price_dec
                ,
            Hourse_bit
                ,
            Comment_nvc
                ,
            ServiceID_int
                ,
            WithLade_bit
                ,
            Printed_bit
                ,
            TemporaryOut_bit
                ,
            AcceptedTurnNumber_bint
                ,
            AcceptedTurnComment_nvc
                ,
            TurnDate_nvc
                ,
            TurnTime_nvc
                ,
            TurnUser_nvc
                ,
            TurnAccepted_bit
                ,
            CarCardRead_bit
                ,
            DriverCardRead_bit
                , 
            TurnPrinted_bit
                ,
            Service_nvc
                ,
            DriverMobileNumber_nvc
                ,
            Area_bit
            ,
            DriverOffline_bit
                ,
            CarOffline_bit
            ,
            CameraPlateNumber_nvc
            ,
            CameraSerialPlate_int
              ,
            EditUserName_nvc 
                ,
              EditDate_vc
                  ,
              EditTime_vc,
              PriceTax_dec
            , LadeReturn_bit

        }

        public enum TrafficStatus
        {
            In = 1,
            TemporaryOut = 2,
            Out = 3,
            Unknown = 4,
            WithoutTraffic = 5
        }

        private Int64 _TrafficID_bint;
        public Int64 TrafficID_bint
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


        private Nullable<Int32> _TurnHour_int;
        public Nullable<Int32> TurnHour_int
        {
            get
            {
                return _TurnHour_int;
            }
            set
            {
                this._TurnHour_int = value;
            }
        }


        private Int64 _TrafficNumber_bint;
        public Int64 TrafficNumber_bint
        {
            get
            {
                return _TrafficNumber_bint;
            }
            set
            {
                this._TrafficNumber_bint = value;
            }
        }


        private Nullable<Int64> _TurnNumber_bint;
        public Nullable<Int64> TurnNumber_bint
        {
            get
            {
                return _TurnNumber_bint;
            }
            set
            {
                this._TurnNumber_bint = value;
            }
        }


        private Nullable<Int64> _DriverID_bint;
        public Nullable<Int64> DriverID_bint
        {
            get
            {
                return _DriverID_bint;
            }
            set
            {
                this._DriverID_bint = value;
            }
        }


        private String _DriverCardDate_nvc;
        public String DriverCardDate_nvc
        {
            get
            {
                return _DriverCardDate_nvc;
            }
            set
            {
                this._DriverCardDate_nvc = value;
            }
        }


        private String _DriverCardNumber_nvc;
        public String DriverCardNumber_nvc
        {
            get
            {
                return _DriverCardNumber_nvc;
            }
            set
            {
                this._DriverCardNumber_nvc = value;
            }
        }


        private String _DriverType_nvc;
        public String DriverType_nvc
        {
            get
            {
                return _DriverType_nvc;
            }
            set
            {
                this._DriverType_nvc = value;
            }
        }


        private String _FirstName_nvc;
        public String FirstName_nvc
        {
            get
            {
                return _FirstName_nvc;
            }
            set
            {
                this._FirstName_nvc = value;
            }
        }


        private String _LastName_nvc;
        public String LastName_nvc
        {
            get
            {
                return _LastName_nvc;
            }
            set
            {
                this._LastName_nvc = value;
            }
        }


        private String _InsuranceNumber_nvc;
        public String InsuranceNumber_nvc
        {
            get
            {
                return _InsuranceNumber_nvc;
            }
            set
            {
                this._InsuranceNumber_nvc = value;
            }
        }


        private Nullable<Int32> _CityID_int;
        public Nullable<Int32> CityID_int
        {
            get
            {
                return _CityID_int;
            }
            set
            {
                this._CityID_int = value;
            }
        }


        private String _CityCode_nvc;
        public String CityCode_nvc
        {
            get
            {
                return _CityCode_nvc;
            }
            set
            {
                this._CityCode_nvc = value;
            }
        }


        private Nullable<Int64> _licenceNumber_int;
        public Nullable<Int64> licenceNumber_int
        {
            get
            {
                return _licenceNumber_int;
            }
            set
            {
                this._licenceNumber_int = value;
            }
        }


        private Nullable<Int32> _LicenceCityID_int;
        public Nullable<Int32> LicenceCityID_int
        {
            get
            {
                return _LicenceCityID_int;
            }
            set
            {
                this._LicenceCityID_int = value;
            }
        }


        private String _LicenceType_nvc;
        public String LicenceType_nvc
        {
            get
            {
                return _LicenceType_nvc;
            }
            set
            {
                this._LicenceType_nvc = value;
            }
        }


        private String _LiceniceDate_nvc;
        public String LiceniceDate_nvc
        {
            get
            {
                return _LiceniceDate_nvc;
            }
            set
            {
                this._LiceniceDate_nvc = value;
            }
        }


        private String _ActivityScope_nvc;
        public String ActivityScope_nvc
        {
            get
            {
                return _ActivityScope_nvc;
            }
            set
            {
                this._ActivityScope_nvc = value;
            }
        }


        private Nullable<Int64> _NationalCode_int;
        public Nullable<Int64> NationalCode_int
        {
            get
            {
                return _NationalCode_int;
            }
            set
            {
                this._NationalCode_int = value;
            }
        }


        private Nullable<Int32> _CarID_int;
        public Nullable<Int32> CarID_int
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


        private Nullable<Int32> _CountryID_int;
        public Nullable<Int32> CountryID_int
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


        private Nullable<Int32> _ProductionYear_int;
        public Nullable<Int32> ProductionYear_int
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


        private String _UserName_nvc;
        public String UserName_nvc
        {
            get
            {
                return _UserName_nvc;
            }
            set
            {
                this._UserName_nvc = value;
            }
        }


        private Int32 _StopFeeID_int;
        public Int32 StopFeeID_int
        {
            get
            {
                return _StopFeeID_int;
            }
            set
            {
                this._StopFeeID_int = value;
            }
        }


        private Int32 _AllowableHour_int;
        public Int32 AllowableHour_int
        {
            get
            {
                return _AllowableHour_int;
            }
            set
            {
                this._AllowableHour_int = value;
            }
        }


        private Int32 _ExtraHour_int;
        public Int32 ExtraHour_int
        {
            get
            {
                return _ExtraHour_int;
            }
            set
            {
                this._ExtraHour_int = value;
            }
        }


        private Decimal _ExtraHourFee_dec;
        public Decimal ExtraHourFee_dec
        {
            get
            {
                return _ExtraHourFee_dec;
            }
            set
            {
                this._ExtraHourFee_dec = value;
            }
        }


        private Decimal _Fee_dec;
        public Decimal Fee_dec
        {
            get
            {
                return _Fee_dec;
            }
            set
            {
                this._Fee_dec = value;
            }
        }


        private Int32 _ComputerID_int;
        public Int32 ComputerID_int
        {
            get
            {
                return _ComputerID_int;
            }
            set
            {
                this._ComputerID_int = value;
            }
        }


        private String _Computer_nvc;
        public String Computer_nvc
        {
            get
            {
                return _Computer_nvc;
            }
            set
            {
                this._Computer_nvc = value;
            }
        }


        private String _IPAddress_nvc;
        public String IPAddress_nvc
        {
            get
            {
                return _IPAddress_nvc;
            }
            set
            {
                this._IPAddress_nvc = value;
            }
        }


        private String _MacAddress_nvc;
        public String MacAddress_nvc
        {
            get
            {
                return _MacAddress_nvc;
            }
            set
            {
                this._MacAddress_nvc = value;
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


        private String _Date_nvc;
        public String Date_nvc
        {
            get
            {
                return _Date_nvc;
            }
            set
            {
                this._Date_nvc = value;
            }
        }


        private String _Time_nvc;
        public String Time_nvc
        {
            get
            {
                return _Time_nvc;
            }
            set
            {
                this._Time_nvc = value;
            }
        }


        private bool _WithFlat_bit;
        public bool WithFlat_bit
        {
            get
            {
                return _WithFlat_bit;
            }
            set
            {
                this._WithFlat_bit = value;
            }
        }


        private Nullable<Int32> _NationalityCountryID_int;
        public Nullable<Int32> NationalityCountryID_int
        {
            get
            {
                return _NationalityCountryID_int;
            }
            set
            {
                this._NationalityCountryID_int = value;
            }
        }


        private Nullable<Int32> _OriginCountryID_int;
        public Nullable<Int32> OriginCountryID_int
        {
            get
            {
                return _OriginCountryID_int;
            }
            set
            {
                this._OriginCountryID_int = value;
            }
        }


        private Nullable<Int32> _DestinationCountryID_int;
        public Nullable<Int32> DestinationCountryID_int
        {
            get
            {
                return _DestinationCountryID_int;
            }
            set
            {
                this._DestinationCountryID_int = value;
            }
        }


        private Nullable<Int32> _EntranceBoundaryID_int;
        public Nullable<Int32> EntranceBoundaryID_int
        {
            get
            {
                return _EntranceBoundaryID_int;
            }
            set
            {
                this._EntranceBoundaryID_int = value;
            }
        }


        private bool _In_bit;
        public bool In_bit
        {
            get
            {
                return _In_bit;
            }
            set
            {
                this._In_bit = value;
            }
        }


        private bool _Out_bit;
        public bool Out_bit
        {
            get
            {
                return _Out_bit;
            }
            set
            {
                this._Out_bit = value;
            }
        }


        private Nullable<Int32> _BillMessageID_int;
        public Nullable<Int32> BillMessageID_int
        {
            get
            {
                return _BillMessageID_int;
            }
            set
            {
                this._BillMessageID_int = value;
            }
        }


        private Nullable<Decimal> _Price_dec;
        public Nullable<Decimal> Price_dec
        {
            get
            {
                return _Price_dec;
            }
            set
            {
                this._Price_dec = value;
            }
        }


        private bool _Hourse_bit;
        public bool Hourse_bit
        {
            get
            {
                return _Hourse_bit;
            }
            set
            {
                this._Hourse_bit = value;
            }
        }


        private String _Comment_nvc;
        public String Comment_nvc
        {
            get
            {
                return _Comment_nvc;
            }
            set
            {
                this._Comment_nvc = value;
            }
        }


        private Int32? _ServiceID_int;
        public Int32? ServiceID_int
        {
            get
            {
                return _ServiceID_int;
            }
            set
            {
                this._ServiceID_int = value;
            }
        }


        private bool _WithLade_bit;
        public bool WithLade_bit
        {
            get
            {
                return _WithLade_bit;
            }
            set
            {
                this._WithLade_bit = value;
            }
        }


        private bool _Printed_bit;
        public bool Printed_bit
        {
            get
            {
                return _Printed_bit;
            }
            set
            {
                this._Printed_bit = value;
            }
        }


        private bool _TemporaryOut_bit;
        public bool TemporaryOut_bit
        {
            get
            {
                return _TemporaryOut_bit;
            }
            set
            {
                this._TemporaryOut_bit = value;
            }
        }


        private Nullable<Int64> _AcceptedTurnNumber_bint;
        public Nullable<Int64> AcceptedTurnNumber_bint
        {
            get
            {
                return _AcceptedTurnNumber_bint;
            }
            set
            {
                this._AcceptedTurnNumber_bint = value;
            }
        }


        private String _AcceptedTurnComment_nvc;
        public String AcceptedTurnComment_nvc
        {
            get
            {
                return _AcceptedTurnComment_nvc;
            }
            set
            {
                this._AcceptedTurnComment_nvc = value;
            }
        }


        private String _TurnDate_nvc;
        public String TurnDate_nvc
        {
            get
            {
                return _TurnDate_nvc;
            }
            set
            {
                this._TurnDate_nvc = value;
            }
        }


        private String _TurnTime_nvc;
        public String TurnTime_nvc
        {
            get
            {
                return _TurnTime_nvc;
            }
            set
            {
                this._TurnTime_nvc = value;
            }
        }


        private String _TurnUser_nvc;
        public String TurnUser_nvc
        {
            get
            {
                return _TurnUser_nvc;
            }
            set
            {
                this._TurnUser_nvc = value;
            }
        }


        private Nullable<bool> _TurnAccepted_bit;
        public Nullable<bool> TurnAccepted_bit
        {
            get
            {
                return _TurnAccepted_bit;
            }
            set
            {
                this._TurnAccepted_bit = value;
            }
        }


        private bool _CarCardRead_bit;
        public bool CarCardRead_bit
        {
            get
            {
                return _CarCardRead_bit;
            }
            set
            {
                this._CarCardRead_bit = value;
            }
        }


        private bool _DriverCardRead_bit;
        public bool DriverCardRead_bit
        {
            get
            {
                return _DriverCardRead_bit;
            }
            set
            {
                this._DriverCardRead_bit = value;
            }
        }


        private bool _TurnPrinted_bit;
        public bool TurnPrinted_bit
        {
            get
            {
                return _TurnPrinted_bit;
            }
            set
            {
                this._TurnPrinted_bit = value;
            }
        }

        private String _Services_nvc;
        public String Services_nvc
        {
            get
            {
                return _Services_nvc;
            }
            set
            {
                this._Services_nvc = value;
            }
        }
        private String _DriverMobileNumber_nvc;
        public String DriverMobileNumber_nvc
        {
            get
            {
                return _DriverMobileNumber_nvc;
            }
            set 
            {
                this._DriverMobileNumber_nvc=value ;
            }
        }

        private Boolean _Area_bit;
        public Boolean Area_bit
        {
            get
            {
                return _Area_bit ;
            }
            set
        {
            this._Area_bit =value;
        }
        }

        private Boolean _DriverOffline_bit;
        public Boolean DriverOffline_bit
        {
            get
            {
                return _DriverOffline_bit;
            }
            set
            {
                this._DriverOffline_bit = value;
            }
        }

        private Boolean _CarOffline_bit;
        public Boolean CarOffline_bit
        {
            get
            {
                return _CarOffline_bit;
            }
            set
            {
                this._CarOffline_bit = value;
            }
        }

        private String _CameraPlateNumber_nvc;
        public String CameraPlateNumber_nvc
        {
            get
            {
                return _CameraPlateNumber_nvc;
            }
            set
            {
                this._CameraPlateNumber_nvc = value;
            }
        }


        private Int32? _CameraSerialPlate_int;
        public Int32? CameraSerialPlate_int
        {
            get
            {
                return _CameraSerialPlate_int;
            }
            set
            {
                this._CameraSerialPlate_int = value;
            }
        }

        private String _EditUserName_nvc;
        public String EditUserName_nvc
        {
            get
            {
                return _EditUserName_nvc;
            }
            set
            {
                this._EditUserName_nvc = value;
            }
        }
        private String _EditDate_vc;
        public String EditDate_vc
        {
            get
            {
                return _EditDate_vc;
            }
            set
            {
                this._EditDate_vc = value;
            }
        }


        private String _EditTime_vc;
        public String EditTime_vc
        {
            get
            {
                return _EditTime_vc;
            }
            set
            {
                this._EditTime_vc = value;
            }
        }

        private Nullable<Decimal> _PriceTax_dec;
        public Nullable<Decimal> PriceTax_dec
        {
            get
            {
                return _PriceTax_dec;
            }
            set
            {
                this._PriceTax_dec = value;
            }
        }
        private Boolean? _LadeReturn_bit;
        public Boolean? LadeReturn_bit
        {
            get
            {
                return _LadeReturn_bit;
            }
            set
            {
                this._LadeReturn_bit = value;
            }
        }
        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("TurnHour_int", "مدت مجاز نوبت", null, null, 0, 0));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TrafficNumber_bint", "شماره پارکینگ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumber_bint", "شماره پارکینگ", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("TurnNumber_bint", "شماره نوبت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("DriverID_bint", "راننده", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardDate_nvc", "تاریخ صدور کارت راننده", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverCardNumber_nvc", "شماره کارت راننده", 7));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMinLengthRule("DriverCardNumber_nvc", "شماره کارت راننده", 7));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DriverType_nvc", "نوع راننده", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FirstName_nvc", "نام", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LastName_nvc", "نام خانوادگی", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InsuranceNumber_nvc", "شماره بیمه", 15));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int", "شهر محل سکونت", "City_T", "CityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CityCode_nvc", "کد شهر محل سکونت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("licenceNumber_int", "شماره گواهینامه", null, null, 0, 0));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int", "محل صدور گواهینامه", "City_T", "CityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LicenceType_nvc", "نوع گواهینامه", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LiceniceDate_nvc", "تاریخ صدور گواهینامه", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ActivityScope_nvc", "حوزه فعالیت", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("NationalCode_int", "کد ملی", null, null, 0, 0));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CarID_int", "خودرو", "Car_T", "CarID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CarCardDate_nvc", "تاریخ صدور کارت ماشین", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CarCardNumber_nvc", "شماره کارت ماشین", 7));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMinLengthRule("CarCardNumber_nvc", "شماره کارت ماشین", 7));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateType_nvc", "نوع پلاک", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("NumberPlate_nvc", "شماره پلاک"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("NumberPlate_nvc", "شماره پلاک", 15));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SerialPlate_nvc", "سری پلاک", 3));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("PlateCityID_int", "محل شماره گذاری", "PlateCity_T", "PlateCityID_int"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("ColorID_int", "رنگ پلاک", "Color_T", "ColorID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CountryID_int", "کشور سازنده", "Country_T", "CountryID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CountryCode_nvc", "کد کشور", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Country_nvc", "نام کشور سازنده", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("YearType_nvc", "نوع سال", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("ProductionYear_int", "سال ساخت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LaderTypeID_int", " نوع بارگیر", "LaderType_T", "LaderTypeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LaderTypeCode_nvc", "کد نوع بارگیر", 30));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("SystemCode_nvc", "نوع وسیله", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("System_nvc", "نوع وسیله"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("System_nvc", "نوع وسیله", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Double>("Capacity_flt", "ظرفیت", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "نام کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "نام کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "نام کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("StopFeeID_int", "هزینه ماندن در پارکینگ "));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("StopFeeID_int", "هزینه ماندن در پارکینگ ", "StopFee_T", "StopFeeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("AllowableHour_int", "ساعت مجاز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("AllowableHour_int", "ساعت مجاز", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ExtraHour_int", "ساعت اضافی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("ExtraHour_int", "ساعت اضافی", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ExtraHourFee_dec", "هزینه ساعات اضافی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("ExtraHourFee_dec", "هزینه ساعات اضافی", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Fee_dec", "مبلغ پارکینگ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("Fee_dec", "مبلغ پارکینگ", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ComputerID_int", "رایانه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("ComputerID_int", "رایانه", "Computer_T", "ComputerID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Computer_nvc", "نام رایانه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Computer_nvc", "نام رایانه", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("IPAddress_nvc", "آدرس IP"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("IPAddress_nvc", "آدرس IP", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MacAddress_nvc", "آدرس Mac"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MacAddress_nvc", "آدرس Mac", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("TrafficTypeID_int", " نوع تردد", "TrafficType_T", "TrafficTypeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ "));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("WithFlat_bit", "کفی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CountryID_int", "تابع کشور", "Country_T", "CountryID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CountryID_int", "کشور مبدأ", "Country_T", "CountryID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CountryID_int", "کشور مقصد", "Country_T", "CountryID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("BoundryID_int", "مرز ورودی", "Boundry_T", "BoundryID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("In_bit", "ورود"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Out_bit", "خروج"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("BillMessageID_int", "پیام قبض", "BillMessage_T", "BillMessageID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("Price_dec", "هزینه دریافتی", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Hourse_bit", "اسبی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Comment_nvc", "توضیحات", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("ServiceID_int", "مراجعه به"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("ServicesID_int", "مراجعه به", "Services_T", "ServicesID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("WithLade_bit", "با بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Printed_bit", "چاپ مجدد قبض"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TemporaryOut_bit", "خروج موقت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int64>("AcceptedTurnNumber_bint", "شماره نوبت تأیید شده", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("AcceptedTurnComment_nvc", "توضیحات تأیید نویت", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("TurnDate_nvc", "تاریخ تأیید نوبت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("TurnTime_nvc", "ساعت تأیید نوبت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("TurnUser_nvc", "کاربر تأیید نوبت", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر تأیید نوبت", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CarCardRead_bit", "استفاده از کارت خوان کامیون"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("DriverCardRead_bit", "استفاده از کارت خوان راننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TurnPrinted_bit", "چاپ مجدد نوبت تأیید شده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueTrafficID_bint", "شناسه تردد", "Traffic_T", "TrafficID_bint"));
            ValidationRules.AddRules(new HPS.validators.DriverInfractionRule("DriverInfractionRule", "DriverInfractionRule"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RegularExpressionRule("DriverMobileNumber_nvc", "شماره موبایل", "[0][9]\\d{9}"));
            //ValidationRules.AddRules(new HPS.validators.UpdateDriverDuplicateNumberRule("UpdateDriverDuplicateNumberRule", "DriverDuplicateNumberRule"));
            //ValidationRules.AddRules(new HPS.validators.InsertDriverDuplicateNumberRule("InsertDriverDuplicateNumberRule", "DriverDuplicateNumberRule"));
            ValidationRules.AddRules(new HPS.validators.DuplicateTurnNumberInUpdateRule("DuplicateTurnNumberInUpdateRule", "DuplicateTurnNumberInUpdateRule"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("PriceTax_dec", "هزینه ارزش افزوده", null, null, 0, 0));
       
        }
    }
}