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
    public partial class TrafficPicturesFullScreanForm : Hepsa.Core.PL.BaseListForm
    {
        public TrafficPicturesFullScreanForm(System.IO.MemoryStream pictureMemoryStream)
        {
            InitializeComponent();
            if (pictureMemoryStream.Length>0)
            {
                pictureBox.Image = System.Drawing.Image.FromStream(pictureMemoryStream);
            }
        }

        private void TrafficPicturesFullScreanForm_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

    }
}
