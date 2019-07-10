using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LadeAssignment
{
    public partial class LadeAssignmentAcceptForm : Hepsa.Core.PL.BaseForm
    {
        private Int64 LadeAsssignmentID=0;
        private DataTable _DataTable;
        public LadeAssignmentAcceptForm(Int64 LadeAssignmentID_bint,DataTable DataTable)
        {
            InitializeComponent();
            this.LadeAsssignmentID = LadeAssignmentID_bint;
            this._DataTable = DataTable;
        }
        HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys LadeAssignmentKeys = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys();

        private void LadeAssignmentAcceptForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            LadeAssignmentKeys.LadeAssignmentID_bint = (Int64?)Hepsa.Core.Common.PersentationController.GetEntityValue(LadeAsssignmentID, TypeCode.Int64);
            DataTable LadeAssignmentDataTable=new DataTable();
            LadeAssignmentFactory.GetBy(LadeAssignmentKeys,ref LadeAssignmentDataTable);
            
            LadingDate_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["LadingDate_nvc"].ToString();
            LadingTime_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["LadingTime_nvc"].ToString();
            City_vncTextBox.Text = LadeAssignmentDataTable.Rows[0]["CityID_intCity_nvc"].ToString();
            CityCode_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["CityCode_nvc"].ToString();
            Good_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["GoodID_intGood_nvc"].ToString();
           // GoodCode_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["GoodCode_nvc"].ToString();
            Boxing_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["BoxingID_intBoxingType_nvc"].ToString();
          //  BoxingCode_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["BoxingCode_nvc"].ToString();
          //  LaderType_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["LaderTypeID_intLaderType_nvc"].ToString();
         //   LaderTypeCode_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["LaderTypeCode_nvc"].ToString();
            CarCount_intNumericTextBox.Text = LadeAssignmentDataTable.Rows[0]["CarCount_int"].ToString();
            Company_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["CompanyID_intCompany_nvc"].ToString();
           // CompanyCode_nvcTextBox.Text = LadeAssignmentDataTable.Rows[0]["CompanyCode_nvc"].ToString();


        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T LadeAssignmentEntity = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                LadeAssignmentEntity = LadeAssignmentFactory.GetBy(LadeAssignmentKeys);
                if (LadeAssignmentEntity == null)
                {
                    throw new HPS.Exceptions.LadeAssignmentNotFound();
                }
                LadeAssignmentEntity.Accepted_bit = true;
                LadeAssignmentFactory.BeginProc();
                LadeAssignmentFactory.Update(LadeAssignmentEntity, LadeAssignmentKeys);
                LadeAssignmentFactory.CommitProc();



                if (this._DataTable != null)
                {
                    DataRow[] dr = this._DataTable.Select("LadeAssignmentID_bint=" + this.LadeAsssignmentID.ToString());
                    if (dr != null && dr.Length > 0)
                    {
                        dr[0].Delete();
                        this._DataTable.AcceptChanges();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }
    }
}
