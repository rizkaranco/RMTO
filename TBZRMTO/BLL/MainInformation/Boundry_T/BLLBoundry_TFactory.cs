using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.BoundryBLL
{
public class BLLBoundry_TFactory: BusinessFactoryBase
    {
    private HPS.DAL.BoundryDAL.DALBoundry_T _dataObject = null;

    public BLLBoundry_TFactory()
        :base("Boundry_T")
    {
        _dataObject = (HPS.DAL.BoundryDAL.DALBoundry_T)base.DataAccessLayer;
    }

    public void Insert(HPS.BLL.BoundryBLL.BLLBoundry_T businessObject){
        try{
            if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except,"BoundryID_int") == false) {
throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
}

            _dataObject.Insert(businessObject);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void Update(  HPS.BLL.BoundryBLL.BLLBoundry_T businessObject,  HPS.BLL.BoundryBLL.BLLBoundry_TKeys  businessObjectKey){
        try{
            if( businessObject.BoundryID_int == businessObjectKey.BoundryID_int )
{
if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except,"UniqueBoundryID_int") == false) {
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
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public  HPS.BLL.BoundryBLL.BLLBoundry_T GetBy( HPS.BLL.BoundryBLL.BLLBoundry_TKeys keys ) {
        try{
            return _dataObject.SelectByPrimaryKey(keys);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetBy( HPS.BLL.BoundryBLL.BLLBoundry_TKeys keys , ref  System.Data.DataSet dataSet,String  srcTable  ){
        try{
                _dataObject.SelectByPrimaryKey(keys,ref dataSet, srcTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetBy( HPS.BLL.BoundryBLL.BLLBoundry_TKeys keys , ref System.Data.DataSet dataSet){
        try{
                    _dataObject.SelectByPrimaryKey(keys,ref dataSet);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetBy(  HPS.BLL.BoundryBLL.BLLBoundry_TKeys keys, ref System.Data.DataTable dataTable  ){
        try{
                        _dataObject.SelectByPrimaryKey(keys,ref dataTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }





    public List< HPS.BLL.BoundryBLL.BLLBoundry_T> GetAll()  {
        try{
            return _dataObject.SelectAll();
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAll(ref  System.Data.DataSet dataSet, String srcTable  ){
        try
        {
                _dataObject.SelectAll(ref dataSet, srcTable);
        }
        catch(System.Exception ex)
        {
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

    public List<HPS.BLL.BoundryBLL.BLLBoundry_T> GetAllBy(  HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField fieldName,Object  value  ) {
        try{
            return _dataObject.SelectByField(fieldName.ToString(), value);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllBy(  HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField fieldName, Object value  , ref  System.Data.DataSet dataSet, String srcTable  ){
        try{
                _dataObject.SelectByField(fieldName.ToString(), value,ref dataSet, srcTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllBy(  HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField fieldName,Object  value  , ref  System.Data.DataSet dataSet){
        try{
                    _dataObject.SelectByField(fieldName.ToString(), value,ref dataSet);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public void GetAllBy(  HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField fieldName, Object value  , ref  System.Data.DataTable dataTable){
        try{
                        _dataObject.SelectByField(fieldName.ToString(), value,ref dataTable);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

    public List< HPS.BLL.BoundryBLL.BLLBoundry_T> GetAllByCondition(String Condition  ) {
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

    public void Delete(  HPS.BLL.BoundryBLL.BLLBoundry_TKeys keys){
        try{
                            _dataObject.Delete(keys);
        }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
        }
    }

     public void Delete( HPS.BLL.BoundryBLL.BLLBoundry_T.Boundry_TField fieldName ,Object  value  ){
         try
         {
              _dataObject.DeleteByField(fieldName.ToString(), value);
         }catch(System.Exception ex){
            throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
         }
     }

   }
}