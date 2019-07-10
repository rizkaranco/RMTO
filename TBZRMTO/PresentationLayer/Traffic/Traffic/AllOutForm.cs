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
    public partial class AllOutForm :Hepsa.Core.PL.BaseEntityForm2
    {
        public AllOutForm()
        {
            InitializeComponent();

            TrafficGridView.AutoGenerateColumns = false;
            this.State = enmFormState.Edit;
            this.EditAndClose = false;
            ((ToolStripButton)this.SaveAndContinueButton).ToolTipText = "حذف خروج";

            Hepsa.Core.PL.BaseListForm.GroupList GroupList = new Hepsa.Core.PL.BaseListForm.GroupList(this.CreateGraphics());
            Hepsa.Core.PL.BaseListForm.Group Group = new Hepsa.Core.PL.BaseListForm.Group();
            Group.set_Grid(true, true, true, this.TrafficGridView);
            Group.ToolStrip = this.ToolStrip1;
            Group.HasFilterControl = true;
            GroupList.Add(Group);
        }

        private void AllOutForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadGrid();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }
        protected override void Edit()
        {
            try
            {
                if (TrafficGridView.CurrentRow != null && (Int64)TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value != 0)
                {
                    HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                    DataTable OutDataTable = new DataTable();
                    string outcondition = "";
                    TrafficFactory.GetAllByConditionOut("", ref OutDataTable);
                    if ((Int64)TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value != (Int64)TrafficGridView.CurrentRow.Cells[colMaxTrafficID_bint.Name].Value)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("امکان احیای این خروج وجود ندارد ، این ناوگان ورود داشته است");
                        return;
                    }
                    if (Hepsa.Core.Common.MessageBox.ConfirmMessage("آیا از احیای این خروج اطمینان دارید؟") == true)
                    {
                        HPS.BLL.TrafficBLL.BLLTraffic_TFactory trafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                        HPS.BLL.TrafficBLL.BLLTraffic_TKeys trafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                        trafficKey.TrafficID_bint = (Int64)TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value;
                        string _LogBody = "<table border=\"1\">";
                        foreach (DataGridViewColumn col in TrafficGridView.Columns)
                        {
                            if (col.Visible)
                                _LogBody += string.Format("<tr><td>{0}</td><td>{1}</td></tr>", col.HeaderText, TrafficGridView.CurrentRow.Cells[col.Name].Value);
                        }
                        _LogBody += "</table>";

                        trafficFactory.BeginProc();
                        trafficFactory.Delete(trafficKey);
                        /********Start Logging********/
                        Hepsa.Core.BLL.BLLLog_TFactory LogFactory = new Hepsa.Core.BLL.BLLLog_TFactory();
                        Hepsa.Core.BLL.BLLLog_T LogEntity = new Hepsa.Core.BLL.BLLLog_T();
                        LogEntity.Date_nvc = LogFactory.ServerJalaliDate;
                        LogEntity.Time_nvc = LogFactory.ServerTime;
                        LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress;
                        LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress;
                        LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc;
                        LogEntity.FormText_nvc = String.IsNullOrEmpty(this.Text) ? this.Name : this.Text;
                        LogEntity.ActionID_int =Convert.ToInt32(Hepsa.Core.BLL.BLLAction_T.Actions.Delete);
                        LogEntity.Body_nvc = _LogBody;
                        LogFactory.Insert(LogEntity);
                        /********End Logging********/
                        trafficFactory.CommitProc();
                        this.LoadGrid();
                    }
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
           
        }

        private void LoadGrid()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable OutDataTable = new DataTable();
            try
            {
                TrafficFactory.GetAllByConditionOut("", ref OutDataTable);
                TrafficGridView.DataSource = OutDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
