using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.TurnCancelCommentDAL
{
class DALTurnCancelComment_T: DataLayerBase
{

public DALTurnCancelComment_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelCommentID_int =new SqlParameter();
TurnCancelCommentID_int.ParameterName = "@TurnCancelCommentID_int";
TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
TurnCancelCommentID_int.Direction = ParameterDirection.Output;
TurnCancelCommentID_int.IsNullable = false;
TurnCancelCommentID_int.Value = businessObject.TurnCancelCommentID_int;
this.Command.Parameters.Add(TurnCancelCommentID_int);

SqlParameter TurnCancelComment_nvc =new SqlParameter();
TurnCancelComment_nvc.ParameterName = "@TurnCancelComment_nvc";
TurnCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
TurnCancelComment_nvc.Direction = ParameterDirection.Input;
TurnCancelComment_nvc.IsNullable = false;
TurnCancelComment_nvc.Value = businessObject.TurnCancelComment_nvc;
this.Command.Parameters.Add(TurnCancelComment_nvc);

SqlParameter UserGroupID_int =new SqlParameter();
UserGroupID_int.ParameterName = "@UserGroupID_int";
UserGroupID_int.SqlDbType = SqlDbType.Int;
UserGroupID_int.Direction = ParameterDirection.Input;
UserGroupID_int.IsNullable = true;
if(businessObject.UserGroupID_int.HasValue == false ){
UserGroupID_int.Value = DBNull.Value;
}else{
UserGroupID_int.Value = businessObject.UserGroupID_int;
}
this.Command.Parameters.Add(UserGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.TurnCancelCommentID_int = (Int32?)(this.Command.Parameters["@TurnCancelCommentID_int"].Value);

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

public void Update(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T businessObject,HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelComment_nvc =new SqlParameter();
TurnCancelComment_nvc.ParameterName = "@TurnCancelComment_nvc";
TurnCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
TurnCancelComment_nvc.Direction = ParameterDirection.Input;
TurnCancelComment_nvc.IsNullable = false;
TurnCancelComment_nvc.Value = businessObject.TurnCancelComment_nvc;
this.Command.Parameters.Add(TurnCancelComment_nvc);

SqlParameter UserGroupID_int =new SqlParameter();
UserGroupID_int.ParameterName = "@UserGroupID_int";
UserGroupID_int.SqlDbType = SqlDbType.Int;
UserGroupID_int.Direction = ParameterDirection.Input;
UserGroupID_int.IsNullable = false;
if(businessObject.UserGroupID_int.HasValue == false ){
UserGroupID_int.Value = DBNull.Value;
}else{
UserGroupID_int.Value = businessObject.UserGroupID_int;
}
this.Command.Parameters.Add(UserGroupID_int);


SqlParameter pk_TurnCancelCommentID_int =new SqlParameter();
pk_TurnCancelCommentID_int.ParameterName = "@pk_TurnCancelCommentID_int";
pk_TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
pk_TurnCancelCommentID_int.Direction = ParameterDirection.Input;
pk_TurnCancelCommentID_int.IsNullable = false;
pk_TurnCancelCommentID_int.Value = businessObjectKey.TurnCancelCommentID_int;
this.Command.Parameters.Add(pk_TurnCancelCommentID_int);



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

public List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> Result  =new  List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T>();
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectAll]";
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

public HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T SelectByPrimaryKey(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelCommentID_int =new SqlParameter();
TurnCancelCommentID_int.ParameterName = "@TurnCancelCommentID_int";
TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
TurnCancelCommentID_int.Direction = ParameterDirection.Input;
TurnCancelCommentID_int.IsNullable = false;
TurnCancelCommentID_int.Value = businessObjectKey.TurnCancelCommentID_int;
this.Command.Parameters.Add(TurnCancelCommentID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T businessObject=new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T();
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

public void SelectByPrimaryKey(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelCommentID_int =new SqlParameter();
TurnCancelCommentID_int.ParameterName = "@TurnCancelCommentID_int";
TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
TurnCancelCommentID_int.Direction = ParameterDirection.Input;
TurnCancelCommentID_int.IsNullable = false;
TurnCancelCommentID_int.Value = businessObjectKey.TurnCancelCommentID_int;
this.Command.Parameters.Add(TurnCancelCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelCommentID_int =new SqlParameter();
TurnCancelCommentID_int.ParameterName = "@TurnCancelCommentID_int";
TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
TurnCancelCommentID_int.Direction = ParameterDirection.Input;
TurnCancelCommentID_int.IsNullable = false;
TurnCancelCommentID_int.Value = businessObjectKey.TurnCancelCommentID_int;
this.Command.Parameters.Add(TurnCancelCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelCommentID_int =new SqlParameter();
TurnCancelCommentID_int.ParameterName = "@TurnCancelCommentID_int";
TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
TurnCancelCommentID_int.Direction = ParameterDirection.Input;
TurnCancelCommentID_int.IsNullable = false;
TurnCancelCommentID_int.Value = businessObjectKey.TurnCancelCommentID_int;
this.Command.Parameters.Add(TurnCancelCommentID_int);



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





public List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[TurnCancelComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> Result = new List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T>();
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[TurnCancelComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[TurnCancelComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[TurnCancelComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> Result= new List<HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T>();
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_TurnCancelComment_T_SelectCondition]";
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

public void Delete(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_TurnCancelComment_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter TurnCancelCommentID_int =new SqlParameter();
TurnCancelCommentID_int.ParameterName = "@TurnCancelCommentID_int";
TurnCancelCommentID_int.SqlDbType = SqlDbType.Int;
TurnCancelCommentID_int.Direction = ParameterDirection.Input;
TurnCancelCommentID_int.IsNullable = false;
TurnCancelCommentID_int.Value = businessObjectKey.TurnCancelCommentID_int;
this.Command.Parameters.Add(TurnCancelCommentID_int);


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
this.Command.CommandText = "[sp_TurnCancelComment_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T businessObject,IDataReader dataReader){
businessObject.TurnCancelCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelCommentID_int.ToString()));
businessObject.TurnCancelComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.TurnCancelComment_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.UserGroupID_int.ToString())) == false) {
businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T.TurnCancelComment_TField.UserGroupID_int.ToString()));
}else{
businessObject.UserGroupID_int = null;
}

}

public List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T> list=new List< HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T>();
while (dataReader.Read()){
HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T businessObject =new HPS.BLL.TurnCancelCommentBLL.BLLTurnCancelComment_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 