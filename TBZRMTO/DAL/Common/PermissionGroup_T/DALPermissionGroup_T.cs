using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.PermissionGroupDAL
{
class DALPermissionGroup_T: DataLayerBase
{

public DALPermissionGroup_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroupID_int =new SqlParameter();
PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
PermissionGroupID_int.SqlDbType = SqlDbType.Int;
PermissionGroupID_int.Direction = ParameterDirection.Output;
PermissionGroupID_int.IsNullable = false;
PermissionGroupID_int.Value = businessObject.PermissionGroupID_int;
this.Command.Parameters.Add(PermissionGroupID_int);

SqlParameter PermissionGroup_nvc =new SqlParameter();
PermissionGroup_nvc.ParameterName = "@PermissionGroup_nvc";
PermissionGroup_nvc.SqlDbType = SqlDbType.NVarChar;
PermissionGroup_nvc.Direction = ParameterDirection.Input;
PermissionGroup_nvc.IsNullable = false;
PermissionGroup_nvc.Value = businessObject.PermissionGroup_nvc;
this.Command.Parameters.Add(PermissionGroup_nvc);

SqlParameter ParentID_int =new SqlParameter();
ParentID_int.ParameterName = "@ParentID_int";
ParentID_int.SqlDbType = SqlDbType.Int;
ParentID_int.Direction = ParameterDirection.Input;
ParentID_int.IsNullable = true;
if(businessObject.ParentID_int.HasValue == false ){
ParentID_int.Value = DBNull.Value;
}else{
ParentID_int.Value = businessObject.ParentID_int;
}
this.Command.Parameters.Add(ParentID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.PermissionGroupID_int = (Int32)(this.Command.Parameters["@PermissionGroupID_int"].Value); 

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

public void Update(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T businessObject,HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroup_nvc =new SqlParameter();
PermissionGroup_nvc.ParameterName = "@PermissionGroup_nvc";
PermissionGroup_nvc.SqlDbType = SqlDbType.NVarChar;
PermissionGroup_nvc.Direction = ParameterDirection.Input;
PermissionGroup_nvc.IsNullable = false;
PermissionGroup_nvc.Value = businessObject.PermissionGroup_nvc;
this.Command.Parameters.Add(PermissionGroup_nvc);

SqlParameter ParentID_int =new SqlParameter();
ParentID_int.ParameterName = "@ParentID_int";
ParentID_int.SqlDbType = SqlDbType.Int;
ParentID_int.Direction = ParameterDirection.Input;
ParentID_int.IsNullable = false;
if(businessObject.ParentID_int.HasValue == false ){
ParentID_int.Value = DBNull.Value;
}else{
ParentID_int.Value = businessObject.ParentID_int;
}
this.Command.Parameters.Add(ParentID_int);


SqlParameter pk_PermissionGroupID_int =new SqlParameter();
pk_PermissionGroupID_int.ParameterName = "@pk_PermissionGroupID_int";
pk_PermissionGroupID_int.SqlDbType = SqlDbType.Int;
pk_PermissionGroupID_int.Direction = ParameterDirection.Input;
pk_PermissionGroupID_int.IsNullable = false;
pk_PermissionGroupID_int.Value = businessObjectKey.PermissionGroupID_int;
this.Command.Parameters.Add(pk_PermissionGroupID_int);



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

public List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> Result  =new  List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T>();
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]";
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]";
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]";
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

public HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T SelectByPrimaryKey(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroupID_int =new SqlParameter();
PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
PermissionGroupID_int.SqlDbType = SqlDbType.Int;
PermissionGroupID_int.Direction = ParameterDirection.Input;
PermissionGroupID_int.IsNullable = false;
PermissionGroupID_int.Value = businessObjectKey.PermissionGroupID_int;
this.Command.Parameters.Add(PermissionGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T businessObject=new HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T();
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

public void SelectByPrimaryKey(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroupID_int =new SqlParameter();
PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
PermissionGroupID_int.SqlDbType = SqlDbType.Int;
PermissionGroupID_int.Direction = ParameterDirection.Input;
PermissionGroupID_int.IsNullable = false;
PermissionGroupID_int.Value = businessObjectKey.PermissionGroupID_int;
this.Command.Parameters.Add(PermissionGroupID_int);


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

public void SelectByPrimaryKey(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroupID_int =new SqlParameter();
PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
PermissionGroupID_int.SqlDbType = SqlDbType.Int;
PermissionGroupID_int.Direction = ParameterDirection.Input;
PermissionGroupID_int.IsNullable = false;
PermissionGroupID_int.Value = businessObjectKey.PermissionGroupID_int;
this.Command.Parameters.Add(PermissionGroupID_int);


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

public void SelectByPrimaryKey(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroupID_int =new SqlParameter();
PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
PermissionGroupID_int.SqlDbType = SqlDbType.Int;
PermissionGroupID_int.Direction = ParameterDirection.Input;
PermissionGroupID_int.IsNullable = false;
PermissionGroupID_int.Value = businessObjectKey.PermissionGroupID_int;
this.Command.Parameters.Add(PermissionGroupID_int);



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





public List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[PermissionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> Result = new List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T>();
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[PermissionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[PermissionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[PermissionGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> Result= new List<HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T>();
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
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
this.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]";
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

public void Delete(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_PermissionGroup_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter PermissionGroupID_int =new SqlParameter();
PermissionGroupID_int.ParameterName = "@PermissionGroupID_int";
PermissionGroupID_int.SqlDbType = SqlDbType.Int;
PermissionGroupID_int.Direction = ParameterDirection.Input;
PermissionGroupID_int.IsNullable = false;
PermissionGroupID_int.Value = businessObjectKey.PermissionGroupID_int;
this.Command.Parameters.Add(PermissionGroupID_int);


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
this.Command.CommandText = "[sp_PermissionGroup_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T businessObject,IDataReader dataReader){
businessObject.PermissionGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T.PermissionGroup_TField.PermissionGroupID_int.ToString()));
businessObject.PermissionGroup_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T.PermissionGroup_TField.PermissionGroup_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T.PermissionGroup_TField.ParentID_int.ToString())) == false) {
businessObject.ParentID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T.PermissionGroup_TField.ParentID_int.ToString()));
}else{
businessObject.ParentID_int = null;
}

}

public List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T> list=new List< HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T>();
while (dataReader.Read()){
HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T businessObject =new HPS.BLL.PermissionGroupBLL.BLLPermissionGroup_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 