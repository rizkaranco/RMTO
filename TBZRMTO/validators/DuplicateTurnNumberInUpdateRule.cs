using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HPS.validators
{
    class DuplicateTurnNumberInUpdateRule : Hepsa.Core.Validation.BaseRule
    {
        public DuplicateTurnNumberInUpdateRule(string PropertyName, string FriendlyName)
            : base(PropertyName, FriendlyName)
        {
            this.Field = null;
            this.Field = new string[6];
            Field[0] = "ServiceID_int";
            Field[1] = "NumberPlate_nvc";
            Field[2] = "SerialPlate_nvc";
            Field[3] = "TrafficID_bint";
            Field[4] = "CarCardNumber_nvc";
            Field[5] = "TrafficNumber_bint";
        }

        public override bool Validate(params object[] value)
        {
            try
            {
                this.Description = string.Empty;
                if (value.Length != Field.Length)
                {
                    this.Description = Hepsa.Core.My.Resources.ValidationMessage.IncorrectDataType;
                    return false;
                }

                Int32? ServiceID_int = (Int32?)value[0];
                string NumberPlate_nvc = Convert.ToString(value[1]);
                string SerialPlate_nvc = Convert.ToString(value[2]);
                Int64? TrafficID_bint = (Int64?)value[3];
                Int64? TrafficNumber_bint = (Int64?)value[5];
                string CarCardNumber_nvc = string.Empty;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
                if (string.IsNullOrEmpty(NumberPlate_nvc) && string.IsNullOrEmpty(SerialPlate_nvc))
                {
                    HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                    TrafficKey.TrafficID_bint = TrafficID_bint.Value;
                   
                    TrafficEntity = TrafficFactory.GetBy(TrafficKey);
                    if (TrafficEntity!=null)
                    {
                        ServiceID_int = TrafficEntity.ServiceID_int;
                        NumberPlate_nvc = TrafficEntity.NumberPlate_nvc;
                        SerialPlate_nvc = TrafficEntity.SerialPlate_nvc;
                    }
                }

                /////////////////////////////////////
                #region AcceptTurn Conditions
                
                DataTable TrafficStatusDataTable = new DataTable();
                TrafficFactory.GetLastStatus(NumberPlate_nvc, SerialPlate_nvc, CarCardNumber_nvc, TrafficStatusDataTable);



                if (ServiceID_int.HasValue && ServiceID_int.Value == 2)
                {
                    if (TrafficStatusDataTable != null && TrafficStatusDataTable.Rows.Count > 0)
                    {
                        Int64 LastTrafficID_bint = 0;
                        if (Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TrafficID_bint"], TypeCode.Int64) != null)
                        {
                            LastTrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TrafficID_bint"], TypeCode.Int64);
                        }
                        bool? HasTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasTurn_bit"], TypeCode.Boolean);
                        bool? TurnReturn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                        bool? TurnCanceled_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                        bool? HasLadBillCredit_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["HasLadBillCredit_bit"], TypeCode.Boolean);
                        bool? LadBillCreditCancel_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                        bool? LadBillCreditTurn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                        bool? TurnAccepted_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);
                        Int64? AcceptedTurnNumber_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusDataTable.Rows[0]["AcceptedTurnNumber_bint"], TypeCode.Int64);
                        if (HasTurn_bit.HasValue == false || HasTurn_bit == false)
                        {
                            /////////TurnAcception(TrafficEntityUpdate, TrafficDate, _TurnHour, TrafficKey);
                        }
                        else
                        {
                            if (TurnAccepted_bit.HasValue && TurnAccepted_bit == true)
                            {
                                if (TurnCanceled_bit.HasValue && TurnCanceled_bit == true)
                                {
                                    DataTable TurnStatusDataTable = new DataTable();
                                    TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                    if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                    {
                                        Description=(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                        return false;
                                    }
                                }

                                else
                                {
                                    if (HasLadBillCredit_bit.HasValue && HasLadBillCredit_bit == true)
                                    {
                                        if (LadBillCreditCancel_bit.HasValue && LadBillCreditCancel_bit == true)
                                        {
                                            if (LadBillCreditTurn_bit.HasValue && LadBillCreditTurn_bit == true)
                                            {
                                                //محاسبه مدت مجاز سفر
                                                DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                                DataTable TrafficDataTable = new DataTable();
                                                string Condition = string.Format("Traffic_T.TrafficID_bint='{0}'", TrafficID_bint);
                                                TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);
                                                if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                                {
                                                    // حذف چک کردن این مورد در زمانی که مجوز گرفته و ابطال با حفظ نوبت شده شده است در تاریخ 93/11/25 انجام شد که بتوان اطلاعات تردد را ویرایش نمود

                                                    //Int32 _CityTravelHour = 0;
                                                    //if (!string.IsNullOrEmpty(TrafficDataTable.Rows[0]["TravelTime_int"].ToString()))
                                                    //{
                                                    //    _CityTravelHour = Convert.ToInt32(TrafficDataTable.Rows[0]["TravelTime_int"].ToString());
                                                    //}
                                                    /////////////////
                                                    //string _OutDate = TrafficDataTable.Rows[0]["Date_nvc"].ToString();
                                                    //string _OutTime = TrafficDataTable.Rows[0]["Time_nvc"].ToString();
                                                    //DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);

                                                    //if (TrafficDataTable.Rows[0]["Out_bit"].ToString() == "False")
                                                    //{
                                                    //    TimeSpan date = NowDate - OutDate;
                                                    //    double remaindedHour = _CityTravelHour - date.TotalHours;
                                                    //    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                    //    {
                                                    //        Description = (string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", TrafficDataTable.Rows[0]["LadBillCreditID_int"], TimeSpan.FromDays(remaindedHour)));
                                                    //        return false;
                                                    //    }
                                                    //}
                                                }
                                                else
                                                {
                                                    DataTable TurnStatusDataTable = new DataTable();
                                                    TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                    if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                    {
                                                        Description = (string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                        return false;
                                                    }
                                                }

                                            }
                                        }
                                        else
                                        {
                                            //محاسبه مدت مجاز سفر
                                            DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                            DataTable TrafficDataTable = new DataTable();
                                            string Condition = string.Format("Traffic_T.TrafficID_bint='{0}'", LastTrafficID_bint);
                                            TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);
                                            if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                            {
                                                Int32 _CityTravelHour = 0;
                                                if (!string.IsNullOrEmpty(TrafficDataTable.Rows[0]["TravelTime_int"].ToString()))
                                                {
                                                    _CityTravelHour = Convert.ToInt32(TrafficDataTable.Rows[0]["TravelTime_int"].ToString());
                                                }
                                                ///////////////
                                                string _OutDate = TrafficDataTable.Rows[0]["Date_nvc"].ToString();
                                                string _OutTime = TrafficDataTable.Rows[0]["Time_nvc"].ToString();
                                                DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);

                                                if (TrafficDataTable.Rows[0]["Out_bit"].ToString() == "False")
                                                {
                                                    TimeSpan date = NowDate - OutDate;
                                                    double remaindedHour = _CityTravelHour - date.TotalHours;
                                                    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                    {
                                                        Description = (string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", TrafficDataTable.Rows[0]["LadBillCreditID_int"], TimeSpan.FromDays(remaindedHour)));
                                                        return false;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                DataTable TurnStatusDataTable = new DataTable();
                                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                {
                                                    Description = (string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                    return false;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        DataTable TurnStatusDataTable = new DataTable();
                                        TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);

                                        if (TrafficID_bint!=LastTrafficID_bint)
                                        {
                                        Description=(string.Format("این ناوگان دارای شماره نوبت تأیید شده {0} می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                        return false;
                                        }
                                    }
                                }
                            }
                            else if (TurnAccepted_bit.HasValue && TurnReturn_bit == true)
                            {
                                DataTable TurnStatusDataTable = new DataTable();
                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                {
                                    Description=(string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                    return false;
                                }
                            }
                            else
                            {
                                //محاسبه مدت مجاز سفر
                                DataTable LadBillDataTable = new DataTable();
                                TrafficFactory.GetTurnStatus(NumberPlate_nvc, SerialPlate_nvc, LadBillDataTable);
                                if (LadBillDataTable != null && LadBillDataTable.Rows.Count > 0)
                                {
                                    bool? PreviousTurnAccepted_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["TurnAccepted_bit"], TypeCode.Boolean);
                                    Int32? PreviousTurnCancelCommandID_bit = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["TurnCancelCommantID_int"], TypeCode.Int32);
                                    bool? PreviousTurnReturn_bit = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["Return_bit"], TypeCode.Boolean);
                                    if (PreviousTurnAccepted_bit.HasValue && PreviousTurnAccepted_bit == true)
                                    {
                                        if (PreviousTurnCancelCommandID_bit.HasValue)
                                        {
                                            if (PreviousTurnReturn_bit.HasValue && PreviousTurnReturn_bit == true)
                                            {
                                                //باطل شده و احیا شده
                                                Description = (string.Format("ناوگان دارای شماره نوبت تأییدی< {0} >می باشد", LadBillDataTable.Rows[LadBillDataTable.Rows.Count - 1]["AcceptedTurnnumber_bint"]));
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            //تأیید شده و باطل نشده

                                            DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                            DataTable TrafficDataTable = new DataTable();
                                            string Condition = string.Format("Traffic_T.NumberPlate_nvc='{0}' and SerialPlate_nvc='{1}'", NumberPlate_nvc, SerialPlate_nvc);
                                            TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);

                                            if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                            {
                                                string filter = "LadeAssignmentId_bint=Max(LadeAssignmentId_bint)";
                                                DataRow[] dr = TrafficDataTable.Select(filter);
                                                if (dr != null && dr.Length > 0)
                                                {

                                                    Int32 _CityTravelHour = 0;
                                                    if (!string.IsNullOrEmpty(dr[dr.Length - 1]["TravelTime_int"].ToString()))
                                                    {
                                                        _CityTravelHour = Convert.ToInt32(dr[dr.Length - 1]["TravelTime_int"].ToString());
                                                    }

                                                    string _OutDate = dr[dr.Length - 1]["LadBillDate"].ToString();
                                                    string _OutTime = dr[dr.Length - 1]["LadBillTime"].ToString();
                                                    DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);
                                                    DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();
                                                    TrafficFactory.GetLastStatusForAcceptTurn((Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["TrafficID_bint"], TypeCode.Int64), TrafficStatusForAcceptTurnDataTable);
                                                    if (TrafficStatusForAcceptTurnDataTable != null && TrafficStatusForAcceptTurnDataTable.Rows.Count > 0 && Convert.ToBoolean(TrafficStatusForAcceptTurnDataTable.Rows[0]["HasTurn_bit"]) == true)
                                                    {
                                                        bool? LadBillCreditCancel = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                                                        bool? LadBillCreditTurn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                                                        bool? TurnReturn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                                                        bool? TurnCanceled = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                                                        bool? TurnAccepted = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);

                                                        if (LadBillCreditCancel.HasValue && LadBillCreditCancel == true)
                                                        {
                                                            if (LadBillCreditTurn.HasValue && LadBillCreditTurn == true)
                                                            {
                                                                Description = (string.Format("این ناوگان دارای شماره نوبت تأیید شده< {0} >می باشد", TrafficStatusForAcceptTurnDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {

                                                            if (TurnCanceled.HasValue && TurnCanceled == true)
                                                            {
                                                                if (TurnReturn.HasValue && TurnReturn == true)
                                                                {
                                                                    //احیای نوبت در ابطال مجوز پس مدت سفر داره
                                                                    if (dr[dr.Length - 1]["Out_bit"].ToString() == "False")
                                                                    {

                                                                        TimeSpan date = NowDate - OutDate;
                                                                        double remaindedHour = _CityTravelHour - date.TotalHours;
                                                                        string RemaindeHour = TimeSpan.FromDays(remaindedHour).ToString().Substring(0, TimeSpan.FromDays(remaindedHour).ToString().Length - 3);
                                                                        if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                                        {
                                                                            Description = (string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", dr[dr.Length - 1]["LadBillCreditID_int"], RemaindeHour));
                                                                            return false;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                // لحاظ نمودن مدت سفر
                                                                if (dr[dr.Length - 1]["Out_bit"].ToString() == "False")
                                                                {
                                                                    TimeSpan date = NowDate - OutDate;
                                                                    double remaindedHour = _CityTravelHour - date.TotalHours;
                                                                    string RemaindeHour = TimeSpan.FromDays(remaindedHour).ToString().Substring(0, TimeSpan.FromDays(remaindedHour).ToString().Length - 3);
                                                                    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)//date.TotalHours > _CityTravelHour)
                                                                    {
                                                                        Description = (string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", dr[dr.Length - 1]["LadBillCreditID_int"], RemaindeHour));
                                                                        return false;
                                                                    }
                                                                    else
                                                                    {
                                                                        DataTable TurnStatusDataTable = new DataTable();
                                                                        TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                                        if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                                        {
                                                                            List<HPS.BLL.TrafficBLL.BLLTraffic_T>trafficList=new List<HPS.BLL.TrafficBLL.BLLTraffic_T>();
                                                                            trafficList=TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, TrafficNumber_bint);
                                                                            if (trafficList != null && trafficList.Count > 0)
                                                                            {
                                                                                if (trafficList[0].In_bit == true && (trafficList[0].NumberPlate_nvc != NumberPlate_nvc || Convert.ToInt32(trafficList[0].SerialPlate_nvc) != Convert.ToInt32(SerialPlate_nvc)))
                                                                                {
                                                                                    Description = (string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                                                    return false;
                                                                                }
                                                                            }
                                                                            
                                                                        }
                                                                    }

                                                                }
                                                            }
                                                        }
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                DataTable TurnStatus = new DataTable();
                                                TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatus);
                                                if (TurnStatus != null && TurnStatus.Rows.Count > 0)
                                                {


                                                    DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();
                                                    TrafficFactory.GetLastStatusForAcceptTurn((Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(TurnStatus.Rows[TurnStatus.Rows.Count - 1]["TrafficID_bint"], TypeCode.Int64), TrafficStatusForAcceptTurnDataTable);
                                                    if (TrafficStatusForAcceptTurnDataTable != null && TrafficStatusForAcceptTurnDataTable.Rows.Count > 0 && Convert.ToBoolean(TrafficStatusForAcceptTurnDataTable.Rows[0]["HasTurn_bit"]) == true)
                                                    {
                                                        bool? LadBillCreditCancel = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditCancel_bit"], TypeCode.Boolean);
                                                        bool? LadBillCreditTurn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["LadBillCreditTurn_bit"], TypeCode.Boolean);
                                                        bool? TurnReturn = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnReturn_bit"], TypeCode.Boolean);
                                                        bool? TurnCanceled = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnCanceled_bit"], TypeCode.Boolean);
                                                        bool? TurnAccepted = (bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficStatusForAcceptTurnDataTable.Rows[0]["TurnAccepted_bit"], TypeCode.Boolean);

                                                        if (LadBillCreditCancel.HasValue && LadBillCreditCancel == true)
                                                        {
                                                            if (LadBillCreditTurn.HasValue && LadBillCreditTurn == true)
                                                            {
                                                                Description = (string.Format("این ناوگان دارای شماره نوبت تأیید شده< {0} >می باشد", TrafficStatusForAcceptTurnDataTable.Rows[0]["AcceptedTurnNumber_bint"]));
                                                                return false;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (TurnCanceled.HasValue && TurnCanceled == true)
                                                            {
                                                                if (TurnReturn.HasValue && TurnReturn == true)
                                                                {
                                                                    //نوبت فعال
                                                                    DataTable TurnStatusDataTable = new DataTable();
                                                                    TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                                                    if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                                                    {
                                                                        Description = (string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                                                        return false;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }

                                else
                                {
                                    DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(TrafficFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + TrafficFactory.ServerTime);
                                    DataTable TrafficDataTable = new DataTable();
                                    string Condition = string.Format("Traffic_T.NumberPlate_nvc='{0}' and SerialPlate_nvc='{1}'", NumberPlate_nvc, SerialPlate_nvc);
                                    TrafficFactory.GetAllByConditionWithLadBill(Condition, ref TrafficDataTable);

                                    if (TrafficDataTable != null && TrafficDataTable.Rows.Count > 0)
                                    {
                                        string filter = "LadeAssignmentId_bint=Max(LadeAssignmentId_bint)";
                                        DataRow[] dr = TrafficDataTable.Select(filter);
                                        if (dr != null && dr.Length > 0)
                                        {
                                            if (((bool?)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["Turn_bit"], TypeCode.Boolean) == true && (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["Canceled_bit"], TypeCode.Boolean) == true) || (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(dr[dr.Length - 1]["Canceled_bit"], TypeCode.Boolean) == false)
                                            {
                                                Int32 _CityTravelHour = 0;
                                                if (!string.IsNullOrEmpty(dr[dr.Length - 1]["TravelTime_int"].ToString()))
                                                {
                                                    _CityTravelHour = Convert.ToInt32(dr[dr.Length - 1]["TravelTime_int"].ToString());
                                                }
                                                string _OutDate = dr[dr.Length - 1]["LadBillDate"].ToString();
                                                string _OutTime = dr[dr.Length - 1]["LadBillTime"].ToString();
                                                DateTime OutDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(_OutDate)).MyDate.ToString("yyyy/MM/dd") + " " + _OutTime);
                                                DataTable TrafficStatusForAcceptTurnDataTable = new DataTable();

                                                if (dr[dr.Length - 1]["Out_bit"].ToString() == "False")
                                                {
                                                    TimeSpan date = NowDate - OutDate;
                                                    double remaindedHour = _CityTravelHour - date.TotalHours;
                                                    string RemaindeHour = TimeSpan.FromDays(remaindedHour).ToString().Substring(0, TimeSpan.FromDays(remaindedHour).ToString().Length - 3);
                                                    if (OutDate.AddHours(_CityTravelHour).CompareTo(NowDate) > 0)
                                                    {
                                                        if (string.IsNullOrEmpty(dr[dr.Length - 1]["Canceled_bit"].ToString()) || dr[dr.Length - 1]["Canceled_bit"].ToString() == "False")
                                                        {
                                                            Description = (string.Format("مدت سفراین ناوگان به مجوز< {0} >تمام نشده و مدت < {1} > مانده است ", dr[dr.Length - 1]["LadBillCreditID_int"], RemaindeHour));
                                                            return false;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // نوبت داره
                                        DataTable TurnStatusDataTable = new DataTable();
                                        TrafficFactory.GetTurnStatus((string)Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvc, TypeCode.String), (string)Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvc, TypeCode.String), TurnStatusDataTable);
                                        if (TurnStatusDataTable != null && TurnStatusDataTable.Rows.Count > 0)
                                        {
                                            Description = (string.Format("ناوگان دارای شماره نوبت تأییدی < {0} >می باشد", TurnStatusDataTable.Rows[TurnStatusDataTable.Rows.Count - 1]["AcceptedTurnNumber_bint"]));
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
                ////////////////////////////////////
                return true;
            }
            catch (System.Exception ex)
            {
                this.Description = ex.Message;
                return false;
            }
        }
    }
}
