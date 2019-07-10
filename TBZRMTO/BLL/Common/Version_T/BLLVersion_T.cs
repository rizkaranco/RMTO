using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.VersionBLL
{
    class BLLVersion_T : BusinessObjectBase
    {
        public enum Version_TField
        {
            VersionID_int
                ,
            Version_nvc
                ,
            Date_nvc
                ,
            Time_nvc
        }

        private Int32? _VersionID_int;
        public Int32? VersionID_int
        {
            get
            {
                return _VersionID_int;
            }
            set
            {
                this._VersionID_int = value;
            }
        }


        private String _Version_nvc;
        public String Version_nvc
        {
            get
            {
                return _Version_nvc;
            }
            set
            {
                this._Version_nvc = value;
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

        public override void AddValidationRules()
        {
        }

    }
}
