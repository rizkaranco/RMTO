using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeAssignmentDAL
{
    class DALLadeAssignment_T : DataLayerBase
    {

        public DALLadeAssignment_T()
            : base(Hepsa.Core.Common.ConnectionString.ConnectionString)
        {
        }

        public void Insert(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_Add]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Output;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);

                SqlParameter LadingDate_nvc = new SqlParameter();
                LadingDate_nvc.ParameterName = "@LadingDate_nvc";
                LadingDate_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingDate_nvc.Direction = ParameterDirection.Input;
                LadingDate_nvc.IsNullable = false;
                LadingDate_nvc.Value = businessObject.LadingDate_nvc;
                this.Command.Parameters.Add(LadingDate_nvc);

                SqlParameter LadingTime_nvc = new SqlParameter();
                LadingTime_nvc.ParameterName = "@LadingTime_nvc";
                LadingTime_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingTime_nvc.Direction = ParameterDirection.Input;
                LadingTime_nvc.IsNullable = false;
                LadingTime_nvc.Value = businessObject.LadingTime_nvc;
                this.Command.Parameters.Add(LadingTime_nvc);

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObject.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);

                SqlParameter CityID_int = new SqlParameter();
                CityID_int.ParameterName = "@CityID_int";
                CityID_int.SqlDbType = SqlDbType.Int;
                CityID_int.Direction = ParameterDirection.Input;
                CityID_int.IsNullable = false;
                CityID_int.Value = businessObject.CityID_int;
                this.Command.Parameters.Add(CityID_int);

                SqlParameter CityCode_nvc = new SqlParameter();
                CityCode_nvc.ParameterName = "@CityCode_nvc";
                CityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CityCode_nvc.Direction = ParameterDirection.Input;
                CityCode_nvc.IsNullable = false;
                CityCode_nvc.Value = businessObject.CityCode_nvc;
                this.Command.Parameters.Add(CityCode_nvc);

                SqlParameter Address_nvc = new SqlParameter();
                Address_nvc.ParameterName = "@Address_nvc";
                Address_nvc.SqlDbType = SqlDbType.NVarChar;
                Address_nvc.Direction = ParameterDirection.Input;
                Address_nvc.IsNullable = false;
                Address_nvc.Value = businessObject.Address_nvc;
                this.Command.Parameters.Add(Address_nvc);

                SqlParameter GoodID_int = new SqlParameter();
                GoodID_int.ParameterName = "@GoodID_int";
                GoodID_int.SqlDbType = SqlDbType.Int;
                GoodID_int.Direction = ParameterDirection.Input;
                GoodID_int.IsNullable = false;
                GoodID_int.Value = businessObject.GoodID_int;
                this.Command.Parameters.Add(GoodID_int);

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObject.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);

                SqlParameter MinWeight_dec = new SqlParameter();
                MinWeight_dec.ParameterName = "@MinWeight_dec";
                MinWeight_dec.SqlDbType = SqlDbType.Decimal;
                MinWeight_dec.Direction = ParameterDirection.Input;
                MinWeight_dec.IsNullable = false;
                MinWeight_dec.Value = businessObject.MinWeight_dec;
                this.Command.Parameters.Add(MinWeight_dec);

                SqlParameter MaxWeight_dec = new SqlParameter();
                MaxWeight_dec.ParameterName = "@MaxWeight_dec";
                MaxWeight_dec.SqlDbType = SqlDbType.Decimal;
                MaxWeight_dec.Direction = ParameterDirection.Input;
                MaxWeight_dec.IsNullable = true;
                if (businessObject.MaxWeight_dec.HasValue == false)
                {
                    MaxWeight_dec.Value = DBNull.Value;
                }
                else
                {
                    MaxWeight_dec.Value = businessObject.MaxWeight_dec;
                }
                this.Command.Parameters.Add(MaxWeight_dec);

                SqlParameter PortageFee_dec = new SqlParameter();
                PortageFee_dec.ParameterName = "@PortageFee_dec";
                PortageFee_dec.SqlDbType = SqlDbType.Decimal;
                PortageFee_dec.Direction = ParameterDirection.Input;
                PortageFee_dec.IsNullable = false;
                PortageFee_dec.Value = businessObject.PortageFee_dec;
                this.Command.Parameters.Add(PortageFee_dec);

                SqlParameter PortPlaceID_int = new SqlParameter();
                PortPlaceID_int.ParameterName = "@PortPlaceID_int";
                PortPlaceID_int.SqlDbType = SqlDbType.Int;
                PortPlaceID_int.Direction = ParameterDirection.Input;
                PortPlaceID_int.IsNullable = false;
                PortPlaceID_int.Value = businessObject.PortPlaceID_int;
                this.Command.Parameters.Add(PortPlaceID_int);

                SqlParameter CarCount_int = new SqlParameter();
                CarCount_int.ParameterName = "@CarCount_int";
                CarCount_int.SqlDbType = SqlDbType.Int;
                CarCount_int.Direction = ParameterDirection.Input;
                CarCount_int.IsNullable = false;
                CarCount_int.Value = businessObject.CarCount_int;
                this.Command.Parameters.Add(CarCount_int);

                SqlParameter Conditin_nvc = new SqlParameter();
                Conditin_nvc.ParameterName = "@Conditin_nvc";
                Conditin_nvc.SqlDbType = SqlDbType.NVarChar;
                Conditin_nvc.Direction = ParameterDirection.Input;
                Conditin_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Conditin_nvc))
                {
                    Conditin_nvc.Value = DBNull.Value;
                }
                else
                {
                    Conditin_nvc.Value = businessObject.Conditin_nvc;
                }
                this.Command.Parameters.Add(Conditin_nvc);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = false;
                CompanyID_int.Value = businessObject.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = false;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.MacAddress_nvc))
                {
                    MacAddress_nvc.Value = DBNull.Value;
                }
                else
                {
                    MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                }
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter IPAddress_nvc = new SqlParameter();
                IPAddress_nvc.ParameterName = "@IPAddress_nvc";
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                IPAddress_nvc.Direction = ParameterDirection.Input;
                IPAddress_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.IPAddress_nvc))
                {
                    IPAddress_nvc.Value = DBNull.Value;
                }
                else
                {
                    IPAddress_nvc.Value = businessObject.IPAddress_nvc;
                }
                this.Command.Parameters.Add(IPAddress_nvc);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = false;
                Date_nvc.Value = businessObject.Date_nvc;
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Time_nvc = new SqlParameter();
                Time_nvc.ParameterName = "@Time_nvc";
                Time_nvc.SqlDbType = SqlDbType.NVarChar;
                Time_nvc.Direction = ParameterDirection.Input;
                Time_nvc.IsNullable = false;
                Time_nvc.Value = businessObject.Time_nvc;
                this.Command.Parameters.Add(Time_nvc);

                SqlParameter PortPlaces_nvc = new SqlParameter();
                PortPlaces_nvc.ParameterName = "@PortPlaces_nvc";
                PortPlaces_nvc.SqlDbType = SqlDbType.NVarChar;
                PortPlaces_nvc.Direction = ParameterDirection.Input;
                PortPlaces_nvc.IsNullable = false;
                PortPlaces_nvc.Value = businessObject.PortPlaces_nvc;
                this.Command.Parameters.Add(PortPlaces_nvc);

                SqlParameter Accepted_bit = new SqlParameter();
                Accepted_bit.ParameterName = "@Accepted_bit";
                Accepted_bit.SqlDbType = SqlDbType.Bit;
                Accepted_bit.Direction = ParameterDirection.Input;
                Accepted_bit.IsNullable = false;
                Accepted_bit.Value = businessObject.Accepted_bit;
                this.Command.Parameters.Add(Accepted_bit);


                SqlParameter AcceptUserName_nvc = new SqlParameter();
                AcceptUserName_nvc.ParameterName = "@AcceptUserName_nvc";
                AcceptUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptUserName_nvc.Direction = ParameterDirection.Input;
                AcceptUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptUserName_nvc))
                {
                    AcceptUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptUserName_nvc.Value = businessObject.AcceptUserName_nvc;
                }
                this.Command.Parameters.Add(AcceptUserName_nvc);
                //
                SqlParameter AcceptDate_vc = new SqlParameter();
                AcceptDate_vc.ParameterName = "@AcceptDate_vc";
                AcceptDate_vc.SqlDbType = SqlDbType.VarChar;
                AcceptDate_vc.Direction = ParameterDirection.Input;
                AcceptDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptDate_vc))
                {
                    AcceptDate_vc.Value = DBNull.Value;
                }
                else
                {
                    AcceptDate_vc.Value = businessObject.AcceptDate_vc;
                }
                this.Command.Parameters.Add(AcceptDate_vc);
                // 
                SqlParameter AcceptTime_vc = new SqlParameter();
                AcceptTime_vc.ParameterName = "@AcceptTime_vc";
                AcceptTime_vc.SqlDbType = SqlDbType.VarChar;
                AcceptTime_vc.Direction = ParameterDirection.Input;
                AcceptTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptTime_vc))
                {
                    AcceptTime_vc.Value = DBNull.Value;
                }
                else
                {
                    AcceptTime_vc.Value = businessObject.AcceptTime_vc;
                }
                this.Command.Parameters.Add(AcceptTime_vc);

                SqlParameter EditUserName_nvc = new SqlParameter();
                EditUserName_nvc.ParameterName = "@EditUserName_nvc";
                EditUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                EditUserName_nvc.Direction = ParameterDirection.Input;
                EditUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EditUserName_nvc))
                {
                    EditUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    EditUserName_nvc.Value = businessObject.EditUserName_nvc;
                }
                this.Command.Parameters.Add(EditUserName_nvc);
                //
                SqlParameter EditDate_vc = new SqlParameter();
                EditDate_vc.ParameterName = "@EditDate_vc";
                EditDate_vc.SqlDbType = SqlDbType.VarChar;
                EditDate_vc.Direction = ParameterDirection.Input;
                EditDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EditDate_vc))
                {
                    EditDate_vc.Value = DBNull.Value;
                }
                else
                {
                    EditDate_vc.Value = businessObject.EditDate_vc;
                }
                this.Command.Parameters.Add(EditDate_vc);
                // 
                SqlParameter EditTime_vc = new SqlParameter();
                EditTime_vc.ParameterName = "@EditTime_vc";
                EditTime_vc.SqlDbType = SqlDbType.VarChar;
                EditTime_vc.Direction = ParameterDirection.Input;
                EditTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EditTime_vc))
                {
                    EditTime_vc.Value = DBNull.Value;
                }
                else
                {
                    EditTime_vc.Value = businessObject.EditTime_vc;
                }
                this.Command.Parameters.Add(EditTime_vc);

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.ExecuteNonQuery();

                businessObject.LadeAssignmentID_bint = (Int64?)(this.Command.Parameters["@LadeAssignmentID_bint"].Value);

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

        public void Update(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject, HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_Update]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadingDate_nvc = new SqlParameter();
                LadingDate_nvc.ParameterName = "@LadingDate_nvc";
                LadingDate_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingDate_nvc.Direction = ParameterDirection.Input;
                LadingDate_nvc.IsNullable = false;
                LadingDate_nvc.Value = businessObject.LadingDate_nvc;
                this.Command.Parameters.Add(LadingDate_nvc);

                SqlParameter LadingTime_nvc = new SqlParameter();
                LadingTime_nvc.ParameterName = "@LadingTime_nvc";
                LadingTime_nvc.SqlDbType = SqlDbType.NVarChar;
                LadingTime_nvc.Direction = ParameterDirection.Input;
                LadingTime_nvc.IsNullable = false;
                LadingTime_nvc.Value = businessObject.LadingTime_nvc;
                this.Command.Parameters.Add(LadingTime_nvc);

                SqlParameter AnnouncementTimeID_int = new SqlParameter();
                AnnouncementTimeID_int.ParameterName = "@AnnouncementTimeID_int";
                AnnouncementTimeID_int.SqlDbType = SqlDbType.Int;
                AnnouncementTimeID_int.Direction = ParameterDirection.Input;
                AnnouncementTimeID_int.IsNullable = false;
                AnnouncementTimeID_int.Value = businessObject.AnnouncementTimeID_int;
                this.Command.Parameters.Add(AnnouncementTimeID_int);

                SqlParameter CityID_int = new SqlParameter();
                CityID_int.ParameterName = "@CityID_int";
                CityID_int.SqlDbType = SqlDbType.Int;
                CityID_int.Direction = ParameterDirection.Input;
                CityID_int.IsNullable = false;
                CityID_int.Value = businessObject.CityID_int;
                this.Command.Parameters.Add(CityID_int);

                SqlParameter CityCode_nvc = new SqlParameter();
                CityCode_nvc.ParameterName = "@CityCode_nvc";
                CityCode_nvc.SqlDbType = SqlDbType.NVarChar;
                CityCode_nvc.Direction = ParameterDirection.Input;
                CityCode_nvc.IsNullable = false;
                CityCode_nvc.Value = businessObject.CityCode_nvc;
                this.Command.Parameters.Add(CityCode_nvc);

                SqlParameter Address_nvc = new SqlParameter();
                Address_nvc.ParameterName = "@Address_nvc";
                Address_nvc.SqlDbType = SqlDbType.NVarChar;
                Address_nvc.Direction = ParameterDirection.Input;
                Address_nvc.IsNullable = false;
                Address_nvc.Value = businessObject.Address_nvc;
                this.Command.Parameters.Add(Address_nvc);

                SqlParameter GoodID_int = new SqlParameter();
                GoodID_int.ParameterName = "@GoodID_int";
                GoodID_int.SqlDbType = SqlDbType.Int;
                GoodID_int.Direction = ParameterDirection.Input;
                GoodID_int.IsNullable = false;
                GoodID_int.Value = businessObject.GoodID_int;
                this.Command.Parameters.Add(GoodID_int);

                SqlParameter BoxingID_int = new SqlParameter();
                BoxingID_int.ParameterName = "@BoxingID_int";
                BoxingID_int.SqlDbType = SqlDbType.Int;
                BoxingID_int.Direction = ParameterDirection.Input;
                BoxingID_int.IsNullable = false;
                BoxingID_int.Value = businessObject.BoxingID_int;
                this.Command.Parameters.Add(BoxingID_int);

                SqlParameter MinWeight_dec = new SqlParameter();
                MinWeight_dec.ParameterName = "@MinWeight_dec";
                MinWeight_dec.SqlDbType = SqlDbType.Decimal;
                MinWeight_dec.Direction = ParameterDirection.Input;
                MinWeight_dec.IsNullable = false;
                MinWeight_dec.Value = businessObject.MinWeight_dec;
                this.Command.Parameters.Add(MinWeight_dec);

                SqlParameter MaxWeight_dec = new SqlParameter();
                MaxWeight_dec.ParameterName = "@MaxWeight_dec";
                MaxWeight_dec.SqlDbType = SqlDbType.Decimal;
                MaxWeight_dec.Direction = ParameterDirection.Input;
                MaxWeight_dec.IsNullable = false;
                if (businessObject.MaxWeight_dec.HasValue == false)
                {
                    MaxWeight_dec.Value = DBNull.Value;
                }
                else
                {
                    MaxWeight_dec.Value = businessObject.MaxWeight_dec;
                }
                this.Command.Parameters.Add(MaxWeight_dec);

                SqlParameter PortageFee_dec = new SqlParameter();
                PortageFee_dec.ParameterName = "@PortageFee_dec";
                PortageFee_dec.SqlDbType = SqlDbType.Decimal;
                PortageFee_dec.Direction = ParameterDirection.Input;
                PortageFee_dec.IsNullable = true;
                PortageFee_dec.Value = businessObject.PortageFee_dec;
                this.Command.Parameters.Add(PortageFee_dec);

                SqlParameter PortPlaceID_int = new SqlParameter();
                PortPlaceID_int.ParameterName = "@PortPlaceID_int";
                PortPlaceID_int.SqlDbType = SqlDbType.Int;
                PortPlaceID_int.Direction = ParameterDirection.Input;
                PortPlaceID_int.IsNullable = false;
                PortPlaceID_int.Value = businessObject.PortPlaceID_int;
                this.Command.Parameters.Add(PortPlaceID_int);

                SqlParameter CarCount_int = new SqlParameter();
                CarCount_int.ParameterName = "@CarCount_int";
                CarCount_int.SqlDbType = SqlDbType.Int;
                CarCount_int.Direction = ParameterDirection.Input;
                CarCount_int.IsNullable = false;
                CarCount_int.Value = businessObject.CarCount_int;
                this.Command.Parameters.Add(CarCount_int);

                SqlParameter Conditin_nvc = new SqlParameter();
                Conditin_nvc.ParameterName = "@Conditin_nvc";
                Conditin_nvc.SqlDbType = SqlDbType.NVarChar;
                Conditin_nvc.Direction = ParameterDirection.Input;
                Conditin_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.Conditin_nvc))
                {
                    Conditin_nvc.Value = DBNull.Value;
                }
                else
                {
                    Conditin_nvc.Value = businessObject.Conditin_nvc;
                }
                this.Command.Parameters.Add(Conditin_nvc);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.SqlDbType = SqlDbType.Int;
                CompanyID_int.Direction = ParameterDirection.Input;
                CompanyID_int.IsNullable = true;
                CompanyID_int.Value = businessObject.CompanyID_int;
                this.Command.Parameters.Add(CompanyID_int);

                SqlParameter Comment_nvc = new SqlParameter();
                Comment_nvc.ParameterName = "@Comment_nvc";
                Comment_nvc.SqlDbType = SqlDbType.NVarChar;
                Comment_nvc.Direction = ParameterDirection.Input;
                Comment_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.Comment_nvc))
                {
                    Comment_nvc.Value = DBNull.Value;
                }
                else
                {
                    Comment_nvc.Value = businessObject.Comment_nvc;
                }
                this.Command.Parameters.Add(Comment_nvc);

                SqlParameter UserName_nvc = new SqlParameter();
                UserName_nvc.ParameterName = "@UserName_nvc";
                UserName_nvc.SqlDbType = SqlDbType.NVarChar;
                UserName_nvc.Direction = ParameterDirection.Input;
                UserName_nvc.IsNullable = true;
                UserName_nvc.Value = businessObject.UserName_nvc;
                this.Command.Parameters.Add(UserName_nvc);

                SqlParameter MacAddress_nvc = new SqlParameter();
                MacAddress_nvc.ParameterName = "@MacAddress_nvc";
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                MacAddress_nvc.Direction = ParameterDirection.Input;
                MacAddress_nvc.IsNullable = false;
                if (String.IsNullOrEmpty(businessObject.MacAddress_nvc))
                {
                    MacAddress_nvc.Value = DBNull.Value;
                }
                else
                {
                    MacAddress_nvc.Value = businessObject.MacAddress_nvc;
                }
                this.Command.Parameters.Add(MacAddress_nvc);

                SqlParameter IPAddress_nvc = new SqlParameter();
                IPAddress_nvc.ParameterName = "@IPAddress_nvc";
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar;
                IPAddress_nvc.Direction = ParameterDirection.Input;
                IPAddress_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.IPAddress_nvc))
                {
                    IPAddress_nvc.Value = DBNull.Value;
                }
                else
                {
                    IPAddress_nvc.Value = businessObject.IPAddress_nvc;
                }
                this.Command.Parameters.Add(IPAddress_nvc);

                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                Date_nvc.Value = businessObject.Date_nvc;
                this.Command.Parameters.Add(Date_nvc);

                SqlParameter Time_nvc = new SqlParameter();
                Time_nvc.ParameterName = "@Time_nvc";
                Time_nvc.SqlDbType = SqlDbType.NVarChar;
                Time_nvc.Direction = ParameterDirection.Input;
                Time_nvc.IsNullable = false;
                Time_nvc.Value = businessObject.Time_nvc;
                this.Command.Parameters.Add(Time_nvc);

                SqlParameter PortPlaces_nvc = new SqlParameter();
                PortPlaces_nvc.ParameterName = "@PortPlaces_nvc";
                PortPlaces_nvc.SqlDbType = SqlDbType.NVarChar;
                PortPlaces_nvc.Direction = ParameterDirection.Input;
                PortPlaces_nvc.IsNullable = false;
                PortPlaces_nvc.Value = businessObject.PortPlaces_nvc;
                this.Command.Parameters.Add(PortPlaces_nvc);

                SqlParameter Accepted_bit = new SqlParameter();
                Accepted_bit.ParameterName = "@Accepted_bit";
                Accepted_bit.SqlDbType = SqlDbType.Bit;
                Accepted_bit.Direction = ParameterDirection.Input;
                Accepted_bit.IsNullable = false;
                Accepted_bit.Value = businessObject.Accepted_bit;
                this.Command.Parameters.Add(Accepted_bit);

                SqlParameter AcceptUserName_nvc = new SqlParameter();
                AcceptUserName_nvc.ParameterName = "@AcceptUserName_nvc";
                AcceptUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                AcceptUserName_nvc.Direction = ParameterDirection.Input;
                AcceptUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptUserName_nvc))
                {
                    AcceptUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    AcceptUserName_nvc.Value = businessObject.AcceptUserName_nvc;
                }
                this.Command.Parameters.Add(AcceptUserName_nvc);
                //
                SqlParameter AcceptDate_vc = new SqlParameter();
                AcceptDate_vc.ParameterName = "@AcceptDate_vc";
                AcceptDate_vc.SqlDbType = SqlDbType.VarChar;
                AcceptDate_vc.Direction = ParameterDirection.Input;
                AcceptDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptDate_vc))
                {
                    AcceptDate_vc.Value = DBNull.Value;
                }
                else
                {
                    AcceptDate_vc.Value = businessObject.AcceptDate_vc;
                }
                this.Command.Parameters.Add(AcceptDate_vc);
                // 
                SqlParameter AcceptTime_vc = new SqlParameter();
                AcceptTime_vc.ParameterName = "@AcceptTime_vc";
                AcceptTime_vc.SqlDbType = SqlDbType.VarChar;
                AcceptTime_vc.Direction = ParameterDirection.Input;
                AcceptTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.AcceptTime_vc))
                {
                    AcceptTime_vc.Value = DBNull.Value;
                }
                else
                {
                    AcceptTime_vc.Value = businessObject.AcceptTime_vc;
                }
                this.Command.Parameters.Add(AcceptTime_vc);

                SqlParameter EditUserName_nvc = new SqlParameter();
                EditUserName_nvc.ParameterName = "@EditUserName_nvc";
                EditUserName_nvc.SqlDbType = SqlDbType.NVarChar;
                EditUserName_nvc.Direction = ParameterDirection.Input;
                EditUserName_nvc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EditUserName_nvc))
                {
                    EditUserName_nvc.Value = DBNull.Value;
                }
                else
                {
                    EditUserName_nvc.Value = businessObject.EditUserName_nvc;
                }
                this.Command.Parameters.Add(EditUserName_nvc);
                //
                SqlParameter EditDate_vc = new SqlParameter();
                EditDate_vc.ParameterName = "@EditDate_vc";
                EditDate_vc.SqlDbType = SqlDbType.VarChar;
                EditDate_vc.Direction = ParameterDirection.Input;
                EditDate_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EditDate_vc))
                {
                    EditDate_vc.Value = DBNull.Value;
                }
                else
                {
                    EditDate_vc.Value = businessObject.EditDate_vc;
                }
                this.Command.Parameters.Add(EditDate_vc);
                // 
                SqlParameter EditTime_vc = new SqlParameter();
                EditTime_vc.ParameterName = "@EditTime_vc";
                EditTime_vc.SqlDbType = SqlDbType.VarChar;
                EditTime_vc.Direction = ParameterDirection.Input;
                EditTime_vc.IsNullable = true;
                if (String.IsNullOrEmpty(businessObject.EditTime_vc))
                {
                    EditTime_vc.Value = DBNull.Value;
                }
                else
                {
                    EditTime_vc.Value = businessObject.EditTime_vc;
                }
                this.Command.Parameters.Add(EditTime_vc);

                SqlParameter pk_LadeAssignmentID_bint = new SqlParameter();
                pk_LadeAssignmentID_bint.ParameterName = "@pk_LadeAssignmentID_bint";
                pk_LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                pk_LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                pk_LadeAssignmentID_bint.IsNullable = false;
                pk_LadeAssignmentID_bint.Value = businessObjectKey.LadeAssignmentID_bint;
                this.Command.Parameters.Add(pk_LadeAssignmentID_bint);

                


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

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> SelectAll()
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAll]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> Result = new List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T>();
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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAll]";
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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAll]";
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

        public HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T SelectByPrimaryKey(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObjectKey.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);



                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                IDataReader dataReader = this.Command.ExecuteReader();
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
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

        public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey, ref System.Data.DataSet dataset, String srcTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObjectKey.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey, ref System.Data.DataSet dataset)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObjectKey.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);


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

        public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey, ref  System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObjectKey.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);



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

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> SelectByField(String fieldName, Object value)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {

                this.Command.Parameters.Clear();

                if (ControlConnection)
                {
                    this.BeginTransaction();
                }

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

                IDataReader dataReader = this.Command.ExecuteReader();
                List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> Result = new List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T>();
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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition", "[LadeAssignment_T]." + fieldName + " = N" + "'" + value.ToString() + "'"));

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

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> SelectByCondition(String Condition)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
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
                List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> Result = new List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T>();
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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
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
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectCondition]";
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

        public void SelectByCondition(String Condition, Int32? SaloonID_int, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAllWithCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;
            try
            {
                this.Command.Parameters.Clear();

                this.Command.Parameters.Add(new SqlParameter("@Condition_nvc", Condition));

                SqlParameter SaloonID_intParam = new SqlParameter();
                SaloonID_intParam.ParameterName = "@SaloonID_int";
                SaloonID_intParam.SqlDbType = SqlDbType.Int;
                SaloonID_intParam.Direction = ParameterDirection.Input;
                SaloonID_intParam.IsNullable = true;
                if (SaloonID_int.HasValue)
                {
                   SaloonID_intParam.Value = SaloonID_int;
                }
                else
                {
                    SaloonID_intParam.Value = DBNull.Value;
                }

                this.Command.Parameters.Add(SaloonID_intParam);

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

        public void Delete(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_TKeys businessObjectKey)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            this.Command.CommandText = "[sp_LadeAssignment_T_DeleteByPrimaryKey]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bint = new SqlParameter();
                LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
                LadeAssignmentID_bint.Direction = ParameterDirection.Input;
                LadeAssignmentID_bint.IsNullable = false;
                LadeAssignmentID_bint.Value = businessObjectKey.LadeAssignmentID_bint;
                this.Command.Parameters.Add(LadeAssignmentID_bint);


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
            this.Command.CommandText = "[sp_LadeAssignment_T_DeleteByField]";
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

        public void PopulateBusinessObjectFromReader(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject, IDataReader dataReader)
        {
            businessObject.LadeAssignmentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadeAssignmentID_bint.ToString()));
            businessObject.LadingDate_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadingDate_nvc.ToString()));
            businessObject.LadingTime_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.LadingTime_nvc.ToString()));
            businessObject.AnnouncementTimeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AnnouncementTimeID_int.ToString()));
            businessObject.CityID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CityID_int.ToString()));
            businessObject.CityCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CityCode_nvc.ToString()));
            businessObject.Address_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Address_nvc.ToString()));
            businessObject.GoodID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.GoodID_int.ToString()));
            businessObject.BoxingID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.BoxingID_int.ToString()));
            businessObject.MinWeight_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MinWeight_dec.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MaxWeight_dec.ToString())) == false)
            {
                businessObject.MaxWeight_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MaxWeight_dec.ToString()));
            }
            else
            {
                businessObject.MaxWeight_dec = null;
            }

            businessObject.PortageFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortageFee_dec.ToString()));
            businessObject.PortPlaceID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortPlaceID_int.ToString()));
            businessObject.CarCount_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CarCount_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Conditin_nvc.ToString())) == false)
            {
                businessObject.Conditin_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Conditin_nvc.ToString()));
            }
            else
            {
                businessObject.Conditin_nvc = String.Empty;
            }

            businessObject.CompanyID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.CompanyID_int.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Comment_nvc.ToString())) == false)
            {
                businessObject.Comment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Comment_nvc.ToString()));
            }
            else
            {
                businessObject.Comment_nvc = String.Empty;
            }

            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.UserName_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MacAddress_nvc.ToString())) == false)
            {
                businessObject.MacAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.MacAddress_nvc.ToString()));
            }
            else
            {
                businessObject.MacAddress_nvc = String.Empty;
            }

            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.IPAddress_nvc.ToString())) == false)
            {
                businessObject.IPAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.IPAddress_nvc.ToString()));
            }
            else
            {
                businessObject.IPAddress_nvc = String.Empty;
            }

            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Date_nvc.ToString()));
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Time_nvc.ToString()));
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortPlaces_nvc.ToString())) == false)
            {
                businessObject.PortPlaces_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.PortPlaces_nvc.ToString()));
            }
            else
            {
                businessObject.PortPlaces_nvc = String.Empty;
            }
            businessObject.Accepted_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.Accepted_bit.ToString()));


           
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AcceptUserName_nvc.ToString())) == false)
            {
                businessObject.AcceptUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AcceptUserName_nvc.ToString()));
            }
            else
            {
                businessObject.AcceptUserName_nvc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AcceptDate_vc.ToString())) == false)
            {
                businessObject.AcceptDate_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AcceptDate_vc.ToString()));
            }
            else
            {
                businessObject.AcceptDate_vc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AcceptTime_vc.ToString())) == false)
            {
                businessObject.AcceptTime_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.AcceptTime_vc.ToString()));
            }
            else
            {
                businessObject.AcceptTime_vc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.EditUserName_nvc.ToString())) == false)
            {
                businessObject.EditUserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.EditUserName_nvc.ToString()));
            }
            else
            {
                businessObject.EditUserName_nvc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.EditDate_vc.ToString())) == false)
            {
                businessObject.EditDate_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.EditDate_vc.ToString()));
            }
            else
            {
                businessObject.EditDate_vc = String.Empty;
            }
            //
            if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.EditTime_vc.ToString())) == false)
            {
                businessObject.EditTime_vc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T.LadeAssignment_TField.EditTime_vc.ToString()));
            }
            else
            {
                businessObject.EditTime_vc = String.Empty;
            }
        }

        public List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> PopulateObjectsFromReader(IDataReader dataReader)
        {
            List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T> list = new List<HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T>();
            while (dataReader.Read())
            {
                HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T businessObject = new HPS.BLL.LadeAssignmentBLL.BLLLadeAssignment_T();
                PopulateBusinessObjectFromReader(businessObject, dataReader);
                list.Add(businessObject);
            }
            return list;
        }

        //LaterAdded
        public void SelectAllActives(ref System.Data.DataTable dataTable, string LaderTypesID_nvc)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAllActives]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();


                SqlParameter LaderTypesID_nvcParam = new SqlParameter();
                LaderTypesID_nvcParam.ParameterName = "@LadertypeIDs_nvc";
                LaderTypesID_nvcParam.SqlDbType = SqlDbType.NVarChar;
                LaderTypesID_nvcParam.Direction = ParameterDirection.Input;
                LaderTypesID_nvcParam.IsNullable = true;
                if (!string.IsNullOrEmpty(LaderTypesID_nvc))
                {
                    LaderTypesID_nvcParam.Value = LaderTypesID_nvc;
                }
                else
                    LaderTypesID_nvcParam.Value = DBNull.Value;
                
                this.Command.Parameters.Add(LaderTypesID_nvcParam);

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

        public void SelectAllLadBillCount(string Date,Int32 SaloonID_int, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_LadBill]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();
                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Date))
                {
                    Date_nvc.Value = DBNull.Value;
                }
                else
                {
                    Date_nvc.Value = Date;
                }

                this.Command.Parameters.Add(Date_nvc);


                SqlParameter SaloonID_intParam = new SqlParameter();
                SaloonID_intParam.ParameterName = "@SaloonID_int";
                SaloonID_intParam.SqlDbType = SqlDbType.Int;
                SaloonID_intParam.Direction = ParameterDirection.Input;
                SaloonID_intParam.IsNullable = true;
                if (SaloonID_int==0)
                {
                    SaloonID_intParam.Value = DBNull.Value;
                }
                else
                {
                    SaloonID_intParam.Value = SaloonID_int;
                }

                this.Command.Parameters.Add(SaloonID_intParam);

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

       

        public void SelectByConditionReport(String Condition, ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectConditionReport]";
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

        public void SelectAllLadBillCreditUsedLadBill(ref System.Data.DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadBillCredit_WithUsedLadBill]";
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

        public void SelectAll(ref System.Data.DataTable dataTable, string Date,int SaloonID_int)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "[sp_LadeAssignment_T_SelectAllWithDateCondition]";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();
                SqlParameter Date_nvc = new SqlParameter();
                Date_nvc.ParameterName = "@Date_nvc";
                Date_nvc.SqlDbType = SqlDbType.NVarChar;
                Date_nvc.Direction = ParameterDirection.Input;
                Date_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(Date))
                {
                    Date_nvc.Value = DBNull.Value;
                }
                else
                {
                    Date_nvc.Value = Date;
                }

                this.Command.Parameters.Add(Date_nvc);


                SqlParameter SaloonID_intParam = new SqlParameter();
                SaloonID_intParam.ParameterName = "@SaloonID_int";
                SaloonID_intParam.SqlDbType = SqlDbType.Int;
                SaloonID_intParam.Direction = ParameterDirection.Input;
                SaloonID_intParam.IsNullable = true;
                if (SaloonID_int==0)
                {
                    SaloonID_intParam.Value = DBNull.Value;
                }
                else
                {
                    SaloonID_intParam.Value = SaloonID_int;
                }

                this.Command.Parameters.Add(SaloonID_intParam);

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

        public void SelectLaderTypeCountReport(string FromDate, string FromTime, string ToDate, string ToTime,string LaderTypeIDList_nvc, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "SP_LaderType_Count";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                SqlParameter LaderTypeIDList = new SqlParameter();
                LaderTypeIDList.ParameterName = "@LaderTypeList";
                LaderTypeIDList.Direction = ParameterDirection.Input;
                LaderTypeIDList.SqlDbType = SqlDbType.NVarChar;
                LaderTypeIDList.IsNullable = true;
                if (string.IsNullOrEmpty(LaderTypeIDList_nvc))
                {
                    LaderTypeIDList.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeIDList.Value = LaderTypeIDList_nvc;
                }

                this.Command.Parameters.Add(LaderTypeIDList);
                
                
                
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

        public void SelectCompanyLadeAssignmentDetail(string FromDate, string FromTime, string ToDate, string ToTime, string LaderTypeID, string CompanyID, string GoodIDList_nvc, String DesticationCityIDList_nvc, String PortPlaceIDList_nvc, string OrderColumns_nvc, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_LadeAssignment_T_RemainedDetail";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                SqlParameter LaderTypeID_int = new SqlParameter();
                LaderTypeID_int.ParameterName = "@LaderTypeID_int";
                LaderTypeID_int.Direction = ParameterDirection.Input;
                LaderTypeID_int.SqlDbType = SqlDbType.NVarChar ;
                LaderTypeID_int.IsNullable = true;
                if (String.IsNullOrEmpty(LaderTypeID))
                {
                    LaderTypeID_int.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeID_int.Value = LaderTypeID;
                }

                this.Command.Parameters.Add(LaderTypeID_int);

                SqlParameter CompanyID_int = new SqlParameter();
                CompanyID_int.ParameterName = "@CompanyID_int";
                CompanyID_int.Direction = ParameterDirection.Input ;
                CompanyID_int.SqlDbType = SqlDbType.NVarChar ;
                CompanyID_int.IsNullable = true;
                if (String.IsNullOrEmpty(CompanyID))
                {
                    CompanyID_int.Value = DBNull.Value;
                }
                else
                {
                    CompanyID_int.Value = CompanyID;
                }

                this.Command.Parameters.Add(CompanyID_int);


                SqlParameter GoodIDList = new SqlParameter();
                GoodIDList.ParameterName = "@GoodIDList_nvc";
                GoodIDList.Direction = ParameterDirection.Input;
                GoodIDList.SqlDbType = SqlDbType.NVarChar;
                GoodIDList.IsNullable = true;
                if (string.IsNullOrEmpty(GoodIDList_nvc))
                {
                    GoodIDList.Value = DBNull.Value;
                }
                else
                {
                    GoodIDList.Value = GoodIDList_nvc;
                }
                this.Command.Parameters.Add(GoodIDList);


                SqlParameter DesticationCityIDList = new SqlParameter();
                DesticationCityIDList.ParameterName = "@DestinationCityIDList_nvc";
                DesticationCityIDList.Direction = ParameterDirection.Input;
                DesticationCityIDList.SqlDbType = SqlDbType.NVarChar;
                DesticationCityIDList.IsNullable = true;
                if (string.IsNullOrEmpty(DesticationCityIDList_nvc))
                {
                    DesticationCityIDList.Value = DBNull.Value;
                }
                else
                {
                    DesticationCityIDList.Value = DesticationCityIDList_nvc;
                }
                this.Command.Parameters.Add(DesticationCityIDList);



                SqlParameter PortPlaceIDList = new SqlParameter();
                PortPlaceIDList.ParameterName = "@PortPlaceIDList_nvc";
                PortPlaceIDList.Direction = ParameterDirection.Input;
                PortPlaceIDList.SqlDbType = SqlDbType.NVarChar;
                PortPlaceIDList.IsNullable = true;
                if (string.IsNullOrEmpty(PortPlaceIDList_nvc))
                {
                    PortPlaceIDList.Value = DBNull.Value;
                }
                else
                {
                    PortPlaceIDList.Value = PortPlaceIDList_nvc;
                }
                this.Command.Parameters.Add(PortPlaceIDList);


                
                SqlParameter OrderColumns_nvcParam = new SqlParameter();
                OrderColumns_nvcParam.ParameterName = "@OrderColumns_nvc";
                OrderColumns_nvcParam.Direction = ParameterDirection.Input;
                OrderColumns_nvcParam.SqlDbType = SqlDbType.NVarChar;
                OrderColumns_nvcParam.IsNullable = true;
                if (string.IsNullOrEmpty(OrderColumns_nvc))
                {
                    OrderColumns_nvcParam.Value = DBNull.Value;
                }
                else
                {
                    OrderColumns_nvcParam.Value = OrderColumns_nvc;
                }
                this.Command.Parameters.Add(OrderColumns_nvcParam);

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

        public void SelectLaderTypeCountWithDateReport(string FromDate, string FromTime, string ToDate, string ToTime,String LaderTypeList, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_LaderType_CountWithDate";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

                SqlParameter LaderTypeList_nvc = new SqlParameter();
                LaderTypeList_nvc.ParameterName = "@LaderTypeList";
                LaderTypeList_nvc.Direction = ParameterDirection.Input;
                LaderTypeList_nvc.SqlDbType = SqlDbType.NVarChar;
                LaderTypeList_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(LaderTypeList))
                {
                    LaderTypeList_nvc.Value = DBNull.Value;
                }
                else
                {
                    LaderTypeList_nvc.Value = LaderTypeList;
                }

                this.Command.Parameters.Add(LaderTypeList_nvc);
                this.Command.CommandTimeout = 500;
                
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

        public void SelectLadeUserDetailReport(string FromDate, string FromTime, string ToDate, string ToTime, ref DataTable dataTable)
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_User_T_LadeDetail";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter FromDate_nvc = new SqlParameter();
                FromDate_nvc.ParameterName = "@FromDate_nvc";
                FromDate_nvc.Direction = ParameterDirection.Input;
                FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                FromDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromDate))
                {
                    FromDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromDate_nvc.Value = FromDate;
                }

                this.Command.Parameters.Add(FromDate_nvc);

                SqlParameter FromTime_nvc = new SqlParameter();
                FromTime_nvc.ParameterName = "@FromTime_nvc";
                FromTime_nvc.Direction = ParameterDirection.Input;
                FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                FromTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(FromTime))
                {
                    FromTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    FromTime_nvc.Value = FromTime;
                }

                this.Command.Parameters.Add(FromTime_nvc);

                SqlParameter ToDate_nvc = new SqlParameter();
                ToDate_nvc.ParameterName = "@ToDate_nvc";
                ToDate_nvc.Direction = ParameterDirection.Input;
                ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                ToDate_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToDate))
                {
                    ToDate_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToDate_nvc.Value = ToDate;
                }

                this.Command.Parameters.Add(ToDate_nvc);

                SqlParameter ToTime_nvc = new SqlParameter();
                ToTime_nvc.ParameterName = "@ToTime_nvc";
                ToTime_nvc.Direction = ParameterDirection.Input;
                ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                ToTime_nvc.IsNullable = true;
                if (string.IsNullOrEmpty(ToTime))
                {
                    ToTime_nvc.Value = DBNull.Value;
                }
                else
                {
                    ToTime_nvc.Value = ToTime;
                }

                this.Command.Parameters.Add(ToTime_nvc);

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

         public void SelectLastLadeAssignmentID(out Int64 LadeAssignmentID_bint )
        {
            bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
            SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
            this.Command.CommandText = "sp_LadeAssignment_T_SelectLastAssignmentID";
            this.Command.CommandType = CommandType.StoredProcedure;

            try
            {
                this.Command.Parameters.Clear();

                SqlParameter LadeAssignmentID_bintParam = new SqlParameter();
                LadeAssignmentID_bintParam.ParameterName = "@LadeAssignmentID_bint";
                LadeAssignmentID_bintParam.Direction = ParameterDirection.Output;
                LadeAssignmentID_bintParam.SqlDbType = SqlDbType.BigInt;
                this.Command.Parameters.Add(LadeAssignmentID_bintParam);


                if (ControlConnection)
                {
                    this.BeginTransaction();
                }
                //if (ControlConnection)
                //{
                //    this.Commit();
                //}
                this.Command.ExecuteNonQuery();
                LadeAssignmentID_bint=Convert.ToInt64(LadeAssignmentID_bintParam.Value);

              
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

         public void SelectForAccept(String Condition, ref System.Data.DataTable dataTable)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "[sp_LadeAssignment_T_SelectforAccept]";
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

         public void SelectLadeAssingmentContByLaderType(String Date_nvc, ref DataTable DataTable)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "[sp_SelectLadeAssignmentByLaderType]";
             this.Command.CommandType = CommandType.StoredProcedure;
             try
             {
                 this.Command.Parameters.Clear();

                 SqlParameter Date_vc = new SqlParameter();
                 Date_vc.ParameterName = "@Date_nvc";
                 Date_vc.SqlDbType = SqlDbType.NVarChar;
                 Date_vc.Direction = ParameterDirection.Input;
                 Date_vc.IsNullable = false;
                 Date_vc.Value = Date_nvc;
                 this.Command.Parameters.Add(Date_vc);

                 if (ControlConnection)
                 {
                     this.BeginTransaction();
                 }

                 sqlDataAdapter.Fill(DataTable);

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

         public void SelectRemaindLadAssingmentByLaderType(String Date_nvc, ref DataTable DataTable)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "[sp_SelectRemaindLadAssingmentByLaderType]";
             this.Command.CommandType = CommandType.StoredProcedure;
             try
             {
                 this.Command.Parameters.Clear();

                 SqlParameter Date_vc = new SqlParameter();
                 Date_vc.ParameterName = "@Date_nvc";
                 Date_vc.SqlDbType = SqlDbType.NVarChar;
                 Date_vc.Direction = ParameterDirection.Input;
                 Date_vc.IsNullable = false;
                 Date_vc.Value = Date_nvc;
                 this.Command.Parameters.Add(Date_vc);

                 if (ControlConnection)
                 {
                     this.BeginTransaction();
                 }

                 sqlDataAdapter.Fill(DataTable);

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

         public void SelectRemainedDetailSelectByCondition(string Condition_nvc, DataTable DataTable)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "[sp_LadeAssignment_T_RemainedDetailSelectByCondition]";
             this.Command.CommandType = CommandType.StoredProcedure;
             try
             {
                 this.Command.Parameters.Clear();

                 this.Command.Parameters.Add(new SqlParameter("@Condition_nvc", Condition_nvc));

                 if (ControlConnection)
                 {
                     this.BeginTransaction();
                 }

                 sqlDataAdapter.Fill(DataTable);

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

         public void SelectCompanyRemainedReport(string FromDate, string FromTime, string ToDate, string ToTime, string LaderTypeList, string CompanyList_nvc, string GoodIDlist, string DestinationCityIDList, string PortPlaceIDList, DataTable dataTable)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "sp_LadeAssignment_T_CompanyRemained";
             this.Command.CommandType = CommandType.StoredProcedure;

             try
             {
                 this.Command.Parameters.Clear();

                 SqlParameter FromDate_nvc = new SqlParameter();
                 FromDate_nvc.ParameterName = "@FromDate_nvc";
                 FromDate_nvc.Direction = ParameterDirection.Input;
                 FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                 FromDate_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(FromDate))
                 {
                     FromDate_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     FromDate_nvc.Value = FromDate;
                 }

                 this.Command.Parameters.Add(FromDate_nvc);

                 SqlParameter FromTime_nvc = new SqlParameter();
                 FromTime_nvc.ParameterName = "@FromTime_nvc";
                 FromTime_nvc.Direction = ParameterDirection.Input;
                 FromTime_nvc.SqlDbType = SqlDbType.NVarChar;
                 FromTime_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(FromTime))
                 {
                     FromTime_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     FromTime_nvc.Value = FromTime;
                 }

                 this.Command.Parameters.Add(FromTime_nvc);

                 SqlParameter ToDate_nvc = new SqlParameter();
                 ToDate_nvc.ParameterName = "@ToDate_nvc";
                 ToDate_nvc.Direction = ParameterDirection.Input;
                 ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                 ToDate_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(ToDate))
                 {
                     ToDate_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     ToDate_nvc.Value = ToDate;
                 }

                 this.Command.Parameters.Add(ToDate_nvc);

                 SqlParameter ToTime_nvc = new SqlParameter();
                 ToTime_nvc.ParameterName = "@ToTime_nvc";
                 ToTime_nvc.Direction = ParameterDirection.Input;
                 ToTime_nvc.SqlDbType = SqlDbType.NVarChar;
                 ToTime_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(ToTime))
                 {
                     ToTime_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     ToTime_nvc.Value = ToTime;
                 }

                 this.Command.Parameters.Add(ToTime_nvc);

                 SqlParameter LaderTypeList_nvc = new SqlParameter();
                 LaderTypeList_nvc.ParameterName = "@LaderTypeID_nvc";
                 LaderTypeList_nvc.Direction = ParameterDirection.Input;
                 LaderTypeList_nvc.SqlDbType = SqlDbType.NVarChar;
                 LaderTypeList_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(LaderTypeList))
                 {
                     LaderTypeList_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     LaderTypeList_nvc.Value = LaderTypeList;
                 }

                 this.Command.Parameters.Add(LaderTypeList_nvc);


                 SqlParameter CompanyList_nvcParam = new SqlParameter();
                 CompanyList_nvcParam.ParameterName = "@CompanyID_nvc";
                 CompanyList_nvcParam.Direction = ParameterDirection.Input;
                 CompanyList_nvcParam.SqlDbType = SqlDbType.NVarChar;
                 CompanyList_nvcParam.IsNullable = true;
                 if (string.IsNullOrEmpty(CompanyList_nvc))
                 {
                     CompanyList_nvcParam.Value = DBNull.Value;
                 }
                 else
                 {
                     CompanyList_nvcParam.Value = CompanyList_nvc;
                 }

                 this.Command.Parameters.Add(CompanyList_nvcParam);

                 SqlParameter GoodIDListParam = new SqlParameter();
                 GoodIDListParam.ParameterName = "@GoodIDList_nvc";
                 GoodIDListParam.Direction = ParameterDirection.Input;
                 GoodIDListParam.SqlDbType = SqlDbType.NVarChar;
                 GoodIDListParam.IsNullable = true;
                 if (string.IsNullOrEmpty(GoodIDlist))
                 {
                     GoodIDListParam.Value = DBNull.Value;
                 }
                 else
                 {
                     GoodIDListParam.Value = GoodIDlist;
                 }
                 this.Command.Parameters.Add(GoodIDListParam);


                 SqlParameter DestinationCityIDListParam = new SqlParameter();
                 DestinationCityIDListParam.ParameterName = "@DestinationCityIDList_nvc";
                 DestinationCityIDListParam.Direction = ParameterDirection.Input;
                 DestinationCityIDListParam.SqlDbType = SqlDbType.NVarChar;
                 DestinationCityIDListParam.IsNullable = true;
                 if (string.IsNullOrEmpty(DestinationCityIDList))
                 {
                     DestinationCityIDListParam.Value = DBNull.Value;
                 }
                 else
                 {
                     DestinationCityIDListParam.Value = DestinationCityIDList;
                 }
                 this.Command.Parameters.Add(DestinationCityIDListParam);



                 SqlParameter PortPlaceIDListParam = new SqlParameter();
                 PortPlaceIDListParam.ParameterName = "@PortPlaceIDList_nvc";
                 PortPlaceIDListParam.Direction = ParameterDirection.Input;
                 PortPlaceIDListParam.SqlDbType = SqlDbType.NVarChar;
                 PortPlaceIDListParam.IsNullable = true;
                 if (string.IsNullOrEmpty(PortPlaceIDList))
                 {
                     PortPlaceIDListParam.Value = DBNull.Value;
                 }
                 else
                 {
                     PortPlaceIDListParam.Value = PortPlaceIDList;
                 }
                 this.Command.Parameters.Add(PortPlaceIDListParam);


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

         public void SelectUsedLadBill(string FromDate, string ToDate, string CompanyCodeList_nvc, string LaderTypeCodeList_nvc, DataTable dataTable)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "[sp_LadeAssignment_T_SelectUsedLadBill]";
             this.Command.CommandType = CommandType.StoredProcedure;

             try
             {
                 this.Command.Parameters.Clear();

                 SqlParameter FromDate_nvc = new SqlParameter();
                 FromDate_nvc.ParameterName = "@FromDate_nvc";
                 FromDate_nvc.Direction = ParameterDirection.Input;
                 FromDate_nvc.SqlDbType = SqlDbType.NVarChar;
                 FromDate_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(FromDate))
                 {
                     FromDate_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     FromDate_nvc.Value = FromDate;
                 }

                 this.Command.Parameters.Add(FromDate_nvc);

                 SqlParameter ToDate_nvc = new SqlParameter();
                 ToDate_nvc.ParameterName = "@ToDate_nvc";
                 ToDate_nvc.Direction = ParameterDirection.Input;
                 ToDate_nvc.SqlDbType = SqlDbType.NVarChar;
                 ToDate_nvc.IsNullable = true;
                 if (string.IsNullOrEmpty(ToDate))
                 {
                     ToDate_nvc.Value = DBNull.Value;
                 }
                 else
                 {
                     ToDate_nvc.Value = ToDate;
                 }

                 this.Command.Parameters.Add(ToDate_nvc);

                 SqlParameter CompanyCodeList_nvcParam = new SqlParameter();
                 CompanyCodeList_nvcParam.ParameterName = "@CompanyCodeList_nvc";
                 CompanyCodeList_nvcParam.Direction = ParameterDirection.Input;
                 CompanyCodeList_nvcParam.SqlDbType = SqlDbType.NVarChar;
                 CompanyCodeList_nvcParam.IsNullable = true;
                 if (string.IsNullOrEmpty(CompanyCodeList_nvc))
                 {
                     CompanyCodeList_nvcParam.Value = DBNull.Value;
                 }
                 else
                 {
                     CompanyCodeList_nvcParam.Value = CompanyCodeList_nvc;
                 }

                 this.Command.Parameters.Add(CompanyCodeList_nvcParam);

                 SqlParameter LaderTypeCodeList_nvcParam = new SqlParameter();
                 LaderTypeCodeList_nvcParam.ParameterName = "@LaderTypeCodeList_nvc";
                 LaderTypeCodeList_nvcParam.Direction = ParameterDirection.Input;
                 LaderTypeCodeList_nvcParam.SqlDbType = SqlDbType.NVarChar;
                 LaderTypeCodeList_nvcParam.IsNullable = true;
                 if (string.IsNullOrEmpty(LaderTypeCodeList_nvc))
                 {
                     LaderTypeCodeList_nvcParam.Value = DBNull.Value;
                 }
                 else
                 {
                     LaderTypeCodeList_nvcParam.Value = LaderTypeCodeList_nvc;
                 }
                 this.Command.CommandTimeout = 150;
                 this.Command.Parameters.Add(LaderTypeCodeList_nvcParam);

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

        public void SelectLastPerBarnameDate(out string LastDate_vc)
         {
             bool ControlConnection = !(this.ConnectionState == System.Data.ConnectionState.Open);
             SqlDataAdapter sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(this.Command);
             this.Command.CommandText = "[sp_PERBARNAME_SelectLastDate]";
             this.Command.CommandType = CommandType.StoredProcedure;
             
            LastDate_vc = string.Empty;
             
            try
             {
                 this.Command.Parameters.Clear();

                 SqlParameter LastDate_vcParam = new SqlParameter();
                 LastDate_vcParam.ParameterName = "@LastDate_vc";
                 LastDate_vcParam.Direction = ParameterDirection.Output;
                 LastDate_vcParam.SqlDbType = SqlDbType.NVarChar;
                 LastDate_vcParam.Size = 12;
                 LastDate_vcParam.IsNullable = true;
                 if (string.IsNullOrEmpty(LastDate_vc))
                 {
                     LastDate_vcParam.Value = DBNull.Value;
                 }
                 else
                 {
                     LastDate_vcParam.Value = LastDate_vc;
                 }

                 this.Command.Parameters.Add(LastDate_vcParam);


                 if (ControlConnection)
                 {
                     this.BeginTransaction();
                 }
                 Command.ExecuteNonQuery();
                 LastDate_vc = Command.Parameters["@LastDate_vc"].Value.ToString();

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