using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    public partial class PlateNumberRecognitionForm : Hepsa.Core.PL.BaseForm
    {
        public string  NumberPlateByCamera { get; set; }
        public string SerialPlateByCamera { get; set; }
        public PlateNumberRecognitionForm()
            : base()
        {
            InitializeComponent();

            axVitaminCtrl1.Url = "http://169.254.0.99";
                axVitaminCtrl1.ViewStream = VITAMINDECODERLib.EDualStreamOption.eStream1;
                axVitaminCtrl1.ConnectionProtocol = VITAMINDECODERLib.EConnProtocol.eProtTCP;
                axVitaminCtrl1.MediaType = VITAMINDECODERLib.EMediaType.eMediaVideo;
                axVitaminCtrl1.Connect();
           
          
        }

        private void PlateNumberRecognitionForm_Load(object sender, EventArgs e)
        {
            try
            {
                ////Read from service and fill numberPlate Text and serialPlateText
                //string numberPlate_nvc = string.Empty; ;
                //string serialPlate_nvc = string.Empty;

                //Mrt.Anpr.Library.dFxCamera cam = new Mrt.Anpr.Library.dFxCamera("172.20.229.202");
                List<byte[]> Inimgs = null;
                WebReference.ServiceRefrence anprService = new WebReference.ServiceRefrence();
                string number = string.Empty;
                object objData;
                object info;
                byte[] byteData;
                Inimgs = new List<byte[]>();

                for (int i = 0; i < 7; i++)
                {
                    axVitaminCtrl1.DigitalZoomFactor = 300;
                    axVitaminCtrl1.GetSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, out objData, out info);
                    if (objData != null)
                    {
                        byteData = (byte[])objData;
                        Inimgs.Add(byteData);
                    }
                    if (Inimgs.Count < 7)
                    {
                        i++;
                        axVitaminCtrl1.GetSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, out objData, out info);
                        if (objData != null)
                        {
                            byteData = (byte[])objData;
                            Inimgs.Add(byteData);
                        }
                    }
                    //if (cntTakeInPicture_int < 2 && i < 2)
                    //{
                    string folderName = @"f:\ANPRPIC\in\" + DateTime.Now.ToString("yyyy MM dd HHmmss");

                    axVitaminCtrl1.SaveSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, folderName + "\\" + i + ".jpg");
                    //}
                }

                number = anprService.GetPlateNumber(Inimgs.ToArray());
                ////number = "56ع87615";
                if (!string.IsNullOrEmpty(number))
                {
                    HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new BLL.TruePlate.ConvertToTrueNumber();
                    string plateNumber_nvc = string.Empty;
                    string plateSerial_nvc = string.Empty;

                    NumberPlateByCamera = trueNumberClass.GetPlateNumber(number.Substring(1, 2) + number.Substring(5, 4) + number.Substring(3, 2));
                    SerialPlateByCamera = trueNumberClass.GetPlateNumber(number.Substring(9, 2));
                }
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ////Read from service and fill numberPlate Text and serialPlateText
                //string numberPlate_nvc = string.Empty; ;
                //string serialPlate_nvc = string.Empty;

                //Mrt.Anpr.Library.dFxCamera cam = new Mrt.Anpr.Library.dFxCamera("172.20.229.202");
                List<byte[]> Inimgs = null;
                WebReference.ServiceRefrence anprService = new WebReference.ServiceRefrence();
                string number = string.Empty;
                object objData;
                object info;
                byte[] byteData;
                Inimgs = new List<byte[]>();

                for (int i = 0; i < 7; i++)
                {
                    axVitaminCtrl1.DigitalZoomFactor = 300;
                    axVitaminCtrl1.GetSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, out objData, out info);
                    if (objData != null)
                    {
                        byteData = (byte[])objData;
                        Inimgs.Add(byteData);
                    }
                    if (Inimgs.Count < 7)
                    {
                        i++;
                        axVitaminCtrl1.GetSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, out objData, out info);
                        if (objData != null)
                        {
                            byteData = (byte[])objData;
                            Inimgs.Add(byteData);
                        }
                    }
                    //if (cntTakeInPicture_int < 2 && i < 2)
                    //{
                    string folderName = @"f:\ANPRPIC\in\" + DateTime.Now.ToString("yyyy MM dd HHmmss");

                    axVitaminCtrl1.SaveSnapshot(VITAMINDECODERLib.EPictureFormat.ePicFmtJpeg, folderName + "\\" + i + ".jpg");
                    //}
                }

                number = anprService.GetPlateNumber(Inimgs.ToArray());
                ////number = "56ع87615";
                if (!string.IsNullOrEmpty(number))
                {
                    HPS.BLL.TruePlate.ConvertToTrueNumber trueNumberClass = new BLL.TruePlate.ConvertToTrueNumber();
                    string plateNumber_nvc = string.Empty;
                    string plateSerial_nvc = string.Empty;

                    NumberPlateByCamera = trueNumberClass.GetPlateNumber(number.Substring(1, 2) + number.Substring(5, 4) + number.Substring(3, 2));
                    SerialPlateByCamera = trueNumberClass.GetPlateNumber(number.Substring(9, 2));
                }
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            finally
            {

            }
        }

        private void PlateNumberRecognitionForm_Activated(object sender, EventArgs e)
        {

        }

    }
}
