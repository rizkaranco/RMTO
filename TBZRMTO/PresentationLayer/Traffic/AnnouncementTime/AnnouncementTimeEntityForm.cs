using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.AnnouncementTime
{
    public partial class AnnouncementTimeEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public AnnouncementTimeEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public AnnouncementTimeEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void AnnouncementTimeEntityForm_Load(object sender, EventArgs e)
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
            this.FillCombo();
            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();
            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T AnnouncementTimeEntity = AnnouncementTimeFactory.GetBy((HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys)Key);
            if (AnnouncementTimeEntity == null)
            {
                throw new HPS.Exceptions.AnnouncementTimeNotFound();
            }
            AnnouncementTime_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(AnnouncementTimeEntity.AnnouncementTime_nvc, TypeCode.String).ToString();
            StartTime_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(AnnouncementTimeEntity.StartTime_nvc, TypeCode.String).ToString();
            EndTime_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(AnnouncementTimeEntity.EndTime_nvc, TypeCode.String).ToString();

        }

        protected override void Insert()
        {
            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();
            try
            {
                HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T AnnouncementTimeEntity = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T();
                AnnouncementTimeEntity.AnnouncementTime_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(AnnouncementTime_nvcTextBox.Text, TypeCode.String).ToString();
                AnnouncementTimeEntity.StartTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(StartTime_nvcTextBox).ToString();
                AnnouncementTimeEntity.EndTime_nvc = Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(EndTime_nvcTextBox).ToString();

                AnnouncementTimeFactory.BeginProc();
                AnnouncementTimeFactory.Insert(AnnouncementTimeEntity);
                AnnouncementTimeFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTimeID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.AnnouncementTimeID_int, TypeCode.Int32);
                    dr[HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.AnnouncementTime_nvc, TypeCode.String);
                    dr[HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.StartTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.StartTime_nvc, TypeCode.String);
                    dr[HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.EndTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.EndTime_nvc, TypeCode.String);

                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                AnnouncementTimeFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();
            try
            {
                HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T AnnouncementTimeEntity = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T();
                AnnouncementTimeEntity.AnnouncementTime_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(AnnouncementTime_nvcTextBox.Text, TypeCode.String).ToString();
                AnnouncementTimeEntity.StartTime_nvc =Convert.ToString(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(StartTime_nvcTextBox));
                AnnouncementTimeEntity.EndTime_nvc =Convert.ToString(Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(EndTime_nvcTextBox));

                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    AnnouncementTimeFactory.BeginProc();
                    AnnouncementTimeFactory.Update(AnnouncementTimeEntity, (HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys)Key);
                    AnnouncementTimeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTimeID_int.ToString() + "='" + ((HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys)Key).AnnouncementTimeID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.AnnouncementTime_nvc, TypeCode.String);
                            dr[0][HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.StartTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.StartTime_nvc, TypeCode.String);
                            dr[0][HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.EndTime_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(AnnouncementTimeEntity.EndTime_nvc, TypeCode.String);

                        }
                        DataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                AnnouncementTimeFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory AnnouncementTimeFactory = new HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    AnnouncementTimeFactory.BeginProc();
                    AnnouncementTimeFactory.Delete((HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys)Key);
                    AnnouncementTimeFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_T.AnnouncementTime_TField.AnnouncementTimeID_int.ToString() + "='" + ((HPS.BLL.AnnouncementTimeBLL.BLLAnnouncementTime_TKeys)Key).AnnouncementTimeID_int.ToString() + "'");
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
                AnnouncementTimeFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}