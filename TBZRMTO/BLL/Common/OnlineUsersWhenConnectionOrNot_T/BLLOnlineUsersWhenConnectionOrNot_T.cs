using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.OnlineUsersWhenConnectionOrNotBLL
{

    public partial class BLLOnlineUsersWhenConnectionOrNot_T : BusinessObjectBase
    {

        public enum OnlineUsersWhenConnectionOrNot_TField
        {
            OnlineUsersWhenConnectionOrNotID_bint
            ,
            OfflineSecondPartSoftwareID_int
                , OnlineUserID_int
            , OffOrOn_nvc
        }


        private Nullable<Int64> _OnlineUsersWhenConnectionOrNotID_bint;
        public Nullable<Int64> OnlineUsersWhenConnectionOrNotID_bint
        {
            get
            {
                return _OnlineUsersWhenConnectionOrNotID_bint;
            }
            set
            {
                this._OnlineUsersWhenConnectionOrNotID_bint = value;
            }
        }


        private Nullable<Int32> _OfflineSecondPartSoftwareID_int;
        public Nullable<Int32> OfflineSecondPartSoftwareID_int
        {
            get
            {
                return _OfflineSecondPartSoftwareID_int;
            }
            set
            {
                this._OfflineSecondPartSoftwareID_int = value;
            }
        }


        private Nullable<Int32> _OnlineUserID_int;
        public Nullable<Int32> OnlineUserID_int
        {
            get
            {
                return _OnlineUserID_int;
            }
            set
            {
                this._OnlineUserID_int = value;
            }
        }

        private String _OffOrOn_nvc;
        public String OffOrOn_nvc
        {
            get
            {
                return _OffOrOn_nvc;
            }
            set
            {
                this._OffOrOn_nvc = value;
            }
        }

        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("OfflineSecondPartSoftwareID_int", "شناسه قطع و وصل بودن نرم افزارها"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("OfflineSecondPartSoftwareID_int", "شناسه قطع و وصل بودن نرم افزارها", "OfflineSecondPartSoftware_T", "OfflineSecondPartSoftwareID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("OnlineUserID_int", "کاربران آنلاین"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("OnlineUserID_int", "کاربران آنلاین", "OnlineUser_T", "OnlineUserID_int"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("OffOrOn_nvc", "قطع یا وصل بودن نرم افزارها"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("OffOrOn_nvc", "قطع یا وصل بودن نرم افزارها", 20));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueOnlineUsersWhenConnectionOrNotID_bint", "شناسه کاربران آنلاین هنگام قطع یا وصل بودن نرم افزارها", "OnlineUsersWhenConnectionOrNot_T", "OnlineUsersWhenConnectionOrNotID_bint"));

            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}