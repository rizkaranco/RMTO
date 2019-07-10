using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.ChargePriceDAL
{
class DALChargePrice_T: DataLayerBase
{

public DALChargePrice_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter ChargePriceID_int =new SqlParameter();
ChargePriceID_int.ParameterName = "@ChargePriceID_int";
ChargePriceID_int.SqlDbType = SqlDbType.Int;
ChargePriceID_int.Direction = ParameterDirection.Output;
ChargePriceID_int.IsNullable = false;
ChargePriceID_int.Value = businessObject.ChargePriceID_int;
this.Command.Parameters.Add(ChargePriceID_int);

SqlParameter DriverID_bint =new SqlParameter();
DriverID_bint.ParameterName = "@DriverID_bint";
DriverID_bint.SqlDbType = SqlDbType.BigInt;
DriverID_bint.Direction = ParameterDirection.Input;
DriverID_bint.IsNullable = false;
DriverID_bint.Value = businessObject.DriverID_bint;
this.Command.Parameters.Add(DriverID_bint);

SqlParameter DriverName_nvc =new SqlParameter();
DriverName_nvc.ParameterName = "@DriverName_nvc";
DriverName_nvc.SqlDbType = SqlDbType.NVarChar;
DriverName_nvc.Direction = ParameterDirection.Input;
DriverName_nvc.IsNullable = false;
DriverName_nvc.Value = businessObject.DriverName_nvc;
this.Command.Parameters.Add(DriverName_nvc);

SqlParameter DriverCardNumber_nvc =new SqlParameter();
DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
DriverCardNumber_nvc.Direction = ParameterDirection.Input;
DriverCardNumber_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.DriverCardNumber_nvc) ){
DriverCardNumber_nvc.Value = DBNull.Value;
}else{
DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
}
this.Command.Parameters.Add(DriverCardNumber_nvc);

SqlParameter Price_dec =new SqlParameter();
Price_dec.ParameterName = "@Price_dec";
Price_dec.SqlDbType = SqlDbType.Decimal;
Price_dec.Direction = ParameterDirection.Input;
Price_dec.IsNullable = false;
Price_dec.Value = businessObject.Price_dec;
this.Command.Parameters.Add(Price_dec);

SqlParameter Date_nvc =new SqlParameter();
Date_nvc.ParameterName = "@Date_nvc";
Date_nvc.SqlDbType = SqlDbType.NVarChar;
Date_nvc.Direction = ParameterDirection.Input;
Date_nvc.IsNullable = false;
Date_nvc.Value = businessObject.Date_nvc;
this.Command.Parameters.Add(Date_nvc);

SqlParameter Time_nvc =new SqlParameter();
Time_nvc.ParameterName = "@Time_nvc";
Time_nvc.SqlDbType = SqlDbType.NVarChar;
Time_nvc.Direction = ParameterDirection.Input;
Time_nvc.IsNullable = false;
Time_nvc.Value = businessObject.Time_nvc;
this.Command.Parameters.Add(Time_nvc);

SqlParameter UserName_nvc =new SqlParameter();
UserName_nvc.ParameterName = "@UserName_nvc";
UserName_nvc.SqlDbType = SqlDbType.NVarChar;
UserName_nvc.Direction = ParameterDirection.Input;
UserName_nvc.IsNullable = false;
UserName_nvc.Value = businessObject.UserName_nvc;
this.Command.Parameters.Add(UserName_nvc);

