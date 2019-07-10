using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class CarAllTrafficForm : Hepsa.Core.PL.BaseListForm
    {
        public CarAllTrafficForm()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group CarAllTrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            CarAllTrafficGroup.ExportButton = this.ExportButton;
            CarAllTrafficGroup.set_Grid(true, true, false, CarAllTrafficfoGridView);
            CarAllTrafficGroup.ToolStrip = AllTrafficToolStrip;
            CarAllTrafficGroup.HasFilterControl = true;
            this.Groups.Add(CarAllTrafficGroup);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                stiViewerControl1.Visible = false;
                CarAllTrafficfoGridView.Visible = true;


                if ((string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text)) && string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    throw new ApplicationException("لطفاً شماره کامیون یا کارت هوشمند را وارد نمایید");
                }
                //HPS.Reports.ReportDoc.CarAllTrafficReport rpt = new HPS.Reports.ReportDoc.CarAllTrafficReport(FromDatefaDatePicker.Text, ToDatefaDatePicker.Text, NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, CarCardNumber_nvcTextBox.Text);
                //CarAllTrafficfoGridView.DataSource = rpt.DataSource;
                //rpt.Document.Printer.PrinterName = string.Empty;
                //viewer1.Document = rpt.Document;
                //rpt.Run();
                string TrafficCondition = string.Empty;

                if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                {
                    TrafficCondition += string.Format(" T.NumberPlate_nvc='{0}' AND T.SerialPlate_nvc='{1}' ", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);

                    if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                    {
                        TrafficCondition += string.Format(" AND T.CarCardNumber_nvc={0} ", CarCardNumber_nvcTextBox.Text);
                    }
                }
                else if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    TrafficCondition += string.Format(" T.CarCardNumber_nvc={0} ", CarCardNumber_nvcTextBox.Text);
                }

                if (!FromDatefaDatePicker.IsNull && !ToDatefaDatePicker.IsNull)
                {
                    TrafficCondition += string.Format(" AND T.Date_nvc>='{0}' AND T.Date_nvc<='{1}' ", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                }

                BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable TraficTable = new DataTable();
                TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref TraficTable);
                CarAllTrafficfoGridView.DataSource = TraficTable;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }



        }

        private void CarAllTrafficForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.CarBLL.BLLCar_TFactory factory = new HPS.BLL.CarBLL.BLLCar_TFactory();

        }

        private void CarAllTrafficfoGridView_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void PrintstripButton_Click(object sender, EventArgs e)
        {
            CarAllTrafficfoGridView.Visible = false;
            stiViewerControl1.Visible = true;

            string TrafficCondition = string.Empty;

            if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
            {
                TrafficCondition += string.Format(" T.NumberPlate_nvc='{0}' AND T.SerialPlate_nvc='{1}' ", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);

                if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
                {
                    TrafficCondition += string.Format(" AND T.CarCardNumber_nvc={0} ", CarCardNumber_nvcTextBox.Text);
                }
            }
            else if (!string.IsNullOrEmpty(CarCardNumber_nvcTextBox.Text))
            {
                TrafficCondition += string.Format(" T.CarCardNumber_nvc={0} ", CarCardNumber_nvcTextBox.Text);
            }

            if (!FromDatefaDatePicker.IsNull && !ToDatefaDatePicker.IsNull)
            {
                TrafficCondition += string.Format(" AND T.Date_nvc>='{0}' AND T.Date_nvc<='{1}' ", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
            }

            CarAllTrafficstiReport.Dictionary.Synchronize();
            CarAllTrafficstiReport.Dictionary.Databases.Clear();
            CarAllTrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
            CarAllTrafficstiReport.Compile();
            //مقدار دهی متغیرها
            //stiReport1["fromDate_nvc"] = 1393 / 01 / 20;//FromDatefaDatePicker.Text;
            CarAllTrafficstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
            if (FromDatefaDatePicker.IsNull)
                CarAllTrafficstiReport["fromDate_nvc"] = string.Empty;
            else
                CarAllTrafficstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;

            if (ToDatefaDatePicker.IsNull)
                CarAllTrafficstiReport["toDate_nvc"] = string.Empty;
            else
                CarAllTrafficstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;

            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();

            CarAllTrafficstiReport["date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime;
            CarAllTrafficstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
            CarAllTrafficstiReport["@Condition"] = TrafficCondition;
            CarAllTrafficstiReport.Render();
            stiViewerControl1.Report = CarAllTrafficstiReport;


        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }
    }
}