using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.AnnouncementTimeBLL
{

    public class BLLAnnouncementTime_T
    : BusinessObjectBase
    {

        public enum AnnouncementTime_TField
        {
            AnnouncementTimeID_int
            ,
            AnnouncementTime_nvc
                ,
            StartTime_nvc
                , EndTime_nvc
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


        private String _AnnouncementTime_nvc;
        public String AnnouncementTime_nvc
        {
            get
            {
                return _AnnouncementTime_nvc;
            }
            set
            {
                this._AnnouncementTime_nvc = value;
            }
        }


        private String _StartTime_nvc;
        public String StartTime_nvc
        {
            get
            {
                return _StartTime_nvc;
            }
            set
            {
                this._StartTime_nvc = value;
            }
        }


        private String _EndTime_nvc;
        public String EndTime_nvc
        {
            get
            {
                return _EndTime_nvc;
            }
            set
            {
                this._EndTime_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("AnnouncementTime_nvc", "اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("AnnouncementTime_nvc", "اطلاع رسانی بار", 30));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("StartTime_nvc", "زمان شروع"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("StartTime_nvc", "زمان شروع", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartTime_nvc", "زمان شروع", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("EndTime_nvc", "زمان اتمام"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("EndTime_nvc", "زمان اتمام", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("EndTime_nvc", "زمان اتمام", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueAnnouncementTimeID_int", "شناسه اطلاع رسانی بار", "AnnouncementTime_T", "AnnouncementTimeID_int"));
        }
    }
}