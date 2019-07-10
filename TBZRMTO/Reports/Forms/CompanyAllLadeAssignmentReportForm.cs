using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Reports.Forms
{
    public partial class CompanyAllLadeAssignmentedReport : Hepsa.Core.PL.BaseForm
    {
        public CompanyAllLadeAssignmentedReport()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string Condition = string.Empty;
            Condition = "LadeAssignment_T.Date_nvc>='" + FromDatefaDatePicker.Text + "' AND LadeAssignment_T.Date_nvc<='" + ToDatefaDatePicker.Text + "'";

            if (CompanyID_intComboBox.SelectedValue != null && (int)CompanyID_intComboBox.SelectedValue != 0)
            {
                Condition +=  " AND LadeAssignment_T.CompanyID_int=" + Convert.ToInt32(CompanyID_intComboBox.SelectedValue) ;
            }

            HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory LadeAssignmentFactory = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TFactory();
            CompanyAllLadeAssignmentedstiReport.Dictionary.Synchronize();
            CompanyAllLadeAssignmentedstiReport.Dictionary.Databases.Clear();
            CompanyAllLadeAssignmentedstiReport.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", Hepsa.Core.Common.ConnectionString.ConnectionString));
            CompanyAllLadeAssignmentedstiReport.Compile();
            CompanyAllLadeAssignmentedstiReport["organ"] = new HPS.BLL.SettingsBLL.BLLSetting_TFactory().GetBy(new BLL.SettingsBLL.BLLSetting_TKeys() { SettingID_int = 1029 }).Value_nvc.ToString();
            HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory PortPlaceFactory = new HPS.BLL.PortPlacesBLL.BLLPortPlaces_TFactory();
            CompanyAllLadeAssignmentedstiReport["FromDate_vc"] = FromDatefaDatePicker.Text;
            CompanyAllLadeAssignmentedstiReport["ToDate_vc"] = ToDatefaDatePicker.Text;
            CompanyAllLadeAssignmentedstiReport["Date_vc"] = PortPlaceFactory.ServerJalaliDate + "   " + PortPlaceFactory.ServerTime; ;
            CompanyAllLadeAssignmentedstiReport["UserName_vc"] = HPS.Common.CurrentUser.user.UserName_nvc;
            CompanyAllLadeAssignmentedstiReport["@Condition"] = Condition;
            CompanyAllLadeAssignmentedstiReport.Render();
            this.stiViewerControl1.Report = CompanyAllLadeAssignmentedstiReport;

        }
        HPS.BLL.CompanyBLL.BLLCompany_T CompanyEntity = new HPS.BLL.CompanyBLL.BLLCompany_T();
        private void CompanyID_intShowButton_Click(object sender, EventArgs e)
        {
            HPS.Present.SearchForm.CompanySearch frm = new HPS.Present.SearchForm.CompanySearch();
            frm.ShowDialog();
            if (frm != null)
            {
                CompanyEntity = frm.SelectedCompanyEntity;
                CompanyID_intComboBox.Text = frm.SelectedCompanyEntity.Company_nvc;
            }
        }
        DataTable CompanyID_intDataTable = new DataTable();
        private void CompanyID_intComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CompanyID_intComboBox.SelectedIndex != -1)
            {

                CompanyEntity.CompanyID_int = (Int32)CompanyID_intComboBox.SelectedValue;
                CompanyEntity.Company_nvc = CompanyID_intDataTable.Rows[Convert.ToInt32(CompanyID_intComboBox.SelectedIndex)]["Company_nvc"].ToString();
                //CompanyCode_nvcTextBox.Text = CompanyID_intDataTable.Rows[Convert.ToInt32(CompanyID_intComboBox.SelectedIndex)]["CompanyCode_nvc"].ToString();
            }
        }

        private void OutTrafficReportForm_Load(object sender, EventArgs e)
        {
            HPS.BLL.CompanyBLL.BLLCompany_TFactory CompanyID_intFactory = new HPS.BLL.CompanyBLL.BLLCompany_TFactory();

            string CompanyCondition = "[Company_T].[Active_bit]='true'";
            CompanyID_intFactory.GetAllByCondition(CompanyCondition, ref CompanyID_intDataTable);
            DataRow Companydr = CompanyID_intDataTable.NewRow();
            Companydr["CompanyID_int"] = 0;
            CompanyID_intDataTable.Rows.InsertAt(Companydr, 0);
            this.CompanyID_intComboBox.DisplayMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.Company_nvc.ToString();
            this.CompanyID_intComboBox.ValueMember = HPS.BLL.CompanyBLL.BLLCompany_T.Company_TField.CompanyID_int.ToString();
            this.CompanyID_intComboBox.DataSource = CompanyID_intDataTable;
            this.CompanyID_intComboBox.SelectedIndex = -1;


            this.FromDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(CompanyID_intFactory.ServerJalaliDate.ToString());
            this.ToDatefaDatePicker.SelectedDateTime = FarsiLibrary.Utils.PersianDateConverter.ToGregorianDateTime(CompanyID_intFactory.ServerJalaliDate.ToString());

        }
    }
}
