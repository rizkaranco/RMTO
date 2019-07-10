using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.PortPlacesBLL
{

    public class BLLPortPlaces_T
    : BusinessObjectBase
    {

        public enum PortPlaces_TField
        {
            PortPlacesID_int
            ,
            PortPlaces_nvc
                , Active_bit
        }


        private Int32? _PortPlacesID_int;
        public Int32? PortPlacesID_int
        {
            get
            {
                return _PortPlacesID_int;
            }
            set
            {
                this._PortPlacesID_int = value;
            }
        }


        private String _PortPlaces_nvc;
        public String PortPlaces_nvc
        {
            get
            {
                return _PortPlaces_nvc;
            }
            set
            {
                this._PortPlaces_nvc = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("PortPlaces_nvc", " محل بارگیری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("PortPlaces_nvc", " محل بارگیری", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquePortPlaces_nvc", "محل بارگیری", "PortPlaces_T", "PortPlaces_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquePortPlacesID_int", "شناسه محل بارگیری", "PortPlaces_T", "PortPlacesID_int"));
        }
    }
}