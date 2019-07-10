using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InfractionGroupBLL
{

    public class BLLInfractionGroup_T
    : BusinessObjectBase
    {

        public enum InfractionGroup_TField
        {
            InfractionGroupID_int
            ,
            InfractionGroup_nvc
                , Active_bit
        }


        private Int32? _InfractionGroupID_int;
        public Int32? InfractionGroupID_int
        {
            get
            {
                return _InfractionGroupID_int;
            }
            set
            {
                this._InfractionGroupID_int = value;
            }
        }


        private String _InfractionGroup_nvc;
        public String InfractionGroup_nvc
        {
            get
            {
                return _InfractionGroup_nvc;
            }
            set
            {
                this._InfractionGroup_nvc = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("InfractionGroup_nvc", "عنوان گروه تخلف"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("InfractionGroup_nvc", "عنوان گروه تخلف", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionGroup_nvc", "عنوان گروه تخلف", "InfractionGroup_T", "InfractionGroup_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueInfractionGroupID_int", "شناسه گروه تخلف", "InfractionGroup_T", "InfractionGroupID_int"));
        }
    }
}