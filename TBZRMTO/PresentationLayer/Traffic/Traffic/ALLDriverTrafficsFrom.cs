using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    public partial class AllDriverTrafficsFrom : Hepsa.Core.PL.BaseListForm
    {
        string DriverCardNumber = string.Empty;
        public AllDriverTrafficsFrom(string DriverCardNumber_nvc)
        {
            InitializeComponent();
            this.DriverTrafficGridView.AutoGenerateColumns = false;
            this.DriverCardNumber = DriverCardNumber_nvc;

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, true, true, this.DriverTrafficGridView);
            TrafficGroup.ToolStrip = this.AllDriverTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);
            try
            {
                this.LoadDriverTraffic();
                this.DriverTrafficGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
       
        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverAllTrafficsFrom_Load(object sender, EventArgs e)
        {

        }
        private void LoadDriverTraffic()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string TrafficCondition = "[T].[DriverCardNumber_nvc]= '" + DriverCardNumber + "'";
            DataTable DriverTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref DriverTrafficDatatable);
            DriverTrafficGridView.DataSource = DriverTrafficDatatable;
        }
    }
}
