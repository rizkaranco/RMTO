using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.NewsBLL
{

    public class BLLNews_T
    : BusinessObjectBase
    {

        public enum News_TField
        {
            NewsID_bint
            ,
            Title_nvc
                ,
            News_nvc
                ,
            StartDate_nvc
                ,
            EndDate_nvc
                ,
            Date_nvc
                ,
            Time_nvc
                , UserName_nvc
        }


        private Int64? _NewsID_bint;
        public Int64? NewsID_bint
        {
            get
            {
                return _NewsID_bint;
            }
            set
            {
                this._NewsID_bint = value;
            }
        }


        private String _Title_nvc;
        public String Title_nvc
        {
            get
            {
                return _Title_nvc;
            }
            set
            {
                this._Title_nvc = value;
            }
        }


        private String _News_nvc;
        public String News_nvc
        {
            get
            {
                return _News_nvc;
            }
            set
            {
                this._News_nvc = value;
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
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Title_nvc", "عنوان خبر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Title_nvc", "عنوان خبر", 100));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("News_nvc", "متن خبر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("News_nvc", "متن خبر", 1000));

            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartDate_nvc", "از تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("StartDate_nvc", "از تاریخ", null, null));
           // ValidationRules.AddRules(new Hepsa.Core.Validation.TodayDateRule("StartDate_nvc", "از تاریخ"));

            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("EndDate_nvc", "تا تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("EndDate_nvc", "تا تاریخ", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Date_nvc", "تاریخ"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.DateRule<string>("Date_nvc", "تاریخ", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Time_nvc", "ساعت"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10));
            ValidationRules.AddRules(new Hepsa.Core.Validation.TimeRule<string>("Time_nvc", "ساعت", null, null));

            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("UserName_nvc", "کاربر"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UserName_nvc", "کاربر", 100));

            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("UserName_nvc", "کاربر", "User_T", "UserName_nvc"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueNewsID_bint", "شناسه اخبار", "News_T", "NewsID_bint"));
        }
    }
}