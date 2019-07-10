using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Linq;
using System.Collections.Generic;


namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for AllInReport.
    /// </summary>
    public partial class AllInfoByDateReport : DataDynamics.ActiveReports.ActiveReport
    {

        public AllInfoByDateReport(string FromDate, string FromTime, string ToDate, string ToTime)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable AllDataTable = new DataTable();
                DataTable LadeAssignmentTable = new DataTable();
                TrafficFactory.TurnAndLadeAssignmentInfoByLaderTypeReport(FromDate, FromTime, ToDate, ToTime, null, ref AllDataTable);
                TrafficFactory.LadeAssignmentInfoByLaderType(FromDate, FromTime, ToDate, ToTime, null, ref LadeAssignmentTable);
                DataRow[] dr=null;
                foreach (DataRow row in AllDataTable.Rows)
                {
                    dr = LadeAssignmentTable.Select(string.Format(" LaderTypeID_int={0} ", row["LaderTypeID_int"]));
                    if (dr != null && dr.Length > 0)
                    {
                        row["CarCount_int"] = dr[0][2];
                        row["ladBillCount_int"] = dr[0][3];
                        row["LadeRemainedCount_int"] = dr[0][4];
                        row["RemainedPercent_flt"] = dr[0][5];
                    }
                    else
                    {
                        //var set = new HashSet<int>(LadeAssignmentTable.AsEnumerable().Select(p =>Convert.ToInt32(p["LaderTypeID_int"])));
                        //var result = AllDataTable.AsEnumerable().Where(i => !set.Contains(Convert.ToInt32(i["LaderTypeID_int"]))).ToList();
                        ////not in LadeAssignmentTable but in AllDataTable
                        //for (int i = 0; i < result.Count; i++)
                        //{
                        //    row["LaderTypeID_int"] = result[i]["LaderTypeID_int"];
                        //    row["LaderType_nvc"] = result[i]["LaderType_nvc"];
                        //    row["CarCount_int"] = result[i]["CarCount_int"];
                        //    row["ladBillCount_int"] = result[i]["ladBillCount_int"];
                        //    row["LadeRemainedCount_int"] = result[i]["LadeRemainedCount_int"];
                        //    row["RemainedPercent_flt"] = result[i]["RemainedPercent_flt"];
                        //    row["TurnRemainedCount_int"] = 0;
                        //    AllDataTable.Rows.Add(row);
                        //}

                        ////not in AllDataTable but in LadeAssignmentTable
                        var ladeset = new HashSet<int>(AllDataTable.AsEnumerable().Select(p => Convert.ToInt32(p["LaderTypeID_int"])));
                        var ladeResult = LadeAssignmentTable.AsEnumerable().Where(i => !ladeset.Contains(Convert.ToInt32(i["LaderTypeID_int"]))).ToList();
                        for (int i = 0; i < ladeResult.Count; i++)
                        {
                            row["LaderTypeID_int"] = ladeResult[i]["LaderTypeID_int"];
                            row["LaderType_nvc"] = ladeResult[i]["LaderType_nvc"];
                            row["CarCount_int"] = ladeResult[i]["CarCount_int"];
                            row["ladBillCount_int"] = ladeResult[i]["ladBillCount_int"];
                            row["LadeRemainedCount_int"] = ladeResult[i]["LadeRemainedCount_int"];
                            row["RemainedPercent_flt"] = ladeResult[i]["RemainedPercent_flt"];
                            row["TurnRemainedCount_int"] = 0;
                            AllDataTable.Rows.Add(row);
                        }

                    }
                    
                }

                this.DataSource = AllDataTable;
                FromDatetxt.Text = FromDate;
                FromTimetxt.Text = FromTime;
                ToDatetxt.Text = ToDate;
                ToTimetxt.Text = ToTime;
                TurnToDatetextBox.Text = ToDate;
                TurnToTimetextBox.Text=ToTime;
                UserNameTextBox.Text = HPS.Common.CurrentUser.user.UserName_nvc;
                Datetxt.Text = TrafficFactory.ServerJalaliDate;
                Timetxt.Text = TrafficFactory.ServerTime;
                LaderType_nvctxt.DataField = "LaderType_nvc";
                TurnCounttxt.DataField = "TurnRemainedCount_int";
                LadeAssignmenttxt.DataField = "CarCount_int";
                LadBillCount_inttextbox.DataField = "LadBillCount_int";
                Remaindtxt.DataField = "LadeRemainedCount_int";
                Percenttxt.DataField = "RemainedPercent_flt";

                Int64? AllturnRemainedRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["TurnRemainedCount_int"])).Sum();
                AllTurnRemainedtxt.Text = AllturnRemainedRecords.HasValue ? AllturnRemainedRecords.ToString() : "0";


                Int64? AllRemainedCountRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["LadeRemainedCount_int"])).Sum();
                AllLadeRemaindedCounttxt.Text = AllRemainedCountRecords.HasValue ? AllRemainedCountRecords.ToString() : "0";

                Int64? AllRequestCountRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["CarCount_int"])).Sum();
                AllRequesttxt.Text = AllRequestCountRecords.HasValue ? AllRequestCountRecords.ToString() : "0";


                Int64? AllLadBillCountRecords = (from row in AllDataTable.AsEnumerable() select Convert.ToInt32(row["LadBillCount_int"])).Sum();
                AllLadBillxt.Text = AllLadBillCountRecords.HasValue ? AllLadBillCountRecords.ToString() : "0";

                if (Convert.ToInt32(AllRequesttxt.Text) != 0)
                {
                    AllRemainedPercentTxt.Text = (Convert.ToDouble(AllLadeRemaindedCounttxt.Text) * 100 / Convert.ToDouble(AllRequesttxt.Text)).ToString("0.##");
                }
                else
                {
                    AllRemainedPercentTxt.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void detail_Format(object sender, EventArgs e)
        {
            //LadeAssignmenttxt.Value = string.Format("{0:#,###}", LadeAssignmenttxt.Value);
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
           
        }

        int Row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = Row.ToString();
            Row++;
        }
    }
}
