using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.BLL.CarBLL
{
    public class BLLCar_TKeys
    {
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

        private Int32? _CarID_intNullable;
        public Int32? CarID_intNullable
        {
            get
            {
                return _CarID_intNullable;
            }
            set
            {
                this._CarID_intNullable = value;
            }
        }

    }
}
