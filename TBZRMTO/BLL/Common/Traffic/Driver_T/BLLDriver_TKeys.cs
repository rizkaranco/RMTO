using System;
using System.Collections.Generic;
using System.Text;

namespace HPS.BLL.DriverBLL
{
    public class BLLDriver_TKeys
      {
       private Int64 _DriverID_bint;
       public Int64 DriverID_bint
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

       private Int64? _DriverID_bintNullable;
       public Int64? DriverID_bintNullable
       {
           get
           {
               return _DriverID_bintNullable;
           }
           set
           {
               this._DriverID_bintNullable = value;
           }
       }

      }
}
