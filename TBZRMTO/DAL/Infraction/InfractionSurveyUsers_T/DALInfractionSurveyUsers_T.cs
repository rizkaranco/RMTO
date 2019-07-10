using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.InfractionSurveyUsersDAL
{
class DALInfractionSurveyUsers_T: DataLayerBase
{

public DALInfractionSurveyUsers_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyUsersID_int =new SqlParameter();
InfractionSurveyUsersID_int.ParameterName = "@InfractionSurveyUsersID_int";
InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyUsersID_int.Direction = ParameterDirection.Output;
InfractionSurveyUsersID_int.IsNullable = false;
InfractionSurveyUsersID_int.Value = businessObject.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(InfractionSurveyUsersID_int);

SqlParameter UserName_nvc =new SqlParameter();
UserName_nvc.ParameterName = "@UserName_nvc";
UserName_nvc.SqlDbType = SqlDbType.NVarChar;
UserName_nvc.Direction = ParameterDirection.Input;
UserName_nvc.IsNullable = false;
UserName_nvc.Value = businessObject.UserName_nvc;
this.Command.Parameters.Add(UserName_nvc);

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObject.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.InfractionSurveyUsersID_int = (Int32)(this.Command.Parameters["@InfractionSurveyUsersID_int"].Value); 

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

public void Update(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T businessObject,HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter UserName_nvc =new SqlParameter();
UserName_nvc.ParameterName = "@UserName_nvc";
UserName_nvc.SqlDbType = SqlDbType.NVarChar;
UserName_nvc.Direction = ParameterDirection.Input;
UserName_nvc.IsNullable = false;
UserName_nvc.Value = businessObject.UserName_nvc;
this.Command.Parameters.Add(UserName_nvc);

SqlParameter InfractionSurveyGroupID_int =new SqlParameter();
InfractionSurveyGroupID_int.ParameterName = "@InfractionSurveyGroupID_int";
InfractionSurveyGroupID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyGroupID_int.Direction = ParameterDirection.Input;
InfractionSurveyGroupID_int.IsNullable = false;
InfractionSurveyGroupID_int.Value = businessObject.InfractionSurveyGroupID_int;
this.Command.Parameters.Add(InfractionSurveyGroupID_int);


SqlParameter pk_InfractionSurveyUsersID_int =new SqlParameter();
pk_InfractionSurveyUsersID_int.ParameterName = "@pk_InfractionSurveyUsersID_int";
pk_InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
pk_InfractionSurveyUsersID_int.Direction = ParameterDirection.Input;
pk_InfractionSurveyUsersID_int.IsNullable = false;
pk_InfractionSurveyUsersID_int.Value = businessObjectKey.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(pk_InfractionSurveyUsersID_int);



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

public List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> Result  =new  List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T>();
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectAll]";
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectAll]";
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectAll]";
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

public HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T SelectByPrimaryKey(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyUsersID_int =new SqlParameter();
InfractionSurveyUsersID_int.ParameterName = "@InfractionSurveyUsersID_int";
InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyUsersID_int.Direction = ParameterDirection.Input;
InfractionSurveyUsersID_int.IsNullable = false;
InfractionSurveyUsersID_int.Value = businessObjectKey.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(InfractionSurveyUsersID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T businessObject=new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T();
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

public void SelectByPrimaryKey(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyUsersID_int =new SqlParameter();
InfractionSurveyUsersID_int.ParameterName = "@InfractionSurveyUsersID_int";
InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyUsersID_int.Direction = ParameterDirection.Input;
InfractionSurveyUsersID_int.IsNullable = false;
InfractionSurveyUsersID_int.Value = businessObjectKey.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(InfractionSurveyUsersID_int);


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

public void SelectByPrimaryKey(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyUsersID_int =new SqlParameter();
InfractionSurveyUsersID_int.ParameterName = "@InfractionSurveyUsersID_int";
InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyUsersID_int.Direction = ParameterDirection.Input;
InfractionSurveyUsersID_int.IsNullable = false;
InfractionSurveyUsersID_int.Value = businessObjectKey.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(InfractionSurveyUsersID_int);


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

public void SelectByPrimaryKey(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyUsersID_int =new SqlParameter();
InfractionSurveyUsersID_int.ParameterName = "@InfractionSurveyUsersID_int";
InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyUsersID_int.Direction = ParameterDirection.Input;
InfractionSurveyUsersID_int.IsNullable = false;
InfractionSurveyUsersID_int.Value = businessObjectKey.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(InfractionSurveyUsersID_int);



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





public List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyUsers_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> Result = new List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T>();
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyUsers_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyUsers_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[InfractionSurveyUsers_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> Result= new List<HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T>();
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_SelectCondition]";
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

public void Delete(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter InfractionSurveyUsersID_int =new SqlParameter();
InfractionSurveyUsersID_int.ParameterName = "@InfractionSurveyUsersID_int";
InfractionSurveyUsersID_int.SqlDbType = SqlDbType.Int;
InfractionSurveyUsersID_int.Direction = ParameterDirection.Input;
InfractionSurveyUsersID_int.IsNullable = false;
InfractionSurveyUsersID_int.Value = businessObjectKey.InfractionSurveyUsersID_int;
this.Command.Parameters.Add(InfractionSurveyUsersID_int);


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
this.Command.CommandText = "[sp_InfractionSurveyUsers_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T businessObject,IDataReader dataReader){
businessObject.InfractionSurveyUsersID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyUsersID_int.ToString()));
businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.UserName_nvc.ToString()));
businessObject.InfractionSurveyGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T.InfractionSurveyUsers_TField.InfractionSurveyGroupID_int.ToString()));
}

public List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T> list=new List< HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T>();
while (dataReader.Read()){
HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T businessObject =new HPS.BLL.InfractionSurveyUsersBLL.BLLInfractionSurveyUsers_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 