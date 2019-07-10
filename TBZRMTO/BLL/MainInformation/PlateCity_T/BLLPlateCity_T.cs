using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.PlateCityBLL
{

    public class BLLPlateCity_T
    : BusinessObjectBase
    {

        public enum PlateCity_TField
        {
            PlateCityID_int
            ,
            PlateCityCode_nvc
                ,
            PlateCity_nvc
                , Active_bit
        }


        private Int32? _PlateCityID_int;
        public Int32? PlateCityID_int
        {
            get
            {
                return _PlateCityID_int;
            }
            set
            {
                this._PlateCityID_int = value;
            }
        }



        private String _PlateCityCode_nvc;
        public String PlateCityCode_nvc
        {
            get
            {
                return _PlateCityCode_nvc;
            }
            set
            {
                this._PlateCityCode_nvc = value;
            }
        }


        private String _PlateCity_nvc;
        public String PlateCity_nvc
        {
            get
            {
                return _PlateCity_nvc;
            }
            set
            {
                this._PlateCity_nvc = value;
            }
        }


        private bool _Active_bit;
        public bool Active_bit
        {
            get
            {
                return _Active_bit;
            }
            set
            {
                this._Active_bit = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PlateCityCode_nvc", "کد شهر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateCityCode_nvc", "کد شهر", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PlateCity_nvc", "نام شهر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PlateCity_nvc", "نام شهر", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquePlateCityID_int", "شناسه محل شماره گذاری", "PlateCity_T", "PlateCityID_int"));
        }
    }
}