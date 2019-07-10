using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.LadBillCreditBLL
{

    public class BLLLadBillCredit_T
    : BusinessObjectBase
    {

        public enum LadBillCredit_TField
        {
            LadBillCreditID_int
            ,
            Date_nvc
                ,
            Time_nvc
                ,
            UserName_nvc
                ,
            Comment_nvc
                ,
            LadeAssignmentID_bint
                ,
            TrafficID_bint
                ,
            Printed_bit
                ,
            Canceled_bit
                ,
            CanceledDate_nvc
                ,
            CanceledTime_nvc
                ,
            CanceledUserName_nvc
                , 
            CanceledComment_nvc
                ,
            Turn_bit
        }


        private Int32 _LadBillCreditID_int;
        public Int32 LadBillCreditID_int
        {
            get
            {
                return _LadBillCreditID_int;
            }
            set
            {
                this._LadBillCreditID_int = value;
            }
        }


        private String _Date_nvc;
        public String Date_nvc
        {
            get
            {
                return _Date_nvc;
            }
            set
            {
                this._Date_nvc = value;
            }
        }


        private String _Time_nvc;
        public String Time_nvc
        {
            get
            {
                return _Time_nvc;
            }
            set
            {
                this._Time_nvc = value;
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


        private String _Comment_nvc;
        public String Comment_nvc
        {
            get
            {
                return _Comment_nvc;
            }
            set
            {
                this._Comment_nvc = value;
            }
        }


        private Int64 _LadeAssignmentID_bint;
        public Int64 LadeAssignmentID_bint
        {
            get
            {
                return _LadeAssignmentID_bint;
            }
            set
            {
                this._LadeAssignmentID_bint = value;
            }
        }


        private Int64 _TrafficID_bint;
        public Int64 TrafficID_bint
        {
            get
            {
                return _TrafficID_bint;
            }
            set
            {
                this._TrafficID_bint = value;
            }
        }


        private bool _Printed_bit;
        public bool Printed_bit
        {
            get
            {
                return _Printed_bit;
            }
            set
            {
                this._Printed_bit = value;
            }
        }


        private Nullable<bool> _Canceled_bit = false;
        public Nullable<bool> Canceled_bit
        {
            get
            {
                return _Canceled_bit;
            }
            set
            {
                this._Canceled_bit = value;
            }
        }


        private String _CanceledDate_nvc;
        public String CanceledDate_nvc
        {
            get
            {
                return _CanceledDate_nvc;
            }
            set
            {
                this._CanceledDate_nvc = value;
            }
        }


        private String _CanceledTime_nvc;
        public String CanceledTime_nvc
        {
            get
            {
                return _CanceledTime_nvc;
            }
            set
            {
                this._CanceledTime_nvc = value;
            }
        }


        private String _CanceledUserName_nvc;
        public String CanceledUserName_nvc
        {
            get
            {
                return _CanceledUserName_nvc;
            }
            set
            {
                this._CanceledUserName_nvc = value;
            }
        }


        private String _CanceledComment_nvc;
        public String CanceledComment_nvc
        {
            get
            {
                return _CanceledComment_nvc;
            }
            set
            {
                this._CanceledComment_nvc = value;
            }
        }

        private bool? _Turn_bit;
        public bool? Turn_bit
        {
            get
            {
                return _Turn_bit;
            }
            set
            {
                this._Turn_bit = value;
            }
        }


        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر ثبت کننده"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر ثبت کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر ثبت کننده", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Comment_nvc", "توضیحات", 1000));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadeAssignmentID_bint", "اطلاع رسانی بار"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadeAssignmentID_bint", "اطلاع رسانی بار", "LadeAssignment_T", "LadeAssignmentID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TrafficID_bint", "نوبت تردد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("TrafficID_bint", "نوبت تردد", "Traffic_T", "TrafficID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Printed_bit", "چاپ مجدد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CanceledDate_nvc", "تارخ حذف", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CanceledTime_nvc", "ساعت حذف", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CanceledUserName_nvc", "کاربر حذف کننده", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر حذف کننده", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CanceledComment_nvc", "توضیحات حذف", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueLadBillCreditID_int", "شناسه مجوز بارگیری", "LadBillCredit_T", "LadBillCreditID_int"));
        }
    }
}