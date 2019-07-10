using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LaderTypeBLL
{

    public class BLLLaderType_T
    : BusinessObjectBase
    {

        public enum LaderType_TField
        {
            LaderTypeID_int
            ,
            LaderTypeCode_nvc
                ,
            LaderType_nvc
                ,
            MinTruckWeight_dec
                ,
            MaxTruckWeight_dec
                ,
            Active_bit
                ,
            SaloonID_int
                , LaderPivotGroupID_int
            , TurnCancel_bit
        }


        private Int32? _LaderTypeID_int;
        public Int32? LaderTypeID_int
        {
            get
            {
                return _LaderTypeID_int;
            }
            set
            {
                this._LaderTypeID_int = value;
            }
        }


        private String _LaderTypeCode_nvc;
        public String LaderTypeCode_nvc
        {
            get
            {
                return _LaderTypeCode_nvc;
            }
            set
            {
                this._LaderTypeCode_nvc = value;
            }
        }


        private String _LaderType_nvc;
        public String LaderType_nvc
        {
            get
            {
                return _LaderType_nvc;
            }
            set
            {
                this._LaderType_nvc = value;
            }
        }


        private Nullable<Decimal> _MinTruckWeight_dec;
        public Nullable<Decimal> MinTruckWeight_dec
        {
            get
            {
                return _MinTruckWeight_dec;
            }
            set
            {
                this._MinTruckWeight_dec = value;
            }
        }


        private Nullable<Decimal> _MaxTruckWeight_dec;
        public Nullable<Decimal> MaxTruckWeight_dec
        {
            get
            {
                return _MaxTruckWeight_dec;
            }
            set
            {
                this._MaxTruckWeight_dec = value;
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


        private Nullable<Int32> _SaloonID_int;
        public Nullable<Int32> SaloonID_int
        {
            get
            {
                return _SaloonID_int;
            }
            set
            {
                this._SaloonID_int = value;
            }
        }


        private Nullable<Int32> _LaderPivotGroupID_int;
        public Nullable<Int32> LaderPivotGroupID_int
        {
            get
            {
                return _LaderPivotGroupID_int;
            }
            set
            {
                this._LaderPivotGroupID_int = value;
            }
        }

        public bool TurnCancel_bit { get; set; }

        public override void AddValidationRules()
        {
          //  ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LaderTypeCode_nvc", "کد بارگیر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LaderTypeCode_nvc", "کد بارگیر", 30));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LaderType_nvc", "نام بارگیر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("LaderType_nvc", "نام بارگیر", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("MinTruckWeight_dec", "حداقل وزن بارگیر", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("MaxTruckWeight_dec", "حداکثر وزن بارگیر", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("SaloonID_int", "FK Not Exits", "Saloon_T", "SaloonID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LaderPivotGroupID_int", "FK Not Exits", "LaderPivotGroup_T", "LaderPivotGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLaderTypeID_int", "شناسه  نوع بارگیر", "LaderType_T", "LaderTypeID_int"));
        }
    }
}