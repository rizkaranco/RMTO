using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL
{

public partial class BLLYear_T: BusinessObjectBase
    {

public enum Year_TField 
{
YearID_int
,Year_nvc
,StartDate_nvc
,EndDate_nvc
,Description_nvc
,CurrencyID_int
,Default_bit
,SourceFiscalYearID_int
,DataBase_nvc
} 


private Nullable< Int32> _YearID_int;
       public Nullable< Int32> YearID_int
        {
            get
            {
                return _YearID_int;
            }
            set
            {
                this._YearID_int = value;
            }
        }


private String _Year_nvc;
       public String Year_nvc
        {
            get
            {
                return _Year_nvc;
            }
            set
            {
                this._Year_nvc = value;
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


private String _Description_nvc;
       public String Description_nvc
        {
            get
            {
                return _Description_nvc;
            }
            set
            {
                this._Description_nvc = value;
            }
        }


private Nullable< Int32> _CurrencyID_int;
       public Nullable< Int32> CurrencyID_int
        {
            get
            {
                return _CurrencyID_int;
            }
            set
            {
                this._CurrencyID_int = value;
            }
        }


private Nullable< bool> _Default_bit;
       public Nullable< bool> Default_bit
        {
            get
            {
                return _Default_bit;
            }
            set
            {
                this._Default_bit = value;
            }
        }


private Nullable< Int32> _SourceFiscalYearID_int;
       public Nullable< Int32> SourceFiscalYearID_int
        {
            get
            {
                return _SourceFiscalYearID_int;
            }
            set
            {
                this._SourceFiscalYearID_int = value;
            }
        }


private String _DataBase_nvc;
       public String DataBase_nvc
        {
            get
            {
                return _DataBase_nvc;
            }
            set
            {
                this._DataBase_nvc = value;
            }
        }



public override void AddValidationRules(){
    ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("FiscalYear_nvc", "نام سال مالی"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("FiscalYear_nvc","نام سال مالی",100));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("StartDate_nvc", "تاریخ شروع"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("StartDate_nvc","تاریخ شروع",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("EndDate_nvc","تاریخ پایان"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("EndDate_nvc","تاریخ پایان",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("Description_nvc","توضیح",1073741823));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CurrencyID_int","واحد پول"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Int32>("CurrencyID_int","واحد پول",null,null,0,0));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("Default_bit","پیش فرض"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("FiscalYearID_int","شناسه سال مالی مبداء","Year_T","YearID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("DataBase_nvc","نام پایگاه داده",200));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniqueFiscalYearID_int","شناسه سال مالی","Year_T","YearID_int"));
AddCustomValidationRules();
}
 partial void AddCustomValidationRules();
}
}