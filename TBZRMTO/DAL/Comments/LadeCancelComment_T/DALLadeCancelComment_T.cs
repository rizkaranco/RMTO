using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeCancelCommentDAL
{
class DALLadeCancelComment_T: DataLayerBase
{

public DALLadeCancelComment_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCanceltCommentID_int =new SqlParameter();
LadeCanceltCommentID_int.ParameterName = "@LadeCanceltCommentID_int";
LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
LadeCanceltCommentID_int.Direction = ParameterDirection.Output;
LadeCanceltCommentID_int.IsNullable = false;
LadeCanceltCommentID_int.Value = businessObject.LadeCanceltCommentID_int;
this.Command.Parameters.Add(LadeCanceltCommentID_int);

SqlParameter LadeCancelComment_nvc =new SqlParameter();
LadeCancelComment_nvc.ParameterName = "@LadeCancelComment_nvc";
LadeCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeCancelComment_nvc.Direction = ParameterDirection.Input;
LadeCancelComment_nvc.IsNullable = false;
LadeCancelComment_nvc.Value = businessObject.LadeCancelComment_nvc;
this.Command.Parameters.Add(LadeCancelComment_nvc);

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

businessObject.LadeCanceltCommentID_int = (Int32)(this.Command.Parameters["@LadeCanceltCommentID_int"].Value); 

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

public void Update(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T businessObject,HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCancelComment_nvc =new SqlParameter();
LadeCancelComment_nvc.ParameterName = "@LadeCancelComment_nvc";
LadeCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeCancelComment_nvc.Direction = ParameterDirection.Input;
LadeCancelComment_nvc.IsNullable = false;
LadeCancelComment_nvc.Value = businessObject.LadeCancelComment_nvc;
this.Command.Parameters.Add(LadeCancelComment_nvc);

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


SqlParameter pk_LadeCanceltCommentID_int =new SqlParameter();
pk_LadeCanceltCommentID_int.ParameterName = "@pk_LadeCanceltCommentID_int";
pk_LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
pk_LadeCanceltCommentID_int.Direction = ParameterDirection.Input;
pk_LadeCanceltCommentID_int.IsNullable = false;
pk_LadeCanceltCommentID_int.Value = businessObjectKey.LadeCanceltCommentID_int;
this.Command.Parameters.Add(pk_LadeCanceltCommentID_int);



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

public List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> Result  =new  List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T>();
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectAll]";
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

public HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T SelectByPrimaryKey(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCanceltCommentID_int =new SqlParameter();
LadeCanceltCommentID_int.ParameterName = "@LadeCanceltCommentID_int";
LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
LadeCanceltCommentID_int.Direction = ParameterDirection.Input;
LadeCanceltCommentID_int.IsNullable = false;
LadeCanceltCommentID_int.Value = businessObjectKey.LadeCanceltCommentID_int;
this.Command.Parameters.Add(LadeCanceltCommentID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T businessObject=new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T();
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

public void SelectByPrimaryKey(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCanceltCommentID_int =new SqlParameter();
LadeCanceltCommentID_int.ParameterName = "@LadeCanceltCommentID_int";
LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
LadeCanceltCommentID_int.Direction = ParameterDirection.Input;
LadeCanceltCommentID_int.IsNullable = false;
LadeCanceltCommentID_int.Value = businessObjectKey.LadeCanceltCommentID_int;
this.Command.Parameters.Add(LadeCanceltCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCanceltCommentID_int =new SqlParameter();
LadeCanceltCommentID_int.ParameterName = "@LadeCanceltCommentID_int";
LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
LadeCanceltCommentID_int.Direction = ParameterDirection.Input;
LadeCanceltCommentID_int.IsNullable = false;
LadeCanceltCommentID_int.Value = businessObjectKey.LadeCanceltCommentID_int;
this.Command.Parameters.Add(LadeCanceltCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCanceltCommentID_int =new SqlParameter();
LadeCanceltCommentID_int.ParameterName = "@LadeCanceltCommentID_int";
LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
LadeCanceltCommentID_int.Direction = ParameterDirection.Input;
LadeCanceltCommentID_int.IsNullable = false;
LadeCanceltCommentID_int.Value = businessObjectKey.LadeCanceltCommentID_int;
this.Command.Parameters.Add(LadeCanceltCommentID_int);



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





public List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeCancelComment_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> Result = new List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T>();
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeCancelComment_T]."+ fieldName + " = N" + "'" + Convert.ToString(value)+ "'"));

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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeCancelComment_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeCancelComment_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

public List<HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> Result= new List<HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T>();
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeCancelComment_T_SelectCondition]";
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

public void Delete(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeCancelComment_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeCanceltCommentID_int =new SqlParameter();
LadeCanceltCommentID_int.ParameterName = "@LadeCanceltCommentID_int";
LadeCanceltCommentID_int.SqlDbType = SqlDbType.Int;
LadeCanceltCommentID_int.Direction = ParameterDirection.Input;
LadeCanceltCommentID_int.IsNullable = false;
LadeCanceltCommentID_int.Value = businessObjectKey.LadeCanceltCommentID_int;
this.Command.Parameters.Add(LadeCanceltCommentID_int);


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
this.Command.CommandText = "[sp_LadeCancelComment_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T businessObject,IDataReader dataReader){
businessObject.LadeCanceltCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCanceltCommentID_int.ToString()));
businessObject.LadeCancelComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.LadeCancelComment_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.UserGroupID_int.ToString())) == false) {
businessObject.UserGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T.LadeCancelComment_TField.UserGroupID_int.ToString()));
}else{
businessObject.UserGroupID_int = null;
}

}

public List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T> list=new List< HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T>();
while (dataReader.Read()){
HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T businessObject =new HPS.BLL.LadeCancelCommentBLL.BLLLadeCancelComment_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 