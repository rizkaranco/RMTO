using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HPS.Present.LaderType
{
    public partial class ChooseSaloonForm : Hepsa.Core.PL.BaseEntityForm1
    {
        public ChooseSaloonForm(DataTable DataTable)
            : base(DataTable)
        {
            InitializeComponent();
        }

        public ChooseSaloonForm(Hepsa.Core.PL.BaseEntityParentForm.enmState State, DataTable DataTable, HPS.BLL.LaderTypeBLL.BLLLaderType_TKeys Key)
            : base(State, DataTable, Key)
        {
            InitializeComponent();
        }

        private void ChooseSaloonForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.State == enmFormState.Add)
                    this.FillCombo();
                Properties.Settings Setting = new HPS.Properties.Settings();
                if (Setting.SaloonID_int!=0)
                {
                    SaloonID_intComboBox.SelectedIndex = Setting.SaloonIDComboBoxIndex;
                }

            }
            catch (Exception ex)
            {
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message);
                this.Close();
            }
        }

        private void FillCombo()
        {
            try
            {
                HPS.BLL.SaloonBLL.BLLSaloon_TFactory Saloon_TFactory = new HPS.BLL.SaloonBLL.BLLSaloon_TFactory();
                DataTable Saloon_TDataTable = new DataTable();
                Saloon_TFactory.GetAll(ref Saloon_TDataTable);
                this.SaloonID_intComboBox.DisplayMember = HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.Saloon_nvc.ToString();
                this.SaloonID_intComboBox.ValueMember = HPS.BLL.SaloonBLL.BLLSaloon_T.Saloon_TField.SaloonID_int.ToString();
                this.SaloonID_intComboBox.DataSource = Saloon_TDataTable;
                this.SaloonID_intComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected override void Insert()
        {
            HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory LaderTypeFactory = new HPS.BLL.LaderTypeBLL.BLLLaderType_TFactory();
            try
            {
                Properties.Settings Setting = new HPS.Properties.Settings();
                if (SaloonID_intComboBox.SelectedIndex != -1)
                {
                    Setting.SaloonID_int = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonID_intComboBox.SelectedValue, TypeCode.Int32);
                    Setting.SaloonIDComboBoxIndex = (Int32)Hepsa.Core.Common.PersentationController.GetEntityValue(SaloonID_intComboBox.SelectedIndex, TypeCode.Int32);
                    Setting.Save();
                }
                else
                {
                    Setting.SaloonID_int = 0;
                    Setting.SaloonIDComboBoxIndex = 0;
                    Setting.Save();
                }

                
                this.ClearForm(this);
            }
            catch (Exception ex)
            {
                LaderTypeFactory.RollBackProc();
                throw ex;
            }
        }


    }
}
