using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.SettingsDAL
{
    class DALSetting_T : DataLayerBase
    {

        public DALSetting_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.SettingsBLL.BLLSetting_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObject.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);

                SqlParameter Setting_nvc = new SqlParameter();
                Setting_nvc.ParameterName = "@Setting_nvc";
                Setting_nvc.SqlDbType = SqlDbType.NVarChar;
                Setting_nvc.Direction = ParameterDirection.Input;
                Setting_nvc.IsNullable = false;
                Setting_nvc.Value = businessObject.Setting_nvc;
                this.Command.Parameters.Add(Setting_nvc);

                SqlParameter Value_nvc = new SqlParameter();
                Value_nvc.ParameterName = "@Value_nvc";
                Value_nvc.SqlDbType = SqlDbType.NVarChar;
                Value_nvc.Direction = ParameterDirection.Input;
                Value_nvc.IsNullable = false;
                Value_nvc.Value = businessObject.Value_nvc;
                this.Command.Parameters.Add(Value_nvc);

                SqlParameter Description_nvc = new SqlParameter();
                Description_nvc.ParameterName = "@Description_nvc";
                Description_nvc.SqlDbType = SqlDbType.NVarChar;
                Description_nvc.Direction = ParameterDirection.Input;
                Description_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Description_nvc))
                {
                    Description_nvc.Value = DBNull.Value;
                }
                else
                {
                    Description_nvc.Value = businessObject.Description_nvc;
                }
                this.Command.Parameters.Add(Description_nvc);

                SqlParameter Boolean_bit = new SqlParameter();
                Boolean_bit.ParameterName = "@Boolean_bit";
                Boolean_bit.SqlDbType = SqlDbType.Bit;
                Boolean_bit.Direction = ParameterDirection.Input;
                Boolean_bit.IsNullable = true;
                if (businessObject.Boolean_bit.HasValue == false)
                {
                    Boolean_bit.Value = DBNull.Value;
                }
                else
                {
                    Boolean_bit.Value = businessObject.Boolean_bit;
                }
                this.Command.Parameters.Add(Boolean_bit);

                SqlParameter Shortcutkey_bit = new SqlParameter();
                Shortcutkey_bit.ParameterName = "@Shortcutkey_bit";
                Shortcutkey_bit.SqlDbType = SqlDbType.Bit;
                Shortcutkey_bit.Direction = ParameterDirection.Input;
                Shortcutkey_bit.IsNullable = true;
                if (businessObject.Shortcutkey_bit.HasValue == false)
                {
                    Shortcutkey_bit.Value = DBNull.Value;
                }
                else
                {
                    Shortcutkey_bit.Value = businessObject.Shortcutkey_bit;
                }
                this.Command.Parameters.Add(Shortcutkey_bit);

                SqlParameter Numeric_bit = new SqlParameter();
                Numeric_bit.ParameterName = "@Numeric_bit";
                Numeric_bit.SqlDbType = SqlDbType.Bit;
                Numeric_bit.Direction = ParameterDirection.Input;
                Numeric_bit.IsNullable = true;
                if (businessObject.Numeric_bit.HasValue == false)
                {
                    Numeric_bit.Value = DBNull.Value;
                }
                else
                {
                    Numeric_bit.Value = businessObject.Numeric_bit;
                }
                this.Command.Parameters.Add(Numeric_bit);

                SqlParameter Text_bit = new SqlParameter();
                Text_bit.ParameterName = "@Text_bit";
                Text_bit.SqlDbType = SqlDbType.Bit;
                Text_bit.Direction = ParameterDirection.Input;
                Text_bit.IsNullable = true;
                if (businessObject.Text_bit.HasValue == false)
                {
                    Text_bit.Value = DBNull.Value;
                }
                else
                {
                    Text_bit.Value = businessObject.Text_bit;
                }
                this.Command.Parameters.Add(Text_bit);

                SqlParameter Account_bit = new SqlParameter();
                Account_bit.ParameterName = "@Account_bit";
                Account_bit.SqlDbType = SqlDbType.Bit;
                Account_bit.Direction = ParameterDirection.Input;
                Account_bit.IsNullable = true;
                if (businessObject.Account_bit.HasValue == false)
                {
                    Account_bit.Value = DBNull.Value;
                }
                else
                {
                    Account_bit.Value = businessObject.Account_bit;
                }
                this.Command.Parameters.Add(Account_bit);

                SqlParameter Selective_bit = new SqlParameter();
                Selective_bit.ParameterName = "@Selective_bit";
                Selective_bit.SqlDbType = SqlDbType.Bit;
                Selective_bit.Direction = ParameterDirection.Input;
                Selective_bit.IsNullable = true;
                if (businessObject.Selective_bit.HasValue == false)
                {
                    Selective_bit.Value = DBNull.Value;
                }
                else
                {
                    Selective_bit.Value = businessObject.Selective_bit;
                }
                this.Command.Parameters.Add(Selective_bit);

                SqlParameter SelectValue1_int = new SqlParameter();
                SelectValue1_int.ParameterName = "@SelectValue1_int";
                SelectValue1_int.SqlDbType = SqlDbType.Int;
                SelectValue1_int.Direction = ParameterDirection.Input;
                SelectValue1_int.IsNullable = true;
                if (businessObject.SelectValue1_int.HasValue == false)
                {
                    SelectValue1_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue1_int.Value = businessObject.SelectValue1_int;
                }
                this.Command.Parameters.Add(SelectValue1_int);

                SqlParameter SelectText1_nvc = new SqlParameter();
                SelectText1_nvc.ParameterName = "@SelectText1_nvc";
                SelectText1_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText1_nvc.Direction = ParameterDirection.Input;
                SelectText1_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText1_nvc))
                {
                    SelectText1_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText1_nvc.Value = businessObject.SelectText1_nvc;
                }
                this.Command.Parameters.Add(SelectText1_nvc);

                SqlParameter SelectValue2_int = new SqlParameter();
                SelectValue2_int.ParameterName = "@SelectValue2_int";
                SelectValue2_int.SqlDbType = SqlDbType.Int;
                SelectValue2_int.Direction = ParameterDirection.Input;
                SelectValue2_int.IsNullable = true;
                if (businessObject.SelectValue2_int.HasValue == false)
                {
                    SelectValue2_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue2_int.Value = businessObject.SelectValue2_int;
                }
                this.Command.Parameters.Add(SelectValue2_int);

                SqlParameter SelectText2_nvc = new SqlParameter();
                SelectText2_nvc.ParameterName = "@SelectText2_nvc";
                SelectText2_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText2_nvc.Direction = ParameterDirection.Input;
                SelectText2_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText2_nvc))
                {
                    SelectText2_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText2_nvc.Value = businessObject.SelectText2_nvc;
                }
                this.Command.Parameters.Add(SelectText2_nvc);

                SqlParameter SelectValue3_int = new SqlParameter();
                SelectValue3_int.ParameterName = "@SelectValue3_int";
                SelectValue3_int.SqlDbType = SqlDbType.Int;
                SelectValue3_int.Direction = ParameterDirection.Input;
                SelectValue3_int.IsNullable = true;
                if (businessObject.SelectValue3_int.HasValue == false)
                {
                    SelectValue3_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue3_int.Value = businessObject.SelectValue3_int;
                }
                this.Command.Parameters.Add(SelectValue3_int);

                SqlParameter SelectText3_nvc = new SqlParameter();
                SelectText3_nvc.ParameterName = "@SelectText3_nvc";
                SelectText3_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText3_nvc.Direction = ParameterDirection.Input;
                SelectText3_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText3_nvc))
                {
                    SelectText3_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText3_nvc.Value = businessObject.SelectText3_nvc;
                }
                this.Command.Parameters.Add(SelectText3_nvc);

                SqlParameter SelectValue4_int = new SqlParameter();
                SelectValue4_int.ParameterName = "@SelectValue4_int";
                SelectValue4_int.SqlDbType = SqlDbType.Int;
                SelectValue4_int.Direction = ParameterDirection.Input;
                SelectValue4_int.IsNullable = true;
                if (businessObject.SelectValue4_int.HasValue == false)
                {
                    SelectValue4_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue4_int.Value = businessObject.SelectValue4_int;
                }
                this.Command.Parameters.Add(SelectValue4_int);

                SqlParameter SelectText4_nvc = new SqlParameter();
                SelectText4_nvc.ParameterName = "@SelectText4_nvc";
                SelectText4_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText4_nvc.Direction = ParameterDirection.Input;
                SelectText4_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText4_nvc))
                {
                    SelectText4_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText4_nvc.Value = businessObject.SelectText4_nvc;
                }
                this.Command.Parameters.Add(SelectText4_nvc);

                SqlParameter SelectValue5_int = new SqlParameter();
                SelectValue5_int.ParameterName = "@SelectValue5_int";
                SelectValue5_int.SqlDbType = SqlDbType.Int;
                SelectValue5_int.Direction = ParameterDirection.Input;
                SelectValue5_int.IsNullable = true;
                if (businessObject.SelectValue5_int.HasValue == false)
                {
                    SelectValue5_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue5_int.Value = businessObject.SelectValue5_int;
                }
                this.Command.Parameters.Add(SelectValue5_int);

                SqlParameter SelectText5_nvc = new SqlParameter();
                SelectText5_nvc.ParameterName = "@SelectText5_nvc";
                SelectText5_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText5_nvc.Direction = ParameterDirection.Input;
                SelectText5_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText5_nvc))
                {
                    SelectText5_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText5_nvc.Value = businessObject.SelectText5_nvc;
                }
                this.Command.Parameters.Add(SelectText5_nvc);

                SqlParameter SelectValue6_int = new SqlParameter();
                SelectValue6_int.ParameterName = "@SelectValue6_int";
                SelectValue6_int.SqlDbType = SqlDbType.Int;
                SelectValue6_int.Direction = ParameterDirection.Input;
                SelectValue6_int.IsNullable = true;
                if (businessObject.SelectValue6_int.HasValue == false)
                {
                    SelectValue6_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue6_int.Value = businessObject.SelectValue6_int;
                }
                this.Command.Parameters.Add(SelectValue6_int);

                SqlParameter SelectText6_nvc = new SqlParameter();
                SelectText6_nvc.ParameterName = "@SelectText6_nvc";
                SelectText6_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText6_nvc.Direction = ParameterDirection.Input;
                SelectText6_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText6_nvc))
                {
                    SelectText6_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText6_nvc.Value = businessObject.SelectText6_nvc;
                }
                this.Command.Parameters.Add(SelectText6_nvc);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();


                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void Update(HPS.BLL.SettingsBLL.BLLSetting_T businessObject, HPS.BLL.SettingsBLL.BLLSetting_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObject.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);

                SqlParameter Setting_nvc = new SqlParameter();
                Setting_nvc.ParameterName = "@Setting_nvc";
                Setting_nvc.SqlDbType = SqlDbType.NVarChar;
                Setting_nvc.Direction = ParameterDirection.Input;
                Setting_nvc.IsNullable = false;
                Setting_nvc.Value = businessObject.Setting_nvc;
                this.Command.Parameters.Add(Setting_nvc);

                SqlParameter Value_nvc = new SqlParameter();
                Value_nvc.ParameterName = "@Value_nvc";
                Value_nvc.SqlDbType = SqlDbType.NVarChar;
                Value_nvc.Direction = ParameterDirection.Input;
                Value_nvc.IsNullable = false;
                Value_nvc.Value = businessObject.Value_nvc;
                this.Command.Parameters.Add(Value_nvc);

                SqlParameter Description_nvc = new SqlParameter();
                Description_nvc.ParameterName = "@Description_nvc";
                Description_nvc.SqlDbType = SqlDbType.NVarChar;
                Description_nvc.Direction = ParameterDirection.Input;
                Description_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Description_nvc))
                {
                    Description_nvc.Value = DBNull.Value;
                }
                else
                {
                    Description_nvc.Value = businessObject.Description_nvc;
                }
                this.Command.Parameters.Add(Description_nvc);

                SqlParameter Boolean_bit = new SqlParameter();
                Boolean_bit.ParameterName = "@Boolean_bit";
                Boolean_bit.SqlDbType = SqlDbType.Bit;
                Boolean_bit.Direction = ParameterDirection.Input;
                Boolean_bit.IsNullable = true;
                if (businessObject.Boolean_bit.HasValue == false)
                {
                    Boolean_bit.Value = DBNull.Value;
                }
                else
                {
                    Boolean_bit.Value = businessObject.Boolean_bit;
                }
                this.Command.Parameters.Add(Boolean_bit);

                SqlParameter Shortcutkey_bit = new SqlParameter();
                Shortcutkey_bit.ParameterName = "@Shortcutkey_bit";
                Shortcutkey_bit.SqlDbType = SqlDbType.Bit;
                Shortcutkey_bit.Direction = ParameterDirection.Input;
                Shortcutkey_bit.IsNullable = true;
                if (businessObject.Shortcutkey_bit.HasValue == false)
                {
                    Shortcutkey_bit.Value = DBNull.Value;
                }
                else
                {
                    Shortcutkey_bit.Value = businessObject.Shortcutkey_bit;
                }
                this.Command.Parameters.Add(Shortcutkey_bit);

                SqlParameter Numeric_bit = new SqlParameter();
                Numeric_bit.ParameterName = "@Numeric_bit";
                Numeric_bit.SqlDbType = SqlDbType.Bit;
                Numeric_bit.Direction = ParameterDirection.Input;
                Numeric_bit.IsNullable = true;
                if (businessObject.Numeric_bit.HasValue == false)
                {
                    Numeric_bit.Value = DBNull.Value;
                }
                else
                {
                    Numeric_bit.Value = businessObject.Numeric_bit;
                }
                this.Command.Parameters.Add(Numeric_bit);

                SqlParameter Text_bit = new SqlParameter();
                Text_bit.ParameterName = "@Text_bit";
                Text_bit.SqlDbType = SqlDbType.Bit;
                Text_bit.Direction = ParameterDirection.Input;
                Text_bit.IsNullable = true;
                if (businessObject.Text_bit.HasValue == false)
                {
                    Text_bit.Value = DBNull.Value;
                }
                else
                {
                    Text_bit.Value = businessObject.Text_bit;
                }
                this.Command.Parameters.Add(Text_bit);

                SqlParameter Account_bit = new SqlParameter();
                Account_bit.ParameterName = "@Account_bit";
                Account_bit.SqlDbType = SqlDbType.Bit;
                Account_bit.Direction = ParameterDirection.Input;
                Account_bit.IsNullable = true;
                if (businessObject.Account_bit.HasValue == false)
                {
                    Account_bit.Value = DBNull.Value;
                }
                else
                {
                    Account_bit.Value = businessObject.Account_bit;
                }
                this.Command.Parameters.Add(Account_bit);

                SqlParameter Selective_bit = new SqlParameter();
                Selective_bit.ParameterName = "@Selective_bit";
                Selective_bit.SqlDbType = SqlDbType.Bit;
                Selective_bit.Direction = ParameterDirection.Input;
                Selective_bit.IsNullable = true;
                if (businessObject.Selective_bit.HasValue == false)
                {
                    Selective_bit.Value = DBNull.Value;
                }
                else
                {
                    Selective_bit.Value = businessObject.Selective_bit;
                }
                this.Command.Parameters.Add(Selective_bit);

                SqlParameter SelectValue1_int = new SqlParameter();
                SelectValue1_int.ParameterName = "@SelectValue1_int";
                SelectValue1_int.SqlDbType = SqlDbType.Int;
                SelectValue1_int.Direction = ParameterDirection.Input;
                SelectValue1_int.IsNullable = true;
                if (businessObject.SelectValue1_int.HasValue == false)
                {
                    SelectValue1_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue1_int.Value = businessObject.SelectValue1_int;
                }
                this.Command.Parameters.Add(SelectValue1_int);

                SqlParameter SelectText1_nvc = new SqlParameter();
                SelectText1_nvc.ParameterName = "@SelectText1_nvc";
                SelectText1_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText1_nvc.Direction = ParameterDirection.Input;
                SelectText1_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText1_nvc))
                {
                    SelectText1_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText1_nvc.Value = businessObject.SelectText1_nvc;
                }
                this.Command.Parameters.Add(SelectText1_nvc);

                SqlParameter SelectValue2_int = new SqlParameter();
                SelectValue2_int.ParameterName = "@SelectValue2_int";
                SelectValue2_int.SqlDbType = SqlDbType.Int;
                SelectValue2_int.Direction = ParameterDirection.Input;
                SelectValue2_int.IsNullable = true;
                if (businessObject.SelectValue2_int.HasValue == false)
                {
                    SelectValue2_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue2_int.Value = businessObject.SelectValue2_int;
                }
                this.Command.Parameters.Add(SelectValue2_int);

                SqlParameter SelectText2_nvc = new SqlParameter();
                SelectText2_nvc.ParameterName = "@SelectText2_nvc";
                SelectText2_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText2_nvc.Direction = ParameterDirection.Input;
                SelectText2_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText2_nvc))
                {
                    SelectText2_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText2_nvc.Value = businessObject.SelectText2_nvc;
                }
                this.Command.Parameters.Add(SelectText2_nvc);

                SqlParameter SelectValue3_int = new SqlParameter();
                SelectValue3_int.ParameterName = "@SelectValue3_int";
                SelectValue3_int.SqlDbType = SqlDbType.Int;
                SelectValue3_int.Direction = ParameterDirection.Input;
                SelectValue3_int.IsNullable = true;
                if (businessObject.SelectValue3_int.HasValue == false)
                {
                    SelectValue3_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue3_int.Value = businessObject.SelectValue3_int;
                }
                this.Command.Parameters.Add(SelectValue3_int);

                SqlParameter SelectText3_nvc = new SqlParameter();
                SelectText3_nvc.ParameterName = "@SelectText3_nvc";
                SelectText3_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText3_nvc.Direction = ParameterDirection.Input;
                SelectText3_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText3_nvc))
                {
                    SelectText3_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText3_nvc.Value = businessObject.SelectText3_nvc;
                }
                this.Command.Parameters.Add(SelectText3_nvc);

                SqlParameter SelectValue4_int = new SqlParameter();
                SelectValue4_int.ParameterName = "@SelectValue4_int";
                SelectValue4_int.SqlDbType = SqlDbType.Int;
                SelectValue4_int.Direction = ParameterDirection.Input;
                SelectValue4_int.IsNullable = true;
                if (businessObject.SelectValue4_int.HasValue == false)
                {
                    SelectValue4_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue4_int.Value = businessObject.SelectValue4_int;
                }
                this.Command.Parameters.Add(SelectValue4_int);

                SqlParameter SelectText4_nvc = new SqlParameter();
                SelectText4_nvc.ParameterName = "@SelectText4_nvc";
                SelectText4_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText4_nvc.Direction = ParameterDirection.Input;
                SelectText4_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText4_nvc))
                {
                    SelectText4_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText4_nvc.Value = businessObject.SelectText4_nvc;
                }
                this.Command.Parameters.Add(SelectText4_nvc);

                SqlParameter SelectValue5_int = new SqlParameter();
                SelectValue5_int.ParameterName = "@SelectValue5_int";
                SelectValue5_int.SqlDbType = SqlDbType.Int;
                SelectValue5_int.Direction = ParameterDirection.Input;
                SelectValue5_int.IsNullable = true;
                if (businessObject.SelectValue5_int.HasValue == false)
                {
                    SelectValue5_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue5_int.Value = businessObject.SelectValue5_int;
                }
                this.Command.Parameters.Add(SelectValue5_int);

                SqlParameter SelectText5_nvc = new SqlParameter();
                SelectText5_nvc.ParameterName = "@SelectText5_nvc";
                SelectText5_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText5_nvc.Direction = ParameterDirection.Input;
                SelectText5_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText5_nvc))
                {
                    SelectText5_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText5_nvc.Value = businessObject.SelectText5_nvc;
                }
                this.Command.Parameters.Add(SelectText5_nvc);

                SqlParameter SelectValue6_int = new SqlParameter();
                SelectValue6_int.ParameterName = "@SelectValue6_int";
                SelectValue6_int.SqlDbType = SqlDbType.Int;
                SelectValue6_int.Direction = ParameterDirection.Input;
                SelectValue6_int.IsNullable = true;
                if (businessObject.SelectValue6_int.HasValue == false)
                {
                    SelectValue6_int.Value = DBNull.Value;
                }
                else
                {
                    SelectValue6_int.Value = businessObject.SelectValue6_int;
                }
                this.Command.Parameters.Add(SelectValue6_int);

                SqlParameter SelectText6_nvc = new SqlParameter();
                SelectText6_nvc.ParameterName = "@SelectText6_nvc";
                SelectText6_nvc.SqlDbType = SqlDbType.NVarChar;
                SelectText6_nvc.Direction = ParameterDirection.Input;
                SelectText6_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.SelectText6_nvc))
                {
                    SelectText6_nvc.Value = DBNull.Value;
                }
                else
                {
                    SelectText6_nvc.Value = businessObject.SelectText6_nvc;
                }
                this.Command.Parameters.Add(SelectText6_nvc);


                SqlParameter pk_SettingID_int = new SqlParameter();
                pk_SettingID_int.ParameterName = "@pk_SettingID_int";
                pk_SettingID_int.SqlDbType = SqlDbType.Int;
                pk_SettingID_int.Direction = ParameterDirection.Input;
                pk_SettingID_int.IsNullable = false;
                pk_SettingID_int.Value = businessObjectKey.SettingID_int;
                this.Command.Parameters.Add(pk_SettingID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public List<HPS.BLL.SettingsBLL.BLLSetting_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.SettingsBLL.BLLSetting_T> Result = new List<HPS.BLL.SettingsBLL.BLLSetting_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAll(ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAll(ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectAll(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public HPS.BLL.SettingsBLL.BLLSetting_T SelectByPrimaryKey(HPS.BLL.SettingsBLL.BLLSetting_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObjectKey.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.SettingsBLL.BLLSetting_T businessObject = new HPS.BLL.SettingsBLL.BLLSetting_T();
                if (dataReader.Read())
                {
                    PopulateBusinessObjectFromReader(businessObject, dataReader);
                }
                else
                {
                    businessObject = null;
                }

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }


                if (ControlConnection)
                {
                    this.Commit();
                }
                return businessObject;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByPrimaryKey(HPS.BLL.SettingsBLL.BLLSetting_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObjectKey.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByPrimaryKey(HPS.BLL.SettingsBLL.BLLSetting_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObjectKey.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByPrimaryKey(HPS.BLL.SettingsBLL.BLLSetting_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObjectKey.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }





        public List<HPS.BLL.SettingsBLL.BLLSetting_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Setting_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.SettingsBLL.BLLSetting_T> Result = new List<HPS.BLL.SettingsBLL.BLLSetting_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByField(String fieldName, Object value, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Setting_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByField(String fieldName, Object value, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Setting_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByField(String fieldName, Object value, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[Setting_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public List<HPS.BLL.SettingsBLL.BLLSetting_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.SettingsBLL.BLLSetting_T> Result = new List<HPS.BLL.SettingsBLL.BLLSetting_T>();
                Result = PopulateObjectsFromReader(dataReader);

                if (dataReader.IsClosed == false)
                {
                    dataReader.Close();
                }

                if (ControlConnection)
                {
                    this.Commit();
                }

                return Result;
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByCondition(String Condition, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset, srcTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByCondition(String Condition, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataset);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void SelectByCondition(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }

            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void Delete(HPS.BLL.SettingsBLL.BLLSetting_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter SettingID_int = new SqlParameter();
                SettingID_int.ParameterName = "@SettingID_int";
                SettingID_int.SqlDbType = SqlDbType.Int;
                SettingID_int.Direction = ParameterDirection.Input;
                SettingID_int.IsNullable = false;
                SettingID_int.Value = businessObjectKey.SettingID_int;
                this.Command.Parameters.Add(SettingID_int);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void DeleteByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_Setting_T_DeleteByField]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
                this.Command.Parameters.Add(new SqlParameter("@Value", value));

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

        public void PopulateBusinessObjectFromReader(HPS.BLL.SettingsBLL.BLLSetting_T businessObject, IDataReader dataReader)
        {
            businessObject.SettingID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SettingID_int.ToString()));
            businessObject.Setting_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Setting_nvc.ToString()));
            businessObject.Value_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Value_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Description_nvc.ToString())) == false)
            {
                businessObject.Description_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Description_nvc.ToString()));
            }
            else
            {
                businessObject.Description_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Boolean_bit.ToString())) == false)
            {
                businessObject.Boolean_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Boolean_bit.ToString()));
            }
            else
            {
                businessObject.Boolean_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Shortcutkey_bit.ToString())) == false)
            {
                businessObject.Shortcutkey_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Shortcutkey_bit.ToString()));
            }
            else
            {
                businessObject.Shortcutkey_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Numeric_bit.ToString())) == false)
            {
                businessObject.Numeric_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Numeric_bit.ToString()));
            }
            else
            {
                businessObject.Numeric_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Text_bit.ToString())) == false)
            {
                businessObject.Text_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Text_bit.ToString()));
            }
            else
            {
                businessObject.Text_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Account_bit.ToString())) == false)
            {
                businessObject.Account_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Account_bit.ToString()));
            }
            else
            {
                businessObject.Account_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Selective_bit.ToString())) == false)
            {
                businessObject.Selective_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.Selective_bit.ToString()));
            }
            else
            {
                businessObject.Selective_bit = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue1_int.ToString())) == false)
            {
                businessObject.SelectValue1_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue1_int.ToString()));
            }
            else
            {
                businessObject.SelectValue1_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText1_nvc.ToString())) == false)
            {
                businessObject.SelectText1_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText1_nvc.ToString()));
            }
            else
            {
                businessObject.SelectText1_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue2_int.ToString())) == false)
            {
                businessObject.SelectValue2_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue2_int.ToString()));
            }
            else
            {
                businessObject.SelectValue2_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText2_nvc.ToString())) == false)
            {
                businessObject.SelectText2_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText2_nvc.ToString()));
            }
            else
            {
                businessObject.SelectText2_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue3_int.ToString())) == false)
            {
                businessObject.SelectValue3_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue3_int.ToString()));
            }
            else
            {
                businessObject.SelectValue3_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText3_nvc.ToString())) == false)
            {
                businessObject.SelectText3_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText3_nvc.ToString()));
            }
            else
            {
                businessObject.SelectText3_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue4_int.ToString())) == false)
            {
                businessObject.SelectValue4_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue4_int.ToString()));
            }
            else
            {
                businessObject.SelectValue4_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText4_nvc.ToString())) == false)
            {
                businessObject.SelectText4_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText4_nvc.ToString()));
            }
            else
            {
                businessObject.SelectText4_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue5_int.ToString())) == false)
            {
                businessObject.SelectValue5_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue5_int.ToString()));
            }
            else
            {
                businessObject.SelectValue5_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText5_nvc.ToString())) == false)
            {
                businessObject.SelectText5_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText5_nvc.ToString()));
            }
            else
            {
                businessObject.SelectText5_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue6_int.ToString())) == false)
            {
                businessObject.SelectValue6_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectValue6_int.ToString()));
            }
            else
            {
                businessObject.SelectValue6_int = null;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText6_nvc.ToString())) == false)
            {
                businessObject.SelectText6_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.SettingsBLL.BLLSetting_T.Setting_TField.SelectText6_nvc.ToString()));
            }
            else
            {
                businessObject.SelectText6_nvc = String.Empty;
            }

        }

        public List<HPS.BLL.SettingsBLL.BLLSetting_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.SettingsBLL.BLLSetting_T> list = new List<HPS.BLL.SettingsBLL.BLLSetting_T>();
            while (dataReader.Read())
            {
                HPS.BLL.SettingsBLL.BLLSetting_T businessObject = new HPS.BLL.SettingsBLL.BLLSetting_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }


        public void SelectAllFormated(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_Setting_T_SelectAllFormatted]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                sqlDataAdapter.Fill(dataTable);

                if (ControlConnection)
                {
                    this.Commit();
                }
            }
            catch (System.Exception ex)
            {
                if (ControlConnection)
                {
                    this.RollBack();
                }
                throw ex;
            }
        }

    
    }
}