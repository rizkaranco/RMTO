using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    public partial class LastCarTraffic : Form
    {
        string NumberPlate = string.Empty;
        string SerialPlate = string.Empty;
        Int32? PlateCityID = 0;
      
        public LastCarTraffic(string NumberPlate_nvc, string SerialPlate_nvc)
        {
            InitializeComponent();

            this.NumberPlate = NumberPlate_nvc;
            this.SerialPlate = SerialPlate_nvc;
            this.Foreign();
        }
      
        public LastCarTraffic(string NumberPlate_nvc, Int32? PlateCityID_int)
        {
            InitializeComponent();

            this.NumberPlate = NumberPlate_nvc;
            this.PlateCityID = PlateCityID_int;

            this.Iranian();
        }

        string TrafficCondition = string.Empty;
      
        private void LastCarTraffic_Load(object sender, EventArgs e)
        {
           
        }

        private void Foreign()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            TrafficCondition = "([Traffic_T].[NumberPlate_nvc]= '" + NumberPlate + "')  AND ([Traffic_T].[SerialPlate_nvc]=" + SerialPlate + ")";
            List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);
            if (TrafficList != null && TrafficList.Count > 0 && TrafficList[TrafficList.Count - 1].In_bit == true)
            {
                this.TrafficFields();
            }
        }

        private void Iranian()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            if (PlateCityID == null || NumberPlate == null)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage("شماره پلاک یا محل شماره گذاری وارد نشده است");
            }
            else
            {
                TrafficCondition = "([Traffic_T].[NumberPlate_nvc]= N'" + NumberPlate + "')  AND ([Traffic_T].[PlateCityID_int]=" + (Int32?)PlateCityID + ")";
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);
                if (TrafficList != null && TrafficList.Count > 0 && TrafficList[TrafficList.Count - 1].In_bit == true)
                {
                    this.TrafficFields();
                }
            }
        }


        HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
        List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = null;

        private void TrafficFields()
        {
            TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);
            if (TrafficList != null && TrafficList.Count > 0 && TrafficList[TrafficList.Count - 1].In_bit == true)
            {
                CarCardNumber_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].CarCardNumber_nvc;
                SavedCarCardDate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].CarCardDate_nvc;
                SavedPlateType_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].PlateType_nvc;
                SavedNumberPlate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].NumberPlate_nvc;
                SavedSerialPlate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].SerialPlate_nvc;
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                string PlateCityCondition = "[PlateCity_T].[PlateCityID_int] = '" + TrafficList[TrafficList.Count - 1].PlateCityID_int+"'";
                List<HPS.BLL.PlateCityBLL.BLLPlateCity_T> PlateCityList = PlateCityFactory.GetAllByCondition(PlateCityCondition);
                if (PlateCityList != null)
                {
                    SavedPlateCityID_inttextBox.Text = PlateCityList[0].PlateCity_nvc;
                }
                HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory = new HPS.BLL.ColorBLL.BLLColor_TFactory();
                string ColorCondition = "[Color_T].[ColorID_int] = '" + TrafficList[TrafficList.Count - 1].PlateColorID_int+"'";
                List<HPS.BLL.ColorBLL.BLLColor_T> ColorList = ColorFactory.GetAllByCondition(ColorCondition);
                if (ColorList != null && ColorList.Count > 0)
                {
                    SavedPlateColorID_inttextBox.Text = ColorList[0].Color_nvc;
                }
                SavedCountryID_inttextBox.Text = TrafficList[TrafficList.Count - 1].Country_nvc;
                SavedYearType_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].YearType_nvc;
                SavedProductionYear_intNumericTextBox.Text = TrafficList[TrafficList.Count - 1].ProductionYear_int.Value.ToString();
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                 string LaderTypecondition = "[LaderType_T].[LaderTypeID_int] = '" + TrafficList[TrafficList.Count - 1].LaderTypeID_int+"'";
                List<HPS.BLL.LaderTypeBLL.BLLLaderType_T> LaderTypeList = LaderTypeFactory.GetAllByCondition(LaderTypecondition);
                if (LaderTypeList != null)
                {
                    SavedLaderType_nvctextBox.Text = LaderTypeList[0].LaderType_nvc;
                }
                SavedLaderTypeCode_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LaderTypeCode_nvc;
                SavedSystemCode_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].SystemCode_nvc;
                SavedSystem_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].System_nvc;
                SavedCapacity_intNumericTextBox.Text = TrafficList[TrafficList.Count - 1].Capacity_flt.Value.ToString();
            }
            else
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(string.Format(HPS.Exceptions.ExceptionCs.RecordNotFound, "ترددی با این مشخصات"));
            }
        }
    }
}

