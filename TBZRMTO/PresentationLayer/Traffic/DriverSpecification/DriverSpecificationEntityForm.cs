using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace HPS.Present.DriverSpecification
{
    public partial class DriverSpecificationEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        private DataTable _datatable;
        private string _DriverCardNumber=string.Empty;
        private string _CarCardNumber = string.Empty;
        private string _FirstName;
        private string _LastName;
        private Int64 _NationalCode;
        private Int32 _DriverSpecificationID;
        bool _Driver_bit = false;
        HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys Key;
        public DriverSpecificationEntityForm(string CardNumber_nvc,bool Driver_bit)
            : base(null)
        {
            InitializeComponent();
            _Driver_bit = Driver_bit;
            if (Driver_bit)
            {
                this._DriverCardNumber = CardNumber_nvc;
            }
            else
                _CarCardNumber = CardNumber_nvc;
        }

        public DriverSpecificationEntityForm(string FirstName, string LastName, Int64 NationalCode)
            : base(null)
        {
            InitializeComponent();
            this._FirstName = FirstName;
            this._LastName = LastName;
            this._NationalCode = NationalCode;

        }

        public DriverSpecificationEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void DriverSpecificationEntityForm_Load(object sender, EventArgs e)
        {
            if (_Driver_bit)
            {
                DriverGropBox.Enabled = true;
                CarGroupBox.Enabled = false;
            }
            else
            {
                DriverGropBox.Enabled = false;
                CarGroupBox.Enabled = true;
            }
            FillCombo();
            try
            {
                if (!string.IsNullOrEmpty(_DriverCardNumber))
                {
                    LoadWithDriverCardNumber();
                }
                //else
                //{
                //    LoadWithoutDriverCardNumber();
                //}
                if (!string.IsNullOrEmpty(_CarCardNumber))
                {
                    LoadWithCarCardNumber();
                }
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        //protected override void ShowForm()
        //{
        //    this.FillCombo();
        //    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
        //    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = DriverSpecificationFactory.GetBy((HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys)Key);
        //    if (DriverSpecificationEntity == null)
        //    {
        //        throw new HPS.Exceptions.DriverSpecificationNotFound();
        //    }
        //    DriverCardNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.DriverCardNumber_nvc, TypeCode.String));
        //    FirstName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.FirstName_nvc, TypeCode.String));
        //    LastName_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.LastName_nvc, TypeCode.String));
        //    NationalCode_intNumericTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.NationalCode_int, TypeCode.Int64).ToString();
        //    licenceNumber_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.licenceNumber_nvc, TypeCode.String));
        //    CarExamination_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.CarExamination_bit, TypeCode.Boolean);
        //    LicenceEnd_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.LicenceEnd_nvc, TypeCode.String));
        //    CarExaminationEndDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.CarExaminationEndDate_nvc, TypeCode.String));
        //    Insurance_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.Insurance_bit, TypeCode.Boolean);
        //    InsuranceStartDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.InsuranceStartDate_nvc, TypeCode.String));
        //    InsuranceEndDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.InsuranceEndDate_nvc, TypeCode.String));
        //    Hepsa.Core.Common.PersentationController.SetComboBoxValue(ref ClassID_intComboBox, DriverSpecificationEntity.ClassID_int, TypeCode.Int32);
        //    HealthCard_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.HealthCard_bit, TypeCode.Boolean);
        //    HealthCardStartDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.HealthCardStartDate_nvc, TypeCode.String));
        //    HealthCardEndDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.HealthCardEndDate_nvc, TypeCode.String));
        //    DriverCardSharje_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.DriverCardSharje_bit, TypeCode.Boolean);
        //    DriverCardSharjeStartDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.DriverCardSharjeStartDate_nvc, TypeCode.String));
        //    DriverCardSharjeEndDate_nvcTextBox.Text = Convert.ToString(Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.DriverCardSharjeEndDate_nvc, TypeCode.String));
        //    StatisticCard_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(DriverSpecificationEntity.StatisticCard_bit, TypeCode.Boolean);

        //}

        protected override void Insert()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            //try
            //{
            //    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
            //    DriverSpecificationEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.NationalCode_int = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
            //    DriverSpecificationEntity.licenceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_nvcTextBox.NumericText, TypeCode.String).ToString();
            //    DriverSpecificationEntity.CarExamination_bit = false;
            //    DriverSpecificationEntity.LicenceEnd_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceEnd_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.CarExaminationEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarExaminationEndDate_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.Insurance_bit = false;
            //    DriverSpecificationEntity.InsuranceStartDate_nvc = string.Empty;
            //    DriverSpecificationEntity.InsuranceEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsuranceEndDate_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.ClassID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(ClassID_intComboBox.SelectedValue, TypeCode.Int32);
            //    DriverSpecificationEntity.HealthCard_bit = false;
            //    DriverSpecificationEntity.HealthCardStartDate_nvc = string.Empty;
            //    DriverSpecificationEntity.HealthCardEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(HealthCardEndDate_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.DriverCardSharje_bit = false;
            //    DriverSpecificationEntity.DriverCardSharjeStartDate_nvc = string.Empty;
            //    DriverSpecificationEntity.DriverCardSharjeEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardSharjeEndDate_nvcTextBox.Text, TypeCode.String).ToString();
            //    DriverSpecificationEntity.StatisticCard_bit = false;
            //    DriverSpecificationEntity.CarCardNumber_nvc = _CarCardNumber;
            //    DriverSpecificationFactory.BeginProc();
            //    DriverSpecificationFactory.Insert(DriverSpecificationEntity);
            //    DriverSpecificationFactory.CommitProc();
            //    if (DataTable != null)
            //    {
            //        DataRow dr = this.DataTable.NewRow();
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverSpecificationID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.DriverSpecificationID_int, TypeCode.Int32);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverID_bint.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.DriverID_bint, TypeCode.Int64);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.DriverCardNumber_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.FirstName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.FirstName_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.LastName_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.LastName_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.NationalCode_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.NationalCode_int, TypeCode.Int64);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.licenceNumber_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.licenceNumber_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarExamination_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.CarExamination_bit, TypeCode.Boolean);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.LicenceEnd_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.LicenceEnd_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.CarExaminationEndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.CarExaminationEndDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.Insurance_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.Insurance_bit, TypeCode.Boolean);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.InsuranceStartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.InsuranceStartDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.InsuranceEndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.InsuranceEndDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.ClassID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.ClassID_int, TypeCode.Int32);
            //        dr["ClassID_intClassName_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(ClassID_intComboBox);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCard_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.HealthCard_bit, TypeCode.Boolean);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCardStartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.HealthCardStartDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.HealthCardEndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.HealthCardEndDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharje_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.DriverCardSharje_bit, TypeCode.Boolean);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharjeStartDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.DriverCardSharjeStartDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardSharjeEndDate_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.DriverCardSharjeEndDate_nvc, TypeCode.String);
            //        dr[HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.StatisticCard_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(DriverSpecificationEntity.StatisticCard_bit, TypeCode.Boolean);

            //        DataTable.Rows.Add(dr);
            //        DataTable.AcceptChanges();
            //    }
            //    this.ClearForm(this);
            //}
            //catch (Exception ex)
            //{
            //    DriverSpecificationFactory.RollBackProc();
            //    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            //}
        }

        protected  void Edit()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            try
            {
                //HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
                //DriverSpecificationEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardNumber_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.NationalCode_int = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
                //DriverSpecificationEntity.licenceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_nvcTextBox.NumericText, TypeCode.String).ToString();
                //DriverSpecificationEntity.CarExamination_bit = false;
                //DriverSpecificationEntity.LicenceEnd_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceEnd_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.CarExaminationEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarExaminationEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.Insurance_bit = false;
                //DriverSpecificationEntity.InsuranceStartDate_nvc = string.Empty;
                //DriverSpecificationEntity.InsuranceEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsuranceEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.ClassID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(ClassID_intComboBox.SelectedValue, TypeCode.Int32);
                //DriverSpecificationEntity.HealthCard_bit = false;
                //DriverSpecificationEntity.HealthCardStartDate_nvc = string.Empty;
                //DriverSpecificationEntity.HealthCardEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(HealthCardEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.DriverCardSharje_bit = false;
                //DriverSpecificationEntity.DriverCardSharjeStartDate_nvc = string.Empty;
                //DriverSpecificationEntity.DriverCardSharjeEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardSharjeEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                //DriverSpecificationEntity.StatisticCard_bit = false;
                //DriverSpecificationEntity.CarCardNumber_nvc = _CarCardNumber;
                //if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                //{
                //    DriverSpecificationFactory.BeginProc();
                //    DriverSpecificationFactory.Update(DriverSpecificationEntity, (HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys)Key);
                //    DriverSpecificationFactory.CommitProc();
                
                //}
            }
            catch (Exception ex)
            {
                DriverSpecificationFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        protected override void Delete()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    DriverSpecificationFactory.BeginProc();
                    DriverSpecificationFactory.Delete((HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys)Key);
                    DriverSpecificationFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverSpecificationID_int.ToString() + "='" + ((HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys)Key).DriverSpecificationID_int.ToString() + "'");
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
                DriverSpecificationFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.ClassBLL.BLLClass_TFactory ClassID_intFactory = new HPS.BLL.ClassBLL.BLLClass_TFactory();
                DataTable ClassID_intDataTable = new DataTable();
                ClassID_intFactory.GetAll(ref ClassID_intDataTable);
                this.ClassID_intComboBox.DisplayMember = HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassName_nvc.ToString();
                this.ClassID_intComboBox.ValueMember = HPS.BLL.ClassBLL.BLLClass_T.Class_TField.ClassID_int.ToString();
                this.ClassID_intComboBox.DataSource = ClassID_intDataTable;
                this.ClassID_intComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ClassID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.Class.ClassEntityForm frm = new HPS.Present.Class.ClassEntityForm((DataTable)ClassID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void LoadWithDriverCardNumber()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> DriverSpecificationList = DriverSpecificationFactory.GetAllBy(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc, _DriverCardNumber);
            if (DriverSpecificationList != null && DriverSpecificationList.Count > 0)
            {
                _DriverSpecificationID = DriverSpecificationList[0].DriverSpecificationID_int;
                Key = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                Key.DriverSpecificationID_int= _DriverSpecificationID;
                DriverCardNumber_nvcTextBox.Text = DriverSpecificationList[0].DriverCardNumber_nvc;
                FirstName_nvcTextBox.Text = DriverSpecificationList[0].FirstName_nvc;
                LastName_nvcTextBox.Text = DriverSpecificationList[0].LastName_nvc;
                NationalCode_intNumericTextBox.Text = Convert.ToString(DriverSpecificationList[0].NationalCode_int);
                licenceNumber_nvcTextBox.Text = DriverSpecificationList[0].licenceNumber_nvc;
                LicenceEnd_nvcTextBox.Text = DriverSpecificationList[0].LicenceEnd_nvc;
                ClassID_intComboBox.SelectedValue = DriverSpecificationList[0].ClassID_int.HasValue?DriverSpecificationList[0].ClassID_int:0;
                HealthCardEndDate_nvcTextBox.Text = DriverSpecificationList[0].HealthCardEndDate_nvc;
                DriverCardSharjeEndDate_nvcTextBox.Text = DriverSpecificationList[0].DriverCardSharjeEndDate_nvc;
                SaveAndCloseButton.Visible = false;
            }
            else
            {
                Editbutton.Visible = false;
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllBy(HPS.BLL.TrafficBLL.BLLTraffic_T.Traffic_TField.DriverCardNumber_nvc, _DriverCardNumber);
                if (TrafficList != null && TrafficList.Count > 0)
                {
                    DriverCardNumber_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].DriverCardNumber_nvc;
                    FirstName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].FirstName_nvc;
                    LastName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LastName_nvc;
                    NationalCode_intNumericTextBox.Text = Convert.ToString(TrafficList[TrafficList.Count - 1].NationalCode_int);
                    licenceNumber_nvcTextBox.Text = Convert.ToString(TrafficList[TrafficList.Count - 1].licenceNumber_int);
                }
                else
                {
                    HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                    List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList = DriverFactory.GetAllBy(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, _DriverCardNumber);
                    if (DriverList != null && DriverList.Count > 0)
                    {
                        DriverCardNumber_nvcTextBox.Text = DriverList[0].DriverCardNumber_nvc;
                        FirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                        LastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                        NationalCode_intNumericTextBox.Text = Convert.ToString(DriverList[0].NationalCode_int);
                        licenceNumber_nvcTextBox.Text = Convert.ToString(DriverList[0].licenceNumber_nvc);
                    }

                }
            }
        }

        private void LoadWithoutDriverCardNumber()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            DataTable DriverFieldTable = new DataTable();
            DriverSpecificationFactory.SelectByDriverField(_FirstName, _LastName, _NationalCode, ref DriverFieldTable);
            if (DriverFieldTable != null && DriverFieldTable.Rows.Count > 0)
            {
                _DriverSpecificationID = (Int32)DriverFieldTable.Rows[0]["DriverSpecificationID_int"];
                Key = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                Key.DriverSpecificationID_int = _DriverSpecificationID;
                DriverCardNumber_nvcTextBox.Text = DriverFieldTable.Rows[0]["DriverCardNumber_nvc"].ToString();
                FirstName_nvcTextBox.Text = DriverFieldTable.Rows[0]["FirstName_nvc"].ToString();
                LastName_nvcTextBox.Text = DriverFieldTable.Rows[0]["LastName_nvc"].ToString();
                NationalCode_intNumericTextBox.Text = DriverFieldTable.Rows[0]["NationalCode_int"].ToString();
                licenceNumber_nvcTextBox.Text = DriverFieldTable.Rows[0]["licenceNumber_nvc"].ToString();
               
                LicenceEnd_nvcTextBox.Text = DriverFieldTable.Rows[0]["LicenceEnd_nvc"].ToString();
                CarExaminationEndDate_nvcTextBox.Text = DriverFieldTable.Rows[0]["CarExaminationEndDate_nvc"].ToString();
              
                InsuranceEndDate_nvcTextBox.Text = DriverFieldTable.Rows[0]["InsuranceEndDate_nvc"].ToString();
                ClassID_intComboBox.SelectedValue = DriverFieldTable.Rows[0]["ClassID_int"];
                HealthCardEndDate_nvcTextBox.Text = DriverFieldTable.Rows[0]["HealthCardEndDate_nvc"].ToString();
                DriverCardSharjeEndDate_nvcTextBox.Text = DriverFieldTable.Rows[0]["DriverCardSharjeEndDate_nvc"].ToString();
              
            }
            else
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                string Condition = "Traffic_T.FirstName_nvc=N'" + _FirstName + "' AND Traffic_T.LastName_nvc=N'" + _LastName + "' AND Traffic_T.NationalCode_int='" + _NationalCode + "'";
                List<HPS.BLL.TrafficBLL.BLLTraffic_T> TrafficList = TrafficFactory.GetAllByCondition(Condition);
                if (TrafficList != null && TrafficList.Count > 0)
                {
                    DriverCardNumber_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].DriverCardNumber_nvc;
                    FirstName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].FirstName_nvc;
                    LastName_nvcTextBox.Text = TrafficList[TrafficList.Count - 1].LastName_nvc;
                    NationalCode_intNumericTextBox.Text = Convert.ToString(TrafficList[TrafficList.Count - 1].NationalCode_int);
                    licenceNumber_nvcTextBox.Text = Convert.ToString(TrafficList[TrafficList.Count - 1].licenceNumber_int);
                }
                else
                {
                    HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
                    List<HPS.BLL.DriverBLL.BLLDriver_T> DriverList = DriverFactory.GetAllBy(HPS.BLL.DriverBLL.BLLDriver_T.Driver_TField.DriverCardNumber_nvc, _DriverCardNumber);
                    if (DriverList != null && DriverList.Count > 0)
                    {
                        DriverCardNumber_nvcTextBox.Text = DriverList[0].DriverCardNumber_nvc;
                        FirstName_nvcTextBox.Text = DriverList[0].FirstName_nvc;
                        LastName_nvcTextBox.Text = DriverList[0].LastName_nvc;
                        NationalCode_intNumericTextBox.Text = Convert.ToString(DriverList[0].NationalCode_int);
                        licenceNumber_nvcTextBox.Text = Convert.ToString(DriverList[0].licenceNumber_nvc);
                    }

                }
            }

        }

        private void LoadWithCarCardNumber()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            List<HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T> DriverSpecificationList = DriverSpecificationFactory.GetAllBy(HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T.DriverSpecification_TField.DriverCardNumber_nvc, _DriverCardNumber);
            DriverSpecificationList = DriverSpecificationFactory.GetAllByCondition(string.Format(" CarCardNumber_nvc={0} ",_CarCardNumber));
            if (DriverSpecificationList != null && DriverSpecificationList.Count > 0)
            {
                _DriverSpecificationID = DriverSpecificationList[0].DriverSpecificationID_int;
                Key = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                Key.DriverSpecificationID_int = _DriverSpecificationID;

                CarExaminationEndDate_nvcTextBox.Text = DriverSpecificationList[0].CarExaminationEndDate_nvc;
                InsuranceEndDate_nvcTextBox.Text = DriverSpecificationList[0].InsuranceEndDate_nvc;
                SaveAndCloseButton.Visible = false;
            }
            else
                Editbutton.Visible = false;

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            if (_DriverSpecificationID!=null && _DriverSpecificationID!=0)
            {
                //Edit();
            }
            this.Close();
        }

        private void DriverControlbutton_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> DateEroorList = new List<string>();

                Hepsa.Core.Validation.TodayDateRule lisenceEndDateRule = new Hepsa.Core.Validation.TodayDateRule("LicenceEnd_nvc", "تاريخ اتمام گواهینامه");
                if (lisenceEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
                {
                    DateEroorList.Add(lisenceEndDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.TodayDateRule DriverCardSharjeStartTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
                if (DriverCardSharjeStartTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(DriverCardSharjeStartTodayDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.TodayDateRule HealthCardEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
                if (HealthCardEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(HealthCardEndTodayDateRule.Description + "\n");
                }

                ////////////add not null rule
                Hepsa.Core.Validation.NotNullRule lisenceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("LicenceEnd_nvc", "تاريخ اتمام گواهینامه");
                if (lisenceEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
                {
                    DateEroorList.Add(lisenceEndDateNotNullRule.Description + "\n");
                }

                Hepsa.Core.Validation.NotNullRule DriverCardSharjeStartDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند");
                if (DriverCardSharjeStartDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(DriverCardSharjeStartDateNotNullRule.Description + "\n");
                }

                Hepsa.Core.Validation.NotNullRule HealthCardEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت");
                if (HealthCardEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(HealthCardEndDateNotNullRule.Description + "\n");
                }

                Hepsa.Core.Validation.NotNullRule licenceNumberNotNullRule = new Hepsa.Core.Validation.NotNullRule("licenceNumber_int", "شماره گواهینامه");
                if (licenceNumberNotNullRule.Validate(licenceNumber_nvcTextBox.NumericText) == false)
                {
                    DateEroorList.Add(licenceNumberNotNullRule.Description + "\n");
                }

                ////////////add date rule
                Hepsa.Core.Validation.DateRule<string> LicenceEndDateRule = new Hepsa.Core.Validation.DateRule<string>("LicenceEnd_nvc", "تاريخ اتمام گواهینامه", null, null);
                if (LicenceEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(LicenceEnd_nvcTextBox)) == false)
                {
                    DateEroorList.Add(LicenceEndDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.DateRule<string> DriverCardSharjeStartDateRule = new Hepsa.Core.Validation.DateRule<string>("DriverCardSharjeStartDate_nvc", "تاريخ اتمام شارژ كارت هوشمند", null, null);
                if (DriverCardSharjeStartDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(DriverCardSharjeEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(DriverCardSharjeStartDateRule.Description + "\n");
                }

                Hepsa.Core.Validation.DateRule<string> HealthCardEndDateRule = new Hepsa.Core.Validation.DateRule<string>("HealthCardEndDate_nvc", "تاريخ اتمام اعتبار کارت سلامت", null, null);
                if (HealthCardEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(HealthCardEndDate_nvcTextBox)) == false)
                {
                    DateEroorList.Add(HealthCardEndDateRule.Description + "\n");
                }

                if (DateEroorList != null && DateEroorList.Count > 0)
                {
                    throw new ApplicationException(DateEroorList.Aggregate((i, j) => i + j));
                }


                DriverInformationSave();


            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        protected void DriverInformationSave()
        {
            HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
            try
            {
                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
                DriverSpecificationEntity.DriverCardNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(_DriverCardNumber, TypeCode.String).ToString();
                DriverSpecificationEntity.FirstName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(FirstName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.LastName_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LastName_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.NationalCode_int = (Int64)Hepsa.Core.Common.PersentationController.GetEntityValue(NationalCode_intNumericTextBox.NumericText, TypeCode.Int64);
                DriverSpecificationEntity.licenceNumber_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(licenceNumber_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.CarExamination_bit = false;
                DriverSpecificationEntity.LicenceEnd_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LicenceEnd_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.Insurance_bit = false;
                DriverSpecificationEntity.InsuranceStartDate_nvc = string.Empty;
                DriverSpecificationEntity.ClassID_int = (Int32?)Hepsa.Core.Common.PersentationController.GetEntityValue(ClassID_intComboBox.SelectedValue, TypeCode.Int32);
                DriverSpecificationEntity.HealthCard_bit = false;
                DriverSpecificationEntity.HealthCardStartDate_nvc = string.Empty;
                DriverSpecificationEntity.HealthCardEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(HealthCardEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.DriverCardSharje_bit = false;
                DriverSpecificationEntity.DriverCardSharjeStartDate_nvc = string.Empty;
                DriverSpecificationEntity.DriverCardSharjeEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(DriverCardSharjeEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                DriverSpecificationEntity.StatisticCard_bit = false;

                HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys driverSpecificationkey = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                if (_DriverSpecificationID != 0)
                {
                    driverSpecificationkey.DriverSpecificationID_int = _DriverSpecificationID;
                    DriverSpecificationFactory.BeginProc();
                    DriverSpecificationFactory.Update(DriverSpecificationEntity, driverSpecificationkey);
                    DriverSpecificationFactory.CommitProc();
                    Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                }
                else
                {
                    DriverSpecificationFactory.BeginProc();
                    DriverSpecificationFactory.Insert(DriverSpecificationEntity);
                    DriverSpecificationFactory.CommitProc();
                    Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                }

            }
            catch (Exception ex)
            {
                DriverSpecificationFactory.RollBackProc();
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }

        }

        private void CarControlButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_CarCardNumber))
                {
                    //HPS.Present.DriverSpecification.DriverSpecificationEntityForm frm = new HPS.Present.DriverSpecification.DriverSpecificationEntityForm(CarCardNumber_nvcTextBox.Text,false);
                    //frm.ShowDialog();

                    List<string> DateEroorList = new List<string>();


                    Hepsa.Core.Validation.TodayDateRule InsuranceEndDate_nvcRule = new Hepsa.Core.Validation.TodayDateRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
                    if (InsuranceEndDate_nvcRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(InsuranceEndDate_nvcRule.Description + "\n");
                    }

                    Hepsa.Core.Validation.TodayDateRule CarExaminationEndTodayDateRule = new Hepsa.Core.Validation.TodayDateRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
                    if (CarExaminationEndTodayDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(CarExaminationEndTodayDateRule.Description + "\n");
                    }

                    ////////////add not null rule

                    Hepsa.Core.Validation.NotNullRule InsuranceEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("InsuranceEndDate_nvc", "تاريخ اتمام بيمه");
                    if (InsuranceEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(InsuranceEndDateNotNullRule.Description + "\n");
                    }

                    Hepsa.Core.Validation.NotNullRule CarExaminationEndDateNotNullRule = new Hepsa.Core.Validation.NotNullRule("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه");
                    if (CarExaminationEndDateNotNullRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(CarExaminationEndDateNotNullRule.Description + "\n");
                    }

                    ////////////add date rule
                    Hepsa.Core.Validation.DateRule<string> InsuranceEndDateaDateRule = new Hepsa.Core.Validation.DateRule<string>("InsuranceEndDate_nvc", "تاريخ اتمام بيمه", null, null);
                    if (InsuranceEndDateaDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(InsuranceEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(InsuranceEndDateaDateRule.Description + "\n");
                    }

                    Hepsa.Core.Validation.DateRule<string> CarExaminationEndDateRule = new Hepsa.Core.Validation.DateRule<string>("CarExaminationEndDate_nvc", "تاريخ اتمام معاينه", null, null);
                    if (CarExaminationEndDateRule.Validate(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(CarExaminationEndDate_nvcTextBox)) == false)
                    {
                        DateEroorList.Add(CarExaminationEndDateRule.Description + "\n");
                    }

                    if (DateEroorList != null && DateEroorList.Count > 0)
                    {
                        throw new ApplicationException(DateEroorList.Aggregate((i, j) => i + j));
                    }

                    HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory DriverSpecificationFactory = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TFactory();
                    try
                    {
                        HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T DriverSpecificationEntity = new HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_T();
                        DriverSpecificationEntity.CarExamination_bit = false;
                        DriverSpecificationEntity.Insurance_bit = false;
                        DriverSpecificationEntity.HealthCard_bit = false;
                        DriverSpecificationEntity.DriverCardSharje_bit = false;
                        DriverSpecificationEntity.StatisticCard_bit = false;
                        DriverSpecificationEntity.CarCardNumber_nvc = _CarCardNumber;
                        DriverSpecificationEntity.CarExaminationEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(CarExaminationEndDate_nvcTextBox.Text, TypeCode.String).ToString();
                        DriverSpecificationEntity.InsuranceEndDate_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(InsuranceEndDate_nvcTextBox.Text, TypeCode.String).ToString();

                        HPS.BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys driverSpecificationkey = new BLL.DriverSpecificationBLL.BLLDriverSpecification_TKeys();
                        if (_DriverSpecificationID != 0)
                        {
                            driverSpecificationkey.DriverSpecificationID_int = _DriverSpecificationID;
                            DriverSpecificationFactory.BeginProc();
                            DriverSpecificationFactory.Update(DriverSpecificationEntity, driverSpecificationkey);
                            DriverSpecificationFactory.CommitProc();
                            Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                        }
                        else
                        {
                            DriverSpecificationFactory.BeginProc();
                            DriverSpecificationFactory.Insert(DriverSpecificationEntity);
                            DriverSpecificationFactory.CommitProc();
                            Hepsa.Core.Common.MessageBox.InformationMessage("اطلاعات ثبت شد");
                        }
                    }
                    catch (Exception ex)
                    {
                        DriverSpecificationFactory.RollBackProc();
                        Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                    }


                    //DriverInformationSave();
                }
                else
                    throw new ApplicationException("اطلاعات ناوگان خالی است");
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }   

    }
}