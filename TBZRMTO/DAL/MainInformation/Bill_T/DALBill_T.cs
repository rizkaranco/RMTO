using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.BillDAL
{
class DALBill_T: DataLayerBase
{

public DALBill_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.BillBLL.BLLBill_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillID_int =new SqlParameter();
BillID_int.ParameterName = "@BillID_int";
BillID_int.SqlDbType = SqlDbType.Int;
BillID_int.Direction = ParameterDirection.Output;
BillID_int.IsNullable = false;
BillID_int.Value = businessObject.BillID_int;
this.Command.Parameters.Add(BillID_int);

SqlParameter BillType_nvc =new SqlParameter();
BillType_nvc.ParameterName = "@BillType_nvc";
BillType_nvc.SqlDbType = SqlDbType.NVarChar;
BillType_nvc.Direction = ParameterDirection.Input;
BillType_nvc.IsNullable = false;
BillType_nvc.Value = businessObject.BillType_nvc;
this.Command.Parameters.Add(BillType_nvc);

SqlParameter TrafficTypeID_int =new SqlParameter();
TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
TrafficTypeID_int.SqlDbType = SqlDbType.Int;
TrafficTypeID_int.Direction = ParameterDirection.Input;
TrafficTypeID_int.IsNullable = true;
if(businessObject.TrafficTypeID_int.HasValue == false ){
TrafficTypeID_int.Value = DBNull.Value;
}else{
TrafficTypeID_int.Value = businessObject.TrafficTypeID_int;
}
this.Command.Parameters.Add(TrafficTypeID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.BillID_int = (Int32)(this.Command.Parameters["@BillID_int"].Value); 

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

public void Update(HPS.BLL.BillBLL.BLLBill_T businessObject,HPS.BLL.BillBLL.BLLBill_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillType_nvc =new SqlParameter();
BillType_nvc.ParameterName = "@BillType_nvc";
BillType_nvc.SqlDbType = SqlDbType.NVarChar;
BillType_nvc.Direction = ParameterDirection.Input;
BillType_nvc.IsNullable = false;
BillType_nvc.Value = businessObject.BillType_nvc;
this.Command.Parameters.Add(BillType_nvc);

SqlParameter TrafficTypeID_int =new SqlParameter();
TrafficTypeID_int.ParameterName = "@TrafficTypeID_int";
TrafficTypeID_int.SqlDbType = SqlDbType.Int;
TrafficTypeID_int.Direction = ParameterDirection.Input;
TrafficTypeID_int.IsNullable = false;
if(businessObject.TrafficTypeID_int.HasValue == false ){
TrafficTypeID_int.Value = DBNull.Value;
}else{
TrafficTypeID_int.Value = businessObject.TrafficTypeID_int;
}
this.Command.Parameters.Add(TrafficTypeID_int);


SqlParameter pk_BillID_int =new SqlParameter();
pk_BillID_int.ParameterName = "@pk_BillID_int";
pk_BillID_int.SqlDbType = SqlDbType.Int;
pk_BillID_int.Direction = ParameterDirection.Input;
pk_BillID_int.IsNullable = false;
pk_BillID_int.Value = businessObjectKey.BillID_int;
this.Command.Parameters.Add(pk_BillID_int);



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

public List< HPS.BLL.BillBLL.BLLBill_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.BillBLL.BLLBill_T> Result  =new  List< HPS.BLL.BillBLL.BLLBill_T>();
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
this.Command.CommandText = "[sp_Bill_T_SelectAll]";
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
this.Command.CommandText = "[sp_Bill_T_SelectAll]";
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
this.Command.CommandText = "[sp_Bill_T_SelectAll]";
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

public HPS.BLL.BillBLL.BLLBill_T SelectByPrimaryKey(HPS.BLL.BillBLL.BLLBill_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillID_int =new SqlParameter();
BillID_int.ParameterName = "@BillID_int";
BillID_int.SqlDbType = SqlDbType.Int;
BillID_int.Direction = ParameterDirection.Input;
BillID_int.IsNullable = false;
BillID_int.Value = businessObjectKey.BillID_int;
this.Command.Parameters.Add(BillID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.BillBLL.BLLBill_T businessObject=new HPS.BLL.BillBLL.BLLBill_T();
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

public void SelectByPrimaryKey(HPS.BLL.BillBLL.BLLBill_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Bill_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillID_int =new SqlParameter();
BillID_int.ParameterName = "@BillID_int";
BillID_int.SqlDbType = SqlDbType.Int;
BillID_int.Direction = ParameterDirection.Input;
BillID_int.IsNullable = false;
BillID_int.Value = businessObjectKey.BillID_int;
this.Command.Parameters.Add(BillID_int);


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

public void SelectByPrimaryKey(HPS.BLL.BillBLL.BLLBill_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Bill_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillID_int =new SqlParameter();
BillID_int.ParameterName = "@BillID_int";
BillID_int.SqlDbType = SqlDbType.Int;
BillID_int.Direction = ParameterDirection.Input;
BillID_int.IsNullable = false;
BillID_int.Value = businessObjectKey.BillID_int;
this.Command.Parameters.Add(BillID_int);


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

public void SelectByPrimaryKey(HPS.BLL.BillBLL.BLLBill_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_Bill_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillID_int =new SqlParameter();
BillID_int.ParameterName = "@BillID_int";
BillID_int.SqlDbType = SqlDbType.Int;
BillID_int.Direction = ParameterDirection.Input;
BillID_int.IsNullable = false;
BillID_int.Value = businessObjectKey.BillID_int;
this.Command.Parameters.Add(BillID_int);



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





public List< HPS.BLL.BillBLL.BLLBill_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[Bill_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.BillBLL.BLLBill_T> Result = new List< HPS.BLL.BillBLL.BLLBill_T>();
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
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Bill_T]."+ fieldName + " = N" + "'" + Convert.ToString(value)+ "'"));

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
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Bill_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[Bill_T]."+ fieldName + " = N" + "'" + Convert.ToString(value) + "'"));

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

public List<HPS.BLL.BillBLL.BLLBill_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.BillBLL.BLLBill_T> Result= new List<HPS.BLL.BillBLL.BLLBill_T>();
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
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
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
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
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
this.Command.CommandText = "[sp_Bill_T_SelectCondition]";
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

public void Delete(HPS.BLL.BillBLL.BLLBill_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_Bill_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter BillID_int =new SqlParameter();
BillID_int.ParameterName = "@BillID_int";
BillID_int.SqlDbType = SqlDbType.Int;
BillID_int.Direction = ParameterDirection.Input;
BillID_int.IsNullable = false;
BillID_int.Value = businessObjectKey.BillID_int;
this.Command.Parameters.Add(BillID_int);


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
this.Command.CommandText = "[sp_Bill_T_DeleteByField]";
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

public void PopulateBusinessObjectFromReader(  HPS.BLL.BillBLL.BLLBill_T businessObject,IDataReader dataReader){
businessObject.BillID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillID_int.ToString()));
businessObject.BillType_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.BillType_nvc.ToString()));
if (dataReader.IsDBNull(dataReader.GetOrdinal(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.TrafficTypeID_int.ToString())) == false) {
businessObject.TrafficTypeID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.BillBLL.BLLBill_T.Bill_TField.TrafficTypeID_int.ToString()));
}else{
businessObject.TrafficTypeID_int = null;
}

}

public List< HPS.BLL.BillBLL.BLLBill_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.BillBLL.BLLBill_T> list=new List< HPS.BLL.BillBLL.BLLBill_T>();
while (dataReader.Read()){
HPS.BLL.BillBLL.BLLBill_T businessObject =new HPS.BLL.BillBLL.BLLBill_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 