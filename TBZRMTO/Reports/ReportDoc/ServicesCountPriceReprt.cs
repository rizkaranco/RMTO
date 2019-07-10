using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace HPS.Reports.ReportDoc
{
    /// <summary>
    /// Summary description for ServicesCountPriceReprt.
    /// </summary>
    public partial class ServicesCountPriceReprt : DataDynamics.ActiveReports.ActiveReport
    {

        public ServicesCountPriceReprt(string FromDate, string FromTime, string ToDate, string ToTime)
        {
            InitializeComponent();

        }

        int Row = 1;
        private void detail_BeforePrint(object sender, EventArgs e)
        {
            Rowtxt.Text = Rowtxt.ToString();
            Row++;
        }
    }
}
