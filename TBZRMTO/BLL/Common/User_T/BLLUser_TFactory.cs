using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.UserBLL
{
    public class BLLUser_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.UserDAL.DALUser_T _dataObject = null;

        public BLLUser_TFactory()
            : base("User_T")
        {
            _dataObject = (HPS.DAL.UserDAL.DALUser_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.UserBLL.BLLUser_T businessObject)
        {
            try
            {
                if (businessObject.IsValid() == false)
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

        public void Update(HPS.BLL.UserBLL.BLLUser_T businessObject, HPS.BLL.UserBLL.BLLUser_TKeys businessObjectKey)
        {
            try
            {
                if (businessObject.UserName_nvc == businessObjectKey.UserName_nvc)
                {
                    if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueUserName_nvc") == false)
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

        public HPS.BLL.UserBLL.BLLUser_T GetBy(HPS.BLL.UserBLL.BLLUser_TKeys keys)
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

        public void GetBy(HPS.BLL.UserBLL.BLLUser_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetBy(HPS.BLL.UserBLL.BLLUser_TKeys keys, ref System.Data.DataSet dataSet)
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

        public void GetBy(HPS.BLL.UserBLL.BLLUser_TKeys keys, ref System.Data.DataTable dataTable)
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





        public List<HPS.BLL.UserBLL.BLLUser_T> GetAll()
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

        public List<HPS.BLL.UserBLL.BLLUser_T> GetAllBy(HPS.BLL.UserBLL.BLLUser_T.User_TField fieldName, Object value)
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

        public void GetAllBy(HPS.BLL.UserBLL.BLLUser_T.User_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetAllBy(HPS.BLL.UserBLL.BLLUser_T.User_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
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

        public void GetAllBy(HPS.BLL.UserBLL.BLLUser_T.User_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
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

        public List<HPS.BLL.UserBLL.BLLUser_T> GetAllByCondition(String Condition)
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

        public void Delete(HPS.BLL.UserBLL.BLLUser_TKeys keys)
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

        public void Delete(HPS.BLL.UserBLL.BLLUser_T.User_TField fieldName, Object value)
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

        public BLL.UserBLL.BLLUser_T Login(Hepsa.Core.BLL.BLLUserLogin_T userLoin)
        {
            try
            {
                if (userLoin.IsValid == false)
                    throw new Hepsa.Core.Validation.InvalidBusinessObjectException(userLoin.BrokenRulesList.ToString());
                BLL.UserBLL.BLLUser_T UserEntity = new BLLUser_T();
                BLL.UserBLL.BLLUser_TKeys UserKey = new BLLUser_TKeys();
                UserKey.UserName_nvc = userLoin.UserName_nvc;
                UserEntity = this.GetBy(UserKey);
                if (UserEntity != null && UserEntity.Password_nvc == userLoin.Password_nvc)
                {
                    if (UserEntity.Active_bit == true)
                    {
                        string ServerDate = this.ServerJalaliDate;
                        if (string.IsNullOrEmpty(UserEntity.StartDate_vc) == false && UserEntity.StartDate_vc.CompareTo(ServerDate) > 0)
                            throw new Hepsa.Core.Exception.UserStartDateError(UserEntity.StartDate_vc);
                        else if (string.IsNullOrEmpty(UserEntity.ExpireDate_vc) == false && UserEntity.ExpireDate_vc.CompareTo(ServerDate) < 0)
                            throw new Hepsa.Core.Exception.UserStartDateError(UserEntity.ExpireDate_vc);
                        else
                            return UserEntity; 
                    }
                    else 
                    {
                        throw new Hepsa.Core.Exception.UserIsNotActive();
                    }
                }
                else
                {
                    throw new ApplicationException("نام کاربری یا رمز عبور اشتباه است یا گروه کاربر غیر فعال میباشد");
                }
            }
            catch (Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
                // Hepsa.Core.throw Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

    }
}