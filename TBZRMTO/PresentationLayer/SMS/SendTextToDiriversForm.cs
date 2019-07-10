using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.IO;

namespace HPS.Present.SMS
{
    public partial class SendTextToDiriversForm : Form
    {
        private HtmlDocument hdoc;

        public SendTextToDiriversForm()
        {
            InitializeComponent();
            
       
        }

        private void SendTextToDiriversForm_Load(object sender, EventArgs e)
        {
            this.CreateFilterCompanent();
        }

        private void LoadDrivers()
        {
            HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
            DataTable DriverDataTable = new DataTable();
            string Condition = string.Empty;
            TrafficFactory.SelectDriverMobile_nvc(Condition,ref DriverDataTable);
             DriverDataTable.Columns.Add(new DataColumn("Checked_bit", Type.GetType("System.Boolean")));
            DriverDataTable.Columns["Checked_bit"].AllowDBNull = true;
            DriverDataTable.Columns["Checked_bit"].DefaultValue = false;
            this.DriversdataGridView.AutoGenerateColumns = false;
            this.DriversdataGridView.DataSource = DriverDataTable;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = (DataTable)this.DriversdataGridView.DataSource;
            Dt.DefaultView.RowFilter = String .Format("FullName_nvc Like '%{0}%'",DriverSearchtextBox.Text );  
        }

