using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.Computer
{
    public partial class ComputerManyEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public string _MacAddress_nvc { get; set; }
        public ComputerManyEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public ComputerManyEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.ComputerBLL.BLLComputer_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
            
        }
        

        
        private void ComputerEntityForm_Load(object sender, EventArgs e)
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
            HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
            HPS.BLL.ComputerBLL.BLLComputer_T ComputerEntity = ComputerFactory.GetBy((HPS.BLL.ComputerBLL.BLLComputer_TKeys)Key);
            if (ComputerEntity == null)
            {
                throw new HPS.Exceptions.ComputerNotFound();
            }
            MessageLED_nvcTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerEntity.MessageLED_nvc, TypeCode.String).ToString();
            IPTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerEntity.IPAddress_nvc, TypeCode.String).ToString();
            MacTextBox.Text = Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerEntity.MacAddress_nvc, TypeCode.String).ToString();
            Active_bitCheckBox.Checked = (Boolean)Hepsa.Core.Common.PersentationController.GetEntityValue(ComputerEntity.Active_bit, TypeCode.Boolean);

           List<HPS.BLL.ComputerBLL.BLLComputer_T> ComputerList = new List<HPS.BLL.ComputerBLL.BLLComputer_T>();
            ComputerList = ComputerFactory.GetAllByCondition(string.Format(" Computer_T.MacAddress_nvc='{0}' AND Deleted_bit=0", _MacAddress_nvc));

            if (ComputerList.Count>0)
            {
                foreach (var item in ComputerList)
                {
                    foreach (var gridRow in UserNameGridView.GetRows())
                    {
                        if (item.Computer_nvc==gridRow.Cells["username_nvc"].Value.ToString())
                        {
                            gridRow.IsChecked = true;
                        }
                    }
                }
            }
          

           
        }

        protected override void Insert()
        {
            HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
            try
            {
                HPS.BLL.ComputerBLL.BLLComputer_T ComputerEntity = new HPS.BLL.ComputerBLL.BLLComputer_T();
                List<BLL.ComputerBLL.BLLComputer_T> ComputerList = new List<BLL.ComputerBLL.BLLComputer_T>();
                ComputerList = ComputerFactory.GetAllByCondition("MacAddress_nvc=N'" + MacTextBox.Text + "'");
                BLL.ComputerBLL.BLLComputer_TKeys ComputerKey = new BLL.ComputerBLL.BLLComputer_TKeys();
                foreach (Janus.Windows.GridEX.GridEXRow item in UserNameGridView.GetCheckedRows())
                {
                    if (ComputerList.Find(a => a.Computer_nvc == item.Cells["username_nvc"].Value.ToString()&& a.Deleted_bit==false && a.MacAddress_nvc== MacTextBox.Text)  == null)
                    {
                        ComputerEntity.ComputerID_int = null;
                        ComputerEntity.Computer_nvc = item.Cells["username_nvc"].Value.ToString();
                        ComputerEntity.IPAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(IPTextBox.Text, TypeCode.String).ToString();
                        ComputerEntity.MacAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MacTextBox.Text, TypeCode.String).ToString();
                        ComputerEntity.MessageLED_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageLED_nvcTextBox.Text, TypeCode.String).ToString();
                        ComputerEntity.Active_bit = Active_bitCheckBox.Checked;
                        ComputerEntity.UserGroupID_int = (Int32)item.Cells["UserGroupID_int"].Value;
                        ComputerFactory.BeginProc();
                        ComputerFactory.Insert(ComputerEntity);
                        ComputerFactory.CommitProc();
                    }
                }
                //if (DataTable != null)
                //{
                //    DataRow dr = this.DataTable.NewRow();
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.ComputerID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ComputerEntity.ComputerID_int, TypeCode.Int32);
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.Computer_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ComputerEntity.Computer_nvc, TypeCode.String);
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.IPAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValue(IPTextBox.Text, TypeCode.String).ToString();
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.MacAddress_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValue(MacTextBox.Text, TypeCode.String).ToString();
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.MessageLED_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ComputerEntity.MessageLED_nvc, TypeCode.String);
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ComputerEntity.Active_bit, TypeCode.Boolean);
                //    dr[HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(ComputerEntity.UserGroupID_int, TypeCode.Int32);
                //    dr["UserGroupID_intUserGroup_nvc"] = Hepsa.Core.Common.PersentationController.GetComboBoxDisplayMember(UserGroupID_intComboBox);

                //    DataTable.Rows.Add(dr);
                //    DataTable.AcceptChanges();
                //}
                //this.ClearForm(this);
            }

            catch (Exception ex)
            {
                ComputerFactory.RollBackProc();
                throw ex;
            }
            this.DialogResult = DialogResult.OK;
        }

        protected override void Edit()
        {
            HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();
            List<BLL.ComputerBLL.BLLComputer_T> ComputerList = new List<BLL.ComputerBLL.BLLComputer_T>();
            ComputerList = ComputerFactory.GetAllByCondition("MacAddress_nvc=N'" + MacTextBox.Text + "'");
            BLL.ComputerBLL.BLLComputer_TKeys ComputerKey = new BLL.ComputerBLL.BLLComputer_TKeys();
            foreach (BLL.ComputerBLL.BLLComputer_T item in ComputerList)
            {
               item.Deleted_bit = true;
                ComputerKey.ComputerID_int = item.ComputerID_int;
                ComputerFactory.Update(item, ComputerKey);
            }
            try
            {
                HPS.BLL.ComputerBLL.BLLComputer_T ComputerEntity = new HPS.BLL.ComputerBLL.BLLComputer_T();
                foreach (Janus.Windows.GridEX.GridEXRow item in UserNameGridView.GetCheckedRows())
                {
                    ComputerEntity.ComputerID_int = null;
                    ComputerEntity.Computer_nvc = item.Cells["username_nvc"].Value.ToString();
                    ComputerEntity.IPAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(IPTextBox.Text, TypeCode.String).ToString();
                    ComputerEntity.MacAddress_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MacTextBox.Text, TypeCode.String).ToString();
                    ComputerEntity.MessageLED_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(MessageLED_nvcTextBox.Text, TypeCode.String).ToString();
                    ComputerEntity.Active_bit = Active_bitCheckBox.Checked;
                    ComputerEntity.UserGroupID_int =(Int32)item.Cells["UserGroupID_int"].Value;
                    ComputerFactory.BeginProc();
                    ComputerFactory.Insert(ComputerEntity);
                    ComputerFactory.CommitProc();
                }
            }
            catch (Exception ex)
            {
                ComputerFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.ComputerBLL.BLLComputer_TFactory ComputerFactory = new HPS.BLL.ComputerBLL.BLLComputer_TFactory();

            try
            {
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.DeleteMessage) == true)
                {
                    ComputerFactory.BeginProc();
                    ComputerFactory.Delete((HPS.BLL.ComputerBLL.BLLComputer_TKeys)Key);
                    ComputerFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.ComputerBLL.BLLComputer_T.Computer_TField.ComputerID_int.ToString() + "='" + ((HPS.BLL.ComputerBLL.BLLComputer_TKeys)Key).ComputerID_int.ToString() + "'");
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
                ComputerFactory.RollBackProc();
                throw ex;
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupID_intFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
                DataTable UserGroupID_intDataTable = new DataTable();
                UserGroupID_intFactory.GetAll(ref UserGroupID_intDataTable);
                this.UserGroupID_intComboBox.DisplayMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroup_nvc.ToString();
                this.UserGroupID_intComboBox.ValueMember = HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString();
                this.UserGroupID_intComboBox.DataSource = UserGroupID_intDataTable;
                this.UserGroupID_intComboBox.SelectedIndex = -1;

                HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable UserDataTable = new DataTable();
                UserFactory.GetAll(ref UserDataTable);
                //UserDataTable.Columns.Add("select_bit").DefaultValue=false;

                UserNameGridView.DataSource = UserDataTable;
                //this.Computer_nvcComboBox.DisplayMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                //this.Computer_nvcComboBox.ValueMember = HPS.BLL.UserBLL.BLLUser_T.User_TField.UserName_nvc.ToString();
                //this.Computer_nvcComboBox.DataSource = UserDataTable;
                //this.Computer_nvcComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UserGroupID_intNewButton_Click(object sender, EventArgs e)
        {
            HPS.Present.UserGroup.UserGroupEntityForm frm = new HPS.Present.UserGroup.UserGroupEntityForm((DataTable)UserGroupID_intComboBox.DataSource);
            frm.ShowDialog();
        }

        private void GetIPButton_Click(object sender, EventArgs e)
        {
            IPTextBox.Text = Hepsa.Core.Common.ApplicationInfo.IpAddress;
        }

        private void GetMacButton_Click(object sender, EventArgs e)
        {
            MacTextBox.Text = Hepsa.Core.Common.ApplicationInfo.MacAddress;
        }

        private void UserGroupID_intComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                HPS.BLL.UserBLL.BLLUser_TFactory UserFactory = new HPS.BLL.UserBLL.BLLUser_TFactory();
                DataTable UserDataTable = new DataTable();
                UserFactory.GetAllBy(BLL.UserBLL.BLLUser_T.User_TField.UserGroupID_int,UserGroupID_intComboBox.SelectedValue,ref UserDataTable);
                UserNameGridView.DataSource = UserDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}