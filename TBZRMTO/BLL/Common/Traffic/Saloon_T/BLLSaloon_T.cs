using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.SaloonBLL
{

    public class BLLSaloon_T
    : BusinessObjectBase
    {

        public enum Saloon_TField
        {
            SaloonID_int
            ,
            Saloon_nvc
                ,
            TurnDistinictAfterCredit_int
                , TurnNumberInLadeAnnouncement_int
        }


        private Int32? _SaloonID_int;
        public Int32? SaloonID_int
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


        private String _Saloon_nvc;
        public String Saloon_nvc
        {
            get
            {
                return _Saloon_nvc;
            }
            set
            {
                this._Saloon_nvc = value;
            }
        }


        private Int32? _TurnDistinictAfterCredit_int;
        public Int32? TurnDistinictAfterCredit_int
        {
            get
            {
                return _TurnDistinictAfterCredit_int;
            }
            set
            {
                this._TurnDistinictAfterCredit_int = value;
            }
        }


        private Int32? _TurnNumberInLadeAnnouncement_int;
        public Int32? TurnNumberInLadeAnnouncement_int
        {
            get
            {
                return _TurnNumberInLadeAnnouncement_int;
            }
            set
            {
                this._TurnNumberInLadeAnnouncement_int = value;
            }
        }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Saloon_nvc", "نام سالن"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Saloon_nvc", "نام سالن", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TurnDistinictAfterCredit_int", "فاصله بین نوبتهابعداز اعتبار "));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("TurnDistinictAfterCredit_int", "فاصله بین نوبتهابعداز اعتبار ", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TurnNumberInLadeAnnouncement_int", "تعدادمجاز نوبت در هر اعلان بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("TurnNumberInLadeAnnouncement_int", "تعدادمجاز نوبت در هر اعلان بار", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueSaloonID_int", "شناسه سالن اعلان بار", "Saloon_T", "SaloonID_int"));
        }
    }
}