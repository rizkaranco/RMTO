using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.Xml;
using System.Reflection;
using System.Diagnostics;

namespace HPS
{
    public partial class Main : Hepsa.Core.PL.BaseForm
    {

        public Main()
        {
            InitializeComponent();

        }

        ToolTip tooltip = new ToolTip();
        //private   string SMSSendTime = string.Empty;
        HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
        //private HtmlDocument hdoc;
        //private  HPS.BLL.BLLSmsInfo_TFactory SmsInfoFactory = new HPS.BLL.BLLSmsInfo_TFactory();
        //private  HPS.BLL.BLLSmsInfo_T SmsInfoEntity = new HPS.BLL.BLLSmsInfo_T();


        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                Date.Text = "امروز: " + NewsFactory.ServerJalaliDate + " ساعت: " + NewsFactory.ServerTime;
                UserName.Text = HPS.Common.CurrentUser.user.UserName_nvc;

                string version = Assembly.GetEntryAssembly().GetName().Version.ToString();
                VersionLabel.Text = version.Substring(0, version.Length - 2);


                string condition = "([News_T].[StartDate_nvc]<='" + NewsFactory.ServerJalaliDate + "') AND ([News_T].[EndDate_nvc]>= '" + NewsFactory.ServerJalaliDate + "' )";
                DataTable NewsDataTable = new DataTable();
                NewsFactory.GetAllByCondition(condition, ref NewsDataTable);
                NewsTitleGrid.SetDataBinding(NewsDataTable, "");

                PictureBox pic = new PictureBox();
                pic.SizeMode = PictureBoxSizeMode.CenterImage;
                pic.Size = new Size(100, 100);
                pic.Name = "Loading";
                pic.Image = Properties.Resources.loading;
                pic.BringToFront();
                pic.Dock = DockStyle.Fill;
                pic.BackColor = System.Drawing.Color.FromArgb(205, 226, 252);
                ContentPane.Controls.Add(pic);

                if (Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "admin" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "backup" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "هدايتي" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "شباني")
                {
                    CameraPicturesMenuItem.Visible = true;
                    TrafficNotInTraffic_TMenuItem.Visible = true;
                    //UsedLadBillMenuItem.Visible = true;
                    //InOutTrafficMenuItem.Visible = true;

                }
                else
                {
                    CameraPicturesMenuItem.Visible = false;
                    TrafficNotInTraffic_TMenuItem.Visible = false;
                    //UsedLadBillMenuItem.Visible = false;
                    //InOutTrafficMenuItem.Visible = false;
                }


                HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TFactory OfflineSecondPartSoftwareFactory = new BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TFactory();
                HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T ANPRSoftwareIsOfflineEntity = new BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();
                //OfflineProcessEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, false, false);
                //ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, true, false, false);
                //if (ANPRSoftwareIsOfflineEntity != null)
                //{
                //    SensorOfflineStatusLabel.BackColor = System.Drawing.Color.Red;
                //    SensorOfflineStatusLabel.Text = HPS.Exceptions.ExceptionCs.ANPRServiceOfflineDueToSensorAlarm;
                //}
                //else
                //{
                //    //SensorOfflineStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                //    //SensorOfflineStatusLabel.Text = "     ";
                //}


                //ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, false, false, false);
                //if (ANPRSoftwareIsOfflineEntity != null)
                //{
                //    ANPRServiceOfflineStatusLabel.BackColor = System.Drawing.Color.Red;
                //    ANPRServiceOfflineStatusLabel.Text = HPS.Exceptions.ExceptionCs.ANPRServiceOfflineAlarm;
                //}
                //else
                //{
                //    ANPRServiceOfflineStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                //    ANPRServiceOfflineStatusLabel.Text = "     ";
                //}

                //ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, false, true, false);
                //if (ANPRSoftwareIsOfflineEntity != null)
                //{
                //    InCameraStatusLabel.BackColor = System.Drawing.Color.Red;
                //    InCameraStatusLabel.Text = "دوربین ورودی قطع می باشد";
                //}
                //else
                //{
                //    InCameraStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                //    InCameraStatusLabel.Text = "     ";
                //}

                //ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, false, false, true);
                //if (ANPRSoftwareIsOfflineEntity != null)
                //{
                //    OutCameraStatusLabel.BackColor = System.Drawing.Color.Red;
                //    OutCameraStatusLabel.Text = "دوربین خروج قطع می باشد";
                //}
                //else
                //{
                //    OutCameraStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                //    OutCameraStatusLabel.Text = "     ";
                //}

                if (OfflineSecondPartSoftwareFactory.ServerTime.CompareTo("08:00:00") >= 0 && OfflineSecondPartSoftwareFactory.ServerTime.CompareTo("18:00:00") <= 0)
                {
                    ANPRSoftwareIsOfflineEntity = new BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();
                    ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.SMSController, false, false,false);
                    if (ANPRSoftwareIsOfflineEntity != null)
                    {
                        SMStoolStripStatusLabel.BackColor = System.Drawing.Color.Red;
                        SMStoolStripStatusLabel.Text = HPS.Exceptions.ExceptionCs.SMSControllerOfflineAlarm;
                    }
                    else
                    {
                        SMStoolStripStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                        SMStoolStripStatusLabel.Text = "     ";
                        //SMStoolStripStatusLabel.Visible = false;
                    }
                }
                else
                {
                    SMStoolStripStatusLabel.Visible = false;
                }

