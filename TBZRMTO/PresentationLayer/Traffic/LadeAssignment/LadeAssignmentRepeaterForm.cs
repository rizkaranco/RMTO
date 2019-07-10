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
    public partial class LadeAssignmentRepeaterForm : Hepsa.Core.PL.BaseListForm
    {
        private int StartIndex = 0;
        private DataTable LadeAssignmentDataTable = null;
        private int _Timertime = 0;
        private string _LaderTypesID_nvc;
        private int? _commentShowTime;

        public LadeAssignmentRepeaterForm(int? Timertime, string LaderTypesID_nvc, int? commentShowTime)
            : base()
        {
            InitializeComponent();
            Group RepeaterGroup = new Group();
            RepeaterGroup.GroupName = "RepeaterGroup";
            RepeaterGroup.set_Grid(true, true, true, this.dataGridView1);
            RepeaterGroup.ToolStrip = null;
            RepeaterGroup.AddButton = null;
            RepeaterGroup.EditButton = null;
            RepeaterGroup.DeleteButton = null;
            RepeaterGroup.RefreshButton = null;
            RepeaterGroup.HasFilterControl = false;
            this.Groups.Add(RepeaterGroup);
            _Timertime = Timertime.Value;
            _LaderTypesID_nvc = LaderTypesID_nvc;
            _commentShowTime = commentShowTime;
        }

        private void LadeAssignmentRepeaterForm_Load(object sender, EventArgs e)
        {
            this.Width = SystemInformation.PrimaryMonitorSize.Width - 20;
            this.Height = SystemInformation.PrimaryMonitorSize.Height - 100;
            this.timer1.Enabled = true;
            timer1.Interval = _Timertime;
            this.timer1.Start();

            BLL.BillMessageBLL.BLLBillMessage_TFactory billMessageFactory = new HPS.BLL.BillMessageBLL.BLLBillMessage_TFactory();
            string conditioin = string.Empty;
            if (Properties.Settings.Default.SaloonID_int != 0)
            {
                conditioin = string.Format("[BillMessage_T].[StartDate_nvc]<='{0}' AND [BillMessage_T].[EndDate_nvc]>='{0}' AND [BillMessage_T].SaloonID_int={1}", billMessageFactory.ServerJalaliDate, Properties.Settings.Default.SaloonID_int);
            }
            else
            {
                conditioin = string.Format("[BillMessage_T].[StartDate_nvc]<='{0}' AND [BillMessage_T].[EndDate_nvc]>='{0}' AND ShowInLadeAssignmentRepetation_bit=1", billMessageFactory.ServerJalaliDate);
            }
            List<BLL.BillMessageBLL.BLLBillMessage_T> BillMessageList = new List<HPS.BLL.BillMessageBLL.BLLBillMessage_T>();
            BillMessageList = billMessageFactory.GetAllByCondition(conditioin);
            if (BillMessageList != null && BillMessageList.Count > 0)
            {
                string marqueeText = string.Format("<style type=\"text/css\">.html-marquee {{width:100%;height:100%; verticalalign:center; background-color:FFFFCC;font-family:B Mitra;font-size:70px;color:660000;font-weight:bold;border-width:2;border-style:dotted;border-color:660000;}}</style> <marquee class=\"html-marquee\" direction=\"right\" behavior=\"scroll\" scrollamount=\"{0}\" >{1}</marquee>", _commentShowTime != 0 ? _commentShowTime.Value : 2, ((BLL.BillMessageBLL.BLLBillMessage_T)BillMessageList[0]).Message_nvc);
                webBrowser1.DocumentText = marqueeText;
                //marqueeControl1.Interval =_commentShowTime!=0?_commentShowTime.Value:100;
                //marqueeControl1.MarqueeText = ((BLL.BillMessageBLL.BLLBillMessage_T)BillMessageList[0]).Message_nvc;
            }
        }

        private  void timer1_Tick(object sender, EventArgs e)
        {

                try
                {
                    HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();

                    if (this.LadeAssignmentDataTable == null || this.StartIndex >= this.LadeAssignmentDataTable.Rows.Count || StartIndex == 0)
                    {
                        LadeAssignmentDataTable = new DataTable();
                        LadeAssignmentFactory.GetAllActives(ref LadeAssignmentDataTable, _LaderTypesID_nvc);
                        this.StartIndex = 0;
                    }
                    if (this.LadeAssignmentDataTable != null && this.LadeAssignmentDataTable.Rows.Count > 0)
                    {
                        this.dataGridView1.Rows.Clear();
                        for (int index = this.StartIndex; index < Math.Min(this.StartIndex + 5, this.LadeAssignmentDataTable.Rows.Count); index++)
                        {
                            this.dataGridView1.Rows.Add();
                            DataGridViewRow row = this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1];
                            //row.Cells[this.colOrder_int.Name].Value = LadeAssignmentDataTable.Rows[index]["Order_int"];
                            row.Cells[this.colLaderType_nvc.Name].Value = LadeAssignmentDataTable.Rows[index]["LaderType_nvc"];
                            row.Cells[this.colCarCount_int.Name].Value = LadeAssignmentDataTable.Rows[index]["CarCount_int"];
                            row.Cells[this.colCity_nvc.Name].Value = LadeAssignmentDataTable.Rows[index]["City_nvc"];
                            row.Cells[this.colGood_nvc.Name].Value = LadeAssignmentDataTable.Rows[index]["Good_nvc"];
                            //row.Cells[this.colWeight_flt.Name].Value = LadeAssignmentDataTable.Rows[index]["Weight_dec"];
                            row.Cells[this.colPortageFee_dec.Name].Value = LadeAssignmentDataTable.Rows[index]["PortageFee_dec"];
                            //row.Cells[this.colComment_nvc.Name].Value = LadeAssignmentDataTable.Rows[index]["Comment_nvc"];
                            row.Cells[this.colBoxingType_nvc.Name].Value = LadeAssignmentDataTable.Rows[index]["BoxingType_nvc"];
                            row.Cells[this.colCompany_nvc.Name].Value = LadeAssignmentDataTable.Rows[index]["Company_nvc"];
                            row.Cells[this.colRemainedCount_int.Name].Value = LadeAssignmentDataTable.Rows[index]["RemainedCount_int"];
                            row.Cells[this.colLadBillCount_int.Name].Value = LadeAssignmentDataTable.Rows[index]["LadBillCount_int"];
                        }
                        this.dataGridView1.Update();
                        this.StartIndex += 5;
                        if (StartIndex >= this.LadeAssignmentDataTable.Rows.Count)
                            this.StartIndex = 0;
                    }
                    else
                    {
                        this.dataGridView1.Rows.Clear();
                    }
                }
                catch (Exception ex)
                {
                }
      
        }

        private void LadeAssignmentRepeaterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer1.Stop();
        }
    }
}
