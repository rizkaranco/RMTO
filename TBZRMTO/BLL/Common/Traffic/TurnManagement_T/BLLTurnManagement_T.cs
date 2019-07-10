using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.TurnManagementBLL
{

    public class BLLTurnManagement_T
    : BusinessObjectBase
    {

        public enum TurnManagement_TField
        {
            TurnManagementID_int
            ,
            TrafficID_bint
                ,
            TurnCancelCommantID_int
                ,
            TurnCancelCommment_nvc
                ,
            Return_bit
                ,
            Date_nvc
                ,
            Time_nvc
                , UserName_nvc
        }


        private Int32? _TurnManagementID_int;
        public Int32? TurnManagementID_int
        {
            get
            {
                return _TurnManagementID_int;
            }
            set
            {
                this._TurnManagementID_int = value;
            }
        }


        private Int64? _TrafficID_bint;
        public Int64? TrafficID_bint
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


        private Nullable<Int32> _TurnCancelCommantID_int;
        public Nullable<Int32> TurnCancelCommantID_int
        {
            get
            {
                return _TurnCancelCommantID_int;
            }
            set
            {
                this._TurnCancelCommantID_int = value;
            }
        }


        private String _TurnCancelCommment_nvc;
        public String TurnCancelCommment_nvc
        {
            get
            {
                return _TurnCancelCommment_nvc;
            }
            set
            {
                this._TurnCancelCommment_nvc = value;
            }
        }


        private Nullable<bool> _Return_bit;
        public Nullable<bool> Return_bit
        {
            get
            {
                return _Return_bit;
            }
            set
            {
                this._Return_bit = value;
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



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("TrafficID_bint", " تردد"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("TrafficID_bint", "تردد", "Traffic_T", "TrafficID_bint"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("TurnCancelCommentID_int", "توضیحات ابطال نوبت", "TurnCancelComment_T", "TurnCancelCommentID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("TurnCancelCommment_nvc", "توضیحات ابطال نوبت", 500));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc,UserName_nvc", "کاربر", "User_T", "UserName_nvc,UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueTurnManagementID_int", "شناسه مدیریت نوبت", "TurnManagement_T", "TurnManagementID_int"));
            ValidationRules.AddRules(new HPS.validators.DuplicateTurnNumberInUpdateRule("DuplicateTurnNumberInUpdateRule", "DuplicateTurnNumberInUpdateRule"));

        }
    }
}