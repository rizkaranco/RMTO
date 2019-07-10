using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Driver
{
    public partial class DriverEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        bool online = false;
        public DriverEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public DriverEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.DriverBLL.BLLDriver_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        public DriverEntityForm(string DriverCardNumber, string CarCardNumber)
            : base()
        {
            InitializeComponent();
            LoadDriverOnlineInformation(DriverCardNumber, CarCardNumber);
        }

        private void LoadDriverOnlineInformation(string DriverCardNumber, string CarCardNumber)
        {
            var Key = new HPS.BLL.DriverBLL.BLLDriver_TKeys();
            List<HPS.BLL.DriverBLL.BLLDriver_T> DriverFactory = (new HPS.BLL.DriverBLL.BLLDriver_TFactory().GetAllBy(BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber));
            if (DriverFactory.Count > 0)
            {
                Key.DriverID_bint = DriverFactory[0].DriverID_bint;
                this.Key = Key;
                ShowForm();
            }
            HPS.BLL.DriverBLL.BLLDriver_T driverEntity = new BLL.DriverBLL.BLLDriver_T();
            object[] driverObject = null;
            var webService = new CheckOnlineRefrence.OnlineInformationChecking();
            //var webService = new WebReference3.OnlineInformationChecking();
            var RecivedObject = webService.GetInformation(DriverCardNumber, CarCardNumber);
            if (RecivedObject != null)
            {
                MessageBox.Show("pep");
                driverObject = (object[])RecivedObject[0];

            }

            if (driverObject != null)
            {
                if (driverObject[8].ToString() == "0")
                {
                    string ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند غیر فعال می باشد. جهت رفع مشکل به مسئول مربوطه مراجعه نمایید ", DriverCardNumber);
                    MessageBox.Show(ErroeMessage);

                }
                DriverCardNumber_nvcTextBox.Text = DriverCardNumber;
                DocNumber_nvcTextBox.Text = driverObject[11].ToString();
                MessageBox.Show(driverObject[11].ToString());
                MessageBox.Show(driverObject[11].ToString());
                FirstName_nvcTextBox.Text = driverObject[0].ToString();
                LastName_nvcTextBox.Text = driverObject[1].ToString();
                NationalCode_intNumericTextBox.Text = driverObject[2].ToString();
                licenceNumber_nvcTextBox.Text = driverObject[4].ToString();
                DriverCardDate_nvcTextBox.Text = driverObject[9].ToString();
                CityCode_nvcTextBox.Text = driverObject[10].ToString();
                online = true;
            }
            else
            {
                ////Information Not exist
                string ErroeMessage = string.Format("کارت هوشمند راننده به شماره <{0}>وارد شده در سیستم استعلام کارت هوشمند موجود نمی باشد. جهت رفع مشکل به مسئول مربوطه مراجعه نمایید ", DriverCardNumber);
                Hepsa.Core.Common.MessageBox.ErrorMessage(ErroeMessage);
            }


        }

        private void DriverEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                    this.FillCombo();

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        protected override void ShowForm()
        {
            try
            {
                this.FillCombo();
                HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = DriverFactory.GetBy((HPS.BLL.DriverBLL.BLLDriver_TKeys)Key);
                if (DriverEntity == null)
                {
                    throw new HPS.Exceptions.DriverNotFound();
                }
                DriverCardDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.DriverCardDate_nvc, TypeCode.String));
                DriverCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.DriverCardNumber_nvc, TypeCode.String));
                DriverType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.DriverType_nvc, TypeCode.String));
                FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.FirstName_nvc, TypeCode.String));
                LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.LastName_nvc, TypeCode.String));
                InsuranceNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.InsuranceNumber_nvc, TypeCode.String));
                Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref CityID_intComboBox, DriverEntity.CityID_int, TypeCode.Int32);
                CityCode_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.CityCode_nvc, TypeCode.String));
                licenceNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.licenceNumber_nvc, TypeCode.String));
                Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref LicenceCityID_intComboBox, DriverEntity.LicenceCityID_int, TypeCode.Int32);
                LicenceType_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.LicenceType_nvc, TypeCode.String));
                LiceniceDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.LiceniceDate_nvc, TypeCode.String));
                ActivityScope_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.ActivityScope_nvc, TypeCode.String));
                NationalCode_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.NationalCode_int, TypeCode.Int64).ToString();
                Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.Active_bit, TypeCode.Boolean);
                Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref InfractionGroupID_intComboBox, DriverEntity.InfractionGroupID_int, TypeCode.Int32);
                DocNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.DocNumber_nvc, TypeCode.String));
                InsertDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.InsertDate_nvc, TypeCode.String));
                UpdateDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.UpdateDate_nvc, TypeCode.String));
                Deleted_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.Deleted_bit, TypeCode.Boolean);
                Mobile_nvctextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.Mobile_nvc, TypeCode.String).ToString();
                Active_bit.Checked = Convert.ToBoolean(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverEntity.Active_bit, TypeCode.Boolean));

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected override void Insert()
        {
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            if (online)
            {
                var driver = DriverFactory.GetAllBy(BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, DriverCardNumber_nvcTextBox.Text);
                if (driver.Count > 0)
                {
                    Edit();
                    return;
                }
            }
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = new HPS.BLL.DriverBLL.BLLDriver_T();
                DriverEntity.DriverCardDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.DriverType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverType_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.InsuranceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsuranceNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.CityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.licenceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.LicenceCityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceCityID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverEntity.LicenceType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceType_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.LiceniceDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LiceniceDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.ActivityScope_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ActivityScope_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.NationalCode_int = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
                DriverEntity.Active_bit = Active_bitCheckBox.Checked;
                DriverEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverEntity.DocNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DocNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.InsertDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsertDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.UpdateDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UpdateDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.Deleted_bit = Deleted_bitCheckBox.Checked;
                DriverEntity.Mobile_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_nvctextBox.Text, TypeCode.String).ToString();
                DriverEntity.Active_bit = Active_bit.Checked;

                DriverFactory.BeginProc();
                DriverFactory.Insert(DriverEntity);
                DriverFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverID_bint, TypeCode.Int64);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverCardDate_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverCardNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverType_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.FirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.FirstName_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LastName_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsuranceNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.InsuranceNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.CityID_int, TypeCode.Int32);
                    dr["CityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CityID_intComboBox);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.CityCode_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.licenceNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.licenceNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceCityID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LicenceCityID_int, TypeCode.Int32);
                    dr["LicenceCityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LicenceCityID_intComboBox);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LicenceType_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LiceniceDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LiceniceDate_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.ActivityScope_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.ActivityScope_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.NationalCode_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.NationalCode_int, TypeCode.Int64);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.Active_bit, TypeCode.Boolean);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InfractionGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.InfractionGroupID_int, TypeCode.Int32);
                    dr["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DocNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DocNumber_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsertDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.InsertDate_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.UpdateDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.UpdateDate_nvc, TypeCode.String);
                    dr[HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Deleted_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.Deleted_bit, TypeCode.Boolean);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                DriverFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            try
            {
                HPS.BLL.DriverBLL.BLLDriver_T DriverEntity = new HPS.BLL.DriverBLL.BLLDriver_T();
                DriverEntity.DriverCardDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.DriverType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverType_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.InsuranceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsuranceNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.CityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(CityID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverEntity.CityCode_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CityCode_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.licenceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.LicenceCityID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceCityID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverEntity.LicenceType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceType_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.LiceniceDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LiceniceDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.ActivityScope_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(ActivityScope_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.NationalCode_int = (Nullable<Int64>)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
                DriverEntity.Active_bit = Active_bitCheckBox.Checked;
                DriverEntity.InfractionGroupID_int = (Nullable<Int32>)Hepsa.Core.Common.PersentationController.GetEntityValue(InfractionGroupID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverEntity.DocNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DocNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.InsertDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsertDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.UpdateDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(UpdateDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverEntity.Deleted_bit = Deleted_bitCheckBox.Checked;
                DriverEntity.Mobile_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(Mobile_nvctextBox.Text, TypeCode.String).ToString();
                DriverEntity.Active_bit = Active_bit.Checked;
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    DriverFactory.BeginProc();
                    DriverFactory.Update(DriverEntity, (HPS.BLL.DriverBLL.BLLDriver_TKeys)Key);
                    DriverFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverID_bint.ToString() + "='" + ((HPS.BLL.DriverBLL.BLLDriver_TKeys)Key).DriverID_bint.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverCardDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverCardNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DriverType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.FirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.FirstName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LastName_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsuranceNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.InsuranceNumber_nvc, TypeCode.String);
                            dr[0]["CityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(CityID_intComboBox);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.CityCode_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.CityCode_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.licenceNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.licenceNumber_nvc, TypeCode.String);
                            dr[0]["LicenceCityID_intCity_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(LicenceCityID_intComboBox);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LicenceType_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LicenceType_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.LiceniceDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.LiceniceDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.ActivityScope_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.ActivityScope_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.NationalCode_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.NationalCode_int, TypeCode.Int64);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.Active_bit, TypeCode.Boolean);
                            dr[0]["InfractionGroupID_intInfractionGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(InfractionGroupID_intComboBox);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DocNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.DocNumber_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.InsertDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.InsertDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.UpdateDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.UpdateDate_nvc, TypeCode.String);
                            dr[0][HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.Deleted_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverEntity.Deleted_bit, TypeCode.Boolean);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                DriverFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    DriverFactory.BeginProc();
                    DriverFactory.Delete((HPS.BLL.DriverBLL.BLLDriver_TKeys)Key);
                    DriverFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverID_bint.ToString() + "='" + ((HPS.BLL.DriverBLL.BLLDriver_TKeys)Key).DriverID_bint.ToString() + "'");
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
                DriverFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.CityBLL.BLLCity_TFactory CityID_intFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                DataTable CityID_intDataTable = new DataTable();
                string condition = "City_T.Active_bit='True'";
                CityID_intFactory.GetAllByCondition(condition, ref CityID_intDataTable);
                this.CityID_intComboBox.DisplayMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString();
                this.CityID_intComboBox.ValueMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString();
                this.CityID_intComboBox.DataSource = CityID_intDataTable;
                this.CityID_intComboBox.SelectedIndex = -1;

                HPS.BLL.CityBLL.BLLCity_TFactory LicenceCityID_intFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
                DataTable LicenceCityID_intDataTable = new DataTable();
                LicenceCityID_intFactory.GetAllByCondition(condition, ref LicenceCityID_intDataTable);
                this.LicenceCityID_intComboBox.DisplayMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.City_nvc.ToString();
                this.LicenceCityID_intComboBox.ValueMember = HPS.BLL.CityBLL.BLLCity_T.City_TField.CityID_int.ToString();
                this.LicenceCityID_intComboBox.DataSource = LicenceCityID_intDataTable;
                this.LicenceCityID_intComboBox.SelectedIndex = -1;

                HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory InfractionGroupID_intFactory = new HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_TFactory();
                DataTable InfractionGroupID_intDataTable = new DataTable();
                string InfractionGroupCondition = "InfractionGroup_T.Active_bit='True'";
                InfractionGroupID_intFactory.GetAllByCondition(InfractionGroupCondition, ref InfractionGroupID_intDataTable);
                this.InfractionGroupID_intComboBox.DisplayMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroup_nvc.ToString();
                this.InfractionGroupID_intComboBox.ValueMember = HPS.BLL.InfractionGroupBLL.BLLInfractionGroup_T.InfractionGroup_TField.InfractionGroupID_int.ToString();
                this.InfractionGroupID_intComboBox.DataSource = InfractionGroupID_intDataTable;
                this.InfractionGroupID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CityID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.City.CityEntityForm frm = new HPS.Present.City.CityEntityForm((DataTable)CityID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void LicenceCityID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.City.CityEntityForm frm = new HPS.Present.City.CityEntityForm((DataTable)LicenceCityID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void InfractionGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.InfractionGroup.InfractionGroupEntityForm frm = new HPS.Present.InfractionGroup.InfractionGroupEntityForm((DataTable)InfractionGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void CityID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            HPS.BLL.CityBLL.BLLCity_TKeys CityKey = new HPS.BLL.CityBLL.BLLCity_TKeys();
            CityKey.CityID_int = (Int32?)CityID_intComboBox.SelectedValue;
            HPS.BLL.CityBLL.BLLCity_T CityEntity = CityFactory.GetBy(CityKey);
            if (CityEntity != null && CityEntity.CityID_int != 0)
            {
                CityCode_nvcTextBox.Text = CityEntity.CityCode_nvc;
            }
        }
    }
}