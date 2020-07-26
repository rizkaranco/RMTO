using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.TurnManagement
{
    public partial class TrafficWithoutTurnAllowadedForm : Hepsa.Core.PL.BaseListForm
    {
        HPS.BLL.TrafficBLL.BLLTraffic_T TrafficEntity = new HPS.BLL.TrafficBLL.BLLTraffic_T();
       
        HPS.Main mainfrm = new HPS.Main();

        public TrafficWithoutTurnAllowadedForm()
        {
            InitializeComponent();
         
            this.TrafficGridView.AutoGenerateColumns = false;

            Hepsa.Core.PL.BaseListForm.Group TrafficGroup = new Hepsa.Core.PL.BaseListForm.Group();
            TrafficGroup.set_Grid(true, false, true, this.TrafficGridView);
            TrafficGroup.ToolStrip = this.AllTrafficToolStrip;
            TrafficGroup.RefreshButton = this.RefreshButton;
            TrafficGroup.HasFilterControl = true;

            this.Groups.Add(TrafficGroup);

           
                try
                {
                    this.TrafficGridView.Focus();
                }
                catch (Exception ex)
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                    this.Close();
                }  
        }

        private void AllTrafficForm_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadAllTraffic()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string Condition = "[T1].[TrafficTypeID_int]=1 AND T1.Date_nvc='" + TrafficFactory.ServerJalaliDate + "'";
            DataTable TrafficDataTable = new DataTable();
            TrafficFactory.GetAllByConditionAllInTrafficForTurnAcception(Condition, ref TrafficDataTable);
            this.TrafficGridView.DataSource = TrafficDataTable;
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TurnallowdedButton_Click(object sender, EventArgs e)   
        {
             try
            {
                if (this.TrafficGridView.CurrentRow == null)
                    throw new ApplicationException(HPS.Exceptions.ExceptionCs.TrafficNotSelected);

                string title_nvc = TrafficGridView.CurrentRow.Cells[colLaderType_nvc.Name].Value.ToString();
                if (title_nvc.Contains("بونكر") || title_nvc.Contains("تانكر") || title_nvc.Contains("كمپرسي"))
                {
                    throw new ApplicationException("امکان نوبت دهی برای " + title_nvc + " وجود ندارد");
                }

                if ((bool)TrafficGridView.CurrentRow.Cells[colWithLade_bit.Name].Value == true)
                {
                    throw new ApplicationException("امکان نوبت دهی برای کامیون های با بار وجود ندارد");
                }
                Int64? TrafficID = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(this.TrafficGridView.CurrentRow.Cells["colTrafficID_bint"].Value, TypeCode.Int64);
                
                if (!TrafficID.HasValue)
                    throw new HPS.Exceptions.TrafficNotFound();

                Int32? CarID = null;
                Int64? DriverID = null;
                string FirstName = string.Empty;
                string LastName = string.Empty;
                Int64? NationaCode = null;
                string NumberPlate = string.Empty;
                string SerialPlate = string.Empty;
                string PlateCityCode = string.Empty;

                if (TrafficGridView.CurrentRow != null)
                {
                    if (TrafficGridView.CurrentRow.Cells[colCarID_int.Name].Value != null)
                    {
                        CarID = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colCarID_int.Name].Value, TypeCode.Int32);
                    }
                    if (TrafficGridView.CurrentRow.Cells[colDriverID_bint.Name].Value != null)
                    {
                        DriverID = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colDriverID_bint.Name].Value, TypeCode.Int64);
                    }
                    FirstName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colFirstName_nvc.Name].Value, TypeCode.String));
                    LastName = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colLastName_nvc.Name].Value, TypeCode.String));
                    NationaCode = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colNationalCode_int.Name].Value, TypeCode.Int64);
                    NumberPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colNumberPlate_nvc.Name].Value, TypeCode.String));
                    SerialPlate = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(TrafficGridView.CurrentRow.Cells[colSerialPlate_nvc.Name].Value, TypeCode.String));


                    HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
                    string InfractionCondition = string.Format("[Infraction_T].NumberPlate_nvc='{0}'  AND Infraction_T.SerialPlate_nvc='{1}' AND ([Infraction_T].[SolverUserName_nvc] IS NULL) AND ([Infraction_T].[SolveDate_nvc] IS NULL) AND ([Infraction_T].[SolveTime_nvc] IS NULL)", NumberPlate, SerialPlate);
                    List<HPS.BLL.InfractionBLL.BLLInfraction_T> InfractionList = InfractionFactory.GetAllByCondition(InfractionCondition);
                    if (InfractionList != null && InfractionList.Count > 0 && InfractionList[0].TurnAccept_bit )
                    {
                        throw new ApplicationException("ناوگان متخلف است" + "(" + InfractionList[0].CommentControl_nvc + ")");
                    }
                    HPS.Present.TurnManagement.TurnAcceptionForm frm = new TurnAcceptionForm(TrafficID.Value, (DataTable)this.TrafficGridView.DataSource);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void AllTurntoolStripButton_Click(object sender, EventArgs e)
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            string Condition = "[T1].[TrafficTypeID_int]=1 ";
            DataTable TrafficDataTable = new DataTable();
            TrafficFactory.GetAllByConditionAllInTrafficForTurnAcception(Condition, ref TrafficDataTable);
            this.TrafficGridView.DataSource = TrafficDataTable;
        }

        private void TrafficWithoutTurnAllowadedForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Insert)
            {
                if (TurnallowdedButton.Visible)
                {
                    TurnallowdedButton.PerformClick(); 
                }
            }
            else if (e.Shift && e.KeyCode == Keys.A)
            {
                if (AllTurntoolStripButton.Visible)
                {
                    AllTurntoolStripButton.PerformClick(); 
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAllTraffic();
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
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TrafficNumberRule", "شماره قبض", 1, null, null, 0);
                        if (NumericValidator.Validate(TrafficNumberTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        TurnNumberTextBox.Text = string.Empty;
                        NumberPlate_nvcTextBox.Text = string.Empty;
                        SerialPlate_nvcTextBox.Text = string.Empty;
                        FromDate_nvcTextBox.Text = string.Empty;
                        ToDate_nvcTextBox.Text = string.Empty;
                        Search();
                        TrafficNumberTextBox.Focus();
                        this.RaiseKeyDownEvent = false;
                        TrafficNumberTextBox.SelectAll();
                    }
                    else
                    {
                        this.TrafficGridView.DataSource = null;
                        TrafficNumberTextBox.Focus();
                        this.RaiseKeyDownEvent = false;
                        TrafficNumberTextBox.SelectAll();
                    }

                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                TrafficNumberTextBox.Focus();
                this.RaiseKeyDownEvent = false;
                TrafficNumberTextBox.SelectAll();
            }


        }

        private void Search()
        {
            try
            {
                TrafficGridView.DataSource = null;
               
                DataTable TrafficDataTable = new DataTable();
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition=string.Empty;
                if (!string.IsNullOrEmpty(TrafficNumberTextBox.Text))
                {
                    Condition = string.Format("[T1].[TrafficTypeID_int]=1  AND T1.TrafficNumber_bint={0} ", TrafficNumberTextBox.Text);
                }
                else if (!string.IsNullOrEmpty(TurnNumberTextBox.Text))
                {
                    Condition = string.Format("[T1].[TrafficTypeID_int]=1  AND T1.TurnNumber_bint={0} ", TurnNumberTextBox.Text);
                }
                else if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                {
                    Condition = string.Format("[T1].[TrafficTypeID_int]=1  AND T1.NumberPlate_nvc='{0}' AND T1.SerialPlate_nvc='{1}' ", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text);
                }
                else
                {
                    Condition = string.Format("[T1].[TrafficTypeID_int]=1  AND T1.Date_nvc>='{0}' AND T1.Date_nvc<='{1}' ", FromDate_nvcTextBox.Text, ToDate_nvcTextBox.Text);
                }


                TrafficFactory.GetAllByConditionAllInTrafficForTurnAcception(Condition, ref TrafficDataTable);
                if (TrafficDataTable.Rows.Count > 0)
                {
                    this.TrafficGridView.DataSource = TrafficDataTable;
                }
                else
                {
                    this.TrafficGridView.DataSource = null;
                }
                if (TrafficDataTable.Rows.Count < 1)
                {
                    throw new ApplicationException("ناوگان مورد نظر یافت نشد");
                }

            }
            catch (System.Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void TurnNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrEmpty(TurnNumberTextBox.Text))
                    {
                        Hepsa.Core.Validation.NumericRule<Int64> NumericValidator = new Hepsa.Core.Validation.NumericRule<Int64>("TurnNumberRule", "شماره نوبت", 1, null, null, 0);
                        if (NumericValidator.Validate(TurnNumberTextBox.Text) == false)
                        {
                            throw new ApplicationException(NumericValidator.Description);
                        }
                        TrafficNumberTextBox.Text = string.Empty;
                        NumberPlate_nvcTextBox.Text = string.Empty;
                        SerialPlate_nvcTextBox.Text = string.Empty;
                        FromDate_nvcTextBox.Text = string.Empty;
                        ToDate_nvcTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        this.TrafficGridView.DataSource = null;
                    }

                }
            }
            catch ( Exception ex)
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
                    if (!string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) && !string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text))
                    {
                        TrafficNumberTextBox.Text = string.Empty;
                        TurnNumberTextBox.Text = string.Empty;
                        FromDate_nvcTextBox.Text = string.Empty;
                        ToDate_nvcTextBox.Text = string.Empty;
                        Search();
                    }
                    else
                    {
                        throw new ApplicationException("شماره پلاک خالی است");
                    }

                }
            }
            catch (Exception ex)
            {

                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CurrentTurnNotAcceptedStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadAllTraffic();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void ToDate_nvcTextBox_Click(object sender, EventArgs e)
        {
            MaskedTextBoxSetFocus(sender, e);
        }

        private void MaskedTextBoxSetFocus(object sender, EventArgs e)
        {
            var mtb = (MaskedTextBox)sender;
            mtb.Focus();
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
                    Hepsa.Core.Validation.DateRule<string> FromDateRule = new Hepsa.Core.Validation.DateRule<string>("FromDate", "از تاریخ", null, null);
                    if (FromDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(FromDate_nvcTextBox))==false)
                    {
                        throw new ApplicationException("از تاریخ صحیح نیست");
                    }
                    Hepsa.Core.Validation.DateRule<string> ToDateRule = new Hepsa.Core.Validation.DateRule<string>("ToDate", "تا تاریخ", null, null);
                    if (ToDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ToDate_nvcTextBox)) == false)
                    {
                        throw new ApplicationException("تا تاریخ صحیح نیست");
                    }
                    TrafficNumberTextBox.Text = string.Empty;
                    TurnNumberTextBox.Text = string.Empty;
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





    }
}
