using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class AllTrafficForm : Hepsa.Core.PL.BaseListForm
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T _TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
        HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();

        DataTable CarTrafficDatatable;
        HPS.Main mainfrm = new HPS.Main();
        bool InNotOut = false;
        private int TrafficType;

        private int _TrafficTypeID;
        public int TrafficTypeID
        {
            get
            {
                return _TrafficTypeID;
            }
            set
            {
                _TrafficTypeID = value;
            }
        }

        public AllTrafficForm(int TrafficType)
        {
            
            InitializeComponent();
            this.TrafficType = TrafficType;

            this.TrafficGridView.AutoGenerateColumns = false;

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, false, false, this.TrafficGridView);
            TrafficGroup.RefreshButton = this.RefreshButton;
            TrafficGroup.ExportButton = this.ExportToExcelStripButton;
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);
            if (TrafficType == 1)
            {
                this.Text = "ورود و خروج كاميون هاي ايراني";
            }
            else if (TrafficType == 2)
            {
                this.Text = "ورود و خروج كاميون هاي خارجی";
            }
            else
            {
                this.Text = "ورود و خروج سواری و سایر خودروها";
            }
        }


        private void LoadAllTraffic()
        {
            try
            {
                if (TrafficType == 1)
                {
                    this.LoadIranianTraffic();
                    this.TrafficGridView.Focus();
                }
                else if (TrafficType == 2)
                {
                    this.LoadForeignTraffic();
                    this.TrafficGridView.Focus();
                }
                else
                {
                    this.LoadOtherTraffic();
                    this.TrafficGridView.Focus();
                }
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void AllTrafficForm_Load(object sender, EventArgs e)
        {
            TrafficNumberTextBox.Focus();


            try
            {
                DataTable BooleanComboTable = new DataTable();
                BooleanComboTable.Columns.Add("DisplayMember");
                BooleanComboTable.Columns.Add("ValueMember");

                BooleanComboTable.Rows.Add(new Object[] { "", "" });
                BooleanComboTable.Rows.Add(new Object[] { "تأیید نوبت", "TurnAccepted" });
                BooleanComboTable.Rows.Add(new Object[] { "مجوز", "LadBillCredit" });
                BooleanComboTable.Rows.Add(new Object[] { "ابطال نوبت", "CancelTurn" });
                BooleanComboTable.Rows.Add(new Object[] { "ابطال مجوز", "CancelLadBillCredit" });
                BooleanComboTable.Rows.Add(new Object[] { "احیای نوبت", "ReturnTurn" });

                BooleanComboBox.DisplayMember = "DisplayMember";
                BooleanComboBox.ValueMember = "ValueMember";
                BooleanComboBox.DataSource = BooleanComboTable;

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderTypeFactory.ServerJalaliDate);
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(LaderTypeFactory.ServerJalaliDate);

            AllCurrentTrafficButton.PerformClick();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();

            try
            {
                TrafficKey.TrafficID_bint = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TrafficGridView.CurrentRow.Cells["colTrafficID_bint"].Value, TypeCode.Int64);
                this._TrafficEntity = TrafficFactory.GetBy(TrafficKey);

                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.TrafficNumber_bint, this.TrafficGridView.CurrentRow.Cells["colTrafficNumber_bint"].Value);
                if (TrafficList.Count > 0 && TrafficList != null)
                {

                    foreach (HPS.BLL.TrafficBLL.BLLTraffic_T item in TrafficList)
                    {
                        //TODO: برای مدیر سیستم چاپ مجدد فعال است
                        if (item.Out_bit == true && HPS.Common.CurrentUser.user.UserGroupID_int != 1)
                        {

                            Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو خارج شده است");
                            return;

                        }
                    }

                    //TODO: برای مدیر سیستم چاپ مجدد فعال است
                    if (TrafficList.Count == 2 && HPS.Common.CurrentUser.user.UserGroupID_int != 1)
                    {
                        return;
                    }
                }
                if (TrafficType == 1)
                {
                    if (_TrafficEntity.ServiceID_int == 2)
                    {

                        //HPS.Reports.ReportDoc.AcceptedTurnReport rpt = new HPS.Reports.ReportDoc.AcceptedTurnReport(_TrafficEntity);
                        //rpt.Document.Printer.PrinterName = string.Empty;
                        //rpt.Run();
                        //Properties.Settings s = new HPS.Properties.Settings();
                        //if (string.IsNullOrEmpty(s.PrinterName))
                        //{
                        //    rpt.Document.Print(true, true, true);
                        //}
                        //else
                        //{
                        //    rpt.Document.Printer.PrinterName = s.PrinterName;
                        //    rpt.Document.Print(false, true, true);
                        //}

                        _TrafficEntity.TurnPrinted_bit = true;
                        StimulViewer frm = new StimulViewer(_TrafficEntity, false, false);
                        frm.ShowDialog();
                        //

                    }
                    else
                    {
                        //HPS.Reports.ReportDoc.TrafficReport rpt = new HPS.Reports.ReportDoc.TrafficReport(_TrafficEntity);
                        //rpt.Document.Printer.PrinterName = string.Empty;
                        //rpt.Run();
                        //rpt.Document.Print(true, true, true);
                        StimulViewer frm = new StimulViewer(_TrafficEntity, true, false);
                        frm.ShowDialog();
                    }
                }
                else if (TrafficType == 2)
                {
                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(_TrafficEntity, true, true);
                    frm.ShowDialog();

                    //HPS.Reports.ReportDoc.ForeignCarsReport rpt = new HPS.Reports.ReportDoc.ForeignCarsReport(_TrafficEntity);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //rpt.Run();
                    //rpt.Document.Print(true, true, true);


                }
                else
                {
                    HPS.Reports.Forms.StimulViewer frm = new Reports.Forms.StimulViewer(_TrafficEntity, false, true);
                    frm.ShowDialog();
                    //HPS.Reports.ReportDoc.OtherCarReport rpt = new HPS.Reports.ReportDoc.OtherCarReport(_TrafficEntity);
                    //rpt.Document.Printer.PrinterName = string.Empty;
                    //rpt.Run();
                    //rpt.Document.Print(true, true, true);
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }



        }

        private void LoadIranianTraffic()
        {
            string TrafficCondition = "([T].[TrafficTypeID_int]=1) AND (T.Date_nvc='" + TrafficFactory.ServerJalaliDate + "')";
            DataTable CarTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
            TrafficGridView.DataSource = CarTrafficDatatable;
            ColorizePlate();

        }

        private void ColorizePlate()
        {
            foreach (DataGridViewRow row in TrafficGridView.Rows)
            {
                if ((row.Cells["colCameraPlateNumber_nvc"].Value!=null && row.Cells["colCameraSerialPlate_int"].Value!=null) && !(row.Cells["colNumberPlate_nvc"].Value.ToString() == row.Cells["colCameraPlateNumber_nvc"].Value.ToString() && row.Cells["colSerialPlate_nvc"].Value.ToString() == row.Cells["colCameraSerialPlate_int"].Value.ToString()))
                {
                    
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 177, 176, 246);
                }
            }
        }

        private void LoadForeignTraffic()
        {
            string TrafficCondition = "([T].[TrafficTypeID_int]=2) AND (T.Date_nvc='" + TrafficFactory.ServerJalaliDate + "') ";
            DataTable CarTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
            TrafficGridView.DataSource = CarTrafficDatatable;
            ColorizePlate();
        }

        private void LoadOtherTraffic()
        {
            string TrafficCondition = "([T].[TrafficTypeID_int]<>1) AND ([T].[TrafficTypeID_int]<>2) AND (T.Date_nvc='" + TrafficFactory.ServerJalaliDate + "')";
            DataTable CarTrafficDatatable = new DataTable();
            TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
            TrafficGridView.DataSource = CarTrafficDatatable;
            ColorizePlate();
        }

        private void TrafficGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void InNotOutStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                InNotOut = true;
                ClearTextBoxes();
                if (TrafficType == 1)
                {

                    string TrafficCondition = "([T1].[TrafficTypeID_int]=1) AND T1.Date_nvc='" + TrafficFactory.ServerJalaliDate + "'";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                }
                else if (TrafficType == 2)
                {
                    string TrafficCondition = "([T1].[TrafficTypeID_int]=2) AND T1.Date_nvc='" + TrafficFactory.ServerJalaliDate + "'";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                }
                else
                {
                    string TrafficCondition = "([T1].[TrafficTypeID_int]<>1) AND ([T1].[TrafficTypeID_int]<>2) AND T1.Date_nvc='" + TrafficFactory.ServerJalaliDate + "'";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void EditStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrafficGridView.CurrentRow == null)
                {
                    return;
                }
                HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory LadBillCreditFactory = new HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_TFactory();
                HPS.BLL.TrafficBLL.BLLTraffic_TKeys TrafficKey = new HPS.BLL.TrafficBLL.BLLTraffic_TKeys();
                TrafficKey.TrafficID_bint = (Int64)TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value;
                //List<HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T> LadBillCreditList = LadBillCreditFactory.GetAllBy(HPS.BLL.LadBillCreditBLL.BLLLadBillCredit_T.LadBillCredit_TField.TrafficID_bint, TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value);
                if ((int)TrafficGridView.CurrentRow.Cells[colLadBillCredit.Name].Value == 1 && (int)TrafficGridView.CurrentRow.Cells[LadBillCanceled.Name].Value == 0)
                {
                    //pep
                    if (HPS.Common.CurrentUser.user.UserGroupID_int != 1)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("این راننده و ناوگان مجوز گرفته است");
                    }
                }
                if (TrafficGridView.CurrentRow != null)
                {
                    if (TrafficGridView.DataSource.GetType().Name == "DataView")
                    {
                        TrafficGridView.DataSource = (DataTable)((DataView)TrafficGridView.DataSource).ToTable();
                        ColorizePlate();
                    }
                    if (TrafficType == 1)
                    {
                        HPS.Present.Traffic.IranianCarsForm frm = new HPS.Present.Traffic.IranianCarsForm(Hepsa.Core.PL.BaseEntityForm1.enmState.Edit, (DataTable)TrafficGridView.DataSource, TrafficKey);
                        frm.ShowDialog();
                    }
                    else if (TrafficType == 2)
                    {
                        HPS.Present.Traffic.ForeignCarsForm frm = new HPS.Present.Traffic.ForeignCarsForm(Hepsa.Core.PL.BaseEntityForm1.enmState.Edit, (DataTable)TrafficGridView.DataSource, TrafficKey);
                        frm.ShowDialog();
                    }
                    else
                    {
                        HPS.Present.Traffic.OtherCarsForm frm = new HPS.Present.Traffic.OtherCarsForm(Hepsa.Core.PL.BaseEntityForm1.enmState.Edit, (DataTable)TrafficGridView.DataSource, TrafficKey);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }


        }

        private void AllTrafficStripButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            InNotOut = false;
            if (TrafficType == 1)
            {
                try
                {
                    string TrafficCondition = "([T].[TrafficTypeID_int]=1)";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                    this.Text = "ورود و خروج كاميون هاي ايراني";
                    this.TrafficGridView.Focus();
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                    this.Close();
                }
            }
            else if (TrafficType == 2)
            {
                try
                {
                    string TrafficCondition = "([T].[TrafficTypeID_int]=2) ";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                    this.Text = "ورود و خروج كاميون هاي خارجی";
                    this.TrafficGridView.Focus();
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                    this.Close();
                }
            }
            else
            {
                try
                {
                    
                    string TrafficCondition = "([T].[TrafficTypeID_int]<>1) AND ([T].[TrafficTypeID_int]<>2) ";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                    this.Text = "ورود و خروج سواری و سایر خودروها";
                    this.TrafficGridView.Focus();
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                    this.Close();
                }
            }
        }

        private void AllInStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                InNotOut = true;
                ClearTextBoxes();
                if (TrafficType == 1)
                {
                    
                    string TrafficCondition = "([T1].[TrafficTypeID_int]=1) ";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizeInNotOut();
                }
                else if (TrafficType == 2)
                {
                    
                    string TrafficCondition = "([T1].[TrafficTypeID_int]=2)";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizeInNotOut();
                }
                else
                {
                    
                    string TrafficCondition = "([T1].[TrafficTypeID_int]<>1) AND ([T1].[TrafficTypeID_int]<>2) ";
                    DataTable CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllInTrafficNotTemporaryOut(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizeInNotOut();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
        private void ColorizeInNotOut()
        {
            foreach (DataGridViewRow row in TrafficGridView.Rows)
            {
                if (Convert.ToUInt32(row.Cells["Duration"].Value) >= 31 && Convert.ToInt32(row.Cells["Duration"].Value) <= 60)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToUInt32(row.Cells["Duration"].Value) > 60)
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                }
            }
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            LoadAllTraffic();
        }

        private void TrafficNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void AcceptedTurnNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SerialPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
   
        }

        private void Search()
        {
            try
            {
                TrafficGridView.DataSource = null;

                if (TrafficType == 1)
                {
                    
                    string TrafficCondition = string.Empty;
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=1) AND TrafficNumber_bint={0} ", Int64.Parse(TrafficNumberTextBox.Text));
                    }
                    else if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=1) AND AcceptedTurnNumber_bint={0} ", Int64.Parse(AcceptedTurnNumberTextBox.Text));
                    }
                    else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=1) AND NumberPlate_nvc='{0}' AND SerialPlate_nvc='{1}'", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                    }
                    if (!(FromDatefaDatePicker.IsNull) && !(ToDatefaDatePicker.IsNull))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=1) AND Date_nvc>='{0}' AND Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                    }
                    if (!string.IsNullOrEmpty(lastNameTextBox.Text))
                    {
                        TrafficCondition = string.Format(" ([TrafficTypeID_int]=1) AND LastName_nvc LIKE '%{0}%'", lastNameTextBox.Text);
                    }
                    if (!string.IsNullOrEmpty(carCardNumberTextBox.Text))
                    {
                        TrafficCondition = string.Format(" ([TrafficTypeID_int]=1) AND CarCardNumber_nvc='{0}'", carCardNumberTextBox.Text);
                    }
                    if (!string.IsNullOrEmpty(driverNationalCodeTextBox.Text))
                    {
                        TrafficCondition = string.Format(" ([TrafficTypeID_int]=1) AND NationalCode_int='{0}'", driverNationalCodeTextBox.Text);
                    }

                    CarTrafficDatatable = new DataTable();
                    TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                    this.TrafficGridView.Focus();
                }
                else if (TrafficType == 2)
                {
                    
                    string TrafficCondition = string.Empty;
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=2) AND TrafficNumber_bint={0} ", Int64.Parse(TrafficNumberTextBox.Text));
                    }
                    else if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=2) AND AcceptedTurnNumber_bint={0} ", Int64.Parse(AcceptedTurnNumberTextBox.Text));
                    }
                    else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=2) AND NumberPlate_nvc='{0}' AND SerialPlate_nvc='{1}'", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                    }
                    if (!FromDatefaDatePicker.IsNull && !ToDatefaDatePicker.IsNull)
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]=2) AND Date_nvc>='{0}' AND Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                    }
                    CarTrafficDatatable = new DataTable();
                    //TrafficFactory.SelectByConditionSelectionTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficFactory.GetAllByConditionAllTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                    this.TrafficGridView.Focus();
                }
                else
                {
                    
                    string TrafficCondition = string.Empty;
                    if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]<>1) AND ([TrafficTypeID_int]<>2) AND TrafficNumber_bint={0} ", Int64.Parse(TrafficNumberTextBox.Text));
                    }
                    //else if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                    //{
                    //    TrafficCondition = string.Format("([TrafficTypeID_int]<>1) AND ([TrafficTypeID_int]<>2) AND AcceptedTurnNumber_bint={0} AND AcceptedTurnNumber_bint={0} ", Int64.Parse(AcceptedTurnNumberTextBox.Text));
                    //}
                    else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]<>1) AND ([TrafficTypeID_int]<>2) AND NumberPlate_nvc='{0}' AND SerialPlate_nvc='{1}'", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                    }
                    if (!FromDatefaDatePicker.IsNull && !ToDatefaDatePicker.IsNull)
                    {
                        TrafficCondition = string.Format("([TrafficTypeID_int]<>1) AND ([TrafficTypeID_int]<>2) AND Traffic_T.Date_nvc>='{0}' AND Traffic_T.Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                    }
                    if (!string.IsNullOrEmpty(lastNameTextBox.Text))
                    {
                        TrafficCondition = string.Format(" ([TrafficTypeID_int]<>1) AND ([TrafficTypeID_int]<>2) AND LastName_nvc LIKE '%{0}%'", lastNameTextBox.Text);
                    }
                    CarTrafficDatatable = new DataTable();
                    TrafficFactory.SelectByConditionSelectionTraffic(TrafficCondition, ref CarTrafficDatatable);
                    TrafficGridView.DataSource = CarTrafficDatatable;
                    ColorizePlate();
                    this.TrafficGridView.Focus();
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

        private void AllCurrentTrafficButton_Click(object sender, EventArgs e)
        {
            InNotOut = false;
            ClearTextBoxes();
            LoadAllTraffic();
        }

        private void ToDatefaDatePicker_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (FromDatefaDatePicker.IsNull)
                    {
                        throw new ApplicationException("از تاریخ خالی است");
                    }
                    else if (ToDatefaDatePicker.IsNull)
                    {
                        throw new ApplicationException("تا تاریخ خالی است");
                    }

                    Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                    if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                        throw new ApplicationException(FromDateValidator.Description);

                    Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                    if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                        throw new ApplicationException(ToDateValidator.Description);

                    TrafficNumberTextBox.Text = string.Empty;
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    lastNameTextBox.Text = string.Empty;
                    driverNationalCodeTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;

                    Search();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void FromDatefaDatePicker_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);

        }

        private void ToDatefaDatePicker_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
        }

        bool isChecked = false;
        private void TrueradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TrueradioButton.Checked)
            {
                isChecked = TrueradioButton.Checked;

                if (TrafficGridView.DataSource != null)
                {
                    DataView dv = null;
                    if (TrafficGridView.DataSource.GetType().Name == "DataView")
                    {
                        dv = ((DataView)TrafficGridView.DataSource).ToTable().DefaultView;
                    }
                    else
                    {
                        dv = ((DataTable)TrafficGridView.DataSource).DefaultView;
                    }

                    if (BooleanComboBox.SelectedValue == "TurnAccepted")
                    {
                        dv.RowFilter = "TurnAccepted_bit=True";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "LadBillCredit")
                    {
                        dv.RowFilter = "LadBillCredit=True";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "CancelTurn")
                    {
                        dv.RowFilter = "TurnCanceled=True";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "CancelLadBillCredit")
                    {
                        dv.RowFilter = "LadBillCanceled=True";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "ReturnTurn")
                    {
                        dv.RowFilter = "TurnReturned=True";
                        TrafficGridView.DataSource = dv;
                    }
                    ColorizePlate();

                }
            }
        }
        bool FalseIsChecked = false;

        private void FalseradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FalseradioButton.Checked)
            {
                FalseIsChecked = FalseradioButton.Checked;

                if (TrafficGridView.DataSource != null)
                {
                    DataView dv = null;
                    if (TrafficGridView.DataSource.GetType().Name == "DataView")
                    {
                        dv = ((DataView)TrafficGridView.DataSource).ToTable().DefaultView;
                    }
                    else
                    {
                        dv = ((DataTable)TrafficGridView.DataSource).DefaultView;
                    }

                    if (BooleanComboBox.SelectedValue == "TurnAccepted")
                    {
                        dv.RowFilter = "TurnAccepted_bit=False";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "LadBillCredit")
                    {
                        dv.RowFilter = "LadBillCredit=False";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "CancelTurn")
                    {
                        dv.RowFilter = "TurnCanceled=False";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "CancelLadBillCredit")
                    {
                        dv.RowFilter = "LadBillCanceled=False";
                        TrafficGridView.DataSource = dv;
                    }

                    else if (BooleanComboBox.SelectedValue == "ReturnTurn")
                    {
                        dv.RowFilter = "TurnReturned=False";
                        TrafficGridView.DataSource = dv;
                    }
                    ColorizePlate();
                }
            }
        }

        private void BooleanComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            TrueradioButton.Checked = false;
            FalseradioButton.Checked = false;
        }


        private void DriverSpecificationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrafficGridView.CurrentRow != null)
                {
                    if (TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value != null && !string.IsNullOrEmpty(TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value.ToString()))
                    {
                        HPS.Present.DriverSpecification.DriverSpecificationEntityForm frm = new HPS.Present.DriverSpecification.DriverSpecificationEntityForm(TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value.ToString(), true);
                        frm.ShowDialog();
                    }
                    else if (TrafficGridView.CurrentRow.Cells[colFirstName_nvc.Name].Value != null && TrafficGridView.CurrentRow.Cells[colLastName_nvc.Name].Value != null && TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value != null && !string.IsNullOrEmpty(TrafficGridView.CurrentRow.Cells[colFirstName_nvc.Name].Value.ToString()) && !string.IsNullOrEmpty(TrafficGridView.CurrentRow.Cells[colLastName_nvc.Name].Value.ToString()) && !string.IsNullOrEmpty(TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value.ToString()))
                    {
                        HPS.Present.DriverSpecification.DriverSpecificationEntityForm frm = new HPS.Present.DriverSpecification.DriverSpecificationEntityForm(TrafficGridView.CurrentRow.Cells[colFirstName_nvc.Name].Value.ToString(), TrafficGridView.CurrentRow.Cells[colLastName_nvc.Name].Value.ToString(), Convert.ToInt64(TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value.ToString()));
                        frm.ShowDialog();
                    }
                }
                else
                    throw new ApplicationException("اطلاعات راننده خالی است");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CarSpecificationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TrafficGridView.CurrentRow != null)
                {
                    if (TrafficGridView.CurrentRow.Cells[colCarCardNumber_nvc.Name].Value != null && !string.IsNullOrEmpty(TrafficGridView.CurrentRow.Cells[colCarCardNumber_nvc.Name].Value.ToString()))
                    {
                        HPS.Present.DriverSpecification.DriverSpecificationEntityForm frm = new HPS.Present.DriverSpecification.DriverSpecificationEntityForm(TrafficGridView.CurrentRow.Cells[colCarCardNumber_nvc.Name].Value.ToString(), false);
                        frm.ShowDialog();
                    }
                }
                else
                    throw new ApplicationException("اطلاعات ناوگان خالی است");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                InNotOut = false;
                if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                {
                    Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumberRule", "شماره قبض", 1, null, null, 0);
                    if (NumericValidator.Validate(TrafficNumberTextBox.Text) == false)
                    {
                        throw new ApplicationException(NumericValidator.Description);
                    }
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    lastNameTextBox.Text = string.Empty;
                    driverNationalCodeTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;
                    Search();
                }
                else if (!string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text))
                {
                    Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("AcceptedTurnNumberRule", "شماره نوبت تأیید شده", 1, null, null, 0);
                    if (NumericValidator.Validate(AcceptedTurnNumberTextBox.Text) == false)
                    {
                        throw new ApplicationException(NumericValidator.Description);
                    }
                    TrafficNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    lastNameTextBox.Text = string.Empty;
                    driverNationalCodeTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;

                    Search();
                }
                else if (!string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
                {
                    TrafficNumberTextBox.Text = string.Empty;
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    lastNameTextBox.Text = string.Empty;
                    driverNationalCodeTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;

                    Search();
                }
                else if (!string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    driverNationalCodeTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;

                    Search();
                }
                else if (!string.IsNullOrEmpty(driverNationalCodeTextBox.Text))
                {
                    Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumberRule", "شماره کارت ناوگان", 1, null, null, 0);
                    if (NumericValidator.Validate(driverNationalCodeTextBox.Text) == false)
                    {
                        throw new ApplicationException(NumericValidator.Description);
                    }
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    lastNameTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;

                    Search();
                }
                else if (!string.IsNullOrEmpty(carCardNumberTextBox.Text))
                {
                    Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumberRule", "شماره کارت ناوگان", 1, null, null, 0);
                    if (NumericValidator.Validate(carCardNumberTextBox.Text) == false)
                    {
                        throw new ApplicationException(NumericValidator.Description);
                    }
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    FromDatefaDatePicker.ResetSelectedDateTime();
                    ToDatefaDatePicker.ResetSelectedDateTime();
                    lastNameTextBox.Text = string.Empty;
                    driverNationalCodeTextBox.Text = string.Empty;

                    Search();
                }
                else
                {

                    if (FromDatefaDatePicker.IsNull)
                    {
                        throw new ApplicationException("از تاریخ خالی است");
                    }
                    else if (ToDatefaDatePicker.IsNull)
                    {
                        throw new ApplicationException("تا تاریخ خالی است");
                    }

                    Hepsa.Core.Validation.DateRule<string> FromDateValidator = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                    if (FromDateValidator.Validate(FromDatefaDatePicker.Text) == false)
                        throw new ApplicationException(FromDateValidator.Description);

                    Hepsa.Core.Validation.DateRule<string> ToDateValidator = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                    if (ToDateValidator.Validate(ToDatefaDatePicker.Text) == false)
                        throw new ApplicationException(ToDateValidator.Description);

                    TrafficNumberTextBox.Text = string.Empty;
                    AcceptedTurnNumberTextBox.Text = string.Empty;
                    NumberPlate_nvcTextBox.Text = string.Empty;
                    SerialPlate_nvcTextBox.Text = string.Empty;
                    lastNameTextBox.Text = string.Empty;
                    driverNationalCodeTextBox.Text = string.Empty;
                    carCardNumberTextBox.Text = string.Empty;

                    Search();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void InTrafficPictureShowButton_Click(object sender, EventArgs e)
        {
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory TrafficPicturesFactory = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TFactory();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_T TrafficPicturesEntity = new BLL.TrafficPicturesBLL.BLLTrafficPictures_T();
            BLL.TrafficPicturesBLL.BLLTrafficPictures_TKeys TrafficPicturesKey = new BLL.TrafficPicturesBLL.BLLTrafficPictures_TKeys();
            TrafficPicturesKey.TrafficID_bint = Convert.ToInt64(TrafficGridView.CurrentRow.Cells[colTrafficID_bint.Name].Value);
            TrafficPicturesEntity = TrafficPicturesFactory.GetBy(TrafficPicturesKey);

            if (TrafficPicturesEntity != null && TrafficPicturesEntity.Picture_vbnry != null)
            {
                System.IO.MemoryStream pictureMemoryStream = new System.IO.MemoryStream();
                pictureMemoryStream.Write(TrafficPicturesEntity.Picture_vbnry, 0, TrafficPicturesEntity.Picture_vbnry.Length);
                //pictureBox.Image = System.Drawing.Image.FromStream(pictureMemoryStream);

                HPS.Reports.Forms.TrafficPicturesFullScreanForm frm = new HPS.Reports.Forms.TrafficPicturesFullScreanForm(pictureMemoryStream);
                frm.ShowDialog();
            }
        }

        private void TrafficGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string PrintingFilter()
        {
            string Condition = "[TrafficTypeID_int]=1";

            if (!(FromDatefaDatePicker.IsNull) && !(ToDatefaDatePicker.IsNull))
            {
                Condition = string.Format("{0} and " + " Date_nvc>='{1}' AND Date_nvc<='{2}'", Condition, FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
            }
            if (!(string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text)) && !(string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text)))
            {
                Condition = string.Format("{0} and " + " NumberPlate_nvc='{1}' AND SerialPlate_nvc='{2}'", Condition, NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
            }
            if (!(string.IsNullOrEmpty(TrafficNumberTextBox.Text)))
            {
                Condition = string.Format("{0} and" + " TrafficNumber_bint={1}", Condition, TrafficNumberTextBox.Text);
            }
            if (!(string.IsNullOrEmpty(AcceptedTurnNumberTextBox.Text)))
            {
                Condition = string.Format("{0} and" + " AcceptedTurnNumber_bint={1}", Condition, AcceptedTurnNumberTextBox.Text);

            }
            if (!(string.IsNullOrEmpty(driverNationalCodeTextBox.Text)))
            {
                Condition = string.Format("{0} and" + " NationalCode_int={1}", Condition, driverNationalCodeTextBox.Text);

            }
            if (!(string.IsNullOrEmpty(carCardNumberTextBox.Text)))
            {
                Condition = string.Format("{0} and" + " CarCardNumber_nvc={1}", Condition, carCardNumberTextBox.Text);

            }
            if (!(string.IsNullOrEmpty(lastNameTextBox.Text)))
            {
                Condition = string.Format("{0} and" + " LastName_nvc={1}", Condition, lastNameTextBox.Text);
            }
            if (TrueradioButton.Checked == true || FalseradioButton.Checked == true)
            {
                Condition = string.Format("{0} and {1}", Condition, IsChecked());
            }



            return Condition;
        }
        private string IsChecked()
        {

            string condition = "";
            if (TrueradioButton.Checked == true)
            {
                if (BooleanComboBox.SelectedValue == "TurnAccepted")
                {
                    condition = "TurnAccepted_bit=True";

                }

                else if (BooleanComboBox.SelectedValue == "LadBillCredit")
                {
                    condition = "LadBillCredit=True";

                }

                else if (BooleanComboBox.SelectedValue == "CancelTurn")
                {
                    condition = "TurnCanceled=True";

                }

                else if (BooleanComboBox.SelectedValue == "CancelLadBillCredit")
                {
                    condition = "LadBillCanceled=True";

                }

                else if (BooleanComboBox.SelectedValue == "ReturnTurn")
                {
                    condition = "TurnReturned=True";

                }
            }
            else if (FalseradioButton.Checked == true)
            {
                if (BooleanComboBox.SelectedValue == "TurnAccepted")
                {
                    condition = "TurnAccepted_bit=false";

                }

                else if (BooleanComboBox.SelectedValue == "LadBillCredit")
                {
                    condition = "LadBillCredit=false";

                }

                else if (BooleanComboBox.SelectedValue == "CancelTurn")
                {
                    condition = "TurnCanceled=false";

                }

                else if (BooleanComboBox.SelectedValue == "CancelLadBillCredit")
                {
                    condition = "LadBillCanceled=false";

                }

                else if (BooleanComboBox.SelectedValue == "ReturnTurn")
                {
                    condition = "TurnReturned=false";

                }
            }
            return condition;
        }

        private void PrintTrafficButton_Click(object sender, EventArgs e)
        {

            try
            {
                StimulViewer rpt = new StimulViewer(AllTrafficstiReport);


                string TrafficCondition = string.Empty;
                if (!(FromDatefaDatePicker.IsNull) && !(ToDatefaDatePicker.IsNull))
                {
                    TrafficCondition = string.Format("([TrafficTypeID_int]=1) AND Date_nvc>='{0}' AND Date_nvc<='{1}'", FromDatefaDatePicker.Text, ToDatefaDatePicker.Text);
                }
                else if (!(string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text)) && !(string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text)))
                {
                    TrafficCondition = string.Format("([TrafficTypeID_int]=1) AND NumberPlate_nvc='{0}' AND SerialPlate_nvc='{1}'", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                }

                AllTrafficstiReport.Dictionary.Synchronize();
                AllTrafficstiReport.Dictionary.Databases.Clear();
                AllTrafficstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
                AllTrafficstiReport.Compile();
                AllTrafficstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
                HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
                if (FromDatefaDatePicker.IsNull)
                {
                    AllTrafficstiReport["fromDate_nvc"] = "";
                }
                else
                {
                    AllTrafficstiReport["fromDate_nvc"] = FromDatefaDatePicker.Text;
                }
                if (ToDatefaDatePicker.IsNull)
                {
                    AllTrafficstiReport["toDate_nvc"] = "";
                }
                else
                {
                    AllTrafficstiReport["toDate_nvc"] = ToDatefaDatePicker.Text;
                }
                AllTrafficstiReport["date_nvc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime;
                AllTrafficstiReport["userName_nvc"] = HPS.Common.CurrentUser.user.UserName_nvc;
                AllTrafficstiReport["@Condition"] = PrintingFilter();
                AllTrafficstiReport.Render();
                AllTrafficstiReport.Show();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void TrafficGridView_Sorted(object sender, EventArgs e)
        {
            if (InNotOut)
            {
                ColorizeInNotOut();
               
            }
            else
            ColorizePlate();
        }

        private void AllTrafficForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F3)
            {
                ShowButton.PerformClick();
            }
        }

        private void ToDatefaDatePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            TrafficNumberTextBox.Text = string.Empty;
            AcceptedTurnNumberTextBox.Text = string.Empty;
            NumberPlate_nvcTextBox.Text = string.Empty;
            SerialPlate_nvcTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            driverNationalCodeTextBox.Text = string.Empty;
            carCardNumberTextBox.Text = string.Empty;
        }

        private void FromDatefaDatePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            TrafficNumberTextBox.Text = string.Empty;
            AcceptedTurnNumberTextBox.Text = string.Empty;
            NumberPlate_nvcTextBox.Text = string.Empty;
            SerialPlate_nvcTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            driverNationalCodeTextBox.Text = string.Empty;
            carCardNumberTextBox.Text = string.Empty;
        }
    }
}
