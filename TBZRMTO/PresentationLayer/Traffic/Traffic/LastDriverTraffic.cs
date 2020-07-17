using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    public partial class LastDriverTraffic : Form
    {
        string NationCode = string.Empty;
        public LastDriverTraffic(string NationCode)
        {
            InitializeComponent();
            this.NationCode = NationCode;
        }

        private void LastDriverTraffic_Load(object sender, EventArgs e)
        {
            TrafficFields();
        }

        private void TrafficFields()
        {
            try
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string TrafficCondition = "[Traffic_T].[NationalCode_int]= '" + NationCode + "'";
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(TrafficCondition);
                if (TrafficList != null && TrafficList.Count > 0 && TrafficList[TrafficList.Count - 1].In_bit == true)
                {
                    SavedFirstName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].FirstName_nvc;
                    SavedLastName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LastName_nvc;
                    SavedDriverCardDate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].DriverCardDate_nvc;
                    SavedDriverType_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].DriverType_nvc;
                    SavedInsuranceNumber_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].InsuranceNumber_nvc;
                    HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                    string CityCondition = "[City_T].[CityID_int] = '" + TrafficList[TrafficList.Count - 1].CityID_int+"'";
                    List<HPS.BLL.CityBLL.BLLCity_T> CityList = CityFactory.GetAllByCondition(CityCondition);
                    if (CityList != null && CityList.Count>0)
                    {
                        SavedDriverCity_nvcTextBox.Text = CityList[0].City_nvc;
                    }
                    SavedlicenceNumber_intNumericTextBox.Text = TrafficList[TrafficList.Count - 1].licenceNumber_int.ToString();

                    string LicenceCityCondition = "[City_T].[CityID_int] = '" + TrafficList[TrafficList.Count - 1].LicenceCityID_int.ToString() + "'";
                    List<HPS.BLL.CityBLL.BLLCity_T> LicenceCityList = CityFactory.GetAllByCondition(LicenceCityCondition);
                    if (LicenceCityList != null && LicenceCityList.Count>0)
                    {
                       
                        SavedLicenceCity_nvcTextBox.Text = LicenceCityList[0].City_nvc;
                       
                    }
                    SavedLicenceType_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LicenceType_nvc;
                    SavedLiceniceDate_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LiceniceDate_nvc;
                    SavedActivityScope_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].ActivityScope_nvc;
                    SavedNationalCode_intNumericTextBox.Text = TrafficList[TrafficList.Count - 1].NationalCode_int.ToString();

                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
