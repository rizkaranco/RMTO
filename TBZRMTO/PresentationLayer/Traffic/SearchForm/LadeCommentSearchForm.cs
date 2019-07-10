using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.SearchForm
{
    public partial class LadeCommentSearchForm : Hepsa.Core.PL.BaseListForm
    {
        public LadeCommentSearchForm()
        {
            InitializeComponent();

            Hepsa.Core.PL.BaseListForm.Group LadeCommentGroup = new Hepsa.Core.PL.BaseListForm.Group();
            LadeCommentGroup.AddButton = SearchButton;
            LadeCommentGroup.set_Grid(true, true, true, this.LadeCommentGridView);
            LadeCommentGroup.ToolStrip = this.LadeCommentToolStrip;
            LadeCommentGroup.HasFilterControl = true;

            this.Groups.Add(LadeCommentGroup);
        }

        HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
        
        private void LadeCommentSearchForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.LoadLadeComment();
                this.LadeCommentGridView.Focus();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void LoadLadeComment()
        {
            try
            {
                HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory LadeCommentFactory = new HPS.BLL.LadeCommentBLL.BLLLadeComment_TFactory();
                DataTable LadeCommentDataTable = new DataTable();
                LadeCommentFactory.GetAll( ref LadeCommentDataTable);
                this.LadeCommentGridView.DataSource = LadeCommentDataTable;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }

        List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> LadeCommentList = new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                LadeCommentList.Clear();
                foreach (Janus.Windows.GridEX.GridEXRow item in LadeCommentGridView.GetCheckedRows())
                {
                    HPS.BLL.LadeCommentBLL.BLLLadeComment_T LadeCommentEntity = new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();

                    LadeCommentEntity.LadeCommentID_int = Convert.ToInt32(item.Cells["LadeCommentID_int"].Value);
                    LadeCommentEntity.LadeComment_nvc = Convert.ToString(item.Cells["LadeComment_nvc"].Value);

                    LadeCommentList.Add(LadeCommentEntity);

                }
                this.Close();
            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void ClosetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> SelectedLadeCommentList
        {
            get
            {
                return LadeCommentList;
            }
        }

        private void LadeCommentGridView_DoubleClick(object sender, EventArgs e)
        {
            SearchButton.PerformClick();
        }

        private void LadeCommentGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SearchButton.PerformClick();
            }
        }

        private void LadeCommentGridView_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

    }
}
