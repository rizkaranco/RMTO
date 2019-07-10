using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadeAssignmentBLL
{

    public class BLLLadeAssignment_T
    : BusinessObjectBase
    {

        public enum LadeAssignment_TField
        {
            LadeAssignmentID_bint
            ,
            LadingDate_nvc
                ,
            LadingTime_nvc
                ,
            AnnouncementTimeID_int
                ,
            CityID_int
                ,
            CityCode_nvc
                ,
            Address_nvc
                ,
            GoodID_int
                ,
            BoxingID_int
                ,
            MinWeight_dec
                ,
            MaxWeight_dec
                ,
            PortageFee_dec
                ,
            PortPlaceID_int
                ,
            LaderTypeID_int
                ,
            CarCount_int
                ,
            Conditin_nvc
                ,
            CompanyID_int
                ,
            Comment_nvc
                ,
            UserName_nvc
                ,
            MacAddress_nvc
                ,
            IPAddress_nvc
                ,
            Date_nvc
                ,
            Time_nvc
                ,
            PortPlaces_nvc
                ,
            Accepted_bit
            ,
            AcceptUserName_nvc
                ,
            AcceptDate_vc
                ,
AcceptTime_vc
    ,
EditUserName_nvc 
    ,
EditDate_vc
    ,
EditTime_vc

        }


        private Int64? _LadeAssignmentID_bint;
        public Int64? LadeAssignmentID_bint
        {
            get
            {
                return _LadeAssignmentID_bint;
            }
            set
            {
                this._LadeAssignmentID_bint = value;
            }
        }


        private String _LadingDate_nvc;
        public String LadingDate_nvc
        {
            get
            {
                return _LadingDate_nvc;
            }
            set
            {
                this._LadingDate_nvc = value;
            }
        }


        private String _LadingTime_nvc;
        public String LadingTime_nvc
        {
            get
            {
                return _LadingTime_nvc;
            }
            set
            {
                this._LadingTime_nvc = value;
            }
        }


        private Int32? _AnnouncementTimeID_int;
        public Int32? AnnouncementTimeID_int
        {
            get
            {
                return _AnnouncementTimeID_int;
            }
            set
            {
                this._AnnouncementTimeID_int = value;
            }
        }


        private Int32? _CityID_int;
        public Int32? CityID_int
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


        private String _Address_nvc;
        public String Address_nvc
        {
            get
            {
                return _Address_nvc;
            }
            set
            {
                this._Address_nvc = value;
            }
        }


        private Int32? _GoodID_int;
        public Int32? GoodID_int
        {
            get
            {
                return _GoodID_int;
            }
            set
            {
                this._GoodID_int = value;
            }
        }


        private Int32? _BoxingID_int;
        public Int32? BoxingID_int
        {
            get
            {
                return _BoxingID_int;
            }
            set
            {
                this._BoxingID_int = value;
            }
        }


        private Nullable<Decimal> _MinWeight_dec;
        public Nullable<Decimal> MinWeight_dec
        {
            get
            {
                return _MinWeight_dec;
            }
            set
            {
                this._MinWeight_dec = value;
            }
        }


        private Nullable<Decimal> _MaxWeight_dec;
        public Nullable<Decimal> MaxWeight_dec
        {
            get
            {
                return _MaxWeight_dec;
            }
            set
            {
                this._MaxWeight_dec = value;
            }
        }


        private Nullable<Decimal> _PortageFee_dec;
        public Nullable<Decimal> PortageFee_dec
        {
            get
            {
                return _PortageFee_dec;
            }
            set
            {
                this._PortageFee_dec = value;
            }
        }


        private Int32? _PortPlaceID_int;
        public Int32? PortPlaceID_int
        {
            get
            {
                return _PortPlaceID_int;
            }
            set
            {
                this._PortPlaceID_int = value;
            }
        }


        private Int32? _LaderTypeID_int;
        public Int32? LaderTypeID_int
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


        private Int32? _CarCount_int;
        public Int32? CarCount_int
        {
            get
            {
                return _CarCount_int;
            }
            set
            {
                this._CarCount_int = value;
            }
        }


        private String _Conditin_nvc;
        public String Conditin_nvc
        {
            get
            {
                return _Conditin_nvc;
            }
            set
            {
                this._Conditin_nvc = value;
            }
        }


        private Int32? _CompanyID_int;
        public Int32? CompanyID_int
        {
            get
            {
                return _CompanyID_int;
            }
            set
            {
                this._CompanyID_int = value;
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

        private String _PortPlaces_nvc;
        public String PortPlaces_nvc
        {
            get
            {
                return _PortPlaces_nvc;
            }
            set
            {
                this._PortPlaces_nvc = value;
            }
        }


        private bool _Accepted_bit;
        public bool Accepted_bit
        {
            get
            {
                return _Accepted_bit;
            }
            set
            {
                this._Accepted_bit = value;
            }
        }
        /// <summary>
        /// /
        /// </summary>
        private String _AcceptUserName_nvc;
        public String AcceptUserName_nvc
        {
            get
            {
                return _AcceptUserName_nvc;
            }
            set
            {
                this._AcceptUserName_nvc = value;
            }
        }
        /// <summary>
        /// //////
        /// </summary>
        private String _AcceptDate_vc;
        public String AcceptDate_vc
        {
            get
            {
                return _AcceptDate_vc;
            }
            set
            {
                this._AcceptDate_vc = value;
            }
        }
        /// <summary>
        /// ////
        /// </summary>
        private String _AcceptTime_vc;
        public String AcceptTime_vc
        {
            get
            {
                return _AcceptTime_vc;
            }
            set
            {
                this._AcceptTime_vc = value;
            }
        }
        //
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
        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadingDate_nvc", "تاریخ بارگیری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadingDate_nvc", "تاریخ بارگیری", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("LadingDate_nvc", "تاریخ بارگیری", null, null));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("LadingDate_nvc", "تاریخ بارگیری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadingTime_nvc", "ساعت بارگیری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LadingTime_nvc", "ساعت بارگیری", 10));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("LadingTime_nvc", "ساعت بارگیری", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PortPlaces_nvc", " محل بارگیری", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("AnnouncementTimeID_int", "زمان اطلاع رسانی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("AnnouncementTimeID_int", "زمان اطلاع رسانی", "AnnouncementTime_T", "AnnouncementTimeID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CityID_int", "شهر مقصد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int", "شهر مقصد", "City_T", "CityID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CityCode_nvc", "کدشهر مقصد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CityCode_nvc", "کدشهر مقصد", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Address_nvc", "آدرس مقصد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Address_nvc", "آدرس مقصد", 300));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("GoodID_int", "کالا"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("GoodID_int", "کالا", "Good_T", "GoodID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("BoxingID_int", "نوع بسته بندی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("BoxingID_int", "نوع بسته بندی", "Boxing_T", "BoxingID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MinWeight_dec", "از وزن"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("MinWeight_dec", "از وزن", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("MaxWeight_dec", "تا وزن", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PortageFee_dec", "نرخ حمل"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("PortageFee_dec", "نرخ حمل", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PortPlaceID_int", "محل بارگیری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("PortPlacesID_int", "محل بارگیری", "PortPlaces_T", "PortPlaceID_int,PortPlacesID_int"));//
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CarCount_int", "تعداد خودرو مورد نیاز"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("CarCount_int", "تعداد خودرو مورد نیاز", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Conditin_nvc", "شرایط", 300));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CompanyID_int", "شرکت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyID_int", "شرکت", "Company_T", "CompanyID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Comment_nvc", "توضیحات", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر ثبت کننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر ثبت کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MacAddress_nvc", "آدرس Mac", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("IPAddress_nvc", "آدرس IP", 50));
            
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ "));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("Time_nvc", "ساعت", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadeAssignmentID_bint", "شناسه اطلاع رسانی بار", "LadeAssignment_T", "LadeAssignmentID_bint"));

            ValidationRules.AddRules(new HPS.validators.PriceNormRule("PriceNormRule", "نرخ حمل"));
        }
    }
}