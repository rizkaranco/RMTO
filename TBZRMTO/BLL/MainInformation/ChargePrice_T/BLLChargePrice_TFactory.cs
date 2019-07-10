using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.ChargePriceBLL
{
public class BLLChargePrice_TFactory: BusinessFactoryBase
    {
    private HPS.DAL.ChargePriceDAL.DALChargePrice_T _dataObject = null;

    public BLLChargePrice_TFactory()
        :base("ChargePrice_T")
    {
        _dataObject = (HPS.DAL.ChargePriceDAL.DALChargePrice_T)base.DataAccessLayer;
    }

    public void Insert(HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject){
        try{
            if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except,"ChargePriceID_int") == false) {
throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
}

            _dataObject.Insert(businessObject);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void Update(HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject, HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey)
    {
        try
        {
            if (businessObject.ChargePriceID_int == businessObjectKey.ChargePriceID_int)
            {
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueChargePriceID_int") == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                }
            }
            else
            {
                if (businessObject.IsValid() == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                }
            }

            _dataObject.Update(businessObject, businessObjectKey);
        }
        catch (System.Exception ex)
        {
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public  HPS.BLL.ChargePriceBLL.BLLChargePrice_T GetBy( HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys keys ) {
        try{
            return _dataObject.SelectByPrimaryKey(keys);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetBy( HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys keys , ref  System.Data.DataSet dataSet,String  srcTable  ){
        try{
                _dataObject.SelectByPrimaryKey(keys,ref dataSet, srcTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetBy( HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys keys , ref System.Data.DataSet dataSet){
        try{
                    _dataObject.SelectByPrimaryKey(keys,ref dataSet);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetBy(  HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys keys, ref System.Data.DataTable dataTable  ){
        try{
                        _dataObject.SelectByPrimaryKey(keys,ref dataTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }





    public List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> GetAll()  {
        try{
            return _dataObject.SelectAll();
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAll(ref  System.Data.DataSet dataSet, String srcTable  ){
        try{
                _dataObject.SelectAll(ref dataSet, srcTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAll(ref System.Data.DataSet dataSet ){
        try{
                    _dataObject.SelectAll(ref dataSet);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAll(ref System.Data.DataTable dataTable ){
        try{
                        _dataObject.SelectAll(ref dataTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public List<HPS.BLL.ChargePriceBLL.BLLChargePrice_T> GetAllBy(  HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField fieldName,Object  value  ) {
        try{
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllBy(  HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField fieldName, Object value  , ref  System.Data.DataSet dataSet, String srcTable  ){
        try{
                _dataObject.SelectByField(fieldName.ToString(), value,ref dataSet, srcTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllBy(  HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField fieldName,Object  value  , ref  System.Data.DataSet dataSet){
        try{
                    _dataObject.SelectByField(fieldName.ToString(), value,ref dataSet);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllBy(  HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField fieldName, Object value  , ref  System.Data.DataTable dataTable){
        try{
                        _dataObject.SelectByField(fieldName.ToString(), value,ref dataTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> GetAllByCondition(String Condition  ) {
        try{
            return _dataObject.SelectByCondition(Condition.ToString());
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllByCondition(String Condition  , ref  System.Data.DataSet dataSet, String srcTable  ){
        try{
                _dataObject.SelectByCondition(Condition.ToString(),ref dataSet, srcTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllByCondition(String Condition  , ref  System.Data.DataSet dataSet){
        try{
                    _dataObject.SelectByCondition(Condition.ToString(),ref dataSet);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllByCondition(String Condition  , ref  System.Data.DataTable dataTable){
        try{
                        _dataObject.SelectByCondition(Condition.ToString(),ref dataTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void Delete(  HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys keys){
        try{
                            _dataObject.Delete(keys);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

     public void Delete( HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField fieldName ,Object  value  ){
         try
         {
                                 _dataObject.DeleteByField(fieldName.ToString(), value);
         }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
         }
     }

   }
}