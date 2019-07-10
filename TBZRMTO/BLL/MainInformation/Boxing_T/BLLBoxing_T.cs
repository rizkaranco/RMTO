using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.BoxingBLL
{

    public class BLLBoxing_T
    : BusinessObjectBase
    {

        public enum Boxing_TField
        {
            BoxingID_int
            ,
            BoxingCode_nvc
                ,
            BoxingType_nvc
                , Active_bit
        }


        private Int32? _BoxingID_int;
        public Int32? BoxingID_int
        {
            get
            {
                return _BoxingID_int;
            }
            set
            {
                this._BoxingID_int = value;
            }
        }


        private String _BoxingCode_nvc;
        public String BoxingCode_nvc
        {
            get
            {
                return _BoxingCode_nvc;
            }
            set
            {
                this._BoxingCode_nvc = value;
            }
        }


        private String _BoxingType_nvc;
        public String BoxingType_nvc
        {
            get
            {
                return _BoxingType_nvc;
            }
            set
            {
                this._BoxingType_nvc = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("BoxingCode_nvc", "کد بسته بندی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("BoxingCode_nvc", "کد بسته بندی", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("BoxingType_nvc", " نوع بسته بندی"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("BoxingType_nvc", " نوع بسته بندی", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueBoxingID_int", "شناسه دسته بندی", "Boxing_T", "BoxingID_int"));
        }
    }
}