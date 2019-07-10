using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    public partial class AllCarTrafficsForm : Hepsa.Core.PL.BaseListForm
    {
        string NumberPlate = string.Empty;
        string SerialPlate = string.Empty;
        Int32? PlateCityID = 0;

        public AllCarTrafficsForm(string NumberPlate_nvc, string SerialPlate_nvc, Int32? PlateCityID_int)
        {
            InitializeComponent();
          
            this.CarTrafficGridView.AutoGenerateColumns = false;
            this.NumberPlate = NumberPlate_nvc;
            this.SerialPlate = SerialPlate_nvc;
            this.PlateCityID = PlateCityID_int;
            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, true, true, this.CarTrafficGridView);
            TrafficGroup.ToolStrip = this.AllCarTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);
            try
            {
                this.LoadCarTraffic();
                this.CarTrafficGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }

        }

        private void AllCarTrafficsForm_Load(object sender, EventArgs e)
        {

        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCarTraffic()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string TrafficCondition = "([T].[NumberPlate_nvc]= '" + NumberPlate + "')  AND ([T].[SerialPlate_nvc]='" + SerialPlate + "') AND ([T].[PlateCityID_int]= '" + PlateCityID + "')";
            DataTable CarTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
            CarTrafficGridView.DataSource = CarTrafficDatatable;
        }
    }
}
