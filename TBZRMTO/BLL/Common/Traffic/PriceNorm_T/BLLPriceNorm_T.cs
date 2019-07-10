using System;
using System.Collections.Generic;
using System.Text;
using HPS.BLL.BusinessObjectMain;

namespace HPS.BLL.PriceNormBLL{

public class BLLPriceNorm_T
: BusinessObjectBase{

public enum PriceNorm_TField {
PriceNormID_int
,CityID_int
,LaderTypeID_int
,GoodID_int
,Price_dec
,OldPrice_dec
,CreateDate_nvc
,UpdateDate_nvc
,OriginCityID_int
} 


private Int32 _PriceNormID_int;
       public Int32 PriceNormID_int
        {
            get
            {
                return _PriceNormID_int;
            }
            set
            {
                this._PriceNormID_int = value;
            }
        }


private Int32 _CityID_int;
       public Int32 CityID_int
        {
            get
            {
                return _CityID_int;
            }
            set
            {
                this._CityID_int = value;
            }
        }


private Int32 _LaderTypeID_int;
       public Int32 LaderTypeID_int
        {
            get
            {
                return _LaderTypeID_int;
            }
            set
            {
                this._LaderTypeID_int = value;
            }
        }


private Nullable< Int32> _GoodID_int;
       public Nullable< Int32> GoodID_int
        {
            get
            {
                return _GoodID_int;
            }
            set
            {
                this._GoodID_int = value;
            }
        }


private Nullable< Decimal> _Price_dec;
       public Nullable< Decimal> Price_dec
        {
            get
            {
                return _Price_dec;
            }
            set
            {
                this._Price_dec = value;
            }
        }


private Nullable< Decimal> _OldPrice_dec;
       public Nullable< Decimal> OldPrice_dec
        {
            get
            {
                return _OldPrice_dec;
            }
            set
            {
                this._OldPrice_dec = value;
            }
        }


private String _CreateDate_nvc;
       public String CreateDate_nvc
        {
            get
            {
                return _CreateDate_nvc;
            }
            set
            {
                this._CreateDate_nvc = value;
            }
        }


private String _UpdateDate_nvc;
       public String UpdateDate_nvc
        {
            get
            {
                return _UpdateDate_nvc;
            }
            set
            {
                this._UpdateDate_nvc = value;
            }
        }


private Nullable< Int32> _OriginCityID_int;
       public Nullable< Int32> OriginCityID_int
        {
            get
            {
                return _OriginCityID_int;
            }
            set
            {
                this._OriginCityID_int = value;
            }
        }



public override void AddValidationRules(){
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("CityID_int","شهر مقصد"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int","شهر مقصد","City_T","CityID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NotNullRule("LaderTypeID_int"," نوع بارگیر"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("LaderTypeID_int"," نوع بارگیر","LaderType_T","LaderTypeID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("GoodID_int","کالا","Good_T","GoodID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("Price_dec","نرخ",null,null,0,0));
ValidationRules.AddRules(new Hepsa.Core.Validation.NumericRule<Decimal>("OldPrice_dec","نرخ قبلی",null,null,0,0));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("CreateDate_nvc","تاریخ ایجاد",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.StringMaxLengthRule("UpdateDate_nvc","تاریخ به روز رسانی",10));
ValidationRules.AddRules(new Hepsa.Core.Validation.RelationRule("CityID_int","شهر مبدأ","City_T","CityID_int"));
ValidationRules.AddRules(new Hepsa.Core.Validation.UniqueRule("UniquePriceNormID_int","شناسه هزینه","PriceNorm_T","PriceNormID_int"));
}
}
}