        private void DriverSelectButton_Click(object sender, EventArgs e)
        {
            DataTable Driverdt =(DataTable)this.DriversdataGridView.DataSource ;
            if (this.DriversdataGridView.RowCount > 0)
            {
                foreach (DataRow row in Driverdt.Rows )
                {
                    if (row["Checked_bit"].ToString() == "True")
                    {
                        row["Checked_bit"] = false;
                    }
                    else
                    {
                        row["Checked_bit"] = true;
                    }
                }
            }
            Driverdt.AcceptChanges();
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            DataTable SelectedDriver = new DataTable();
            SelectedDriver = (DataTable)this.DriversdataGridView.DataSource;
            if (SelectedDriver != null)
            {
                DataRow[] Row = SelectedDriver.Select("Checked_bit = 'True'");
                if (Row != null && Row.Length > 0)
                {
                    HPS.Present.SMS.LogintoSmsSystemForm frm = new LogintoSmsSystemForm();
                    frm.ShowDialog();
                    if (frm.True_bit)
                    {
                        System.IO.FileStream source = new System.IO.FileStream(@"index.html", System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        WebBrowser webBrowser1 = new WebBrowser();
                        webBrowser1.DocumentStream = source;
                        string sourceText = string.Empty;
                        using (StreamReader sourceReader = new StreamReader(source))
                        {
                            sourceText = sourceReader.ReadToEnd();
                        }
                        webBrowser1.Document.Write(sourceText);
                        var htmlElements = webBrowser1.Document.GetElementById("btnSubmit");

                        hdoc = webBrowser1.Document;

                        String Pass = string.Empty;
                        string UserName = string.Empty;
                        HPS.BLL.SettingsBLL.BLLSetting_TFactory SettingFactory = new HPS.BLL.SettingsBLL.BLLSetting_TFactory();
                        HPS.BLL.SettingsBLL.BLLSetting_TKeys SettingKey = new HPS.BLL.SettingsBLL.BLLSetting_TKeys();
                        HPS.BLL.SettingsBLL.BLLSetting_T SettingEntity = new HPS.BLL.SettingsBLL.BLLSetting_T();
                        SettingKey.SettingID_int = 1005;
                        SettingEntity = SettingFactory.GetBy(SettingKey);
                        UserName = SettingEntity.Value_nvc;
                        SettingKey.SettingID_int = 1006;
                        SettingEntity = SettingFactory.GetBy(SettingKey);
                        Pass = SettingEntity.Value_nvc;
                        sourceText = string.Format(sourceText, UserName, Pass);
                        String MessegeText = string.Empty;
                        string MobileList = string.Empty;


                        foreach (DataRow rw in Row)
                        {
                            MobileList = string.Format("{0},{1}", MobileList, rw["DriverMobileNumber_nvc"].ToString());
                        }
                        MessegeText = this.MessageTextrichTextBox.Text;
                        if (MobileList.Length > 0)
                        {
                            if (MobileList.Substring(0, 1) == ",")
                            {
                                MobileList = MobileList.Substring(1, MobileList.Length - 1);
                            }
                        }

                        hdoc.GetElementById("mobilenumber").SetAttribute("value", MobileList);
                        hdoc.GetElementById("message").SetAttribute("value", MessegeText.ToString());
                        hdoc.GetElementById("btnSubmit").InvokeMember("click");
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    Hepsa.Core.Common.MessageBox.ErrorMessage(HPS.Exceptions.ExceptionCs.DriverIsNotChosen);
                }
            }
        }

        private void CreateFilterCompanent()
        {
            DataTable FildNameDataTable = new DataTable();
            FildNameDataTable.Columns.Add("FieldName", System.Type.GetType("System.String"));
            FildNameDataTable.Columns.Add("TitleName", System.Type.GetType("System.String"));
            DataRow dr = FildNameDataTable.NewRow();
            dr["FieldName"] = "FirstName_nvc";
            dr["TitleName"] = "نام";
            FildNameDataTable.Rows.Add(dr);
            dr = FildNameDataTable.NewRow();
            dr["FieldName"] = "LastName_nvc";
            dr["TitleName"] = "نام خانوادگی";
            FildNameDataTable.Rows.Add(dr);
            dr = FildNameDataTable.NewRow();
            dr["FieldName"] = "Mobile_nvc";
            dr["TitleName"] = "شماره موبایل";
            FildNameDataTable.Rows.Add(dr);
            dr = FildNameDataTable.NewRow();
            dr["FieldName"] = "NationalCode_int";
            dr["TitleName"] = "کد ملی";
            FildNameDataTable.Rows.Add(dr);
            dr = FildNameDataTable.NewRow();
            dr["FieldName"] = "DriverCardNumber_nvc";
            dr["TitleName"] = "شماره کارت";
            FildNameDataTable.Rows.Add(dr);
            this.FieldNamecomboBox.DisplayMember = "TitleName";
            this.FieldNamecomboBox.ValueMember = "FieldName";
            this.FieldNamecomboBox.DataSource = FildNameDataTable;
            this.FieldNamecomboBox.SelectedIndex = -1;


            DataTable OperatorDataTable = new DataTable();
            OperatorDataTable.Columns.Add("FieldName", System.Type.GetType("System.String"));
            OperatorDataTable.Columns.Add("TitleName", System.Type.GetType("System.String"));
            DataRow Operatordr = OperatorDataTable.NewRow();
            Operatordr["FieldName"] = " = '{0}'";
            Operatordr["TitleName"] = "مساوی";
            OperatorDataTable.Rows.Add(Operatordr);
            Operatordr = OperatorDataTable.NewRow();
            Operatordr["FieldName"] = " Like N'%{0}%'";
            Operatordr["TitleName"] = "شامل";
            OperatorDataTable.Rows.Add(Operatordr);
            Operatordr = OperatorDataTable.NewRow();
            Operatordr["FieldName"] = " Not Like N'%{0}%'";
            Operatordr["TitleName"] = "ناشامل";
            OperatorDataTable.Rows.Add(Operatordr);
            Operatordr = OperatorDataTable.NewRow();
            Operatordr["FieldName"] = " < '{0}'";
            Operatordr["TitleName"] = "کوچکتر";
            OperatorDataTable.Rows.Add(Operatordr);
            Operatordr = OperatorDataTable.NewRow();
            Operatordr["FieldName"] = " > '{0}'";
            Operatordr["TitleName"] = "بزرگتر";
            OperatorDataTable.Rows.Add(Operatordr);
            this.OperatorcomboBox.DisplayMember = "TitleName";
            this.OperatorcomboBox.ValueMember = "FieldName";
            this.OperatorcomboBox.DataSource = OperatorDataTable;
            this.OperatorcomboBox.SelectedIndex = -1;


        }

        private void ShowAllbutton_Click(object sender, EventArgs e)
        {
            this.LoadDrivers();

        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            if (FieldNamecomboBox.SelectedIndex != -1 && OperatorcomboBox.SelectedIndex != -1 && string.IsNullOrEmpty(SearchtextBox.Text) == false)
            {
                HPS.BLL.TrafficBLL.BLLTraffic_TFactory TrafficFactory = new HPS.BLL.TrafficBLL.BLLTraffic_TFactory();
                DataTable DriverDataTable = new DataTable();
                String Condition = string.Empty;
                Condition = string.Format("{0} {1}", FieldNamecomboBox.SelectedValue.ToString(), OperatorcomboBox.SelectedValue.ToString());
                Condition = string.Format(Condition, SearchtextBox.Text);
                TrafficFactory.SelectDriverMobile_nvc(Condition, ref DriverDataTable);
                DriverDataTable.Columns.Add(new DataColumn("Checked_bit", Type.GetType("System.Boolean")));
                DriverDataTable.Columns["Checked_bit"].AllowDBNull = true;
                DriverDataTable.Columns["Checked_bit"].DefaultValue = false;
                this.DriversdataGridView.AutoGenerateColumns = false;
                this.DriversdataGridView.DataSource = DriverDataTable;
            }
        }


    }
}
