using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.TurnManagement
{
    public partial class TurnManagementListForm : Hepsa.Core.PL.BaseListForm
    {
        Int32 _TurnStatus = 0;
        public TurnManagementListForm(Int32 TurnStatus)
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group TurnManagementGroup = new Hepsa.Core.PL.BaseListForm.Group();
                TurnManagementGroup.AddButton = this.NewButton;
                TurnManagementGroup.DeleteButton = this.DeleteButton;
                TurnManagementGroup.EditButton = this.EditButton;
                TurnManagementGroup.RefreshButton = this.RefreshButton;
                TurnManagementGroup.ExportButton = this.ExportButton;
                TurnManagementGroup.set_Grid(true,true,true, this.TurnManagementGridView);
                TurnManagementGroup.ToolStrip = this.TurnManagementToolStrip;
                TurnManagementGroup.HasFilterControl = true;

            this.Groups.Add(TurnManagementGroup);
            this._TurnStatus = TurnStatus;
        }

         private void TurnManagementListForm_Load(object sender, EventArgs e)
       {
           if (_TurnStatus==1)
           {
               this.Text = "لیست نوبت ها برای احیا";
               CanceledTurnFromLadbilltoolStripButton.Visible = true;
           }
           else
               this.Text = "لیست نوبت ها برای ابطال";

       }
      
        private void LoadTurnManagement()
         {
             try
             {      
                 if (_TurnStatus == 1)//return
                 {
                     HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                     HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                     HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                     DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(SettingFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + SettingFactory.ServerTime);
                     DateTime SubtractedTime = NowDate.Subtract(new TimeSpan(Convert.ToInt32(SettingEntity.Value_nvc), 0, 0));

                     SettingKey.SettingID_int = 1001;
                     SettingEntity = SettingFactory.GetBy(SettingKey);
                     HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                     DataTable TurnManagementDataTable = new DataTable();
                     TurnManagementFactory.GetAllWithTrafficForReturnTurn(SettingFactory.ServerJalaliDate, SubtractedTime.ToString("HH:mm"),null,null,string.Empty,string.Empty,string.Empty,string.Empty, ref TurnManagementDataTable);
                     this.TurnManagementGridView.DataSource = TurnManagementDataTable;
                 }
                 else//cancel
                 {
                     CanceledTurnFromLadbilltoolStripButton.Visible = false;
                    
                     HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                     DataTable TurnManagementDataTable = new DataTable();
                     TurnManagementFactory.GetAllWithTrafficForCancelTurn( null, null, string.Empty, string.Empty, string.Empty, string.Empty, ref TurnManagementDataTable);
                     this.TurnManagementGridView.DataSource = TurnManagementDataTable;
                 }

                 
             }
             catch (System.Exception ex)
             {
                 throw ex;
             }

         }

         private void NewButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                if (TurnManagementGridView.Rows.Count != 0)
                {
                    Int64? s = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TurnManagementGridView.CurrentRow.Cells["colTurnManagementID_int"].Value, TypeCode.Int64);
                    if (s.HasValue)
                    {
                        string condition = "([TurnManagement_T].[TurnManagementID_int]=" + s.ToString() + ")";
                        DataTable dt = new DataTable();
                        TurnManagementFactory.GetAllByConditionWithTraffic(condition, ref dt);
                        if (Convert.ToBoolean(dt.Rows[0]["Return_bit"].ToString()) == false && !string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["TurnCancelCommantID_int"])))
                        {
                            Hepsa.Core.Common.MessageBox.InformationMessage("این نوبت باطل شده است");
                        }
                    }
                    HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                    TrafficKey.TrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TurnManagementGridView.CurrentRow.Cells[this.colTurnManagementTrafficID_bint.Name].Value, TypeCode.Int64);
                    if (_TurnStatus == 1)
                    {
                        TurnManagementEntityForm TurnManagement = new TurnManagementEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.TurnManagementGridView.DataSource, TrafficKey, 1,Convert.ToInt32(TurnManagementGridView.CurrentRow.Cells[this.colLadBillCreditID_int.Name].Value));
                        TurnManagement.ShowDialog();
                    }
                    else
                    {
                        TurnManagementEntityForm TurnManagement = new TurnManagementEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.TurnManagementGridView.DataSource, TrafficKey, 0,null);
                        TurnManagement.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
          
        }

         private void EditButton_Click(object sender, EventArgs e)
         {
         }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory=new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagement_TFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
            HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys TurnManagementKey= new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TKeys();

            TurnManagementKey.TurnManagementID_int = (Int32?)TurnManagementGridView.CurrentRow.Cells["colTurnManagementID_int"].Value;
            TurnManagementFactory.Delete(TurnManagementKey);

            DataRow[] dr=((DataTable)this.TurnManagementGridView.DataSource).Select(HPS.BLL.TurnManagementBLL.BLLTurnManagement_T.TurnManagement_TField.TurnManagementID_int.ToString() + "='" +TurnManagementKey.TurnManagementID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.TurnManagementGridView.DataSource).AcceptChanges();
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.ClearTextBoxes();
                this.LoadTurnManagement();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          }

        private void CanceledTurnFromLadbilltoolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                DataTable CanceledTurnDataTable = new DataTable();
                TurnManagementFactory.GetCanceledTurn(ref CanceledTurnDataTable);
                this.TurnManagementGridView.DataSource = CanceledTurnDataTable;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void CloceButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrentTurnStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ClearTextBoxes();
                this.LoadTurnManagement();
                this.TurnManagementGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void TrafficNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("AcceptedTurnNumberRule", "شماره نوبت تأیید شده", 1, null, null, 0);
                        if (NumericValidator.Validate(AcceptedTurnNumberTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        Search();
                    }
                    else
                    {
                        this.TurnManagementGridView.DataSource = null;
                    }
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDate_nvcTextBox.Text = string.Empty;
                    ToDate_nvcTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void AcceptedTurnNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("AcceptedTurnNumberRule", "شماره نوبت تأیید شده", 1, null, null, 0);
                        if (NumericValidator.Validate(Convert.ToInt64(AcceptedTurnNumberTextBox.Text)) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        Search();
                    }
                    else
                    {
                        this.TurnManagementGridView.DataSource = null;
                    }
                    TrafficNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDate_nvcTextBox.Text = string.Empty;
                    ToDate_nvcTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void SerialPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
                    {
                        Search();
                    }
                    else
                    {
                        this.TurnManagementGridView.DataSource = null;
                        throw new ApplicationException("شماره یا سری پلاک خالی است");
                    }
                    TrafficNumberTextBox.Text = string.Empty;
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    FromDate_nvcTextBox.Text = string.Empty;
                    ToDate_nvcTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void Search()
        {
            try
            {
                TurnManagementGridView.DataSource = null;

                DataTable TrafficDataTable = new DataTable();
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = string.Empty;

                if (_TurnStatus == 1)//return
                {
                    HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                    HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                    HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                    SettingKey.SettingID_int = 1001;
                    SettingEntity = SettingFactory.GetBy(SettingKey);
                   
                    DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(SettingFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + SettingFactory.ServerTime);
                    DateTime SubtractedTime = NowDate.Subtract(new TimeSpan(Convert.ToInt32(SettingEntity.Value_nvc), 0, 0));

                    

                    HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                    DataTable TurnManagementDataTable = new DataTable();
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForReturnTurn(SettingFactory.ServerJalaliDate, SubtractedTime.ToString("HH:mm"), Int64.Parse(TrafficNumberTextBox.Text), null, string.Empty, string.Empty,string.Empty,string.Empty, ref TurnManagementDataTable);
                    }
                    else if(!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForReturnTurn(SettingFactory.ServerJalaliDate, SubtractedTime.ToString("HH:mm"), null, Int64.Parse(AcceptedTurnNumberTextBox.Text), string.Empty, string.Empty, string.Empty, string.Empty, ref TurnManagementDataTable);
                    }
                    else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForReturnTurn(SettingFactory.ServerJalaliDate, SubtractedTime.ToString("HH:mm"), null, null, NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, string.Empty, string.Empty, ref TurnManagementDataTable);
                    }
                    else if (!string.IsNullOrEmpty(FromDate_nvcTextBox.Text) && !string.IsNullOrEmpty(ToDate_nvcTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForReturnTurn(SettingFactory.ServerJalaliDate, SubtractedTime.ToString("HH:mm"), null, null, string.Empty, string.Empty, FromDate_nvcTextBox.Text, ToDate_nvcTextBox.Text, ref TurnManagementDataTable);
                    }
                    this.TurnManagementGridView.DataSource = TurnManagementDataTable;
                }
                else//cancel
                {
                    CanceledTurnFromLadbilltoolStripButton.Visible = false;
                    this.Text = "لیست نوبت ها برای ابطال";
                    HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                    DataTable TurnManagementDataTable = new DataTable();
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForCancelTurn(Int64.Parse(TrafficNumberTextBox.Text), null, string.Empty, string.Empty,string.Empty, string.Empty, ref TurnManagementDataTable);
                    }
                    else if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForCancelTurn(null, Int64.Parse(AcceptedTurnNumberTextBox.Text), string.Empty, string.Empty, string.Empty, string.Empty, ref TurnManagementDataTable);
                    }
                    else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForCancelTurn(null, null, NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text,string.Empty, string.Empty, ref TurnManagementDataTable);
                    }
                    else if (!string.IsNullOrEmpty(FromDate_nvcTextBox.Text) && !string.IsNullOrEmpty(ToDate_nvcTextBox.Text))
                    {
                        TurnManagementFactory.GetAllWithTrafficForCancelTurn(null, null, string.Empty, string.Empty,FromDate_nvcTextBox.Text,ToDate_nvcTextBox.Text, ref TurnManagementDataTable);
                    }
                    this.TurnManagementGridView.DataSource = TurnManagementDataTable;
                }

            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
       
        private void ClearTextBoxes()
        {
            TrafficNumberTextBox.Text = string.Empty;
                AcceptedTurnNumberTextBox.Text = string.Empty;
                NumberPlate_nvcTextBox.Text = string.Empty;
                SerialPlate_nvcTextBox.Text = string.Empty;
        }

        private void ToDate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromDate_nvcTextBox)))
                    {
                        throw new ApplicationException("از تاریخ خالی است");
                    }
                    else if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToDate_nvcTextBox)))
                    {
                        throw new ApplicationException("تا تاریخ خالی است");
                    }
                    TrafficNumberTextBox.Text = string.Empty;
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    Search();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromDate_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        private void ToDate_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void TodayTurnButton_Click(object sender, EventArgs e)
        {
            LoadTurnManagement();
        }

        private void LoadAllTurnManagement()
        {
            try
            {

                if (_TurnStatus == 1)//return
                {

                    HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                    HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                    HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                    DateTime NowDate = DateTime.Parse((new Hepsa.Core.Common.MyDateTime(SettingFactory.ServerJalaliDate)).MyDate.ToString("yyyy/MM/dd") + " " + SettingFactory.ServerTime);
                    DateTime SubtractedTime = NowDate.Subtract(new TimeSpan(Convert.ToInt32(SettingEntity.Value_nvc), 0, 0));

                    SettingKey.SettingID_int = 1001;
                    SettingEntity = SettingFactory.GetBy(SettingKey);
                    HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                    DataTable TurnManagementDataTable = new DataTable();
                    TurnManagementFactory.GetAllWithTrafficForReturnTurn(SettingFactory.ServerJalaliDate, SubtractedTime.ToString("HH:mm"), null, null, string.Empty, string.Empty, string.Empty, string.Empty, ref TurnManagementDataTable);
                    this.TurnManagementGridView.DataSource = TurnManagementDataTable;
                }
                else//cancel
                {
                    CanceledTurnFromLadbilltoolStripButton.Visible = false;

                    HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                    DataTable TurnManagementDataTable = new DataTable();
                    TurnManagementFactory.GetAllWithTrafficForCancelTurn(null, null, string.Empty, string.Empty, string.Empty, string.Empty, ref TurnManagementDataTable);
                    this.TurnManagementGridView.DataSource = TurnManagementDataTable;
                }


            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                 //ابطال نوبت 
                HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
                if (TurnManagementGridView.Rows.Count != 0)
                {
                    Int64? s = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TurnManagementGridView.CurrentRow.Cells["colTurnManagementID_int"].Value, TypeCode.Int64);
                    if (s.HasValue)
                    {
                        string condition = "([TurnManagement_T].[TurnManagementID_int]=" + s.ToString() + ")";
                        DataTable dt = new DataTable();
                        TurnManagementFactory.GetAllByConditionWithTraffic(condition, ref dt);
                        if (Convert.ToBoolean(dt.Rows[0]["Return_bit"].ToString()) == false && !string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["TurnCancelCommantID_int"])))
                        {
                            Hepsa.Core.Common.MessageBox.InformationMessage("این نوبت باطل شده است");
                        }
                    }
                    HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                    TrafficKey.TrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TurnManagementGridView.CurrentRow.Cells[this.colTurnManagementTrafficID_bint.Name].Value, TypeCode.Int64);
                    //if (_TurnStatus == 1)
                    //{
                        TurnManagementEntityForm TurnManagement = new TurnManagementEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.TurnManagementGridView.DataSource, TrafficKey, 0, 0);
                        TurnManagement.ShowDialog();
                    //}
                    //else
                    //{
                    //    TurnManagementEntityForm TurnManagement = new TurnManagementEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.TurnManagementGridView.DataSource, TrafficKey, 0, null);
                    //    TurnManagement.ShowDialog();
                    //}
                }
            //HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory TurnManagementFactory = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_TFactory();
            //    HPS.BLL.TurnManagementBLL.BLLTurnManagement_T TurnManagementEntity = new HPS.BLL.TurnManagementBLL.BLLTurnManagement_T();
            //TurnManagementEntity.TurnCancelCommantID_int =38;
            //TurnManagementEntity.TurnCancelCommment_nvc = "به دستور مديريت نوبت باطل گرديد";
            //TurnManagementEntity.Return_bit = false;
            //TurnManagementEntity.Date_nvc = TurnManagementFactory.ServerJalaliDate;
            //TurnManagementEntity.Time_nvc = TurnManagementFactory.ServerTime;
            //TurnManagementEntity.UserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
            //TurnManagementEntity.TrafficID_bint = (Int64?)TurnManagementGridView.CurrentRow.Cells["TrafficID_bint"].Value;
            //TurnManagementFactory.Insert(TurnManagementEntity);
            }
            catch (Exception ex)
            {
                
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }
     }
}