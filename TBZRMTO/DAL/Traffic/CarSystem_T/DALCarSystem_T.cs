using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CarSystemDAL
{
class DALCarSystem_T: DataLayerBase
{

public DALCarSystem_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.CarSystemBLL.BLLCarSystem_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystemID_int =new SqlParameter();
CarSystemID_int.ParameterName = "@CarSystemID_int";
CarSystemID_int.SqlDbType = SqlDbType.Int;
CarSystemID_int.Direction = ParameterDirection.Output;
CarSystemID_int.IsNullable = false;
CarSystemID_int.Value = businessObject.CarSystemID_int;
this.Command.Parameters.Add(CarSystemID_int);

SqlParameter CarSystem_nvc =new SqlParameter();
CarSystem_nvc.ParameterName = "@CarSystem_nvc";
CarSystem_nvc.SqlDbType = SqlDbType.NVarChar;
CarSystem_nvc.Direction = ParameterDirection.Input;
CarSystem_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.CarSystem_nvc) ){
CarSystem_nvc.Value = DBNull.Value;
}else{
CarSystem_nvc.Value = businessObject.CarSystem_nvc;
}
this.Command.Parameters.Add(CarSystem_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.CarSystemID_int = (Int32)(this.Command.Parameters["@CarSystemID_int"].Value); 

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

public void Update(HPS.BLL.CarSystemBLL.BLLCarSystem_T businessObject,HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystem_nvc =new SqlParameter();
CarSystem_nvc.ParameterName = "@CarSystem_nvc";
CarSystem_nvc.SqlDbType = SqlDbType.NVarChar;
CarSystem_nvc.Direction = ParameterDirection.Input;
CarSystem_nvc.IsNullable = false;
if(String.IsNullOrEmpty(businessObject.CarSystem_nvc) ){
CarSystem_nvc.Value = DBNull.Value;
}else{
CarSystem_nvc.Value = businessObject.CarSystem_nvc;
}
this.Command.Parameters.Add(CarSystem_nvc);


SqlParameter pk_CarSystemID_int =new SqlParameter();
pk_CarSystemID_int.ParameterName = "@pk_CarSystemID_int";
pk_CarSystemID_int.SqlDbType = SqlDbType.Int;
pk_CarSystemID_int.Direction = ParameterDirection.Input;
pk_CarSystemID_int.IsNullable = false;
pk_CarSystemID_int.Value = businessObjectKey.CarSystemID_int;
this.Command.Parameters.Add(pk_CarSystemID_int);



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

public List< HPS.BLL.CarSystemBLL.BLLCarSystem_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.CarSystemBLL.BLLCarSystem_T> Result  =new  List< HPS.BLL.CarSystemBLL.BLLCarSystem_T>();
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
this.Command.CommandText = "[sp_CarSystem_T_SelectAll]";
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
this.Command.CommandText = "[sp_CarSystem_T_SelectAll]";
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
this.Command.CommandText = "[sp_CarSystem_T_SelectAll]";
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

public HPS.BLL.CarSystemBLL.BLLCarSystem_T SelectByPrimaryKey(HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystemID_int =new SqlParameter();
CarSystemID_int.ParameterName = "@CarSystemID_int";
CarSystemID_int.SqlDbType = SqlDbType.Int;
CarSystemID_int.Direction = ParameterDirection.Input;
CarSystemID_int.IsNullable = false;
CarSystemID_int.Value = businessObjectKey.CarSystemID_int;
this.Command.Parameters.Add(CarSystemID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.CarSystemBLL.BLLCarSystem_T businessObject=new HPS.BLL.CarSystemBLL.BLLCarSystem_T();
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

public void SelectByPrimaryKey(HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_CarSystem_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystemID_int =new SqlParameter();
CarSystemID_int.ParameterName = "@CarSystemID_int";
CarSystemID_int.SqlDbType = SqlDbType.Int;
CarSystemID_int.Direction = ParameterDirection.Input;
CarSystemID_int.IsNullable = false;
CarSystemID_int.Value = businessObjectKey.CarSystemID_int;
this.Command.Parameters.Add(CarSystemID_int);


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

public void SelectByPrimaryKey(HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_CarSystem_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystemID_int =new SqlParameter();
CarSystemID_int.ParameterName = "@CarSystemID_int";
CarSystemID_int.SqlDbType = SqlDbType.Int;
CarSystemID_int.Direction = ParameterDirection.Input;
CarSystemID_int.IsNullable = false;
CarSystemID_int.Value = businessObjectKey.CarSystemID_int;
this.Command.Parameters.Add(CarSystemID_int);


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

public void SelectByPrimaryKey(HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_CarSystem_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystemID_int =new SqlParameter();
CarSystemID_int.ParameterName = "@CarSystemID_int";
CarSystemID_int.SqlDbType = SqlDbType.Int;
CarSystemID_int.Direction = ParameterDirection.Input;
CarSystemID_int.IsNullable = false;
CarSystemID_int.Value = businessObjectKey.CarSystemID_int;
this.Command.Parameters.Add(CarSystemID_int);



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





public List< HPS.BLL.CarSystemBLL.BLLCarSystem_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[CarSystem_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.CarSystemBLL.BLLCarSystem_T> Result = new List< HPS.BLL.CarSystemBLL.BLLCarSystem_T>();
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
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[CarSystem_T]."+ fieldName + " = N" + "'" + Convert.ToString(value)+ "'"));

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
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[CarSystem_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[CarSystem_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

public List<HPS.BLL.CarSystemBLL.BLLCarSystem_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.CarSystemBLL.BLLCarSystem_T> Result= new List<HPS.BLL.CarSystemBLL.BLLCarSystem_T>();
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
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
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
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
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
this.Command.CommandText = "[sp_CarSystem_T_SelectCondition]";
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

public void Delete(HPS.BLL.CarSystemBLL.BLLCarSystem_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_CarSystem_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CarSystemID_int =new SqlParameter();
CarSystemID_int.ParameterName = "@CarSystemID_int";
CarSystemID_int.SqlDbType = SqlDbType.Int;
CarSystemID_int.Direction = ParameterDirection.Input;
CarSystemID_int.IsNullable = false;
CarSystemID_int.Value = businessObjectKey.CarSystemID_int;
this.Command.Parameters.Add(CarSystemID_int);


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
this.Command.CommandText = "[sp_CarSystem_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.CarSystemBLL.BLLCarSystem_T businessObject,IDataReader dataReader){
businessObject.CarSystemID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystemID_int.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystem_nvc.ToString())) == false) {
businessObject.CarSystem_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CarSystemBLL.BLLCarSystem_T.CarSystem_TField.CarSystem_nvc.ToString()));
}else{
businessObject.CarSystem_nvc = String.Empty;
}

}

public List< HPS.BLL.CarSystemBLL.BLLCarSystem_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.CarSystemBLL.BLLCarSystem_T> list=new List< HPS.BLL.CarSystemBLL.BLLCarSystem_T>();
while (dataReader.Read()){
HPS.BLL.CarSystemBLL.BLLCarSystem_T businessObject =new HPS.BLL.CarSystemBLL.BLLCarSystem_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 