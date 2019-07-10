using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.DestinationAddressDAL
{
class DALDestinationAddress_T: DataLayerBase
{

public DALDestinationAddress_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddressID_int =new SqlParameter();
DestinationAddressID_int.ParameterName = "@DestinationAddressID_int";
DestinationAddressID_int.SqlDbType = SqlDbType.Int;
DestinationAddressID_int.Direction = ParameterDirection.Output;
DestinationAddressID_int.IsNullable = false;
DestinationAddressID_int.Value = businessObject.DestinationAddressID_int;
this.Command.Parameters.Add(DestinationAddressID_int);

SqlParameter DestinationAddress_nvc =new SqlParameter();
DestinationAddress_nvc.ParameterName = "@DestinationAddress_nvc";
DestinationAddress_nvc.SqlDbType = SqlDbType.NVarChar;
DestinationAddress_nvc.Direction = ParameterDirection.Input;
DestinationAddress_nvc.IsNullable = true;
if(String.IsNullOrEmpty(businessObject.DestinationAddress_nvc) ){
DestinationAddress_nvc.Value = DBNull.Value;
}else{
DestinationAddress_nvc.Value = businessObject.DestinationAddress_nvc;
}
this.Command.Parameters.Add(DestinationAddress_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.DestinationAddressID_int = (Int32)(this.Command.Parameters["@DestinationAddressID_int"].Value); 

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

public void Update(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T businessObject,HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddress_nvc =new SqlParameter();
DestinationAddress_nvc.ParameterName = "@DestinationAddress_nvc";
DestinationAddress_nvc.SqlDbType = SqlDbType.NVarChar;
DestinationAddress_nvc.Direction = ParameterDirection.Input;
DestinationAddress_nvc.IsNullable = false;
if(String.IsNullOrEmpty(businessObject.DestinationAddress_nvc) ){
DestinationAddress_nvc.Value = DBNull.Value;
}else{
DestinationAddress_nvc.Value = businessObject.DestinationAddress_nvc;
}
this.Command.Parameters.Add(DestinationAddress_nvc);


SqlParameter pk_DestinationAddressID_int =new SqlParameter();
pk_DestinationAddressID_int.ParameterName = "@pk_DestinationAddressID_int";
pk_DestinationAddressID_int.SqlDbType = SqlDbType.Int;
pk_DestinationAddressID_int.Direction = ParameterDirection.Input;
pk_DestinationAddressID_int.IsNullable = false;
pk_DestinationAddressID_int.Value = businessObjectKey.DestinationAddressID_int;
this.Command.Parameters.Add(pk_DestinationAddressID_int);



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

public List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> Result  =new  List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T>();
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectAll]";
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectAll]";
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectAll]";
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

public HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T SelectByPrimaryKey(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddressID_int =new SqlParameter();
DestinationAddressID_int.ParameterName = "@DestinationAddressID_int";
DestinationAddressID_int.SqlDbType = SqlDbType.Int;
DestinationAddressID_int.Direction = ParameterDirection.Input;
DestinationAddressID_int.IsNullable = false;
DestinationAddressID_int.Value = businessObjectKey.DestinationAddressID_int;
this.Command.Parameters.Add(DestinationAddressID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T businessObject=new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T();
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

public void SelectByPrimaryKey(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddressID_int =new SqlParameter();
DestinationAddressID_int.ParameterName = "@DestinationAddressID_int";
DestinationAddressID_int.SqlDbType = SqlDbType.Int;
DestinationAddressID_int.Direction = ParameterDirection.Input;
DestinationAddressID_int.IsNullable = false;
DestinationAddressID_int.Value = businessObjectKey.DestinationAddressID_int;
this.Command.Parameters.Add(DestinationAddressID_int);


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

public void SelectByPrimaryKey(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddressID_int =new SqlParameter();
DestinationAddressID_int.ParameterName = "@DestinationAddressID_int";
DestinationAddressID_int.SqlDbType = SqlDbType.Int;
DestinationAddressID_int.Direction = ParameterDirection.Input;
DestinationAddressID_int.IsNullable = false;
DestinationAddressID_int.Value = businessObjectKey.DestinationAddressID_int;
this.Command.Parameters.Add(DestinationAddressID_int);


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

public void SelectByPrimaryKey(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddressID_int =new SqlParameter();
DestinationAddressID_int.ParameterName = "@DestinationAddressID_int";
DestinationAddressID_int.SqlDbType = SqlDbType.Int;
DestinationAddressID_int.Direction = ParameterDirection.Input;
DestinationAddressID_int.IsNullable = false;
DestinationAddressID_int.Value = businessObjectKey.DestinationAddressID_int;
this.Command.Parameters.Add(DestinationAddressID_int);



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





public List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[DestinationAddress_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> Result = new List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T>();
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[DestinationAddress_T]."+ fieldName + " = N" + "'" + Convert.ToString(value)+ "'"));

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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[DestinationAddress_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[DestinationAddress_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

public List<HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> Result= new List<HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T>();
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
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
this.Command.CommandText = "[sp_DestinationAddress_T_SelectCondition]";
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

public void Delete(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_DestinationAddress_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter DestinationAddressID_int =new SqlParameter();
DestinationAddressID_int.ParameterName = "@DestinationAddressID_int";
DestinationAddressID_int.SqlDbType = SqlDbType.Int;
DestinationAddressID_int.Direction = ParameterDirection.Input;
DestinationAddressID_int.IsNullable = false;
DestinationAddressID_int.Value = businessObjectKey.DestinationAddressID_int;
this.Command.Parameters.Add(DestinationAddressID_int);


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
this.Command.CommandText = "[sp_DestinationAddress_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T businessObject,IDataReader dataReader){
businessObject.DestinationAddressID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddressID_int.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddress_nvc.ToString())) == false) {
businessObject.DestinationAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T.DestinationAddress_TField.DestinationAddress_nvc.ToString()));
}else{
businessObject.DestinationAddress_nvc = String.Empty;
}

}

public List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T> list=new List< HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T>();
while (dataReader.Read()){
HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T businessObject =new HPS.BLL.DestinationAddressBLL.BLLDestinationAddress_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 