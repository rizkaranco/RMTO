using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LadeAssignmentCancelRequestCommentDAL
{
class DALLadeAssignmentCancelRequestComment_T: DataLayerBase
{

public DALLadeAssignmentCancelRequestComment_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
LadeAssignmentCancelRequestCommentID_int.ParameterName = "@LadeAssignmentCancelRequestCommentID_int";
LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Output;
LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
LadeAssignmentCancelRequestCommentID_int.Value = businessObject.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestCommentID_int);

SqlParameter LadeAssignmentCancelRequestID_int =new SqlParameter();
LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestID_int.IsNullable = false;
LadeAssignmentCancelRequestID_int.Value = businessObject.LadeAssignmentCancelRequestID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);

SqlParameter LadeCancelCommentID_int =new SqlParameter();
LadeCancelCommentID_int.ParameterName = "@LadeCancelCommentID_int";
LadeCancelCommentID_int.SqlDbType = SqlDbType.Int;
LadeCancelCommentID_int.Direction = ParameterDirection.Input;
LadeCancelCommentID_int.IsNullable = false;
LadeCancelCommentID_int.Value = businessObject.LadeCancelCommentID_int;
this.Command.Parameters.Add(LadeCancelCommentID_int);

SqlParameter LadeCancelComment_nvc =new SqlParameter();
LadeCancelComment_nvc.ParameterName = "@LadeCancelComment_nvc";
LadeCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeCancelComment_nvc.Direction = ParameterDirection.Input;
LadeCancelComment_nvc.IsNullable = false;
LadeCancelComment_nvc.Value = businessObject.LadeCancelComment_nvc;
this.Command.Parameters.Add(LadeCancelComment_nvc);

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

businessObject.LadeAssignmentCancelRequestCommentID_int = (Int32)(this.Command.Parameters["@LadeAssignmentCancelRequestCommentID_int"].Value); 

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

public void Update(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject,HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestID_int =new SqlParameter();
LadeAssignmentCancelRequestID_int.ParameterName = "@LadeAssignmentCancelRequestID_int";
LadeAssignmentCancelRequestID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestID_int.IsNullable = false;
LadeAssignmentCancelRequestID_int.Value = businessObject.LadeAssignmentCancelRequestID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestID_int);

SqlParameter LadeCancelCommentID_int =new SqlParameter();
LadeCancelCommentID_int.ParameterName = "@LadeCancelCommentID_int";
LadeCancelCommentID_int.SqlDbType = SqlDbType.Int;
LadeCancelCommentID_int.Direction = ParameterDirection.Input;
LadeCancelCommentID_int.IsNullable = false;
LadeCancelCommentID_int.Value = businessObject.LadeCancelCommentID_int;
this.Command.Parameters.Add(LadeCancelCommentID_int);

SqlParameter LadeCancelComment_nvc =new SqlParameter();
LadeCancelComment_nvc.ParameterName = "@LadeCancelComment_nvc";
LadeCancelComment_nvc.SqlDbType = SqlDbType.NVarChar;
LadeCancelComment_nvc.Direction = ParameterDirection.Input;
LadeCancelComment_nvc.IsNullable = false;
LadeCancelComment_nvc.Value = businessObject.LadeCancelComment_nvc;
this.Command.Parameters.Add(LadeCancelComment_nvc);

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


SqlParameter pk_LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
pk_LadeAssignmentCancelRequestCommentID_int.ParameterName = "@pk_LadeAssignmentCancelRequestCommentID_int";
pk_LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
pk_LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Input;
pk_LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
pk_LadeAssignmentCancelRequestCommentID_int.Value = businessObjectKey.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(pk_LadeAssignmentCancelRequestCommentID_int);



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

public List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> Result  =new  List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T>();
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectAll]";
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectAll]";
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

public HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T SelectByPrimaryKey(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
LadeAssignmentCancelRequestCommentID_int.ParameterName = "@LadeAssignmentCancelRequestCommentID_int";
LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
LadeAssignmentCancelRequestCommentID_int.Value = businessObjectKey.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestCommentID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject=new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T();
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

public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
LadeAssignmentCancelRequestCommentID_int.ParameterName = "@LadeAssignmentCancelRequestCommentID_int";
LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
LadeAssignmentCancelRequestCommentID_int.Value = businessObjectKey.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
LadeAssignmentCancelRequestCommentID_int.ParameterName = "@LadeAssignmentCancelRequestCommentID_int";
LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
LadeAssignmentCancelRequestCommentID_int.Value = businessObjectKey.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestCommentID_int);


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

public void SelectByPrimaryKey(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
LadeAssignmentCancelRequestCommentID_int.ParameterName = "@LadeAssignmentCancelRequestCommentID_int";
LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
LadeAssignmentCancelRequestCommentID_int.Value = businessObjectKey.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestCommentID_int);



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





public List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentCancelRequestComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> Result = new List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T>();
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentCancelRequestComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentCancelRequestComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LadeAssignmentCancelRequestComment_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> Result= new List<HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T>();
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_SelectCondition]";
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

public void Delete(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LadeAssignmentCancelRequestCommentID_int =new SqlParameter();
LadeAssignmentCancelRequestCommentID_int.ParameterName = "@LadeAssignmentCancelRequestCommentID_int";
LadeAssignmentCancelRequestCommentID_int.SqlDbType = SqlDbType.Int;
LadeAssignmentCancelRequestCommentID_int.Direction = ParameterDirection.Input;
LadeAssignmentCancelRequestCommentID_int.IsNullable = false;
LadeAssignmentCancelRequestCommentID_int.Value = businessObjectKey.LadeAssignmentCancelRequestCommentID_int;
this.Command.Parameters.Add(LadeAssignmentCancelRequestCommentID_int);


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
this.Command.CommandText = "[sp_LadeAssignmentCancelRequestComment_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject,IDataReader dataReader){
businessObject.LadeAssignmentCancelRequestCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.LadeAssignmentCancelRequestCommentID_int.ToString()));
businessObject.LadeAssignmentCancelRequestID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.LadeAssignmentCancelRequestID_int.ToString()));
businessObject.LadeCancelCommentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.LadeCancelCommentID_int.ToString()));
businessObject.LadeCancelComment_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.LadeCancelComment_nvc.ToString()));
businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.Date_nvc.ToString()));
businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.Time_nvc.ToString()));
businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T.LadeAssignmentCancelRequestComment_TField.UserName_nvc.ToString()));
}

public List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T> list=new List< HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T>();
while (dataReader.Read()){
HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T businessObject =new HPS.BLL.LadeAssignmentCancelRequestCommentBLL.BLLLadeAssignmentCancelRequestComment_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 