                ServiceOfflineCheckingTimer.Start();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            tooltip.AutoPopDelay = 1000;
            tooltip.InitialDelay = 100;
            tooltip.ReshowDelay = 100;
            tooltip.ShowAlways = true;

            timer1.Start();
            timer2.Start();
            timer3.Start();

            ServiceOfflineCheckingTimer.Start();
        }

        private void GoodMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Good.GoodListForm goodFrm = new HPS.Present.Good.GoodListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, goodFrm, this, false, true);
        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Color.ColorListForm colorFrm = new HPS.Present.Color.ColorListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, colorFrm, this, false, true);

        }

        private void BoundryMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Boundry.BoundryListForm boundryFrm = new HPS.Present.Boundry.BoundryListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, boundryFrm, this, false, true);

        }

        private void CityMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.City.CityListForm cityFrm = new HPS.Present.City.CityListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, cityFrm, this, false, true);
        }

        private void CountryMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Country.CountryListForm countryFrm = new HPS.Present.Country.CountryListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, countryFrm, this, false, true);
        }

        private void ComputerMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Computer.ComputerListForm computerFrm = new HPS.Present.Computer.ComputerListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, computerFrm, this, false, true);
        }

        private void PlateCityMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.PlateCity.PlateCityListForm platecityFrm = new HPS.Present.PlateCity.PlateCityListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, platecityFrm, this, false, true);
        }

        private void BoxingMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Boxing.BoxingListForm BoxingFrm = new HPS.Present.Boxing.BoxingListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, BoxingFrm, this, false, true);
        }

        private void ServicesMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Services.ServicesListForm servicesFrm = new HPS.Present.Services.ServicesListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, servicesFrm, this, false, true);
        }

        private void InfractionTypeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionType.InfractionTypeListForm InfractionFrm = new HPS.Present.InfractionType.InfractionTypeListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, InfractionFrm, this, false, true);
        }

        private void InfractionSurveyGroupMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionSurveyGroup.InfractionSurveyGroupListForm InfractionsurveyGroupFrm = new HPS.Present.InfractionSurveyGroup.InfractionSurveyGroupListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, InfractionsurveyGroupFrm, this, false, true);
        }

        private void BillMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Bill.BillListForm BillFrm = new HPS.Present.Bill.BillListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, BillFrm, this, false, true);
        }

        private void LadeCommentMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeComment.LadeCommentListForm LadeFrm = new HPS.Present.LadeComment.LadeCommentListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, LadeFrm, this, false, true);
        }

        private void RevokeCommentMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadBillCancelComment.LadBillCancelCommentListForm LadebillCancellFrm = new HPS.Present.LadBillCancelComment.LadBillCancelCommentListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, LadebillCancellFrm, this, false, true);
        }

        private void TurnCancelCommentMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnCancelComment.TurnCancelCommentListForm turncancelcommnetFrm = new HPS.Present.TurnCancelComment.TurnCancelCommentListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, turncancelcommnetFrm, this, false, true);
        }

        private void LadeCancelCommnetMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeCancelComment.LadeCancelCommentListForm ladecelcommnetFrm = new HPS.Present.LadeCancelComment.LadeCancelCommentListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, ladecelcommnetFrm, this, false, true);
        }

        private void StopFeeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.StopFee.StopFeeListForm stopfeeFrm = new HPS.Present.StopFee.StopFeeListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, stopfeeFrm, this, false, true);
        }

        private void LaderTypeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LaderType.LaderTypeListForm ladertypeFrm = new HPS.Present.LaderType.LaderTypeListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, ladertypeFrm, this, false, true);
        }

        private void PortPlaceMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.PortPlaces.PortPlacesListForm portplaceFrm = new HPS.Present.PortPlaces.PortPlacesListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, portplaceFrm, this, false, true);
        }

        private void SaloonMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Saloon.SaloonListForm saloonFrm = new HPS.Present.Saloon.SaloonListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, saloonFrm, this, false, true);
        }

        private void AnnouncementTimeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.AnnouncementTime.AnnouncementTimeListForm announcementtimeFrm = new HPS.Present.AnnouncementTime.AnnouncementTimeListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, announcementtimeFrm, this, false, true);
        }

        private void CompanyLadBillMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.CompanyLadBill.CompanyLadBillListForm companyladFrm = new HPS.Present.CompanyLadBill.CompanyLadBillListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, companyladFrm, this, false, true);
        }

        private void TrafficTypeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.TrafficType.TrafficTypeListForm trafficFrm = new HPS.Present.TrafficType.TrafficTypeListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, trafficFrm, this, false, true);
        }

        private void LadBillMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["LadBillCreditListForm"];

            if (fc != null)
                fc.Dispose();

            HPS.Present.LadBillCredit.LadBillCreditListForm ladbillFrm = new HPS.Present.LadBillCredit.LadBillCreditListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, ladbillFrm, this, false, true);
        }

        private void TrafficMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void PriceNormMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.PriceNorm.PriceNormListForm pricenormFrm = new HPS.Present.PriceNorm.PriceNormListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, pricenormFrm, this, false, true);
        }

        private void InfractionMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Infraction.InfractionListForm infractionFrm = new HPS.Present.Infraction.InfractionListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, infractionFrm, this, false, true);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.AreuSureToExitProgram) == false)
                e.Cancel = true;
            else
            {
                var OnlineUserEntity = new HPS.BLL.OnlineUserBLL.BLLOnlineUser_T();
                var OnlineUserFactory = new HPS.BLL.OnlineUserBLL.BLLOnlineUser_TFactory();
                var OnlineUserKey = new HPS.BLL.OnlineUserBLL.BLLOnlineUser_TKeys();
                OnlineUserKey.OnlineUserID_int = HPS.Common.CurrentUser.user.OnlineUserID_int.Value;
                OnlineUserEntity = OnlineUserFactory.GetBy(OnlineUserKey);
                if (OnlineUserEntity != null)
                {
                    OnlineUserEntity.LogOutDate_vc = OnlineUserFactory.ServerJalaliDate;
                    OnlineUserEntity.LogOutTime_vc = OnlineUserFactory.ServerTime;
                    OnlineUserFactory.Update(OnlineUserEntity, OnlineUserKey);
                }
            }

        }

        private void RoleMenuItem_Click(object sender, EventArgs e)
        {
            Present.UserGroup.UserGroupListForm userGroupFrm = new HPS.Present.UserGroup.UserGroupListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, userGroupFrm, this, false, true);
        }

        private void UserMenuItem_Click(object sender, EventArgs e)
        {
            Present.User.UserListForm userFrm = new HPS.Present.User.UserListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, userFrm, this, false, true);
        }

        private void BillMessageMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.BillMessage.BillMessageListForm BillMessageFrm = new HPS.Present.BillMessage.BillMessageListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, BillMessageFrm, this, false, true);
        }

        private void InfractionSurveyUserMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionSurveyUsers.InfractionSurveyUsersListForm InfractionsurveyUserFrm = new HPS.Present.InfractionSurveyUsers.InfractionSurveyUsersListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, InfractionsurveyUserFrm, this, false, true);
        }

        private void MessageMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewsMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.News.NewsListForm newsFrm = new HPS.Present.News.NewsListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, newsFrm, this, false, true);
        }

        private void MessageRecipientMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProvinceMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Province.ProvinceListForm provinceFrm = new HPS.Present.Province.ProvinceListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, provinceFrm, this, false, true);
        }

        private void CompanyMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Company.CompanyListForm companyFrm = new HPS.Present.Company.CompanyListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, companyFrm, this, false, true);
        }

        private void DriverMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Driver.DriverListForm driverFrm = new HPS.Present.Driver.DriverListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, driverFrm, this, false, true);
        }

        private void CarMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Car.CarListForm carFrm = new HPS.Present.Car.CarListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, carFrm, this, false, true);
        }

        private void LadeAssignmentMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeAssignment.LadeAssignmentListForm frm = new HPS.Present.LadeAssignment.LadeAssignmentListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void InfractionGroupMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionGroup.InfractionGroupListForm ladeassignmentFrm = new HPS.Present.InfractionGroup.InfractionGroupListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, ladeassignmentFrm, this, false, true);
        }

        private void GroupMessageMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.MessageRecipient.MessageRecipientListForm MessagerecipientFrm = new HPS.Present.MessageRecipient.MessageRecipientListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, MessagerecipientFrm, this, false, true);
        }

        private void UserMessageMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Message.MessageListForm messageFrm = new HPS.Present.Message.MessageListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, messageFrm, this, false, true);
        }

        private void UsedLadeBillMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.UsedLadBill.UsedLadBillListForm usedladebillFrm = new HPS.Present.UsedLadBill.UsedLadBillListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, usedladebillFrm, this, false, true);
        }

        private void ExportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Common.ExportDataForm ExportData = new HPS.Present.Common.ExportDataForm();
            ExportData.ShowDialog();
        }

        private void LadeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.LadBillReportForm frm = new HPS.Reports.Forms.LadBillReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void NewsTitleCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IranianTruckMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["IranianCarsForm"];

            if (fc != null)
                fc.Dispose();

            HPS.Present.Traffic.IranianCarsForm TrafficFrm = new HPS.Present.Traffic.IranianCarsForm();
            TrafficFrm.Show();
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, TrafficFrm, this, false, true);
        }

        private void ForeignTruckMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ForeignCarsForm"];

            if (fc != null)
                fc.Dispose();

            HPS.Present.Traffic.ForeignCarsForm frm = new HPS.Present.Traffic.ForeignCarsForm();
            frm.Show();
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OtherMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["OtherCarsForm"];

            if (fc != null)
                fc.Dispose();
            HPS.Present.Traffic.OtherCarsForm frm = new HPS.Present.Traffic.OtherCarsForm();
            frm.Show();
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OutIranianTruckMenuItem_Click(object sender, EventArgs e)
        {
            //HPS.Present.TrafficOut.TrafficOutEntityForm traficout = new HPS.Present.TrafficOut.TrafficOutEntityForm();
            //traficout.Text = "خروج كاميون ايراني از پايانه بار";
            //traficout.TrafficTypeID = 1;
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, traficout, this, false, true);
        }

        private void OutForeignTruckMenuItem_Click(object sender, EventArgs e)
        {
            //HPS.Present.TrafficOut.TrafficOutEntityForm traficout = new HPS.Present.TrafficOut.TrafficOutEntityForm();
            //traficout.Text = "خروج كاميون خارجي از تير پارك";
            //traficout.TrafficTypeID = 2;
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, traficout, this, false, true);
        }

        private void OutOtherMenuItem_Click(object sender, EventArgs e)
        {
            //HPS.Present.TrafficOut.TrafficOutEntityForm traficout = new HPS.Present.TrafficOut.TrafficOutEntityForm();
            //traficout.Text = "خروج سواري يا ساير وسائط نقليه از پاركينگ پايانه بار";
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, traficout, this, false, true);
        }

        private void TurnReturnMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnManagement.TurnManagementListForm turnmanagementFrm = new HPS.Present.TurnManagement.TurnManagementListForm(1);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, turnmanagementFrm, this, false, true);
        }

        private void TuenAcceptMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnManagement.TrafficWithoutTurnAllowadedForm frm = new HPS.Present.TurnManagement.TrafficWithoutTurnAllowadedForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

        }
        public int TrafficType;
        private void IranianCarReportMenuItem_Click(object sender, EventArgs e)
        {
            TrafficType = 1;
            HPS.Reports.Forms.AllTrafficForm frm = new HPS.Reports.Forms.AllTrafficForm(TrafficType);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void ForeignCarReportMenuItem_Click(object sender, EventArgs e)
        {
            TrafficType = 2;
            HPS.Reports.Forms.AllTrafficForm frm = new HPS.Reports.Forms.AllTrafficForm(TrafficType);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OtherReportripMenuItem_Click(object sender, EventArgs e)
        {
            TrafficType = 3;
            HPS.Reports.Forms.AllTrafficForm frm = new HPS.Reports.Forms.AllTrafficForm(TrafficType);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.F2)
            //{
               
            //        InIranianTruckMenuItem.PerformClick();
                
            //}
            //else if (e.KeyCode == Keys.F3)
            //{
                
            //        InForeignTruckMenuItem.PerformClick();
               
            //}
            //else if (e.KeyCode == Keys.F4)
            //{
                
            //        InOtherMenuItem.PerformClick();
                
            //}
            //else if (e.KeyCode == Keys.F5)
            //{
               
            //        OutTrafficMenuItem.PerformClick();
                
            //}

        }

        private void LadeMnuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeAssignment.ShowFormSetting frm = new HPS.Present.LadeAssignment.ShowFormSetting();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AcceptMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeAssignment.LadeAssignmentWithoutAcceptedForm frm = new HPS.Present.LadeAssignment.LadeAssignmentWithoutAcceptedForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
            try
            {
                string condition = "([News_T].[StartDate_nvc]<='" + NewsFactory.ServerJalaliDate + "') AND ([News_T].[EndDate_nvc]>= '" + NewsFactory.ServerJalaliDate + "' )";
                DataTable NewsDataTable = new DataTable();
                NewsFactory.GetAllByCondition(condition, ref NewsDataTable);
                NewsTitleGrid.SetDataBinding(NewsDataTable, "");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void NewsTitleGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.NewsBLL.BLLNews_TFactory NewsFactory = new HPS.BLL.NewsBLL.BLLNews_TFactory();
                string condition = "[News_T].[NewsID_bint]= " + this.NewsTitleGrid.CurrentRow.Cells["NewsID_int"].Value;
                List<HPS.BLL.NewsBLL.BLLNews_T> NewsList = NewsFactory.GetAllByCondition(condition);
                NewsLabel.Text = NewsList[0].News_nvc;
            }
            catch (Exception)
            {
                Hepsa.Core.Common.MessageBox.InformationMessage("یک مورد را انتخاب کنید");
            }
        }

        private void AllLadBillMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllLadBillReport frm = new HPS.Reports.Forms.AllLadBillReport();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CarPriceMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CarAllTrafficForm frm = new HPS.Reports.Forms.CarAllTrafficForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Date.Text = "امروز: " + NewsFactory.ServerJalaliDate + " ساعت  " + NewsFactory.ServerTime;
       }

        private void IranianInTrafficReportMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InTrafficReportForm frm = new HPS.Reports.Forms.InTrafficReportForm(1);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void ForeignInTrafficMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InTrafficReportForm frm = new HPS.Reports.Forms.InTrafficReportForm(2);
            frm.Text = "کامیون های خارجي ورودی به تیر پارک پايانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OtherInStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InTrafficReportForm frm = new HPS.Reports.Forms.InTrafficReportForm(0);
            frm.Text = "سواری و سایر خودروهای ورودی به پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void IranianOutTrafficReportMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.OutTrafficReportForm frm = new HPS.Reports.Forms.OutTrafficReportForm(1);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void ForeignOutTrafficMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.OutTrafficReportForm frm = new HPS.Reports.Forms.OutTrafficReportForm(2);
            frm.Text = "کامیون های خارجي خروجي از تیر پارک پايانه بار تبریز";

            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OtherOutTrafficMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.OutTrafficReportForm frm = new HPS.Reports.Forms.OutTrafficReportForm(0);
            frm.Text = "سواری و سایر خودروهای خروجی از پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        //private void IranianINNotOutMenuItem_Click(object sender, EventArgs e)
        //{
        //    HPS.Reports.Forms.InNotOutTrafficReportForm frm = new HPS.Reports.Forms.InNotOutTrafficReportForm(1);
        //    frm.Text = "گزارش ترددهای ورودی خارج نشده از پارکینگ پایانه بار تبریز";
        //    Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        //}

        private void ForeignInNotOutMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InNotOutTrafficReportForm frm = new HPS.Reports.Forms.InNotOutTrafficReportForm(2);
            frm.Text = "گزارش کامیون های خارجی ورودی خارج نشده از پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OtherInNotOutMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InNotOutTrafficReportForm frm = new HPS.Reports.Forms.InNotOutTrafficReportForm(3);
            frm.Text = "گزارش سواری های ورودی خارج نشده از پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CompanyLadeAssignmentReportMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CompanyAllLadeAssignmentedReport frm = new HPS.Reports.Forms.CompanyAllLadeAssignmentedReport();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void TurnAcceptedReportMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.TurnAcceptedReportForm frm = new HPS.Reports.Forms.TurnAcceptedReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LadeCancelRequestMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeAssignmentCacelRequest.LadeAssignmentCacelRequestListForm frm = new HPS.Present.LadeAssignmentCacelRequest.LadeAssignmentCacelRequestListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LadBillCancelMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.CancelLadBillForm CancelLadBillForm = new HPS.Present.CancelLadBillForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, CancelLadBillForm, this, false, true);
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Common.AboutForm frm = new HPS.Present.Common.AboutForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CarSystemStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.CarSystem.CarSystemListForm frm = new HPS.Present.CarSystem.CarSystemListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

        }

        private void BackUpStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Common.BackUpForm bf = new HPS.Present.Common.BackUpForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, bf, this, false, true);
        }

        private void ClassMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Class.ClassListForm ClassForm = new HPS.Present.Class.ClassListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, ClassForm, this, false, true);
        }

        private void AllInTrafficStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllInTrafficWithPriceReportForm frm = new HPS.Reports.Forms.AllInTrafficWithPriceReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AllOutTrafficStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllOutTrafficReportForm frm = new HPS.Reports.Forms.AllOutTrafficReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AllInServiceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllInServiceTypeReportForm frm = new HPS.Reports.Forms.AllInServiceTypeReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AllOutServiceTypeStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllOutServiceTypeReportForm frm = new HPS.Reports.Forms.AllOutServiceTypeReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void UsersPriceStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.UsersPriceReportForm frm = new HPS.Reports.Forms.UsersPriceReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LogStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Log.LogListForm frm = new HPS.Present.Log.LogListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void DestinationAddressStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.DestinationAddress.DestinationAddressListForm DestinationAddress = new HPS.Present.DestinationAddress.DestinationAddressListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, DestinationAddress, this, false, true);
        }

        private void ChoosePrinterStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings s = new HPS.Properties.Settings();
                s.PrinterName = dlg.PrinterSettings.PrinterName;
                s.Save();
            }
        }

        private void LaderTypeCountStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.LederTypeCountReportForm frm = new HPS.Reports.Forms.LederTypeCountReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CompanyLadeAssignmentDetailStipMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CompanyLadeAssignmentDetailReportForm frm = new HPS.Reports.Forms.CompanyLadeAssignmentDetailReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CompanyRemaiderLadeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CompanyRemainderLadeReportForm frm = new HPS.Reports.Forms.CompanyRemainderLadeReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void OutTrafficMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["TrafficOutEntityForm"];

            if (fc != null)
                fc.Dispose();
            HPS.Present.TrafficOut.TrafficOutEntityForm traficout = new HPS.Present.TrafficOut.TrafficOutEntityForm();
            traficout.Show();
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, traficout, this, false, true);
        }

        private void TurnCancelMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnManagement.TurnManagementListForm turnmanagementFrm = new HPS.Present.TurnManagement.TurnManagementListForm(0);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, turnmanagementFrm, this, false, true);

        }

        private void AllInReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllInReportForm allInReport = new HPS.Reports.Forms.AllInReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, allInReport, this, false, true);
        }

        private void AcceptedWithoutLadBillCreditReportStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AcceptedTurnWithoutLadBillCreditReportForm frm = new HPS.Reports.Forms.AcceptedTurnWithoutLadBillCreditReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

        }

        private void LadeUserDateilStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.UsersLadeDetailReportForm frm = new HPS.Reports.Forms.UsersLadeDetailReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LaderTypeTurnStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.LaderTypeTurnReportForm frm = new HPS.Reports.Forms.LaderTypeTurnReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void InServiceTypeWithPivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InServiceTypeWithPivoteReportForm frm = new HPS.Reports.Forms.InServiceTypeWithPivoteReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AgeAvgMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AgeAvgReportForm frm = new HPS.Reports.Forms.AgeAvgReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void ChooseSaloonMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LaderType.ChooseSaloonForm frm = new HPS.Present.LaderType.ChooseSaloonForm(null);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, true, true);

        }

        private void SendtextToDriversMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.SMS.SendTextToDiriversForm frm = new HPS.Present.SMS.SendTextToDiriversForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, true, true);
        }

        private void SendNewsToDriversMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.SMS.SendNewsToDiriversForm frm = new HPS.Present.SMS.SendNewsToDiriversForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, true, true);
        }

        private void SMSPasswordChangeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.SMS.SetSMSUserNameAndPassForm frm = new HPS.Present.SMS.SetSMSUserNameAndPassForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int ExecuteCount = -1;
                    ExecuteCount = CancelTimeExpiredTurns(false);
                    if (ExecuteCount >= 0)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage(string.Format("تعداد {0} نوبت باطل شد", ExecuteCount.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                }
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        static string HttpGet(string url)
        {
            HttpWebRequest req = WebRequest.Create(url)
                                 as HttpWebRequest;
            string result = null;
            using (HttpWebResponse resp = req.GetResponse()
                                          as HttpWebResponse)
            {
                StreamReader reader =
                    new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        private void SettingMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.Common.Setting_T.SettingListForm frm = new HPS.Present.Common.Setting_T.SettingListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

        }

        private void CompanyMobileMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.CompanyMobileListForm frm = new HPS.Present.CompanyMobileListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LastTurnNumberAndRemaindCountByLaderTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.LastTurnNumberAndRemaindCountByLaderTypeForm frm = new HPS.Reports.Forms.LastTurnNumberAndRemaindCountByLaderTypeForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CancelTimeExpiredTurnsMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnManagement.CancelExpiredTurnForm frm = new HPS.Present.TurnManagement.CancelExpiredTurnForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private Int32 CancelTimeExpiredTurns(bool doManually)
        {
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
            SettingKey.SettingID_int = 1008;
            SettingEntity = SettingFactory.GetBy(SettingKey);
            int rowcount = -1;
            if (doManually)
            {
                rowcount = DoCancelOperation();
            }
            else
            {
                if (SettingFactory.ServerTime.Substring(0, 5) == SettingEntity.Value_nvc)
                {
                    rowcount = DoCancelOperation();
                }
            }
            return rowcount;
        }

        private Int32 DoCancelOperation()
        {
            HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
            HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
            HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();

            SettingKey.SettingID_int = 1003;
            SettingEntity = SettingFactory.GetBy(SettingKey);

            Hepsa.Core.Common.MyDateTime CurrentDate = new Hepsa.Core.Common.MyDateTime(SettingFactory.ServerJalaliDate);
            string CancelTime = SettingFactory.ServerTime;
            string CurrentDateTime = CurrentDate.MyDate.ToString("yyyy/MM/dd") + " " + CancelTime;

            DateTime SubtractedDate = DateTime.Parse(CurrentDateTime);
            SubtractedDate = SubtractedDate.AddHours(-Int32.Parse(SettingEntity.Value_nvc));

            string CancelDate = new Hepsa.Core.Common.MyDateTime(SubtractedDate).ConvertToPersianShortDate();

            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory TurnCancelCommentFactory = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TFactory();
            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T TurnCancelCommentEntity = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T();
            HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys TurnCancelCommentKey = new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys();
            TurnCancelCommentKey.TurnCancelCommentID_int = 40;
            TurnCancelCommentEntity = TurnCancelCommentFactory.GetBy(TurnCancelCommentKey);
            HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable AcceptedTurnsWithoutLadBillDataTable = new DataTable();
            TrafficFactory.SelectInTurnAcceptedForDelete(CancelDate, string.Empty, AcceptedTurnsWithoutLadBillDataTable);
            int rowcount = -1;
            if (AcceptedTurnsWithoutLadBillDataTable != null && AcceptedTurnsWithoutLadBillDataTable.Rows.Count > 0)
            {
                rowcount = AcceptedTurnsWithoutLadBillDataTable.Rows.Count;
                foreach (DataRow row in AcceptedTurnsWithoutLadBillDataTable.Rows)
                {
                    HPS.BLL.TurnManagementBLL.BLLTurnManagement_T TurnManagementEntity = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
                    TurnManagementEntity.TurnCancelCommantID_int = TurnCancelCommentEntity.TurnCancelCommentID_int;
                    TurnManagementEntity.TurnCancelCommment_nvc = TurnCancelCommentEntity.TurnCancelComment_nvc;
                    TurnManagementEntity.Return_bit = false;
                    TurnManagementEntity.Date_nvc = TurnManagementFactory.ServerJalaliDate;
                    TurnManagementEntity.Time_nvc = TurnManagementFactory.ServerTime;
                    TurnManagementEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    TurnManagementEntity.TrafficID_bint = Convert.ToInt64(row["TrafficID_bint"]);
                    TurnManagementFactory.BeginProc();
                    TurnManagementFactory.Insert(TurnManagementEntity);
                    TurnManagementFactory.CommitProc();
                }
            }
            return rowcount;
        }

        private void SMSLogMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.SMS.SMSLogForm frm = new HPS.Present.SMS.SMSLogForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LadBillCreditReportStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.LadBillCreditReporForm frm = new HPS.Reports.Forms.LadBillCreditReporForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AllInfoByDateReportMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllInfoByDateReportForm frm = new HPS.Reports.Forms.AllInfoByDateReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void AcceptedTurnWithoutLadBillCreditDevidedByLaderTypeAndDateMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AcceptedTurnWithoutLadBillCreditDevidedByLaderTypeAndDateForm frm = new HPS.Reports.Forms.AcceptedTurnWithoutLadBillCreditDevidedByLaderTypeAndDateForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void DuplicateTurnsMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Forms.StimulViewer Viewer = new HPS.Reports.Forms.StimulViewer("dublicateTurns");
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, Viewer, this, false, true);
        }


        private void OtherInNotOutTrafficMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InNotOutTrafficReportForm frm = new HPS.Reports.Forms.InNotOutTrafficReportForm(8);
            frm.Text = "گزارش متفرقه های ورودی خارج نشده از پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void inCameraPicturesMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CompanyReminedStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.AllInfoByDateReportForm frm = new HPS.Reports.Forms.AllInfoByDateReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CanceledTurnsMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CanceledTurnsReportForm frm = new HPS.Reports.Forms.CanceledTurnsReportForm();
            //Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
            frm.Show();
        }

        private void CameraPicturesMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "admin" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "backup" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "هدايتي" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "شباني")
                {
                    HPS.Reports.Forms.TrafficPictures frm = new HPS.Reports.Forms.TrafficPictures();
                    Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void TrafficNotInTraffic_TMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "admin" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "backup" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "هدايتي" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "شباني")
                {
                    HPS.Reports.Forms.TrafficPicturesNotInTraffic_T frm = new HPS.Reports.Forms.TrafficPicturesNotInTraffic_T();
                    Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ActiveTurnsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Reports.Forms.ActiveTurnsReportForm frm = new HPS.Reports.Forms.ActiveTurnsReportForm();
                Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ReturnedTurnsStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Reports.Forms.ReturnedTurnsReportForm frm = new HPS.Reports.Forms.ReturnedTurnsReportForm();
                Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        bool ANPRProcessIsRun_bit = false;
        bool SMSProcessIsRun_bit = false;
        bool ThreadDone_bit = false;
        private void ServiceOfflineCheckingTimer_Tick(object sender, EventArgs e)
        {
            try
            {

                //System.Threading.Thread th = new System.Threading.Thread(DoProcessCheck);
                //th.IsBackground = true;
                //th.Start();
                DoProcessCheck();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void DoProcessCheck()
        {
            HPS.BLL.Common.RemoteProccessControl processControl = new BLL.Common.RemoteProccessControl();
            HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TFactory OfflineSecondPartSoftwareFactory = new BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_TFactory();
            var ANPRSoftwareIsOfflineEntity = new HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();

            ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, true,false,false);
            if (ANPRSoftwareIsOfflineEntity != null)
            {
                SensorOfflineStatusLabel.BackColor = System.Drawing.Color.Red;
                SensorOfflineStatusLabel.Text =HPS.Exceptions.ExceptionCs.ANPRServiceOfflineDueToSensorAlarm;
            }
            else
            {
                SensorOfflineStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                SensorOfflineStatusLabel.Text = "       ";
            }


            ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, false, false, false);
            if (ANPRSoftwareIsOfflineEntity != null)
            {
                ANPRServiceOfflineStatusLabel.BackColor = System.Drawing.Color.Red;
                ANPRServiceOfflineStatusLabel.Text = HPS.Exceptions.ExceptionCs.ANPRServiceOfflineAlarm;
            }
            else
            {
                ANPRServiceOfflineStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                ANPRServiceOfflineStatusLabel.Text = "       ";
            }
          
                ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR,false, true, false);
                if (ANPRSoftwareIsOfflineEntity != null)
                {
                    InCameraStatusLabel.BackColor = System.Drawing.Color.Red;
                    InCameraStatusLabel.Text = "دوربین ورودی قطع می باشد";
                }
                else
                {
                    InCameraStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    InCameraStatusLabel.Text = "       ";
                }

                ANPRSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.ANPR, false,false, true);
                if (ANPRSoftwareIsOfflineEntity != null)
                {
                    OutCameraStatusLabel.BackColor = System.Drawing.Color.Red;
                    OutCameraStatusLabel.Text = "دوربین خروج قطع می باشد";
                }
                else
                {
                    OutCameraStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    OutCameraStatusLabel.Text = "       ";
                }
          

            ///// Check SMS Controller
            if (OfflineSecondPartSoftwareFactory.ServerTime.CompareTo("08:00:00") >= 0 && OfflineSecondPartSoftwareFactory.ServerTime.CompareTo("18:00:00") <= 0)
            {
                var SMSSoftwareIsOfflineEntity = new HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T();
                SMSSoftwareIsOfflineEntity = OfflineSecondPartSoftwareFactory.SelectOfflineSoftwares((Int32)HPS.BLL.OfflineSecondPartSoftwareBLL.BLLOfflineSecondPartSoftware_T.SoftwareCodeField.SMSController, false, false,false);

                if (SMSSoftwareIsOfflineEntity != null)
                {
                    SMStoolStripStatusLabel.BackColor = System.Drawing.Color.Red;
                    SMStoolStripStatusLabel.Text = HPS.Exceptions.ExceptionCs.SMSControllerOfflineAlarm;
                }
                else
                {
                    SMStoolStripStatusLabel.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
                    SMStoolStripStatusLabel.Text = "     ";
                }
            }
        }

        private void ServicesStatusStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Reports.Forms.ServiceStatusReportForm frm = new HPS.Reports.Forms.ServiceStatusReportForm();
                Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);

            }
        }

        private void OnlineSmartCardControllingStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Reports.Forms.OnlineCardCheckingReportForm frm = new HPS.Reports.Forms.OnlineCardCheckingReportForm();
                Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);

            }
        }

        private void UsedLadBillMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "admin" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "backup" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "هدايتي" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "شباني")
                //{
                    HPS.Reports.Forms.UseLadBillVSLadeCountReportForm frm = new HPS.Reports.Forms.UseLadBillVSLadeCountReportForm();
                    Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
                //}
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);

            }
        }

        private void InOutTrafficMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //if (Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "admin" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "backup" || Hepsa.Core.Common.CurrentUser.User.UserName_nvc == "هدايتي")
                //{
                    HPS.Reports.Forms.TrafficPicturesForm frm = new HPS.Reports.Forms.TrafficPicturesForm();
                    Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
                //}
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CompnyGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Present.CompanyGroup.CompanyGroupListForm frmGroup = new HPS.Present.CompanyGroup.CompanyGroupListForm();
                Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frmGroup, this, false, true);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void InNotOutMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InNotOutTrafficReportForm frm = new HPS.Reports.Forms.InNotOutTrafficReportForm(1);
            frm.Text = "گزارش ترددهای ورودی خارج نشده از پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void FromDateForCheckActiveTurn_Click(object sender, EventArgs e)
        {
            HPS.Present.TurnManagement.InDateCheckForm frm = new HPS.Present.TurnManagement.InDateCheckForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void ITSInfoMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.Reports.Forms.ITSInformationReportForm frm = new HPS.Reports.Forms.ITSInformationReportForm();
                Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);

            }
        }

        private void TypeandLastInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.TypeandLastInReportForm frm = new Reports.Forms.TypeandLastInReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);

        }

        private void CountInTrafficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.TrafficCountInReport frm = new Reports.Forms.TrafficCountInReport();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
            
        }

        private void importToDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.ImportToDataBase Import = new Present.ImportToDataBase();
            Import.DeleteFromPERBARNAME_T();
            DataTable ImportDataTable = new DataTable();
            Import.SelectFromPERBARNAME_T(ImportDataTable);
            Import.InsertFromQuery_T_Toperbarname_T();
        }

        private void CompanyRemaiderPortPlaceMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.PortPlaceCountReportForm frm = new HPS.Reports.Forms.PortPlaceCountReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void GroupTrafficMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.GroupTrafficReportForm frm = new HPS.Reports.Forms.GroupTrafficReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void InNotOutByLaderTypeMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.InNotOutTrafficReportForm frm = new HPS.Reports.Forms.InNotOutTrafficReportForm(1);
            frm.Text = "گزارش ترددهای ورودی خارج نشده از پارکینگ پایانه بار تبریز";
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CarLadBillMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CarLadeBillReportForm frm = new HPS.Reports.Forms.CarLadeBillReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void TurnAcceptedAreaButton_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.TurnAcceptedAreaForm frm = new HPS.Reports.Forms.TurnAcceptedAreaForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void CarLadBillAndCancelAndTurnMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Reports.Forms.CarLadBillAndCancelAndTurnReportForm frm = new HPS.Reports.Forms.CarLadBillAndCancelAndTurnReportForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LadeAssignmentInforming_Click(object sender, EventArgs e)
        {

            HPS.Present.LadeAssignment.LadeAssignmentInforming frm = new HPS.Present.LadeAssignment.LadeAssignmentInforming(null);
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void LadeAssignmentInformingListFormMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.LadeAssignment.LadeAssignmentInformingListForm frm = new HPS.Present.LadeAssignment.LadeAssignmentInformingListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void TasksMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InForeignTruckMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["ForeignCarsForm"];

            if (fc != null)
                fc.Dispose();

            HPS.Present.Traffic.ForeignCarsForm TrafficFrm = new HPS.Present.Traffic.ForeignCarsForm();
            TrafficFrm.Show();
        }

        private void VerifiedOtherAarsMenuItem_Click(object sender, EventArgs e)
        {
            HPS.Present.VerifiedCars.VerifiedCarsListForm frm = new Present.VerifiedCars.VerifiedCarsListForm();
            Hepsa.Core.Common.PersentationController.ShowForm(this.ContentPane, frm, this, false, true);
        }

        private void InTrafficMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

