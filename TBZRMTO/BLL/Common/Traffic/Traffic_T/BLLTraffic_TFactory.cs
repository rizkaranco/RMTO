using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using HPS.BLL.BusinessFactoryMain;

namespace HPS.BLL.TrafficBLL
{
    public class BLLTraffic_TFactory : BusinessFactoryBase
    {
        private HPS.DAL.TrafficDAL.DALTraffic_T _dataObject = null;

        public BLLTraffic_TFactory()
            : base("Traffic_T")
        {
            _dataObject = (HPS.DAL.TrafficDAL.DALTraffic_T)base.DataAccessLayer;
        }

        public void Insert(HPS.BLL.TrafficBLL.BLLTraffic_T businessObject)
        {
            try
            {
                List<string> ExceptList = new List<string>();
                ExceptList.AddRange(new string[] { "UniqueTrafficID_bint", "DriverInfractionRule" });
                ExceptList.AddRange(new string[] { "DuplicateTurnNumberInUpdateRule", "DuplicateTurnNumberInUpdateRule" });
                ExceptList.AddRange(new string[] { "UniqueDriverMobileNumber_nvc", "UniqueNationalCode_int", "UpdateDriverDuplicateNumberRule" });
                if (businessObject.TrafficTypeID_int == 3)
                    ExceptList.Add("System_nvc");
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

        public void Update(HPS.BLL.TrafficBLL.BLLTraffic_T businessObject, HPS.BLL.TrafficBLL.BLLTraffic_TKeys businessObjectKey)
        {
            try
            {
                List<string> ExceptList = new List<string>();
                ExceptList.AddRange(new string[] { "UniqueTrafficID_bint", "DriverInfractionRule" });
                ExceptList.AddRange(new string[] { "UniqueDriverMobileNumber_nvc", "UniqueNationalCode_int", "InsertDriverDuplicateNumberRule" });
                ExceptList.AddRange(new string[] { "DuplicateTurnNumberInUpdateRule", "DuplicateTurnNumberInUpdateRule" });
                HPS.BLL.TrafficBLL.BLLTraffic_T trafficEntity = new BLLTraffic_T();
 
                if (businessObject.TrafficTypeID_int == 3)
                    ExceptList.Add("System_nvc");
                if (businessObject.TrafficID_bint == businessObjectKey.TrafficID_bint)
                {
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

        public HPS.BLL.TrafficBLL.BLLTraffic_T GetBy(HPS.BLL.TrafficBLL.BLLTraffic_TKeys keys)
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

        public void GetBy(HPS.BLL.TrafficBLL.BLLTraffic_TKeys keys, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetBy(HPS.BLL.TrafficBLL.BLLTraffic_TKeys keys, ref System.Data.DataSet dataSet)
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

        public void GetBy(HPS.BLL.TrafficBLL.BLLTraffic_TKeys keys, ref System.Data.DataTable dataTable)
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

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> GetAll()
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

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField fieldName, Object value)
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

        public void GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField fieldName, Object value, ref  System.Data.DataSet dataSet, String srcTable)
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

        public void GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField fieldName, Object value, ref  System.Data.DataSet dataSet)
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

        public void GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField fieldName, Object value, ref  System.Data.DataTable dataTable)
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

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> GetAllByCondition(String Condition)
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

        public void Delete(HPS.BLL.TrafficBLL.BLLTraffic_TKeys keys)
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

        public void Delete(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField fieldName, Object value)
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
        public void GetAllByConditionAllTraffic(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionAllTraffic(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionAllInTraffic(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionAllInTraffic(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionAllInForOutTraffic(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionAllInTrafficForOut(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public List<HPS.BLL.TrafficBLL.BLLTraffic_T> GetAllByConditionAllInTraffic(String Condition)
        {
            try
            {
                return _dataObject.SelectByConditionAllInTraffic(Condition.ToString());
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public Int64 GetLastTurnNumber()
        {
            try
            {
                return _dataObject.GetLastTurnNumber();
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionWithLadBill(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllByConditionWithLadBill(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllTemporaryOutByCondition(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllTepmoraryOutByCondition(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionAllInTrafficNotTemporaryOut(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionAllInTrafficNotTemporaryOut(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionAllInTrafficForTurnAcception(String Condition,ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionAllInTrafficForTurnAcception(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectByFieldReportAllTraffic(string FromDateTimenvc, string ToDateTimenvc, string FromTrafficNumbernvc, string ToTrafficNumbernvc, string LaderPivotGroupIDnvc, string LaderTypeIDnvc, string TrafficTypeIDnvc, string Inbit, string Outbit,string ServicesID,string TurnAccepted, ref System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByFieldReportAllTraffic(FromDateTimenvc, ToDateTimenvc, FromTrafficNumbernvc, ToTrafficNumbernvc, LaderPivotGroupIDnvc, LaderTypeIDnvc, TrafficTypeIDnvc, Inbit, Outbit,ServicesID,TurnAccepted, ref dataTable);
            }
            catch (Exception ex)
            {

                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectByDriverField(string FirstName, string LastName, Int64 NationalCode, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByDriverField(FirstName,LastName,NationalCode, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllAutoComplete(String Condition, System.Windows.Forms.AutoCompleteStringCollection Collection)
        {
            try
            {
                _dataObject.SelectAutoComplete(Condition, Collection);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAllInTrafficReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllInTrafficReport(FromDate,FromTime,ToDate,ToTime , ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAllOutTrafficReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllOutTrafficReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAllInServiceTypeReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllInServicetypeReport (FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAllOutServiceTypeReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllOutServicetypeReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectUsersPriceReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectUsersPriceReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectTurnAcceptedWithFields(ref System.Data.DataTable dataTable, string AcceptedTurnNumber, string TrafficNumber, string NumberPlate, string SerialPlate, string FromDate,string ToDate,string LastName)
        {
            try
            {
                _dataObject.SelectTurnAcceptedWithFields(ref dataTable, AcceptedTurnNumber, TrafficNumber, NumberPlate, SerialPlate, FromDate, ToDate, LastName);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectTurnAccepted(ref System.Data.DataTable dataTable, string Date, Int64 AcceptedTurnNumber)
        {
            try
            {
                _dataObject.SelectTurnAccepted(ref dataTable, Date,AcceptedTurnNumber);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void PreviousNavigation(int TrafficTypeID, Int64? TrafficNumber, DataTable dataTable)
        {
            try
            {
                 _dataObject.PreviousNavigation(TrafficTypeID,TrafficNumber,dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void NextNavigation(int TrafficTypeID, Int64? TrafficNumber, DataTable dataTable)
        {
            try
            {
                _dataObject.NextNavigation(TrafficTypeID, TrafficNumber, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetAllByConditionOut(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllByConditionOut(Condition, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void PreviousTurnNavigation(Int64? TrafficNumber, DataTable dataTable)
        {
            try
            {
                _dataObject.PreviousTurnNavigation(TrafficNumber, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void NextTurnNavigation(Int64? TrafficNumber, DataTable dataTable)
        {
            try
            {
                _dataObject.NextTurnNavigation( TrafficNumber, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void FindLaderTypeInTraffic(string NumberPlate, string SerialPlate, Int32 PlateCityID, DataTable dataTable)
        {
            try
            {
                _dataObject.FindLaderTypeInTraffic(NumberPlate,SerialPlate,PlateCityID, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void CheckWithLadBillCreditAndTurnStatus(string AcceptedTurnNumber, string TrafficNumber, string NumberPlate, string TurnDate, DataTable dataTable)
        {
            try
            {
                _dataObject.CheckWithLadBillCreditAndTurnStatus(AcceptedTurnNumber,TrafficNumber,NumberPlate,TurnDate, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void CheckWithLadBillCreditAndTurnStatusForInsertOut( string TrafficNumber, string NumberPlate, DataTable dataTable)
        {
            try
            {
                _dataObject.CheckWithLadBillCreditAndTurnStatusForInsertOut( TrafficNumber, NumberPlate,dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAllInReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllInReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public HPS.BLL.TrafficBLL.BLLTraffic_T.TrafficStatus GetCarStatus(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc)
        {
            try
            {
                return _dataObject.GetCarStatus(NumberPlate_nvc, SerialPlate_nvc, CarCardNumber_nvc);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetLastStatus(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.GetLastStatus(NumberPlate_nvc, SerialPlate_nvc, CarCardNumber_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public Int64 GetLastTrafficNumber()
        {
            try
            {
                return _dataObject.GetLastTrafficNumber();
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetLastStatusForAcceptTurn(Int64 TrafficID_bint, DataTable dataTable)
        {
            try
            {
                _dataObject.GetLastStatusForAcceptTurn(TrafficID_bint, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetTrafficLadBillCreditStatusForTurnAccepted(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)//, string CarCardNumber_nvc
        {
            try
            {
                _dataObject.GetTrafficLadBillCreditStatusForTurnAccepted(NumberPlate_nvc, SerialPlate_nvc, dataTable);//, CarCardNumber_nvc
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetTrafficStatus(string NumberPlate_nvc, string SerialPlate_nvc, string CarCardNumber_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.GetTrafficStatus(NumberPlate_nvc, SerialPlate_nvc, CarCardNumber_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetTurnStatus(string NumberPlate_nvc, string SerialPlate_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.GetTurnStatus(NumberPlate_nvc, SerialPlate_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectLaderTypeTurnReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectLaderTypeTurnReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAllInServiceTypeWithPivotReport(string FromDate, string FromTime, string ToDate, string ToTime, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAllInServiceTypeWithPivotReport(FromDate, FromTime, ToDate, ToTime, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAvgAgeReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            try
            {
                _dataObject.SelectAvgAgeReport(FromDate, FromTime, ToDate, ToTime, ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void GetConditionLastTraffic(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectConditionLastTraffic(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectByConditionSelectionTraffic(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionSelectionTraffic(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectDriverMobile_nvc(String Condition, ref DataTable DataTable)
        {
            try
            {
                _dataObject.SelectDriverMobile_nvc(Condition, ref DataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAcceptedTurnNumber(String DriverMobile_nvc, string LaderTypeID_nvc, ref String lastLadBillCrediteTurnNumber, ref string DriverAcceptedTurnNumber_bint)
        {
            try
            {
                _dataObject.SelectAcceptedTurnNumber(DriverMobile_nvc, LaderTypeID_nvc, ref lastLadBillCrediteTurnNumber, ref DriverAcceptedTurnNumber_bint);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectRemainedLaderTypeCountReport(string FromDate, string ToDate,  DataTable dataTable)
        {
            try
            {
                _dataObject.SelectRemainedLaderTypeCountReport(FromDate, ToDate,dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectRemainedAcceptedTurnNumberByLaderTypeReport(string FromDate, string ToDate, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectRemainedAcceptedTurnNumberByLaderTypeReport(FromDate, ToDate, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectInTurnAcceptedForDelete(string ToDate, string LaderTypeID_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectInTurnAcceptedForDelete(ToDate, LaderTypeID_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
        public void SelectByPlate(string NumberPlate_nvc, string SerialPlate_nvc,  DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByPlate(NumberPlate_nvc, SerialPlate_nvc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectDriverDuplicateNumber(string DriverMobileNumber_nvc,Int64? NationalCode_bint, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectDriverDuplicateNumber(DriverMobileNumber_nvc,NationalCode_bint , dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectRemainedAcceptedTurnNumberByLaderTypeWithDateReport(string FromDate,string FromTime,string ToTime, string ToDate, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectRemainedAcceptedTurnNumberByLaderTypeWithDateReport(FromDate,ToDate,FromTime,ToTime, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectTurnAcceptedWithoutLadBill(ref System.Data.DataTable dataTable, string AcceptedTurnNumber, string TrafficNumber, string NumberPlate, string SerialPlate, string FromDate, string ToDate, string LastName)
        {
            try
            {
                _dataObject.SelectTurnAcceptedWithoutLadBill(ref dataTable, AcceptedTurnNumber, TrafficNumber, NumberPlate, SerialPlate, FromDate, ToDate, LastName);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void TurnAndLadeAssignmentInfoByLaderTypeReport(string FromDate, string FromTime, string ToDate, string ToTime, Int32? laderTypeID_int, ref DataTable dataTable)
        {
            try
            {
                _dataObject.TurnAndLadeAssignmentInfoByLaderTypeReport(FromDate, FromTime, ToDate, ToTime, laderTypeID_int, ref dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void DuplicateTurnsReport(DataTable dataTable)
        {
            try
            {
                _dataObject.DuplicateTurnsReport(dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        public void SelectDuplicateTurnByDrivers(DataTable dataTable, string DriverCardNumber)
        {
            try
            {
                _dataObject.SelectDuplicateTurnByDrivers(dataTable,DriverCardNumber);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void WaitingLaderTypesReport(string FromDate,string FromTime,string ToDate,string ToTime,Int32? laderTypeID_int, ref DataTable dataTable)
        {
            try
            {
                _dataObject.WaitingLaderTypesReport(FromDate, FromTime, ToDate, ToTime, laderTypeID_int, ref dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void SelectInNotOutCount(Int32 TrafficTypeID_int, System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectInNotOutCount(TrafficTypeID_int, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }

        public void SelectAcceptedTurns(System.Data.DataTable dataTable, string condition)
        {
            try
            {
                _dataObject.SelectAcceptedTurns(dataTable,condition);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }


        public void SelectCanceledTurns(string FromDate_nvc, string ToDate_nvc, string FromTime_nvc, string ToTime_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectCanceledTurns(FromDate_nvc,ToDate_nvc, FromTime_nvc, ToTime_nvc, dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void SelectActiveTurns(string FromDate_nvc, string FromTime_nvc, string ToDate_nvc, string ToTime_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectActiveTurns(FromDate_nvc, ToDate_nvc, FromTime_nvc, ToTime_nvc, dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void SelectReturnedTurns(string FromDate_nvc, string FromTime_nvc, string ToDate_nvc, string ToTime_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectReturnedTurns(FromDate_nvc, ToDate_nvc, FromTime_nvc, ToTime_nvc, dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void SelectActiveTurnsForInTraffic(string NumberPlate_nvc, string SerialPlate_nvc, string FromDate_nvc, string FromTime_nvc, string ToDate_nvc, string ToTime_nvc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectActiveTurnsForInTraffic(NumberPlate_nvc, SerialPlate_nvc, FromDate_nvc, ToDate_nvc, FromTime_nvc, ToTime_nvc, dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        public void LadeAssignmentInfoByLaderType(string FromDate, string FromTime, string ToDate, string ToTime, Int32? laderTypeID_int, ref DataTable dataTable)
        {
            try
            {
                _dataObject.LadeAssignmentInfoByLaderType(FromDate, FromTime, ToDate, ToTime, laderTypeID_int, ref dataTable);
            }
            catch (System.Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        //***********************************نوع و تاریخ آخرین مراجعه به پایانه گزارش 93-06-17
        public void SelectTypeandLasteIn(string FromDate_vc, string ToDate_vc, string FromTime_vc, string ToTime_vc, DataTable dataTable)
        {
            try
            {
                _dataObject.SelectTypeandLasteIn(FromDate_vc, ToDate_vc,FromTime_vc, ToTime_vc, dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
        //**********************************
        public void GetAllByConditionAllInTrafficArea(String Condition, ref  System.Data.DataTable dataTable)
        {
            try
            {
                _dataObject.SelectByConditionAllInTrafficArea(Condition.ToString(), ref dataTable);
            }
            catch (System.Exception ex)
            {
                throw Hepsa.Core.Exception.HandleException.ChangeExceptionLanguage(ex, this);
            }
        }
      
    }
}