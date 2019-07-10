using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeCommentDAL
{
class DALLadeComment_T: DataLayerBase
{

public DALLadeComment_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.LadeCommentBLL.BLLLadeComment_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Output;
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

businessObject.LadeCommentID_int = (Int32?)(this.Command.Parameters["@LadeCommentID_int"].Value);

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

public void Update(HPS.BLL.LadeCommentBLL.BLLLadeComment_T businessObject,HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeComment_nvc =new SqlParameter();
LadeComment_nvc.ParameterName = "@LadeComment_nvc";
LadeComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeComment_nvc.Direction = ParameterDirection.Input;
LadeComment_nvc.IsNullable = false;
LadeComment_nvc.Value = businessObject.LadeComment_nvc;
this.Command.Parameters.Add(LadeComment_nvc);

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


SqlParameter pk_LadeCommentID_int =new SqlParameter();
pk_LadeCommentID_int.ParameterName = "@pk_LadeCommentID_int";
pk_LadeCommentID_int.SqlDbType = SqlDbType.Int;
pk_LadeCommentID_int.Direction = ParameterDirection.Input;
pk_LadeCommentID_int.IsNullable = false;
pk_LadeCommentID_int.Value = businessObjectKey.LadeCommentID_int;
this.Command.Parameters.Add(pk_LadeCommentID_int);



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

public List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T> Result  =new  List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
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
this.Command.CommandText = "[sp_LadeComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeComment_T_SelectAll]";
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

public HPS.BLL.LadeCommentBLL.BLLLadeComment_T SelectByPrimaryKey(HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObjectKey.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.LadeCommentBLL.BLLLadeComment_T businessObject=new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
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

public void SelectByPrimaryKey(HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObjectKey.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObjectKey.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObjectKey.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);



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





public List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T> Result = new List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
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
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T> Result= new List<HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
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
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeComment_T_SelectCondition]";
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

public void Delete(HPS.BLL.LadeCommentBLL.BLLLadeComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeComment_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCommentID_int =new SqlParameter();
LadeCommentID_int.ParameterName = "@LadeCommentID_int";
LadeCommentID_int.SqlDbType = SqlDbType.Int;
LadeCommentID_int.Direction = ParameterDirection.Input;
LadeCommentID_int.IsNullable = false;
LadeCommentID_int.Value = businessObjectKey.LadeCommentID_int;
this.Command.Parameters.Add(LadeCommentID_int);


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
this.Command.CommandText = "[sp_LadeComment_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.LadeCommentBLL.BLLLadeComment_T businessObject,IDataReader dataReader){
businessObject.LadeCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeCommentID_int.ToString()));
businessObject.LadeComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.LadeComment_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.UserGroupID_int.ToString())) == false) {
businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCommentBLL.BLLLadeComment_T.LadeComment_TField.UserGroupID_int.ToString()));
}else{
businessObject.UserGroupID_int = null;
}

}

public List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T> list=new List< HPS.BLL.LadeCommentBLL.BLLLadeComment_T>();
while (dataReader.Read()){
HPS.BLL.LadeCommentBLL.BLLLadeComment_T businessObject =new HPS.BLL.LadeCommentBLL.BLLLadeComment_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 