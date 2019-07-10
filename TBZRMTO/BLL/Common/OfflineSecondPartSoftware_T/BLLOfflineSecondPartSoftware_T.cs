using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.OfflineSecondPartSoftwareBLL
{

    public partial class BLLOfflineSecondPartSoftware_T : BusinessObjectBase
    {

        public enum OfflineSecondPartSoftware_TField
        {
            OfflineSecondPartSoftwareID_int
            ,
            DisconnectDate_vc
                ,
            DisconnectTime_vc
                ,
            ConnectDate_vc
                ,
            ConnectTime_vc
                ,
            SoftwareCode_int
               ,
            SensorIsOff_bit
                 ,
            inCameraDisconnected_bit,
            outCameraDisconnected_bit
        }

        public enum SoftwareCodeField
        {
            ANPR=1
                ,
            SMSController=2
        }


        private Nullable<Int32> _OfflineSecondPartSoftwareID_int;
        public Nullable<Int32> OfflineSecondPartSoftwareID_int
        {
            get
            {
                return _OfflineSecondPartSoftwareID_int;
            }
            set
            {
                this._OfflineSecondPartSoftwareID_int = value;
            }
        }


        private String _DisconnectDate_vc;
        public String DisconnectDate_vc
        {
            get
            {
                return _DisconnectDate_vc;
            }
            set
            {
                this._DisconnectDate_vc = value;
            }
        }


        private String _DisconnectTime_vc;
        public String DisconnectTime_vc
        {
            get
            {
                return _DisconnectTime_vc;
            }
            set
            {
                this._DisconnectTime_vc = value;
            }
        }


        private String _ConnectDate_vc;
        public String ConnectDate_vc
        {
            get
            {
                return _ConnectDate_vc;
            }
            set
            {
                this._ConnectDate_vc = value;
            }
        }


        private String _ConnectTime_vc;
        public String ConnectTime_vc
        {
            get
            {
                return _ConnectTime_vc;
            }
            set
            {
                this._ConnectTime_vc = value;
            }
        }


        private Nullable<Int32> _SoftwareCode_int;
        public Nullable<Int32> SoftwareCode_int
        {
            get
            {
                return _SoftwareCode_int;
            }
            set
            {
                this._SoftwareCode_int = value;
            }
        }

        private bool _SensorIsOff_bit;
        public bool SensorIsOff_bit
        {
            get
            {
                return _SensorIsOff_bit;
            }
            set
            {
                this._SensorIsOff_bit = value;
            }
        }


        private bool _inCameraDisconnected_bit;
        public bool inCameraDisconnected_bit
        {
            get
            {
                return _inCameraDisconnected_bit;
            }
            set
            {
                this._inCameraDisconnected_bit = value;
            }
        }

        private bool _outCameraDisconnected_bit;
        public bool outCameraDisconnected_bit
        {
            get
            {
                return _outCameraDisconnected_bit;
            }
            set
            {
                this._outCameraDisconnected_bit = value;
            }
        }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DisconnectDate_vc", "تاریخ قطعی", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("DisconnectDate_vc", "تاریخ قطعی", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DisconnectTime_vc", "ساعت قطعی", 8));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("DisconnectTime_vc", "ساعت قطعی", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ConnectDate_vc", "تاریخ وصل", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("ConnectDate_vc", "تاریخ وصل", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("ConnectTime_vc", "ساعت وصل", 8));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("ConnectTime_vc", "ساعت وصل", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("SoftwareCode_int", "کد سرویس"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("SoftwareCode_int", "کد سرویس", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueOfflineSecondPartSoftwareID_int", "شناسه ", "OfflineSecondPartSoftware_T", "OfflineSecondPartSoftwareID_int"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}