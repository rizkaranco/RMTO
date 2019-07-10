using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeAssignmentCommentDAL
{
class DALLadeAssignmentComment_T: DataLayerBase
{

public DALLadeAssignmentComment_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCommentID_int =new SqlParameter();
LadeAssignmentCommentID_int.ParameterName = "@LadeAssignmentCommentID_int";
LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCommentID_int.Direction = ParameterDirection.Output;
LadeAssignmentCommentID_int.IsNullable = false;
LadeAssignmentCommentID_int.Value = businessObject.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCommentID_int);

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObject.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);

SqlParameter LadeComment_nvc =new SqlParameter();
LadeComment_nvc.ParameterName = "@LadeComment_nvc";
LadeComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeComment_nvc.Direction = ParameterDirection.Input;
LadeComment_nvc.IsNullable = false;
LadeComment_nvc.Value = businessObject.LadeComment_nvc;
this.Command.Parameters.Add(LadeComment_nvc);

SqlParameter LadeAssignmentID_bint =new SqlParameter();
LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
LadeAssignmentID_bint.Direction = ParameterDirection.Input;
LadeAssignmentID_bint.IsNullable = false;
LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
this.Command.Parameters.Add(LadeAssignmentID_bint);

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



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.LadeAssignmentCommentID_int = (Int32?)(this.Command.Parameters["@LadeAssignmentCommentID_int"].Value);

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

public void Update(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T businessObject,HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObject.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);

SqlParameter LadeComment_nvc =new SqlParameter();
LadeComment_nvc.ParameterName = "@LadeComment_nvc";
LadeComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeComment_nvc.Direction = ParameterDirection.Input;
LadeComment_nvc.IsNullable = false;
LadeComment_nvc.Value = businessObject.LadeComment_nvc;
this.Command.Parameters.Add(LadeComment_nvc);

SqlParameter LadeAssignmentID_bint =new SqlParameter();
LadeAssignmentID_bint.ParameterName = "@LadeAssignmentID_bint";
LadeAssignmentID_bint.SqlDbType = SqlDbType.BigInt;
LadeAssignmentID_bint.Direction = ParameterDirection.Input;
LadeAssignmentID_bint.IsNullable = false;
LadeAssignmentID_bint.Value = businessObject.LadeAssignmentID_bint;
this.Command.Parameters.Add(LadeAssignmentID_bint);

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


SqlParameter pk_LadeAssignmentCommentID_int =new SqlParameter();
pk_LadeAssignmentCommentID_int.ParameterName = "@pk_LadeAssignmentCommentID_int";
pk_LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
pk_LadeAssignmentCommentID_int.Direction = ParameterDirection.Input;
pk_LadeAssignmentCommentID_int.IsNullable = false;
pk_LadeAssignmentCommentID_int.Value = businessObjectKey.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(pk_LadeAssignmentCommentID_int);



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

public List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> Result  =new  List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T>();
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectAll]";
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

public HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T SelectByPrimaryKey(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCommentID_int =new SqlParameter();
LadeAssignmentCommentID_int.ParameterName = "@LadeAssignmentCommentID_int";
LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCommentID_int.IsNullable = false;
LadeAssignmentCommentID_int.Value = businessObjectKey.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCommentID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T businessObject=new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T();
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

public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCommentID_int =new SqlParameter();
LadeAssignmentCommentID_int.ParameterName = "@LadeAssignmentCommentID_int";
LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCommentID_int.IsNullable = false;
LadeAssignmentCommentID_int.Value = businessObjectKey.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCommentID_int =new SqlParameter();
LadeAssignmentCommentID_int.ParameterName = "@LadeAssignmentCommentID_int";
LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCommentID_int.IsNullable = false;
LadeAssignmentCommentID_int.Value = businessObjectKey.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCommentID_int =new SqlParameter();
LadeAssignmentCommentID_int.ParameterName = "@LadeAssignmentCommentID_int";
LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCommentID_int.IsNullable = false;
LadeAssignmentCommentID_int.Value = businessObjectKey.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCommentID_int);



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





public List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> Result = new List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T>();
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> Result= new List<HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T>();
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_SelectCondition]";
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

public void Delete(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentComment_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCommentID_int =new SqlParameter();
LadeAssignmentCommentID_int.ParameterName = "@LadeAssignmentCommentID_int";
LadeAssignmentCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCommentID_int.IsNullable = false;
LadeAssignmentCommentID_int.Value = businessObjectKey.LadeAssignmentCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCommentID_int);


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
this.Command.CommandText = "[sp_LadeAssignmentComment_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T businessObject,IDataReader dataReader){
businessObject.LadeAssignmentCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeAssignmentCommentID_int.ToString()));
businessObject.LadeCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeCommentID_int.ToString()));
businessObject.LadeComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeComment_nvc.ToString()));
businessObject.LadeAssignmentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.LadeAssignmentID_bint.ToString()));
businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.Date_nvc.ToString()));
businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.Time_nvc.ToString()));
businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T.LadeAssignmentComment_TField.UserName_nvc.ToString()));
}

public List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T> list=new List< HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T>();
while (dataReader.Read()){
HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T businessObject =new HPS.BLL.LadeAssignmentCommentBLL.BLLLadeAssignmentComment_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 