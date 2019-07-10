using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.TurnManagementBLL
{
    public class BLLTurnManagement_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.TurnManagementDAL.DALTurnManagement_T _dataObject = null;

        public BLLTurnManagement_TFactory()
            : base("TurnManagement_T")
        {
            _dataObject = (HPS.DAL.TurnManagementDAL.DALTurnManagement_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject)
        {
            try
            {
                List<string> ExceptList = new List<string>();
                ExceptList.AddRange(new string[] { "DuplicateTurnNumberInUpdateRule", "DuplicateTurnNumberInUpdateRule" });
                ExceptList.AddRange(new string[] { "UniqueTurnManagementID_int", "UniqueTurnManagementID_int" });

                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, ExceptList.ToArray()) == false)
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

        public void Update(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T businessObject, HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys businessObjectKey)
        {
            try
            {
                if (businessObject.TurnManagementID_int == businessObjectKey.TurnManagementID_int)
                {
                    List<string> ExceptList = new List<string>();
                    ExceptList.AddRange(new string[] { "DuplicateTurnNumberInUpdateRule", "DuplicateTurnNumberInUpdateRule" });
                    ExceptList.AddRange(new string[] { "UniqueTurnManagementID_int", "UniqueTurnManagementID_int" });

                    if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, ExceptList.ToArray()) == false)
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

        public HPS.BLL.TurnManagementBLL.BLLTurnManagement_T GetBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys keys)
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

        public void GetBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys keys, ref System.Data.DataSet dataSet)
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

        public void GetBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys keys, ref System.Data.DataTable dataTable)
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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> GetAll()
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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> GetAllBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField fieldName, Object value)
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

        public void GetAllBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetAllBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
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

        public void GetAllBy(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
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

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> GetAllByCondition(String Condition)
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

        public void Delete(HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys keys)
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

        public void Delete(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField fieldName, Object value)
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

        //LaterAdded
        public void GetAllWithTrafficForCancelTurn(Int64? TrafficNumber_bint, Int64? AcceptedturnNumber_bint, string NumberPlate_nvc, string SerialPlate_nvc,string FromDate_nvc,string ToDate_nvc, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllWithTrafficForCancelTurn(TrafficNumber_bint,AcceptedturnNumber_bint,NumberPlate_nvc,SerialPlate_nvc,FromDate_nvc,ToDate_nvc,ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllWithTrafficForReturnTurn(string Date, string Time, Int64? TrafficNumber_bint, Int64? AcceptedturnNumber_bint, string NumberPlate_nvc, string SerialPlate_nvc, string FromDate_nvc, string ToDate_nvc, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllWithTrafficForReturnTurn(Date,Time,TrafficNumber_bint,AcceptedturnNumber_bint,NumberPlate_nvc,SerialPlate_nvc,FromDate_nvc,ToDate_nvc, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public List<HPS.BLL.TurnManagementBLL.BLLTurnManagement_T> GetAllByConditionWithTraffic(String Condition)
        {
            try
            {
                return _dataObject.SelectByConditionWithTraffic(Condition.ToString());
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionWithTraffic(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionWithTraffic(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetCanceledTurn(ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectCanceledTurn(ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectSMSInfo(Int32 LaderTypeID_bint, String Date_nvc, ref Int64 LastAcceptedTurnNumber_bint, ref Int32 LaderTypeCount_int, ref Int32 RemaindLaderTypeCount_int)
        {
            try
            {
                _dataObject.SelectSMSInfo(LaderTypeID_bint, Date_nvc, ref LastAcceptedTurnNumber_bint, ref LaderTypeCount_int, ref RemaindLaderTypeCount_int);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectCanceledTurn(String Date_nvc, ref DataTable DataTable)
        {
            try
            {
                _dataObject.SelectCanceledTurn(Date_nvc, ref DataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
    }
}