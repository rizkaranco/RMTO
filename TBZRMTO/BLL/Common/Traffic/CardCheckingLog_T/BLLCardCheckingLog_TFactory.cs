using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.CardCheckingLogBLL
{
    public partial class BLLCardCheckingLog_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.CardCheckingLogDAL.DALCardCheckingLog_T _dataObject = null;

        public BLLCardCheckingLog_TFactory()
            : base("CardCheckingLog_T")
        {
            _dataObject = (HPS.DAL.CardCheckingLogDAL.DALCardCheckingLog_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject)
        {
            try
            {
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueCardCheckingLogID_int") == false)
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

        public void Update(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T businessObject, HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys businessObjectKey)
        {
            try
            {
                List<string> ExceptList = new List<string>();
                if (businessObject.CardCheckingLogID_int == businessObjectKey.CardCheckingLogID_int)
                {
                    ExceptList.Add("UniqueCardCheckingLogID_int");
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

        public HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T GetBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys keys)
        {
            try
            {
                return _dataObject.SelectByPrimaryKey(keys);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
        {
            try
            {
                _dataObject.SelectByPrimaryKey(keys, ref dataSet, srcTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys keys, ref System.Data.DataSet dataSet)
        {
            try
            {
                _dataObject.SelectByPrimaryKey(keys, ref dataSet);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys keys, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByPrimaryKey(keys, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> GetAll()
        {
            try
            {
                return _dataObject.SelectAll();
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
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> GetAllBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField fieldName, Object value)
        {
            try
            {
                return _dataObject.SelectByField(fieldName.ToString(), value);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
        {
            try
            {
                _dataObject.SelectByField(fieldName.ToString(), value, ref dataSet, srcTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
        {
            try
            {
                _dataObject.SelectByField(fieldName.ToString(), value, ref dataSet);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllBy(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByField(fieldName.ToString(), value, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public List<HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T> GetAllByCondition(String Condition)
        {
            try
            {
                return _dataObject.SelectByCondition(Condition.ToString());
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
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void Delete(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_TKeys keys)
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

        public void Delete(HPS.BLL.CardCheckingLogBLL.BLLCardCheckingLog_T.CardCheckingLog_TField fieldName, Object value)
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