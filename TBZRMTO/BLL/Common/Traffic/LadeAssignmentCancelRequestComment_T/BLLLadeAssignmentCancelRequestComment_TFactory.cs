using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.LadeAssignmentCancelRequestCommentBLL
{
    public class BLLLadeAssignmentCancelRequestComment_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.LadeAssignmentCancelRequestCommentDAL.DALLadeAssignmentCancelRequestComment_T _dataObject = null;

        public BLLLadeAssignmentCancelRequestComment_TFactory()
            : base("LadeAssignmentCancelRequestComment_T")
        {
            _dataObject = (HPS.DAL.LadeAssignmentCancelRequestCommentDAL.DALLadeAssignmentCancelRequestComment_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject)
        {
            try
            {
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueLadeAssignmentCancelRequestCommentID_int") == false)
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

        public void Update(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject, HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey)
        {
            try
            {
                if (businessObject.LadeAssignmentCancelRequestCommentID_int == businessObjectKey.LadeAssignmentCancelRequestCommentID_int)
                {
                    if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueLadeAssignmentCancelRequestCommentID_int") == false)
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

        public HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T GetBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys keys)
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

        public void GetBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys keys, ref System.Data.DataSet dataSet)
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

        public void GetBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys keys, ref System.Data.DataTable dataTable)
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





        public List<HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> GetAll()
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

        public List<HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> GetAllBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField fieldName, Object value)
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

        public void GetAllBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetAllBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
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

        public void GetAllBy(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
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

        public List<HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> GetAllByCondition(String Condition)
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

        public void Delete(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys keys)
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

        public void Delete(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField fieldName, Object value)
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