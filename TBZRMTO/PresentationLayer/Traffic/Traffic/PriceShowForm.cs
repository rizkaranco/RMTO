using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Traffic
{
    public partial class PriceShowForm : Hepsa.Core.PL.BaseListForm
    {
        public PriceShowForm(decimal? Price)
        {
            InitializeComponent();
            PriceTextBox.Text = Price.ToString();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
