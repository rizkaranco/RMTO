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
    public partial class StimulReportViewerForm : Form
    {
        Stimulsoft.Report.StiReport _sti = new Stimulsoft.Report.StiReport();
        public StimulReportViewerForm(Stimulsoft.Report.StiReport sti)
        {
            InitializeComponent();
            _sti = sti;
        }

        private void stiViewerControl1_Load(object sender, EventArgs e)
        {
            stiViewerControl1.Report = _sti;
        }
    }
}
