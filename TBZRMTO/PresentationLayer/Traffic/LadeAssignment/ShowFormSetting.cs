using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignment
{
    public partial class ShowFormSetting : Hepsa.Core.PL.BaseForm
    {
        public ShowFormSetting()
        {
            InitializeComponent();
        }

        private  void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                string LaderTypesID_nvc = string.Empty;
                if (!string.IsNullOrEmpty(TimerTime_intTextBox.Text))
                {
                    if (LaderTypeGridView.GetCheckedRows() != null)
                    {
                        foreach (Janus.Windows.GridEX.GridEXRow row in LaderTypeGridView.GetCheckedRows())
                        {
                            LaderTypesID_nvc = LaderTypesID_nvc + row.Cells["LaderTypeID_int"].Value.ToString() + ",";
                        }
                    }
                    if (LaderTypesID_nvc.EndsWith(","))
                    {
                        LaderTypesID_nvc = LaderTypesID_nvc.Substring(0, LaderTypesID_nvc.Length - 1);
                    }        
                        HPS.Present.LadeAssignment.LadeAssignmentRepeaterForm frm = new HPS.Present.LadeAssignment.LadeAssignmentRepeaterForm(int.Parse(TimerTime_intTextBox.Text) * 1000, LaderTypesID_nvc, Convert.ToInt32(!string.IsNullOrEmpty(CommentShowTimeTextBox.Text) ? CommentShowTimeTextBox.Text : null));
                        frm.Show();

                    //this.Close();
                }
                else
                {
                    throw new ApplicationException("مدت زمان نمایش را وارد نمایید");
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ShowFormSetting_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadLaderType();
                this.LaderTypeGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void CheckAllbutton_Click(object sender, EventArgs e)
        {
            LaderTypeGridView.CheckAllRecords();
        }

        private void LoadLaderType()
        {
            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                string Condition = "[LaderType_T].[Active_bit]='true' AND TurnCancel_bit='true'";
                DataTable LaderTypeDataTable = new DataTable();
                LaderTypeFactory.GetAllByCondition(Condition, ref LaderTypeDataTable);
                this.LaderTypeGridView.DataSource = LaderTypeDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void ShowFormSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F3)
            {
                ShowButton.PerformClick();
            }
        }
    }
}
