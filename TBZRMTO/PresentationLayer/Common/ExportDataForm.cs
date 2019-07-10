using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace HPS.Present.Common
{
    public partial class ExportDataForm : Hepsa.Core.PL.BaseForm
    {
        private string BasicDataFilePath = string.Empty;
        private string CarFilePath = string.Empty;
        private string DriverFilePath = string.Empty;
        private string CarTableName = string.Empty;
        private string DriverTableName = string.Empty;

        public ExportDataForm()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string rootpath = System.IO.Directory.GetCurrentDirectory();
               
                if (string.IsNullOrEmpty(this.BasicDataFilePathTextBox.Text) == false)
                {
                    System.IO.FileInfo f = new System.IO.FileInfo(this.BasicDataFilePathTextBox.Text);
                    if (!f.Exists)
                        throw new ApplicationException(string.Format(HPS.Exceptions.ExceptionCs.FileNotExists, "اطلاعات پایه"));
                    if (string.IsNullOrEmpty(this.BasicDataFilePath))
                    {
                       // this.BasicDataFilePath = string.Format(@"\\{0}\ImportDataFile\BasicData.mdb", (Hepsa.Core.Common.ConnectionString.Server == "." ? System.Environment.MachineName : Hepsa.Core.Common.ConnectionString.Server));
                        this.BasicDataFilePath = string.Format(@"{0}\ImportDataFile\BasicData.mdb", rootpath);
                        System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo(BasicDataFilePath);
                        System.IO.FileInfo tempFile = new System.IO.FileInfo(BasicDataFilePath);
                        if (tempFile.Exists)
                        {
                            System.IO.FileInfo[] fileList = DI.GetFiles("*.mdb");
                            foreach (System.IO.FileInfo fi in fileList)
                                fi.Delete();
                        }
                        
                        f.CopyTo(BasicDataFilePath, true);
                    }
                    if (this.LaderTypeComboBox.SelectedIndex > 0)
                    {
                        this.TransferLaderType(this.BasicDataFilePath, this.LaderTypeComboBox.Text);
                    }
                    if (this.BoxingComboBox.SelectedIndex > 0)
                    {
                        this.TransferBoxing(this.BasicDataFilePath, this.BoxingComboBox.Text);
                    }
                    if (this.CityComboBox.SelectedIndex > 0)
                    {
                        this.TransferCity(this.BasicDataFilePath, this.CityComboBox.Text);
                    }
                    if (this.GoodComboBox.SelectedIndex > 0)
                    {
                        this.TransferGood(this.BasicDataFilePath, this.GoodComboBox.Text);
                    }
                    if (this.PlateCityComboBox.SelectedIndex > 0)
                    {
                        this.TransferPlateCity(this.BasicDataFilePath, this.PlateCityComboBox.Text);
                    }
                }
                if (string.IsNullOrEmpty(this.CarFilePathTextBox.Text) == false)
                {
                    CarFilePath = string.Empty;
                    System.IO.FileInfo f = new System.IO.FileInfo(this.CarFilePathTextBox.Text);
                    if (!f.Exists)
                        throw new ApplicationException(string.Format(HPS.Exceptions.ExceptionCs.FileNotExists, "اطلاعات ناوگان"));
                    if (string.IsNullOrEmpty(this.CarFilePath))
                    {
                        //this.CarFilePath = string.Format(@"{0}\ImportDataFile\CarData.mdb", (Hepsa.Core.Common.ConnectionString.Server == "." ? System.Environment.MachineName : Hepsa.Core.Common.ConnectionString.Server));
                        this.CarFilePath = string.Format(@"{0}\ImportDataFile\CarData.mdb", rootpath);
                        System.IO.FileInfo tempFile = new System.IO.FileInfo(CarFilePath);
                        //System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo(string.Format(@"\\{0}\ImportDataFile\", (Hepsa.Core.Common.ConnectionString.Server == "." ? System.Environment.MachineName : Hepsa.Core.Common.ConnectionString.Server)));
                        System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo(CarFilePath);
                        if (tempFile.Exists)
                        {
                            //System.IO.FileInfo[] fileList = DI.GetFiles("*.mdb");
                            //string[] filePaths = Directory.GetFiles(CarFilePath, "*.mdb");
                            tempFile.Delete();
                            //foreach (System.IO.FileInfo fi in fileList)
                            //    fi.Delete();
                            
                        }
                        
                    }
                    f.CopyTo(this.CarFilePath, true);
                    this.DeleteTransferCarData(this.CarFilePath, this.CarTableName);
                    this.TransferCar(CarFilePath, this.CarTableName);
                }
                if (string.IsNullOrEmpty(this.DriverFilePathTextBox.Text) == false)
                {
                    System.IO.FileInfo f = new System.IO.FileInfo(this.DriverFilePathTextBox.Text);
                    if (!f.Exists)
                        throw new ApplicationException(string.Format(HPS.Exceptions.ExceptionCs.FileNotExists, "اطلاعات رانندگان"));
                 
                    if (string.IsNullOrEmpty(this.DriverFilePath))
                    {
                        //this.DriverFilePath = string.Format(@"\\{0}\ImportDataFile\DriverData.mdb", (Hepsa.Core.Common.ConnectionString.Server == "." ? System.Environment.MachineName : Hepsa.Core.Common.ConnectionString.Server));
                        this.DriverFilePath = string.Format(@"{0}\ImportDataFile\DriverData.mdb", rootpath);
                        System.IO.FileInfo tempFile = new System.IO.FileInfo(DriverFilePath);
                        System.IO.DirectoryInfo DI = new System.IO.DirectoryInfo(DriverFilePath);
                        if (tempFile.Exists)
                        {
                            //System.IO.FileInfo[] fileList = DI.GetFiles("*.mdb");
                            //foreach (System.IO.FileInfo fi in fileList)
                            tempFile.Delete();
                        }
                        f.CopyTo(this.DriverFilePath, true);
                        this.DeleteTransferData(this.DriverFilePath, this.DriverTableName);
                        this.TransferDriver(this.DriverFilePath, this.DriverTableName);
                    }
                }
                Hepsa.Core.Common.MessageBox.CompleteSuccessfulMessage();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void BasicDataBrowsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Microsoft Office Access (*.mdb)|*.mdb";
            if (dlg.ShowDialog() == DialogResult.OK && this.BasicDataFilePathTextBox.Text != dlg.FileName)
            {
                this.BasicDataFilePathTextBox.Text = dlg.FileName;
                this.BasicDataFilePath = string.Empty;
                List<string> TableList = this.GetTableList(this.BasicDataFilePathTextBox.Text);
                this.LaderTypeComboBox.Items.Clear();
                this.BoxingComboBox.Items.Clear();
                this.CityComboBox.Items.Clear();
                this.GoodComboBox.Items.Clear();
                this.PlateCityComboBox.Items.Clear();
                foreach (string tbl in TableList)
                {
                    this.LaderTypeComboBox.Items.Add(tbl);
                    this.BoxingComboBox.Items.Add(tbl);
                    this.CityComboBox.Items.Add(tbl);
                    this.GoodComboBox.Items.Add(tbl);
                    this.PlateCityComboBox.Items.Add(tbl);
                }
            }
        }

        private void DriverBrowsButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Microsoft Office Access (*.mdb)|*.mdb";
                if (dlg.ShowDialog() == DialogResult.OK && this.DriverFilePathTextBox.Text != dlg.FileName)
                {
                    this.DriverFilePathTextBox.Text = dlg.FileName;
                    this.DriverFilePath = string.Empty;
                    List<string> TableList = this.GetTableList(this.DriverFilePathTextBox.Text);
                    if (TableList != null && TableList.Count > 1)
                        this.DriverTableName = TableList[1];
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void CarBrowsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Microsoft Office Access (*.mdb)|*.mdb";
            if (dlg.ShowDialog() == DialogResult.OK && this.CarFilePathTextBox.Text != dlg.FileName)
            {
                this.CarFilePathTextBox.Text = dlg.FileName;
                this.CarFilePath = string.Empty;
                List<string> TableList = this.GetTableList(this.CarFilePathTextBox.Text);
                if (TableList != null && TableList.Count > 1)
                    this.CarTableName = TableList[1];
            }
        }

        private void BasicDataClearButton_Click(object sender, EventArgs e)
        {
            this.BasicDataFilePathTextBox.Clear();
            this.BasicDataFilePath = string.Empty;
            this.LaderTypeComboBox.Items.Clear();
            this.BoxingComboBox.Items.Clear();
            this.CityComboBox.Items.Clear();
            this.GoodComboBox.Items.Clear();
            this.PlateCityComboBox.Items.Clear();
        }

        private void DriverClearButton_Click(object sender, EventArgs e)
        {
            this.DriverFilePathTextBox.Clear();
            this.DriverFilePath = string.Empty;
            this.DriverTableName = string.Empty;
        }

        private void CarClearButton_Click(object sender, EventArgs e)
        {
            this.CarFilePathTextBox.Clear();
            this.CarFilePath = string.Empty;
            this.CarTableName = string.Empty;
        }

        private List<string> GetTableList(string FilePath)
        {
            string ConnectionString = string.Format("Provider=Microsoft.jet.OLEDB.4.0;Data Source='{0}'", FilePath);
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                dt = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" });
                connection.Close();
                List<string> TableList = new List<string>();
                TableList.Add("");
                foreach (DataRow row in dt.Rows)
                    TableList.Add((string)Hepsa.Core.Common.PersentationController.GetEntityValue(row["Table_Name"], TypeCode.String));
                return TableList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
                connection.Dispose();

            }
        }

        private void TransferLaderType(string FilePath, string TableName)
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            try
            {
                LaderTypeFactory.BeginProc();
                LaderTypeFactory.TransferData(FilePath, TableName);
                LaderTypeFactory.CommitProc();
            }
            catch (Exception ex)
            {
                LaderTypeFactory.RollBackProc();
                throw ex;
            }
        }

        private void TransferBoxing(string FilePath, string TableName)
        {
            HPS.BLL.BoxingBLL.BLLBoxing_TFactory BoxingFactory = new HPS.BLL.BoxingBLL.BLLBoxing_TFactory();
            try
            {
                BoxingFactory.BeginProc();
                BoxingFactory.TransferData(FilePath, TableName);
                BoxingFactory.CommitProc();
            }
            catch (Exception ex)
            {
                BoxingFactory.RollBackProc();
                throw ex;
            }
        }

        private void TransferCity(string FilePath, string TableName)
        {
            HPS.BLL.CityBLL.BLLCity_TFactory CityFactory = new HPS.BLL.CityBLL.BLLCity_TFactory();
            try
            {
                CityFactory.BeginProc();
                CityFactory.TransferData(FilePath, TableName);
                CityFactory.CommitProc();
            }
            catch (Exception ex)
            {
                CityFactory.RollBackProc();
                throw ex;
            }
        }

        private void TransferGood(string FilePath, string TableName)
        {
            HPS.BLL.GoodBLL.BLLGood_TFactory GoodFactory = new HPS.BLL.GoodBLL.BLLGood_TFactory();
            try
            {
                GoodFactory.BeginProc();
                GoodFactory.TransferData(FilePath, TableName);
                GoodFactory.CommitProc();
            }
            catch (Exception ex)
            {
                GoodFactory.RollBackProc();
                throw ex;
            }
        }

        private void TransferPlateCity(string FilePath, string TableName)
        {
            HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory PlateCityFactory = new HPS.BLL.PlateCityBLL.BLLPlateCity_TFactory();
            try
            {
                PlateCityFactory.BeginProc();
                PlateCityFactory.TransferData(FilePath, TableName);
                PlateCityFactory.CommitProc();
            }
            catch (Exception ex)
            {
                PlateCityFactory.RollBackProc();
                throw ex;
            }
        }

        private void TransferCar(string FilePath, string TableName)
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            try
            {
                CarFactory.CommitProc();
                CarFactory.TransferData(FilePath, TableName);
                CarFactory.CommitProc();
            }
            catch (Exception ex)
            {
                CarFactory.RollBackProc();
                throw ex;
            }
        }

        private void TransferDriver(string FilePath, string TableName)
        {
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            try
            {
                DriverFactory.CommitProc();
                DriverFactory.TransferData(FilePath, TableName);
                DriverFactory.CommitProc();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DeleteTransferData(string FilePath, string TableName)
        {
            HPS.BLL.DriverBLL.BLLDriver_TFactory DriverFactory = new HPS.BLL.DriverBLL.BLLDriver_TFactory();
            try
            {
                DriverFactory.DeleteTransferData(FilePath, TableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DeleteTransferCarData(string FilePath, string TableName)
        {
            HPS.BLL.CarBLL.BLLCar_TFactory CarFactory = new HPS.BLL.CarBLL.BLLCar_TFactory();
            try
            {
                CarFactory.DeleteTransferCarData(FilePath, TableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