SqlParameter Description_nvc =new SqlParameter();
Description_nvc.ParameterName = "@Description_nvc";
Description_nvc.SqlDbType = SqlDbType.NVarChar;
Description_nvc.Direction = ParameterDirection.Input;
Description_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.Description_nvc) ){
Description_nvc.Value = DBNull.Value;
}else{
Description_nvc.Value = businessObject.Description_nvc;
}
this.Command.Parameters.Add(Description_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.ChargePriceID_int = (Int32?)(this.Command.Parameters["@ChargePriceID_int"].Value);

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void Update(HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject,HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DriverID_bint =new SqlParameter();
DriverID_bint.ParameterName = "@DriverID_bint";
DriverID_bint.SqlDbType = SqlDbType.BigInt;
DriverID_bint.Direction = ParameterDirection.Input;
DriverID_bint.IsNullable = false;
DriverID_bint.Value = businessObject.DriverID_bint;
this.Command.Parameters.Add(DriverID_bint);

SqlParameter DriverName_nvc =new SqlParameter();
DriverName_nvc.ParameterName = "@DriverName_nvc";
DriverName_nvc.SqlDbType = SqlDbType.NVarChar;
DriverName_nvc.Direction = ParameterDirection.Input;
DriverName_nvc.IsNullable = false;
DriverName_nvc.Value = businessObject.DriverName_nvc;
this.Command.Parameters.Add(DriverName_nvc);

SqlParameter DriverCardNumber_nvc =new SqlParameter();
DriverCardNumber_nvc.ParameterName = "@DriverCardNumber_nvc";
DriverCardNumber_nvc.SqlDbType = SqlDbType.NVarChar;
DriverCardNumber_nvc.Direction = ParameterDirection.Input;
DriverCardNumber_nvc.IsNullable = false;
if(String.IsNullOrEmpty(businessObject.DriverCardNumber_nvc) ){
DriverCardNumber_nvc.Value = DBNull.Value;
}else{
DriverCardNumber_nvc.Value = businessObject.DriverCardNumber_nvc;
}
this.Command.Parameters.Add(DriverCardNumber_nvc);

SqlParameter Price_dec =new SqlParameter();
Price_dec.ParameterName = "@Price_dec";
Price_dec.SqlDbType = SqlDbType.Decimal;
Price_dec.Direction = ParameterDirection.Input;
Price_dec.IsNullable = true;
Price_dec.Value = businessObject.Price_dec;
this.Command.Parameters.Add(Price_dec);

SqlParameter Date_nvc =new SqlParameter();
Date_nvc.ParameterName = "@Date_nvc";
Date_nvc.SqlDbType = SqlDbType.NVarChar;
Date_nvc.Direction = ParameterDirection.Input;
Date_nvc.IsNullable = false;
Date_nvc.Value = businessObject.Date_nvc;
this.Command.Parameters.Add(Date_nvc);

SqlParameter Time_nvc =new SqlParameter();
Time_nvc.ParameterName = "@Time_nvc";
Time_nvc.SqlDbType = SqlDbType.NVarChar;
Time_nvc.Direction = ParameterDirection.Input;
Time_nvc.IsNullable = false;
Time_nvc.Value = businessObject.Time_nvc;
this.Command.Parameters.Add(Time_nvc);

SqlParameter UserName_nvc =new SqlParameter();
UserName_nvc.ParameterName = "@UserName_nvc";
UserName_nvc.SqlDbType = SqlDbType.NVarChar;
UserName_nvc.Direction = ParameterDirection.Input;
UserName_nvc.IsNullable = false;
UserName_nvc.Value = businessObject.UserName_nvc;
this.Command.Parameters.Add(UserName_nvc);

SqlParameter Description_nvc =new SqlParameter();
Description_nvc.ParameterName = "@Description_nvc";
Description_nvc.SqlDbType = SqlDbType.NVarChar;
Description_nvc.Direction = ParameterDirection.Input;
Description_nvc.IsNullable = false;
if(String.IsNullOrEmpty(businessObject.Description_nvc) ){
Description_nvc.Value = DBNull.Value;
}else{
Description_nvc.Value = businessObject.Description_nvc;
}
this.Command.Parameters.Add(Description_nvc);


SqlParameter pk_ChargePriceID_int =new SqlParameter();
pk_ChargePriceID_int.ParameterName = "@pk_ChargePriceID_int";
pk_ChargePriceID_int.SqlDbType = SqlDbType.Int;
pk_ChargePriceID_int.Direction = ParameterDirection.Input;
pk_ChargePriceID_int.IsNullable = false;
pk_ChargePriceID_int.Value = businessObjectKey.ChargePriceID_int;
this.Command.Parameters.Add(pk_ChargePriceID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> Result  =new  List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset,String srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public HPS.BLL.ChargePriceBLL.BLLChargePrice_T SelectByPrimaryKey(HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter ChargePriceID_int =new SqlParameter();
ChargePriceID_int.ParameterName = "@ChargePriceID_int";
ChargePriceID_int.SqlDbType = SqlDbType.Int;
ChargePriceID_int.Direction = ParameterDirection.Input;
ChargePriceID_int.IsNullable = false;
ChargePriceID_int.Value = businessObjectKey.ChargePriceID_int;
this.Command.Parameters.Add(ChargePriceID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject=new HPS.BLL.ChargePriceBLL.BLLChargePrice_T();
if(dataReader.Read()) {
PopulateBusinessObjectFromReader(businessObject, dataReader);
}else{
businessObject = null;
}

if(dataReader.IsClosed == false) {
dataReader.Close();
}


if(ControlConnection) {
this.Commit();
}
return businessObject;}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter ChargePriceID_int =new SqlParameter();
ChargePriceID_int.ParameterName = "@ChargePriceID_int";
ChargePriceID_int.SqlDbType = SqlDbType.Int;
ChargePriceID_int.Direction = ParameterDirection.Input;
ChargePriceID_int.IsNullable = false;
ChargePriceID_int.Value = businessObjectKey.ChargePriceID_int;
this.Command.Parameters.Add(ChargePriceID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter ChargePriceID_int =new SqlParameter();
ChargePriceID_int.ParameterName = "@ChargePriceID_int";
ChargePriceID_int.SqlDbType = SqlDbType.Int;
ChargePriceID_int.Direction = ParameterDirection.Input;
ChargePriceID_int.IsNullable = false;
ChargePriceID_int.Value = businessObjectKey.ChargePriceID_int;
this.Command.Parameters.Add(ChargePriceID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter ChargePriceID_int =new SqlParameter();
ChargePriceID_int.ParameterName = "@ChargePriceID_int";
ChargePriceID_int.SqlDbType = SqlDbType.Int;
ChargePriceID_int.Direction = ParameterDirection.Input;
ChargePriceID_int.IsNullable = false;
ChargePriceID_int.Value = businessObjectKey.ChargePriceID_int;
this.Command.Parameters.Add(ChargePriceID_int);



if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}





public List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[ChargePrice_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> Result = new List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName ,Object  value  , ref System.Data.DataSet dataset  ,String  srcTable  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[ChargePrice_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref System.Data.DataSet dataset  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[ChargePrice_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[ChargePrice_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public List<HPS.BLL.ChargePriceBLL.BLLChargePrice_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.ChargePriceBLL.BLLChargePrice_T> Result= new List<HPS.BLL.ChargePriceBLL.BLLChargePrice_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataSet dataset,String srcTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  ,ref System.Data.DataSet dataset ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataTable dataTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_ChargePrice_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void Delete(HPS.BLL.ChargePriceBLL.BLLChargePrice_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter ChargePriceID_int =new SqlParameter();
ChargePriceID_int.ParameterName = "@ChargePriceID_int";
ChargePriceID_int.SqlDbType = SqlDbType.Int;
ChargePriceID_int.Direction = ParameterDirection.Input;
ChargePriceID_int.IsNullable = false;
ChargePriceID_int.Value = businessObjectKey.ChargePriceID_int;
this.Command.Parameters.Add(ChargePriceID_int);


if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void DeleteByField(String fieldName,Object value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_ChargePrice_T_DeleteByField]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
this.Command.Parameters.Add(new SqlParameter("@Value", value));

if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void PopulateBusinessObjectFromReader(  HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject,IDataReader dataReader){
businessObject.ChargePriceID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.ChargePriceID_int.ToString()));
businessObject.DriverID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverID_bint.ToString()));
businessObject.DriverName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverName_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverCardNumber_nvc.ToString())) == false) {
businessObject.DriverCardNumber_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.DriverCardNumber_nvc.ToString()));
}else{
businessObject.DriverCardNumber_nvc = String.Empty;
}

businessObject.Price_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Price_dec.ToString()));
businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Date_nvc.ToString()));
businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Time_nvc.ToString()));
businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.UserName_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Description_nvc.ToString())) == false) {
businessObject.Description_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.ChargePriceBLL.BLLChargePrice_T.ChargePrice_TField.Description_nvc.ToString()));
}else{
businessObject.Description_nvc = String.Empty;
}

}

public List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T> list=new List< HPS.BLL.ChargePriceBLL.BLLChargePrice_T>();
while (dataReader.Read()){
HPS.BLL.ChargePriceBLL.BLLChargePrice_T businessObject =new HPS.BLL.ChargePriceBLL.BLLChargePrice_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 