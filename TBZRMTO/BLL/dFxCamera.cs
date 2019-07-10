using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gx;
using System.Threading;
using System.Drawing;

namespace Mrt.Anpr.Library
{
    public class dFxCamera
    {
        #region Private Data Members

        private fxCamera cam = null;

        private string Ip;

        #endregion

        #region Constructors

        public dFxCamera(string Ip)
        {
            this.Ip = Ip;
        }

        #endregion

        #region Public Methods

        public bool StartCameraService()
        {
            try
            {
                this.cam = new fxCamera();
                // Check the fxcam module
                cam.IsValid();

                // Connect to the camera
                Console.Write("Connect to the camera...");
                cam.SetProperty("connect/devname", this.Ip);
                cam.Connect();
                Console.WriteLine("OK");

                // Stop capture
                cam.StopCapture();

                // Turn on automatic synchronization (synchronize the DSP time to PC time)
                // Don't use this if you have NTP synchronization in the camera
                cam.SetProperty("time/sync", 1);

                // Query camera information
                int img_width = cam.GetPropertyInt("info/capture/xsize");
                int img_height = cam.GetPropertyInt("info/capture/ysize");

                if ((img_width == 0) || (img_height == 0))
                {
                    Console.WriteLine("Unknown camera type: {0}", cam.GetPropertyInt("info/camera_type"));
                    return false;
                }

                // Setup camera
                Console.Write("Setup camera...");
                cam.MPStartTransaction();

                
                cam.SetProperty("capture/again", 100);
                cam.SetProperty("capture/dgain", 100);
                HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TFactory factory = new HPS.BLL.InCameraPicturesBLL.BLLInCameraPictures_TFactory();
                //if (factory.ServerTime.CompareTo("20:00:00")>0 && factory.ServerTime.CompareTo("06:00:00")<0)
                //{
                    cam.SetProperty("capture/shutter",500);
                    cam.SetProperty("capture/lights", 0);
                //}
                //else
                //{
                //    cam.SetProperty("capture/shutter",2500);
                //    cam.SetProperty("capture/lights", 1);
                //}
                
                cam.SetProperty("capture/fps", cam.GetPropertyInt("info/capture/fps"));
                cam.SetProperty("capture/gamma", 0);			// 0: linear, 1: gamma

                cam.SetProperty("camera/led_infra", 1);			// 1 = turn on all LEDs (0=off)
                cam.SetProperty("camera/led_power", 1);		// normal: 16V
                cam.SetProperty("camera/led_timeus", 100);		// 100us

                cam.SetProperty("imgproc/shutter/max", 10000);
                cam.SetProperty("imgproc/again/max", 200);
                cam.SetProperty("capture/color", 0);

                cam.MPCommit();
                Console.WriteLine("OK");

                // Switch to automatic mode 
                Console.Write("Switch to the automatic mode...");
                cam.SwitchMode((int)FXCAM_MODES.FXCAM_MODE_AUTOMATIC);
                Console.WriteLine("OK");

                // Unlock all locked frames if there is any
                cam.UnlockFrames((ushort)FXCAM_UNLOCK_FLAGS.FXCAM_UNLOCK_RELEASE_ALL, 0, 0);

                // Start capture
                Console.Write("Start the capturing...");
                cam.StartCapture();
                Console.WriteLine("OK");

                //Waiting for the end of the camera initialization
                Thread.Sleep(2000);

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool StopCameraService()
        {
            if (this.cam != null)
            {
                return cam.StopCapture();
            }
            else
            {
                return false;
            }
        }

        public bool StartAutoFocus()
        {
            if (this.cam != null)
            {
                return cam.StartAutoFocus();
            }
            else
            {
                return false;
            }
        }

        public bool StopAutoFocus()
        {
            if (this.cam != null)
            {
                return cam.StopAutoFocus();
            }
            else
            {
                return false;
            }
        }

        public gxImage GetGxImage()
        {
            if (this.cam == null)
            {
                return null;
            }

            cam.GetCaptureInfo();
            int cap_frameix = cam.GetPropertyInt("captureinfo/newestframeix");

            gxImage image = new gxImage();

            //String fname = "";
            //fname = String.Format("getframe{0:00}.bmp", i);
            //Console.Write(String.Format("GetFrame {0}...", i));

            cam.GetFrame((int)FXCAM_GETFRAME_FLAGS.FXCAM_GETFRAME_NEWEST, 0, image);
          //  Console.WriteLine("OK");
            // Save to file
            if (image.GetPixelFormat() != (int)GX_PIXELFORMATS.GX_GRAY) image.Convert((int)GX_PIXELFORMATS.GX_RGB);	// color image
            //Console.Write(String.Format("Save image: {0}...", fname));

            //image.Save(fname, (int)GX_IMGFILEFORMATS.GX_BMP);
            //Console.WriteLine("OK");

            //System.Drawing.Image img = System.Drawing.Image.FromStream(new System.IO.MemoryStream(image.SaveToMem((int)gx.GX_IMGFILEFORMATS.GX_JPEG)));
            return image;

        }

        public Image GetImage()
        {
            gxImage gxImg = this.GetGxImage();

            System.Drawing.Image img = System.Drawing.Image.FromStream(new System.IO.MemoryStream(gxImg.SaveToMem((int)gx.GX_IMGFILEFORMATS.GX_JPEG)));
            return img;
        }

        #endregion
    }
}
