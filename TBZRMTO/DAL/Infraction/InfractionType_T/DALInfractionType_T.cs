using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.InfractionTypeDAL
{
class DALInfractionType_T: DataLayerBase
{

public DALInfractionType_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionTypeID_int =new SqlParameter();
InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
InfractionTypeID_int.SqlDbType = SqlDbType.Int;
InfractionTypeID_int.Direction = ParameterDirection.Output;
InfractionTypeID_int.IsNullable = false;
InfractionTypeID_int.Value = businessObject.InfractionTypeID_int;
this.Command.Parameters.Add(InfractionTypeID_int);

SqlParameter InfractionType_nvc =new SqlParameter();
InfractionType_nvc.ParameterName = "@InfractionType_nvc";
InfractionType_nvc.SqlDbType = SqlDbType.NVarChar;
InfractionType_nvc.Direction = ParameterDirection.Input;
InfractionType_nvc.IsNullable = false;
InfractionType_nvc.Value = businessObject.InfractionType_nvc;
this.Command.Parameters.Add(InfractionType_nvc);

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObject.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);

SqlParameter PenaltyFee_dec =new SqlParameter();
PenaltyFee_dec.ParameterName = "@PenaltyFee_dec";
PenaltyFee_dec.SqlDbType = SqlDbType.Decimal;
PenaltyFee_dec.Direction = ParameterDirection.Input;
PenaltyFee_dec.IsNullable = true;
if(businessObject.PenaltyFee_dec.HasValue == false ){
PenaltyFee_dec.Value = DBNull.Value;
}else{
PenaltyFee_dec.Value = businessObject.PenaltyFee_dec;
}
this.Command.Parameters.Add(PenaltyFee_dec);

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

SqlParameter Active_bit =new SqlParameter();
Active_bit.ParameterName = "@Active_bit";
Active_bit.SqlDbType = SqlDbType.Bit;
Active_bit.Direction = ParameterDirection.Input;
Active_bit.IsNullable = false;
Active_bit.Value = businessObject.Active_bit;
this.Command.Parameters.Add(Active_bit);

SqlParameter UserName_nvc =new SqlParameter();
UserName_nvc.ParameterName = "@UserName_nvc";
UserName_nvc.SqlDbType = SqlDbType.NVarChar;
UserName_nvc.Direction = ParameterDirection.Input;
UserName_nvc.IsNullable = false;
UserName_nvc.Value = businessObject.UserName_nvc;
this.Command.Parameters.Add(UserName_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.InfractionTypeID_int = (Int32?)(this.Command.Parameters["@InfractionTypeID_int"].Value);

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

public void Update(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T businessObject,HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionType_nvc =new SqlParameter();
InfractionType_nvc.ParameterName = "@InfractionType_nvc";
InfractionType_nvc.SqlDbType = SqlDbType.NVarChar;
InfractionType_nvc.Direction = ParameterDirection.Input;
InfractionType_nvc.IsNullable = false;
InfractionType_nvc.Value = businessObject.InfractionType_nvc;
this.Command.Parameters.Add(InfractionType_nvc);

SqlParameter InfractionGroupID_int =new SqlParameter();
InfractionGroupID_int.ParameterName = "@InfractionGroupID_int";
InfractionGroupID_int.SqlDbType = SqlDbType.Int;
InfractionGroupID_int.Direction = ParameterDirection.Input;
InfractionGroupID_int.IsNullable = false;
InfractionGroupID_int.Value = businessObject.InfractionGroupID_int;
this.Command.Parameters.Add(InfractionGroupID_int);

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObject.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);

SqlParameter PenaltyFee_dec =new SqlParameter();
PenaltyFee_dec.ParameterName = "@PenaltyFee_dec";
PenaltyFee_dec.SqlDbType = SqlDbType.Decimal;
PenaltyFee_dec.Direction = ParameterDirection.Input;
PenaltyFee_dec.IsNullable = false;
if(businessObject.PenaltyFee_dec.HasValue == false ){
PenaltyFee_dec.Value = DBNull.Value;
}else{
PenaltyFee_dec.Value = businessObject.PenaltyFee_dec;
}
this.Command.Parameters.Add(PenaltyFee_dec);

SqlParameter Date_nvc =new SqlParameter();
Date_nvc.ParameterName = "@Date_nvc";
Date_nvc.SqlDbType = SqlDbType.NVarChar;
Date_nvc.Direction = ParameterDirection.Input;
Date_nvc.IsNullable = true;
Date_nvc.Value = businessObject.Date_nvc;
this.Command.Parameters.Add(Date_nvc);

SqlParameter Time_nvc =new SqlParameter();
Time_nvc.ParameterName = "@Time_nvc";
Time_nvc.SqlDbType = SqlDbType.NVarChar;
Time_nvc.Direction = ParameterDirection.Input;
Time_nvc.IsNullable = false;
Time_nvc.Value = businessObject.Time_nvc;
this.Command.Parameters.Add(Time_nvc);

SqlParameter Active_bit =new SqlParameter();
Active_bit.ParameterName = "@Active_bit";
Active_bit.SqlDbType = SqlDbType.Bit;
Active_bit.Direction = ParameterDirection.Input;
Active_bit.IsNullable = false;
Active_bit.Value = businessObject.Active_bit;
this.Command.Parameters.Add(Active_bit);

SqlParameter UserName_nvc =new SqlParameter();
UserName_nvc.ParameterName = "@UserName_nvc";
UserName_nvc.SqlDbType = SqlDbType.NVarChar;
UserName_nvc.Direction = ParameterDirection.Input;
UserName_nvc.IsNullable = false;
UserName_nvc.Value = businessObject.UserName_nvc;
this.Command.Parameters.Add(UserName_nvc);


SqlParameter pk_InfractionTypeID_int =new SqlParameter();
pk_InfractionTypeID_int.ParameterName = "@pk_InfractionTypeID_int";
pk_InfractionTypeID_int.SqlDbType = SqlDbType.Int;
pk_InfractionTypeID_int.Direction = ParameterDirection.Input;
pk_InfractionTypeID_int.IsNullable = false;
pk_InfractionTypeID_int.Value = businessObjectKey.InfractionTypeID_int;
this.Command.Parameters.Add(pk_InfractionTypeID_int);



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

public List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> Result  =new  List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T>();
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
this.Command.CommandText = "[sp_InfractionType_T_SelectAll]";
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
this.Command.CommandText = "[sp_InfractionType_T_SelectAll]";
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
this.Command.CommandText = "[sp_InfractionType_T_SelectAll]";
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

public HPS.BLL.InfractionTypeBLL.BLLInfractionType_T SelectByPrimaryKey(HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionTypeID_int =new SqlParameter();
InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
InfractionTypeID_int.SqlDbType = SqlDbType.Int;
InfractionTypeID_int.Direction = ParameterDirection.Input;
InfractionTypeID_int.IsNullable = false;
InfractionTypeID_int.Value = businessObjectKey.InfractionTypeID_int;
this.Command.Parameters.Add(InfractionTypeID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.InfractionTypeBLL.BLLInfractionType_T businessObject=new HPS.BLL.InfractionTypeBLL.BLLInfractionType_T();
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

public void SelectByPrimaryKey(HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionType_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionTypeID_int =new SqlParameter();
InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
InfractionTypeID_int.SqlDbType = SqlDbType.Int;
InfractionTypeID_int.Direction = ParameterDirection.Input;
InfractionTypeID_int.IsNullable = false;
InfractionTypeID_int.Value = businessObjectKey.InfractionTypeID_int;
this.Command.Parameters.Add(InfractionTypeID_int);


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

public void SelectByPrimaryKey(HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionType_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionTypeID_int =new SqlParameter();
InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
InfractionTypeID_int.SqlDbType = SqlDbType.Int;
InfractionTypeID_int.Direction = ParameterDirection.Input;
InfractionTypeID_int.IsNullable = false;
InfractionTypeID_int.Value = businessObjectKey.InfractionTypeID_int;
this.Command.Parameters.Add(InfractionTypeID_int);


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

public void SelectByPrimaryKey(HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionType_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionTypeID_int =new SqlParameter();
InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
InfractionTypeID_int.SqlDbType = SqlDbType.Int;
InfractionTypeID_int.Direction = ParameterDirection.Input;
InfractionTypeID_int.IsNullable = false;
InfractionTypeID_int.Value = businessObjectKey.InfractionTypeID_int;
this.Command.Parameters.Add(InfractionTypeID_int);



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





public List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionType_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> Result = new List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T>();
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
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionType_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionType_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionType_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> Result= new List<HPS.BLL.InfractionTypeBLL.BLLInfractionType_T>();
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
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
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
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
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
this.Command.CommandText = "[sp_InfractionType_T_SelectCondition]";
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

public void Delete(HPS.BLL.InfractionTypeBLL.BLLInfractionType_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionType_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionTypeID_int =new SqlParameter();
InfractionTypeID_int.ParameterName = "@InfractionTypeID_int";
InfractionTypeID_int.SqlDbType = SqlDbType.Int;
InfractionTypeID_int.Direction = ParameterDirection.Input;
InfractionTypeID_int.IsNullable = false;
InfractionTypeID_int.Value = businessObjectKey.InfractionTypeID_int;
this.Command.Parameters.Add(InfractionTypeID_int);


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
this.Command.CommandText = "[sp_InfractionType_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.InfractionTypeBLL.BLLInfractionType_T businessObject,IDataReader dataReader){
businessObject.InfractionTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionTypeID_int.ToString()));
businessObject.InfractionType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionType_nvc.ToString()));
businessObject.InfractionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionGroupID_int.ToString()));
businessObject.InfractionSurveyGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.InfractionSurveyGroupID_int.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.PenaltyFee_dec.ToString())) == false) {
businessObject.PenaltyFee_dec = dataReader.GetDecimal(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.PenaltyFee_dec.ToString()));
}else{
businessObject.PenaltyFee_dec = null;
}

businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Date_nvc.ToString()));
businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Time_nvc.ToString()));
businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.Active_bit.ToString()));
businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionTypeBLL.BLLInfractionType_T.InfractionType_TField.UserName_nvc.ToString()));
}

public List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T> list=new List< HPS.BLL.InfractionTypeBLL.BLLInfractionType_T>();
while (dataReader.Read()){
HPS.BLL.InfractionTypeBLL.BLLInfractionType_T businessObject =new HPS.BLL.InfractionTypeBLL.BLLInfractionType_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 