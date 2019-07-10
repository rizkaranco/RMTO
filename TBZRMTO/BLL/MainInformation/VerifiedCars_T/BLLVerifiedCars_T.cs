using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.VerifiedCarsBLL
{

    public partial class BLLVerifiedCars_T : BusinessObjectBase
    {

        public enum VerifiedCars_TField
        {
            VerifiedCarID_int
        , CompanyID_int
        , NumberPlate_nvc
        , SerialPlate_nvc
        , Date_vc
                , FullName_nvc
                , Unit_nvc
        }


        private Nullable<Int32> _VerifiedCarID_int;
        public Nullable<Int32> VerifiedCarID_int
        {
            get
            {
                return _VerifiedCarID_int;
            }
            set
            {
                this._VerifiedCarID_int = value;
            }
        }


        private Nullable<Int32> _CompanyID_int;
        public Nullable<Int32> CompanyID_int
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


        private String _Date_vc;
        public String Date_vc
        {
            get
            {
                return _Date_vc;
            }
            set
            {
                this._Date_vc = value;
            }
        }

        public string FullName_nvc { get; set; }

        public string Unit_nvc { get; set; }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueVerifiedCarID_int", "", "VerifiedCars_T", "VerifiedCarID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueNumberPlate", "شماره پلاک و سری", "VerifiedCars_T", "NumberPlate_nvc", "SerialPlate_nvc"));
            AddCustomValidationRules();

        }
        partial void AddCustomValidationRules();
    }
}