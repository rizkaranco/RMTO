using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.ComputerBLL
{

    public class BLLComputer_T
    : BusinessObjectBase
    {

        public enum Computer_TField
        {
            ComputerID_int
            ,
            Computer_nvc
                ,
            IPAddress_nvc
                ,
            MacAddress_nvc
                ,
            MessageLED_nvc
                ,
            Active_bit
                , UserGroupID_int,
            Deleted_bit
        }


        private Int32? _ComputerID_int;
        public Int32? ComputerID_int
        {
            get
            {
                return _ComputerID_int;
            }
            set
            {
                this._ComputerID_int = value;
            }
        }


        private String _Computer_nvc;
        public String Computer_nvc
        {
            get
            {
                return _Computer_nvc;
            }
            set
            {
                this._Computer_nvc = value;
            }
        }


        private String _IPAddress_nvc;
        public String IPAddress_nvc
        {
            get
            {
                return _IPAddress_nvc;
            }
            set
            {
                this._IPAddress_nvc = value;
            }
        }


        private String _MacAddress_nvc;
        public String MacAddress_nvc
        {
            get
            {
                return _MacAddress_nvc;
            }
            set
            {
                this._MacAddress_nvc = value;
            }
        }


        private String _MessageLED_nvc;
        public String MessageLED_nvc
        {
            get
            {
                return _MessageLED_nvc;
            }
            set
            {
                this._MessageLED_nvc = value;
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


        private Int32? _UserGroupID_int;
        public Int32? UserGroupID_int
        {
            get
            {
                return _UserGroupID_int;
            }
            set
            {
                this._UserGroupID_int = value;
            }
        }

        private bool _Deleted_bit;
        public bool Deleted_bit
        {
            get
            {
                return _Deleted_bit;
            }

            set
            {
                _Deleted_bit = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Computer_nvc", "نام رایانه"));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueMacAddress_nvc", "رایانه با این مشخصات ", "Computer_T", "MacAddress_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Computer_nvc", "نام رایانه", 50));
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("IPAddress_nvc", "آدرس IP"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("IPAddress_nvc", "آدرس IP", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("MacAddress_nvc", "آدرس Mac"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MacAddress_nvc", "آدرس Mac", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("MessageLED_nvc", "پیام نمایشگر LED", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Active_bit", "فعال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserGroupID_int", "گروه رایانه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserGroupID_int", "گروه کاربری", "UserGroup_T", "UserGroupID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueComputerID_int", "شناسه رایانه", "Computer_T", "ComputerID_int"));
        }
    }
}