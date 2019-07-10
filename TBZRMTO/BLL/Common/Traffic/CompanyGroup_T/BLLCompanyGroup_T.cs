using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.CompanyGroupBLL
{

    public partial class BLLCompanyGroup_T : BusinessObjectBase
    {

        public enum CompanyGroup_TField
        {
            GroupID_int
            , GroupName_nvc
        }


        private Nullable<Int32> _GroupID_int;
        public Nullable<Int32> GroupID_int
        {
            get
            {
                return _GroupID_int;
            }
            set
            {
                this._GroupID_int = value;
            }
        }


        private String _GroupName_nvc;
        public String GroupName_nvc
        {
            get
            {
                return _GroupName_nvc;
            }
            set
            {
                this._GroupName_nvc = value;
            }
        }



        public override void AddValidationRules()
        {
            ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("GroupName_nvc", "نام گروه"));
            ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("GroupName_nvc", "نام گروه", 50));
            ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueGroupID_int", "گروه", "CompanyGroup_T", "GroupID_int"));
            AddCustomValidationRules();
        }
        partial void AddCustomValidationRules();
    }
}