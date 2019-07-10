using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.CompanyGroupBLL
{

    [System.ComponentModel.DataObject]
    public partial class BLLCompanyGroup_TFactory : BusinessFactoryBase
    {

        protected int _count = -1;
        private HPS.DAL.CompanyGroupDAL.DALCompanyGroup_T _dataObject = null;

        public BLLCompanyGroup_TFactory()
            : base("CompanyGroup_T")
        {
            _dataObject = (HPS.DAL.CompanyGroupDAL.DALCompanyGroup_T)base.DataAccessLayer;
        }

       
        public void Insert(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject)
        {
            try
            {
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueGroupID_int") == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                }

                _dataObject.Insert(businessObject);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

       
        public void Update(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject, HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys businessObjectKey)
        {
            try
            {
                List<string> ExceptList = new List<string>();
                if (businessObject.GroupID_int == businessObjectKey.GroupID_int)
                {
                    ExceptList.Add("UniqueGroupID_int");
                }
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, ExceptList.ToArray()) == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                }

                _dataObject.Update(businessObject, businessObjectKey);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

       
        public void Update(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject)
        {
            try
            {
                List<string> ExceptList = new List<string>();
                ExceptList.Add("UniqueGroupID_int");
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, ExceptList.ToArray()) == false)
                {
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                }

                _dataObject.Update(businessObject);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T GetBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys keys)
        {
            try
            {
                this._count = 1;
                return _dataObject.SelectByPrimaryKey(keys);

            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
        {
            try
            {
                _dataObject.SelectByPrimaryKey(keys, ref dataSet, srcTable);
                this._count = dataSet.Tables[srcTable].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys keys, ref System.Data.DataSet dataSet)
        {
            try
            {
                _dataObject.SelectByPrimaryKey(keys, ref dataSet);
                this._count = 1;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys keys, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByPrimaryKey(keys, ref dataTable);
                this._count = 1;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> GetAll()
        {
            try
            {
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> lst;
                lst = _dataObject.SelectAll();
                this._count = lst.Count;
                return lst;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }



        
        public DataTable GetAllToDataTable()
        {
            try
            {
                DataTable dt;
                dt = _dataObject.SelectAllToDataTable();
                this._count = dt.Rows.Count;
                return dt;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }


        
        public DataView GetAllToDataView(string sortExpression)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = _dataObject.SelectAllToDataTable();
                DataView dv = new DataView(dt);
                dv.Sort = sortExpression;
                this._count = dv.Count;
                return dv;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetAll(ref  System.Data.DataSet dataSet, String srcTable)
        {
            try
            {
                _dataObject.SelectAll(ref dataSet, srcTable);
                this._count = dataSet.Tables[srcTable].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetAll(ref System.Data.DataSet dataSet)
        {
            try
            {
                _dataObject.SelectAll(ref dataSet);
                this._count = dataSet.Tables[dataSet.Tables.Count - 1].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetAll(ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAll(ref dataTable);
                this._count = dataTable.Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> GetAllBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField fieldName, Object value)
        {
            try
            {
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> lst;
                lst = _dataObject.SelectByField(fieldName.ToString(), value);
                this._count = lst.Count;
                return lst;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetAllBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
        {
            try
            {
                _dataObject.SelectByField(fieldName.ToString(), value, ref dataSet, srcTable);
                this._count = dataSet.Tables[srcTable].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetAllBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
        {
            try
            {
                _dataObject.SelectByField(fieldName.ToString(), value, ref dataSet);
                this._count = dataSet.Tables[dataSet.Tables.Count - 1].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void GetAllBy(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByField(fieldName.ToString(), value, ref dataTable);
                this._count = dataTable.Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> GetAllByCondition(String Condition)
        {
            try
            {
                List<HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T> lst;
                lst = _dataObject.SelectByCondition(Condition.ToString());
                this._count = lst.Count;
                return lst;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

       
        public void GetAllByCondition(String Condition, ref  System.Data.DataSet dataSet, String srcTable)
        {
            try
            {
                _dataObject.SelectByCondition(Condition.ToString(), ref dataSet, srcTable);

            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

       
        public void GetAllByCondition(String Condition, ref  System.Data.DataSet dataSet)
        {
            try
            {
                _dataObject.SelectByCondition(Condition.ToString(), ref dataSet);
                this._count = this._count = dataSet.Tables[dataSet.Tables.Count - 1].Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
        
        public void GetAllByCondition(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByCondition(Condition.ToString(), ref dataTable);
                this._count = dataTable.Rows.Count;
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
         
        public void Delete(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_TKeys keys)
        {
            try
            {
                _dataObject.Delete(keys);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        
        public void Delete(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T businessObject)
        {
            try
            {
                _dataObject.Delete(businessObject);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

         
        public void Delete(HPS.BLL.CompanyGroupBLL.BLLCompanyGroup_T.CompanyGroup_TField fieldName, Object value)
        {
            try
            {
                _dataObject.DeleteByField(fieldName.ToString(), value);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

    }
}