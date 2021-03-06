using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Infraction
{
    public partial class InfractionEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public InfractionEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public InfractionEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.InfractionBLL.BLLInfraction_TKeys Key, bool Registered)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
            this._Registered = Registered;
        }



        List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList;
        List<HPS.BLL.CarBLL.BLLCar_T> CarList;
        HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();
        private bool _Registered = false;
        private bool _Solved = false;
        private void InfractionEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                {
                    this.FillCombo();
                }
                if (_Registered == true && _Solved==false)
                {
                    SolveComment_nvcTextBox.Enabled = true;
                }
                else if( this.State == enmFormState.Edit)
                {
                    this.State = enmFormState.View;
                    this.InfractionTypeNewButton.Enabled = false;
                    //SolveComment_nvcTextBox.Enabled = false;
                    //RegiaterComment_nvcTextBox.Enabled = false;
                    //DrivergroupBox.Enabled = false;
                    //CargroupBox.Enabled = false;
                    //CompanygroupBox.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void ShowForm()
        {
            this.FillCombo();
            HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
            HPS.BLL.InfractionBLL.BLLInfraction_T InfractionEntity = InfractionFactory.GetBy((HPS.BLL.InfractionBLL.BLLInfraction_TKeys)Key);
            if (InfractionEntity == null)
            {
                throw new HPS.Exceptions.InfractionNotFound();
            }
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionTypeID_intComboBox, InfractionEntity.InfractionTypeID_int, TypeCode.Int32);
            DriverFirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.DriverFirstName_nvc, TypeCode.String));
            DriverLastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.DriverLastName_nvc, TypeCode.String));
            DriverLicenceNumber_intNumericTextBox.Text = Convert.ToString( Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.DriverLicenceNumber_int, TypeCode.Int64));
            DriverNationalCode_bintNumericTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.DriverNationalCode_bint, TypeCode.Int64));
            NumberPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.NumberPlate_nvc, TypeCode.String));
            SerialPlate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.SerialPlate_nvc, TypeCode.String));
            PlateCityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.PlateCityCode_nvc, TypeCode.String));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CompanyID_intComboBox, InfractionEntity.CompanyID_int, TypeCode.Int32);
            CompanyCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.CompanyCode_nvc, TypeCode.String));
            RegiaterComment_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.RegiaterComment_nvc, TypeCode.String));
            SolveComment_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.SolveComment_nvc, TypeCode.String));
            PenaltyFee_decNumericTextBox.Text =Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.PenaltyFee_dec, TypeCode.Decimal));
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref OtherOffender_nvcComboBox, InfractionEntity.OtherOffender_nvc, TypeCode.String);
            Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionGroupID_intComboBox, InfractionEntity.InfractionGroupID_int, TypeCode.Int32);

            TrafficcheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.Traffic_bit, TypeCode.Boolean);
            TurnAccept_bitcheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.TurnAccept_bit , TypeCode.Boolean);
            TurnSave_bitcheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.TurnSave_bit , TypeCode.Boolean);
            Exit_bitcheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.Exit_bit, TypeCode.Boolean);
            CommentControl_nvctextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.CommentControl_nvc , TypeCode.String ));
            if (!string.IsNullOrEmpty(InfractionEntity.PlateCityCode_nvc))
            {
                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                List<HPS.BLL.PlateCityBLL.BLLPlateCity_T> PlateList = PlateCityFactory.GetAllBy(HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityCode_nvc, InfractionEntity.PlateCityCode_nvc);
                if (PlateList!=null && PlateList.Count>0)
                {
                    PlateCityID_intComboBox.Text = PlateList[0].PlateCity_nvc;
                }
            }
            if (_Registered == true)
            {
                SolveComment_nvcTextBox.Enabled = true;
                SolveComment_nvcTextBox.Focus();
                SolveComment_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionEntity.SolveComment_nvc, TypeCode.String));
            }
            else
            {
                SolveComment_nvcTextBox.Enabled = false;
            }
            if (!string.IsNullOrEmpty(InfractionEntity.SolveComment_nvc) && !string.IsNullOrEmpty(InfractionEntity.SolveDate_nvc))
            {
                _Solved = true;
            }
        }

        protected override void Insert()
        {
            HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
            try
            {
                HPS.BLL.InfractionBLL.BLLInfraction_T InfractionEntity = new HPS.BLL.InfractionBLL.BLLInfraction_T();
                InfractionEntity.InfractionTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                if (DriverList != null && DriverList.Count > 0)
                {
                    InfractionEntity.DriverID_bint = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverList[0].DriverID_bint, TypeCode.Int64);
                }

                if (CarList != null && CarList.Count > 0)
                {
                    InfractionEntity.CarID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CarList[0].CarID_int, TypeCode.Int32);
                }

                if (CompanyEntity != null && CompanyEntity.CompanyID_int != 0)
                {
                    InfractionEntity.CompanyID_int = CompanyEntity.CompanyID_int;
                }
                if (InfractionGroupID_intComboBox.Text=="راننده")
                {
                    if (string.IsNullOrEmpty(DriverFirstName_nvcTextBox.Text) || string.IsNullOrEmpty(DriverLastName_nvcTextBox.Text) || string.IsNullOrEmpty(DriverNationalCode_bintNumericTextBox.NumericText))
                {
                    throw new ApplicationException("اطلاعات راننده خالی است");
                }
                }
                else if (InfractionGroupID_intComboBox.Text == "ناوگان")
                {
                    if (string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text) || string.IsNullOrEmpty(SerialPlate_nvcTextBox.Text) || string.IsNullOrEmpty(PlateCityCode_nvcTextBox.Text))
                    {
                        throw new ApplicationException("اطلاعات ناوگان خالی است");
                    }
                }

                else if (InfractionGroupID_intComboBox.Text == "شرکت")
                {
                    if (string.IsNullOrEmpty(CompanyID_intComboBox.Text))
                    {
                        throw new ApplicationException("اطلاعات شرکت خالی است");
                    }
                }
                

                InfractionEntity.DriverFirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverFirstName_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.DriverLastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverLastName_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.DriverLicenceNumber_int = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverLicenceNumber_intNumericTextBox.NumericText, TypeCode.Int64);
                InfractionEntity.DriverNationalCode_bint = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverNationalCode_bintNumericTextBox.NumericText, TypeCode.Int64);
                
                InfractionEntity.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.PlateCityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityCode_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.CompanyID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.Int32);
                InfractionEntity.CompanyCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyCode_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.CompanyName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.Text, TypeCode.String).ToString();
                InfractionEntity.RegisterUserName_nvc = HPS.Common.CurrentUser.user.UserName_nvc;
                InfractionEntity.RegisterDate_nvc = InfractionFactory.ServerJalaliDate; ;
                InfractionEntity.RegisterTime_nvc = InfractionFactory.ServerTime;
                InfractionEntity.RegiaterComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(RegiaterComment_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.PenaltyFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(PenaltyFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                InfractionEntity.OtherOffender_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(OtherOffender_nvcComboBox.SelectedValue, TypeCode.String);
                InfractionEntity.Traffic_bit = TrafficcheckBox.Checked;
                InfractionEntity.TurnAccept_bit = TurnAccept_bitcheckBox.Checked;
                InfractionEntity.TurnSave_bit = TurnSave_bitcheckBox.Checked;
                InfractionEntity.Exit_bit = Exit_bitcheckBox.Checked;
                InfractionEntity.CommentControl_nvc = CommentControl_nvctextBox.Text;
                DataRow[] tablerow = null;
                DataTable InfractionDataTabl = new DataTable();
                string Condition = string.Format("([Infraction_T].NumberPlate_nvc= '{0}' AND  [Infraction_T].SerialPlate_nvc='{1}' AND SolveDate_nvc is null) or ([Infraction_T].DriverFirstName_nvc = '{2}' And [Infraction_T].DriverNationalCode_bint='{3}' AND SolveDate_nvc is null) ", NumberPlate_nvcTextBox.Text, SerialPlate_nvcTextBox.Text, DriverLastName_nvcTextBox.Text, DriverNationalCode_bintNumericTextBox.Text);
                if (CompanyID_intComboBox.SelectedValue != null)
                {
                    Condition = string.Format("{0} or ([Infraction_T].CompanyID_int={1} And  SolveDate_nvc is null)", Condition, Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.Int32));
                }
                InfractionFactory.GetAllByCondition(Condition, ref InfractionDataTabl);

                tablerow = InfractionDataTabl.Select("NumberPlate_nvc='" + NumberPlate_nvcTextBox.Text + "' AND SerialPlate_nvc='" + SerialPlate_nvcTextBox.Text + "' AND SolveDate_nvc is null");
                if (tablerow!=null && tablerow.Length>0)
                {
                    throw new ApplicationException("برای این ناوگان تخلف ثبت شده و رفع تخلف نشده است");
                }

                tablerow = InfractionDataTabl.Select("DriverFirstName_nvc='" + DriverFirstName_nvcTextBox.Text + "' AND DriverLastName_nvc='" + DriverLastName_nvcTextBox.Text + "' AND DriverNationalCode_bint='" + DriverNationalCode_bintNumericTextBox.Text + "' AND SolveDate_nvc is null");
                if (tablerow != null && tablerow.Length > 0)
                {
                    throw new ApplicationException("برای این راننده تخلف ثبت شده و رفع تخلف نشده است");
                }

                tablerow = InfractionDataTabl.Select("CompanyID_int='" + Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.Int32) + "' AND SolveDate_nvc is null");
                if (tablerow != null && tablerow.Length > 0)
                {
                    throw new ApplicationException("برای این شرکت تخلف ثبت شده و رفع تخلف نشده است");
                }

                InfractionFactory.BeginProc();
                InfractionFactory.Insert(InfractionEntity);
                InfractionFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.InfractionID_int, TypeCode.Int32);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionTypeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.InfractionTypeID_int, TypeCode.Int32);
                    dr["InfractionTypeID_intInfractionType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionTypeID_intComboBox);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverID_bint, TypeCode.Int64);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverFirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverFirstName_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverLastName_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLicenceNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverLicenceNumber_int, TypeCode.Int64);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverNationalCode_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverNationalCode_bint, TypeCode.Int64);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CarID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.CarID_int, TypeCode.Int32);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.NumberPlate_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SerialPlate_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PlateCityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.PlateCityCode_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.CompanyID_int, TypeCode.Int32);
                    dr["CompanyID_intCompany_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyID_intComboBox);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.CompanyCode_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.CompanyName_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterUserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterUserName_nvc, TypeCode.String);
                    dr["RegisterUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterUserName_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterDate_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterTime_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegiaterComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegiaterComment_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolverUserName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolverUserName_nvc, TypeCode.String);
                    dr["SolverUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolverUserName_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolveDate_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolveTime_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolveComment_nvc, TypeCode.String);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PenaltyFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.PenaltyFee_dec, TypeCode.Decimal);
                    dr[HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.OtherOffender_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.OtherOffender_nvc, TypeCode.String);
                    dr["OtherOffender_nvcFullName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(OtherOffender_nvcComboBox);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                InfractionFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();
            try
            {
                HPS.BLL.InfractionBLL.BLLInfraction_T InfractionEntity = new HPS.BLL.InfractionBLL.BLLInfraction_T();
                InfractionEntity.InfractionTypeID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionTypeID_intComboBox.SelectedValue, TypeCode.Int32);
                if (DriverList != null && DriverList.Count > 0)
                {
                    InfractionEntity.DriverID_bint = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverList[0].DriverID_bint, TypeCode.Int64);
                }

                if (CarList != null && CarList.Count > 0)
                {
                    InfractionEntity.CarID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CarList[0].CarID_int, TypeCode.Int32);
                }
                if (CompanyEntity!=null && CompanyEntity.CompanyID_int!=0)
                {
                    InfractionEntity.CompanyID_int = CompanyEntity.CompanyID_int;
                }
                InfractionEntity.DriverFirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverFirstName_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.DriverLastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverLastName_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.DriverLicenceNumber_int = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverLicenceNumber_intNumericTextBox.NumericText, TypeCode.Int64);
                InfractionEntity.DriverNationalCode_bint = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverNationalCode_bintNumericTextBox.NumericText, TypeCode.Int64);
                InfractionEntity.NumberPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(NumberPlate_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.SerialPlate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SerialPlate_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.PlateCityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(PlateCityCode_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.CompanyID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.SelectedValue, TypeCode.Int32);
                InfractionEntity.CompanyCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyCode_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.CompanyName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CompanyID_intComboBox.Text, TypeCode.String).ToString();
                HPS.BLL.InfractionBLL.BLLInfraction_TKeys infkey = new HPS.BLL.InfractionBLL.BLLInfraction_TKeys();
                infkey.InfractionID_int=((HPS.BLL.InfractionBLL.BLLInfraction_TKeys)Key).InfractionID_int;
                HPS.BLL.InfractionBLL.BLLInfraction_T infrentity = InfractionFactory.GetBy(infkey);
                InfractionEntity.RegisterUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(infrentity.RegisterUserName_nvc, TypeCode.String);
                InfractionEntity.RegisterDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(infrentity.RegisterDate_nvc, TypeCode.String).ToString();
                InfractionEntity.RegisterTime_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(infrentity.RegisterTime_nvc, TypeCode.String).ToString();
                InfractionEntity.RegiaterComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(RegiaterComment_nvcTextBox.Text, TypeCode.String).ToString();
                InfractionEntity.PenaltyFee_dec = (Nullable<Decimal>)Hepsa.Core.Common.PersentationController.GetEntityValue(PenaltyFee_decNumericTextBox.NumericText, TypeCode.Decimal);
                InfractionEntity.OtherOffender_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(OtherOffender_nvcComboBox.SelectedValue, TypeCode.String);
                InfractionEntity.Traffic_bit = TrafficcheckBox.Checked;
                InfractionEntity.TurnAccept_bit = TurnAccept_bitcheckBox.Checked;
                InfractionEntity.TurnSave_bit = TurnSave_bitcheckBox.Checked;
                InfractionEntity.Exit_bit = Exit_bitcheckBox.Checked;

                InfractionEntity.CommentControl_nvc = CommentControl_nvctextBox.Text;
                if (!string.IsNullOrEmpty(SolveComment_nvcTextBox.Text))
                {
                    InfractionEntity.SolverUserName_nvc = (String)Hepsa.Core.Common.PersentationController.GetEntityValue(HPS.Common.CurrentUser.user.UserName_nvc, TypeCode.String);
                    InfractionEntity.SolveDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionFactory.ServerJalaliDate, TypeCode.String).ToString();
                    InfractionEntity.SolveTime_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionFactory.ServerTime, TypeCode.String).ToString();
                    InfractionEntity.SolveComment_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(SolveComment_nvcTextBox.Text, TypeCode.String).ToString();
                   
                }
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    InfractionFactory.BeginProc();
                    InfractionFactory.Update(InfractionEntity,(HPS.BLL.InfractionBLL.BLLInfraction_TKeys)Key);
                    InfractionFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionID_int.ToString() + "='" + ((HPS.BLL.InfractionBLL.BLLInfraction_TKeys)Key).InfractionID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0]["InfractionTypeID_intInfractionType_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionTypeID_intComboBox);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverID_bint, TypeCode.Int64);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverFirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverFirstName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverLastName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverLicenceNumber_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverLicenceNumber_int, TypeCode.Int64);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.DriverNationalCode_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.DriverNationalCode_bint, TypeCode.Int64);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.NumberPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.NumberPlate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SerialPlate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SerialPlate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PlateCityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.PlateCityCode_nvc, TypeCode.String);
                            dr[0]["CompanyID_intCompany_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CompanyID_intComboBox);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.CompanyCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.CompanyName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.CompanyName_nvc, TypeCode.String);
                            dr[0]["RegisterUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterUserName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegisterTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegisterTime_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.RegiaterComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.RegiaterComment_nvc, TypeCode.String);
                            dr[0]["SolverUserName_nvcUserName_nvc"] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolverUserName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolveDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolveTime_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.SolveComment_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.SolveComment_nvc, TypeCode.String);
                            dr[0][HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.PenaltyFee_dec.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(InfractionEntity.PenaltyFee_dec, TypeCode.Decimal);
                            dr[0]["OtherOffender_nvcFullName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(OtherOffender_nvcComboBox);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                InfractionFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.InfractionBLL.BLLInfraction_TFactory InfractionFactory = new HPS.BLL.InfractionBLL.BLLInfraction_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    InfractionFactory.BeginProc();
                    InfractionFactory.Delete((HPS.BLL.InfractionBLL.BLLInfraction_TKeys)Key);
                    InfractionFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.InfractionBLL.BLLInfraction_T.Infraction_TField.InfractionID_int.ToString() + "='" + ((HPS.BLL.InfractionBLL.BLLInfraction_TKeys)Key).InfractionID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0].Delete();
                        }
                        DataTable.AcceptChanges();
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                InfractionFactory.RollBackProc();
                throw ex;
            }
        }
        DataTable PlateCityID_intDataTable = new DataTable();
        private void FillCombo()
        {
            try
            {
                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupID_intFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
                DataTable InfractionGroupID_intDataTable = new DataTable();
                string condition="InfractionGroup_T.Active_bit='True'";
                InfractionGroupID_intFactory.GetAllByCondition(condition,ref InfractionGroupID_intDataTable);
                this.InfractionGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString();
                this.InfractionGroupID_intComboBox.ValueMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.DataSource = InfractionGroupID_intDataTable;
                this.InfractionGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeID_intFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
                DataTable InfractionTypeID_intDataTable = new DataTable();
                string TypeCondition = "InfractionType_T.Active_bit='True'";
                InfractionTypeID_intFactory.GetAllByCondition(TypeCondition,ref InfractionTypeID_intDataTable);
                this.InfractionTypeID_intComboBox.DisplayMember = HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionType_nvc.ToString();
                this.InfractionTypeID_intComboBox.ValueMember = HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString();
                this.InfractionTypeID_intComboBox.DataSource = InfractionTypeID_intDataTable;
                this.InfractionTypeID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();
                DataTable CompanyID_intDataTable = new DataTable();
                string companyCondition = "Company_T.Active_bit='True'";
                CompanyID_intFactory.GetAllByCondition(companyCondition,ref CompanyID_intDataTable);
                this.CompanyID_intComboBox.DisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
                this.CompanyID_intComboBox.ValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
                this.CompanyID_intComboBox.DataSource = CompanyID_intDataTable;
                this.CompanyID_intComboBox.SelectedIndex = -1;

                string UserCondition = "User_T.Active_bit='True'"; 
                
                HPS.BLL.UserBLL.BLLUser_TFactory OtherOffender_nvcFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable OtherOffender_nvcDataTable = new DataTable();        
                OtherOffender_nvcFactory.GetAllByCondition(UserCondition, ref OtherOffender_nvcDataTable);
                this.OtherOffender_nvcComboBox.DisplayMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.FullName_nvc.ToString();
                this.OtherOffender_nvcComboBox.ValueMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                this.OtherOffender_nvcComboBox.DataSource = OtherOffender_nvcDataTable;
                this.OtherOffender_nvcComboBox.SelectedIndex = -1;

                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityID_intFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                string PlateCityCondition = "[PlateCity_T].[Active_bit]='true'";
                
                PlateCityID_intFactory.GetAllByCondition(PlateCityCondition, ref PlateCityID_intDataTable);
                this.PlateCityID_intComboBox.DisplayMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCity_nvc.ToString();
                this.PlateCityID_intComboBox.ValueMember = HPS.BLL.PlateCityBLL.BLLPlateCity_T.PlateCity_TField.PlateCityID_int.ToString();
                this.PlateCityID_intComboBox.DataSource = PlateCityID_intDataTable;
                this.PlateCityID_intComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InfractionTypeID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionType.InfractionTypeEntityForm frm = new HPS.Present.InfractionType.InfractionTypeEntityForm((DataTable)InfractionTypeID_intComboBox.DataSource);
            frm.ShowDialog();
        }



        private void OtherOffender_nvcNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.User.UserEntityForm frm = new HPS.Present.User.UserEntityForm((DataTable)OtherOffender_nvcComboBox.DataSource);
            frm.ShowDialog();
        }

        private void InfractionTypeID_intComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void InfractionGroupID_intComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableFields();
        }

        private void EnableFields()
        {
            if (InfractionGroupID_intComboBox.Text == "راننده")
            {
                DrivergroupBox.Enabled = true;
                TrafficgroupBox.Enabled = false;
            }
            else
            {
                DrivergroupBox.Enabled =false;
            }

            if (InfractionGroupID_intComboBox.Text == "ناوگان")
            {
                CargroupBox.Enabled = true;
                TrafficgroupBox.Enabled = true ;
               
            }
            else
            {
                CargroupBox.Enabled = false;
            }
            if (InfractionGroupID_intComboBox.Text == "شركت")
            {
                CompanygroupBox.Enabled = true;

            }
            else
            {
                CompanygroupBox.Enabled = false;
            }
            if (InfractionGroupID_intComboBox.Text != "راننده" && InfractionGroupID_intComboBox.Text != "ناوگان" && InfractionGroupID_intComboBox.Text != "شركت")
            {
                OtherOffender_nvcComboBox.Enabled = true;
                OtherOffender_nvcNewButton.Enabled = true;

            }
            else
            {
                OtherOffender_nvcComboBox.Enabled = false;
                OtherOffender_nvcNewButton.Enabled = false;
            }


        }

        private void InfractionTypeID_intLabel_Click(object sender, EventArgs e)
        {

        }

        private void InfractionGroupID_intLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void DriverCardNumber_bintTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(DriverCardNumber_bintTextBox.Text))
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
                string DriverCondition = "([Driver_T].[DriverCardNumber_nvc]='" + DriverCardNumber_bintTextBox.Text + "') ";
                DriverList = DriverFactory.GetAllByCondition(DriverCondition);

                if (DriverList.Count == 1)
                {
                    if (DriverList[0].Active_bit == false)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("این راننده توسط مدیریت غیر فعال شده است");
                    }
                    DriverFirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                    DriverLastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                    DriverLicenceNumber_intNumericTextBox.Text = DriverList[0].licenceNumber_nvc;
                    DriverNationalCode_bintNumericTextBox.Text = DriverList[0].NationalCode_int.ToString();
                }
                else
                {

                    HPS.Present.SearchForm.DriverSearch frm = new HPS.Present.SearchForm.DriverSearch();
                    DriverList.Clear();
                    if (frm.ShowDialog()!=DialogResult.Cancel)
                    {
                        
                        DriverList.Add(frm.SelectedDriver);
                        if (DriverList[0].Active_bit == false)
                        {
                            Hepsa.Core.Common.MessageBox.InformationMessage("این راننده توسط مدیریت غیر فعال شده است");
                        }
                        DriverFirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                        DriverLastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                        DriverLicenceNumber_intNumericTextBox.Text = DriverList[0].licenceNumber_nvc;
                        DriverNationalCode_bintNumericTextBox.Text = DriverList[0].NationalCode_int.ToString();
                    }
                }
            }
        }

        private void InfractionGroupID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeID_intFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
            string condition = "[InfractionType_T].[InfractionGroupID_int]=" + InfractionGroupID_intComboBox.SelectedValue + " AND (InfractionType_T.Active_bit='True')";
            DataTable InfractionTypeID_intDataTable = new DataTable();
            InfractionTypeID_intFactory.GetAllByCondition(condition, ref InfractionTypeID_intDataTable);
            this.InfractionTypeID_intComboBox.DisplayMember = HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionType_nvc.ToString();
            this.InfractionTypeID_intComboBox.ValueMember = HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString();
            this.InfractionTypeID_intComboBox.DataSource = InfractionTypeID_intDataTable;
            this.InfractionTypeID_intComboBox.SelectedIndex = -1;

            InfractionTypeID_intComboBox.Enabled = true;
        }

        private void DriverID_bintNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                DriverList = new List<HPS.BLL.DriverBLL.BLLDriver_T>();
                string DriverCondition = "([Driver_T].[DriverCardNumber_nvc]='" + DriverCardNumber_bintTextBox.Text + "') ";
                DriverList = DriverFactory.GetAllByCondition(DriverCondition);

                if (DriverList.Count == 1)
                {
                    if (DriverList[0].Active_bit==false && DriverList[0].DriverID_bint!=0)
                    {
                        Hepsa.Core.Common.MessageBox.ErrorMessage("این راننده توسط مدیریت غیر فعال شده است");
                    }
                    if (DriverList!=null && DriverList.Count>0)
                    {
                        DriverCardNumber_bintTextBox.Text = DriverList[0].DriverCardNumber_nvc;
                        DriverFirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                        DriverLastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                        DriverLicenceNumber_intNumericTextBox.Text = DriverList[0].licenceNumber_nvc;
                        DriverNationalCode_bintNumericTextBox.Text = DriverList[0].NationalCode_int.ToString();
                    }
                }
                else
                {

                    HPS.Present.SearchForm.DriverSearchForTraffic frm = new HPS.Present.SearchForm.DriverSearchForTraffic();
                    DriverList.Clear();
                    if (frm.ShowDialog() != DialogResult.Cancel)
                    {
                         DriverList.Add(frm.SelectedDriver);
                        if (DriverList[0].Active_bit == false && DriverList[0].DriverID_bint != 0)
                        {
                            Hepsa.Core.Common.MessageBox.ErrorMessage("این راننده توسط مدیریت غیر فعال شده است");
                        }
                        if (DriverList!=null && DriverList.Count>0)
                        {
                            DriverCardNumber_bintTextBox.Text = DriverList[0].DriverCardNumber_nvc;
                            DriverFirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                            DriverLastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                            DriverLicenceNumber_intNumericTextBox.Text = DriverList[0].licenceNumber_nvc;
                            DriverNationalCode_bintNumericTextBox.Text = DriverList[0].NationalCode_int.ToString();
                        }
                    }
                }
            }
            catch ( Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void NumberPlate_nvcTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
                {
                    if (NumberPlate_nvcTextBox.Text != "")
                    {
                        HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
                        CarList = new List<HPS.BLL.CarBLL.BLLCar_T>();
                        string CarCondition = "([Car_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "') ";
                        CarList = CarFactory.GetAllByCondition(CarCondition);

                        if (CarList.Count == 1)
                        {
                            if (CarList[0].Active_bit == false)
                            {
                                Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو توسط مدیریت غیر فعال شده است");
                            }
                            if (CarList != null && CarList.Count > 0)
                            {
                                SerialPlate_nvcTextBox.Text = CarList[0].SerialPlate_nvc;
                                NumberPlate_nvcTextBox.Text = CarList[0].NumberPlate_nvc;
                                HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                                HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                                PlateCityKey.PlateCityID_int = CarList[0].PlateCityID_int;
                                HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);
                                PlateCityCode_nvcTextBox.Text = PlateCityEntity.PlateCityCode_nvc;
                                PlateCityID_intComboBox.Text = PlateCityEntity.PlateCity_nvc;
                            }
                        }
                        else if (CarList.Count > 1)
                        {
                            string rs = NumberPlate_nvcTextBox.Text;
                            HPS.Present.SearchForm.CarSearch frm = new HPS.Present.SearchForm.CarSearch(rs);
                            CarList.Clear();
                            if (frm.ShowDialog() !=DialogResult.Cancel)
                            {
                                
                                CarList.Add(frm.SelectedCar);
                                if (CarList[0].Active_bit == false && CarList[0].CarID_int != 0)
                                {
                                    Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو توسط مدیریت غیر فعال شده است");
                                }
                                if (CarList != null && CarList.Count > 0 && CarList[0].CarID_int!=0)
                                {
                                    SerialPlate_nvcTextBox.Text = CarList[0].SerialPlate_nvc;
                                    NumberPlate_nvcTextBox.Text = CarList[0].NumberPlate_nvc;
                                    HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                                    HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                                    PlateCityKey.PlateCityID_int = CarList[0].PlateCityID_int;
                                    HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);
                                    PlateCityCode_nvcTextBox.Text = PlateCityEntity.PlateCityCode_nvc;
                                    PlateCityID_intComboBox.Text = PlateCityEntity.PlateCity_nvc;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                
            }

        }

        private void CarID_intNewButton_Click(object sender, EventArgs e)
        {

            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            CarList = new List<HPS.BLL.CarBLL.BLLCar_T>();

            if (string.IsNullOrEmpty(NumberPlate_nvcTextBox.Text))
            {
                HPS.Present.SearchForm.CarSearchForTraffic frm = new HPS.Present.SearchForm.CarSearchForTraffic();
                CarList.Clear();
                if (frm.ShowDialog()!=DialogResult.Cancel)
                {
                    
                    CarList.Add(frm.SelectedCar);
                    if (CarList[0].Active_bit == false && CarList[0].CarID_int!=0)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو توسط مدیریت غیر فعال شده است");
                    }
                    if (CarList!=null && CarList.Count>0)
                    {
                        SerialPlate_nvcTextBox.Text = CarList[0].SerialPlate_nvc;
                        NumberPlate_nvcTextBox.Text = CarList[0].NumberPlate_nvc;
                        HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                        HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                        if (CarList[0].PlateCityID_int.HasValue)
                        {
                            PlateCityKey.PlateCityID_int = CarList[0].PlateCityID_int;
                            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);
                            PlateCityCode_nvcTextBox.Text = PlateCityEntity.PlateCityCode_nvc;
                            PlateCityID_intComboBox.Text = PlateCityEntity.PlateCity_nvc;
                        }
                    }

                }
            }
            string CarCondition = "([Car_T].[NumberPlate_nvc]='" + NumberPlate_nvcTextBox.Text + "') ";
            CarList = CarFactory.GetAllByCondition(CarCondition);

            if (CarList.Count == 1)
            {
                if (CarList[0].Active_bit == false && CarList[0].CarID_int!=0)
                {
                    Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو توسط مدیریت غیر فعال شده است");
                }
                if (CarList!=null && CarList.Count>0)
                {
                    SerialPlate_nvcTextBox.Text = CarList[0].SerialPlate_nvc;
                    NumberPlate_nvcTextBox.Text = CarList[0].NumberPlate_nvc;
                    HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                    HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                    if (CarList[0].PlateCityID_int.HasValue)
                    {
                        PlateCityKey.PlateCityID_int = CarList[0].PlateCityID_int;
                        HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);
                        PlateCityCode_nvcTextBox.Text = PlateCityEntity.PlateCityCode_nvc;
                        PlateCityID_intComboBox.Text = PlateCityEntity.PlateCity_nvc;
                    }
                }
            }
            else if (CarList.Count > 1)
            {
                string rs = NumberPlate_nvcTextBox.Text;
                HPS.Present.SearchForm.CarSearch frm = new HPS.Present.SearchForm.CarSearch(rs);
               CarList.Clear();
                if ( frm.ShowDialog()!= DialogResult.Cancel)
                {
                    
                    CarList.Add(frm.SelectedCar);
                    if (CarList[0].Active_bit == false && CarList[0].CarID_int != 0)
                    {
                        Hepsa.Core.Common.MessageBox.InformationMessage("این خودرو توسط مدیریت غیر فعال شده است");
                    }
                    if (CarList!=null && CarList.Count>0)
                    {
                        SerialPlate_nvcTextBox.Text = CarList[0].SerialPlate_nvc;
                        NumberPlate_nvcTextBox.Text = CarList[0].NumberPlate_nvc;
                        HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
                        HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys PlateCityKey = new HPS.BLL.PlateCityBLL.BLLPlateCity_TKeys();
                        if (CarList[0].PlateCityID_int.HasValue)
                        {
                            PlateCityKey.PlateCityID_int = CarList[0].PlateCityID_int;
                            HPS.BLL.PlateCityBLL.BLLPlateCity_T PlateCityEntity = PlateCityFactory.GetBy(PlateCityKey);
                            PlateCityCode_nvcTextBox.Text = PlateCityEntity.PlateCityCode_nvc;
                            PlateCityID_intComboBox.Text = PlateCityEntity.PlateCity_nvc;
                        }
                    }
                }
            }
        }

        private void CompanyID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CompanySearch frm = new HPS.Present.SearchForm.CompanySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CompanyEntity = frm.SelectedCompanyEntity;
                CompanyID_intComboBox.Text = CompanyEntity.Company_nvc;
                CompanyCode_nvcTextBox.Text = CompanyEntity.CompanyCode_nvc;
                
                
            }
        }

        private void InfractionTypeID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory InfractionTypeFactory = new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TFactory();
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys InfractionTypeKey= new HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys();
            InfractionTypeKey.InfractionTypeID_int = (Int32?)InfractionTypeID_intComboBox.SelectedValue;
            HPS.BLL.InfractionTypeBLL.BLLInfractionType_T InfractionTypeEntity = InfractionTypeFactory.GetBy(InfractionTypeKey);
            PenaltyFee_decNumericTextBox.Text = InfractionTypeEntity.PenaltyFee_dec.ToString();
        }

        private void InfractionTypeNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionType.InfractionTypeEntityForm frm = new HPS.Present.InfractionType.InfractionTypeEntityForm((DataTable)InfractionTypeID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void NumberPlate_nvcTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlateCity_nvcBottun_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.PlateCitySearch frm = new HPS.Present.SearchForm.PlateCitySearch();
            if (frm.ShowDialog()!=DialogResult.Cancel)
            {
                PlateCityID_intComboBox.Text = frm.SelectedPlateCity.PlateCity_nvc;
                PlateCityCode_nvcTextBox.Text = frm.SelectedPlateCity.PlateCityCode_nvc;
            }
        }

        private void PlateCityID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (PlateCityID_intComboBox.SelectedIndex != -1)
            {
               // PlateCityID_intComboBox.Text = PlateCityID_intDataTable.Rows[Convert.ToInt32(PlateCityID_intComboBox.SelectedIndex)]["PlateCity_nvc"].ToString();
                PlateCityCode_nvcTextBox.Text = PlateCityID_intDataTable.Rows[Convert.ToInt32(PlateCityID_intComboBox.SelectedIndex)]["PlateCityCode_nvc"].ToString();
            }
            else
            {
                PlateCityCode_nvcTextBox.Text = string.Empty;
            }
        }

        private void CompanyID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)CompanyID_intComboBox.DataSource;
            DataRow[] dr = dt.Select(string.Format(" CompanyID_int={0}", CompanyID_intComboBox.SelectedValue));
            if (dr != null && dr.Length > 0)
            {
                CompanyCode_nvcTextBox.Text = dr[0]["CompanyCode_nvc"].ToString();
            }
        }
   }
}