using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.UsedLadBillBLL
{

    public class BLLUsedLadBill_T
    : BusinessObjectBase
    {

        public enum UsedLadBill_TField
        {
            UsedLadBillID_int
            ,
            LadBillCreditID_int
                ,
            CompanyLadBillID_bint
                ,
            Serial_nvc
                ,
            LadBillNumber_int
                ,
            Comment_nvc
                ,
            Date_nvc
                ,
            Time_nvc
                , 
            UserName_nvc
            ,
            LadeAssignmentID_bint
            ,
            Date_nvcTime_nvc
            ,
            City_nvc
            ,
            Good_nvc
            ,
            CarCount_int
            ,
            LaderType_nvc
            ,
            CompanyID_int
            ,
            Company_nvc
        }


        private Int32? _Company_nvc;
        public Int32? Company_nvc
        {
            get
            {
                return _Company_nvc;
            }
            set
            {
                this._Company_nvc = value;
            }
        }

        private Int32? _CompanyID_int;
        public Int32? CompanyID_int
        {
            get
            {
                return _CompanyID_int;
            }
            set
            {
                this._CompanyID_int = value;
            }
        }

        private String _LaderType_nvc;
        public String LaderType_nvc
        {
            get
            {
                return _LaderType_nvc;
            }
            set
            {
                this._LaderType_nvc = value;
            }
        }

        private String _CarCount_int;
        public String CarCount_int
        {
            get
            {
                return _CarCount_int;
            }
            set
            {
                this._CarCount_int = value;
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

        private String _City_nvc;
        public String City_nvc
        {
            get
            {
                return _City_nvc;
            }
            set
            {
                this._City_nvc = value;
            }
        }

        private String _Date_nvcTime_nvc;
        public String Date_nvcTime_nvc
        {
            get
            {
                return _Date_nvcTime_nvc;
            }
            set
            {
                this._Date_nvcTime_nvc = value;
            }
        }

        private Int32? _LadeAssignmentID_bint;
        public Int32? LadeAssignmentID_bint
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

        private Int32? _UsedLadBillID_int;
        public Int32? UsedLadBillID_int
        {
            get
            {
                return _UsedLadBillID_int;
            }
            set
            {
                this._UsedLadBillID_int = value;
            }
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


        private Int64? _CompanyLadBillID_bint;
        public Int64? CompanyLadBillID_bint
        {
            get
            {
                return _CompanyLadBillID_bint;
            }
            set
            {
                this._CompanyLadBillID_bint = value;
            }
        }


        private String _Serial_nvc;
        public String Serial_nvc
        {
            get
            {
                return _Serial_nvc;
            }
            set
            {
                this._Serial_nvc = value;
            }
        }


        private Int32? _LadBillNumber_int;
        public Int32? LadBillNumber_int
        {
            get
            {
                return _LadBillNumber_int;
            }
            set
            {
                this._LadBillNumber_int = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadBillCreditID_int", "مجوز بارگیری"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LadBillCreditID_int", "مجوز بارگیری", "LadBillCredit_T", "LadBillCreditID_int"));
            
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CompanyLadBillID_bint", "بارنامه های تحویلی به شرکت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CompanyLadBillID_bint", "بارنامه های تحویلی به شرکت", "CompanyLadBill_T", "CompanyLadBillID_bint"));
            
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Serial_nvc", "سریال"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Serial_nvc", "سریال", 100));
            
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LadBillNumber_int", "شماره بارنامه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("LadBillNumber_int", "شماره بارنامه", null, null, 0, 0));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Comment_nvc", "توضیح", 1000));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("Time_nvc", "ساعت", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueUsedLadBillID_int", "شناسه بارنامه های استفاده شده", "UsedLadBill_T", "UsedLadBillID_int"));
        }
    }
}