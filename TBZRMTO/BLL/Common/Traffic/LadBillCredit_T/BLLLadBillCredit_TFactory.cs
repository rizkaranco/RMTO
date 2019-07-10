using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.LadBillCreditBLL
{
    public class BLLLadBillCredit_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.LadBillCreditDAL.DALLadBillCredit_T _dataObject = null;

        public BLLLadBillCredit_TFactory()
            : base("LadBillCredit_T")
        {
            _dataObject = (HPS.DAL.LadBillCreditDAL.DALLadBillCredit_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject)
        {
            try
            {
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueLadBillCreditID_int") == false)
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

        public void Update(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T businessObject, HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys businessObjectKey)
        {
            try
            {
                if (businessObject.LadBillCreditID_int == businessObjectKey.LadBillCreditID_int)
                {
                    if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueLadBillCreditID_int") == false)
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

        public HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T GetBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys keys)
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

        public void GetBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys keys, ref System.Data.DataSet dataSet)
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

        public void GetBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys keys, ref System.Data.DataTable dataTable)
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

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> GetAll()
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

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField fieldName, Object value)
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

        public void GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
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

        public void GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
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

        public List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> GetAllByCondition(String Condition)
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

        public void Delete(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys keys)
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

        public void Delete(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField fieldName, Object value)
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

        /////LaterAdded
        public void GetAllLadeAssignment(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TKeys keys, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllLadeAssignment(keys, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GetAllWithTrafficLadBillCredit(ref System.Data.DataTable dataTable, string Date)
        {
            try
            {
                _dataObject.SelectAllWithTrafficLadBillCredit(ref dataTable, Date);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllWithTrafficLadBillCreditByConditon(String Condition, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllWithTrafficLadBillCreditByConditon(Condition, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void GetActives(ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectActives(ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetLastStatusForCancelLadBillCredit(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.GetLastStatusForCancelLadBillCredit(NumberPlate_nvc, SerialPlate_nvc, CarCardNumber_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetLadBillCreditTrafficStatus(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)//, string CarCardNumber_nvc
        {
            try
            {
                _dataObject.GetLadBillCreditTrafficStatus(NumberPlate_nvc, SerialPlate_nvc, dataTable);//, CarCardNumber_nvc
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLadBillCreditByLaderType(String Date_nvc, ref DataTable DataTable)
        {
            try
            {
                _dataObject.SelectLadBillCreditByLaderType(Date_nvc,ref DataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLadBillCreditOrderColumn(System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectLadBillCreditOrderColumn(dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectCompanyRemainedLadBillReportOrderColumns(System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectCompanyRemainedLadBillReportOrderColumns(dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

    }
}