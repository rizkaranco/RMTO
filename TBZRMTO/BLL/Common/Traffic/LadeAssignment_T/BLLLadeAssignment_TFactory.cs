using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.LadeAssignmentBLL
{
    public class BLLLadeAssignment_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.LadeAssignmentDAL.DALLadeAssignment_T _dataObject = null;

        public BLLLadeAssignment_TFactory()
            : base("LadeAssignment_T")
        {
            _dataObject = (HPS.DAL.LadeAssignmentDAL.DALLadeAssignment_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject)
        {
            try
            {
                if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueLadeAssignmentID_bint", "PriceNormRule") == false)
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

        public void Update(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject, HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey)
        {
            try
            {
                if (businessObject.LadeAssignmentID_bint == businessObjectKey.LadeAssignmentID_bint)
                {
                    if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "UniqueLadeAssignmentID_bint", "PriceNormRule") == false)
                    {
                        throw new Hepsa.Core.Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList().ToString());
                    }
                }
                else
                {
                    if (businessObject.IsValid(Hepsa.Core.Validation.ValidationExceptionType.Except, "PriceNormRule") == false)
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

        public HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T GetBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys keys)
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

        public void GetBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys keys, ref System.Data.DataSet dataSet)
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

        public void GetBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys keys, ref System.Data.DataTable dataTable)
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

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> GetAll()
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

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> GetAllBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField fieldName, Object value)
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

        public void GetAllBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetAllBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
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

        public void GetAllBy(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
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

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> GetAllByCondition(String Condition)
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

        public void GetAllByCondition(String Condition, Int32? SaloonID_int, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByCondition(Condition.ToString(),SaloonID_int, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void Delete(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys keys)
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

        public void Delete(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField fieldName, Object value)
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

        //Later Added
        public void GetAllActives(ref System.Data.DataTable dataTable, string LaderTypesID_nvc)
        {
            try
            {
                _dataObject.SelectAllActives(ref dataTable, LaderTypesID_nvc);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllLadBillCount(string Date, Int32 SaloonID_int, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllLadBillCount(Date, SaloonID_int, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }    

        public void GetAllByConditionReport(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionReport(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllLadBillCreditUsedLadBill(ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllLadBillCreditUsedLadBill(ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAll(ref System.Data.DataTable dataTable, string Date, int SaloonID_int)
        {
            try
            {
                _dataObject.SelectAll(ref dataTable, Date,SaloonID_int);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
 
        public void SelectLaderTypeCountReport(string FromDate, string FromTime, string ToDate, string ToTime,string LaderTypeIDList_nvc, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectLaderTypeCountReport(FromDate, FromTime, ToDate, ToTime,LaderTypeIDList_nvc, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectCompanyLadeAssignmentDetail(string FromDate, string FromTime, string ToDate, string ToTime, String LaderTypeID, String CompanyID, String GoodIDList, String DestincationCityIDList, String PortPlaceIDList, string OrderColumns_nvc, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectCompanyLadeAssignmentDetail(FromDate, FromTime, ToDate, ToTime, LaderTypeID, CompanyID, GoodIDList, DestincationCityIDList, PortPlaceIDList, OrderColumns_nvc, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLaderTypeCountWithDateReport(string FromDate, string FromTime, string ToDate, string ToTime,String LaderTypeList_nvc, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectLaderTypeCountWithDateReport(FromDate, FromTime, ToDate, ToTime,LaderTypeList_nvc, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLadeUserDetailReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectLadeUserDetailReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetLastLadeAssignmentID(out Int64 LadeAssignmentID_bint)
        {
            try
            {
                _dataObject.SelectLastLadeAssignmentID(out LadeAssignmentID_bint);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetForAccept(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectForAccept(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLadeAssingmentContByLaderType(String Date_nvc, ref DataTable DataTable)
        {
            try
            {
                _dataObject.SelectLadeAssingmentContByLaderType(Date_nvc, ref DataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectRemaindLadAssingmentByLaderType(String Date_nvc, ref DataTable DataTable)
        {
            try
            {
                _dataObject.SelectRemaindLadAssingmentByLaderType(Date_nvc, ref DataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectRemainedDetailSelectByCondition(string Condition_nvc,  DataTable DataTable)
        {
            try
            {
                _dataObject.SelectRemainedDetailSelectByCondition(Condition_nvc, DataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectCompanyRemainedReport(string FromDate, string FromTime, string ToDate, string ToTime, string LaderTypeList_nvc, string CompanyList_nvc, string GoodIDlist, string DestinationCityIDList, string PortPlaceList, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectCompanyRemainedReport(FromDate, FromTime, ToDate, ToTime, LaderTypeList_nvc, CompanyList_nvc, GoodIDlist, DestinationCityIDList, PortPlaceList, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectUsedLadBill(string FromDate, string ToDate, string CompanyCodeList_nvc,string LaderTypeCodeList_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectUsedLadBill(FromDate, ToDate, CompanyCodeList_nvc, LaderTypeCodeList_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLastPerBarnameDate(out string LastDate_vc)
        {
            try
            {
                _dataObject.SelectLastPerBarnameDate(out LastDate_vc);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
    }
}