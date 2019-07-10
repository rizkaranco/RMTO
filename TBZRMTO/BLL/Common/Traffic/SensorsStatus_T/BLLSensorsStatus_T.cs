using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.BLLSensorsStatus
{

    public partial class BLLSensorsStatus_T : BusinessObjectBase
    {

        public enum SensorsStatus_TField
        {
            sensorsStatusID_int
            ,
            inSensor_bit
                ,
            inGateSensor_bit
                ,
            outSensor_bit
                , outGateSensor_bit
        }


        private Nullable<Int32> _sensorsStatusID_int;
        public Nullable<Int32> sensorsStatusID_int
        {
            get
            {
                return _sensorsStatusID_int;
            }
            set
            {
                this._sensorsStatusID_int = value;
            }
        }


        private Nullable<bool> _inSensor_bit;
        public Nullable<bool> inSensor_bit
        {
            get
            {
                return _inSensor_bit;
            }
            set
            {
                this._inSensor_bit = value;
            }
        }


        private Nullable<bool> _inGateSensor_bit;
        public Nullable<bool> inGateSensor_bit
        {
            get
            {
                return _inGateSensor_bit;
            }
            set
            {
                this._inGateSensor_bit = value;
            }
        }


        private Nullable<bool> _outSensor_bit;
        public Nullable<bool> outSensor_bit
        {
            get
            {
                return _outSensor_bit;
            }
            set
            {
                this._outSensor_bit = value;
            }
        }


        private Nullable<bool> _outGateSensor_bit;
        public Nullable<bool> outGateSensor_bit
        {
            get
            {
                return _outGateSensor_bit;
            }
            set
            {
                this._outGateSensor_bit = value;
            }
        }



        public override void AddValidationRules()
        {
        }
        partial void AddCustomValidationRules();
    }
}