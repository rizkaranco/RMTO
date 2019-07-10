using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.Reports
{
   public  class LadBillReportBLL
     : BusinessObjectBase
    {

        public enum LadBillReportField
        {
            CompanyID_nvc
             ,
            CompanyCode_nvc
                ,
            Company_nvc
                ,
            DriverCardNumber_nvc
                ,
            CarCardNumber_nvc
                ,
            CityID_nvc
               ,
            CityCode_nvc
                ,
            LaderTypeID_nvc
               ,
            BoxingID_nvc
                ,
            GoodID_nvc
               ,
            TrafficTypeID_nvc
               ,
            TrafficType_nvc
                ,
            AnnouncementTimeID_nvc
                ,
            FromSerial_nvc
                 ,
            ToSerial_nvc
                 ,
            FromLadBillNumbe_int
                 ,
            ToLadBillNumber_int
                 ,
            PortPlaceID_nvc
                ,
            FromLadingDate_nvc
                ,
            ToLadingDate_nvc
                ,
            FromLadingTime_nvc
                ,
            ToLadingTime_nvc
                 ,
            FromLadBillDate_nvc
                 ,
            ToLadBillDate_nvc
                 ,
            FromLadBillTime_nvc
                  ,
            ToLadBillTime_nvc

        }

        private String _CompanyID_nvc;
        public String CompanyID_nvc
        {
            get
            {
                return _CompanyID_nvc;
            }
            set
            {
                this._CompanyID_nvc = value;
            }
        }

        private String _CompanyCode_nvc;
        public String CompanyCode_nvc
        {
            get
            {
                return _CompanyCode_nvc;
            }
            set
            {
                this._CompanyCode_nvc = value;
            }
        }

        private String _Company_nvc;
        public String Company_nvc
        {
            get
            {
                return _Company_nvc;
            }
            set
            {
                this._Company_nvc = value;
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

        private String _CityID_nvc;
        public String CityID_nvc
        {
            get
            {
                return _CityID_nvc;
            }
            set
            {
                this._CityID_nvc = value;
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


        private String _LaderTypeID_nvc;
        public String LaderTypeID_nvc
        {
            get
            {
                return _LaderTypeID_nvc;
            }
            set
            {
                this._LaderTypeID_nvc = value;
            }
        }

        private String _BoxingID_nvc;
        public String BoxingID_nvc
        {
            get
            {
                return _BoxingID_nvc;
            }
            set
            {
                this._BoxingID_nvc = value;
            }
        }

        private String _GoodID_nvc;
        public String GoodID_nvc
        {
            get
            {
                return _GoodID_nvc;
            }
            set
            {
                this._GoodID_nvc = value;
            }
        }

        private String _TrafficTypeID_nvc;
        public String TrafficTypeID_nvc
        {
            get
            {
                return _TrafficTypeID_nvc;
            }
            set
            {
                this._TrafficTypeID_nvc = value;
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

        private String _AnnouncementTimeID_nvc;
        public String AnnouncementTimeID_nvc
        {
            get
            {
                return _AnnouncementTimeID_nvc;
            }
            set
            {
                this._AnnouncementTimeID_nvc = value;
            }
        }

        private String _FromSerial_nvc;
        public String FromSerial_nvc
        {
            get
            {
                return _FromSerial_nvc;
            }
            set
            {
                this._FromSerial_nvc = value;
            }
        }

        private String _ToSerial_nvc;
        public String ToSerial_nvc
        {
            get
            {
                return _ToSerial_nvc;
            }
            set
            {
                this._ToSerial_nvc = value;
            }
        }

        private Int32? _FromLadBillNumber_int;
        public Int32? FromLadBillNumber_int
        {
            get
            {
                return _FromLadBillNumber_int;
            }
            set
            {
                this._FromLadBillNumber_int = value;
            }
        }

        private Int32? _ToLadBillNumber_int;
        public Int32? ToLadBillNumber_int
        {
            get
            {
                return _ToLadBillNumber_int;
            }
            set
            {
                this._ToLadBillNumber_int = value;
            }
        }

        private String _PortPlaceID_nvc;
        public String PortPlaceID_nvc
        {
            get
            {
                return _PortPlaceID_nvc;
            }
            set
            {
                this._PortPlaceID_nvc = value;
            }
        }

        private String _FromLadingDate_nvc;
        public String FromLadingDate_nvc
        {
            get
            {
                return _ToLadingDate_nvc;
            }
            set
            {
                this._ToLadingDate_nvc = value;
            }
        }

        private String _ToLadingDate_nvc;
        public String ToLadingDate_nvc
        {
            get
            {
                return _ToLadingDate_nvc;
            }
            set
            {
                this._ToLadingDate_nvc = value;
            }
        }

        private String _FromLadingTime_nvc;
        public String FromLadingTime_nvc
        {
            get
            {
                return _ToLadingTime_nvc;
            }
            set
            {
                this._ToLadingTime_nvc = value;
            }
        }

        private String _ToLadingTime_nvc;
        public String ToLadingTime_nvc
        {
            get
            {
                return _ToLadingTime_nvc;
            }
            set
            {
                this._ToLadingTime_nvc = value;
            }
        }

        private String _FromLadBillDate_nvc;
        public String FromLadBillDate_nvc
        {
            get
            {
                return _FromLadBillTime_nvc;
            }
            set
            {
                this._FromLadBillTime_nvc = value;
            }
        }

        private String _ToLadBillDate_nvc;
        public String ToLadBillDate_nvc
        {
            get
            {
                return _FromLadBillTime_nvc;
            }
            set
            {
                this._FromLadBillTime_nvc = value;
            }
        }

        private String _FromLadBillTime_nvc;
        public String FromLadBillTime_nvc
        {
            get
            {
                return _FromLadBillTime_nvc;
            }
            set
            {
                this._FromLadBillTime_nvc = value;
            }
        }

        private String _ToLadBillTime_nvc;
        public String ToLadBillTime_nvc
        {
            get
            {
                return _FromLadBillTime_nvc;
            }
            set
            {
                this._FromLadBillTime_nvc = value;
            }
        }


        public override void AddValidationRules()
        {
        }
    }
}
