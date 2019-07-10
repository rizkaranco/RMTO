using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.GoodBLL
{

    public class BLLGood_T
    : BusinessObjectBase
    {

        public enum Good_TField
        {
            GoodID_int
            ,
            GoodCode_nvc
                ,
            Good_nvc
                , Avtive_bit
        }


        private Int32? _GoodID_int;
        public Int32? GoodID_int
        {
            get
            {
                return _GoodID_int;
            }
            set
            {
                this._GoodID_int = value;
            }
        }


        private String _GoodCode_nvc;
        public String GoodCode_nvc
        {
            get
            {
                return _GoodCode_nvc;
            }
            set
            {
                this._GoodCode_nvc = value;
            }
        }


        private String _Good_nvc;
        public String Good_nvc
        {
            get
            {
                return _Good_nvc;
            }
            set
            {
                this._Good_nvc = value;
            }
        }


        private bool _Avtive_bit;
        public bool Avtive_bit
        {
            get
            {
                return _Avtive_bit;
            }
            set
            {
                this._Avtive_bit = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("GoodCode_nvc", "کد کالا"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("GoodCode_nvc", "کد کالا", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Good_nvc", "نام کالا"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Good_nvc", "نام کالا", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Avtive_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueGoodID_int", "شناسه کالا", "Good_T", "GoodID_int"));
        }
    }
}