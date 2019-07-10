using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ITS
{

    public partial class BLLITS_T : BusinessObjectBase
    {

        public enum ITS_TField
        {
            ITSID_bint
            ,
            TrafficID_bint
                ,
            SendToITSDate_nvc
                ,
            SendToITSTime_nvc
                ,
            ResiveTimeStamp_nvc
                ,
            NumberPlate_nvc
                , SerialPlate_nvc
            , StationCode_int
        }


        private Nullable<Int64> _ITSID_bint;
        public Nullable<Int64> ITSID_bint
        {
            get
            {
                return _ITSID_bint;
            }
            set
            {
                this._ITSID_bint = value;
            }
        }


        private Nullable<Int64> _TrafficID_bint;
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

        private Int32 _StationCode_int;
        public Int32 StationCode_int
        {
            get
            {
                return _StationCode_int;
            }
            set
            {
                this._StationCode_int = value;
            }
        }


        private String _SendToITSDate_nvc;
        public String SendToITSDate_nvc
        {
            get
            {
                return _SendToITSDate_nvc;
            }
            set
            {
                this._SendToITSDate_nvc = value;
            }
        }



        private String _SendToITSTime_nvc;
        public String SendToITSTime_nvc
        {
            get
            {
                return _SendToITSTime_nvc;
            }
            set
            {
                this._SendToITSTime_nvc = value;
            }
        }


        private String _ResiveTimeStamp_nvc;
        public String ResiveTimeStamp_nvc
        {
            get
            {
                return _ResiveTimeStamp_nvc;
            }
            set
            {
                this._ResiveTimeStamp_nvc = value;
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



        public override void AddValidationRules()
        {
            //ValidationRules.AddRules(new HPS.Validation.NotNullRule("TrafficID_bint", ""));
            //ValidationRules.AddRules(new HPS.Validation.RelationRule("TrafficID_bint", "", "Traffic_T", "TrafficID_bint"));
            //ValidationRules.AddRules(new HPS.Validation.StringMaxLengthRule("SendToITSDate_nvc", "", 10));
            //ValidationRules.AddRules(new HPS.Validation.StringMaxLengthRule("SendToITSTime_nvc", "", 10));
            //ValidationRules.AddRules(new HPS.Validation.StringMaxLengthRule("ResiveTimeStamp_nvc", " ITSزمان و تاریخ دریافتی از ", 30));
            //ValidationRules.AddRules(new HPS.Validation.NotNullRule("NumberPlate_nvc", "شماره پلاک"));
            //ValidationRules.AddRules(new HPS.Validation.StringMaxLengthRule("NumberPlate_nvc", "شماره پلاک", 15));
            //ValidationRules.AddRules(new HPS.Validation.StringMaxLengthRule("SerialPlate_nvc", "سری پلاک", 3));
            //ValidationRules.AddRules(new HPS.Validation.UniqueRule("UniqueITSID_bint", " ITSشناسه", "ITS_T", "ITSID_bint"));
            //AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
       
    } 
}