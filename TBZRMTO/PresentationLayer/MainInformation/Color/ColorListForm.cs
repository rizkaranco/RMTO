using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hepsa.Core.PL;

namespace HPS.Present.Color
{
    public partial class ColorListForm : Hepsa.Core.PL.BaseListForm
    {
        public ColorListForm()
        {
            InitializeComponent();

                Hepsa.Core.PL.BaseListForm.Group ColorGroup = new Hepsa.Core.PL.BaseListForm.Group();
                ColorGroup.AddButton = this.NewButton;
                ColorGroup.DeleteButton = this.DeleteButton;
                ColorGroup.EditButton = this.EditButton;
                ColorGroup.RefreshButton = this.RefreshButton;
                ColorGroup.ExportButton = this.ExportButton;
                ColorGroup.set_Grid(true,true,true, this.ColorGridView);
                ColorGroup.ToolStrip = this.ColorToolStrip;
                ColorGroup.HasFilterControl = true;

            this.Groups.Add(ColorGroup);

        }

         private void ColorListForm_Load(object sender, EventArgs e)
       {
            try
          {
            this.LoadColor();
            this.ColorGridView.Focus();
          }
        catch (Exception ex)
          {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
          }

       }
         private void LoadColor()
        {
            try
            {
               HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory = new HPS.BLL.ColorBLL.BLLColor_TFactory();
               DataTable ColorDataTable= new DataTable();
               ColorFactory.GetAll(ref ColorDataTable);
               this.ColorGridView.DataSource = ColorDataTable;
            }
            catch(System.Exception ex)
             {
                throw ex;
             }

        }

         private void NewButton_Click(object sender, EventArgs e)
        {
          ColorEntityForm Color=new ColorEntityForm((DataTable)this.ColorGridView.DataSource);
          Color.ShowDialog();
        }

        private void EditButton_Click(object sender,EventArgs e)
        {
          HPS.BLL.ColorBLL.BLLColor_TKeys ColorKey= new HPS.BLL.ColorBLL.BLLColor_TKeys();
          ColorKey.ColorID_int = (Int32)this.ColorGridView.CurrentRow.Cells["colColorID_int"].Value;
          ColorEntityForm Color=new ColorEntityForm(BaseEntityForm1.enmState.Edit, (DataTable)this.ColorGridView.DataSource, ColorKey);
          Color.ShowDialog();
        }

        private void DeleteButton_Click(object sender,EventArgs e)
        {
        HPS.BLL.ColorBLL.BLLColor_TFactory ColorFactory=new HPS.BLL.ColorBLL.BLLColor_TFactory();

            try
             {
            if (Hepsa.Core.Common.MessageBox.ConfirmDeleteMessage() == false)
            {
                 return;
            }


            HPS.BLL.ColorBLL.BLLColor_TFactory Color_TFactory = new HPS.BLL.ColorBLL.BLLColor_TFactory();
            HPS.BLL.ColorBLL.BLLColor_TKeys ColorKey= new HPS.BLL.ColorBLL.BLLColor_TKeys();

            ColorKey.ColorID_int = (Int32)ColorGridView.CurrentRow.Cells["colColorID_int"].Value;
            ColorFactory.Delete(ColorKey);

            DataRow[] dr=((DataTable)this.ColorGridView.DataSource).Select(HPS.BLL.ColorBLL.BLLColor_T.Color_TField.ColorID_int.ToString() + "='" +ColorKey.ColorID_int.ToString()+"'");
                if (dr.Length > 0)
                   {
                    dr[0].Delete();
                   }
            ((DataTable)this.ColorGridView.DataSource).AcceptChanges();
            }

            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender,EventArgs e)
         {  
            try
            {
                this.LoadColor();
            }
            catch(Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
             }
          } 
     }
}