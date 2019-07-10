using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.BillMessageBLL
{

    public class BLLBillMessage_T
    : BusinessObjectBase
    {

        public enum BillMessage_TField
        {
            BillMessageID_int
            ,
            BillID_int
                ,
            Message_nvc
                ,
            StartDate_nvc
                ,
            EndDate_nvc
            , UserName_nvc
            ,ShowInLadeAssignmentRepetation_bit,
            SaloonID_int
        }


        private Int32? _BillMessageID_int;
        public Int32? BillMessageID_int
        {
            get
            {
                return _BillMessageID_int;
            }
            set
            {
                this._BillMessageID_int = value;
            }
        }


        private Int32? _BillID_int;
        public Int32? BillID_int
        {
            get
            {
                return _BillID_int;
            }
            set
            {
                this._BillID_int = value;
            }
        }


        private String _Message_nvc;
        public String Message_nvc
        {
            get
            {
                return _Message_nvc;
            }
            set
            {
                this._Message_nvc = value;
            }
        }


        private String _StartDate_nvc;
        public String StartDate_nvc
        {
            get
            {
                return _StartDate_nvc;
            }
            set
            {
                this._StartDate_nvc = value;
            }
        }


        private String _EndDate_nvc;
        public String EndDate_nvc
        {
            get
            {
                return _EndDate_nvc;
            }
            set
            {
                this._EndDate_nvc = value;
            }
        }


        private String _UserName_nvc;
        public String UserName_nvc
        {
            get
            {
                return _UserName_nvc;
            }
            set
            {
                this._UserName_nvc = value;
            }
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

        private bool? _ShowInLadeAssignmentRepetation_bit;
        public bool? ShowInLadeAssignmentRepetation_bit
        {
            get
            {
                return _ShowInLadeAssignmentRepetation_bit;
            }
            set
            {
                this._ShowInLadeAssignmentRepetation_bit = value;
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

        public override void AddValidationRules()
        {
            //ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("BillID_int", "قبض"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("BillID_int", "قبض", "Bill_T", "BillID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Message_nvc", "پیام"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Message_nvc", "پیام", 1000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("StartDate_nvc", "از تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("StartDate_nvc", "از تاریخ", null, null));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("StartDate_nvc", "از تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartDate_nvc", "از تاریخ", 10)); 
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("EndDate_nvc", "تا تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("EndDate_nvc", "تا تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("EndDate_nvc", "تا تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueBillMessageID_int", "شناسه پیام قبض", "BillMessage_T", "BillMessageID_int"));
       //     ValidationRules.AddRules(new HPS.validators.BillMessageDateValidationRule("StartDate_nvc", "از تاریخ", "BillMessageID_int"));
        }
    }
}