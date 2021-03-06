using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace HPS.Present.UserGroup
{
    public partial class UserGroupEntityForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public UserGroupEntityForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public UserGroupEntityForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void UserGroupEntityForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                {
                    this.MakePermission();
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
            HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
            HPS.BLL.UserGroupBLL.BLLUserGroup_T UserGroupEntity = UserGroupFactory.GetBy((HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys)Key);
            if (UserGroupEntity == null)
                throw new HPS.Exceptions.UserGroupNotFound();
            else
            {
                this.MakePermission();
                if (UserGroupEntity.Permission_nvc != null)
                {
                    this.ShowPermision(UserGroupEntity.Permission_nvc, this.PermisionTabControl);
                }
                this.UserGroup_nvcTextBox.Text = UserGroupEntity.UserGroup_nvc;
                Active_bitCheckBox.Checked = (bool)Hepsa.Core.Common.PersentationController.GetEntityValue(UserGroupEntity.Active_bit, TypeCode.Boolean);
            }
        }

        protected override void Insert()
        {
            HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
            HPS.BLL.UserGroupBLL.BLLUserGroup_T UserGroupEntity = new HPS.BLL.UserGroupBLL.BLLUserGroup_T();
            HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys UserGroupKey = new HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys();
            try
            {
                UserGroupEntity.Active_bit = this.Active_bitCheckBox.Checked;
                string refer = null;
                this.GetPermission(ref refer, this.PermisionTabControl);
                UserGroupEntity.Permission_nvc = refer;
                UserGroupEntity.UserGroup_nvc = this.UserGroup_nvcTextBox.Text;
                UserGroupFactory.BeginProc();
                UserGroupFactory.Insert(UserGroupEntity);
                UserGroupFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow dr = this.DataTable.NewRow();
                    dr[HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.UserGroupID_int, TypeCode.Int32);
                    dr[HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.UserGroup_nvc, TypeCode.String);
                    dr[HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.Permission_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.Permission_nvc, TypeCode.String);
                    dr[HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.Active_bit, TypeCode.Boolean);
                    DataTable.Rows.Add(dr);
                    DataTable.AcceptChanges();
                }
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                UserGroupFactory.RollBackProc();
                throw ex;
            }
        }

        protected override void Edit()
        {
            HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();
            try
            {
                HPS.BLL.UserGroupBLL.BLLUserGroup_T UserGroupEntity = new HPS.BLL.UserGroupBLL.BLLUserGroup_T();
                UserGroupEntity.UserGroupID_int = ((HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys)Key).UserGroupID_int;
                UserGroupEntity.Active_bit = Active_bitCheckBox.Checked;
                UserGroupEntity.UserGroup_nvc = UserGroup_nvcTextBox.Text;
                string refer = null;
                this.GetPermission(ref refer, this.PermisionTabControl);
                UserGroupEntity.Permission_nvc = refer;
                if (Hepsa.Core.Common.MessageBox.ConfirmMessage(HPS.Exceptions.ExceptionCs.EditMessage) == true)
                {
                    UserGroupFactory.BeginProc();
                    UserGroupFactory.Update(UserGroupEntity, (HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys)Key);
                    UserGroupFactory.CommitProc();
                    if (DataTable != null)
                    {
                        DataRow[] dr = DataTable.Select(HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString() + "='" + ((HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys)Key).UserGroupID_int.ToString() + "'");
                        if (dr.Length > 0)
                        {
                            dr[0][HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.UserGroupID_int, TypeCode.Int32);
                            dr[0][HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroup_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.UserGroup_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.Permission_nvc.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.Permission_nvc, TypeCode.String);
                            dr[0][HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.Active_bit.ToString()] = Hepsa.Core.Common.PersentationController.GetEntityValueInDatabaseFormat(UserGroupEntity.Active_bit, TypeCode.Boolean);
                        }
                        DataTable.AcceptChanges();
                    } 
                }
            }
            catch (Exception ex)
            {
                UserGroupFactory.RollBackProc();
                throw ex;
            }

        }

        protected override void Delete()
        {
            HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory UserGroupFactory = new HPS.BLL.UserGroupBLL.BLLUserGroup_TFactory();

            try
            {
                UserGroupFactory.BeginProc();
                UserGroupFactory.Delete((HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys)Key);
                UserGroupFactory.CommitProc();
                if (DataTable != null)
                {
                    DataRow[] dr = DataTable.Select(HPS.BLL.UserGroupBLL.BLLUserGroup_T.UserGroup_TField.UserGroupID_int.ToString() + "='" + ((HPS.BLL.UserGroupBLL.BLLUserGroup_TKeys)Key).UserGroupID_int.ToString() + "'");
                    if (dr.Length > 0)
                    {
                        dr[0].Delete();
                    }
                    DataTable.AcceptChanges();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                UserGroupFactory.RollBackProc();
                throw ex;
            }
        }

        private void SelectAllPermissionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Control> lst = this.FindControls(this, "CheckListBox");
                if (lst != null && lst.Count > 0)
                {
                    foreach (Control item in lst)
                    {
                        if (item.GetType() == typeof(CheckedListBox)) 
                        {
                            for (int i = 0; i < ((CheckedListBox)item).Items.Count ; i++)
                            {
                                ((CheckedListBox)item).SetItemChecked(i, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message); }
        }

        private void ClearAllPermissionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Control> lst = this.FindControls(this, "CheckListBox");
                if (lst != null && lst.Count > 0)
                {
                    foreach (Control item in lst)
                    {
                        if (item.GetType() == typeof(CheckedListBox))
                        {
                            for (int i = 0; i < ((CheckedListBox)item).Items.Count ; i++)
                            {
                                ((CheckedListBox)item).SetItemChecked(i, false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message); }
        }

        private void ReversePermissionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Control> lst = this.FindControls(this, "CheckListBox");
                if (lst != null && lst.Count > 0)
                {
                    foreach (Control item in lst)
                    {
                        if (item.GetType() == typeof(CheckedListBox))
                        {
                            for (int i = 0; i < ((CheckedListBox)item).Items.Count ; i++)
                            {
                                if (((CheckedListBox)item).GetItemChecked(i) == true)
                                    ((CheckedListBox)item).SetItemChecked(i, false);
                                else
                                    ((CheckedListBox)item).SetItemChecked(i, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message); }
        }

        private List<Control> FindControls(Control parent , string NamePattern)
        {
            List<Control> lst = new List<Control>();
            if (parent.Name.Contains(NamePattern))
                lst.Add(parent);
            if (parent.HasChildren)
            {
                foreach (Control item in parent.Controls)
                {
                    lst.AddRange(this.FindControls(item,NamePattern));
                }
            }
            return lst;
        }

        private void GetPermission(ref string Permission , Control tabPage)
        {
            foreach (Control item in tabPage.Controls)
            {
                if (item.Controls.Count > 0)
                    GetPermission(ref Permission,item);
                else if (item.GetType() == typeof(CheckedListBox))
                {
                    CheckedListBox CheckList = (CheckedListBox)item;
                    for (int i = 0; i < CheckList.Items.Count; i++)
                    {
                        if (CheckList.GetItemCheckState(i) == CheckState.Unchecked)
                        {
                            if (string.IsNullOrEmpty(Permission) == false)
                            {
                                Permission += "$";
                            }
                            Permission += ((HPS.BLL.PermissionBLL.BLLPermission_T)CheckList.Items[i]).PermissionID_bint.ToString();
                        }
                    }
                }
            }
        }

        private void ShowPermision(string Permision, Control tabPage)
        {
            string[] SplitedPermission = Permision.Split('$');
            foreach (Control item in tabPage.Controls)
            {
                if (item.Controls.Count > 0)
                    ShowPermision(Permision, item);
                else if (item.GetType() == typeof(CheckedListBox))
                {
                    CheckedListBox CheckList = (CheckedListBox)item;
                    for (int i = 0; i < CheckList.Items.Count; i++)
                    {
                        
                        
                        if (SplitedPermission.Contains((((HPS.BLL.PermissionBLL.BLLPermission_T)CheckList.Items[i]).PermissionID_bint.ToString())))
                            CheckList.SetItemChecked(i, false);
                        else
                            CheckList.SetItemChecked(i, true);



                    }
                }
            }
        }

        /*Private Sub MakePermision()
        Try
            Dim SystemEntity As List(Of HPS.ACC.BLL.BLLSystem_T)
            Dim SystemFactory As New HPS.ACC.BLL.BLLSystem_TFactory
            Dim GroupFactory As New HPS.ACC.BLL.BLLPermissionGroup_TFactory
            Dim PermisionFactory As New HPS.ACC.BLL.BLLPermission_TFactory

            SystemEntity = SystemFactory.GetAll()
            For index As Integer = 0 To SystemEntity.Count - 1
                Dim GroupEnity As List(Of HPS.ACC.BLL.BLLPermissionGroup_T) = GroupFactory.GetAllBy(HPS.ACC.BLL.BLLPermissionGroup_T.PermissionGroup_TField.SystemID_tint, SystemEntity.Item(index).SystemID_tint)
                Dim TabPage As New TabPage
                TabPage.Name = SystemEntity.Item(index).SystemID_tint
                TabPage.Text = SystemEntity.Item(index).System_nvc
                TabPage.UseVisualStyleBackColor = True
                Dim GroupTabControl As New TabControl
                GroupTabControl.Name = SystemEntity.Item(index).SystemID_tint.ToString + "GroupTabControl"
                GroupTabControl.Dock = DockStyle.Fill
                GroupTabControl.RightToLeft = Windows.Forms.RightToLeft.Yes
                GroupTabControl.RightToLeftLayout = True
                TabPage.Controls.Add(GroupTabControl)
                For j As Integer = 0 To GroupEnity.Count - 1
                    Dim GroupTabPage As New TabPage
                    GroupTabPage.Name = GroupEnity.Item(j).PermissionGroupID_bint
                    GroupTabPage.Text = GroupEnity.Item(j).PermissionGroup_nvc
                    GroupTabPage.UseVisualStyleBackColor = True
                    GroupTabPage.AutoScroll = True
                    GroupTabPage.RightToLeft = Windows.Forms.RightToLeft.Yes
                    Dim CheckListBox As New CheckedListBox
                    CheckListBox.Name = GroupEnity.Item(j).PermissionGroupID_bint.ToString + "CheckListBox"
                    CheckListBox.Dock = DockStyle.Fill
                    CheckListBox.CheckOnClick = True
                    Dim PermisionEntity As List(Of HPS.ACC.BLL.BLLPermission_T) = PermisionFactory.GetAllBy(HPS.ACC.BLL.BLLPermission_T.Permission_TField.PermissionGroupID_bint, GroupEnity.Item(j).PermissionGroupID_bint)
                    CheckListBox.DisplayMember = HPS.ACC.BLL.BLLPermission_T.Permission_TField.Permission_nvc.ToString
                    CheckListBox.ValueMember = HPS.ACC.BLL.BLLPermission_T.Permission_TField.PermissionID_bint.ToString
                    For k As Integer = 0 To PermisionEntity.Count - 1
                        CheckListBox.Items.Add(PermisionEntity.Item(k), False)
                    Next

                    GroupTabPage.Controls.Add(CheckListBox)
                    GroupTabControl.Controls.Add(GroupTabPage)
                Next
                Me.PermisionTabControl.Controls.Add(TabPage)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub*/

        private void MakePermission()
        {
            HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TFactory PermissionGroupFactory = new HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TFactory();
            HPS.BLL.PermissionBLL.BLLPermission_TFactory PermissionFactory = new HPS.BLL.PermissionBLL.BLLPermission_TFactory();

            try
            {
                List<HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> PermissionGroupList = PermissionGroupFactory.GetAll();
                if (PermissionGroupList != null && PermissionGroupList.Count > 0)
                {
                    for (int index = 0; index < PermissionGroupList.Count; index++)
                    {
                        TabPage GroupTabPage = new TabPage();

                        GroupTabPage.Name = PermissionGroupList[index].PermissionGroupID_int.ToString();
                        GroupTabPage.Text = PermissionGroupList[index].PermissionGroup_nvc;
                        GroupTabPage.UseVisualStyleBackColor = true;
                        GroupTabPage.AutoScroll = true;
                        GroupTabPage.RightToLeft = RightToLeft.Yes;
                        CheckedListBox CheckListBox = new CheckedListBox();
                        CheckListBox.Name = PermissionGroupList[index].PermissionGroupID_int.ToString() + "CheckListBox";
                        CheckListBox.Dock = DockStyle.Fill;
                        CheckListBox.CheckOnClick = true;
                        CheckListBox.DisplayMember = HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.Permission_nvc.ToString();
                        CheckListBox.ValueMember = HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.PermissionID_bint.ToString();
                        List<HPS.BLL.PermissionBLL.BLLPermission_T> PermissionList = PermissionFactory.GetAllBy(HPS.BLL.PermissionBLL.BLLPermission_T.Permission_TField.PermissionGroupID_int, PermissionGroupList[index].PermissionGroupID_int);
                        if (PermissionList != null && PermissionList.Count > 0)
                        {
                            for (int PermissionIndex = 0; PermissionIndex < PermissionList.Count; PermissionIndex++)
                                CheckListBox.Items.Add(PermissionList[PermissionIndex]);
                        }
                        GroupTabPage.Controls.Add(CheckListBox);
                        this.PermisionTabControl.Controls.Add(GroupTabPage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}