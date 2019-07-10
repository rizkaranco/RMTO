﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class LaderTypeSearch : Hepsa.Core.PL.BaseListForm
    {
        public LaderTypeSearch()
        {
            InitializeComponent();
            Hepsa.Core.PL.BaseListForm.Group LaderTypeGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LaderTypeGroup.AddButton = SearchButton;
            LaderTypeGroup.set_Grid(true, true, true, this.LaderTypeGridView);
            LaderTypeGroup.ToolStrip = this.BoxingToolStrip;
            LaderTypeGroup.HasFilterControl = true;

            this.Groups.Add(LaderTypeGroup);
            this.LaderTypeGridView.MultiSelect = true;
        }

        HPS.BLL.LaderTypeBLL.BLLLaderType_T LaderTypeEntity = new HPS.BLL.LaderTypeBLL.BLLLaderType_T();

        private void LaderTypeSearch_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadLaderType();
                this.LaderTypeGridView.Focus();
                this.LaderTypeEntity = null;
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (LaderTypeGridView.CurrentRow != null)
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys LaderTypeKey = new HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys();
                LaderTypeKey.LaderTypeID_int = (Int32)LaderTypeGridView.CurrentRow.Cells[colLaderTypeID_int.Name].Value;
                LaderTypeEntity = LaderTypeFactory.GetBy(LaderTypeKey);

                if (string.IsNullOrEmpty(Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeGridView.CurrentRow.Cells[colLaderTypeID_int.Name].Value, TypeCode.String).ToString()) == false)
                {
                    LaderTypeEntity.LaderType_nvc = Hepsa.Core.Common.PersentationController.GetEntityValue(LaderTypeGridView.CurrentRow.Cells[colLaderType_nvc.Name].Value, TypeCode.String).ToString();
                }
            }
            this.Close();
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LaderTypeGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void LaderTypeGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void LoadLaderType()
        {
            try
            {
                HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
                string Condition = "[LaderType_T].[Active_bit]='true'";
                DataTable LaderTypeDataTable = new DataTable();
                LaderTypeFactory.GetAllByCondition(Condition, ref LaderTypeDataTable);
                this.LaderTypeGridView.DataSource = LaderTypeDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        public HPS.BLL.LaderTypeBLL.BLLLaderType_T SelectedLaderTypeEntity
        {
            get
            {
                return LaderTypeEntity;
            }
        }

        private void Multiselect_Click(object sender, EventArgs e)
        {
           
        }

    }
}
