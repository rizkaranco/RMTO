using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.CountryDAL
{
class DALCountry_T: DataLayerBase
{

public DALCountry_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.CountryBLL.BLLCountry_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryID_int =new SqlParameter();
CountryID_int.ParameterName = "@CountryID_int";
CountryID_int.SqlDbType = SqlDbType.Int;
CountryID_int.Direction = ParameterDirection.Output;
CountryID_int.IsNullable = false;
CountryID_int.Value = businessObject.CountryID_int;
this.Command.Parameters.Add(CountryID_int);

SqlParameter CountryCode_nvc =new SqlParameter();
CountryCode_nvc.ParameterName = "@CountryCode_nvc";
CountryCode_nvc.SqlDbType = SqlDbType.NVarChar;
CountryCode_nvc.Direction = ParameterDirection.Input;
CountryCode_nvc.IsNullable = false;
CountryCode_nvc.Value = businessObject.CountryCode_nvc;
this.Command.Parameters.Add(CountryCode_nvc);

SqlParameter Country_nvc =new SqlParameter();
Country_nvc.ParameterName = "@Country_nvc";
Country_nvc.SqlDbType = SqlDbType.NVarChar;
Country_nvc.Direction = ParameterDirection.Input;
Country_nvc.IsNullable = false;
Country_nvc.Value = businessObject.Country_nvc;
this.Command.Parameters.Add(Country_nvc);

SqlParameter Active_bit =new SqlParameter();
Active_bit.ParameterName = "@Active_bit";
Active_bit.SqlDbType = SqlDbType.Bit;
Active_bit.Direction = ParameterDirection.Input;
Active_bit.IsNullable = false;
Active_bit.Value = businessObject.Active_bit;
this.Command.Parameters.Add(Active_bit);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.CountryID_int = (Int32)this.Command.Parameters["@CountryID_int"].Value;

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

public void Update(HPS.BLL.CountryBLL.BLLCountry_T businessObject,HPS.BLL.CountryBLL.BLLCountry_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryCode_nvc =new SqlParameter();
CountryCode_nvc.ParameterName = "@CountryCode_nvc";
CountryCode_nvc.SqlDbType = SqlDbType.NVarChar;
CountryCode_nvc.Direction = ParameterDirection.Input;
CountryCode_nvc.IsNullable = false;
CountryCode_nvc.Value = businessObject.CountryCode_nvc;
this.Command.Parameters.Add(CountryCode_nvc);

SqlParameter Country_nvc =new SqlParameter();
Country_nvc.ParameterName = "@Country_nvc";
Country_nvc.SqlDbType = SqlDbType.NVarChar;
Country_nvc.Direction = ParameterDirection.Input;
Country_nvc.IsNullable = false;
Country_nvc.Value = businessObject.Country_nvc;
this.Command.Parameters.Add(Country_nvc);

SqlParameter Active_bit =new SqlParameter();
Active_bit.ParameterName = "@Active_bit";
Active_bit.SqlDbType = SqlDbType.Bit;
Active_bit.Direction = ParameterDirection.Input;
Active_bit.IsNullable = false;
Active_bit.Value = businessObject.Active_bit;
this.Command.Parameters.Add(Active_bit);


SqlParameter pk_CountryID_int =new SqlParameter();
pk_CountryID_int.ParameterName = "@pk_CountryID_int";
pk_CountryID_int.SqlDbType = SqlDbType.Int;
pk_CountryID_int.Direction = ParameterDirection.Input;
pk_CountryID_int.IsNullable = false;
pk_CountryID_int.Value = businessObjectKey.CountryID_int;
this.Command.Parameters.Add(pk_CountryID_int);



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

public List< HPS.BLL.CountryBLL.BLLCountry_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.CountryBLL.BLLCountry_T> Result  =new  List< HPS.BLL.CountryBLL.BLLCountry_T>();
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
this.Command.CommandText = "[sp_Country_T_SelectAll]";
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
this.Command.CommandText = "[sp_Country_T_SelectAll]";
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
this.Command.CommandText = "[sp_Country_T_SelectAll]";
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

public HPS.BLL.CountryBLL.BLLCountry_T SelectByPrimaryKey(HPS.BLL.CountryBLL.BLLCountry_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryID_int =new SqlParameter();
CountryID_int.ParameterName = "@CountryID_int";
CountryID_int.SqlDbType = SqlDbType.Int;
CountryID_int.Direction = ParameterDirection.Input;
CountryID_int.IsNullable = false;
CountryID_int.Value = businessObjectKey.CountryID_int;
this.Command.Parameters.Add(CountryID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.CountryBLL.BLLCountry_T businessObject=new HPS.BLL.CountryBLL.BLLCountry_T();
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

public void SelectByPrimaryKey(HPS.BLL.CountryBLL.BLLCountry_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Country_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryID_int =new SqlParameter();
CountryID_int.ParameterName = "@CountryID_int";
CountryID_int.SqlDbType = SqlDbType.Int;
CountryID_int.Direction = ParameterDirection.Input;
CountryID_int.IsNullable = false;
CountryID_int.Value = businessObjectKey.CountryID_int;
this.Command.Parameters.Add(CountryID_int);


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

public void SelectByPrimaryKey(HPS.BLL.CountryBLL.BLLCountry_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Country_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryID_int =new SqlParameter();
CountryID_int.ParameterName = "@CountryID_int";
CountryID_int.SqlDbType = SqlDbType.Int;
CountryID_int.Direction = ParameterDirection.Input;
CountryID_int.IsNullable = false;
CountryID_int.Value = businessObjectKey.CountryID_int;
this.Command.Parameters.Add(CountryID_int);


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

public void SelectByPrimaryKey(HPS.BLL.CountryBLL.BLLCountry_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Country_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryID_int =new SqlParameter();
CountryID_int.ParameterName = "@CountryID_int";
CountryID_int.SqlDbType = SqlDbType.Int;
CountryID_int.Direction = ParameterDirection.Input;
CountryID_int.IsNullable = false;
CountryID_int.Value = businessObjectKey.CountryID_int;
this.Command.Parameters.Add(CountryID_int);



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





public List< HPS.BLL.CountryBLL.BLLCountry_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[Country_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.CountryBLL.BLLCountry_T> Result = new List< HPS.BLL.CountryBLL.BLLCountry_T>();
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
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Country_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Country_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Country_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

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

public List<HPS.BLL.CountryBLL.BLLCountry_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.CountryBLL.BLLCountry_T> Result= new List<HPS.BLL.CountryBLL.BLLCountry_T>();
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
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
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
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
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
this.Command.CommandText = "[sp_Country_T_SelectCondition]";
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

public void Delete(HPS.BLL.CountryBLL.BLLCountry_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Country_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter CountryID_int =new SqlParameter();
CountryID_int.ParameterName = "@CountryID_int";
CountryID_int.SqlDbType = SqlDbType.Int;
CountryID_int.Direction = ParameterDirection.Input;
CountryID_int.IsNullable = false;
CountryID_int.Value = businessObjectKey.CountryID_int;
this.Command.Parameters.Add(CountryID_int);


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
this.Command.CommandText = "[sp_Country_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.CountryBLL.BLLCountry_T businessObject,IDataReader dataReader){
businessObject.CountryID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryID_int.ToString()));
businessObject.CountryCode_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.CountryCode_nvc.ToString()));
businessObject.Country_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Country_nvc.ToString()));
businessObject.Active_bit = dataReader.GetBoolean(dataReader.GetOrdinal(HPS.BLL.CountryBLL.BLLCountry_T.Country_TField.Active_bit.ToString()));
}

public List< HPS.BLL.CountryBLL.BLLCountry_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.CountryBLL.BLLCountry_T> list=new List< HPS.BLL.CountryBLL.BLLCountry_T>();
while (dataReader.Read()){
HPS.BLL.CountryBLL.BLLCountry_T businessObject =new HPS.BLL.CountryBLL.BLLCountry_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 