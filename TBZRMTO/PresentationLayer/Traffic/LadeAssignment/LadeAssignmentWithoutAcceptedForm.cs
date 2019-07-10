using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignment
{
    public partial class LadeAssignmentWithoutAcceptedForm : Hepsa.Core.PL.BaseListForm
    {
        DataTable LadeAssignmentDataTable = new DataTable();
        public LadeAssignmentWithoutAcceptedForm()
        {
            InitializeComponent();


            Hepsa.Core.PL.BaseListForm.Group LadeAssignmentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeAssignmentGroup.RefreshButton = this.RefreshButton;
            LadeAssignmentGroup.set_Grid(true, false, false, this.LadeAssignmentGridView);
            LadeAssignmentGroup.ToolStrip = this.LadeAssignmentToolStrip;
            LadeAssignmentGroup.HasFilterControl = true;
            this.Groups.Add(LadeAssignmentGroup);
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadLadeAssignmentWithDate();
        }
        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LadeAssignmentWithoutAcceptedForm_Load(object sender, EventArgs e)
        {
            LoadLadeAssignmentWithDate();
        }
       
        private void LoadLadeAssignmentWithDate()
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                Properties.Settings Setting=new HPS.Properties.Settings();
                string Condition = string.Empty;
                if (Setting.SaloonID_int!=0)
                {
                    Condition = string.Format("[LadeAssignment_T].[Accepted_bit]='false' AND LadeAssignment_T.LadingDate_nvc='{0}' AND (LT.SaloonID_int ={1}) ", LadeAssignmentFactory.ServerJalaliDate, Setting.SaloonID_int );

                }
                else
                    Condition = string.Format("[LadeAssignment_T].[Accepted_bit]='false' AND LadeAssignment_T.LadingDate_nvc='{0}' ", LadeAssignmentFactory.ServerJalaliDate);
                LadeAssignmentDataTable.Clear();
                LadeAssignmentFactory.GetForAccept(Condition, ref LadeAssignmentDataTable);
                LadeAssignmentGridView.DataSource = null;
                this.LadeAssignmentGridView.SetDataBinding(LadeAssignmentDataTable, "LadeAssignmentDataTable");
                Janus.Windows.GridEX.GridEXFormatStyle Focus = new Janus.Windows.GridEX.GridEXFormatStyle();
                Focus.FontSize = 20;
                Janus.Windows.GridEX.GridEXFormatStyle yellow = new Janus.Windows.GridEX.GridEXFormatStyle();
                yellow.BackColor = System.Drawing.Color.FromArgb(253, 217, 142);
                for (int i = 0; i < ((DataTable)LadeAssignmentGridView.DataSource).Rows.Count; i++ )
                {
                    if (LadeAssignmentGridView.GetRow(i).Cells["EditUserName_nvc"].Value != DBNull.Value && LadeAssignmentGridView.GetRow(i).Cells["AcceptUserName_nvc"].Value != DBNull.Value)
                    {
                        LadeAssignmentGridView.GetRow(i).RowStyle = yellow;
                        LadeAssignmentGridView.GetRow(i).Cells["EditUserName_nvc"].FormatStyle = yellow;
                    }
                }
                ChooseLadeAssignmentAcceptedButton.Select();
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
      
        private void LoadLadeAssignment()
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                Properties.Settings Setting = new HPS.Properties.Settings();
                string Condition = string.Format("[LadeAssignment_T].[Accepted_bit]='false' AND (SaloonID_int IS NULL OR LT.SaloonID_int={0}) ", Setting.SaloonID_int != 0 ? Setting.SaloonID_int : 0);
                DataTable LadeAssignmentDataTable = new DataTable();
                LadeAssignmentFactory.GetForAccept(Condition, ref LadeAssignmentDataTable);
                this.LadeAssignmentGridView.SetDataBinding(LadeAssignmentDataTable, "LadeAssignmentDataTable");
               
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void LadeAssignmentAcceptedButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LadeAssignmentGridView.GetCheckedRows().Length>1)
                {
                    throw new ApplicationException("تعداد بارگیر انتخاب شده بیشتر از یک مورد است");
                }
                if (LadeAssignmentGridView != null && LadeAssignmentGridView.GetCheckedRows().Length>0 )
                {
                    HPS.Present.LadeAssignment.LadeAssignmentAcceptForm frm = new LadeAssignmentAcceptForm((Int64)this.LadeAssignmentGridView.CurrentRow.Cells["LadeAssignmentID_bint"].Value, (DataTable)this.LadeAssignmentGridView.DataSource);
                    frm.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AllLadeAssignmenttoolStripButton_Click(object sender, EventArgs e)
        {
            this.LoadLadeAssignment();
        }

        private void ChooseLadeAssignmentAcceptedButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity=new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T() ;
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKeys = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();
                DataTable gridTable = new DataTable();
                gridTable = LadeAssignmentDataTable.Copy();

                DataRow[] dr = null;
                LadeAssignmentFactory.BeginProc();
                foreach (Janus.Windows.GridEX.GridEXRow itm in LadeAssignmentGridView.GetCheckedRows())
                {
                    LadeAssignmentKeys.LadeAssignmentID_bint = (Int64)itm.Cells["LadeAssignmentID_bint"].Value;
                    LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKeys);
                    LadeAssignmentEntity.Accepted_bit = true;
                    LadeAssignmentEntity.AcceptUserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                    LadeAssignmentEntity.AcceptDate_vc = LadeAssignmentFactory.ServerJalaliDate;
                    LadeAssignmentEntity.AcceptTime_vc = LadeAssignmentFactory.ServerTime;
                    LadeAssignmentFactory.Update(LadeAssignmentEntity, LadeAssignmentKeys);

                    dr = gridTable.Select(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint.ToString() + "='" + (Int64)itm.Cells["LadeAssignmentID_bint"].Value + "'");
                    if (dr.Length > 0)
                    {
                        dr[0].Delete();
                    }
                    gridTable.AcceptChanges();

                    
                }
                LadeAssignmentFactory.CommitProc();
                LadeAssignmentGridView.DataSource = null;
                LadeAssignmentGridView.SetDataBinding(gridTable, "gridTable");
                LadeAssignmentDataTable = gridTable.Copy();
                gridTable.Dispose();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void LadeAssignmentWithoutAcceptedForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F8)
            {
                LoadLadeAssignmentWithDate();
            }
        }

        private void SelectAlltoolStripButton_Click(object sender, EventArgs e)
        {
            LadeAssignmentGridView.CheckAllRecords();
        }

        private void LadeAssignmentGridView_RowCheckStateChanged(object sender, Janus.Windows.GridEX.RowCheckStateChangeEventArgs e)
        {
            Janus.Windows.GridEX.GridEXFormatStyle yellow = new Janus.Windows.GridEX.GridEXFormatStyle();
            yellow.BackColor = System.Drawing.Color.FromArgb(253, 217, 142);
            Janus.Windows.GridEX.GridEXFormatStyle White = new Janus.Windows.GridEX.GridEXFormatStyle();
            White.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            Janus.Windows.GridEX.GridEXFormatStyle Blue = new Janus.Windows.GridEX.GridEXFormatStyle();
            //Blue.BackColor = System.Drawing.Color.FromArgb(192, 222, 255);
            Blue.BackColor = System.Drawing.Color.FromArgb(64, 156, 225);
            Blue.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            if (LadeAssignmentGridView.CurrentRow.IsChecked)
            {
                LadeAssignmentGridView.CurrentRow.RowStyle = Blue;
                LadeAssignmentGridView.CurrentRow.Cells["EditUserName_nvc"].FormatStyle = Blue;
            }
            else
            {
                if (LadeAssignmentGridView.CurrentRow.Cells["EditUserName_nvc"].Value != DBNull.Value && LadeAssignmentGridView.CurrentRow.Cells["AcceptUserName_nvc"].Value != DBNull.Value)
                {
                    yellow.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    LadeAssignmentGridView.CurrentRow.RowStyle = yellow;
                    LadeAssignmentGridView.CurrentRow.Cells["EditUserName_nvc"].FormatStyle = yellow;
                }
                else
                {
                    White.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
                    LadeAssignmentGridView.CurrentRow.RowStyle = White;
                    LadeAssignmentGridView.CurrentRow.Cells["EditUserName_nvc"].FormatStyle = White;
                }
            }
          
            
              
        }
    }
}
