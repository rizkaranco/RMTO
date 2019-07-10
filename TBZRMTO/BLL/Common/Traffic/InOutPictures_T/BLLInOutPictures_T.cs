using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.InOutPicturesBLL
{

    public partial class BLLInOutPictures_T : BusinessObjectBase
    {

        public enum InOutPictures_TField
        {
            inOutPicturesID_bint
            ,
            inOutID_bint
                , picture_vbnry
        }


        private Nullable<Int64> _inOutPicturesID_bint;
        public Nullable<Int64> inOutPicturesID_bint
        {
            get
            {
                return _inOutPicturesID_bint;
            }
            set
            {
                this._inOutPicturesID_bint = value;
            }
        }


        private Nullable<Int64> _inOutID_bint;
        public Nullable<Int64> inOutID_bint
        {
            get
            {
                return _inOutID_bint;
            }
            set
            {
                this._inOutID_bint = value;
            }
        }


        private byte[] _picture_vbnry;
        public byte[] picture_vbnry
        {
            get
            {
                return _picture_vbnry;
            }
            set
            {
                this._picture_vbnry = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("inOutID_bint", " هر ورود و خروج"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("inOutID_bint", " هر ورود و خروج", "InOut_T", "inOutID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("picture_vbnry", " تصاویر هر ورود و خروج"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("picture_vbnry", " تصاویر هر ورود و خروج", 2147483647));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueinOutPicturesID_bint", "شناسه تصاویر هر ورود و خروج", "InOutPictures_T", "inOutPicturesID_bint"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}